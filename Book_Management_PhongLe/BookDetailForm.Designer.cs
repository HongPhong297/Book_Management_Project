namespace Book_Management_PhongLe
{
    partial class BookDetailForm
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
            grbBookInfo = new GroupBox();
            cboBookCaretoryID = new ComboBox();
            dtbPublicationDay = new DateTimePicker();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblCaretory = new Label();
            lblBookName = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblPublicationDay = new Label();
            lblDescription = new Label();
            txtQuantity = new TextBox();
            txtBookID = new TextBox();
            lblBookID = new Label();
            lblHeader = new Label();
            btnSave = new Button();
            btnExit = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCaretoryID);
            grbBookInfo.Controls.Add(dtbPublicationDay);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(lblCaretory);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDay);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtBookID);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            grbBookInfo.Location = new Point(12, 102);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(920, 507);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Info";
            // 
            // cboBookCaretoryID
            // 
            cboBookCaretoryID.FormattingEnabled = true;
            cboBookCaretoryID.Location = new Point(216, 437);
            cboBookCaretoryID.Name = "cboBookCaretoryID";
            cboBookCaretoryID.Size = new Size(196, 39);
            cboBookCaretoryID.TabIndex = 7;
            // 
            // dtbPublicationDay
            // 
            dtbPublicationDay.Format = DateTimePickerFormat.Short;
            dtbPublicationDay.Location = new Point(216, 263);
            dtbPublicationDay.Name = "dtbPublicationDay";
            dtbPublicationDay.Size = new Size(151, 38);
            dtbPublicationDay.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(216, 375);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(698, 38);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(606, 263);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(182, 38);
            txtPrice.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(216, 142);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(698, 101);
            txtDescription.TabIndex = 2;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(216, 91);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(698, 38);
            txtBookName.TabIndex = 1;
            // 
            // lblCaretory
            // 
            lblCaretory.AutoSize = true;
            lblCaretory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCaretory.Location = new Point(17, 440);
            lblCaretory.Name = "lblCaretory";
            lblCaretory.Size = new Size(106, 31);
            lblCaretory.TabIndex = 11;
            lblCaretory.Text = "Caretory";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookName.Location = new Point(17, 98);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 10;
            lblBookName.Text = "Book Name";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblAuthor.Location = new Point(17, 382);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(90, 31);
            lblAuthor.TabIndex = 9;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPrice.Location = new Point(533, 270);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(67, 31);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblQuantity.Location = new Point(17, 322);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(108, 31);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // lblPublicationDay
            // 
            lblPublicationDay.AutoSize = true;
            lblPublicationDay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPublicationDay.Location = new Point(17, 270);
            lblPublicationDay.Name = "lblPublicationDay";
            lblPublicationDay.Size = new Size(193, 31);
            lblPublicationDay.TabIndex = 6;
            lblPublicationDay.Text = "Publication Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDescription.Location = new Point(17, 149);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 31);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(216, 315);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(148, 38);
            txtQuantity.TabIndex = 5;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(216, 37);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(698, 38);
            txtBookID.TabIndex = 0;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookID.Location = new Point(17, 46);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(100, 31);
            lblBookID.TabIndex = 3;
            lblBookID.Text = "Book ID";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe Script", 36F, FontStyle.Bold);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(466, 99);
            lblHeader.TabIndex = 7;
            lblHeader.Text = "Add | Update";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSave.Location = new Point(938, 118);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 38);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnExit.Location = new Point(938, 192);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 38);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1136, 664);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(lblHeader);
            Controls.Add(grbBookInfo);
            Name = "BookDetailForm";
            Text = "Add | Update";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbBookInfo;
        private TextBox txtQuantity;
        private TextBox txtBookID;
        private Label lblBookID;
        private Label lblHeader;
        private Label lblCaretory;
        private Label lblBookName;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblPublicationDay;
        private Label lblDescription;
        private TextBox txtBookName;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnExit;
        private TextBox txtPrice;
        private TextBox txtAuthor;
        private DateTimePicker dtbPublicationDay;
        private ComboBox cboBookCaretoryID;
    }
}