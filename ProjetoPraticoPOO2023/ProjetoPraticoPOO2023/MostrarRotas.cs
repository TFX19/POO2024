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
    public partial class MostrarRotas : Form
    {
        private Gestor gestor;

        public MostrarRotas(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void MostrarRotas_Load(object sender, EventArgs e)
        {
            List<Rota> LRota = gestor.GetListaRota();
            //MessageBox.Show(LRota.Count.ToString());
            foreach (Rota rota in LRota)
                dataGridView1.Rows.Add(rota.GetIdRota(), rota.GetNrVoos(), rota.GetDestino(), rota.GetDistancia(), Gestor.PATH_FILE_ROTAS);
        }

    }
}
