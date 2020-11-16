using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7_ex2
{
    // Дубровский Вячеслав

//    Используя Windows Forms, разработать игру «Угадай число». 
//    Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
//    Компьютер говорит, больше или меньше загаданное число введенного. 

//    a) Для ввода данных от человека используется элемент TextBox;

    public partial class Form1 : Form
    {
        public int answer;
        public int rightanswer;
        public Form1()
        {
            InitializeComponent();
            textBox1.Hide();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            label1.Text = r.Next(0, 100).ToString();
            rightanswer = Int32.Parse(label1.Text);
            button1.Hide();
            label1.Hide();
            textBox1.Show();
            label2.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                answer = Int32.Parse(textBox1.Text);
                if (answer == rightanswer)
                {
                    MessageBox.Show("Поздравляю, вы победили!");
                    button1.Show();
                    textBox1.Hide();
                    label2.Hide();
                }
                else if (answer < rightanswer)
                {
                    MessageBox.Show("Загаданное число больше введенного");
                }
                else if (answer > rightanswer)
                {
                    MessageBox.Show("Загаданное число меньше введенного");
                }
            }
        }
    }
}
