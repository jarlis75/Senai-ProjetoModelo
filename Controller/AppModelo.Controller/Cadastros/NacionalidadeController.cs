﻿using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        public bool Cadastrar(string descricao, bool ativo)
        {
            var repositorio = new NacionalidadeRepository();

            var nacionalidade = repositorio.ObterPorDescricao (descricao);
            if (nacionalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao, ativo);
            return resposta;
        }

        public bool CadastrarAtualizacao(string descricao, int id)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(descricao, id);
            return resposta;
        }
        public bool ExcluirNacionalidade(int Id)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Remover(Id);
            return resposta;
        }


        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }
    }
}