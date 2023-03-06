//Напишите программу, которая принимает 
//на вход число N и выдаёт количество цифр в числе.

Console.Clear();
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());

int Count(int number){ //123
    int colvo = 0;
    if (number < 0){
        number = number * (-1); //n*=(-1)
    }
    while (number > 0){
        number = number / 10; // n/=10
        colvo++; // colvo =3
    }
    return colvo;
}
Console.WriteLine($"Количество цифр = {Count(N)}");
