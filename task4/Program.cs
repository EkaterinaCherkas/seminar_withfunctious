// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// a = new Random().Next()
//int a = new Random().Next(2)


Console.Clear();
int[] array = MyArray(8);
Console.WriteLine($"[{String.Join(" , ", array)}]");
// Вывод выше равносилен 
// for (int i = 0 ; i < array.Length - 1 ; i++){ // исключаем последний элемент ,чтобы после него не было запятой
// Console.Write($"{array[i]}, ");
//}
// Console.Write($"{array[array.Length - 1]}"); //выводим последний элемент , без запятой

int[] MyArray(int size){
int[] masiv = new int[size];
for (int i = 0; i < masiv.Length;i++){
masiv[i] = new Random().Next(2);
}
return masiv;
}
//foreach(var el in array){
    //Console.Write($"{el} ")} если надо перебрать элементы массива, равносильно for

