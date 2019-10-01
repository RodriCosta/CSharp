namespace Banco
{
    partial class Banco
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
            this.textTitular = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.Deposita = new System.Windows.Forms.Button();
            this.buttonSaca = new System.Windows.Forms.Button();
            this.textSaca = new System.Windows.Forms.TextBox();
           
            this.textIndice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTitular
            // 
            this.textTitular.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textTitular.Location = new System.Drawing.Point(126, 89);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(100, 20);
            this.textTitular.TabIndex = 0;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(126, 115);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 1;
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(126, 141);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 2;
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(125, 217);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 20);
            this.textValor.TabIndex = 3;
            // 
            // Deposita
            // 
            this.Deposita.Location = new System.Drawing.Point(44, 217);
            this.Deposita.Name = "Deposita";
            this.Deposita.Size = new System.Drawing.Size(75, 23);
            this.Deposita.TabIndex = 4;
            this.Deposita.Text = "Deposita";
            this.Deposita.UseVisualStyleBackColor = true;
            this.Deposita.Click += new System.EventHandler(this.Deposita_Click);
            // 
            // buttonSaca
            // 
            this.buttonSaca.Location = new System.Drawing.Point(44, 188);
            this.buttonSaca.Name = "buttonSaca";
            this.buttonSaca.Size = new System.Drawing.Size(75, 23);
            this.buttonSaca.TabIndex = 5;
            this.buttonSaca.Text = "Saca";
            this.buttonSaca.UseVisualStyleBackColor = true;
            this.buttonSaca.Click += new System.EventHandler(this.buttonSaca_Click);
            // 
            // textSaca
            // 
            this.textSaca.Location = new System.Drawing.Point(126, 190);
            this.textSaca.Name = "textSaca";
            this.textSaca.Size = new System.Drawing.Size(100, 20);
            this.textSaca.TabIndex = 6;
            // 
            
          
            this.textIindice.Click += new System.EventHandler(this.textIndice_Click);
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Banco.Properties.Resources.the_last_of_us_part_ii_reveal_screen_03_ps4_us_10jul18;
            this.ClientSize = new System.Drawing.Size(262, 249);
            this.Controls.Add(this.textIindice);
            this.Controls.Add(this.textIindice);
            this.Controls.Add(this.textSaca);
            this.Controls.Add(this.buttonSaca);
            this.Controls.Add(this.Deposita);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.textTitular);
            this.Name = "Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Button Deposita;
        private System.Windows.Forms.Button buttonSaca;
        private System.Windows.Forms.TextBox textSaca;
        private System.Windows.Forms.TextBox textIindice;
        private System.Windows.Forms.Button textIndice;
    }
}

