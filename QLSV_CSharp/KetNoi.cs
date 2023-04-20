using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace QLSV_CSharp
{
    internal class KetNoi
    {
        public SqlConnection connect = new SqlConnection("Data Source=TRUONGJAE\\SQLEXPRESS;Initial Catalog=QLSV_C#;Integrated Security=True");
        public void Execute(string sql) {
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
        }

    }
}
