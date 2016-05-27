using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;

namespace MouseClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private System.Timers.Timer _delayTimer;
        private System.Timers.Timer _clickTimer;

        private int _numberOfSeconds; //countdown timer
        private int _clickSpeed; //speed (interval) of clicks
        private int _timeSpentClicking; //how many seconds to click
        private int _sumClicks; //to calculate number of clicks
        private int _clickCount; //for testing


        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValues();
            button1.Text = "5";
            //_delayTimer = new System.Timers.Timer();
            //_delayTimer.Interval = 1000;
            //_delayTimer.Elapsed += _delayTimer_Elapsed;

            //_clickTimer = new System.Timers.Timer();
            //_clickTimer.Interval = _clickSpeed;
            //_clickTimer.Elapsed += _clickTimer_Elapsed;

            //_delayTimer.Start();

            timerCountDown.Start();
        }

        //private void _clickTimer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    DoMouseClick();
        //}

        //private void _delayTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    //button1.Text = _numberOfSeconds.ToString();

        //    this.SetText(_numberOfSeconds.ToString());

        //    if (_numberOfSeconds == 0)
        //    {
        //        _delayTimer.Stop();
        //        this.SetText("Start");
        //        _clickTimer.Start();
        //    }

        //    --_numberOfSeconds;        
        //}

        //private void SetText(string text)
        //{
        //    // InvokeRequired required compares the thread ID of the
        //    // calling thread to the thread ID of the creating thread.
        //    // If these threads are different, it returns true.
        //    if (this.button1.InvokeRequired)
        //    {
        //        SetTextCallback d = new SetTextCallback(SetText);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        this.button1.Text = text;
        //    }
        //}


        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            //if (_clickSpeed == 0)
            //{
            //    _clickTimer.Stop();
            //}
            //else
            //{
            //    int X = Cursor.Position.X;
            //    int Y = Cursor.Position.Y;
            //    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            //    _clickSpeed = _clickSpeed - (int)clickSpeed.Value;
            //}
            //            MessageBox.Show("ClickTimer Triggered");

            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ++_clickCount;

            if (button2.BackColor == Color.Red)
            {
                button2.BackColor = Color.Green;
                button2.Text = _clickCount.ToString();
            }
            else
            {
                button2.BackColor = Color.Red;
                button2.Text = _clickCount.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetValues();
            lblTotalClicks.Text = _sumClicks.ToString();
        }

        private void SetValues()
        {
            _clickSpeed = (int)clickSpeed.Value;
            _numberOfSeconds = 5;
            _sumClicks = ((int)durationOfClicks.Value * 1000) / _clickSpeed;
            _timeSpentClicking = (int)durationOfClicks.Value;

            timerClickSpeed.Interval = _clickSpeed;

            _clickCount = 0;

        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            button1.Text = (_numberOfSeconds - 1).ToString();
            --_numberOfSeconds;

            if (_numberOfSeconds == 0)
            {
                timerCountDown.Stop();
                button1.Text = "Start";
                timerDuration.Start();
                timerClickSpeed.Start();
            }
        }

        private void timerDuration_Tick(object sender, EventArgs e)
        {
            //DoMouseClick();


            if (_timeSpentClicking != 0)
            {
                --_timeSpentClicking;
            }
            else
            {
                timerClickSpeed.Stop();
                timerDuration.Stop();
            }
        }

        private void timerClickSpeed_Tick(object sender, EventArgs e)
        {
            DoMouseClick();
        }
    }
}
