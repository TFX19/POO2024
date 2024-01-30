using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPraticoPOO2023.Classes
{
    [Serializable()]
    public class BilheteSuplente : Bilhete
    {
        //variaveis
        private double desconto;
        public const int NUM_MAX_VOO = 4;

        //construtor

        public BilheteSuplente(int idVoo, string tipo, int preco, int nifP) : base(idVoo, tipo, preco, nifP){
            this.desconto = 0;
        }

        public double GetDesconto() {
            return desconto;
        }

        public void SetDesconto(double desconto) {
            if(desconto > 0 && desconto <= 1)
                this.desconto = desconto;
            else this.desconto = 0;
        }
        public override double CalcularDesconto(double distancia) {
            double descAux = 0;

            if (distancia > 300 && distancia <= 1000) {
                descAux = 0.25;
            } else if (distancia > 1000) {
                descAux = 0.5;
            }

            this.SetDesconto(descAux);
            return descAux;
        }

        public double CalcularValorComDesconto(){
            return base.GetPreco() * (1 - desconto);
        }

        public override string ToString() {
            return base.ToString() + " " + this.CalcularValorComDesconto() + " MAX_SUP_VOO: " + BilheteSuplente.NUM_MAX_VOO; //polimorfismo
        }
    }
}
