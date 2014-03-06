using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Кредитный_калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            /*
            int x; // возраст заемщика
            if (!int.TryParse(Age.Text, out x))
            {
                MessageBox.Show("Возраст указывается в целых числах.");
                return;
            }
            if (x < 21)
            {
                MessageBox.Show("Возраст заемщика не может быть меньше 21 года.");
                return;
            }
            if (x>60)
            {
                MessageBox.Show("Возраст заемщика не может быть больше 60 лет.");
                return;
            }
            */

            int s; // сумма кредита
            if (!int.TryParse(Sum.Text, out s))
            {
                MessageBox.Show("Не верно указана сумма кредита");
                return;
            }
            if (s < 10000)
            {
                MessageBox.Show("Сумма кредита не может быть меньше 10 000 руб.");
                return;
            }
            if (s > 10000000)
            {
                MessageBox.Show("Сумма кредита не может быть больше 10 000 000 руб.");
                return;
            }
           
            double p; // процентная ставка по кредиту
            if (!double.TryParse(Percent.Text, out p))
            {
                MessageBox.Show("Процентная ставка может быть только числом");
                return;
            }
            if (p == 0)
            {
                MessageBox.Show("Ставка по кредиту не может быть равна 0");
                return;
            }
            if (p>100)
            {
                MessageBox.Show("Ставка по кредиту не может быть более 100 процентов");
                return;
            }

            int n; // срок кредита
            if (!int.TryParse(Date.Text, out n))
            {
                MessageBox.Show("Срок кредита указывается целым числом от 1 до 360");
                return;
            }
            if (n==0)
            {
                MessageBox.Show("Срок кредита не может быть равным 0");
                return;
            }
            if (n>360)
            {
                MessageBox.Show("Срок кредита не может быть болше 360 мес или 30 лет.");
                return;
            }

            double a, b, c, d, h, f, z, y;
            b = (p / 12)/100;
            c = 1 + b;
            d = Math.Pow(c, n);
            h = d - 1;
            f = b / h;
            y = b + f;
            a = s * y; // Ежемесячный платеж
            z = Math.Round(a, 2);
            Payment.Text = z.ToString();

            double t, u;
            t = a * n;

            u = Math.Round(t, 2); // полная стоимость кредита
            Payment2.Text = u.ToString();

            double k, l;
            k = t - s;
            l = Math.Round(k, 2); // переплата за весь срок в %
            Payment3.Text = l.ToString();

            double v, m, q, w;
            v = s*(p/100)/12; // Сумма ежемесячного платежа % за 1й месяц.
           // m = Math.Round(v, 2);
           // Payment4.Text = m.ToString();

            q = a - v; // сумма основного долга за 1й месяц

            w = s - q; // остаток после 

            double r, o;
            for (r = a; r <= u; r++ );
           // m = Math.Round(r, 2);
            Payment4.Text = r.ToString();

                             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                Hide();
                Reference reference = new Reference();
                reference.ShowDialog();
            }
        }
        
    }
}
