class Program
{
    static void Main(string[] args)
    {
        int max_temp=0, result=0,temp=0;
        Console.WriteLine("Input Length Of Street");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Distance Of Shop");
        int distance = int.Parse(Console.ReadLine());
        int[] shop = new int[length];
        Console.WriteLine("Input Number Of Customer");
        for (int i=0;i<length;i++)
        {
            shop[i] = int.Parse(Console.ReadLine());
        }
        for (int i=distance;i<(length-(distance));i++)
        {
            for (int j=1;j<=distance;j++)
            {
                temp = temp+shop[i-j]+shop[i+j];
            }
            max_temp = shop[i] + temp;
            temp = 0;
            if (max_temp >= result)
            {
                result = max_temp;
            }
        }

        Console.WriteLine("Most Customer As Possibility Is {0}",result);
    }
}
