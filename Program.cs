// Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив,
// каждый элемент которого равен разности элементов двух входящих массивов в той же ячейке.
// Если длины массивов не равны, необходимо как-то оповестить пользователя.

//Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив,
//каждый элемент которого равен частному элементов двух входящих массивов в той же ячейке.
//Если длины массивов не равны, необходимо как-то оповестить пользователя.
//Важно: При выполнении метода единственное исключение, которое пользователь может увидеть - RuntimeException, т.е. ваше.

int[,] NewMassRazn(int[,] x, int[,] y)
{
    int[,] resultMass = new int[x.GetLength(0), x.GetLength(1)];

    if(x.GetLength(0) != y.GetLength(0) || x.GetLength(1) != y.GetLength(1))
    {
        Console.WriteLine("Массивы не одинаковые, введите одинаковые массивы");

        return resultMass;
    }

    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            resultMass[i, j] = x[i, j] - y[i, j];
        }
    }
    return resultMass;
}

int[,] NewMassUmn(int[,] x, int[,] y)
{
    int[,] resultMass = new int[x.GetLength(0), x.GetLength(1)];

    if(x.GetLength(0) != y.GetLength(0) || x.GetLength(1) != y.GetLength(1))
    {
        Console.WriteLine("Массивы не одинаковые, введите одинаковые массивы");

        return resultMass;
    }

    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            resultMass[i, j] = x[i, j] * y[i, j];
        }
    }
    return resultMass;
}



int[,] array = new int[3, 3];
int[,] array2 = new int[3, 3];
Random rand = new Random();

// инициация
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(10);
    }
}

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = rand.Next(10);
    }
}


// массивы
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + ", ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        Console.Write(array2[i, j] + ", ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();



// результат
int[,] array3 = new int[3, 3];

array3 = NewMassRazn(array, array2);

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        Console.Write(array3[i, j] + ", ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] array4 = new int[3, 3];

array4 = NewMassUmn(array, array2);

for (int i = 0; i < array4.GetLength(0); i++)
{
    for (int j = 0; j < array4.GetLength(1); j++)
    {
        Console.Write(array4[i, j] + ", ");
    }
    Console.WriteLine();
}