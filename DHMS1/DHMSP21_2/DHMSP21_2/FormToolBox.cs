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
    public partial class FormToolBox : Form
    {
        private static FormToolBox frm = null;

        //构造方法私有，外部代码不能直接用new实例化它
        private FormToolBox()
        {
            InitializeComponent();
        }

        public static FormToolBox GetInstance()
        {
            if(frm==null||frm.IsDisposed)
            {
                frm = new FormToolBox();
                frm.MdiParent = Form1.ActiveForm;
            }
            return frm;
        }
    }
}
