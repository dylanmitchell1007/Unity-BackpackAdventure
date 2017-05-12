using System.Collections.Generic;

public class LargeNumberStorage
{
    public bool negative;
    public List<int> number;

    public static LargeNumberStorage operator +(LargeNumberStorage a, LargeNumberStorage b)
    {
        var larger = a.number.Count > b.number.Count ? a : b;
        var smaller = larger == a ? b : a;
        for (var i = larger.number.Count - smaller.number.Count; i < larger.number.Count; i++)
            larger.number[i] = smaller.number[i - (larger.number.Count - smaller.number.Count)] + larger.number[i];
        for (var i = larger.number.Count - 1; i > -1; i--)
            if (larger.number[i] > 9)
            {
                var num = larger.number[i];
                var carry = num / 10;
                if (i != 0)
                {
                    larger.number[i - 1] += carry;
                    larger.number[i] = larger.number[i] % 10;
                }
                else
                {
                    larger.number.Insert(0, carry);
                    larger.number[i + 1] = larger.number[i] % 10;
                }
            }
        return larger;
    }

    public static LargeNumberStorage operator -(LargeNumberStorage a, LargeNumberStorage b)
    {
        //need to use function below to figure out if the subtraction will come out negative
        var larger = a.number.Count < b.number.Count ? b : a;
        var smaller = larger == a ? b : a;
        bool resultNegitive = ResultNegative(a, b);
        for (var i = larger.number.Count - 1; i > -1 + larger.number.Count - smaller.number.Count; i--)
            larger.number[i] = larger.number[i] - smaller.number[i - (larger.number.Count - smaller.number.Count)];


        for (var i = larger.number.Count - 1; i > -1; i--)
        {
            if (larger.number[i] < 0)
                if (i != 0)
                {
                    larger.number[i] = 10 - larger.number[i] * -1;
                    larger.number[i - 1] -= 1;
                }
        }
        if (resultNegitive)
        {
            larger.negative = true;
            for (var i = 0; i < larger.number.Count; i++)
                if (larger.number[i] < 0)
                    larger.number[i] *= -1;
        }
        return larger;
    }


    public static bool ResultNegative(LargeNumberStorage a, LargeNumberStorage b)
    {
        //basically a negative check
        if (b.number.Count > a.number.Count) return true;
        if (a.number.Count == b.number.Count)
        {
            for (var i = 0; i < a.number.Count; i++)
                if (a.number[i] > b.number[i])
                    break;
                else if (a.number[i] == b.number[i])
                    continue;
                else if (a.number[i] < b.number[i])
                    return true;
        }
        return false;

    }

}