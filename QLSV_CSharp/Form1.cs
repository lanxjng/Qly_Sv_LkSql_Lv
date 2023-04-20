using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSV_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nhậpDLTableLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Lop f = new Form_Lop();
            f.Show();
        }

        private void nhậpDLTableSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SinhVien2 f = new Form_SinhVien2();
            f.Show();
        }
    }
}
