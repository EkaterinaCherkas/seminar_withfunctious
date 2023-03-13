// Задайте массив.Напишите программу,которая определяет, присутствует ли данное число в массиве
// 4, массив[6, 7, 19, 345, 3]-> no
// 3, массив[6, 7, 19, 345, 3]-> yes
 Console.Clear();
 Console.Write("Введите элементы массива через пробел: ");
 string elements = Console.ReadLine();
 int[] baseArray = GetArrayFromString(elements);// функция гетэрэй. на вход принимает строку возращает массив целых чисел
 // функция переводит в строку элемент в массив чисел и это  массив записывает в basearray
 Console.Write("Введите число: ");
 int n = int.Parse(Console.ReadLine());
 if (FindElement(baseArray, n)){// в этой функции буул и можно сразу ее указать в иф,выведет в зависимости от того что вернет
    Console.WriteLine("Да");
 }
 else{
    Console.WriteLine("Нет");
 }
 int[] GetArrayFromString(string stringArray){
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] mas = new int[nums.Length];
    for (int i = 0; i<nums.Length;i++){
        mas[i] = int.Parse(nums[i]);
    }
    return mas;
 }
 bool FindElement(int[] array, int el){
    foreach (var item in array){
        if (el == item ) return true;
    }
    return false;
 }