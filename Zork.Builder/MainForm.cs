using Newtonsoft.Json;
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
using Zork;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {

        //internal WorldViewModel ViewModel { get; private set; }

        private WorldViewModel _viewModel;

        private WorldViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (ViewModel != value)
                {
                    _viewModel = value;
                    worldViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }


        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
            }
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to quit Zork Builder?";
            const string caption = "The adventure must continue!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
