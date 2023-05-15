using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms
{
    public partial class RequestsForm : Form
    {
        public RequestsForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ChartsButton_Click(object sender, EventArgs e)
        {
            //new ChartsForm().Show();
        }
    }
}
