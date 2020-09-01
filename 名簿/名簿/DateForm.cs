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

        bool trysearch = false;
        string tryclass = "";
        string tryfname = "";
        string tryname = "";
        string trygender = "";
        string trybirthday = "";

        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
            if(trysearch == true)
            {
                this.InsTableAdapter1.Searchinformation(this.InsdataSet11.Table, tryclass, tryfname, tryname, trygender, trybirthday);
                trysearch = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.InsTableAdapter1.Fill(this.InsdataSet11.Table);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void searchrecive(string classresult, string fnameresult, string nameresult, string genderresult, string birthdayresult)
        {
            trysearch = true;
            tryclass = classresult;
            tryfname = fnameresult;
            tryname = nameresult;
            trygender = genderresult;
            trybirthday = birthdayresult;
        }
    }
}
