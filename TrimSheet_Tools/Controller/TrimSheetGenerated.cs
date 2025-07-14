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

            this._targetForm.generateTexture_Btn.Click += this.generateTexture_Btn_Click;
            this._targetForm.stripsInfo_DataGridView.CellEndEdit += this.stripsInfo_DataGridView_CellEndEdit;
            //this._targetForm.texelDensityGridCheker_CheckBox.CheckedChanged += this.texelDensityGridCheker_CheckBox_CheckedChanged;
        }


        // Methods
        /// <summary>
        /// Redraws the viewport as part of ResponsiveSystem
        /// </summary>
        public void ResponsiveSystemViewer()
        { RebuildShapesFromData(); }

        // Color randomization
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

        // Unit size convertion
        private float Convert_CentimeterToViewer(float centimeters, int texResolution, float texelDensity)
        { return (centimeters * texelDensity) / texResolution; }
        private float Convert_ViewerToCentimeter(float centimeters, int texResolution, float texelDensity)
        { return (centimeters * texResolution) / texelDensity; }

        // Label Size
        private float LerpLabelSize(float value, float inputMin, float inputMax, float outputMin, float outputMax)
        {
            value = Math.Max(inputMin, Math.Min(inputMax, value));
            float percent = (value - inputMin) / (inputMax - inputMin);

            return outputMin + percent * (outputMax - outputMin);
        }

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

        private void UpdateFixedDimensionValues(int resolution, float texelDensity)
        {
            float fixedValueCm = Convert_ViewerToCentimeter(1f, resolution, texelDensity);
            string columnName = _genVerticalMode ? "ShapeSizeY" : "ShapeSizeX";

            for (int i = 0; i < _stripDataList.Count; i++)
            {
                _targetForm.stripsInfo_DataGridView.Rows[i].Cells[columnName].Value =
                    fixedValueCm.ToString("0.##", CultureInfo.InvariantCulture);
            }
        }

        private void RebuildShapesFromData()
        {
            // Obtém parâmetros
            float scaleFactor = _targetDockingPanelSystem.isDocked ? 615f / (float)_genResolution : 480f / (float)_genResolution;
            float currentOffset = 0f;

            // Limpa o viewport
            _targetForm.uvTrimView_Panel.Controls.Clear();

            // Adiciona as shapes
            for (int i = 0; i < _stripDataList.Count; i++)
            {
                var stripData = _stripDataList[i];
                var shape = stripData.StripShape;

                // Calcula dimensões
                int width = (int)(stripData.StripSize.X * (_genVerticalMode ? _genResolution * scaleFactor : _targetForm.uvTrimView_Panel.Width));
                int height = (int)(stripData.StripSize.Y * (_genVerticalMode ? _targetForm.uvTrimView_Panel.Height : _genResolution * scaleFactor));
                int left = _genVerticalMode ? (int)(currentOffset * _targetForm.uvTrimView_Panel.Width) : 0;
                int top = _genVerticalMode ? 0 : (int)(currentOffset * _targetForm.uvTrimView_Panel.Height);

                shape.Width = width;
                shape.Height = height;
                shape.Left = left;
                shape.Top = top;

                _targetForm.uvTrimView_Panel.Controls.Add(shape);

                // Cria o label
                VerticalLabel nameLabel = new VerticalLabel
                {
                    Name = $"labelShapeName{i}",
                    Text = stripData.StripName,
                    ForeColor = Color.Black,
                    BackColor = stripData.StripColor,
                    BackgroundImage = _targetForm.texelDensityGridCheker_CheckBox.Checked ? stripData.StripShape.BackgroundImage : null,
                    BackgroundImageLayout = ImageLayout.Tile,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    Width = width,
                    Height = height,
                    Top = top,
                    Left = left,
                    DrawVertically = _genVerticalMode
                };

                _targetForm.uvTrimView_Panel.Controls.Add(nameLabel);
                nameLabel.BringToFront();

                // Atualiza o offset
                currentOffset += _genVerticalMode ? stripData.StripSize.X : stripData.StripSize.Y;
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
            //Graphics g = Graphics.FromImage(finalImage);
            //try
            //{
            //    g.SmoothingMode = SmoothingMode.AntiAlias;
            //    g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            //    g.Clear(Color.White);

            //    float currentOffset = 0f;

            //    for (int i = 0; i < _stripDataList.Count; i++)
            //    {
            //        var stripData = _stripDataList[i];
            //        float shapeSize = stripData.StripSize * resolution;

            //        // Shape Size
            //        int width = _genVerticalMode ? (int)(shapeSize * scaleFactor) : resolution;
            //        int height = _genVerticalMode ? resolution : (int)(shapeSize * scaleFactor);
            //        int x = _genVerticalMode ? (int)(currentOffset * resolution) : 0;
            //        int y = _genVerticalMode ? 0 : (int)(currentOffset * resolution);

            //        // Draw shape color
            //        using (Brush baseBrush = new SolidBrush(stripData.StripColor))
            //        {
            //            g.FillRectangle(baseBrush, x, y, width, height);
            //        }

            //        // Apply Checker map
            //        if (stripData.StripShape.BackgroundImage != null)
            //        {
            //            using (TextureBrush texture = new TextureBrush(stripData.StripShape.BackgroundImage, WrapMode.Tile))
            //            {
            //                texture.TranslateTransform(x, y);
            //                g.FillRectangle(texture, x, y, width, height);
            //            }
            //        }

            //        // Add the Labels
            //        float baseSize = _genVerticalMode ? width : height;
            //        float dynamicFontSize = LerpLabelSize(baseSize, 10f, resolution, 8f, 70f);

            //        VerticalLabel nameLabel = new VerticalLabel
            //        {
            //            Text = stripData.StripName,
            //            ForeColor = Color.Black,
            //            BackColor = stripData.StripColor,
            //            BackgroundImage = stripData.StripShape.BackgroundImage,
            //            BackgroundImageLayout = ImageLayout.Tile,
            //            AutoSize = false,
            //            TextAlign = ContentAlignment.MiddleCenter,
            //            Font = new Font("Segoe UI", dynamicFontSize, FontStyle.Bold),
            //            Width = width,
            //            Height = height,
            //            Top = y,
            //            Left = x,
            //            DrawVertically = _genVerticalMode
            //        };

            //        using (Bitmap labelBitmap = new Bitmap(width, height))
            //        {
            //            nameLabel.DrawToBitmap(labelBitmap, new Rectangle(0, 0, width, height));
            //            g.DrawImage(labelBitmap, x, y);
            //        }

            //        currentOffset += stripData.StripSize;
            //    }
            //}
            //finally
            //{
            //    g.Dispose();
            //}

            // Return the final image
            return finalImage;
        }


        // Event Methods
        private void generateTexture_Btn_Click(object sender, EventArgs e)
        {
            // Limpa informações antigas
            _targetForm.stripsInfo_DataGridView.Rows.Clear();
            _stripDataList.Clear();
            _targetForm.uvTrimView_Panel.Controls.Clear();
            _usedHueBuckets.Clear();

            // Obtém parâmetros
            if (!int.TryParse(_targetForm.stripQuantity_TextBox.Text, out int stripCount) || stripCount <= 0)
                return;

            if (!int.TryParse(_targetForm.selectedResolution.SelectedItem?.ToString().Split('x')[0], out _genResolution))
                return;

            // Configuração da textura checker
            _genTexelDensity = CheckerTexelDensity(_targetForm.TexelDensityGroupGenerated);
            float texelDensity = float.Parse(_genTexelDensity, CultureInfo.InvariantCulture);
            float totalSizeCm = _genResolution / texelDensity;
            float minSizeCm = 1f; // Tamanho mínimo de 1cm

            // Calcula o tamanho igualitário garantindo o mínimo
            float equalSizeCm = Math.Max(minSizeCm, totalSizeCm / stripCount);

            // Se a soma ultrapassar, ajusta proporcionalmente
            if (equalSizeCm * stripCount > totalSizeCm)
            {
                equalSizeCm = totalSizeCm / stripCount;
            }

            // Converte para fração (0-1)
            float equalSizeFraction = Convert_CentimeterToViewer(equalSizeCm, _genResolution, texelDensity);

            // Modo de geração
            _genVerticalMode = _targetForm.verticalMode_CheckBox.Checked;
            Image checkerTexture = null;
            switch (_genTexelDensity)
            {
                case "5.12": checkerTexture = Resources.Checker_5_12; break;
                case "10.24": checkerTexture = Resources.Checker_10_24; break;
                case "20.48": checkerTexture = Resources.Checker_20_48; break;
            }

            for (int i = 0; i < stripCount; i++)
            {
                // Cria a shape
                Color pastelColor = GeneratedColor(_random);
                BunifuShapes shape = new BunifuShapes
                {
                    BackColor = pastelColor,
                    BackgroundImage = checkerTexture,
                    BackgroundImageLayout = ImageLayout.Tile,
                    Shape = BunifuShapes.Shapes.Rectangle,
                    BorderThickness = 0,
                };

                // Configura os dados da strip
                var stripData = new StripData
                {
                    StripShape = shape,
                    StripColor = pastelColor,
                    StripName = $"Strip {i + 1}",
                    StripSize = _genVerticalMode ?
                        new Vector2D(equalSizeFraction, 1f) :
                        new Vector2D(1f, equalSizeFraction)
                };

                _stripDataList.Add(stripData);

                // Converte para centímetros para exibição
                float sizeXCm = _genVerticalMode ?
                    equalSizeCm :
                    totalSizeCm;
                float sizeYCm = _genVerticalMode ?
                    totalSizeCm :
                    equalSizeCm;

                // Adiciona à DataGridView
                _targetForm.stripsInfo_DataGridView.Rows.Add(
                    stripData.GetBitmap(),
                    stripData.StripName,
                    sizeXCm.ToString("0.##", CultureInfo.InvariantCulture),
                    sizeYCm.ToString("0.##", CultureInfo.InvariantCulture),
                    null,
                    _genTexelDensity
                );
            }

            // Atualiza informações
            float coverageSpace = (_genResolution / texelDensity);
            _targetForm.resolutionInfo.Text = _targetForm.selectedResolution.SelectedItem?.ToString() + " px";
            _targetForm.coverageSpaceInfo.Text = coverageSpace.ToString() + " cm²";
            _targetForm.baseDensityInfo.Text = _genTexelDensity + " px/cm";

            RebuildShapesFromData();
        }

        private void stripsInfo_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                if (!int.TryParse(_targetForm.selectedResolution.SelectedItem?.ToString().Split('x')[0], out int resolution))
                    return;

                string selectedDensity = CheckerTexelDensity(_targetForm.TexelDensityGroupGenerated);
                if (!float.TryParse(selectedDensity, NumberStyles.Float, CultureInfo.InvariantCulture, out float texelDensity))
                    return;

                int index = e.RowIndex;
                StripData currentStrip = _stripDataList[index];
                float minSizeCm = 1f; // Tamanho mínimo de 1cm
                float minSizeFraction = Convert_CentimeterToViewer(minSizeCm, resolution, texelDensity);
                float totalSizeCm = resolution / texelDensity;

                bool isEditingPrimaryDimension =
                    (_genVerticalMode && e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeSizeX"].Index) ||
                    (!_genVerticalMode && e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeSizeY"].Index);

                if (isEditingPrimaryDimension)
                {
                    // Obtém o novo valor em cm
                    float newCmValue;
                    if (!float.TryParse(
                        _targetForm.stripsInfo_DataGridView.Rows[index].Cells[
                            _genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value.ToString(),
                        out newCmValue))
                    {
                        // Valor inválido, reverte para o valor anterior
                        _targetForm.stripsInfo_DataGridView.Rows[index].Cells[
                            _genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value =
                            Convert_ViewerToCentimeter(
                                _genVerticalMode ? currentStrip.StripSize.X : currentStrip.StripSize.Y,
                                resolution, texelDensity)
                            .ToString("0.##");
                        return;
                    }

                    // Garante o mínimo de 1cm
                    newCmValue = Math.Max(minSizeCm, newCmValue);
                    float newSize = Convert_CentimeterToViewer(newCmValue, resolution, texelDensity);

                    // Calcula o tamanho total já usado pelas shapes anteriores
                    float usedSize = 0f;
                    for (int i = 0; i < index; i++)
                    {
                        usedSize += _genVerticalMode ? _stripDataList[i].StripSize.X : _stripDataList[i].StripSize.Y;
                    }

                    // Calcula o espaço restante para as shapes seguintes
                    float remainingSize = 1f - usedSize - newSize;
                    int remainingShapes = _stripDataList.Count - index - 1;

                    // Verifica se é possível distribuir o espaço restante mantendo o mínimo
                    if (remainingShapes > 0 && remainingSize < minSizeFraction * remainingShapes)
                    {
                        // Calcula o valor máximo permitido para esta shape
                        float maxAllowedCm = Convert_ViewerToCentimeter(
                            1f - usedSize - (minSizeFraction * remainingShapes),
                            resolution, texelDensity);

                        // Limita ao valor máximo permitido
                        newCmValue = Math.Min(newCmValue, maxAllowedCm);
                        newSize = Convert_CentimeterToViewer(newCmValue, resolution, texelDensity);

                        // Atualiza o valor na grid
                        _targetForm.stripsInfo_DataGridView.Rows[index].Cells[
                            _genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value =
                            newCmValue.ToString("0.##", CultureInfo.InvariantCulture);

                        MessageBox.Show($"O valor máximo permitido para esta shape é {maxAllowedCm.ToString("0.##")} cm",
                            "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Se chegou aqui, o valor é válido - prossegue com as alterações
                    float currentSize = _genVerticalMode ? currentStrip.StripSize.X : currentStrip.StripSize.Y;
                    float delta = newSize - currentSize;

                    // Se for a última shape, trata de forma especial (ajusta apenas a penúltima)
                    if (index == _stripDataList.Count - 1)
                    {
                        if (index > 0) // Tem uma shape anterior para ajustar
                        {
                            StripData prevStrip = _stripDataList[index - 1];
                            float prevSize = _genVerticalMode ? prevStrip.StripSize.X : prevStrip.StripSize.Y;
                            float newPrevSize = prevSize - delta;

                            // Verifica se a penúltima shape ficaria com menos do que o mínimo
                            if (newPrevSize < minSizeFraction)
                            {
                                // Calcula o valor máximo permitido para a última shape
                                float maxAllowedCm = Convert_ViewerToCentimeter(
                                    currentSize + (prevSize - minSizeFraction),
                                    resolution, texelDensity);

                                // Limita ao valor máximo permitido
                                newCmValue = Math.Min(newCmValue, maxAllowedCm);
                                newSize = Convert_CentimeterToViewer(newCmValue, resolution, texelDensity);

                                // Atualiza o valor na grid
                                _targetForm.stripsInfo_DataGridView.Rows[index].Cells[
                                    _genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value =
                                    newCmValue.ToString("0.##", CultureInfo.InvariantCulture);

                                MessageBox.Show($"O valor máximo permitido para esta shape é {maxAllowedCm.ToString("0.##")} cm",
                                    "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Aplica os ajustes
                            if (_genVerticalMode)
                            {
                                prevStrip.StripSize = new Vector2D(newPrevSize, 1f);
                                currentStrip.StripSize = new Vector2D(newSize, 1f);
                            }
                            else
                            {
                                prevStrip.StripSize = new Vector2D(1f, newPrevSize);
                                currentStrip.StripSize = new Vector2D(1f, newSize);
                            }

                            // Atualiza a grid para a penúltima shape
                            _targetForm.stripsInfo_DataGridView.Rows[index - 1].Cells[
                                _genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value =
                                Convert_ViewerToCentimeter(newPrevSize, resolution, texelDensity)
                                .ToString("0.##", CultureInfo.InvariantCulture);
                        }
                    }
                    else
                    {
                        // Para shapes que não são a última, redistribui entre todas as seguintes
                        float remainingSizeAfterChange = 1f - usedSize - newSize;
                        int remainingShapesAfterChange = _stripDataList.Count - index - 1;

                        if (remainingShapesAfterChange > 0)
                        {
                            float equalSize = remainingSizeAfterChange / remainingShapesAfterChange;

                            // Aplica o novo tamanho à shape atual
                            if (_genVerticalMode)
                                currentStrip.StripSize = new Vector2D(newSize, 1f);
                            else
                                currentStrip.StripSize = new Vector2D(1f, newSize);

                            // Redistribui para as shapes seguintes
                            for (int i = index + 1; i < _stripDataList.Count; i++)
                            {
                                if (_genVerticalMode)
                                    _stripDataList[i].StripSize = new Vector2D(equalSize, 1f);
                                else
                                    _stripDataList[i].StripSize = new Vector2D(1f, equalSize);

                                // Atualiza a grid
                                _targetForm.stripsInfo_DataGridView.Rows[i].Cells[
                                    _genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value =
                                    Convert_ViewerToCentimeter(equalSize, resolution, texelDensity)
                                    .ToString("0.##", CultureInfo.InvariantCulture);
                            }
                        }
                    }

                    // Atualiza o valor na grid (pode ter sido ajustado)
                    _targetForm.stripsInfo_DataGridView.Rows[index].Cells[
                        _genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value =
                        newCmValue.ToString("0.##", CultureInfo.InvariantCulture);

                    // Atualiza a dimensão fixa
                    UpdateFixedDimensionValues(resolution, texelDensity);

                    // Reconstroi a visualização
                    RebuildShapesFromData();
                }
                else if (e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeName"].Index)
                {
                    string newName = _targetForm.stripsInfo_DataGridView.Rows[index].Cells["ShapeName"].Value.ToString();
                    currentStrip.StripName = newName;

                    var label = _targetForm.uvTrimView_Panel.Controls.Find($"labelShapeName{index}", false).FirstOrDefault() as Label;
                    if (label != null)
                        label.Text = newName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing shape: " + ex.Message);
            }
        }

        private void UpdateAllDataGridViewValues(int resolution, float texelDensity)
        {
            for (int i = 0; i < _stripDataList.Count; i++)
            {
                var strip = _stripDataList[i];
                float sizeXCm = Convert_ViewerToCentimeter(strip.StripSize.X, resolution, texelDensity);
                float sizeYCm = Convert_ViewerToCentimeter(strip.StripSize.Y, resolution, texelDensity);

                _targetForm.stripsInfo_DataGridView.Rows[i].Cells["ShapeSizeX"].Value =
                    sizeXCm.ToString("0.##", CultureInfo.InvariantCulture);
                _targetForm.stripsInfo_DataGridView.Rows[i].Cells["ShapeSizeY"].Value =
                    sizeYCm.ToString("0.##", CultureInfo.InvariantCulture);
            }
        }
    }
}
