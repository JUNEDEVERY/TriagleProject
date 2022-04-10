using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNetFR
{
    public partial class Form1 : Form
    {
        int x, y, z;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) // сгенерировать равнобедренный треугольник
        {

        }

        private void button5_Click(object sender, EventArgs e) // сгенерировать равносторонний треугольник 
        {

        }

        private void button6_Click(object sender, EventArgs e) // сгенерировать разносторонний треугольник
        {

        }

        private void button3_Click(object sender, EventArgs e) // сгенерировать рандомные числа в поля
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FirstSide_TextChanged(object sender, EventArgs e)
        {




        }

        private void FirstSide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FirstSide.Focused)
            {
                string clipdata = Clipboard.GetText();
                if (FirstSide.Text.Contains(clipdata))
                {
                    FirstSide.Clear();
                }
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (FirstSide.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;

            //if (Char.IsNumber(e.KeyChar) ||
            //   (!string.IsNullOrEmpty(FirstSide.Text)))
            //{
            //    return;
            //}
            //else if (e.KeyChar == Convert.ToChar(Keys.Back)) return;

            //e.Handled = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SecondSide.Clear();
            FirstSide.Clear();
            ThirdSide.Clear();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Очистить поля");
            t.SetToolTip(button2, "Cгенерировать треугольник по введеным сторонам");
            t.SetToolTip(button3, "Сгенерировать треугольник случайными числами");
            t.SetToolTip(FirstSide, "Поле для ввода первой стороны");
            t.SetToolTip(SecondSide, "Поле для ввода первой стороны");
            t.SetToolTip(ThirdSide, "Поле для ввода первой стороны");
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void FirstSide_Enter(object sender, EventArgs e)
        {

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void SecondSide_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) 
            {
                e.Handled = true;
            }
            if (SecondSide.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;
        }



    

        private void ThirdSide_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (ThirdSide.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;

            //if (Char.IsNumber(e.KeyChar) ||
            //  (!string.IsNullOrEmpty(ThirdSide.Text)))
            //{
            //    return;
            //}
            //else if (e.KeyChar == Convert.ToChar(Keys.Back)) return;

            //e.Handled = true;

            //else if (Char.IsDigit(e.KeyChar) == false) return;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("\tИнструкция по использованию приложения.\nДанное приложение предназначено для определения типа треугольника." +
                " (Равносторонний, равнобедренный и разносторонний).\nДля начала работы, необходимо заполнить поля, означающие каждую сторону.\n" +
                "Кнопка ОК - сгенерирует треугольник и отдельным окном выведет тип треугольника.При отсутствии значения в каком - либо поле, программа выдаст соответствующую ошибку.\n" +
                "Кнопка Случайные числа - сгенерирует случайный порядок чисел и автоматически подставит их в поля.\n "+
                "Кнопка Очистка полей - очищает все три поля.\nПрограмму невозможно развернуть на полный экран и / или увеличить / уменьшить в размере");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            SecondSide.Text = Convert.ToString(random.Next(0, 100));
            FirstSide.Text = Convert.ToString(random.Next(0, 100));
            ThirdSide.Text = Convert.ToString(random.Next(0, 100));
        }

        private void button2_Click_1(object sender, EventArgs e)

        {
            
            if (SecondSide.TextLength == 0 || FirstSide.TextLength == 0 || ThirdSide.TextLength == 0)
            {
                MessageBox.Show("Одно или несколько полей не были заполнены", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                x = Convert.ToInt32(SecondSide.Text);
                y = Convert.ToInt32(FirstSide.Text);
                z = Convert.ToInt32(ThirdSide.Text);

                if ((x == y) && (y == z) && (x == z))
                    MessageBox.Show("Треугольник относится к типу равносторонних");
                else
                {
                    if ((x + y > z) && (x + z > y) && (y + z > x))
                    {
                        if ((x == y && x != z) || (x == z && x != y) || (y == z && y != x))
                            MessageBox.Show("Треугольник относится к типу равнобедренных");
                        else
                            MessageBox.Show("Треугольник относится к типу разносторонних");
                    }
                    else MessageBox.Show("По указанным сторонам невозможно сгенерировать треугольник!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}

