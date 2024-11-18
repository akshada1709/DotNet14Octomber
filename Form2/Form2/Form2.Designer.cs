namespace Form2
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.btncreatefolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(533, 169);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(114, 26);
            this.btncreatefile.TabIndex = 2;
            this.btncreatefile.Text = "Create File";
            this.btncreatefile.UseVisualStyleBackColor = true;
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.Location = new System.Drawing.Point(533, 67);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(114, 26);
            this.btncreatefolder.TabIndex = 3;
            this.btncreatefolder.Text = "Create Folder";
            this.btncreatefolder.UseVisualStyleBackColor = true;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salary";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(262, 65);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(125, 20);
            this.txtid.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(262, 169);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(125, 20);
            this.txtname.TabIndex = 8;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(262, 252);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(125, 20);
            this.txtsalary.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Employye Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncreatefolder);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Button btncreatefolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label1;
    }
}