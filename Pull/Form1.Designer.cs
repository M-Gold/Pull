namespace Puull_2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_targetDownloads = new System.Windows.Forms.Label();
            this.lbl_currentDownloads = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTiny = new System.Windows.Forms.CheckBox();
            this.cbImgur = new System.Windows.Forms.CheckBox();
            this.cbPuush = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDownPath = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filterGrid = new System.Windows.Forms.DataGridView();
            this.Extensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.rbExclude = new System.Windows.Forms.RadioButton();
            this.rbDownload = new System.Windows.Forms.RadioButton();
            this.toolTIp1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of downloads";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_targetDownloads
            // 
            this.lbl_targetDownloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_targetDownloads.Location = new System.Drawing.Point(89, 0);
            this.lbl_targetDownloads.Name = "lbl_targetDownloads";
            this.lbl_targetDownloads.Size = new System.Drawing.Size(142, 73);
            this.lbl_targetDownloads.TabIndex = 6;
            this.lbl_targetDownloads.Text = "0";
            this.lbl_targetDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_currentDownloads
            // 
            this.lbl_currentDownloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_currentDownloads.Location = new System.Drawing.Point(0, 0);
            this.lbl_currentDownloads.Name = "lbl_currentDownloads";
            this.lbl_currentDownloads.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_currentDownloads.Size = new System.Drawing.Size(88, 73);
            this.lbl_currentDownloads.TabIndex = 7;
            this.lbl_currentDownloads.Text = "0";
            this.lbl_currentDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTiny);
            this.panel1.Controls.Add(this.cbImgur);
            this.panel1.Controls.Add(this.cbPuush);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 73);
            this.panel1.TabIndex = 8;
            // 
            // cbTiny
            // 
            this.cbTiny.AutoSize = true;
            this.cbTiny.Enabled = false;
            this.cbTiny.Location = new System.Drawing.Point(201, 49);
            this.cbTiny.Name = "cbTiny";
            this.cbTiny.Size = new System.Drawing.Size(60, 17);
            this.cbTiny.TabIndex = 6;
            this.cbTiny.Text = "Tinypic";
            this.cbTiny.UseVisualStyleBackColor = true;
            this.cbTiny.CheckedChanged += new System.EventHandler(this.cbSites_CheckedChanged);
            // 
            // cbImgur
            // 
            this.cbImgur.AutoSize = true;
            this.cbImgur.Location = new System.Drawing.Point(201, 6);
            this.cbImgur.Name = "cbImgur";
            this.cbImgur.Size = new System.Drawing.Size(52, 17);
            this.cbImgur.TabIndex = 4;
            this.cbImgur.Text = "Imgur";
            this.cbImgur.UseVisualStyleBackColor = true;
            this.cbImgur.CheckedChanged += new System.EventHandler(this.cbSites_CheckedChanged);
            // 
            // cbPuush
            // 
            this.cbPuush.AutoSize = true;
            this.cbPuush.Enabled = false;
            this.cbPuush.Location = new System.Drawing.Point(201, 27);
            this.cbPuush.Name = "cbPuush";
            this.cbPuush.Size = new System.Drawing.Size(56, 17);
            this.cbPuush.TabIndex = 5;
            this.cbPuush.Text = "Puush";
            this.cbPuush.UseVisualStyleBackColor = true;
            this.cbPuush.CheckedChanged += new System.EventHandler(this.cbSites_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 38);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_targetDownloads);
            this.panel2.Controls.Add(this.lbl_currentDownloads);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 73);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label5.Location = new System.Drawing.Point(76, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 73);
            this.label5.TabIndex = 6;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(299, 131);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(291, 105);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Open Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(291, 105);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(194, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "MB (WIP)";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(156, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(6, 81);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(154, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Limit total bandwidth usage";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(6, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(179, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Maintain original filenames (WIP)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Download to seperate folders";
            this.toolTIp1.SetToolTip(this.checkBox1, "Each website will have its images downloaded to a subfolder of the chosen downloa" +
        "d folder");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDownPath);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Download location";
            this.toolTIp1.SetToolTip(this.label3, "Defaults to the same directory as the executeable if left blank");
            // 
            // tbDownPath
            // 
            this.tbDownPath.Location = new System.Drawing.Point(107, 13);
            this.tbDownPath.Name = "tbDownPath";
            this.tbDownPath.Size = new System.Drawing.Size(100, 20);
            this.tbDownPath.TabIndex = 0;
            this.toolTIp1.SetToolTip(this.tbDownPath, "Defaults to the same directory as the executeable if left blank");
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(291, 105);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.filterGrid);
            this.groupBox3.Controls.Add(this.cbFilter);
            this.groupBox3.Controls.Add(this.rbExclude);
            this.groupBox3.Controls.Add(this.rbDownload);
            this.groupBox3.Location = new System.Drawing.Point(3, -5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 108);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filter Mode";
            // 
            // filterGrid
            // 
            this.filterGrid.AllowUserToResizeColumns = false;
            this.filterGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filterGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.filterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Extensions});
            this.filterGrid.EnableHeadersVisualStyles = false;
            this.filterGrid.Location = new System.Drawing.Point(175, 9);
            this.filterGrid.Name = "filterGrid";
            this.filterGrid.ReadOnly = true;
            this.filterGrid.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.filterGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.filterGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filterGrid.ShowEditingIcon = false;
            this.filterGrid.Size = new System.Drawing.Size(103, 96);
            this.filterGrid.StandardTab = true;
            this.filterGrid.TabIndex = 0;
            this.filterGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterGrid_KeyDown);
            this.filterGrid.MouseLeave += new System.EventHandler(this.filterGrid_MouseLeave);
            // 
            // Extensions
            // 
            this.Extensions.HeaderText = "Extensions";
            this.Extensions.Name = "Extensions";
            this.Extensions.ReadOnly = true;
            // 
            // cbFilter
            // 
            this.cbFilter.AutoSize = true;
            this.cbFilter.Location = new System.Drawing.Point(6, 13);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(84, 17);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.Text = "Enable Filter";
            this.cbFilter.UseVisualStyleBackColor = true;
            this.cbFilter.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbExclude
            // 
            this.rbExclude.AutoSize = true;
            this.rbExclude.Checked = true;
            this.rbExclude.Enabled = false;
            this.rbExclude.Location = new System.Drawing.Point(4, 51);
            this.rbExclude.Name = "rbExclude";
            this.rbExclude.Size = new System.Drawing.Size(63, 17);
            this.rbExclude.TabIndex = 3;
            this.rbExclude.TabStop = true;
            this.rbExclude.Text = "Exclude";
            this.rbExclude.UseVisualStyleBackColor = true;
            // 
            // rbDownload
            // 
            this.rbDownload.AutoSize = true;
            this.rbDownload.Enabled = false;
            this.rbDownload.Location = new System.Drawing.Point(4, 67);
            this.rbDownload.Name = "rbDownload";
            this.rbDownload.Size = new System.Drawing.Size(70, 17);
            this.rbDownload.TabIndex = 2;
            this.rbDownload.Text = "Exclusive";
            this.rbDownload.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 132);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Pull";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_targetDownloads;
        private System.Windows.Forms.Label lbl_currentDownloads;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDownPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView filterGrid;
        private System.Windows.Forms.RadioButton rbExclude;
        private System.Windows.Forms.RadioButton rbDownload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensions;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbPuush;
        private System.Windows.Forms.CheckBox cbImgur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTIp1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbTiny;
    }
}

