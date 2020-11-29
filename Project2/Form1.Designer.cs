
namespace Project2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxStudentList = new System.Windows.Forms.ListBox();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxStudentList
            // 
            this.lbxStudentList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxStudentList.FormattingEnabled = true;
            this.lbxStudentList.ItemHeight = 28;
            this.lbxStudentList.Location = new System.Drawing.Point(47, 125);
            this.lbxStudentList.Name = "lbxStudentList";
            this.lbxStudentList.Size = new System.Drawing.Size(150, 200);
            this.lbxStudentList.TabIndex = 0;
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentList.Location = new System.Drawing.Point(47, 86);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(138, 28);
            this.lblStudentList.TabIndex = 1;
            this.lblStudentList.Text = "Öğrenci Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxStudentName.Location = new System.Drawing.Point(344, 86);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(275, 34);
            this.tbxStudentName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddStudent.Location = new System.Drawing.Point(525, 126);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(94, 42);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(72, 331);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveStudent.TabIndex = 5;
            this.btnRemoveStudent.Text = "Sil";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.tbxStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.lbxStudentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudentList;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
    }
}

