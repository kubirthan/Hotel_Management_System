using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHotelApp
{
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
            populate();
            GetRooms();
            GetCustomer();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kubi\Documents\HotelDBase.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String Query = "select * from RoomTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetRooms()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from RoomTbl where RStatus = 'Available'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RNum", typeof(int));
            dt.Load(rdr);
            BRoomcol.ValueMember = "RNum";
            BRoomcol.DataSource = dt;
            Con.Close();
        }

        int price = 0;
        private void fetchCost()
        {
            Con.Open();
            string Query = "select TypeCost from RoomTbl join TypeTbl on RType=TypeNum where RNum=" + BRoomcol.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                price = Convert.ToInt32(dr["TypeCost"].ToString());
            }
            Con.Close();
        }

        private void GetCustomer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from CustomerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CusNum", typeof(int));
            dt.Load(rdr);
            BCustomer.ValueMember = "CusNum";
            BCustomer.DataSource = dt;
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (BRoomcol.SelectedIndex == -1 || BCustomer.SelectedIndex == -1 || Bamount.Text == "" || BDuration.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BookingTbl(Room,Customer,BookDate,Duration,Cost) values(@BR,@C,@BD,@D,@BC)", Con);
                    cmd.Parameters.AddWithValue("@BR", BRoomcol.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@C", BCustomer.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@BD", Bookdate.Value.Date);
                    cmd.Parameters.AddWithValue("@D", BDuration.Text);
                    cmd.Parameters.AddWithValue("@BC", Bamount.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room booked");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bookings_Load(object sender, EventArgs e)
        {

        }

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BRoomcol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCost();
        }

        private void BDuration_TextChanged(object sender, EventArgs e)
        {
            if (Bamount.Text == "")
            {
                Bamount.Text = "RS 0";
            }
            else
            {
                try
                {
                    int Total = price * Convert.ToInt32(BDuration.Text);
                    Bamount.Text = "" + Total;
                }
                catch (Exception Ex)
                {

                }
            }

        }

        private void Bcancelbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
