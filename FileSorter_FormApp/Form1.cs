using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSorter_FormApp
{
    public partial class FileSorterForm : Form
    {
        public FileSorterForm()
        {
            InitializeComponent();
        }

        string dirPath;

        List<string> filePaths = new List<string>();
        List<FileDetail> fileDetailList = new List<FileDetail>();

        private void chooseDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DialogSelectDir = new FolderBrowserDialog();
            DialogSelectDir.Description = "Select a folder to sort.";

            if (DialogSelectDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dirPath = DialogSelectDir.SelectedPath;
            }
            else
            {
                MessageBox.Show("Folder not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dirPath = "";
            }

            if (dirPath != "")
            {
                IncludeSubDirs.Enabled = true;
                ExcludeSubDirs.Enabled = true;
                gatherFiles.Enabled = true;
            }
        }

        private void gatherFiles_Click(object sender, EventArgs e)
        {
            filePaths.Clear();
            checkedListBox.Items.Clear();
            fileDetailList.Clear();

            if (IncludeSubDirs.Checked == true)
            {
                filePaths = Directory.GetFiles(dirPath, "*.*", SearchOption.AllDirectories).ToList();
            }
            else if (ExcludeSubDirs.Checked == true)
            {
                filePaths = Directory.GetFiles(dirPath, "*.*", SearchOption.TopDirectoryOnly).ToList();
            }
            else
            {
                MessageBox.Show("Include subfolders or not? Please make a selection and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            int count = 0;
            foreach (string filePath in filePaths)
            {
                DateTime date = GetDateTakenOrModified(filePath);

                int indexOfLastBSlash = filePath.LastIndexOf("\\");
                string fileName = filePath.Substring(indexOfLastBSlash + 1);

                fileDetailList.Add(new FileDetail(fileName, filePath, date));

                count += 1;
            }

            PopulateCheckedListBox(fileDetailList, checkedListBox);

            int index = dirPath.LastIndexOf("\\");
            string folderName = dirPath.Substring(index + 1);

            folderOutput.Text = "Files in " + folderName + " that will be sorted.";

            copyFiles.Enabled = true;
            moveFiles.Enabled = true;
            createFoldersByDay.Enabled = true;
            createFoldersByMonth.Enabled = true;
            createFoldersByYear.Enabled = true;
            removeCheckedFiles.Enabled = true;
            submitButton.Enabled = true;
        }

        private void removeCheckedFiles_Click(object sender, EventArgs e)
        {
            foreach (string checkedName in checkedListBox.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox.Items.Remove(checkedName);

                fileDetailList.RemoveAll(x => x.Name == checkedName);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            fileDetailList.Sort(new Comparison<FileDetail>((x, y) => DateTime.Compare(x.Date, y.Date)));
            
            if (!createFoldersByDay.Checked && !createFoldersByMonth.Checked && !createFoldersByYear.Checked)
            {
                MessageBox.Show("Create Folders by not selected.  Select Day, Month, or Year and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (!moveFiles.Checked && !copyFiles.Checked)
            {
                MessageBox.Show("Move or Copy files not selected.  Select Move or Copy and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            int copyOrMoveCounter = 0;
            int directoryCounter = 0;

            foreach (FileDetail file in fileDetailList)
            {
                string newFileDestination = "";

                if (createFoldersByDay.Checked)
                {
                    newFileDestination = dirPath + "\\" + file.Date.Year + "-" + file.Date.Month + "-" + file.Date.Day + " " + file.Date.DayOfWeek;
                }
                else if (createFoldersByMonth.Checked)
                {
                    newFileDestination = dirPath + "\\" + file.Date.Year + "-" + file.Date.Month;
                }
                else
                {
                    newFileDestination = dirPath + "\\" + file.Date.Year;
                }

                int index = file.Path.LastIndexOf("\\");
                string fileName = file.Path.Substring(index + 1);

                if (!Directory.Exists(newFileDestination))
                {
                    Directory.CreateDirectory(newFileDestination);
                    directoryCounter += 1;
                }

                if (!File.Exists(newFileDestination + "\\" + fileName))
                {
                    copyOrMoveCounter += 1;

                    if (copyFiles.Checked)
                    {
                        File.Copy(file.Path, (newFileDestination + "\\" + fileName));

                        outputLabel.Text = "Copied " + copyOrMoveCounter + " files of total " + filePaths.Count +
                            ".  Created " + directoryCounter + " new folders.";
                    }
                    else if (moveFiles.Checked)
                    {
                        File.Move(file.Path, (newFileDestination + "\\" + fileName));

                        outputLabel.Text = "Moved " + copyOrMoveCounter + " files of total " + filePaths.Count +
                            ".  Created " + directoryCounter + " new folders.";

                        submitButton.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Internal Error. Function: submitButton_Click. Please restart the program.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
        }
        
        /// <summary>
        /// Return the date the image was taken if available or if not the file last modified (FileInfo.LastWriteTime)
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static DateTime GetDateTakenOrModified(string filePath)
        {
            string fullDate;
            DateTime date = new System.IO.FileInfo(filePath).LastWriteTime; //assume property is not available from image

            PropertyItem dateProp = null;

            Image myImage = null;

            try
            {
                myImage = Image.FromFile(filePath);
                dateProp = myImage.GetPropertyItem(36867);
            }

            catch (Exception)
            {
                Console.WriteLine(filePath + " (no date taken property - getting date modified).");
            }

            finally
            {
                if (myImage != null)
                {
                    myImage.Dispose();
                    myImage = null;
                }
            }

            if (dateProp != null)
            {
                // fullDate = "2014:12:29 11:00:05\0"
                fullDate = Encoding.UTF8.GetString(dateProp.Value).Trim();

                int seperator = fullDate.IndexOf(" ");
                // dayMonthYear = "2014:12:29"
                string dayMonthYear = fullDate.Substring(0, seperator);
                // dayMonthYear = "2014-12-29"
                dayMonthYear = dayMonthYear.Replace(":", "-");

                // time = " 11:00:05\0"
                string time = fullDate.Substring(seperator, fullDate.Length - seperator);
                // time = "11:00:05"
                time = time.Substring(0, 9);

                // "2014-12-29 11:00:05"
                date = DateTime.Parse(dayMonthYear + time);
            }


            return date;
        }
        
        /// <summary>
        /// Populates a CheckedListBox with "X" amount of strings.
        /// </summary>
        /// <param name="list">A list of strings you want to populate into a CheckedListBox.</param>
        /// <param name="box">Name of the CheckedListBox you want to populate.</param>
        private void PopulateCheckedListBox(List<FileDetail> list, CheckedListBox box)
        {
            foreach (FileDetail elm in list)
            {
                box.Items.Add(elm.Name);
            }
        }

        public class FileDetail
        {
            private string _name;
            private string _path;
            private DateTime _date;

            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            public string Path
            {
                get { return this._path; }
                set { this._path = value; }
            }
            public DateTime Date
            {
                get { return this._date; }
                set { this._date = value; }
            }

            public FileDetail(string name, string path, DateTime date)
            {
                this._name = name;
                this._path = path;
                this._date = date;
            }
        }

        
    }
}
