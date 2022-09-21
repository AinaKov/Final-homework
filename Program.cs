string[,] tab = {{ "hello", "2", @"world", ":-)" },
                    {"1234", "1567", "-2", "computer"},
                    { "Russian", "Denmark", "Kazan", "Tumen"}};
int n = 3;
for (int i = 0; i < tab.GetLength(0); i++)
{
    Console.Write("[");
    for (int j = 0; j < tab.GetLength(1); j++)
    
    {
        if (tab[i, j].Length <= n)
            Console.Write(tab[i, j] + ", ");

    }

    Console.WriteLine("]");
}

