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
    public partial class MostrarPassageirosEfetivosVoo : Form
    {
        private Gestor gestor;
        public MostrarPassageirosEfetivosVoo(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void MostrarPassageirosEfetivosVoo_Load(object sender, EventArgs e)
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

                List<Voo> voosPorRota = gestor.GetListaVoo().FindAll(x => x.GetIdRota() == rotaSelecionada.GetIdRota());
                Dictionary<int, List<Bilhete>> meusBilhetes = this.gestor.GetDicBilhetes();
                Dictionary<string, List<Passageiro>> dicPassageiros = this.gestor.GetDicPass();

                foreach (var parBilhetes in meusBilhetes)
                {
                    int idVoo = parBilhetes.Key;

                    if (voosPorRota.Any(voo => voo.GetIdVoo() == idVoo))
                    {
                        List<Bilhete> bilhetesDoVoo = parBilhetes.Value;

                        foreach (Bilhete bilhete in bilhetesDoVoo)
                        {
                            foreach (var parPassageiros in dicPassageiros)
                            {
                                Passageiro passageiro = parPassageiros.Value.FirstOrDefault(p => p.GetNif() == bilhete.GetnifP());

                                if (passageiro != null)
                                {
                                    Voo voo = gestor.GetVooById(idVoo);

                                    dataGridView1.Rows.Add(
                                        passageiro.GetNome(),
                                        gestor.GetAviaoById(voo.GetIdAviao()).GetModelo(),
                                        voo.GetDia(),
                                        voo.GetHora()
                                    );
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma rota válida.");
            }
        }
    }
}

