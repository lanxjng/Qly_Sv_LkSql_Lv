using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV_CSharp
{
    internal class Lop
    {
        string MaLop, TenLop;
        public Lop() { }
        public Lop(string MaLop, string TenLop)
        {
            this.MaLop = MaLop;
            this.TenLop = TenLop;
        }
        //khai bao doi tuong ket noi

        KetNoi ketnoi = new KetNoi();
        public void Insert(Lop lop1)
        {
            string sql = "Insert into Lop values('" + lop1.MaLop + "', '" + lop1.TenLop + "')";
            ketnoi.Execute(sql);
        }

        public void HienThi(ListView lv)
        {
            int i=0;
            string sql = "select * from Lop";
            ketnoi.connect.Open();
            SqlCommand cmd = new SqlCommand(sql, ketnoi.connect);
            SqlDataReader doc =  cmd.ExecuteReader();
            lv.Items.Clear();
            while (doc.Read())
            {
                lv.Items.Add((i + 1).ToString());
                lv.Items[i].SubItems.Add(doc[0].ToString());
                lv.Items[i].SubItems.Add(doc[1].ToString());
                i++;
            
            }
            ketnoi.connect.Close();

        }
        public void Update(Lop lop1)
        {
            string sql = "Update Lop set TenLop ='" + lop1.TenLop + "' where MaLop = '" + lop1.MaLop + "'";
            ketnoi.Execute(sql);
        }
        public void Delete(Lop lop1)
        {
            string sql = "Delete from Lop where MaLop = '" + lop1.MaLop + "'";
            ketnoi.Execute(sql);
        }

    }
}
