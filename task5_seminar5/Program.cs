// Задайте массив из 12 элементов, заполненый случайными числами из промежутка [-9, 9]
// Найдите сумму отрицательных и положительных элементов массива
Console.Clear();
int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine($"[{String.Join(" , ", array)}]");
int[] SumPosNeg(int[] array){
    int[] result = new int[2];
    foreach(int el in array){
        result[0] += el > 0 ? el : 0;
        result[1] += el < 0 ? el : 0;
    }
    return result;
}
Console.WriteLine($"Positive sum = {SumPosNeg(array)[0]}, Negative sum = {SumPosNeg(array)[1]}");
int[] GetRandomArray(int size, int MinValue, int MaxValue){
    int[] result = new int[size];
    for(int i = 0; i < size ; i++){
        result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return result;
}
