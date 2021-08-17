
namespace FormularioAula
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tbLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbLista
            // 
            this.tbLista.Location = new System.Drawing.Point(67, 46);
            this.tbLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLista.Multiline = true;
            this.tbLista.Name = "tbLista";
            this.tbLista.Size = new System.Drawing.Size(577, 182);
            this.tbLista.TabIndex = 0;
            this.tbLista.Text = resources.GetString("tbLista.Text");
            this.tbLista.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 473);
            this.Controls.Add(this.tbLista);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Trabalho de Pesquisa";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLista;
    }
}