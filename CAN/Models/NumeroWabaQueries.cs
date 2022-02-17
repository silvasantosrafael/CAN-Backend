namespace CAN.Models
{
    public static class NumeroWabaQueries
    {
        public static string Select(int id)
        {
            return $@"SELECT * 
                        FROM numeros_waba 
                        WHERE id = {id};";
        }

        public static string SelectAll()
        {
            return @"SELECT * 
                        FROM numeros_waba;";
        }
        
        public static string Inserir(NumeroWaba numeroWaba)
        {
            return $@"INSERT INTO numeros_waba
                       (nome_numero, 
                        numero, 
                        bm_id, 
                        empresa, 
                        data_ativacao, 
                        data_desativacao, 
                        parceiro, 
                        ativo, 
                        caminho_imagem) 
                    VALUES ('{numeroWaba.Nome_Numero}',
                            '{numeroWaba.Numero}',
                            '{numeroWaba.Bm_id}',
                            '{numeroWaba.Empresa}',
                            '{numeroWaba.Data_ativacao:yyyy-MM-dd HH:mm:ss}',
                            '{numeroWaba.Data_desativacao:yyyy-MM-dd HH:mm:ss}',
                            '{numeroWaba.Parceiro}',
                             {numeroWaba.Ativo},
                            '{numeroWaba.Caminho_imagem}')";
        }    

        public static string Delete(int id)
        {
            return $"DELETE FROM numeros_waba WHERE id = {id}";
        }


        public static string Update(NumeroWaba numeroWaba)
        {
            return $@"UPDATE numeros_waba 
                      SET 
                        nome_numero =      '{numeroWaba.Nome_Numero}',
                        numero =           '{numeroWaba.Numero}',
                        bm_id =            '{numeroWaba.Bm_id}',
                        empresa =          '{numeroWaba.Empresa}',
                        data_ativacao =    '{numeroWaba.Data_ativacao:yyyy-MM-dd HH:mm:ss}',
                        data_desativacao = '{numeroWaba.Data_desativacao:yyyy-MM-dd HH:mm:ss}',
                        parceiro =         '{numeroWaba.Parceiro}',
                        ativo =             {numeroWaba.Ativo},
                        caminho_imagem =   '{numeroWaba.Caminho_imagem}' 
                      WHERE 
                       `id`=                {numeroWaba.Id};";
        }

    }
}