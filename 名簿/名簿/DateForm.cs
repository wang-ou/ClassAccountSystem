using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 名簿
{
    public partial class DateForm : Form
    {

        static DataSet1 db;

        protected static DataSet1 App
        {
            get
            {
                if (db == null)
                    db = new DataSet1();
                return db;
            }
        }

        public DateForm()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.TableTableAdapter person = new DataSet1TableAdapters.TableTableAdapter();

        private void DateForm_Load(object sender, EventArgs e)
        {
        }
    }   
}
