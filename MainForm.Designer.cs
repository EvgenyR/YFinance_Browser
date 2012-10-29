namespace Finance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.symbolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageWeb = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lblCookies = new System.Windows.Forms.Label();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.tabPageSymbols = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlFinance = new System.Windows.Forms.TabControl();
            this.lblSymbols = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.symbolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumBindingSource)).BeginInit();
            this.tabPageWeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.tabPageSymbols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlFinance.SuspendLayout();
            this.SuspendLayout();
            // 
            // symbolBindingSource
            // 
            this.symbolBindingSource.DataSource = typeof(Finance.Symbol);
            // 
            // datumBindingSource
            // 
            this.datumBindingSource.DataSource = typeof(Finance.Datum);
            // 
            // tabPageWeb
            // 
            this.tabPageWeb.Controls.Add(this.txtPassword);
            this.tabPageWeb.Controls.Add(this.txtUsername);
            this.tabPageWeb.Controls.Add(this.lblPassword);
            this.tabPageWeb.Controls.Add(this.lblUsername);
            this.tabPageWeb.Controls.Add(this.btnRefresh);
            this.tabPageWeb.Controls.Add(this.dataGridViewData);
            this.tabPageWeb.Controls.Add(this.btnGetData);
            this.tabPageWeb.Controls.Add(this.lblCookies);
            this.tabPageWeb.Controls.Add(this.btnAuthenticate);
            this.tabPageWeb.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeb.Name = "tabPageWeb";
            this.tabPageWeb.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWeb.Size = new System.Drawing.Size(607, 294);
            this.tabPageWeb.TabIndex = 1;
            this.tabPageWeb.Text = "Download";
            this.tabPageWeb.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(347, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(347, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(168, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(285, 56);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(278, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "User Name:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(101, 51);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Stop";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AutoGenerateColumns = false;
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.lTPDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.askDataGridViewTextBoxColumn,
            this.bidDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn});
            this.dataGridViewData.DataSource = this.datumBindingSource;
            this.dataGridViewData.Location = new System.Drawing.Point(6, 86);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersVisible = false;
            this.dataGridViewData.Size = new System.Drawing.Size(595, 169);
            this.dataGridViewData.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 75;
            // 
            // lTPDataGridViewTextBoxColumn
            // 
            this.lTPDataGridViewTextBoxColumn.DataPropertyName = "LTP";
            this.lTPDataGridViewTextBoxColumn.HeaderText = "LTP";
            this.lTPDataGridViewTextBoxColumn.Name = "lTPDataGridViewTextBoxColumn";
            this.lTPDataGridViewTextBoxColumn.ReadOnly = true;
            this.lTPDataGridViewTextBoxColumn.Width = 52;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.timeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 55;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumeDataGridViewTextBoxColumn.Width = 67;
            // 
            // askDataGridViewTextBoxColumn
            // 
            this.askDataGridViewTextBoxColumn.DataPropertyName = "Ask";
            this.askDataGridViewTextBoxColumn.HeaderText = "Ask";
            this.askDataGridViewTextBoxColumn.Name = "askDataGridViewTextBoxColumn";
            this.askDataGridViewTextBoxColumn.ReadOnly = true;
            this.askDataGridViewTextBoxColumn.Width = 50;
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "Bid";
            this.bidDataGridViewTextBoxColumn.HeaderText = "Bid";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidDataGridViewTextBoxColumn.Width = 47;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "High";
            this.highDataGridViewTextBoxColumn.HeaderText = "High";
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.ReadOnly = true;
            this.highDataGridViewTextBoxColumn.Width = 54;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "Low";
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.ReadOnly = true;
            this.lowDataGridViewTextBoxColumn.Width = 52;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(20, 51);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "Start";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lblCookies
            // 
            this.lblCookies.AutoSize = true;
            this.lblCookies.Location = new System.Drawing.Point(17, 268);
            this.lblCookies.Name = "lblCookies";
            this.lblCookies.Size = new System.Drawing.Size(35, 13);
            this.lblCookies.TabIndex = 1;
            this.lblCookies.Text = "label1";
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(526, 24);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(75, 23);
            this.btnAuthenticate.TabIndex = 0;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // tabPageSymbols
            // 
            this.tabPageSymbols.Controls.Add(this.lblSymbols);
            this.tabPageSymbols.Controls.Add(this.btnUpdate);
            this.tabPageSymbols.Controls.Add(this.dataGridView1);
            this.tabPageSymbols.Location = new System.Drawing.Point(4, 22);
            this.tabPageSymbols.Name = "tabPageSymbols";
            this.tabPageSymbols.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSymbols.Size = new System.Drawing.Size(607, 294);
            this.tabPageSymbols.TabIndex = 0;
            this.tabPageSymbols.Text = "Symbols";
            this.tabPageSymbols.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(202, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.symbolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(202, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(232, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // tabControlFinance
            // 
            this.tabControlFinance.Controls.Add(this.tabPageSymbols);
            this.tabControlFinance.Controls.Add(this.tabPageWeb);
            this.tabControlFinance.Location = new System.Drawing.Point(12, 12);
            this.tabControlFinance.Name = "tabControlFinance";
            this.tabControlFinance.SelectedIndex = 0;
            this.tabControlFinance.Size = new System.Drawing.Size(615, 320);
            this.tabControlFinance.TabIndex = 2;
            // 
            // lblSymbols
            // 
            this.lblSymbols.AutoSize = true;
            this.lblSymbols.Location = new System.Drawing.Point(200, 12);
            this.lblSymbols.Name = "lblSymbols";
            this.lblSymbols.Size = new System.Drawing.Size(131, 13);
            this.lblSymbols.TabIndex = 2;
            this.lblSymbols.Text = "Manage the list of symbols";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 344);
            this.Controls.Add(this.tabControlFinance);
            this.Name = "MainForm";
            this.Text = "Yahoo! Finance";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symbolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumBindingSource)).EndInit();
            this.tabPageWeb.ResumeLayout(false);
            this.tabPageWeb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.tabPageSymbols.ResumeLayout(false);
            this.tabPageSymbols.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlFinance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource symbolBindingSource;
        private System.Windows.Forms.BindingSource datumBindingSource;
        private System.Windows.Forms.TabPage tabPageWeb;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn askDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label lblCookies;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.TabPage tabPageSymbols;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControlFinance;
        private System.Windows.Forms.Label lblSymbols;
    }
}

