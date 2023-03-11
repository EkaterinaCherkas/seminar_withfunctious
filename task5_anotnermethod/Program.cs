// Задайте массив из 12 элементов, заполненый случайными числами из промежутка [-9, 9]
// Найдите сумму отрицательных и положительных элементов массива

Console.Clear();
int[] array = GetRandomArray(12, -9, 9);
int[] GetRandomArray(int size, int MinValue, int MaxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(MinValue, MaxValue+1);
    }
    return result;
}
Console.WriteLine($"[{String.Join(" , ", array)}]");
int positivesum = 0;
int negativesum = 0;
foreach (int el in array){
    positivesum += el > 0 ? el : 0;
    negativesum += el < 0 ? el : 0;
}
Console.WriteLine($"Positive sum ={positivesum}, Negative sum = {negativesum} ");