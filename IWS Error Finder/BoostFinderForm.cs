using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoostFinder
{
    public partial class BoostFinderForm : Form
    {
        Presenter presenter;
        string soundPath;
        public BoostFinderForm()
        {
            InitializeComponent();
            presenter = new Presenter();
            urlTextBox.Text = "http://www.elitepvpers.com/forum/";
        }

        private void loadUrlButton_Click(object sender, EventArgs e)
        {

            presenter.getFile(urlTextBox.Text, key1TextBox.Text, soundPath);

            /*
            var timer = new System.Threading.Timer((f) =>
            {
                turnOn();
            }, null, 0, 10000);//TimeSpan.FromMinutes(5).TotalMilliseconds);
            */


        }

        private void turnOn()
        {
            presenter.getFile(urlTextBox.Text, key1TextBox.Text, soundPath);
            //loadUrlButton.Enabled = false;
            //backgroundWorker1.RunWorkerAsync();
        }

        private void getData()
        {
            //errorsContentMemoEdit.Text = presenter.getFile(urlTextBox.Text);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            getData();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadUrlButton.Enabled = true;
        }

        private void soundPathButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                soundPath = openFileDialog1.FileName;
                soundTextBox.Text = soundPath;
                try
                {
                    //string text = File.ReadAllText(file);
                    //size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(result);
        }

    }
}
