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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoPraticoPOO2023
{
    public partial class MostrarVoosRota : Form
    {
        private Gestor gestor;
        public MostrarVoosRota(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void MostrarVoosRota_Load(object sender, EventArgs e)
        {

            comboBoxProcurarRota.DisplayMember = "Text";
            comboBoxProcurarRota.ValueMember = "Value";


            foreach (Rota rota in gestor.GetListaRota())
            {
                if (this.gestor.GetListaVoo().Find(x => x.GetIdRota() == rota.GetIdRota()) != null)
                    comboBoxProcurarRota.Items.Add(new { Text = rota.GetDestino(), Value = rota });
            }

        }

        private void Btn_procurar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (comboBoxProcurarRota.SelectedIndex >= 0)
            {

                Rota rotaSelecionada = (comboBoxProcurarRota.SelectedItem as dynamic).Value;

                // Filtra os voos correspondentes à rota selecionada
                List<Voo> voosPorRota = gestor.GetListaVoo().FindAll(x => x.GetIdRota() == rotaSelecionada.GetIdRota());

                foreach (Voo voo in voosPorRota)
                {
                    dataGridView1.Rows.Add(voo.GetIdVoo(), gestor.GetAviaoById(voo.GetIdAviao()).GetModelo(), voo.GetDia(), voo.GetHora());
                }
            }
            else
            {
                MessageBox.Show("Selecione uma rota válida.");
            }

        }
    }
}
