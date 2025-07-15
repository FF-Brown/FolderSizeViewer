
namespace FolderSizeViewer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSelectFolder = new Button();
            listView1 = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderSize = new ColumnHeader();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(12, 12);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(110, 30);
            btnSelectFolder.TabIndex = 0;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderSize });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 50);
            listView1.Name = "listView1";
            listView1.Size = new Size(460, 300);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 300;
            // 
            // columnHeaderSize
            // 
            columnHeaderSize.Text = "Size";
            columnHeaderSize.Width = 150;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(151, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(321, 30);
            progressBar1.TabIndex = 2;
            // 
            // MainForm
            // 
            ClientSize = new Size(484, 361);
            Controls.Add(progressBar1);
            Controls.Add(listView1);
            Controls.Add(btnSelectFolder);
            Name = "MainForm";
            Text = "Folder Size Viewer";
            ResumeLayout(false);
        }
        private ProgressBar progressBar1;
    }
}
