namespace Hall_Management_System.Settings
{
    partial class room_info
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hall_name_CB = new System.Windows.Forms.ComboBox();
            this.roomNoTB = new System.Windows.Forms.TextBox();
            this.capacityTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addRoomB = new System.Windows.Forms.Button();
            this.updateRoomB = new System.Windows.Forms.Button();
            this.deleteRoomB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchHallCB = new System.Windows.Forms.ComboBox();
            this.searchRoomToDeleteRB = new System.Windows.Forms.RadioButton();
            this.searchRoomCB = new System.Windows.Forms.ComboBox();
            this.addRoomRB = new System.Windows.Forms.RadioButton();
            this.searchRoomToUpdateRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.roomidL = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.roomidL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hall_name_CB);
            this.groupBox2.Controls.Add(this.roomNoTB);
            this.groupBox2.Controls.Add(this.capacityTB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 239);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Annex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hall Name:";
            // 
            // hall_name_CB
            // 
            this.hall_name_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hall_name_CB.FormattingEnabled = true;
            this.hall_name_CB.Location = new System.Drawing.Point(159, 170);
            this.hall_name_CB.Name = "hall_name_CB";
            this.hall_name_CB.Size = new System.Drawing.Size(192, 21);
            this.hall_name_CB.TabIndex = 7;
            // 
            // roomNoTB
            // 
            this.roomNoTB.Location = new System.Drawing.Point(159, 76);
            this.roomNoTB.Name = "roomNoTB";
            this.roomNoTB.Size = new System.Drawing.Size(192, 20);
            this.roomNoTB.TabIndex = 6;
            // 
            // capacityTB
            // 
            this.capacityTB.Location = new System.Drawing.Point(159, 120);
            this.capacityTB.Name = "capacityTB";
            this.capacityTB.Size = new System.Drawing.Size(219, 20);
            this.capacityTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room No:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addRoomB);
            this.groupBox3.Controls.Add(this.updateRoomB);
            this.groupBox3.Controls.Add(this.deleteRoomB);
            this.groupBox3.Controls.Add(this.cancelB);
            this.groupBox3.Location = new System.Drawing.Point(14, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 68);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action Annex";
            // 
            // addRoomB
            // 
            this.addRoomB.Location = new System.Drawing.Point(151, 30);
            this.addRoomB.Name = "addRoomB";
            this.addRoomB.Size = new System.Drawing.Size(75, 23);
            this.addRoomB.TabIndex = 3;
            this.addRoomB.Text = "Add";
            this.addRoomB.UseVisualStyleBackColor = true;
            this.addRoomB.Click += new System.EventHandler(this.addRoomB_Click);
            // 
            // updateRoomB
            // 
            this.updateRoomB.Location = new System.Drawing.Point(232, 30);
            this.updateRoomB.Name = "updateRoomB";
            this.updateRoomB.Size = new System.Drawing.Size(75, 23);
            this.updateRoomB.TabIndex = 2;
            this.updateRoomB.Text = "Update";
            this.updateRoomB.UseVisualStyleBackColor = true;
            this.updateRoomB.Click += new System.EventHandler(this.updateRoomB_Click);
            // 
            // deleteRoomB
            // 
            this.deleteRoomB.Location = new System.Drawing.Point(325, 30);
            this.deleteRoomB.Name = "deleteRoomB";
            this.deleteRoomB.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomB.TabIndex = 1;
            this.deleteRoomB.Text = "Delete";
            this.deleteRoomB.UseVisualStyleBackColor = true;
            this.deleteRoomB.Click += new System.EventHandler(this.deleteRoomB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(406, 30);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchHallCB);
            this.groupBox1.Controls.Add(this.searchRoomToDeleteRB);
            this.groupBox1.Controls.Add(this.searchRoomCB);
            this.groupBox1.Controls.Add(this.addRoomRB);
            this.groupBox1.Controls.Add(this.searchRoomToUpdateRB);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Annex";
            // 
            // searchHallCB
            // 
            this.searchHallCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchHallCB.FormattingEnabled = true;
            this.searchHallCB.Location = new System.Drawing.Point(324, 16);
            this.searchHallCB.Name = "searchHallCB";
            this.searchHallCB.Size = new System.Drawing.Size(134, 21);
            this.searchHallCB.TabIndex = 4;
            this.searchHallCB.SelectedIndexChanged += new System.EventHandler(this.searchHallCB_SelectedIndexChanged);
            // 
            // searchRoomToDeleteRB
            // 
            this.searchRoomToDeleteRB.AutoSize = true;
            this.searchRoomToDeleteRB.Location = new System.Drawing.Point(85, 44);
            this.searchRoomToDeleteRB.Name = "searchRoomToDeleteRB";
            this.searchRoomToDeleteRB.Size = new System.Drawing.Size(136, 17);
            this.searchRoomToDeleteRB.TabIndex = 3;
            this.searchRoomToDeleteRB.TabStop = true;
            this.searchRoomToDeleteRB.Text = "Search Room to Delete";
            this.searchRoomToDeleteRB.UseVisualStyleBackColor = true;
            this.searchRoomToDeleteRB.CheckedChanged += new System.EventHandler(this.searchRoomToDeleteRB_CheckedChanged_1);
            // 
            // searchRoomCB
            // 
            this.searchRoomCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchRoomCB.FormattingEnabled = true;
            this.searchRoomCB.Location = new System.Drawing.Point(324, 54);
            this.searchRoomCB.Name = "searchRoomCB";
            this.searchRoomCB.Size = new System.Drawing.Size(134, 21);
            this.searchRoomCB.TabIndex = 2;
            this.searchRoomCB.SelectedIndexChanged += new System.EventHandler(this.searchRoomCB_SelectedIndexChanged_1);
            // 
            // addRoomRB
            // 
            this.addRoomRB.AutoSize = true;
            this.addRoomRB.Location = new System.Drawing.Point(85, 67);
            this.addRoomRB.Name = "addRoomRB";
            this.addRoomRB.Size = new System.Drawing.Size(150, 17);
            this.addRoomRB.TabIndex = 1;
            this.addRoomRB.Text = "I want to add a new Room";
            this.addRoomRB.UseVisualStyleBackColor = true;
            this.addRoomRB.CheckedChanged += new System.EventHandler(this.addRoomRB_CheckedChanged_1);
            // 
            // searchRoomToUpdateRB
            // 
            this.searchRoomToUpdateRB.AutoSize = true;
            this.searchRoomToUpdateRB.Checked = true;
            this.searchRoomToUpdateRB.Location = new System.Drawing.Point(85, 20);
            this.searchRoomToUpdateRB.Name = "searchRoomToUpdateRB";
            this.searchRoomToUpdateRB.Size = new System.Drawing.Size(140, 17);
            this.searchRoomToUpdateRB.TabIndex = 0;
            this.searchRoomToUpdateRB.TabStop = true;
            this.searchRoomToUpdateRB.Text = "Search Room to Update";
            this.searchRoomToUpdateRB.UseVisualStyleBackColor = true;
            this.searchRoomToUpdateRB.CheckedChanged += new System.EventHandler(this.searchRoomToUpdateRB_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room ID:";
            // 
            // roomidL
            // 
            this.roomidL.AutoSize = true;
            this.roomidL.Location = new System.Drawing.Point(169, 36);
            this.roomidL.Name = "roomidL";
            this.roomidL.Size = new System.Drawing.Size(157, 13);
            this.roomidL.TabIndex = 10;
            this.roomidL.Text = "It will be generate automatically.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Maroon;
            this.label26.Location = new System.Drawing.Point(357, 67);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 29);
            this.label26.TabIndex = 33;
            this.label26.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(384, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "*";
            // 
            // room_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "room_info";
            this.Text = "room_info";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox capacityTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addRoomB;
        private System.Windows.Forms.Button updateRoomB;
        private System.Windows.Forms.Button deleteRoomB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchRoomToDeleteRB;
        private System.Windows.Forms.ComboBox searchRoomCB;
        private System.Windows.Forms.RadioButton addRoomRB;
        private System.Windows.Forms.RadioButton searchRoomToUpdateRB;
        private System.Windows.Forms.TextBox roomNoTB;
        private System.Windows.Forms.ComboBox searchHallCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hall_name_CB;
        private System.Windows.Forms.Label roomidL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label26;

    }
}