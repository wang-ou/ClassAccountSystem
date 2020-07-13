namespace 名簿
{
    partial class DateForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InsdataSet11 = new 名簿.DataSet1();
            this.InsTableAdapter1 = new 名簿.DataSet1TableAdapters.TableTableAdapter();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.クラス番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.苗字DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名前DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生年月日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsdataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.クラス番号DataGridViewTextBoxColumn,
            this.苗字DataGridViewTextBoxColumn,
            this.名前DataGridViewTextBoxColumn,
            this.生年月日DataGridViewTextBoxColumn,
            this.性別DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(383, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "4件見つかりました。";
            this.label1.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.InsdataSet11;
            // 
            // クラス番号DataGridViewTextBoxColumn
            // 
            this.クラス番号DataGridViewTextBoxColumn.DataPropertyName = "クラス番号";
            this.クラス番号DataGridViewTextBoxColumn.HeaderText = "クラス番号";
            this.クラス番号DataGridViewTextBoxColumn.Name = "クラス番号DataGridViewTextBoxColumn";
            // 
            // 苗字DataGridViewTextBoxColumn
            // 
            this.苗字DataGridViewTextBoxColumn.DataPropertyName = "苗字";
            this.苗字DataGridViewTextBoxColumn.HeaderText = "苗字";
            this.苗字DataGridViewTextBoxColumn.Name = "苗字DataGridViewTextBoxColumn";
            // 
            // 名前DataGridViewTextBoxColumn
            // 
            this.名前DataGridViewTextBoxColumn.DataPropertyName = "名前";
            this.名前DataGridViewTextBoxColumn.HeaderText = "名前";
            this.名前DataGridViewTextBoxColumn.Name = "名前DataGridViewTextBoxColumn";
            // 
            // 生年月日DataGridViewTextBoxColumn
            // 
            this.生年月日DataGridViewTextBoxColumn.DataPropertyName = "生年月日";
            this.生年月日DataGridViewTextBoxColumn.HeaderText = "生年月日";
            this.生年月日DataGridViewTextBoxColumn.Name = "生年月日DataGridViewTextBoxColumn";
            // 
            // 性別DataGridViewTextBoxColumn
            // 
            this.性別DataGridViewTextBoxColumn.DataPropertyName = "性別";
            this.性別DataGridViewTextBoxColumn.HeaderText = "性別";
            this.性別DataGridViewTextBoxColumn.Name = "性別DataGridViewTextBoxColumn";
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DateForm";
            this.Text = "クラス名簿管理システム";
            this.Load += new System.EventHandler(this.DateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsdataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private DataSet1 InsdataSet11;
        private DataSet1TableAdapters.TableTableAdapter InsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn クラス番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 苗字DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生年月日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性別DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableBindingSource;
    }
}