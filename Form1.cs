using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Note
{
    public partial class OneNote : Form
    {
        public OneNote()
        {
            InitializeComponent();
        }

        private void OneNote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'one_NoteDataSet.OneTab' table. You can move, or remove it, as needed.
            this.oneTabTableAdapter.Fill(this.one_NoteDataSet.OneTab);
            Update_btn.Hide();
            DeletePanel.Hide();
            NewPanel.Hide();
            StartPanel.Show();
            select();
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            StartPanel.Hide();
            NewPanel.Show();
            Update_btn.Hide();
            Save_btn.Show();
            TitleBox.Enabled = true;
        }

        OnNote c = new OnNote();
        private void Save_btn_Click(object sender, EventArgs e)
        {
            c.title = TitleBox.Text.Trim();
            c.message = MessageBox.Text;
            c.timeDate = timeBox.Text +"/ "+ datebox.Text;
            c.lmod = "Empty";
            bool success = c.insert(c);
            if (success == true)
            {
                NewPanel.Hide();
                StartPanel.Show();
                select();
            }
            else
            {
                
            }

        }


        static String myconnstring = System.Configuration.ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public void select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from OneTab", conn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public string x;
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            deleteTitle.Text = "Click on a row header to delete.";
            NewPanel.Hide();
            StartPanel.Hide();
            DeletePanel.Show();
            x ="Clicked";
        }

        private void DelConfirmBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlCommand cmd = new SqlCommand("Delete from OneTab where Title=@Title", conn);
            cmd.Parameters.AddWithValue("@Title", deleteTitle.Text.Trim());
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            if(r > 0)
            {
                StartPanel.Show();
                DeletePanel.Hide();
                select();
            }
            else
            {

            }
            conn.Close();
        }

        private void DataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TitleBox.Enabled = false;
            int rowIndex = e.RowIndex;
            TitleBox.Text = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            MessageBox.Text = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            if (x == "Clicked")
            {
                deleteTitle.Text = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            c.title = TitleBox.Text.Trim();
            c.message = MessageBox.Text;
            c.lmod = timeBox.Text + "/ " + datebox.Text;
            bool success = c.Update(c);
            if (success == true)
            {
                NewPanel.Hide();
                StartPanel.Show();
                select();
            }
            else
            {

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            timeBox.Enabled = false;
            datebox.Enabled = false;
            TitleBox.Enabled = false;
            StartPanel.Hide();
            DeletePanel.Hide();
            NewPanel.Show();
            Save_btn.Hide();
            Update_btn.Show();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string key = SearchBox.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from OneTab where Title LIKE '%" + key + "%' OR Time_date LIKE '%" + key + "%'", conn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost/phpmyadmin/");
        }
    }
}
