using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup
{
    public partial class Form1 : Form
    {

        string targetPath;
        string targetFileName;
        string backupDir;

        FileSystemWatcher watcher = new FileSystemWatcher();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"D:\OneDrive\Work\Code\C#\AutoBackup";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                targetPath = openFileDialog.FileName;
                targetFileName = openFileDialog.SafeFileName;
                txbOpenFile.Text = openFileDialog.FileName;
                
            }

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                backupDir = folderBrowserDialog.SelectedPath;
                txbSaveFile.Text = backupDir;
            }
        }
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void btnStartStop_Click(object sender, EventArgs e)
        {

            if (btnStartStop.Text.Equals("Start"))
            {

                watcher.Path = Path.GetDirectoryName(targetPath);
                watcher.Filter = targetFileName;

                // Watch for changes in LastAccess and LastWrite times, and
                // the renaming of files or directories.
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;


                // Add event handlers.
                watcher.Changed += OnChanged;

                // Begin watching.
                watcher.EnableRaisingEvents = true;
                btnStartStop.Text = "Stop";
            }
            else
            {
                // Stop watching.
                watcher.EnableRaisingEvents = false;
                btnStartStop.Text = "Start";
            }
                
           
         }

            void OnChanged(object source, FileSystemEventArgs e)
            {

               string timeStamp = DateTime.Now.ToString("hhmmss dd-MM-yyyy");
               string fileName = targetFileName.Insert(targetFileName.LastIndexOf('.'), " " + timeStamp);
               
               // Specify what is done when a file is changed
               File.Copy(targetPath, backupDir + "\\" + fileName);
            }
        }
    }

