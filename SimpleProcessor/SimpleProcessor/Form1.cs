using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SimpleProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshTimer.Start();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void processFind_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != " ")
            {
                int index = listBox1.FindString(textBox1.Text);
                listBox1.SelectedIndex = index;
            }
            else
            {
                textBox1.Text = "It cannot be left blank.";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            comboBox1.Items.Clear();
            int index = listBox1.SelectedIndex, count = 0;
            Process[] processList = Process.GetProcesses();
            foreach (Process pro in processList)
            {
                if (index == count)
                {
                    if (pro.Id != 0)
                    {
                        comboBox1.Text = pro.ProcessName;
                        comboBox1.Items.Add("Physical Memory= " + pro.WorkingSet64);
                        comboBox1.Items.Add("base priority= " + pro.BasePriority);
                        try
                        {
                            comboBox1.Items.Add("priority class= " + pro.PriorityClass);
                        }
                        catch
                        {
                            try
                            {
                                comboBox1.Items.Add("user processor time= " + pro.UserProcessorTime);
                            }
                            catch (Exception)
                            {
                                comboBox1.Items.Add("privileged processor time= " + pro.PrivilegedProcessorTime);
                                comboBox1.Items.Add("total processor time= " + pro.TotalProcessorTime);
                                comboBox1.Items.Add("PagedSystemMemorySize64= " + pro.PagedSystemMemorySize64);
                                comboBox1.Items.Add("PagedMemorySize64= " + pro.PagedMemorySize64);
                            }
                            comboBox1.Items.Add("privileged processor time= " + pro.PrivilegedProcessorTime);
                            comboBox1.Items.Add("total processor time= " + pro.TotalProcessorTime);
                            comboBox1.Items.Add("PagedSystemMemorySize64= " + pro.PagedSystemMemorySize64);
                            comboBox1.Items.Add("PagedMemorySize64= " + pro.PagedMemorySize64);
                            return;
                        }
                        comboBox1.Items.Add("user processor time= " + pro.UserProcessorTime);
                        comboBox1.Items.Add("privileged processor time= " + pro.PrivilegedProcessorTime);
                        comboBox1.Items.Add("total processor time= " + pro.TotalProcessorTime);
                        comboBox1.Items.Add("PagedSystemMemorySize64= " + pro.PagedSystemMemorySize64);
                        comboBox1.Items.Add("PagedMemorySize64= " + pro.PagedMemorySize64);
                    }
                    else
                    {
                        
                    }
                }
                count++;
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            int count = 0;
            Process[] processList = Process.GetProcesses();
            foreach (Process proc in processList)
            {
                if (index == count)
                {
                    proc.Kill();
                    break;
                }
                else
                {
                    count++;
                    continue;
                }
            }
            refreshTimer.Start();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process processes in processList)
            {
                if (processes.Id == 0)
                {
                    listBox1.Items.Add("System Idle" + " - 0");
                }
                else
                {
                    listBox1.Items.Add(processes.ProcessName + " - " + processes.Id);
                }
            }
            refreshTimer.Stop();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            refreshTimer.Start();
        }

        private void starterButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog(); // dosyayı seçme diyaloğunu açıyor
            string name = fileDialog.FileName; // name değişkenine seçilen dosyanın url atıyor
            try
            {
                Process.Start(name); // belirtilen url'deki dosyayı çalıştırıyor
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
