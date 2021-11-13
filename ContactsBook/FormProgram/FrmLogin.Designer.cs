
namespace ContactsBook.FormProgram
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.PbLogin = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxbUserLogin = new System.Windows.Forms.TextBox();
            this.TxbPasswordLogin = new System.Windows.Forms.TextBox();
            this.BtnEntry = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TlpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpLogin
            // 
            this.TlpLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TlpLogin.ColumnCount = 3;
            this.TlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4723F));
            this.TlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0554F));
            this.TlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.47231F));
            this.TlpLogin.Controls.Add(this.PbLogin, 1, 0);
            this.TlpLogin.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.TlpLogin.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.TlpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpLogin.Location = new System.Drawing.Point(0, 0);
            this.TlpLogin.Name = "TlpLogin";
            this.TlpLogin.RowCount = 3;
            this.TlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.6609F));
            this.TlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.9244F));
            this.TlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.63067F));
            this.TlpLogin.Size = new System.Drawing.Size(436, 424);
            this.TlpLogin.TabIndex = 1;
            // 
            // PbLogin
            // 
            this.PbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbLogin.Image = ((System.Drawing.Image)(resources.GetObject("PbLogin.Image")));
            this.PbLogin.Location = new System.Drawing.Point(74, 3);
            this.PbLogin.Name = "PbLogin";
            this.PbLogin.Size = new System.Drawing.Size(286, 157);
            this.PbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbLogin.TabIndex = 0;
            this.PbLogin.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxbUserLogin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxbPasswordLogin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnEntry, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 184);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblUser
            // 
            this.LblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUser.Location = new System.Drawing.Point(67, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(73, 21);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Usuario:";
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPassword.Location = new System.Drawing.Point(40, 73);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(100, 21);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Contraseña:";
            // 
            // TxbUserLogin
            // 
            this.TxbUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbUserLogin.Location = new System.Drawing.Point(146, 3);
            this.TxbUserLogin.Name = "TxbUserLogin";
            this.TxbUserLogin.Size = new System.Drawing.Size(137, 23);
            this.TxbUserLogin.TabIndex = 2;
            // 
            // TxbPasswordLogin
            // 
            this.TxbPasswordLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbPasswordLogin.Location = new System.Drawing.Point(146, 76);
            this.TxbPasswordLogin.Name = "TxbPasswordLogin";
            this.TxbPasswordLogin.Size = new System.Drawing.Size(137, 23);
            this.TxbPasswordLogin.TabIndex = 3;
            this.TxbPasswordLogin.UseSystemPasswordChar = true;
            // 
            // BtnEntry
            // 
            this.BtnEntry.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnEntry, 2);
            this.BtnEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEntry.FlatAppearance.BorderSize = 0;
            this.BtnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEntry.Location = new System.Drawing.Point(3, 149);
            this.BtnEntry.Name = "BtnEntry";
            this.BtnEntry.Size = new System.Drawing.Size(280, 32);
            this.BtnEntry.TabIndex = 4;
            this.BtnEntry.Text = "Entrar";
            this.BtnEntry.UseVisualStyleBackColor = false;
            this.BtnEntry.Click += new System.EventHandler(this.BtnEntry_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.68916F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.61927F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69157F));
            this.tableLayoutPanel2.Controls.Add(this.BtnRegister, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(74, 356);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(286, 65);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegister.ForeColor = System.Drawing.Color.MediumBlue;
            this.BtnRegister.Location = new System.Drawing.Point(62, 3);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(161, 26);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "Registrarse";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 424);
            this.Controls.Add(this.TlpLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "Inicio";
            this.TlpLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpLogin;
        private System.Windows.Forms.PictureBox PbLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxbUserLogin;
        private System.Windows.Forms.TextBox TxbPasswordLogin;
        private System.Windows.Forms.Button BtnEntry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnRegister;
    }
}