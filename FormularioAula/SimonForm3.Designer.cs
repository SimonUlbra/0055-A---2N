
namespace FormularioAula
{
    partial class simonForm3
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
            this.btn_MeuPrimeiroBotao = new System.Windows.Forms.Button();
            this.lb_MasQueBah = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_MeuPrimeiroBotao
            // 
            this.btn_MeuPrimeiroBotao.BackColor = System.Drawing.Color.DarkGray;
            this.btn_MeuPrimeiroBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MeuPrimeiroBotao.ForeColor = System.Drawing.Color.Red;
            this.btn_MeuPrimeiroBotao.Location = new System.Drawing.Point(15, 33);
            this.btn_MeuPrimeiroBotao.Name = "btn_MeuPrimeiroBotao";
            this.btn_MeuPrimeiroBotao.Size = new System.Drawing.Size(132, 56);
            this.btn_MeuPrimeiroBotao.TabIndex = 0;
            this.btn_MeuPrimeiroBotao.Text = "Meu Primeiro Botão";
            this.btn_MeuPrimeiroBotao.UseVisualStyleBackColor = false;
            this.btn_MeuPrimeiroBotao.Click += new System.EventHandler(this.btn_MeuPrimeiroBotao_Click);
            // 
            // lb_MasQueBah
            // 
            this.lb_MasQueBah.AutoSize = true;
            this.lb_MasQueBah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MasQueBah.Location = new System.Drawing.Point(12, 9);
            this.lb_MasQueBah.Name = "lb_MasQueBah";
            this.lb_MasQueBah.Size = new System.Drawing.Size(120, 25);
            this.lb_MasQueBah.TabIndex = 1;
            this.lb_MasQueBah.Text = "Exemplo de";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(16, 105);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(100, 22);
            this.tb_Nome.TabIndex = 2;
            // 
            // simonForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lb_MasQueBah);
            this.Controls.Add(this.btn_MeuPrimeiroBotao);
            this.Name = "simonForm3";
            this.Text = "Ulbra - Desenvolvimento de Sistemas de Informação";
            this.Load += new System.EventHandler(this.SimonForm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MeuPrimeiroBotao;
        private System.Windows.Forms.Label lb_MasQueBah;
        private System.Windows.Forms.TextBox tb_Nome;
    }
}