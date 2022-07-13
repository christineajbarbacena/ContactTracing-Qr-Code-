﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMobileNumber_Click(object sender, EventArgs e)
        {

        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\barbacena\Desktop\ContactTracingResponses\" + txtboxDate.Text + ".txt", true);
            file.WriteLine("Contact Tracing Response ");
            file.WriteLine("Date and Time: " + txtboxDate.Text + " , " + txtboxTime.Text);
            file.WriteLine("Name: " + txtboxSurname.Text + "," + txtboxFirstName.Text + " " + txtboxMiddleInitial.Text + "." + " " + txtboxSuffix.Text);
            file.WriteLine("Birth Date: " + txtboxBirthdate.Text);
            file.WriteLine("Age: " + txtboxAge.Text + " years old");
            file.WriteLine("Sex: " + txtboxSex.Text);
            file.WriteLine("ADDRESS ");
            file.WriteLine("Province: " + txtboxProvince.Text);
            file.WriteLine("City: " + txtboxCity.Text);
            file.WriteLine("Street Name: " + txtboxStreetName.Text);
            file.WriteLine("Barangay: " + txtboxBarangay.Text);
            file.WriteLine("----End of Response----");
            file.WriteLine("");
            file.Close();
            MessageBox.Show("I HEREBY CERTIFY that the information provided in this form is complete, true and correct.");
            MessageBox.Show("Thank you Mr/Ms." + txtboxSurname.Text);
            this.Close();
        }

        private void bttnAdminSignIn_Click(object sender, EventArgs e)
        {
            //adding username and password for sign in button
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;

            if ((username == "admin") && (password == "admin"))

            //right password and username
            {
                this.Hide();
                Form2 adminForm = new Form2();
                adminForm.ShowDialog();
            }

            //incorrect username and password
            else
            {
                MessageBox.Show("Incorrect Username and/or Password");
            }
        }

        private void bttnGenerate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirecting to Generate Form");

            StreamWriter file = new StreamWriter(@"C:\Users\barbacena\Desktop\ContactTracingResponses\generatedqr.txt", true);
            file.WriteLine("Date and Time: " + txtboxDate.Text + " , " + txtboxTime.Text + "Name: " + txtboxSurname.Text + "," + txtboxFirstName.Text + " " + txtboxMiddleInitial.Text + "." + " " + txtboxSuffix.Text + "Birth Date: " + txtboxBirthdate.Text + "Age: " + txtboxAge.Text + " years old" + "Sex: " + txtboxSex.Text + "ADDRESS " + txtboxProvince.Text + ", " + txtboxCity.Text + ", " + txtboxStreetName.Text + ", " + txtboxBarangay.Text);
            file.Close();

            Form3 GenerateForm = new Form3();
            GenerateForm.ShowDialog();
        }

        private void bttnScan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirecting to Scan Form");
            Form4 ScanQr = new Form4();
            ScanQr.ShowDialog();
        }
    }
}
