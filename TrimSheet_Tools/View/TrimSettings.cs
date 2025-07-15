using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TrimSheet_Tools.Controller;
using TrimSheet_Tools.Model;
//using TrimSheet_Tools.Model;

namespace TrimSheet_Tools.View
{
    public partial class TrimSettings : Form, IStartComponents
    {
        // Global variables
        private TrimSheet_Tools.Model.DockPanelModel _dockingPanelState;
        private ResponsivitySystem _responsivitySystem;
        private ExportTextureSystem _exportTextureSystem;

        // Trim Sheet System
        public int _genResolution;
        public bool _genVerticalMode;
        public float _genTexelDensity;
        private List<TrimSheet_Tools.Model.StripData> _targetStripDataList;

        // Trim Sheet System Components
        private TrimSheet_RebuildingShapeSystem _rebuildShapeSystem;
        private TrimSheet_GeneratedSystem _generatedTexureSystem;
        private TrimSheet_DataGridEditSystem _dataGridEditSystem;


        public TrimSettings(ref List<TrimSheet_Tools.Model.StripData> stripDataListRef, in TrimSheet_Tools.Model.DockPanelModel dockingPanelRef)
        {
            InitializeComponent();

            // Initialize References
            this._targetStripDataList = stripDataListRef;
            this._dockingPanelState = dockingPanelRef;

            // Trim Sheet System
            this._rebuildShapeSystem = new TrimSheet_RebuildingShapeSystem(ref _targetStripDataList, this, _dockingPanelState);
            this._generatedTexureSystem = new TrimSheet_GeneratedSystem(ref _targetStripDataList, ref _rebuildShapeSystem, this);
            this._dataGridEditSystem = new TrimSheet_DataGridEditSystem(ref _targetStripDataList, ref _rebuildShapeSystem, this);
            this._exportTextureSystem = new ExportTextureSystem();

            // Set Responsive Panels
            this._responsivitySystem = new ResponsivitySystem(this, _dockingPanelState);
            SetResponsivePanels();

            // Set Resources Type
            SetResourceFonts();
            DataGridViewStart();
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
            new SetFontStyle(outputInfoTitle_Label, Model.ECustomFont.MollenBold);
            new SetFontStyle(projectTitle_Label, Model.ECustomFont.MollenBold);

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

            // Output Info Panel
            new SetFontStyle(outResolutionLabel, Model.ECustomFont.MollenRegular);
            new SetFontStyle(outCoverageSpaceLabel, Model.ECustomFont.MollenRegular);
            new SetFontStyle(outBaseDensityLabel, Model.ECustomFont.MollenRegular);
            new SetFontStyle(resolutionInfo, Model.ECustomFont.MollenRegular);
            new SetFontStyle(coverageSpaceInfo, Model.ECustomFont.MollenRegular);
            new SetFontStyle(baseDensityInfo, Model.ECustomFont.MollenRegular);

            // SelectedStripManipulation Panel
            new SetFontStyle(StripTexelDesnsityLabel, Model.ECustomFont.MollenRegular);
            new SetFontStyle(stripTexelDensityLabel1, Model.ECustomFont.MollenLight);
            new SetFontStyle(stripTexelDensityLabel2, Model.ECustomFont.MollenLight);
            new SetFontStyle(stripTexelDensityLabel3, Model.ECustomFont.MollenLight);
            new SetFontStyle(splitStrip_Btn, Model.ECustomFont.MollenBold);
            new SetFontStyle(deleteStrip_Btn, Model.ECustomFont.MollenBold);
            new SetFontStyle(changeStripTexelDensity_Btn, Model.ECustomFont.MollenBold);

            // Project Panel
            new SetFontStyle(projectSave_Btn, Model.ECustomFont.MollenBold);
            new SetFontStyle(prujectImport_Btn, Model.ECustomFont.MollenBold);

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
            stripsInfo_DataGridView.Columns["ShapeSizeX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stripsInfo_DataGridView.Columns["ShapeSizeY"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stripsInfo_DataGridView.Columns["StripSize"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stripsInfo_DataGridView.Columns["ShapeTexDensity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
        private void TrimSettings_Resize(object sender, EventArgs e)
        {
            // Docking System re-drawing
            _responsivitySystem.ResponsiveSystem();
            _generatedTexureSystem.ResponsiveSystemViewer();
        }

        private void generateTexture_Btn_Click(object sender, EventArgs e)
        {
            // Get parameters
            if (!int.TryParse(selectedResolution.SelectedItem?.ToString().Split('x')[0], out _genResolution))
                return;
            _genTexelDensity = float.Parse(TrimSheet_Utilities.CheckerTexelDensity(TexelDensityGroupGenerated), CultureInfo.InvariantCulture);
            _genVerticalMode = verticalMode_CheckBox.Checked;

            // Generat TrimSheet
            _generatedTexureSystem.Generat(e);
        }
        
        private void stripsInfo_DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _dataGridEditSystem.DataGridStripEditing(e);
        }

        private void selectFolder_Btn_Click(object sender, EventArgs e)
        { folderPath_TextBox.Text = _exportTextureSystem.ExportTexture(_generatedTexureSystem.ImageToExport()); }

    }
}
