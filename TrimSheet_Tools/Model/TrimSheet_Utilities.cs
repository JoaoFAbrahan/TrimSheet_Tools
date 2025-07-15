using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrimSheet_Tools.Model
{
    public static class TrimSheet_Utilities
    {
        // Methods
        /// <summary>
        /// Return a unit in ViewportUnit
        /// </summary>
        /// <param name="centimeters"></param>
        /// <param name="texResolution"></param>
        /// <param name="texelDensity"></param>
        /// <returns></returns>
        public static double ConvertUnits_CentimetersToViewport(double centimeters, int texResolution, float texelDensity)
        { return (centimeters * texelDensity) / texResolution; }

        /// <summary>
        /// Return a unit in Centimeters
        /// </summary>
        /// <param name="centimeters"></param>
        /// <param name="texResolution"></param>
        /// <param name="texelDensity"></param>
        /// <returns></returns>
        public static double ConvertUnits_ViewportToCentimeters(double centimeters, int texResolution, float texelDensity)
        { return (centimeters * texResolution) / texelDensity; }

        public static String CheckerTexelDensity(Panel panelRef)
        {
            // Check the selected Radio Button in the Panel
            String radioButtonSelected = null;

            foreach (Control ctrl in panelRef.Controls)
            {
                if (ctrl is BunifuRadioButton btn && btn.Checked)
                {
                    radioButtonSelected = btn.Tag?.ToString();
                    break;
                }
            }

            // Return the selected button value
            return radioButtonSelected;
        }
    }
}
