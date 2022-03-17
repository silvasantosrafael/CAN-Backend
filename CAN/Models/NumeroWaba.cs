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
        public string Waba { get; set; }
        public string Empresa { get; set; }
        public string Bm_id { get; set; }
        public DateTime Data_ativacao { get; set; }
        public DateTime Data_desativacao { get; set; }
        public string Parceiro { get; set; }
        public int Ativo { get; set; }
        public string Caminho_imagem { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }



        public NumeroWaba()
        {

        }

        public NumeroWaba(int id)
        {
            this.Id = id;
        }

        #region Colocar estes metodos numa classe NumeroWabaRepositorio
        public List<NumeroWaba> Select()
        {
            ConexaoDB connSql = new ConexaoDB();
            connSql.Conectar();
            connSql.connection.Open();
            connSql.connection.CreateCommand();
            connSql.comandoSQL = new MySqlCommand(NumeroWabaQueries.Select(this.Id), connSql.connection);
            MySqlCommand setcharset = new MySqlCommand("SET character_set_results=utf8", connSql.connection);

            MySqlDataReader dataReader = connSql.comandoSQL.ExecuteReader();

            List<NumeroWaba> listaRetornoId = new List<NumeroWaba>();
            while (dataReader.Read())
            {
                NumeroWaba numero = new NumeroWaba();

                numero.Id                    = dataReader.GetInt32   ("id");
                numero.Nome_Numero           = dataReader.GetString  ("nome_numero");
                numero.Numero                = dataReader.GetString  ("numero");
                numero.Waba                  = dataReader.GetString  ("waba");
                numero.Empresa               = dataReader.GetString  ("empresa");
                numero.Bm_id                 = dataReader.GetString  ("bm_id");
                numero.Data_ativacao         = dataReader.GetDateTime("data_ativacao");
                numero.Data_desativacao      = dataReader.GetDateTime("data_desativacao");
                numero.Parceiro              = dataReader.GetString  ("parceiro");
                numero.Ativo                 = dataReader.GetInt32   ("ativo");
                numero.Caminho_imagem        = dataReader.GetString  ("caminho_imagem");
                numero.Descricao             = dataReader.GetString  ("Descricao");
                numero.Endereco              = dataReader.GetString  ("Endereco");
                numero.Email                 = dataReader.GetString  ("Email");
                numero.Site                  = dataReader.GetString  ("Site");

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
            connSql.comandoSQL = new MySqlCommand(NumeroWabaQueries.SelectAll(), connSql.connection);
            MySqlCommand setcharset = new MySqlCommand("SET character_set_results=utf8", connSql.connection);

            MySqlDataReader dataReader = connSql.comandoSQL.ExecuteReader();

            List<NumeroWaba> listaRetorno = new List<NumeroWaba>();

            while (dataReader.Read())
            {
                NumeroWaba numero = new NumeroWaba();

                numero.Id                    = dataReader.GetInt32   ("id");
                numero.Nome_Numero           = dataReader.GetString  ("nome_numero");
                numero.Numero                = dataReader.GetString  ("numero");
                numero.Waba                  = dataReader.GetString  ("waba");
                numero.Empresa               = dataReader.GetString  ("empresa");
                numero.Bm_id                 = dataReader.GetString  ("bm_id");
                numero.Data_ativacao         = dataReader.GetDateTime("data_ativacao");
                numero.Data_desativacao      = dataReader.GetDateTime("data_desativacao");
                numero.Parceiro              = dataReader.GetString  ("parceiro");
                numero.Ativo                 = dataReader.GetInt32   ("ativo");
                numero.Caminho_imagem        = dataReader.GetString  ("caminho_imagem");
                numero.Descricao             = dataReader.GetString  ("Descricao");
                numero.Endereco              = dataReader.GetString  ("Endereco");
                numero.Email                 = dataReader.GetString  ("Email");
                numero.Site                  = dataReader.GetString  ("Site");

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
            connSql.comandoSQL = new MySqlCommand(NumeroWabaQueries.Update(this), connSql.connection);
            connSql.comandoSQL.ExecuteNonQuery();
            connSql.comandoSQL.Dispose();
            connSql.connection.Close();
        }

        public void Delete()
        {
            ConexaoDB connSql = new ConexaoDB();
            connSql.Conectar();
            connSql.connection.Open();
            connSql.comandoSQL = new MySqlCommand(NumeroWabaQueries.Delete(this.Id), connSql.connection);
            connSql.comandoSQL.ExecuteNonQuery();
            connSql.comandoSQL.Dispose();
            connSql.connection.Close();
        }
        #endregion
    }
}