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
    public partial class frm_agenda : Form
    {
        //=========================================
        public frm_agenda()
        {
            InitializeComponent();

            //carrega contatos
             cl_geral.ControiListaDeContatos();

            label_versao.Text = cl_geral.versao;
        }

        //=========================================
        private void frm_agenda_Load(object sender, EventArgs e)
        {

        }

        //=========================================
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação ?", "SAIR", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }

        //=========================================
        private void cmd_inserir_editar_Click(object sender, EventArgs e)
        {
            frmInserirEditar formulario = new frmInserirEditar();
            formulario.ShowDialog();
        }
        
        //=========================================
        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            frmTexto pesquisa = new frmTexto();
            pesquisa.ShowDialog();

            if (pesquisa.cancelado) return;

            //abrir quadro com pesquisa
            frmResultados ff = new frmResultados(pesquisa.texto);
            ff.ShowDialog();


        }
    }
}
