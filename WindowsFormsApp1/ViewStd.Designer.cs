namespace WindowsFormsApp1
{
    partial class ViewStd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AGe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.addr = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.mailid = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stdId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.groupBox1.Controls.Add(this.Dept);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AGe);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.fee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.addr);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.mailid);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stdId);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 170);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Dept
            // 
            this.Dept.Location = new System.Drawing.Point(78, 99);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(100, 20);
            this.Dept.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Dept";
            // 
            // AGe
            // 
            this.AGe.Location = new System.Drawing.Point(78, 140);
            this.AGe.Name = "AGe";
            this.AGe.Size = new System.Drawing.Size(100, 20);
            this.AGe.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label9.Location = new System.Drawing.Point(11, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Age";
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(332, 136);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(100, 20);
            this.fee.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label7.Location = new System.Drawing.Point(245, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Password";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.update.Image = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.update.Location = new System.Drawing.Point(549, 136);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 26;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(549, 25);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(100, 71);
            this.addr.TabIndex = 25;
            this.addr.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label8.Location = new System.Drawing.Point(498, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Address";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(332, 95);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(181, 20);
            this.date.TabIndex = 23;
            // 
            // mailid
            // 
            this.mailid.Location = new System.Drawing.Point(332, 57);
            this.mailid.Name = "mailid";
            this.mailid.Size = new System.Drawing.Size(100, 20);
            this.mailid.TabIndex = 22;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(332, 25);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label6.Location = new System.Drawing.Point(240, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Join Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label5.Location = new System.Drawing.Point(240, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label4.Location = new System.Drawing.Point(240, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mobile Number";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(78, 66);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "StudentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // stdId
            // 
            this.stdId.Location = new System.Drawing.Point(78, 28);
            this.stdId.Name = "stdId";
            this.stdId.Size = new System.Drawing.Size(100, 20);
            this.stdId.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 226);
            this.dataGridView1.TabIndex = 20;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.btndelete.Image = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.btndelete.Location = new System.Drawing.Point(706, 96);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(92, 41);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.search.Image = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.search.Location = new System.Drawing.Point(706, 29);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(92, 41);
            this.search.TabIndex = 21;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ViewStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic03;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewStd";
            this.Text = "ViewStd";
            this.Load += new System.EventHandler(this.ViewStd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.RichTextBox addr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox mailid;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stdId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox AGe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Dept;
        private System.Windows.Forms.Label label3;
    }
}