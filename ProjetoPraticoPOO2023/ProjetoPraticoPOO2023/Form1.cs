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
    public partial class Form_main : Form
    {
        private Gestor gestor;
        public Form_main()
        {
            InitializeComponent();

            gestor = new Gestor();
            gestor.LerAvioesFicheiro(Gestor.PATH_FILE_AVIOES);
            gestor.LerPassageirosFicheiro(Gestor.PATH_FILE_PASSAGEIROS);
            gestor.LerRotasFicheiro(Gestor.PATH_FILE_ROTAS);
            gestor.LerVoosFicheiro(Gestor.PATH_FILE_VOOS);
            gestor.LerBilhetesFicheiro(Gestor.PATH_FILE_BILHETES);
            
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Passageiros_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGPassageiro form = new FormGPassageiro(this.gestor);
            form.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGAdmin formA = new FormGAdmin(this.gestor);
            formA.Show();
        }
    }
}
