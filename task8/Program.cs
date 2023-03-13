//Задайте одномерный массив из 123 случайных чисел.Найдите количество элементов массив,значения которых 
//лежат в отрезке[10,99]
// пример для массива из 5 элементов , а не из 123.В своём решении сделайте из 123
//[ 5,18,123,6,2]--> 1
//[ 1,2,3,6,2]--> 0
//[ 10,11,12,13,14]--> 5
Console.Clear();
int[] MyArray = FillArray(123, 0 , 150);
Console.WriteLine($"кол во эл = {FindElement(MyArray,10,99)}");
int[] FillArray(int size , int MinValue , int MaxValue){
int[] masiv = new int[size];
    for (int i = 0; i< size; i++){
    masiv[i] = new Random().Next ( MinValue ,MaxValue + 1 );}
    return masiv;
}

int FindElement(int[] array,int leftel, int rightel){
    int colvo = 0;
    for(int i = 0; i < array.Length ;i++){
        if(i>=leftel && i<=rightel) colvo ++;
    }
  return colvo;
}
