// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число больше 1: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 1){
    Console.WriteLine("Вы ввели некорректное число, попробуйте ещё раз!"); 
} else {
    int i = 1;
    while (i <= num){
        Console.WriteLine(i*i*i);
        i++;
    }
}