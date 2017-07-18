using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmTexto : Form
    {
        public bool cancelado { get; set; }
        public string texto { get; set; }

        //=======================================    
        public frmTexto()
        {
            InitializeComponent();
        }

        //=======================================
        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        //=======================================
        private void cmd_pesquisa_Click(object sender, EventArgs e)
        {   if (text_texto.Text == "") return;
            texto = text_texto.Text;
            cancelado = false;
            this.Close();
        }

        //=======================================
        private void text_texto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                cmd_pesquisa_Click(cmd_pesquisa, EventArgs.Empty);
        }
    }
}
