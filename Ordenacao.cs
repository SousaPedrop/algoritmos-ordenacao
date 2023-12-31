using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algoritmos_ordenacao
{
    public class Ordenacao
    {
        static public void BolhaPropria(List<int> lista)
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
                    if (lista[num] > lista[num + 1])
                    {
                        aux = lista[num + 1];
                        lista[num + 1] = lista[num];
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
            int aux, chave;
            int j;

            Console.Write("Lista no início: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($" {lista[i]} ");
            }
            Console.WriteLine();

            for (int i = 1; i < lista.Length; i++)
            {
                chave = lista[i];
                j = i - 1;

                Console.Write("Lista atual: ");
                foreach (var numero in lista)
                {
                    Console.Write($" {numero}");
                }
                Console.WriteLine();
                
                while (j >= 0)
                {

                    if (lista[j] > chave)
                    {
                        aux = chave;
                        lista[j + 1] = lista[j];
                        lista[j] = aux;
                        // i--;s
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

        static public void Selecao(int[] lista)
        {
            int chave, aux, posicaoMenor;

            Console.Write("Lista no início: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($" {lista[i]} ");
            }
            Console.WriteLine();

            //Iniciando iteração do array
            for(int i = 0; i < lista.Length; i++)
            {
                chave = lista[i];
                posicaoMenor = i;
                
                Console.Write("Lista atual: ");
                foreach (var numero in lista)
                {
                    Console.Write($" {numero}");
                }
                Console.WriteLine();
                
                //Escolhendo a chave (menor valor) e sua respectiva posicao.
                for (int j = i; j < lista.Length; j++)
                {
                    if(chave > lista[j])
                    {
                        chave = lista[j];
                        posicaoMenor = j;
                    }
                }
                //Comparar se o menor valor esta no lugar errado
                if(posicaoMenor != i)
                {
                    aux = lista[i];
                    lista[i] = lista[posicaoMenor];
                    lista[posicaoMenor] = aux;
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