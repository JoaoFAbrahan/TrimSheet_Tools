using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrimSheet_Tools.Controller
{
    internal class WinMain_ControlBox
    {
        // variáveis privadas globis
        private TrimSheet_Tools.View.WinMain formRef;   // Referência para WinMain

        // Método setter
        public WinMain_ControlBox(TrimSheet_Tools.View.WinMain formInput)
        {
            this.formRef = formInput;

            // Conecta os eventos do formulário aos métodos
            this.formRef.btnClose.Click += this.btnClose_Click;
            this.formRef.btnMinimize.Click += this.btnMinimize_Click;
            this.formRef.Resize += this.WinMain_Resize;
        }

        //Métodos de controle dos Eventos
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Fecha o programa
            formRef.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            // Minimiza o programa
            formRef.topPanelSeparator.Visible = false;
            formRef.WindowState = System.Windows.Forms.FormWindowState.Minimized; // Correção de bug lib bunifu
        }

        private void WinMain_Resize(object sender, EventArgs e)
        {
            // Correção de bug bunifu
            if (formRef.WindowState != FormWindowState.Minimized)
                formRef.topPanelSeparator.Visible = true;
        }
    }
}
