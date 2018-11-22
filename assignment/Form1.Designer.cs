namespace assignment
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
            this.grpdevice = new System.Windows.Forms.GroupBox();
            this.btnDsearch = new System.Windows.Forms.Button();
            this.btnDadd = new System.Windows.Forms.Button();
            this.btnDedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.grpswitch = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnSadd = new System.Windows.Forms.Button();
            this.btnSedit = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.lstcomments = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDtype = new System.Windows.Forms.TextBox();
            this.txtDloc = new System.Windows.Forms.TextBox();
            this.txtDmanufaturer = new System.Windows.Forms.TextBox();
            this.txtDmodel = new System.Windows.Forms.TextBox();
            this.txtDserialnum = new System.Windows.Forms.TextBox();
            this.txtDdate = new System.Windows.Forms.TextBox();
            this.txtDcomments = new System.Windows.Forms.TextBox();
            this.txtSdate = new System.Windows.Forms.TextBox();
            this.txtSlast = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.txtSserialnum = new System.Windows.Forms.TextBox();
            this.lbldevice = new System.Windows.Forms.Label();
            this.lblswitch = new System.Windows.Forms.Label();
            this.lstdevice = new System.Windows.Forms.ListBox();
            this.lstswitch = new System.Windows.Forms.ListBox();
            this.txtSdevices = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grpdevice.SuspendLayout();
            this.grpswitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpdevice
            // 
            this.grpdevice.Controls.Add(this.btnDsearch);
            this.grpdevice.Controls.Add(this.btnDadd);
            this.grpdevice.Controls.Add(this.btnDedit);
            this.grpdevice.Controls.Add(this.btndelete);
            this.grpdevice.Location = new System.Drawing.Point(29, 370);
            this.grpdevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpdevice.Name = "grpdevice";
            this.grpdevice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpdevice.Size = new System.Drawing.Size(139, 188);
            this.grpdevice.TabIndex = 133;
            this.grpdevice.TabStop = false;
            this.grpdevice.Text = "options";
            // 
            // btnDsearch
            // 
            this.btnDsearch.Location = new System.Drawing.Point(15, 28);
            this.btnDsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDsearch.Name = "btnDsearch";
            this.btnDsearch.Size = new System.Drawing.Size(113, 31);
            this.btnDsearch.TabIndex = 31;
            this.btnDsearch.Text = "Search";
            this.btnDsearch.UseVisualStyleBackColor = true;
            // 
            // btnDadd
            // 
            this.btnDadd.Location = new System.Drawing.Point(15, 65);
            this.btnDadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDadd.Name = "btnDadd";
            this.btnDadd.Size = new System.Drawing.Size(113, 31);
            this.btnDadd.TabIndex = 32;
            this.btnDadd.Text = "Add";
            this.btnDadd.UseVisualStyleBackColor = true;
            this.btnDadd.Click += new System.EventHandler(this.btnDadd_Click);
            // 
            // btnDedit
            // 
            this.btnDedit.Location = new System.Drawing.Point(15, 102);
            this.btnDedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDedit.Name = "btnDedit";
            this.btnDedit.Size = new System.Drawing.Size(113, 31);
            this.btnDedit.TabIndex = 33;
            this.btnDedit.Text = "Edit";
            this.btnDedit.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(15, 139);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(113, 31);
            this.btndelete.TabIndex = 34;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // grpswitch
            // 
            this.grpswitch.Controls.Add(this.btnsearch);
            this.grpswitch.Controls.Add(this.btnSadd);
            this.grpswitch.Controls.Add(this.btnSedit);
            this.grpswitch.Location = new System.Drawing.Point(29, 89);
            this.grpswitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpswitch.Name = "grpswitch";
            this.grpswitch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpswitch.Size = new System.Drawing.Size(143, 135);
            this.grpswitch.TabIndex = 132;
            this.grpswitch.TabStop = false;
            this.grpswitch.Text = "options";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(15, 25);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(113, 33);
            this.btnsearch.TabIndex = 28;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnSadd
            // 
            this.btnSadd.Location = new System.Drawing.Point(15, 63);
            this.btnSadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSadd.Name = "btnSadd";
            this.btnSadd.Size = new System.Drawing.Size(113, 31);
            this.btnSadd.TabIndex = 29;
            this.btnSadd.Text = "Add";
            this.btnSadd.UseVisualStyleBackColor = true;
            this.btnSadd.Click += new System.EventHandler(this.btnSadd_Click);
            // 
            // btnSedit
            // 
            this.btnSedit.Location = new System.Drawing.Point(15, 100);
            this.btnSedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSedit.Name = "btnSedit";
            this.btnSedit.Size = new System.Drawing.Size(113, 31);
            this.btnSedit.TabIndex = 30;
            this.btnSedit.Text = "Edit";
            this.btnSedit.UseVisualStyleBackColor = true;
            this.btnSedit.Click += new System.EventHandler(this.btnSedit_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(229, 592);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(205, 48);
            this.btnexit.TabIndex = 131;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Unmanaged",
            "Managed",
            "Smart",
            "Enterprise Managed\t"});
            this.cmbtype.Location = new System.Drawing.Point(375, 116);
            this.cmbtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(220, 24);
            this.cmbtype.TabIndex = 108;
            this.cmbtype.Text = " ";
            // 
            // lstcomments
            // 
            this.lstcomments.FormattingEnabled = true;
            this.lstcomments.ItemHeight = 16;
            this.lstcomments.Location = new System.Drawing.Point(700, 572);
            this.lstcomments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstcomments.Name = "lstcomments";
            this.lstcomments.Size = new System.Drawing.Size(983, 68);
            this.lstcomments.TabIndex = 105;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(196, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 130;
            this.label12.Text = "Type of device:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(196, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 129;
            this.label11.Text = "Location of device:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(196, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 128;
            this.label10.Text = "Manufacturer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(196, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 127;
            this.label9.Text = "Model:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(196, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 126;
            this.label8.Text = "Serial number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 125;
            this.label7.Text = "PAT date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 124;
            this.label6.Text = "PAT comments:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 123;
            this.label5.Text = "Switch type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 122;
            this.label4.Text = "Date installed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 121;
            this.label3.Text = "Date last tested:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 120;
            this.label2.Text = "ID of PAT staff:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "Serial number:";
            // 
            // txtDtype
            // 
            this.txtDtype.Location = new System.Drawing.Point(375, 370);
            this.txtDtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDtype.Name = "txtDtype";
            this.txtDtype.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDtype.Size = new System.Drawing.Size(220, 22);
            this.txtDtype.TabIndex = 112;
            this.txtDtype.Text = ",";
            // 
            // txtDloc
            // 
            this.txtDloc.Location = new System.Drawing.Point(375, 399);
            this.txtDloc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDloc.Name = "txtDloc";
            this.txtDloc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDloc.Size = new System.Drawing.Size(220, 22);
            this.txtDloc.TabIndex = 113;
            // 
            // txtDmanufaturer
            // 
            this.txtDmanufaturer.Location = new System.Drawing.Point(375, 427);
            this.txtDmanufaturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDmanufaturer.Name = "txtDmanufaturer";
            this.txtDmanufaturer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDmanufaturer.Size = new System.Drawing.Size(220, 22);
            this.txtDmanufaturer.TabIndex = 114;
            // 
            // txtDmodel
            // 
            this.txtDmodel.Location = new System.Drawing.Point(375, 455);
            this.txtDmodel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDmodel.Name = "txtDmodel";
            this.txtDmodel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDmodel.Size = new System.Drawing.Size(220, 22);
            this.txtDmodel.TabIndex = 115;
            // 
            // txtDserialnum
            // 
            this.txtDserialnum.Location = new System.Drawing.Point(375, 482);
            this.txtDserialnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDserialnum.Name = "txtDserialnum";
            this.txtDserialnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDserialnum.Size = new System.Drawing.Size(220, 22);
            this.txtDserialnum.TabIndex = 116;
            // 
            // txtDdate
            // 
            this.txtDdate.Location = new System.Drawing.Point(375, 511);
            this.txtDdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDdate.Name = "txtDdate";
            this.txtDdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDdate.Size = new System.Drawing.Size(220, 22);
            this.txtDdate.TabIndex = 117;
            // 
            // txtDcomments
            // 
            this.txtDcomments.Location = new System.Drawing.Point(375, 539);
            this.txtDcomments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDcomments.Name = "txtDcomments";
            this.txtDcomments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDcomments.Size = new System.Drawing.Size(220, 22);
            this.txtDcomments.TabIndex = 118;
            // 
            // txtSdate
            // 
            this.txtSdate.Location = new System.Drawing.Point(375, 146);
            this.txtSdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSdate.Name = "txtSdate";
            this.txtSdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSdate.Size = new System.Drawing.Size(220, 22);
            this.txtSdate.TabIndex = 109;
            // 
            // txtSlast
            // 
            this.txtSlast.Location = new System.Drawing.Point(375, 174);
            this.txtSlast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlast.Name = "txtSlast";
            this.txtSlast.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSlast.Size = new System.Drawing.Size(220, 22);
            this.txtSlast.TabIndex = 110;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(375, 202);
            this.txtSid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSid.Name = "txtSid";
            this.txtSid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSid.Size = new System.Drawing.Size(220, 22);
            this.txtSid.TabIndex = 111;
            // 
            // txtSserialnum
            // 
            this.txtSserialnum.Location = new System.Drawing.Point(375, 89);
            this.txtSserialnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSserialnum.Name = "txtSserialnum";
            this.txtSserialnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSserialnum.Size = new System.Drawing.Size(220, 22);
            this.txtSserialnum.TabIndex = 107;
            // 
            // lbldevice
            // 
            this.lbldevice.AutoSize = true;
            this.lbldevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldevice.Location = new System.Drawing.Point(181, 304);
            this.lbldevice.Name = "lbldevice";
            this.lbldevice.Size = new System.Drawing.Size(124, 36);
            this.lbldevice.TabIndex = 106;
            this.lbldevice.Text = "devices:";
            // 
            // lblswitch
            // 
            this.lblswitch.AutoSize = true;
            this.lblswitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblswitch.Location = new System.Drawing.Point(163, 18);
            this.lblswitch.Name = "lblswitch";
            this.lblswitch.Size = new System.Drawing.Size(143, 36);
            this.lblswitch.TabIndex = 104;
            this.lblswitch.Text = "Switches:";
            // 
            // lstdevice
            // 
            this.lstdevice.FormattingEnabled = true;
            this.lstdevice.ItemHeight = 16;
            this.lstdevice.Location = new System.Drawing.Point(699, 370);
            this.lstdevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstdevice.Name = "lstdevice";
            this.lstdevice.Size = new System.Drawing.Size(984, 180);
            this.lstdevice.TabIndex = 103;
            // 
            // lstswitch
            // 
            this.lstswitch.FormattingEnabled = true;
            this.lstswitch.ItemHeight = 16;
            this.lstswitch.Location = new System.Drawing.Point(700, 66);
            this.lstswitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstswitch.Name = "lstswitch";
            this.lstswitch.Size = new System.Drawing.Size(983, 244);
            this.lstswitch.TabIndex = 102;
            this.lstswitch.SelectedIndexChanged += new System.EventHandler(this.lstswitch_SelectedIndexChanged);
            // 
            // txtSdevices
            // 
            this.txtSdevices.Location = new System.Drawing.Point(375, 231);
            this.txtSdevices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSdevices.Name = "txtSdevices";
            this.txtSdevices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSdevices.Size = new System.Drawing.Size(220, 22);
            this.txtSdevices.TabIndex = 134;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(196, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 20);
            this.label13.TabIndex = 135;
            this.label13.Text = "Number of devices:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 664);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSdevices);
            this.Controls.Add(this.grpdevice);
            this.Controls.Add(this.grpswitch);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.lstcomments);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDtype);
            this.Controls.Add(this.txtDloc);
            this.Controls.Add(this.txtDmanufaturer);
            this.Controls.Add(this.txtDmodel);
            this.Controls.Add(this.txtDserialnum);
            this.Controls.Add(this.txtDdate);
            this.Controls.Add(this.txtDcomments);
            this.Controls.Add(this.txtSdate);
            this.Controls.Add(this.txtSlast);
            this.Controls.Add(this.txtSid);
            this.Controls.Add(this.txtSserialnum);
            this.Controls.Add(this.lbldevice);
            this.Controls.Add(this.lblswitch);
            this.Controls.Add(this.lstdevice);
            this.Controls.Add(this.lstswitch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpdevice.ResumeLayout(false);
            this.grpswitch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpdevice;
        private System.Windows.Forms.Button btnDsearch;
        private System.Windows.Forms.Button btnDadd;
        private System.Windows.Forms.Button btnDedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox grpswitch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnSadd;
        private System.Windows.Forms.Button btnSedit;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.ListBox lstcomments;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDtype;
        private System.Windows.Forms.TextBox txtDloc;
        private System.Windows.Forms.TextBox txtDmanufaturer;
        private System.Windows.Forms.TextBox txtDmodel;
        private System.Windows.Forms.TextBox txtDserialnum;
        private System.Windows.Forms.TextBox txtDdate;
        private System.Windows.Forms.TextBox txtDcomments;
        private System.Windows.Forms.TextBox txtSdate;
        private System.Windows.Forms.TextBox txtSlast;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.TextBox txtSserialnum;
        private System.Windows.Forms.Label lbldevice;
        private System.Windows.Forms.Label lblswitch;
        private System.Windows.Forms.ListBox lstdevice;
        private System.Windows.Forms.ListBox lstswitch;
        private System.Windows.Forms.TextBox txtSdevices;
        private System.Windows.Forms.Label label13;
    }
}

