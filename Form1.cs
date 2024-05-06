using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SourceChangeSearch
{
    public partial class Form1 : Form
    {
        Thread t = null;
        volatile bool running = true;
        string text = string.Empty;
        volatile bool updated = false;

        public Form1()
        {
            InitializeComponent();

            t = new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while(running)
                {
                    if(updated)
                    {
                        string text_copy = "";
                        lock (text)
                        {
                            text_copy = string.Copy(text);
                        }

                        updated = false;

                        if (text != null)
                        {
                            Process p = new Process();
                            // Redirect the output stream of the child process.
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.CreateNoWindow = true;

                            p.StartInfo.FileName = "git";
                            p.StartInfo.Arguments = "log -S \"" + text + "\"";
                            p.Start();
                            string output = p.StandardOutput.ReadToEnd();
                            p.WaitForExit();

                            string filteredLines = string.Join("\n", output.Split('\n').Where(l => l.Contains("GOG Galaxy SDK")).ToArray());
                            results_textbox.BeginInvoke(new Action(() =>
                            {
                                    results_textbox.Text = filteredLines;
                            }));
                        }
                    }
                }
            });

            t.Start();
        }

        private void text_input_TextChanged(object sender, EventArgs e)
        {
            lock (text)
            {
                text = text_input.Text;
                updated = true;
            }        
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            running = false;
        }
    }
}
