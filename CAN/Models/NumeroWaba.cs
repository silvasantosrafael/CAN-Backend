using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace CAN.Models
{
    public class NumeroWaba
    {
        public int Id { get; set; }
        public string Nome_Numero { get; set; }
        public string Numero { get; set; }
        public string Empresa { get; set; }
        public string Bm_id { get; set; }
        public DateTime DateTimeAtivacaoBD { get; set; }
        public string Data_ativacao { get; set; }
        public DateTime DateTimeDesativacaoBD { get; set; }
        public string Data_desativacao { get; set; }
        public string Parceiro { get; set; }
        public int Ativo { get; set; }
        public string Caminho_imagem { get; set; }

        public NumeroWaba()
        {

        }

        public NumeroWaba(int id)
        {
            this.Id = id;
        }

        #region Colocar estes metodos numa classe NumeroWabaRepositorio
        public List<NumeroWaba> Select(int id)
        {
            ConexaoDB connSql = new ConexaoDB();
            connSql.Conectar();
            connSql.connection.Open();
            connSql.connection.CreateCommand();
            connSql.comandoSQL = new MySqlCommand($"SELECT * FROM numeros_waba WHERE id = {id};", connSql.connection);
            MySqlCommand setcharset = new MySqlCommand("SET character_set_results=utf8", connSql.connection);

            MySqlDataReader dataReader = connSql.comandoSQL.ExecuteReader();

            List<NumeroWaba> listaRetornoId = new List<NumeroWaba>();
            while (dataReader.Read())
            {
                NumeroWaba numero = new NumeroWaba();

                numero.Id                    = dataReader.GetInt32  ("id");
                numero.Nome_Numero           = dataReader.GetString ("nome_numero");
                numero.Numero                = dataReader.GetString ("numero");
                numero.Empresa               = dataReader.GetString ("empresa");
                numero.Bm_id                 = dataReader.GetString ("bm_id");
                numero.DateTimeAtivacaoBD    = dataReader.GetDateTime ("data_ativacao");
                numero.Data_ativacao         = numero.DateTimeAtivacaoBD.ToString("dd/MM/yyyy HH:mm:ss");
                numero.DateTimeDesativacaoBD = dataReader.GetDateTime("data_desativacao");
                numero.Data_desativacao      = numero.DateTimeDesativacaoBD.ToString("dd/MM/yyyy HH:mm:ss");
                numero.Parceiro              = dataReader.GetString ("parceiro");
                numero.Ativo                 = dataReader.GetInt32  ("ativo");
                numero.Caminho_imagem        = dataReader.GetString ("caminho_imagem");

 
                

                listaRetornoId.Add(numero);
            }

            return listaRetornoId;
        }

        public List<NumeroWaba> SelectAll()
        {
            ConexaoDB connSql = new ConexaoDB();
            connSql.Conectar();
            connSql.connection.Open();
            connSql.connection.CreateCommand();
            connSql.comandoSQL = new MySqlCommand("SELECT * FROM numeros_waba;", connSql.connection);
            MySqlCommand setcharset = new MySqlCommand("SET character_set_results=utf8", connSql.connection);

            MySqlDataReader dataReader = connSql.comandoSQL.ExecuteReader();

            List<NumeroWaba> listaRetorno = new List<NumeroWaba>();

            while (dataReader.Read())
            {
                NumeroWaba numero = new NumeroWaba();

                numero.Id                    = dataReader.GetInt32  ("id");
                numero.Nome_Numero           = dataReader.GetString ("nome_numero");
                numero.Numero                = dataReader.GetString ("numero");
                numero.Empresa               = dataReader.GetString ("empresa");
                numero.Bm_id                 = dataReader.GetString ("bm_id");
                numero.DateTimeAtivacaoBD    = dataReader.GetDateTime("data_ativacao");
                numero.Data_ativacao         = numero.DateTimeAtivacaoBD.ToString("dd/MM/yyyy HH:mm:ss");
                numero.DateTimeDesativacaoBD = dataReader.GetDateTime("data_desativacao");
                numero.Data_desativacao      = numero.DateTimeDesativacaoBD.ToString("dd/MM/yyyy HH:mm:ss");
                numero.Parceiro              = dataReader.GetString ("parceiro");
                numero.Ativo                 = dataReader.GetInt32  ("ativo");
                numero.Caminho_imagem        = dataReader.GetString ("caminho_imagem");


                listaRetorno.Add(numero);
            }

            dataReader.Close();
            connSql.connection.Close();

            return listaRetorno;
        }

        public void Insert()
        {

            ConexaoDB connSql = new ConexaoDB();
            connSql.Conectar();
            connSql.connection.Open();

            connSql.comandoSQL = new MySqlCommand(NumeroWabaQueries.Inserir(this), connSql.connection);
            connSql.comandoSQL.ExecuteNonQuery();
            connSql.comandoSQL.Dispose();
            connSql.connection.Close();
        }

        public void Update()
        {
            ConexaoDB connSql = new ConexaoDB();
            connSql.Conectar();
            connSql.connection.Open();

            string dataAtivacaoFormatada;
            dataAtivacaoFormatada = this.DateTimeAtivacaoBD.ToString("yyyy-MM-dd HH:mm:ss");

            string dataDesativacaoFormatada;
            dataDesativacaoFormatada = this.DateTimeDesativacaoBD.ToString("yyyy-MM-dd HH:mm:ss");

            connSql.comandoSQL = new MySqlCommand($"UPDATE numeros_waba SET nome_numero = '{this.Nome_Numero}', numero = '{this.Numero}', bm_id = '{this.Bm_id}', empresa = '{this.Empresa}', data_ativacao = '{dataAtivacaoFormatada}', data_desativacao = '{dataDesativacaoFormatada}', parceiro = '{this.Parceiro}', ativo = {this.Ativo} ,caminho_imagem = '{this.Caminho_imagem}' WHERE `id`= {this.Id};", connSql.connection);
            connSql.comandoSQL.ExecuteNonQuery();
            connSql.comandoSQL.Dispose();
            connSql.connection.Close();
        }

        public void Delete()
        {
            ConexaoDB connSql = new ConexaoDB();
            connSql.Conectar();
            connSql.connection.Open();
            //connSql.comandoSQL = new MySqlCommand($"DELETE FROM numeros_waba WHERE id = {this.Id}", connSql.connection);
            connSql.comandoSQL = new MySqlCommand(NumeroWabaQueries.Delete(this.Id), connSql.connection);
            connSql.comandoSQL.ExecuteNonQuery();
            connSql.comandoSQL.Dispose();
            connSql.connection.Close();
        }
        #endregion
    }
}