// Class containing the WinMain main controller system
using System;
using System.Windows.Forms;

namespace TrimSheet_Tools.Controller
{
    /// <summary>
    /// Functionality controller for the main window management buttons "Close button and Minilize button" 
    /// </summary>
    internal class WinMain_ControlBox
    {
        // Global variables
        private TrimSheet_Tools.View.WinMain targetForm;   // Reference to WinMain


        /// <summary>
        /// Controller Initializer
        /// </summary>
        /// <param name="formRef">Main Window Reference</param>
        public WinMain_ControlBox(TrimSheet_Tools.View.WinMain formRef)
        {
            this.targetForm = formRef;

            // Connect form events to methods
            this.targetForm.btnClose.Click += this.btnClose_Click;
            this.targetForm.btnMinimize.Click += this.btnMinimize_Click;
            this.targetForm.Resize += this.WinMain_Resize;
        }


        //Event Control Methods
        private void btnClose_Click(object sender, EventArgs e)
        { targetForm.Close(); }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            // Minimize the program
            targetForm.topPanelSeparator.Visible = false;
            targetForm.WindowState = System.Windows.Forms.FormWindowState.Minimized; // bunifu lib bug correction
        }

        private void WinMain_Resize(object sender, EventArgs e)
        {
            // bunifu bug fix
            if (targetForm.WindowState != FormWindowState.Minimized)
                targetForm.topPanelSeparator.Visible = true;
        }
    }
}
