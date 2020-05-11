namespace MaskON_DB_Library
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Data;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Datum> Data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        SqlConnection connection = new SqlConnection(@"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\MaskOn_Database.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        private string data = "";
        private int sum;
        private int total;
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }

        public DataTable ReadData()
        {
            DataTable table = new DataTable();
            openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT N95, Surgery, Lokasi FROM Data WHERE N95 > 0 OR Surgery > 0", connection);
            adapter.Fill(table);
            return table;
        }

        public void UpdateN95(int donate, string lokasi)
        {
            SqlCommand get = new SqlCommand("SELECT N95 FROM Data WHERE Lokasi=@lokasi", connection);
            get.Parameters.Add("@lokasi", SqlDbType.NVarChar).Value = lokasi;
            openConnection();
            using (SqlDataReader reader = get.ExecuteReader())
            {
                while (reader.Read())
                {
                    data = reader["N95"].ToString();
                }
            }
            sum = Convert.ToInt32(data);
            total = sum - donate;
            SqlCommand update = new SqlCommand("UPDATE Data SET N95 = @jumlah WHERE Lokasi=@lokasi", connection);
            update.Parameters.Add("@jumlah", SqlDbType.Int).Value = total;
            update.Parameters.Add("@lokasi", SqlDbType.NVarChar).Value = lokasi;
            openConnection();
            update.ExecuteNonQuery();
            closeConnection();
        }

        public void UpdateSurgery(int donate, string lokasi)
        {
            SqlCommand get = new SqlCommand("SELECT Surgery FROM Data WHERE Lokasi=@lokasi", connection);
            get.Parameters.Add("@lokasi", SqlDbType.NVarChar).Value = lokasi;
            openConnection();
            using (SqlDataReader reader = get.ExecuteReader())
            {
                while (reader.Read())
                {
                    data = reader["Surgery"].ToString();
                }
            }
            sum = Convert.ToInt32(data);
            total = sum - donate;
            SqlCommand update = new SqlCommand("UPDATE Data SET Surgery = @jumlah WHERE Lokasi=@lokasi", connection);
            update.Parameters.Add("@jumlah", SqlDbType.Int).Value = total;
            update.Parameters.Add("@lokasi", SqlDbType.NVarChar).Value = lokasi;
            openConnection();
            update.ExecuteNonQuery();
            closeConnection();
        }
    }
}
