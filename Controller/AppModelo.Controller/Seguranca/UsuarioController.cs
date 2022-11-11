using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModelo.Model.Infra.Services;

namespace AppModelo.Controller.Seguranca
{
    public class UsuarioController
    {
        public bool EfetuarLogin(string usuario, string senha)
        {
            var repositorio = new UsuarioRepository();
            var usuarioEncontrado = repositorio.Obter(usuario, senha);
            if (usuarioEncontrado is not null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RecuperarSenha(string email)
        {
            //1 PASSO VERIFICA SE EMAIL É DE UM USUARIO
            var repository = new UsuarioRepository();
            var usuario = repository.ObterPorEmail(email);
            if(usuario is null)
            {
                return "Usuario não foi encontrado";
            }

            //2 PASSO GERAR SENHA NOVA E GRAVA NO BANCO DE DADOS
            var novaSenha = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            var atualizouSenha = repository.AtualizarSenha(email, novaSenha);
            if(atualizouSenha is false)
            {
                return "Programador errou o sql e vc não pode recuperar sua senha";
            }

            //3 PASSO MANDAR A NOVA SENHA PARA O E-MAIL
            var emailService = new EmailService();
            var mensagemHtml = @"<p><b>Criamos uma nova senha para você</p></b><p> Sua nova senha é: </p>" + novaSenha + "</p></b>";
            var emailEnviado = emailService.EnviarEmail(usuario.Nome, usuario.Email, "Recuperação de Senha",mensagemHtml);

            return "";
        }

        

    }

    


}

