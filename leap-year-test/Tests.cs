﻿namespace leap_year_test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void NoLeapYear(int year)
    {
        var result = LeapYear.IsLeap(year);
        Assert.False(result);
    }
}