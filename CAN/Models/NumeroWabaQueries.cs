namespace CAN.Models
{
    public static class NumeroWabaQueries
    {
        public static string Delete(int id) => $"DELETE FROM numeros_waba WHERE id = {id}";

        public static string Inserir(NumeroWaba numeroWaba) => $@"INSERT INTO numeros_waba
                                                            (nome_numero, 
                                                            numero, 
                                                            bm_id, 
                                                            empresa, 
                                                            data_ativacao, 
                                                            data_desativacao, 
                                                            parceiro, 
                                                            ativo, 
                                                            caminho_imagem) 
                                                            VALUES('{numeroWaba.Nome_Numero}', 
'{numeroWaba.Numero}', 
'{numeroWaba.Bm_id}', '{numeroWaba.Empresa}', '{numeroWaba.Data_ativacao}', '{numeroWaba.Data_desativacao}','{numeroWaba.Parceiro}', { numeroWaba.Ativo},'{numeroWaba.Caminho_imagem}')";
    
        
    }
}