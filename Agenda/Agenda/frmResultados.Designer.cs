namespace Agenda
{
    partial class frmResultados
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
            this.cmd_pesquisa = new System.Windows.Forms.Button();
            this.lista_final = new System.Windows.Forms.ListBox();
            this.label_registros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(323, 199);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(107, 39);
            this.cmd_fechar.TabIndex = 0;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // cmd_pesquisa
            // 
            this.cmd_pesquisa.Location = new System.Drawing.Point(209, 199);
            this.cmd_pesquisa.Name = "cmd_pesquisa";
            this.cmd_pesquisa.Size = new System.Drawing.Size(108, 39);
            this.cmd_pesquisa.TabIndex = 1;
            this.cmd_pesquisa.Text = "Nova pesquisa...";
            this.cmd_pesquisa.UseVisualStyleBackColor = true;
            this.cmd_pesquisa.Click += new System.EventHandler(this.cmd_pesquisa_Click);
            // 
            // lista_final
            // 
            this.lista_final.FormattingEnabled = true;
            this.lista_final.Location = new System.Drawing.Point(12, 12);
            this.lista_final.Name = "lista_final";
            this.lista_final.Size = new System.Drawing.Size(418, 173);
            this.lista_final.TabIndex = 2;
            // 
            // label_registros
            // 
            this.label_registros.AutoSize = true;
            this.label_registros.Location = new System.Drawing.Point(9, 199);
            this.label_registros.Name = "label_registros";
            this.label_registros.Size = new System.Drawing.Size(63, 13);
            this.label_registros.TabIndex = 3;
            this.label_registros.Text = "Registros: 0";
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 250);
            this.ControlBox = false;
            this.Controls.Add(this.label_registros);
            this.Controls.Add(this.lista_final);
            this.Controls.Add(this.cmd_pesquisa);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTADOS";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Button cmd_pesquisa;
        private System.Windows.Forms.ListBox lista_final;
        private System.Windows.Forms.Label label_registros;
    }
}