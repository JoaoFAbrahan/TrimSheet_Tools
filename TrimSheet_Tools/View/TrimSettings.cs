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
using TrimSheet_Tools.Model;

namespace TrimSheet_Tools.View
{
    public partial class TrimSettings : Form
    {
        // Global variables
        private ResponsivitySystem _responsivitySystem;


        public TrimSettings(DockPanelModel dockingPanelRef)
        {
            InitializeComponent();

            // Get Reference
            _responsivitySystem = new ResponsivitySystem(this,  dockingPanelRef);

            // Set Responsive Panels
            // UV Panel
            _responsivitySystem.AddResponsivePanel(uvTrimView_Panel,
                                                   new SResponsiveSizeState { DefaultSize = new Size(uvTrimView_Panel.Size.Width, uvTrimView_Panel.Size.Height), NewSize = new Size(480, 480) },
                                                   new SResponsiveLocationState { DefaultPoint = new Point(uvTrimView_Panel.Location.X, uvTrimView_Panel.Location.Y), NewPoint = new Point(uvTrimView_Panel.Location.X, uvTrimView_Panel.Location.Y) });
            // TrimSheet Viewer Panel
            _responsivitySystem.AddResponsivePanel(trimSheetViewerPanel,
                                                   new SResponsiveSizeState { DefaultSize = new Size(trimSheetViewerPanel.Size.Width, trimSheetViewerPanel.Size.Height), NewSize = new Size(519, 564) },
                                                   new SResponsiveLocationState { DefaultPoint = new Point(trimSheetViewerPanel.Location.X, trimSheetViewerPanel.Location.Y), NewPoint = new Point(trimSheetViewerPanel.Location.X, trimSheetViewerPanel.Location.Y) });
            // Export Texture Panel
            _responsivitySystem.AddResponsivePanel(exportTexturePanel,
                                                   new SResponsiveSizeState { DefaultSize = new Size(exportTexturePanel.Size.Width, exportTexturePanel.Size.Height), NewSize = new Size(519, 118) },
                                                   new SResponsiveLocationState { DefaultPoint = new Point(exportTexturePanel.Location.X, exportTexturePanel.Location.Y), NewPoint = new Point(exportTexturePanel.Location.X, 593) });
        }

        
        // 
        private void TrimSettings_Paint(object sender, PaintEventArgs e)
        {
            // Docking System re-drawing
            _responsivitySystem.ResponsiveSystem();
         }
    }
}
