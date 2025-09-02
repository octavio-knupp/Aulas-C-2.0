Console.WriteLine("Hello Word!!");
//nome usar a variavel do tipo string
string nomeAluno = "Octavio Henrique Knupp Lucio";
// numero usa a variavel do tipo int
int periodo = 1;
//nota usa a varivel do tipo float
float nota1Bim = 9.3f;
//nota usa a varivel do tipo float
float nota2Bim = 7.5f;
//nota usa a varivel do tipo float
float somaNotas = nota1Bim + nota2Bim;
//nota usa a varivel do tipo float
float media = somaNotas / 2;
Console.WriteLine("Nome: "+nomeAluno);
Console.WriteLine("Periodo: "+periodo);
Console.WriteLine("Nota 1 Bim: "+nota1Bim);
Console.WriteLine("Nota 2 Bim: "+nota2Bim);
Console.WriteLine("Soma das notas: "+somaNotas);
Console.WriteLine("Média das notas: "+media);
Console.ReadKey();

//próxima aula 

//void SomarDoisValores(int a, int b)
//{
//    //int a = 20;
//    //int b = 35;
//    int soma = a + b;
//    Console.Write($"A soma de {a} e {b} é igual a {soma}");
//}
//SomarDoisValores(8889,5565);
//SomarDoisValores(8889, 10000000);
//hardcode



int SomarDoisValores(int valor1, int valor2)
{
    int soma = valor1 + valor2;
    return soma;
}
int SubtrairDoisValores(int valor1, int valor2)
{
    int sub = valor1 - valor2;
    return sub;
}
int SolicitarValorInteiro()
{
    Console.WriteLine("Digite: ");
    string texto = Console.ReadLine();
    int.TryParse(texto, out int valor);
    return valor;
}
void Calcular()
{
    Console.WriteLine("Digite (+-*/) :");
    string operador = Console.ReadLine();

    int valor1 = SolicitarValorInteiro();
    int valor2 = SolicitarValorInteiro();
    int res = 0;
    switch (operador)
    {
        case "+": res = SomarDoisValores(valor1, valor2); break;
        case "-": res = SubtrairDoisValores(valor1, valor2); break;
        default: Console.WriteLine($"Operacao invalida");  break;
    }
    Console.WriteLine($"Resultado: {res}");
}
Calcular();




