using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoLP
{
    public class Vendedor
    {
        int idVendedor;
        String usuario;
        String senha;

        public string Usuario { get => usuario; set => usuario = value; }
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
