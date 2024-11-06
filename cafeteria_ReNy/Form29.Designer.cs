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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(47)))));
            this.label10.Location = new System.Drawing.Point(1769, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 31);
            this.label10.TabIndex = 40;
            this.label10.Text = "Ajuda";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(47)))));
            this.label11.Location = new System.Drawing.Point(1590, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 31);
            this.label11.TabIndex = 39;
            this.label11.Text = "Menu";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(47)))));
            this.label12.Location = new System.Drawing.Point(1416, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 31);
            this.label12.TabIndex = 38;
            this.label12.Text = "Sobre";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(47)))));
            this.label13.Location = new System.Drawing.Point(1238, -1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 31);
            this.label13.TabIndex = 37;
            this.label13.Text = "Home";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1586, 967);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 233;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1724, 968);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 232;
            this.button1.Text = "Fazer pedido";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafeteria_ReNy.Properties.Resources.Design_sem_nome__2_10;
            this.ClientSize = new System.Drawing.Size(1924, 1032);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}