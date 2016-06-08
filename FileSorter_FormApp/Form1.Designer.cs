namespace FileSorter_FormApp
{
    partial class FileSorterForm
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
            this.chooseDir = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupSubDirs = new System.Windows.Forms.GroupBox();
            this.ExcludeSubDirs = new System.Windows.Forms.RadioButton();
            this.IncludeSubDirs = new System.Windows.Forms.RadioButton();
            this.removeCheckedFiles = new System.Windows.Forms.Button();
            this.folderOutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createFoldersByYear = new System.Windows.Forms.RadioButton();
            this.createFoldersByMonth = new System.Windows.Forms.RadioButton();
            this.createFoldersByDay = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyFiles = new System.Windows.Forms.RadioButton();
            this.moveFiles = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.gatherFiles = new System.Windows.Forms.Button();
            this.groupSubDirs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseDir
            // 
            this.chooseDir.Location = new System.Drawing.Point(40, 12);
            this.chooseDir.Name = "chooseDir";
            this.chooseDir.Size = new System.Drawing.Size(101, 34);
            this.chooseDir.TabIndex = 0;
            this.chooseDir.Text = "Choose Folder to Sort";
            this.chooseDir.UseVisualStyleBackColor = true;
            this.chooseDir.Click += new System.EventHandler(this.chooseDir_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(186, 23);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(238, 319);
            this.checkedListBox.TabIndex = 2;
            this.checkedListBox.ThreeDCheckBoxes = true;
            // 
            // groupSubDirs
            // 
            this.groupSubDirs.Controls.Add(this.ExcludeSubDirs);
            this.groupSubDirs.Controls.Add(this.IncludeSubDirs);
            this.groupSubDirs.Location = new System.Drawing.Point(10, 53);
            this.groupSubDirs.Name = "groupSubDirs";
            this.groupSubDirs.Size = new System.Drawing.Size(167, 68);
            this.groupSubDirs.TabIndex = 3;
            this.groupSubDirs.TabStop = false;
            this.groupSubDirs.Text = "Include Subfolders?";
            // 
            // ExcludeSubDirs
            // 
            this.ExcludeSubDirs.AutoSize = true;
            this.ExcludeSubDirs.Enabled = false;
            this.ExcludeSubDirs.Location = new System.Drawing.Point(6, 42);
            this.ExcludeSubDirs.Name = "ExcludeSubDirs";
            this.ExcludeSubDirs.Size = new System.Drawing.Size(39, 17);
            this.ExcludeSubDirs.TabIndex = 1;
            this.ExcludeSubDirs.TabStop = true;
            this.ExcludeSubDirs.Text = "No";
            this.ExcludeSubDirs.UseVisualStyleBackColor = true;
            // 
            // IncludeSubDirs
            // 
            this.IncludeSubDirs.AutoSize = true;
            this.IncludeSubDirs.Enabled = false;
            this.IncludeSubDirs.Location = new System.Drawing.Point(6, 19);
            this.IncludeSubDirs.Name = "IncludeSubDirs";
            this.IncludeSubDirs.Size = new System.Drawing.Size(43, 17);
            this.IncludeSubDirs.TabIndex = 0;
            this.IncludeSubDirs.TabStop = true;
            this.IncludeSubDirs.Text = "Yes";
            this.IncludeSubDirs.UseVisualStyleBackColor = true;
            // 
            // removeCheckedFiles
            // 
            this.removeCheckedFiles.Enabled = false;
            this.removeCheckedFiles.Location = new System.Drawing.Point(320, 356);
            this.removeCheckedFiles.Name = "removeCheckedFiles";
            this.removeCheckedFiles.Size = new System.Drawing.Size(104, 23);
            this.removeCheckedFiles.TabIndex = 4;
            this.removeCheckedFiles.Text = "Remove Checked";
            this.removeCheckedFiles.UseVisualStyleBackColor = true;
            this.removeCheckedFiles.Click += new System.EventHandler(this.removeCheckedFiles_Click);
            // 
            // folderOutput
            // 
            this.folderOutput.AutoSize = true;
            this.folderOutput.Location = new System.Drawing.Point(183, 7);
            this.folderOutput.Name = "folderOutput";
            this.folderOutput.Size = new System.Drawing.Size(116, 13);
            this.folderOutput.TabIndex = 5;
            this.folderOutput.Text = "Files that will be sorted.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createFoldersByYear);
            this.groupBox1.Controls.Add(this.createFoldersByMonth);
            this.groupBox1.Controls.Add(this.createFoldersByDay);
            this.groupBox1.Location = new System.Drawing.Point(10, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 88);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create folders by:";
            // 
            // createFoldersByYear
            // 
            this.createFoldersByYear.AutoSize = true;
            this.createFoldersByYear.Enabled = false;
            this.createFoldersByYear.Location = new System.Drawing.Point(6, 65);
            this.createFoldersByYear.Name = "createFoldersByYear";
            this.createFoldersByYear.Size = new System.Drawing.Size(47, 17);
            this.createFoldersByYear.TabIndex = 2;
            this.createFoldersByYear.TabStop = true;
            this.createFoldersByYear.Text = "Year";
            this.createFoldersByYear.UseVisualStyleBackColor = true;
            // 
            // createFoldersByMonth
            // 
            this.createFoldersByMonth.AutoSize = true;
            this.createFoldersByMonth.Enabled = false;
            this.createFoldersByMonth.Location = new System.Drawing.Point(6, 42);
            this.createFoldersByMonth.Name = "createFoldersByMonth";
            this.createFoldersByMonth.Size = new System.Drawing.Size(55, 17);
            this.createFoldersByMonth.TabIndex = 1;
            this.createFoldersByMonth.TabStop = true;
            this.createFoldersByMonth.Text = "Month";
            this.createFoldersByMonth.UseVisualStyleBackColor = true;
            // 
            // createFoldersByDay
            // 
            this.createFoldersByDay.AutoSize = true;
            this.createFoldersByDay.Enabled = false;
            this.createFoldersByDay.Location = new System.Drawing.Point(6, 19);
            this.createFoldersByDay.Name = "createFoldersByDay";
            this.createFoldersByDay.Size = new System.Drawing.Size(44, 17);
            this.createFoldersByDay.TabIndex = 0;
            this.createFoldersByDay.TabStop = true;
            this.createFoldersByDay.Text = "Day";
            this.createFoldersByDay.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copyFiles);
            this.groupBox2.Controls.Add(this.moveFiles);
            this.groupBox2.Location = new System.Drawing.Point(10, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 65);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move or Copy files?";
            // 
            // copyFiles
            // 
            this.copyFiles.AutoSize = true;
            this.copyFiles.Enabled = false;
            this.copyFiles.Location = new System.Drawing.Point(6, 19);
            this.copyFiles.Name = "copyFiles";
            this.copyFiles.Size = new System.Drawing.Size(49, 17);
            this.copyFiles.TabIndex = 1;
            this.copyFiles.TabStop = true;
            this.copyFiles.Text = "Copy";
            this.copyFiles.UseVisualStyleBackColor = true;
            // 
            // moveFiles
            // 
            this.moveFiles.AutoSize = true;
            this.moveFiles.Enabled = false;
            this.moveFiles.Location = new System.Drawing.Point(6, 42);
            this.moveFiles.Name = "moveFiles";
            this.moveFiles.Size = new System.Drawing.Size(52, 17);
            this.moveFiles.TabIndex = 0;
            this.moveFiles.TabStop = true;
            this.moveFiles.Text = "Move";
            this.moveFiles.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "--------------------------------";
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(41, 331);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 37);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(7, 371);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 8;
            // 
            // gatherFiles
            // 
            this.gatherFiles.Enabled = false;
            this.gatherFiles.Location = new System.Drawing.Point(52, 127);
            this.gatherFiles.Name = "gatherFiles";
            this.gatherFiles.Size = new System.Drawing.Size(75, 23);
            this.gatherFiles.TabIndex = 9;
            this.gatherFiles.Text = "Gather Files";
            this.gatherFiles.UseVisualStyleBackColor = true;
            this.gatherFiles.Click += new System.EventHandler(this.gatherFiles_Click);
            // 
            // FileSorterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 391);
            this.Controls.Add(this.gatherFiles);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.folderOutput);
            this.Controls.Add(this.removeCheckedFiles);
            this.Controls.Add(this.groupSubDirs);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.chooseDir);
            this.MaximizeBox = false;
            this.Name = "FileSorterForm";
            this.Text = "FileSorter";
            this.groupSubDirs.ResumeLayout(false);
            this.groupSubDirs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseDir;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.GroupBox groupSubDirs;
        private System.Windows.Forms.RadioButton ExcludeSubDirs;
        private System.Windows.Forms.RadioButton IncludeSubDirs;
        private System.Windows.Forms.Button removeCheckedFiles;
        private System.Windows.Forms.Label folderOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton createFoldersByYear;
        private System.Windows.Forms.RadioButton createFoldersByMonth;
        private System.Windows.Forms.RadioButton createFoldersByDay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RadioButton copyFiles;
        private System.Windows.Forms.RadioButton moveFiles;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button gatherFiles;
    }
}

