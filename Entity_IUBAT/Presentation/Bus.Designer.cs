namespace Entity_IUBAT.Presentation
{
    partial class Bus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bus));
            this.txt_busSearch = new System.Windows.Forms.TextBox();
            this.btn_busSearch = new System.Windows.Forms.Button();
            this.btn_addBus = new System.Windows.Forms.Button();
            this.btn_editBus = new System.Windows.Forms.Button();
            this.btn_deleteBus = new System.Windows.Forms.Button();
            this.bus_data = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBus_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber_plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Max_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_printBus = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bus_data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busSearch
            // 
            this.txt_busSearch.Location = new System.Drawing.Point(3, 3);
            this.txt_busSearch.Name = "txt_busSearch";
            this.txt_busSearch.Size = new System.Drawing.Size(177, 21);
            this.txt_busSearch.TabIndex = 0;
            this.txt_busSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_busSearch
            // 
            this.btn_busSearch.Location = new System.Drawing.Point(188, 3);
            this.btn_busSearch.Name = "btn_busSearch";
            this.btn_busSearch.Size = new System.Drawing.Size(87, 23);
            this.btn_busSearch.TabIndex = 1;
            this.btn_busSearch.Text = "Search";
            this.btn_busSearch.UseVisualStyleBackColor = true;
            this.btn_busSearch.Click += new System.EventHandler(this.btn_busSearch_Click);
            // 
            // btn_addBus
            // 
            this.btn_addBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addBus.Location = new System.Drawing.Point(544, 3);
            this.btn_addBus.Name = "btn_addBus";
            this.btn_addBus.Size = new System.Drawing.Size(87, 23);
            this.btn_addBus.TabIndex = 2;
            this.btn_addBus.Text = "Add";
            this.btn_addBus.UseVisualStyleBackColor = true;
            this.btn_addBus.Click += new System.EventHandler(this.btn_addBus_Click);
            // 
            // btn_editBus
            // 
            this.btn_editBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editBus.Location = new System.Drawing.Point(638, 3);
            this.btn_editBus.Name = "btn_editBus";
            this.btn_editBus.Size = new System.Drawing.Size(87, 23);
            this.btn_editBus.TabIndex = 3;
            this.btn_editBus.Text = "Edit";
            this.btn_editBus.UseVisualStyleBackColor = true;
            this.btn_editBus.Click += new System.EventHandler(this.btn_editBus_Click);
            // 
            // btn_deleteBus
            // 
            this.btn_deleteBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteBus.Location = new System.Drawing.Point(733, 3);
            this.btn_deleteBus.Name = "btn_deleteBus";
            this.btn_deleteBus.Size = new System.Drawing.Size(87, 23);
            this.btn_deleteBus.TabIndex = 4;
            this.btn_deleteBus.Text = "Delete";
            this.btn_deleteBus.UseVisualStyleBackColor = true;
            this.btn_deleteBus.Click += new System.EventHandler(this.btn_deleteBus_Click);
            // 
            // bus_data
            // 
            this.bus_data.AllowUserToAddRows = false;
            this.bus_data.AllowUserToDeleteRows = false;
            this.bus_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bus_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bus_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bus_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colBus_number,
            this.colNumber_plate,
            this.col_Max_capacity});
            this.bus_data.Location = new System.Drawing.Point(3, 30);
            this.bus_data.Name = "bus_data";
            this.bus_data.ReadOnly = true;
            this.bus_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bus_data.Size = new System.Drawing.Size(918, 537);
            this.bus_data.TabIndex = 5;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colBus_number
            // 
            this.colBus_number.DataPropertyName = "bus_number";
            this.colBus_number.HeaderText = "Bus Number";
            this.colBus_number.Name = "colBus_number";
            this.colBus_number.ReadOnly = true;
            // 
            // colNumber_plate
            // 
            this.colNumber_plate.DataPropertyName = "number_plate";
            this.colNumber_plate.HeaderText = "Number Plate";
            this.colNumber_plate.Name = "colNumber_plate";
            this.colNumber_plate.ReadOnly = true;
            // 
            // col_Max_capacity
            // 
            this.col_Max_capacity.DataPropertyName = "max_capacity";
            this.col_Max_capacity.HeaderText = "Maximum Capacity";
            this.col_Max_capacity.Name = "col_Max_capacity";
            this.col_Max_capacity.ReadOnly = true;
            // 
            // btn_printBus
            // 
            this.btn_printBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_printBus.Location = new System.Drawing.Point(825, 3);
            this.btn_printBus.Name = "btn_printBus";
            this.btn_printBus.Size = new System.Drawing.Size(87, 23);
            this.btn_printBus.TabIndex = 6;
            this.btn_printBus.Text = "Print";
            this.btn_printBus.UseVisualStyleBackColor = true;
            this.btn_printBus.Click += new System.EventHandler(this.btn_printBus_Click);
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
            // Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 561);
            this.Controls.Add(this.btn_printBus);
            this.Controls.Add(this.bus_data);
            this.Controls.Add(this.btn_deleteBus);
            this.Controls.Add(this.btn_editBus);
            this.Controls.Add(this.btn_addBus);
            this.Controls.Add(this.btn_busSearch);
            this.Controls.Add(this.txt_busSearch);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(936, 600);
            this.MinimumSize = new System.Drawing.Size(936, 600);
            this.Name = "Bus";
            this.Text = "Bus";
            this.Load += new System.EventHandler(this.Bus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bus_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_busSearch;
        private System.Windows.Forms.Button btn_busSearch;
        private System.Windows.Forms.Button btn_addBus;
        private System.Windows.Forms.Button btn_editBus;
        private System.Windows.Forms.Button btn_deleteBus;
        private System.Windows.Forms.DataGridView bus_data;
        private System.Windows.Forms.Button btn_printBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBus_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber_plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Max_capacity;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}