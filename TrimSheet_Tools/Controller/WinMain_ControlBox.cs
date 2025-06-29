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
        private TrimSheet_Tools.View.WinMain formRef;   // Referência para WinMain

        /// <summary>
        /// Controller Initializer
        /// </summary>
        /// <param name="formInput">Main Window Reference</param>
        public WinMain_ControlBox(TrimSheet_Tools.View.WinMain formInput)
        {
            this.formRef = formInput;

            // Connect form events to methods
            this.formRef.btnClose.Click += this.btnClose_Click;
            this.formRef.btnMinimize.Click += this.btnMinimize_Click;
            this.formRef.Resize += this.WinMain_Resize;
        }


        //Event Control Methods
        private void btnClose_Click(object sender, EventArgs e)
        { formRef.Close(); }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            // Minimize the program
            formRef.topPanelSeparator.Visible = false;
            formRef.WindowState = System.Windows.Forms.FormWindowState.Minimized; // Correção de bug lib bunifu
        }

        private void WinMain_Resize(object sender, EventArgs e)
        {
            // bunifu bug fix
            if (formRef.WindowState != FormWindowState.Minimized)
                formRef.topPanelSeparator.Visible = true;
        }
    }
}
