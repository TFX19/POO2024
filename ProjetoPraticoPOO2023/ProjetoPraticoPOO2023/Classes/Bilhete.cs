using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPraticoPOO2023.Classes
{
    [Serializable()]
    public abstract class Bilhete 
    {
        //variaveis
        private string tipo;
        private double preco;
        private int idVoo;
        private int nifP;

        //construtor

        public Bilhete(int idVoo, string tipo, int preco, int nifP)
        {
           this.idVoo = idVoo; 
           this.tipo = tipo;
           this.preco = preco;
           this.nifP = nifP;
        }
        
        #region GETS
        public string GetTipo() { return tipo;}

        public int GetIdVoo() { return idVoo;}

        public double GetPreco() { return preco;}

        public int GetnifP() {  return nifP;}
        #endregion

        #region SETS
        private void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public void SetPreco(int preco)
        {
            this.preco = preco;
        }
        public void SetIdVoo(int idVoo)
        {
            this.idVoo = idVoo;
        }
        public void SetnifP(int nifP)
        {
            this.nifP = nifP;
        }
        public void SetTipo(double distancia){
            if (distancia > 300 && distancia <= 1000){
                SetTipo("B");
            }
            else if (distancia > 1000){
                SetTipo("C");
            }
            else{
                SetTipo("A");
            }
        }
        #endregion

        public abstract double CalcularDesconto(double distancia);

        public override string ToString()
        {
            return this.idVoo + " " + this.tipo + " " + this.preco;
        }
    }
}
