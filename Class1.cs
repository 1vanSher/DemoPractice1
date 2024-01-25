using System.Xml.Linq;

namespace DemoPractice1
{
    public class Class1
    {
        public static string TimeDifference(string time1, string time2)
        {
            DateTime dateTime = TimeConvert(time1);
            DateTime dateTime2 = TimeConvert(time2);

            TimeSpan interval = dateTime2.Subtract(dateTime);
            return interval.ToString();
        }

        public static DateTime TimeConvert(string time1)
        {
            DateTime enteredDate = DateTime.Parse(time1);
            return enteredDate;
        }

        public static bool YearVis(string _year)
        {
            int Year = Convert.ToInt32(_year);
            if (Year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string TimeOfDay(string time)
        {
            DateTime dateTime = TimeConvert(time);

            int Hour = dateTime.Hour;

            switch (Hour)
            {
                case int n when (n >= 0 && n <= 6):
                    return "Ночь";
                    break;

                case int n when (n > 6 && n < 12):
                    return "Утро";
                    break;

                case int n when (n >= 12 && n < 18):
                    return "День";
                    break;

                case int n when (n >= 18 && n <= 23):
                    return "Вечер";
                    break;
            }
            return Hour.ToString();
        }
    }
}
