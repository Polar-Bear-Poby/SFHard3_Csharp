using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp_C_sharp_geon
{
    public partial class Practice_0106 : Form
    {
        private BackgroundWorker worker;
        public Practice_0106()
        {
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            
            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            
            this.worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            this.worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Completed);
            
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(30);
                this.worker.ReportProgress(i);    
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Worker_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("Completed");
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
            while (true)
            {
                progressBar1.Value += 1;
                if (progressBar1.Value >= 100) break;
                
            }
            if (!this.worker.IsBusy) this.worker.RunWorkerAsync();
        }
    }
}