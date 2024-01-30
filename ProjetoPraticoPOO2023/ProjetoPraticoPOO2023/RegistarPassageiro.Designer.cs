namespace ProjetoPraticoPOO2023
{
    partial class RegistarPassageiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistarPassageiro));
            this.Btn_registar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_nif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.comboBoxPassageiro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_procurar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_registar
            // 
            this.Btn_registar.Location = new System.Drawing.Point(26, 264);
            this.Btn_registar.Name = "Btn_registar";
            this.Btn_registar.Size = new System.Drawing.Size(199, 32);
            this.Btn_registar.TabIndex = 0;
            this.Btn_registar.Text = "Registar";
            this.Btn_registar.UseVisualStyleBackColor = true;
            this.Btn_registar.Click += new System.EventHandler(this.Btn_registar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // TB_nome
            // 
            this.TB_nome.Location = new System.Drawing.Point(26, 126);
            this.TB_nome.Multiline = true;
            this.TB_nome.Name = "TB_nome";
            this.TB_nome.Size = new System.Drawing.Size(200, 30);
            this.TB_nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIF";
            // 
            // TB_nif
            // 
            this.TB_nif.Location = new System.Drawing.Point(25, 65);
            this.TB_nif.Multiline = true;
            this.TB_nif.Name = "TB_nif";
            this.TB_nif.Size = new System.Drawing.Size(200, 30);
            this.TB_nif.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Nascimento";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(26, 197);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(199, 24);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(23, 197);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 118);
            this.listBox1.TabIndex = 7;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(688, 397);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(100, 32);
            this.btn_Fechar.TabIndex = 8;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // comboBoxPassageiro
            // 
            this.comboBoxPassageiro.FormattingEnabled = true;
            this.comboBoxPassageiro.Location = new System.Drawing.Point(23, 71);
            this.comboBoxPassageiro.Name = "comboBoxPassageiro";
            this.comboBoxPassageiro.Size = new System.Drawing.Size(280, 27);
            this.comboBoxPassageiro.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selecionar Passageiro";
            // 
            // Btn_procurar
            // 
            this.Btn_procurar.Location = new System.Drawing.Point(309, 71);
            this.Btn_procurar.Name = "Btn_procurar";
            this.Btn_procurar.Size = new System.Drawing.Size(77, 27);
            this.Btn_procurar.TabIndex = 11;
            this.Btn_procurar.Text = "Procurar";
            this.Btn_procurar.UseVisualStyleBackColor = true;
            this.Btn_procurar.Click += new System.EventHandler(this.Btn_procurar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_nome);
            this.groupBox1.Controls.Add(this.Btn_registar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_nif);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 329);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.comboBoxPassageiro);
            this.groupBox2.Controls.Add(this.Btn_procurar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(384, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 329);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Informações";
            // 
            // RegistarPassageiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Fechar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistarPassageiro";
            this.Text = "RegistarPassageiro";
            this.Load += new System.EventHandler(this.RegistarPassageiro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_registar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_nif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.ComboBox comboBoxPassageiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_procurar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}