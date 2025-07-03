// Interface for Docking Panel System
namespace TrimSheet_Tools.View
{
    /// <summary>
    /// Form element (Panel and Transition) containing the Docking Panel System
    /// </summary>
    public interface IDockPanelView
    {
        void SetPanelSize(int width, int height);
        void AnimatePanel();
    }
}
