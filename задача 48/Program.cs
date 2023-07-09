// Задайте двумерный массив n на m. Каждый элемент находится по формуле А(mn) = m + n. Выведите полученный массив на экран

void PrintArray() {
    int[,] Array = new int[3, 4];
    for (int j = 0; j < 3; j++)
    {
        for (int i = 0; i < 4; i++)
        {
            Array[j, i] = i + j;
            System.Console.Write(Array[j, i]);
        }
        System.Console.WriteLine();
    }
}
PrintArray();
