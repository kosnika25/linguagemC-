using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        int i;
        for (i=0; i<5; i++)
        {
            Console.WriteLine("Informe o valor: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        for(i=0; i < 5; i++)
        {
            if(numeros[i]%2 == 0)
            Console.Write(numeros[i]+" ");
        }
    }
}
