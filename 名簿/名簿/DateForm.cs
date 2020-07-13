using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 名簿
{
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.InsTableAdapter1.Fill(this.InsdataSet11.Table);
        }
    }
}
