namespace cafeteria_ReNy
{
    partial class Form29
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
            this.lblforma = new System.Windows.Forms.Label();
            this.cbforma = new System.Windows.Forms.ComboBox();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblforma
            // 
            this.lblforma.AutoSize = true;
            this.lblforma.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforma.Location = new System.Drawing.Point(135, 215);
            this.lblforma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblforma.Name = "lblforma";
            this.lblforma.Size = new System.Drawing.Size(203, 23);
            this.lblforma.TabIndex = 0;
            this.lblforma.Text = "forma de pagamento:";
            // 
            // cbforma
            // 
            this.cbforma.FormattingEnabled = true;
            this.cbforma.Items.AddRange(new object[] {
            "Dinheiro ",
            "Cartão de crédito",
            "Cartão de debito",
            "Pix"});
            this.cbforma.Location = new System.Drawing.Point(355, 218);
            this.cbforma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbforma.Name = "cbforma";
            this.cbforma.Size = new System.Drawing.Size(120, 21);
            this.cbforma.TabIndex = 1;
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.lblmensagem.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagem.Location = new System.Drawing.Point(271, 320);
            this.lblmensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(482, 90);
            this.lblmensagem.TabIndex = 2;
            this.lblmensagem.Text = "Seu pedido está a caminho \r\nAgradecemos a preferencia!";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(418, 271);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // Form29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafeteria_ReNy.Properties.Resources.Captura_de_tela_2024_09_27_14250610;
            this.ClientSize = new System.Drawing.Size(1051, 738);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.cbforma);
            this.Controls.Add(this.lblforma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form29";
            this.Text = "Form29";
            this.Load += new System.EventHandler(this.Form29_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblforma;
        private System.Windows.Forms.ComboBox cbforma;
        private System.Windows.Forms.Label lblmensagem;
        private System.Windows.Forms.Button btnok;
    }
}