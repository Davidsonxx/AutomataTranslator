using AutomataTranslator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ATGUI {
    public partial class Form1 : Form {

        private List<string> AllStrings = new List <string>();
        private List<string> MatchingStrings = new List<string>();
        private List<string> MatchingStringsLines = new List<string>();
        private List<string> MatchingStringsPaths = new List<string>();
        readonly string StringsFilePath = "strings.txt";
        string FileToEditPath = "";
        bool LockLoadedFile = false;
        bool LockEditedLine = false;
        bool BinMode = false;
        bool TmdMode = false;
        private BinTL BinEditor;
        private SMDManager Editor;
        private TMDEditor TmdEditor;

        public Form1() {
            InitializeComponent();
            LoadStringsFile(StringsFilePath);
        }      

        /* -------------------- strings.txt file operations -------------------- */
        private void LoadStringsFile(string path) {
            try {
                AllStrings = File.ReadAllLines(path).ToList();
            } catch {
                textBoxStringSearch.Text = "Nie można odczytać pliku strings.txt.";
                textBoxStringSearch.Enabled = false;
            }
        }

        private void SearchInStringsFile(string expression) {
            try {
                if (expression.Length > 0) {
                    buttonSave.Enabled = false;
                    listBoxFoundStrings.Items.Clear();
                    MatchingStrings.Clear();
                    MatchingStringsPaths.Clear();
                    MatchingStringsLines.Clear();

                    if (checkBoxCaseSensitive.Checked) {
                        MatchingStrings = AllStrings.FindAll(s => s.Substring(s.IndexOf(':') + 2).Contains(expression));
                    } else {
                        MatchingStrings = AllStrings.FindAll(s => s.Substring(s.IndexOf(':') + 2).ToLower().Contains(expression.ToLower()));
                    }

                    MatchingStrings.ForEach(s => MatchingStringsPaths.Add(s.Substring(2, s.IndexOf(':') - 2)));
                    MatchingStrings.ForEach(s => MatchingStringsLines.Add(s.Substring(s.IndexOf(':') + 2)));

                    if (checkBoxShowPaths.Checked) {
                        MatchingStrings.ForEach(s => listBoxFoundStrings.Items.Add(s));
                    } else {
                        MatchingStringsLines.ForEach(s => listBoxFoundStrings.Items.Add(s));
                    }
                }
            } catch { }
        }

        private void ReloadSearchResults() {
            try {
                if (MatchingStrings.Count > 0) {
                    LockLoadedFile = true;
                    int selected_index = listBoxFoundStrings.SelectedIndex;
                    listBoxFoundStrings.Items.Clear();
                    if (checkBoxShowPaths.Checked) {
                        MatchingStrings.ForEach(s => listBoxFoundStrings.Items.Add(s));
                    } else {
                        MatchingStringsLines.ForEach(s => listBoxFoundStrings.Items.Add(s));
                    }
                    listBoxFoundStrings.SelectedIndex = selected_index;
                    LockLoadedFile = false;
                }
            } catch { }
        }

        /* -------------------- BIN/TMD/SMD file operations -------------------- */
        private void LoadFile(string path) {
            try {
                listBoxLinesInFile.Items.Clear();
                BinMode = path.ToLower().EndsWith(".bin");
                TmdMode = path.ToLower().EndsWith(".tmd");
                byte[] Script = File.ReadAllBytes(path);
                string[] strs;
                if (TmdMode) {
                    TmdEditor = new TMDEditor(Script);
                    strs = TmdEditor.Import();
                } else if (BinMode) {
                    BinEditor = new BinTL(Script);
                    BinEditor.ImportTargetLangOnly = !checkBoxShowAllLangs.Checked;
                    strs = BinEditor.Import();
                } else {
                    Editor = new SMDManager(Script);
                    strs = Editor.Import();
                }

                foreach (string str in strs) {
                    string linia = str;
                    string[] niepolskie = { "À", "Â", "È", "Ê", "Ù", "Û", "Ç", "Ô", "à", "â", "è", "ì", "ù", "û", "ç", "ô" };
                    string[] polskie = { "Ą", "Ć", "Ę", "Ł", "Ń", "Ś", "Ź", "Ż", "ą", "ć", "ę", "ł", "ń", "ś", "ź", "ż" };
                    for (int i = 0; i < 16; i++) {
                        linia = linia.Replace(niepolskie[i], polskie[i]);
                    }
                    listBoxLinesInFile.Items.Add(linia);
                }

                textBoxEditedLine.Enabled = true;
                textBoxEditedLine.Clear();
                buttonSave.Enabled = false;
            } catch { }
        }

        private void ReplaceSelectedLine(string text) {
            try {
                LockEditedLine = true;
                listBoxLinesInFile.Items[listBoxLinesInFile.SelectedIndex] = text;
                LockEditedLine = false;
                buttonSave.Enabled = true;
            } catch { }
        }

        private void SaveFile(string path) {
            try {
                string[] Strs = new string[listBoxLinesInFile.Items.Count];

                for (int i = 0; i < Strs.Length; i++) {
                    Strs[i] = listBoxLinesInFile.Items[i].ToString();
                    string[] niepolskie = { "À", "Â", "È", "Ê", "Ù", "Û", "Ç", "Ô", "à", "â", "è", "ì", "ù", "û", "ç", "ô" };
                    string[] polskie = { "Ą", "Ć", "Ę", "Ł", "Ń", "Ś", "Ź", "Ż", "ą", "ć", "ę", "ł", "ń", "ś", "ź", "ż" };

                    for (int j = 0; j < 16; j++) {
                        Strs[i] = Strs[i].Replace(polskie[j], niepolskie[j]);
                    }
                }

                File.WriteAllBytes(path, TmdMode ? TmdEditor.Export(Strs) : (BinMode ? BinEditor.Export(Strs) : Editor.Export(Strs)));
                MessageBox.Show("Zapisano pomyślnie.", "AutomataTranslator GUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSave.Enabled = false;
            } catch { }
        }

        /* -------------------- event handling -------------------- */
        private void buttonSave_Clicked(object sender, EventArgs e) {
            SaveFile(FileToEditPath);
        }

        private void checkBoxCaseSensitive_CheckedChanged(object sender, EventArgs e) {
            SearchInStringsFile(textBoxStringSearch.Text);
        }

        private void checkBoxShowPaths_CheckedChanged(object sender, EventArgs e) {
            ReloadSearchResults();
        }

        private void checkBoxShowAllLangs_CheckedChanged(object sender, EventArgs e) {
            if (FileToEditPath.Length > 0) {
                LoadFile(FileToEditPath);
            }
        }

        private void listBoxLinesInFile_SelectedIndexChanged(object sender, EventArgs e) {
            if (!LockEditedLine) {
                textBoxEditedLine.Text = listBoxLinesInFile.Items[listBoxLinesInFile.SelectedIndex].ToString();
            }
        }

        private void listBoxFoundStrings_SelectedIndexChanged(object sender, EventArgs e) {
            if (!LockLoadedFile) {
                FileToEditPath = MatchingStringsPaths[listBoxFoundStrings.SelectedIndex];
                LoadFile(FileToEditPath);
            }
        }

        private void textBoxEditedLine_KeyPress(object sender, KeyPressEventArgs e) {
             if ((e.KeyChar == '\n' || e.KeyChar == '\r') && textBoxEditedLine.TextLength > 0) {
                 ReplaceSelectedLine(textBoxEditedLine.Text);
             }
        }


        private void textBoxStringSearch_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar == '\n' || e.KeyChar == '\r') && textBoxStringSearch.TextLength > 0) {
                SearchInStringsFile(textBoxStringSearch.Text);
            }
        }
    }
}
