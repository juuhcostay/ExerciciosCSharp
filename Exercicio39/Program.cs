// See https://aka.ms/new-console-template for more information
string nome;
int valor, valorpg, total;
Console.WriteLine("Digite o valor da compra: ");
valor = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor pago: ");
valorpg = int.Parse(Console.ReadLine());

total = valorpg - valor;

if (total > 99)
{
    Console.WriteLine("O troco sera com nota de 100");
}
if (total > 10 && total < 100)
{
    Console.WriteLine("O troco sera com nota de 10");
}
if (total < 10)
{
    Console.WriteLine("O troco sera com nota de 1");
}





