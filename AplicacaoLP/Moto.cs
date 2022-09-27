using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacaoLP
{
    public class Moto
    {
        private int idMoto;
        private String placa;
        private String marca;
        private String modelo;
        private Double valor;

        public int IdMoto { get => idMoto; set => idMoto = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
