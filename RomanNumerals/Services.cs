namespace RomanNumerals;

public class Services
{
    public string ConvertToRoman(int decimalNumber)
    {
        if (!(decimalNumber >= 1 && decimalNumber <= 3999))
        {
            throw new ArgumentOutOfRangeException("Can only accept integer between 1 and 3999");
        }

        var stringRepresentation = decimalNumber.ToString();

        remainder = decimalNumber;
        var output = string.Empty;
        int[] divisorValues = new int[] { 1000,500,100,50,10,5,1 };

        //for (int i = 0; i < stringRepresentation.Length; i++)
        //{
        //    char character = stringRepresentation[i];
        //    if ( character != '0')
        //    {
        //       var numberVal =Convert.ToInt32(character) * divisorValues[i] ;


        //    }

        //}

        //could be better to handle the decimal as character array
        for (int i = 0; i < divisorValues.Length; i++)
        {
            if (remainder == 0) break;
            output += HandleConversion(divisorValues[i]);
        }


        remainder = 0;
        return output;
    }


    public string HandleSpecialConversion(int numberToHandle)
    {
        var stringRep = numberToHandle.ToString();
        TypeOfNumber? type = null;
        var thousands = (numberToHandle / 1000) * 1000;
        var hundreds = ((numberToHandle % 1000) / 100) * 100;
        var tens = ((numberToHandle % 100) / 10) * 10;
        var ones = (numberToHandle % 10) / 1;

        if (stringRep.Length == 3) {
            type = TypeOfNumber.Hundreds;
        }
        if (stringRep.Length == 2)
        {
            type = TypeOfNumber.Tens;
        }
        if(stringRep.Length == 1)
        {
            type = TypeOfNumber.Ones;
        }

        var firstNumeral = string.Empty;
        var secondNumeral = string.Empty;

        if(type == TypeOfNumber.Hundreds)
        {
            var divisor = 1000;

            firstNumeral = blah[divisor - hundreds];
            secondNumeral = blah[divisor];

        }

        if (type == TypeOfNumber.Tens)
        {
            var divisor = 100;

            firstNumeral = blah[divisor - tens];
            secondNumeral = blah[divisor];

        }
        if (type == TypeOfNumber.Ones)
        {
            var divisor = 10;

            firstNumeral = blah[divisor - ones];
            secondNumeral = blah[divisor];

        }
        return firstNumeral + secondNumeral;

    }

    private string HandleConversion(int divisor)
    {
        var output = string.Empty;
        int result=0;
        
        if (remainder >= divisor )
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
            else
            {
                output += HandleSpecialConversion(result*divisor);
                remainder -= result * divisor;
            }

        }

        return output;
    }

    public Dictionary<int, string> blah = new Dictionary<int, string>{{1,"I"}, {5,"V"},{10,"X"},{50,"L"},{100,"C"},{500,"D"},{1000,"M"}};
    private int remainder;

    public enum TypeOfNumber
    {
        Hundreds,
        Tens,
        Ones
    }
}