using ProjetoPraticoPOO2023.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoPraticoPOO2023
{
    public partial class RegistarPassageiro : Form
    {
        private Gestor gestor;
        public RegistarPassageiro(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_procurar_Click(object sender, EventArgs e)
        {
            if (comboBoxPassageiro.Text.Trim() != "") //retira os espaços em branco
            {
                string resp = gestor.PesquisaNomePassageiro(comboBoxPassageiro.Text);
                listBox1.Items.Add(resp);
            }
            else
                MessageBox.Show("Insira o nome a pesquisar!");
        }

        private void RegistarPassageiro_Load(object sender, EventArgs e)
        {
            // Carregar nomes na comboBox usando um dicionário
            Dictionary<string, List<Passageiro>> dicPassageiros = gestor.GetDicPass();

            foreach (var entrada in dicPassageiros)
            {
                string nome = entrada.Key;

                // Adicionar o nome à comboBox
                comboBoxPassageiro.Items.Add(nome);
            }
        }

        private void Btn_registar_Click(object sender, EventArgs e)
        {

            string nome = TB_nome.Text;
            string dataNasc = maskedTextBox1.Text;
            string nif = TB_nif.Text;
            string resp = "";

            if (nome.Trim() != "" && dataNasc.Trim() != "" && nif.Trim() != "")
            {
                resp = gestor.AdicionarPassageiro(nome, dataNasc, Convert.ToInt32(nif), Gestor.PATH_FILE_PASSAGEIROS);
                MessageBox.Show(resp);
            }
            else
                MessageBox.Show("Falta preencher dados!");
        }
    }
}
