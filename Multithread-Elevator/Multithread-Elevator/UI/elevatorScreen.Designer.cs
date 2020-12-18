namespace MultithreadElevator.UI
{
    partial class elevatorScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.controlThreadCount = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.avmLoginCount = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.avmExitCount = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.totalPersonAllQueue = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.totalPersonExit = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.floor_0_queue = new System.Windows.Forms.Label();
            this.floor_1_queue = new System.Windows.Forms.Label();
            this.floor_2_queue = new System.Windows.Forms.Label();
            this.floor_3_queue = new System.Windows.Forms.Label();
            this.floor_4_queue = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.floor_1_totalPerson = new System.Windows.Forms.Label();
            this.floor_2_totalPerson = new System.Windows.Forms.Label();
            this.floor_3_totalPerson = new System.Windows.Forms.Label();
            this.floor_4_totalPerson = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.speedValue = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.threadSpeedRate = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elev_1_totalInside = new System.Windows.Forms.Label();
            this.elev_1_cap = new System.Windows.Forms.Label();
            this.elev_1_direc = new System.Windows.Forms.Label();
            this.elev_1_dest = new System.Windows.Forms.Label();
            this.elev_1_floor = new System.Windows.Forms.Label();
            this.elev_1_mode = new System.Windows.Forms.Label();
            this.elev_1_status = new System.Windows.Forms.Label();
            this.elev_1_insideList = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.elev_3_totalInside = new System.Windows.Forms.Label();
            this.elev_3_cap = new System.Windows.Forms.Label();
            this.elev_3_direc = new System.Windows.Forms.Label();
            this.elev_3_dest = new System.Windows.Forms.Label();
            this.elev_3_floor = new System.Windows.Forms.Label();
            this.elev_3_mode = new System.Windows.Forms.Label();
            this.elev_3_status = new System.Windows.Forms.Label();
            this.elev_3_insideList = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.elev_5_totalInside = new System.Windows.Forms.Label();
            this.elev_5_cap = new System.Windows.Forms.Label();
            this.elev_5_direc = new System.Windows.Forms.Label();
            this.elev_5_dest = new System.Windows.Forms.Label();
            this.elev_5_floor = new System.Windows.Forms.Label();
            this.elev_5_mode = new System.Windows.Forms.Label();
            this.elev_5_status = new System.Windows.Forms.Label();
            this.elev_5_insideList = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.elev_2_totalInside = new System.Windows.Forms.Label();
            this.elev_2_cap = new System.Windows.Forms.Label();
            this.elev_2_direc = new System.Windows.Forms.Label();
            this.elev_2_dest = new System.Windows.Forms.Label();
            this.elev_2_floor = new System.Windows.Forms.Label();
            this.elev_2_mode = new System.Windows.Forms.Label();
            this.elev_2_status = new System.Windows.Forms.Label();
            this.elev_2_insideList = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.elev_4_totalInside = new System.Windows.Forms.Label();
            this.elev_4_cap = new System.Windows.Forms.Label();
            this.elev_4_direc = new System.Windows.Forms.Label();
            this.elev_4_dest = new System.Windows.Forms.Label();
            this.elev_4_floor = new System.Windows.Forms.Label();
            this.elev_4_mode = new System.Windows.Forms.Label();
            this.elev_4_status = new System.Windows.Forms.Label();
            this.elev_4_insideList = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label50 = new System.Windows.Forms.Label();
            this.floorLog4 = new System.Windows.Forms.ListBox();
            this.label49 = new System.Windows.Forms.Label();
            this.floorLog3 = new System.Windows.Forms.ListBox();
            this.label48 = new System.Windows.Forms.Label();
            this.floorLog2 = new System.Windows.Forms.ListBox();
            this.label46 = new System.Windows.Forms.Label();
            this.floorLog1 = new System.Windows.Forms.ListBox();
            this.label36 = new System.Windows.Forms.Label();
            this.floorLog0 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadSpeedRate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1125, 605);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.speedValue);
            this.tabPage1.Controls.Add(this.start);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.stop);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.threadSpeedRate);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1117, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simulation";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.controlThreadCount);
            this.groupBox6.Controls.Add(this.label47);
            this.groupBox6.Controls.Add(this.avmLoginCount);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.avmExitCount);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.totalPersonAllQueue);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.totalPersonExit);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.floor_0_queue);
            this.groupBox6.Controls.Add(this.floor_1_queue);
            this.groupBox6.Controls.Add(this.floor_2_queue);
            this.groupBox6.Controls.Add(this.floor_3_queue);
            this.groupBox6.Controls.Add(this.floor_4_queue);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.floor_1_totalPerson);
            this.groupBox6.Controls.Add(this.floor_2_totalPerson);
            this.groupBox6.Controls.Add(this.floor_3_totalPerson);
            this.groupBox6.Controls.Add(this.floor_4_totalPerson);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(9, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(874, 155);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Floor";
            // 
            // controlThreadCount
            // 
            this.controlThreadCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.controlThreadCount.Location = new System.Drawing.Point(643, 122);
            this.controlThreadCount.Name = "controlThreadCount";
            this.controlThreadCount.Size = new System.Drawing.Size(56, 23);
            this.controlThreadCount.TabIndex = 57;
            this.controlThreadCount.Text = "0";
            this.controlThreadCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label47.Location = new System.Drawing.Point(402, 122);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(214, 23);
            this.label47.TabIndex = 56;
            this.label47.Text = "ControlThread tick count :";
            // 
            // avmLoginCount
            // 
            this.avmLoginCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.avmLoginCount.Location = new System.Drawing.Point(643, 98);
            this.avmLoginCount.Name = "avmLoginCount";
            this.avmLoginCount.Size = new System.Drawing.Size(56, 23);
            this.avmLoginCount.TabIndex = 55;
            this.avmLoginCount.Text = "0";
            this.avmLoginCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(402, 98);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(243, 23);
            this.label37.TabIndex = 54;
            this.label37.Text = "Avm Login thread tick count : ";
            // 
            // avmExitCount
            // 
            this.avmExitCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.avmExitCount.Location = new System.Drawing.Point(643, 74);
            this.avmExitCount.Name = "avmExitCount";
            this.avmExitCount.Size = new System.Drawing.Size(56, 23);
            this.avmExitCount.TabIndex = 53;
            this.avmExitCount.Text = "0";
            this.avmExitCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(402, 74);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(227, 23);
            this.label35.TabIndex = 52;
            this.label35.Text = "Avm Exit thread tick count: ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(226, 98);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 23);
            this.label33.TabIndex = 51;
            this.label33.Text = "Total Person :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(226, 74);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(116, 23);
            this.label32.TabIndex = 50;
            this.label32.Text = "Total Person :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(226, 50);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(116, 23);
            this.label31.TabIndex = 49;
            this.label31.Text = "Total Person :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(226, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 23);
            this.label22.TabIndex = 48;
            this.label22.Text = "Total Person :";
            // 
            // totalPersonAllQueue
            // 
            this.totalPersonAllQueue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPersonAllQueue.Location = new System.Drawing.Point(639, 50);
            this.totalPersonAllQueue.Name = "totalPersonAllQueue";
            this.totalPersonAllQueue.Size = new System.Drawing.Size(60, 23);
            this.totalPersonAllQueue.TabIndex = 47;
            this.totalPersonAllQueue.Text = "0";
            this.totalPersonAllQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(402, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(212, 23);
            this.label20.TabIndex = 46;
            this.label20.Text = "Total Person in all queue :";
            // 
            // totalPersonExit
            // 
            this.totalPersonExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPersonExit.Location = new System.Drawing.Point(639, 26);
            this.totalPersonExit.Name = "totalPersonExit";
            this.totalPersonExit.Size = new System.Drawing.Size(60, 23);
            this.totalPersonExit.TabIndex = 45;
            this.totalPersonExit.Text = "0";
            this.totalPersonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(402, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 23);
            this.label19.TabIndex = 44;
            this.label19.Text = "Total Person of Exit :";
            // 
            // floor_0_queue
            // 
            this.floor_0_queue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor_0_queue.Location = new System.Drawing.Point(168, 122);
            this.floor_0_queue.Name = "floor_0_queue";
            this.floor_0_queue.Size = new System.Drawing.Size(50, 23);
            this.floor_0_queue.TabIndex = 43;
            this.floor_0_queue.Text = "0";
            this.floor_0_queue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // floor_1_queue
            // 
            this.floor_1_queue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor_1_queue.Location = new System.Drawing.Point(168, 98);
            this.floor_1_queue.Name = "floor_1_queue";
            this.floor_1_queue.Size = new System.Drawing.Size(50, 23);
            this.floor_1_queue.TabIndex = 42;
            this.floor_1_queue.Text = "0";
            this.floor_1_queue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // floor_2_queue
            // 
            this.floor_2_queue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor_2_queue.Location = new System.Drawing.Point(168, 74);
            this.floor_2_queue.Name = "floor_2_queue";
            this.floor_2_queue.Size = new System.Drawing.Size(50, 23);
            this.floor_2_queue.TabIndex = 41;
            this.floor_2_queue.Text = "0";
            this.floor_2_queue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // floor_3_queue
            // 
            this.floor_3_queue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor_3_queue.Location = new System.Drawing.Point(168, 50);
            this.floor_3_queue.Name = "floor_3_queue";
            this.floor_3_queue.Size = new System.Drawing.Size(50, 23);
            this.floor_3_queue.TabIndex = 40;
            this.floor_3_queue.Text = "0";
            this.floor_3_queue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // floor_4_queue
            // 
            this.floor_4_queue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor_4_queue.Location = new System.Drawing.Point(168, 26);
            this.floor_4_queue.Name = "floor_4_queue";
            this.floor_4_queue.Size = new System.Drawing.Size(50, 23);
            this.floor_4_queue.TabIndex = 39;
            this.floor_4_queue.Text = "0";
            this.floor_4_queue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(96, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 23);
            this.label18.TabIndex = 38;
            this.label18.Text = "Queue :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(96, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 23);
            this.label17.TabIndex = 37;
            this.label17.Text = "Queue :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(96, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 23);
            this.label16.TabIndex = 36;
            this.label16.Text = "Queue :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(96, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Queue :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(96, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Queue :";
            // 
            // floor_1_totalPerson
            // 
            this.floor_1_totalPerson.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor_1_totalPerson.Location = new System.Drawing.Point(342, 98);
            this.floor_1_totalPerson.Name = "floor_1_totalPerson";
            this.floor_1_totalPerson.Size = new System.Drawing.Size(50, 23);
            this.floor_1_totalPerson.TabIndex = 32;
            this.floor_1_totalPerson.Text = "0";
            this.floor_1_totalPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // floor_2_totalPerson
            // 
            this.floor_2_totalPerson.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor_2_totalPerson.Location = new System.Drawing.Point(342, 74);
            this.floor_2_totalPerson.Name = "floor_2_totalPerson";
            this.floor_2_totalPerson.Size = new System.Drawing.Size(50, 23);
            this.floor_2_totalPerson.TabIndex = 31;
            this.floor_2_totalPerson.Text = "0";
            this.floor_2_totalPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // floor_3_totalPerson
            // 
            this.floor_3_totalPerson.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor_3_totalPerson.Location = new System.Drawing.Point(342, 50);
            this.floor_3_totalPerson.Name = "floor_3_totalPerson";
            this.floor_3_totalPerson.Size = new System.Drawing.Size(50, 23);
            this.floor_3_totalPerson.TabIndex = 30;
            this.floor_3_totalPerson.Text = "0";
            this.floor_3_totalPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // floor_4_totalPerson
            // 
            this.floor_4_totalPerson.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floor_4_totalPerson.Location = new System.Drawing.Point(342, 26);
            this.floor_4_totalPerson.Name = "floor_4_totalPerson";
            this.floor_4_totalPerson.Size = new System.Drawing.Size(50, 23);
            this.floor_4_totalPerson.TabIndex = 29;
            this.floor_4_totalPerson.Text = "0";
            this.floor_4_totalPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Floor 0 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Floor 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Floor 2 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Floor 3 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Floor 4 :";
            // 
            // speedValue
            // 
            this.speedValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedValue.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.speedValue.ForeColor = System.Drawing.SystemColors.Control;
            this.speedValue.Location = new System.Drawing.Point(967, 115);
            this.speedValue.Margin = new System.Windows.Forms.Padding(0);
            this.speedValue.Name = "speedValue";
            this.speedValue.Size = new System.Drawing.Size(64, 19);
            this.speedValue.TabIndex = 46;
            this.speedValue.Text = "0";
            this.speedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start.ForeColor = System.Drawing.SystemColors.Control;
            this.start.Location = new System.Drawing.Point(891, 17);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(101, 49);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.ForeColor = System.Drawing.SystemColors.Control;
            this.label34.Location = new System.Drawing.Point(1032, 115);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(84, 18);
            this.label34.TabIndex = 45;
            this.label34.Text = "Hızlandır >>";
            // 
            // stop
            // 
            this.stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop.ForeColor = System.Drawing.SystemColors.Control;
            this.stop.Location = new System.Drawing.Point(1004, 17);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(101, 49);
            this.stop.TabIndex = 16;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(887, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 18);
            this.label21.TabIndex = 44;
            this.label21.Text = "<< Yavaşlat\r\n";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(9, 444);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1096, 125);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Floor 4:\nFloor 3:\nFloor 2:\nFloor 1:\nFloor 0:";
            // 
            // threadSpeedRate
            // 
            this.threadSpeedRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.threadSpeedRate.LargeChange = 1;
            this.threadSpeedRate.Location = new System.Drawing.Point(891, 88);
            this.threadSpeedRate.Minimum = -10;
            this.threadSpeedRate.Name = "threadSpeedRate";
            this.threadSpeedRate.Size = new System.Drawing.Size(214, 45);
            this.threadSpeedRate.TabIndex = 43;
            this.threadSpeedRate.ValueChanged += new System.EventHandler(this.threadSpeedRate_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elev_1_totalInside);
            this.groupBox1.Controls.Add(this.elev_1_cap);
            this.groupBox1.Controls.Add(this.elev_1_direc);
            this.groupBox1.Controls.Add(this.elev_1_dest);
            this.groupBox1.Controls.Add(this.elev_1_floor);
            this.groupBox1.Controls.Add(this.elev_1_mode);
            this.groupBox1.Controls.Add(this.elev_1_status);
            this.groupBox1.Controls.Add(this.elev_1_insideList);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 264);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elevator 1";
            // 
            // elev_1_totalInside
            // 
            this.elev_1_totalInside.AutoSize = true;
            this.elev_1_totalInside.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_1_totalInside.Location = new System.Drawing.Point(134, 173);
            this.elev_1_totalInside.Name = "elev_1_totalInside";
            this.elev_1_totalInside.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_1_totalInside.Size = new System.Drawing.Size(19, 21);
            this.elev_1_totalInside.TabIndex = 36;
            this.elev_1_totalInside.Text = "0";
            this.elev_1_totalInside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_1_cap
            // 
            this.elev_1_cap.AutoSize = true;
            this.elev_1_cap.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_1_cap.Location = new System.Drawing.Point(134, 149);
            this.elev_1_cap.Name = "elev_1_cap";
            this.elev_1_cap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_1_cap.Size = new System.Drawing.Size(28, 21);
            this.elev_1_cap.TabIndex = 35;
            this.elev_1_cap.Text = "10";
            this.elev_1_cap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_1_direc
            // 
            this.elev_1_direc.AutoSize = true;
            this.elev_1_direc.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_1_direc.Location = new System.Drawing.Point(134, 125);
            this.elev_1_direc.Name = "elev_1_direc";
            this.elev_1_direc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_1_direc.Size = new System.Drawing.Size(30, 21);
            this.elev_1_direc.TabIndex = 34;
            this.elev_1_direc.Text = "Up";
            this.elev_1_direc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_1_dest
            // 
            this.elev_1_dest.AutoSize = true;
            this.elev_1_dest.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_1_dest.Location = new System.Drawing.Point(134, 101);
            this.elev_1_dest.Name = "elev_1_dest";
            this.elev_1_dest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_1_dest.Size = new System.Drawing.Size(19, 21);
            this.elev_1_dest.TabIndex = 33;
            this.elev_1_dest.Text = "0";
            this.elev_1_dest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_1_floor
            // 
            this.elev_1_floor.AutoSize = true;
            this.elev_1_floor.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_1_floor.Location = new System.Drawing.Point(134, 77);
            this.elev_1_floor.Name = "elev_1_floor";
            this.elev_1_floor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_1_floor.Size = new System.Drawing.Size(19, 21);
            this.elev_1_floor.TabIndex = 32;
            this.elev_1_floor.Text = "0";
            this.elev_1_floor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_1_mode
            // 
            this.elev_1_mode.AutoSize = true;
            this.elev_1_mode.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_1_mode.ForeColor = System.Drawing.Color.DarkGray;
            this.elev_1_mode.Location = new System.Drawing.Point(134, 53);
            this.elev_1_mode.Name = "elev_1_mode";
            this.elev_1_mode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_1_mode.Size = new System.Drawing.Size(37, 21);
            this.elev_1_mode.TabIndex = 31;
            this.elev_1_mode.Text = "Idle";
            this.elev_1_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_1_status
            // 
            this.elev_1_status.AutoSize = true;
            this.elev_1_status.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_1_status.ForeColor = System.Drawing.Color.IndianRed;
            this.elev_1_status.Location = new System.Drawing.Point(134, 30);
            this.elev_1_status.Name = "elev_1_status";
            this.elev_1_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_1_status.Size = new System.Drawing.Size(72, 21);
            this.elev_1_status.TabIndex = 30;
            this.elev_1_status.Text = "Deactive";
            this.elev_1_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_1_insideList
            // 
            this.elev_1_insideList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.elev_1_insideList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_1_insideList.ForeColor = System.Drawing.SystemColors.Control;
            this.elev_1_insideList.Location = new System.Drawing.Point(21, 222);
            this.elev_1_insideList.Name = "elev_1_insideList";
            this.elev_1_insideList.Size = new System.Drawing.Size(185, 26);
            this.elev_1_insideList.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Inside  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Total inside  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(18, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Capacity  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(18, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Direction  :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(18, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Floor :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(18, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "Destination :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(18, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Status :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(18, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Mode :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.elev_3_totalInside);
            this.groupBox4.Controls.Add(this.elev_3_cap);
            this.groupBox4.Controls.Add(this.elev_3_direc);
            this.groupBox4.Controls.Add(this.elev_3_dest);
            this.groupBox4.Controls.Add(this.elev_3_floor);
            this.groupBox4.Controls.Add(this.elev_3_mode);
            this.groupBox4.Controls.Add(this.elev_3_status);
            this.groupBox4.Controls.Add(this.elev_3_insideList);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.label57);
            this.groupBox4.Controls.Add(this.label58);
            this.groupBox4.Controls.Add(this.label59);
            this.groupBox4.Controls.Add(this.label60);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(449, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 264);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Elevator 3";
            // 
            // elev_3_totalInside
            // 
            this.elev_3_totalInside.AutoSize = true;
            this.elev_3_totalInside.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_3_totalInside.Location = new System.Drawing.Point(134, 173);
            this.elev_3_totalInside.Name = "elev_3_totalInside";
            this.elev_3_totalInside.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_3_totalInside.Size = new System.Drawing.Size(19, 21);
            this.elev_3_totalInside.TabIndex = 36;
            this.elev_3_totalInside.Text = "0";
            this.elev_3_totalInside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_3_cap
            // 
            this.elev_3_cap.AutoSize = true;
            this.elev_3_cap.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_3_cap.Location = new System.Drawing.Point(134, 149);
            this.elev_3_cap.Name = "elev_3_cap";
            this.elev_3_cap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_3_cap.Size = new System.Drawing.Size(28, 21);
            this.elev_3_cap.TabIndex = 35;
            this.elev_3_cap.Text = "10";
            this.elev_3_cap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_3_direc
            // 
            this.elev_3_direc.AutoSize = true;
            this.elev_3_direc.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_3_direc.Location = new System.Drawing.Point(134, 125);
            this.elev_3_direc.Name = "elev_3_direc";
            this.elev_3_direc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_3_direc.Size = new System.Drawing.Size(30, 21);
            this.elev_3_direc.TabIndex = 34;
            this.elev_3_direc.Text = "Up";
            this.elev_3_direc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_3_dest
            // 
            this.elev_3_dest.AutoSize = true;
            this.elev_3_dest.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_3_dest.Location = new System.Drawing.Point(134, 101);
            this.elev_3_dest.Name = "elev_3_dest";
            this.elev_3_dest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_3_dest.Size = new System.Drawing.Size(19, 21);
            this.elev_3_dest.TabIndex = 33;
            this.elev_3_dest.Text = "0";
            this.elev_3_dest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_3_floor
            // 
            this.elev_3_floor.AutoSize = true;
            this.elev_3_floor.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_3_floor.Location = new System.Drawing.Point(134, 77);
            this.elev_3_floor.Name = "elev_3_floor";
            this.elev_3_floor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_3_floor.Size = new System.Drawing.Size(19, 21);
            this.elev_3_floor.TabIndex = 32;
            this.elev_3_floor.Text = "0";
            this.elev_3_floor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_3_mode
            // 
            this.elev_3_mode.AutoSize = true;
            this.elev_3_mode.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_3_mode.ForeColor = System.Drawing.Color.DarkGray;
            this.elev_3_mode.Location = new System.Drawing.Point(134, 53);
            this.elev_3_mode.Name = "elev_3_mode";
            this.elev_3_mode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_3_mode.Size = new System.Drawing.Size(37, 21);
            this.elev_3_mode.TabIndex = 31;
            this.elev_3_mode.Text = "Idle";
            this.elev_3_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_3_status
            // 
            this.elev_3_status.AutoSize = true;
            this.elev_3_status.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_3_status.ForeColor = System.Drawing.Color.IndianRed;
            this.elev_3_status.Location = new System.Drawing.Point(134, 30);
            this.elev_3_status.Name = "elev_3_status";
            this.elev_3_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_3_status.Size = new System.Drawing.Size(72, 21);
            this.elev_3_status.TabIndex = 30;
            this.elev_3_status.Text = "Deactive";
            this.elev_3_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_3_insideList
            // 
            this.elev_3_insideList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.elev_3_insideList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_3_insideList.ForeColor = System.Drawing.SystemColors.Control;
            this.elev_3_insideList.Location = new System.Drawing.Point(21, 222);
            this.elev_3_insideList.Name = "elev_3_insideList";
            this.elev_3_insideList.Size = new System.Drawing.Size(185, 26);
            this.elev_3_insideList.TabIndex = 21;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label53.Location = new System.Drawing.Point(18, 199);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(56, 18);
            this.label53.TabIndex = 29;
            this.label53.Text = "Inside  :";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label54.Location = new System.Drawing.Point(18, 175);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(89, 18);
            this.label54.TabIndex = 28;
            this.label54.Text = "Total inside  :";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label55.Location = new System.Drawing.Point(18, 151);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(70, 18);
            this.label55.TabIndex = 27;
            this.label55.Text = "Capacity  :";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label56.Location = new System.Drawing.Point(18, 127);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(75, 18);
            this.label56.TabIndex = 26;
            this.label56.Text = "Direction  :";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label57.Location = new System.Drawing.Point(18, 79);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(47, 18);
            this.label57.TabIndex = 25;
            this.label57.Text = "Floor :";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label58.Location = new System.Drawing.Point(18, 103);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(87, 18);
            this.label58.TabIndex = 24;
            this.label58.Text = "Destination :";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label59.Location = new System.Drawing.Point(18, 31);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(53, 18);
            this.label59.TabIndex = 23;
            this.label59.Text = "Status :";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label60.Location = new System.Drawing.Point(18, 55);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(52, 18);
            this.label60.TabIndex = 22;
            this.label60.Text = "Mode :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.elev_5_totalInside);
            this.groupBox5.Controls.Add(this.elev_5_cap);
            this.groupBox5.Controls.Add(this.elev_5_direc);
            this.groupBox5.Controls.Add(this.elev_5_dest);
            this.groupBox5.Controls.Add(this.elev_5_floor);
            this.groupBox5.Controls.Add(this.elev_5_mode);
            this.groupBox5.Controls.Add(this.elev_5_status);
            this.groupBox5.Controls.Add(this.elev_5_insideList);
            this.groupBox5.Controls.Add(this.label68);
            this.groupBox5.Controls.Add(this.label69);
            this.groupBox5.Controls.Add(this.label70);
            this.groupBox5.Controls.Add(this.label71);
            this.groupBox5.Controls.Add(this.label72);
            this.groupBox5.Controls.Add(this.label73);
            this.groupBox5.Controls.Add(this.label74);
            this.groupBox5.Controls.Add(this.label75);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(891, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(214, 264);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elevator 4";
            // 
            // elev_5_totalInside
            // 
            this.elev_5_totalInside.AutoSize = true;
            this.elev_5_totalInside.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_5_totalInside.Location = new System.Drawing.Point(134, 173);
            this.elev_5_totalInside.Name = "elev_5_totalInside";
            this.elev_5_totalInside.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_5_totalInside.Size = new System.Drawing.Size(19, 21);
            this.elev_5_totalInside.TabIndex = 36;
            this.elev_5_totalInside.Text = "0";
            this.elev_5_totalInside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_5_cap
            // 
            this.elev_5_cap.AutoSize = true;
            this.elev_5_cap.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_5_cap.Location = new System.Drawing.Point(134, 149);
            this.elev_5_cap.Name = "elev_5_cap";
            this.elev_5_cap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_5_cap.Size = new System.Drawing.Size(28, 21);
            this.elev_5_cap.TabIndex = 35;
            this.elev_5_cap.Text = "10";
            this.elev_5_cap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_5_direc
            // 
            this.elev_5_direc.AutoSize = true;
            this.elev_5_direc.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_5_direc.Location = new System.Drawing.Point(134, 125);
            this.elev_5_direc.Name = "elev_5_direc";
            this.elev_5_direc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_5_direc.Size = new System.Drawing.Size(30, 21);
            this.elev_5_direc.TabIndex = 34;
            this.elev_5_direc.Text = "Up";
            this.elev_5_direc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_5_dest
            // 
            this.elev_5_dest.AutoSize = true;
            this.elev_5_dest.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_5_dest.Location = new System.Drawing.Point(134, 101);
            this.elev_5_dest.Name = "elev_5_dest";
            this.elev_5_dest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_5_dest.Size = new System.Drawing.Size(19, 21);
            this.elev_5_dest.TabIndex = 33;
            this.elev_5_dest.Text = "0";
            this.elev_5_dest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_5_floor
            // 
            this.elev_5_floor.AutoSize = true;
            this.elev_5_floor.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_5_floor.Location = new System.Drawing.Point(134, 77);
            this.elev_5_floor.Name = "elev_5_floor";
            this.elev_5_floor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_5_floor.Size = new System.Drawing.Size(19, 21);
            this.elev_5_floor.TabIndex = 32;
            this.elev_5_floor.Text = "0";
            this.elev_5_floor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_5_mode
            // 
            this.elev_5_mode.AutoSize = true;
            this.elev_5_mode.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_5_mode.ForeColor = System.Drawing.Color.DarkGray;
            this.elev_5_mode.Location = new System.Drawing.Point(134, 53);
            this.elev_5_mode.Name = "elev_5_mode";
            this.elev_5_mode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_5_mode.Size = new System.Drawing.Size(37, 21);
            this.elev_5_mode.TabIndex = 31;
            this.elev_5_mode.Text = "Idle";
            this.elev_5_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_5_status
            // 
            this.elev_5_status.AutoSize = true;
            this.elev_5_status.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_5_status.ForeColor = System.Drawing.Color.IndianRed;
            this.elev_5_status.Location = new System.Drawing.Point(134, 30);
            this.elev_5_status.Name = "elev_5_status";
            this.elev_5_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_5_status.Size = new System.Drawing.Size(72, 21);
            this.elev_5_status.TabIndex = 30;
            this.elev_5_status.Text = "Deactive";
            this.elev_5_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_5_insideList
            // 
            this.elev_5_insideList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.elev_5_insideList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_5_insideList.ForeColor = System.Drawing.SystemColors.Control;
            this.elev_5_insideList.Location = new System.Drawing.Point(21, 222);
            this.elev_5_insideList.Name = "elev_5_insideList";
            this.elev_5_insideList.Size = new System.Drawing.Size(185, 26);
            this.elev_5_insideList.TabIndex = 21;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label68.Location = new System.Drawing.Point(18, 199);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(56, 18);
            this.label68.TabIndex = 29;
            this.label68.Text = "Inside  :";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label69.Location = new System.Drawing.Point(18, 175);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(89, 18);
            this.label69.TabIndex = 28;
            this.label69.Text = "Total inside  :";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label70.Location = new System.Drawing.Point(18, 151);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(70, 18);
            this.label70.TabIndex = 27;
            this.label70.Text = "Capacity  :";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label71.Location = new System.Drawing.Point(18, 127);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(75, 18);
            this.label71.TabIndex = 26;
            this.label71.Text = "Direction  :";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label72.Location = new System.Drawing.Point(18, 79);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(47, 18);
            this.label72.TabIndex = 25;
            this.label72.Text = "Floor :";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label73.Location = new System.Drawing.Point(18, 103);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(87, 18);
            this.label73.TabIndex = 24;
            this.label73.Text = "Destination :";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label74.Location = new System.Drawing.Point(18, 31);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(53, 18);
            this.label74.TabIndex = 23;
            this.label74.Text = "Status :";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label75.Location = new System.Drawing.Point(18, 55);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(52, 18);
            this.label75.TabIndex = 22;
            this.label75.Text = "Mode :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.elev_2_totalInside);
            this.groupBox2.Controls.Add(this.elev_2_cap);
            this.groupBox2.Controls.Add(this.elev_2_direc);
            this.groupBox2.Controls.Add(this.elev_2_dest);
            this.groupBox2.Controls.Add(this.elev_2_floor);
            this.groupBox2.Controls.Add(this.elev_2_mode);
            this.groupBox2.Controls.Add(this.elev_2_status);
            this.groupBox2.Controls.Add(this.elev_2_insideList);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(229, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 264);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elevator 2";
            // 
            // elev_2_totalInside
            // 
            this.elev_2_totalInside.AutoSize = true;
            this.elev_2_totalInside.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_2_totalInside.Location = new System.Drawing.Point(134, 173);
            this.elev_2_totalInside.Name = "elev_2_totalInside";
            this.elev_2_totalInside.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_2_totalInside.Size = new System.Drawing.Size(19, 21);
            this.elev_2_totalInside.TabIndex = 36;
            this.elev_2_totalInside.Text = "0";
            this.elev_2_totalInside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_2_cap
            // 
            this.elev_2_cap.AutoSize = true;
            this.elev_2_cap.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_2_cap.Location = new System.Drawing.Point(134, 149);
            this.elev_2_cap.Name = "elev_2_cap";
            this.elev_2_cap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_2_cap.Size = new System.Drawing.Size(28, 21);
            this.elev_2_cap.TabIndex = 35;
            this.elev_2_cap.Text = "10";
            this.elev_2_cap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_2_direc
            // 
            this.elev_2_direc.AutoSize = true;
            this.elev_2_direc.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_2_direc.Location = new System.Drawing.Point(134, 125);
            this.elev_2_direc.Name = "elev_2_direc";
            this.elev_2_direc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_2_direc.Size = new System.Drawing.Size(30, 21);
            this.elev_2_direc.TabIndex = 34;
            this.elev_2_direc.Text = "Up";
            this.elev_2_direc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_2_dest
            // 
            this.elev_2_dest.AutoSize = true;
            this.elev_2_dest.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_2_dest.Location = new System.Drawing.Point(134, 101);
            this.elev_2_dest.Name = "elev_2_dest";
            this.elev_2_dest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_2_dest.Size = new System.Drawing.Size(19, 21);
            this.elev_2_dest.TabIndex = 33;
            this.elev_2_dest.Text = "0";
            this.elev_2_dest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_2_floor
            // 
            this.elev_2_floor.AutoSize = true;
            this.elev_2_floor.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_2_floor.Location = new System.Drawing.Point(134, 77);
            this.elev_2_floor.Name = "elev_2_floor";
            this.elev_2_floor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_2_floor.Size = new System.Drawing.Size(19, 21);
            this.elev_2_floor.TabIndex = 32;
            this.elev_2_floor.Text = "0";
            this.elev_2_floor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_2_mode
            // 
            this.elev_2_mode.AutoSize = true;
            this.elev_2_mode.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_2_mode.ForeColor = System.Drawing.Color.DarkGray;
            this.elev_2_mode.Location = new System.Drawing.Point(134, 53);
            this.elev_2_mode.Name = "elev_2_mode";
            this.elev_2_mode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_2_mode.Size = new System.Drawing.Size(37, 21);
            this.elev_2_mode.TabIndex = 31;
            this.elev_2_mode.Text = "Idle";
            this.elev_2_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_2_status
            // 
            this.elev_2_status.AutoSize = true;
            this.elev_2_status.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_2_status.ForeColor = System.Drawing.Color.IndianRed;
            this.elev_2_status.Location = new System.Drawing.Point(134, 30);
            this.elev_2_status.Name = "elev_2_status";
            this.elev_2_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_2_status.Size = new System.Drawing.Size(72, 21);
            this.elev_2_status.TabIndex = 30;
            this.elev_2_status.Text = "Deactive";
            this.elev_2_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_2_insideList
            // 
            this.elev_2_insideList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.elev_2_insideList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_2_insideList.ForeColor = System.Drawing.SystemColors.Control;
            this.elev_2_insideList.Location = new System.Drawing.Point(21, 222);
            this.elev_2_insideList.Name = "elev_2_insideList";
            this.elev_2_insideList.Size = new System.Drawing.Size(185, 26);
            this.elev_2_insideList.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(18, 199);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 18);
            this.label23.TabIndex = 29;
            this.label23.Text = "Inside  :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(18, 175);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 18);
            this.label24.TabIndex = 28;
            this.label24.Text = "Total inside  :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(18, 151);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 18);
            this.label25.TabIndex = 27;
            this.label25.Text = "Capacity  :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(18, 127);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 18);
            this.label26.TabIndex = 26;
            this.label26.Text = "Direction  :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(18, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 18);
            this.label27.TabIndex = 25;
            this.label27.Text = "Floor :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(18, 103);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 18);
            this.label28.TabIndex = 24;
            this.label28.Text = "Destination :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(18, 31);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 18);
            this.label29.TabIndex = 23;
            this.label29.Text = "Status :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(18, 55);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 18);
            this.label30.TabIndex = 22;
            this.label30.Text = "Mode :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elev_4_totalInside);
            this.groupBox3.Controls.Add(this.elev_4_cap);
            this.groupBox3.Controls.Add(this.elev_4_direc);
            this.groupBox3.Controls.Add(this.elev_4_dest);
            this.groupBox3.Controls.Add(this.elev_4_floor);
            this.groupBox3.Controls.Add(this.elev_4_mode);
            this.groupBox3.Controls.Add(this.elev_4_status);
            this.groupBox3.Controls.Add(this.elev_4_insideList);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(669, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 264);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elevator 4";
            // 
            // elev_4_totalInside
            // 
            this.elev_4_totalInside.AutoSize = true;
            this.elev_4_totalInside.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_4_totalInside.Location = new System.Drawing.Point(134, 173);
            this.elev_4_totalInside.Name = "elev_4_totalInside";
            this.elev_4_totalInside.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_4_totalInside.Size = new System.Drawing.Size(19, 21);
            this.elev_4_totalInside.TabIndex = 36;
            this.elev_4_totalInside.Text = "0";
            this.elev_4_totalInside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_4_cap
            // 
            this.elev_4_cap.AutoSize = true;
            this.elev_4_cap.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_4_cap.Location = new System.Drawing.Point(134, 149);
            this.elev_4_cap.Name = "elev_4_cap";
            this.elev_4_cap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_4_cap.Size = new System.Drawing.Size(28, 21);
            this.elev_4_cap.TabIndex = 35;
            this.elev_4_cap.Text = "10";
            this.elev_4_cap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_4_direc
            // 
            this.elev_4_direc.AutoSize = true;
            this.elev_4_direc.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_4_direc.Location = new System.Drawing.Point(134, 125);
            this.elev_4_direc.Name = "elev_4_direc";
            this.elev_4_direc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_4_direc.Size = new System.Drawing.Size(30, 21);
            this.elev_4_direc.TabIndex = 34;
            this.elev_4_direc.Text = "Up";
            this.elev_4_direc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_4_dest
            // 
            this.elev_4_dest.AutoSize = true;
            this.elev_4_dest.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_4_dest.Location = new System.Drawing.Point(134, 101);
            this.elev_4_dest.Name = "elev_4_dest";
            this.elev_4_dest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_4_dest.Size = new System.Drawing.Size(19, 21);
            this.elev_4_dest.TabIndex = 33;
            this.elev_4_dest.Text = "0";
            this.elev_4_dest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_4_floor
            // 
            this.elev_4_floor.AutoSize = true;
            this.elev_4_floor.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_4_floor.Location = new System.Drawing.Point(134, 77);
            this.elev_4_floor.Name = "elev_4_floor";
            this.elev_4_floor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_4_floor.Size = new System.Drawing.Size(19, 21);
            this.elev_4_floor.TabIndex = 32;
            this.elev_4_floor.Text = "0";
            this.elev_4_floor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_4_mode
            // 
            this.elev_4_mode.AutoSize = true;
            this.elev_4_mode.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_4_mode.ForeColor = System.Drawing.Color.DarkGray;
            this.elev_4_mode.Location = new System.Drawing.Point(134, 53);
            this.elev_4_mode.Name = "elev_4_mode";
            this.elev_4_mode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_4_mode.Size = new System.Drawing.Size(37, 21);
            this.elev_4_mode.TabIndex = 31;
            this.elev_4_mode.Text = "Idle";
            this.elev_4_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_4_status
            // 
            this.elev_4_status.AutoSize = true;
            this.elev_4_status.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_4_status.ForeColor = System.Drawing.Color.IndianRed;
            this.elev_4_status.Location = new System.Drawing.Point(134, 30);
            this.elev_4_status.Name = "elev_4_status";
            this.elev_4_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elev_4_status.Size = new System.Drawing.Size(72, 21);
            this.elev_4_status.TabIndex = 30;
            this.elev_4_status.Text = "Deactive";
            this.elev_4_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elev_4_insideList
            // 
            this.elev_4_insideList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.elev_4_insideList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elev_4_insideList.ForeColor = System.Drawing.SystemColors.Control;
            this.elev_4_insideList.Location = new System.Drawing.Point(21, 222);
            this.elev_4_insideList.Name = "elev_4_insideList";
            this.elev_4_insideList.Size = new System.Drawing.Size(185, 26);
            this.elev_4_insideList.TabIndex = 21;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(18, 199);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(56, 18);
            this.label38.TabIndex = 29;
            this.label38.Text = "Inside  :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.Location = new System.Drawing.Point(18, 175);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(89, 18);
            this.label39.TabIndex = 28;
            this.label39.Text = "Total inside  :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(18, 151);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(70, 18);
            this.label40.TabIndex = 27;
            this.label40.Text = "Capacity  :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.Location = new System.Drawing.Point(18, 127);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(75, 18);
            this.label41.TabIndex = 26;
            this.label41.Text = "Direction  :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.Location = new System.Drawing.Point(18, 79);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(47, 18);
            this.label42.TabIndex = 25;
            this.label42.Text = "Floor :";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label43.Location = new System.Drawing.Point(18, 103);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(87, 18);
            this.label43.TabIndex = 24;
            this.label43.Text = "Destination :";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label44.Location = new System.Drawing.Point(18, 31);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(53, 18);
            this.label44.TabIndex = 23;
            this.label44.Text = "Status :";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label45.Location = new System.Drawing.Point(18, 55);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(52, 18);
            this.label45.TabIndex = 22;
            this.label45.Text = "Mode :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.tabPage2.Controls.Add(this.label50);
            this.tabPage2.Controls.Add(this.floorLog4);
            this.tabPage2.Controls.Add(this.label49);
            this.tabPage2.Controls.Add(this.floorLog3);
            this.tabPage2.Controls.Add(this.label48);
            this.tabPage2.Controls.Add(this.floorLog2);
            this.tabPage2.Controls.Add(this.label46);
            this.tabPage2.Controls.Add(this.floorLog1);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.floorLog0);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1117, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label50.Location = new System.Drawing.Point(468, 199);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(65, 23);
            this.label50.TabIndex = 9;
            this.label50.Text = "Floor 4";
            // 
            // floorLog4
            // 
            this.floorLog4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.floorLog4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floorLog4.ForeColor = System.Drawing.SystemColors.Control;
            this.floorLog4.FormattingEnabled = true;
            this.floorLog4.HorizontalScrollbar = true;
            this.floorLog4.ItemHeight = 23;
            this.floorLog4.Location = new System.Drawing.Point(472, 225);
            this.floorLog4.Name = "floorLog4";
            this.floorLog4.Size = new System.Drawing.Size(417, 142);
            this.floorLog4.TabIndex = 8;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label49.Location = new System.Drawing.Point(468, 16);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(65, 23);
            this.label49.TabIndex = 7;
            this.label49.Text = "Floor 3";
            // 
            // floorLog3
            // 
            this.floorLog3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.floorLog3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floorLog3.ForeColor = System.Drawing.SystemColors.Control;
            this.floorLog3.FormattingEnabled = true;
            this.floorLog3.HorizontalScrollbar = true;
            this.floorLog3.ItemHeight = 23;
            this.floorLog3.Location = new System.Drawing.Point(472, 42);
            this.floorLog3.Name = "floorLog3";
            this.floorLog3.Size = new System.Drawing.Size(417, 142);
            this.floorLog3.TabIndex = 6;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label48.Location = new System.Drawing.Point(8, 388);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(65, 23);
            this.label48.TabIndex = 5;
            this.label48.Text = "Floor 2";
            // 
            // floorLog2
            // 
            this.floorLog2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.floorLog2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floorLog2.ForeColor = System.Drawing.SystemColors.Control;
            this.floorLog2.FormattingEnabled = true;
            this.floorLog2.HorizontalScrollbar = true;
            this.floorLog2.ItemHeight = 23;
            this.floorLog2.Location = new System.Drawing.Point(11, 414);
            this.floorLog2.Name = "floorLog2";
            this.floorLog2.Size = new System.Drawing.Size(418, 142);
            this.floorLog2.TabIndex = 4;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label46.Location = new System.Drawing.Point(8, 199);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(65, 23);
            this.label46.TabIndex = 3;
            this.label46.Text = "Floor 1";
            // 
            // floorLog1
            // 
            this.floorLog1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.floorLog1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floorLog1.ForeColor = System.Drawing.SystemColors.Control;
            this.floorLog1.FormattingEnabled = true;
            this.floorLog1.HorizontalScrollbar = true;
            this.floorLog1.ItemHeight = 23;
            this.floorLog1.Location = new System.Drawing.Point(12, 225);
            this.floorLog1.Name = "floorLog1";
            this.floorLog1.Size = new System.Drawing.Size(418, 142);
            this.floorLog1.TabIndex = 2;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(8, 16);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 23);
            this.label36.TabIndex = 1;
            this.label36.Text = "Floor 0";
            // 
            // floorLog0
            // 
            this.floorLog0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.floorLog0.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floorLog0.ForeColor = System.Drawing.SystemColors.Control;
            this.floorLog0.FormattingEnabled = true;
            this.floorLog0.HorizontalScrollbar = true;
            this.floorLog0.ItemHeight = 23;
            this.floorLog0.Location = new System.Drawing.Point(12, 42);
            this.floorLog0.Name = "floorLog0";
            this.floorLog0.Size = new System.Drawing.Size(418, 142);
            this.floorLog0.TabIndex = 0;
            // 
            // elevatorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1120, 602);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "elevatorScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multithread - Elevator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.elevatorScreen_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadSpeedRate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label controlThreadCount;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label avmLoginCount;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label avmExitCount;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label totalPersonAllQueue;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label totalPersonExit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label floor_0_queue;
        private System.Windows.Forms.Label floor_1_queue;
        private System.Windows.Forms.Label floor_2_queue;
        private System.Windows.Forms.Label floor_3_queue;
        private System.Windows.Forms.Label floor_4_queue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label floor_1_totalPerson;
        private System.Windows.Forms.Label floor_2_totalPerson;
        private System.Windows.Forms.Label floor_3_totalPerson;
        private System.Windows.Forms.Label floor_4_totalPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speedValue;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TrackBar threadSpeedRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label elev_1_totalInside;
        private System.Windows.Forms.Label elev_1_cap;
        private System.Windows.Forms.Label elev_1_direc;
        private System.Windows.Forms.Label elev_1_dest;
        private System.Windows.Forms.Label elev_1_floor;
        private System.Windows.Forms.Label elev_1_mode;
        private System.Windows.Forms.Label elev_1_status;
        private System.Windows.Forms.TextBox elev_1_insideList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label elev_3_totalInside;
        private System.Windows.Forms.Label elev_3_cap;
        private System.Windows.Forms.Label elev_3_direc;
        private System.Windows.Forms.Label elev_3_dest;
        private System.Windows.Forms.Label elev_3_floor;
        private System.Windows.Forms.Label elev_3_mode;
        private System.Windows.Forms.Label elev_3_status;
        private System.Windows.Forms.TextBox elev_3_insideList;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label elev_5_totalInside;
        private System.Windows.Forms.Label elev_5_cap;
        private System.Windows.Forms.Label elev_5_direc;
        private System.Windows.Forms.Label elev_5_dest;
        private System.Windows.Forms.Label elev_5_floor;
        private System.Windows.Forms.Label elev_5_mode;
        private System.Windows.Forms.Label elev_5_status;
        private System.Windows.Forms.TextBox elev_5_insideList;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label elev_2_totalInside;
        private System.Windows.Forms.Label elev_2_cap;
        private System.Windows.Forms.Label elev_2_direc;
        private System.Windows.Forms.Label elev_2_dest;
        private System.Windows.Forms.Label elev_2_floor;
        private System.Windows.Forms.Label elev_2_mode;
        private System.Windows.Forms.Label elev_2_status;
        private System.Windows.Forms.TextBox elev_2_insideList;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label elev_4_totalInside;
        private System.Windows.Forms.Label elev_4_cap;
        private System.Windows.Forms.Label elev_4_direc;
        private System.Windows.Forms.Label elev_4_dest;
        private System.Windows.Forms.Label elev_4_floor;
        private System.Windows.Forms.Label elev_4_mode;
        private System.Windows.Forms.Label elev_4_status;
        private System.Windows.Forms.TextBox elev_4_insideList;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ListBox floorLog0;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ListBox floorLog4;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ListBox floorLog3;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ListBox floorLog2;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ListBox floorLog1;
    }
}

