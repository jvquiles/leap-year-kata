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
        bool result = LeapYear.IsLeap(1);
        Assert.False(result);
    }
}