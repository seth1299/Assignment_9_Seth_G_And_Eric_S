using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        #region Global Variable declarations

        private WorldViewModel _viewModel;

        private WorldViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (ViewModel != value)
                {
                    _viewModel = value;
                  //  worldViewModelBindingSource.DataSource = _viewModel; //This was giving off errors. Commented out
                }
            }
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();

            /*
            _worldDependentControls = new Control[]
            {
                addPlayerButton;
            }
            */
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
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename ="TestFile.json";

            _viewModel.SaveWorld(filename);

            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
