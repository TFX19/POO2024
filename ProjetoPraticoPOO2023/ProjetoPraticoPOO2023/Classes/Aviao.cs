using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPraticoPOO2023.Classes
{
    public class Aviao
    {
        //variaveis
        private int idAviao;
        private string modelo;
        private int nrLugares;

        //construtores

        public Aviao(int idAviao, string modelo, int nrLugares) 
        {
            this.modelo = modelo;
            this.nrLugares = nrLugares;
            this.idAviao = idAviao;
        }

        //metodos GET E SET
        #region GETS
        public string GetModelo()
        { 
            return modelo;
        }

        public int GetnrLugares() 
        {
            return nrLugares;
        }

        public int GetIdAviao()
        {
            return idAviao;
        }

        #endregion

        #region SETS
        public void SetIdAviao(int idAviao)
        {
            this.idAviao = idAviao;
        }

        public void SetModelo (string modelo) 
        {
            this.modelo = modelo;
        }

        public void SetnrLugares(int nrLugares)
        {
            this.nrLugares = nrLugares;
        }
        #endregion

        public string ConverterStringA()
        {
            return idAviao + " " + modelo + " " + nrLugares;
        }
    }
}
