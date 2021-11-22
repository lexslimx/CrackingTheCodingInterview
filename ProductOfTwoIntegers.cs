public class ProductOfTwoIntegers
{
    public int GetProduct(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }
        else if (b < 0)
        {
            for (int i = (b * -1); i > 1; i--)
            {
                a = a + a;
            }

            return -(a);
        }
        else
        {
            for (int i = b; i > 1; i--)
            {
                a = a + a;
            }

            return a;
        }
    }
}