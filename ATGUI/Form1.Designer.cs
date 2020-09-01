namespace ATGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxLinesInFile = new System.Windows.Forms.ListBox();
            this.textBoxEditedLine = new System.Windows.Forms.TextBox();
            this.textBoxStringSearch = new System.Windows.Forms.TextBox();
            this.listBoxFoundStrings = new System.Windows.Forms.ListBox();
            this.checkBoxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPaths = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxShowAllLangs = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxLinesInFile, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEditedLine, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxStringSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxFoundStrings, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxCaseSensitive, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxShowPaths, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(990, 497);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listBoxLinesInFile
            // 
            this.listBoxLinesInFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLinesInFile.FormattingEnabled = true;
            this.listBoxLinesInFile.HorizontalScrollbar = true;
            this.listBoxLinesInFile.Location = new System.Drawing.Point(3, 251);
            this.listBoxLinesInFile.Name = "listBoxLinesInFile";
            this.listBoxLinesInFile.Size = new System.Drawing.Size(784, 217);
            this.listBoxLinesInFile.TabIndex = 0;
            this.listBoxLinesInFile.SelectedIndexChanged += new System.EventHandler(this.listBoxLinesInFile_SelectedIndexChanged);
            // 
            // textBoxEditedLine
            // 
            this.textBoxEditedLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEditedLine.Enabled = false;
            this.textBoxEditedLine.Location = new System.Drawing.Point(3, 474);
            this.textBoxEditedLine.Name = "textBoxEditedLine";
            this.textBoxEditedLine.Size = new System.Drawing.Size(784, 20);
            this.textBoxEditedLine.TabIndex = 1;
            this.textBoxEditedLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditedLine_KeyPress);
            // 
            // textBoxStringSearch
            // 
            this.textBoxStringSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStringSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxStringSearch.Name = "textBoxStringSearch";
            this.textBoxStringSearch.Size = new System.Drawing.Size(784, 20);
            this.textBoxStringSearch.TabIndex = 2;
            this.textBoxStringSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStringSearch_KeyPress);
            // 
            // listBoxFoundStrings
            // 
            this.listBoxFoundStrings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFoundStrings.FormattingEnabled = true;
            this.listBoxFoundStrings.HorizontalScrollbar = true;
            this.listBoxFoundStrings.Location = new System.Drawing.Point(3, 28);
            this.listBoxFoundStrings.Name = "listBoxFoundStrings";
            this.listBoxFoundStrings.Size = new System.Drawing.Size(784, 217);
            this.listBoxFoundStrings.TabIndex = 3;
            this.listBoxFoundStrings.SelectedIndexChanged += new System.EventHandler(this.listBoxFoundStrings_SelectedIndexChanged);
            // 
            // checkBoxCaseSensitive
            // 
            this.checkBoxCaseSensitive.AutoSize = true;
            this.checkBoxCaseSensitive.Location = new System.Drawing.Point(793, 3);
            this.checkBoxCaseSensitive.Name = "checkBoxCaseSensitive";
            this.checkBoxCaseSensitive.Size = new System.Drawing.Size(146, 17);
            this.checkBoxCaseSensitive.TabIndex = 4;
            this.checkBoxCaseSensitive.Text = "Uwzględniaj wielkość liter";
            this.checkBoxCaseSensitive.UseVisualStyleBackColor = true;
            this.checkBoxCaseSensitive.CheckedChanged += new System.EventHandler(this.checkBoxCaseSensitive_CheckedChanged);
            // 
            // checkBoxShowPaths
            // 
            this.checkBoxShowPaths.AutoSize = true;
            this.checkBoxShowPaths.Location = new System.Drawing.Point(793, 28);
            this.checkBoxShowPaths.Name = "checkBoxShowPaths";
            this.checkBoxShowPaths.Size = new System.Drawing.Size(111, 17);
            this.checkBoxShowPaths.TabIndex = 5;
            this.checkBoxShowPaths.Text = "Wyświetlaj ścieżki";
            this.checkBoxShowPaths.UseVisualStyleBackColor = true;
            this.checkBoxShowPaths.CheckedChanged += new System.EventHandler(this.checkBoxShowPaths_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSave, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxShowAllLangs, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(790, 248);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 223);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(194, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Clicked);
            // 
            // checkBoxShowAllLangs
            // 
            this.checkBoxShowAllLangs.AutoSize = true;
            this.checkBoxShowAllLangs.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxShowAllLangs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxShowAllLangs.Location = new System.Drawing.Point(3, 32);
            this.checkBoxShowAllLangs.Name = "checkBoxShowAllLangs";
            this.checkBoxShowAllLangs.Size = new System.Drawing.Size(194, 43);
            this.checkBoxShowAllLangs.TabIndex = 7;
            this.checkBoxShowAllLangs.Text = "Wyświetl wszystkie języki\r\n(użyj, jeśli na liście brakuje kwestii)\r\nUtracisz niez" +
    "apisane postępy!\r\n";
            this.checkBoxShowAllLangs.UseVisualStyleBackColor = true;
            this.checkBoxShowAllLangs.CheckedChanged += new System.EventHandler(this.checkBoxShowAllLangs_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AutomataTranslator GUI - wersja polska";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxLinesInFile;
        private System.Windows.Forms.TextBox textBoxEditedLine;
        private System.Windows.Forms.TextBox textBoxStringSearch;
        private System.Windows.Forms.ListBox listBoxFoundStrings;
        private System.Windows.Forms.CheckBox checkBoxCaseSensitive;
        private System.Windows.Forms.CheckBox checkBoxShowPaths;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxShowAllLangs;
    }
}

