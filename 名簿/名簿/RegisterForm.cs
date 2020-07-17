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
        private const String classBoxtext = "クラス番号を入力してください（例：01番）。";
        private const String FamilyBoxtext = "苗字";
        private const String NameBoxtext = "名前";
        private const String BirthdayBoxtext = "生年月日を入力してください（例：1990090）。";
        private const String Bt = "性別";

        DataSet1TableAdapters.TableTableAdapter person = new DataSet1TableAdapters.TableTableAdapter();

        public RegisterForm()
        {
            InitializeComponent();
            SetclassBoxText();
            SetFamilynameText();
            SetNameText();
            SetBirthdaytext();
            SetComboxtext();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label2;
            CalssNlabel.Visible = false;
            Fnamelabel.Visible = false;
            namelabel.Visible = false;
            birdaylabel.Visible = false;

        }

        #region
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
            nameBox.ForeColor = Color.Gray; ;
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
        #endregion

        #region
        private void classBox_Enter(object sender, EventArgs e)
        {
            if (classBox.Text == classBoxtext)
            {
                classBox.Clear();
                CalssNlabel.Visible = true;
                classBox.ForeColor = Color.Black;
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
        #endregion

        private void Regbutton_Click(object sender, EventArgs e)
        {
            bool classT = classBox_TextCheck();
            bool nameT = nameBox_TextCheck();
            bool familyT = familynameBox_TextCheck();
            bool birthdayT = brithdayBox_TextCheck();
            bool sexT = sexCbBox_SelectCheck();

            if (classT == true &&
                nameT == true &&
                familyT == true &&
                birthdayT == true &&
                sexT == true)
            {
                person.Insert(classBox.Text, familynameBox.Text, nameBox.Text, int.Parse(brithdayBox.Text), SexCbBox.Text);

                DateForm dateForm = new DateForm();
                dateForm.dataGridView1.DataSource = person.list2();
                dateForm.label1.Text = dateForm.dataGridView1.Rows.Count + "件登録されました。";
                dateForm.ShowDialog();
                MessageBox.Show("登録完了");

                /*DateTime.Now.ToString("yyMMddhhmmss");*/
                string FileName = "保存ファイル";
                //Filter = "XML文件(*.xml)|*.xml";
                    DataTable dt = (DataTable)dateForm.dataGridView1.DataSource;
                    DataSet1 ds = new DataSet1();
                    ds.Tables.Add(dt);
                    ds.WriteXml(FileName);

                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                SexCbBox.Items.Remove(SexCbBox.SelectedIndex);
            }
            else 
            {
                MessageBox.Show("登録失敗しました。入力形式に誤りがあります。");
            }
        }

        #region
        private bool classBox_TextCheck()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(classBox.Text, @"^[0-9]{2}$") )
            {
                classBox.BackColor = Color.White;
                return true;
            }
            else
            {
                classBox.BackColor = Color.Red;
                return false;
            }
        }

        public bool familynameBox_TextCheck()
        {
            if (
                System.Text.RegularExpressions.Regex.IsMatch(familynameBox.Text, @"^\p{IsHiragana}+$") ||
                System.Text.RegularExpressions.Regex.IsMatch(familynameBox.Text, @"^[\p{IsKatakana}\u31F0-\u31FF\u3099-\u309C\uFF65-\uFF9F]+$") ||
                System.Text.RegularExpressions.Regex.IsMatch(familynameBox.Text, @"^[a-zA-Z]+$") ||
                System.Text.RegularExpressions.Regex.IsMatch(familynameBox.Text, @"[\p{IsCJKUnifiedIdeographs}"
                                                                            + @"\p{IsCJKCompatibilityIdeographs}"
                                                                            + @"\p{IsCJKUnifiedIdeographsExtensionA}]|"
                                                                            + @"[\uD840-\uD869][\uDC00-\uDFFF]|\uD869[\uDC00-\uDEDF]") && familynameBox.Text != FamilyBoxtext)
            {
                familynameBox.BackColor = Color.White;
                return true;
            }
            else
            {
                familynameBox.BackColor = Color.Red;
                return false;
            }
        }

        public bool nameBox_TextCheck()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^\p{IsHiragana}+$") ||
                System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^[\p{IsKatakana}\u31F0-\u31FF\u3099-\u309C\uFF65-\uFF9F]+$") ||
                System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^[a-zA-Z]+$") ||
                System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"[\p{IsCJKUnifiedIdeographs}"
                                                                        + @"\p{IsCJKCompatibilityIdeographs}"
                                                                        + @"\p{IsCJKUnifiedIdeographsExtensionA}]|"
                                                                        + @"[\uD840-\uD869][\uDC00-\uDFFF]|\uD869[\uDC00-\uDEDF]") && nameBox.Text != NameBoxtext)
            {
                nameBox.BackColor = Color.White;
                return true;
            }
            else
            {
                nameBox.BackColor = Color.Red;
                return false;
            }
        }

        public bool brithdayBox_TextCheck() 
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(brithdayBox.Text, @"^[0-9]{8}$") )
            {
                brithdayBox.BackColor = Color.White;
                return true;
            }
            else
            {
                brithdayBox.BackColor = Color.Red;
                return false;
            }
        }

        public bool sexCbBox_SelectCheck()
        {
            if (SexCbBox.SelectedIndex != -1)
            {
                SexCbBox.BackColor = Color.White;
                return true;
            }
            else
            {
                SexCbBox.BackColor = Color.Red;
                return false;
            }
        }
        #endregion
    }
}
