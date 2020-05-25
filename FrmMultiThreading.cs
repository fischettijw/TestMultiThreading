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
using System.Windows.Threading;

namespace TestMultiThreading
{
    public partial class FrmMultiThreading : Form
    {
        int i1 = 0;
        int i2 = 0;
        public FrmMultiThreading()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (CbxBackgroundWorker.Checked)
            {
                Bgw1.RunWorkerAsync();
                Bgw2.RunWorkerAsync();
            }
            else
            {
                for (int i = 0; i < 201; i++)
                {
                    Thread.Sleep(50);
                    LblCount03.Text = i.ToString();
                }
            }
        }

        private void Bgw1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (i1 = 0; i1 < 200; i1++)
            {
                Thread.Sleep(55);

                Bgw1.ReportProgress(i1 / 100);
            }
        }

        private void Bgw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LblCount01.Text = i1.ToString();
        }

        private void Bgw1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //LblCount01.Text = i1.ToString();
            BtnStart.Text = "01 FINISHED";
        }


        private void Bgw2_DoWork(object sender, DoWorkEventArgs e)
        {
            for (i2 = 0; i2 < 200; i2++)
            {
                Thread.Sleep(50);

                Bgw2.ReportProgress(i2 / 100);
            }
        }

        private void Bgw2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LblCount02.Text = i2.ToString();
        }

        private void Bgw2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnStart.Text = "02 FINISHED";
        }
    }
}
