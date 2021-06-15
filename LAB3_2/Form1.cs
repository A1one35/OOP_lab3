using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_add
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            DoubleBuffered = true;
        }

        private void New_Click(object sender, EventArgs e)
        {
            count++;
            int randSize = rnd.Next(100, 200);
            int rand = rnd.Next(0, 500 - randSize);
            int rand2 = rnd.Next(0, 450 - randSize);

            CEmblem figure = new CEmblem(rand, rand2, randSize, "Емблема №" + count, Color.Red);
            figure.Show();
            figure.Draw(pictureBox1);
            comboBox1.Items.Add(figure);

            comboBox1.SelectedIndex = count - 1;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
            
        }

        private void Show_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void full_up_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Full_Up();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void up_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Up();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void full_left_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Full_Left();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void left_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Left();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void full_right_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Full_Right();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void right_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Right();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void full_down_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Full_Down();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void down_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Down();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Plus();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Minus();
            figure.Show();
            figure.Draw(pictureBox1);
        }
    }
}
