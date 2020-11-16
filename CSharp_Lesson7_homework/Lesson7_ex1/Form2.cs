using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7_ex1
{
    // Дубровский Вячеслав
    // а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    public partial class Form2 : Form
    {
        public int n = 0;

        // в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.

        // Не получилось

        // public int lastitem;
        //static void stackClass(string[]args)
        //{
        //    var stack = new Stack<int>();
        //    lastitem = Convert.ToInt32(Counter.Text);
        //    stack.Push(lastitem);
        //}
        public Form2()
        {
            InitializeComponent();
            this.Text = "Удвоитель";
            Counter.Text = "0";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            Counter.Text = (int.Parse(Counter.Text) + 1).ToString();
            n++;
            label3.Text = $"Вы воспользовались программой {n} раз";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Counter.Text = (int.Parse(Counter.Text) * 2).ToString();
            n++;
            label3.Text = $"Вы воспользовались программой {n} раз";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Counter.Text = "0";
            n++;
            label3.Text = $"Вы воспользовались программой {n} раз";
        }

        private void Counter_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не получилось =(");
        }
    }
}

