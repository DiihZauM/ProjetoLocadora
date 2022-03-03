using ProjetoLocadora.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLocadora.Dados
{
    public class clLivrosAcoes
    {
        conexao con = new conexao();

        public void inserirLivro(Filme cm) // cm: É um objeto que vai trazer as "VARIAVEIS DO MODELO".
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbFilme (nomeFilme, sta) values (@nome, @sta)", con.MyConectarBD()); // @: PARAMETRO


            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = cm.nomeFilme;
            cmd.Parameters.Add("@sta", MySqlDbType.VarChar).Value = cm.sta;

            // nomeCli e telCli: São variaveis

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();

        }

        public void excluirFilme(string valor)
        {

            MySqlCommand cmd = new MySqlCommand("delete from tbFilme where codFilme=@cod", con.MyConectarBD());

            cmd.Parameters.Add("@cod", MySqlDbType.VarChar).Value = valor;
            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();
        }


        MySqlDataReader dr;
        public void BuscarFilme(Filme cm)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tbFilme where codFilme=@codfil", con.MyConectarBD());
            cmd.Parameters.AddWithValue("@codfil", cm.codFilme);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cm.nomeFilme = dr[1].ToString();
                cm.sta = dr[2].ToString();
                
            }

            con.MyDesConectarBD();

        }
        public void atualizarFilme(Filme cm)
        {

            MySqlCommand cmd = new MySqlCommand("update tbFilme set nomeFilme=@nomeFilme, sta=@status where codFilme=@codFilme", con.MyConectarBD());

            cmd.Parameters.Add("@codFilme", MySqlDbType.VarChar).Value = cm.codFilme;
            cmd.Parameters.Add("@nomeFilme", MySqlDbType.VarChar).Value = cm.nomeFilme;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = cm.sta;

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();

        }







    }
}