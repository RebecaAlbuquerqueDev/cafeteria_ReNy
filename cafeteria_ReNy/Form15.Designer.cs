namespace cafeteria_ReNy
{
    partial class Form15
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::cafeteria_ReNy.Properties.Resources.Captura_de_tela_2024_09_27_155431;
            this.pictureBox2.Location = new System.Drawing.Point(88, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 348);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Frango ",
            "Frango com Catupiry",
            "Carne Seca",
            "Camarão",
            "Calabresa com Queijo",
            "Palmito",
            "Milho com Frango",
            "Costela de Boi",
            "Espinafre com Ricota",
            "Quatro Queijos",
            "Peito de Peru com Requeijão",
            "Frango com Bacon",
            "Brócolis com bacon"});
            this.checkedListBox1.Location = new System.Drawing.Point(576, 285);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(306, 355);
            this.checkedListBox1.TabIndex = 4;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafeteria_ReNy.Properties.Resources.Captura_de_tela_2024_09_27_1425067;
            this.ClientSize = new System.Drawing.Size(1223, 795);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form15";
            this.Text = "Form15";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}