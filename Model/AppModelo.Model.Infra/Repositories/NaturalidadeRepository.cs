using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        //CRUD - create - read   - update - delete
        //       insert - select - update - delete  
        public bool Inserir(string descricao, bool ativo)
        {
            //string interpolation
            var agora = DateTime.Now.ToString("u");
            var sql = $"INSERT INTO naturalidade (descricao, dataCriacao, dataAlteracao, ativo) VALUES ('{descricao}','{agora}','{agora}', {ativo})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public bool Atualizar(string descricao, int id)
        {
            //string interpolation
            var sql = $"UPDATE naturalidade SET descricao = '{descricao}'  WHERE id = '{id}'";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public bool Remover(int id)
        {
            //string interpolation
            var sql = $"DELETE FROM naturalidade  WHERE id  = '{id}'";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM naturalidade";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodosAtivos()
        {
            var sql = "SELECT id, descricao FROM naturalidade ORDER BY descricao DESC WHERE ativo = true";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        }
        public NacionalidadeEntity ObterPorDescricao(String descricao)
        {
            var sql = $"Select id,descricao FROM naturalidade WHERE descricao = '{descricao}'";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.QuerySingleOrDefault<NacionalidadeEntity> (sql);
            return resultado;
        }
        
    }
}
