using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tradingTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TradingTicket obj = new TradingTicket();
            obj.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blotterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blotter obj = new Blotter();
            obj.Show();
        }

        private void allocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Allocation obj=new Allocation();
            obj.Show();
        }
    }
}
