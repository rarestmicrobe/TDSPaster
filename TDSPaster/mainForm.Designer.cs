﻿namespace TDSPaster
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PasteDataButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.previewListBox = new System.Windows.Forms.ListBox();
            this.elevationOverwriteLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rowLeftLabel = new System.Windows.Forms.Label();
            this.rowCenterLabel = new System.Windows.Forms.Label();
            this.rowRightLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sublimeCheckBox = new System.Windows.Forms.CheckBox();
            this.singleRowRadioButton = new System.Windows.Forms.RadioButton();
            this.tripleRowRadioButton = new System.Windows.Forms.RadioButton();
            this.colRightLabel = new System.Windows.Forms.Label();
            this.colCenterLabel = new System.Windows.Forms.Label();
            this.colLeftLabel = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.elevationInfoListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // PasteDataButton
            // 
            this.PasteDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteDataButton.Location = new System.Drawing.Point(339, 137);
            this.PasteDataButton.Name = "PasteDataButton";
            this.PasteDataButton.Size = new System.Drawing.Size(214, 121);
            this.PasteDataButton.TabIndex = 1;
            this.PasteDataButton.Text = "Paste Data";
            this.PasteDataButton.UseVisualStyleBackColor = true;
            this.PasteDataButton.Click += new System.EventHandler(this.PasteDataButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(625, 661);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveFileButton.TabIndex = 2;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileButton.Location = new System.Drawing.Point(339, 86);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(214, 34);
            this.SelectFileButton.TabIndex = 3;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // previewListBox
            // 
            this.previewListBox.FormattingEnabled = true;
            this.previewListBox.Location = new System.Drawing.Point(64, 85);
            this.previewListBox.Name = "previewListBox";
            this.previewListBox.Size = new System.Drawing.Size(267, 173);
            this.previewListBox.TabIndex = 4;
            // 
            // elevationOverwriteLabel
            // 
            this.elevationOverwriteLabel.AutoSize = true;
            this.elevationOverwriteLabel.ForeColor = System.Drawing.Color.Red;
            this.elevationOverwriteLabel.Location = new System.Drawing.Point(559, 68);
            this.elevationOverwriteLabel.Name = "elevationOverwriteLabel";
            this.elevationOverwriteLabel.Size = new System.Drawing.Size(229, 13);
            this.elevationOverwriteLabel.TabIndex = 13;
            this.elevationOverwriteLabel.Text = "This is the elevation you are going to overwrite!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Selected file preview";
            // 
            // rowLeftLabel
            // 
            this.rowLeftLabel.AutoSize = true;
            this.rowLeftLabel.Location = new System.Drawing.Point(33, 362);
            this.rowLeftLabel.Name = "rowLeftLabel";
            this.rowLeftLabel.Size = new System.Drawing.Size(25, 13);
            this.rowLeftLabel.TabIndex = 15;
            this.rowLeftLabel.Text = "Left";
            // 
            // rowCenterLabel
            // 
            this.rowCenterLabel.AutoSize = true;
            this.rowCenterLabel.Location = new System.Drawing.Point(20, 384);
            this.rowCenterLabel.Name = "rowCenterLabel";
            this.rowCenterLabel.Size = new System.Drawing.Size(38, 13);
            this.rowCenterLabel.TabIndex = 16;
            this.rowCenterLabel.Text = "Center";
            // 
            // rowRightLabel
            // 
            this.rowRightLabel.AutoSize = true;
            this.rowRightLabel.Location = new System.Drawing.Point(26, 409);
            this.rowRightLabel.Name = "rowRightLabel";
            this.rowRightLabel.Size = new System.Drawing.Size(32, 13);
            this.rowRightLabel.TabIndex = 17;
            this.rowRightLabel.Text = "Right";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Select the format of your pasted data.";
            // 
            // sublimeCheckBox
            // 
            this.sublimeCheckBox.AutoSize = true;
            this.sublimeCheckBox.Location = new System.Drawing.Point(625, 638);
            this.sublimeCheckBox.Name = "sublimeCheckBox";
            this.sublimeCheckBox.Size = new System.Drawing.Size(173, 17);
            this.sublimeCheckBox.TabIndex = 19;
            this.sublimeCheckBox.Text = "Open file in sublime after save?";
            this.sublimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // singleRowRadioButton
            // 
            this.singleRowRadioButton.AutoSize = true;
            this.singleRowRadioButton.Checked = true;
            this.singleRowRadioButton.Location = new System.Drawing.Point(358, 299);
            this.singleRowRadioButton.Name = "singleRowRadioButton";
            this.singleRowRadioButton.Size = new System.Drawing.Size(79, 17);
            this.singleRowRadioButton.TabIndex = 20;
            this.singleRowRadioButton.TabStop = true;
            this.singleRowRadioButton.Text = "Single Row";
            this.singleRowRadioButton.UseVisualStyleBackColor = true;
            this.singleRowRadioButton.CheckedChanged += new System.EventHandler(this.singleRowRadioButton_CheckedChanged);
            // 
            // tripleRowRadioButton
            // 
            this.tripleRowRadioButton.AutoSize = true;
            this.tripleRowRadioButton.Location = new System.Drawing.Point(441, 299);
            this.tripleRowRadioButton.Name = "tripleRowRadioButton";
            this.tripleRowRadioButton.Size = new System.Drawing.Size(76, 17);
            this.tripleRowRadioButton.TabIndex = 21;
            this.tripleRowRadioButton.Text = "Triple Row";
            this.tripleRowRadioButton.UseVisualStyleBackColor = true;
            this.tripleRowRadioButton.CheckedChanged += new System.EventHandler(this.tripleRowRadioButton_CheckedChanged);
            // 
            // colRightLabel
            // 
            this.colRightLabel.AutoSize = true;
            this.colRightLabel.Location = new System.Drawing.Point(329, 340);
            this.colRightLabel.Name = "colRightLabel";
            this.colRightLabel.Size = new System.Drawing.Size(32, 13);
            this.colRightLabel.TabIndex = 24;
            this.colRightLabel.Text = "Right";
            // 
            // colCenterLabel
            // 
            this.colCenterLabel.AutoSize = true;
            this.colCenterLabel.Location = new System.Drawing.Point(232, 340);
            this.colCenterLabel.Name = "colCenterLabel";
            this.colCenterLabel.Size = new System.Drawing.Size(38, 13);
            this.colCenterLabel.TabIndex = 23;
            this.colCenterLabel.Text = "Center";
            // 
            // colLeftLabel
            // 
            this.colLeftLabel.AutoSize = true;
            this.colLeftLabel.Location = new System.Drawing.Point(139, 340);
            this.colLeftLabel.Name = "colLeftLabel";
            this.colLeftLabel.Size = new System.Drawing.Size(25, 13);
            this.colLeftLabel.TabIndex = 22;
            this.colLeftLabel.Text = "Left";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(142, 661);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 25;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // elevationInfoListBox
            // 
            this.elevationInfoListBox.FormattingEnabled = true;
            this.elevationInfoListBox.Location = new System.Drawing.Point(562, 84);
            this.elevationInfoListBox.Name = "elevationInfoListBox";
            this.elevationInfoListBox.Size = new System.Drawing.Size(236, 173);
            this.elevationInfoListBox.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Clear Pasted";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elevationInfoListBox);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.colRightLabel);
            this.Controls.Add(this.colCenterLabel);
            this.Controls.Add(this.colLeftLabel);
            this.Controls.Add(this.tripleRowRadioButton);
            this.Controls.Add(this.singleRowRadioButton);
            this.Controls.Add(this.sublimeCheckBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rowRightLabel);
            this.Controls.Add(this.rowCenterLabel);
            this.Controls.Add(this.rowLeftLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.elevationOverwriteLabel);
            this.Controls.Add(this.previewListBox);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.PasteDataButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TDS Data Paste Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PasteDataButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.ListBox previewListBox;
        private System.Windows.Forms.Label elevationOverwriteLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rowLeftLabel;
        private System.Windows.Forms.Label rowCenterLabel;
        private System.Windows.Forms.Label rowRightLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox sublimeCheckBox;
        private System.Windows.Forms.RadioButton singleRowRadioButton;
        private System.Windows.Forms.RadioButton tripleRowRadioButton;
        private System.Windows.Forms.Label colRightLabel;
        private System.Windows.Forms.Label colCenterLabel;
        private System.Windows.Forms.Label colLeftLabel;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.ListBox elevationInfoListBox;
        private System.Windows.Forms.Button button1;
    }
}

