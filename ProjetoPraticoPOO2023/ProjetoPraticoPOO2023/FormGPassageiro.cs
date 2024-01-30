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
    public partial class FormGPassageiro : Form
    {
        //gestor

        private Gestor gestor;

        public FormGPassageiro(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void passageiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistarPassageiro formRP = new RegistarPassageiro(this.gestor);
            formRP.MdiParent = this;
            formRP.Show();
        }

        private void FormGPassageiro_Load(object sender, EventArgs e)
        {

        }

        private void rotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MostrarRotas mostrarR = new MostrarRotas(this.gestor);
            mostrarR.ShowDialog();     
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_main form = new Form_main();
            form.Show();
        }

        private void comprarBilhetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarBilhetes comprarB = new ComprarBilhetes(this.gestor);
            comprarB.Show();     
        }

        private void voosPorRotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVoosRota mostrarVR = new MostrarVoosRota(this.gestor);
            mostrarVR.Show();
        }

        private void cancelarBilhetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarBilhetes cancelarB = new CancelarBilhetes(this.gestor);
            cancelarB.Show();
        }

        private void voosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarViagensRealizadas mostrarVRS = new MostrarViagensRealizadas(this.gestor);
            mostrarVRS.Show();
        }
    }
}
