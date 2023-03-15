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
void BubleSort (int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length-1; i++)
    {  
        for (int j = 0; j < arr.Length - 1-i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }

        }
    }
    
}


int[] testArr = Gen1DArray(10,100,999);
Print1DArr(testArr);
BubleSort(testArr);
Print1DArr(testArr);