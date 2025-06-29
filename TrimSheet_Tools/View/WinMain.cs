using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrimSheet_Tools.Controller;

namespace TrimSheet_Tools.View
{
    public partial class WinMain : Form
    {
        // Global variables
        private WinMain_ControlBox controlBox;

        public WinMain()
        {
            InitializeComponent();


            controlBox = new WinMain_ControlBox(this); // Minimize and Close control
            SetFontFromUI();
        }

        private void SetFontFromUI()
        {
            new SetFontStyle(trimSettingsBtn, Model.CustomFont.MollenBold);
            new SetFontStyle(uvPlanningBtn, Model.CustomFont.MollenRegular);
            new SetFontStyle(helpInfoBtn, Model.CustomFont.MollenRegular);
            new SetFontStyle(aboutBtn, Model.CustomFont.MollenRegular);
            new SetFontStyle(toggleBtnLabel, Model.CustomFont.MollenLight);
        }


        // Window Methods
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
    }
}
