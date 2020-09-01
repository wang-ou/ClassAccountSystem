namespace 名簿
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.famnametexb = new System.Windows.Forms.TextBox();
            this.classNtexb = new System.Windows.Forms.TextBox();
            this.nametexb = new System.Windows.Forms.TextBox();
            this.yeartexb = new System.Windows.Forms.TextBox();
            this.monthtexb = new System.Windows.Forms.TextBox();
            this.daytxtb = new System.Windows.Forms.TextBox();
            this.Searbutton = new System.Windows.Forms.Button();
            this.gendercomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InsdataSet11 = new 名簿.DataSet1();
            this.InsTableAdapter1 = new 名簿.DataSet1TableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InsdataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "クラス名簿の検索フォーム";
            // 
            // famnametexb
            // 
            this.famnametexb.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.famnametexb.Location = new System.Drawing.Point(68, 179);
            this.famnametexb.Multiline = true;
            this.famnametexb.Name = "famnametexb";
            this.famnametexb.Size = new System.Drawing.Size(75, 20);
            this.famnametexb.TabIndex = 2;
            this.famnametexb.Enter += new System.EventHandler(this.famnametexb_Enter);
            // 
            // classNtexb
            // 
            this.classNtexb.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.classNtexb.Location = new System.Drawing.Point(68, 135);
            this.classNtexb.Multiline = true;
            this.classNtexb.Name = "classNtexb";
            this.classNtexb.Size = new System.Drawing.Size(215, 20);
            this.classNtexb.TabIndex = 3;
            this.classNtexb.TextChanged += new System.EventHandler(this.classNtexb_TextChanged);
            this.classNtexb.Enter += new System.EventHandler(this.classNtexb_Enter);
            // 
            // nametexb
            // 
            this.nametexb.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nametexb.Location = new System.Drawing.Point(208, 179);
            this.nametexb.Multiline = true;
            this.nametexb.Name = "nametexb";
            this.nametexb.Size = new System.Drawing.Size(75, 20);
            this.nametexb.TabIndex = 4;
            this.nametexb.TextChanged += new System.EventHandler(this.nametexb_TextChanged);
            this.nametexb.Enter += new System.EventHandler(this.nametexb_Enter);
            // 
            // yeartexb
            // 
            this.yeartexb.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yeartexb.Location = new System.Drawing.Point(68, 228);
            this.yeartexb.Multiline = true;
            this.yeartexb.Name = "yeartexb";
            this.yeartexb.Size = new System.Drawing.Size(60, 20);
            this.yeartexb.TabIndex = 5;
            this.yeartexb.Enter += new System.EventHandler(this.yeartexb_Enter);
            // 
            // monthtexb
            // 
            this.monthtexb.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.monthtexb.Location = new System.Drawing.Point(144, 228);
            this.monthtexb.Multiline = true;
            this.monthtexb.Name = "monthtexb";
            this.monthtexb.Size = new System.Drawing.Size(60, 20);
            this.monthtexb.TabIndex = 6;
            this.monthtexb.Enter += new System.EventHandler(this.monthtexb_Enter);
            // 
            // daytxtb
            // 
            this.daytxtb.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.daytxtb.Location = new System.Drawing.Point(223, 228);
            this.daytxtb.Multiline = true;
            this.daytxtb.Name = "daytxtb";
            this.daytxtb.Size = new System.Drawing.Size(60, 20);
            this.daytxtb.TabIndex = 7;
            this.daytxtb.Enter += new System.EventHandler(this.daytxtb_Enter);
            // 
            // Searbutton
            // 
            this.Searbutton.Location = new System.Drawing.Point(251, 318);
            this.Searbutton.Name = "Searbutton";
            this.Searbutton.Size = new System.Drawing.Size(100, 40);
            this.Searbutton.TabIndex = 9;
            this.Searbutton.Text = "検索";
            this.Searbutton.UseVisualStyleBackColor = true;
            this.Searbutton.Click += new System.EventHandler(this.Searbutton_Click);
            // 
            // gendercomboBox
            // 
            this.gendercomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.gendercomboBox.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gendercomboBox.FormattingEnabled = true;
            this.gendercomboBox.Items.AddRange(new object[] {
            "男(man)",
            "女(woman)"});
            this.gendercomboBox.Location = new System.Drawing.Point(68, 281);
            this.gendercomboBox.Name = "gendercomboBox";
            this.gendercomboBox.Size = new System.Drawing.Size(75, 19);
            this.gendercomboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "クラス番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(65, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "苗字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(201, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "名前";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(65, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "生年月日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(65, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "性別";
            // 
            // InsdataSet11
            // 
            this.InsdataSet11.DataSetName = "DataSet1";
            this.InsdataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InsTableAdapter1
            // 
            this.InsTableAdapter1.ClearBeforeFill = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gendercomboBox);
            this.Controls.Add(this.Searbutton);
            this.Controls.Add(this.daytxtb);
            this.Controls.Add(this.monthtexb);
            this.Controls.Add(this.yeartexb);
            this.Controls.Add(this.nametexb);
            this.Controls.Add(this.classNtexb);
            this.Controls.Add(this.famnametexb);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.Text = "クラス名簿管理システム";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InsdataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox famnametexb;
        public System.Windows.Forms.TextBox classNtexb;
        public System.Windows.Forms.TextBox nametexb;
        public System.Windows.Forms.TextBox yeartexb;
        public System.Windows.Forms.TextBox monthtexb;
        public System.Windows.Forms.TextBox daytxtb;
        private System.Windows.Forms.Button Searbutton;
        public System.Windows.Forms.ComboBox gendercomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public DataSet1 InsdataSet11;
        private DataSet1TableAdapters.TableTableAdapter InsTableAdapter1;
    }
}