using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace _8HrBackupTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime endTime;
        //double span;        

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
         UIntPtr dwExtraInfo);
        const int KEYEVENTF_EXTENDEDKEY = 0x1;
        const int KEYEVENTF_KEYUP = 0x2;
        const int CAPSLOCK = 0x14;
        const int NUMLOCK = 0x90;
        const int SCROLLLOCK = 0x91;
        public double weekMins, leftOvers;
        TimeSpan remainingTime;
        int remainMins;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TimeKeeper2");
            weekMins = Convert.ToDouble(regkey.GetValue("wkMins"));
            leftOvers = Convert.ToDouble(regkey.GetValue("leftOvers"));
            
             DateTime thisDay = DateTime.Today;
            string today = thisDay.ToString("ddd");             
            if (today == "Mon")
            {
                if (weekMins < 2400)
                {
                    regkey.SetValue("leftOvers", 2400 - weekMins);
                    regkey.SetValue("wkMins", 0);
                    gbMakeup.Visible = true;
                    lblMakeupMins.Text = Convert.ToString(regkey.GetValue("leftOvers"));
                }
                else
                {
                    regkey.SetValue("wkMins", 0);
                }
            }
        }

        

        private void btnStart_Click(object sender, EventArgs e)
        {

            endTime = DateTime.Now;
            endTime = endTime.AddHours(8);
            remainingTime = endTime - DateTime.Now;
            remainMins = Convert.ToInt16(remainingTime.TotalMinutes);
            
            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnMinsAdd.Enabled = true;
            btnMinsMinus.Enabled = true;
        }


        public void LocNLoc()
        {
            keybd_event(CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            keybd_event(CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);                      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            remainingTime = endTime - DateTime.Now;
            remainMins = Convert.ToInt16(remainingTime.TotalMinutes);
            
            if (remainingTime < TimeSpan.Zero) //end of day
            {   
                Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TimeKeeper2");                
                //set wkHrs
                regkey.SetValue("wkMins", (weekMins + 480 - remainMins));
                //reset dayMins to zero               
                regkey.Close();
                timer1.Enabled = false;

                lblMessage.Text = "SHIFT COMPLETE!";
                SetFocus();
                new System.Threading.ManualResetEvent(false).WaitOne(10000);
                Application.Exit();
            }
            else
            {
                LocNLoc();
                Thread.Sleep(10);
                LocNLoc();                             
                               
                //display dayMins on pbarShiftCountdown                
                pbarShiftCountdown.Value = 480-remainMins;
                label21.Text = "Remaining: " + remainingTime.ToString("h\\:mm");


                //get wkHrs
                //double weekHrs = Convert.ToDouble(regkey.GetValue("wkHrs"));
                Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TimeKeeper2");
                double weekly = Convert.ToDouble(regkey.GetValue("wkMins"));
                pbarWeek.Value = Convert.ToInt16(weekly)+(480-remainMins);                

            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TimeKeeper2");
            //set wkHrs
            regkey.SetValue("wkMins", (weekMins + 480 - remainMins));
            if (480 - remainMins > 0)
            {
                double left = Convert.ToDouble(regkey.GetValue("leftOvers"));
                regkey.SetValue("leftOvers", (left + (480 - remainMins)));
                //reset dayMins to zero               
                regkey.Close();
                lblMessage.Text = "SHIFT COMPLETE!";
                SetFocus();
                new System.Threading.ManualResetEvent(false).WaitOne(10000);
                Application.Exit();
            }
        }

        private void btnMinsAdd_Click(object sender, EventArgs e)
        {
            int ts = 0-Convert.ToInt16(tbAdjMins.Text);
            // tSpan is 0 days, 1 hours, 30 minutes and 0 second.
            TimeSpan tSpan = new System.TimeSpan(0, 0, ts, 0);
            endTime = endTime.Add(tSpan);            
        }
       
        private void btnMinsMinus_Click_1(object sender, EventArgs e)
        {
            int ts = Convert.ToInt16(tbAdjMins.Text);
            // tSpan is 0 days, 1 hours, 30 minutes and 0 second.
            TimeSpan tSpan = new System.TimeSpan(0, 0, ts, 0);
            endTime = endTime.Add(tSpan); 
        }
        
        public void SetFocus()
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Focus();
            this.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TimeKeeper2");
            regkey.SetValue("leftOvers", 0);
        }

        


       
    }
}
