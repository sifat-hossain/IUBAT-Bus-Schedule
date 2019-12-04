namespace Entity_IUBAT.Presentation
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.txt_scheduleSearch = new System.Windows.Forms.TextBox();
            this.btn_scheduleSearch = new System.Windows.Forms.Button();
            this.btn_schedulePrint = new System.Windows.Forms.Button();
            this.btn_scheduleDelete = new System.Windows.Forms.Button();
            this.btn_scheduleEdit = new System.Windows.Forms.Button();
            this.btn_scheduleAdd = new System.Windows.Forms.Button();
            this.schedule_data = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_scheduleSearch
            // 
            this.txt_scheduleSearch.Location = new System.Drawing.Point(14, 12);
            this.txt_scheduleSearch.Name = "txt_scheduleSearch";
            this.txt_scheduleSearch.Size = new System.Drawing.Size(159, 21);
            this.txt_scheduleSearch.TabIndex = 0;
            // 
            // btn_scheduleSearch
            // 
            this.btn_scheduleSearch.Location = new System.Drawing.Point(181, 10);
            this.btn_scheduleSearch.Name = "btn_scheduleSearch";
            this.btn_scheduleSearch.Size = new System.Drawing.Size(87, 23);
            this.btn_scheduleSearch.TabIndex = 1;
            this.btn_scheduleSearch.Text = "Search";
            this.btn_scheduleSearch.UseVisualStyleBackColor = true;
            this.btn_scheduleSearch.Click += new System.EventHandler(this.btn_scheduleSearch_Click);
            // 
            // btn_schedulePrint
            // 
            this.btn_schedulePrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_schedulePrint.Location = new System.Drawing.Point(819, 10);
            this.btn_schedulePrint.Name = "btn_schedulePrint";
            this.btn_schedulePrint.Size = new System.Drawing.Size(87, 23);
            this.btn_schedulePrint.TabIndex = 2;
            this.btn_schedulePrint.Text = "Print";
            this.btn_schedulePrint.UseVisualStyleBackColor = true;
            this.btn_schedulePrint.Click += new System.EventHandler(this.btn_schedulePrint_Click);
            // 
            // btn_scheduleDelete
            // 
            this.btn_scheduleDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scheduleDelete.Location = new System.Drawing.Point(724, 10);
            this.btn_scheduleDelete.Name = "btn_scheduleDelete";
            this.btn_scheduleDelete.Size = new System.Drawing.Size(87, 23);
            this.btn_scheduleDelete.TabIndex = 3;
            this.btn_scheduleDelete.Text = "Delete";
            this.btn_scheduleDelete.UseVisualStyleBackColor = true;
            this.btn_scheduleDelete.Click += new System.EventHandler(this.btn_scheduleDelete_Click);
            // 
            // btn_scheduleEdit
            // 
            this.btn_scheduleEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scheduleEdit.Location = new System.Drawing.Point(630, 10);
            this.btn_scheduleEdit.Name = "btn_scheduleEdit";
            this.btn_scheduleEdit.Size = new System.Drawing.Size(87, 23);
            this.btn_scheduleEdit.TabIndex = 4;
            this.btn_scheduleEdit.Text = "Edit";
            this.btn_scheduleEdit.UseVisualStyleBackColor = true;
            this.btn_scheduleEdit.Click += new System.EventHandler(this.btn_scheduleEdit_Click);
            // 
            // btn_scheduleAdd
            // 
            this.btn_scheduleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scheduleAdd.Location = new System.Drawing.Point(535, 10);
            this.btn_scheduleAdd.Name = "btn_scheduleAdd";
            this.btn_scheduleAdd.Size = new System.Drawing.Size(87, 23);
            this.btn_scheduleAdd.TabIndex = 5;
            this.btn_scheduleAdd.Text = "Add";
            this.btn_scheduleAdd.UseVisualStyleBackColor = true;
            this.btn_scheduleAdd.Click += new System.EventHandler(this.btn_scheduleAdd_Click);
            // 
            // schedule_data
            // 
            this.schedule_data.AllowUserToAddRows = false;
            this.schedule_data.AllowUserToDeleteRows = false;
            this.schedule_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schedule_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schedule_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.t_id,
            this.l_from,
            this.l_to});
            this.schedule_data.Location = new System.Drawing.Point(-6, 39);
            this.schedule_data.Name = "schedule_data";
            this.schedule_data.ReadOnly = true;
            this.schedule_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schedule_data.Size = new System.Drawing.Size(929, 526);
            this.schedule_data.TabIndex = 6;
            this.schedule_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedule_data_CellContentClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // t_id
            // 
            this.t_id.DataPropertyName = "time_id";
            this.t_id.HeaderText = "Time ";
            this.t_id.Name = "t_id";
            this.t_id.ReadOnly = true;
            // 
            // l_from
            // 
            this.l_from.DataPropertyName = "location_from";
            this.l_from.HeaderText = "From";
            this.l_from.Name = "l_from";
            this.l_from.ReadOnly = true;
            // 
            // l_to
            // 
            this.l_to.DataPropertyName = "location_to";
            this.l_to.HeaderText = "To";
            this.l_to.Name = "l_to";
            this.l_to.ReadOnly = true;
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
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 562);
            this.Controls.Add(this.schedule_data);
            this.Controls.Add(this.btn_scheduleAdd);
            this.Controls.Add(this.btn_scheduleEdit);
            this.Controls.Add(this.btn_scheduleDelete);
            this.Controls.Add(this.btn_schedulePrint);
            this.Controls.Add(this.btn_scheduleSearch);
            this.Controls.Add(this.txt_scheduleSearch);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(936, 600);
            this.MinimumSize = new System.Drawing.Size(936, 600);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedule_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_scheduleSearch;
        private System.Windows.Forms.Button btn_scheduleSearch;
        private System.Windows.Forms.Button btn_schedulePrint;
        private System.Windows.Forms.Button btn_scheduleDelete;
        private System.Windows.Forms.Button btn_scheduleEdit;
        private System.Windows.Forms.Button btn_scheduleAdd;
        private System.Windows.Forms.DataGridView schedule_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_to;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}