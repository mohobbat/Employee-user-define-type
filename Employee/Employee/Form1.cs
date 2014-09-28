using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class EmployeeAppUI : Form
    {
        public EmployeeAppUI()
        {
            InitializeComponent();
        }

        Employee anEmployee=new Employee();
        private void showButton_Click(object sender, EventArgs e)
        {
            anEmployee.id = idTextBox.Text;
            anEmployee.name = nameTextBox.Text;
            anEmployee.salary = Convert.ToDouble(salaryTextBox.Text);

            MessageBox.Show("Your ID is: " + anEmployee.id + "\nName is: " + anEmployee.name + "\nSalary is: " +
                            anEmployee.salary);

            idTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            salaryTextBox.Text = string.Empty;


        }

        private void retriveButton_Click(object sender, EventArgs e)
        {

            idTextBox.Text = anEmployee.id;
            nameTextBox.Text = anEmployee.name;
            salaryTextBox.Text = anEmployee.salary.ToString();

            MessageBox.Show("Message Retrive Successfuly");
        }
    }
}
