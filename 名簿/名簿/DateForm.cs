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

        DataSet1TableAdapters.TableTableAdapter person = new DataSet1TableAdapters.TableTableAdapter();

        private void DateForm_Load(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm();
            string FileName = DateTime.Now.ToString("yyMMddhhmmss");

            DataTable dt = (DataTable)dateForm.dataGridView1.DataSource;
            DataSet ds = new DataSet();
            //ds.Tables.Add(dt);
            //ds.WriteXml(FileName);

            ds.ReadXml(FileName);
            dateForm.dataGridView1.DataSource = ds.Tables[0];


        }

        private void DateForm_Load_1(object sender, EventArgs e)
        {
        }
    }   
}
