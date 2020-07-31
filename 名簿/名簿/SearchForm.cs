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
        //textbox提示文　定数
        private const String ClassNtext = "(例：01番)";
        private const String FamNametext = "(例：山本)";
        private const String Nametext = "(例：太郎)";
        private const String Yeartext = "(例：1990)";
        private const String Monthtext = "(例：09)";
        private const String Daytext = "(例：09)";

        DataSet1TableAdapters.TableTableAdapter person = new DataSet1TableAdapters.TableTableAdapter();

        string classs;
        string fname;
        string name;
        string birthday;

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

        #region
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
            nametexb.Text = Nametext;
            nametexb.ForeColor = Color.Gray;
        }
        #endregion

        #region
        private void classNtexb_Enter(object sender, EventArgs e)
        {
            if (classNtexb.Text == ClassNtext)
            {
                //classNtexb.Clear();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                classNtexb.ForeColor = Color.Black;
            }
        }
        private void famnametexb_Enter(object sender, EventArgs e)
        {
            if (famnametexb.Text == FamNametext)
            {
                //famnametexb.Clear();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                famnametexb.ForeColor = Color.Black;
            }
        }
        private void yeartexb_Enter(object sender, EventArgs e)
        {
            if (yeartexb.Text == Yeartext)
            {
                //yeartexb.Clear();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                yeartexb.ForeColor = Color.Black;

            }
        }
        private void monthtexb_Enter(object sender, EventArgs e)
        {
            if (monthtexb.Text == Monthtext)
            {
                //monthtexb.Clear();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                monthtexb.ForeColor = Color.Black;
            }
        }
        private void daytxtb_Enter(object sender, EventArgs e)
        {
            if (daytxtb.Text == Daytext)
            {
                //daytxtb.Clear();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                daytxtb.ForeColor = Color.Black;
            }
        }
        private void nametexb_Enter(object sender, EventArgs e)
        {
            if (nametexb.Text == Nametext)
            {
                //nametexb.Clear();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                nametexb.ForeColor = Color.Black;
            }
        }
        #endregion

        //検索ボタンを押した処理
        #region
        private void Searbutton_Click(object sender, EventArgs e)
        {

            if (classNtexb.Text != ClassNtext)
            {
                classs = System.Text.RegularExpressions.Regex.Replace(classNtexb.Text, @"[^0-9]+", "");
            }

            if (famnametexb.Text != FamNametext)
            {
                fname = famnametexb.Text;
            }

            if (nametexb.Text != Nametext)
            {
                name = nametexb.Text;
            }

            if (yeartexb.Text != Yeartext)
            {
                birthday = yeartexb.Text + monthtexb.Text + daytxtb.Text;
            }

            if (monthtexb.Text != Monthtext)
            {
                birthday = yeartexb.Text + monthtexb.Text + daytxtb.Text;
            }

            if (daytxtb.Text != Daytext)
            {
                birthday = yeartexb.Text + monthtexb.Text + daytxtb.Text;
            }

            DateForm dateForm = new DateForm();
            
            dateForm.dataGridView1.DataSource = person.search4(int.Parse('0' + classs), fname, name, int.Parse('0' + birthday), comboBox1.Text);
            dateForm.label1.Text = dateForm.dataGridView1.Rows.Count + "件見つかりました。";
            dateForm.ShowDialog();
        }

        #endregion

        //private void monthtexb_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        int monthnum = Convert.ToInt32(monthtexb.Text);
        //        if (monthnum > 12 || monthnum < 1)
        //        {
        //            MessageBox.Show("1～12月しか検索できません。月の入力を変更してください。");
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("半角数字を入力してください。");
        //    }
        //}
    }
}