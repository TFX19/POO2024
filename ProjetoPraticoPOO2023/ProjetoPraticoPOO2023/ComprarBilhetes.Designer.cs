﻿namespace ProjetoPraticoPOO2023
{
    partial class ComprarBilhetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprarBilhetes));
            this.comboBoxPassageiro = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lhora = new System.Windows.Forms.Label();
            this.CB_hora = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPassageiro
            // 
            this.comboBoxPassageiro.FormattingEnabled = true;
            this.comboBoxPassageiro.Location = new System.Drawing.Point(39, 169);
            this.comboBoxPassageiro.Name = "comboBoxPassageiro";
            this.comboBoxPassageiro.Size = new System.Drawing.Size(237, 30);
            this.comboBoxPassageiro.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 30);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(39, 371);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(237, 38);
            this.btn_comprar.TabIndex = 12;
            this.btn_comprar.Text = "Comprar Bilhete";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selecione o Passageiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Selecione a Rota";
            // 
            // Lhora
            // 
            this.Lhora.AutoSize = true;
            this.Lhora.BackColor = System.Drawing.Color.White;
            this.Lhora.Location = new System.Drawing.Point(43, 264);
            this.Lhora.Name = "Lhora";
            this.Lhora.Size = new System.Drawing.Size(38, 22);
            this.Lhora.TabIndex = 17;
            this.Lhora.Text = "hora";
            // 
            // CB_hora
            // 
            this.CB_hora.FormattingEnabled = true;
            this.CB_hora.Location = new System.Drawing.Point(39, 291);
            this.CB_hora.Name = "CB_hora";
            this.CB_hora.Size = new System.Drawing.Size(237, 30);
            this.CB_hora.TabIndex = 18;
            this.CB_hora.SelectedIndexChanged += new System.EventHandler(this.CB_hora_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_comprar);
            this.groupBox1.Controls.Add(this.CB_hora);
            this.groupBox1.Controls.Add(this.comboBoxPassageiro);
            this.groupBox1.Controls.Add(this.Lhora);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 434);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comprar Bilhetes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ProjetoPraticoPOO2023.Properties.Resources.ticketvisual;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = global::ProjetoPraticoPOO2023.Properties.Resources.ticketvisual;
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(306, 402);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ComprarBilhetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComprarBilhetes";
            this.Text = "ComprarBilhetes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComprarBilhetes_FormClosing);
            this.Load += new System.EventHandler(this.ComprarBilhetes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPassageiro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lhora;
        private System.Windows.Forms.ComboBox CB_hora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}