using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Address_Book_Win_Forms_App
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        DataBaseCnn dataBase = new DataBaseCnn();
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(dataBase.Connection());
            LoadingDates();
        }
        public void LoadingDates()
        {
            book_grid.Rows.Clear();
            string index = "";
            connection.Open();
            command = new SqlCommand("SELECT * FROM AddressBook", connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                index = dataReader["id"].ToString();
                book_grid.Rows.Add(index, dataReader["fullname"].ToString(), dataReader["email"].ToString(), dataReader["phonenumber"].ToString(), dataReader["address"].ToString());
            }
            dataReader.Close();
            connection.Close();
        }
        
        private void creata_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.save_btn.Enabled = true;
            
            form2.ShowDialog();
            LoadingDates();
        }

        private void book_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 form2 = new Form2(this);
            if (book_grid.Columns[e.ColumnIndex].HeaderCell.Value.ToString() == "Full Name" || book_grid.Columns[e.ColumnIndex].HeaderCell.Value.ToString() == "E-Mail"
                || book_grid.Columns[e.ColumnIndex].HeaderCell.Value.ToString() == "Phone Number" || book_grid.Columns[e.ColumnIndex].HeaderCell.Value.ToString() == "Address")
            {
                MessageBox.Show("Please Click to cursor!", "Messaage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var msb = MessageBox.Show("Do you want to DELETE  record?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (msb == DialogResult.Yes)
                {
                    //delete record
                    connection.Open();
                    command = new SqlCommand(@"DELETE FROM AddressBook WHERE id = '" + book_grid.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record hes been successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadingDates();
                }
                else if (msb == DialogResult.No)
                {
                    //LoadingDates();
                    //editing record
                   // connection.Open();
                    form2.id_tb.Text = book_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //command = new SqlCommand(@"DELETE FROM AddressBook WHERE id = '" + book_grid.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connection);
                    //command.ExecuteNonQuery();
                    //connection.Close();
                    form2.save_btn.Enabled = true;
                    
                    form2.fullName_tb.Text = book_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    form2.email_tb.Text = book_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    form2.phone_tb.Text = book_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    form2.address_tb.Text = book_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    form2.ShowDialog();
                    LoadingDates();
                }
                else
                {
                    form2.Visible = false;
                }
            }

        }


        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
