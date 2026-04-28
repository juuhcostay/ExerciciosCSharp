// See https://aka.ms/new-console-template for more information
string nome;
float p1, p2, p3, total;
Console.WriteLine("Digite a nota da prova 1: ");
p1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da prova 2:");
p2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da prova 3:");
p3 = float.Parse(Console.ReadLine());

total= (p1+ p2 + p3) / 3;
Console.WriteLine("A media é: " + total);