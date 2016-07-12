using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RemoveRaws
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            SelectFolder();
            ScanFolder();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            ScanFolder();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveSelected();
            ScanFolder();
        }

        private void SelectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.selectedFolderLabel.Text = fbd.SelectedPath;
                this.scanButton.Enabled = true;
                this.fileListBox.Items.Clear();
            }
        }

        private void ScanFolder()
        {
            fileListBox.Items.Clear();
            List<string> filePaths = GetFilesToScan();
            HashSet<string> extensions = GetExtensionsToRemove();

            HashSet<string> fileNames = new HashSet<string>();
            foreach (string filePath in filePaths)
                if (!extensions.Contains(Path.GetExtension(filePath).ToLower()))
                    fileNames.Add(Path.GetFileNameWithoutExtension(filePath));

            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string extension = Path.GetExtension(filePath);
                bool remove = extensions.Contains(extension.ToLower()) && !fileNames.Contains(fileName);
                fileListBox.Items.Add(Path.GetFileName(filePath), remove);
            }
            removeButton.Enabled = true;
        }

        private void RemoveSelected()
        {
            string folderPath = selectedFolderLabel.Text;
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Folder does not exist.");
                return;
            }
            foreach (string fileName in fileListBox.CheckedItems)
            {
                string path = Path.Combine(folderPath, fileName);
                File.Delete(path);
            }

        }

        private List<string> GetFilesToScan()
        {
            string folderPath = selectedFolderLabel.Text;
            List<string> filePaths = new List<string>(Directory.GetFiles(folderPath));
            filePaths.Sort();
            return filePaths;
        }

        private HashSet<string> GetExtensionsToRemove()
        {
            HashSet<string> extensions = new HashSet<string>();

            string unformattedExtensions = fileTypesTextBox.Text;
            foreach (string extension in unformattedExtensions.Split(','))
            {
                extensions.Add("." + extension.ToLower().Trim());
            }
            return extensions;
            // Hello World
        }
    }
}