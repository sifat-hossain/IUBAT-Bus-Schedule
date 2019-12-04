namespace Entity_IUBAT.Presentation
{
    partial class AdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManager));
            this.data_admin = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_printAdmin = new System.Windows.Forms.Button();
            this.btn_adsearch = new System.Windows.Forms.Button();
            this.txt_adSearch = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.data_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // data_admin
            // 
            this.data_admin.AllowUserToAddRows = false;
            this.data_admin.AllowUserToDeleteRows = false;
            this.data_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ad_id,
            this.name,
            this.password,
            this.contact,
            this.email,
            this.gender,
            this.joinDate,
            this.address});
            this.data_admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.data_admin.Location = new System.Drawing.Point(-1, 33);
            this.data_admin.Name = "data_admin";
            this.data_admin.ReadOnly = true;
            this.data_admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_admin.Size = new System.Drawing.Size(923, 525);
            this.data_admin.TabIndex = 9;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ad_id
            // 
            this.ad_id.DataPropertyName = "ad_id";
            this.ad_id.HeaderText = "ID Number";
            this.ad_id.Name = "ad_id";
            this.ad_id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "Contact";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gn";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // joinDate
            // 
            this.joinDate.DataPropertyName = "joinDate";
            this.joinDate.HeaderText = "Join Date";
            this.joinDate.Name = "joinDate";
            this.joinDate.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // btn_printAdmin
            // 
            this.btn_printAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_printAdmin.Location = new System.Drawing.Point(817, 4);
            this.btn_printAdmin.Name = "btn_printAdmin";
            this.btn_printAdmin.Size = new System.Drawing.Size(87, 23);
            this.btn_printAdmin.TabIndex = 8;
            this.btn_printAdmin.Text = "Print";
            this.btn_printAdmin.UseVisualStyleBackColor = true;
            this.btn_printAdmin.Click += new System.EventHandler(this.btn_printAdmin_Click);
            // 
            // btn_adsearch
            // 
            this.btn_adsearch.Location = new System.Drawing.Point(246, 4);
            this.btn_adsearch.Name = "btn_adsearch";
            this.btn_adsearch.Size = new System.Drawing.Size(87, 23);
            this.btn_adsearch.TabIndex = 7;
            this.btn_adsearch.Text = "Search";
            this.btn_adsearch.UseVisualStyleBackColor = true;
            this.btn_adsearch.Click += new System.EventHandler(this.btn_adsearch_Click);
            // 
            // txt_adSearch
            // 
            this.txt_adSearch.Location = new System.Drawing.Point(20, 6);
            this.txt_adSearch.Name = "txt_adSearch";
            this.txt_adSearch.Size = new System.Drawing.Size(219, 20);
            this.txt_adSearch.TabIndex = 6;
            this.txt_adSearch.TextChanged += new System.EventHandler(this.txt_adSearch_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // AdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 562);
            this.Controls.Add(this.data_admin);
            this.Controls.Add(this.btn_printAdmin);
            this.Controls.Add(this.btn_adsearch);
            this.Controls.Add(this.txt_adSearch);
            this.MaximumSize = new System.Drawing.Size(936, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(936, 600);
            this.Name = "AdminManager";
            this.Text = "AdminManager";
            this.Load += new System.EventHandler(this.AdminManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_admin;
        private System.Windows.Forms.Button btn_printAdmin;
        private System.Windows.Forms.Button btn_adsearch;
        private System.Windows.Forms.TextBox txt_adSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}