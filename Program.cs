using LAB2;

public class Program
{
    public static void Main()
    {
        RomanNumber a = new RomanNumber(12);
        RomanNumber b = new RomanNumber(4);
        Console.WriteLine(a.ToString());
        Console.WriteLine(b.ToString());
        Console.WriteLine(RomanNumber.Add(a, b));
        Console.WriteLine(RomanNumber.Sub(a, b));
        Console.WriteLine(RomanNumber.Mul(a, b));
        Console.WriteLine(RomanNumber.Div(a, b));

        RomanNumber c = new RomanNumber(1232);
        RomanNumber d = new RomanNumber(422);

        Console.WriteLine("Sort: ");
        RomanNumber[] nums = { a, b, c, d };
        Array.Sort(nums);
        foreach (RomanNumber num in nums)
            Console.WriteLine("* " + num.ToString());

        Console.WriteLine("\nClone: ");
        Console.WriteLine("a = " + a);
        var p = (RomanNumber)a.Clone();
        a = (RomanNumber)b.Clone();
        Console.WriteLine("p = " + p);
        Console.WriteLine("a = " + a);

        Console.WriteLine("\nCompare: \nb & b");
        Console.WriteLine(b.CompareTo(b));
        Console.WriteLine("\nCompare: \nc & b");
        Console.WriteLine(c.CompareTo(b));
    }
}