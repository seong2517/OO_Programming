using System;
using System.Windows.Forms;

namespace UpgradeMemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.Modified)
            {
                DialogResult dr = MessageBox.Show("변경 내용을 저장하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    저장ToolStripMenuItem_Click(null, null);
                }
                else if (dr == DialogResult.No)
                {
                    textBox.Text = string.Empty;
                }
                else
                {

                }
            }
            else
            {
                
            }
		}

        string filename = "";
        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                string Data = System.IO.File.ReadAllText(filename);
                textBox.Text = Data;
            }
        }
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(filename == "")
            {
                saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일|*.*";
                DialogResult dr = saveFileDialog1.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox.Text);
                    filename = saveFileDialog1.FileName;
                }
            }
            else
            {
                System.IO.File.WriteAllText(filename, textBox.Text);
            }
        }
        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일|*.*";
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox.Text);
            }
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.WordWrap = !textBox.WordWrap;
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox.Font = fontDialog1.Font;
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info i = new Info();
            i.ShowDialog();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox.Modified)
            {
                DialogResult dr = MessageBox.Show("변경 내용을 저장하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    저장ToolStripMenuItem_Click(null, null);
                }
                else if (dr == DialogResult.No)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {

            }
        }
        private void textBox_SelectionChanged(object sender, EventArgs e)
        {
            int ln = textBox.GetLineFromCharIndex(textBox.SelectionStart) + 1;
            int col = textBox.SelectionStart -
            textBox.GetFirstCharIndexOfCurrentLine() + 1;
            toolStripStatusLabel1.Text = "Ln " + ln + ", Col " + col;
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void 시간날짜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = String.Format("{0} {1}", DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
        }

        private void 전체선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }
    }
}