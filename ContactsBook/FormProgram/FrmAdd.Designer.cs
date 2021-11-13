
namespace ContactsBook.FormProgram
{
    partial class FrmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PbAdd = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblNameAdd = new System.Windows.Forms.Label();
            this.LblLastAdd = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhonePersonal = new System.Windows.Forms.Label();
            this.LblPhoneWork = new System.Windows.Forms.Label();
            this.TxbNameAdd = new System.Windows.Forms.TextBox();
            this.TxbLastAdd = new System.Windows.Forms.TextBox();
            this.TxbAddress = new System.Windows.Forms.TextBox();
            this.MtbPhonePersonal = new System.Windows.Forms.MaskedTextBox();
            this.MtbPhoneWork = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAddCont = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAdd)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.08769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.82277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.08953F));
            this.tableLayoutPanel1.Controls.Add(this.PbAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.30935F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.12529F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.61731F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 439);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PbAdd
            // 
            this.PbAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbAdd.Image = ((System.Drawing.Image)(resources.GetObject("PbAdd.Image")));
            this.PbAdd.Location = new System.Drawing.Point(57, 3);
            this.PbAdd.Name = "PbAdd";
            this.PbAdd.Size = new System.Drawing.Size(336, 140);
            this.PbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbAdd.TabIndex = 0;
            this.PbAdd.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LblNameAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblLastAdd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblAddress, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LblPhonePersonal, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LblPhoneWork, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxbNameAdd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxbLastAdd, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxbAddress, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.MtbPhonePersonal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.MtbPhoneWork, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(57, 149);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 235);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // LblNameAdd
            // 
            this.LblNameAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNameAdd.AutoSize = true;
            this.LblNameAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNameAdd.Location = new System.Drawing.Point(104, 0);
            this.LblNameAdd.Name = "LblNameAdd";
            this.LblNameAdd.Size = new System.Drawing.Size(61, 17);
            this.LblNameAdd.TabIndex = 0;
            this.LblNameAdd.Text = "Nombre:";
            // 
            // LblLastAdd
            // 
            this.LblLastAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLastAdd.AutoSize = true;
            this.LblLastAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLastAdd.Location = new System.Drawing.Point(105, 47);
            this.LblLastAdd.Name = "LblLastAdd";
            this.LblLastAdd.Size = new System.Drawing.Size(60, 17);
            this.LblLastAdd.TabIndex = 1;
            this.LblLastAdd.Text = "Apellido:";
            // 
            // LblAddress
            // 
            this.LblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddress.Location = new System.Drawing.Point(99, 94);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(66, 17);
            this.LblAddress.TabIndex = 2;
            this.LblAddress.Text = "Dirección:";
            // 
            // LblPhonePersonal
            // 
            this.LblPhonePersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPhonePersonal.AutoSize = true;
            this.LblPhonePersonal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPhonePersonal.Location = new System.Drawing.Point(103, 141);
            this.LblPhonePersonal.Name = "LblPhonePersonal";
            this.LblPhonePersonal.Size = new System.Drawing.Size(62, 17);
            this.LblPhonePersonal.TabIndex = 3;
            this.LblPhonePersonal.Text = "Télefono:";
            // 
            // LblPhoneWork
            // 
            this.LblPhoneWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPhoneWork.AutoSize = true;
            this.LblPhoneWork.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPhoneWork.Location = new System.Drawing.Point(55, 188);
            this.LblPhoneWork.Name = "LblPhoneWork";
            this.LblPhoneWork.Size = new System.Drawing.Size(110, 17);
            this.LblPhoneWork.TabIndex = 4;
            this.LblPhoneWork.Text = "Télefono Trabajo:";
            // 
            // TxbNameAdd
            // 
            this.TxbNameAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbNameAdd.Location = new System.Drawing.Point(171, 3);
            this.TxbNameAdd.Name = "TxbNameAdd";
            this.TxbNameAdd.Size = new System.Drawing.Size(162, 23);
            this.TxbNameAdd.TabIndex = 5;
            // 
            // TxbLastAdd
            // 
            this.TxbLastAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbLastAdd.Location = new System.Drawing.Point(171, 50);
            this.TxbLastAdd.Name = "TxbLastAdd";
            this.TxbLastAdd.Size = new System.Drawing.Size(162, 23);
            this.TxbLastAdd.TabIndex = 6;
            // 
            // TxbAddress
            // 
            this.TxbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbAddress.Location = new System.Drawing.Point(171, 97);
            this.TxbAddress.Name = "TxbAddress";
            this.TxbAddress.Size = new System.Drawing.Size(162, 23);
            this.TxbAddress.TabIndex = 7;
            // 
            // MtbPhonePersonal
            // 
            this.MtbPhonePersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtbPhonePersonal.Location = new System.Drawing.Point(171, 144);
            this.MtbPhonePersonal.Mask = "(999) 000-0000";
            this.MtbPhonePersonal.Name = "MtbPhonePersonal";
            this.MtbPhonePersonal.Size = new System.Drawing.Size(162, 23);
            this.MtbPhonePersonal.TabIndex = 8;
            // 
            // MtbPhoneWork
            // 
            this.MtbPhoneWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtbPhoneWork.Location = new System.Drawing.Point(171, 191);
            this.MtbPhoneWork.Mask = "(999) 000-0000";
            this.MtbPhoneWork.Name = "MtbPhoneWork";
            this.MtbPhoneWork.Size = new System.Drawing.Size(162, 23);
            this.MtbPhoneWork.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnAddCont, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnCancel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(57, 390);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(336, 46);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // BtnAddCont
            // 
            this.BtnAddCont.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnAddCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddCont.FlatAppearance.BorderSize = 0;
            this.BtnAddCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCont.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddCont.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddCont.Image")));
            this.BtnAddCont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddCont.Location = new System.Drawing.Point(171, 3);
            this.BtnAddCont.Name = "BtnAddCont";
            this.BtnAddCont.Size = new System.Drawing.Size(162, 40);
            this.BtnAddCont.TabIndex = 0;
            this.BtnAddCont.Text = "Añadir";
            this.BtnAddCont.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(3, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 40);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSecciónToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // cerrarSecciónToolStripMenuItem
            // 
            this.cerrarSecciónToolStripMenuItem.Name = "cerrarSecciónToolStripMenuItem";
            this.cerrarSecciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarSecciónToolStripMenuItem.Text = "Cerrar Sección";
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdd";
            this.Text = "FrmAdd";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbAdd)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PbAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblNameAdd;
        private System.Windows.Forms.Label LblLastAdd;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblPhonePersonal;
        private System.Windows.Forms.Label LblPhoneWork;
        private System.Windows.Forms.TextBox TxbNameAdd;
        private System.Windows.Forms.TextBox TxbLastAdd;
        private System.Windows.Forms.TextBox TxbAddress;
        private System.Windows.Forms.MaskedTextBox MtbPhonePersonal;
        private System.Windows.Forms.MaskedTextBox MtbPhoneWork;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnAddCont;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSecciónToolStripMenuItem;
    }
}