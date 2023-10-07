using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHotelApp
{
    public partial class Room : Form
    {

        public Room()
        {
            InitializeComponent();
            populate();
            GetCategories();
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
            RoomDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void EditRoom()
        {

            if (RNameCol.Text == "" || RoomTypecol.SelectedIndex == -1 || RStatusCol.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update RoomTbl set RName=@RN,RType=@RT,RStatus=@RS where RNum = @RKey ", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameCol.Text);
                    cmd.Parameters.AddWithValue("@RT", RoomTypecol.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@RS", RStatusCol.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room updateed");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteRooms()
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a room!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from RoomTbl where RNum = @Key ", Con);
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room deleted");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }





        }
        private void InsertRooms()
        {
            if (RNameCol.Text == "" || RoomTypecol.SelectedIndex == -1 || RStatusCol.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into RoomTbl(RName,RType,RStatus) values(@RN,@RT,@RS)", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameCol.Text);
                    cmd.Parameters.AddWithValue("@RT", RoomTypecol.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@RS", "Available");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room added");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }





        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GetCategories()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from TypeTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TypeNum", typeof(int));
            dt.Load(rdr);
            RoomTypecol.ValueMember = "TypeNum";
            RoomTypecol.DataSource = dt;
            Con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            InsertRooms();
        }
        int Key = 0;
        private void RoomDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RNameCol.Text = RoomDGV.SelectedRows[0].Cells[1].Value.ToString();
            RoomTypecol.Text = RoomDGV.SelectedRows[0].Cells[2].Value.ToString();
            RStatusCol.Text = RoomDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (RNameCol.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(RoomDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditRoom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRooms();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Types obj = new Types();
            obj.Show();
            this.Hide();
        }

        private void RNameCol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}