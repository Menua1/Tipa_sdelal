void NumDigitsSum()
{
    Console.Write("input number: ");
    var num = Console.ReadLine();
    int[] arr = new int[num.Length];

    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine(num[i]);
        arr[i] = Convert.ToInt16(num[i].ToString());
    }

    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        sum += arr[i];
    }
    Console.WriteLine(sum);
}

NumDigitsSum();