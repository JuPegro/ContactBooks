using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactsBook.FormProgram
{
    public partial class FrmLogin : Form
    {
        public static FrmLogin Instance { get; } = new FrmLogin();

        public FrmLogin()
        {
            InitializeComponent();
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
                FrmLogin.Instance.Hide();
                FrmContacts newForm = new FrmContacts();
                newForm.Show();
                ClearTxb();
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
