using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class UsuarioEmpresa
    {
        private int id;
        private int idEmpresa;
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
        private string funcao;
        private string nivelEmp;
        private int qtdServicos;
        private string nivelEscolar;
        private string formacao;
        private int repMedia;
        private DateTime dataCadastro;
        private DateTime ultimoLogin;
        private int errosSenha;
        private int block;
        private int nivel;

        public UsuarioEmpresa(int id, int idEmpresa, string login, string senha, string nome, string email,
            string cpf, string tel1, string tel2, string endereco, int numero, string complemento,
            string cep, string cidade, string funcao, string nivelEmp, int qtdServicos, string nivelEscolar,
            string formacao, int repMedia, DateTime dataCadastro, DateTime ultimoLogin, int errosSenha,
            int block, int nivel)
        {
            this.id = id;
            this.idEmpresa = idEmpresa;
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
            this.funcao = funcao;
            this.nivelEmp = nivelEmp;
            this.qtdServicos = qtdServicos;
            this.nivelEscolar = nivelEscolar;
            this.formacao = formacao;
            this.repMedia = repMedia;
            this.dataCadastro = dataCadastro;
            this.ultimoLogin = ultimoLogin;
            this.errosSenha = errosSenha;
            this.block = block;
            this.nivel = nivel;
        }
        public UsuarioEmpresa()
        {

        }
        public int Id { get => id; set => id = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
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
        public string Funcao { get => funcao; set => funcao = value; }
        public string NivelEmp { get => nivelEmp; set => nivelEmp = value; }
        public int QtdServicos { get => qtdServicos; set => qtdServicos = value; }
        public string NivelEscolar { get => nivelEscolar; set => nivelEscolar = value; }
        public string Formacao { get => formacao; set => formacao = value; }
        public int RepMedia { get => repMedia; set => repMedia = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime UltimoLogin { get => ultimoLogin; set => ultimoLogin = value; }
        public int ErrosSenha { get => errosSenha; set => errosSenha = value; }
        public int Block { get => block; set => block = value; }
        public int Nivel { get => nivel; set => nivel = value; }
    }
}