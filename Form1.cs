using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF_redactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void FormTheme(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            bool isDay = currentTime.Hour >= 6 &  currentTime.Hour <= 18;
            if (isDay)
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
            else
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
            }
        }

        private void openBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string result = OpenFile();
            if (result != "none")
            {
                TextBox.LoadFile(result);
            }
        }

        private string OpenFile()
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "RTF files (*.rtf)|*.rtf";
                of.InitialDirectory = Environment.CurrentDirectory;

                if (of.ShowDialog() == DialogResult.OK)
                {
                    return of.FileName;
                }
            }
            return "none";
        }
    }
 
}
