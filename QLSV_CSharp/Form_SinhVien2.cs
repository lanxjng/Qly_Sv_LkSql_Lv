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
    public partial class Form_SinhVien2 : Form
    {
        public Form_SinhVien2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SinhVien2 sv = new SinhVien2(txtMaSv.Text, txtHoTen.Text, NgaySinh.Value, cbbMaLop.Text);
            sv.Update(sv);
            Form_SinhVien2_Load(sender, e);

        }

        private void Form_SinhVien2_Load(object sender, EventArgs e)
        {
            SinhVien2 sv = new SinhVien2();
            sv.HienThi(listView1);
            cbbMaLop.ValueMember = "MaLop";
            cbbMaLop.DisplayMember = "TenLop";
            

        }


        private void Chon_Sv(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var sv = e.Item;
            txtMaSv.Text = sv.SubItems[1].Text;
            txtHoTen.Text = sv.SubItems[2].Text;
            NgaySinh.Text = sv.SubItems[3].Text;
            cbbMaLop.Text = sv.SubItems[4].Text;
            txtMaSv.Enabled = false;
            cbbMaLop.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SinhVien2 sv = new SinhVien2(txtMaSv.Text, txtHoTen.Text, NgaySinh.Value, cbbMaLop.Text);
            sv.Update(sv);
            Form_SinhVien2_Load(sender, e);
            txtMaSv.Enabled = true;
            cbbMaLop.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SinhVien2 sv = new SinhVien2(txtMaSv.Text, txtHoTen.Text, NgaySinh.Value, cbbMaLop.Text);
            sv.Delete(sv);
            Form_SinhVien2_Load(sender, e);
            txtMaSv.Enabled = true;
            cbbMaLop.Enabled = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
