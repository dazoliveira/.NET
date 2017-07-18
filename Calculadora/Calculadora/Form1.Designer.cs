namespace Calculadora
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.text_operacao = new System.Windows.Forms.TextBox();
            this.label_algoritmo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.Location = new System.Drawing.Point(140, 68);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(75, 23);
            this.cmd_calcular.TabIndex = 1;
            this.cmd_calcular.Text = "Calcular";
            this.cmd_calcular.UseVisualStyleBackColor = true;
            this.cmd_calcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_operacao
            // 
            this.text_operacao.Location = new System.Drawing.Point(59, 42);
            this.text_operacao.MaxLength = 30;
            this.text_operacao.Name = "text_operacao";
            this.text_operacao.Size = new System.Drawing.Size(156, 20);
            this.text_operacao.TabIndex = 0;
            this.text_operacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_operacao_KeyDown);
            // 
            // label_algoritmo
            // 
            this.label_algoritmo.AutoSize = true;
            this.label_algoritmo.Location = new System.Drawing.Point(56, 26);
            this.label_algoritmo.Name = "label_algoritmo";
            this.label_algoritmo.Size = new System.Drawing.Size(104, 13);
            this.label_algoritmo.TabIndex = 3;
            this.label_algoritmo.Text = " Escreva o Algoritmo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 125);
            this.Controls.Add(this.label_algoritmo);
            this.Controls.Add(this.text_operacao);
            this.Controls.Add(this.cmd_calcular);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Calculadora 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.TextBox text_operacao;
        private System.Windows.Forms.Label label_algoritmo;
    }
}

