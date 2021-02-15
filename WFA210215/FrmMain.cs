using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210215
{
    public partial class FrmMain : Form
    {
        int alapAr = 100;
        int extraAr = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void AlapTermekCheckedChanged(object sender, EventArgs e)
        {
            lblAr.Text = "###";
            cbTej.Enabled = !rbTea.Checked;

            if (rbKV.Checked) alapAr = 100;
            else if (rbTea.Checked)
            {
                alapAr = 80;
                cbTej.Checked = false;
            }
            else if (rbCsoki.Checked) alapAr = 120;
        }

        private void BtnSzamolClick(object sender, EventArgs e)
        {
            lblAr.Text = $"{alapAr + extraAr} Ft";
        }

        private void ExtraCheckedChanged(object sender, EventArgs e)
        {
            lblAr.Text = "###";
            extraAr = 0;
            if (cbPohar.Checked) extraAr -= 10;
            if (cbTej.Checked) extraAr += 10;
            if (cbCukor.Checked) extraAr += 20;
        }
    }
}
