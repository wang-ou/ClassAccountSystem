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
    public partial class SearchForm : Form
    {
        private const String ClassNtext = "（例：01番）";
        private const String FamNametext = "（例：山本）";
        private const String Nametext = "（例：太郎）";
        private const String Yeartext = "（例：1990）";
        private const String Monthtext = "（例：09）";
        private const String Daytext = "（例：09）";
        public SearchForm()
        {
            InitializeComponent();
            SetClassNtext();
            SetFamNametext();
            SetYeartext();
            SetMonthtext();
            SetDaytext();
            SetNametext();
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
        private void SetClassNtext()
        {
            classNtexb.Text = ClassNtext;
            classNtexb.ForeColor = Color.Gray;
        }
        private void SetFamNametext()
        {
            famnametexb.Text = FamNametext;
            famnametexb.ForeColor = Color.Gray;
        }
        private void SetYeartext()
        {
            yeartexb.Text = Yeartext;
            yeartexb.ForeColor = Color.Gray;
        }
        private void SetMonthtext()
        {
            monthtexb.Text = Monthtext;
            monthtexb.ForeColor = Color.Gray;
        }
        private void SetDaytext()
        {
            daytxtb.Text = Daytext;
            daytxtb.ForeColor = Color.Gray;
        }
        private void SetNametext()
        {
            nametexb .Text = Nametext;
            nametexb.ForeColor = Color.Gray;
        }
    

        private void classNtexb_Enter(object sender, EventArgs e)
        {
            if (classNtexb.Text == ClassNtext)
            {
                classNtexb.Clear();
                classNtexb.ForeColor = Color.Black;
            }
        }
        private void famnametexb_Enter(object sender, EventArgs e)
        {
            if (famnametexb.Text == FamNametext)
            {
                famnametexb.Clear();
                famnametexb.ForeColor = Color.Black;
            }
        }
        private void yeartexb_Enter(object sender, EventArgs e)
        {
            if (yeartexb.Text == Yeartext)
            {
                yeartexb.Clear();
                yeartexb.ForeColor = Color.Black;
            }
        }
        private void monthtexb_Enter(object sender, EventArgs e)
        {
            if (monthtexb.Text == Monthtext)
            {
                monthtexb.Clear();
                monthtexb.ForeColor = Color.Black;
            }
        }
        private void daytxtb_Enter(object sender, EventArgs e)
        {
            if (daytxtb.Text == Daytext)
            {
                daytxtb.Clear();
                daytxtb.ForeColor = Color.Black;
            }
        }
        private void nametexb_Enter(object sender, EventArgs e)
        {
            if (nametexb.Text == Nametext)
            {
                nametexb.Clear();
                nametexb.ForeColor = Color.Black;
            }
        }

        DataSet1TableAdapters.TableTableAdapter person = new DataSet1TableAdapters.TableTableAdapter();

        private void Searbutton_Click(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm();

            string classBoxText = System.Text.RegularExpressions.Regex.Replace(classNtexb.Text, @"[^0-9]+", "");
            dateForm.dataGridView1.DataSource = person.Search2(Convert.ToInt32("0" + classBoxText), famnametexb.Text, nametexb.Text, comboBox1.Text,yeartexb.Text);
           
            dateForm.label1.Text = dateForm.dataGridView1.Rows.Count + "件見つかりました。";
            dateForm.ShowDialog(); 
           
        }
    }
}
