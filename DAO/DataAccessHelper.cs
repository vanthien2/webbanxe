using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DataAccessHelper
    {
        private static SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Website;Integrated Security=True");


        public static SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        private static SqlCommand Cmd;
        public static SqlCommand cmd
        {
            get { return Cmd; }
            set { Cmd = value; }
        }


        private static SqlDataAdapter Da;
        public static SqlDataAdapter da
        {
            get { return Da; }
            set { Da = value; }
        }
        /// <summary>
        /// mở kết nối
        /// </summary>
        public static void Open()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }


        public static void Close()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        /// <summary>
        /// Phương thức lấy ra 1 bảng để thực hiện truy vấn
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataTable LayBang(string query)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            da.Fill(dt);
            return dt;

        }


        /// <summary>
        /// Phương thức thực thi 1 câu lệnh Insert , Update , Delete
        /// </summary>
        /// <param name="query"></param>
        /// Phương thức trả về kiểu nguyên
        public static void ExecuteNonQuery(string query)
        {
            Open();
            cmd = new SqlCommand(query, Conn);
            cmd.ExecuteNonQuery();
            Close();
        }




        /// <summary>
        /// Phương thức trả về 1 giá trị kiểu số nguyên
        /// </summary>
        /// <param name="selectCommandText"></param>
        /// <returns></returns>
        public static int GetValueInt(string sql)
        {
            Open();
            cmd = new SqlCommand(sql, Conn);
            return (int)cmd.ExecuteScalar();


        }
    }
}
