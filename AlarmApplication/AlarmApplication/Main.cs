using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace AlarmApplication
{
    
    public partial class FormMain : Form
    {
        private Stopwatch stopWatch;

        int totalSeconds;

        private SoundPlayer simpleSound;


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer_CurrentTime.Start();

            stopWatch = new Stopwatch();

            simpleSound = new SoundPlayer(@"alarmbell.wav");

            for (int i = 0;i < 10; i++)
            {
                cb_Hour.Items.Add("0" + i.ToString());
                cb_Minute.Items.Add("0" + i.ToString());
                cb_Second.Items.Add("0" + i.ToString());
            }

            for (int i = 10; i <= 24; i++)
            {
                cb_Hour.Items.Add(i.ToString());
            }

            for (int i = 10; i < 60; i++)
            {
                cb_Minute.Items.Add(i.ToString());
                cb_Second.Items.Add(i.ToString());
            }

            this.cb_Hour.SelectedIndex = 0;
            this.cb_Minute.SelectedIndex = 0;
            this.cb_Second.SelectedIndex = 0;

            for (int i = 0; i < 60; i++)
            {
                cb_TimerMinute.Items.Add(i.ToString());
                cb_TimerSecond.Items.Add(i.ToString());
            }

            this.cb_TimerMinute.SelectedIndex = 0;
            this.cb_TimerSecond.SelectedIndex = 10;

        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            pnl_OnButton.Height = btnAlarm.Height;
            pnl_OnButton.Top = btnAlarm.Top;

            pnl_Move.Visible = true;
            pnl_alarm.Visible = true;
            pnl_Stopwatch.Visible = false;
            pnl_Timer.Visible = false;
        }

        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            pnl_OnButton.Height = btnStopwatch.Height;
            pnl_OnButton.Top = btnStopwatch.Top;

            pnl_Move.Visible = true;
            pnl_alarm.Visible = false;
            pnl_Stopwatch.Visible = true;
            pnl_Timer.Visible = false;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            pnl_OnButton.Height = btnTimer.Height;
            pnl_OnButton.Top = btnTimer.Top;

            pnl_Move.Visible = true;
            pnl_alarm.Visible = false;
            pnl_Stopwatch.Visible = false;
            pnl_Timer.Visible = true;
        }

        private void timer_CurrentTime_Tick(object sender, EventArgs e)
        {
            lbl_CurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void pnl_alarm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lbl_AlarmTitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_SetAlarm_Click(object sender, EventArgs e)
        {
            timer_AlarmTime.Start();         
        }
        
        private void timer_AlarmTime_Tick(object sender, EventArgs e)
        {
            lbl_AlarmTime.Text = cb_Hour.SelectedItem.ToString() + ":" + cb_Minute.SelectedItem.ToString() + ":" + cb_Second.SelectedItem.ToString();

            if (lbl_AlarmTime.Text == lbl_CurrentTime.Text)
            {
                
                timer_AlarmTime.Stop();
                
                simpleSound.Play();
                               
                MessageBox.Show("It's Time!", "Alarm");
            }
        }

        private void btn_StopAlarm_Click(object sender, EventArgs e)
        {
            timer_AlarmTime.Stop();
            simpleSound.Stop();
            lbl_AlarmTime.Text = "Alarm canceled.";
        }
        
        private void btn_SW_Start_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            btn_SW_Start.Visible = false;
            btn_SW_Pause.Visible = true;
        }

        private void btn_SW_Pause_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            btn_SW_Start.Visible = true;
            btn_SW_Pause.Visible = false;
        }

        private void btn_SW_Reset_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void pnl_Stopwatch_Paint(object sender, PaintEventArgs e)
        {
            //btn_SW_Pause.Visible = false;
        }

        private void timer_Stopwatch_Tick(object sender, EventArgs e)
        {
            this.lbl_Stopwatch.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", stopWatch.Elapsed);
        }

        private void btn_TimerStart_Click(object sender, EventArgs e)
        {
            int minutes = int.Parse(cb_TimerMinute.SelectedItem.ToString());
            int seconds = int.Parse(cb_TimerSecond.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + seconds;

            timer_Timer.Start();

            btn_TimerStart.Visible = false;
            btn_TimerPause.Visible = true;
        }

        private void btn_TimerPause_Click(object sender, EventArgs e)
        {
            totalSeconds = 0;
            timer_Timer.Stop();
            lbl_TimerCount.Text = "00:00";
            simpleSound.Stop();

            btn_TimerStart.Visible = true;
            btn_TimerPause.Visible = false;
        }

        private void timer_Timer_Tick(object sender, EventArgs e)
        {
            if(totalSeconds > 0)
            {
                totalSeconds--;

                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);

                if (minutes < 10 && seconds>=10)
                {
                    lbl_TimerCount.Text = "0" + minutes.ToString() + ":" + seconds.ToString();

                }

                else if(minutes >= 10 && seconds < 10)
                {
                    lbl_TimerCount.Text = minutes.ToString() + ":" + "0" + seconds.ToString();
                }

                else if(minutes < 10 && seconds < 10)
                {
                    lbl_TimerCount.Text = "0" + minutes.ToString() + ":" + "0" + seconds.ToString();
                }

                else
                {
                    lbl_TimerCount.Text = minutes.ToString() + ":" + seconds.ToString();
                }       
            }

            else
            {
                timer_Timer.Stop();
                simpleSound.Play();
                MessageBox.Show("Time's up!", "Timer");
            }
        }

        private void cb_Minute_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_alarm_MouseDown(object sender, MouseEventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnl_Move_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

            else if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
                {
                    this.Size = new Size(700, 440);
                    this.CenterToScreen();
                }
                else
                {
                    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    this.Location = new Point(0, 0);
                }
            }
        }

        private void pnl_Move_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
