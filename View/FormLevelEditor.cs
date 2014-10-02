using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGame.View
{
    public partial class FormLevelEditor : Form
    {
        public FormLevelEditor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximumSize = new Size(1366, 768);
            this.MinimumSize = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
