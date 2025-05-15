using System;

namespace BubbleSort
{
    /// <summary>
    /// Die Program-Klasse enthält Methoden zur Implementierung des Bubble-Sort-Algorithmus.
    /// </summary>
    public sealed class Program
    {
        // Einfacher Bubble-Sort nur für int-Arrays
        /// <summary>
        /// Sortiert ein ganzzahliges Array aufsteigend mithilfe des Bubble-Sort-Algorithmus.
        /// </summary>
        /// <param name="array">Das zu sortierende Array. Darf nicht null sein.</param>
        public static void BubbleSort(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));

            for (int pass = 0; pass < array.Length - 1; pass++)
            {
                for (int i = 0; i < array.Length - 1 - pass; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Elemente vertauschen
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
        
        // Optimierter Bubble-Sort nur für int-Arrays
        /// <summary>
        /// Sortiert ein ganzzahliges Array aufsteigend mithilfe eines optimierten Bubble-Sort-Algorithmus.
        /// </summary>
        /// <param name="array">Das zu sortierende Array. Darf nicht null sein.</param>
        public static void BubbleSortOptimized(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));

            int upperBound = array.Length - 1; // letzter Index, der noch verglichen werden muss
            while (upperBound > 0)
            {
                int lastSwapIndex = 0;

                for (int i = 0; i < upperBound; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Elemente vertauschen
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        lastSwapIndex = i; // Position der letzten Vertauschung merken
                    }
                }

                // Alles hinter lastSwapIndex ist bereits sortiert
                upperBound = lastSwapIndex;
            }
        }


        /// <summary>
        /// Der Einstiegspunkt der Anwendung. Führt den Bubble-Sort-Algorithmus aus und gibt das sortierte Array aus.
        /// </summary>
        /// <param name="args">Ein Array von Argumenten, das an die Programmausführung übergeben wird.</param>
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 4, 2 };

            // BubbleSort(numbers);
            BubbleSortOptimized(numbers);

            Console.WriteLine(string.Join(", ", numbers)); // Ausgabe: 2, 3, 4, 5, 8
        }
    }
}