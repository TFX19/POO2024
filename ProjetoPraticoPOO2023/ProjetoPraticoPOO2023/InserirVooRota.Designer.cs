namespace ProjetoPraticoPOO2023
{
    partial class InserirVooRota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirVooRota));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxHora = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDia = new System.Windows.Forms.MaskedTextBox();
            this.Fechar = new System.Windows.Forms.Button();
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxModeloAviao = new System.Windows.Forms.ComboBox();
            this.comboBoxRota = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownIdVoo = new System.Windows.Forms.NumericUpDown();
            this.Btn_inserirvoorota = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdVoo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxHora);
            this.groupBox1.Controls.Add(this.maskedTextBoxDia);
            this.groupBox1.Controls.Add(this.Fechar);
            this.groupBox1.Controls.Add(this.Btn_limpar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxModeloAviao);
            this.groupBox1.Controls.Add(this.comboBoxRota);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownIdVoo);
            this.groupBox1.Controls.Add(this.Btn_inserirvoorota);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 390);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Voos numa Rota";
            // 
            // maskedTextBoxHora
            // 
            this.maskedTextBoxHora.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxHora.Location = new System.Drawing.Point(263, 113);
            this.maskedTextBoxHora.Mask = "00:00";
            this.maskedTextBoxHora.Name = "maskedTextBoxHora";
            this.maskedTextBoxHora.Size = new System.Drawing.Size(199, 24);
            this.maskedTextBoxHora.TabIndex = 19;
            this.maskedTextBoxHora.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDia
            // 
            this.maskedTextBoxDia.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDia.Location = new System.Drawing.Point(265, 54);
            this.maskedTextBoxDia.Mask = "00/00/0000";
            this.maskedTextBoxDia.Name = "maskedTextBoxDia";
            this.maskedTextBoxDia.Size = new System.Drawing.Size(199, 24);
            this.maskedTextBoxDia.TabIndex = 18;
            this.maskedTextBoxDia.ValidatingType = typeof(System.DateTime);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(11, 352);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(452, 32);
            this.Fechar.TabIndex = 17;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.Location = new System.Drawing.Point(11, 314);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(452, 32);
            this.Btn_limpar.TabIndex = 16;
            this.Btn_limpar.Text = "Limpar";
            this.Btn_limpar.UseVisualStyleBackColor = true;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Inserir a hora";
            // 
            // comboBoxModeloAviao
            // 
            this.comboBoxModeloAviao.FormattingEnabled = true;
            this.comboBoxModeloAviao.Location = new System.Drawing.Point(10, 116);
            this.comboBoxModeloAviao.Name = "comboBoxModeloAviao";
            this.comboBoxModeloAviao.Size = new System.Drawing.Size(195, 27);
            this.comboBoxModeloAviao.TabIndex = 13;
            // 
            // comboBoxRota
            // 
            this.comboBoxRota.FormattingEnabled = true;
            this.comboBoxRota.Location = new System.Drawing.Point(10, 51);
            this.comboBoxRota.Name = "comboBoxRota";
            this.comboBoxRota.Size = new System.Drawing.Size(195, 27);
            this.comboBoxRota.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inserir o dia";
            // 
            // numericUpDownIdVoo
            // 
            this.numericUpDownIdVoo.Location = new System.Drawing.Point(11, 180);
            this.numericUpDownIdVoo.Name = "numericUpDownIdVoo";
            this.numericUpDownIdVoo.Size = new System.Drawing.Size(200, 24);
            this.numericUpDownIdVoo.TabIndex = 7;
            // 
            // Btn_inserirvoorota
            // 
            this.Btn_inserirvoorota.Location = new System.Drawing.Point(11, 276);
            this.Btn_inserirvoorota.Name = "Btn_inserirvoorota";
            this.Btn_inserirvoorota.Size = new System.Drawing.Size(452, 32);
            this.Btn_inserirvoorota.TabIndex = 0;
            this.Btn_inserirvoorota.Text = "Inserir";
            this.Btn_inserirvoorota.UseVisualStyleBackColor = true;
            this.Btn_inserirvoorota.Click += new System.EventHandler(this.Btn_inserirvoorota_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "modelo do avião";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = " Rota desejada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Inserir o Id Voo";
            // 
            // InserirVooRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirVooRota";
            this.Text = "InserirVooRota";
            this.Load += new System.EventHandler(this.InserirVooRota_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdVoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownIdVoo;
        private System.Windows.Forms.Button Btn_inserirvoorota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRota;
        private System.Windows.Forms.Button Btn_limpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxModeloAviao;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDia;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHora;
    }
}