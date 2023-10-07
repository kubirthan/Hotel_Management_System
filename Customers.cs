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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kubi\Documents\HotelDBase.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String Query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CusGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void EditCustomer()
        {

            if (CNameCO.Text == "" || CGender.SelectedIndex == -1 || CusPhone.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update CustomerTbl set CusName=@CN,CusPhone=@CP,CusGender=@CG where CusNum = @CKey ", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameCO.Text);
                    cmd.Parameters.AddWithValue("@CG", CGender.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@CP", CusPhone.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer updateed");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteCustomer()
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Customer!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CusNum = @CKey ", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }





        }
        private void InsertCustomer()
        {
            if (CNameCO.Text == "" || CGender.SelectedIndex == -1 || CusPhone.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CusName,CusPhone,CusGender) values(@CN,@CP,@CG)", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameCO.Text);
                    cmd.Parameters.AddWithValue("@CG", CGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CP", CusPhone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CSavebtn_Click(object sender, EventArgs e)
        {
            InsertCustomer();
        }


        int Key = 0;
        private void CusGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameCO.Text = CusGridView.SelectedRows[0].Cells[1].Value.ToString();
            CusPhone.Text = CusGridView.SelectedRows[0].Cells[3].Value.ToString();
            CGender.Text = CusGridView.SelectedRows[0].Cells[2].Value.ToString();
            
            if (CNameCO.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CusGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        private void CEditbtn_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void CDeletebtn_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }
    }
}
