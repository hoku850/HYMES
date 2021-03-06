﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAS.Modularization;
namespace HYMes.WinUI.Tracking
{
    [Module("576E230F-3FFE-4AA1-91D9-B5AC820DE594","产品过账-组料站", "产品Tracking基本界面")]
    public partial class FrmTrackAssembly : UserControl
    {
        public FrmTrackAssembly()
        {
            InitializeComponent();
        }
        [ModuleStart()]
        public void StartEx()
        {
            this.Initialize();
        }
        private void txtSN_TextChanged(object sender, EventArgs e)
        {
           
        }
        internal void Initialize()
        {
            this.txtSN.Text = "";
            this.txtSN.Focus();
        }
        private void txtSN_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (e.KeyChar.ToString() == Keys.Enter.ToString())
            if(e.KeyChar==13)
            {
                if (this.txtSN.Text.Trim().Length == 0)
                {
                    DialogResult di = MessageBox.Show("SN不能为空，请重新刷入", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    this.txtSN.Focus();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSN_Enter(object sender, EventArgs e)
        {
            this.txtSN.BackColor = Color.Orange;
        }

        private void txtSN_Leave(object sender, EventArgs e)
        {
            //if (this.txtSN.Text.Trim().Length == 0)
            //{
            //   // DialogResult di = MessageBox.Show("SN不能为空，请重新刷入", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            //    this.txtSN.Focus();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
