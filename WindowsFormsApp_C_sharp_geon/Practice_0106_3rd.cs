using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp_C_sharp_geon
{
    public partial class Practice_0106_3rd : Form
    {
        private BackgroundWorker worker;
        private string[] allFiles;

        public Practice_0106_3rd()
        {
            InitializeComponent();

            // BackgroundWorker 초기화
            worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            // 이벤트 핸들러 등록
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string directoryPath = textBox1.Text;
            string fileExtension = string.IsNullOrWhiteSpace(textBox2.Text) ? "*.*" : textBox2.Text;

            if (string.IsNullOrWhiteSpace(directoryPath))
            {
                MessageBox.Show("Please enter a valid directory path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("The specified directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBox1.Items.Clear();

            if (worker.IsBusy)
            {
                MessageBox.Show("Task is already running.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            button1.Enabled = false;
            worker.RunWorkerAsync(new { DirectoryPath = directoryPath, FileExtension = fileExtension });
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var arguments = (dynamic)e.Argument;
            string directoryPath = arguments.DirectoryPath;
            string fileExtension = arguments.FileExtension;

            try
            {
                allFiles = Directory.GetFiles(directoryPath, fileExtension, SearchOption.AllDirectories);

                for (int i = 0; i < allFiles.Length; i++)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    worker.ReportProgress(i);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Access error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during file search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listBox1.Items.Add(allFiles[e.ProgressPercentage]);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Task was cancelled. Please try again.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("File search completed successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        
    }
}
