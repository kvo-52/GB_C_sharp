// Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

int[] CreateArray(int temp)
{
    if(temp <2)
    {
        temp = 2;
    }
    int[] tempArray = new int[temp];
    tempArray[0] = 0;
    tempArray[1] = 1;
    for (int i = 2; i < temp; i++)
    {
        tempArray[i] = tempArray[i-1] + tempArray[i-2];
    }
    return tempArray;
}
int[] CopyArr(int[] arr)
{
    int[] result = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }

    return result;
}

void Runner()
{
    int[] arr1 = CreateArray(len:5);
    PrintArray(arr1);

    int[] arr2 = arr1;
    PrintArray(arr2);

    arr1[0] = 422;
    PrintArray(arr1);
    PrintArray(arr2);

    int[] arr3 = CopyArr(arr1);
    arr1[1] = 1000;

    PrintArray(arr1);
    PrintArray(arr3);
}

Runner();
