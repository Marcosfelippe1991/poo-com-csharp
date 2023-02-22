using BancoCSharp.Models;

Console.WriteLine("************************************");
Console.WriteLine("********** Banco CSharp ************");
Console.WriteLine("************************************");
System.Console.WriteLine();

var endereco = new Endereco
{
    Cep = "25645060",
    Rua = "ABC",
    Numero = 20
};

var titular01 = new Titular("José da Silva", "12345678901", "2199997788", endereco);


var conta01 = new ContaBancaria(titular01, 100,00);

System.Console.WriteLine(conta01.Saldo);