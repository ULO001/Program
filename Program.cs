{
    static void PrintNaturalNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.WriteLine(M);
            PrintNaturalNumbers(M + 1, N);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите начальное значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите конечное значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Натуральные числа от {0} до {1} включительно:", M, N);
        PrintNaturalNumbers(M, N);
    }
}