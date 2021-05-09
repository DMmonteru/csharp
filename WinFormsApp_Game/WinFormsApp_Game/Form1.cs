using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 15. Игра «Быки и коровы» (вариант 1). Компьютер генерирует случайное четырехзначное число,
// в котором все цифры различны. Игрок должен отгадать число, делая несколько попыток.
// После ввода очередного числа компьютер сообщает о степени совпадения введенного
//числа с исходным, т.е. количество «быков» и «коров»: «корова» – это
//цифра в числе игрока, совпадающая по разряду с такой же цифрой в
//загаданном числе; «бык» – это цифра в числе игрока, не совпадающая
//по разряду с такой же цифрой в загаданном числе. Если, например,
//загадано число 6482, то число 5428 содержит 1«корову» и 2«быка».

namespace WinFormsApp_Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string generated_s = "";
        int b = 0, k = 0;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text.Length == 4) { Check(textBox_number.Text.ToCharArray()); }
            textBox_number.Text = "";
        }

        private void Start()
        {
            Generate_num();
            // обнуление:
            label_b.Text = "";
            label_k.Text = "";
            button_show.Text = "Показать число";
            label_result.Text = "Здесь отображается результат проверки";
        }

        private void Generate_num()
        {
            int[] generated = new int[4];
            bool different = false;
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    generated[i] = random.Next(10);
                    different = true;
                    for (int j = 0; j < i; j++)
                    {
                        if (generated[j] == generated[i])
                        {
                            different = false;
                        }
                    }
                } while (!different);
                if (i == 0) { generated_s = generated[i].ToString(); }
                else { generated_s += generated[i].ToString(); }
            }
        }

        private void Check(char[] sp) 
        {
            b = 0; k = 0;
            for (int i = 0; i < 4; i++)
            {
                if (generated_s.Contains(sp[i]))
                {
                    if (generated_s[i] == sp[i]) { b++; } // бык
                    else { k++; } // корова
                }
            }
            label_b.Text = b.ToString();
            label_k.Text = k.ToString();
            if (b != 4)
            {
                label_result.Text = $"{textBox_number.Text} содержит {b.ToString()} быков и {k.ToString()} коров";
                counter++;
            }
            else
            {
                label_result.Text = $"{textBox_number.Text} - верное число. С победой! (кол-во ходов: {counter})";
            }
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            button_show.Text = generated_s;
        }
    }
}
