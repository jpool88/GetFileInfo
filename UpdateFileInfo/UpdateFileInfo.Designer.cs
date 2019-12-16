namespace UpdateFileInfo
{
    partial class UpdateFileInfo
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txtInputFileLocation = new System.Windows.Forms.TextBox();
            this.lblInputFileLocation = new System.Windows.Forms.Label();
            this.lblOutputFileLocation = new System.Windows.Forms.Label();
            this.txtOutputFileLocation = new System.Windows.Forms.TextBox();
            this.lblDataFileName = new System.Windows.Forms.Label();
            this.txtDataFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(545, 204);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(86, 19);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "DO IT !";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtInputFileLocation
            // 
            this.txtInputFileLocation.Location = new System.Drawing.Point(12, 45);
            this.txtInputFileLocation.Name = "txtInputFileLocation";
            this.txtInputFileLocation.Size = new System.Drawing.Size(512, 20);
            this.txtInputFileLocation.TabIndex = 1;
            // 
            // lblInputFileLocation
            // 
            this.lblInputFileLocation.AutoSize = true;
            this.lblInputFileLocation.Location = new System.Drawing.Point(12, 29);
            this.lblInputFileLocation.Name = "lblInputFileLocation";
            this.lblInputFileLocation.Size = new System.Drawing.Size(94, 13);
            this.lblInputFileLocation.TabIndex = 2;
            this.lblInputFileLocation.Text = "Input File Location";
            // 
            // lblOutputFileLocation
            // 
            this.lblOutputFileLocation.AutoSize = true;
            this.lblOutputFileLocation.Location = new System.Drawing.Point(12, 73);
            this.lblOutputFileLocation.Name = "lblOutputFileLocation";
            this.lblOutputFileLocation.Size = new System.Drawing.Size(102, 13);
            this.lblOutputFileLocation.TabIndex = 4;
            this.lblOutputFileLocation.Text = "Output File Location";
            // 
            // txtOutputFileLocation
            // 
            this.txtOutputFileLocation.Location = new System.Drawing.Point(12, 89);
            this.txtOutputFileLocation.Name = "txtOutputFileLocation";
            this.txtOutputFileLocation.Size = new System.Drawing.Size(512, 20);
            this.txtOutputFileLocation.TabIndex = 3;
            // 
            // lblDataFileName
            // 
            this.lblDataFileName.AutoSize = true;
            this.lblDataFileName.Location = new System.Drawing.Point(12, 117);
            this.lblDataFileName.Name = "lblDataFileName";
            this.lblDataFileName.Size = new System.Drawing.Size(80, 13);
            this.lblDataFileName.TabIndex = 6;
            this.lblDataFileName.Text = "Data File Name";
            // 
            // txtDataFileName
            // 
            this.txtDataFileName.Location = new System.Drawing.Point(12, 133);
            this.txtDataFileName.Name = "txtDataFileName";
            this.txtDataFileName.Size = new System.Drawing.Size(512, 20);
            this.txtDataFileName.TabIndex = 5;
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(540, 45);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(90, 20);
            this.btnBrowse1.TabIndex = 7;
            this.btnBrowse1.Text = "Browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(540, 89);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(90, 20);
            this.btnBrowse2.TabIndex = 8;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.Location = new System.Drawing.Point(540, 132);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(90, 20);
            this.btnBrowse3.TabIndex = 9;
            this.btnBrowse3.Text = "Browse";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Click += new System.EventHandler(this.btnBrowse3_Click);
            // 
            // UpdateFileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 235);
            this.Controls.Add(this.btnBrowse3);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.lblDataFileName);
            this.Controls.Add(this.txtDataFileName);
            this.Controls.Add(this.lblOutputFileLocation);
            this.Controls.Add(this.txtOutputFileLocation);
            this.Controls.Add(this.lblInputFileLocation);
            this.Controls.Add(this.txtInputFileLocation);
            this.Controls.Add(this.btn1);
            this.Name = "UpdateFileInfo";
            this.Text = "UpdateFileInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtInputFileLocation;
        private System.Windows.Forms.Label lblInputFileLocation;
        private System.Windows.Forms.Label lblOutputFileLocation;
        private System.Windows.Forms.TextBox txtOutputFileLocation;
        private System.Windows.Forms.Label lblDataFileName;
        private System.Windows.Forms.TextBox txtDataFileName;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnBrowse3;
    }
}

