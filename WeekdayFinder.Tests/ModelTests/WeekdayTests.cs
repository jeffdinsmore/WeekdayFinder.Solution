using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System.Collections.Generic;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class WeekdayTests
  {
    [TestMethod]
    public void CheckMonth_WhenMonthIsEnteredWillOutputValue_MonthValue()
    {
      Weekday testMonth = new Weekday();
      string month = "march";
      Assert.AreEqual("1", testMonth.Month(month));
    }

    [TestMethod]
    public void CheckCentury_WhenYearIsEnteredWillOutputCentury_Century()
    {
      Weekday testCentury = new Weekday();
      string year = "2364";
      Assert.AreEqual(23, testCentury.Century(year));
    }
    
    [TestMethod]
    public void CheckTwoDigitYear_WhenYearIsEnteredWillOutputTwoDigitYear_TwoDigitYear()
    {
      Weekday testTwoDigitYear = new Weekday();
      string year = "2364";
      Assert.AreEqual(64, testTwoDigitYear.TwoDigitYear(year));
    }

    [TestMethod]
    public void ConvertYear_WhenYearIsEnteredWillOutputInteger_IntegerYear()
    {
      Weekday convert = new Weekday();
      string year = "2364";
      Assert.AreEqual(2364, convert.ConvertYear(year));
    }

    [TestMethod]
    public void ZellersEquation_DateEnteredReturnsInteger_Int()
    {
      Weekday equate = new Weekday();
      string year = "2001";
      double day = 28;
      double month = 1;
      Assert.AreEqual(3, equate.ZellersEquation(month, day, year));
    }
  }
}