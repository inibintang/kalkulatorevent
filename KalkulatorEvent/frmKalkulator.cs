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
    public partial class frmKalkulator : Form
    {

        //delegate dan event
        public delegate void Kalkulasi(string name, string symbol, float a, float b, float hasil);
        public event Kalkulasi OnUpdate;
        public frmKalkulator()
        {
            InitializeComponent();
        }
        
        //penghitungan
        private void buttHitung_Click(object sender, EventArgs e)
        {
            string name = this.comboBox1.Text.ToLower();
            string symbol = null;
            float nilaiA = float.Parse(txtA.Text);
            float nilaiB = float.Parse(txtB.Text);
            float hasil = 0;
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    hasil = nilaiA + nilaiB;
                    symbol = "+";
                    break;
                case 1:
                    hasil = nilaiA - nilaiB;
                    symbol = "-";
                    break;
                case 2:
                    hasil = nilaiA / nilaiB;
                    symbol = "/";
                    break;
                case 3:
                    hasil = nilaiA * nilaiB;
                    symbol = "*";
                    break;
                
            }
            this.OnUpdate(name, symbol, nilaiA, nilaiB, hasil);
        }
    }
}
