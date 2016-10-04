using System;
using System.Text.RegularExpressions;

public class Q2
{
    public static int ProductCost(char code)
    {
        int returnValue;
        switch (code)
        {
            case 'A':
                returnValue = 100;
                break;
            case 'B':
            case 'C':
            case 'D':
                returnValue = 200;
                break;
            case 'E':
                returnValue = 250;
                break;
            default:
                returnValue = 0;
                break;

        }
        return returnValue;
    }



    public static bool CanBuy(int qty)
    {
        return (qty <= 24) && (qty % 8 == 0);
    }

    public static double FutureValue(int noOfMonths, double monthlyAmount, double monthlyInterest)
    {
        double savings = 0;
        for (int i = 0; i < noOfMonths; i++)
        {
            savings += monthlyAmount;
            savings += savings * monthlyInterest;
        }
        return savings;
    }

    public static void DoubleValues(ref int a, ref int b)
    {
        a *= 2;
        b *= 2;
    }

    public static int Search (String str, String searchString)
    {
        int result = 0;
        String[] elems = str.Split(' ');
        foreach (String item in elems)
        {

            return Regex.Matches(str, searchString).Count;
            //if (item.Equals(searchString)) {
            //    result++;
            //}
        }
        return result;
    }






}
