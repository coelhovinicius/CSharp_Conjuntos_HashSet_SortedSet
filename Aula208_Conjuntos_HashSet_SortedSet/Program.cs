/* HashSet<T> e SortedSet<T> - Representa um conjunto de elementos (similar ao da Algebra)
    - Nao admite repeticoes;
    - Elementos nao possuem posicao;
    - Acesso, insercao e remocao de elementos sao rapidos - nao ha obrigacao de inserir elementos em posicoes;
    - Oferece operacoes eficientes de conjunto: insercao, uniao, diferenca.

    >>> HashSet:
         - Armazenamento em tabela hash;
         - Extremamente rapido: insercao, remocao e busca O(1) - "ordem de 1", em um passo;
         - A ordem dos elementos nao e garantida. 

    >>> SortedSet:
         - Armazenamento em arvore;
         - Rapido: insercao, remocao e busca O(log(n)) - busta logaritmica
         - Os elementos sao armazenados ordenadamente, conforme implementacao IComparer<T>.
*/

using System;
using System.Collections.Generic;

namespace Aula208_Conjuntos_HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // HASHSET - Conjuntos - Instanciar, Inserir elementos e Percorrer um Conjunto
            HashSet<string> set = new HashSet<string>(); // Instancia um Conjunto vazio

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine("HASHSET:");
            Console.WriteLine(set.Contains("Notebook")); // Retorna True

            /* Foreach percorre os elementos do conjunto, fazendo a interacao entre esses elementos de forma interna, 
             * conforme esta implementado no conjunto */
            Console.WriteLine("Elementos do Conjunto:");
            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            // SORTEDSET
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 }; // Instancia conjunto com elementos
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("SORTEDSET:");
            Console.Write("Conjunto a: ");
            PrintCollection(a); // Imprime a colecao do conjunto "a"
            Console.Write("Conjunto b: ");
            PrintCollection(b); // Exibe os elementos ordenados

            // Uniao entre Conjuntos
            SortedSet<int> c = new SortedSet<int>(a); // Instancia um conjunto "c" contendo os elementos do "a"
            c.UnionWith(b); // Uniao do conjunto "c" com "b", sem repeticoes
            Console.Write("Uniao dos conjuntos a e b: ");
            PrintCollection(c); // Exibe os elementos ordenados

            // Interseccao entre Conjuntos
            SortedSet<int> d = new SortedSet<int>(a); // Instancia um conjunto "d" contendo os elementos do "a"
            d.IntersectWith(b); // Faz a interseccao entre os elementos dos conjuntos "a" e "b"
            Console.Write("Interseccao de a e b: ");
            PrintCollection(d);

            // Diferenca entre Conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("Diferencas do conjunto a para o conjunto b: ");
            PrintCollection(e);
        }

        // Funcao auxiliar
        static void PrintCollection<T>(IEnumerable<T> collection) /* Colecao "collection" e uma colecao do tipo "T"
                                                                   * que implementa o IEnumerable */
        {
            foreach (T obj in collection) // Foreach funciona em cima de colecoes IEnumerable
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}