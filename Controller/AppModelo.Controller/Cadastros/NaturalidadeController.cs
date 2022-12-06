using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        /// <summary>
        /// Solicita dados de uma nova Naturalidade para cadastro no NaturalidadeRepository
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="ativo"></param>
        /// <returns>Retorna os dados cadastrados salvos no banco</returns>
        public bool Cadastrar(string descricao, bool ativo)
        {
            var repositorio = new NaturalidadeRepository();

            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if(naturalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao,ativo);
            return resposta;
        }
        
        /// <summary>
        /// Chama o metodo de atualização e sobrepoe a nova descrição
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CadastrarAtualizacao(string descricao, int id)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Atualizar(descricao, id);
            return resposta;
        }

        /// <summary>
        /// Exclui a Naturalidade do banco de dados atravez do ID dela.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool ExcluirNaturalidade(int Id)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Remover(Id);
            return resposta;
        }

        /// <summary>
        /// Chama a lista de todas as Naturalidades cadastradas no NaturalidadeRepository
        /// </summary>
        /// <returns></returns>
        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }

       
    }
}
