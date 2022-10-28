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
    public partial class Form2 : Form
    {

        SqlConnection connection;
        SqlCommand command;
        DataBaseCnn dataBase = new DataBaseCnn();
        Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            connection = new SqlConnection(dataBase.Connection());
            this.form1 = form1;
        }
        public void Clear()
        {
            fullName_tb.Clear();
            email_tb.Clear();
            address_tb.Clear();
            phone_tb.Clear();
            save_btn.Enabled = true;


        }
        private bool IsCompleted()
        {
            if (fullName_tb.Text.Length > 0 && email_tb.Text.Length > 0 &&
                address_tb.Text.Length > 0 && phone_tb.Text.Length > 0 && phone_tb.Text.Length < 12)
            {
                return true;
            }
            return false;
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (!IsCompleted())
                {
                    MessageBox.Show("Compleate or Correct all fields!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                connection.Open();
                if (id_tb.Text.Length==0)
                {
                    command = new SqlCommand("INSERT INTO AddressBook (fullname,email,phonenumber,address) VALUES (@fullname,@email,@phonenumber,@address)", connection);

                }
                else
                {
                    command = new SqlCommand("UPDATE  AddressBook SET fullname=@fullname,email=@email,phonenumber=@phonenumber,address=@address WHERE id=@id", connection);
                    command.Parameters.AddWithValue("@id", id_tb.Text);
                }
                command.Parameters.AddWithValue("@fullname", fullName_tb.Text);
                command.Parameters.AddWithValue("@email", email_tb.Text);
                command.Parameters.AddWithValue("@phonenumber", phone_tb.Text);
                command.Parameters.AddWithValue("@address", address_tb.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Your data has been successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form1.LoadingDates();
               // Clear();
                this.Visible = false;
            }
            catch (Exception exception)
            {
                connection.Close();
                MessageBox.Show(exception.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.AddressBook' table. You can move, or remove it, as needed.
            //this.addressBookTableAdapter.Fill(this.appData.AddressBook);
           
        }
    }
}
