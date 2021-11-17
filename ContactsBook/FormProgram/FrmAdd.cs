using BusinessLayers;
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
    public partial class FrmAdd : Form
    {
        public ContactService contactService;

        public FrmAdd()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString; //Connection SQL

            SqlConnection connection = new SqlConnection(connectionString);

            contactService = new ContactService(connection);
        }


        #region "Events"

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            if (ContactRepository.Instance.SelectIndex != null)
            {
                LoadEditContact();
            }
        }

        private void cerrarSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seccion();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void FrmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClose();
            ClearTbx();
        }

        private void BtnAddCont_Click(object sender, EventArgs e)
        {
            if (ContactRepository.Instance.SelectIndex == null)
            {
                AddContact();
            }
            else
            {
                EditContact();
            }
        }

        #endregion

        #region "Methods"

        public void Cancel()
        {
            FormClose();
            ClearTbx();
        }

        public void Seccion()
        {
            FrmLogin.Instance.Show();
            this.Hide();
            ClearTbx();
        }

        public void AddContact()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxbNameAdd.Text) || string.IsNullOrWhiteSpace(TxbLastAdd.Text)
                || string.IsNullOrWhiteSpace(TxbAddress.Text) || !MtbPhonePersonal.MaskCompleted || !MtbPhoneWork.MaskCompleted)
                {
                    MessageBox.Show("Debe Completar Todos los Datos", "Advertencia");
                }
                else
                {
                    DataContacts contact = new DataContacts()
                    {

                        Name = TxbNameAdd.Text,
                        LastName = TxbLastAdd.Text,
                        Address = TxbAddress.Text,
                        Phone = MtbPhonePersonal.Text,
                        PhoneWork = MtbPhoneWork.Text,
                        IdUser = UserRepository.Instance.IdUser

                    };

                    contactService.Add(contact);

                    MessageBox.Show("Se Agrego el Nuevo Contacto", "Notificación");
                    ClearTbx();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe Completar Todos los Datos", "Error");
            }
        }

        public void ClearTbx()
        {
            TxbNameAdd.Clear();
            TxbLastAdd.Clear();
            TxbAddress.Clear();
            MtbPhonePersonal.Clear();
            MtbPhoneWork.Clear();
            TxbNameAdd.Focus();
        }

        public void FormClose()
        {
            FrmContacts newForm = new FrmContacts();
            newForm.Show();
            this.Hide();
            ClearTbx();
        }

        public void EditContact()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxbNameAdd.Text) || string.IsNullOrWhiteSpace(TxbLastAdd.Text)
                || string.IsNullOrWhiteSpace(TxbAddress.Text) || !MtbPhonePersonal.MaskCompleted || !MtbPhoneWork.MaskCompleted)
                {
                    MessageBox.Show("Debe Completar Todos los Datos", "Advertencia");
                }
                else
                {
                    DataContacts contact = new DataContacts();
                    contact.Name = TxbNameAdd.Text;
                    contact.LastName = TxbLastAdd.Text;
                    contact.Address = TxbAddress.Text;
                    contact.Phone = MtbPhonePersonal.Text;
                    contact.PhoneWork = MtbPhoneWork.Text;
                    contact.Id = (int)ContactRepository.Instance.SelectIndex;


                    contactService.Edit(contact);
                    MessageBox.Show("Se Edito el Contacto", "Notificación");
                    FormClose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe Completar Todos los Datos", "Error");
            }
        }

        private void LoadEditContact()
        {
            if (ContactRepository.Instance.SelectIndex != null)
            {
                DataContacts editContact = contactService.GetById(ContactRepository.Instance.SelectIndex.Value);
                TxbNameAdd.Text = editContact.Name;
                TxbLastAdd.Text = editContact.LastName;
                TxbAddress.Text = editContact.Address;
                MtbPhonePersonal.Text = editContact.Phone;
                MtbPhoneWork.Text = editContact.PhoneWork;
                editContact.Id = ContactRepository.Instance.SelectIndex.Value;
            }
        }

        #endregion
    }
}
