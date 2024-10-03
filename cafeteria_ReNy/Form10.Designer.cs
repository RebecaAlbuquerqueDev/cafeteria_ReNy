namespace cafeteria_ReNy
{
    partial class Form10
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
            this.listBoxCarrinho = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxCarrinho
            // 
            this.listBoxCarrinho.FormattingEnabled = true;
            this.listBoxCarrinho.Location = new System.Drawing.Point(43, 127);
            this.listBoxCarrinho.Name = "listBoxCarrinho";
            this.listBoxCarrinho.Size = new System.Drawing.Size(120, 381);
            this.listBoxCarrinho.TabIndex = 0;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafeteria_ReNy.Properties.Resources.Captura_de_tela_2024_09_27_1425062;
            this.ClientSize = new System.Drawing.Size(1223, 796);
            this.Controls.Add(this.listBoxCarrinho);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCarrinho;
    }
}