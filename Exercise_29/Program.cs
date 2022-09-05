int[] RandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i ++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
    System.Console.Write($"[{string.Join(", ", RandomArray())}]");