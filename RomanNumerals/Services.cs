namespace RomanNumerals;

public class Services
{
    public string ConvertToRoman(int decimalNumber)
    {
        if (!(decimalNumber >= 1 && decimalNumber <= 3999))
        {
            throw new ArgumentOutOfRangeException("Can only accept integer between 1 and 3999");
        }


        remainder = decimalNumber;
        var output = string.Empty;
        int[] divisorValues = new int[] { 1000,500,100,50,10,5,1 };
        for (int i = 0;i < divisorValues.Length; i++)
        {
            if(remainder == 0)break;
            output += handleConversion(divisorValues[i]);
        }


        remainder = 0;
        return output;
    }

    private string handleConversion(int divisor)
    {
        var output = string.Empty;
        int result=0;
        if (remainder >= divisor)
        {
            result = remainder / divisor;
            if(result <= 3)
            {
                for (int i = 0; i < result; i++)
                {
                    output += blah[divisor];
                }
                remainder -= result * divisor; //remove we what have converted
            }  
        }
        //if (remainder > 0) //handling 990
        //{
        //    var leftOver = 1000 - (remainder / 100 * 100);
        //    remainder = 1000 - remainder;

        //    output += blah[leftOver] + blah[1000];
        //    output += blah[remainder] + blah[100];
        //    remainder = 0;
        //}
                  
        return output;
    }

    public Dictionary<int, string> blah = new Dictionary<int, string>{{1,"I"}, {5,"V"},{10,"X"},{50,"L"},{100,"C"},{500,"D"},{1000,"M"}};
    private int remainder;
}