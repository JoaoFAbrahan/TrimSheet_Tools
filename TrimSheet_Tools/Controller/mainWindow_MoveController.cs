using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrimSheet_Tools.Controller
{
    public class mainWindow_MoveController
    {
        // variáveis privadas
        private TrimSheet_Tools.View.WinMain formRef;   // Referência para WinMain
        private bool togMove;
        private int moveX;
        private int moveY;

        // Método setter
        public mainWindow_MoveController(TrimSheet_Tools.View.WinMain formInput)
        {  
            this.formRef = formInput;

            // Conecta os eventos do formulário aos métodos
            this.formRef.topPanel.MouseDown += topPanel_MouseDown;
            this.formRef.topPanel.MouseUp += topPanel_MouseUp;
            this.formRef.topPanel.MouseMove += topPanel_MouseMove;
        }

        // Métodos de manipulação
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = true;
            moveX = e.X;
            moveY = e.Y;
        }
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = false;
        }
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove)
                formRef.SetDesktopLocation(Cursor.Position.X - moveX, Cursor.Position.Y - moveY);
        }
    }
}
