namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        public static string ConectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline09;uid=wwonline09;password=aluno22senai;";
            return conn;
        }
    }
}
