using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algoritmos_ordenacao
{
    public class Ordenacao
    {
        static public void Proprio(List<int> lista)
        {
            int aux;
            for (int i = 0; i < lista.Count; i++)
            {
                // num = lista[i];
                for (int j = i + 1; j < lista.Count; j++)
                {
                    Console.WriteLine($"Testando {lista[i]} na posição {i} e {lista[j]} na posição {j}\n");
                    if (lista[i] > lista[j])
                    {
                        Console.WriteLine($"{lista[i]} eh maior que {lista[j]}. Troca.\n");
                        aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                        Console.WriteLine($"lista[{i}] agora é: {lista[i]}\nlista[{j}] agora é: {lista[j]}\n");
                    }
                    
                    Console.WriteLine("Lista atual: ");
                    foreach (var numero in lista)
                    {
                        Console.Write($"{numero}, ");
                    }

                }
            }
        }
        
        static public void Bolha(int[] lista)
        {
            int aux;
            int num = 0;

            Console.Write("Lista no início: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($" {lista[i]} ");
            }

            for (int i = 0; i < lista.Length; i++)
            {
                while (num < lista.Length - 1)
                {
                    if (lista[num] > lista[num+1])
                    {
                        aux = lista[num+1];
                        lista[num+1] = lista[num];
                        lista[num] = aux;
                    }
                    num++;
                }
                num = 0;
            }
            
            Console.WriteLine();
            Console.Write("Lista no fim: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($" {lista[i]} ");
            }
        }

        static public void Insercao(int[] lista)
        {
            int aux;
            int j;

            Console.Write("Lista no início: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($" {lista[i]} ");
            }

            for (int i = 1; i < lista.Length; i++)
            {
                j = i - 1;
                while (j >= 0)
                {
                    Console.Write("Lista atual: ");
                    foreach (var numero in lista)
                    {
                        Console.Write($" {numero}");
                    }
                    Console.WriteLine();
                    
                    if (lista[j] > lista[i] )
                    {
                        aux = lista[j];
                        lista[j] = lista[i];
                        lista[i] = aux;
                        i--;
                    }
                    j--;
                }
            }

            Console.WriteLine();
            Console.Write("Lista no fim: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($" {lista[i]} ");
            }

        }
    }
}