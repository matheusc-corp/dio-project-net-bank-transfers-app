using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace bank_transfer_app.Model
{
    public class Menu
    {
        List<Conta> listaContas = new List<Conta>();


        public string ObterOpcaoUsuario(){
            System.Console.WriteLine();
            System.Console.WriteLine("DIO Bank a seu dispor!!!");
            System.Console.WriteLine("Informe a opcao desejada:");
            
            System.Console.WriteLine("1- Listar contas");
            System.Console.WriteLine("2- Inserir uma nova conta");
            System.Console.WriteLine("3- Transferir");
            System.Console.WriteLine("4- Sacar");
            System.Console.WriteLine("5- Depositar");
            System.Console.WriteLine("C- Limpar tela");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();

            string opcaoUsuario = System.Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }

        public void Acoes(){
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1":
                        ListarContas();
                        break;

                    case "2":
                        InserirConta();
                        break;

                    case "3":
                        // Transferir();
                        break;

                    case "4":
                        // Sacar();
                        break;

                    case "5":
                        // Depositar();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            System.Console.WriteLine("Obrigado por utilizar nossos serviços!");
            System.Console.ReadLine();
        }

        private void ListarContas()
        {
            System.Console.WriteLine("Listar contas");

            if(listaContas.Count == 0){
                System.Console.WriteLine("Nenhuma conta cadastrada.");

                return;
            }

            foreach(Conta conta in listaContas){
                System.Console.WriteLine(conta);
            }
        }

        private void InserirConta()
        {
            System.Console.WriteLine("Inserir nova conta");

            System.Console.WriteLine("Digite 1 para Conta Fisica ou 2 para Juridica:");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do cliente:");
            string entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite o saldo inicial:");
            double entradaSaldo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o credito inicial:");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta((TipoConta) entradaTipoConta, entradaNome, entradaSaldo, entradaCredito);

            listaContas.Add(novaConta);

        }
    }
}