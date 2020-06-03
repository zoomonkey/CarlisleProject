namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.carlDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlFreightTerms = new System.Windows.Forms.ComboBox();
            this.ddlOrderStatus = new System.Windows.Forms.ComboBox();
            this.btnSaveRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.dtpReqShipDate = new System.Windows.Forms.DateTimePicker();
            this.cbOpenOrdersOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.carlDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(1858, 1157);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(376, 98);
            this.btnRefreshGrid.TabIndex = 0;
            this.btnRefreshGrid.Text = "Refresh Grid View";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2181, 936);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(940, 140);
            this.txtQuantity.MaxLength = 4;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(171, 39);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Req Ship Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Freight Terms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(934, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity";
            // 
            // ddlFreightTerms
            // 
            this.ddlFreightTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFreightTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFreightTerms.FormattingEnabled = true;
            this.ddlFreightTerms.Items.AddRange(new object[] {
            "",
            "Third Party Bill",
            "Prepaid"});
            this.ddlFreightTerms.Location = new System.Drawing.Point(638, 138);
            this.ddlFreightTerms.Name = "ddlFreightTerms";
            this.ddlFreightTerms.Size = new System.Drawing.Size(272, 40);
            this.ddlFreightTerms.TabIndex = 10;
            // 
            // ddlOrderStatus
            // 
            this.ddlOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlOrderStatus.FormattingEnabled = true;
            this.ddlOrderStatus.Items.AddRange(new object[] {
            "",
            "Open",
            "Invoiced",
            "Cancelled"});
            this.ddlOrderStatus.Location = new System.Drawing.Point(332, 137);
            this.ddlOrderStatus.Name = "ddlOrderStatus";
            this.ddlOrderStatus.Size = new System.Drawing.Size(272, 40);
            this.ddlOrderStatus.TabIndex = 11;
            // 
            // btnSaveRefresh
            // 
            this.btnSaveRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRefresh.Location = new System.Drawing.Point(1138, 137);
            this.btnSaveRefresh.Name = "btnSaveRefresh";
            this.btnSaveRefresh.Size = new System.Drawing.Size(344, 42);
            this.btnSaveRefresh.TabIndex = 12;
            this.btnSaveRefresh.Text = "Save And Refresh";
            this.btnSaveRefresh.UseVisualStyleBackColor = false;
            this.btnSaveRefresh.Click += new System.EventHandler(this.btnSaveRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Editing Order Number: ";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.ForeColor = System.Drawing.Color.Red;
            this.lblOrderNumber.Location = new System.Drawing.Point(414, 56);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(0, 32);
            this.lblOrderNumber.TabIndex = 14;
            // 
            // dtpReqShipDate
            // 
            this.dtpReqShipDate.CustomFormat = "yyyymmdd";
            this.dtpReqShipDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReqShipDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReqShipDate.Location = new System.Drawing.Point(87, 137);
            this.dtpReqShipDate.Name = "dtpReqShipDate";
            this.dtpReqShipDate.Size = new System.Drawing.Size(215, 39);
            this.dtpReqShipDate.TabIndex = 15;
            // 
            // cbOpenOrdersOnly
            // 
            this.cbOpenOrdersOnly.AutoSize = true;
            this.cbOpenOrdersOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpenOrdersOnly.Location = new System.Drawing.Point(1516, 140);
            this.cbOpenOrdersOnly.Name = "cbOpenOrdersOnly";
            this.cbOpenOrdersOnly.Size = new System.Drawing.Size(302, 33);
            this.cbOpenOrdersOnly.TabIndex = 16;
            this.cbOpenOrdersOnly.Text = "Show Only Open Orders";
            this.cbOpenOrdersOnly.UseVisualStyleBackColor = true;
            this.cbOpenOrdersOnly.CheckedChanged += new System.EventHandler(this.cbOpenOrdersOnly_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2323, 1356);
            this.Controls.Add(this.cbOpenOrdersOnly);
            this.Controls.Add(this.dtpReqShipDate);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaveRefresh);
            this.Controls.Add(this.ddlOrderStatus);
            this.Controls.Add(this.ddlFreightTerms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefreshGrid);
            this.Name = "MainForm";
            this.Text = "Carlisle Mini Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carlDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.BindingSource carlDBDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlFreightTerms;
        private System.Windows.Forms.ComboBox ddlOrderStatus;
        private System.Windows.Forms.Button btnSaveRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.DateTimePicker dtpReqShipDate;
        private System.Windows.Forms.CheckBox cbOpenOrdersOnly;
    }
}

