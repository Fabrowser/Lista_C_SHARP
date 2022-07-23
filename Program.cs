using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "Alex"};

            list.Add("Maria");
            list.Add("Fabricio");
            list.Add("Tereza");
            list.Add("Alex");
            list.Add("Angelica");
            list.Add("Tereza");


            Console.WriteLine("LISTA 1\n");
            foreach (string nomes in list)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("---------------------");

            Console.WriteLine("LISTA 2\n");
            foreach (string nomes in list2)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("---------------------");

            list.Insert(3, "insert NOME");

            Console.WriteLine("INSERT LIST \n");
            foreach (string nomes in list)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("---------------------");

            Console.WriteLine("Tamanho da Lista 1: "+list.Count);
            Console.WriteLine("Tamanho da Lista 2: " + list2.Count);

            Console.WriteLine("---------------------");

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("1ª posição de A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição de A: " + pos2);
          
            Console.WriteLine("---------------------");
            Console.WriteLine("Filtro: \n");

            List<string> filtro = list.FindAll(x => x.Length == 5); // Cria uma nova lista e filtra da primeira lista os nomes que tem 5 caracteres

            foreach (string nomes in filtro)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Remove: \n");

            list.Remove("Alex");

            foreach (string nomes in list)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("---------------------");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string nomes in list)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("---------------------");


            list.RemoveAt(2);

            foreach (string nomes in list)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("---------------------");

            list.RemoveRange(2, 2);
            foreach (string nomes in list)
            {
                Console.WriteLine(nomes);
            }

        }
    }
}
