using MySql.Data.MySqlClient;
using ProjetoLocadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLocadora.Dados
{
    public class ClClienteAcoes
    {
        conexao con = new conexao();  
        
        public void CadastroCliente (Cliente cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbCliente (NomeCliente,EnderecoCliente,telefoneCliente,EmailCliente,CpfCliente) values (@nome, @endereco,@telefone,@email,@cpf)", con.MyConectarBD());

            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = cm.nomeCliente;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = cm.enderecoCliente;
            cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = cm.telefoneCliente;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = cm.emailCliente;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cm.CpfCliente;

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();

        }

        public void DeletarCliente (Cliente Dl)
        {
            MySqlCommand cmd = new MySqlCommand("delete from tbCliente where CpfCliente=@cpf", con.MyConectarBD());
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Dl.CpfCliente;

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();
        }
    }
}