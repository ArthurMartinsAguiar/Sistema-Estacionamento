using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIOFUNDAMENTOS.Models
{
    public class Veiculo
    {
        public string ? placa = "";
        public int horarioDeEntrada; 

        public Veiculo(string placa, int horarioDeEntrada){
            this.placa = placa;
            this.horarioDeEntrada = horarioDeEntrada;
        }       
    }
}