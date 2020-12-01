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
            this.başlat = new System.Windows.Forms.Button();
            this.elevator_0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elevator_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.elevator_3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.elevator_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.elevator_4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // başlat
            // 
            this.başlat.Location = new System.Drawing.Point(828, 87);
            this.başlat.Name = "başlat";
            this.başlat.Size = new System.Drawing.Size(111, 32);
            this.başlat.TabIndex = 0;
            this.başlat.Text = "Başlat";
            this.başlat.UseVisualStyleBackColor = true;
            this.başlat.Click += new System.EventHandler(this.başlat_Click);
            // 
            // elevator_0
            // 
            this.elevator_0.Location = new System.Drawing.Point(837, 190);
            this.elevator_0.Name = "elevator_0";
            this.elevator_0.Size = new System.Drawing.Size(69, 20);
            this.elevator_0.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(764, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asansör 2";
            // 
            // elevator_1
            // 
            this.elevator_1.Location = new System.Drawing.Point(837, 216);
            this.elevator_1.Name = "elevator_1";
            this.elevator_1.Size = new System.Drawing.Size(69, 20);
            this.elevator_1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Asansör 4";
            // 
            // elevator_3
            // 
            this.elevator_3.Location = new System.Drawing.Point(837, 268);
            this.elevator_3.Name = "elevator_3";
            this.elevator_3.Size = new System.Drawing.Size(69, 20);
            this.elevator_3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asansör 3";
            // 
            // elevator_2
            // 
            this.elevator_2.Location = new System.Drawing.Point(837, 242);
            this.elevator_2.Name = "elevator_2";
            this.elevator_2.Size = new System.Drawing.Size(69, 20);
            this.elevator_2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(764, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Asansör 5";
            // 
            // elevator_4
            // 
            this.elevator_4.Location = new System.Drawing.Point(837, 294);
            this.elevator_4.Name = "elevator_4";
            this.elevator_4.Size = new System.Drawing.Size(69, 20);
            this.elevator_4.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Floor 0 : ",
            "Floor 1 : ",
            "Floor 2 : ",
            "Floor 3 : ",
            "Floor 4 : "});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(927, 69);
            this.listBox1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 185);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elevator 1";
            // 
            // elevatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.elevator_4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elevator_3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.elevator_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elevator_1);
            this.Controls.Add(this.elevator_0);
            this.Controls.Add(this.başlat);
            this.Name = "elevatorUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button başlat;
        private System.Windows.Forms.TextBox elevator_0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox elevator_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox elevator_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox elevator_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox elevator_4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

