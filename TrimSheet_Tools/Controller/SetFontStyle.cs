// Classe utilizada para setar uma fonte customizada carregada no Resources para uma label.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;
using TrimSheet_Tools.Model;

namespace TrimSheet_Tools.Controller
{
    internal class SetFontStyle
    {
        // variáveis privadas globais
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton targetBunifuButton;
        private Bunifu.UI.WinForms.BunifuLabel targetBunifuLabel;
        private Label targetLabel;
        private CustomFont fontName;

        /// <summary>
        /// Aplica uma fonte customizada em um Bunifu Button
        /// </summary>
        /// <param name="bunifuButtonRef">BunifuButton que recebe a custom font</param>
        /// <param name="selectedFont">CustonFont a ser definida</param>
        public SetFontStyle(Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonRef, CustomFont selectedFont)
        {
            this.fontName = selectedFont;
            this.targetBunifuButton = bunifuButtonRef;

            SetFont(0);
        }

        /// <summary>
        /// Aplica uma fonte customizada em uma Bunifu Label
        /// </summary>
        /// <param name="bunifuLabelRef">BunifuLabel que recebe a custom font</param>
        /// <param name="selectedFont">CustonFont a ser definida</param>
        public SetFontStyle(Bunifu.UI.WinForms.BunifuLabel bunifuLabelRef, CustomFont selectedFont)
        {
            this.fontName = selectedFont;
            this.targetBunifuLabel = bunifuLabelRef;

            SetFont(1);
        }

        /// <summary>
        /// Aplica uma fonte customizada em uma Label
        /// </summary>
        /// <param name="labelRef">Label que recebe a custom font</param>
        /// <param name="selectedFont">CustonFont a ser definida</param>
        public SetFontStyle(Label labelRef, CustomFont selectedFont) 
        {
            this.fontName = selectedFont;
            this.targetLabel = labelRef;

            SetFont(2);
        }
        

        private void SetFont(int index)
        {
            switch (index)
            {
                case 0:
                    targetBunifuButton.Font = FontLoader.GetFont(fontName, targetBunifuButton.Font.Size, targetBunifuButton.Font.Style);
                    break;
                case 1:
                    targetBunifuLabel.Font = FontLoader.GetFont(fontName, targetBunifuLabel.Font.Size, targetBunifuLabel.Font.Style);
                    break;
                case 2:
                    targetLabel.Font = FontLoader.GetFont(fontName, targetLabel.Font.Size, targetLabel.Font.Style);
                    break;
                default:
                    MessageBox.Show($"Erro: índice de destino inválido ({index}). Nenhum controle foi encontrado para aplicar a fonte.",
                        "Erro de aplicação de fonte",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
