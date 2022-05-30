using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KP_FORMA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char N;
            N = char.Parse(textBox4.Text);
            switch (N)
            {
                case '1':
                    double t, y, z;
                    t = double.Parse(textBox1.Text);
                    y = double.Parse(textBox2.Text);
                    z = (2 * t + y * Math.Cos(t)) / Math.Sqrt(y + 4.831);
                    textBox3.Text = z.ToString();
                    break;
                case '2':
                    Random  random = new Random();  
                    double a_1, b_1, a_2, b_2, x, y_2, t_1, b;
                    a_1 = -1.75;
                    b_1 = 3.28;
                    a_2 = Convert.ToDouble(textBox5.Text);
                    b_2 = Convert.ToDouble(textBox6.Text);
                    t_1 = Convert.ToDouble(textBox7.Text);
                    x = a_2;
                    b = random.Next(1, 10);
                    listBox1.Items.Add("x      y");
                    while (x <= b_2)
                    {
                        if (x*x <= b)
                        {
                            y_2 = 6.3 * Math.Exp(-x) + Math.Pow(Math.Cos(a_1 * x + b_1 * x * x) , 3.3);
                            listBox1.Items.Add(x.ToString("f2") + " " + y_2.ToString("f2"));
                        }
                        if (x * x > b)
                        {
                            y_2 = Math.Log(Math.Abs(a_2 * Math.Pow(x, 3) + b)) - x * 1.42;
                            listBox1.Items.Add(x.ToString("f2") + " " + y_2.ToString("f2"));
                        }
                        x = t_1 + x;
                    }
                    double[] boo = { 1.123, 1.3211 };
                    double[] foo = { 5.123, 7.3411 };
                    var pane = new ZedGraph.GraphPane();
                    var curve1 = pane.AddCurve("Графік", boo, foo, System.Drawing.Color.Blue);
                    curve1.Line.IsAntiAlias = true;
                    pane.AxisChange();
                    Bitmap bmp = pane.GetImage(400, 300, dpi: 100, isAntiAlias: true);
                    bmp.Save("zedgraph-console-quickstart.png", System.Drawing.Imaging.ImageFormat.Png);

                    break;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
