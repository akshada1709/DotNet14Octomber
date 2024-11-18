namespace WindowsFormsDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.listBoxCities = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.butRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter City Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(261, 50);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(132, 20);
            this.txtCity.TabIndex = 1;
            this.txtCity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxCities
            // 
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.Location = new System.Drawing.Point(223, 129);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.Size = new System.Drawing.Size(205, 121);
            this.listBoxCities.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // butRemove
            // 
            this.butRemove.Location = new System.Drawing.Point(367, 305);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(123, 29);
            this.butRemove.TabIndex = 4;
            this.butRemove.Text = "Remove";
            this.butRemove.UseVisualStyleBackColor = true;
            this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxCities);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ListBox listBoxCities;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button butRemove;
    }
}