using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacaoLP
{
    public class Pagamento
    {
        private int idPagamento;
        private String tipo_pagamento;

        public int IdPagamento { get => idPagamento; set => idPagamento = value; }
        public string Tipo_pagamento { get => tipo_pagamento; set => tipo_pagamento = value; }
    }
}
