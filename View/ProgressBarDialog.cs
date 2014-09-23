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
        public UpdateProgressBar updateProgressBar;

        public ProgressBarDialog()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            updateProgressBar += InitProgressBar;
            this.Show();
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
