namespace GetFileInfo
{
    partial class formGetFileInfo
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
            this.txtInfolder = new System.Windows.Forms.TextBox();
            this.txtOutLocation = new System.Windows.Forms.TextBox();
            this.lblInputFolder = new System.Windows.Forms.Label();
            this.lblOutputLocation = new System.Windows.Forms.Label();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInfolder
            // 
            this.txtInfolder.Location = new System.Drawing.Point(12, 32);
            this.txtInfolder.Name = "txtInfolder";
            this.txtInfolder.Size = new System.Drawing.Size(434, 20);
            this.txtInfolder.TabIndex = 0;
            // 
            // txtOutLocation
            // 
            this.txtOutLocation.Location = new System.Drawing.Point(12, 80);
            this.txtOutLocation.Name = "txtOutLocation";
            this.txtOutLocation.Size = new System.Drawing.Size(434, 20);
            this.txtOutLocation.TabIndex = 1;
            // 
            // lblInputFolder
            // 
            this.lblInputFolder.AutoSize = true;
            this.lblInputFolder.Location = new System.Drawing.Point(12, 16);
            this.lblInputFolder.Name = "lblInputFolder";
            this.lblInputFolder.Size = new System.Drawing.Size(63, 13);
            this.lblInputFolder.TabIndex = 2;
            this.lblInputFolder.Text = "Input Folder";
            // 
            // lblOutputLocation
            // 
            this.lblOutputLocation.AutoSize = true;
            this.lblOutputLocation.Location = new System.Drawing.Point(12, 63);
            this.lblOutputLocation.Name = "lblOutputLocation";
            this.lblOutputLocation.Size = new System.Drawing.Size(83, 13);
            this.lblOutputLocation.TabIndex = 3;
            this.lblOutputLocation.Text = "Output Location";
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(463, 79);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(78, 20);
            this.btnBrowse2.TabIndex = 5;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(463, 32);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(78, 20);
            this.btnBrowse1.TabIndex = 4;
            this.btnBrowse1.Text = "Browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(15, 123);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(145, 20);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // formGetFileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 155);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.lblOutputLocation);
            this.Controls.Add(this.lblInputFolder);
            this.Controls.Add(this.txtOutLocation);
            this.Controls.Add(this.txtInfolder);
            this.Name = "formGetFileInfo";
            this.Text = "Get File Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfolder;
        private System.Windows.Forms.TextBox txtOutLocation;
        private System.Windows.Forms.Label lblInputFolder;
        private System.Windows.Forms.Label lblOutputLocation;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnProcess;
    }
}

