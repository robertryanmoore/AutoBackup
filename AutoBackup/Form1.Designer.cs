namespace AutoBackup
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbOpenFile = new System.Windows.Forms.TextBox();
            this.txbSaveFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbOpenFile
            // 
            this.txbOpenFile.Location = new System.Drawing.Point(36, 26);
            this.txbOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbOpenFile.Name = "txbOpenFile";
            this.txbOpenFile.Size = new System.Drawing.Size(469, 20);
            this.txbOpenFile.TabIndex = 0;
            this.txbOpenFile.TabStop = false;
            // 
            // txbSaveFile
            // 
            this.txbSaveFile.Location = new System.Drawing.Point(36, 51);
            this.txbSaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSaveFile.Name = "txbSaveFile";
            this.txbSaveFile.Size = new System.Drawing.Size(469, 20);
            this.txbSaveFile.TabIndex = 1;
            this.txbSaveFile.TabStop = false;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.AutoSize = true;
            this.btnSelectFile.Location = new System.Drawing.Point(514, 26);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(92, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Target File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.AutoSize = true;
            this.btnSaveFile.Location = new System.Drawing.Point(514, 51);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(92, 23);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "Backup Folder";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnStartStop
            // 
            this.btnStartStop.AutoSize = true;
            this.btnStartStop.Location = new System.Drawing.Point(514, 84);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(92, 23);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 111);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txbSaveFile);
            this.Controls.Add(this.txbOpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Auto Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbOpenFile;
        private System.Windows.Forms.TextBox txbSaveFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnStartStop;
    }
}

