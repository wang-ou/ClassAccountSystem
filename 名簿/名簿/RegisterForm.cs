using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 名簿
{
    public partial class RegisterForm : Form
    {
        private const String classBoxtext = "クラス番号を入力してください。（例：01番）";
        private const String FamilyBoxtext = "苗字";
        private const String NameBoxtext = "名前";
        private const String BirthdayBoxtext = "生年月日を入力してください（例：1990090）";
        private const String Bt = "性別";

        public RegisterForm()
        {
            InitializeComponent();
            SetclassBoxText();
            SetFamilynameText();
            SetNameText();
            SetBirthdaytext();
            SetComboxtext();
            CalssNlabel.Visible = false;
            Fnamelabel.Visible = false;
            namelabel.Visible = false;
            birdaylabel.Visible = false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label2;
        }

        private void SetclassBoxText()
        {   
            classBox.Text = classBoxtext; 
            classBox.ForeColor = Color.Gray;
        }
        private void SetFamilynameText()
        {
            familynameBox.Text = FamilyBoxtext;
            familynameBox.ForeColor = Color.Gray;
        }
        private void SetNameText()
        {
            nameBox.Text = NameBoxtext;
            nameBox.ForeColor = Color.Gray;
        }
        private void SetBirthdaytext()
        {
            brithdayBox.Text = BirthdayBoxtext;
            brithdayBox.ForeColor = Color.Gray;
        }

        private void SetComboxtext()
        {
            SexCbBox.Text = Bt;
            SexCbBox.ForeColor = Color.Gray;
        }
        

        private void classBox_Enter(object sender, EventArgs e)
        {
            if (classBox.Text == classBoxtext)
            {
                classBox.Clear();
                CalssNlabel.Visible = true;
                classBox.ForeColor = Color.Black;
                classBox.BackColor = Color.White;
            }
        }

        private void familynameBox_Enter(object sender, EventArgs e)
        {
            if (familynameBox.Text == FamilyBoxtext)
            {
                familynameBox.Clear();
                familynameBox.ForeColor = Color.Black;
                Fnamelabel.Visible = true;

            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == NameBoxtext)
            {
                nameBox.Clear();
                nameBox.ForeColor = Color.Black;
                namelabel.Visible = true;
            }
        }

        private void brithdayBox_Enter(object sender, EventArgs e)
        {
            if (brithdayBox.Text == BirthdayBoxtext)
            {
                brithdayBox.Clear();
                brithdayBox.ForeColor = Color.Black;
                birdaylabel.Visible = true;
            }
        }

        private void Regbutton_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("insert into 表名（名字，密码）values (@username,@password)");
            //cmd.Parameters.AddWithValue("@username", classBox.Text);
            //cmd.Parameters.AddWithValue("@password", familynameBox.Text);

            if (
               classBox.Text != null &&
               familynameBox.Text != null &&
               nameBox.Text != null &&
               brithdayBox.Text != null &&
               SexCbBox.SelectedIndex != -1) 
            {
                classBox.BackColor = Color.White;
                familynameBox.BackColor = Color.White;
                nameBox.BackColor = Color.White;
                brithdayBox.BackColor = Color.White;
                SexCbBox.BackColor = Color.White;
                RegisitInformation(classBox.Text, familynameBox.Text, nameBox.Text, brithdayBox.Text, SexCbBox.Text);
                MessageBox.Show("登録完了");
            }
            else 
            {
                if (classBox.Text == string.Empty)
                {
                    classBox.BackColor = Color.Red;
                }
                if (familynameBox.Text == string.Empty)
                {
                    familynameBox.BackColor = Color.Red;
                }
                if (nameBox.Text == string.Empty)
                {
                    nameBox.BackColor = Color.Red;
                }
                if (brithdayBox.Text == string.Empty)
                {
                    brithdayBox.BackColor = Color.Red;
                }
                if(SexCbBox.SelectedIndex == -1)
                {
                    SexCbBox.BackColor = Color.Red;
                }
                MessageBox.Show("登録失敗しました。入力形式に誤りがあります。");
            }
        }

        private void RegisitInformation(string Classnumber, string Familyname, string Name, string Birthday, string Gender)
        {
            this.InsTableAdapter1.Registarinformation(Classnumber, Familyname, Name, Birthday, Gender);
        }

    }
}
