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
int positivesum = 0;
int negativesum = 0;
for (int i = 0 ; i < array.Length; i++){
    int el = array[i];
  if (el > 0){
      positivesum = positivesum + el;
    }
  else{
      positivesum = positivesum + 0;
    }
  if (el < 0){
      negativesum = negativesum + el;
  }
  else {
    negativesum = negativesum + 0;
  }
}
Console.WriteLine($"[{String.Join(" , ", array)}]");
Console.WriteLine($"Positive sum ={positivesum}, Negative sum = {negativesum} ");