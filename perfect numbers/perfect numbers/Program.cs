Console.Write("Enter the first number: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int n2 = int.Parse(Console.ReadLine());

int[] perfectNumbers = GetPerfectNumbers(n1, n2);

Console.WriteLine("Perfect numbers between {0} and {1}:", n1, n2);
foreach (int perfect in perfectNumbers)
{
    Console.WriteLine(perfect);
}


static int[] GetPerfectNumbers(int n1, int n2)
{
    var perfectNumbers = new List<int>();

    for (int i = n1; i <= n2; i++)
    {
        if (IsPerfect(i))
        {
            perfectNumbers.Add(i);
        }
    }

    return perfectNumbers.ToArray();
}

static bool IsPerfect(int n)
{
    int sum = 0;

    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sum += i;
        }
    }
    return sum == n;
}

