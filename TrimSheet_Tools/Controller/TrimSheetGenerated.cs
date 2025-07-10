// Class contains trim sheet shape generation system
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TrimSheet_Tools.Model;
using TrimSheet_Tools.Properties;
using TrimSheet_Tools.View;

namespace TrimSheet_Tools.Controller
{
    internal class TrimSheetGenerated
    {
        private TrimSettings _targetForm;
        private DockPanelModel _targetDockingPanelSystem;
        private int _genResolution;
        private bool _genVerticalMode;
        private String _genTexelDensity;
        private Random _random = new Random();
        private List<StripData> _stripDataList = new List<StripData>();
        private HashSet<int> _usedHueBuckets = new HashSet<int>();


        /// <summary>
        /// Trim Sheet Generated System
        /// </summary>
        /// <param name="trimSettingsRef">TrimSettings form reference</param>
        /// <param name="dockingPanelRef"></param>
        public TrimSheetGenerated(TrimSettings trimSettingsRef, DockPanelModel dockingPanelRef)
        {
            this._targetForm = trimSettingsRef;
            this._targetDockingPanelSystem = dockingPanelRef;

            this._targetForm.stripsInfo_DataGridView.CellEndEdit += this.stripsInfo_DataGridView_CellEndEdit;
            this._targetForm.generateTexture_Btn.Click += this.generateTexture_Btn_Click;
        }


        // Methods
        /// <summary>
        /// Redraws the viewport as part of ResponsiveSystem
        /// </summary>
        public void ResponsiveSystemViewer()
        { RebuildShapesFromData(); }

        private Color GeneratedColor(Random range)
        {
            int hueBucket;
            int maxAttempts = 50;
            int attempt = 0;

            // Divide o espectro em "buckets" de 15 graus e evita repetir
            do
            {
                hueBucket = range.Next(0, 360 / 15); // 24 buckets
                attempt++;
            }
            while (_usedHueBuckets.Contains(hueBucket) && attempt < maxAttempts);

            _usedHueBuckets.Add(hueBucket);
            double hue = hueBucket * 15;

            // Suavemente aleatoriza saturação e brilho para mais variedade
            double saturation = 0.3 + range.NextDouble() * 0.2;
            double brightness = 0.85 + range.NextDouble() * 0.1;

            return FromHSV(hue, saturation, brightness);
        }
        private Color FromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value *= 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            switch (hi)
            {
                case 0: return Color.FromArgb(v, t, p);
                case 1: return Color.FromArgb(q, v, p);
                case 2: return Color.FromArgb(p, v, t);
                case 3: return Color.FromArgb(p, q, v);
                case 4: return Color.FromArgb(t, p, v);
                default: return Color.FromArgb(v, p, q);
            }
        }

        private float Convert_CentimeterToViewer(float centimeters, int texResolution, float texelDensity)
        { return (centimeters * texelDensity) / texResolution; }
        private float Convert_ViewerToCentimeter(float centimeters, int texResolution, float texelDensity)
        { return (centimeters * texResolution) / texelDensity; }

        private String CheckerTexelDensity(Panel panelRef)
        {
            // Check the selected Radio Button in the Panel
            String radioButtonSelected = null;

            foreach (Control ctrl in panelRef.Controls)
            {
                if (ctrl is BunifuRadioButton btn && btn.Checked)
                {
                    radioButtonSelected = btn.Tag?.ToString();
                    break;
                }
            }

            // Return the selected button value
            return radioButtonSelected;
        }

        private void RebuildShapesFromData()
        {
            // Get parameters
            float scaleFactor = _targetDockingPanelSystem.isDocked ? 615f / (float)_genResolution : 480f / (float)_genResolution;
            float currentOffset = 0f;

            // Clear the viewport
            _targetForm.uvTrimView_Panel.Controls.Clear();

            // Add new informations
            for (int i = 0; i < _stripDataList.Count; i++)
            {

                var stripData = _stripDataList[i];
                var shape = stripData.StripShape;
                float shapeSize = stripData.StripSize * _genResolution;

                // Get Strip orientation
                int width = _genVerticalMode  ? (int)(shapeSize * scaleFactor) : _targetForm.uvTrimView_Panel.Width;
                int height = _genVerticalMode ? _targetForm.uvTrimView_Panel.Height : (int)(shapeSize * scaleFactor);
                int left = _genVerticalMode   ? (int)(currentOffset * _targetForm.uvTrimView_Panel.Width) : 0;
                int top = _genVerticalMode    ? 0 : (int)(currentOffset * _targetForm.uvTrimView_Panel.Height);

                shape.Width = width;
                shape.Height = height;
                shape.Left = left;
                shape.Top = top;

                _targetForm.uvTrimView_Panel.Controls.Add(shape);

                // Create a StripName Label
                VerticalLabel nameLabel = new VerticalLabel
                {
                    Name = $"labelShapeName{i}",
                    Text = stripData.StripName,
                    ForeColor = Color.Black,
                    BackColor = stripData.StripColor,
                    BackgroundImage = stripData.StripShape.BackgroundImage,
                    BackgroundImageLayout = ImageLayout.Tile,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Width = width,
                    Height = height,
                    Top = top,
                    Left = left,
                    DrawVertically = _genVerticalMode // chave do controle
                };

                _targetForm.uvTrimView_Panel.Controls.Add(nameLabel);
                nameLabel.BringToFront();

                currentOffset += stripData.StripSize;

                // Convert to centimeters size
                float texelDensity = float.Parse(CheckerTexelDensity(_targetForm.TexelDensityGroupGenerated), CultureInfo.InvariantCulture);
                float sizeCm = Convert_ViewerToCentimeter(stripData.StripSize, _genResolution, texelDensity);

                // Update DataGridView
                _targetForm.stripsInfo_DataGridView.Rows[i].Cells["ShapeSize"].Value = sizeCm.ToString("0.##", CultureInfo.InvariantCulture);
                _targetForm.stripsInfo_DataGridView.Rows[i].Cells["ShapeName"].Value = stripData.StripName;
            }

            _targetForm.uvTrimView_Panel.Invalidate();
            _targetForm.uvTrimView_Panel.Refresh();
        }

        /// <summary>
        /// Generates the final image based on the selected resolution
        /// </summary>
        /// <returns></returns>
        public Image ImageToExport()
        {
            // Get parameters
            int resolution = _genResolution;
            float scaleFactor = 1f;

            // Create the image
            Bitmap finalImage = new Bitmap(resolution, resolution);
            Graphics g = Graphics.FromImage(finalImage);
            try
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                g.Clear(Color.White);

                float currentOffset = 0f;

                for (int i = 0; i < _stripDataList.Count; i++)
                {
                    var stripData = _stripDataList[i];
                    float shapeSize = stripData.StripSize * resolution;

                    // Shape Size
                    int width = _genVerticalMode ? (int)(shapeSize * scaleFactor) : resolution;
                    int height = _genVerticalMode ? resolution : (int)(shapeSize * scaleFactor);
                    int x = _genVerticalMode ? (int)(currentOffset * resolution) : 0;
                    int y = _genVerticalMode ? 0 : (int)(currentOffset * resolution);

                    // Draw shape color
                    using (Brush baseBrush = new SolidBrush(stripData.StripColor))
                    {
                        g.FillRectangle(baseBrush, x, y, width, height);
                    }

                    // Apply Checker map
                    if (stripData.StripShape.BackgroundImage != null)
                    {
                        using (TextureBrush texture = new TextureBrush(stripData.StripShape.BackgroundImage, WrapMode.Tile))
                        {
                            texture.TranslateTransform(x, y);
                            g.FillRectangle(texture, x, y, width, height);
                        }
                    }

                    // Add the Labels
                    VerticalLabel nameLabel = new VerticalLabel
                    {
                        Text = stripData.StripName,
                        ForeColor = Color.Black,
                        BackColor = stripData.StripColor,
                        BackgroundImage = stripData.StripShape.BackgroundImage,
                        BackgroundImageLayout = ImageLayout.Tile,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Width = width,
                        Height = height,
                        Top = y,
                        Left = x,
                        DrawVertically = _genVerticalMode
                    };

                    using (Bitmap labelBitmap = new Bitmap(width, height))
                    {
                        nameLabel.DrawToBitmap(labelBitmap, new Rectangle(0, 0, width, height));
                        g.DrawImage(labelBitmap, x, y);
                    }

                    currentOffset += stripData.StripSize;
                }
            }
            finally
            {
                g.Dispose();
            }

            // Return the final image
            return finalImage;
        }


        // Event Methods
        private void generateTexture_Btn_Click(object sender, EventArgs e)
        {
            // Clear old informations
            _targetForm.stripsInfo_DataGridView.Rows.Clear();
            _stripDataList.Clear();
            _targetForm.uvTrimView_Panel.Controls.Clear();
            _usedHueBuckets.Clear();

            // Get parameters
            if (!int.TryParse(_targetForm.stripQuantity_TextBox.Text, out int stripCount) || stripCount <= 0)
                return;

            if (!int.TryParse(_targetForm.selectedResolution.SelectedItem?.ToString().Split('x')[0], out _genResolution))
                return;

            // Texel Density Checker map verification
            bool useCheckerTexture = _targetForm.texelDensityGridCheker_CheckBox.Checked;
            _genTexelDensity = CheckerTexelDensity(_targetForm.TexelDensityGroupGenerated);
            Image checkerTexture = null;

            if(useCheckerTexture)
            {
                switch(_genTexelDensity)
                {
                    case "5.12":
                        checkerTexture = Resources.Checker_5_12;
                        break;
                    case "10.24":
                        checkerTexture = Resources.Checker_10_24;
                        break;
                    case "20.48":
                        checkerTexture = Resources.Checker_20_48;
                        break;
                }
            };

            // Generated Shape
            _genVerticalMode = _targetForm.verticalMode_CheckBox.Checked;
            float equalSize = 1f / stripCount;
            float scaleFactor = _targetDockingPanelSystem.isDocked ? 615f / (float)_genResolution : 480f / (float)_genResolution;
            float currentOffset = 0f;

            for (int i = 0; i < stripCount; i++)
            {
                // Get Strip orientation
                int width =  _genVerticalMode ? (int)(equalSize * _genResolution * scaleFactor) : _targetForm.uvTrimView_Panel.Width;
                int height = _genVerticalMode ? _targetForm.uvTrimView_Panel.Height : (int)(equalSize * _genResolution * scaleFactor);
                int left = _genVerticalMode   ? (int)(currentOffset * _targetForm.uvTrimView_Panel.Width) : 0;
                int top = _genVerticalMode    ? 0 : (int)(currentOffset * _targetForm.uvTrimView_Panel.Height);

                // Create a shape
                Color pastelColor = GeneratedColor(_random);

                BunifuShapes shape = new BunifuShapes
                {
                    BackColor = pastelColor,
                    BackgroundImage = checkerTexture,
                    BackgroundImageLayout = ImageLayout.Tile,
                    Shape = BunifuShapes.Shapes.Rectangle,
                    Width = width,
                    Height = height,
                    Top = top,
                    Left = left,
                    BorderThickness = 0,
                };

                _targetForm.uvTrimView_Panel.Controls.Add(shape);
                shape.SendToBack();

                // Set strip data
                var stripData = new StripData
                {
                    StripShape = shape,
                    StripColor = pastelColor,
                    StripName = $"Shape {i + 1}",
                    StripSize = equalSize
                };

                // Add the shape to DataList
                _stripDataList.Add(stripData);

                // Convert to centimeters size
                float shapeSizeCm = Convert_ViewerToCentimeter(equalSize, _genResolution, float.Parse(_genTexelDensity, CultureInfo.InvariantCulture));

                _targetForm.stripsInfo_DataGridView.Rows.Add(stripData.GetBitmap(), stripData.StripName, shapeSizeCm.ToString("0.##", CultureInfo.InvariantCulture), _genTexelDensity);
                currentOffset += equalSize;
            }

            RebuildShapesFromData();
        }

        private void stripsInfo_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora se não for uma linha válida
            if (e.RowIndex < 0)
                return;

            // Verifica se a célula editada foi da coluna ShapeSize
            if (e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeSize"].Index)
            {
                try
                {
                    // Obtém a resolução selecionada (ex: "1024x1024") e extrai o valor numérico
                    if (!int.TryParse(_targetForm.selectedResolution.SelectedItem?.ToString().Split('x')[0], out int resolution))
                        return;

                    // Obtém a densidade de texel selecionada (ex: "5.12") e converte para float
                    string selectedDensity = CheckerTexelDensity(_targetForm.TexelDensityGroupGenerated);
                    if (!float.TryParse(selectedDensity, NumberStyles.Float, CultureInfo.InvariantCulture, out float texelDensity))
                        return;

                    // Lê o valor digitado na célula em centímetros
                    float cmValue = float.Parse(
                        _targetForm.stripsInfo_DataGridView.Rows[e.RowIndex].Cells["ShapeSize"].Value.ToString(),
                        CultureInfo.InvariantCulture
                    );

                    // Converte de centímetros para a fração da textura com base na resolução e texel density
                    float newValue = Convert_CentimeterToViewer(cmValue, resolution, texelDensity);

                    // Garante que o valor fique entre 0.01 e 0.99 (evita faixas muito pequenas ou grandes)
                    newValue = Math.Max(0.01f, Math.Min(0.99f, newValue));

                    int index = e.RowIndex;
                    StripData stripCurrent = _stripDataList[index];

                    // Caso não seja a última faixa, ajusta a próxima faixa
                    if (index < _stripDataList.Count - 1)
                    {
                        StripData stripNext = _stripDataList[index + 1];
                        float delta = newValue - stripCurrent.StripSize;
                        float adjustedNext = stripNext.StripSize - delta;

                        // Garante que a próxima faixa não fique menor que o mínimo permitido
                        if (adjustedNext < 0.01f)
                        {
                            adjustedNext = 0.01f;
                            newValue = stripCurrent.StripSize + (stripNext.StripSize - 0.01f);
                        }

                        // Aplica os novos valores às faixas
                        stripCurrent.StripSize = newValue;
                        stripNext.StripSize = adjustedNext;

                        // Converte os valores de volta para cm para exibir na grade
                        float updatedCmCurrent = Convert_ViewerToCentimeter(newValue, resolution, texelDensity);
                        float updatedCmNext = Convert_ViewerToCentimeter(adjustedNext, resolution, texelDensity);

                        // Atualiza visualmente os valores da tabela (em cm formatado)
                        _targetForm.stripsInfo_DataGridView.Rows[index].Cells["ShapeSize"].Value =
                            updatedCmCurrent.ToString("0.##", CultureInfo.InvariantCulture);
                        _targetForm.stripsInfo_DataGridView.Rows[index + 1].Cells["ShapeSize"].Value =
                            updatedCmNext.ToString("0.##", CultureInfo.InvariantCulture);
                    }
                    else // Caso seja a última faixa, ajusta a anterior
                    {
                        StripData stripPrev = _stripDataList[index - 1];
                        float delta = newValue - stripCurrent.StripSize;
                        float adjustedPrev = stripPrev.StripSize - delta;

                        // Garante que a faixa anterior não fique menor que o mínimo permitido
                        if (adjustedPrev < 0.01f)
                        {
                            adjustedPrev = 0.01f;
                            newValue = stripCurrent.StripSize + (stripPrev.StripSize - 0.01f);
                        }

                        // Aplica os novos valores às faixas
                        stripCurrent.StripSize = newValue;
                        stripPrev.StripSize = adjustedPrev;

                        // Converte os valores de volta para cm para exibir na grade
                        float updatedCmCurrent = Convert_ViewerToCentimeter(newValue, resolution, texelDensity);
                        float updatedCmPrev = Convert_ViewerToCentimeter(adjustedPrev, resolution, texelDensity);

                        // Atualiza visualmente os valores da tabela (em cm formatado)
                        _targetForm.stripsInfo_DataGridView.Rows[index].Cells["ShapeSize"].Value =
                            updatedCmCurrent.ToString("0.##", CultureInfo.InvariantCulture);
                        _targetForm.stripsInfo_DataGridView.Rows[index - 1].Cells["ShapeSize"].Value =
                            updatedCmPrev.ToString("0.##", CultureInfo.InvariantCulture);
                    }

                    // Recria visualmente os shapes com os novos tamanhos
                    RebuildShapesFromData();
                }
                catch (Exception ex)
                {
                    // Exibe erro caso algo dê errado na conversão ou atualização
                    MessageBox.Show("Error editing shape: " + ex.Message);
                }
            }
            // Caso a célula editada seja o nome da shape
            else if (e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeName"].Index)
            {
                // Atualiza o nome da faixa no backend
                string newName = _targetForm.stripsInfo_DataGridView.Rows[e.RowIndex].Cells["ShapeName"].Value.ToString();
                _stripDataList[e.RowIndex].StripName = newName;

                // Atualiza o texto do label correspondente na visualização (viewport)
                var label = _targetForm.uvTrimView_Panel.Controls.Find($"labelShapeName{e.RowIndex}", false).FirstOrDefault() as Label;
                if (label != null)
                    label.Text = newName;
            }
        }

    }
}
