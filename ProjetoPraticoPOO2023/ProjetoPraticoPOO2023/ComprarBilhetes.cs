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
    public partial class ComprarBilhetes : Form
    {
        private Gestor gestor;

        public ComprarBilhetes(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;

            btn_comprar.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Metodo Comprar Bilhete
            Dictionary<int, List<Bilhete>> dBilhetesAux = this.gestor.GetDicBilhetes();

            Voo vooSelecionado = (CB_hora.SelectedItem as dynamic).Value;
            Passageiro passageiroSelecionado = (comboBoxPassageiro.SelectedItem as dynamic).Value;

            double distancia = this.gestor.GetListaRota().Find(x => x.GetIdRota() == vooSelecionado.GetIdRota()).GetDistancia();

            if (dBilhetesAux.ContainsKey(vooSelecionado.GetIdVoo())) {
                //voo ja existe no dicionário

                if (dBilhetesAux[vooSelecionado.GetIdVoo()].Count < this.gestor.GetListaAviao().Find(x=> x.GetIdAviao() == vooSelecionado.GetIdAviao()).GetnrLugares()) {
                    //Bilhetes comprados < numero de lugares do voo == bilhete efetivo

                    BilheteEfetivo be = new BilheteEfetivo(vooSelecionado.GetIdVoo(), "", 0, passageiroSelecionado.GetNif());

                    be.SetTipo(distancia);
                    be.CalcularDesconto(distancia);
                    dBilhetesAux[vooSelecionado.GetIdVoo()].Add(be);

                    //mensagembox

                } else {
                    int numBilhetesSuplentes = 0;

                    foreach (Bilhete item in dBilhetesAux[vooSelecionado.GetIdVoo()]) {
                        if (item is BilheteSuplente) 
                            numBilhetesSuplentes++;
                    }

                    if(numBilhetesSuplentes < BilheteSuplente.NUM_MAX_VOO) {
                        //Pode adicionar mais um bilhete suplente

                        BilheteSuplente bs = new BilheteSuplente(vooSelecionado.GetIdVoo(), "", 0, passageiroSelecionado.GetNif());
                        bs.SetTipo(distancia);
                        bs.CalcularDesconto(distancia);
                        dBilhetesAux[vooSelecionado.GetIdVoo()].Add(bs);

                        //mensagembox

                    } else {
                        MessageBox.Show("Espaço no avião lotado");
                    }
                }
            } else {
                //Voo não existe no diccionário == adicionar novo item no diccionario com 1 bilhete apenas associado
                dBilhetesAux.Add(vooSelecionado.GetIdVoo(), new List<Bilhete>());

                BilheteEfetivo be = new BilheteEfetivo(vooSelecionado.GetIdVoo(), "", 0, passageiroSelecionado.GetNif());

                be.SetTipo(distancia);
                be.CalcularDesconto(distancia);
                dBilhetesAux[vooSelecionado.GetIdVoo()].Add(be);

                //mensagembox
            }

            gestor.setDicBilhetes(dBilhetesAux);

            int bilhetesEfetivos = 0;
            int bilhetesSuplentes = 0;

            foreach(Bilhete b in gestor.GetDicBilhetes()[vooSelecionado.GetIdVoo()]) {
                if (b is BilheteEfetivo) bilhetesEfetivos++;
                else if (b is BilheteSuplente) bilhetesSuplentes++;
            }

            MessageBox.Show("Bilhetes Efetivos = " + bilhetesEfetivos + "\nBilhetes Suplentes = " + bilhetesSuplentes);

        }

        private void ComprarBilhetes_Load(object sender, EventArgs e)
        {
            comboBoxPassageiro.DisplayMember = "Text";
            comboBoxPassageiro.ValueMember = "Value";

            // Carregar nomes na comboBox com um dicionário
            Dictionary<string, List<Passageiro>> dicPassageiros = gestor.GetDicPass();

            foreach (var entrada in dicPassageiros){
                string nomePassageiro = entrada.Key;

                foreach(Passageiro passageiro in entrada.Value) {
                    comboBoxPassageiro.Items.Add(new { Text = nomePassageiro, Value = passageiro });
                }
                
            }

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            foreach (Rota rota in gestor.GetListaRota()) {
                if(this.gestor.GetListaVoo().Find(x=> x.GetIdRota() == rota.GetIdRota()) != null)
                    comboBox1.Items.Add(new { Text = rota.GetDestino(), Value = rota });
            }

            CB_hora.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){
            Rota rotaSelecionada = (comboBox1.SelectedItem as dynamic).Value;

            List<Voo> voosPorRota = gestor.GetListaVoo().FindAll(x => x.GetIdRota() == rotaSelecionada.GetIdRota());

            CB_hora.Items.Clear();

            CB_hora.DisplayMember = "Text";
            CB_hora.ValueMember = "Value";

            //
            voosPorRota.ForEach(x => CB_hora.Items.Add(new { Text = x.GetDia() + " " + x.GetHora(), Value = x }));

            CB_hora.Enabled = true;
        }

        private void CB_hora_SelectedIndexChanged(object sender, EventArgs e){
            if (CB_hora.Text != "")
                btn_comprar.Enabled = true;
        }

        private void ComprarBilhetes_FormClosing(object sender, FormClosingEventArgs e){
            gestor.escreverFicheiroObjeto(gestor.GetDicBilhetes(), Gestor.PATH_FILE_BILHETES);
        }
    }
}