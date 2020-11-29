
namespace Classes
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
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.dgrwStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 28;
            this.lbxStudents.Location = new System.Drawing.Point(45, 36);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(191, 312);
            this.lbxStudents.TabIndex = 0;
            // 
            // dgrwStudents
            // 
            this.dgrwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwStudents.Location = new System.Drawing.Point(268, 36);
            this.dgrwStudents.Name = "dgrwStudents";
            this.dgrwStudents.RowHeadersWidth = 51;
            this.dgrwStudents.RowTemplate.Height = 29;
            this.dgrwStudents.Size = new System.Drawing.Size(428, 312);
            this.dgrwStudents.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgrwStudents);
            this.Controls.Add(this.lbxStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.DataGridView dgrwStudents;
    }
}

