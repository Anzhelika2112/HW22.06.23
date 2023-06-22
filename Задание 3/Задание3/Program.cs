//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int[] RandomArray = new int[8];
int min = GetNumberFromUser1("Введите минимальное число в массиве: ", "Ошибка ввода!");
int max = GetNumberFromUser2("Введите максимальное число в массиве: ", "Ошибка ввода!");

ArrayRand(RandomArray);

Write(RandomArray);

int GetNumberFromUser1(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber1))
            return userNumber1;
        Console.WriteLine(errorMessage);
    }
}

int GetNumberFromUser2(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber2))
            return userNumber2;
        Console.WriteLine(errorMessage);
    }
}

void ArrayRand(int[] RandomArray)
{
for (int i = 0; i < RandomArray.Length; i++)
  {
    RandomArray[i] = Rand(min,max);
  }
  
}


int Rand(int min,int max)
{
  return new Random().Next(min, max);
}

void Write(int[] RandomArray)
{
  Console.Write("{");
  for (int i = 0; i < RandomArray.Length; i++)
  {
    if (i + 1 == RandomArray.Length)
    {
      Console.Write($"{RandomArray[i]}");
    }
    else
    {
      Console.Write($"{RandomArray[i]}, ");
    }
  }
  Console.Write("}");
}