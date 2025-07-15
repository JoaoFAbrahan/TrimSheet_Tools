// Class contains trim sheet shape generation system
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using TrimSheet_Tools.Model;
using TrimSheet_Tools.Properties;
using TrimSheet_Tools.View;

namespace TrimSheet_Tools.Controller
{
    internal class TrimSheet_GeneratedSystem
    {
        // Global variables
        private List<StripData> _targetStripDataList;
        private TrimSheet_RebuildingShapeSystem _targetRebuildingShapeSystem;
        private TrimSettings _targetForm;

        // Generated System
        private Random _random = new Random();
        private HashSet<int> _usedHueBuckets = new HashSet<int>();


        /// <summary>
        /// Trim Sheet Generated System
        /// </summary>
        /// <param name="_stripDataListRef">StripDataList reference</param>
        /// <param name="rebuildingSystemRef">RebuildSystem reference</param>
        /// <param name="trimSettingsRef">Form reference</param>
        public TrimSheet_GeneratedSystem(ref List<StripData> _stripDataListRef, ref TrimSheet_RebuildingShapeSystem rebuildingSystemRef, TrimSettings trimSettingsRef)
        {
            // Initialize References
            this._targetStripDataList = _stripDataListRef;
            this._targetRebuildingShapeSystem = rebuildingSystemRef;
            this._targetForm = trimSettingsRef;
        }


        // Methods
        /// <summary>
        /// Redraws the viewport as part of ResponsiveSystem
        /// </summary>
        public void ResponsiveSystemViewer()
        { _targetRebuildingShapeSystem.Rebuild(); }

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

        // OutputInfo Panel
        private void Set_OutputInfo(float coverageSpaceRef)
        {
            _targetForm.resolutionInfo.Text = _targetForm.selectedResolution.SelectedItem?.ToString() + " px";
            _targetForm.coverageSpaceInfo.Text = coverageSpaceRef.ToString() + " cm²";
            _targetForm.baseDensityInfo.Text = _targetForm._genTexelDensity + " px/cm";
        }

        // Label Size
        private float LerpLabelSize(float value, float inputMin, float inputMax, float outputMin, float outputMax)
        {
            value = Math.Max(inputMin, Math.Min(inputMax, value));
            float percent = (value - inputMin) / (inputMax - inputMin);

            return outputMin + percent * (outputMax - outputMin);
        }
             
        /// <summary>
        /// Generates the final image based on the selected resolution
        /// </summary>
        /// <returns></returns>
        public Image ImageToExport()
        {
            // Get parameters
            int resolution = _targetForm._genResolution;
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


        /// <summary>
        /// Generate Trim Sheet
        /// </summary>
        /// <param name="e"></param>
        public void Generat(EventArgs e)
        {
            // Clear old informations
            _targetForm.stripsInfo_DataGridView.Rows.Clear();
            _targetStripDataList.Clear();
            _targetForm.uvTrimView_Panel.Controls.Clear();
            _usedHueBuckets.Clear();

            // Get parameters
            if (!int.TryParse(_targetForm.stripQuantity_TextBox.Text, out int stripCount) || stripCount <= 0)
                return;

            double totalSizeCm = _targetForm._genResolution / _targetForm._genTexelDensity;
            float minSizeCm = 1f; // Min strip size

            // Calculates the equal size ensuring the minimum
            double equalSizeCm = Math.Max(minSizeCm, totalSizeCm / stripCount);

            // Adjust the aspect ratio
            if (equalSizeCm * stripCount > totalSizeCm)
            {
                equalSizeCm = totalSizeCm / stripCount;
            }

            // Convert to fraction (0-1)
            double equalSizeFraction = TrimSheet_Utilities.ConvertUnits_CentimetersToViewport(equalSizeCm, _targetForm._genResolution, _targetForm._genTexelDensity);

            // Strip generation
            Image checkerTexture = null;
            switch (_targetForm._genTexelDensity)
            {
                case 5.12f: 
                    checkerTexture = Resources.Checker_5_12; 
                    break;
                case 10.24f: 
                    checkerTexture = Resources.Checker_10_24; 
                    break;
                case 20.48f: 
                    checkerTexture = Resources.Checker_20_48; 
                    break;
            }

            for (int i = 0; i < stripCount; i++)
            {
                // Shape creation
                Color pastelColor = GeneratedColor(_random);
                BunifuShapes shape = new BunifuShapes
                {
                    BackColor = pastelColor,
                    BackgroundImage = checkerTexture,
                    BackgroundImageLayout = ImageLayout.Tile,
                    Shape = BunifuShapes.Shapes.Rectangle,
                    BorderThickness = 0,
                };

                // Set StripData
                var stripData = new StripData
                {
                    StripShape = shape,
                    StripColor = pastelColor,
                    StripName = $"Strip {i + 1}",
                    StripSize = _targetForm._genVerticalMode ? new Vector2D(equalSizeFraction, 1f) : new Vector2D(1f, equalSizeFraction),
                    StripDensity = _targetForm._genTexelDensity,
                };
                _targetStripDataList.Add(stripData);

                // Size unit convertion
                double sizeXCm = _targetForm._genVerticalMode ? equalSizeCm : totalSizeCm;
                double sizeYCm = _targetForm._genVerticalMode ? totalSizeCm : equalSizeCm;

                // Set to DataGridView
                _targetForm.stripsInfo_DataGridView.Rows.Add(
                    stripData.GetBitmap(),
                    stripData.StripName,
                    sizeXCm.ToString("0.##", CultureInfo.InvariantCulture),
                    sizeYCm.ToString("0.##", CultureInfo.InvariantCulture),
                    null,
                    _targetForm._genTexelDensity
                );
            }

            // Update informations
            float coverageSpace = (_targetForm._genResolution / _targetForm._genTexelDensity);
            Set_OutputInfo(coverageSpace);

            _targetRebuildingShapeSystem.Rebuild();
        }
    }
}
