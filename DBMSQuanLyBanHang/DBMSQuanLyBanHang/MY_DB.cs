using System.Data;
using System.Data.SqlClient;


namespace DBMSQuanLyBanHang
{
    internal class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=PHANTATDUY;Initial Catalog=QuanLyBanHang;Integrated Security=True");

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }

    }

}
