using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Sheet_metal_board_reminder
{
    public partial class MainForm : Form
    {
        private WarningForm warningForm;
        private Settings settings;
        private string[] emptyContainers;
        private const string runningStat = "Status: Běží";
        private const string stoppedStat = "Status: Neběží";
        private const string defaultPath = @"\\192.168.1.217\HeliosIQ\Trumpf\Export_from_FAB\SingleStockExp.xml";
        private string sheetList = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\seznam.txt";
        private List<string> listOfSheets = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            settings = new Settings();
            lblStatus.Text = stoppedStat;
            tbXmlFile.Text = settings.xmlFilePath;
            tbTimer.Text = settings.timer;
            btnStop.Enabled = false;
            if (!File.Exists(sheetList))
            {
                btnStart.Enabled = false;
                MessageBox.Show("Nebyl nalezen seznam plechů", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listOfSheets = File.ReadAllLines(sheetList).ToList<string>();
            }
            chbOnStartTimer.Checked = settings.onStartTimer;
            if(chbOnStartTimer.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
                Start();
            }

        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML |*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbXmlFile.Text = openFileDialog.FileName;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblStatus.Text = stoppedStat;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Read2();
            lblStatus.Text = $"{runningStat} - poslední kontrola: {DateTime.Now}";
        }
        private void Start()
        {
            if (File.Exists(tbXmlFile.Text))
            {
                if (Int32.TryParse(tbTimer.Text, out int result))
                {
                    if (Convert.ToInt32(tbTimer.Text) > 0)
                    {
                        timer1.Interval = Convert.ToInt32(tbTimer.Text) * 60000;
                        timer1.Start();
                        lblStatus.Text = $"{runningStat} - poslední kontrola: {DateTime.Now}";
                        Read2();
                        btnStart.Enabled = false;
                        btnStop.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Časovač musí být větší než 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Zadaná hodnota časovače není platná", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vybraný soubor neexistuje", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Read2()
        {
            if (File.Exists(tbXmlFile.Text))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(tbXmlFile.Text);
                List<string> emptyList = new List<string>();
                XmlNodeList xmlnodeList = xmlDoc.GetElementsByTagName("Container");
                foreach (XmlNode xmlnode in xmlnodeList)
                {
                    string name = xmlnode.Attributes["ContainerIdentNo"].Value;
                    bool haveBoards = false;
                    
                    foreach (XmlNode xmlnode2 in xmlnode.ChildNodes)
                    {
                        if (xmlnode2.Name == "SingleStock")
                        {
                            foreach (XmlNode xmlnode3 in xmlnode2.ChildNodes)
                            {
                                if (xmlnode3.Name == "Quantity")
                                {
                                    if (Convert.ToInt32(Convert.ToDecimal(xmlnode3.InnerText.Replace('.', ','))) > 0)
                                    {
                                        haveBoards = true;
                                    }
                                }
                            }
                        }
                    }
                    if (!haveBoards)
                    {
                        emptyList.Add(name);
                    }
                }

                if (warningForm != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        warningForm.Close();
                    });
                }

                if (emptyList != null && emptyList.Count > 0)
                {
                    emptyContainers = Translate(emptyList.ToArray());

                    string r = "";
                    foreach (string s in emptyContainers)
                    {
                        r += s + "\n";
                    }
                    warningForm = new WarningForm(r);
                    warningForm.StartPosition = FormStartPosition.CenterScreen;
                    warningForm.Show();
                }
            }
            else
            {
                timer1.Stop();
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                lblStatus.Text = stoppedStat;
                MessageBox.Show("Nebyl nalezen XML soubor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string[] Translate(string[] array)
        {
            List<string> result = new List<string>();

            foreach(string s in array)
            {
                foreach(string s2 in listOfSheets)
                {
                    if(s2.Contains(s))
                    {
                        string[] tmpArray = s2.Split('%');
                        result.Add(tmpArray[0].Replace("SP0", "Police č.: ") + " - " + tmpArray[1] + "\n");
                    }
                }
            }
            
            return result.ToArray();
        }

        private void BtnDefault_Click(object sender, EventArgs e)
        {
            tbXmlFile.Text = defaultPath;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.xmlFilePath = tbXmlFile.Text;
            settings.timer = tbTimer.Text;
            settings.onStartTimer = chbOnStartTimer.Checked;
            settings.Save();
        }
    }
}