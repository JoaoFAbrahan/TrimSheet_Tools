using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrimSheet_Tools.View;

namespace TrimSheet_Tools.Controller
{
    internal class TrimSettings_ResponsivitySystem
    {
        // Global variables
        private TrimSettings targetTrimSettings;
        private DockPanel targetDockingPanelSystem;


        public TrimSettings_ResponsivitySystem(TrimSettings trimSettingsRef, DockPanel dockingPanelRef)
        {
            this.targetTrimSettings = trimSettingsRef;
            this.targetDockingPanelSystem = dockingPanelRef;
        }


        // Methods
        public void ResponsiveSystem()
        {
            // Docking System re-drawing
            if (targetDockingPanelSystem.GetDockingStatus())
            {
                targetTrimSettings.uvTrimView_Panel.Size = new Size(615, 615);
                targetTrimSettings.trimSheetViewerPanel.Height = 700;
                targetTrimSettings.exportTexturePanel.Location = new Point(targetTrimSettings.exportTexturePanel.Location.X, 730);
            }
            else
            {
                targetTrimSettings.uvTrimView_Panel.Size = new Size(480, 480);
                targetTrimSettings.trimSheetViewerPanel.Height = 564;
                targetTrimSettings.exportTexturePanel.Location = new Point(targetTrimSettings.exportTexturePanel.Location.X, 593);
            }
        }
    }
}
