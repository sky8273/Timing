namespace TimingSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Event = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ManageEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ManageDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ManageSharedTimers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ManageDecoders = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Left = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Warmup = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_End = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_result = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Report = new System.Windows.Forms.ToolStripButton();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Dir = new System.Windows.Forms.TabPage();
            this.tabPage_Data = new System.Windows.Forms.TabPage();
            this.tabPage_running = new System.Windows.Forms.TabPage();
            this.label_RaceName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1_DriverTable = new System.Windows.Forms.DataGridView();
            this.dataGridView3_running = new System.Windows.Forms.DataGridView();
            this.tabControl_RaceData = new System.Windows.Forms.TabControl();
            this.tabPage_TotalResult = new System.Windows.Forms.TabPage();
            this.tabPage_SingleResult = new System.Windows.Forms.TabPage();
            this.tabPage_RawResult = new System.Windows.Forms.TabPage();
            this.dataGridView2_TatalResult = new System.Windows.Forms.DataGridView();
            this.dataGridView2_SingleResult = new System.Windows.Forms.DataGridView();
            this.dataGridView2_RawResult = new System.Windows.Forms.DataGridView();
            this.MenuStrip_Main.SuspendLayout();
            this.toolStrip_Left.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Dir.SuspendLayout();
            this.tabPage_Data.SuspendLayout();
            this.tabPage_running.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_DriverTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_running)).BeginInit();
            this.tabControl_RaceData.SuspendLayout();
            this.tabPage_TotalResult.SuspendLayout();
            this.tabPage_SingleResult.SuspendLayout();
            this.tabPage_RawResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_TatalResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_SingleResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_RawResult)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Event,
            this.toolStripMenuItem_help});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(1064, 28);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Event
            // 
            this.toolStripMenuItem_Event.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ManageEvents,
            this.toolStripMenuItem_ManageDrivers,
            this.toolStripMenuItem_ManageSharedTimers,
            this.toolStripMenuItem_ManageDecoders});
            this.toolStripMenuItem_Event.Name = "toolStripMenuItem_Event";
            this.toolStripMenuItem_Event.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem_Event.Text = "赛事";
            // 
            // toolStripMenuItem_ManageEvents
            // 
            this.toolStripMenuItem_ManageEvents.Name = "toolStripMenuItem_ManageEvents";
            this.toolStripMenuItem_ManageEvents.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem_ManageEvents.Text = "管理总赛事";
            this.toolStripMenuItem_ManageEvents.Click += new System.EventHandler(this.toolStripMenuItem_ManageEvents_Click);
            // 
            // toolStripMenuItem_ManageDrivers
            // 
            this.toolStripMenuItem_ManageDrivers.Name = "toolStripMenuItem_ManageDrivers";
            this.toolStripMenuItem_ManageDrivers.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem_ManageDrivers.Text = "管理车手库";
            // 
            // toolStripMenuItem_ManageSharedTimers
            // 
            this.toolStripMenuItem_ManageSharedTimers.Name = "toolStripMenuItem_ManageSharedTimers";
            this.toolStripMenuItem_ManageSharedTimers.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem_ManageSharedTimers.Text = "管理公共计时器";
            // 
            // toolStripMenuItem_ManageDecoders
            // 
            this.toolStripMenuItem_ManageDecoders.Name = "toolStripMenuItem_ManageDecoders";
            this.toolStripMenuItem_ManageDecoders.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem_ManageDecoders.Text = "管理解码器编号";
            // 
            // toolStripMenuItem_help
            // 
            this.toolStripMenuItem_help.Name = "toolStripMenuItem_help";
            this.toolStripMenuItem_help.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem_help.Text = "帮助";
            // 
            // toolStrip_Left
            // 
            this.toolStrip_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip_Left.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip_Left.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_Left.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip_Left.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Warmup,
            this.toolStripButton_Start,
            this.toolStripButton_End,
            this.toolStripButton_Stop,
            this.toolStripButton_result,
            this.toolStripButton_Report});
            this.toolStrip_Left.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip_Left.Location = new System.Drawing.Point(0, 28);
            this.toolStrip_Left.Name = "toolStrip_Left";
            this.toolStrip_Left.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip_Left.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_Left.Size = new System.Drawing.Size(76, 517);
            this.toolStrip_Left.TabIndex = 1;
            this.toolStrip_Left.Text = "toolStrip1";
            // 
            // toolStripButton_Warmup
            // 
            this.toolStripButton_Warmup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Warmup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Warmup.Image")));
            this.toolStripButton_Warmup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Warmup.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_Warmup.Name = "toolStripButton_Warmup";
            this.toolStripButton_Warmup.Size = new System.Drawing.Size(67, 68);
            this.toolStripButton_Warmup.Text = "开始热身";
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Start.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Start.Image")));
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(67, 68);
            this.toolStripButton_Start.Text = "toolStripButton2";
            this.toolStripButton_Start.ToolTipText = "开始比赛";
            // 
            // toolStripButton_End
            // 
            this.toolStripButton_End.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_End.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_End.Image")));
            this.toolStripButton_End.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_End.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_End.Name = "toolStripButton_End";
            this.toolStripButton_End.Size = new System.Drawing.Size(67, 68);
            this.toolStripButton_End.Text = "结束比赛";
            // 
            // toolStripButton_Stop
            // 
            this.toolStripButton_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Stop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Stop.Image")));
            this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_Stop.Name = "toolStripButton_Stop";
            this.toolStripButton_Stop.Size = new System.Drawing.Size(67, 68);
            this.toolStripButton_Stop.Text = "toolStripButton4";
            this.toolStripButton_Stop.ToolTipText = "停止比赛";
            // 
            // toolStripButton_result
            // 
            this.toolStripButton_result.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_result.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_result.Image")));
            this.toolStripButton_result.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_result.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_result.Name = "toolStripButton_result";
            this.toolStripButton_result.Size = new System.Drawing.Size(67, 68);
            this.toolStripButton_result.Text = "toolStripButton5";
            this.toolStripButton_result.ToolTipText = "比赛数据";
            // 
            // toolStripButton_Report
            // 
            this.toolStripButton_Report.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Report.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Report.Image")));
            this.toolStripButton_Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Report.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_Report.Name = "toolStripButton_Report";
            this.toolStripButton_Report.Size = new System.Drawing.Size(67, 68);
            this.toolStripButton_Report.Text = "toolStripButton6";
            this.toolStripButton_Report.ToolTipText = "比赛结果";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Dir);
            this.tabControl_Main.Controls.Add(this.tabPage_Data);
            this.tabControl_Main.Controls.Add(this.tabPage_running);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tabControl_Main.ItemSize = new System.Drawing.Size(92, 36);
            this.tabControl_Main.Location = new System.Drawing.Point(76, 28);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(988, 517);
            this.tabControl_Main.TabIndex = 2;
            // 
            // tabPage_Dir
            // 
            this.tabPage_Dir.Controls.Add(this.dataGridView1_DriverTable);
            this.tabPage_Dir.Controls.Add(this.panel1);
            this.tabPage_Dir.Controls.Add(this.treeView1);
            this.tabPage_Dir.Controls.Add(this.comboBox1);
            this.tabPage_Dir.Controls.Add(this.label1);
            this.tabPage_Dir.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Dir.Name = "tabPage_Dir";
            this.tabPage_Dir.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dir.Size = new System.Drawing.Size(980, 473);
            this.tabPage_Dir.TabIndex = 0;
            this.tabPage_Dir.Text = "比赛目录";
            this.tabPage_Dir.UseVisualStyleBackColor = true;
            // 
            // tabPage_Data
            // 
            this.tabPage_Data.Controls.Add(this.tabControl_RaceData);
            this.tabPage_Data.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Data.Name = "tabPage_Data";
            this.tabPage_Data.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage_Data.Size = new System.Drawing.Size(980, 473);
            this.tabPage_Data.TabIndex = 1;
            this.tabPage_Data.Text = "比赛数据";
            this.tabPage_Data.UseVisualStyleBackColor = true;
            // 
            // tabPage_running
            // 
            this.tabPage_running.Controls.Add(this.dataGridView3_running);
            this.tabPage_running.Location = new System.Drawing.Point(4, 40);
            this.tabPage_running.Name = "tabPage_running";
            this.tabPage_running.Size = new System.Drawing.Size(980, 473);
            this.tabPage_running.TabIndex = 2;
            this.tabPage_running.Text = "比赛进程";
            this.tabPage_running.UseVisualStyleBackColor = true;
            // 
            // label_RaceName
            // 
            this.label_RaceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RaceName.AutoSize = true;
            this.label_RaceName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_RaceName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_RaceName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label_RaceName.Location = new System.Drawing.Point(1011, 5);
            this.label_RaceName.Name = "label_RaceName";
            this.label_RaceName.Size = new System.Drawing.Size(53, 20);
            this.label_RaceName.TabIndex = 3;
            this.label_RaceName.Text = "label1";
            this.label_RaceName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前赛事";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 31);
            this.comboBox1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(0, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(221, 438);
            this.treeView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(227, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 167);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1_DriverTable
            // 
            this.dataGridView1_DriverTable.AllowUserToAddRows = false;
            this.dataGridView1_DriverTable.AllowUserToDeleteRows = false;
            this.dataGridView1_DriverTable.AllowUserToResizeRows = false;
            this.dataGridView1_DriverTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_DriverTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_DriverTable.Location = new System.Drawing.Point(227, 180);
            this.dataGridView1_DriverTable.Name = "dataGridView1_DriverTable";
            this.dataGridView1_DriverTable.ReadOnly = true;
            this.dataGridView1_DriverTable.RowTemplate.Height = 24;
            this.dataGridView1_DriverTable.Size = new System.Drawing.Size(750, 297);
            this.dataGridView1_DriverTable.TabIndex = 4;
            // 
            // dataGridView3_running
            // 
            this.dataGridView3_running.AllowUserToAddRows = false;
            this.dataGridView3_running.AllowUserToDeleteRows = false;
            this.dataGridView3_running.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3_running.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3_running.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3_running.Name = "dataGridView3_running";
            this.dataGridView3_running.ReadOnly = true;
            this.dataGridView3_running.RowTemplate.Height = 24;
            this.dataGridView3_running.Size = new System.Drawing.Size(980, 473);
            this.dataGridView3_running.TabIndex = 0;
            // 
            // tabControl_RaceData
            // 
            this.tabControl_RaceData.Controls.Add(this.tabPage_TotalResult);
            this.tabControl_RaceData.Controls.Add(this.tabPage_SingleResult);
            this.tabControl_RaceData.Controls.Add(this.tabPage_RawResult);
            this.tabControl_RaceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_RaceData.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tabControl_RaceData.Location = new System.Drawing.Point(6, 6);
            this.tabControl_RaceData.Name = "tabControl_RaceData";
            this.tabControl_RaceData.SelectedIndex = 0;
            this.tabControl_RaceData.Size = new System.Drawing.Size(968, 461);
            this.tabControl_RaceData.TabIndex = 0;
            // 
            // tabPage_TotalResult
            // 
            this.tabPage_TotalResult.Controls.Add(this.dataGridView2_TatalResult);
            this.tabPage_TotalResult.Location = new System.Drawing.Point(4, 32);
            this.tabPage_TotalResult.Name = "tabPage_TotalResult";
            this.tabPage_TotalResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TotalResult.Size = new System.Drawing.Size(960, 425);
            this.tabPage_TotalResult.TabIndex = 0;
            this.tabPage_TotalResult.Text = "比赛结果";
            this.tabPage_TotalResult.UseVisualStyleBackColor = true;
            // 
            // tabPage_SingleResult
            // 
            this.tabPage_SingleResult.Controls.Add(this.dataGridView2_SingleResult);
            this.tabPage_SingleResult.Location = new System.Drawing.Point(4, 32);
            this.tabPage_SingleResult.Name = "tabPage_SingleResult";
            this.tabPage_SingleResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SingleResult.Size = new System.Drawing.Size(960, 425);
            this.tabPage_SingleResult.TabIndex = 1;
            this.tabPage_SingleResult.Text = "单圈成绩";
            this.tabPage_SingleResult.UseVisualStyleBackColor = true;
            // 
            // tabPage_RawResult
            // 
            this.tabPage_RawResult.Controls.Add(this.dataGridView2_RawResult);
            this.tabPage_RawResult.Location = new System.Drawing.Point(4, 32);
            this.tabPage_RawResult.Name = "tabPage_RawResult";
            this.tabPage_RawResult.Size = new System.Drawing.Size(960, 425);
            this.tabPage_RawResult.TabIndex = 2;
            this.tabPage_RawResult.Text = "原始成绩";
            this.tabPage_RawResult.UseVisualStyleBackColor = true;
            // 
            // dataGridView2_TatalResult
            // 
            this.dataGridView2_TatalResult.AllowUserToAddRows = false;
            this.dataGridView2_TatalResult.AllowUserToDeleteRows = false;
            this.dataGridView2_TatalResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_TatalResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2_TatalResult.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2_TatalResult.Name = "dataGridView2_TatalResult";
            this.dataGridView2_TatalResult.ReadOnly = true;
            this.dataGridView2_TatalResult.RowTemplate.Height = 24;
            this.dataGridView2_TatalResult.Size = new System.Drawing.Size(954, 419);
            this.dataGridView2_TatalResult.TabIndex = 0;
            // 
            // dataGridView2_SingleResult
            // 
            this.dataGridView2_SingleResult.AllowUserToAddRows = false;
            this.dataGridView2_SingleResult.AllowUserToDeleteRows = false;
            this.dataGridView2_SingleResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_SingleResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2_SingleResult.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2_SingleResult.Name = "dataGridView2_SingleResult";
            this.dataGridView2_SingleResult.ReadOnly = true;
            this.dataGridView2_SingleResult.RowTemplate.Height = 24;
            this.dataGridView2_SingleResult.Size = new System.Drawing.Size(954, 419);
            this.dataGridView2_SingleResult.TabIndex = 0;
            // 
            // dataGridView2_RawResult
            // 
            this.dataGridView2_RawResult.AllowUserToAddRows = false;
            this.dataGridView2_RawResult.AllowUserToDeleteRows = false;
            this.dataGridView2_RawResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_RawResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2_RawResult.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2_RawResult.Name = "dataGridView2_RawResult";
            this.dataGridView2_RawResult.ReadOnly = true;
            this.dataGridView2_RawResult.RowTemplate.Height = 24;
            this.dataGridView2_RawResult.Size = new System.Drawing.Size(960, 425);
            this.dataGridView2_RawResult.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 545);
            this.Controls.Add(this.label_RaceName);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.toolStrip_Left);
            this.Controls.Add(this.MenuStrip_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(680, 420);
            this.Name = "MainForm";
            this.Text = "计时系统";
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.toolStrip_Left.ResumeLayout(false);
            this.toolStrip_Left.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Dir.ResumeLayout(false);
            this.tabPage_Dir.PerformLayout();
            this.tabPage_Data.ResumeLayout(false);
            this.tabPage_running.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_DriverTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_running)).EndInit();
            this.tabControl_RaceData.ResumeLayout(false);
            this.tabPage_TotalResult.ResumeLayout(false);
            this.tabPage_SingleResult.ResumeLayout(false);
            this.tabPage_RawResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_TatalResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_SingleResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_RawResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Event;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_help;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ManageEvents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ManageDrivers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ManageSharedTimers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ManageDecoders;
        private System.Windows.Forms.ToolStrip toolStrip_Left;
        private System.Windows.Forms.ToolStripButton toolStripButton_Warmup;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripButton toolStripButton_End;
        private System.Windows.Forms.ToolStripButton toolStripButton_Stop;
        private System.Windows.Forms.ToolStripButton toolStripButton_result;
        private System.Windows.Forms.ToolStripButton toolStripButton_Report;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Dir;
        private System.Windows.Forms.TabPage tabPage_Data;
        private System.Windows.Forms.TabPage tabPage_running;
        private System.Windows.Forms.Label label_RaceName;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1_DriverTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl_RaceData;
        private System.Windows.Forms.TabPage tabPage_TotalResult;
        private System.Windows.Forms.DataGridView dataGridView2_TatalResult;
        private System.Windows.Forms.TabPage tabPage_SingleResult;
        private System.Windows.Forms.DataGridView dataGridView2_SingleResult;
        private System.Windows.Forms.TabPage tabPage_RawResult;
        private System.Windows.Forms.DataGridView dataGridView2_RawResult;
        private System.Windows.Forms.DataGridView dataGridView3_running;
    }
}

