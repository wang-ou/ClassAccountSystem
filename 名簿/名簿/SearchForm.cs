using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void Searbutton_Click(object sender, EventArgs e)
        {
            Searchresult();
        }

        private void classNtexb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchresult()
        {
            Datacheck Dtcheck = new Datacheck();

            string classsearchresult = "";
            string fnamesearchresult = "";
            string namesearchresult = "";
            string yearsearchresult = "";
            string monthsearchresult = "";
            string daysearchresult = "";
            string gendersearchresult = "";

            string classresult = "";
            string fnameresult = "";
            string nameresult = "";
            string yearresult = "";
            string monthresult = "";
            string dayresult = "";
            string genderresult = "";

            string birthdayresult = "";

            if (classNtexb.Text != ClassNtext && classNtexb.Text != String.Empty)
            {
                classsearchresult = classNtexb.Text;
                classresult = Dtcheck.Classcheck(classsearchresult);
            }

            if (famnametexb.Text != FamNametext && famnametexb.Text != String.Empty)
            {
                fnamesearchresult = famnametexb.Text;
                fnameresult = Dtcheck.fnamecheck(fnamesearchresult);
            }

            if (nametexb.Text != Nametext && nametexb.Text != String.Empty)
            {
                namesearchresult = nametexb.Text;
                nameresult = Dtcheck.namecheck(namesearchresult);
            }

            if (yeartexb.Text != Yeartext && yeartexb.Text != String.Empty)
            {
                yearsearchresult = yeartexb.Text;
                yearresult = Dtcheck.yearcheck(yearsearchresult);
            }

            if (monthtexb.Text != Monthtext && monthtexb.Text != String.Empty)
            {
                monthsearchresult = monthtexb.Text;
                monthresult = Dtcheck.monthcheck(monthsearchresult);
            }

            if (daytxtb.Text != Daytext && daytxtb.Text != String.Empty)
            {
                daysearchresult = daytxtb.Text;
                dayresult = Dtcheck.daycheck(daysearchresult);
            }

            if (gendercomboBox.Text != String.Empty)
            {
                gendersearchresult = gendercomboBox.Text;
                genderresult = Dtcheck.gendercheck(gendersearchresult);
            }

            birthdayresult = yearresult + monthresult + dayresult;

            DateForm dateForm = new DateForm();
            dateForm.searchrecive(classresult, fnameresult, nameresult, genderresult, birthdayresult);
            dateForm.ShowDialog();

        }

        private void nametexb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
