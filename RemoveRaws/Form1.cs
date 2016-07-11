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
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.selectedFolderLabel.Text = fbd.SelectedPath;
                this.scanButton.Enabled = true;
                this.fileListBox.Items.Clear();
            }
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            string folderPath = selectedFolderLabel.Text;
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Folder does not exist.");
                return;
            }
            fileListBox.Items.Clear();

            List<string> filePaths = new List<string>(Directory.GetFiles(folderPath));
            filePaths.Sort();
            HashSet<string> fileNames = new HashSet<string>();
            foreach (string filePath in filePaths)
                if (Path.GetExtension(filePath).ToLower() != ".cr2")
                    fileNames.Add(Path.GetFileNameWithoutExtension(filePath));

            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string extension = Path.GetExtension(filePath);
                bool remove = extension.ToLower() == ".cr2" && !fileNames.Contains(fileName);
                fileListBox.Items.Add(Path.GetFileName(filePath), remove);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
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

        private HashSet<string> GetExtensionsToRemove()
        {
            string unformattedExtensions = fileTypesTextBox.Text;
            return null;
        }
    }
}
