// See https://aka.ms/new-console-template for more information
string nome;
float idade, soma, total;
Console.WriteLine("Digite o sua idade:");
idade = float.Parse(Console.ReadLine());

soma = idade * 12;
total = soma * 30;
Console.WriteLine("Voce tem " + total + "dias vividos");
