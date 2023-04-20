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
    public partial class Form_Lop : Form
    {
        public Form_Lop()
        {
            InitializeComponent();
        }

        private void Form_Lop_Load(object sender, EventArgs e)
        {
            Lop lop1 = new Lop();
            lop1.HienThi(listView1);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lop lop1 = new Lop(txtMaLop.Text, txtLop.Text);
            lop1.Insert(lop1);
            Form_Lop_Load(sender, e);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Lop lop1 = new Lop(txtMaLop.Text, txtLop.Text);
            lop1.Update(lop1);
            Form_Lop_Load(sender, e);
            txtMaLop.Enabled = true;

        }

        private void Chon_Lop(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var lop1 = e.Item;
            txtMaLop.Text = lop1.SubItems[1].Text;
            txtLop.Text = lop1.SubItems[2].Text;
            txtMaLop.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Lop lop1 = new Lop(txtMaLop.Text, txtLop.Text);
            lop1.Delete(lop1);
            Form_Lop_Load(sender, e);
            txtMaLop.Enabled = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
