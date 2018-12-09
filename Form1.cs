using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Mtext : Form
    {
        bool isaved;
        public Mtext()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "Untitled.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
               
                System.IO.File.WriteAllLines(Path.GetFullPath(savefile.FileName), codebox.Lines);

            }


        }

        #region Labels and links

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://fedqxcode.wordpress.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fedqx");
        }

        private void cppreference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.cppreference.com/w/");
        }

        private void creference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.cppreference.com/w/c");
        }

        private void asmreference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.felixcloutier.com/x86/");
        }

        private void javareference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.oracle.com/javase/specs/jls/se8/html/");
        }

        private void csharpreference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/");
        }

        #endregion

        private void openbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
               codebox.Lines = System.IO.File.ReadAllLines(selectedFileName);
                Filenamelabel.Text = selectedFileName;
                isaved = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Filenamelabel.Text == "")
            {
                MessageBox.Show("Cannot open file!");
            }
            else
            {
                System.IO.File.WriteAllText(Filenamelabel.Text, codebox.Text);
                isaved = true;
            }
            
        }


        private void Mtext_Load(object sender, EventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
           codebox.Size = new System.Drawing.Size(751,Convert.ToInt32(numericUpDown1.Value));
            
        }

        private void Mtext_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
