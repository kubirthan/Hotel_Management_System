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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kubi\Documents\HotelDBase.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String Query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UDataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void EditUsers()
        {

            if (UNameCh.Text == "" || UGenderCol.SelectedIndex == -1 || UPasswordCol.Text == "" || UPhoneCo.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update UserTbl set UName=@UN,UPhone=@UP,UGender=@UG,UPassword=@UPW where UNum = @UKey ", Con);
                    cmd.Parameters.AddWithValue("@UN", UNameCh.Text);
                    cmd.Parameters.AddWithValue("@UP", UPhoneCo.Text);
                    cmd.Parameters.AddWithValue("@UG", UGenderCol.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UPW", UPasswordCol.Text);
                    cmd.Parameters.AddWithValue("@UKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteUser()
        {
            if (Key == 0)
            {
                MessageBox.Show("delete a user!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from UserTbl where UNum = @UKey ", Con);
                    cmd.Parameters.AddWithValue("@UKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }





        }
        private void InsertUser()
        {
            if (UNameCh.Text == "" || UGenderCol.SelectedIndex == -1 || UPasswordCol.Text == "" || UPhoneCo.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl(UName,UPhone,UGender,UPassword) values(@UN,@UP,@UG,@UPW)", Con);
                    cmd.Parameters.AddWithValue("@UN", UNameCh.Text);
                    cmd.Parameters.AddWithValue("@UP", UPhoneCo.Text);
                    cmd.Parameters.AddWithValue("@UG", UGenderCol.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UPW", UPasswordCol.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }





        }

        private void SaveCol_Click(object sender, EventArgs e)
        {
            InsertUser();
        }

        int Key = 0;
        private void UDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UNameCh.Text = UDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            UPhoneCo.Text = UDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            UGenderCol.Text = UDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            UPasswordCol.Text = UDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            if (UNameCh.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(UDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditUsers();
        }


    }
}
