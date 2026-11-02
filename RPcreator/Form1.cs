using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RPcreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Аудиофайлы (*.mp3;*.ogg)|*.mp3; *.ogg";
        }

        public void ConvertMp3ToOgg(string inputFile, string outputFile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "ffmpeg.exe";
            startInfo.Arguments = "-y -i \"" + inputFile + "\" - vn -c:a libvorbis -q:a 5\"" + outputFile + "\"";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;

            using (Process process = Process.Start(startInfo))
            {
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode != 0)
                    throw new Exception(error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Path.IsPathFullyQualified(textBox2.Text) && comboBox1.SelectedItem != null)
            {
                music.Items.Add(Path.GetFileName(openFileDialog1.FileName));
                disks.Items.Add(comboBox1.SelectedItem);
                File.Copy(openFileDialog1.FileName, textBox1.Text + "/" + textBox3.Text + "/assets/minecraft/sounds/records/" + comboBox1.SelectedItem + ".ogg");
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (Path.IsPathFullyQualified(textBox1.Text))
            {
                string folder_path = textBox1.Text + "/" + textBox3.Text;
                Directory.CreateDirectory(folder_path);
                File.Copy("pack.mcmeta", folder_path + "/pack.mcmeta");
                string records = folder_path + "/assets/minecraft/sounds/records";
                Directory.CreateDirectory(records);
                save.Enabled = false;
                cancel.Enabled = false;
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void music_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Path.IsPathFullyQualified(textBox2.Text)))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(folderBrowserDialog2.SelectedPath + "/pack.mcmeta"))
                {
                    textBox1.Text = folderBrowserDialog2.SelectedPath;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;

                    string path = folderBrowserDialog2.SelectedPath + "/assets/minecraft/sounds/records/";

                    string[] files = Directory.GetFiles(path);
                    if (files.Length > 0)
                    {
                        foreach (string file in files)
                        {
                            string filename = Path.GetFileName(file);
                            music.Items.Add(filename);
                            disks.Items.Add(filename[..^4]);
                            comboBox1.Items.Remove(filename[..^4]);
                        }
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            music.Items.Clear();
            disks.Items.Clear();
            comboBox1.Items.Clear();
            string[] all_disks = { "13", "cat", "blocks", "chirp", "far", "mall", "mellohi", "stal",
                "strad", "ward", "11", "wait", "otherside", "5","pigstep","relic","precipice",
                "creator","creator_music_box","tears","lava_chicken"};
            comboBox1.Items.AddRange(all_disks);
        }
        //
        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?",
            "Are You Sure?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                if (music.SelectedItem != null)
                {
                    disks.Items.RemoveAt(music.SelectedIndex);
                    music.Items.Remove(music.SelectedItem);
                }
            }
        }
    }
}
