// Model for Docking Panel System
namespace TrimSheet_Tools.Model
{
    /// <summary>
    /// Docking Panel System status controller
    /// </summary>
    public class DockPanelModel
    {
        // Global variables
        /// <summary>
        /// Docking Panel State
        /// </summary>
        public bool isDocked { get; private set; } = false;


        // Methods
        /// <summary>
        /// Change Docking States
        /// </summary>
        public void ToogleDocking()
        { isDocked = !isDocked; }
    }
}
