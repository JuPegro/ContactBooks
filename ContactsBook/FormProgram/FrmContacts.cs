using BusinessLayers;
using BusinessLayers.UserBusiness;
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
    public partial class FrmContacts : Form
    {
        public ContactService contactService;

        public FrmContacts()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            contactService = new ContactService(connection);

            Boleans();
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

        private void DgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ContactRepository.Instance.SelectIndex = Convert.ToInt32(DgvContacts.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnDeselect.Visible = true;
            }
        }

        private void FrmContacts_VisibleChanged(object sender, EventArgs e)
        {
            LoadData();
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
            DgvContacts.DataSource = contactService.GetAll(UserRepository.Instance.IdUser);

            DgvContacts.ClearSelection();

            ContactRepository.Instance.SelectIndex = null;

            Deselect();
        }

        private void Add()
        {
            if (ContactRepository.Instance.SelectIndex == null)
            {
                FrmAdd newForm = new FrmAdd();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe Deseleccionar el Contacto Antes de Agregar", "Advertencia");
            }
        }

        private void Deselect()
        {
            DgvContacts.ClearSelection();

            BtnDeselect.Visible = false;

            ContactRepository.Instance.SelectIndex = null;
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

        public void Boleans()
        {
            BtnDeselect.Visible = false;
            ContactRepository.Instance.SelectIndex = null;
        }

        #endregion
    }
}
