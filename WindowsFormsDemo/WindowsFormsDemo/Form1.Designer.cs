namespace WindowsFormsDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.butJSONWrite = new System.Windows.Forms.Button();
            this.btnbinaryRead = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.butJSONRead = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(235, 40);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 20);
            this.txtid.TabIndex = 3;
            this.txtid.Text = "101";
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(235, 151);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(129, 20);
            this.txtsalary.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(235, 98);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(129, 20);
            this.txtname.TabIndex = 5;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(119, 222);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(114, 35);
            this.btnBinaryWrite.TabIndex = 6;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(119, 285);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(114, 35);
            this.btnXmlWrite.TabIndex = 7;
            this.btnXmlWrite.Text = "XMLWrite";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(119, 348);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(114, 35);
            this.btnSoapWrite.TabIndex = 8;
            this.btnSoapWrite.Text = "Soap Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // butJSONWrite
            // 
            this.butJSONWrite.Location = new System.Drawing.Point(119, 403);
            this.butJSONWrite.Name = "butJSONWrite";
            this.butJSONWrite.Size = new System.Drawing.Size(114, 35);
            this.butJSONWrite.TabIndex = 9;
            this.butJSONWrite.Text = "JSON Write";
            this.butJSONWrite.UseVisualStyleBackColor = true;
            this.butJSONWrite.Click += new System.EventHandler(this.butJSONWrite_Click);
            // 
            // btnbinaryRead
            // 
            this.btnbinaryRead.Location = new System.Drawing.Point(335, 222);
            this.btnbinaryRead.Name = "btnbinaryRead";
            this.btnbinaryRead.Size = new System.Drawing.Size(114, 35);
            this.btnbinaryRead.TabIndex = 10;
            this.btnbinaryRead.Text = "Binary Read";
            this.btnbinaryRead.UseVisualStyleBackColor = true;
            this.btnbinaryRead.Click += new System.EventHandler(this.btnbinaryRead_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(335, 285);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(114, 35);
            this.btnXmlRead.TabIndex = 11;
            this.btnXmlRead.Text = "XMLRead";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(335, 348);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(114, 35);
            this.btnSoapRead.TabIndex = 12;
            this.btnSoapRead.Text = "Soap Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // butJSONRead
            // 
            this.butJSONRead.Location = new System.Drawing.Point(335, 403);
            this.butJSONRead.Name = "butJSONRead";
            this.butJSONRead.Size = new System.Drawing.Size(114, 35);
            this.butJSONRead.TabIndex = 13;
            this.butJSONRead.Text = "JSONRead";
            this.butJSONRead.UseVisualStyleBackColor = true;
            this.butJSONRead.Click += new System.EventHandler(this.butJSONRead_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(544, 77);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(139, 34);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.butJSONRead);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnbinaryRead);
            this.Controls.Add(this.butJSONWrite);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button butJSONWrite;
        private System.Windows.Forms.Button btnbinaryRead;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button butJSONRead;
        private System.Windows.Forms.Button btnclear;
    }
}

