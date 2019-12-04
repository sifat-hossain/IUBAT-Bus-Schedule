namespace Entity_IUBAT.Presentation
{
    partial class PenaltyDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenaltyDetails));
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.data_cancle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_from = new System.Windows.Forms.ComboBox();
            this.cmb_to = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Bus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pas = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passanger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penalty_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_cancle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(597, 45);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(477, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Paid Penalty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data_cancle
            // 
            this.data_cancle.AllowUserToAddRows = false;
            this.data_cancle.AllowUserToDeleteRows = false;
            this.data_cancle.AllowUserToResizeColumns = false;
            this.data_cancle.AllowUserToResizeRows = false;
            this.data_cancle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_cancle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cancle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.passanger,
            this.from,
            this.to,
            this.time,
            this.bus,
            this.date,
            this.penalty_status,
            this.amount});
            this.data_cancle.Location = new System.Drawing.Point(-6, 74);
            this.data_cancle.Name = "data_cancle";
            this.data_cancle.ReadOnly = true;
            this.data_cancle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_cancle.Size = new System.Drawing.Size(700, 277);
            this.data_cancle.TabIndex = 6;
            this.data_cancle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_cancle_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // cmb_from
            // 
            this.cmb_from.AutoCompleteCustomSource.AddRange(new string[] {
            "All"});
            this.cmb_from.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_from.FormattingEnabled = true;
            this.cmb_from.Location = new System.Drawing.Point(48, 15);
            this.cmb_from.Name = "cmb_from";
            this.cmb_from.Size = new System.Drawing.Size(169, 21);
            this.cmb_from.TabIndex = 11;
            this.cmb_from.SelectedIndexChanged += new System.EventHandler(this.cmb_from_SelectedIndexChanged);
            // 
            // cmb_to
            // 
            this.cmb_to.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_to.FormattingEnabled = true;
            this.cmb_to.Location = new System.Drawing.Point(48, 44);
            this.cmb_to.Name = "cmb_to";
            this.cmb_to.Size = new System.Drawing.Size(169, 21);
            this.cmb_to.TabIndex = 12;
            this.cmb_to.SelectedIndexChanged += new System.EventHandler(this.cmb_to_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Passanger";
            // 
            // cmb_Bus
            // 
            this.cmb_Bus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Bus.FormattingEnabled = true;
            this.cmb_Bus.Location = new System.Drawing.Point(297, 47);
            this.cmb_Bus.Name = "cmb_Bus";
            this.cmb_Bus.Size = new System.Drawing.Size(169, 21);
            this.cmb_Bus.TabIndex = 15;
            this.cmb_Bus.SelectedIndexChanged += new System.EventHandler(this.cmb_Bus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bus";
            // 
            // txt_pas
            // 
            this.txt_pas.Location = new System.Drawing.Point(297, 15);
            this.txt_pas.Name = "txt_pas";
            this.txt_pas.Size = new System.Drawing.Size(169, 20);
            this.txt_pas.TabIndex = 16;
            this.txt_pas.TextChanged += new System.EventHandler(this.txt_pas_TextChanged);
            this.txt_pas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pas_KeyPress);
            this.txt_pas.Leave += new System.EventHandler(this.txt_pas_Leave);
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
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // passanger
            // 
            this.passanger.DataPropertyName = "passanger";
            this.passanger.HeaderText = "Passanger";
            this.passanger.Name = "passanger";
            this.passanger.ReadOnly = true;
            // 
            // from
            // 
            this.from.DataPropertyName = "from";
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // to
            // 
            this.to.DataPropertyName = "to";
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // bus
            // 
            this.bus.DataPropertyName = "bus";
            this.bus.HeaderText = "Bus";
            this.bus.Name = "bus";
            this.bus.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // penalty_status
            // 
            this.penalty_status.DataPropertyName = "penalty_status";
            this.penalty_status.HeaderText = "Status";
            this.penalty_status.Name = "penalty_status";
            this.penalty_status.ReadOnly = true;
            this.penalty_status.Visible = false;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // PenaltyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 347);
            this.Controls.Add(this.txt_pas);
            this.Controls.Add(this.cmb_Bus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_to);
            this.Controls.Add(this.cmb_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_cancle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_print);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 385);
            this.MinimumSize = new System.Drawing.Size(700, 385);
            this.Name = "PenaltyDetails";
            this.Text = "Penalty Details";
            this.Load += new System.EventHandler(this.PenaltyDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_cancle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView data_cancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_from;
        private System.Windows.Forms.ComboBox cmb_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Bus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pas;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn passanger;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn penalty_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}