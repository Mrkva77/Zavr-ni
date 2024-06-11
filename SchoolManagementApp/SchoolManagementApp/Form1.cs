using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementApp
{
    public partial class Form1 : Form
    {

        private List<Person> people;

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
        }  

        private void ShowPeople(List<Person> peopleToShow)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Person person in peopleToShow)
            {
                sb.AppendLine($"First Name: {person.FirstName}, Last Name: {person.LastName}, Role: {person.Role}, Activity: {person.Activity}");
            }

            textbox1.Text = sb.ToString();
        }

        private void ClearInputFields()
        {
            txtIme.Text = string.Empty;
            txtPrezime.Text = string.Empty;
            cmbUloga.SelectedIndex = -1;
        }
                public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Role { get; set; }
            public string Activity { get; set; }

            public Person(string firstName, string lastName, string role)
            {
                FirstName = firstName;
                LastName = lastName;
                Role = role;
                Activity = string.Empty;
            }

        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Please enter a first name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Please enter a last name.");
                return;
            }

            if (cmbUloga.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string firstName = txtIme.Text;
            string lastName = txtPrezime.Text;
            string role = cmbUloga.SelectedItem.ToString();

            Person person = new Person(firstName, lastName, role);
            people.Add(person);
        }

        private void btnShowPeople_Click_1(object sender, EventArgs e)
        {
            ShowPeople(people);
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            string selectedRole = cmbUloga.SelectedItem.ToString();

            List<Person> filteredPeople = people.FindAll(p => p.Role == selectedRole);

            ShowPeople(filteredPeople);
        }

        private void btnProcessData_Click_1(object sender, EventArgs e)
        {
            foreach (Person person in people)
            {
                if (person.Role == "Student")
                {
                    person.Activity = "Studying";
                }
                else if (person.Role == "Teacher")
                {
                    person.Activity = "Teaching";
                }
                else if (person.Role == "Staff")
                {
                    person.Activity = "Maintaining";
                }
            }

            ShowPeople(people);
        }
    }
}


