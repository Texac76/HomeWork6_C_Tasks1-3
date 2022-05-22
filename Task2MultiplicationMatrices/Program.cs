// ДЗ ЗАДАЧА 2. Найти произведение двух матриц


 Console.Clear();
 
int[,] m1 = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int[,] m2 = {
    {5, 5, 5},
    {5, 5, 5},
    {5, 5, 5}
};


void MultiplicationMatrices(int[,] m1)
{
for (int i = 0; i < 3; i++) 
{
    for (int j = 0; j < 3; j++)
    {
    m1[i, j] = m1[i, j] * m2[i, j];
    }
}
}

void PrintArray(int[,] m1)
{
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m1.GetLength(1); j++)
        {
        Console.Write($"{m1[i, j]} ");  
        }
        Console.WriteLine();  
    }
}

int[,] matrix = new int[3,3];
MultiplicationMatrices(m1);
Console.WriteLine(); 
PrintArray(m1);

