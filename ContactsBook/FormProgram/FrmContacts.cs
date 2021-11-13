using BusinessLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactsBook.FormProgram
{
    public partial class FrmContacts : Form
    {
        public ContactService contactService;

        public FrmContacts()
        {
            InitializeComponent();
            contactService = new ContactService();
            BtnDeselect.Visible = false;
            ContactRepository.Instance.SelectIndex = null;
        }


        #region "Events"

        private void FrmContacts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cerrarSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void FrmContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Instance.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void DgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ContactRepository.Instance.SelectIndex = e.RowIndex;
                BtnDeselect.Visible = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        #endregion


        #region "Methods"

        public void Exit()
        {
            FrmLogin.Instance.Show();
            this.Close();
        }

        private void LoadData()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = contactService.GetAll();

            DgvContacts.DataSource = bindingSource;
            DgvContacts.ClearSelection();
            ContactRepository.Instance.SelectIndex = null;
        }

        private void Add()
        {
            FrmAdd newForm = new FrmAdd();
            newForm.Show();
            this.Hide();
        }

        private void Deselect()
        {
            DgvContacts.ClearSelection();

            BtnDeselect.Visible = false;
        }

        private void Delete()
        {
            if (ContactRepository.Instance.SelectIndex == null)
            {
                MessageBox.Show("Debe Seleccionar Un Contacto", "Advertencia");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Esta Seguro que Desea Eliminar Este Contacto?",
                    "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    contactService.Delete(ContactRepository.Instance.SelectIndex.Value);
                    MessageBox.Show("Ha Eliminado el Contacto", "Notificación");
                    Deselect();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("No se ha Eliminado el Contacto", "Notificación");
                    Deselect();
                    LoadData();
                }

            }
        }

        public void Edit()
        {
            FrmAdd newForm = new FrmAdd();
            newForm.Show();
            this.Hide();
        }

        #endregion
    }
}
