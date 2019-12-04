namespace Entity_IUBAT.Presentation
{
    partial class Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location));
            this.txt_lsearch = new System.Windows.Forms.TextBox();
            this.btn_lsearch = new System.Windows.Forms.Button();
            this.btn_addLocation = new System.Windows.Forms.Button();
            this.btn_editLocation = new System.Windows.Forms.Button();
            this.btn_deleteLocation = new System.Windows.Forms.Button();
            this.btn_printLocation = new System.Windows.Forms.Button();
            this.data_location = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.data_location)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_lsearch
            // 
            this.txt_lsearch.Location = new System.Drawing.Point(14, 12);
            this.txt_lsearch.Name = "txt_lsearch";
            this.txt_lsearch.Size = new System.Drawing.Size(175, 21);
            this.txt_lsearch.TabIndex = 0;
            this.txt_lsearch.TextChanged += new System.EventHandler(this.txt_lsearch_TextChanged);
            // 
            // btn_lsearch
            // 
            this.btn_lsearch.Location = new System.Drawing.Point(197, 10);
            this.btn_lsearch.Name = "btn_lsearch";
            this.btn_lsearch.Size = new System.Drawing.Size(87, 23);
            this.btn_lsearch.TabIndex = 1;
            this.btn_lsearch.Text = "Search";
            this.btn_lsearch.UseVisualStyleBackColor = true;
            this.btn_lsearch.Click += new System.EventHandler(this.btn_lsearch_Click);
            // 
            // btn_addLocation
            // 
            this.btn_addLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addLocation.Location = new System.Drawing.Point(538, 10);
            this.btn_addLocation.Name = "btn_addLocation";
            this.btn_addLocation.Size = new System.Drawing.Size(87, 23);
            this.btn_addLocation.TabIndex = 2;
            this.btn_addLocation.Text = "Add";
            this.btn_addLocation.UseVisualStyleBackColor = true;
            this.btn_addLocation.Click += new System.EventHandler(this.btn_addLocation_Click);
            // 
            // btn_editLocation
            // 
            this.btn_editLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editLocation.Location = new System.Drawing.Point(633, 10);
            this.btn_editLocation.Name = "btn_editLocation";
            this.btn_editLocation.Size = new System.Drawing.Size(87, 23);
            this.btn_editLocation.TabIndex = 3;
            this.btn_editLocation.Text = "Edit";
            this.btn_editLocation.UseVisualStyleBackColor = true;
            this.btn_editLocation.Click += new System.EventHandler(this.btn_editLocation_Click);
            // 
            // btn_deleteLocation
            // 
            this.btn_deleteLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteLocation.Location = new System.Drawing.Point(727, 10);
            this.btn_deleteLocation.Name = "btn_deleteLocation";
            this.btn_deleteLocation.Size = new System.Drawing.Size(87, 23);
            this.btn_deleteLocation.TabIndex = 4;
            this.btn_deleteLocation.Text = "Delete";
            this.btn_deleteLocation.UseVisualStyleBackColor = true;
            this.btn_deleteLocation.Click += new System.EventHandler(this.btn_deleteLocation_Click);
            // 
            // btn_printLocation
            // 
            this.btn_printLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_printLocation.Location = new System.Drawing.Point(822, 10);
            this.btn_printLocation.Name = "btn_printLocation";
            this.btn_printLocation.Size = new System.Drawing.Size(87, 23);
            this.btn_printLocation.TabIndex = 5;
            this.btn_printLocation.Text = "Print";
            this.btn_printLocation.UseVisualStyleBackColor = true;
            this.btn_printLocation.Click += new System.EventHandler(this.btn_printLocation_Click);
            // 
            // data_location
            // 
            this.data_location.AllowUserToAddRows = false;
            this.data_location.AllowUserToDeleteRows = false;
            this.data_location.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_location.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_location.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.city});
            this.data_location.Location = new System.Drawing.Point(-6, 38);
            this.data_location.Name = "data_location";
            this.data_location.ReadOnly = true;
            this.data_location.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_location.Size = new System.Drawing.Size(933, 527);
            this.data_location.TabIndex = 6;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
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
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 562);
            this.Controls.Add(this.data_location);
            this.Controls.Add(this.btn_printLocation);
            this.Controls.Add(this.btn_deleteLocation);
            this.Controls.Add(this.btn_editLocation);
            this.Controls.Add(this.btn_addLocation);
            this.Controls.Add(this.btn_lsearch);
            this.Controls.Add(this.txt_lsearch);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(936, 600);
            this.MinimumSize = new System.Drawing.Size(936, 600);
            this.Name = "Location";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.Location_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_location)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_lsearch;
        private System.Windows.Forms.Button btn_lsearch;
        private System.Windows.Forms.Button btn_addLocation;
        private System.Windows.Forms.Button btn_editLocation;
        private System.Windows.Forms.Button btn_deleteLocation;
        private System.Windows.Forms.Button btn_printLocation;
        private System.Windows.Forms.DataGridView data_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}