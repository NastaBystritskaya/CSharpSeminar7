//// Задайте двумерный массив . Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.

int[,] GetArray() {
    int[,] Array = new int[3, 4];
    for (int j = 0; j < 3; j++)
    {
        for (int i = 0; i < 4; i++)
        {
            Array[j, i] = new Random().Next(1, 11);
            System.Console.Write(Array[j, i] + " ");
        }
        System.Console.WriteLine();
    }
    return Array;
}

void PrintArray(int[,] Array) {
    for (int j = 0; j < 3; j++)
    {
        for (int i = 0; i < 4; i++)
        {
            if (i % 2 == 0 && j % 2 == 0) {
                Array[j, i] = Array[j, i] * Array[j, i];
            }
            System.Console.Write(Array[j, i] + " ");
        }
        System.Console.WriteLine();
    }
}
void Main() {
    int[,] Array = GetArray();
    System.Console.WriteLine();
    PrintArray(Array);
}
Main();
