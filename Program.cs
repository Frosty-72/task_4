

Console.WriteLine("введите числа по порядку");
int max = int.MinValue; // переменная счётчик с минимальным значением типа int
for (int i = 0; i < 3; i++) // цикл, повторяющийся 3 раза
{
   int num = Convert.ToInt32(Console.ReadLine()); // получаем число с консоли и переводим его из типа string  в тип int
   if (num > max) // сравниваем число с нашей переменной 
      max = num; // если больше то приравниваем 
}
Console.WriteLine(max); // выводим в консоль максимальное число
