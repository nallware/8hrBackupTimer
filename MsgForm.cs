using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8HrBackupTimer
{
    public partial class MsgForm : Form
    {
        public MsgForm()
        {
            InitializeComponent();
        }
        public string _message;

        private void btnOk_Click(object sender, EventArgs e)
        {
            tbMessage.Text = "";
            this.Close();
        }

        private void MsgForm_Load(object sender, EventArgs e)
        {
            tbMessage.Text = _message;
        }
    }
}
