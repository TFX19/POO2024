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

namespace ProjetoPraticoPOO2023
{
    public partial class InserirVooRota : Form
    {
        private Gestor gestor;

        public InserirVooRota(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void InserirVooRota_Load(object sender, EventArgs e)
        {
            //gestor.LerAvioesFicheiro(caminho + "avioes.txt");
            //gestor.LerRotasFicheiro(caminho + "rotas.txt");

            maskedTextBoxDia.Text = DateTime.Now.ToString("dd/MM/yyyy");

            comboBoxRota.DisplayMember = "Text";
            comboBoxRota.ValueMember = "Value";


            foreach (Rota rota in gestor.GetListaRota())
            {
                //if (this.gestor.GetListaVoo().Find(x => x.GetIdRota() == rota.GetIdRota()) != null)
                    comboBoxRota.Items.Add(new { Text = rota.GetDestino(), Value = rota });
            }

            foreach (Aviao aviao in gestor.GetListaAviao())
            {
                comboBoxModeloAviao.Items.Add(aviao.GetModelo());
            }

            List<Voo> Lvoo = gestor.GetListaVoo();
            int maxId = Lvoo.Max(voo => voo.GetIdVoo());
            numericUpDownIdVoo.Value = maxId + 1;
            numericUpDownIdVoo.Enabled = false;
        }

        private void Btn_inserirvoorota_Click(object sender, EventArgs e)
        {


            if (comboBoxModeloAviao.SelectedItem != null)
            {
                int idVoo = Convert.ToInt32(numericUpDownIdVoo.Value);  
                string dia = maskedTextBoxDia.Text;
                string hora = maskedTextBoxHora.Text;

                string modeloSelecionado = comboBoxModeloAviao.SelectedItem.ToString();
                int idAviao = gestor.GetIdAviaoByModelo(modeloSelecionado);

                int idRota = -1;

                if (comboBoxRota.SelectedItem != null)
                {
                    var selectedItem = (dynamic)comboBoxRota.SelectedItem;
                    idRota = selectedItem.Value.GetIdRota();
                }

                if (idRota != -1)
                {
                    List<Voo> voosPorRota = gestor.GetListaVoo().FindAll(x => x.GetIdRota() == idRota);

                    string resultado = gestor.AdicionarVooRota(idVoo, idAviao, idRota, dia, hora, Gestor.PATH_FILE_VOOS);

                    MessageBox.Show(resultado);
                }
                else
                {
                    MessageBox.Show("Selecione uma rota válida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um modelo de avião.");
            }

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {

            maskedTextBoxDia.Clear();
            maskedTextBoxHora.Clear();

        }
    }
}
