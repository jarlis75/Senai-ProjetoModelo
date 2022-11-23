using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    /// <summary>
    /// 
    /// </summary>
    public class FuncionarioController
    {
        public bool SalvarCadastro(string nome, DateTime dataDeNascimento, bool sexo, string cpf, int id_nacionalidade, int id_naturalidade, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento,string bairro, string municipio, string uf )
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(nome, dataDeNascimento, sexo, cpf, id_nacionalidade, id_naturalidade, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf);
            return resposta;
        }

        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return (List<FuncionarioEntity>)resposta;
        }

    }
}
