using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationMyClock
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        private Timer timerSec = new Timer();
        private bool trigger = false;
        private int second = 0;
        private int min = 0;
        DateTime dt = new DateTime();
        


        public Form1()
        {
            InitializeComponent();
            timerSec.Interval = 1000;
            timerSec.Tick += (o, e) =>
            {
                second++;
                if (second >= 60)
                {
                    min++;
                    second = 0;
                }
                labelSec.Text = min.ToString() + "m " + second.ToString() + "sec";
                Invalidate();
            };
            labelSec.Text = "0m 0sec";
            timer.Interval = 1000;
            DoubleBuffered = true;
            timer.Tick += DoTime;
            timer.Start();
            Text = "Clock";
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void DoTime(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeTransform(Graphics g)
        {
            g.ResetTransform();
            g.TranslateTransform(ClientSize.Width / 2f, ClientSize.Height / 2f);
            float scale = System.Math.Min(ClientSize.Width, ClientSize.Height) / 200.0f;
            g.ScaleTransform(scale, scale);
        }
        private void InitializeTransformForSec(Graphics g)
        {
            g.ResetTransform();
            g.TranslateTransform(ClientSize.Width / 2f + 90f + 45f, ClientSize.Height / 2f + 35f);
            float scale = System.Math.Min(ClientSize.Width, ClientSize.Height) / 200.0f;
            //g.ScaleTransform(scale, scale);
        }
        //Секундомер
        private void Sec(Graphics g, SolidBrush brush)
        {
            InitializeTransformForSec(g);
            for (int i = 0; i < 72; i++)
            {
                g.RotateTransform(5.0f);
                g.FillRectangle(brush, 50, -5, 5, 5);
            }
            InitializeTransformForSec(g);
            for (int i = 0; i < 60; i++)
            {
                g.RotateTransform(6.0f);
                g.FillRectangle(brush, 45, -1, 10, 2);
            }
            //Стрелка
            InitializeTransformForSec(g);
            
            g.RotateTransform(second * 6.0f);

            DrawHand(g, brush, 45, true);


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush black = new SolidBrush(Color.Black);
            SolidBrush green = new SolidBrush(Color.Green);
            SolidBrush blue = new SolidBrush(Color.Blue);
            SolidBrush red = new SolidBrush(Color.Red);
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            InitializeTransform(g);
            //внешний круг
            for (int i = 0; i < 72; i++)
            {
                g.RotateTransform(5.0f);
                g.FillRectangle(black, 90, -5, 10, 10);
            }
            InitializeTransform(g);
            //деления минут
            for (int i = 0; i < 60; i++)
            {
                g.RotateTransform(6.0f);
                g.FillRectangle(black, 85, -1, 10, 2);
            }
            InitializeTransform(g);
            //Актуальная дата
            DateTime time = DateTime.Now;
            int secondInt = time.Second;
            int minuteInt = time.Minute;
            int hourInt = time.Hour % 12;
            //Стрелка часов
            g.RotateTransform((hourInt * 30f) + (minuteInt / 2f/* делить на 60 и умножить на 30 сокращаем до: делить на 2 */));
            DrawHand(g, blue, 75, false);
            InitializeTransform(g);
            //Стрелка минут
            g.RotateTransform((minuteInt * 6f) + (secondInt / 10f));
            DrawHand(g, red, 95, false);
            InitializeTransform(g);
            //Стрелка секунд
            g.RotateTransform(secondInt * 6f);
            DrawHand(g, green, 85, true);
            InitializeTransform(g);

            //Дорисовываем секундомер
            Sec(g, black);

            //освобождение ресурсов
            green.Dispose();
            black.Dispose();
            blue.Dispose();
            yellow.Dispose();
            red.Dispose();
        }
        private void DrawHand(Graphics g, SolidBrush solidBrush, int length, bool seen)
        {
            Point[] points = new Point[4];
            points[0].X = 0;
            points[0].Y = -length;
            points[1].X = (seen) ? -2 : -10;
            points[1].Y = 0;
            points[2].X = 0;
            points[2].Y = (seen) ? 2 : 10;
            points[3].X = (seen) ? 2 : 10;
            points[3].Y = 0;
            g.FillPolygon(solidBrush, points);
        }

        private void startPauseButton_Click(object sender, EventArgs e)
        {
            if (!trigger)
            {
                timerSec.Start();
                startPauseButton.Text = "pause";
                trigger = true;
            }
            else if (trigger)
            {
                timerSec.Stop();
                startPauseButton.Text = "start";
                trigger = false;
            }
            Invalidate();
        }

        private void labelSec_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerSec.Stop();
            min = 0;
            second = 0;
            trigger = false;
            startPauseButton.Text = "start";
            labelSec.Text = "0m 0sec";
            Invalidate();
        }
    }
}


