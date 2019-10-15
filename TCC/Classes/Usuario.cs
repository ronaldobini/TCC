﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{

    public class Usuario
    {
        private int id;
        private string login;
        private string senha;
        private string nome;
        private string email;
        private string cpf;
        private string tel1;
        private string tel2;
        private string endereco;
        private int numero;
        private string complemento;
        private string cep;
        private string cidade;
        private string reputacao;
        private DateTime dataCadastro;
        private DateTime ultimoLogin;
        private int errosSenha;
        private int block;
        private int nivel;

        public Usuario()
        {

        }
        public Usuario(int id, string login, string senha, string nome, string email,
            string cpf, string tel1, string tel2, string endereco, int numero, string complemento,
            string cep, string cidade, string reputacao, DateTime dataCadastro, DateTime ultimoLogin,
            int errosSenha, int block, int nivel)
        {
            this.id = id;
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.tel1 = tel1;
            this.tel2 = tel2;
            this.endereco = endereco;
            this.numero = numero;
            this.complemento = complemento;
            this.cep = cep;
            this.cidade = cidade;
            this.reputacao = reputacao;
            this.dataCadastro = dataCadastro;
            this.ultimoLogin = ultimoLogin;
            this.errosSenha = errosSenha;
            this.block = block;
            this.nivel = nivel;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Tel1 { get => tel1; set => tel1 = value; }
        public string Tel2 { get => tel2; set => tel2 = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Reputacao { get => reputacao; set => reputacao = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime UltimoLogin { get => ultimoLogin; set => ultimoLogin = value; }
        public int ErrosSenha { get => errosSenha; set => errosSenha = value; }
        public int Block { get => block; set => block = value; }
        public int Nivel { get => nivel; set => nivel = value; }
    }
}