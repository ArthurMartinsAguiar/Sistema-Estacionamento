using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DESAFIOFUNDAMENTOS.Models
{
    public class Estacionamento
    {
       /*Possui 3 atributos: 

        decimal precoInicial; 
        decimal precoPorHora;
        List<string> listaDeVeiculos;

        A tipagem decimal permite maior precisão em termos numéricos.

        Métodos:

        Registrar placa
        revomer veiculo
        listar veiculos
       
       */

        // O modificador de tipo private especifica que a variavel somente pode
        // ser acessado dentro da classe que há sua definição;

        private decimal precoInicial;
        private decimal precoPorHora;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void registrarVeiculo(){
            string ? placa = "";
            int horarioDeEntrada;

            Console.WriteLine("Placa: ");
            placa = Console.ReadLine();
            horarioDeEntrada = DateTime.Now.Hour;

            if (veiculos.Any(x => x.placa == placa.ToUpper())){
                Console.WriteLine("Veículos já registrado!");
            }
            else{
                veiculos.Add(new Veiculo(placa.ToUpper(), horarioDeEntrada));
                Console.WriteLine("Veículo registrado...");
            }
            
        }

        public void removerVeiculo(){
            string ? placa = "";
            decimal valorTotal = 0;
            int horarioAtual = DateTime.Now.Hour;

            Console.WriteLine("Placa: ");
            placa = Console.ReadLine();

            if (veiculos.Any(x => x.placa == placa.ToUpper())){

                var veiculoASerRemovido = veiculos.Find(x => x.placa == placa.ToUpper());
                valorTotal = precoInicial + precoPorHora * (horarioAtual - veiculoASerRemovido.horarioDeEntrada);

                Console.WriteLine($"Valor a ser pago: R$ {valorTotal}");

                veiculos.Remove(veiculoASerRemovido);
                Console.WriteLine("Veículo removido...");

            }
            else{
                Console.WriteLine("Placa de veículo não registrada...Verifique novamente.");
            }
        }

        public void listarVeiculos(){

            if (veiculos == null){
                Console.WriteLine("Estacionamento vazio...");
            }

            foreach (Veiculo v in veiculos){
                Console.WriteLine($"PLACA - {v.placa} HORÁRIO DE ENTRADA: {v.horarioDeEntrada}");
            }
        }

    }
}