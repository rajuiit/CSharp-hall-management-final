using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hall_Management_System.Basic
{
    class time
    {
        public static String todbTime(DateTime start)
        {
            string month = start.Month.ToString();
            string day = start.Day.ToString();
            string hours = start.Hour.ToString();
            string minutes = start.Minute.ToString();
            string seconds = start.Second.ToString();
            if (month.Length < 2) month = "0" + month;
            if (day.Length < 2) day = "0" + day;
            if (hours.Length < 2) hours = "0" + hours;
            if (minutes.Length < 2) minutes = "0" + minutes;
            if (seconds.Length < 2) seconds = "0" + seconds;
            
            return start.Year + "-" + month + "-" + day + " " + hours + ":" + minutes + ":" + seconds;

        }
        public void inputToSeconds(string timerInput)
        {
            try
            {
                string[] timeArray = new string[3];
                int minutes = 0;
                int hours = 0;
                int seconds = 0;
                int occurence = 0;
                int length = 0;

                occurence = timerInput.LastIndexOf(":");
                length = timerInput.Length;

                //Check for invalid input
                if (occurence == -1 || length != 8)
                {
                    MessageBox.Show("Invalid Time Format.");
                   
                }
                else
                {
                    timeArray = timerInput.Split(':');

                    seconds = Convert.ToInt32(timeArray[2]);
                    minutes = Convert.ToInt32(timeArray[1]);
                    hours = Convert.ToInt32(timeArray[0]);

                   // this.alarmTime += seconds;
                    //this.alarmTime += minutes * 60;
                    //this.alarmTime += (hours * 60) * 60;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("inputToSeconds(): " + e.Message);
            }
        }

        public static string secondsToTime(int seconds)
        {
            int minutes = 0;
            int hours = 0;

            while (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }
            while (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }

            string strHours = hours.ToString();
            string strMinutes = minutes.ToString();
            string strSeconds = seconds.ToString();

            if (strHours.Length < 2) strHours = "0" + strHours;
            if (strMinutes.Length < 2) strMinutes = "0" + strMinutes;
            if (strSeconds.Length < 2) strSeconds = "0" + strSeconds;

            return strHours + ":" + strMinutes + ":" + strSeconds;
        }

    }
}
