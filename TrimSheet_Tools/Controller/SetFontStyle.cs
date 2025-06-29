// Class used to set a custom font loaded in Resources for a label.
using System.Windows.Forms;
using TrimSheet_Tools.Model;

namespace TrimSheet_Tools.Controller
{
    internal class SetFontStyle
    {
        // Global variables
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton targetBunifuButton;
        private Bunifu.UI.WinForms.BunifuLabel targetBunifuLabel;
        private Label targetLabel;
        private CustomFont fontName;

        /// <summary>
        /// Apply a custom font to a Bunifu Button
        /// </summary>
        /// <param name="bunifuButtonRef">BunifuButton that receives the custom font</param>
        /// <param name="selectedFont">CustonFont to be defined</param>
        public SetFontStyle(Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonRef, CustomFont selectedFont)
        {
            this.fontName = selectedFont;
            this.targetBunifuButton = bunifuButtonRef;

            SetFont(0);
        }

        /// <summary>
        /// Apply a custom font to a Bunifu Label
        /// </summary>
        /// <param name="bunifuLabelRef">BunifuLabel that receives the custom font</param>
        /// <param name="selectedFont">CustonFont to be defined</param>
        public SetFontStyle(Bunifu.UI.WinForms.BunifuLabel bunifuLabelRef, CustomFont selectedFont)
        {
            this.fontName = selectedFont;
            this.targetBunifuLabel = bunifuLabelRef;

            SetFont(1);
        }

        /// <summary>
        /// Apply a custom font to a Label
        /// </summary>
        /// <param name="labelRef">Label that receives the custom font</param>
        /// <param name="selectedFont">CustonFont to be defined</param>
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
