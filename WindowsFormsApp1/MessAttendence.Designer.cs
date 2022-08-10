namespace WindowsFormsApp1
{
    partial class MessAttendence
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
            this.Submit = new System.Windows.Forms.Button();
            this.outTime = new System.Windows.Forms.DateTimePicker();
            this.Lunch = new System.Windows.Forms.CheckBox();
            this.breakfast = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dinner = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.GrayText;
            this.Submit.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(239, 274);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(132, 32);
            this.Submit.TabIndex = 32;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // outTime
            // 
            this.outTime.Location = new System.Drawing.Point(465, 103);
            this.outTime.Name = "outTime";
            this.outTime.Size = new System.Drawing.Size(230, 20);
            this.outTime.TabIndex = 31;
            this.outTime.ValueChanged += new System.EventHandler(this.outTime_ValueChanged);
            // 
            // Lunch
            // 
            this.Lunch.AutoSize = true;
            this.Lunch.BackColor = System.Drawing.Color.LightSlateGray;
            this.Lunch.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.Lunch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lunch.Location = new System.Drawing.Point(239, 163);
            this.Lunch.Name = "Lunch";
            this.Lunch.Size = new System.Drawing.Size(93, 37);
            this.Lunch.TabIndex = 29;
            this.Lunch.Text = "Lunch";
            this.Lunch.UseVisualStyleBackColor = false;
            // 
            // breakfast
            // 
            this.breakfast.AutoSize = true;
            this.breakfast.BackColor = System.Drawing.Color.LightSlateGray;
            this.breakfast.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.breakfast.Location = new System.Drawing.Point(239, 103);
            this.breakfast.Name = "breakfast";
            this.breakfast.Size = new System.Drawing.Size(137, 37);
            this.breakfast.TabIndex = 28;
            this.breakfast.Text = "Break Fast";
            this.breakfast.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.label1.Image = global::WindowsFormsApp1.Properties.Resources.pic02;
            this.label1.Location = new System.Drawing.Point(333, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Attendence";
            // 
            // Dinner
            // 
            this.Dinner.AutoSize = true;
            this.Dinner.BackColor = System.Drawing.Color.LightSlateGray;
            this.Dinner.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.Dinner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dinner.Location = new System.Drawing.Point(239, 223);
            this.Dinner.Name = "Dinner";
            this.Dinner.Size = new System.Drawing.Size(101, 37);
            this.Dinner.TabIndex = 33;
            this.Dinner.Text = "Dinner";
            this.Dinner.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "StudentID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(135, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 35;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(689, 234);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(399, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 32);
            this.button1.TabIndex = 37;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Dinner);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.outTime);
            this.Controls.Add(this.Lunch);
            this.Controls.Add(this.breakfast);
            this.Controls.Add(this.label1);
            this.Name = "MessAttendence";
            this.Text = "MessAttendence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.DateTimePicker outTime;
        private System.Windows.Forms.CheckBox Lunch;
        private System.Windows.Forms.CheckBox breakfast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Dinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button button1;
    }
}