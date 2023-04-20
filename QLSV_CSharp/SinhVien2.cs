using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV_CSharp
{
    class SinhVien2
    {
        string MaSv, HoTen, MaLop;
        DateTime NS;
        public SinhVien2(){}
        public SinhVien2(string MaSv, string HoTen, DateTime NgaySinh, string MaLop)
        {
            this.MaSv = MaSv;
            this.HoTen = HoTen;
            this.NS = NgaySinh;
            this.MaLop = MaLop;
        
        }
        //khai bao doi tuong ket noi
        KetNoi ketnoi = new KetNoi();
        public void Insert(SinhVien2 sv1)
        {
            string sql = "Insert into SinhVien values('" + sv1.MaSv + "', '" + sv1.HoTen + "' , '" + sv1.NS +"', '" + sv1.MaLop + "')";
            ketnoi.Execute(sql);
        }
        public void HienThi(ListView lv)
        {
            int i = 0;
            string sql = "select * from SinhVien";
            ketnoi.connect.Open();
            SqlCommand cmd = new SqlCommand(sql, ketnoi.connect);
            SqlDataReader doc = cmd.ExecuteReader();
            lv.Items.Clear();
            while (doc.Read())
            {
                lv.Items.Add((i + 1).ToString());
                lv.Items[i].SubItems.Add(doc[0].ToString());
                lv.Items[i].SubItems.Add(doc[1].ToString());
                lv.Items[i].SubItems.Add(doc[2].ToString());
                lv.Items[i].SubItems.Add(doc[3].ToString());
                i++;

            }
            ketnoi.connect.Close();

        }
        public void Update(SinhVien2 sv1)
        {
            string sql = "Update SinhVien set HoTen ='" + sv1.HoTen + "' where MaSv = '" + sv1.MaSv + "'and Lop.MaLop = '" + sv1.MaLop +"'";
            ketnoi.Execute(sql);
        }
        public void Delete(SinhVien2 sv1)
        {
            string sql = "Delete from SinhVien where MaSv = '" + sv1.MaSv + "'";
            ketnoi.Execute(sql);
        }


        
    }
}
