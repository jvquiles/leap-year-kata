using leap_year_domain;

namespace leap_year_test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(100)]
    public void NoLeapYear(int year)
    {
        var result = LeapYear.IsLeap(year);
        Assert.False(result);
    }
    
    [TestCase(4)]
    [TestCase(400)]
    public void IsLeapYear(int year)
    {
        var result = LeapYear.IsLeap(year);
        Assert.True(result);
    }
}