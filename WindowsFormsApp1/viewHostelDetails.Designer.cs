namespace WindowsFormsApp1
{
    partial class viewHostelDetails
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
            this.del = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.noRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hosLoc = new System.Windows.Forms.TextBox();
            this.noFloor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HosId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.groupBox1.Controls.Add(this.del);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.noRoom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hosLoc);
            this.groupBox1.Controls.Add(this.noFloor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.HosId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(87, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 208);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hostel Details";
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.del.Image = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.del.Location = new System.Drawing.Point(552, 132);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 33;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(91, 60);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.btnUpdate.Image = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.btnUpdate.Location = new System.Drawing.Point(552, 99);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.Search.Image = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.Search.Location = new System.Drawing.Point(552, 63);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 27;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.insert.Image = global::WindowsFormsApp1.Properties.Resources.pic01;
            this.insert.Location = new System.Drawing.Point(552, 19);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 26;
            this.insert.Text = "Enter";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // noRoom
            // 
            this.noRoom.Location = new System.Drawing.Point(325, 25);
            this.noRoom.Name = "noRoom";
            this.noRoom.Size = new System.Drawing.Size(100, 20);
            this.noRoom.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label4.Location = new System.Drawing.Point(240, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "No # Room";
            // 
            // hosLoc
            // 
            this.hosLoc.Location = new System.Drawing.Point(91, 99);
            this.hosLoc.Name = "hosLoc";
            this.hosLoc.Size = new System.Drawing.Size(100, 20);
            this.hosLoc.TabIndex = 16;
            // 
            // noFloor
            // 
            this.noFloor.Location = new System.Drawing.Point(91, 131);
            this.noFloor.Name = "noFloor";
            this.noFloor.Size = new System.Drawing.Size(100, 20);
            this.noFloor.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hostel ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Location";
            // 
            // HosId
            // 
            this.HosId.Location = new System.Drawing.Point(91, 28);
            this.HosId.Name = "HosId";
            this.HosId.Size = new System.Drawing.Size(100, 20);
            this.HosId.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "No # Floor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 187);
            this.dataGridView1.TabIndex = 24;
            // 
            // viewHostelDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Text = "Hostel View";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox noRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hosLoc;
        private System.Windows.Forms.TextBox noFloor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HosId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button del;
    }
}