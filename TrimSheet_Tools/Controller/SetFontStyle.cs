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
        private Bunifu.UI.WinForms.BunifuDataGridView _targetDataGridView;
        private Label _targetLabel;
        private ECustomFont _fontName;
        private ECustomFont _fontName2;


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

        /// <summary>
        /// Apply a custom font to a DataGridView
        /// </summary>
        /// <param name="dataGridViewRef">DataGridView that receives the custom font</param>
        /// <param name="headerCellFont">CustonFont to be defined in Header</param>
        /// <param name="rowsCellFont">CustonFont to be defined in Rows</param>
        public SetFontStyle(Bunifu.UI.WinForms.BunifuDataGridView dataGridViewRef, ECustomFont headerCellFont, ECustomFont rowsCellFont)
        {
            this._fontName = headerCellFont;
            this._fontName2 = rowsCellFont;
            this._targetDataGridView = dataGridViewRef;
            SetFont(3);
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
                case 3:
                    _targetDataGridView.ColumnHeadersDefaultCellStyle.Font = FontLoader.GetFont(_fontName, _targetDataGridView.ColumnHeadersDefaultCellStyle.Font.Size, _targetDataGridView.ColumnHeadersDefaultCellStyle.Font.Style);
                    _targetDataGridView.DefaultCellStyle.Font = FontLoader.GetFont(_fontName2, _targetDataGridView.DefaultCellStyle.Font.Size, _targetDataGridView.DefaultCellStyle.Font.Style);
                    break;
                default:
                    MessageBox.Show($"Error: Invalid target index ({index}). No control was found to apply the font.", 
                                    "Font application error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
