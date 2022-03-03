using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLocadora.Models
{
    public class Cliente
    {
        internal string nomeCLiente;

        public int codCliente {get; set;}
    public string nomeCliente {get; set;}

    public string CpfCliente { get; set; }
    public string enderecoCliente { get; set;}
    public string telefoneCliente { get; set;}
    public string emailCliente { get; set;}
    }
}