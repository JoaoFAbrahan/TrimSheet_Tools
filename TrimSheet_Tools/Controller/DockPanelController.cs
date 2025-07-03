// Class containing the implementtion for Docking Panel System
using TrimSheet_Tools.Model;
using TrimSheet_Tools.View;

namespace TrimSheet_Tools.Controller
{
    /// <summary>
    /// Docking Panel System Controller
    /// </summary>
    public class DockPanelController
    {
        // Global variables
        private readonly DockPanelModel _targetDockModel;
        private readonly IDockPanelView _targetDockView;
        private readonly int _dockedWidth, _dockedHeight;
        private readonly int _defaultWidth, _defaultHeight;


        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="modelRef">Reference to State Controller for change state</param>
        /// <param name="viewRef">Reference to Form for Panel and Transition</param>
        /// <param name="defaultWidthRef">Panel Width in Undocked State</param>
        /// <param name="defaultHeightRef">Panel Height in Undocked State</param>
        /// <param name="dockedWidthRef">Panel Width in Docked State</param>
        /// <param name="dockedHeightRef">Panel Height in Docked State</param>
        public DockPanelController( DockPanelModel modelRef, 
                                    IDockPanelView viewRef,
                                    int defaultWidthRef,
                                    int defaultHeightRef, 
                                    int dockedWidthRef,
                                    int dockedHeightRef )
        {
            // Get Reference
            this._targetDockModel = modelRef;
            this._targetDockView = viewRef;
            this._defaultWidth = defaultWidthRef;
            this._defaultHeight = defaultHeightRef;
            this._dockedWidth = dockedWidthRef;
            this._dockedHeight = dockedHeightRef;
        }


        public void ToggleDocking()
        {
            _targetDockModel.ToogleDocking();    // Change State
            _targetDockView.AnimatePanel();      // Animation Controller

            // Docking FlipFlop controller
            if (_targetDockModel.isDocked)
                _targetDockView.SetPanelSize(_dockedWidth, _dockedHeight);
            else
                _targetDockView.SetPanelSize(_defaultWidth, _defaultHeight);
        }
    }
}
