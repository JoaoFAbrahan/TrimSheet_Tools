using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimSheet_Tools.Model
{
    public struct SColorButtonStates
    {
        public Color IdleState {  get; set; }
        public Color HoverState { get; set; }
        public Color PressedState { get; set; }
        public Color DisableState { get; set; }
    }
}
