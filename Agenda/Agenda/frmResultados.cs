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
    public partial class frmResultados : Form
    {
        string texto;

        //=======================================
        public frmResultados(string texto)
        {
            InitializeComponent();

            this.texto = texto.ToUpper();
        }

        //=======================================
        private void frmResultados_Load(object sender, EventArgs e)
        {
            ExecutaPesquisa();
        }

        //=======================================
        private void ExecutaPesquisa()
        {
            List<cl_contato> lista_resultados = new List<cl_contato>();

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS) {

                if(contato.nome.ToUpper().Contains(texto)||
                    contato.numero.ToUpper().Contains(texto))
                {
                    lista_resultados.Add(contato);
                }
            } 

            lista_final.Items.Clear();
            foreach (cl_contato contato in lista_resultados)
            {
                lista_final.Items.Add(contato.nome +"("+contato.numero+")");
                label_registros.Text = "Registros: " + lista_final.Items.Count;
            }
        }

        //=======================================
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //=======================================
        private void cmd_pesquisa_Click(object sender, EventArgs e)
        {
            frmTexto f = new frmTexto();
            f.ShowDialog();

            if (f.cancelado) return;

            texto = f.texto.ToUpper();
            ExecutaPesquisa();
        }
    }
}
