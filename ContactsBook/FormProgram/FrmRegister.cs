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
    public partial class FrmRegister : Form
    {
        public UserService userService;

        public FrmRegister()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString; //Connection SQL

            SqlConnection connection = new SqlConnection(connectionString);

            userService = new UserService(connection);
        }

        #region "Events"

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Back();
        }

        private void FrmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Instance.Show();
            ClearTxb();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }


        #endregion


        #region

        public void Confirm()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbxName.Text) || string.IsNullOrWhiteSpace(TbxLastName.Text) ||
                string.IsNullOrWhiteSpace(TbxUser.Text) || string.IsNullOrWhiteSpace(TbxPassword.Text)
                || string.IsNullOrWhiteSpace(TxbPasswordC.Text))
                {
                    MessageBox.Show("Debe Completar todos los Datos", "Advertencia");
                }
                else if (TbxPassword.Text != null && TxbPasswordC.Text != null && TbxPassword.Text == TxbPasswordC.Text)
                {

                    DataUser users = new DataUser()
                    {
                        Name = TbxName.Text,
                        LastName = TbxLastName.Text,
                        UserName = TbxUser.Text,
                        Password = TxbPasswordC.Text
                    };

                    if (userService.CheckUser(users))
                    {
                        MessageBox.Show("Este Usuario ya esta registrado", "Notificación");
                    }
                    else
                    {
                        userService.Add(users);
                        MessageBox.Show("Se ha registrado con Exito", "Notificación");
                        ClearTxb();
                        Back();
                    } 
                }
                else
                {
                    MessageBox.Show("Las Contraseñas no coinciden Intente de Nuevo", "Error");
                    TxbPasswordC.Focus();
                    TxbPasswordC.Clear();
                    TbxPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe Completar  los Datos", "Advertencia");
            }
        }

        public void Back()
        {
            FrmLogin.Instance.Show();
            this.Hide();
            ClearTxb();
        }

        public void ClearTxb()
        {
            TbxLastName.Clear();
            TbxName.Clear();
            TbxUser.Clear();
            TbxPassword.Clear();
            TxbPasswordC.Clear();
        }

        #endregion
    }
}
