void FillArray(int[] collection) //Метод с именем FillArray
//ключевое слово void
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection) //Метод, печатающий массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine(collection[index]);
        index++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
            position = index;
            break;
        index++;
    }
    return position;
}

int[] array = new int[10]; //автоматически создает массив с 10 элементами
//                           по умолчанию они равны нулю
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
