using System;

namespace 名簿
{
    partial class RegisterForm
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
            this.classBox = new System.Windows.Forms.TextBox();
            this.brithdayBox = new System.Windows.Forms.TextBox();
            this.familynameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.Regbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SexCbBox = new System.Windows.Forms.ComboBox();
            this.CalssNlabel = new System.Windows.Forms.Label();
            this.Fnamelabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.birdaylabel = new System.Windows.Forms.Label();
            this.InsdataSet11 = new 名簿.DataSet1();
            this.InsTableAdapter1 = new 名簿.DataSet1TableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InsdataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // classBox
            // 
            this.classBox.Location = new System.Drawing.Point(80, 169);
            this.classBox.Multiline = true;
            this.classBox.Name = "classBox";
            this.classBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.classBox.Size = new System.Drawing.Size(250, 21);
            this.classBox.TabIndex = 0;
            this.classBox.Enter += new System.EventHandler(this.classBox_Enter);
            // 
            // brithdayBox
            // 
            this.brithdayBox.Location = new System.Drawing.Point(80, 269);
            this.brithdayBox.Multiline = true;
            this.brithdayBox.Name = "brithdayBox";
            this.brithdayBox.Size = new System.Drawing.Size(250, 21);
            this.brithdayBox.TabIndex = 1;
            this.brithdayBox.Enter += new System.EventHandler(this.brithdayBox_Enter);
            // 
            // familynameBox
            // 
            this.familynameBox.Location = new System.Drawing.Point(80, 220);
            this.familynameBox.Multiline = true;
            this.familynameBox.Name = "familynameBox";
            this.familynameBox.Size = new System.Drawing.Size(87, 21);
            this.familynameBox.TabIndex = 2;
            this.familynameBox.Enter += new System.EventHandler(this.familynameBox_Enter);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(244, 220);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(87, 21);
            this.nameBox.TabIndex = 3;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            // 
            // Regbutton
            // 
            this.Regbutton.Location = new System.Drawing.Point(293, 351);
            this.Regbutton.Name = "Regbutton";
            this.Regbutton.Size = new System.Drawing.Size(117, 43);
            this.Regbutton.TabIndex = 5;
            this.Regbutton.Text = "登録";
            this.Regbutton.UseVisualStyleBackColor = true;
            this.Regbutton.Click += new System.EventHandler(this.Regbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(82, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "クラス名簿の登録フォーム";
            // 
            // SexCbBox
            // 
            this.SexCbBox.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SexCbBox.FormattingEnabled = true;
            this.SexCbBox.Items.AddRange(new object[] {
            "男(man)",
            "女(woman)"});
            this.SexCbBox.Location = new System.Drawing.Point(79, 319);
            this.SexCbBox.Name = "SexCbBox";
            this.SexCbBox.Size = new System.Drawing.Size(87, 19);
            this.SexCbBox.TabIndex = 8;
            this.SexCbBox.TabStop = false;
            // 
            // CalssNlabel
            // 
            this.CalssNlabel.AutoSize = true;
            this.CalssNlabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CalssNlabel.Location = new System.Drawing.Point(79, 153);
            this.CalssNlabel.Name = "CalssNlabel";
            this.CalssNlabel.Size = new System.Drawing.Size(223, 13);
            this.CalssNlabel.TabIndex = 9;
            this.CalssNlabel.Text = "クラス番号を入力してください（例：01番）。";
            // 
            // Fnamelabel
            // 
            this.Fnamelabel.AutoSize = true;
            this.Fnamelabel.Location = new System.Drawing.Point(79, 204);
            this.Fnamelabel.Name = "Fnamelabel";
            this.Fnamelabel.Size = new System.Drawing.Size(33, 13);
            this.Fnamelabel.TabIndex = 10;
            this.Fnamelabel.Text = "苗字";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(244, 204);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(33, 13);
            this.namelabel.TabIndex = 11;
            this.namelabel.Text = "名前";
            // 
            // birdaylabel
            // 
            this.birdaylabel.AutoSize = true;
            this.birdaylabel.Location = new System.Drawing.Point(79, 253);
            this.birdaylabel.Name = "birdaylabel";
            this.birdaylabel.Size = new System.Drawing.Size(243, 13);
            this.birdaylabel.TabIndex = 12;
            this.birdaylabel.Text = "生年月日を入力してください（例：1990090）。";
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
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 445);
            this.Controls.Add(this.birdaylabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.Fnamelabel);
            this.Controls.Add(this.CalssNlabel);
            this.Controls.Add(this.SexCbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Regbutton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.familynameBox);
            this.Controls.Add(this.brithdayBox);
            this.Controls.Add(this.classBox);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "RegisterForm";
            this.Text = "クラス名簿管理システム";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InsdataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.TextBox brithdayBox;
        private System.Windows.Forms.TextBox familynameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button Regbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SexCbBox;
        private System.Windows.Forms.Label CalssNlabel;
        private System.Windows.Forms.Label Fnamelabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label birdaylabel;
        private DataSet1 InsdataSet11;
        private DataSet1TableAdapters.TableTableAdapter InsTableAdapter1;
    }
}