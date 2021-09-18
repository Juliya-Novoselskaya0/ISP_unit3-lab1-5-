using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_3._1
{
    public partial class Form1 : Form
    {
        static string path = "12345";
        static Color color = Color.White;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           // this.BackColor = Color.Pink;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //this.BackColor = Color.LightBlue;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

 

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == path)
            {
                lbl1.Text = "Добро пожаловать!";
                showCalculate();
            }
            else
            {
                lbl1.Text = "Вход запрещён!";    
            }
        }

        void showCalculate()
        {
            lbl1.Visible = false;
            label2.Visible = true;
            label1.Visible = true;
            trackBar1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v = trackBar1.Value;
           const int g = 10;
            double rez = Math.Pow(v, 2) / 2 * g;
            labelREZ.Text = "h = "+Convert.ToString(rez);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now;
            var newYearDate = new DateTime(currentDate.Year + 1, 1, 1);
            var toNewYear = newYearDate - currentDate;
            label3.Text = $"До нового года осталось {toNewYear.Days} дней {toNewYear.Hours} часов {toNewYear.Minutes} минут {toNewYear.Seconds} секунд.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;

            colorDialog1.ShowDialog();

            this.BackColor = colorDialog1.Color;// установка цвета формы
            Color color= colorDialog1.Color;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = color;
            Graphics g = this.CreateGraphics();   // создание графического объекта
            Pen pn = new Pen(Color.Red, 1);
            int thinkness = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            switch (listBox2.SelectedIndex)       // выбор и рисование примитива
            {
                case 0: pn = new Pen(Color.Red, thinkness); break;
                case 1: pn = new Pen(Color.Green, 4); break;
                case 2: pn = new Pen(Color.Blue, 4); break;
            }
            Brush br = new SolidBrush(Color.Green);  // создание кисти
            g.Clear(SystemColors.Control);        // очистка области цветом формы
            switch (listBox1.SelectedIndex)       // выбор и рисование примитива
            {
                case 0: g.DrawLine(pn, 170, 40, 350, 180); break;
                case 1: g.DrawRectangle(pn, 170, 30, 250, 150); break;
                case 2: g.FillRectangle(br, 170, 30, 250, 150); break;
                case 3: g.DrawEllipse(pn, 170, 30, 250, 150); break;
                case 4: g.FillEllipse(br, 170, 30, 250, 150); break;
                case 5: g.DrawPie(pn, 170, 30, 200, 200, 180, 225); break;
                case 6: g.FillPie(br, 170, 30, 150, 150, 0, 45); break;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
