using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetoPraticoPOO2023.Classes
{
    public class Passageiro
    {
        //Variaveis
        private int nif;
        private string nome;
        private string dataNasc;

        //construtor

        public Passageiro( int nif, string nome, string dataNasc)
        {
            this.nif = nif;
            this.nome = nome;
            this.dataNasc = dataNasc;
        }

        //metodos

        #region gets
        public int GetNif() { return nif; }

        public string GetNome() {  return nome; }

        public string GetDataNasc() {  return dataNasc; }

        #endregion

        #region sets

        public void SetNif( int nif )
        {
            this.nif = nif;
        }

        public void SetNome( string nome )
        { 
            this.nome = nome;
        }

        public void SetDataNascimento( string dataNasc ) 
        {
            this.dataNasc = dataNasc;
        }
        #endregion

        public string ConverterString()
        {
            return nif + " " + nome + "" + dataNasc ;
        }
    }
}
