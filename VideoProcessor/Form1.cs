using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbInputDir.AppendText("C:\\Users\\Lennart\\Desktop\\Lennart\\Masterarbeit\\Videos\\BAK8013\\7_23_2019_11_32_37");
            tbOutputDir.AppendText("C:\\Users\\Lennart\\Desktop\\Lennart\\Masterarbeit\\Videos");
        }

        private void btInputDirDialog_Click(object sender, EventArgs e)
        {
            using (var Dialog = new FolderBrowserDialog())
            {
                DialogResult Result = Dialog.ShowDialog();
                if (Result == DialogResult.OK && !string.IsNullOrWhiteSpace(Dialog.SelectedPath))
                {
                    if (Dialog.SelectedPath[Dialog.SelectedPath.Length-1] != '\\')
                        Dialog.SelectedPath += "\\";

                    tbInputDir.Text = Dialog.SelectedPath;
                }
            }
        }

        private void btOutputDirDialog_Click(object sender, EventArgs e)
        {
            using (var Dialog = new FolderBrowserDialog())
            {
                DialogResult Result = Dialog.ShowDialog();

                if (Result == DialogResult.OK && !string.IsNullOrWhiteSpace(Dialog.SelectedPath))
                {
                    if (Dialog.SelectedPath[Dialog.SelectedPath.Length-1] != '\\')
                        Dialog.SelectedPath += "\\";

                    tbOutputDir.Text = Dialog.SelectedPath;
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            string InputPath = tbInputDir.Text;
            string OutputPath = tbOutputDir.Text;
            if (!OutputPath.EndsWith("\\"))
                OutputPath += "\\";

            if (System.IO.Directory.Exists(InputPath) && System.IO.Directory.Exists(OutputPath))
            {
                string[] FilePaths = System.IO.Directory.GetFiles(InputPath);

                for (int i = 0; i < FilePaths.Length; ++i)
                {
                    if (FilePaths[i].EndsWith(".avi"))
                    {
                        string FileNameWithoutPath = System.IO.Path.GetFileNameWithoutExtension(FilePaths[i]);
                        string FileCompleteTop = OutputPath + FileNameWithoutPath + "_top" + System.IO.Path.GetExtension(FilePaths[i]);
                        string FileCompleteBottom = OutputPath + FileNameWithoutPath + "_bottom" + System.IO.Path.GetExtension(FilePaths[i]);

                        ProcessTop(FilePaths[i], FileCompleteTop);
                        ProcessBottom(FilePaths[i], FileCompleteBottom);
                    }
                }

                btStart.Text = "Done!";
            }
            else
            {
                MessageBox.Show("Please enter valid directory paths.");
            }
        }

        private void ProcessTop(string FileInput, string FileOutput)
        {
            using (Process p = new Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.FileName = "ffmpeg.exe";                             // width:height:xoffset:yoffset           ohne: -codec libx264 -preset ultrafast -crf 0 für windows Mediaplayer
                p.StartInfo.Arguments = "-i " + FileInput + " -filter_complex \"[0:v]crop=512:250:0:6[vid]; [vid]scale=512:512\" -codec libx264 -preset ultrafast -crf 0 " + FileOutput;
                                                                                                            // width : height
                p.Start();
                p.WaitForExit();
            }
        }

        private void ProcessBottom(string FileInput, string FileOutput)
        {
            using (Process p = new Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.FileName = "ffmpeg.exe";                               // width:height:xoffset:yoffset           ohne: -codec libx264 -preset ultrafast -crf 0 für windows Mediaplayer
                p.StartInfo.Arguments = "-i " + FileInput + " -filter_complex \"[0:v]crop=512:256:0:256[vid]; [vid]scale=512:512\" -codec libx264 -preset ultrafast -crf 0 " + FileOutput;
                                                                                                            // width : height
                p.Start();
                p.WaitForExit();
            }
        }
    }
}
