using System;
using System.Globalization;
using FactoryManager.AppService.ConfigurationReader;
using FactoryManager.Model.MainForm;

namespace FactoryManager.AppService.DateTimeCounting
{
    public class CurrentDateTimeHelper : ICurrentDateTimeHelper
    {
        private readonly IConfigurationReader configurationReader;
        public CurrentDateTimeHelper(IConfigurationReader _configurationReader)
        {
            this.configurationReader = _configurationReader;
        }

        public string GetCurrentDate()
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            return currentDate;
        }

        public string GetCurrentTime()
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            return currentTime;
        }

        public string GetCurrentDay()
        {
            string currentDay = DateTime.Now.ToString("dddddddddd").ToUpper();
            return currentDay;
        }

        public string GetCurrentWeek()
        {
            DateTime time = DateTime.Now;

            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);

            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday).ToString();
        }

        public DateTimeViewModel GetAllDateTimeValues()
        {
            DateTimeViewModel mainFormVM = new DateTimeViewModel
            {
                CurrentDate = GetCurrentDate(),
                CurrentTime = GetCurrentTime(),
                CurrentDay = GetCurrentDay(),
                WeekNumber = GetCurrentWeek()
            };

            return mainFormVM;
        }


        public string GetCopyrightYear()
        {
            var copyright = configurationReader.GetAppCopyright();
            string copyrightYear = copyright.Substring(copyright.Length - 4);

            string currentYear = DateTime.Now.ToString("yyyy");
            if (currentYear == copyrightYear)
            {
                return null;
            }
            else
            {
                return "- " + currentYear;
            }
        }
    }
}
