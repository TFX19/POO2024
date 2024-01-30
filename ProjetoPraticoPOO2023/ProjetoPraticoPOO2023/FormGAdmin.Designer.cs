namespace ProjetoPraticoPOO2023
{
    partial class FormGAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirRotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirVoosNumaRotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voosPorRotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passageirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirRotasToolStripMenuItem,
            this.inserirVoosNumaRotaToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // inserirRotasToolStripMenuItem
            // 
            this.inserirRotasToolStripMenuItem.Name = "inserirRotasToolStripMenuItem";
            this.inserirRotasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.inserirRotasToolStripMenuItem.Text = "Inserir Rotas";
            this.inserirRotasToolStripMenuItem.Click += new System.EventHandler(this.inserirRotasToolStripMenuItem_Click);
            // 
            // inserirVoosNumaRotaToolStripMenuItem
            // 
            this.inserirVoosNumaRotaToolStripMenuItem.Name = "inserirVoosNumaRotaToolStripMenuItem";
            this.inserirVoosNumaRotaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.inserirVoosNumaRotaToolStripMenuItem.Text = "Inserir Voos numa Rota";
            this.inserirVoosNumaRotaToolStripMenuItem.Click += new System.EventHandler(this.inserirVoosNumaRotaToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotasToolStripMenuItem,
            this.voosPorRotasToolStripMenuItem,
            this.passageirosToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // rotasToolStripMenuItem
            // 
            this.rotasToolStripMenuItem.Name = "rotasToolStripMenuItem";
            this.rotasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.rotasToolStripMenuItem.Text = "Rotas";
            this.rotasToolStripMenuItem.Click += new System.EventHandler(this.rotasToolStripMenuItem_Click);
            // 
            // voosPorRotasToolStripMenuItem
            // 
            this.voosPorRotasToolStripMenuItem.Name = "voosPorRotasToolStripMenuItem";
            this.voosPorRotasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.voosPorRotasToolStripMenuItem.Text = "Voos por Rotas";
            this.voosPorRotasToolStripMenuItem.Click += new System.EventHandler(this.voosPorRotasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // passageirosToolStripMenuItem
            // 
            this.passageirosToolStripMenuItem.Name = "passageirosToolStripMenuItem";
            this.passageirosToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.passageirosToolStripMenuItem.Text = "Passageiros efetivos de um voo";
            this.passageirosToolStripMenuItem.Click += new System.EventHandler(this.passageirosToolStripMenuItem_Click);
            // 
            // FormGAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGAdmin";
            this.Text = "FormGAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirRotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirVoosNumaRotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voosPorRotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passageirosToolStripMenuItem;
    }
}