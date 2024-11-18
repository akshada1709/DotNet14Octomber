namespace Form3
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
            this.btnwrite = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(258, 49);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(120, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(258, 190);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(120, 20);
            this.txtsalary.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(258, 121);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(120, 20);
            this.txtname.TabIndex = 5;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(133, 254);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(102, 31);
            this.btnwrite.TabIndex = 6;
            this.btnwrite.Text = " Binary Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Binary Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "XML Write";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "XML Read";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "SOAP Write";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(280, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 27);
            this.button6.TabIndex = 11;
            this.button6.Text = "SOAP Read";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(513, 124);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(119, 43);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "JSON Write";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(280, 411);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 27);
            this.button7.TabIndex = 14;
            this.button7.Text = "JSON Write";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
    }
}

