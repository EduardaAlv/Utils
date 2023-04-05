//using System;
//using System.Diagnostics;

//class MergeSort
//{

//    // Merges two subarrays of []arr.
//    // First subarray is arr[l..m]
//    // Second subarray is arr[m+1..r]
//    void merge(int[] arr, int l, int m, int r)
//    {
//        // Find sizes of two
//        // subarrays to be merged
//        int n1 = m - l + 1;
//        int n2 = r - m;

//        // Create temp arrays
//        int[] L = new int[n1];
//        int[] R = new int[n2];
//        int i, j;

//        // Copy data to temp arrays
//        for (i = 0; i < n1; ++i)
//            L[i] = arr[l + i];
//        for (j = 0; j < n2; ++j)
//            R[j] = arr[m + 1 + j];

//        // Merge the temp arrays

//        // Initial indexes of first
//        // and second subarrays
//        i = 0;
//        j = 0;

//        // Initial index of merged
//        // subarray array
//        int k = l;
//        while (i < n1 && j < n2)
//        {
//            if (L[i] <= R[j])
//            {
//                arr[k] = L[i];
//                i++;
//            }
//            else
//            {
//                arr[k] = R[j];
//                j++;
//            }
//            k++;
//        }

//        // Copy remaining elements
//        // of L[] if any
//        while (i < n1)
//        {
//            arr[k] = L[i];
//            i++;
//            k++;
//        }

//        // Copy remaining elements
//        // of R[] if any
//        while (j < n2)
//        {
//            arr[k] = R[j];
//            j++;
//            k++;
//        }
//    }

//    // Main function that
//    // sorts arr[l..r] using
//    // merge()
//    void sort(int[] arr, int l, int r)
//    {
//        if (l < r)
//        {
//            // Find the middle
//            // point
//            int m = l + (r - l) / 2;

//            // Sort first and
//            // second halves
//            sort(arr, l, m);
//            sort(arr, m + 1, r);

//            // Merge the sorted halves
//            merge(arr, l, m, r);
//        }
//    }

//    // A utility function to
//    // print array of size n */
//    static void printArray(int[] arr)
//    {
//        int n = arr.Length;
//        for (int i = 0; i < n; ++i)
//            Console.Write(arr[i] + " ");
//        Console.WriteLine();
//    }

//    // Driver code
//    public static void Main(String[] args)
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\eduar\\Source\\Repos\\ConsoleTeste\\ConsoleTeste\\data.txt");
//        int[] numbers = new int[lines.Length];
//        double[] tempo = new double[1000];
//        double[] memoria = new double[1000];

//        for (int i = 0; i < lines.Length; i++)
//        {
//            if (int.TryParse(lines[i], out int number))
//            {
//                numbers[i] = number;
//            }
//        }

//        long tempoDeExecucao = 0;
//        long memoriaUsada = 0;

//        Stopwatch stopwatch = new Stopwatch();
//        MergeSort ob = new MergeSort();

//        for (int i = 0; i < 1000; i++)
//        {
//            stopwatch.Start();
//            long startMemory = GC.GetTotalMemory(true);

//            ob.sort(numbers, 0, numbers.Length - 1);

//            stopwatch.Stop();
//            long endMemory = GC.GetTotalMemory(true);
//            memoriaUsada = endMemory - startMemory;
//            tempoDeExecucao = stopwatch.ElapsedMilliseconds;

//            tempo[i] = tempoDeExecucao;
//            memoria[i] = memoriaUsada;
//        }
//        double mediaTempoDeExecucao = tempo.Average();
//        double mediaMemoriaUtilizada = memoria.Average();

//        double varianciaTempoDeExecucao = tempo.Select(x => Math.Pow(x - mediaTempoDeExecucao, 2)).Average();
//        double varianciaMemoriaUtilizada = tempo.Select(x => Math.Pow(x - mediaMemoriaUtilizada, 2)).Average();

//        double desvioPadraoTempoDeExecucao = Math.Sqrt(varianciaTempoDeExecucao);
//        double desvioPadraoMemoriaUtilizada = Math.Sqrt(varianciaMemoriaUtilizada);

//        // Média do tempo de execução
//        Console.WriteLine("Média Simples Tempo de execução: " + mediaTempoDeExecucao + " ms");

//        // Média do uso de memória
//        Console.WriteLine("Média Simples Uso de memória: " + mediaMemoriaUtilizada + " bytes");

//        // Variancia tempo de execução
//        Console.WriteLine("Variância Tempo de execução: " + varianciaTempoDeExecucao + " ms");

//        // Variancia uso de memória
//        Console.WriteLine("Variância Uso de memória: " + varianciaMemoriaUtilizada + " bytes");

//        // Desvio Padrão tempo de execução
//        Console.WriteLine("Desvio Padrão tempo de execução: " + desvioPadraoTempoDeExecucao + " ms");

//        // Desvio Padrão uso de memória
//        Console.WriteLine("Desvio Padrão uso de memória: " + desvioPadraoMemoriaUtilizada + " bytes");

//    }
//}