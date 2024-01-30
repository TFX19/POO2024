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
    public partial class CancelarBilhetes : Form
    {
        private Gestor gestor;
        public CancelarBilhetes(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            btn_cancelarB.Enabled = false;
        }

        private void btn_cancelarB_Click(object sender, EventArgs e)
        {
            Passageiro passageiroSelecionado = (comboBoxPassageiro.SelectedItem as dynamic).Value;
            Voo vooSelecionado = (CB_hora.SelectedItem as dynamic).Value;

            Dictionary<int, List<Bilhete>> meusBilhetes = this.gestor.GetDicBilhetes();

            //elimina dos bilhetes o bilhete de um determinado passageiro do voo que nós queremos retirar
            meusBilhetes[vooSelecionado.GetIdVoo()].Remove(
                meusBilhetes[vooSelecionado.GetIdVoo()].Find(
                    x=> x.GetnifP()== passageiroSelecionado.GetNif()
                    )
                );

            //Verificar se há bilhetes suplentes daquele voo para atualizá-lo
            int numBilSup = 0;
            foreach(Bilhete b in meusBilhetes[vooSelecionado.GetIdVoo()]) {
               if(b is BilheteSuplente)
                    numBilSup++;
            }

            if(numBilSup != 0) {
                double distancia = this.gestor.GetListaRota().Find(x => x.GetIdRota() == vooSelecionado.GetIdRota()).GetDistancia();

                int indexPrimeiroBilSuplente = meusBilhetes[vooSelecionado.GetIdVoo()].FindIndex(x=> x is BilheteSuplente); //através do findindex encontra o primeiro bilhete sup existente

                BilheteSuplente bsAntigo = (BilheteSuplente)meusBilhetes[vooSelecionado.GetIdVoo()].ElementAt(indexPrimeiroBilSuplente);

                BilheteEfetivo novoBe = new BilheteEfetivo(bsAntigo.GetIdVoo(), "", 0, bsAntigo.GetnifP());

                novoBe.SetTipo(distancia);
                novoBe.CalcularDesconto(distancia);

                meusBilhetes[vooSelecionado.GetIdVoo()].Insert(indexPrimeiroBilSuplente, novoBe);
            }

            this.gestor.setDicBilhetes(meusBilhetes);
            MessageBox.Show("Bilhete de " + passageiroSelecionado.GetNome() + " foi apagado com sucesso");
        }

        private void CancelarBilhetes_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            Dictionary<int, List<Bilhete>> meusBilhetes = this.gestor.GetDicBilhetes();


            foreach (Rota rota in gestor.GetListaRota()) {

                foreach (var bilhete in meusBilhetes) {
                    int idVoo = bilhete.Key;

                    if(this.gestor.GetVooById(idVoo).GetIdRota() == rota.GetIdRota()) {
                        comboBox1.Items.Add(new { Text = rota.GetDestino(), Value = rota });
                    }

                }
            }

            comboBoxPassageiro.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rota rotaSelecionada = (comboBox1.SelectedItem as dynamic).Value;

            List<Voo> voosPorRota = gestor.GetListaVoo().FindAll(x => x.GetIdRota() == rotaSelecionada.GetIdRota());

            CB_hora.Items.Clear();

            CB_hora.DisplayMember = "Text";
            CB_hora.ValueMember = "Value";


            Dictionary<int, List<Bilhete>> meusBilhetes = this.gestor.GetDicBilhetes();


            foreach (Voo voo in voosPorRota) {
                try {
                    if (meusBilhetes[voo.GetIdVoo()].Count > 0)
                        CB_hora.Items.Add(new { Text = voo.GetDia() + " " + voo.GetHora(), Value = voo });
                }catch(Exception) {}
            }


            //voosPorRota.ForEach(x => CB_hora.Items.Add(new { Text = x.GetDia() + " " + x.GetHora(), Value = x }));
        }

        private void CB_hora_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPassageiro.DisplayMember = "Text";
            comboBoxPassageiro.ValueMember = "Value";

            // Carregar nomes na comboBox usando um dicionário
            Dictionary<string, List<Passageiro>> dicPassageiros = gestor.GetDicPass();
            Dictionary<int, List<Bilhete>> meusBilhetes = this.gestor.GetDicBilhetes();
            Voo vooSelecionado = (CB_hora.SelectedItem as dynamic).Value;

            foreach (var entrada in dicPassageiros) 
            {
                string nomePassageiro = entrada.Key;

                foreach (Passageiro passageiro in entrada.Value) {
                    if (meusBilhetes[vooSelecionado.GetIdVoo()].Find(x => x.GetnifP() == passageiro.GetNif()) != null)
                        comboBoxPassageiro.Items.Add(new { Text = nomePassageiro, Value = passageiro });
                }
            }

            if(comboBoxPassageiro.Items.Count != 0)
                comboBoxPassageiro.Enabled = true;
        }

        private void CancelarBilhetes_FormClosing(object sender, FormClosingEventArgs e)
        {
            gestor.escreverFicheiroObjeto(gestor.GetDicBilhetes(), Gestor.PATH_FILE_BILHETES);
        }

        private void comboBoxPassageiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPassageiro.Text != "")
                btn_cancelarB.Enabled = true;
        }
    }
}
