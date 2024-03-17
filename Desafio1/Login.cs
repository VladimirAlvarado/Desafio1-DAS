using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class FormLogin : Form
    {

        private Dictionary<string, User> usuariosRegistrados = new Dictionary<string, User>();

        public FormLogin()
        {
            InitializeComponent();
            InitializeRegisteredUsers();
        }

        private void InitializeRegisteredUsers()
        {
            usuariosRegistrados.Add("Usuario1", new User("Usuario1", "User1234", "Programas de Entretenimiento"));
            usuariosRegistrados.Add("Usuario2", new User("Usuario2", "User123", "Lenguajes de Programacion"));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxLogin.Image = Image.FromFile("C:\\Users\\GUASI\\Documents\\GitHub\\Desafio1-DAS\\Desafio1\\img\\Login.png");
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            if (usuariosRegistrados.ContainsKey(username))
            {
                User user = usuariosRegistrados[username];

                if (user.Password == password)
                {
                    MessageBox.Show("Bienvenido, " + username);

                    FormInformation formInformation = new FormInformation(user);
                    formInformation.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas!");

                }
            }
            else
            {
                MessageBox.Show("Usuario no registrado");
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
