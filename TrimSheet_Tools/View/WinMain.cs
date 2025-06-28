using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrimSheet_Tools.Controller;

namespace TrimSheet_Tools.View
{
    public partial class WinMain : Form
    {
        private mainWindow_MoveController movementController;

        public WinMain()
        {
            InitializeComponent();

            // Sistema de movimentação movimentação da janela
            movementController = new mainWindow_MoveController(this);
    }
    }
}
