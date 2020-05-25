namespace TestMultiThreading
{
    partial class FrmMultiThreading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblCount01 = new System.Windows.Forms.Label();
            this.LblCount02 = new System.Windows.Forms.Label();
            this.Bgw1 = new System.ComponentModel.BackgroundWorker();
            this.Bgw2 = new System.ComponentModel.BackgroundWorker();
            this.LblCount03 = new System.Windows.Forms.Label();
            this.CbxBackgroundWorker = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(154, 43);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(140, 48);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblCount01
            // 
            this.LblCount01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount01.Location = new System.Drawing.Point(135, 119);
            this.LblCount01.Name = "LblCount01";
            this.LblCount01.Size = new System.Drawing.Size(179, 50);
            this.LblCount01.TabIndex = 1;
            this.LblCount01.Text = "0";
            this.LblCount01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCount02
            // 
            this.LblCount02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount02.Location = new System.Drawing.Point(135, 198);
            this.LblCount02.Name = "LblCount02";
            this.LblCount02.Size = new System.Drawing.Size(179, 50);
            this.LblCount02.TabIndex = 2;
            this.LblCount02.Text = "0";
            this.LblCount02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bgw1
            // 
            this.Bgw1.WorkerReportsProgress = true;
            this.Bgw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw1_DoWork);
            this.Bgw1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Bgw1_ProgressChanged);
            this.Bgw1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bgw1_RunWorkerCompleted);
            // 
            // Bgw2
            // 
            this.Bgw2.WorkerReportsProgress = true;
            this.Bgw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw2_DoWork);
            this.Bgw2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Bgw2_ProgressChanged);
            this.Bgw2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bgw2_RunWorkerCompleted);
            // 
            // LblCount03
            // 
            this.LblCount03.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount03.Location = new System.Drawing.Point(135, 272);
            this.LblCount03.Name = "LblCount03";
            this.LblCount03.Size = new System.Drawing.Size(179, 50);
            this.LblCount03.TabIndex = 3;
            this.LblCount03.Text = "0";
            this.LblCount03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxBackgroundWorker
            // 
            this.CbxBackgroundWorker.AutoSize = true;
            this.CbxBackgroundWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxBackgroundWorker.Location = new System.Drawing.Point(126, 366);
            this.CbxBackgroundWorker.Name = "CbxBackgroundWorker";
            this.CbxBackgroundWorker.Size = new System.Drawing.Size(197, 28);
            this.CbxBackgroundWorker.TabIndex = 4;
            this.CbxBackgroundWorker.Text = "Background Worker";
            this.CbxBackgroundWorker.UseVisualStyleBackColor = true;
            // 
            // FrmMultiThreading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.CbxBackgroundWorker);
            this.Controls.Add(this.LblCount03);
            this.Controls.Add(this.LblCount02);
            this.Controls.Add(this.LblCount01);
            this.Controls.Add(this.BtnStart);
            this.Name = "FrmMultiThreading";
            this.Text = "Multi-Threading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblCount01;
        private System.Windows.Forms.Label LblCount02;
        private System.ComponentModel.BackgroundWorker Bgw1;
        private System.ComponentModel.BackgroundWorker Bgw2;
        private System.Windows.Forms.Label LblCount03;
        private System.Windows.Forms.CheckBox CbxBackgroundWorker;
    }
}

