
using System;
using System.Windows.Forms;

namespace AskueObserver
{
    partial class FirstForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tablessControl1 = new AskueObserver.TablessControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonObektItems = new System.Windows.Forms.Button();
            this.buttonObektBack = new System.Windows.Forms.Button();
            this.ObektDataGridView = new System.Windows.Forms.DataGridView();
            this.N_OB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FiderDataGridView = new System.Windows.Forms.DataGridView();
            this.n_fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_sh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dat_pov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kl_napr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kt_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kt_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_kre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFiderTestseti = new System.Windows.Forms.Button();
            this.buttonFiderAutoread = new System.Windows.Forms.Button();
            this.buttonFiderPok = new System.Windows.Forms.Button();
            this.buttonFiderBack = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ProfileDataGridView = new System.Windows.Forms.DataGridView();
            this.profile_n_sh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile_dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile_pok_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile_rash_poln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProfileRadioButton4 = new System.Windows.Forms.RadioButton();
            this.ProfileRadioButton3 = new System.Windows.Forms.RadioButton();
            this.ProfileRadioButton2 = new System.Windows.Forms.RadioButton();
            this.ProfileRadioButton1 = new System.Windows.Forms.RadioButton();
            this.ProfileMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonProfileBack = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.AutoreadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Akwh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bkwh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сkwh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AutoreadRadioButton4 = new System.Windows.Forms.RadioButton();
            this.AutoreadRadioButton3 = new System.Windows.Forms.RadioButton();
            this.AutoreadRadioButton2 = new System.Windows.Forms.RadioButton();
            this.AutoreadRadioButton1 = new System.Windows.Forms.RadioButton();
            this.AutoreadMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonAutoreadBack = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.TestsetiDataGridView = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TestsetiMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonTestsetiBack = new System.Windows.Forms.Button();
            this.TestsetiN_sh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestsetiTestime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.tablessControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObektDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiderDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoreadDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestsetiDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tablessControl1
            // 
            this.tablessControl1.Controls.Add(this.tabPage1);
            this.tablessControl1.Controls.Add(this.tabPage2);
            this.tablessControl1.Controls.Add(this.tabPage3);
            this.tablessControl1.Controls.Add(this.tabPage4);
            this.tablessControl1.Controls.Add(this.tabPage5);
            this.tablessControl1.Controls.Add(this.tabPage6);
            this.tablessControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablessControl1.Location = new System.Drawing.Point(0, 0);
            this.tablessControl1.Name = "tablessControl1";
            this.tablessControl1.SelectedIndex = 0;
            this.tablessControl1.Size = new System.Drawing.Size(734, 739);
            this.tablessControl1.TabIndex = 9;
            this.tablessControl1.SelectedIndexChanged += new System.EventHandler(this.tablessControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 713);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главное меню";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 85);
            this.button1.TabIndex = 10;
            this.button1.Text = "Объекты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(33, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 85);
            this.button3.TabIndex = 9;
            this.button3.Text = "Тревоги";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(33, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 85);
            this.button2.TabIndex = 8;
            this.button2.Text = "Последние показания";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.ObektDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 713);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Объекты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonObektItems);
            this.panel1.Controls.Add(this.buttonObektBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(482, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 707);
            this.panel1.TabIndex = 1;
            // 
            // buttonObektItems
            // 
            this.buttonObektItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonObektItems.Location = new System.Drawing.Point(16, 132);
            this.buttonObektItems.Name = "buttonObektItems";
            this.buttonObektItems.Size = new System.Drawing.Size(210, 85);
            this.buttonObektItems.TabIndex = 12;
            this.buttonObektItems.Text = "Точки учета";
            this.buttonObektItems.UseVisualStyleBackColor = true;
            this.buttonObektItems.Click += new System.EventHandler(this.buttonObektItems_Click);
            // 
            // buttonObektBack
            // 
            this.buttonObektBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonObektBack.Location = new System.Drawing.Point(16, 18);
            this.buttonObektBack.Name = "buttonObektBack";
            this.buttonObektBack.Size = new System.Drawing.Size(210, 85);
            this.buttonObektBack.TabIndex = 11;
            this.buttonObektBack.Text = "Назад";
            this.buttonObektBack.UseVisualStyleBackColor = true;
            this.buttonObektBack.Click += new System.EventHandler(this.buttonObektBack_Click);
            // 
            // ObektDataGridView
            // 
            this.ObektDataGridView.AllowUserToAddRows = false;
            this.ObektDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObektDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_OB,
            this.TXT});
            this.ObektDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObektDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ObektDataGridView.Name = "ObektDataGridView";
            this.ObektDataGridView.ReadOnly = true;
            this.ObektDataGridView.Size = new System.Drawing.Size(720, 707);
            this.ObektDataGridView.TabIndex = 0;
            this.ObektDataGridView.SelectionChanged += new System.EventHandler(this.ObektDataGridView_SelectionChanged);
            // 
            // N_OB
            // 
            this.N_OB.DataPropertyName = "N_OB";
            this.N_OB.HeaderText = "№ ПС";
            this.N_OB.Name = "N_OB";
            this.N_OB.ReadOnly = true;
            this.N_OB.Width = 70;
            // 
            // TXT
            // 
            this.TXT.DataPropertyName = "TXT";
            this.TXT.HeaderText = "Название";
            this.TXT.Name = "TXT";
            this.TXT.ReadOnly = true;
            this.TXT.Width = 220;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.FiderDataGridView);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(726, 713);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Точки учета";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FiderDataGridView
            // 
            this.FiderDataGridView.AllowUserToAddRows = false;
            this.FiderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FiderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_fid,
            this.disnam,
            this.n_sh,
            this.name_typ,
            this.dat_pov,
            this.kl_napr,
            this.kt_1,
            this.kt_2,
            this.cod_kre});
            this.FiderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiderDataGridView.Location = new System.Drawing.Point(3, 3);
            this.FiderDataGridView.Name = "FiderDataGridView";
            this.FiderDataGridView.Size = new System.Drawing.Size(479, 707);
            this.FiderDataGridView.TabIndex = 3;
            // 
            // n_fid
            // 
            this.n_fid.DataPropertyName = "n_fid";
            this.n_fid.HeaderText = "ИИК";
            this.n_fid.Name = "n_fid";
            this.n_fid.Width = 50;
            // 
            // disnam
            // 
            this.disnam.DataPropertyName = "disnam";
            this.disnam.HeaderText = "Фидер";
            this.disnam.Name = "disnam";
            this.disnam.Width = 150;
            // 
            // n_sh
            // 
            this.n_sh.DataPropertyName = "n_sh";
            this.n_sh.HeaderText = "Счетчик";
            this.n_sh.Name = "n_sh";
            // 
            // name_typ
            // 
            this.name_typ.DataPropertyName = "name_typ";
            this.name_typ.HeaderText = "Тип";
            this.name_typ.Name = "name_typ";
            // 
            // dat_pov
            // 
            this.dat_pov.DataPropertyName = "dat_pov";
            this.dat_pov.HeaderText = "Дата поверки";
            this.dat_pov.Name = "dat_pov";
            // 
            // kl_napr
            // 
            this.kl_napr.DataPropertyName = "kl_napr";
            this.kl_napr.HeaderText = "Класс напр.";
            this.kl_napr.Name = "kl_napr";
            // 
            // kt_1
            // 
            this.kt_1.DataPropertyName = "kt_1";
            this.kt_1.HeaderText = "kt_1";
            this.kt_1.Name = "kt_1";
            // 
            // kt_2
            // 
            this.kt_2.DataPropertyName = "kt_2";
            this.kt_2.HeaderText = "kt_2";
            this.kt_2.Name = "kt_2";
            // 
            // cod_kre
            // 
            this.cod_kre.DataPropertyName = "cod_kre";
            this.cod_kre.HeaderText = "Код АСКУЭ";
            this.cod_kre.Name = "cod_kre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonFiderTestseti);
            this.panel2.Controls.Add(this.buttonFiderAutoread);
            this.panel2.Controls.Add(this.buttonFiderPok);
            this.panel2.Controls.Add(this.buttonFiderBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(482, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 707);
            this.panel2.TabIndex = 2;
            // 
            // buttonFiderTestseti
            // 
            this.buttonFiderTestseti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFiderTestseti.Location = new System.Drawing.Point(16, 360);
            this.buttonFiderTestseti.Name = "buttonFiderTestseti";
            this.buttonFiderTestseti.Size = new System.Drawing.Size(210, 85);
            this.buttonFiderTestseti.TabIndex = 14;
            this.buttonFiderTestseti.Text = "Измерения";
            this.buttonFiderTestseti.UseVisualStyleBackColor = true;
            this.buttonFiderTestseti.Click += new System.EventHandler(this.buttonFiderTestseti_Click);
            // 
            // buttonFiderAutoread
            // 
            this.buttonFiderAutoread.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFiderAutoread.Location = new System.Drawing.Point(16, 246);
            this.buttonFiderAutoread.Name = "buttonFiderAutoread";
            this.buttonFiderAutoread.Size = new System.Drawing.Size(210, 85);
            this.buttonFiderAutoread.TabIndex = 13;
            this.buttonFiderAutoread.Text = "Авточтения";
            this.buttonFiderAutoread.UseVisualStyleBackColor = true;
            this.buttonFiderAutoread.Click += new System.EventHandler(this.buttonFiderAutoread_Click);
            // 
            // buttonFiderPok
            // 
            this.buttonFiderPok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFiderPok.Location = new System.Drawing.Point(16, 132);
            this.buttonFiderPok.Name = "buttonFiderPok";
            this.buttonFiderPok.Size = new System.Drawing.Size(210, 85);
            this.buttonFiderPok.TabIndex = 12;
            this.buttonFiderPok.Text = "Показания";
            this.buttonFiderPok.UseVisualStyleBackColor = true;
            this.buttonFiderPok.Click += new System.EventHandler(this.buttonFiderPok_Click);
            // 
            // buttonFiderBack
            // 
            this.buttonFiderBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFiderBack.Location = new System.Drawing.Point(16, 18);
            this.buttonFiderBack.Name = "buttonFiderBack";
            this.buttonFiderBack.Size = new System.Drawing.Size(210, 85);
            this.buttonFiderBack.TabIndex = 11;
            this.buttonFiderBack.Text = "Назад";
            this.buttonFiderBack.UseVisualStyleBackColor = true;
            this.buttonFiderBack.Click += new System.EventHandler(this.buttonFiderBack_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ProfileDataGridView);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(726, 713);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Показания";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ProfileDataGridView
            // 
            this.ProfileDataGridView.AllowUserToAddRows = false;
            this.ProfileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profile_n_sh,
            this.profile_dat,
            this.profile_pok_start,
            this.profile_rash_poln});
            this.ProfileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ProfileDataGridView.Name = "ProfileDataGridView";
            this.ProfileDataGridView.Size = new System.Drawing.Size(479, 707);
            this.ProfileDataGridView.TabIndex = 4;
            // 
            // profile_n_sh
            // 
            this.profile_n_sh.DataPropertyName = "n_sh";
            this.profile_n_sh.HeaderText = "Счетчик";
            this.profile_n_sh.Name = "profile_n_sh";
            // 
            // profile_dat
            // 
            this.profile_dat.DataPropertyName = "dat";
            this.profile_dat.HeaderText = "Дата";
            this.profile_dat.Name = "profile_dat";
            // 
            // profile_pok_start
            // 
            this.profile_pok_start.DataPropertyName = "pok_start";
            this.profile_pok_start.HeaderText = "Показания";
            this.profile_pok_start.Name = "profile_pok_start";
            // 
            // profile_rash_poln
            // 
            this.profile_rash_poln.DataPropertyName = "rash_poln";
            this.profile_rash_poln.HeaderText = "Расход";
            this.profile_rash_poln.Name = "profile_rash_poln";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProfileRadioButton4);
            this.panel3.Controls.Add(this.ProfileRadioButton3);
            this.panel3.Controls.Add(this.ProfileRadioButton2);
            this.panel3.Controls.Add(this.ProfileRadioButton1);
            this.panel3.Controls.Add(this.ProfileMonthCalendar);
            this.panel3.Controls.Add(this.buttonProfileBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(482, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 707);
            this.panel3.TabIndex = 3;
            // 
            // ProfileRadioButton4
            // 
            this.ProfileRadioButton4.AutoSize = true;
            this.ProfileRadioButton4.Location = new System.Drawing.Point(16, 417);
            this.ProfileRadioButton4.Name = "ProfileRadioButton4";
            this.ProfileRadioButton4.Size = new System.Drawing.Size(94, 17);
            this.ProfileRadioButton4.TabIndex = 18;
            this.ProfileRadioButton4.Text = "отд.РЭ(кварч)";
            this.ProfileRadioButton4.UseVisualStyleBackColor = true;
            this.ProfileRadioButton4.CheckedChanged += new System.EventHandler(this.ProfileRadioButton1_CheckedChanged);
            // 
            // ProfileRadioButton3
            // 
            this.ProfileRadioButton3.AutoSize = true;
            this.ProfileRadioButton3.Location = new System.Drawing.Point(16, 380);
            this.ProfileRadioButton3.Name = "ProfileRadioButton3";
            this.ProfileRadioButton3.Size = new System.Drawing.Size(100, 17);
            this.ProfileRadioButton3.TabIndex = 17;
            this.ProfileRadioButton3.Text = "потр.РЭ(кварч)";
            this.ProfileRadioButton3.UseVisualStyleBackColor = true;
            this.ProfileRadioButton3.CheckedChanged += new System.EventHandler(this.ProfileRadioButton1_CheckedChanged);
            // 
            // ProfileRadioButton2
            // 
            this.ProfileRadioButton2.AutoSize = true;
            this.ProfileRadioButton2.Location = new System.Drawing.Point(16, 345);
            this.ProfileRadioButton2.Name = "ProfileRadioButton2";
            this.ProfileRadioButton2.Size = new System.Drawing.Size(91, 17);
            this.ProfileRadioButton2.TabIndex = 16;
            this.ProfileRadioButton2.Text = "отд. АЭ(кВтч)";
            this.ProfileRadioButton2.UseVisualStyleBackColor = true;
            this.ProfileRadioButton2.CheckedChanged += new System.EventHandler(this.ProfileRadioButton1_CheckedChanged);
            // 
            // ProfileRadioButton1
            // 
            this.ProfileRadioButton1.AutoSize = true;
            this.ProfileRadioButton1.Checked = true;
            this.ProfileRadioButton1.Location = new System.Drawing.Point(16, 310);
            this.ProfileRadioButton1.Name = "ProfileRadioButton1";
            this.ProfileRadioButton1.Size = new System.Drawing.Size(94, 17);
            this.ProfileRadioButton1.TabIndex = 15;
            this.ProfileRadioButton1.TabStop = true;
            this.ProfileRadioButton1.Text = "потр.АЭ(кВтч)";
            this.ProfileRadioButton1.UseVisualStyleBackColor = true;
            this.ProfileRadioButton1.CheckedChanged += new System.EventHandler(this.ProfileRadioButton1_CheckedChanged);
            // 
            // ProfileMonthCalendar
            // 
            this.ProfileMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileMonthCalendar.Location = new System.Drawing.Point(16, 127);
            this.ProfileMonthCalendar.Name = "ProfileMonthCalendar";
            this.ProfileMonthCalendar.TabIndex = 14;
            this.ProfileMonthCalendar.TodayDate = new System.DateTime(2023, 9, 17, 0, 0, 0, 0);
            // 
            // buttonProfileBack
            // 
            this.buttonProfileBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProfileBack.Location = new System.Drawing.Point(16, 18);
            this.buttonProfileBack.Name = "buttonProfileBack";
            this.buttonProfileBack.Size = new System.Drawing.Size(210, 85);
            this.buttonProfileBack.TabIndex = 11;
            this.buttonProfileBack.Text = "Назад";
            this.buttonProfileBack.UseVisualStyleBackColor = true;
            this.buttonProfileBack.Click += new System.EventHandler(this.buttonFiderBack_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.AutoreadDataGridView);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(726, 713);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Авточтения";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // AutoreadDataGridView
            // 
            this.AutoreadDataGridView.AllowUserToAddRows = false;
            this.AutoreadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoreadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Akwh,
            this.Bkwh,
            this.Сkwh,
            this.kwha});
            this.AutoreadDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoreadDataGridView.Location = new System.Drawing.Point(3, 3);
            this.AutoreadDataGridView.Name = "AutoreadDataGridView";
            this.AutoreadDataGridView.Size = new System.Drawing.Size(479, 707);
            this.AutoreadDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "n_sh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Счетчик";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dat";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Akwh
            // 
            this.Akwh.DataPropertyName = "akwh";
            this.Akwh.HeaderText = "Тариф1";
            this.Akwh.Name = "Akwh";
            // 
            // Bkwh
            // 
            this.Bkwh.DataPropertyName = "bkwh";
            this.Bkwh.HeaderText = "Тариф2";
            this.Bkwh.Name = "Bkwh";
            // 
            // Сkwh
            // 
            this.Сkwh.DataPropertyName = "ckwh";
            this.Сkwh.HeaderText = "Тариф3";
            this.Сkwh.Name = "Сkwh";
            // 
            // kwha
            // 
            this.kwha.DataPropertyName = "kwha";
            this.kwha.HeaderText = "Сумма";
            this.kwha.Name = "kwha";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AutoreadRadioButton4);
            this.panel4.Controls.Add(this.AutoreadRadioButton3);
            this.panel4.Controls.Add(this.AutoreadRadioButton2);
            this.panel4.Controls.Add(this.AutoreadRadioButton1);
            this.panel4.Controls.Add(this.AutoreadMonthCalendar);
            this.panel4.Controls.Add(this.buttonAutoreadBack);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(482, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 707);
            this.panel4.TabIndex = 5;
            // 
            // AutoreadRadioButton4
            // 
            this.AutoreadRadioButton4.AutoSize = true;
            this.AutoreadRadioButton4.Location = new System.Drawing.Point(16, 417);
            this.AutoreadRadioButton4.Name = "AutoreadRadioButton4";
            this.AutoreadRadioButton4.Size = new System.Drawing.Size(94, 17);
            this.AutoreadRadioButton4.TabIndex = 18;
            this.AutoreadRadioButton4.Text = "отд.РЭ(кварч)";
            this.AutoreadRadioButton4.UseVisualStyleBackColor = true;
            this.AutoreadRadioButton4.CheckedChanged += new System.EventHandler(this.AutoreadRadioButton1_CheckedChanged);
            // 
            // AutoreadRadioButton3
            // 
            this.AutoreadRadioButton3.AutoSize = true;
            this.AutoreadRadioButton3.Location = new System.Drawing.Point(16, 380);
            this.AutoreadRadioButton3.Name = "AutoreadRadioButton3";
            this.AutoreadRadioButton3.Size = new System.Drawing.Size(100, 17);
            this.AutoreadRadioButton3.TabIndex = 17;
            this.AutoreadRadioButton3.Text = "потр.РЭ(кварч)";
            this.AutoreadRadioButton3.UseVisualStyleBackColor = true;
            this.AutoreadRadioButton3.CheckedChanged += new System.EventHandler(this.AutoreadRadioButton1_CheckedChanged);
            // 
            // AutoreadRadioButton2
            // 
            this.AutoreadRadioButton2.AutoSize = true;
            this.AutoreadRadioButton2.Location = new System.Drawing.Point(16, 345);
            this.AutoreadRadioButton2.Name = "AutoreadRadioButton2";
            this.AutoreadRadioButton2.Size = new System.Drawing.Size(91, 17);
            this.AutoreadRadioButton2.TabIndex = 16;
            this.AutoreadRadioButton2.Text = "отд. АЭ(кВтч)";
            this.AutoreadRadioButton2.UseVisualStyleBackColor = true;
            this.AutoreadRadioButton2.CheckedChanged += new System.EventHandler(this.AutoreadRadioButton1_CheckedChanged);
            // 
            // AutoreadRadioButton1
            // 
            this.AutoreadRadioButton1.AutoSize = true;
            this.AutoreadRadioButton1.Checked = true;
            this.AutoreadRadioButton1.Location = new System.Drawing.Point(16, 310);
            this.AutoreadRadioButton1.Name = "AutoreadRadioButton1";
            this.AutoreadRadioButton1.Size = new System.Drawing.Size(94, 17);
            this.AutoreadRadioButton1.TabIndex = 15;
            this.AutoreadRadioButton1.TabStop = true;
            this.AutoreadRadioButton1.Text = "потр.АЭ(кВтч)";
            this.AutoreadRadioButton1.UseVisualStyleBackColor = true;
            this.AutoreadRadioButton1.CheckedChanged += new System.EventHandler(this.AutoreadRadioButton1_CheckedChanged);
            // 
            // AutoreadMonthCalendar
            // 
            this.AutoreadMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoreadMonthCalendar.Location = new System.Drawing.Point(16, 127);
            this.AutoreadMonthCalendar.Name = "AutoreadMonthCalendar";
            this.AutoreadMonthCalendar.TabIndex = 14;
            this.AutoreadMonthCalendar.TodayDate = new System.DateTime(2023, 9, 17, 0, 0, 0, 0);
            this.AutoreadMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AutoreadMonthCalendar_DateChanged);
            // 
            // buttonAutoreadBack
            // 
            this.buttonAutoreadBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAutoreadBack.Location = new System.Drawing.Point(16, 18);
            this.buttonAutoreadBack.Name = "buttonAutoreadBack";
            this.buttonAutoreadBack.Size = new System.Drawing.Size(210, 85);
            this.buttonAutoreadBack.TabIndex = 11;
            this.buttonAutoreadBack.Text = "Назад";
            this.buttonAutoreadBack.UseVisualStyleBackColor = true;
            this.buttonAutoreadBack.Click += new System.EventHandler(this.buttonAutoreadBack_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.TestsetiDataGridView);
            this.tabPage6.Controls.Add(this.panel5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(726, 713);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Измерения";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // TestsetiDataGridView
            // 
            this.TestsetiDataGridView.AllowUserToAddRows = false;
            this.TestsetiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestsetiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestsetiN_sh,
            this.TestsetiTestime});
            this.TestsetiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestsetiDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TestsetiDataGridView.Name = "TestsetiDataGridView";
            this.TestsetiDataGridView.Size = new System.Drawing.Size(479, 707);
            this.TestsetiDataGridView.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TestsetiMonthCalendar);
            this.panel5.Controls.Add(this.buttonTestsetiBack);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(482, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 707);
            this.panel5.TabIndex = 4;
            // 
            // TestsetiMonthCalendar
            // 
            this.TestsetiMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestsetiMonthCalendar.Location = new System.Drawing.Point(16, 127);
            this.TestsetiMonthCalendar.Name = "TestsetiMonthCalendar";
            this.TestsetiMonthCalendar.TabIndex = 14;
            this.TestsetiMonthCalendar.TodayDate = new System.DateTime(2023, 9, 17, 0, 0, 0, 0);
            // 
            // buttonTestsetiBack
            // 
            this.buttonTestsetiBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTestsetiBack.Location = new System.Drawing.Point(16, 18);
            this.buttonTestsetiBack.Name = "buttonTestsetiBack";
            this.buttonTestsetiBack.Size = new System.Drawing.Size(210, 85);
            this.buttonTestsetiBack.TabIndex = 11;
            this.buttonTestsetiBack.Text = "Назад";
            this.buttonTestsetiBack.UseVisualStyleBackColor = true;
            this.buttonTestsetiBack.Click += new System.EventHandler(this.buttonAutoreadBack_Click);
            // 
            // TestsetiN_sh
            // 
            this.TestsetiN_sh.DataPropertyName = "n_sh";
            this.TestsetiN_sh.HeaderText = "Счетчик";
            this.TestsetiN_sh.Name = "TestsetiN_sh";
            // 
            // TestsetiTestime
            // 
            this.TestsetiTestime.DataPropertyName = "testtime";
            this.TestsetiTestime.HeaderText = "Дата";
            this.TestsetiTestime.Name = "TestsetiTestime";
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 761);
            this.Controls.Add(this.tablessControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обозреватель АСКУЭ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstForm_FormClosing);
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tablessControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ObektDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FiderDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoreadDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestsetiDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private TablessControl tablessControl1;
        private TabPage tabPage1;
        private Button button1;
        private Button button3;
        private Button button2;
        private TabPage tabPage2;
        private DataGridView ObektDataGridView;
        private Panel panel1;
        private Button buttonObektBack;
        private DataGridViewTextBoxColumn N_OB;
        private DataGridViewTextBoxColumn TXT;
        private Button buttonObektItems;
        private TabPage tabPage3;
        private Panel panel2;
        private Button buttonFiderTestseti;
        private Button buttonFiderAutoread;
        private Button buttonFiderPok;
        private Button buttonFiderBack;
        private DataGridView FiderDataGridView;
        private DataGridViewTextBoxColumn n_fid;
        private DataGridViewTextBoxColumn disnam;
        private DataGridViewTextBoxColumn n_sh;
        private DataGridViewTextBoxColumn name_typ;
        private DataGridViewTextBoxColumn dat_pov;
        private DataGridViewTextBoxColumn kl_napr;
        private DataGridViewTextBoxColumn kt_1;
        private DataGridViewTextBoxColumn kt_2;
        private DataGridViewTextBoxColumn cod_kre;
        private TabPage tabPage4;
        private DataGridView ProfileDataGridView;
        private Panel panel3;
        private Button buttonProfileBack;
        private DataGridViewTextBoxColumn profile_n_sh;
        private DataGridViewTextBoxColumn profile_dat;
        private DataGridViewTextBoxColumn profile_pok_start;
        private DataGridViewTextBoxColumn profile_rash_poln;
        private RadioButton ProfileRadioButton4;
        private RadioButton ProfileRadioButton3;
        private RadioButton ProfileRadioButton2;
        private RadioButton ProfileRadioButton1;
        private MonthCalendar ProfileMonthCalendar;
        private TabPage tabPage5;
        private DataGridView AutoreadDataGridView;
        private Panel panel4;
        private RadioButton AutoreadRadioButton4;
        private RadioButton AutoreadRadioButton3;
        private RadioButton AutoreadRadioButton2;
        private RadioButton AutoreadRadioButton1;
        private MonthCalendar AutoreadMonthCalendar;
        private Button buttonAutoreadBack;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Akwh;
        private DataGridViewTextBoxColumn Bkwh;
        private DataGridViewTextBoxColumn Сkwh;
        private DataGridViewTextBoxColumn kwha;
        private TabPage tabPage6;
        private DataGridView TestsetiDataGridView;
        private Panel panel5;
        private MonthCalendar TestsetiMonthCalendar;
        private Button buttonTestsetiBack;
        private DataGridViewTextBoxColumn TestsetiN_sh;
        private DataGridViewTextBoxColumn TestsetiTestime;
    }
}

