// TrimSettings Form Responsive Controller
using System.Collections.Generic;
using System.Windows.Forms;
using TrimSheet_Tools.Model;

namespace TrimSheet_Tools.Controller
{
    /// <summary>
    /// Responsivity System
    /// </summary>
    internal class ResponsivitySystem
    {
        // Global variables
        private Form _targetForm;
        private DockPanelModel _targetDockingPanelSystem;
        
        // Panel
        private List<Panel> _targetPanelList = new List<Panel> ();
        private List<SResponsiveSizeState> _targetPanelSizeStateList = new List<SResponsiveSizeState>();
        private List<SResponsiveLocationState> _targetPanelLocateStateList = new List<SResponsiveLocationState> ();

        // Bunifu Panel
        private List<Bunifu.UI.WinForms.BunifuPanel> _targetBunifuPanelList = new List<Bunifu.UI.WinForms.BunifuPanel> ();
        private List<SResponsiveSizeState> _targetBunifuPanelSizeStateList = new List<SResponsiveSizeState> ();
        private List<SResponsiveLocationState> _targetBunifuPanelLocateStateList = new List<SResponsiveLocationState> ();


        public ResponsivitySystem(Form trimSettingsRef, in DockPanelModel dockingPanelRef)
        {
            // Initialize References
            this._targetForm = trimSettingsRef;
            this._targetDockingPanelSystem = dockingPanelRef;
        }


        // Methods
        /// <summary>
        /// Add the panel for responsive system
        /// </summary>
        /// <param name="panelRef">Reference to the panel</param>
        /// <param name="sizeStateRef">Size state for the panel</param>
        /// <param name="locationStateRef">Location state for the panel</param>
        public void AddResponsivePanel(Panel panelRef, SResponsiveSizeState sizeStateRef, SResponsiveLocationState locationStateRef)
        {
            _targetPanelList.Add(panelRef);
            _targetPanelSizeStateList.Add(sizeStateRef);
            _targetPanelLocateStateList.Add(locationStateRef);
        }

        /// <summary>
        /// Add the panel for responsive system
        /// </summary>
        /// <param name="panelRef">Reference to the bunifu panel</param>
        /// <param name="sizeStateRef">Size state for the panel</param>
        /// <param name="locationStateRef">Location state for the panel</param>
        public void AddResponsivePanel(Bunifu.UI.WinForms.BunifuPanel panelRef, SResponsiveSizeState sizeStateRef, SResponsiveLocationState locationStateRef)
        {
            _targetBunifuPanelList.Add(panelRef);
            _targetBunifuPanelSizeStateList.Add(sizeStateRef);
            _targetBunifuPanelLocateStateList.Add(locationStateRef);
        }

        /// <summary>
        /// Adjust based in Docked state
        /// </summary>
        public void ResponsiveSystem()
        {            
            // FlipFlop responsive resize 
            bool isDocked = _targetDockingPanelSystem.isDocked;

            // Panel List resize
            if (_targetPanelList.Count > 0)
            {
                for (int i = 0; i < _targetPanelList.Count; i++)
                {
                    _targetPanelList[i].Size = isDocked ? _targetPanelSizeStateList[i].DefaultSize : _targetPanelSizeStateList[i].NewSize;
                    _targetPanelList[i].Location = isDocked ? _targetPanelLocateStateList[i].DefaultPoint : _targetPanelLocateStateList[i].NewPoint;
                }
            }
            
            // Bunifu Panel List responsivity
            if (_targetBunifuPanelList.Count > 0)
            {
                for (int i = 0; i < _targetBunifuPanelList.Count; i++)
                {
                    _targetBunifuPanelList[i].Size = isDocked ? _targetBunifuPanelSizeStateList[i].DefaultSize : _targetBunifuPanelSizeStateList[i].NewSize;
                    _targetBunifuPanelList[i].Location = isDocked ? _targetBunifuPanelLocateStateList[i].DefaultPoint : _targetBunifuPanelLocateStateList[i].NewPoint;
                }
            }         
        }
    }
}
