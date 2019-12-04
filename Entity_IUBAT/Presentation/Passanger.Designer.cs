namespace Entity_IUBAT.Presentation
{
    partial class Passanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passanger));
            this.txt_pSearch = new System.Windows.Forms.TextBox();
            this.btn_psearch = new System.Windows.Forms.Button();
            this.btn_printPassanger = new System.Windows.Forms.Button();
            this.data_passanger = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.std_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.data_passanger)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pSearch
            // 
            this.txt_pSearch.Location = new System.Drawing.Point(14, 12);
            this.txt_pSearch.Name = "txt_pSearch";
            this.txt_pSearch.Size = new System.Drawing.Size(219, 21);
            this.txt_pSearch.TabIndex = 0;
            this.txt_pSearch.TextChanged += new System.EventHandler(this.txt_pSearch_TextChanged);
            // 
            // btn_psearch
            // 
            this.btn_psearch.Location = new System.Drawing.Point(240, 10);
            this.btn_psearch.Name = "btn_psearch";
            this.btn_psearch.Size = new System.Drawing.Size(87, 23);
            this.btn_psearch.TabIndex = 1;
            this.btn_psearch.Text = "Search";
            this.btn_psearch.UseVisualStyleBackColor = true;
            this.btn_psearch.Click += new System.EventHandler(this.btn_psearch_Click);
            // 
            // btn_printPassanger
            // 
            this.btn_printPassanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_printPassanger.Location = new System.Drawing.Point(594, 10);
            this.btn_printPassanger.Name = "btn_printPassanger";
            this.btn_printPassanger.Size = new System.Drawing.Size(87, 23);
            this.btn_printPassanger.TabIndex = 4;
            this.btn_printPassanger.Text = "Print";
            this.btn_printPassanger.UseVisualStyleBackColor = true;
            this.btn_printPassanger.Click += new System.EventHandler(this.btn_printPassanger_Click);
            // 
            // data_passanger
            // 
            this.data_passanger.AllowUserToAddRows = false;
            this.data_passanger.AllowUserToDeleteRows = false;
            this.data_passanger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_passanger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_passanger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_passanger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.std_id,
            this.name,
            this.password,
            this.contact,
            this.email,
            this.gender,
            this.joinDate,
            this.address});
            this.data_passanger.Cursor = System.Windows.Forms.Cursors.Default;
            this.data_passanger.Location = new System.Drawing.Point(-7, 39);
            this.data_passanger.Name = "data_passanger";
            this.data_passanger.ReadOnly = true;
            this.data_passanger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_passanger.Size = new System.Drawing.Size(697, 312);
            this.data_passanger.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // std_id
            // 
            this.std_id.DataPropertyName = "std_id";
            this.std_id.HeaderText = "Student Id";
            this.std_id.Name = "std_id";
            this.std_id.ReadOnly = true;
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Passanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 347);
            this.Controls.Add(this.data_passanger);
            this.Controls.Add(this.btn_printPassanger);
            this.Controls.Add(this.btn_psearch);
            this.Controls.Add(this.txt_pSearch);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 385);
            this.MinimumSize = new System.Drawing.Size(700, 385);
            this.Name = "Passanger";
            this.Text = "Passanger Details";
            this.Load += new System.EventHandler(this.Passanger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_passanger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pSearch;
        private System.Windows.Forms.Button btn_psearch;
        private System.Windows.Forms.Button btn_printPassanger;
        private System.Windows.Forms.DataGridView data_passanger;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn std_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}