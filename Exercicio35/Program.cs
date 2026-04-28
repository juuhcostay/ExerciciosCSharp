// See https://aka.ms/new-console-template for more information
string aluno;
float p1, p2, p3;
Console.WriteLine("Digite a nota da prova de Portugues");
p1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da prova de Matematica");
p2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da prova de Conhecimentos Gerais");
p3 = float.Parse(Console.ReadLine());


if (p1 >= 7 && p2 >= 7 && p3 >= 7)
{ 
    Console.WriteLine("APROVADO:");
}
else if (p1 <= 7 && p2 <= 7 && p3 <= 7) 
{
    Console.WriteLine("Reprovado");
}

