namespace WindowsFormsApp1
{
    partial class std_payment
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
            this.stdId = new System.Windows.Forms.TextBox();
            this.std_id = new System.Windows.Forms.Label();
            this.std_Name = new System.Windows.Forms.Label();
            this.stdName = new System.Windows.Forms.TextBox();
            this.Tot_Free = new System.Windows.Forms.Label();
            this.tot_fee = new System.Windows.Forms.TextBox();
            this.duedate = new System.Windows.Forms.Label();
            this.duefee = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.amunt = new System.Windows.Forms.TextBox();
            this.Pay = new System.Windows.Forms.Button();
            this.mess = new System.Windows.Forms.CheckBox();
            this.hostel = new System.Windows.Forms.CheckBox();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stdId
            // 
            this.stdId.Location = new System.Drawing.Point(349, 73);
            this.stdId.Name = "stdId";
            this.stdId.Size = new System.Drawing.Size(180, 20);
            this.stdId.TabIndex = 0;
            // 
            // std_id
            // 
            this.std_id.AutoSize = true;
            this.std_id.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_id.Image = global::WindowsFormsApp1.Properties.Resources.pic03;
            this.std_id.Location = new System.Drawing.Point(206, 76);
            this.std_id.Name = "std_id";
            this.std_id.Size = new System.Drawing.Size(93, 21);
            this.std_id.TabIndex = 1;
            this.std_id.Text = "Student Id";
            // 
            // std_Name
            // 
            this.std_Name.AutoSize = true;
            this.std_Name.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_Name.Image = global::WindowsFormsApp1.Properties.Resources.pic03;
            this.std_Name.Location = new System.Drawing.Point(206, 116);
            this.std_Name.Name = "std_Name";
            this.std_Name.Size = new System.Drawing.Size(122, 21);
            this.std_Name.TabIndex = 3;
            this.std_Name.Text = "Student Name";
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(349, 113);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(180, 20);
            this.stdName.TabIndex = 2;
            // 
            // Tot_Free
            // 
            this.Tot_Free.AutoSize = true;
            this.Tot_Free.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tot_Free.Image = global::WindowsFormsApp1.Properties.Resources.pic03;
            this.Tot_Free.Location = new System.Drawing.Point(206, 155);
            this.Tot_Free.Name = "Tot_Free";
            this.Tot_Free.Size = new System.Drawing.Size(88, 21);
            this.Tot_Free.TabIndex = 5;
            this.Tot_Free.Text = "Total Free";
            // 
            // tot_fee
            // 
            this.tot_fee.Location = new System.Drawing.Point(349, 152);
            this.tot_fee.Name = "tot_fee";
            this.tot_fee.Size = new System.Drawing.Size(180, 20);
            this.tot_fee.TabIndex = 4;
            // 
            // duedate
            // 
            this.duedate.AutoSize = true;
            this.duedate.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedate.Image = global::WindowsFormsApp1.Properties.Resources.pic03;
            this.duedate.Location = new System.Drawing.Point(206, 232);
            this.duedate.Name = "duedate";
            this.duedate.Size = new System.Drawing.Size(71, 21);
            this.duedate.TabIndex = 9;
            this.duedate.Text = "Due Fee";
            // 
            // duefee
            // 
            this.duefee.Location = new System.Drawing.Point(349, 229);
            this.duefee.Name = "duefee";
            this.duefee.Size = new System.Drawing.Size(180, 20);
            this.duefee.TabIndex = 8;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Image = global::WindowsFormsApp1.Properties.Resources.pic03;
            this.amount.Location = new System.Drawing.Point(206, 271);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(69, 21);
            this.amount.TabIndex = 11;
            this.amount.Text = "Amount";
            // 
            // amunt
            // 
            this.amunt.Location = new System.Drawing.Point(349, 268);
            this.amunt.Name = "amunt";
            this.amunt.Size = new System.Drawing.Size(180, 20);
            this.amunt.TabIndex = 10;
            // 
            // Pay
            // 
            this.Pay.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.Pay.Location = new System.Drawing.Point(306, 308);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(111, 30);
            this.Pay.TabIndex = 12;
            this.Pay.Text = "Pay Now";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // mess
            // 
            this.mess.AutoSize = true;
            this.mess.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic);
            this.mess.Location = new System.Drawing.Point(612, 139);
            this.mess.Name = "mess";
            this.mess.Size = new System.Drawing.Size(66, 25);
            this.mess.TabIndex = 14;
            this.mess.Text = "Mess";
            this.mess.UseVisualStyleBackColor = true;
            // 
            // hostel
            // 
            this.hostel.AutoSize = true;
            this.hostel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic);
            this.hostel.Location = new System.Drawing.Point(612, 170);
            this.hostel.Name = "hostel";
            this.hostel.Size = new System.Drawing.Size(76, 25);
            this.hostel.TabIndex = 15;
            this.hostel.Text = "Hostel";
            this.hostel.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.search.Location = new System.Drawing.Point(593, 67);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(111, 30);
            this.search.TabIndex = 13;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // std_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic02;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hostel);
            this.Controls.Add(this.mess);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.amunt);
            this.Controls.Add(this.duedate);
            this.Controls.Add(this.duefee);
            this.Controls.Add(this.Tot_Free);
            this.Controls.Add(this.tot_fee);
            this.Controls.Add(this.std_Name);
            this.Controls.Add(this.stdName);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.stdId);
            this.Name = "std_payment";
            this.Text = "std_payment";
            this.Load += new System.EventHandler(this.std_payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stdId;
        private System.Windows.Forms.Label std_id;
        private System.Windows.Forms.Label std_Name;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.Label Tot_Free;
        private System.Windows.Forms.TextBox tot_fee;
        private System.Windows.Forms.Label duedate;
        private System.Windows.Forms.TextBox duefee;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.TextBox amunt;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.CheckBox mess;
        private System.Windows.Forms.CheckBox hostel;
        private System.Windows.Forms.Button search;
    }
}