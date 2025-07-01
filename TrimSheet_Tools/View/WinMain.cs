using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrimSheet_Tools.Properties;
using TrimSheet_Tools.Controller;

namespace TrimSheet_Tools.View
{
    public partial class WinMain : Form
    {
        // Global variables
        private WinMain_ControlBox controlBox;
        private DockPanel dockPanelSystem;


        public WinMain()
        {
            InitializeComponent();

            // Initialize 
            controlBox = new WinMain_ControlBox(this); // Minimize and Close control
            dockPanelSystem = new DockPanel(this.mainMenuTransition, this.logoImage, this.menuPanel, 80, 740); // Dock system Main Menu
            SetFontFromUI(); // Buttons Custom Type

            LoadWindow();
        }

        // Window Methods
        private void SetFontFromUI()
        {
            new SetFontStyle(trimSettingsBtn, Model.CustomFont.MollenBold);
            new SetFontStyle(uvPlanningBtn, Model.CustomFont.MollenRegular);
            new SetFontStyle(helpInfoBtn, Model.CustomFont.MollenRegular);
            new SetFontStyle(aboutBtn, Model.CustomFont.MollenRegular);
            new SetFontStyle(onTopLabel, Model.CustomFont.MollenLight);
        }
        private void LoadWindow()
        {
            TrimSettings newForm = new TrimSettings(dockPanelSystem);
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;

            formContainerPanel.Controls.Clear();
            formContainerPanel.Controls.Add(newForm);
            newForm.Show();
        }

        // Event Methods
        private void trimSettingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void uvPlanningBtn_Click(object sender, EventArgs e)
        {

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
