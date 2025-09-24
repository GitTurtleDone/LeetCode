// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Solution sol = new Solution();
// int result = sol.HammingWeight(121);
// Console.WriteLine(result);
using System;

public class Solution
{
    public int HammingWeight(int n)
    {
        int count = 0;
        while (n != 0)
        {
            count += n & 1;
            n >>= 1;
        }
        return count;

    }

    public string ReverseBits(int n)
    {
        char[] binaryArray = Convert.ToString(n, 2).PadLeft(32, '0').ToCharArray();
        Array.Reverse(binaryArray);
        return new string(binaryArray);
    }

    public string AddBinary(string a, string b)
    {
        int maxLength = Math.Max(a.Length, b.Length);
        a = a.PadLeft(maxLength, '0');
        b = b.PadLeft(maxLength, '0');

        string result = "";
        int carry = 0;

        for (int i = maxLength - 1; i >= 0; i--)
        {
            int bitA = a[i] - '0';
            int bitB = b[i] - '0';
            int sum = bitA + bitB + carry;
            result = (sum % 2).ToString() + result;
            carry = sum / 2;
        }

        if (carry > 0)
        {
            result = carry.ToString() + result;
        }

        return result;
    }


}
public class Program
{
    public static void Main()
    {
        Solution sol = new Solution();
        int result = sol.HammingWeight(2147483645);
        Console.WriteLine(result);
    }
}
