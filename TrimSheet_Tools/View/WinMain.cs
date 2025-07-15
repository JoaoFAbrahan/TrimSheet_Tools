using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TrimSheet_Tools.Controller;

namespace TrimSheet_Tools.View
{
    public partial class WinMain : Form, IDockPanelView
    {
        // Global variables
        private WinMain_ControlBox _controlBox; // ControlBox Component
        List<TrimSheet_Tools.Model.StripData> _stripDataList = new List<TrimSheet_Tools.Model.StripData>(); // Trim Sheet Data

        // Docking Panel System Component
        private TrimSheet_Tools.Model.DockPanelModel _dockPanelModel;
        private DockPanelController _dockPanelSystem; 

        // Forms
        private WinMain_LoadForms _loadFormSystem;
        private TrimSettings _trimSettings;
        private UVPlanning _uvPlanning;


        public WinMain()
        {
            InitializeComponent();

            // Initialize 
            _controlBox = new WinMain_ControlBox(this); //Minimize and Close control
            _loadFormSystem = new WinMain_LoadForms(formContainerPanel); //Form Loader System

            // Docking Panel System
            _dockPanelModel = new TrimSheet_Tools.Model.DockPanelModel();
            _dockPanelSystem = new DockPanelController(_dockPanelModel, this, menuPanel.Width, menuPanel.Height, 80, 740);
            logoImage.Click += (s, e) => _dockPanelSystem.ToggleDocking();

            // Set Resources Type
            SetFontFromUI(); //Buttons Custom Type

            // Forms initialization
            _loadFormSystem.AddFormList(_trimSettings = new TrimSettings(ref _stripDataList, in _dockPanelModel));
            _loadFormSystem.AddFormList(_uvPlanning = new UVPlanning());
        }


        // Window Methods
        private void SetFontFromUI()
        {
            new SetFontStyle(trimSettingsBtn, Model.ECustomFont.MollenBold);
            new SetFontStyle(uvPlanningBtn, Model.ECustomFont.MollenBold);
            new SetFontStyle(helpInfoBtn, Model.ECustomFont.MollenBold);
            new SetFontStyle(aboutBtn, Model.ECustomFont.MollenBold);
            new SetFontStyle(onTopLabel, Model.ECustomFont.MollenLight);
            new SetFontStyle(textPresentation1Label, Model.ECustomFont.MollenRegular);
            new SetFontStyle(textPresentation2Label, Model.ECustomFont.MollenRegular);
        }


        public void SetPanelSize(int width, int height)
        { menuPanel.Size  = new Size(width, height); }

        public void AnimatePanel()
        { mainMenuTransition.ShowSync(menuPanel); }


        // Event Methods
        private void trimSettingsBtn_Click(object sender, EventArgs e)
        {
            _loadFormSystem.LoadWindow(0);
        }

        private void uvPlanningBtn_Click(object sender, EventArgs e)
        {
            _loadFormSystem.LoadWindow(1);
        }

        private void helpInfoBtn_Click(object sender, EventArgs e)
        {

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {

        }

        private void onTopToggleSwitch_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            // Apply window behavior
            this.TopMost = onTopToggleSwitch.Value;
        }

    }
}
