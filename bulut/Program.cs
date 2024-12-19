namespace GitHup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[,] massiv = new int[n, n];
            int qiymat = 1;
            int qavat = 0;

            while (qiymat <= n * n)
            {
                for (int i = qavat; i < n - qavat; i++)
                    massiv[qavat, i] = qiymat++;
                for (int i = qavat + 1; i < n - qavat; i++)
                    massiv[i, n - qavat - 1] = qiymat++;

                for (int i = n - qavat - 2; i >= qavat; i--)
                    massiv[n - qavat - 1, i] = qiymat++;
                for (int i = n - qavat - 2; i > qavat; i--)
                    massiv[i, qavat] = qiymat++;

                qavat++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(massiv[i, j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}