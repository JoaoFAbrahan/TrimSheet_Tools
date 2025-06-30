// Class containing the docking controller system
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Windows.Forms;

namespace TrimSheet_Tools.Controller
{
    /// <summary>
    /// Functionality controller for the docking panel system 
    /// </summary>
    internal class DockPanel
    {
        // Global variables
        private bool expandStatus = false;

        // Panel Reference
        private Panel targetPanel;
        private BunifuTransition targetTransition;

        // Button Reference
        private Button targetButton;
        private PictureBox targetPictureBox;
        private BunifuButton targetBunifuButton;
        private BunifuImageButton targetBunifuImageButton;

        // Docking Size
        private int defaultSize_X, defaultSize_Y;
        private int dockedSize_X, dockedSize_Y;

        /// <summary>
        /// DockingSystem Initializer
        /// </summary>
        /// <param name="transitionRef">Reference to the BunifuTransition</param>
        /// <param name="buttonRef">Reference to the button that activates the function</param>
        /// <param name="panelRef">Reference of the panel that receives the function</param>
        /// <param name="dockedSize_XRef">New Width</param>
        /// <param name="dockedSize_YRef">New Height</param>
        public DockPanel(BunifuTransition transitionRef, Button buttonRef, Panel panelRef, int dockedSize_XRef, int dockedSize_YRef)
        {
            // Get Reference
            this.targetTransition = transitionRef;
            this.targetButton = buttonRef;
            this.targetPanel = panelRef;
            this.defaultSize_X = panelRef.Width;
            this.defaultSize_Y = panelRef.Height;
            this.dockedSize_X = dockedSize_XRef;
            this.dockedSize_Y = dockedSize_YRef;

            // Connect button events to methods
            targetButton.Click += this.ApplyDocking_Click;
        }

        /// <summary>
        /// DockingSystem Initializer
        /// </summary>
        /// <param name="transitionRef">Reference to the BunifuTransition</param>
        /// <param name="buttonRef">Reference to the button that activates the function</param>
        /// <param name="panelRef">Reference of the panel that receives the function</param>
        /// <param name="dockedSize_XRef">New Width</param>
        /// <param name="dockedSize_YRef">New Height</param>
        public DockPanel(BunifuTransition transitionRef, PictureBox buttonRef, Panel panelRef, int dockedSize_XRef, int dockedSize_YRef)
        {
            // Get Reference
            this.targetTransition = transitionRef;
            this.targetPictureBox = buttonRef;
            this.targetPanel = panelRef;
            this.defaultSize_X = panelRef.Width;
            this.defaultSize_Y = panelRef.Height;
            this.dockedSize_X = dockedSize_XRef;
            this.dockedSize_Y = dockedSize_YRef;

            // Connect button events to methods
            targetPictureBox.Click += this.ApplyDocking_Click;
        }

        /// <summary>
        /// DockingSystem Initializer
        /// </summary>
        /// <param name="transitionRef">Reference to the BunifuTransition</param>
        /// <param name="buttonRef">Reference to the button that activates the function</param>
        /// <param name="panelRef">Reference of the panel that receives the function</param>
        /// <param name="dockedSize_XRef">New Width</param>
        /// <param name="dockedSize_YRef">New Height</param>
        public DockPanel(BunifuTransition transitionRef, BunifuButton buttonRef, Panel panelRef, int dockedSize_XRef, int dockedSize_YRef)
        {
            // Get Reference
            this.targetTransition = transitionRef;
            this.targetBunifuButton = buttonRef;
            this.targetPanel = panelRef;
            this.defaultSize_X = panelRef.Width;
            this.defaultSize_Y = panelRef.Height;
            this.dockedSize_X = dockedSize_XRef;
            this.dockedSize_Y = dockedSize_YRef;

            // Connect button events to methods
            targetBunifuButton.Click += this.ApplyDocking_Click;
        }

        /// <summary>
        /// DockingSystem Initializer
        /// </summary>
        /// <param name="transitionRef">Reference to the BunifuTransition</param>
        /// <param name="buttonRef">Reference to the button that activates the function</param>
        /// <param name="panelRef">Reference of the panel that receives the function</param>
        /// <param name="dockedSize_XRef">New Width</param>
        /// <param name="dockedSize_YRef">New Height</param>
        public DockPanel(BunifuTransition transitionRef, BunifuImageButton buttonRef, Panel panelRef, int dockedSize_XRef, int dockedSize_YRef)
        {
            // Get Reference
            this.targetTransition = transitionRef;
            this.targetBunifuImageButton = buttonRef;
            this.targetPanel = panelRef;
            this.defaultSize_X = panelRef.Width;
            this.defaultSize_Y = panelRef.Height;
            this.dockedSize_X = dockedSize_XRef;
            this.dockedSize_Y = dockedSize_YRef;

            // Connect button events to methods
            targetBunifuImageButton.Click += this.ApplyDocking_Click;
        }



        private void ApplyDocking_Click(object sender, EventArgs e)
        {
            // Docking panel FlipFlop
            if(expandStatus)
            {
                // Docking the menu
                targetTransition.ShowSync(targetPanel);
                targetPanel.Width = dockedSize_X;
                targetPanel.Height = dockedSize_Y;
                expandStatus = false;
            }
            else
            {
                // Undocking the menu
                targetPanel.Width = defaultSize_X;
                targetPanel.Height = defaultSize_Y;
                targetTransition.ShowSync(targetPanel);
                expandStatus = true;
            }
        }

    }
}
