using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algoritmos_ordenacao
{
    public class Ordenacao
    {
        static public void proprio(List<int> lista)
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
        
        static public void Bolha(List<int> lista)
        {
            int itera = 0;
            int aux;
            int num = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                while (num < lista.Count - 1)
                {
                    if (lista[num] > lista[num+1])
                    {
                        aux = lista[num+1];
                        lista[num+1] = lista[num];
                        lista[num] = aux;
                    }
                    num++;
                    Console.Write(" -> Lista atual: ");
                    itera++;
                    foreach (var numero in lista)
                    {
                        Console.Write($" {numero},");
                    }
                    Console.Write($" itera: {itera}");
                    Console.WriteLine();
                }
                num = 0;
            }
        }
    }
}