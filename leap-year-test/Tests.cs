namespace leap_year_test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Year1()
    {
        var result = LeapYear.IsLeap(1);
        Assert.False(result);
    }

    [Test]
    public void Year2()
    {
        var result = LeapYear.IsLeap(2);
        Assert.False(result);
    }

    [Test]
    public void Year3()
    {
        var result = LeapYear.IsLeap(3);
        Assert.False(result);
    }
}