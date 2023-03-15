int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
void PrintData( int res)
{
    Console.WriteLine(res);
}
int[] InserMethod(int[] arr)
{
    int [] resArr = new int[arr.Length];
    
    for (int i = 0; i < arr.Length; i++)
    {
        int key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
    for (int i = 0; i < arr.Length; i++) resArr[i] = arr[i];
    return resArr;
}
int arrLenght = ReadData("Введите длинну массива:");
int arrMinVol = ReadData("Введите Min значение элемента  массива (число должно быть > или = 0!!!):");
int arrMaxVol = ReadData("Введите Max значение элемента массива:");
int[] CountMethod(int[] arr)
{
    int [] resArr = new int[arr.Length];
    int n = arr.Length;
    int[] output = new int[n];
    int[] count = new int[arrMaxVol + 1];
    for (int i = 0; i < (arrMaxVol + 1); i++) count[i] = 0;
    for (int i = 0; i < n; ++i) ++count[arr[i]];
    for (int i = 1; i <= arrMaxVol; ++i) count[i] += count[i - 1];
    for (int i = n -1; i  >= 0; i--)
    {
        output[count[arr[i]] - 1] = arr[i];
        --count[arr[i]];
    }
    for (int i = 0; i < n; ++i) arr[i] = output[i];
    for (int i = 0; i < arr.Length; i++) resArr[i] = arr[i];
    return resArr;
}
int[] testArr = Gen1DArray(arrLenght, arrMinVol, arrMaxVol);
Console.WriteLine("Исходный сгенерированный массив: ");
Print1DArr(testArr);
Console.WriteLine("");
int[] insertArr = InserMethod(testArr);
Console.WriteLine("Отсортированный массив методом Вставки: ");
Print1DArr(insertArr);
int[] counttArr = CountMethod(testArr);
Console.WriteLine("");
Console.WriteLine("Отсортированный массив методом Подсчета: ");
Print1DArr(counttArr);
Console.WriteLine("");
Console.Write("Разница м/д Макс и Мин элементами массива: ");
PrintData(counttArr[counttArr.Length - 1] - counttArr[0]);