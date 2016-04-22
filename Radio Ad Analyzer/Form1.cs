using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using AXVLC;
using AxAXVLC;


namespace Radio_Ad_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addAudioFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfiledialog = new OpenFileDialog();

            openfiledialog.Title = "Add Audio Files";
            openfiledialog.Filter = ("MP3 Files(.mp3)|*.mp3|All Files (*.*)|*.*");
            openfiledialog.CheckFileExists = true;

            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                var uri = new Uri(@openfiledialog.FileName);
                var convertedURI = uri.AbsoluteUri;
                axVLCPlugin21.playlist.add(convertedURI);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.play();

        }

        private void Pause_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}