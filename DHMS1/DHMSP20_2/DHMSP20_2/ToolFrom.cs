using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHMSP21_2
{
    public partial class ToolFrom : Form
    {
        private static ToolFrom tolFrom = null;

        private ToolFrom()
        {
            InitializeComponent();
        }

        public static ToolFrom GetInstance()
        {
            if (tolFrom == null || tolFrom.IsDisposed)
            {
                tolFrom = new ToolFrom();
                tolFrom.MdiParent = Form.ActiveForm;
            }
            return tolFrom;
        }
    }
}
