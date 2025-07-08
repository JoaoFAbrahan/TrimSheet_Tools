using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrimSheet_Tools.Controller;
using TrimSheet_Tools.Model;

namespace TrimSheet_Tools.View
{
    public partial class TrimSettings : Form, IStartComponents
    {
        // Global variables
        private TrimSheet_Tools.Model.DockPanelModel _dockingPanelState;
        private ResponsivitySystem _responsivitySystem;
        private List<TrimStrips> stripDataList;
        private Random random = new Random();


        public TrimSettings(TrimSheet_Tools.Model.DockPanelModel dockingPanelRef)
        {
            InitializeComponent();

            // Initialize
            this._dockingPanelState = dockingPanelRef;
            this.stripDataList = new List<TrimStrips>();

            // Set Responsive Panels
            this._responsivitySystem = new ResponsivitySystem(this, _dockingPanelState);
            SetResponsivePanels();

            // Set Resources Type
            SetResourceFonts();
            DataGridViewStart();



            ////////
        }


        // Methods
        public void SetResponsivePanels()
        {
            // UV Panel
            _responsivitySystem.AddResponsivePanel(uvTrimView_Panel,
                                                   new TrimSheet_Tools.Model.SResponsiveSizeState { DefaultSize = new Size(uvTrimView_Panel.Size.Width, uvTrimView_Panel.Size.Height), NewSize = new Size(480, 480) },
                                                   new TrimSheet_Tools.Model.SResponsiveLocationState { DefaultPoint = new Point(uvTrimView_Panel.Location.X, uvTrimView_Panel.Location.Y), NewPoint = new Point(uvTrimView_Panel.Location.X, uvTrimView_Panel.Location.Y) });
            // TrimSheet Viewer Panel
            _responsivitySystem.AddResponsivePanel(trimSheetViewerPanel,
                                                   new TrimSheet_Tools.Model.SResponsiveSizeState { DefaultSize = new Size(trimSheetViewerPanel.Size.Width, trimSheetViewerPanel.Size.Height), NewSize = new Size(519, 564) },
                                                   new TrimSheet_Tools.Model.SResponsiveLocationState { DefaultPoint = new Point(trimSheetViewerPanel.Location.X, trimSheetViewerPanel.Location.Y), NewPoint = new Point(trimSheetViewerPanel.Location.X, trimSheetViewerPanel.Location.Y) });
            // Export Texture Panel
            _responsivitySystem.AddResponsivePanel(exportTexturePanel,
                                                   new TrimSheet_Tools.Model.SResponsiveSizeState { DefaultSize = new Size(exportTexturePanel.Size.Width, exportTexturePanel.Size.Height), NewSize = new Size(519, 118) },
                                                   new TrimSheet_Tools.Model.SResponsiveLocationState { DefaultPoint = new Point(exportTexturePanel.Location.X, exportTexturePanel.Location.Y), NewPoint = new Point(exportTexturePanel.Location.X, 593) });
        } 

        public void SetResourceFonts()
        {
            // Titles Panel
            new SetFontStyle(textureSettingsTitle_Label, Model.ECustomFont.MollenBold);
            new SetFontStyle(selectedStripManipulationTitle_Label, Model.ECustomFont.MollenBold);
            new SetFontStyle(stripInformation_Label, Model.ECustomFont.MollenBold);
            new SetFontStyle(trimSheetViewer_Label, Model.ECustomFont.MollenBold);
            new SetFontStyle(exportTexture_Label, Model.ECustomFont.MollenBold);

            // TextureSettings Panel
            new SetFontStyle(resolutionLabel, Model.ECustomFont.MollenRegular);
            new SetFontStyle(trimRowsLabel, Model.ECustomFont.MollenRegular);
            new SetFontStyle(verticalLabel, Model.ECustomFont.MollenRegular);
            new SetFontStyle(texelDensityLabel, Model.ECustomFont.MollenRegular);
            new SetFontStyle(texelDensityGridCheker_Label, Model.ECustomFont.MollenLight);
            new SetFontStyle(texelDensityLabel1, Model.ECustomFont.MollenLight);
            new SetFontStyle(texelDensityLabel2, Model.ECustomFont.MollenLight);
            new SetFontStyle(texelDensityLabel3, Model.ECustomFont.MollenLight);
            new SetFontStyle(generateTexture_Btn, Model.ECustomFont.MollenBold);

            // SelectedStripManipulation Panel
            new SetFontStyle(StripTexelDesnsityLabel, Model.ECustomFont.MollenRegular);
            new SetFontStyle(stripTexelDensityLabel1, Model.ECustomFont.MollenLight);
            new SetFontStyle(stripTexelDensityLabel2, Model.ECustomFont.MollenLight);
            new SetFontStyle(stripTexelDensityLabel3, Model.ECustomFont.MollenLight);
            new SetFontStyle(splitStrip_Btn, Model.ECustomFont.MollenBold);
            new SetFontStyle(deleteStrip_Btn, Model.ECustomFont.MollenBold);
            new SetFontStyle(changeStripTexelDensity_Btn, Model.ECustomFont.MollenBold);

            // DataGridView Panel
            new SetFontStyle(stripsInfo_DataGridView, Model.ECustomFont.MollenBold, Model.ECustomFont.MollenRegular);
            stripsInfo_DataGridView.DefaultCellStyle.Font = new Font(stripsInfo_DataGridView.DefaultCellStyle.Font.FontFamily, 
                                                                     8, 
                                                                     stripsInfo_DataGridView.DefaultCellStyle.Font.Style);
            stripsInfo_DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(stripsInfo_DataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily,
                                                                     10,
                                                                     stripsInfo_DataGridView.ColumnHeadersDefaultCellStyle.Font.Style);
        }

        private void DataGridViewStart()
        {
            // Custom DataGridView Style
            // Headers
            stripsInfo_DataGridView.ColumnHeadersHeight = 45;
            stripsInfo_DataGridView.EnableHeadersVisualStyles = false;
            stripsInfo_DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 16, 17);
            stripsInfo_DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            stripsInfo_DataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 63, 66);
            stripsInfo_DataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            // Rows
            stripsInfo_DataGridView.GridColor = Color.FromArgb(33, 37, 40);
            stripsInfo_DataGridView.DefaultCellStyle.BackColor = Color.FromArgb(33, 37, 40);
            stripsInfo_DataGridView.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            stripsInfo_DataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(124, 126, 124);
            stripsInfo_DataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            stripsInfo_DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(43, 48, 52);
            stripsInfo_DataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            stripsInfo_DataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(124, 126, 124);
            stripsInfo_DataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        }


        // Event Methods
        private void TrimSettings_Paint(object sender, PaintEventArgs e)
        {
            // Docking System re-drawing
            _responsivitySystem.ResponsiveSystem();
        }





        private HashSet<int> usedHueBuckets = new HashSet<int>();

        private Color GeneratePastelColor(Random rng)
        {
            int hueBucket;
            int maxAttempts = 50;
            int attempt = 0;

            // Divide o espectro em "buckets" de 15 graus e evita repetir
            do
            {
                hueBucket = rng.Next(0, 360 / 15); // 24 buckets
                attempt++;
            }
            while (usedHueBuckets.Contains(hueBucket) && attempt < maxAttempts);

            usedHueBuckets.Add(hueBucket);
            double hue = hueBucket * 15;

            // Suavemente aleatoriza saturação e brilho para mais variedade
            double saturation = 0.3 + rng.NextDouble() * 0.2;  // entre 0.3 e 0.5
            double brightness = 0.85 + rng.NextDouble() * 0.1; // entre 0.85 e 0.95

            return FromHsv(hue, saturation, brightness);
        }

        private Color FromHsv(double hue, double saturation, double value)
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

        private void generateTexture_Btn_Click(object sender, EventArgs e)
        {
            stripsInfo_DataGridView.Rows.Clear();
            stripDataList.Clear();
            uvTrimView_Panel.Controls.Clear();
            usedHueBuckets.Clear();

            if (!int.TryParse(stripQuantity_TextBox.Text, out int stripCount) || stripCount <= 0)
                return;

            if (!int.TryParse(selectedResolution.SelectedItem?.ToString().Split('x')[0], out int resolution))
                return;

            float equalHeight = 1f / stripCount;
            float scaleFactor = 615f / (float)resolution;
            float currentTop = 0f;

            for (int i = 0; i < stripCount; i++)
            {
                BunifuShapes shape = new BunifuShapes
                {
                    Shape = BunifuShapes.Shapes.Rectangle,
                    Width = uvTrimView_Panel.Width,
                    Height = (int)(equalHeight * resolution * scaleFactor),
                    Top = (int)(currentTop * resolution * scaleFactor),
                    Left = 0,
                    BorderThickness = 0,
                };

                Color pastelColor = GeneratePastelColor(random);
                shape.FillColor = pastelColor;

                uvTrimView_Panel.Controls.Add(shape);

                var stripData = new TrimStrips
                {
                    ShapeControl = shape,
                    HeightPercent = equalHeight,
                    Color = pastelColor,
                    Name = $"Shape {i + 1}"
                };

                stripDataList.Add(stripData);

                Bitmap bmp = new Bitmap(24, 24);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(stripData.Color);
                    g.DrawRectangle(Pens.Gray, 0, 0, bmp.Width - 1, bmp.Height - 1);
                }

                stripsInfo_DataGridView.Rows.Add(bmp, stripData.Name, equalHeight.ToString("0.###", CultureInfo.InvariantCulture), "1x");

                currentTop += equalHeight;
            }

            RebuildShapesFromData();
        }          

        private void stripsInfo_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == stripsInfo_DataGridView.Columns["ShapeSize"].Index)
            {
                try
                {
                    float newValue = float.Parse(
                        stripsInfo_DataGridView.Rows[e.RowIndex].Cells["ShapeSize"].Value.ToString(),
                        CultureInfo.InvariantCulture
                    );

                    newValue = Math.Max(0.01f, Math.Min(0.99f, newValue));
                    int index = e.RowIndex;
                    TrimStrips current = stripDataList[index];

                    if (index < stripDataList.Count - 1)
                    {
                        TrimStrips next = stripDataList[index + 1];
                        float delta = newValue - current.HeightPercent;
                        float adjustedNext = next.HeightPercent - delta;

                        if (adjustedNext < 0.01f)
                        {
                            adjustedNext = 0.01f;
                            newValue = current.HeightPercent + (next.HeightPercent - 0.01f);
                        }

                        current.HeightPercent = newValue;
                        next.HeightPercent = adjustedNext;

                        stripsInfo_DataGridView.Rows[index].Cells["ShapeSize"].Value =
                            newValue.ToString("0.###", CultureInfo.InvariantCulture);

                        stripsInfo_DataGridView.Rows[index + 1].Cells["ShapeSize"].Value =
                            adjustedNext.ToString("0.###", CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        TrimStrips prev = stripDataList[index - 1];
                        float delta = newValue - current.HeightPercent;
                        float adjustedPrev = prev.HeightPercent - delta;

                        if (adjustedPrev < 0.01f)
                        {
                            adjustedPrev = 0.01f;
                            newValue = current.HeightPercent + (prev.HeightPercent - 0.01f);
                        }

                        current.HeightPercent = newValue;
                        prev.HeightPercent = adjustedPrev;

                        stripsInfo_DataGridView.Rows[index].Cells["ShapeSize"].Value =
                            newValue.ToString("0.###", CultureInfo.InvariantCulture);

                        stripsInfo_DataGridView.Rows[index - 1].Cells["ShapeSize"].Value =
                            adjustedPrev.ToString("0.###", CultureInfo.InvariantCulture);
                    }

                    RebuildShapesFromData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar shape: " + ex.Message);
                }
            }
            else if (e.ColumnIndex == stripsInfo_DataGridView.Columns["ShapeName"].Index)
            {
                string newName = stripsInfo_DataGridView.Rows[e.RowIndex].Cells["ShapeName"].Value.ToString();
                stripDataList[e.RowIndex].Name = newName;

                // Atualiza texto da label
                var label = uvTrimView_Panel.Controls.Find($"labelShapeName{e.RowIndex}", false).FirstOrDefault() as Label;
                if (label != null)
                    label.Text = newName;
            }
        }

        private void RebuildShapesFromData()
        {
            if (!int.TryParse(selectedResolution.SelectedItem?.ToString().Split('x')[0], out int resolution))
                return;

            float scaleFactor = 615f / (float)resolution;
            float accumulatedTop = 0f;

            // Limpa todos controles (shapes e labels)
            uvTrimView_Panel.Controls.Clear();

            for (int i = 0; i < stripDataList.Count; i++)
            {
                var data = stripDataList[i];
                var shape = data.ShapeControl;

                float shapeHeight = data.HeightPercent * resolution;
                float shapeTop = accumulatedTop * resolution;

                shape.Top = (int)(shapeTop * scaleFactor);
                shape.Height = (int)(shapeHeight * scaleFactor);
                shape.Width = uvTrimView_Panel.Width;
                shape.BorderThickness = 0;

                uvTrimView_Panel.Controls.Add(shape);

                // Cria label para o texto do nome, transparente e posicionada sobre a shape
                Label nameLabel = new Label
                {
                    Name = $"labelShapeName{i}",
                    Text = data.Name,
                    ForeColor = Color.Black,
                    BackColor = data.Color,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Width = shape.Width,
                    Height = shape.Height,
                    Top = shape.Top,
                    Left = shape.Left
                };

                uvTrimView_Panel.Controls.Add(nameLabel);
                // label na frente da shape
                nameLabel.BringToFront();

                accumulatedTop += data.HeightPercent;

                // Atualiza grid com valores atuais
                stripsInfo_DataGridView.Rows[i].Cells["ShapeSize"].Value =
                    data.HeightPercent.ToString("0.###", CultureInfo.InvariantCulture);

                stripsInfo_DataGridView.Rows[i].Cells["ShapeName"].Value = data.Name;
            }

            uvTrimView_Panel.Invalidate();
            uvTrimView_Panel.Refresh();
        }
    }
}
