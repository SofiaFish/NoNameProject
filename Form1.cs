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

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbPath.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            
            DirectoryInfo dir = new DirectoryInfo(tbPath.Text);
            var directory = dir.GetDirectories();
            Type type = typeof(Info);
            foreach (var item in directory)
            {
                var lvi = new ListViewItem(item.Name);
                lvResult.Items.Add(lvi);
                lvi.SubItems.Add(item.GetFiles().ToString());
            }
            
            dir.GetFiles();

        }
    }
}
