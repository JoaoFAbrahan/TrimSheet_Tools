//Struct responsible for storing element size change values ​​during the responsiveness system
using System.Drawing;

namespace TrimSheet_Tools.Model
{
    /// <summary>
    /// Struct containing two sizes for the two states of an element's responsiveness
    /// </summary>
    public struct SResponsiveSizeState
    {
        /// <summary>
        /// Default Size of the Element
        /// </summary>
        public Size DefaultSize {  get; set; }
        /// <summary>
        /// New Size of the Element
        /// </summary>
        public Size NewSize { get; set; }
    }
}
