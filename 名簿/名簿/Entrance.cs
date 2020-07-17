﻿using System;
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
    public partial class Entrance : Form
    {
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

        private void Entrance_Load(object sender, EventArgs e)
        {
            //string FileName = "保存ファイル";
            //DateForm dateForm = new DateForm();
            //DataSet1 ds = new DataSet1();
            //ds.ReadXml(FileName);
            //dateForm.dataGridView1.DataSource = ds;
            //dateForm.dataGridView1.DataBind();
        }
    }
}
