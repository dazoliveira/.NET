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
    public partial class frmInserirEditar : Form
    {
        int indice;

        //=========================================
        public frmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }

        //=========================================
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //=========================================
        private void frmInserirEditar_Load(object sender, EventArgs e)
        {

        }

        //=========================================
        private void ConstroiLista()
        {
            
            lista_contatos.Items.Clear();
            //adiciona lista de contatos os contatos registrados
            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                lista_contatos.Items.Add(contato.nome + " (" + contato.numero + ")");
            }

            label_qtd_registros.Text = "Registros: " + lista_contatos.Items.Count;

            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
        }

        //=========================================
        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //insere um novo registro na lista 


            //verifica se todo os campos estao preenchidos
            if (text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("Os campos não foram preenchidos.");
                return;
            }
            
            //verifica se existe registro igual
            foreach(cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                if (contato.nome == text_nome.Text && contato.numero == text_numero.Text)
                {
                    MessageBox.Show("ERRO! Contato Existente");
                    return;
                }
            }

            cl_geral.GravarUmNovoRegistro(text_nome.Text, text_numero.Text);

            //atualizar lista
            ConstroiLista();

            //limpa caixa
            text_nome.Text = "";
            text_numero.Text = "";            
            text_nome.Focus();
        }

        private void lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecionar um contato
            if (lista_contatos.SelectedIndex == -1) return;

            indice = lista_contatos.SelectedIndex;
            cmd_editar.Enabled = true;
            cmd_apagar.Enabled = true;                
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            cl_geral.LISTA_CONTATOS.RemoveAt(indice);
            cl_geral.GravarFicheiro();
            ConstroiLista();
        }

        private void cmd_editar_Click(object sender, EventArgs e)
        {

        }
    }
}
