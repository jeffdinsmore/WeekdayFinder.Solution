using System;
using System.Collections.Generic;
using System.Linq;

namespace WeekdayFinder.Models
{
  public class Weekday
  {
    public string Month(string month)
    {
      Dictionary<string, string> months = new Dictionary<string, string>() { {"january", "11"}, {"february", "12"}, {"march", "1"}, {"april", "2"}, {"may", "3"}, {"june", "4"}, {"july", "5"}, {"august", "6"}, {"september", "7"}, {"october", "8"}, {"november", "9"}, {"december", "10"} }; 
      
      string output = months[month];
      return output;
    }
    
    public int Century(string year)
    {
      string centuryString = year.Substring(0,2);
      int century = int.Parse(centuryString);
      return century;
    }

    public int TwoDigitYear(string year)
    {
      string twoDigitYearString = year.Substring(2,2);
      int twoDigitYear = int.Parse(twoDigitYearString);
      return twoDigitYear;
    }

    public int ConvertYear(string year)
    {
      int Year = int.Parse(year);
      return Year;
    }

    public int ZellersEquation(string stringMonth, double day, string year)
    {
      Dictionary<string, string> months = new Dictionary<string, string>() { {"january", "11"}, {"february", "12"}, {"march", "1"}, {"april", "2"}, {"may", "3"}, {"june", "4"}, {"july", "5"}, {"august", "6"}, {"september", "7"}, {"october", "8"}, {"november", "9"}, {"december", "10"} }; 
      
      string monthString = months[stringMonth];
      double month = int.Parse(monthString);

      string twoDigitYearString = year.Substring(2,2);
      double twoDigitYear = int.Parse(twoDigitYearString);

      string centuryString = year.Substring(0,2);
      double century = int.Parse(centuryString);

      double Day = day + Math.Floor((13*month-1)/5) + twoDigitYear + Math.Floor(twoDigitYear/4) + Math.Floor(century/4) - (2*century);
      if (Day < 0 && Day > -7)
      {
        Day = Day + 7;
      }
      double Day2 = Math.Floor(Day % 7);
      if (Day2 < 0 && Day2 > -7)
      {
        Day2 = Day2 + 7;
      }
      int DayOfTheWeek = Convert.ToInt32(Day2);
      return DayOfTheWeek;
    }
  }
}