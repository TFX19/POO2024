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
    public partial class MostrarViagensRealizadas : Form
    {
        private Gestor gestor;
        public MostrarViagensRealizadas(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void MostrarViagensRealizadas_Load(object sender, EventArgs e)
        {
           

            DateTime dataAtual = DateTime.Now;
            labelhora.Text = $"Data: {dataAtual.ToShortDateString()}, Hora: {dataAtual.ToShortTimeString()}";
            

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

                                    // Convertendo as strings para DateTime e TimeSpan
                                    DateTime dataVoo = DateTime.Parse(voo.GetDia());
                                    TimeSpan horaVoo = TimeSpan.Parse(voo.GetHora());

                                    DateTime dataHoraVoo = dataVoo + horaVoo;

                                    if (dataHoraVoo < DateTime.Now)
                                    {
                                        dataGridView1.Rows.Add(
                                            passageiro.GetNome(),
                                            gestor.GetAviaoById(voo.GetIdAviao()).GetModelo(),
                                            dataVoo,
                                            horaVoo
                                        );
                                    }
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
