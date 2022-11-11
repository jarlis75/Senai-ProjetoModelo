using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        public bool Cadastrar(string descricao, bool ativo)
        {
            var repositorio = new NaturalidadeRepository();

            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if(naturalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao,ativo);
            return resposta;
        }

        public bool CadastrarAtualizacao(string descricao, int id)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Atualizar(descricao, id);
            return resposta;
        }

        public bool ExcluirNaturalidade(int Id)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Remover(Id);
            return resposta;
        }

        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }

       
    }
}
