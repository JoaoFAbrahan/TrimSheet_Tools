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
    public partial class TrimSettings : Form
    {
        // Global variables
        private TrimSettings_ResponsivitySystem responsivitySystem;


        public TrimSettings(DockPanel dockingPanelRef)
        {
            InitializeComponent();

            // Get Reference
            responsivitySystem = new TrimSettings_ResponsivitySystem(this,  dockingPanelRef);
        }


        // 
        private void TrimSettings_Paint(object sender, PaintEventArgs e)
        {
            // Docking System re-drawing
            responsivitySystem.ResponsiveSystem();
        }
    }
}
