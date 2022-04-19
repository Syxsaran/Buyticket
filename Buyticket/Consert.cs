using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buyticket
{
    public partial class Consert : Form
    {
        public Consert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            S1 s1 = new S1();
            s1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            S2 s2 = new S2();
            s2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visible = false;
            S3 s3 = new S3();
            s3.Visible = true;
        }
    }
}
