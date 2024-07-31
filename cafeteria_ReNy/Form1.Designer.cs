namespace cafeteria_ReNy
{
    partial class cafeteria
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encomendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitóricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bnt_login = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.group_login = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            this.group_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.encomendaToolStripMenuItem,
            this.hitóricoToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(847, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clToolStripMenuItem,
            this.funcionárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cadastroToolStripMenuItem.Text = "cadastro";
            // 
            // clToolStripMenuItem
            // 
            this.clToolStripMenuItem.Name = "clToolStripMenuItem";
            this.clToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.clToolStripMenuItem.Text = "cliente";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.funcionárioToolStripMenuItem.Text = "funcionário";
            // 
            // encomendaToolStripMenuItem
            // 
            this.encomendaToolStripMenuItem.Name = "encomendaToolStripMenuItem";
            this.encomendaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.encomendaToolStripMenuItem.Text = "encomenda";
            // 
            // hitóricoToolStripMenuItem
            // 
            this.hitóricoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem});
            this.hitóricoToolStripMenuItem.Name = "hitóricoToolStripMenuItem";
            this.hitóricoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.hitóricoToolStripMenuItem.Text = "hitórico";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pedidosToolStripMenuItem.Text = "pedidos";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fotoToolStripMenuItem,
            this.nomeDeUsuárioToolStripMenuItem,
            this.endereçoToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "perfil";
            // 
            // fotoToolStripMenuItem
            // 
            this.fotoToolStripMenuItem.Name = "fotoToolStripMenuItem";
            this.fotoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.fotoToolStripMenuItem.Text = "foto";
            // 
            // nomeDeUsuárioToolStripMenuItem
            // 
            this.nomeDeUsuárioToolStripMenuItem.Name = "nomeDeUsuárioToolStripMenuItem";
            this.nomeDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nomeDeUsuárioToolStripMenuItem.Text = "nome de usuário";
            // 
            // endereçoToolStripMenuItem
            // 
            this.endereçoToolStripMenuItem.Name = "endereçoToolStripMenuItem";
            this.endereçoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.endereçoToolStripMenuItem.Text = "endereço";
            // 
            // bnt_login
            // 
            this.bnt_login.BackColor = System.Drawing.Color.RosyBrown;
            this.bnt_login.ForeColor = System.Drawing.Color.Black;
            this.bnt_login.Location = new System.Drawing.Point(56, 33);
            this.bnt_login.Name = "bnt_login";
            this.bnt_login.Size = new System.Drawing.Size(75, 23);
            this.bnt_login.TabIndex = 8;
            this.bnt_login.Text = "login";
            this.bnt_login.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // group_login
            // 
            this.group_login.BackColor = System.Drawing.Color.RosyBrown;
            this.group_login.Controls.Add(this.button3);
            this.group_login.Controls.Add(this.bnt_login);
            this.group_login.ForeColor = System.Drawing.Color.Black;
            this.group_login.Location = new System.Drawing.Point(215, 314);
            this.group_login.Name = "group_login";
            this.group_login.Size = new System.Drawing.Size(200, 100);
            this.group_login.TabIndex = 10;
            this.group_login.TabStop = false;
            this.group_login.Text = "Já tem uma conta ?";
            // 
            // cafeteria
            // 
            this.ClientSize = new System.Drawing.Size(847, 573);
            this.Controls.Add(this.group_login);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "cafeteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.group_login.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encomendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hitóricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endereçoToolStripMenuItem;
        private System.Windows.Forms.Button bnt_login;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox group_login;
    }
}

