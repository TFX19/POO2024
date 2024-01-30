namespace ProjetoPraticoPOO2023
{
    partial class FormGPassageiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGPassageiro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passageiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarBilhetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarBilhetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voosPorRotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.operaçõesToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passageiroToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // passageiroToolStripMenuItem
            // 
            this.passageiroToolStripMenuItem.Name = "passageiroToolStripMenuItem";
            this.passageiroToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.passageiroToolStripMenuItem.Text = "Passageiro";
            this.passageiroToolStripMenuItem.Click += new System.EventHandler(this.passageiroToolStripMenuItem_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarBilhetesToolStripMenuItem,
            this.cancelarBilhetesToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // comprarBilhetesToolStripMenuItem
            // 
            this.comprarBilhetesToolStripMenuItem.Name = "comprarBilhetesToolStripMenuItem";
            this.comprarBilhetesToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.comprarBilhetesToolStripMenuItem.Text = "ComprarBilhetes";
            this.comprarBilhetesToolStripMenuItem.Click += new System.EventHandler(this.comprarBilhetesToolStripMenuItem_Click);
            // 
            // cancelarBilhetesToolStripMenuItem
            // 
            this.cancelarBilhetesToolStripMenuItem.Name = "cancelarBilhetesToolStripMenuItem";
            this.cancelarBilhetesToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.cancelarBilhetesToolStripMenuItem.Text = "CancelarBilhetes";
            this.cancelarBilhetesToolStripMenuItem.Click += new System.EventHandler(this.cancelarBilhetesToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotasToolStripMenuItem,
            this.voosPorRotasToolStripMenuItem,
            this.voosRealizadosToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // rotasToolStripMenuItem
            // 
            this.rotasToolStripMenuItem.Name = "rotasToolStripMenuItem";
            this.rotasToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.rotasToolStripMenuItem.Text = "Rotas";
            this.rotasToolStripMenuItem.Click += new System.EventHandler(this.rotasToolStripMenuItem_Click);
            // 
            // voosPorRotasToolStripMenuItem
            // 
            this.voosPorRotasToolStripMenuItem.Name = "voosPorRotasToolStripMenuItem";
            this.voosPorRotasToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.voosPorRotasToolStripMenuItem.Text = "Voos por Rotas";
            this.voosPorRotasToolStripMenuItem.Click += new System.EventHandler(this.voosPorRotasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // voosRealizadosToolStripMenuItem
            // 
            this.voosRealizadosToolStripMenuItem.Name = "voosRealizadosToolStripMenuItem";
            this.voosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.voosRealizadosToolStripMenuItem.Text = "Voos Realizados";
            this.voosRealizadosToolStripMenuItem.Click += new System.EventHandler(this.voosRealizadosToolStripMenuItem_Click);
            // 
            // FormGPassageiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGPassageiro";
            this.Text = "FormGPassageiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGPassageiro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passageiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarBilhetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voosPorRotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarBilhetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voosRealizadosToolStripMenuItem;
    }
}