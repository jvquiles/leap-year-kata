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
}