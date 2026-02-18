namespace SubwayPOSManagementSystem
{
    partial class JagSubs
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
            this.ProcessOrder = new System.Windows.Forms.TabControl();
            this.tbpProcessOrder = new System.Windows.Forms.TabPage();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.lstVeggies = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbChicken = new System.Windows.Forms.RadioButton();
            this.rdbTurkey = new System.Windows.Forms.RadioButton();
            this.rdbHam = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbItalian = new System.Windows.Forms.RadioButton();
            this.rdbSourDough = new System.Windows.Forms.RadioButton();
            this.rdbWholeGrain = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDouble = new System.Windows.Forms.RadioButton();
            this.rdbWhole = new System.Windows.Forms.RadioButton();
            this.rdbHalf = new System.Windows.Forms.RadioButton();
            this.rdbKids = new System.Windows.Forms.RadioButton();
            this.lblSandwiches = new System.Windows.Forms.Label();
            this.hsbSandwiches = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.tbpReceipt = new System.Windows.Forms.TabPage();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.tbpNewCustomer = new System.Windows.Forms.TabPage();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessOrder.SuspendLayout();
            this.tbpProcessOrder.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpReceipt.SuspendLayout();
            this.tbpNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessOrder
            // 
            this.ProcessOrder.Controls.Add(this.tbpProcessOrder);
            this.ProcessOrder.Controls.Add(this.tbpReceipt);
            this.ProcessOrder.Controls.Add(this.tbpNewCustomer);
            this.ProcessOrder.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessOrder.Location = new System.Drawing.Point(46, 73);
            this.ProcessOrder.Name = "ProcessOrder";
            this.ProcessOrder.SelectedIndex = 0;
            this.ProcessOrder.Size = new System.Drawing.Size(1361, 1059);
            this.ProcessOrder.TabIndex = 0;
            // 
            // tbpProcessOrder
            // 
            this.tbpProcessOrder.Controls.Add(this.chkCheese);
            this.tbpProcessOrder.Controls.Add(this.lstVeggies);
            this.tbpProcessOrder.Controls.Add(this.btnClear);
            this.tbpProcessOrder.Controls.Add(this.btnReceipt);
            this.tbpProcessOrder.Controls.Add(this.chkStudent);
            this.tbpProcessOrder.Controls.Add(this.chkDelivery);
            this.tbpProcessOrder.Controls.Add(this.groupBox3);
            this.tbpProcessOrder.Controls.Add(this.groupBox2);
            this.tbpProcessOrder.Controls.Add(this.groupBox1);
            this.tbpProcessOrder.Controls.Add(this.lblSandwiches);
            this.tbpProcessOrder.Controls.Add(this.hsbSandwiches);
            this.tbpProcessOrder.Controls.Add(this.label1);
            this.tbpProcessOrder.Controls.Add(this.cboCustomer);
            this.tbpProcessOrder.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpProcessOrder.Location = new System.Drawing.Point(8, 40);
            this.tbpProcessOrder.Name = "tbpProcessOrder";
            this.tbpProcessOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProcessOrder.Size = new System.Drawing.Size(1345, 1011);
            this.tbpProcessOrder.TabIndex = 0;
            this.tbpProcessOrder.Text = "ProcessOrder";
            this.tbpProcessOrder.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(591, 581);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(201, 30);
            this.chkCheese.TabIndex = 13;
            this.chkCheese.Text = "Cheese Added?";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // lstVeggies
            // 
            this.lstVeggies.Font = new System.Drawing.Font("Courier New", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVeggies.FormattingEnabled = true;
            this.lstVeggies.ItemHeight = 32;
            this.lstVeggies.Location = new System.Drawing.Point(806, 175);
            this.lstVeggies.Name = "lstVeggies";
            this.lstVeggies.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstVeggies.Size = new System.Drawing.Size(502, 740);
            this.lstVeggies.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(413, 831);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(229, 93);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(55, 831);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(272, 93);
            this.btnReceipt.TabIndex = 9;
            this.btnReceipt.Text = "Print Reciept";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(389, 707);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(124, 30);
            this.chkStudent.TabIndex = 8;
            this.chkStudent.Text = "Student";
            this.chkStudent.UseVisualStyleBackColor = true;
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Location = new System.Drawing.Point(55, 707);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(280, 30);
            this.chkDelivery.TabIndex = 7;
            this.chkDelivery.Text = "Delivery ($5.00 Charge)";
            this.chkDelivery.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbChicken);
            this.groupBox3.Controls.Add(this.rdbTurkey);
            this.groupBox3.Controls.Add(this.rdbHam);
            this.groupBox3.Location = new System.Drawing.Point(55, 538);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meat";
            // 
            // rdbChicken
            // 
            this.rdbChicken.AutoSize = true;
            this.rdbChicken.Location = new System.Drawing.Point(338, 31);
            this.rdbChicken.Name = "rdbChicken";
            this.rdbChicken.Size = new System.Drawing.Size(124, 30);
            this.rdbChicken.TabIndex = 2;
            this.rdbChicken.TabStop = true;
            this.rdbChicken.Text = "Chicken";
            this.rdbChicken.UseVisualStyleBackColor = true;
            // 
            // rdbTurkey
            // 
            this.rdbTurkey.AutoSize = true;
            this.rdbTurkey.Location = new System.Drawing.Point(177, 30);
            this.rdbTurkey.Name = "rdbTurkey";
            this.rdbTurkey.Size = new System.Drawing.Size(111, 30);
            this.rdbTurkey.TabIndex = 1;
            this.rdbTurkey.TabStop = true;
            this.rdbTurkey.Text = "Turkey";
            this.rdbTurkey.UseVisualStyleBackColor = true;
            // 
            // rdbHam
            // 
            this.rdbHam.AutoSize = true;
            this.rdbHam.Location = new System.Drawing.Point(30, 31);
            this.rdbHam.Name = "rdbHam";
            this.rdbHam.Size = new System.Drawing.Size(92, 30);
            this.rdbHam.TabIndex = 0;
            this.rdbHam.TabStop = true;
            this.rdbHam.Text = "Ham";
            this.rdbHam.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbItalian);
            this.groupBox2.Controls.Add(this.rdbSourDough);
            this.groupBox2.Controls.Add(this.rdbWholeGrain);
            this.groupBox2.Location = new System.Drawing.Point(46, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bread Type";
            // 
            // rdbItalian
            // 
            this.rdbItalian.AutoSize = true;
            this.rdbItalian.Location = new System.Drawing.Point(522, 42);
            this.rdbItalian.Name = "rdbItalian";
            this.rdbItalian.Size = new System.Drawing.Size(106, 30);
            this.rdbItalian.TabIndex = 2;
            this.rdbItalian.TabStop = true;
            this.rdbItalian.Text = "Italian";
            this.rdbItalian.UseVisualStyleBackColor = true;
            // 
            // rdbSourDough
            // 
            this.rdbSourDough.AutoSize = true;
            this.rdbSourDough.Location = new System.Drawing.Point(338, 42);
            this.rdbSourDough.Name = "rdbSourDough";
            this.rdbSourDough.Size = new System.Drawing.Size(165, 30);
            this.rdbSourDough.TabIndex = 1;
            this.rdbSourDough.TabStop = true;
            this.rdbSourDough.Text = "Sour Dough";
            this.rdbSourDough.UseVisualStyleBackColor = true;
            // 
            // rdbWholeGrain
            // 
            this.rdbWholeGrain.AutoSize = true;
            this.rdbWholeGrain.Location = new System.Drawing.Point(30, 42);
            this.rdbWholeGrain.Name = "rdbWholeGrain";
            this.rdbWholeGrain.Size = new System.Drawing.Size(302, 30);
            this.rdbWholeGrain.TabIndex = 0;
            this.rdbWholeGrain.TabStop = true;
            this.rdbWholeGrain.Text = "Whole Grain ($2.00 Extra)";
            this.rdbWholeGrain.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDouble);
            this.groupBox1.Controls.Add(this.rdbWhole);
            this.groupBox1.Controls.Add(this.rdbHalf);
            this.groupBox1.Controls.Add(this.rdbKids);
            this.groupBox1.Location = new System.Drawing.Point(46, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rdbDouble
            // 
            this.rdbDouble.AutoSize = true;
            this.rdbDouble.Location = new System.Drawing.Point(531, 31);
            this.rdbDouble.Name = "rdbDouble";
            this.rdbDouble.Size = new System.Drawing.Size(207, 30);
            this.rdbDouble.TabIndex = 3;
            this.rdbDouble.TabStop = true;
            this.rdbDouble.Text = "Double ($12.00)";
            this.rdbDouble.UseVisualStyleBackColor = true;
            // 
            // rdbWhole
            // 
            this.rdbWhole.AutoSize = true;
            this.rdbWhole.Location = new System.Drawing.Point(347, 31);
            this.rdbWhole.Name = "rdbWhole";
            this.rdbWhole.Size = new System.Drawing.Size(186, 30);
            this.rdbWhole.TabIndex = 2;
            this.rdbWhole.TabStop = true;
            this.rdbWhole.Text = "Whole ($9.00)";
            this.rdbWhole.UseVisualStyleBackColor = true;
            // 
            // rdbHalf
            // 
            this.rdbHalf.AutoSize = true;
            this.rdbHalf.Location = new System.Drawing.Point(186, 30);
            this.rdbHalf.Name = "rdbHalf";
            this.rdbHalf.Size = new System.Drawing.Size(162, 30);
            this.rdbHalf.TabIndex = 1;
            this.rdbHalf.TabStop = true;
            this.rdbHalf.Text = "Half ($7.00)";
            this.rdbHalf.UseVisualStyleBackColor = true;
            // 
            // rdbKids
            // 
            this.rdbKids.AutoSize = true;
            this.rdbKids.Location = new System.Drawing.Point(21, 31);
            this.rdbKids.Name = "rdbKids";
            this.rdbKids.Size = new System.Drawing.Size(163, 30);
            this.rdbKids.TabIndex = 0;
            this.rdbKids.TabStop = true;
            this.rdbKids.Text = "Kids ($5.00)";
            this.rdbKids.UseVisualStyleBackColor = true;
            // 
            // lblSandwiches
            // 
            this.lblSandwiches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSandwiches.Location = new System.Drawing.Point(529, 144);
            this.lblSandwiches.Name = "lblSandwiches";
            this.lblSandwiches.Size = new System.Drawing.Size(113, 32);
            this.lblSandwiches.TabIndex = 3;
            this.lblSandwiches.Click += new System.EventHandler(this.lblSandwiches_Click);
            // 
            // hsbSandwiches
            // 
            this.hsbSandwiches.LargeChange = 1;
            this.hsbSandwiches.Location = new System.Drawing.Point(310, 141);
            this.hsbSandwiches.Maximum = 10;
            this.hsbSandwiches.Name = "hsbSandwiches";
            this.hsbSandwiches.Size = new System.Drawing.Size(203, 35);
            this.hsbSandwiches.TabIndex = 2;
            this.hsbSandwiches.ValueChanged += new System.EventHandler(this.hsbSandwiches_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Of Sandwiches:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(31, 50);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(374, 34);
            this.cboCustomer.TabIndex = 0;
            // 
            // tbpReceipt
            // 
            this.tbpReceipt.Controls.Add(this.lstDisplay);
            this.tbpReceipt.Location = new System.Drawing.Point(8, 40);
            this.tbpReceipt.Name = "tbpReceipt";
            this.tbpReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReceipt.Size = new System.Drawing.Size(1345, 1011);
            this.tbpReceipt.TabIndex = 1;
            this.tbpReceipt.Text = "Receipt";
            this.tbpReceipt.UseVisualStyleBackColor = true;
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 30;
            this.lstDisplay.Location = new System.Drawing.Point(74, 51);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(1170, 874);
            this.lstDisplay.TabIndex = 0;
            // 
            // tbpNewCustomer
            // 
            this.tbpNewCustomer.Controls.Add(this.btnSaveCustomer);
            this.tbpNewCustomer.Controls.Add(this.txtPhoneNumber);
            this.tbpNewCustomer.Controls.Add(this.txtZipCode);
            this.tbpNewCustomer.Controls.Add(this.txtAddress);
            this.tbpNewCustomer.Controls.Add(this.txtName);
            this.tbpNewCustomer.Controls.Add(this.label6);
            this.tbpNewCustomer.Controls.Add(this.label5);
            this.tbpNewCustomer.Controls.Add(this.label4);
            this.tbpNewCustomer.Controls.Add(this.label3);
            this.tbpNewCustomer.Font = new System.Drawing.Font("Courier New", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpNewCustomer.Location = new System.Drawing.Point(8, 40);
            this.tbpNewCustomer.Name = "tbpNewCustomer";
            this.tbpNewCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNewCustomer.Size = new System.Drawing.Size(1345, 1011);
            this.tbpNewCustomer.TabIndex = 2;
            this.tbpNewCustomer.Text = "New Customer";
            this.tbpNewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(176, 509);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(369, 98);
            this.btnSaveCustomer.TabIndex = 8;
            this.btnSaveCustomer.Text = "Save Customer";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(429, 381);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(286, 38);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(429, 299);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(286, 38);
            this.txtZipCode.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(429, 193);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(286, 38);
            this.txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(429, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 38);
            this.txtName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Zip Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Street Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(880, 1131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "KARRA SATISH BABU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // JagSubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 1190);
            this.Controls.Add(this.ProcessOrder);
            this.Controls.Add(this.label2);
            this.Name = "JagSubs";
            this.Text = "Jaguar Subway";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JagSubs_FormClosing);
            this.Load += new System.EventHandler(this.JagSubs_Load);
            this.ProcessOrder.ResumeLayout(false);
            this.tbpProcessOrder.ResumeLayout(false);
            this.tbpProcessOrder.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpReceipt.ResumeLayout(false);
            this.tbpNewCustomer.ResumeLayout(false);
            this.tbpNewCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProcessOrder;
        private System.Windows.Forms.TabPage tbpProcessOrder;
        private System.Windows.Forms.TabPage tbpReceipt;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TabPage tbpNewCustomer;
        private System.Windows.Forms.HScrollBar hsbSandwiches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSandwiches;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbDouble;
        private System.Windows.Forms.RadioButton rdbWhole;
        private System.Windows.Forms.RadioButton rdbHalf;
        private System.Windows.Forms.RadioButton rdbKids;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbItalian;
        private System.Windows.Forms.RadioButton rdbSourDough;
        private System.Windows.Forms.RadioButton rdbWholeGrain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbChicken;
        private System.Windows.Forms.RadioButton rdbTurkey;
        private System.Windows.Forms.RadioButton rdbHam;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.ListBox lstVeggies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
    }
}

