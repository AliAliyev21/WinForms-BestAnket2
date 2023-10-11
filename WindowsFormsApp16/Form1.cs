using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        private List<User> users;

        public Form1()
        {


            InitializeComponent();

            LoadUsers();

            ListBox.DataSource= users;
            ListBox.DisplayMember=(nameof(User.Name));
            ListBox.SelectedIndex=0;
        }


        private void LoadUsers()
        {
            users = new List<User>
            {
                new User
                {
                    Name = "Asim",
                    Surname = "Rehimov",
                    Email = "rehimov19@gmail.com",
                    Phone = "0519476787",
                    BirthDate = new DateTime(2000, 10, 21),
                    JsonFileName = "asim.json"
                },
                new User
                {
                    Name = "Haci",
                    Surname = "Salmanov",
                    Email = "salmanov16@gmail.com",
                    Phone = "0503448723",
                    BirthDate = new DateTime(1996, 02, 27),
                    JsonFileName = "haci.json"
                },
            };
        }

        #region ErorLog
        private void LogError(string errorMessage)
        {
            try
            {
                using (StreamWriter writer = File.AppendText("error.log"))
                {
                    string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Error: {errorMessage}";
                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while writing to the error log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name=nameTxtb.Text;
            string surname = surnameTxtb.Text;
            string email = emailTxtb.Text;
            string phone=phoneMtb.Text;
            DateTime birthDate = dateTimePicker1.Value;

            User newUser=new User { Name=name, Surname=surname, Email=email, Phone=phone, BirthDate=birthDate,JsonFileName="user.json" };

            bool hasError=false;
            //Name verification
            try
            {
                Validations.IsNameValid(name);
                nameTxtb.ForeColor = SystemColors.WindowText;
            }
            catch (ArgumentException ex)
            {
                nameTxtb.ForeColor = Color.Red;
                hasError = true;
                LogError("Invalid name : " + ex.Message);
                MessageBox.Show(ex.Message, "The Name cannot be empty\nCan only contain letters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTxtb.Clear();
                nameTxtb.ForeColor= SystemColors.WindowText;
            }
            //Surname verification
            try
            {
                Validations.IsValidSurname(surname);
                surnameTxtb.ForeColor = SystemColors.WindowText;
            }
            catch (ArgumentException ex)
            {
                surnameTxtb.ForeColor = Color.Red;
                hasError = true;
                LogError("Invalid surname : " + ex.Message);
                MessageBox.Show(ex.Message, "The Surname cannot be empty\nCan only contain letters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                surnameTxtb.Clear();
                surnameTxtb.ForeColor= SystemColors.WindowText;
            }
            //Email verification
            try
            {
                Validations.IsEmailValid(email);
                emailTxtb.ForeColor = SystemColors.WindowText;
            }
            catch (ArgumentException ex)
            {
                emailTxtb.ForeColor = Color.Red;
                hasError = true;
                LogError("Invalid email address : " + ex.Message);
                MessageBox.Show(ex.Message, "Enter the correct email address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTxtb.Clear();
                emailTxtb.ForeColor=SystemColors.WindowText;
            }
            //Email verification
            try
            {
                Validations.IsPhoneNumberValid(phone);
                phoneMtb.ForeColor = SystemColors.WindowText;
            }
            catch (ArgumentException ex)
            {
                phoneMtb.ForeColor = Color.Red;
                hasError = true;
                LogError("Invalid phone number : " + ex.Message);
                MessageBox.Show(ex.Message, "The number cannot contain letters\nCan contain a maximum of 12 digits", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneMtb.Clear();
                phoneMtb.ForeColor= SystemColors.WindowText;
            }
            if (hasError)
            {
                return;

            }

            users.Add(newUser);

            

            LogError("User added : " + name);
            ListBox.DataSource = null;
            ListBox.DataSource = users;
            ListBox.DisplayMember = (nameof(User.Name));

            nameTxtb.Clear();
            surnameTxtb.Clear();
            emailTxtb.Clear();
            phoneMtb.Clear();
            dateTimePicker1.Value = DateTime.Now;
            nameTxtb.ForeColor = SystemColors.WindowText;
            surnameTxtb.ForeColor = SystemColors.WindowText;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxtb.Clear();
            surnameTxtb.Clear();
            emailTxtb.Clear();
            phoneMtb.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }


       

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = ListBox.SelectedItem as User;
            if (selectedUser != null)
            {
                fileNametxtb.Text = selectedUser.JsonFileName;
            }
        }


        private void WriteJson(User user)
        {
            string jsonFileName = user.JsonFileName;

            if (string.IsNullOrWhiteSpace(jsonFileName))
            {
                MessageBox.Show("Please enter a valid JSON file name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
                var json = JsonConvert.SerializeObject(user, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
                MessageBox.Show("User data saved to JSON file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving JSON file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private User LoadUserFromJson(string jsonFileName)
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);

            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<User>(jsonData);
            }

            return null;
        }



        private void saveBtn_Click(object sender, EventArgs e)
        {

            User selectedUser = ListBox.SelectedItem as User;

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user from the list to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WriteJson(selectedUser);

        }


        private void loadBtn_Click(object sender, EventArgs e)
        {
            User selectedUser = ListBox.SelectedItem as User;

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user from the list to load.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string jsonFileName = selectedUser.JsonFileName;
            User loadedUser = LoadUserFromJson(jsonFileName);

            if (loadedUser != null)
            {
                nameTxtb.Text = loadedUser.Name;
                surnameTxtb.Text = loadedUser.Surname;
                emailTxtb.Text = loadedUser.Email;
                phoneMtb.Text = loadedUser.Phone;
                dateTimePicker1.Value = loadedUser.BirthDate;
            }
        }


        private User selectedUserToChange;

        private void changeBtn_Click(object sender, EventArgs e)
        {
            User selectedUser = ListBox.SelectedItem as User;

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user from the list to change.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = nameTxtb.Text;
            string surname = surnameTxtb.Text;
            string email = emailTxtb.Text;
            string phone = phoneMtb.Text;
            DateTime birthDate = dateTimePicker1.Value;

            bool hasError = false;

            try
            {
                Validations.IsNameValid(name);
                nameTxtb.ForeColor = SystemColors.WindowText;
            }
            catch (ArgumentException ex)
            {
                nameTxtb.ForeColor = Color.Red;
                hasError = true;
                LogError("Invalid name: " + ex.Message);
                MessageBox.Show(ex.Message, "The Name cannot be empty and can only contain letters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                Validations.IsValidSurname(surname);
                surnameTxtb.ForeColor = SystemColors.WindowText;
            }
            catch (ArgumentException ex)
            {
                surnameTxtb.ForeColor = Color.Red;
                hasError = true;
                LogError("Invalid surname: " + ex.Message);
                MessageBox.Show(ex.Message, "The Surname cannot be empty and can only contain letters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                Validations.IsEmailValid(email);
                emailTxtb.ForeColor = SystemColors.WindowText;
            }
            catch (ArgumentException ex)
            {
                emailTxtb.ForeColor = Color.Red;
                hasError = true;
                LogError("Invalid email address: " + ex.Message);
                MessageBox.Show(ex.Message, "Enter the correct email address.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                Validations.IsPhoneNumberValid(phone);
                phoneMtb.ForeColor = SystemColors.WindowText;
            }
            catch (ArgumentException ex)
            {
                phoneMtb.ForeColor = Color.Red;
                hasError = true;
                LogError("Invalid phone number: " + ex.Message);
                MessageBox.Show(ex.Message, "The number cannot contain letters and can contain a maximum of 12 digits.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (hasError)
            {
                return;
            }

            selectedUserToChange = new User
            {
                Name = name,
                Surname = surname,
                Email = email,
                Phone = phone,
                BirthDate = birthDate
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedUserToChange == null)
            {
                MessageBox.Show("No changes to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            WriteJson(selectedUserToChange);

            ListBox.DataSource = null;
            ListBox.DataSource = users;
            ListBox.DisplayMember = nameof(User.Name);

            nameTxtb.Clear();
            surnameTxtb.Clear();
            emailTxtb.Clear();
            phoneMtb.Clear();
            dateTimePicker1.Value = DateTime.Now;

            selectedUserToChange = null;
        }
    }
}
