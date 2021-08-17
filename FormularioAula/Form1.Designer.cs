
namespace FormularioAula
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
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbLista = new System.Windows.Forms.TextBox();
            this.lbSaida = new System.Windows.Forms.Label();
            this.btCopiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(397, 28);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(90, 37);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(53, 37);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(338, 20);
            this.tbNome.TabIndex = 2;
            // 
            // tbLista
            // 
            this.tbLista.Location = new System.Drawing.Point(57, 95);
            this.tbLista.Multiline = true;
            this.tbLista.Name = "tbLista";
            this.tbLista.Size = new System.Drawing.Size(334, 132);
            this.tbLista.TabIndex = 3;
            // 
            // lbSaida
            // 
            this.lbSaida.AutoSize = true;
            this.lbSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSaida.ForeColor = System.Drawing.Color.Red;
            this.lbSaida.Location = new System.Drawing.Point(57, 241);
            this.lbSaida.Name = "lbSaida";
            this.lbSaida.Size = new System.Drawing.Size(110, 15);
            this.lbSaida.TabIndex = 4;
            this.lbSaida.Text = "Lista de Informações:";
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(397, 205);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(84, 22);
            this.btCopiar.TabIndex = 5;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de Nomes";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(403, 282);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 7;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 321);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.lbSaida);
            this.Controls.Add(this.tbLista);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOk);
            this.Name = "Form1";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbLista;
        private System.Windows.Forms.Label lbSaida;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLimpar;
    }
}

