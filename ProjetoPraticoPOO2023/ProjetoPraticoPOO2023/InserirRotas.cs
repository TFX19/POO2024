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
    public partial class InserirRotas : Form
    {
        private Gestor gestor;
        public InserirRotas(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void InserirRotas_Load(object sender, EventArgs e)
        {
            List<Rota> LRotas = gestor.GetListaRota();
            int maxId = LRotas.Max(rota => rota.GetIdRota());
            numericUpDown_idrota.Value = maxId + 1;
            numericUpDown_idrota.Enabled = false;
        }

        private void Btn_inserirrota_Click(object sender, EventArgs e)
        {
            int idRota = (int)numericUpDown_idrota.Value;
            int nrVoos = (int)TB_nrvoos.Value;
            string destino = TB_destino.Text;
            string distancia = TB_distancia.Text; 

           
            string resp = "";

            if (idRota > 0 && nrVoos > 0 && !string.IsNullOrWhiteSpace(destino))
            {
                double distanciaValue;
                if (double.TryParse(distancia, out distanciaValue))
                {
                    resp = gestor.AdicionarRota(idRota, nrVoos, destino, distanciaValue, Gestor.PATH_FILE_ROTAS);
                    MessageBox.Show(resp);
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor numérico válido para a distância.");
                }
            }
            else
            {
                MessageBox.Show("Falta preencher dados!");
            }
        }
    }
}
