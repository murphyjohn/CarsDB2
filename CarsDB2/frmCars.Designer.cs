namespace CarsDB2
{
    partial class frmCars
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVehicleRegNo = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.lblDateRegistered = new System.Windows.Forms.Label();
            this.lblRentalPerDay = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtVehicleRegNo = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.txtDateRegistered = new System.Windows.Forms.TextBox();
            this.txtRentalPerDay = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtRecordCount = new System.Windows.Forms.TextBox();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(243, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(354, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bowman Car Hire";
            // 
            // lblVehicleRegNo
            // 
            this.lblVehicleRegNo.AutoSize = true;
            this.lblVehicleRegNo.Location = new System.Drawing.Point(59, 132);
            this.lblVehicleRegNo.Name = "lblVehicleRegNo";
            this.lblVehicleRegNo.Size = new System.Drawing.Size(188, 17);
            this.lblVehicleRegNo.TabIndex = 1;
            this.lblVehicleRegNo.Text = "Vehicle Registration Number";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(59, 187);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(42, 17);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make";
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(59, 242);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(83, 17);
            this.lblEngineSize.TabIndex = 3;
            this.lblEngineSize.Text = "Engine Size";
            // 
            // lblDateRegistered
            // 
            this.lblDateRegistered.AutoSize = true;
            this.lblDateRegistered.Location = new System.Drawing.Point(59, 297);
            this.lblDateRegistered.Name = "lblDateRegistered";
            this.lblDateRegistered.Size = new System.Drawing.Size(111, 17);
            this.lblDateRegistered.TabIndex = 4;
            this.lblDateRegistered.Text = "Date Registered";
            // 
            // lblRentalPerDay
            // 
            this.lblRentalPerDay.AutoSize = true;
            this.lblRentalPerDay.Location = new System.Drawing.Point(59, 352);
            this.lblRentalPerDay.Name = "lblRentalPerDay";
            this.lblRentalPerDay.Size = new System.Drawing.Size(104, 17);
            this.lblRentalPerDay.TabIndex = 5;
            this.lblRentalPerDay.Text = "Rental Per Day";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(59, 407);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(65, 17);
            this.lblAvailable.TabIndex = 6;
            this.lblAvailable.Text = "Available";
            // 
            // txtVehicleRegNo
            // 
            this.txtVehicleRegNo.Location = new System.Drawing.Point(318, 132);
            this.txtVehicleRegNo.Name = "txtVehicleRegNo";
            this.txtVehicleRegNo.Size = new System.Drawing.Size(113, 22);
            this.txtVehicleRegNo.TabIndex = 7;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(318, 187);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(190, 22);
            this.txtMake.TabIndex = 8;
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.Location = new System.Drawing.Point(318, 239);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(100, 22);
            this.txtEngineSize.TabIndex = 9;
            // 
            // txtDateRegistered
            // 
            this.txtDateRegistered.Location = new System.Drawing.Point(318, 292);
            this.txtDateRegistered.Name = "txtDateRegistered";
            this.txtDateRegistered.Size = new System.Drawing.Size(100, 22);
            this.txtDateRegistered.TabIndex = 10;
            this.tTip.SetToolTip(this.txtDateRegistered, "Enter the date in the format DD-MM-YYYY.");
            // 
            // txtRentalPerDay
            // 
            this.txtRentalPerDay.Location = new System.Drawing.Point(318, 352);
            this.txtRentalPerDay.Name = "txtRentalPerDay";
            this.txtRentalPerDay.Size = new System.Drawing.Size(100, 22);
            this.txtRentalPerDay.TabIndex = 11;
            this.txtRentalPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(318, 402);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(18, 17);
            this.chkAvailable.TabIndex = 12;
            this.tTip.SetToolTip(this.chkAvailable, "Tick this box if the Vehicle is currently available for hire.");
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(690, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 56);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(690, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 56);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(690, 291);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 56);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "&Search";
            this.tTip.SetToolTip(this.btnSearch, "Click here to bring up the Search window.");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(690, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 56);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(690, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 56);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(690, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 56);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(49, 495);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(118, 56);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(173, 495);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(118, 56);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(445, 495);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 56);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(569, 495);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(118, 56);
            this.btnLast.TabIndex = 22;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtRecordCount
            // 
            this.txtRecordCount.Location = new System.Drawing.Point(314, 512);
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(113, 22);
            this.txtRecordCount.TabIndex = 23;
            this.txtRecordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(837, 578);
            this.Controls.Add(this.txtRecordCount);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.txtRentalPerDay);
            this.Controls.Add(this.txtDateRegistered);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtVehicleRegNo);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblRentalPerDay);
            this.Controls.Add(this.lblDateRegistered);
            this.Controls.Add(this.lblEngineSize);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblVehicleRegNo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCars";
            this.Text = "Task A - John Murphy";
            this.Load += new System.EventHandler(this.frmCars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVehicleRegNo;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.Label lblDateRegistered;
        private System.Windows.Forms.Label lblRentalPerDay;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtVehicleRegNo;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.TextBox txtDateRegistered;
        private System.Windows.Forms.TextBox txtRentalPerDay;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtRecordCount;
        private System.Windows.Forms.ToolTip tTip;
    }
}

