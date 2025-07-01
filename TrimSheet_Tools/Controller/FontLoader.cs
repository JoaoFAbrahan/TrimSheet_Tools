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
        private static PrivateFontCollection fontCollection = new PrivateFontCollection();
        private static Dictionary<CustomFont, FontFamily> fontLib = new Dictionary<CustomFont, FontFamily>();


        /// <summary>
        /// Resource Initializer
        /// </summary>
        static FontLoader()
        {
            // Loads fonts from Resources
            LoadFont(Resources.MollenNarrow_Regular, CustomFont.MollenRegular);
            LoadFont(Resources.MollenNarrow_RegularItalic, CustomFont.MollenRegularItatic);
            LoadFont(Resources.MollenNarrow_Light,CustomFont.MollenLight);
            LoadFont(Resources.MollenNarrow_LightItalic, CustomFont.MollenLightItalic);
            LoadFont(Resources.MollenNarrow_Bold, CustomFont.MollenBold);
            LoadFont(Resources.MollenNarrow_BoldItalic, CustomFont.MollenBoldItalic);
        }


        private static void LoadFont(byte[] fontData, CustomFont font)
        {
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            fontCollection.AddMemoryFont(fontPtr, fontData.Length);
            FontFamily family = fontCollection.Families[fontCollection.Families.Length - 1];

            fontLib[font] = family;

            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
        }

        public static Font GetFont(CustomFont font, float size, FontStyle style = FontStyle.Regular)
        {
            if(fontLib.TryGetValue(font, out FontFamily family))
                return new Font(family, size, style);
            

            throw new ArgumentException($"Fonte não encontrada: {font}");
        }
    }
}
