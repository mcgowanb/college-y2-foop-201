using System;

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

        }
        return returnValue;
    }

    public bool canBuy(int qty)
    {
        return (qty <= 24) && (qty % 8 == 0);
    }






}
