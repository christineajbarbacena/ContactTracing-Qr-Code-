using System;
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
    }
}
