using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHMSP2
{
    public partial class Form1 : Form
    {
        double total = 0.0d;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashSuper csuper = CashFactory.createCashAccept(comboBox1.SelectedItem.ToString());
            double totalPrice = 0d;
            totalPrice = csuper.acceptCash(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total = total + totalPrice;
            lbxInfo.Items.Add("单价：" + txtPrice.Text + " 数量：" + txtNum.Text + " 合计：" + totalPrice);
            lblTotal.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashContext cc = new CashContext(comboBox1.SelectedItem.ToString());
            //switch (comboBox1.SelectedItem.ToString())
            //{
            //    case "正常收费":
            //        cc = new CashContext(new CashNormal());
            //        break;
            //    case "满300百送100":
            //        cc = new CashContext(new CashReturn("300", "100"));
            //        break;
            //    case "打8折":
            //        cc = new CashContext(new CashRebate("0.8"));
            //        break;
            //}

            double totalPrice = 0d;
            totalPrice = cc.GetResult((Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text)));
            total = total + totalPrice;
            lbxInfo.Items.Add("单价：" + txtPrice.Text + " 数量：" + txtNum.Text + " 合计：" + totalPrice);
            lblTotal.Text = total.ToString();
        }
            
    }
}
