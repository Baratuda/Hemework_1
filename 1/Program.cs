//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.Write("Введите чилсо A ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите чилсо B ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Введите чилсо C ");
int thirdNumber = int.Parse(Console.ReadLine());

int maxNumber = firstNumber;

if(maxNumber<=secondNumber){
    maxNumber = secondNumber;
} 
if(maxNumber<=thirdNumber){
   maxNumber = thirdNumber;
} 

Console.Write($"Max number is:  {maxNumber};");
