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
                        waba,
                        empresa, 
                        data_ativacao, 
                        data_desativacao,
                        data_ultima_modificacao,
                        parceiro, 
                        ativo, 
                        caminho_imagem,
                        descricao,
                        endereco,
                        email,
                        site) 
                    VALUES ('{numeroWaba.Nome_Numero}',
                            '{numeroWaba.Numero}',
                            '{numeroWaba.Bm_id}',
                            '{numeroWaba.Waba}',
                            '{numeroWaba.Empresa}',
                            '{numeroWaba.Data_ativacao:yyyy-MM-dd HH:mm:ss}',
                            '{numeroWaba.Data_desativacao:yyyy-MM-dd HH:mm:ss}',
                            '{numeroWaba.Data_ultima_modificacao:yyyy-MM-dd HH:mm:ss}',
                            '{numeroWaba.Parceiro}',
                             {numeroWaba.Ativo},
                            '{numeroWaba.Caminho_imagem}',
                            '{numeroWaba.Descricao}',
                            '{numeroWaba.Endereco}',
                            '{numeroWaba.Email}',
                            '{numeroWaba.Site}')";
        }    

        public static string Delete(int id)
        {
            return $"DELETE FROM numeros_waba WHERE id = {id}";
        }


        public static string Update(NumeroWaba numeroWaba)
        {
            return $@"UPDATE numeros_waba 
                      SET 
                        nome_numero =               '{numeroWaba.Nome_Numero}',
                        numero =                    '{numeroWaba.Numero}',
                        bm_id =                     '{numeroWaba.Bm_id}',
                        waba =                      '{numeroWaba.Waba}',
                        empresa =                   '{numeroWaba.Empresa}',
                        data_ativacao =             '{numeroWaba.Data_ativacao:yyyy-MM-dd HH:mm:ss}',
                        data_desativacao =          '{numeroWaba.Data_desativacao:yyyy-MM-dd HH:mm:ss}',
                        data_ultima_modificacao =   '{numeroWaba.Data_ultima_modificacao:yyyy-MM-dd HH:mm:ss}',
                        parceiro =                  '{numeroWaba.Parceiro}',
                        ativo =                      {numeroWaba.Ativo},
                        caminho_imagem =            '{numeroWaba.Caminho_imagem}',
                        descricao =                 '{numeroWaba.Descricao}',
                        endereco =                  '{numeroWaba.Endereco}',
                        email =                     '{numeroWaba.Email}',
                        site =                      '{numeroWaba.Site}'
                      WHERE 
                       `id`=                         {numeroWaba.Id};";
        }

    }
}