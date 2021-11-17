using BusinessLayers.UserBusiness;
using SQLConnection.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactsBook.FormProgram
{
    public partial class FrmLogin : Form
    {
        private UserService userService;

        public static FrmLogin Instance { get; } = new FrmLogin();

        public FrmLogin()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString; //Connection SQL

            SqlConnection connection = new SqlConnection(connectionString);

            userService = new UserService(connection);
        }

        #region "Events"

        private void BtnRegister_Click_1(object sender, EventArgs e)
        {
            RegisterForm();
        }

        private void BtnEntry_Click_1(object sender, EventArgs e)
        {
            Login();
        }

        #endregion

        #region "Methods"

        public void Login()
        {
            if (string.IsNullOrWhiteSpace(TxbUserLogin.Text) || string.IsNullOrWhiteSpace(TxbPasswordLogin.Text))
            {
                MessageBox.Show("Debe Completar todos los Datos", "Advertencia");
                ClearTxb();
            }
            else
            {
                DataUser data = userService.Login(TxbUserLogin.Text, TxbPasswordLogin.Text);
                if (data.UserName == TxbUserLogin.Text && data.Password == TxbPasswordLogin.Text)
                {
                    UserRepository.Instance.IdUser = data.Id;

                    FrmLogin.Instance.Hide();
                    FrmContacts newForm = new FrmContacts();
                    newForm.Show();
                    ClearTxb();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto", "Advertencia");
                }
            }
        }

        public void RegisterForm()
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
            ClearTxb();
        }

        public void ClearTxb()
        {
            TxbPasswordLogin.Clear();
            TxbUserLogin.Clear();
            TxbUserLogin.Focus();
        }

        #endregion
    }
}
