// Class used to set a custom font loaded in Resources for a label.
using System.Windows.Forms;
using TrimSheet_Tools.Model;

namespace TrimSheet_Tools.Controller
{
    internal class SetFontStyle
    {
        // Global variables
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _targetBunifuButton;
        private Bunifu.UI.WinForms.BunifuLabel _targetBunifuLabel;
        private Label _targetLabel;
        private ECustomFont _fontName;


        /// <summary>
        /// Apply a custom font to a Bunifu Button
        /// </summary>
        /// <param name="bunifuButtonRef">BunifuButton that receives the custom font</param>
        /// <param name="selectedFont">CustonFont to be defined</param>
        public SetFontStyle(Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonRef, ECustomFont selectedFont)
        {
            this._fontName = selectedFont;
            this._targetBunifuButton = bunifuButtonRef;

            SetFont(0);
        }

        /// <summary>
        /// Apply a custom font to a Bunifu Label
        /// </summary>
        /// <param name="bunifuLabelRef">BunifuLabel that receives the custom font</param>
        /// <param name="selectedFont">CustonFont to be defined</param>
        public SetFontStyle(Bunifu.UI.WinForms.BunifuLabel bunifuLabelRef, ECustomFont selectedFont)
        {
            this._fontName = selectedFont;
            this._targetBunifuLabel = bunifuLabelRef;

            SetFont(1);
        }

        /// <summary>
        /// Apply a custom font to a Label
        /// </summary>
        /// <param name="labelRef">Label that receives the custom font</param>
        /// <param name="selectedFont">CustonFont to be defined</param>
        public SetFontStyle(Label labelRef, ECustomFont selectedFont) 
        {
            this._fontName = selectedFont;
            this._targetLabel = labelRef;

            SetFont(2);
        }
        

        private void SetFont(int index)
        {
            switch (index)
            {
                case 0:
                    _targetBunifuButton.Font = FontLoader.GetFont(_fontName, _targetBunifuButton.Font.Size, _targetBunifuButton.Font.Style);
                    break;
                case 1:
                    _targetBunifuLabel.Font = FontLoader.GetFont(_fontName, _targetBunifuLabel.Font.Size, _targetBunifuLabel.Font.Style);
                    break;
                case 2:
                    _targetLabel.Font = FontLoader.GetFont(_fontName, _targetLabel.Font.Size, _targetLabel.Font.Style);
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
