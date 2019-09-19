using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class Index : System.Web.UI.Page
    {
        public string results = "-";
        protected void Page_Load(object sender, EventArgs e)
        {

            Conn c = new Conn();
            //results = c.conectarErros();

            //results = "asp ok";


            try
            {

                MySqlConnection conn = c.conectar();
                string sql = "SELECT * FROM usuario";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();


                results = reader.GetString(3);

            }
            catch (Exception err)
            {
                results = "ERRO: " + err;
            }

            //INSERT INTO `usuario` (`id`, `login`, `senha`, `nome`, `email`, `cpf`, `telefone1`, `telefone2`, `endereco`, `numero`, `complemento`, `cep`, `cidade`, `reputacao`, `data_cadastro`, `ultimo_login`, `erros_senha`, `block`, `nivel_acesso`) VALUES (NULL, 'admin', '123', 'administrator', 'adm@adm.com', '12312312321', '555', '555', 'Rua dos adms', '321', 'superadmin', '81578989', 'curitiba', '10', '2019-09-04 00:00:00', '2019-09-04 00:00:00', '0', '0', '10');

        }
    }
}