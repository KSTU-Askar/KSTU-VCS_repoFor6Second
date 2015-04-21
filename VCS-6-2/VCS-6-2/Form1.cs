using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCS_6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cena = 0 ; // цена
    int n=0;            // кол-фо фотографий
    double sum;       // сумма
    
	if (radioButton1.Checked)
		cena = 3.50;
    if (radioButton2.Checked)
        cena = 4.50;
    if (radioButton3.Checked)
        cena = 12.0;
    try
    {
        n = Convert.ToInt32(textBox1.Text);
    }
    catch (Exception ex) {
        MessageBox.Show(ex.Message);
    }
    sum = n * cena;

    label2.Text = "Цена: " + cena.ToString("c") +
                "\nКоличество: " + n.ToString() + "шт.\n" +
                "Сумма заказа: " + sum.ToString("C");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "";

            // установить курсор в поле Количество
            textBox1.Focus();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "";

            // установить курсор в поле Количество
            textBox1.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "";

            // установить курсор в поле Количество
            textBox1.Focus();
        }
    }
}
