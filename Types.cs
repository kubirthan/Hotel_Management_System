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
    public partial class Types : Form
    {
        public Types()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kubi\Documents\HotelDBase.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String Query = "select * from TypeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TypesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void InsertCategori()
        {
            if (CategoriNamTbl.Text == "" || CostTbl.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TypeTbl(TypeName,TypeCost) values(@TN,@TC)", Con);
                    cmd.Parameters.AddWithValue("@TN", CategoriNamTbl.Text);
                    cmd.Parameters.AddWithValue("@TC", CostTbl.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category inserted!!!");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditCategorie()
        {
            if (CategoriNamTbl.Text == "" || CostTbl.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update TypeTbl set TypeName=@TN,TypeCost=@TC where TypeNum = @TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", CategoriNamTbl.Text);
                    cmd.Parameters.AddWithValue("@TC", CostTbl.Text);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category updated!!!");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeletCategorie()
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a category!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TypeTbl where TypeNum = @TKey ", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categorie deleted");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }





        }
        private void Types_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertCategori();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Room obj = new Room();
            obj.Show();
            this.Hide();

        }



        int Key = 0;
        private void TypesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriNamTbl.Text = TypesDGV.SelectedRows[0].Cells[1].Value.ToString();
            CostTbl.Text = TypesDGV.SelectedRows[0].Cells[2].Value.ToString();

            if (CategoriNamTbl.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TypesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EditCategorie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeletCategorie();
        }
    }
}
