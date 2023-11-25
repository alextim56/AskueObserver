using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using AskueObserver.Model;

namespace AskueObserver
{
    public partial class FirstForm : Form
    {
        DatabaseManager databaseManager;
        BindingSource obektSource;
        BindingSource fidSource;
        BindingSource profileSource;
        string SelectedObekt;

        public FirstForm()
        {
            InitializeComponent();
            this.Width = 300;
            this.Height = 450;
            tablessControl1.SelectedIndex = 0;
        }

        public static void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Ошибка записи app settings");
            }
        }

        private void Connected(object sender, EventArgs e)
        {
            button1.Enabled = databaseManager.isConnected;
            button2.Enabled = databaseManager.isConnected;
            button3.Enabled = databaseManager.isConnected;

            if (databaseManager.isConnected)
            {
                toolStripStatusLabel1.Text = "Подключение установлено";
            }
            else
            {
                toolStripStatusLabel1.Text = "Нет подключения";
            }
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            databaseManager = new DatabaseManager(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            databaseManager.OnConnected += Connected;
            databaseManager.OnDisconnected += Connected;

            obektSource = new BindingSource();
            //fidSource = new BindingSource();
            ObektDataGridView.AutoGenerateColumns = false;
            FiderDataGridView.AutoGenerateColumns = false;
            ProfileDataGridView.AutoGenerateColumns = false;
            TestsetiDataGridView.AutoGenerateColumns = false;

            //временно отключим реакцию на изменение и установим текущую дату
            ProfileMonthCalendar.DateChanged -= ProfileMonthCalendar_DateChanged;
            AutoreadMonthCalendar.DateChanged -= AutoreadMonthCalendar_DateChanged;
            TestsetiMonthCalendar.DateChanged -= TestsetiMonthCalendar_DateChanged;
            ProfileMonthCalendar.SelectionStart = DateTime.Now;
            ProfileMonthCalendar.SelectionEnd = DateTime.Now;
            AutoreadMonthCalendar.SelectionStart = DateTime.Now;
            AutoreadMonthCalendar.SelectionEnd = DateTime.Now;
            TestsetiMonthCalendar.SelectionStart = DateTime.Now;
            TestsetiMonthCalendar.SelectionEnd = DateTime.Now;
            ProfileMonthCalendar.DateChanged += ProfileMonthCalendar_DateChanged;
            AutoreadMonthCalendar.DateChanged += AutoreadMonthCalendar_DateChanged;
            TestsetiMonthCalendar.DateChanged += TestsetiMonthCalendar_DateChanged;

            SelectedObekt = ConfigurationManager.AppSettings["SelectedObekt"];

            string errMsg;
            errMsg = databaseManager.Connect();
            if (errMsg != "")
            {
                //MessageBox.Show($"Ошибка подключения - {errMsg}");
                toolStripStatusLabel1.Text = $"Ошибка подключения - {errMsg}";
            }

        }

        private void FirstForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseManager.CloseConnection();
        }

        #region MenuNavigation
        private void button1_Click(object sender, EventArgs e)
        {
            ObektDataGridView.SelectionChanged -= ObektDataGridView_SelectionChanged;
            databaseManager.LoadObekts();
            int selectedObekt = 0;
            if (SelectedObekt != null)
            {
                foreach (var obekt in databaseManager.Obekts)
                {
                    if (obekt.N_ob.ToString() == SelectedObekt)
                    {
                        break;
                    }
                    selectedObekt++;
                }
            }
            obektSource.DataSource = databaseManager.Obekts;
            ObektDataGridView.DataSource = obektSource;
            obektSource.Position = selectedObekt;
            //obektSource.Position = obektSource.Find("N_ob", SelectedObekt);
            ObektDataGridView.SelectionChanged += ObektDataGridView_SelectionChanged;
            tablessControl1.SelectedIndex = 1;
            this.Width = 750;
            this.Height = 800;
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            databaseManager.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obektSource.DataSource = databaseManager.LoadOtherObekts();
            ObektDataGridView.DataSource = obektSource;
            tablessControl1.SelectedIndex = 1;
        }

        private void buttonObektBack_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 0;
            toolStripStatusLabel1.Text = "Главное меню";
            this.Width = 300;
            this.Height = 450;
            this.CenterToScreen();
        }

        private void buttonObektItems_Click(object sender, EventArgs e)
        {
            //определим какой выбран объект
            Obekt currow = (Obekt)obektSource.Current;
            int id = currow.N_ob;
            databaseManager.LoadFiderList(id);
            fidSource = new BindingSource();
            fidSource.DataSource = databaseManager.Fiders;
            FiderDataGridView.DataSource = fidSource;
            tablessControl1.SelectedIndex = 2;
        }

        private void buttonFiderBack_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex--;
        }
        private void buttonFiderPok_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 3;
        }
        #endregion MenuNavigation

        private void tablessControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = tablessControl1.SelectedTab.Text;
        }

        private void ShowData(int n_gr, DateTime dt)
        {
            //определим какой выбран фидер
            Fid currow = (Fid)fidSource.Current;
            if (tablessControl1.SelectedIndex == 3)
            {
                databaseManager.LoadMeterProfile(currow.N_ob, currow.N_fid, n_gr, dt);
                profileSource = new BindingSource();
                profileSource.DataSource = databaseManager.Profiles;
                ProfileDataGridView.DataSource = profileSource;
            }
            if (tablessControl1.SelectedIndex == 4)
            {
                databaseManager.LoadMeterAutoread(currow.N_ob, currow.N_fid, n_gr, dt);
                profileSource = new BindingSource();
                profileSource.DataSource = databaseManager.Autoreads;
                AutoreadDataGridView.DataSource = profileSource;
            }
            if (tablessControl1.SelectedIndex == 5)
            {
                databaseManager.LoadMeterTestseti(currow.N_sh, dt);
                profileSource = new BindingSource();
                profileSource.DataSource = databaseManager.Testsetis;
                TestsetiDataGridView.DataSource = profileSource;
            }
        }

        private void ProfileMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dt;
            databaseManager.Profiles.Clear();
            int n_gr = 0;
            if (ProfileRadioButton1.Checked) n_gr = 1;
            if (ProfileRadioButton2.Checked) n_gr = 2;
            if (ProfileRadioButton3.Checked) n_gr = 3;
            if (ProfileRadioButton4.Checked) n_gr = 4;

            if (DateTime.TryParse(e.Start.ToString(), out dt))
            {
                ShowData(n_gr, dt);
            }
        }

        private void ProfileRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ProfileMonthCalendar_DateChanged(sender, new DateRangeEventArgs(ProfileMonthCalendar.SelectionStart, ProfileMonthCalendar.SelectionEnd));
        }

        private void buttonFiderAutoread_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 4;
        }

        private void buttonAutoreadBack_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex -= 2;
        }

        private void AutoreadMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dt;
            databaseManager.Autoreads.Clear();
            int n_gr = 0;
            if (AutoreadRadioButton1.Checked) n_gr = 1;
            if (AutoreadRadioButton2.Checked) n_gr = 2;
            if (AutoreadRadioButton3.Checked) n_gr = 3;
            if (AutoreadRadioButton4.Checked) n_gr = 4;

            if (DateTime.TryParse(e.Start.ToString(), out dt))
            {
                ShowData(n_gr, dt);
            }
        }

        private void AutoreadRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AutoreadMonthCalendar_DateChanged(sender, new DateRangeEventArgs(AutoreadMonthCalendar.SelectionStart, AutoreadMonthCalendar.SelectionEnd));
        }

        private void ObektDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (obektSource != null)
            {
                //определим какой выбран объект
                Obekt currow = (Obekt)obektSource.Current;
                SelectedObekt = currow.N_ob.ToString();
                AddOrUpdateAppSettings("SelectedObekt", SelectedObekt);
            }
        }

        private void TestsetiMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dt;
            databaseManager.Testsetis.Clear();
            int n_gr = 0;

            if (DateTime.TryParse(e.Start.ToString(), out dt))
            {
                ShowData(n_gr, dt);
            }
        }

        private void buttonFiderTestseti_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 5;
        }
    }
}
