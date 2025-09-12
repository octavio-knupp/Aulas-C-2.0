// Link para as anotações (https://www.notion.so/Aula-Programa-o-de-Computadores-com-C-24d8539fb3f080a4a4bfd9556e8b9091?source=copy_link)



int[,] matriz = new int[3,3];
matriz[0, 0] = 10;
matriz[0, 1] = 20;
matriz[0, 2] = 30;

matriz[1, 0] = 40;
matriz[1, 1] = 50;
matriz[1, 2] = 60;

matriz[2, 0] = 70;
matriz[2, 1] = 80;
matriz[2, 2] = 90;


for (int l = 0; l < matriz.GetLength(0); l++)
{
    for (int c = 0; c < matriz.GetLength(1); c++)
    {
        Console.Write($"[{matriz[l, c]}]");
    }
    Console.WriteLine();
}
