//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Please, input number to check it for parity: ");
int number = int.Parse(Console.ReadLine());
if(number!=0){
   int privateNumbeer = (number/2);
   if(number-privateNumbeer*2==1 || 
      number-privateNumbeer*2==-1){
      Console.Write($"Number {number} isn't even");
   } else {
      Console.Write($"Number {number} is even");
   }
} else {
   Console.Write("Number eqeals 0");
}

