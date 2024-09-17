namespace Book_Management_PhongLe
{
    partial class BookManagerMainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            grbSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtBookDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookDescription = new Label();
            lblBookName = new Label();
            btnCreate = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            btnback = new Button();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe Script", 36F, FontStyle.Bold);
            lblHeader.Location = new Point(0, -2);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(493, 99);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtBookDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookDescription);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            grbSearchCriteria.Location = new Point(12, 100);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(1112, 151);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = "Search Criteria";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(873, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(190, 38);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(585, 46);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(182, 38);
            txtBookDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(154, 46);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(182, 38);
            txtBookName.TabIndex = 0;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookDescription.Location = new Point(379, 53);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(200, 31);
            lblBookDescription.TabIndex = 4;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookName.Location = new Point(17, 53);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCreate.Location = new Point(885, 293);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(190, 38);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create A Book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnExit.Location = new Point(885, 551);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 38);
            btnExit.TabIndex = 4;
            btnExit.Text = "Quit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDelete.Location = new Point(885, 462);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 38);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete A Book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(885, 372);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 38);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update A Book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 293);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(857, 296);
            dgvBookList.TabIndex = 12;
            dgvBookList.CellClick += dgvBookList_CellClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblBookList.Location = new Point(12, 259);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(112, 31);
            lblBookList.TabIndex = 13;
            lblBookList.Text = "Book List";
            // 
            // btnback
            // 
            btnback.BackColor = Color.FromArgb(192, 192, 0);
            btnback.FlatStyle = FlatStyle.Flat;
            btnback.Location = new Point(12, 595);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 14;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1136, 646);
            Controls.Add(btnback);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            MaximizeBox = false;
            Name = "BookManagerMainUI";
            Text = "Book Manager";
            Load += BookManagerMainUI_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearchCriteria;
        private TextBox txtBookName;
        private Label lblBookDescription;
        private Label lblBookName;
        private TextBox txtBookDescription;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private Button btnback;
    }
}
