// ДЗ ЗАДАЧА 1. Составить частотный словарь элементов двумерного массива

Console.Clear();

int num1=1; int num2=2; int num3=3; int num4=4; int num5=5; int num6=6; int num7=7; int num8=8; int num9=9;
int count1=0; // Как эффективнее ввести множество одинаковых переменных?
int count2=0;
int count3=0;
int count4=0;
int count5=0;
int count6=0;
int count7=0;
int count8=0;
int count9=0;
int[,] matrix = new int[3,4];


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i, j]} ");  
        }
        Console.WriteLine();  
    }
    Console.WriteLine("Количество 1= " + count1); 
    Console.WriteLine("Количество 2= " + count2); 
    Console.WriteLine("Количество 3= " + count3);
    Console.WriteLine("Количество 4= " + count4); 
    Console.WriteLine("Количество 5= " + count5); 
    Console.WriteLine("Количество 6= " + count6); 
    Console.WriteLine("Количество 7= " + count7); 
    Console.WriteLine("Количество 8= " + count8); 
    Console.WriteLine("Количество 9= " + count9);  
}

int  FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); 
            
                if (num1==matr[i,j]) count1++; //Можно ли было обойтись без столь громозкой конструкции с несколькими if?
                if (num2==matr[i,j]) count2++;
                if (num3==matr[i,j]) count3++;
                if (num4==matr[i,j]) count4++;
                if (num5==matr[i,j]) count5++;
                if (num6==matr[i,j]) count6++;
                if (num7==matr[i,j]) count7++;
                if (num8==matr[i,j]) count8++;
                if (num9==matr[i,j]) count9++;
        }
    }
    return count9; // Почему здесь не обязательно возвращать все count-ы. Достаточно 1 любой count(x)?
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

