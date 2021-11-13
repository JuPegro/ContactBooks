using BusinessLayers.UserBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            userService = new UserService();
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

                    Users users = new Users
                    {
                        Name = TbxName.Text,
                        LastName = TbxLastName.Text,
                        UserName = TbxUser.Text,
                        Password = TxbPasswordC.Text
                    };

                    userService.Add(users);
                    ClearTxb();
                    MessageBox.Show("Se ha registrado con Exito", "Notificación");
                    Back();
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
                MessageBox.Show("Debe Completar todos los Datos", "Advertencia");
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
