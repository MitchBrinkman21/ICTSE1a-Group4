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

namespace WarGame.View
{
    public partial class ProgressBarDialog : Form
    {
        public delegate void UpdateProgressBar(int max, int value);
        FormImportLevelStatus status = new FormImportLevelStatus();
        public UpdateProgressBar updateProgressBar;

        public ProgressBarDialog()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            updateProgressBar += InitProgressBar;
            this.Show();
            status.Show();
        }

        public void InitProgressBar(int max, int value)
        {
            progressBar.Maximum = max;
            DoWork(value);
        }

        public void DoWork(int value)
        {
            progressBar.Value = value;
        }
    }
}
