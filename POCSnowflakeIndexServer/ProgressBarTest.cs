using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POCSnowflakeIndexServer
{
    public partial class ProgressBarTest : Form
    {
        public ProgressBarTest()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            var progress = new Progress<int>(percent =>
            {
                progressBar1.Value = percent;

            });
            await Task.Run(() => DoSomething(progress));
        }

        public void DoSomething(IProgress<int> progress)
        {

            int i = 1;
            while (i < 100)
            {
                Thread.Sleep(100);
                if (progress != null)
                    progress.Report(i);
                i++;
            }
        }
    }
}
