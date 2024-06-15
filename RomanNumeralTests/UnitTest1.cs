using RomanNumerals;

namespace RomanNumeralTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase (1)]
    [TestCase (3999)]
    public void MethodTakesIntegerBetween1And3999(int number)
    {
        var sut = new Services();
        Assert.DoesNotThrow(()=>sut.ConvertToRoman(number));
    }
    
    [Test]
    public void OutOfRangeThrows()
    {
        var sut = new Services();
        Assert.Throws<ArgumentOutOfRangeException>(()=>sut.ConvertToRoman(4000));
    }
    [Test]
    public void FourDigitThousandsCovert()
    {
        var sut = new Services();
        var result = sut.ConvertToRoman(1000);
        Assert.AreEqual("M", result);
    }
}