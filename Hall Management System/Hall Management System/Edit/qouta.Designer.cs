namespace Hall_Management_System.Edit
{
    partial class qouta
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
            this.addQoutaB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qoutaNameTB = new System.Windows.Forms.TextBox();
            this.qoutaIdL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateQoutaB = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteQoutaB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchQoutaToDeleteRB = new System.Windows.Forms.RadioButton();
            this.searchQoutaCB = new System.Windows.Forms.ComboBox();
            this.addQoutaRB = new System.Windows.Forms.RadioButton();
            this.searchQoutaToUpdateRB = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addQoutaB
            // 
            this.addQoutaB.Location = new System.Drawing.Point(151, 30);
            this.addQoutaB.Name = "addQoutaB";
            this.addQoutaB.Size = new System.Drawing.Size(75, 23);
            this.addQoutaB.TabIndex = 3;
            this.addQoutaB.Text = "Add";
            this.addQoutaB.UseVisualStyleBackColor = true;
            this.addQoutaB.Click += new System.EventHandler(this.addQoutaB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qoutaNameTB);
            this.groupBox2.Controls.Add(this.qoutaIdL);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 239);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Annex";
            // 
            // qoutaNameTB
            // 
            this.qoutaNameTB.Location = new System.Drawing.Point(162, 96);
            this.qoutaNameTB.Name = "qoutaNameTB";
            this.qoutaNameTB.Size = new System.Drawing.Size(219, 20);
            this.qoutaNameTB.TabIndex = 5;
            // 
            // qoutaIdL
            // 
            this.qoutaIdL.AutoSize = true;
            this.qoutaIdL.Location = new System.Drawing.Point(159, 52);
            this.qoutaIdL.Name = "qoutaIdL";
            this.qoutaIdL.Size = new System.Drawing.Size(67, 13);
            this.qoutaIdL.TabIndex = 4;
            this.qoutaIdL.Text = "No Qouta ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qouta Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qouta ID:";
            // 
            // updateQoutaB
            // 
            this.updateQoutaB.Location = new System.Drawing.Point(232, 30);
            this.updateQoutaB.Name = "updateQoutaB";
            this.updateQoutaB.Size = new System.Drawing.Size(75, 23);
            this.updateQoutaB.TabIndex = 2;
            this.updateQoutaB.Text = "Update";
            this.updateQoutaB.UseVisualStyleBackColor = true;
            this.updateQoutaB.Click += new System.EventHandler(this.updateQoutaB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addQoutaB);
            this.groupBox3.Controls.Add(this.updateQoutaB);
            this.groupBox3.Controls.Add(this.deleteQoutaB);
            this.groupBox3.Controls.Add(this.cancelB);
            this.groupBox3.Location = new System.Drawing.Point(29, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 68);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action Annex";
            // 
            // deleteQoutaB
            // 
            this.deleteQoutaB.Location = new System.Drawing.Point(325, 30);
            this.deleteQoutaB.Name = "deleteQoutaB";
            this.deleteQoutaB.Size = new System.Drawing.Size(75, 23);
            this.deleteQoutaB.TabIndex = 1;
            this.deleteQoutaB.Text = "Delete";
            this.deleteQoutaB.UseVisualStyleBackColor = true;
            this.deleteQoutaB.Click += new System.EventHandler(this.deleteQoutaB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(406, 30);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchQoutaToDeleteRB);
            this.groupBox1.Controls.Add(this.searchQoutaCB);
            this.groupBox1.Controls.Add(this.addQoutaRB);
            this.groupBox1.Controls.Add(this.searchQoutaToUpdateRB);
            this.groupBox1.Location = new System.Drawing.Point(30, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 90);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Annex";
            // 
            // searchQoutaToDeleteRB
            // 
            this.searchQoutaToDeleteRB.AutoSize = true;
            this.searchQoutaToDeleteRB.Location = new System.Drawing.Point(85, 44);
            this.searchQoutaToDeleteRB.Name = "searchQoutaToDeleteRB";
            this.searchQoutaToDeleteRB.Size = new System.Drawing.Size(137, 17);
            this.searchQoutaToDeleteRB.TabIndex = 3;
            this.searchQoutaToDeleteRB.TabStop = true;
            this.searchQoutaToDeleteRB.Text = "Search Qouta to Delete";
            this.searchQoutaToDeleteRB.UseVisualStyleBackColor = true;
            this.searchQoutaToDeleteRB.CheckedChanged += new System.EventHandler(this.searchQoutaToDeleteRB_CheckedChanged);
            // 
            // searchQoutaCB
            // 
            this.searchQoutaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchQoutaCB.FormattingEnabled = true;
            this.searchQoutaCB.Location = new System.Drawing.Point(320, 27);
            this.searchQoutaCB.Name = "searchQoutaCB";
            this.searchQoutaCB.Size = new System.Drawing.Size(134, 21);
            this.searchQoutaCB.TabIndex = 2;
            this.searchQoutaCB.SelectedIndexChanged += new System.EventHandler(this.searchQoutaCB_SelectedIndexChanged);
            // 
            // addQoutaRB
            // 
            this.addQoutaRB.AutoSize = true;
            this.addQoutaRB.Location = new System.Drawing.Point(85, 67);
            this.addQoutaRB.Name = "addQoutaRB";
            this.addQoutaRB.Size = new System.Drawing.Size(151, 17);
            this.addQoutaRB.TabIndex = 1;
            this.addQoutaRB.Text = "I want to add a new Qouta";
            this.addQoutaRB.UseVisualStyleBackColor = true;
            this.addQoutaRB.CheckedChanged += new System.EventHandler(this.addQoutaRB_CheckedChanged);
            // 
            // searchQoutaToUpdateRB
            // 
            this.searchQoutaToUpdateRB.AutoSize = true;
            this.searchQoutaToUpdateRB.Checked = true;
            this.searchQoutaToUpdateRB.Location = new System.Drawing.Point(85, 20);
            this.searchQoutaToUpdateRB.Name = "searchQoutaToUpdateRB";
            this.searchQoutaToUpdateRB.Size = new System.Drawing.Size(170, 17);
            this.searchQoutaToUpdateRB.TabIndex = 0;
            this.searchQoutaToUpdateRB.TabStop = true;
            this.searchQoutaToUpdateRB.Text = "Search Qouta name to Update";
            this.searchQoutaToUpdateRB.UseVisualStyleBackColor = true;
            this.searchQoutaToUpdateRB.CheckedChanged += new System.EventHandler(this.searchQoutaToUpdateRB_CheckedChanged);
            // 
            // qouta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "qouta";
            this.Text = "Hall Management System Qouta Information";
            this.Load += new System.EventHandler(this.searchQoutaToUpdateRB_CheckedChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQoutaB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox qoutaNameTB;
        private System.Windows.Forms.Label qoutaIdL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateQoutaB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteQoutaB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchQoutaToDeleteRB;
        private System.Windows.Forms.ComboBox searchQoutaCB;
        private System.Windows.Forms.RadioButton addQoutaRB;
        private System.Windows.Forms.RadioButton searchQoutaToUpdateRB;
    }
}