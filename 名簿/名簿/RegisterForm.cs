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
        //textbox入力提示文　定数
        private const String classBoxtext = "学生番号を入力してください(例：01番)";
        private const String FamilyBoxtext = "苗字";
        private const String NameBoxtext = "名前";
        private const String BirthdayBoxtext = "生年月日を入力してください(例：19900909)";
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

        //登録ボタンを押した処理
        #region
        private void Regbutton_Click(object sender, EventArgs e)
        {
            try
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
                    string classText = System.Text.RegularExpressions.Regex.Replace(classBox.Text, @"[^0-9]+", "");                   
                    person.Insert1(int.Parse('0' + classText), familynameBox.Text, nameBox.Text, int.Parse('0' + brithdayBox.Text), SexCbBox.Text);
                    DateForm dateForm = new DateForm();
                    dateForm.dataGridView1.DataSource = person.list2();
                    dateForm.label1.Text = dateForm.dataGridView1.Rows.Count + "件登録されました";
                    dateForm.ShowDialog();
                    //MessageBox.Show("登録完了");

                    switch (MessageBox.Show("現在の情報を名簿に登録しました。登録を完了しますか。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        //case DialogResult.Cancel:
                        //    //最後に登録した情報を削除する
                        //    person.Delete(int.Parse(classText), familynameBox.Text, nameBox.Text, int.Parse(brithdayBox.Text), SexCbBox.Text);
                        //    MessageBox.Show("現在の情報を名簿から削除しました");
                        //    break;

                        case DialogResult.Yes:
                            this.Close(); //登録フォームを閉じる
                            MessageBox.Show("「クラス名簿の登録フォーム」を閉じます");
                            break;

                        case DialogResult.No:
                            foreach (Control item in Controls) if (item is TextBox) item.Text = "";//textboxをクリアし、続いて登録
                            this.SexCbBox.SelectedIndex = -1;
                            MessageBox.Show("続いて登録してください");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("登録失敗しました。入力形式に誤りがあります。");
                }
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("学生番号重複しています");
                }
                else
                {
                    throw ex;
                }
            }
        }
        #endregion

        #region
        public bool classBox_TextCheck()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(classBox.Text, @"^[0-9]{2}$") ||
                System.Text.RegularExpressions.Regex.IsMatch(classBox.Text, @"^[0-9]{2}番$"))
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
            if (System.Text.RegularExpressions.Regex.IsMatch(brithdayBox.Text, @"^[0-9]{8}$"))
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

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((ActiveControl is ComboBox || ActiveControl is TextBox) &&
                keyData == Keys.Enter)
            {
                keyData = Keys.Tab;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}


