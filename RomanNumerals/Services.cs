namespace RomanNumerals;

public class Services
{
    public string ConvertToRoman(int decimalNumber)
    {
        if (!(decimalNumber >= 1 && decimalNumber <= 3999))
        { 
            throw new ArgumentOutOfRangeException("Can only accept integer between 1 and 3999");
        }

        var output = string.Empty;

        var remainder = decimalNumber;
        
        if (remainder >= 1000)
        {
            var result = remainder / 1000;
            for (int i = 0; i < result; i++)
            {
                output += blah[1000];
            }
            remainder -= result*1000; //remove what have converted
        }

        if (remainder >= 500)
        {
            var result = remainder / 500;
            for (int i = 0; i < result; i++)
            {
                output += blah[500];
            }
            remainder -= result * 500; //remove what have converted
        }


        return output;
    }

    public Dictionary<int, string> blah = new Dictionary<int, string>{{1,"I"}, {5,"V"},{10,"X"},{50,"L"},{100,"C"},{500,"D"},{1000,"M"}};

}