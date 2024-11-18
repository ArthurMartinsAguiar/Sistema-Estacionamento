using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DESAFIOFUNDAMENTOS.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string ? placa = "";
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            placa = Console.ReadLine();
            this.veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            string ? placa = "";
            
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                int horas = 0;
                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt16(Console.ReadLine());
                
                decimal valorTotal = 0; 
                valorTotal = this.precoInicial + this.precoPorHora * horas;
                
                this.veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach(var elem in this.veiculos){
                    Console.WriteLine(elem);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}