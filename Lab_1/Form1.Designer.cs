namespace Lab_1
{
	partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.g_h = new ZedGraph.ZedGraphControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.L_h = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.N_h = new System.Windows.Forms.TextBox();
            this.Calc_h = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.r_h = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_h = new System.Windows.Forms.TextBox();
            this.Tc = new System.Windows.Forms.Label();
            this.tc_h = new System.Windows.Forms.TextBox();
            this.Тп = new System.Windows.Forms.Label();
            this.tn_h = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.N_c = new System.Windows.Forms.TextBox();
            this.Calc_c = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.c_c = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tc_c = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.g_c = new ZedGraph.ZedGraphControl();
            this.tn_c = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // g_h
            // 
            this.g_h.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g_h.BackColor = System.Drawing.Color.Silver;
            this.g_h.Location = new System.Drawing.Point(249, 25);
            this.g_h.Name = "g_h";
            this.g_h.ScrollGrace = 0D;
            this.g_h.ScrollMaxX = 0D;
            this.g_h.ScrollMaxY = 0D;
            this.g_h.ScrollMaxY2 = 0D;
            this.g_h.ScrollMinX = 0D;
            this.g_h.ScrollMinY = 0D;
            this.g_h.ScrollMinY2 = 0D;
            this.g_h.Size = new System.Drawing.Size(687, 426);
            this.g_h.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 499);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.L_h);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.N_h);
            this.tabPage1.Controls.Add(this.Calc_h);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.r_h);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.c_h);
            this.tabPage1.Controls.Add(this.Tc);
            this.tabPage1.Controls.Add(this.tc_h);
            this.tabPage1.Controls.Add(this.Тп);
            this.tabPage1.Controls.Add(this.g_h);
            this.tabPage1.Controls.Add(this.tn_h);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(977, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "L";
            // 
            // L_h
            // 
            this.L_h.Location = new System.Drawing.Point(67, 199);
            this.L_h.Name = "L_h";
            this.L_h.Size = new System.Drawing.Size(100, 20);
            this.L_h.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "N";
            // 
            // N_h
            // 
            this.N_h.Location = new System.Drawing.Point(67, 173);
            this.N_h.Name = "N_h";
            this.N_h.Size = new System.Drawing.Size(100, 20);
            this.N_h.TabIndex = 19;
            // 
            // Calc_h
            // 
            this.Calc_h.Location = new System.Drawing.Point(67, 140);
            this.Calc_h.Name = "Calc_h";
            this.Calc_h.Size = new System.Drawing.Size(100, 27);
            this.Calc_h.TabIndex = 18;
            this.Calc_h.Text = "Розрах";
            this.Calc_h.UseVisualStyleBackColor = true;
            this.Calc_h.Click += new System.EventHandler(this.Calc_h_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "R";
            // 
            // r_h
            // 
            this.r_h.Location = new System.Drawing.Point(67, 103);
            this.r_h.Name = "r_h";
            this.r_h.Size = new System.Drawing.Size(100, 20);
            this.r_h.TabIndex = 16;
            this.r_h.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "С";
            // 
            // c_h
            // 
            this.c_h.Location = new System.Drawing.Point(67, 77);
            this.c_h.Name = "c_h";
            this.c_h.Size = new System.Drawing.Size(100, 20);
            this.c_h.TabIndex = 14;
            this.c_h.Text = "100000";
            // 
            // Tc
            // 
            this.Tc.AutoSize = true;
            this.Tc.Location = new System.Drawing.Point(11, 54);
            this.Tc.Name = "Tc";
            this.Tc.Size = new System.Drawing.Size(20, 13);
            this.Tc.TabIndex = 13;
            this.Tc.Text = "Tп";
            // 
            // tc_h
            // 
            this.tc_h.Location = new System.Drawing.Point(67, 51);
            this.tc_h.Name = "tc_h";
            this.tc_h.Size = new System.Drawing.Size(100, 20);
            this.tc_h.TabIndex = 12;
            this.tc_h.Text = "0,01";
            // 
            // Тп
            // 
            this.Тп.AutoSize = true;
            this.Тп.Location = new System.Drawing.Point(11, 28);
            this.Тп.Name = "Тп";
            this.Тп.Size = new System.Drawing.Size(20, 13);
            this.Тп.TabIndex = 11;
            this.Тп.Text = "Тр";
            // 
            // tn_h
            // 
            this.tn_h.Location = new System.Drawing.Point(67, 25);
            this.tn_h.Name = "tn_h";
            this.tn_h.Size = new System.Drawing.Size(100, 20);
            this.tn_h.TabIndex = 10;
            this.tn_h.Text = "0,01";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.N_c);
            this.tabPage2.Controls.Add(this.Calc_c);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.c_c);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tc_c);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.g_c);
            this.tabPage2.Controls.Add(this.tn_c);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(977, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "N";
            // 
            // N_c
            // 
            this.N_c.Location = new System.Drawing.Point(82, 171);
            this.N_c.Name = "N_c";
            this.N_c.Size = new System.Drawing.Size(100, 20);
            this.N_c.TabIndex = 33;
            // 
            // Calc_c
            // 
            this.Calc_c.Location = new System.Drawing.Point(82, 138);
            this.Calc_c.Name = "Calc_c";
            this.Calc_c.Size = new System.Drawing.Size(100, 27);
            this.Calc_c.TabIndex = 32;
            this.Calc_c.Text = "Розрах";
            this.Calc_c.UseVisualStyleBackColor = true;
            this.Calc_c.Click += new System.EventHandler(this.Calc_c_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "С";
            // 
            // c_c
            // 
            this.c_c.Location = new System.Drawing.Point(82, 75);
            this.c_c.Name = "c_c";
            this.c_c.Size = new System.Drawing.Size(100, 20);
            this.c_c.TabIndex = 28;
            this.c_c.Text = "100000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tп";
            // 
            // tc_c
            // 
            this.tc_c.Location = new System.Drawing.Point(82, 49);
            this.tc_c.Name = "tc_c";
            this.tc_c.Size = new System.Drawing.Size(100, 20);
            this.tc_c.TabIndex = 26;
            this.tc_c.Text = "0,01";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Тр";
            // 
            // g_c
            // 
            this.g_c.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g_c.BackColor = System.Drawing.Color.Silver;
            this.g_c.Location = new System.Drawing.Point(236, 23);
            this.g_c.Name = "g_c";
            this.g_c.ScrollGrace = 0D;
            this.g_c.ScrollMaxX = 0D;
            this.g_c.ScrollMaxY = 0D;
            this.g_c.ScrollMaxY2 = 0D;
            this.g_c.ScrollMinX = 0D;
            this.g_c.ScrollMinY = 0D;
            this.g_c.ScrollMinY2 = 0D;
            this.g_c.Size = new System.Drawing.Size(527, 311);
            this.g_c.TabIndex = 23;
            // 
            // tn_c
            // 
            this.tn_c.Location = new System.Drawing.Point(82, 23);
            this.tn_c.Name = "tn_c";
            this.tn_c.Size = new System.Drawing.Size(100, 20);
            this.tn_c.TabIndex = 24;
            this.tn_c.Text = "0,01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lab_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private ZedGraph.ZedGraphControl g_h;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Тп;
        private System.Windows.Forms.TextBox tn_h;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox L_h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox N_h;
        private System.Windows.Forms.Button Calc_h;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox r_h;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_h;
        private System.Windows.Forms.Label Tc;
        private System.Windows.Forms.TextBox tc_h;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox N_c;
        private System.Windows.Forms.Button Calc_c;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox c_c;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tc_c;
        private System.Windows.Forms.Label label10;
        private ZedGraph.ZedGraphControl g_c;
        private System.Windows.Forms.TextBox tn_c;
	}
}

