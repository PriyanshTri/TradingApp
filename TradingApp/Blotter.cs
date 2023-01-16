using Infragistics.Win;
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
    public partial class Blotter : Form
    {
        public Blotter()
        {
            InitializeComponent();
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void ultraDataSource1_CellDataRequested(object sender, Infragistics.Win.UltraWinDataSource.CellDataRequestedEventArgs e)
        {

        }

        private void ultraGrid1_InitializeLayout_1(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.GroupByBox.Hidden = true;
            e.Layout.Override.AllowGroupBy = DefaultableBoolean.False;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ultraGrid2_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.GroupByBox.Hidden = true;
            e.Layout.Override.AllowGroupBy = DefaultableBoolean.False;
        }
    }
}
