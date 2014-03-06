using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Кредитный_калькулятор
{
    public partial class Reference : Form
    {
        public Reference()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                 
      
            Hide();
            Form1 Form = new Form1();
            Form.ShowDialog();
        }
    }

}
