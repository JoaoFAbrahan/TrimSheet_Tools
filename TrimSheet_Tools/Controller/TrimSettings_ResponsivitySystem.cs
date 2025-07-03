// TrimSettings Form Responsive Controller
using System.Drawing;
using TrimSheet_Tools.Model;
using TrimSheet_Tools.View;

namespace TrimSheet_Tools.Controller
{
    internal class TrimSettings_ResponsivitySystem
    {
        // Global variables
        private TrimSettings _targetTrimSettings;
        private DockPanelModel _targetDockingPanelSystem;


        public TrimSettings_ResponsivitySystem(TrimSettings trimSettingsRef, DockPanelModel dockingPanelRef)
        {
            this._targetTrimSettings = trimSettingsRef;
            this._targetDockingPanelSystem = dockingPanelRef;
        }


        // Methods
        public void ResponsiveSystem()
        {            
            // FlipFlop responsive resize
            bool isDocked = _targetDockingPanelSystem.isDocked;

            _targetTrimSettings.uvTrimView_Panel.Size = isDocked ? new Size(615, 615) : new Size(480, 480);         // UV Panel
            _targetTrimSettings.trimSheetViewerPanel.Size = isDocked ? new Size(655, 700) : new Size(519, 564);     // TrimSheet Viewer Panel
            _targetTrimSettings.exportTexturePanel.Size = isDocked ? new Size(655, 118) : new Size(519, 118);       // Export Texture Panel

            // FlipFlop responsive position
            int defaultPositionX = _targetTrimSettings.exportTexturePanel.Location.X;
            int newPositionY = isDocked ? 730 : 593;

            _targetTrimSettings.exportTexturePanel.Location = new Point(defaultPositionX, newPositionY);            
        }
    }
}
