using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.Database;
using LibraryManager.CRUDService;

namespace LibraryManager
{
    public partial class LoginWindow : Form
    {
        private LibraryPanel library;
        private DatabaseHandler databaseHandler;

        public enum UserRole { ADMIN, USER, GUEST}
        public UserRole loggedUserRole;
        public string loggedUserName;
        public LoginWindow()
        {
            InitializeComponent();
            CenterToScreen();
            databaseHandler = new DatabaseHandler();
        }

        private void btn_login_signin_Click(object sender, EventArgs e)
        {
            if (tbx_login_name.Text.Equals("") || tbx_login_pwd.Text.Equals(""))
            {
                MessageBox.Show("Passowrd or Name not given");
                return;
            }

            if (!databaseHandler.GetUsers().Contains(tbx_login_name.Text.TrimEnd(' ')))
            {
                MessageBox.Show("Given name does not exist in database");
                return;
            }

            using (var client = new CRUDServiceClient())
            {
                string hashedPassword = client.GenerateSHA256Hash(tbx_login_pwd.Text);

                if (!databaseHandler.FetchPassword(tbx_login_name.Text).Equals(hashedPassword))
                {
                    MessageBox.Show("Incorrect password");
                    return;
                }
            }
            
            loggedUserRole = (UserRole) databaseHandler.GetUserRole(tbx_login_name.Text);
            loggedUserName = tbx_login_name.Text;
            library = new LibraryPanel(this);
            library.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, this.Size.Width + 200);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (tbx_create_name.Text.Equals(""))
            {
                MessageBox.Show("Name not given.");
                return;
            }

            if (tbx_create_pwd.Text.Equals("")|| tbx_create_pwd2.Text.Equals(""))
            {
                MessageBox.Show("Password not given.");
                return;
            }

            if (!tbx_create_pwd.Text.Equals(tbx_create_pwd2.Text))
            {
                MessageBox.Show("Passwords are not the same.");
                return;
            }

            if (databaseHandler.GetUsers().Contains(tbx_create_name.Text.TrimEnd(' ')))
            {
                MessageBox.Show("Name has been already taken. Please change it.");
                return;
            }

            using (var client = new CRUDServiceClient())
            {
                bool isCreated = client.AddUser(tbx_create_name.Text, tbx_create_pwd.Text);

                if (isCreated)
                {
                    MessageBox.Show("Account successfully created. You can log in now.");
                }

                else
                {
                    MessageBox.Show("An error occurred while creating an account.");
                }
            }    
        }

        private void btn_login_guest_Click(object sender, EventArgs e)
        {
            loggedUserRole = UserRole.GUEST;
            library = new LibraryPanel(this);
            library.Show();
            this.Hide();
        }
    }
}
