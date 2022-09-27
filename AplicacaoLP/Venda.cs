using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacaoLP
{
    public class Venda
    {
        private int idVenda;
        Cliente cl;
        Pagamento pag;
        Moto mot;
        Vendedor vend;

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public Cliente Cl { get => cl; set => cl = value; }
        public Pagamento Pag { get => pag; set => pag = value; }
        public Moto Mot { get => mot; set => mot = value; }
        public Vendedor Vend { get => vend; set => vend = value; }
    }
}
