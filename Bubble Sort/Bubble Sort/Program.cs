internal class Program
{
    private static void Main()
    {
        double[] doubles = { 5.6, 5.1, 999, 8.14324, 1 };
        double[] doubles2 = BubbleSort(doubles);
        for (int i = 0; i < doubles2.Length; i++)
        {
            Console.WriteLine(doubles2[i]);
        }
    }

    private static double[] BubbleSort(double[] a)
    {
        bool update = true;
        while (update)
        {
            update = false;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] >= a[i + 1])
                {
                    double temp = a[i];
                    double temp2 = a[i + 1];
                    a[i] = temp2;
                    a[i + 1] = temp;
                    update = true;
                }
            }
        }
        return a;
    }
}