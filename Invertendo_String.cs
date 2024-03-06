using System;

class InvertendoString
{
    static void Main(string[] args)
    {
        int i;
        char auxiliar;
        string palavra;
        Console.WriteLine("Digite uma palavra: ");
        palavra = Console.ReadLine();
        char[] PalavraChar = new char[palavra.Length];
        int teste = palavra.Length-1;
        for (i = 0;i<=PalavraChar.Length/2;i++)
        {
            auxiliar = palavra[i];
            PalavraChar[i] = palavra[teste-i];
            PalavraChar[teste-i] = auxiliar;
        }

        Console.WriteLine(PalavraChar);
    }
}