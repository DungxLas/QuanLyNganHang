﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNganHang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public CoKyHan ooo { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            //CoKyHan stk = new CoKyHan();

            cBxKyHanGui.Items.Add("01 tháng / 5.65%");
            cBxKyHanGui.Items.Add("03 tháng / 6.00%");
            cBxKyHanGui.Items.Add("06 tháng / 7.60%");
            cBxKyHanGui.Items.Add("12 tháng / 8.04%");
            cBxKyHanGui.Items.Add("18 tháng / 8.40%");

            cBxKyHanGui.SelectedIndex = 0;
        }
    }
}
