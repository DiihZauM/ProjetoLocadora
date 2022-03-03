using ProjetoLocadora.Dados;
using ProjetoLocadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLocadora.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        Filme ab = new Filme();
        clLivrosAcoes ac = new clLivrosAcoes();
        public ActionResult AlugarFilme(string btn, FormCollection frm)
        {

            if (btn == "Buscar")
            {
                ab.codFilme = frm["txtCod"];
                ac.BuscarFilme(ab);
                ViewBag.cod = ab.codFilme;
                ViewBag.nome = ab.nomeFilme;
                ViewBag.status = ab.sta;
                return View();

            }

            else if (btn == "Atualizar")
            {
                ab.codFilme = frm["txtCod"];
                ab.nomeFilme = frm["txtNome"];
                ab.sta = frm["txtStatus"];
                ac.atualizarFilme(ab);
                return View();
            }

            else
            {
                return View();
            }

        }
        Cliente cli = new Cliente();
        ClClienteAcoes cl = new ClClienteAcoes();
        public ActionResult CadCliente(String btn, FormCollection frm)
        {
            if (btn == "cadastrar")
            {
                cli.nomeCliente = frm["txtNome"];
                cli.CpfCliente = frm["txtCpf"];
                cli.enderecoCliente = frm["txtEndereco"];
                cli.emailCliente = frm["txtEmail"];
                cli.telefoneCliente = frm["txtTelefone"];
                cl.CadastroCliente(cli);
                return View();



            }

            else if (btn == "Deletar")
            {
                cli.CpfCliente = frm["txtCpf"];
                cl.DeletarCliente(cli);
                return View();

            }
            else
            {

                return View();
            }
        }
    }
}
