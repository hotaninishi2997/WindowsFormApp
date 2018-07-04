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
using WindowsFormsApp6.Newform;


namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const string FORMAT = "MM/dd/yyyy";
        submitClass c = new submitClass();

        private void textBox4_TextChanged(object sender, EventArgs e )
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            c.Institute = textBox1.Text;
            c.FirstName = textBox2.Text;
            c.LastName = textBox3.Text;
            c.StudentRollNo = int.Parse(textBox4.Text);
            c.DOB = Convert.ToDateTime(dateTimePicker1.Text);
            c.Contact = int.Parse(textBox6.Text);
            c.EmailID = textBox7.Text;
            c.Address = textBox8.Text;
            c.Pincode = int.Parse(textBox9.Text);
            c.Landmark = textBox10.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact Successfully Inserted");
                
            }
            else
            {
                MessageBox.Show("Failed to add new contact. Try again!");

            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.Institute = textBox1.Text;
            c.FirstName = textBox2.Text;
            c.LastName = textBox3.Text;
            c.StudentRollNo = int.Parse(textBox4.Text);
            c.DOB = Convert.ToDateTime(dateTimePicker1.Text);
            c.Contact = int.Parse(textBox6.Text);
            c.EmailID = textBox7.Text;
            c.Address = textBox8.Text;
            c.Pincode = int.Parse(textBox9.Text);
            c.Landmark = textBox10.Text;

            bool success = c.Update(c);
            if(success==true)
            {
                MessageBox.Show("Contact has been successfully updated");

            }
            else
            {
                MessageBox.Show("Cannot update contact. Try again!");

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            c.StudentRollNo = Convert.ToInt32(textBox4.Text);
           
            bool success = c.Delete(c);

            if (success == true)
            {
                MessageBox.Show("Contact has been successfully deleted");

            }
            else
            {
                MessageBox.Show("Cannot delete contact. Try again!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Institute = textBox1.Text;
            c.FirstName = textBox2.Text;
            c.LastName = textBox3.Text;
            c.StudentRollNo = int.Parse(textBox4.Text);
            c.DOB = Convert.ToDateTime(dateTimePicker1.Text);
            c.Contact = int.Parse(textBox6.Text);
            c.EmailID = textBox7.Text;
            c.Address = textBox8.Text;
            c.Pincode = int.Parse(textBox9.Text);
            c.Landmark = textBox10.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact Successfully Inserted");

            }
            else
            {
                MessageBox.Show("Failed to add new contact. Try again!");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
