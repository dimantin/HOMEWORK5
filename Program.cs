/*Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count = count + 1;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void ArrayRandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}*/

/*Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i+=2)
    sum = sum + numbers[i];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void ArrayRandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = new Random().Next(-1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
        {
            Console.Write(numbers[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}*/

/*Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void ArrayRandomNumbers(double[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
        {
            Console.Write(numbers[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}*/