// See https://aka.ms/new-console-template for more information

using bank_transfer_app.Model;

Conta minhaConta = new Conta(TipoConta.PessoaFisica, "Matheus", 2000, 0);
Conta outraConta = new(TipoConta.PessoaFisica, "Julio", 0, 0);

System.Console.WriteLine(minhaConta);
System.Console.WriteLine(outraConta);

minhaConta.Sacar(200);
minhaConta.Transferir(1200, outraConta);
outraConta.Deposito(300);




System.Console.WriteLine(minhaConta);
System.Console.WriteLine(outraConta);