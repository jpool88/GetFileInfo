using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateFileInfo
{
    public partial class UpdateFileInfo : Form
    {
        public UpdateFileInfo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtInputFileLocation.Text == "")
            {
                MessageBox.Show("Input file loctation cannot be empty", "Error!");
                return;
            }                

            if (!Directory.Exists(txtInputFileLocation.Text))
            {
                MessageBox.Show("Input file directory not found", "Error!");
                return;
            }

            if (txtOutputFileLocation.Text == "")
            {
                MessageBox.Show("Output file cannot be empty", "Error!");
                return;
            }

            if (!Directory.Exists(txtOutputFileLocation.Text))
                CreateOutputDirectory(txtOutputFileLocation.Text);

            if (txtDataFileName.Text == "")
            {
                MessageBox.Show("Data file name cannot be empty", "Error!");
                return;
            }

            if (!File.Exists(txtDataFileName.Text))
            {
                MessageBox.Show("Data file could not be found", "Error!");
                return;
            } 

            var fileNames = GetFileNames(txtDataFileName.Text);
            CopyAndRenameFiles(fileNames);

            MessageBox.Show("Process Complete", "Process Complete");
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                txtInputFileLocation.Text = folderBrowserDialog.SelectedPath;
                btn1.Enabled = true;
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                txtOutputFileLocation.Text = folderBrowserDialog.SelectedPath;
                btn1.Enabled = true;
            }
        }

        private void btnBrowse3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                txtDataFileName.Text = folderBrowserDialog.SelectedPath;
                btn1.Enabled = true;
            }
        }

        private string[] GetFileNames(string DataFile)
        {
            var FileNames = File.ReadAllLines(DataFile);

            return FileNames;
        }

        private void CopyAndRenameFiles(string[] FileNames)
        {
            for (int i = 0; i < FileNames.Length; i++)
            {
                var inFile = Path.Combine(txtInputFileLocation.Text, FileNames[i].Split(',').First().ToString());
                var outFile = Path.Combine(txtOutputFileLocation.Text, FileNames[i].Split(',').Last().ToString());

                if (!File.Exists(inFile))
                {
                    MessageBox.Show($"File {inFile} cannot be found", "Error!");
                    continue;
                }

                File.Copy(inFile, outFile);
            }   
        }

        private void CreateOutputDirectory(string DirectoryName)
        {
            Directory.CreateDirectory(DirectoryName);
        }
    }
}
