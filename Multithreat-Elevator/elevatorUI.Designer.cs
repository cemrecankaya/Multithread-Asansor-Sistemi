namespace Multithreat_Elevator
{
    partial class elevatorUI
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
            this.start = new System.Windows.Forms.Button();
            this.elevator_0 = new System.Windows.Forms.TextBox();
            this.elevator_1 = new System.Windows.Forms.TextBox();
            this.elevator_3 = new System.Windows.Forms.TextBox();
            this.elevator_2 = new System.Windows.Forms.TextBox();
            this.elevator_4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(957, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(79, 51);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // elevator_0
            // 
            this.elevator_0.Location = new System.Drawing.Point(125, 30);
            this.elevator_0.Name = "elevator_0";
            this.elevator_0.Size = new System.Drawing.Size(69, 22);
            this.elevator_0.TabIndex = 1;
            // 
            // elevator_1
            // 
            this.elevator_1.Location = new System.Drawing.Point(125, 30);
            this.elevator_1.Name = "elevator_1";
            this.elevator_1.Size = new System.Drawing.Size(69, 22);
            this.elevator_1.TabIndex = 3;
            // 
            // elevator_3
            // 
            this.elevator_3.Location = new System.Drawing.Point(125, 30);
            this.elevator_3.Name = "elevator_3";
            this.elevator_3.Size = new System.Drawing.Size(69, 22);
            this.elevator_3.TabIndex = 7;
            // 
            // elevator_2
            // 
            this.elevator_2.Location = new System.Drawing.Point(125, 30);
            this.elevator_2.Name = "elevator_2";
            this.elevator_2.Size = new System.Drawing.Size(69, 22);
            this.elevator_2.TabIndex = 5;
            // 
            // elevator_4
            // 
            this.elevator_4.Location = new System.Drawing.Point(125, 30);
            this.elevator_4.Name = "elevator_4";
            this.elevator_4.Size = new System.Drawing.Size(69, 22);
            this.elevator_4.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Floor 4: Total Person : [ 0 ] -- Queue : [ 0 ]",
            "Floor 3: Total Person : [ 0 ] -- Queue : [ 0 ]",
            "Floor 2: Total Person : [ 0 ] -- Queue : [ 0 ]",
            "Floor 1: Total Person : [ 0 ] -- Queue : [ 0 ]",
            "Floor 0: Total Person : [ 0 ] -- Queue : [ 0 ]"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(939, 104);
            this.listBox1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elevator_0);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 185);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elevator 1";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(957, 69);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(79, 51);
            this.stop.TabIndex = 16;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.elevator_1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(218, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 185);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elevator 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elevator_2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(424, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 185);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elevator 3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.elevator_3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(630, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 185);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Elevator 4";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.elevator_4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(836, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 185);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elevator 5";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 332);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1023, 108);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Floor 4:\nFloor 3:\nFloor 2:\nFloor 1:\nFloor 0:";
            // 
            // elevatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 469);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.start);
            this.Name = "elevatorUI";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.elevatorUI_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox elevator_0;
        private System.Windows.Forms.TextBox elevator_1;
        private System.Windows.Forms.TextBox elevator_3;
        private System.Windows.Forms.TextBox elevator_2;
        private System.Windows.Forms.TextBox elevator_4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

