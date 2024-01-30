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
    public partial class FormGAdmin : Form
    {
        private Gestor gestor;
        public FormGAdmin(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void rotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarRotas mostrarR = new MostrarRotas(this.gestor);
            mostrarR.ShowDialog();     // Mostra o novo formulário
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_main form = new Form_main();
            form.Show();
        }

        private void inserirRotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirRotas inserirR = new InserirRotas(this.gestor);
            inserirR.Show();
        }

        private void inserirVoosNumaRotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirVooRota inserirVR = new InserirVooRota(this.gestor);
            inserirVR.Show();
        }

        private void voosPorRotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVoosRota mostrarVR = new MostrarVoosRota(this.gestor);
            mostrarVR.Show();
        }

        private void passageirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPassageirosEfetivosVoo mostrarPEV = new MostrarPassageirosEfetivosVoo(this.gestor);
            mostrarPEV.Show();
        }
    }
}
