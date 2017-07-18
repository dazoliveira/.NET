namespace Agenda
{
    partial class frmTexto
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_texto = new System.Windows.Forms.TextBox();
            this.cmd_pesquisa = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Termo de Pesquisa:";
            // 
            // text_texto
            // 
            this.text_texto.Location = new System.Drawing.Point(21, 37);
            this.text_texto.MaxLength = 30;
            this.text_texto.Name = "text_texto";
            this.text_texto.Size = new System.Drawing.Size(194, 20);
            this.text_texto.TabIndex = 0;
            this.text_texto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_texto_KeyDown);
            // 
            // cmd_pesquisa
            // 
            this.cmd_pesquisa.Location = new System.Drawing.Point(121, 63);
            this.cmd_pesquisa.Name = "cmd_pesquisa";
            this.cmd_pesquisa.Size = new System.Drawing.Size(94, 30);
            this.cmd_pesquisa.TabIndex = 1;
            this.cmd_pesquisa.Text = "Pesquisa";
            this.cmd_pesquisa.UseVisualStyleBackColor = true;
            this.cmd_pesquisa.Click += new System.EventHandler(this.cmd_pesquisa_Click);
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(21, 63);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(94, 30);
            this.cmd_cancelar.TabIndex = 2;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // frmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 109);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_pesquisa);
            this.Controls.Add(this.text_texto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_texto;
        private System.Windows.Forms.Button cmd_pesquisa;
        private System.Windows.Forms.Button cmd_cancelar;
    }
}