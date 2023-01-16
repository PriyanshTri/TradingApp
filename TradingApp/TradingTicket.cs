using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace TradingApp
{
    public partial class TradingTicket : Form
    {
        public TradingTicket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String str;
            str = textBox3.Text;
            String str2 = textBox2.Text;
            int intValue = int.Parse(str2, CultureInfo.InvariantCulture.NumberFormat);
            float floatValue = float.Parse(str, CultureInfo.InvariantCulture.NumberFormat);
            if (floatValue <= 0 && intValue <= 0)
            {
                MessageBox.Show("Please Fill data Properly!");
            }
            else
            {
               MessageBox.Show("Order placed");
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str;
            str = textBox3.Text;
            String str2 = textBox2.Text;
            int intValue = int.Parse(str2, CultureInfo.InvariantCulture.NumberFormat);
            float floatValue = float.Parse(str, CultureInfo.InvariantCulture.NumberFormat);
            if (floatValue <= 0 && intValue <= 0)
            {
                MessageBox.Show("Please Fill data Properly!");
            }
            else
            {
                MessageBox.Show("Order placed");
                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
