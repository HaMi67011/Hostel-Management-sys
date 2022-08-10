namespace WindowsFormsApp1
{
    partial class stdBill
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
            this.label2 = new System.Windows.Forms.Label();
            this.HosDue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessDue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StdId = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hostel Due";
            // 
            // HosDue
            // 
            this.HosDue.Location = new System.Drawing.Point(259, 106);
            this.HosDue.Name = "HosDue";
            this.HosDue.Size = new System.Drawing.Size(100, 20);
            this.HosDue.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mess Due";
            // 
            // MessDue
            // 
            this.MessDue.Location = new System.Drawing.Point(259, 149);
            this.MessDue.Name = "MessDue";
            this.MessDue.Size = new System.Drawing.Size(100, 20);
            this.MessDue.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Student Id";
            // 
            // StdId
            // 
            this.StdId.Location = new System.Drawing.Point(340, 45);
            this.StdId.Name = "StdId";
            this.StdId.Size = new System.Drawing.Size(100, 20);
            this.StdId.TabIndex = 25;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(480, 45);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(136, 21);
            this.search.TabIndex = 26;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // stdBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic02;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StdId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessDue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HosDue);
            this.Name = "stdBill";
            this.Text = "stdBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HosDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MessDue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StdId;
        private System.Windows.Forms.Button search;
    }
}