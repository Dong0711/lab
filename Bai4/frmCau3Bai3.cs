﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmCau3Bai3 : Form
    {
        public frmCau3Bai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXinChao_Click(object sender, EventArgs e)
        { string gioiTinh;
            if (rdbNam.Checked)
                gioiTinh = "ông";
            else gioiTinh = "bà";
            MessageBox.Show("Xin chào " + gioiTinh + " " + txtTen.Text);
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string kq = TinhToan.TimUCLN(int.Parse(txta.Text), int.Parse(txtb.Text)).ToString();
            MessageBox.Show("Ước số chung lớn nhất của 2 số "+ txta.Text+" và "+txtb.Text+" là : "+kq);
        }
    }
}
