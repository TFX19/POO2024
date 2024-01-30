namespace ProjetoPraticoPOO2023
{
    partial class InserirRotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirRotas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_distancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_destino = new System.Windows.Forms.TextBox();
            this.TB_nrvoos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_idrota = new System.Windows.Forms.NumericUpDown();
            this.Btn_inserirrota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_nrvoos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idrota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TB_distancia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_destino);
            this.groupBox1.Controls.Add(this.TB_nrvoos);
            this.groupBox1.Controls.Add(this.numericUpDown_idrota);
            this.groupBox1.Controls.Add(this.Btn_inserirrota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 390);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Rotas";
            // 
            // TB_distancia
            // 
            this.TB_distancia.Location = new System.Drawing.Point(6, 254);
            this.TB_distancia.Multiline = true;
            this.TB_distancia.Name = "TB_distancia";
            this.TB_distancia.Size = new System.Drawing.Size(200, 30);
            this.TB_distancia.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Distância";
            // 
            // TB_destino
            // 
            this.TB_destino.Location = new System.Drawing.Point(6, 180);
            this.TB_destino.Multiline = true;
            this.TB_destino.Name = "TB_destino";
            this.TB_destino.Size = new System.Drawing.Size(200, 30);
            this.TB_destino.TabIndex = 9;
            // 
            // TB_nrvoos
            // 
            this.TB_nrvoos.Location = new System.Drawing.Point(6, 116);
            this.TB_nrvoos.Name = "TB_nrvoos";
            this.TB_nrvoos.Size = new System.Drawing.Size(200, 24);
            this.TB_nrvoos.TabIndex = 8;
            // 
            // numericUpDown_idrota
            // 
            this.numericUpDown_idrota.Location = new System.Drawing.Point(6, 51);
            this.numericUpDown_idrota.Name = "numericUpDown_idrota";
            this.numericUpDown_idrota.Size = new System.Drawing.Size(200, 24);
            this.numericUpDown_idrota.TabIndex = 7;
            // 
            // Btn_inserirrota
            // 
            this.Btn_inserirrota.Location = new System.Drawing.Point(6, 352);
            this.Btn_inserirrota.Name = "Btn_inserirrota";
            this.Btn_inserirrota.Size = new System.Drawing.Size(199, 32);
            this.Btn_inserirrota.TabIndex = 0;
            this.Btn_inserirrota.Text = "Inserir";
            this.Btn_inserirrota.UseVisualStyleBackColor = true;
            this.Btn_inserirrota.Click += new System.EventHandler(this.Btn_inserirrota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Voos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id da Rota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destino";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoPraticoPOO2023.Properties.Resources.flying_routes;
            this.pictureBox1.Location = new System.Drawing.Point(318, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // InserirRotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirRotas";
            this.Text = "InserirRotas";
            this.Load += new System.EventHandler(this.InserirRotas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_nrvoos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idrota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_inserirrota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_idrota;
        private System.Windows.Forms.NumericUpDown TB_nrvoos;
        private System.Windows.Forms.TextBox TB_destino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_distancia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}