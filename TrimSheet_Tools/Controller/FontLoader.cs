// Class used to load custom fonts from Resources into memory.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using TrimSheet_Tools.Properties;
using TrimSheet_Tools.Model;

namespace TrimSheet_Tools.Controller
{
    /// <summary>
    /// Loads custom resource sources into application memory
    /// </summary>
    internal class FontLoader
    {
        // Global Variables
        private static PrivateFontCollection _fontCollection = new PrivateFontCollection();
        private static Dictionary<ECustomFont, FontFamily> _fontLib = new Dictionary<ECustomFont, FontFamily>();


        /// <summary>
        /// Resource Initializer
        /// </summary>
        static FontLoader()
        {
            // Loads fonts from Resources
            LoadFont(Resources.MollenNarrow_Regular, ECustomFont.MollenRegular);
            LoadFont(Resources.MollenNarrow_RegularItalic, ECustomFont.MollenRegularItatic);
            LoadFont(Resources.MollenNarrow_Light,ECustomFont.MollenLight);
            LoadFont(Resources.MollenNarrow_LightItalic, ECustomFont.MollenLightItalic);
            LoadFont(Resources.MollenNarrow_Bold, ECustomFont.MollenBold);
            LoadFont(Resources.MollenNarrow_BoldItalic, ECustomFont.MollenBoldItalic);
        }


        private static void LoadFont(byte[] fontData, ECustomFont font)
        {
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            _fontCollection.AddMemoryFont(fontPtr, fontData.Length);

            if (_fontCollection.Families.Length == 0)
                throw new Exception($"The font {font} was not loaded correctly.");

            var family = _fontCollection.Families[_fontCollection.Families.Length - 1];
            _fontLib[font] = family;

            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
        }

        public static Font GetFont(ECustomFont font, float size, FontStyle style = FontStyle.Regular)
        {
            if(_fontLib.TryGetValue(font, out FontFamily family))
                return new Font(family, size, style);
            

            throw new ArgumentException($"Font not found: {font}");
        }
    }
}
