using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        /// <summary>
        /// Cadastrar - Inseri uma nova Nacionalidade no NacionalidadeRepository.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="ativo"></param>
        /// <returns> Ela inseri a Nacionalidade se  </returns>
        public bool Cadastrar(string descricao, bool ativo)
        {
            var repositorio = new NacionalidadeRepository();

            var nacionalidade = repositorio.ObterPorDescricao (descricao);
            if (nacionalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao, ativo);
            return resposta;
        }
        /// <summary>
        /// Metodo usado para cadastrar uma nova atualização no Nacionalidade Repositorio.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns>Banco Atualizado</returns>
        public bool CadastrarAtualizacao(string descricao, int id)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(descricao, id);
            return resposta;
        }
        /// <summary>
        /// Seleciona pelo Id para assim então realizar a Exclusao
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Exclui a Nacionalidade pelo ID</returns>
        public bool ExcluirNacionalidade(int Id)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Remover(Id);
            return resposta;
        }

        /// <summary>
        /// Vai no banco de dados e puxa todas as Nacionalidades registradas no mesmo
        /// </summary>
        /// <returns></returns>
        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }
    }
}
