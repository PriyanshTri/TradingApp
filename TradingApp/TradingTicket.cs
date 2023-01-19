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
        public static string symbol;
        public static string side;
        public static string account;
        public static int quantity;
        public static double avgPrice;
        public static int remainingQuanity;
        public static string orderStatus = "New";
        public static string clOrderId = "Order 1";
        public static string parentCLOrderId = "Order1";
        public static string stagedOrderId = "Null";
        public static string originalCLOrderId = "Null";

        static DataTable data;
        static int count = 0;

        public void getText()
        {
            symbol = textBox1.Text;
            side = comboBox1.Text;
            account = comboBox2.Text;
            quantity = int.Parse(textBox2.Text);
            avgPrice = float.Parse(textBox3.Text);
            remainingQuanity = 1000;
        }
        public static DataTable InitializeTable()
        {
            data = new DataTable();
            data.Columns.Add("symbol", typeof(string));
            data.Columns.Add("side", typeof(string));
            data.Columns.Add("account", typeof(string));
            data.Columns.Add("quantity", typeof(string));
            data.Columns.Add("avgPrice", typeof(string));
            data.Columns.Add("remainingQuanity", typeof(string));
            data.Columns.Add("orderStatus", typeof(string));
            data.Columns.Add("clOrderId", typeof(string));
            data.Columns.Add("parentCLOrderId", typeof(string));
            data.Columns.Add("stagedOrderId", typeof(string));
            data.Columns.Add("originalCLOrderId", typeof(string));
            return data;
        }
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
            getText();
            count++;
            if (count == 1)
            {

                DataTable data = InitializeTable();
                data.Rows.Add(symbol, side, account, quantity, avgPrice, remainingQuanity, orderStatus, "order" + count, "order" + count, stagedOrderId, originalCLOrderId);
                Blotter bt = new Blotter(data);
                bt.Show();
            }
            else
            {
                data.Rows.Add(symbol, side, account, quantity, avgPrice, remainingQuanity, orderStatus, "order" + count, "order" + count, stagedOrderId, originalCLOrderId);
                
            }
            /*String str;
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
            }*/
            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
            {
                if (e.KeyChar == 46)
                {
                    if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                        e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
                return;
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getText();
            count++;
            if (count == 1)
            {

                DataTable data = InitializeTable();
                data.Rows.Add(symbol, side, account, quantity, avgPrice, remainingQuanity, "Filled", "order" + count, "order" + count, stagedOrderId, originalCLOrderId);
                Blotter bt = new Blotter(data);
                bt.Show();

            }
            else
            {
                data.Rows.Add(symbol, side, account, quantity, avgPrice, remainingQuanity, "Filled", "order" + count, "order" + count, stagedOrderId, originalCLOrderId);
                Blotter bt = new Blotter(data);
                bt.Show();
            }
            /*String str;
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
            }*/
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
