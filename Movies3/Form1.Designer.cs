namespace Movies3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DVCustomer = new System.Windows.Forms.DataGridView();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.ListBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.DVMovies = new System.Windows.Forms.DataGridView();
            this.lblMovies = new System.Windows.Forms.Label();
            this.lblRented = new System.Windows.Forms.Label();
            this.DVRentedMovies = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRental_Cost = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtGenre1 = new System.Windows.Forms.TextBox();
            this.txtRMID = new System.Windows.Forms.TextBox();
            this.txtCustFKID = new System.Windows.Forms.TextBox();
            this.txtMoviesFKID = new System.Windows.Forms.TextBox();
            this.txtDateRented = new System.Windows.Forms.TextBox();
            this.txtDateRetured = new System.Windows.Forms.TextBox();
            this.lblMoviesID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddM = new System.Windows.Forms.Button();
            this.btnDeleteM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVRentedMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // DVCustomer
            // 
            this.DVCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVCustomer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DVCustomer.Location = new System.Drawing.Point(31, 25);
            this.DVCustomer.Name = "DVCustomer";
            this.DVCustomer.Size = new System.Drawing.Size(541, 150);
            this.DVCustomer.TabIndex = 0;
            this.DVCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVCustomer_CellcontentClick);
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.BackColor = System.Drawing.Color.White;
            this.lblcustomer.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer.Location = new System.Drawing.Point(25, 9);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(67, 15);
            this.lblcustomer.TabIndex = 1;
            this.lblcustomer.Text = "Customers";
            // 
            // lbGenre
            // 
            this.lbGenre.FormattingEnabled = true;
            this.lbGenre.Location = new System.Drawing.Point(893, 40);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(120, 95);
            this.lbGenre.TabIndex = 2;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(913, 155);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 3;
            // 
            // DVMovies
            // 
            this.DVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVMovies.Location = new System.Drawing.Point(28, 376);
            this.DVMovies.Name = "DVMovies";
            this.DVMovies.Size = new System.Drawing.Size(877, 150);
            this.DVMovies.TabIndex = 4;
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.BackColor = System.Drawing.Color.White;
            this.lblMovies.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovies.Location = new System.Drawing.Point(28, 360);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(45, 15);
            this.lblMovies.TabIndex = 5;
            this.lblMovies.Text = "Movies";
            this.lblMovies.Click += new System.EventHandler(this.lblMovies_Click);
            // 
            // lblRented
            // 
            this.lblRented.AutoSize = true;
            this.lblRented.BackColor = System.Drawing.Color.White;
            this.lblRented.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRented.Location = new System.Drawing.Point(28, 182);
            this.lblRented.Name = "lblRented";
            this.lblRented.Size = new System.Drawing.Size(86, 15);
            this.lblRented.TabIndex = 6;
            this.lblRented.Text = "Rented Movies";
            // 
            // DVRentedMovies
            // 
            this.DVRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVRentedMovies.Location = new System.Drawing.Point(28, 198);
            this.DVRentedMovies.Name = "DVRentedMovies";
            this.DVRentedMovies.Size = new System.Drawing.Size(396, 150);
            this.DVRentedMovies.TabIndex = 7;
            this.DVRentedMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVRentedMovies_CellContentClick);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(113, 569);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(114, 553);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(25, 569);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(56, 20);
            this.txtCustID.TabIndex = 8;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(26, 553);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(42, 13);
            this.lblCustID.TabIndex = 9;
            this.lblCustID.Text = "Cust ID";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(247, 553);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(245, 569);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(379, 569);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(576, 569);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(381, 553);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(576, 553);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(753, 566);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(843, 566);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(934, 566);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(25, 618);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(56, 20);
            this.txtMovieID.TabIndex = 15;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(92, 618);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(56, 20);
            this.txtRating.TabIndex = 15;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(162, 618);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(113, 20);
            this.txtTitle.TabIndex = 15;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(293, 618);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(56, 20);
            this.txtYear.TabIndex = 15;
            // 
            // txtRental_Cost
            // 
            this.txtRental_Cost.Location = new System.Drawing.Point(368, 618);
            this.txtRental_Cost.Name = "txtRental_Cost";
            this.txtRental_Cost.Size = new System.Drawing.Size(56, 20);
            this.txtRental_Cost.TabIndex = 15;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(450, 618);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(56, 20);
            this.txtCopies.TabIndex = 15;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(525, 618);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(141, 20);
            this.txtPlot.TabIndex = 15;
            // 
            // txtGenre1
            // 
            this.txtGenre1.Location = new System.Drawing.Point(686, 618);
            this.txtGenre1.Name = "txtGenre1";
            this.txtGenre1.Size = new System.Drawing.Size(89, 20);
            this.txtGenre1.TabIndex = 15;
            // 
            // txtRMID
            // 
            this.txtRMID.Location = new System.Drawing.Point(25, 670);
            this.txtRMID.Name = "txtRMID";
            this.txtRMID.Size = new System.Drawing.Size(100, 20);
            this.txtRMID.TabIndex = 16;
            // 
            // txtCustFKID
            // 
            this.txtCustFKID.Location = new System.Drawing.Point(310, 670);
            this.txtCustFKID.Name = "txtCustFKID";
            this.txtCustFKID.Size = new System.Drawing.Size(100, 20);
            this.txtCustFKID.TabIndex = 16;
            // 
            // txtMoviesFKID
            // 
            this.txtMoviesFKID.Location = new System.Drawing.Point(168, 670);
            this.txtMoviesFKID.Name = "txtMoviesFKID";
            this.txtMoviesFKID.Size = new System.Drawing.Size(100, 20);
            this.txtMoviesFKID.TabIndex = 16;
            // 
            // txtDateRented
            // 
            this.txtDateRented.Location = new System.Drawing.Point(458, 670);
            this.txtDateRented.Name = "txtDateRented";
            this.txtDateRented.Size = new System.Drawing.Size(100, 20);
            this.txtDateRented.TabIndex = 16;
            // 
            // txtDateRetured
            // 
            this.txtDateRetured.Location = new System.Drawing.Point(604, 670);
            this.txtDateRetured.Name = "txtDateRetured";
            this.txtDateRetured.Size = new System.Drawing.Size(100, 20);
            this.txtDateRetured.TabIndex = 16;
            // 
            // lblMoviesID
            // 
            this.lblMoviesID.AutoSize = true;
            this.lblMoviesID.Location = new System.Drawing.Point(25, 602);
            this.lblMoviesID.Name = "lblMoviesID";
            this.lblMoviesID.Size = new System.Drawing.Size(55, 13);
            this.lblMoviesID.TabIndex = 17;
            this.lblMoviesID.Text = "Movies ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rental_Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Copies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Plot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 602);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Genre";
            // 
            // btnAddM
            // 
            this.btnAddM.Location = new System.Drawing.Point(796, 615);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(96, 23);
            this.btnAddM.TabIndex = 18;
            this.btnAddM.Text = "Add Movies";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // btnDeleteM
            // 
            this.btnDeleteM.Location = new System.Drawing.Point(913, 615);
            this.btnDeleteM.Name = "btnDeleteM";
            this.btnDeleteM.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteM.TabIndex = 18;
            this.btnDeleteM.Text = "Delete Movies";
            this.btnDeleteM.UseVisualStyleBackColor = true;
            this.btnDeleteM.Click += new System.EventHandler(this.btnDeleteM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 654);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "RMID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 654);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "MovieIDFK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "CustIDFK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(459, 654);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Date Rented";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(606, 654);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Date Retured";
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(753, 667);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(75, 43);
            this.btnIssue.TabIndex = 20;
            this.btnIssue.Text = "Issue Movies";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(873, 667);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 43);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return Movies";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 722);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteM);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMoviesID);
            this.Controls.Add(this.txtDateRetured);
            this.Controls.Add(this.txtDateRented);
            this.Controls.Add(this.txtMoviesFKID);
            this.Controls.Add(this.txtCustFKID);
            this.Controls.Add(this.txtRMID);
            this.Controls.Add(this.txtGenre1);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtRental_Cost);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.DVRentedMovies);
            this.Controls.Add(this.lblRented);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.DVMovies);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lblcustomer);
            this.Controls.Add(this.DVCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVRentedMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DVCustomer;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.ListBox lbGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.DataGridView DVMovies;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Label lblRented;
        private System.Windows.Forms.DataGridView DVRentedMovies;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRental_Cost;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtGenre1;
        private System.Windows.Forms.TextBox txtRMID;
        private System.Windows.Forms.TextBox txtCustFKID;
        private System.Windows.Forms.TextBox txtMoviesFKID;
        private System.Windows.Forms.TextBox txtDateRented;
        private System.Windows.Forms.TextBox txtDateRetured;
        private System.Windows.Forms.Label lblMoviesID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.Button btnDeleteM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;
    }
}

