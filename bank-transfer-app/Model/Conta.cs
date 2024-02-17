using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace bank_transfer_app.Model
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
         private string Nome { get; set; }
         private double Saldo { get; set; }
         private double Credito { get; set; }

        public Conta(TipoConta tipoConta, string nome, double saldo, double credito){
            TipoConta = tipoConta;
            Nome = nome;
            Saldo = saldo;
            Credito = credito;
        }

        public bool Sacar(double valor){
            if(Saldo - valor < Credito){
                System.Console.WriteLine("Saldo insuficiente.");
                return false;
            }
            Saldo -= valor;
            VerificarSaldo();
            return true;
        }

        public void Deposito(double valor){
            Saldo += valor;
            VerificarSaldo();
        }

        public void Transferir(double valor, Conta conta){
            if(Sacar(valor)){
                conta.Deposito(valor);
            }
        }

        public void VerificarSaldo(){            
            System.Console.WriteLine("Saldo atual da conta de {0} é R$ {1}\n", Nome, Saldo);
        }

        public override string ToString()
        {
            string texto = "";
            texto += $"Nome: {Nome}\n" +
            $"Tipo conta: {TipoConta}\n" +
            $"Saldo: {Saldo}\n" +
            $"Credito: {Credito}\n";
            return texto;
        }


    }
}