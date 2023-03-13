// Задайте массив.Напишите программу,которая определяет, присутствует ли данное число в массиве
// 4, массив[6, 7, 19, 345, 3]-> no
// 3, массив[6, 7, 19, 345, 3]-> yes

int Prompt(string message){
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
void FillArray(int[] array, int MinValue, int MaxValue){
    for(int i = 0; i<array.Length;i++)
    array[i] = new Random().Next(MinValue,MaxValue);
}
void PrintArray (int[] masiv){
    for(int i = 0; i<masiv.Length;i++)
    Console.Write ($"{(masiv[i])} ");
}
void FindNumber(int[] array, int number){
    for(int i = 0; i < array.Length;i++){
        if(array[i]==number){
            Console.WriteLine("yes");
            return;
        }
    }
           Console.WriteLine("no");
}
int number = Prompt("Введите число: ");
int size = Prompt("Введите длину массива: ");
int MinValue = Prompt("Введите начало диапазона: ");
int MaxValue = Prompt("Введите конец диапазона: ");
int [] array = new int[size];
FillArray(array, MinValue, MaxValue);
PrintArray(array);
FindNumber(array,number);
