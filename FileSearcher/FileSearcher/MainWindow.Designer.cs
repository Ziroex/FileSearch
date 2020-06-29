namespace FileSearcher
{
    partial class MainWindow
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
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchDirTextBox = new System.Windows.Forms.TextBox();
            this.selectSearchDirButton = new System.Windows.Forms.Button();
            this.includeSubDirsCheckBox = new System.Windows.Forms.CheckBox();
            this.newerThanCheckBox = new System.Windows.Forms.CheckBox();
            this.newerThanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.olderThanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.olderThanCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unicodeRadioButton = new System.Windows.Forms.RadioButton();
            this.asciiRadioButton = new System.Windows.Forms.RadioButton();
            this.containingTextBox = new System.Windows.Forms.TextBox();
            this.containingCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delimeterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.writeResultsButton = new System.Windows.Forms.Button();
            this.resultsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openContainingFolderContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Location = new System.Drawing.Point(126, 61);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(345, 20);
            this.fileNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя файла:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Директория поиска:";
            // 
            // searchDirTextBox
            // 
            this.searchDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDirTextBox.Location = new System.Drawing.Point(126, 12);
            this.searchDirTextBox.Name = "searchDirTextBox";
            this.searchDirTextBox.Size = new System.Drawing.Size(345, 20);
            this.searchDirTextBox.TabIndex = 1;
            // 
            // selectSearchDirButton
            // 
            this.selectSearchDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectSearchDirButton.Location = new System.Drawing.Point(477, 12);
            this.selectSearchDirButton.Name = "selectSearchDirButton";
            this.selectSearchDirButton.Size = new System.Drawing.Size(24, 21);
            this.selectSearchDirButton.TabIndex = 2;
            this.selectSearchDirButton.Text = "...";
            this.selectSearchDirButton.UseVisualStyleBackColor = true;
            this.selectSearchDirButton.Click += new System.EventHandler(this.selectSearchDirButton_Click);
            // 
            // includeSubDirsCheckBox
            // 
            this.includeSubDirsCheckBox.AutoSize = true;
            this.includeSubDirsCheckBox.Location = new System.Drawing.Point(126, 38);
            this.includeSubDirsCheckBox.Name = "includeSubDirsCheckBox";
            this.includeSubDirsCheckBox.Size = new System.Drawing.Size(155, 17);
            this.includeSubDirsCheckBox.TabIndex = 3;
            this.includeSubDirsCheckBox.Text = "Включить поддиректории";
            this.includeSubDirsCheckBox.UseVisualStyleBackColor = true;
            // 
            // newerThanCheckBox
            // 
            this.newerThanCheckBox.AutoSize = true;
            this.newerThanCheckBox.Location = new System.Drawing.Point(6, 22);
            this.newerThanCheckBox.Name = "newerThanCheckBox";
            this.newerThanCheckBox.Size = new System.Drawing.Size(113, 17);
            this.newerThanCheckBox.TabIndex = 0;
            this.newerThanCheckBox.Text = "Файл новее чем:";
            this.newerThanCheckBox.UseVisualStyleBackColor = true;
            this.newerThanCheckBox.CheckedChanged += new System.EventHandler(this.newerThanCheckBox_CheckedChanged);
            // 
            // newerThanDateTimePicker
            // 
            this.newerThanDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.newerThanDateTimePicker.Enabled = false;
            this.newerThanDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newerThanDateTimePicker.Location = new System.Drawing.Point(261, 19);
            this.newerThanDateTimePicker.Name = "newerThanDateTimePicker";
            this.newerThanDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.newerThanDateTimePicker.TabIndex = 1;
            // 
            // olderThanDateTimePicker
            // 
            this.olderThanDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.olderThanDateTimePicker.Enabled = false;
            this.olderThanDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.olderThanDateTimePicker.Location = new System.Drawing.Point(261, 45);
            this.olderThanDateTimePicker.Name = "olderThanDateTimePicker";
            this.olderThanDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.olderThanDateTimePicker.TabIndex = 3;
            // 
            // olderThanCheckBox
            // 
            this.olderThanCheckBox.AutoSize = true;
            this.olderThanCheckBox.Location = new System.Drawing.Point(6, 48);
            this.olderThanCheckBox.Name = "olderThanCheckBox";
            this.olderThanCheckBox.Size = new System.Drawing.Size(118, 17);
            this.olderThanCheckBox.TabIndex = 2;
            this.olderThanCheckBox.Text = "Файл старее чем:";
            this.olderThanCheckBox.UseVisualStyleBackColor = true;
            this.olderThanCheckBox.CheckedChanged += new System.EventHandler(this.olderThanCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.unicodeRadioButton);
            this.groupBox1.Controls.Add(this.asciiRadioButton);
            this.groupBox1.Controls.Add(this.containingTextBox);
            this.groupBox1.Controls.Add(this.containingCheckBox);
            this.groupBox1.Controls.Add(this.olderThanDateTimePicker);
            this.groupBox1.Controls.Add(this.newerThanCheckBox);
            this.groupBox1.Controls.Add(this.olderThanCheckBox);
            this.groupBox1.Controls.Add(this.newerThanDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия";
            // 
            // unicodeRadioButton
            // 
            this.unicodeRadioButton.AutoSize = true;
            this.unicodeRadioButton.Enabled = false;
            this.unicodeRadioButton.Location = new System.Drawing.Point(319, 97);
            this.unicodeRadioButton.Name = "unicodeRadioButton";
            this.unicodeRadioButton.Size = new System.Drawing.Size(65, 17);
            this.unicodeRadioButton.TabIndex = 7;
            this.unicodeRadioButton.TabStop = true;
            this.unicodeRadioButton.Text = "Unicode";
            this.unicodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // asciiRadioButton
            // 
            this.asciiRadioButton.AutoSize = true;
            this.asciiRadioButton.Enabled = false;
            this.asciiRadioButton.Location = new System.Drawing.Point(261, 97);
            this.asciiRadioButton.Name = "asciiRadioButton";
            this.asciiRadioButton.Size = new System.Drawing.Size(52, 17);
            this.asciiRadioButton.TabIndex = 6;
            this.asciiRadioButton.TabStop = true;
            this.asciiRadioButton.Text = "ASCII";
            this.asciiRadioButton.UseVisualStyleBackColor = true;
            // 
            // containingTextBox
            // 
            this.containingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containingTextBox.Enabled = false;
            this.containingTextBox.Location = new System.Drawing.Point(261, 71);
            this.containingTextBox.Name = "containingTextBox";
            this.containingTextBox.Size = new System.Drawing.Size(222, 20);
            this.containingTextBox.TabIndex = 5;
            // 
            // containingCheckBox
            // 
            this.containingCheckBox.AutoSize = true;
            this.containingCheckBox.Location = new System.Drawing.Point(6, 73);
            this.containingCheckBox.Name = "containingCheckBox";
            this.containingCheckBox.Size = new System.Drawing.Size(177, 17);
            this.containingCheckBox.TabIndex = 4;
            this.containingCheckBox.Text = "Файлы, содержащие строку :";
            this.containingCheckBox.UseVisualStyleBackColor = true;
            this.containingCheckBox.CheckedChanged += new System.EventHandler(this.containingCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.delimeterTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.writeResultsButton);
            this.groupBox2.Controls.Add(this.resultsList);
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 259);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // delimeterTextBox
            // 
            this.delimeterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delimeterTextBox.Location = new System.Drawing.Point(150, 233);
            this.delimeterTextBox.MaxLength = 4;
            this.delimeterTextBox.Name = "delimeterTextBox";
            this.delimeterTextBox.Size = new System.Drawing.Size(38, 20);
            this.delimeterTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Разделение для txt файла:";
            // 
            // writeResultsButton
            // 
            this.writeResultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.writeResultsButton.Location = new System.Drawing.Point(333, 230);
            this.writeResultsButton.Name = "writeResultsButton";
            this.writeResultsButton.Size = new System.Drawing.Size(150, 23);
            this.writeResultsButton.TabIndex = 3;
            this.writeResultsButton.Text = "Создать txt файл";
            this.writeResultsButton.UseVisualStyleBackColor = true;
            this.writeResultsButton.Click += new System.EventHandler(this.writeResultsButton_Click);
            // 
            // resultsList
            // 
            this.resultsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.resultsList.ContextMenuStrip = this.contextMenuStrip;
            this.resultsList.FullRowSelect = true;
            this.resultsList.HideSelection = false;
            this.resultsList.Location = new System.Drawing.Point(6, 19);
            this.resultsList.MultiSelect = false;
            this.resultsList.Name = "resultsList";
            this.resultsList.ShowItemToolTips = true;
            this.resultsList.Size = new System.Drawing.Size(477, 205);
            this.resultsList.TabIndex = 0;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.Details;
            this.resultsList.DoubleClick += new System.EventHandler(this.resultsList_DoubleClick);
            this.resultsList.Resize += new System.EventHandler(this.resultsList_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Путь";
            this.columnHeader1.Width = 212;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Размер";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Последнее обновление";
            this.columnHeader3.Width = 120;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openContainingFolderContextMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(198, 26);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // openContainingFolderContextMenuItem
            // 
            this.openContainingFolderContextMenuItem.Name = "openContainingFolderContextMenuItem";
            this.openContainingFolderContextMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openContainingFolderContextMenuItem.Text = "Open containing folder";
            this.openContainingFolderContextMenuItem.Click += new System.EventHandler(this.openContainingFolderContextMenuItem_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(426, 213);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Поиск";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(345, 213);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.stopButton;
            this.ClientSize = new System.Drawing.Size(512, 513);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.includeSubDirsCheckBox);
            this.Controls.Add(this.selectSearchDirButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchDirTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameTextBox);
            this.MinimumSize = new System.Drawing.Size(485, 490);
            this.Name = "MainWindow";
            this.Text = "Поиск файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchDirTextBox;
        private System.Windows.Forms.Button selectSearchDirButton;
        private System.Windows.Forms.CheckBox includeSubDirsCheckBox;
        private System.Windows.Forms.CheckBox newerThanCheckBox;
        private System.Windows.Forms.DateTimePicker newerThanDateTimePicker;
        private System.Windows.Forms.DateTimePicker olderThanDateTimePicker;
        private System.Windows.Forms.CheckBox olderThanCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox containingTextBox;
        private System.Windows.Forms.CheckBox containingCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.RadioButton unicodeRadioButton;
        private System.Windows.Forms.RadioButton asciiRadioButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderContextMenuItem;
        private System.Windows.Forms.TextBox delimeterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button writeResultsButton;
    }
}

