using System;
using System.ComponentModel.Design; // importante de blibliotecas do sistema
class Programa // classe principal do sistema
{
    static void Main()// classe principal
    {
        int idade;// variavel inteira para armazenar idade
        Console.WriteLine("Informe uma idade:  ");
        idade = Convert.ToInt32(Console.ReadLine());// converte a entrada para numero
        if (idade >0 && idade < 12)
        {
            Console.WriteLine("Criança");

        }
        else if (idade >= 12 && idade < 18)
        {
            Console.WriteLine("Adolescente");
        }
        else if(idade>=18)
        { Console.WriteLine("adulto");

        }
        else { Console.WriteLine("Idade Invalida!");
        }
        
        
        }
    }
