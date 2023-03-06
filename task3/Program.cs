//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.
// 4 = 24
// 5 = 120 == 1*2*3*4*5

Console.Clear();
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());

int Count(int number){
    int colvo = 1;
    int i = 1;
    if(number < 0){
        i = number;
        number = -1;
    }
for ( ; i <= number ; i++){
    colvo = colvo * i;
}
    return colvo;
}
Console.WriteLine($"{Count(N)}");