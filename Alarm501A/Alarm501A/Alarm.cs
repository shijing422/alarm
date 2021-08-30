using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: Alarm.cs
 * Purpose: Class used to represent Alarm
 */



namespace Alarm501
{
    /// <summary>
    /// Class used to represent Alarm
    /// </summary>
    public class Alarm
    {

        /// <value>
        /// Set or Get the time of the alarm
        /// </value>
        private DateTime time = DateTime.Now;
        public DateTime Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;

            }
        }







        /// <value>
        /// set or get the status of the alarm. If the alarm is on, otherwise it is off
        /// </value>
        private bool on = true;
        public bool ON
        {
            get
            {
                return on;
            }
            set
            {
                on = value;

            }
        }


        /// <value>
        /// To sting the alarm
        /// </value>
        /// <returns>return a string represents the text of this alarm</returns>
        public string toString()
        {

            string content = time.ToString("hh:mm  tt");
            if (on == true)
            {
                content += "   ON";
            }
            else
            {
                content += "    OFF";
            }

            return content;

        }
    }


}

