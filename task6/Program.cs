// Запишите программу замена элементов массива:положительные элементы замените на соответствующие отрицательные и наоборот
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
int[] array = GetRandom(4); // (4 , -10 , 10)
int[] GetRandom(int size){ // (int size, MinValue, MaxValue)
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
    result[i] = new Random().Next(-100, 100); //(MinValue,MaxValue +1)
    }
    return result;
}
int[] Zamen(int[] array){
    //int[]result = new int[array.Length]
    //int j = 0
    //foreach(int i in array)
    //{result[j] = i * -1}
    int[] result = new int[4];
    for(int i = 0 ; i < array.Length; i++){ // array[i] *= -1 можно сразу после for без if
    int el = array[i];
    if (el < 0  || el > 0){
        result[i] = el * (-1);}
    }
    return result;
}
Console.WriteLine($"[{String.Join(" , ", array)}]");
Console.WriteLine($"[{String.Join(" , ", Zamen(array))}]");
