namespace WindowsFormsApp1
{
    partial class Shifting
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
            this.stdId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CurRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewRoom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.HallName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newHallName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "StudentID";
            // 
            // stdId
            // 
            this.stdId.Location = new System.Drawing.Point(229, 73);
            this.stdId.Name = "stdId";
            this.stdId.Size = new System.Drawing.Size(100, 20);
            this.stdId.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Current Room";
            // 
            // CurRoom
            // 
            this.CurRoom.Location = new System.Drawing.Point(229, 125);
            this.CurRoom.Name = "CurRoom";
            this.CurRoom.Size = new System.Drawing.Size(100, 20);
            this.CurRoom.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "New Room";
            // 
            // NewRoom
            // 
            this.NewRoom.Location = new System.Drawing.Point(229, 167);
            this.NewRoom.Name = "NewRoom";
            this.NewRoom.Size = new System.Drawing.Size(100, 20);
            this.NewRoom.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label6.Location = new System.Drawing.Point(128, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Shifting Date";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.GrayText;
            this.Submit.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(169, 263);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(132, 29);
            this.Submit.TabIndex = 50;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.GrayText;
            this.Search.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(389, 66);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(132, 27);
            this.Search.TabIndex = 51;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Hall Name";
            // 
            // HallName
            // 
            this.HallName.Location = new System.Drawing.Point(510, 121);
            this.HallName.Name = "HallName";
            this.HallName.Size = new System.Drawing.Size(100, 20);
            this.HallName.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Hall Name";
            // 
            // newHallName
            // 
            this.newHallName.Location = new System.Drawing.Point(510, 167);
            this.newHallName.Name = "newHallName";
            this.newHallName.Size = new System.Drawing.Size(100, 20);
            this.newHallName.TabIndex = 55;
            // 
            // Shifting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic03;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newHallName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HallName);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stdId);
            this.Name = "Shifting";
            this.Text = "Shifting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CurRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewRoom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HallName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newHallName;
    }
}