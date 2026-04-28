// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
string nome;
float v1;
Console.WriteLine("Digite o nome:");
nome = Console.ReadLine();
Console.WriteLine("Digite o valor das vendas:");
v1 = float.Parse(Console.ReadLine());

if (v1 >= 50.000)
{
    Console.WriteLine("A comissao sera de 12%! = R$" + v1 * 0.12);

}
else if (v1 >= 30.000 && v1 <= 50.000)
{
    Console.WriteLine("A comissao sera de 9.5%! = R$" + v1 * 0.095);

}
else
{
    Console.WriteLine("A comissao sera de 7%! = R$" + v1 * 0.7);
}
