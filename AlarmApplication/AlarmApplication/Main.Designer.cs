
namespace AlarmApplication
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_OnButton = new System.Windows.Forms.Panel();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnStopwatch = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.pnl_alarm = new System.Windows.Forms.Panel();
            this.lbl_AlarmHour = new System.Windows.Forms.Label();
            this.lbl_AlarmSeconds = new System.Windows.Forms.Label();
            this.lbl_AlarmMinutes = new System.Windows.Forms.Label();
            this.pnl_AlarmBottom = new System.Windows.Forms.Panel();
            this.btn_SetAlarm = new System.Windows.Forms.Button();
            this.lbl_AlarmTime = new System.Windows.Forms.Label();
            this.btn_StopAlarm = new System.Windows.Forms.Button();
            this.pnl_AlarmTop = new System.Windows.Forms.Panel();
            this.lbl_CurrentTime = new System.Windows.Forms.Label();
            this.cb_Second = new System.Windows.Forms.ComboBox();
            this.cb_Minute = new System.Windows.Forms.ComboBox();
            this.cb_Hour = new System.Windows.Forms.ComboBox();
            this.pnl_Stopwatch = new System.Windows.Forms.Panel();
            this.btn_SW_Start = new System.Windows.Forms.Button();
            this.btn_SW_Reset = new System.Windows.Forms.Button();
            this.btn_SW_Pause = new System.Windows.Forms.Button();
            this.lbl_Stopwatch = new System.Windows.Forms.Label();
            this.pnl_Timer = new System.Windows.Forms.Panel();
            this.pnl_TimerTop = new System.Windows.Forms.Panel();
            this.lbl_TimerSeconds = new System.Windows.Forms.Label();
            this.lbl_TimerMinutes = new System.Windows.Forms.Label();
            this.lbl_TimerCount = new System.Windows.Forms.Label();
            this.cb_TimerMinute = new System.Windows.Forms.ComboBox();
            this.btn_TimerStart = new System.Windows.Forms.Button();
            this.cb_TimerSecond = new System.Windows.Forms.ComboBox();
            this.btn_TimerPause = new System.Windows.Forms.Button();
            this.timer_CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.timer_AlarmTime = new System.Windows.Forms.Timer(this.components);
            this.timer_Stopwatch = new System.Windows.Forms.Timer(this.components);
            this.timer_Timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_Move = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pnl_left.SuspendLayout();
            this.pnl_alarm.SuspendLayout();
            this.pnl_AlarmBottom.SuspendLayout();
            this.pnl_AlarmTop.SuspendLayout();
            this.pnl_Stopwatch.SuspendLayout();
            this.pnl_Timer.SuspendLayout();
            this.pnl_TimerTop.SuspendLayout();
            this.pnl_Move.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(144)))), ((int)(((byte)(219)))));
            this.pnl_left.Controls.Add(this.lbl_Title);
            this.pnl_left.Controls.Add(this.pnl_OnButton);
            this.pnl_left.Controls.Add(this.btnTimer);
            this.pnl_left.Controls.Add(this.btnStopwatch);
            this.pnl_left.Controls.Add(this.btnAlarm);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(200, 498);
            this.pnl_left.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Title.Location = new System.Drawing.Point(12, 28);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(171, 37);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "alarmApp";
            // 
            // pnl_OnButton
            // 
            this.pnl_OnButton.BackColor = System.Drawing.Color.Black;
            this.pnl_OnButton.Location = new System.Drawing.Point(0, 103);
            this.pnl_OnButton.Name = "pnl_OnButton";
            this.pnl_OnButton.Size = new System.Drawing.Size(6, 100);
            this.pnl_OnButton.TabIndex = 5;
            // 
            // btnTimer
            // 
            this.btnTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimer.FlatAppearance.BorderSize = 0;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTimer.Image = global::AlarmApplication.Properties.Resources.sand_clock;
            this.btnTimer.Location = new System.Drawing.Point(0, 363);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(200, 100);
            this.btnTimer.TabIndex = 3;
            this.btnTimer.Text = " Timer";
            this.btnTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnStopwatch
            // 
            this.btnStopwatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopwatch.FlatAppearance.BorderSize = 0;
            this.btnStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopwatch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopwatch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStopwatch.Image = global::AlarmApplication.Properties.Resources.clock_3_;
            this.btnStopwatch.Location = new System.Drawing.Point(0, 233);
            this.btnStopwatch.Name = "btnStopwatch";
            this.btnStopwatch.Size = new System.Drawing.Size(200, 100);
            this.btnStopwatch.TabIndex = 3;
            this.btnStopwatch.Text = " Stopwatch";
            this.btnStopwatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStopwatch.UseVisualStyleBackColor = true;
            this.btnStopwatch.Click += new System.EventHandler(this.btnStopwatch_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAlarm.FlatAppearance.BorderSize = 0;
            this.btnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlarm.Image = global::AlarmApplication.Properties.Resources.alarm_clock;
            this.btnAlarm.Location = new System.Drawing.Point(0, 103);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(200, 100);
            this.btnAlarm.TabIndex = 0;
            this.btnAlarm.Text = " Alarm";
            this.btnAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // pnl_alarm
            // 
            this.pnl_alarm.Controls.Add(this.lbl_AlarmHour);
            this.pnl_alarm.Controls.Add(this.lbl_AlarmSeconds);
            this.pnl_alarm.Controls.Add(this.lbl_AlarmMinutes);
            this.pnl_alarm.Controls.Add(this.pnl_AlarmBottom);
            this.pnl_alarm.Controls.Add(this.pnl_AlarmTop);
            this.pnl_alarm.Controls.Add(this.cb_Second);
            this.pnl_alarm.Controls.Add(this.cb_Minute);
            this.pnl_alarm.Controls.Add(this.cb_Hour);
            this.pnl_alarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_alarm.Location = new System.Drawing.Point(200, 0);
            this.pnl_alarm.Name = "pnl_alarm";
            this.pnl_alarm.Size = new System.Drawing.Size(683, 498);
            this.pnl_alarm.TabIndex = 1;
            this.pnl_alarm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_alarm_Paint);
            this.pnl_alarm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_alarm_MouseDown);
            // 
            // lbl_AlarmHour
            // 
            this.lbl_AlarmHour.AutoSize = true;
            this.lbl_AlarmHour.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlarmHour.Location = new System.Drawing.Point(192, 264);
            this.lbl_AlarmHour.Name = "lbl_AlarmHour";
            this.lbl_AlarmHour.Size = new System.Drawing.Size(54, 23);
            this.lbl_AlarmHour.TabIndex = 13;
            this.lbl_AlarmHour.Text = "Hour:";
            // 
            // lbl_AlarmSeconds
            // 
            this.lbl_AlarmSeconds.AutoSize = true;
            this.lbl_AlarmSeconds.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlarmSeconds.Location = new System.Drawing.Point(376, 264);
            this.lbl_AlarmSeconds.Name = "lbl_AlarmSeconds";
            this.lbl_AlarmSeconds.Size = new System.Drawing.Size(83, 23);
            this.lbl_AlarmSeconds.TabIndex = 12;
            this.lbl_AlarmSeconds.Text = "Seconds:";
            // 
            // lbl_AlarmMinutes
            // 
            this.lbl_AlarmMinutes.AutoSize = true;
            this.lbl_AlarmMinutes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlarmMinutes.Location = new System.Drawing.Point(284, 264);
            this.lbl_AlarmMinutes.Name = "lbl_AlarmMinutes";
            this.lbl_AlarmMinutes.Size = new System.Drawing.Size(80, 23);
            this.lbl_AlarmMinutes.TabIndex = 11;
            this.lbl_AlarmMinutes.Text = "Minutes:";
            // 
            // pnl_AlarmBottom
            // 
            this.pnl_AlarmBottom.Controls.Add(this.btn_SetAlarm);
            this.pnl_AlarmBottom.Controls.Add(this.lbl_AlarmTime);
            this.pnl_AlarmBottom.Controls.Add(this.btn_StopAlarm);
            this.pnl_AlarmBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_AlarmBottom.Location = new System.Drawing.Point(0, 442);
            this.pnl_AlarmBottom.Name = "pnl_AlarmBottom";
            this.pnl_AlarmBottom.Size = new System.Drawing.Size(683, 56);
            this.pnl_AlarmBottom.TabIndex = 10;
            // 
            // btn_SetAlarm
            // 
            this.btn_SetAlarm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SetAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SetAlarm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SetAlarm.FlatAppearance.BorderSize = 0;
            this.btn_SetAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetAlarm.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetAlarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SetAlarm.Location = new System.Drawing.Point(483, 0);
            this.btn_SetAlarm.Name = "btn_SetAlarm";
            this.btn_SetAlarm.Size = new System.Drawing.Size(100, 56);
            this.btn_SetAlarm.TabIndex = 3;
            this.btn_SetAlarm.Text = "Add";
            this.btn_SetAlarm.UseVisualStyleBackColor = false;
            this.btn_SetAlarm.Click += new System.EventHandler(this.btn_SetAlarm_Click);
            // 
            // lbl_AlarmTime
            // 
            this.lbl_AlarmTime.AutoSize = true;
            this.lbl_AlarmTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlarmTime.Location = new System.Drawing.Point(26, 11);
            this.lbl_AlarmTime.Name = "lbl_AlarmTime";
            this.lbl_AlarmTime.Size = new System.Drawing.Size(0, 36);
            this.lbl_AlarmTime.TabIndex = 7;
            // 
            // btn_StopAlarm
            // 
            this.btn_StopAlarm.BackColor = System.Drawing.Color.Tomato;
            this.btn_StopAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StopAlarm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_StopAlarm.FlatAppearance.BorderSize = 0;
            this.btn_StopAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StopAlarm.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StopAlarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_StopAlarm.Location = new System.Drawing.Point(583, 0);
            this.btn_StopAlarm.Name = "btn_StopAlarm";
            this.btn_StopAlarm.Size = new System.Drawing.Size(100, 56);
            this.btn_StopAlarm.TabIndex = 8;
            this.btn_StopAlarm.Text = "Cancel";
            this.btn_StopAlarm.UseVisualStyleBackColor = false;
            this.btn_StopAlarm.Click += new System.EventHandler(this.btn_StopAlarm_Click);
            // 
            // pnl_AlarmTop
            // 
            this.pnl_AlarmTop.Controls.Add(this.lbl_CurrentTime);
            this.pnl_AlarmTop.Location = new System.Drawing.Point(0, 31);
            this.pnl_AlarmTop.Name = "pnl_AlarmTop";
            this.pnl_AlarmTop.Size = new System.Drawing.Size(683, 143);
            this.pnl_AlarmTop.TabIndex = 9;
            // 
            // lbl_CurrentTime
            // 
            this.lbl_CurrentTime.AutoSize = true;
            this.lbl_CurrentTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentTime.Location = new System.Drawing.Point(14, 20);
            this.lbl_CurrentTime.Name = "lbl_CurrentTime";
            this.lbl_CurrentTime.Size = new System.Drawing.Size(255, 104);
            this.lbl_CurrentTime.TabIndex = 1;
            this.lbl_CurrentTime.Text = "Clock";
            // 
            // cb_Second
            // 
            this.cb_Second.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Second.FormattingEnabled = true;
            this.cb_Second.Location = new System.Drawing.Point(380, 290);
            this.cb_Second.Name = "cb_Second";
            this.cb_Second.Size = new System.Drawing.Size(86, 24);
            this.cb_Second.TabIndex = 6;
            // 
            // cb_Minute
            // 
            this.cb_Minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Minute.FormattingEnabled = true;
            this.cb_Minute.Location = new System.Drawing.Point(288, 290);
            this.cb_Minute.Name = "cb_Minute";
            this.cb_Minute.Size = new System.Drawing.Size(86, 24);
            this.cb_Minute.TabIndex = 5;
            this.cb_Minute.SelectedIndexChanged += new System.EventHandler(this.cb_Minute_SelectedIndexChanged);
            // 
            // cb_Hour
            // 
            this.cb_Hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Hour.FormattingEnabled = true;
            this.cb_Hour.Location = new System.Drawing.Point(196, 290);
            this.cb_Hour.Name = "cb_Hour";
            this.cb_Hour.Size = new System.Drawing.Size(86, 24);
            this.cb_Hour.TabIndex = 4;
            // 
            // pnl_Stopwatch
            // 
            this.pnl_Stopwatch.Controls.Add(this.btn_SW_Start);
            this.pnl_Stopwatch.Controls.Add(this.btn_SW_Reset);
            this.pnl_Stopwatch.Controls.Add(this.btn_SW_Pause);
            this.pnl_Stopwatch.Controls.Add(this.lbl_Stopwatch);
            this.pnl_Stopwatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Stopwatch.Location = new System.Drawing.Point(200, 0);
            this.pnl_Stopwatch.Name = "pnl_Stopwatch";
            this.pnl_Stopwatch.Size = new System.Drawing.Size(683, 498);
            this.pnl_Stopwatch.TabIndex = 2;
            this.pnl_Stopwatch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Stopwatch_Paint);
            // 
            // btn_SW_Start
            // 
            this.btn_SW_Start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SW_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SW_Start.FlatAppearance.BorderSize = 0;
            this.btn_SW_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SW_Start.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SW_Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SW_Start.Location = new System.Drawing.Point(210, 320);
            this.btn_SW_Start.Name = "btn_SW_Start";
            this.btn_SW_Start.Size = new System.Drawing.Size(106, 54);
            this.btn_SW_Start.TabIndex = 1;
            this.btn_SW_Start.Text = "Start";
            this.btn_SW_Start.UseVisualStyleBackColor = false;
            this.btn_SW_Start.Click += new System.EventHandler(this.btn_SW_Start_Click);
            // 
            // btn_SW_Reset
            // 
            this.btn_SW_Reset.BackColor = System.Drawing.Color.Tomato;
            this.btn_SW_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SW_Reset.FlatAppearance.BorderSize = 0;
            this.btn_SW_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SW_Reset.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SW_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SW_Reset.Location = new System.Drawing.Point(359, 320);
            this.btn_SW_Reset.Name = "btn_SW_Reset";
            this.btn_SW_Reset.Size = new System.Drawing.Size(106, 54);
            this.btn_SW_Reset.TabIndex = 3;
            this.btn_SW_Reset.Text = "Cancel";
            this.btn_SW_Reset.UseVisualStyleBackColor = false;
            this.btn_SW_Reset.Click += new System.EventHandler(this.btn_SW_Reset_Click);
            // 
            // btn_SW_Pause
            // 
            this.btn_SW_Pause.BackColor = System.Drawing.Color.Yellow;
            this.btn_SW_Pause.FlatAppearance.BorderSize = 0;
            this.btn_SW_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SW_Pause.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SW_Pause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SW_Pause.Location = new System.Drawing.Point(210, 320);
            this.btn_SW_Pause.Name = "btn_SW_Pause";
            this.btn_SW_Pause.Size = new System.Drawing.Size(106, 54);
            this.btn_SW_Pause.TabIndex = 2;
            this.btn_SW_Pause.Text = "Pause";
            this.btn_SW_Pause.UseVisualStyleBackColor = false;
            this.btn_SW_Pause.Click += new System.EventHandler(this.btn_SW_Pause_Click);
            // 
            // lbl_Stopwatch
            // 
            this.lbl_Stopwatch.AutoSize = true;
            this.lbl_Stopwatch.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stopwatch.Location = new System.Drawing.Point(81, 124);
            this.lbl_Stopwatch.Name = "lbl_Stopwatch";
            this.lbl_Stopwatch.Size = new System.Drawing.Size(478, 104);
            this.lbl_Stopwatch.TabIndex = 0;
            this.lbl_Stopwatch.Text = "00:00:00.00";
            // 
            // pnl_Timer
            // 
            this.pnl_Timer.Controls.Add(this.pnl_TimerTop);
            this.pnl_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Timer.Location = new System.Drawing.Point(200, 0);
            this.pnl_Timer.Name = "pnl_Timer";
            this.pnl_Timer.Size = new System.Drawing.Size(683, 498);
            this.pnl_Timer.TabIndex = 3;
            // 
            // pnl_TimerTop
            // 
            this.pnl_TimerTop.Controls.Add(this.lbl_TimerSeconds);
            this.pnl_TimerTop.Controls.Add(this.lbl_TimerMinutes);
            this.pnl_TimerTop.Controls.Add(this.lbl_TimerCount);
            this.pnl_TimerTop.Controls.Add(this.cb_TimerMinute);
            this.pnl_TimerTop.Controls.Add(this.btn_TimerStart);
            this.pnl_TimerTop.Controls.Add(this.cb_TimerSecond);
            this.pnl_TimerTop.Controls.Add(this.btn_TimerPause);
            this.pnl_TimerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TimerTop.Location = new System.Drawing.Point(0, 0);
            this.pnl_TimerTop.Name = "pnl_TimerTop";
            this.pnl_TimerTop.Size = new System.Drawing.Size(683, 495);
            this.pnl_TimerTop.TabIndex = 5;
            // 
            // lbl_TimerSeconds
            // 
            this.lbl_TimerSeconds.AutoSize = true;
            this.lbl_TimerSeconds.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimerSeconds.Location = new System.Drawing.Point(338, 251);
            this.lbl_TimerSeconds.Name = "lbl_TimerSeconds";
            this.lbl_TimerSeconds.Size = new System.Drawing.Size(83, 23);
            this.lbl_TimerSeconds.TabIndex = 6;
            this.lbl_TimerSeconds.Text = "Seconds:";
            // 
            // lbl_TimerMinutes
            // 
            this.lbl_TimerMinutes.AutoSize = true;
            this.lbl_TimerMinutes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimerMinutes.Location = new System.Drawing.Point(189, 251);
            this.lbl_TimerMinutes.Name = "lbl_TimerMinutes";
            this.lbl_TimerMinutes.Size = new System.Drawing.Size(80, 23);
            this.lbl_TimerMinutes.TabIndex = 5;
            this.lbl_TimerMinutes.Text = "Minutes:";
            // 
            // lbl_TimerCount
            // 
            this.lbl_TimerCount.AutoSize = true;
            this.lbl_TimerCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimerCount.Location = new System.Drawing.Point(203, 84);
            this.lbl_TimerCount.Name = "lbl_TimerCount";
            this.lbl_TimerCount.Size = new System.Drawing.Size(252, 104);
            this.lbl_TimerCount.TabIndex = 2;
            this.lbl_TimerCount.Text = "00:00";
            // 
            // cb_TimerMinute
            // 
            this.cb_TimerMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TimerMinute.FormattingEnabled = true;
            this.cb_TimerMinute.Location = new System.Drawing.Point(193, 277);
            this.cb_TimerMinute.Name = "cb_TimerMinute";
            this.cb_TimerMinute.Size = new System.Drawing.Size(121, 24);
            this.cb_TimerMinute.TabIndex = 0;
            // 
            // btn_TimerStart
            // 
            this.btn_TimerStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_TimerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimerStart.FlatAppearance.BorderSize = 0;
            this.btn_TimerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimerStart.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimerStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimerStart.Location = new System.Drawing.Point(280, 368);
            this.btn_TimerStart.Name = "btn_TimerStart";
            this.btn_TimerStart.Size = new System.Drawing.Size(98, 57);
            this.btn_TimerStart.TabIndex = 3;
            this.btn_TimerStart.Text = "Start";
            this.btn_TimerStart.UseVisualStyleBackColor = false;
            this.btn_TimerStart.Click += new System.EventHandler(this.btn_TimerStart_Click);
            // 
            // cb_TimerSecond
            // 
            this.cb_TimerSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TimerSecond.FormattingEnabled = true;
            this.cb_TimerSecond.Location = new System.Drawing.Point(342, 277);
            this.cb_TimerSecond.Name = "cb_TimerSecond";
            this.cb_TimerSecond.Size = new System.Drawing.Size(121, 24);
            this.cb_TimerSecond.TabIndex = 1;
            // 
            // btn_TimerPause
            // 
            this.btn_TimerPause.BackColor = System.Drawing.Color.Tomato;
            this.btn_TimerPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimerPause.FlatAppearance.BorderSize = 0;
            this.btn_TimerPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimerPause.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimerPause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimerPause.Location = new System.Drawing.Point(280, 368);
            this.btn_TimerPause.Name = "btn_TimerPause";
            this.btn_TimerPause.Size = new System.Drawing.Size(98, 57);
            this.btn_TimerPause.TabIndex = 4;
            this.btn_TimerPause.Text = "Cancel";
            this.btn_TimerPause.UseVisualStyleBackColor = false;
            this.btn_TimerPause.Click += new System.EventHandler(this.btn_TimerPause_Click);
            // 
            // timer_CurrentTime
            // 
            this.timer_CurrentTime.Tick += new System.EventHandler(this.timer_CurrentTime_Tick);
            // 
            // timer_AlarmTime
            // 
            this.timer_AlarmTime.Tick += new System.EventHandler(this.timer_AlarmTime_Tick);
            // 
            // timer_Stopwatch
            // 
            this.timer_Stopwatch.Enabled = true;
            this.timer_Stopwatch.Tick += new System.EventHandler(this.timer_Stopwatch_Tick);
            // 
            // timer_Timer
            // 
            this.timer_Timer.Interval = 1000;
            this.timer_Timer.Tick += new System.EventHandler(this.timer_Timer_Tick);
            // 
            // pnl_Move
            // 
            this.pnl_Move.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Move.Controls.Add(this.panel1);
            this.pnl_Move.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Move.Location = new System.Drawing.Point(200, 0);
            this.pnl_Move.Name = "pnl_Move";
            this.pnl_Move.Size = new System.Drawing.Size(683, 25);
            this.pnl_Move.TabIndex = 14;
            this.pnl_Move.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Move_Paint);
            this.pnl_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_Maximize);
            this.panel1.Controls.Add(this.pictureBox_Minimize);
            this.panel1.Controls.Add(this.pictureBox_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(574, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 25);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox_Maximize
            // 
            this.pictureBox_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Maximize.Image = global::AlarmApplication.Properties.Resources.circle_16;
            this.pictureBox_Maximize.Location = new System.Drawing.Point(82, 3);
            this.pictureBox_Maximize.Name = "pictureBox_Maximize";
            this.pictureBox_Maximize.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Maximize.TabIndex = 2;
            this.pictureBox_Maximize.TabStop = false;
            this.pictureBox_Maximize.Click += new System.EventHandler(this.pictureBox_Maximize_Click);
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Minimize.Image = global::AlarmApplication.Properties.Resources.circle_16_2_;
            this.pictureBox_Minimize.Location = new System.Drawing.Point(56, 3);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Minimize.TabIndex = 3;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.pictureBox_Minimize_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Close.Image = global::AlarmApplication.Properties.Resources.circle_16_1_;
            this.pictureBox_Close.Location = new System.Drawing.Point(30, 3);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Close.TabIndex = 0;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 498);
            this.Controls.Add(this.pnl_Move);
            this.Controls.Add(this.pnl_alarm);
            this.Controls.Add(this.pnl_Stopwatch);
            this.Controls.Add(this.pnl_Timer);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.pnl_alarm.ResumeLayout(false);
            this.pnl_alarm.PerformLayout();
            this.pnl_AlarmBottom.ResumeLayout(false);
            this.pnl_AlarmBottom.PerformLayout();
            this.pnl_AlarmTop.ResumeLayout(false);
            this.pnl_AlarmTop.PerformLayout();
            this.pnl_Stopwatch.ResumeLayout(false);
            this.pnl_Stopwatch.PerformLayout();
            this.pnl_Timer.ResumeLayout(false);
            this.pnl_TimerTop.ResumeLayout(false);
            this.pnl_TimerTop.PerformLayout();
            this.pnl_Move.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnStopwatch;
        private System.Windows.Forms.Panel pnl_OnButton;
        private System.Windows.Forms.Panel pnl_alarm;
        private System.Windows.Forms.Panel pnl_Stopwatch;
        private System.Windows.Forms.Panel pnl_Timer;
        private System.Windows.Forms.Label lbl_CurrentTime;
        private System.Windows.Forms.Timer timer_CurrentTime;
        private System.Windows.Forms.Button btn_SetAlarm;
        private System.Windows.Forms.ComboBox cb_Second;
        private System.Windows.Forms.ComboBox cb_Minute;
        private System.Windows.Forms.ComboBox cb_Hour;
        private System.Windows.Forms.Timer timer_AlarmTime;
        private System.Windows.Forms.Label lbl_AlarmTime;
        private System.Windows.Forms.Button btn_StopAlarm;
        private System.Windows.Forms.Panel pnl_AlarmBottom;
        private System.Windows.Forms.Panel pnl_AlarmTop;
        private System.Windows.Forms.Button btn_SW_Reset;
        private System.Windows.Forms.Button btn_SW_Pause;
        private System.Windows.Forms.Button btn_SW_Start;
        private System.Windows.Forms.Label lbl_Stopwatch;
        private System.Windows.Forms.Timer timer_Stopwatch;
        private System.Windows.Forms.ComboBox cb_TimerSecond;
        private System.Windows.Forms.ComboBox cb_TimerMinute;
        private System.Windows.Forms.Button btn_TimerPause;
        private System.Windows.Forms.Button btn_TimerStart;
        private System.Windows.Forms.Label lbl_TimerCount;
        private System.Windows.Forms.Timer timer_Timer;
        private System.Windows.Forms.Panel pnl_TimerTop;
        private System.Windows.Forms.Label lbl_AlarmMinutes;
        private System.Windows.Forms.Label lbl_TimerSeconds;
        private System.Windows.Forms.Label lbl_TimerMinutes;
        private System.Windows.Forms.Label lbl_AlarmHour;
        private System.Windows.Forms.Label lbl_AlarmSeconds;
        private System.Windows.Forms.Panel pnl_Move;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_Maximize;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
    }
}

