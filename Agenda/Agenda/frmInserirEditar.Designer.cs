namespace Agenda
{
    partial class frmInserirEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_numero = new System.Windows.Forms.Label();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.lista_contatos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_qtd_registros = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(366, 346);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(106, 37);
            this.cmd_fechar.TabIndex = 3;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(94, 30);
            this.text_nome.MaxLength = 50;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(298, 20);
            this.text_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_numero
            // 
            this.label_numero.Location = new System.Drawing.Point(-12, 54);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(100, 23);
            this.label_numero.TabIndex = 7;
            this.label_numero.Text = "Número:";
            this.label_numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(94, 56);
            this.text_numero.MaxLength = 20;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(122, 20);
            this.text_numero.TabIndex = 1;
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Location = new System.Drawing.Point(110, 82);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(106, 37);
            this.cmd_gravar.TabIndex = 2;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // lista_contatos
            // 
            this.lista_contatos.FormattingEnabled = true;
            this.lista_contatos.Location = new System.Drawing.Point(39, 165);
            this.lista_contatos.Name = "lista_contatos";
            this.lista_contatos.Size = new System.Drawing.Size(433, 173);
            this.lista_contatos.TabIndex = 9;
            this.lista_contatos.SelectedIndexChanged += new System.EventHandler(this.lista_contatos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de contatos registrados:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_qtd_registros
            // 
            this.label_qtd_registros.Location = new System.Drawing.Point(36, 346);
            this.label_qtd_registros.Name = "label_qtd_registros";
            this.label_qtd_registros.Size = new System.Drawing.Size(100, 23);
            this.label_qtd_registros.TabIndex = 10;
            this.label_qtd_registros.Text = "Registros: 0";
            this.label_qtd_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(254, 346);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(106, 37);
            this.cmd_apagar.TabIndex = 4;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Location = new System.Drawing.Point(142, 346);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(106, 37);
            this.cmd_editar.TabIndex = 5;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // frmInserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 395);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_qtd_registros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lista_contatos);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA - INSERIR /EDITAR";
            this.Load += new System.EventHandler(this.frmInserirEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.ListBox lista_contatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_qtd_registros;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
    }
}