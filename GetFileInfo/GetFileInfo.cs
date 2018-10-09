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

namespace GetFileInfo
{
    public partial class formGetFileInfo : Form
    {
        public formGetFileInfo()
        {
            InitializeComponent();
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                txtInfolder.Text = folderBrowserDialog.SelectedPath;
                btnProcess.Enabled = true;
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                txtOutLocation.Text = folderBrowserDialog.SelectedPath;
                btnProcess.Enabled = true;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var outputFile = $"{txtOutLocation.Text}\\FileInfo.csv";

            if (File.Exists(outputFile) != false)
                File.Delete(outputFile);

            string[] files = Directory.GetFiles(txtInfolder.Text);
            List<string> lines = new List<string>();
            Parallel.ForEach(files, file =>
            {
                var fileinfo = new FileInfo(file);
                var filesize = fileinfo.Length /1000;
                var filename = Path.GetFileName(file);
                var filetype = Path.GetExtension(filename).TrimStart('.');
                var output = $"{filetype},{filename},{filesize}\r\n";

                lines.Add(output);
            });
            foreach (string line in lines)
            {
                File.AppendAllText(outputFile, line);
            }
            MessageBox.Show("Process Complete", "Process Complete");
        }
    }
}
