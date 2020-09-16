using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Management;

namespace Kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckWebCoonection_Click(object sender, EventArgs e)
        {
            txtWebConnectionStatus.Text = CheckForInternetConnection() ? "Данный компьютер подключен к интернету!" : "Данный компьютер не подключен к интернету!";
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void btnCheckExistanceFirewall_Click(object sender, EventArgs e)
        {
            txtCheckExistanceFirewall.Text = File.Exists("C:\\Program Files\\COMODO\\COMODO Internet Security\\cis.exe") ? "Фаервол COMODO установлен!" : "Фаервол COMODO не установлен!";
        }

        private void btnCheckFirewall_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            String Response;
            try
            {
                Response = client.DownloadString("http://wwwwww.googlе.com");
            }
            catch
            {
                txtbtnCheckFirewall.Text = "Межсетевой экран функционирует правильно!";
            }
            txtbtnCheckFirewall.Text = "Межсетевой экран функционирует неверно, или не функционирует во-все!";

        }

        private void btnCheckExistaneAntivirus_Click(object sender, EventArgs e)
        {
            string name = "Avast Free Antivirus";
            txtCheckExistaneAntivirus.Text= IsProgramInstalled(name) ? "Антивирус Avast установлен в системе" : "Антивирус Avast не установлен в системе";


        }

        public static bool IsProgramInstalled(string programDisplayName)
        {

            Console.WriteLine(string.Format("Checking install status of: {0}", programDisplayName));
            foreach (var item in Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall").GetSubKeyNames())
            {

                object programName = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + item).GetValue("DisplayName");

                Console.WriteLine(programName);

                if (string.Equals(programName, programDisplayName))
                {
                    Console.WriteLine("Install status: INSTALLED");
                    return true;
                }
            }
            Console.WriteLine("Install status: NOT INSTALLED");
            return false;
        }


        private void btnTestAntivirus_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        int i = 20;
        string file_name = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(i)
            {
                case 0:
                    if(!File.Exists("mallware.txt"))
                        txtTestAntivirus.Text = "Файл с вирусом заблокирован антивирусом.";
                    else
                        txtTestAntivirus.Text = "Файл с вирусом не заблокирован антивирусом.";
                    i = 20;
                    file_name = "";
                    timer1.Stop();
                    return;
                default:
                    txtTestAntivirus.Text = "Cоздан файл с вирусом.Ждем " + i + "с.";
                    if (file_name == "")
                    {
                        File.WriteAllText("mallware.txt","X5O!P%@AP[4\\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H" + "+H*");
                        file_name = "mallware.txt";
                    }
                    break;
            }
            i--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //Вывод информации о проверки наличия соединения
            textBox1.Text = "Результаты проведенного тестирования антивируса и фаервола" + System.Environment.NewLine + System.Environment.NewLine;
            if (txtWebConnectionStatus.Text != "...") 
                textBox1.Text = textBox1.Text + "1. " + txtWebConnectionStatus.Text;
            else
            {               
               textBox1.Text = textBox1.Text + " 1. Тестирование подключения к интернету не выполнялось";
            }
            textBox1.Text = textBox1.Text + System.Environment.NewLine;


            if (txtCheckExistanceFirewall.Text != "...")
                textBox1.Text = textBox1.Text + "2. " + txtCheckExistanceFirewall.Text;
            else
            {
                textBox1.Text = textBox1.Text + " 2. Тестирование наличия МЭ не выполнялось";
            }
            textBox1.Text = textBox1.Text + System.Environment.NewLine;
            
            if (txtbtnCheckFirewall.Text != "...")
                textBox1.Text = textBox1.Text + "3. " + txtbtnCheckFirewall.Text;
            else
            {
                textBox1.Text = textBox1.Text + " 3. Тестирование работоспособности МЭ не выполнялось";
            }
            textBox1.Text = textBox1.Text + System.Environment.NewLine;


            if (txtCheckExistaneAntivirus.Text != "...")
                textBox1.Text = textBox1.Text + "4. " + txtCheckExistaneAntivirus.Text;
            else
            {
                textBox1.Text = textBox1.Text + " 4. Тестирование наличия антивируса не выполнялось";
            }
            textBox1.Text = textBox1.Text + System.Environment.NewLine;


            if (txtTestAntivirus.Text != "...")
                textBox1.Text = textBox1.Text + "5. " + txtTestAntivirus.Text;
            else
            {
                textBox1.Text = textBox1.Text + " 5. Тестирование работоспособности антивируса не выполнялось";
            }
            textBox1.Text = textBox1.Text + System.Environment.NewLine;
            txtWebConnectionStatus.Clear();
            txtCheckExistanceFirewall.Clear();
            txtbtnCheckFirewall.Clear();
            txtCheckExistaneAntivirus.Clear();
            txtTestAntivirus.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                File.WriteAllText(filename, textBox1.Text);
            }

        }
    }
}
