namespace ProjetoMVC35
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCpfC30 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaeC30 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeC30 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCpfC30
            // 
            this.txtCpfC30.Font = new System.Drawing.Font("Yu Gothic", 10.25F);
            this.txtCpfC30.Location = new System.Drawing.Point(280, 108);
            this.txtCpfC30.Name = "txtCpfC30";
            this.txtCpfC30.Size = new System.Drawing.Size(243, 29);
            this.txtCpfC30.TabIndex = 14;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Green;
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviar.Location = new System.Drawing.Point(349, 313);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(112, 51);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.25F);
            this.label3.Location = new System.Drawing.Point(277, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome da mãe:";
            // 
            // txtMaeC30
            // 
            this.txtMaeC30.Font = new System.Drawing.Font("Yu Gothic", 10.25F);
            this.txtMaeC30.Location = new System.Drawing.Point(280, 249);
            this.txtMaeC30.Name = "txtMaeC30";
            this.txtMaeC30.Size = new System.Drawing.Size(243, 29);
            this.txtMaeC30.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.25F);
            this.label2.Location = new System.Drawing.Point(277, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome completo:";
            // 
            // txtNomeC30
            // 
            this.txtNomeC30.Font = new System.Drawing.Font("Yu Gothic", 10.25F);
            this.txtNomeC30.Location = new System.Drawing.Point(280, 182);
            this.txtNomeC30.Name = "txtNomeC30";
            this.txtNomeC30.Size = new System.Drawing.Size(243, 29);
            this.txtNomeC30.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.25F);
            this.label1.Location = new System.Drawing.Point(277, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCpfC30);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaeC30);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeC30);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpfC30;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaeC30;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeC30;
        private System.Windows.Forms.Label label1;
    }
}

