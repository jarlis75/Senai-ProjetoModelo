using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        /// <summary>
        /// SalvarCadastro - Instancia objeto do tipo FuncionarioRepository, enviando parametros advinhos do formulario frmCadastroDeFuncionarios
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="dataDeNascimento"></param>
        /// <param name="sexo"></param>
        /// <param name="cpf"></param>
        /// <param name="id_nacionalidade"></param>
        /// <param name="id_naturalidade"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="telefone_contato"></param>
        /// <param name="cep"></param>
        /// <param name="logradouro"></param>
        /// <param name="numero"></param>
        /// <param name="complemento"></param>
        /// <param name="bairro"></param>
        /// <param name="municipio"></param>
        /// <param name="uf"></param>
        /// <returns>Retorna uma Variavel que contem parametros para instanciação do metodo inserir no FuncionarioRepositorio</returns>
        
        public bool SalvarCadastro(string nome, DateTime dataDeNascimento, bool sexo, string cpf, int id_nacionalidade, int id_naturalidade, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento,string bairro, string municipio, string uf )
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(nome, dataDeNascimento, sexo, cpf, id_nacionalidade, id_naturalidade, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf);
            return resposta;
        }
        /// <summary>
        /// List - Instancia uma List FuncionarioEntity e busca o repositorio onde se encontram as informações
        /// </summary>
        /// <returns>Chama a lista que se encontra registrada no banco de dados e faz uma lista de todos</returns>
        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return (List<FuncionarioEntity>)resposta;
        }

    }
}
