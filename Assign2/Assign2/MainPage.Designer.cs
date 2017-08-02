namespace Assign2
{
    partial class MainPage
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
            this.btnStudent = new System.Windows.Forms.Button();
            this.Coursesbtn = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.lblCollege = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(73, 30);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(95, 33);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // Coursesbtn
            // 
            this.Coursesbtn.Location = new System.Drawing.Point(73, 94);
            this.Coursesbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Coursesbtn.Name = "Coursesbtn";
            this.Coursesbtn.Size = new System.Drawing.Size(95, 32);
            this.Coursesbtn.TabIndex = 2;
            this.Coursesbtn.Text = "Courses";
            this.Coursesbtn.UseVisualStyleBackColor = true;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(73, 155);
            this.btnEnroll.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(95, 38);
            this.btnEnroll.TabIndex = 3;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Location = new System.Drawing.Point(31, 204);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(0, 20);
            this.lblCollege.TabIndex = 5;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.lblCollege);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.Coursesbtn);
            this.Controls.Add(this.btnStudent);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button Coursesbtn;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Label lblCollege;
    }
}