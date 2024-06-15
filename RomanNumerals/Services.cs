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
        
        
        if (decimalNumber >= 1000)
        {
            var result = decimalNumber / 1000;
            for (int i = 0; i < result; i++)
            {
                output += blah[1000];
            }
        }

        return output;
    }

    public Dictionary<int, string> blah = new Dictionary<int, string>{{1,"I"}, {5,"V"},{10,"X"},{50,"L"},{100,"C"},{500,"D"},{1000,"M"}};

}