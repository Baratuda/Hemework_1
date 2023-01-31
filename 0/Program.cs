//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите чилсо A ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите чилсо B ");
int secondNumber = int.Parse(Console.ReadLine());

if(firstNumber>secondNumber){
    Console.Write($"Max number is:  {firstNumber}; "+$"Min number is:  {secondNumber}; ");
} else if(firstNumber==secondNumber){
   Console.Write("These numbers equals each other");
} else{
   Console.Write($"Min number is:  {firstNumber}; "+$"Max number is:  {secondNumber}; ");
}
