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
        private TrimSheet_Tools.View.WinMain _targetForm;   // Reference to WinMain


        /// <summary>
        /// Controller Initializer
        /// </summary>
        /// <param name="formRef">Main Window Reference</param>
        public WinMain_ControlBox(TrimSheet_Tools.View.WinMain formRef)
        {
            // Initialize References
            this._targetForm = formRef;

            // Connect form events to methods
            this._targetForm.btnClose.Click += this.btnClose_Click;
            this._targetForm.btnMinimize.Click += this.btnMinimize_Click;
            this._targetForm.Resize += this.WinMain_Resize;
        }


        //Event Control Methods
        private void btnClose_Click(object sender, EventArgs e)
        { _targetForm.Close(); }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            _targetForm.bunifuSeparator2.Dock = DockStyle.None; //bunifu Separator Anchor bug correction
            _targetForm.WindowState = FormWindowState.Minimized;
        }

        private void WinMain_Resize(object sender, EventArgs e)
        {
            // Bunifu Separator Anchor bug correction
            if (_targetForm.WindowState != FormWindowState.Minimized)
               _targetForm.bunifuSeparator2.Dock = DockStyle.Bottom;

        }
    }
}
