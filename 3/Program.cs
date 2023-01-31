// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Please, input number: ");
int number = int.Parse(Console.ReadLine());
if(number!=0){
  if(number>0){ 
   for(int i=1; number>=i*2; i++){
      Console.Write(i*2+", ");
   }
  } else {
   for(int i=-1; number<=i*2; i--){
      Console.Write(i*2+", ");
   }
  }
} else {
   Console.Write("Number haven't to eqeals of 0. Please input another number.");
}
