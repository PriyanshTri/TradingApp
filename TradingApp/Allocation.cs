using Infragistics.Win.UltraWinGrid;
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
    
    public partial class Allocation : Form
    {
        private object dataSet1;

        public Allocation()
        {
            InitializeComponent();
        }

        private void ultraSplitter2_Click(object sender, EventArgs e)
        {
            //ultraSplitter2.Collapsed = true;
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            UltraGridRow row = this.ultraGrid1.DisplayLayout.Bands[0].AddNew();
            row.Cells[0].Value = "Red";
            row.Cells[1].Value = "1";
            row.Cells[2].Value = Color.Red;
        }
        
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            List<Data> datas = new List<Data>();
            Data d = new Data("hello", "1", "buy", 5000, 1000f, 1000.45f, 10000, 1);
            datas.Add(d);
            datas.Add(d);
            datas.Add(d);
            datas.Add(d);
            Label lbl = new Label();
            lbl.Size = new Size(100, 100);
            lbl.Location = new Point(1200, 800);
            lbl.BackColor = Color.Black;
            lbl.Text = "hello";
        }

        private void Allocation_Load(object sender, EventArgs e)
        {

            

        }

        
    }
    class Data
    {
        string sym { get; set; }
        string account { get; set; }
        string side { get; set; }
        int quantity { get; set; }
        float price { get; set; }
        float avgPrice { get; set; }
        int remainingQuant { get; set; }
        int orderStatus { get; set; }

        public Data(string sym, string account, string side, int quantity, float price, float avgPrice, int remainingQuant, int orderStatus)
        {
            this.sym = sym;
            this.account = account;
            this.side = side;
            this.quantity = quantity;
            this.price = price;
            this.avgPrice = avgPrice;
            this.remainingQuant = remainingQuant;
            this.orderStatus = orderStatus;
        }
    }
    
}
