#pragma warning disable

// задание 1

//static double Fx(double x)
//{
//    Random rnd = new();
//    int a = rnd.Next(-50, 51);
//    Console.WriteLine(a);
//    if (x == a)
//        throw new DivideByZeroException();
//    if (x < 0)
//        return x + Math.Pow(Math.Sin(1.0 / (x - a) + 4), 2);
//    else
//    {
//        if (x == -a)
//            throw new DivideByZeroException();
//        if (a * a - x * x < 0)
//            throw new ArgumentException();
//        return a * x / Math.Sqrt(a * a - x * x);
//    }
//}
//try
//{
//    Console.WriteLine("Значение функции f(x) при x = 5: " + Fx(5.0));
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("В функции произошло деление на ноль (x = a). Значение f(x) = inf.");
//}
//catch (ArgumentException)
//{
//    Console.WriteLine("В функции значение под корнем отрицательное. Значение f(x) не числовое.");
//}


// задание 2

//static void InputArray(double[] a, int k1, int k2)
//{
//    if (k2 < k1)
//        throw new LeftIndexMoreThanRightException();
//    if (k1 < 0 || k2 >= a.Length || k2 < 0)
//        throw new IndexOutOfRangeException();
//    for (int i = k1; i <= k2; i++)
//    {
//        Console.Write($"array[{i}] = ");
//        a[i] = double.Parse(Console.ReadLine());
//    }
//}

//static void RandomArray(double[] a, int k1, int k2)
//{
//    if (k2 < k1)
//        throw new LeftIndexMoreThanRightException();
//    if (k1 < 0 || k2 >= a.Length || k2 < 0)
//        throw new IndexOutOfRangeException();
//    Random rnd = new();
//    for (int i = k1; i <= k2; i++)
//        a[i] = rnd.Next(-100, 101);
//}

//static void PrintArray(double[] a)
//{
//    Console.Write("Полученный массив:");
//    for (int i = 0; i < a.Length; i++) Console.Write(" " + a[i]);
//    Console.WriteLine();
//}

//try
//{
//    double[] arr = { 5, 3, 4, 8, 9, 0 };
//    InputArray(arr, 4, 5);
//    PrintArray(arr);

//    RandomArray(arr, 1, 3);
//    PrintArray(arr);
//}
//catch (FormatException)
//{
//    Console.WriteLine("Было введено недопустимое значение элемента массива.");
//}
//catch (IndexOutOfRangeException)
//{
//    Console.WriteLine("Были введены недопустимые значения индексов.");
//}
//catch (LeftIndexMoreThanRightException)
//{
//    Console.WriteLine("Значение левого индекса больше значения правого");
//}

//class LeftIndexMoreThanRightException : Exception
//{
//    public LeftIndexMoreThanRightException() : base() { }
//}


// задание 3

//try
//{
//    int k1, k2, n;
//    Console.Write("Введите два целых числа k1 и k2\nk1 = ");
//    k1 = int.Parse(Console.ReadLine());
//    Console.Write("k2 = ");
//    k2 = int.Parse(Console.ReadLine());
//    Console.Write("Введите целое число n\nn = ");
//    n = int.Parse(Console.ReadLine());
//    if (n <= 0)
//        throw new NegativeArraySizeException();

//    double[] x = new double[n];
//    InputArray(x, k1, k2);
//    if (k1 > 0)
//        RandomArray(x, 0, k1 - 1);
//    if (k2 < x.Length - 1)
//        RandomArray(x, k2 + 1, x.Length - 1);
//    PrintArray(x);

//    double?[] y = new double?[n];
//    for (int i = 0; i < n; i++) y[i] = Fx(x[i]);
//    Console.Write("\nмассив y:");
//    for (int i = 0; i < n; i++)
//    {
//        if (y[i] == null) Console.Write(" nothing");
//        Console.Write(" " + y[i]);
//    }
//    Console.WriteLine();

//    int count = 0;
//    Console.WriteLine("Точки, принадлежащие заштрихованной области:");
//    for (int i = 0; i < n; i++)
//    {
//        if (CheckBelongsToThePlane(x[i], y[i]))
//        {
//            count++;
//            Console.WriteLine($"({x[i]}, {y[i]})");
//        }
//    }
//    if (count == 0) Console.WriteLine("отсутствуют");
//    else Console.WriteLine($"Количество точек, попавших в заштрихованную область = {count}");

//    Console.WriteLine($"Длина ломаной, соединяющей точки плоскости в порядке индексации массива = {PolylineLength(x,y)}");
//}
//catch (NegativeArraySizeException)
//{
//    Console.WriteLine("Было введено неположительное значение размера массива.");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Было введено недопустимое значение элемента массива или индексов k1 / k2.");
//}
//catch (IndexOutOfRangeException)
//{
//    Console.WriteLine("Были введены недопустимые значения индексов.");
//}
//catch (LeftIndexMoreThanRightException)
//{
//    Console.WriteLine("Значение левого индекса больше значения правого.");
//}
//catch (EmptyPointException)
//{
//    Console.WriteLine("Отсутствует значение y[i]. Длина ломаной не может быть посчитана.");
//}

//static double? Fx(double x)
//{
//    Random rnd = new();
//    int a = rnd.Next(-50, 51);
//    if (x == a)
//        return null;
//    if (x < 0)
//        return x + Math.Pow(Math.Sin(1.0 / (x - a) + 4), 2);
//    else
//    {
//        if (x == -a)
//            return null;
//        if (a * a - x * x < 0)
//            return null;
//        return a * x / Math.Sqrt(a * a - x * x);
//    }
//}
//static void InputArray(double[] a, int k1, int k2)
//{
//    if (k2 < k1)
//        throw new LeftIndexMoreThanRightException();
//    if (k1 < 0 || k2 >= a.Length || k2 < 0)
//        throw new IndexOutOfRangeException();
//    for (int i = k1; i <= k2; i++)
//    {
//        Console.Write($"array[{i}] = ");
//        a[i] = double.Parse(Console.ReadLine());
//    }
//}

//static void RandomArray(double[] a, int k1, int k2)
//{
//    if (k2 < k1)
//        throw new LeftIndexMoreThanRightException();
//    if (k1 < 0 || k2 >= a.Length || k2 < 0)
//        throw new IndexOutOfRangeException();
//    Random rnd = new();
//    for (int i = k1; i <= k2; i++)
//        a[i] = rnd.Next(-100, 101);
//}

//static void PrintArray(double[] a)
//{
//    Console.Write("Полученный массив:");
//    for (int i = 0; i < a.Length; i++) Console.Write(" " + a[i]);
//    Console.WriteLine();
//}

//static bool CheckBelongsToThePlane(double x, double? y)
//{
//    if (y == null) return false;
//    else if (y <= 4 & y >= -4 & x >= -4 & x <= 0 || y <= -x + 4 & y >= 0 & x > 0)
//        return true;
//    return false;
//}
//static double PolylineLength(double[] x, double?[] y)
//{
//    double l = 0;
//    if (y[0] == null) throw new EmptyPointException();
//    for (int i = 1; i < x.Length; i++)
//    {
//        if (y[i] == null) throw new EmptyPointException();
//        l += Math.Sqrt(Math.Pow(x[i] - x[i-1], 2) + Math.Pow((double)(y[i] - y[i-1]), 2));
//    }
//    return l;
//}
//class NegativeArraySizeException : Exception
//{
//    public NegativeArraySizeException() : base() { }
//}
//class LeftIndexMoreThanRightException : Exception
//{
//    public LeftIndexMoreThanRightException() : base() { }
//}
//class EmptyPointException : Exception
//{
//    public EmptyPointException() : base() { }
//}


// задание 4

static void InputArray(double[] a, int k1, int k2)
{
    if (k2 < k1)
        throw new InputArrayException("Ошибка ввода массива", $"Значение k1 не может быть больше k2: k1={k1}, k2={k2}");
    if (k1 < 0 || k1 >= a.Length)
        throw new InputArrayException("Ошибка ввода массива", $"Неверное значение k1: {k1}");
    if (k2 >= a.Length || k2 < 0)
        throw new InputArrayException("Ошибка ввода массива", $"Неверное значение k2: {k2}");
    try
    {
        for (int i = k1; i <= k2; i++)
        {
            Console.Write($"array[{i}] = ");
            a[i] = double.Parse(Console.ReadLine());
        }
    }
    catch (FormatException ex)
    {
        throw new InputArrayException("Ошибка ввода массива", "Неверный формат числа");
    }
}
static double Fx(double x)
{
    Random rnd = new();
    int a = rnd.Next(-50, 51);
    if (x == a)
        throw new FunctionxException("Ошибка вычисления функции", $"Деление на ноль: x = {x}, a = {a}");
    if (x < 0)
        return x + Math.Pow(Math.Sin(1.0 / (x - a) + 4), 2);
    else
    {
        if (x == -a)
            throw new FunctionxException("Ошибка вычисления функции", $"Деление на ноль: x = {x}, a = {a}");
        if (a * a - x * x < 0)
            throw new FunctionxException("Ошибка вычисления функции", $"Отрицательное значение под корнем: x = {x}, a = {a}");
        return a * x / Math.Sqrt(a * a - x * x);
    }
}
static void RandomArray(double[] a, int k1, int k2)
{
    if (k2 < k1)
        throw new RandomArrayException("Ошибка заполнения массива случайными числами", $"Значение k1 не может быть больше k2: k1={k1}, k2={k2}");
    if (k1 < 0 || k1 >= a.Length)
        throw new RandomArrayException("Ошибка заполнения массива случайными числами", $"Неверное значение k1: {k1}");
    if (k2 >= a.Length || k2 < 0)
        throw new RandomArrayException("Ошибка заполнения массива случайными числами", $"Неверное значение k2: {k2}");
    try
    {
        Random rnd = new();
        for (int i = k1; i <= k2; i++)
            a[i] = rnd.Next(-100, 101);
    }
    catch (Exception ex)
    {
        throw new RandomArrayException("Ошибка заполнения массива случайными числами", "Ошибка при генерации случайного числа");
    }
}
try
{
    double[] array = new double[5];
    InputArray(array, 0, 4);
    PrintArray(array);

    double result = Fx(array[3]);
    Console.WriteLine($"Результат функции: {result}");

    RandomArray(array, 1, 3);
    PrintArray(array);
}
catch (InputArrayException ex)
{
    Console.WriteLine($"Ошибка ввода массива: {ex.Reason}");
}
catch (FunctionxException ex)
{
    Console.WriteLine($"Ошибка вычисления функции: {ex.Reason}");
}
catch (RandomArrayException ex)
{
    Console.WriteLine($"Ошибка заполнения массива случайными числами: {ex.Reason}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}
static void PrintArray(double[] a)
{
    Console.Write("Полученный массив:");
    for (int i = 0; i < a.Length; i++) Console.Write(" " + a[i]);
    Console.WriteLine();
}
