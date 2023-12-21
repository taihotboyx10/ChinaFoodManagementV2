namespace ChinaFoodManagementV2
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.予約リストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アカウント情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.個人情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ログアウトToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTableChange = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTableDestination = new System.Windows.Forms.ComboBox();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrFoodNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboFoodName = new System.Windows.Forms.ComboBox();
            this.btnFoodAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnCashier = new Guna.UI2.WinForms.Guna2Button();
            this.cboTableBase = new System.Windows.Forms.ComboBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCashier = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTable
            // 
            this.pnlTable.AutoScroll = true;
            this.pnlTable.Location = new System.Drawing.Point(16, 42);
            this.pnlTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(569, 520);
            this.pnlTable.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理者ToolStripMenuItem,
            this.予約リストToolStripMenuItem,
            this.アカウント情報ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理者ToolStripMenuItem
            // 
            this.管理者ToolStripMenuItem.Name = "管理者ToolStripMenuItem";
            this.管理者ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.管理者ToolStripMenuItem.Text = "管理者";
            this.管理者ToolStripMenuItem.Click += new System.EventHandler(this.管理者ToolStripMenuItem_Click);
            // 
            // 予約リストToolStripMenuItem
            // 
            this.予約リストToolStripMenuItem.Name = "予約リストToolStripMenuItem";
            this.予約リストToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.予約リストToolStripMenuItem.Text = "予約リスト";
            // 
            // アカウント情報ToolStripMenuItem
            // 
            this.アカウント情報ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.個人情報ToolStripMenuItem,
            this.ログアウトToolStripMenuItem});
            this.アカウント情報ToolStripMenuItem.Name = "アカウント情報ToolStripMenuItem";
            this.アカウント情報ToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.アカウント情報ToolStripMenuItem.Text = "アカウント情報&&ログアウト";
            // 
            // 個人情報ToolStripMenuItem
            // 
            this.個人情報ToolStripMenuItem.Name = "個人情報ToolStripMenuItem";
            this.個人情報ToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.個人情報ToolStripMenuItem.Text = "アカウント情報";
            this.個人情報ToolStripMenuItem.Click += new System.EventHandler(this.個人情報ToolStripMenuItem_Click);
            // 
            // ログアウトToolStripMenuItem
            // 
            this.ログアウトToolStripMenuItem.Name = "ログアウトToolStripMenuItem";
            this.ログアウトToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.ログアウトToolStripMenuItem.Text = "ログアウト";
            this.ログアウトToolStripMenuItem.Click += new System.EventHandler(this.ログアウトToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(601, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "テーブル先";
            // 
            // btnTableChange
            // 
            this.btnTableChange.BorderRadius = 15;
            this.btnTableChange.BorderThickness = 2;
            this.btnTableChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTableChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTableChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTableChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTableChange.FillColor = System.Drawing.Color.Orange;
            this.btnTableChange.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableChange.ForeColor = System.Drawing.Color.Black;
            this.btnTableChange.Image = ((System.Drawing.Image)(resources.GetObject("btnTableChange.Image")));
            this.btnTableChange.Location = new System.Drawing.Point(707, 509);
            this.btnTableChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTableChange.Name = "btnTableChange";
            this.btnTableChange.Size = new System.Drawing.Size(173, 43);
            this.btnTableChange.TabIndex = 34;
            this.btnTableChange.Text = "テーブル変更";
            this.btnTableChange.Click += new System.EventHandler(this.btnTableChange_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(601, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(601, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "テーブル元";
            // 
            // cboTableDestination
            // 
            this.cboTableDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableDestination.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTableDestination.FormattingEnabled = true;
            this.cboTableDestination.Location = new System.Drawing.Point(605, 563);
            this.cboTableDestination.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTableDestination.Name = "cboTableDestination";
            this.cboTableDestination.Size = new System.Drawing.Size(95, 28);
            this.cboTableDestination.TabIndex = 43;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Location = new System.Drawing.Point(889, 563);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(152, 29);
            this.txtDiscount.TabIndex = 42;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTableName.Location = new System.Drawing.Point(793, 42);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(103, 22);
            this.lblTableName.TabIndex = 41;
            this.lblTableName.Text = "table name";
            this.lblTableName.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(1067, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(1067, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "料理名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1015, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1070, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "料理の種類";
            // 
            // nmrFoodNum
            // 
            this.nmrFoodNum.BackColor = System.Drawing.Color.Transparent;
            this.nmrFoodNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmrFoodNum.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrFoodNum.Location = new System.Drawing.Point(1074, 193);
            this.nmrFoodNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmrFoodNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrFoodNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrFoodNum.Name = "nmrFoodNum";
            this.nmrFoodNum.Size = new System.Drawing.Size(157, 29);
            this.nmrFoodNum.TabIndex = 29;
            this.nmrFoodNum.UpDownButtonFillColor = System.Drawing.Color.Gray;
            this.nmrFoodNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(1074, 69);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(157, 28);
            this.cboCategory.TabIndex = 27;
            this.cboCategory.SelectedValueChanged += new System.EventHandler(this.cboCategory_SelectedValueChanged);
            // 
            // cboFoodName
            // 
            this.cboFoodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodName.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFoodName.FormattingEnabled = true;
            this.cboFoodName.Location = new System.Drawing.Point(1074, 132);
            this.cboFoodName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboFoodName.Name = "cboFoodName";
            this.cboFoodName.Size = new System.Drawing.Size(157, 28);
            this.cboFoodName.TabIndex = 32;
            // 
            // btnFoodAdd
            // 
            this.btnFoodAdd.BorderRadius = 15;
            this.btnFoodAdd.BorderThickness = 2;
            this.btnFoodAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodAdd.FillColor = System.Drawing.Color.Orange;
            this.btnFoodAdd.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodAdd.ForeColor = System.Drawing.Color.Black;
            this.btnFoodAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnFoodAdd.Image")));
            this.btnFoodAdd.Location = new System.Drawing.Point(1073, 250);
            this.btnFoodAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFoodAdd.Name = "btnFoodAdd";
            this.btnFoodAdd.Size = new System.Drawing.Size(157, 43);
            this.btnFoodAdd.TabIndex = 28;
            this.btnFoodAdd.Text = "料理追加";
            this.btnFoodAdd.Click += new System.EventHandler(this.btnFoodAdd_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BorderRadius = 15;
            this.btnDiscount.BorderThickness = 2;
            this.btnDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscount.FillColor = System.Drawing.Color.Orange;
            this.btnDiscount.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.Location = new System.Drawing.Point(889, 509);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(152, 43);
            this.btnDiscount.TabIndex = 35;
            this.btnDiscount.Text = "割引適用";
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.BorderRadius = 15;
            this.btnCashier.BorderThickness = 2;
            this.btnCashier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCashier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCashier.FillColor = System.Drawing.Color.Orange;
            this.btnCashier.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ForeColor = System.Drawing.Color.Black;
            this.btnCashier.Image = ((System.Drawing.Image)(resources.GetObject("btnCashier.Image")));
            this.btnCashier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCashier.Location = new System.Drawing.Point(1073, 509);
            this.btnCashier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(159, 43);
            this.btnCashier.TabIndex = 33;
            this.btnCashier.Text = "会計";
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // cboTableBase
            // 
            this.cboTableBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableBase.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTableBase.FormattingEnabled = true;
            this.cboTableBase.Location = new System.Drawing.Point(605, 507);
            this.cboTableBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTableBase.Name = "cboTableBase";
            this.cboTableBase.Size = new System.Drawing.Size(95, 28);
            this.cboTableBase.TabIndex = 31;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.aaa,
            this.Column2,
            this.Total,
            this.ColDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.Location = new System.Drawing.Point(605, 69);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(436, 410);
            this.dgvMain.TabIndex = 47;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "FoodName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "料理名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 108;
            // 
            // aaa
            // 
            this.aaa.DataPropertyName = "Price";
            this.aaa.HeaderText = "単価(税込)";
            this.aaa.MinimumWidth = 6;
            this.aaa.Name = "aaa";
            this.aaa.ReadOnly = true;
            this.aaa.Width = 115;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FoodCount";
            this.Column2.HeaderText = "数量";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "合計";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 70;
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "削除";
            this.ColDelete.MinimumWidth = 6;
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDelete.Text = "✕";
            this.ColDelete.ToolTipText = "✕";
            this.ColDelete.UseColumnTextForButtonValue = true;
            this.ColDelete.Width = 70;
            // 
            // txtCashier
            // 
            this.txtCashier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashier.DefaultText = "";
            this.txtCashier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCashier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCashier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCashier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCashier.ForeColor = System.Drawing.Color.Black;
            this.txtCashier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCashier.Location = new System.Drawing.Point(1074, 563);
            this.txtCashier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCashier.Name = "txtCashier";
            this.txtCashier.PasswordChar = '\0';
            this.txtCashier.PlaceholderText = "";
            this.txtCashier.SelectedText = "";
            this.txtCashier.Size = new System.Drawing.Size(152, 29);
            this.txtCashier.TabIndex = 48;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUserName.Location = new System.Drawing.Point(137, 574);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(59, 22);
            this.lblUserName.TabIndex = 49;
            this.lblUserName.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(12, 574);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "ログインユーザ：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1253, 605);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtCashier);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTableChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTableDestination);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrFoodNum);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboFoodName);
            this.Controls.Add(this.btnFoodAdd);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.cboTableBase);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "中華料理管理";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 予約リストToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アカウント情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 個人情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ログアウトToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnTableChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTableDestination;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmrFoodNum;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboFoodName;
        private Guna.UI2.WinForms.Guna2Button btnFoodAdd;
        private Guna.UI2.WinForms.Guna2Button btnDiscount;
        private Guna.UI2.WinForms.Guna2Button btnCashier;
        private System.Windows.Forms.ComboBox cboTableBase;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtCashier;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label8;
    }
}