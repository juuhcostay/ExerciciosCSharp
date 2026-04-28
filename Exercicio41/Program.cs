// See https://aka.ms/new-console-template for more information
string nome;
double numa, numb, minimo, comissao, final, porvendas;
Console.WriteLine("Digite o nome do vendedor: ");
nome = Console.ReadLine();
Console.WriteLine("Digite o numeros de carros por mes: ");
numa = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o numero de vendas por mes: ");
nome = float.Parse(Console.ReadLine());
minimo = 1600 * 2;
comissao = numb * 0.05;
final = minimo + comissao + porvendas;

Console.WriteLine("Salario fixo: " + minimo);
Console.WriteLine("Valor dos 5% das vendas: " + porvendas);
Console.WriteLine("Valor em comissao: " + comissao);
Console.WriteLine("Salario total: " + final);


