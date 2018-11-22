namespace assignment
{
    partial class switcheditor
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtSdevices = new System.Windows.Forms.TextBox();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSdate = new System.Windows.Forms.TextBox();
            this.txtSlast = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.txtSserialnum = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 208);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 147;
            this.label13.Text = "Number of devices:";
            // 
            // txtSdevices
            // 
            this.txtSdevices.Location = new System.Drawing.Point(140, 208);
            this.txtSdevices.Margin = new System.Windows.Forms.Padding(2);
            this.txtSdevices.Name = "txtSdevices";
            this.txtSdevices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSdevices.Size = new System.Drawing.Size(166, 20);
            this.txtSdevices.TabIndex = 146;
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Unmanaged",
            "Managed",
            "Smart",
            "Enterprise Managed\t"});
            this.cmbtype.Location = new System.Drawing.Point(140, 114);
            this.cmbtype.Margin = new System.Windows.Forms.Padding(2);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(166, 21);
            this.cmbtype.TabIndex = 137;
            this.cmbtype.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 145;
            this.label5.Text = "Switch type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 144;
            this.label4.Text = "Date installed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 143;
            this.label3.Text = "Date last tested:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 142;
            this.label2.Text = "ID of PAT staff:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 141;
            this.label1.Text = "Serial number:";
            // 
            // txtSdate
            // 
            this.txtSdate.Location = new System.Drawing.Point(140, 139);
            this.txtSdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtSdate.Name = "txtSdate";
            this.txtSdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSdate.Size = new System.Drawing.Size(166, 20);
            this.txtSdate.TabIndex = 138;
            // 
            // txtSlast
            // 
            this.txtSlast.Location = new System.Drawing.Point(140, 161);
            this.txtSlast.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlast.Name = "txtSlast";
            this.txtSlast.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSlast.Size = new System.Drawing.Size(166, 20);
            this.txtSlast.TabIndex = 139;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(140, 184);
            this.txtSid.Margin = new System.Windows.Forms.Padding(2);
            this.txtSid.Name = "txtSid";
            this.txtSid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSid.Size = new System.Drawing.Size(166, 20);
            this.txtSid.TabIndex = 140;
            // 
            // txtSserialnum
            // 
            this.txtSserialnum.Location = new System.Drawing.Point(140, 92);
            this.txtSserialnum.Margin = new System.Windows.Forms.Padding(2);
            this.txtSserialnum.Name = "txtSserialnum";
            this.txtSserialnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSserialnum.Size = new System.Drawing.Size(166, 20);
            this.txtSserialnum.TabIndex = 136;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(77, 295);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(160, 39);
            this.btnsave.TabIndex = 148;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 31);
            this.label6.TabIndex = 149;
            this.label6.Text = "switch editor";
            // 
            // switcheditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 346);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSdevices);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSdate);
            this.Controls.Add(this.txtSlast);
            this.Controls.Add(this.txtSid);
            this.Controls.Add(this.txtSserialnum);
            this.Name = "switcheditor";
            this.Text = "switcheditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSdevices;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSdate;
        private System.Windows.Forms.TextBox txtSlast;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.TextBox txtSserialnum;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label6;
    }
}