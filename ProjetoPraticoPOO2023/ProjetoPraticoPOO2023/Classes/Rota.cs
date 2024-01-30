using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPraticoPOO2023.Classes
{
    public class Rota
    {
        //variaveis
        private int idRota;
        private int nrVoos;
        private string destino;
        private double distancia;

        //contrutores
        public Rota(int idRota, int nrVoos, string destino, double distancia)
        {
            this.idRota = idRota;
            this.nrVoos = nrVoos;
            this.destino = destino;
            this.distancia = distancia;
        }
        #region GETS

        public int GetIdRota() { return idRota; }

        public int GetNrVoos() {  return nrVoos; }

        public string GetDestino() {  return destino; }

        public double GetDistancia() {  return distancia; }

        #endregion

        #region SETS
        public void SetIdRota(int idRota)
        {
            this.idRota = idRota;
        }

        public void SetNrVoos(int nrVoos)
        {
            this.nrVoos= nrVoos;
        }

        public void SetDestino(string destino)
        {
            this.destino = destino; 
        }
        public void SetDistancia(double distancia)
        {
            this.distancia = distancia;
        }

        #endregion

        public void IncrementarNrVoos()
        {
            nrVoos++;
        }

        public string ConverterStringR()
        {
            return idRota + " " + nrVoos + " " + destino + " " + distancia;
        }

    }


}
