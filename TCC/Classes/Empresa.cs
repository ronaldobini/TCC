using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Empresa
    {
        private int id;
        private int idDiretor;
        public UsuarioEmpresa diretor { get; set; }
        private int idComercial;
        public UsuarioEmpresa representanteComercial { get; set; }
        private int idTecnico;
        public UsuarioEmpresa representateTecnico { get; set; }
        private string cnpj;
        private string razaoSocial;
        private string tel1;
        private string tel2;
        private string endereco;
        private int numero;
        private string complemento;
        private string cep;
        private double lat;
        private double lon;
        //private int idCidade;
        public Cidade cidade { get; set; }
        private MySqlDateTime inicioEmpresa;
        private string descEmpresa;
        private int qtdFuncionarios;
        private int repTempo;
        private int repQualidade;
        private int repAtendimento;
        private int repQuantidade;
        private int repFiscal;
        private int qtdServ;
        private string zonaAtendimento;
        private MySqlDateTime dataCadastro;
        private int block;

        public Empresa(int id, int idDiretor, int idComercial, int idTecnico, string cnpj, string razaoSocial,
            string tel1, string tel2, string endereco, int numero, string complemento, string cep, double lat, double lon, Cidade cidade,
            MySqlDateTime inicioEmpresa, string descEmpresa, int qtdFuncionarios, int repTempo, int repQualidade, int repAtendimento,
            int repQuantidade, int repFiscal, int qtdServ, string zonaAtendimento, MySqlDateTime dataCadastro, int block)
        {
            this.id = id;
            this.idDiretor = idDiretor;
            this.idComercial = idComercial;
            this.idTecnico = idTecnico;
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
            this.tel1 = tel1;
            this.tel2 = tel2;
            this.endereco = endereco;
            this.numero = numero;
            this.complemento = complemento;
            this.cep = cep;
            this.lat = lat;
            this.lon = lon;
            this.cidade = cidade;
            this.inicioEmpresa = inicioEmpresa;
            this.descEmpresa = descEmpresa;
            this.qtdFuncionarios = qtdFuncionarios;
            this.repTempo = repTempo;
            this.repQualidade = repQualidade;
            this.repAtendimento = repAtendimento;
            this.repQuantidade = repQuantidade;
            this.repFiscal = repFiscal;
            this.qtdServ = qtdServ;
            this.zonaAtendimento = zonaAtendimento;
            this.dataCadastro = dataCadastro;
            this.block = block;
        }
        public Empresa()
        {

        }

        public int Id { get => id; set => id = value; }
        public int IdDiretor { get => idDiretor; set => idDiretor = value; }
        public int IdComercial { get => idComercial; set => idComercial = value; }
        public int IdTecnico { get => idTecnico; set => idTecnico = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Tel1 { get => tel1; set => tel1 = value; }
        public string Tel2 { get => tel2; set => tel2 = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep { get => cep; set => cep = value; }
        public double Lat { get => lat; set => lat = value; }
        public double Lon { get => lon; set => lon = value; }
        //public int IdCidade { get => idCidade; set => idCidade = value; }
        public MySqlDateTime InicioEmpresa { get => inicioEmpresa; set => inicioEmpresa = value; }
        public string DescEmpresa { get => descEmpresa; set => descEmpresa = value; }
        public int QtdFuncionarios { get => qtdFuncionarios; set => qtdFuncionarios = value; }
        public int RepTempo { get => repTempo; set => repTempo = value; }
        public int RepQualidade { get => repQualidade; set => repQualidade = value; }
        public int RepAtendimento { get => repAtendimento; set => repAtendimento = value; }
        public int RepQuantidade { get => repQuantidade; set => repQuantidade = value; }
        public int RepFiscal { get => repFiscal; set => repFiscal = value; }
        public string ZonaAtendimento { get => zonaAtendimento; set => zonaAtendimento = value; }
        public MySqlDateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public int Block { get => block; set => block = value; }
        public int QtdServ { get => qtdServ; set => qtdServ = value; }
    }
}