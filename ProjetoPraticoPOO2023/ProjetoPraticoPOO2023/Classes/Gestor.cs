using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPraticoPOO2023.Classes
{
    public class Gestor
    {
        //Path dos ficheiros

        static public string PATH_FILE_VOOS = "../../Files/voos.txt";
        static public string PATH_FILE_AVIOES = "../../Files/avioes.txt";
        static public string PATH_FILE_PASSAGEIROS = "../../Files/passageiros.txt";
        static public string PATH_FILE_ROTAS = "../../Files/rotas.txt";
        static public string PATH_FILE_BILHETES = "../../Files/bilhetes.bin";

        //variaveis

        private Dictionary<int, List<Bilhete>> DBilhetes;
        private Dictionary<string, List<Passageiro>> DPassageiro;

        private List<Passageiro> LPassageiros;
        private List<Rota> LRotas;
        private List<Aviao> LAvioes;
        private List<Voo> LVoo;


        //construtor

        public Gestor()
        { 
            DBilhetes = new Dictionary<int, List<Bilhete>>();
            DPassageiro = new Dictionary<string, List<Passageiro>>(); 

            LRotas = new List<Rota>();
            LAvioes = new List<Aviao>();
            LVoo = new List<Voo>();
        }

        //----------------------------

        #region ReturnsDicionarioseListas
        public Dictionary<string, List<Passageiro>> GetDicPass()
        {
            return DPassageiro;
        }

        public Dictionary<int, List<Bilhete>> GetDicBilhetes() {
            return DBilhetes;
        }

        public bool setDicBilhetes(Dictionary<int, List<Bilhete>> bilhetes) {
            try {
                DBilhetes = bilhetes;

                return true;
            }catch(Exception e) {
                return false;
            }
        }

        public List<Passageiro> GetListaPassageiro()
        {
            return LPassageiros;
        }

        public List<Rota> GetListaRota()
        {
            return LRotas;
        }
        public List<Aviao> GetListaAviao()
        {
            return LAvioes;
        }
        public List<Voo> GetListaVoo()
        {
            return LVoo;
        }
        #endregion

        #region LerFicheiros
        public void LerPassageirosFicheiro(string passageirosCaminho) {

            StreamReader F = null;
            string linha, nome, dataNasc;
            string[] partes;
            int nif;
            try
            {
                F = new StreamReader(passageirosCaminho);
                Console.WriteLine("esta a ler o ficheiro");
                while ((linha = F.ReadLine()) != null)
                {
                    partes = linha.Split(';'); //divide a linha pelo ponto e virgula
                    nif = Convert.ToInt32(Convert.ToInt32(partes[0]));
                    nome = partes[1];
                    dataNasc = partes[2];
                    if (DPassageiro.ContainsKey(nome) == false)             // se ainda não existe a chave nome no dicionario
                    {
                        List<Passageiro> lista = new List<Passageiro>();  // cria o objeto lista da classe List
                        Passageiro p = new Passageiro(nif, nome, dataNasc);  //cria o objeto p da classe Passageiro
                        lista.Add(p);                             // adiciona p à lista 
                        DPassageiro.Add(nome, lista);                    // adiciona o par (nome, lista) ao dicionario
                    }
                    else                                          //já existe a chave
                    {
                        Passageiro p = new Passageiro(nif, nome, dataNasc);
                        DPassageiro[nome].Add(p);           // adiciona o objeto p à lista de passageiros  de nome
                    }
                    Console.WriteLine($"Passageiro lido: NIF {nif}, Nome {nome}, Data de Nascimento {dataNasc}");
                }
            }
            catch (FileNotFoundException)  //exceção mais específica
            {
                Console.WriteLine("Ficheiro não encontrado!");
            }
            catch (IOException erro)
            {
                Console.WriteLine("Erro de Input/Output" + erro);
            }
            catch (Exception erro)     //exceção mais genérica  
            {
                Console.WriteLine("Erro de Execução" + erro);
            }
            finally
            {
                if (F != null)
                {
                    Console.WriteLine("Ficheiro de passageiros lido com sucesso!");
                    F.Close();
                }
            }

        }

        public void LerRotasFicheiro(string nomeFicheiro)
        {
            StreamReader F = null;
            string linha, destino;
            string[] partes;
            int idRota, nrVoos;
            double distancia;
            try
            {
                F = new StreamReader(nomeFicheiro);
                linha = F.ReadLine();
               //Console.WriteLine(linha);
                while ((linha = F.ReadLine()) != null)
                {
                    //Console.WriteLine(linha);
                    partes = linha.Split(';'); //divide a linha pelo ponto e virgula
                    idRota = Convert.ToInt32(Convert.ToInt32(partes[0]));
                    nrVoos = Convert.ToInt32(partes[1]);
                    destino = partes[2];
                    distancia = Convert.ToDouble(partes[3]);
                    //Console.WriteLine(distancia);
                    Rota rota = new Rota(idRota, nrVoos, destino, distancia); //cria o objeto filme
                    LRotas.Add(rota);
                }
            }
            catch (FileNotFoundException)  //execeção mais específica
            {
                Console.WriteLine("Ficheiro não encontrado!");
            }
            catch (IOException erro)
            {
                Console.WriteLine("Erro de Input/Output" + erro);
            }
            catch (Exception erro)     //exceção mais genérica  
            {
                Console.WriteLine("Erro de Execução" + erro);
            }
            finally
            {
                if (F != null)
                {
                    Console.WriteLine("Ficheiro de rotas lido com sucesso!");
                    F.Close();
                }
            }

        }

        public void LerAvioesFicheiro(string nomeFicheiro)
        {
            StreamReader F = null;
            string linha, modelo;
            string[] partes;
            int idAviao, nrLugares;
            try
            {
                F = new StreamReader(nomeFicheiro);
                //linha = F.ReadLine();
                while ((linha = F.ReadLine()) != null)
                {
                    partes = linha.Split(';'); //divide a linha pelo ponto e virgula
                    idAviao = Convert.ToInt32(Convert.ToInt32(partes[0]));
                    modelo = partes[1];
                    nrLugares = Convert.ToInt32(Convert.ToInt32(partes[2]));
                    Aviao aviao = new Aviao(idAviao, modelo, nrLugares); //cria o objeto filme
                    LAvioes.Add(aviao);
                }
            }
            catch (FileNotFoundException)  //execeção mais específica
            {
                Console.WriteLine("Ficheiro não encontrado!");
            }
            catch (IOException erro)
            {
                Console.WriteLine("Erro de Input/Output" + erro);
            }
            catch (Exception erro)     //exceção mais genérica  
            {
                Console.WriteLine("Erro de Execução" + erro);
            }
            finally
            {
                if (F != null)
                {
                    Console.WriteLine("Ficheiro de rotas lido com sucesso!");
                    F.Close();
                }
            }

        }

        public void LerVoosFicheiro(string nomeFicheiro)
        {
            StreamReader F = null;
            string linha, dia, hora;
            string[] partes;
            int idVoo, idAviao, idRota;
            try
            {
                F = new StreamReader(nomeFicheiro);
                //linha = F.ReadLine();
                while ((linha = F.ReadLine()) != null)
                {
                    partes = linha.Split(';'); //divide a linha pelo ponto e virgula
                    idVoo = Convert.ToInt32(Convert.ToInt32(partes[0]));
                    idAviao = Convert.ToInt32(Convert.ToInt32(partes[1]));
                    idRota = Convert.ToInt32(Convert.ToInt32(partes[2]));
                    dia = partes[3];
                    hora = partes[4];
                    Voo voo = new Voo(idVoo,idAviao, idRota, dia, hora); //cria o objeto filme
                    LVoo.Add(voo);
                }
            }
            catch (FileNotFoundException)  //execeção mais específica
            {
                Console.WriteLine("Ficheiro não encontrado!");
            }
            catch (IOException erro)
            {
                Console.WriteLine("Erro de Input/Output" + erro);
            }
            catch (Exception erro)     //exceção mais genérica  
            {
                Console.WriteLine("Erro de Execução" + erro);
            }
            finally
            {
                if (F != null)
                {
                    Console.WriteLine("Ficheiro de rotas lido com sucesso!");
                    F.Close();
                }
            }

        }

        public void LerBilhetesFicheiro(string filePath) {

            Dictionary<int, List<Bilhete>> meusBilhetes = (Dictionary<int, List<Bilhete>>)lerFicheiroObjeto(Gestor.PATH_FILE_BILHETES);
            if (meusBilhetes != null)
                setDicBilhetes(meusBilhetes);
            else
                setDicBilhetes(new Dictionary<int, List<Bilhete>>());
        }

        public Object lerFicheiroObjeto(string filePath) {
            string serializationFile = Path.Combine(filePath);

            try {
                //deserialize
                using (Stream stream = File.Open(serializationFile, FileMode.Open)) {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    return bformatter.Deserialize(stream);
                }
            }catch(Exception e) {
                return null;
            }
        }

        #endregion

        #region FuncoesEscreverFicheiro

        public void escreverFicheiroObjeto(Object obj, string filePath) {
            string serializationFile = Path.Combine(filePath);

            //serialize
            using (Stream stream = File.Open(serializationFile, FileMode.Create)) {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, obj);
            }

        }

        public string AdicionarPassageiro(string nome, string dataNasc, int nif, string caminhoFicheiro)
        {
            foreach (Passageiro p in LPassageiros)
                if (p.GetNif() == nif)
                    return "Passageiro já existente!";

            Passageiro passageiro = new Passageiro(nif, nome, dataNasc);
            LPassageiros.Add(passageiro);

            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoFicheiro, true))
                {
                    writer.WriteLine($"{nif};{nome};{dataNasc};");
                }
                return "Passageiro inserido com sucesso!";
            }
            catch (IOException erro)
            {
                return "Erro ao escrever no arquivo: " + erro.Message;
            }
        }

        public string AdicionarRota(int idRota, int nrVoos, string destino, double distancia, string caminhoFicheiro)
        {
            foreach (Rota r in LRotas)
                if (r.GetIdRota() == idRota)
                    return "Rota já existente!";

            Rota rota = new Rota(idRota, nrVoos, destino, distancia);
            LRotas.Add(rota);

            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoFicheiro, true))
                {
                    writer.WriteLine($"{idRota};{nrVoos};{destino};{distancia};");
                }
                return "Rota inserida com sucesso!";
            }
            catch (IOException erro)
            {
                return "Erro ao escrever no arquivo: " + erro.Message;
            }
        }

        public string AdicionarVooRota(int idVoo, int idAviao, int idRota, string dia, string hora, string caminhoFicheiro)
        {
            // Encontrar a Rota correspondente
            Rota rotaCorrespondente = LRotas.FirstOrDefault(r => r.GetIdRota() == idRota);

            if (rotaCorrespondente == null)
            {
                return "Rota não existe!";
            }

            // Verificar se o Voo já existe
            foreach (Voo v in LVoo)
                if (v.GetIdVoo() == idVoo)
                    return "Voo já existente!";

            // Criar o novo Voo e associá-lo à Rota
            Voo novoVoo = new Voo(idVoo, idAviao,idRota, dia, hora);
            LVoo.Add(novoVoo);

            // Atualizar o número de voos na Rota correspondente
            rotaCorrespondente.IncrementarNrVoos();

            try
            {
                // Escrever no arquivo (ajuste conforme necessário)
                using (StreamWriter writer = new StreamWriter(caminhoFicheiro, true))
                {
                    writer.WriteLine($"{idVoo};{idAviao};{idRota};{dia};{hora};");
                }
                return "Voo inserido com sucesso!";
            }
            catch (IOException erro)
            {
                return "Erro ao escrever no arquivo: " + erro.Message;
            }
        }


        #endregion

        public string PesquisaNomePassageiro(string nome)
        {  //Pesquisa pessoa no dicionário
           // nome - variável que traz o nome (da textBox)
           //  s - variável que leva a informação da pessoa (para a listBox)
            string s = "";
            foreach (KeyValuePair<string, List<Passageiro>> par in DPassageiro)
                foreach (Passageiro p in par.Value)
                    if (p.GetNome().ToUpper().Equals(nome.ToUpper()))
                    {
                        s = p.ConverterString();
                        return s;
                    }
            s = "Pessoa com esse nome não existe!";
            return s;
        }

        public int GetIdAviaoByModelo(string modelo)
        {
            foreach (Aviao aviao in LAvioes)
            {
                if (aviao.GetModelo() == modelo)
                {
                    return aviao.GetIdAviao();
                }
            }
            return -1; 
        }

        public Aviao GetAviaoByModelo(string modelo) {
            return this.LAvioes.Find(x=> x.GetModelo() == modelo);
        }
        public Aviao GetAviaoById(int idAviao)
        {
            return this.LAvioes.Find(x => x.GetIdAviao() == idAviao);
        }

        public Voo GetVooById(int id){
            return this.LVoo.Find(x => x.GetIdVoo() == id);
        }

        public Rota GetRotaById(int id)
        {
            return this.LRotas.Find(x => x.GetIdRota() == id);
        }
    }
}
