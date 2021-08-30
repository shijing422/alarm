using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Alarm501;

namespace Alarm501A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkAlarmList();
            invisibleTimer();
            invisibleAlarming();
        }



        private List<Alarm> AlarmList = new List<Alarm>();






        /// <summary>
        /// When Loading the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            exRunTimer.Enabled = true;



            /* using (StreamReader sr = new StreamReader(@"C:\Users\shijingzhang\source\repos\Alarm501\Alarm501A\Alarm501A\alarm501.txt"))
             {
                 while (sr.Peek() >= 0)
                 {

                     string line = sr.ReadLine();
                     while (String.IsNullOrEmpty(line) == false && String.IsNullOrWhiteSpace(line) == false)
                     {
                         string[] linelist = line.Split(' ');
                         Alarm a = new Alarm();
                         if (linelist[2].Contains("ON"))
                         {
                             a.ON = true;

                         }

                         else a.ON = false;


                         string timeline = linelist[0] + " " + linelist[1];
                         a.Time = DateTime.Parse(timeline);
                         AlarmList.Add(a);
                         line = sr.ReadLine();

                     }
                 }
             }

             */


            StreamReader sr = new StreamReader(@"C:\Users\shijingzhang\source\repos\Alarm501\Alarm501A\Alarm501A\alarm501.txt", false);
            string line = sr.ReadLine();



             while(!String.IsNullOrEmpty(line) && !String.IsNullOrWhiteSpace(line))
            {
                string[] linelist = line.Split(' ');
                Alarm a = new Alarm();
                if (linelist[2].Contains("ON"))
                {
                    a.ON = true;

                }

                else a.ON = false;


                string timeline = linelist[0] + " " + linelist[1];
                a.Time = DateTime.Parse(timeline);
                AlarmList.Add(a);
                line = sr.ReadLine();
            }
            


            sr.Close();



            checkAlarmList();
            showAlarmList();

        }
        /// <summary>
        /// When closing the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AlarmList.Count > 0)
            {
                TextWriter tw = new StreamWriter(@"C:\Users\shijingzhang\source\repos\Alarm501\Alarm501A\Alarm501A\alarm501.txt", false);
                tw.Write(string.Empty);
                tw.Close();
                // Path.Combine(Environment.CurrentDirectory, "alarm501.txt")
                //@"C:\Users\shiji\OneDrive\Desktop\cis501p1\Alarm501\Alarm501\alarm501.txt"
                using (StreamWriter sw = File.AppendText(@"C:\Users\shijingzhang\source\repos\Alarm501\Alarm501A\Alarm501A\alarm501.txt"))
                {


                    foreach (Alarm i in AlarmList)
                    {

                        string timetext = i.Time.ToString();
                        if (i.ON == true) timetext += " ON";
                        else timetext += " OFF";
                        sw.WriteLine(timetext);

                    }

                }
            }

        }



























        private bool Editing = false;
        private Alarm EditingItem;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exEdit_Click(object sender, EventArgs e)
        {
            if (exAlarmList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = (ListViewItem)exAlarmList.SelectedItems[0];
                if (selectedItem != null)
                {

                    Editing = true;
                    Alarm i = (Alarm)selectedItem.Tag;
                    EditingItem = i;
                    visibleTimer();

                    exTimer.Value = i.Time;

                    if (i.ON == true) exAlarmON.Checked = true;
                    else exAlarmON.Checked = false;
                }
            }

        }

        private void exAdd_Click(object sender, EventArgs e)
        {
            visibleTimer();
        }

        private void exSnooze_Click(object sender, EventArgs e)
        {
            snoozeStartTime = DateTime.Now;


            exSnoozeTimer.Start();
        }

        private void exStop_Click(object sender, EventArgs e)
        {
            stopStartTime = DateTime.Now;
            exAlarmTurnOff.Start();

            foreach (Alarm a in AlarmList)
            {
                if (a.Time == runingAlarm.Time)
                {
                    a.ON = false;
                }
            }
            invisibleAlarming();
            showAlarmList();
        }

        private void exCancel_Click(object sender, EventArgs e)
        {
            invisibleTimer();
            checkAlarmList();
        }

        private void exSet_Click(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                foreach (Alarm a in AlarmList)
                {
                    if (a.Time == EditingItem.Time && a.ON == EditingItem.ON)
                    {
                        a.Time = exTimer.Value;
                        if (exAlarmON.Checked == true) a.ON = true;
                        else a.ON = false;
                    }
                }

                Editing = false;
            }
            else
            {
                Alarm tempAlarm = new Alarm();
                tempAlarm.Time = exTimer.Value;
                if (exAlarmON.Checked == true)
                {
                    tempAlarm.ON = true;
                }
                else
                {
                    tempAlarm.ON = false;
                }
                AlarmList.Add(tempAlarm);
            }
            showAlarmList();

            invisibleTimer();
            checkAlarmList();

        }






        void checkAlarmList()
        {
            if (AlarmList.Count == 0)
            {
                exEdit.Enabled = false;
            }
            else
            {
                exEdit.Enabled = true;
            }
        }
        void invisibleAlarming()
        {
            exAdd.Enabled = true;
            exEdit.Enabled = true;
            exSnooze.Enabled = false;
            exStop.Enabled = false;

        }
        void invisibleTimer()
        {
            exCancel.Visible = false;
            exSet.Visible = false;
            exTimer.Visible = false;
            exAlarmON.Visible = false;
        }

        void visibleAlarming()
        {
            exAlarming.Text = "Alarming!!!!!";
            exSnooze.Enabled = true;
            exStop.Enabled = true;
            exEdit.Enabled = false;
            exAdd.Enabled = false;
        }
        void visibleTimer()
        {
            exCancel.Visible = true;
            exSet.Visible = true;
            exTimer.Visible = true;
            exAlarmON.Visible = true;
        }
        void showAlarmList()
        {
            exAlarmList.Items.Clear();
            foreach (Alarm a in AlarmList)
            {
                ListViewItem i = new ListViewItem();
                i.Tag = a;
                i.Text = a.toString();

                exAlarmList.Items.Add(i);

            }

        }
















        private Alarm runingAlarm;
        private void exRunTimer_Tick(object sender, EventArgs e)
        {
            foreach (Alarm a in AlarmList)
            {
                if (a.ON == true)
                {

                    DateTime nowTime = DateTime.Now;
                    if (a.Time.Hour == nowTime.Hour && a.Time.Minute == nowTime.Minute && a.Time.Second == nowTime.Second)
                    {
                        runingAlarm = a;
                        visibleAlarming();
                    }
                }
            }

        }
        private DateTime snoozeStartTime;
        private void exSnoozeTimer_Tick(object sender, EventArgs e)
        {
            exAlarming.Text = "Snoozing...ZZZZ";
            DateTime threeSec = DateTime.Now;
            if (threeSec.Second == snoozeStartTime.AddSeconds(3).Second)
            {
                exAlarming.Text = "Alarming!!!!!!";
                exSnoozeTimer.Stop();
            }
        }
        private DateTime stopStartTime;
        private void exAlarmTurnOff_Tick(object sender, EventArgs e)
        {
            exAlarming.Text = "Alarm Turn Off";
            DateTime threeSec = DateTime.Now;
            if (threeSec.Second == stopStartTime.AddSeconds(3).Second)
            {
                exAlarming.Text = "Running.......";
                exAlarmTurnOff.Stop();
            }
        }
    }
}
