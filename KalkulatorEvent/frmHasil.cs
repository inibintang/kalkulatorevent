using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorEvent
{
    public partial class frmHasil : Form
    {
        public frmHasil()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void buttKalkulator_Click(object sender, EventArgs e)
        {
            frmKalkulator getfrmKalkulator = new frmKalkulator();
            getfrmKalkulator.OnUpdate += new frmKalkulator.Kalkulasi(this.callBack);
            float num = (float)getfrmKalkulator.ShowDialog();
        }

        private void callBack(string name, string symbol, float a, float b, float hasil)
        {
            listview.Items.Add("Hasil " + name + " " + a + " " + symbol + " " + b + " = " + hasil);
        }
        private void InisialisasiListView()
        {
            listview.View = View.Details;
            listview.FullRowSelect = true;
            listview.GridLines = true;
        }
        private void listview_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
