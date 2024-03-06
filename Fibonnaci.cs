using System;

class Fibonnaci
{
    //Esse programa tolera até o 92º número da sequência de fibonnaci.
    static void Main(string[] args)
    {
        long[] comparacao = new long[92];
        int i;
        bool flag = false;
        Console.WriteLine("Digite um número: ");
        long numero = Convert.ToInt64(Console.ReadLine());
        if (numero == 0 || numero == 1)
        {
            Console.WriteLine("O número digitado está na sequência de fibonnaci!");
        }

        comparacao[0] = 1;
        comparacao[1] = 1;
        for (i = 2; i< 92; i++)
        {
            comparacao[i] = comparacao[i-1]+ comparacao[i-2];
            if (comparacao[i] == numero)
            {
                Console.WriteLine("O número digitado está na sequência de Fibonnaci!");
                flag = true;
                break;
            }
        }

        if(flag == false)
        {
            Console.WriteLine("O número digitado não está na sequência de Fibonnaci!");
        }
    }
}