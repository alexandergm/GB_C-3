class Program
{
    static int[,] labirynth1 = new int[,]
    {
        {1, 1, 1, 1, 1, 1, 1 },
        {1, 0, 0, 0, 0, 0, 1 },
        {1, 0, 1, 1, 1, 0, 1 },
        {0, 0, 0, 0, 1, 0, 0 },
        {1, 1, 0, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 }
    };
    static void Main(string[] args)
    {
        int exitCount = HasExit(1, 1, labirynth1);
        Console.WriteLine("Количество выходов: " + exitCount);
    }
    static int HasExit(int startI, int startJ, int[,] l)
    {
        int countExit = 0;
        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] { startI, startJ });

        while (queue.Count > 0)
        {
            int[] current = queue.Dequeue();
            int i = current[0];
            int j = current[1];

            if (i < 0 || i >= l.GetLength(0) || j < 0 || j >= l.GetLength(1))
            {
                countExit++;
                continue;
            }

            if (l[i, j] == 1)
            {
                continue;
            }

            l[i, j] = 1;
            
            queue.Enqueue(new int[] { i + 1, j });
            queue.Enqueue(new int[] { i - 1, j });
            queue.Enqueue(new int[] { i, j + 1 });
            queue.Enqueue(new int[] { i, j - 1 });
        }

        return countExit;
    }
}
