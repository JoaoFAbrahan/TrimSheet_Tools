// Struct responsible for storing element position change values ​​during the responsiveness system
using System.Drawing;

namespace TrimSheet_Tools.Model
{
    /// <summary>
    /// Struct containing two points for the two states of an element's responsiveness
    /// </summary>
    public struct SResponsiveLocationState
    {
        /// <summary>
        /// Default Point Location of the Element
        /// </summary>
        public Point DefaultPoint {  get; set; }
        /// <summary>
        /// New Point Location for the Element
        /// </summary>
        public Point NewPoint { get; set; }
    }
}
