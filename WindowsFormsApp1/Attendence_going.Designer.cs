namespace WindowsFormsApp1
{
    partial class Attendence_going
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
            this.goingin = new System.Windows.Forms.CheckBox();
            this.goingout = new System.Windows.Forms.CheckBox();
            this.inTime = new System.Windows.Forms.DateTimePicker();
            this.outTime = new System.Windows.Forms.DateTimePicker();
            this.Submit = new System.Windows.Forms.Button();
            this.stdid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.label1.Image = global::WindowsFormsApp1.Properties.Resources.pic02;
            this.label1.Location = new System.Drawing.Point(294, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendence";
            // 
            // goingin
            // 
            this.goingin.AutoSize = true;
            this.goingin.BackColor = System.Drawing.Color.LightSlateGray;
            this.goingin.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.goingin.Location = new System.Drawing.Point(200, 101);
            this.goingin.Name = "goingin";
            this.goingin.Size = new System.Drawing.Size(117, 37);
            this.goingin.TabIndex = 1;
            this.goingin.Text = "Going In";
            this.goingin.UseVisualStyleBackColor = false;
            // 
            // goingout
            // 
            this.goingout.AutoSize = true;
            this.goingout.BackColor = System.Drawing.Color.LightSlateGray;
            this.goingout.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.goingout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goingout.Location = new System.Drawing.Point(200, 161);
            this.goingout.Name = "goingout";
            this.goingout.Size = new System.Drawing.Size(134, 37);
            this.goingout.TabIndex = 2;
            this.goingout.Text = "Going Out";
            this.goingout.UseVisualStyleBackColor = false;
            // 
            // inTime
            // 
            this.inTime.Location = new System.Drawing.Point(391, 109);
            this.inTime.Name = "inTime";
            this.inTime.Size = new System.Drawing.Size(180, 20);
            this.inTime.TabIndex = 24;
            // 
            // outTime
            // 
            this.outTime.Location = new System.Drawing.Point(391, 169);
            this.outTime.Name = "outTime";
            this.outTime.Size = new System.Drawing.Size(180, 20);
            this.outTime.TabIndex = 25;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.GrayText;
            this.Submit.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(300, 242);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(132, 32);
            this.Submit.TabIndex = 26;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // stdid
            // 
            this.stdid.Location = new System.Drawing.Point(149, 58);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(100, 20);
            this.stdid.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label2.Location = new System.Drawing.Point(71, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "StudentID";
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.SystemColors.GrayText;
            this.check.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(60, 242);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(132, 32);
            this.check.TabIndex = 45;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // Attendence_going
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check);
            this.Controls.Add(this.stdid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.outTime);
            this.Controls.Add(this.inTime);
            this.Controls.Add(this.goingout);
            this.Controls.Add(this.goingin);
            this.Controls.Add(this.label1);
            this.Name = "Attendence_going";
            this.Text = "Attendence_going";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox goingin;
        private System.Windows.Forms.CheckBox goingout;
        private System.Windows.Forms.DateTimePicker inTime;
        private System.Windows.Forms.DateTimePicker outTime;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox stdid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button check;
    }
}