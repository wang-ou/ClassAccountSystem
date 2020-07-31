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
        DataSet1TableAdapters.TableTableAdapter person = new DataSet1TableAdapters.TableTableAdapter();

        public DateForm()
        {
            InitializeComponent();
        }

        #region
        //private void correctbutton_Click(object sender, EventArgs e)
        //{
        //    RegisterForm registerForm = new RegisterForm();
        //    person.Update1(registerForm.familynameBox.Text,registerForm.nameBox.Text,int.Parse(registerForm.brithdayBox.Text), registerForm.SexCbBox.Text,int.Parse(registerForm.classBox.Text));
        //}
        #endregion
    }
}
