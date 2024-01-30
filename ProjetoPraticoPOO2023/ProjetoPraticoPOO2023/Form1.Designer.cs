namespace ProjetoPraticoPOO2023
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_Passageiros = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_admin.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(514, 290);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(164, 58);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "Administração";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_Passageiros
            // 
            this.btn_Passageiros.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Passageiros.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Passageiros.Location = new System.Drawing.Point(99, 290);
            this.btn_Passageiros.Name = "btn_Passageiros";
            this.btn_Passageiros.Size = new System.Drawing.Size(164, 58);
            this.btn_Passageiros.TabIndex = 2;
            this.btn_Passageiros.Text = "Passageiros";
            this.btn_Passageiros.UseVisualStyleBackColor = false;
            this.btn_Passageiros.Click += new System.EventHandler(this.btn_Passageiros_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Image = global::ProjetoPraticoPOO2023.Properties.Resources.x1;
            this.btn_Close.Location = new System.Drawing.Point(744, 25);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(32, 32);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Close.TabIndex = 3;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(145, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestão e Venda de bilhetes";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoPraticoPOO2023.Properties.Resources.wp_airport;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Passageiros);
            this.Controls.Add(this.btn_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_Passageiros;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Label label1;
    }
}

