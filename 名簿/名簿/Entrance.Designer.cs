namespace 名簿
{
    partial class Entrance
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
            this.Registerbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.listbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "クラス名簿管理システム";
            // 
            // Registerbutton
            // 
            this.Registerbutton.Location = new System.Drawing.Point(75, 277);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(100, 40);
            this.Registerbutton.TabIndex = 1;
            this.Registerbutton.Text = "登録";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Searchbutton.Location = new System.Drawing.Point(251, 277);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(100, 40);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "検索";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // listbutton
            // 
            this.listbutton.Location = new System.Drawing.Point(161, 229);
            this.listbutton.Name = "listbutton";
            this.listbutton.Size = new System.Drawing.Size(106, 31);
            this.listbutton.TabIndex = 3;
            this.listbutton.Text = "名簿一覧表";
            this.listbutton.UseVisualStyleBackColor = true;
            this.listbutton.Click += new System.EventHandler(this.listbutton_Click);
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.listbutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.label1);
            this.Name = "Entrance";
            this.Text = "クラス名簿管理システム";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Entrance_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button listbutton;
    }
}