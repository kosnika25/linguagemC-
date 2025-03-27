using System;
class Programa
{
    static void Main()
    {
        Console.WriteLine("Informe o valor: ");
        int valor;
        valor = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
        {
            int res;
            res = valor * i;
            Console.WriteLine(valor + " X " + i + " = " + res);
        }
    }

}
