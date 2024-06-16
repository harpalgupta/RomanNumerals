using RomanNumerals;

namespace RomanNumeralTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase (0)]
    [TestCase (4000)]
    public void MethodDoesNotTakeOfRangeNumbers(int number)
    {
        var sut = new Services();
        Assert.Throws<ArgumentOutOfRangeException>(()=>sut.ConvertToRoman(number));
    }
    
    [Test]
    public void FourDigitThousandsCovert()
    {
        var sut = new Services();
        var result = sut.ConvertToRoman(1000);
        Assert.AreEqual("M", result);
    }

    [Test]
    [TestCase(2022,"MMXXII")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(1666, "MDCLXVI")]
    public void TestUsingExamples(int integerRepresentation, string expectedRomanNumerals)
    {
        var sut = new Services();
        var result = sut.ConvertToRoman(integerRepresentation);
        Assert.AreEqual(expectedRomanNumerals, result);
    }


    [Test]
    public void TestSpecialConversion()
    {

        var sut = new Services();
        var result = sut.HandleSpecialConversion(900);
        Assert.AreEqual("CM", result);

    }
}