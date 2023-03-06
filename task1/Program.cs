//24 Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A
// a = 5
// sum = 1 + 2 + 3 + 4 + 5

int GetSum(int number){
int sum = 0 ;
for (int i = 1; i<=number; i++){
    sum += i ;}  // sum = sum + i;
    return sum;
}
Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int result = GetSum(number);
Console.WriteLine($"Сумма от 1 до {number} = {result}");