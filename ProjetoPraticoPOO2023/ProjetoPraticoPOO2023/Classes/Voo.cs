using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPraticoPOO2023.Classes
{
    public class Voo
    {
        //variaveis
        private int idVoo;
        private int idAviao;
        private int idRota;
        private string dia;
        private string hora;

        //contrutor
        public Voo(int idVoo, int idAviao, int idRota, string dia, string hora)
        {
            this.idVoo = idVoo;
            this.idAviao = idAviao;
            this.idRota = idRota;
            this.dia = dia;
            this.hora = hora;
        }

        #region GETS
        public int GetIdVoo() {  return idVoo; }

        public int GetIdAviao() { return idAviao; }

        public int GetIdRota() {  return idRota; }

        public string GetDia() {  return dia; }

        public string GetHora() {  return hora; }

        #endregion

        #region SETS

        public void SetIdVoo( int idVoo )
        {
            this.idVoo= idVoo;
        }
        public void SetIdRota(int idRota)
        {
            this.idRota = idRota;
        }
        public void SetIdAviao(int idAviao)
        {
            this.idAviao = idAviao;
        }

        public void SetDia(string dia)
        {
            this.dia = dia;
        }

        public void SetHora(string hora)
        {
            this.hora= hora;
        }

        #endregion


    }
}
