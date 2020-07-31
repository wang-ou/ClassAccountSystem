using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 名簿
{
    public partial class Entrance : Form
    {
        DataSet1TableAdapters.TableTableAdapter person = new DataSet1TableAdapters.TableTableAdapter();

        public Entrance()
        {
            InitializeComponent();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.ShowDialog();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm();
            dateForm.dataGridView1.DataSource = person.list2();
            dateForm.label1.Text = dateForm.dataGridView1.Rows.Count + "件登録されました";
            dateForm.ShowDialog();
        }

        private void Entrance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("「クラス名簿管理システム」を終了しますか。","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            e.Cancel = true;
        }
    }
}
