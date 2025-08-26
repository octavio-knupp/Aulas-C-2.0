# Aulas-C-2.0

# Aula -03
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite a nota1: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a nota2: ");
double nota2 = double.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de faltas: ");
double qtdFalta = double.Parse(Console.ReadLine());

double qtdAulas = 80;
double qtdpresenca = qtdAulas - qtdFalta;
double percentualPresenca = (qtdpresenca * 100) / qtdAulas;
Console.WriteLine($"O percentual de presença é {percentualPresenca}%.");
//percentualPresenca = double.Parse(Console.ReadLine());

Console.WriteLine($"As notas são {nota1} | {nota2}");


double media = (nota1 + nota2) / 2;
Console.WriteLine($"A média das notas é {media}");


Console.Write("Digite um número: ");
int n1 = int.Parse(Console.ReadLine());

int i = 1;
int r = 0;
while (i <= 10)
{
    r = n1 * i;
    Console.WriteLine($"{n1} X {i} = {r}");
    i++;
 
}


