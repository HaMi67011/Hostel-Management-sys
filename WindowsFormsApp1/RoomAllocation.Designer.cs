namespace WindowsFormsApp1
{
    partial class RoomAllocation
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
            this.Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StdRoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RomCap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "StudentID";
            // 
            // stdId
            // 
            this.stdId.Location = new System.Drawing.Point(194, 45);
            this.stdId.Name = "stdId";
            this.stdId.Size = new System.Drawing.Size(100, 20);
            this.stdId.TabIndex = 17;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(138, 92);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(108, 24);
            this.Search.TabIndex = 19;
            this.Search.Text = "search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Student Room";
            // 
            // StdRoom
            // 
            this.StdRoom.Location = new System.Drawing.Point(220, 199);
            this.StdRoom.Name = "StdRoom";
            this.StdRoom.Size = new System.Drawing.Size(100, 20);
            this.StdRoom.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Room Full";
            // 
            // RomCap
            // 
            this.RomCap.Location = new System.Drawing.Point(218, 245);
            this.RomCap.Name = "RomCap";
            this.RomCap.Size = new System.Drawing.Size(100, 20);
            this.RomCap.TabIndex = 27;
            // 
            // RoomAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic03;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RomCap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StdRoom);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stdId);
            this.Name = "RoomAllocation";
            this.Text = "RoomAllocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdId;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StdRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RomCap;
    }
}