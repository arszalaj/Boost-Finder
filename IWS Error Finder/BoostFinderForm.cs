using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BoostFinder
{
    public partial class BoostFinderForm : Form
    {
        Model model;
        string soundPath;
        List<string> listOfKeys;
        List<string> alreadyFoundEntries = new List<string>();
        public BoostFinderForm()
        {
            InitializeComponent();
            model = new Model();
            urlTextBox.Text = "http://www.elitepvpers.com/forum/";
        }

        private void loadUrlButton_Click(object sender, EventArgs e)
        {
            List<string> listOfKeys = new List<string>();
            { listOfKeys.Add(key1TextBox.Text); }
            { listOfKeys.Add(key2TextBox.Text); }
            { listOfKeys.Add(key3TextBox.Text); }
            { listOfKeys.Add(key4TextBox.Text); }

            turnOn(listOfKeys);
            ////model.getFile(urlTextBox.Text, listOfKeys, soundPath);
            //AutoResetEvent autoEvent = new AutoResetEvent(false);

            //StatusChecker statusChecker = new StatusChecker(10);

            //// Create an inferred delegate that invokes methods for the timer.
            //TimerCallback tcb = turnOn;

            //Timer stateTimer = new Timer(tcb, autoEvent, 1000, 250);

            //var timer = new System.Threading.Timer((f) =>
            //{
            //    turnOn(listOfKeys);
            //}, null, 0, 5000);//TimeSpan.FromMinutes(5).TotalMilliseconds);
            

        }

        public void turnOn(List<string> listOfKeys)
        {
            model.getFile(urlTextBox.Text, listOfKeys, soundPath);
            //loadUrlButton.Enabled = false;
            //backgroundWorker1.RunWorkerAsync();
            key1Label.Text = model.keyCounter[0].ToString();
            key1TextBox.BackColor = model.keyCounter[0] > 0 ? Color.Aqua : Color.White;
            key2Label.Text = model.keyCounter[1].ToString();
            key2TextBox.BackColor = model.keyCounter[1] > 0 ? Color.Aqua : Color.White;
            key3Label.Text = model.keyCounter[2].ToString();
            key3TextBox.BackColor = model.keyCounter[2] > 0 ? Color.Aqua : Color.White;
            key4Label.Text = model.keyCounter[3].ToString();
            key4TextBox.BackColor = model.keyCounter[3] > 0 ? Color.Aqua : Color.White;
            //if (key1Label.InvokeRequired)
            //{
            //    key1Label.BeginInvoke((MethodInvoker)delegate
            //    {
            //        key1Label.Text = model.keyCounter[0].ToString();
            //        key1TextBox.BackColor = model.keyCounter[0] > 0 ? Color.Aqua : Color.White;
            //    });
            //}

            //if (key2Label.InvokeRequired)
            //{
            //    key2Label.BeginInvoke((MethodInvoker)delegate
            //    {
            //        key2Label.Text = model.keyCounter[1].ToString();
            //        key2TextBox.BackColor = model.keyCounter[1] > 0 ? Color.Aqua : Color.White;
            //    });
            //}
            //if (key3Label.InvokeRequired)
            //{
            //    key3Label.BeginInvoke((MethodInvoker)delegate
            //    {
            //        key3Label.Text = model.keyCounter[2].ToString();
            //        key3TextBox.BackColor = model.keyCounter[2] > 0 ? Color.Aqua : Color.White;
            //    });
            //}
            //if (key4Label.InvokeRequired)
            //{
            //    key4Label.BeginInvoke((MethodInvoker)delegate
            //    {
            //        key4Label.Text = model.keyCounter[3].ToString();
            //        key4TextBox.BackColor = model.keyCounter[3] > 0 ? Color.Aqua : Color.White;
            //    });
            //}
            
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
