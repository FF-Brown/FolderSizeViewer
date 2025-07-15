
using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace FolderSizeViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            string selectedPath = dialog.SelectedPath;
            listView1.Items.Clear();
            progressBar1.Value = 0;

            var entries = Directory.GetFileSystemEntries(selectedPath);
            progressBar1.Maximum = entries.Length;
            progressBar1.Step = 1;

            await Task.Run(() =>
            {
                foreach (var entry in entries)
                {
                    long size = FolderScanner.GetSize(entry);
                    string name = Path.GetFileName(entry);
                    string sizeFormatted = size.ToString("N0") + " bytes";

                    // Update UI on the main thread
                    Invoke(() =>
                    {
                        var item = new ListViewItem(new[] { name, sizeFormatted });
                        listView1.Items.Add(item);
                        progressBar1.PerformStep();
                    });
                }
            });

            progressBar1.Value = progressBar1.Maximum;
        }
    }
}
