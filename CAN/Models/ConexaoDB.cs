using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace CAN.Models
{
    public class ConexaoDB
    {
        //Por a string de conexão no webconfig
        //Altrerar o modificador de acesso para private e readonly, não são dados que devem ser alterados por classes externas
        //Ver o padrão sigleton, isso pode ajudar
        public string connString = "Server=localhost;Database=waba;Uid=root;Pwd=root";
        public MySqlConnection connection;
        public MySqlCommand comandoSQL;

        public void Conectar()
        {
            connection = new MySqlConnection(connString);
            try
            {
                connection.Open();
            }
            //utilizar o catch para capturar erros que podem ajudar na depuração
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}