// Class contains trim sheet shape generation system
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using TrimSheet_Tools.Properties;
using TrimSheet_Tools.Model;
using TrimSheet_Tools.View;

namespace TrimSheet_Tools.Controller
{
    internal class TrimSheetGenerated
    {
        private TrimSettings _targetForm;
        private DockPanelModel _targetDockingPanelSystem;
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
        { RebuildShapesFromData(true); }

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

        private void RebuildShapesFromData(bool viewTarget)
        {
            // Get parameters
            if (!int.TryParse(_targetForm.selectedResolution.SelectedItem?.ToString().Split('x')[0], out int resolution))
                return;

            // Check image target to Viewer or Export
            float scaleFactor;
            if (viewTarget)
                scaleFactor = _targetDockingPanelSystem.isDocked ? 615f / (float)resolution : 480f / (float)resolution;
            else
                scaleFactor = (float)resolution;

            float currentOffset = 0f;
            bool verticalMode = _targetForm.verticalMode_CheckBox.Checked;

            // Clear the viewport
            _targetForm.uvTrimView_Panel.Controls.Clear();

            // Add new informations
            for (int i = 0; i < _stripDataList.Count; i++)
            {

                var stripData = _stripDataList[i];
                var shape = stripData.StripShape;
                float shapeSize = stripData.StripSize * resolution;

                // Get Strip orientation
                int width = verticalMode  ? (int)(shapeSize * scaleFactor) : _targetForm.uvTrimView_Panel.Width;
                int height = verticalMode ? _targetForm.uvTrimView_Panel.Height : (int)(shapeSize * scaleFactor);
                int left = verticalMode   ? (int)(currentOffset * _targetForm.uvTrimView_Panel.Width) : 0;
                int top = verticalMode    ? 0 : (int)(currentOffset * _targetForm.uvTrimView_Panel.Height);

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
                    DrawVertically = verticalMode // chave do controle
                };

                _targetForm.uvTrimView_Panel.Controls.Add(nameLabel);
                nameLabel.BringToFront();

                currentOffset += stripData.StripSize;

                // Update DataGridView
                _targetForm.stripsInfo_DataGridView.Rows[i].Cells["ShapeSize"].Value = stripData.StripSize.ToString("0.###", CultureInfo.InvariantCulture);
                _targetForm.stripsInfo_DataGridView.Rows[i].Cells["ShapeName"].Value = stripData.StripName;
            }

            _targetForm.uvTrimView_Panel.Invalidate();
            _targetForm.uvTrimView_Panel.Refresh();
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

            if (!int.TryParse(_targetForm.selectedResolution.SelectedItem?.ToString().Split('x')[0], out int resolution))
                return;

            // Texel Density Checker map verification
            bool useCheckerTexture = _targetForm.texelDensityGridCheker_CheckBox.Checked;
            String texDensitySelected = CheckerTexelDensity(_targetForm.TexelDensityGroupGenerated);
            Image checkerTexture = null;

            if(useCheckerTexture)
            {
                switch(texDensitySelected)
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
            bool verticalMode = _targetForm.verticalMode_CheckBox.Checked;
            float equalSize = 1f / stripCount;
            float scaleFactor = _targetDockingPanelSystem.isDocked ? 615f / (float)resolution : 480f / (float)resolution;
            float currentOffset = 0f;

            for (int i = 0; i < stripCount; i++)
            {
                // Get Strip orientation
                int width =  verticalMode ? (int)(equalSize * resolution * scaleFactor) : _targetForm.uvTrimView_Panel.Width;
                int height = verticalMode ? _targetForm.uvTrimView_Panel.Height : (int)(equalSize * resolution * scaleFactor);
                int left = verticalMode   ? (int)(currentOffset * _targetForm.uvTrimView_Panel.Width) : 0;
                int top = verticalMode    ? 0 : (int)(currentOffset * _targetForm.uvTrimView_Panel.Height);

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
                _targetForm.stripsInfo_DataGridView.Rows.Add(stripData.GetBitmap(), stripData.StripName, equalSize.ToString("0.###", CultureInfo.InvariantCulture), texDensitySelected);
                currentOffset += equalSize;
            }

            RebuildShapesFromData(true);
        }

        private void stripsInfo_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeSize"].Index)
            {
                try
                {
                    float newValue = float.Parse(
                        _targetForm.stripsInfo_DataGridView.Rows[e.RowIndex].Cells["ShapeSize"].Value.ToString(),
                        CultureInfo.InvariantCulture
                    );

                    newValue = Math.Max(0.01f, Math.Min(0.99f, newValue));
                    int index = e.RowIndex;
                    StripData stripCurrent = _stripDataList[index];

                    if (index < _stripDataList.Count - 1)
                    {
                        StripData stripNext = _stripDataList[index + 1];
                        float delta = newValue - stripCurrent.StripSize;
                        float adjustedNext = stripNext.StripSize - delta;

                        if (adjustedNext < 0.01f)
                        {
                            adjustedNext = 0.01f;
                            newValue = stripCurrent.StripSize + (stripNext.StripSize - 0.01f);
                        }

                        stripCurrent.StripSize = newValue;
                        stripNext.StripSize = adjustedNext;

                        _targetForm.stripsInfo_DataGridView.Rows[index].Cells["ShapeSize"].Value =
                            newValue.ToString("0.###", CultureInfo.InvariantCulture);

                        _targetForm.stripsInfo_DataGridView.Rows[index + 1].Cells["ShapeSize"].Value =
                            adjustedNext.ToString("0.###", CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        StripData stripPrev = _stripDataList[index - 1];
                        float delta = newValue - stripCurrent.StripSize;
                        float adjustedPrev = stripPrev.StripSize - delta;

                        if (adjustedPrev < 0.01f)
                        {
                            adjustedPrev = 0.01f;
                            newValue = stripCurrent.StripSize + (stripPrev.StripSize - 0.01f);
                        }

                        stripCurrent.StripSize = newValue;
                        stripPrev.StripSize = adjustedPrev;

                        _targetForm.stripsInfo_DataGridView.Rows[index].Cells["ShapeSize"].Value =
                            newValue.ToString("0.###", CultureInfo.InvariantCulture);

                        _targetForm.stripsInfo_DataGridView.Rows[index - 1].Cells["ShapeSize"].Value =
                            adjustedPrev.ToString("0.###", CultureInfo.InvariantCulture);
                    }

                    RebuildShapesFromData(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error editing shape: " + ex.Message);
                }
            }
            else if (e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeName"].Index)
            {
                string newName = _targetForm.stripsInfo_DataGridView.Rows[e.RowIndex].Cells["ShapeName"].Value.ToString();
                _stripDataList[e.RowIndex].StripName = newName;

                // Update Label Text
                var label = _targetForm.uvTrimView_Panel.Controls.Find($"labelShapeName{e.RowIndex}", false).FirstOrDefault() as Label;
                if (label != null)
                    label.Text = newName;
            }
        }

    }
}
