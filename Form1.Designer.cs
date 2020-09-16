namespace Kurs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtbtnCheckFirewall = new System.Windows.Forms.TextBox();
            this.btnCheckFirewall = new System.Windows.Forms.Button();
            this.txtCheckExistanceFirewall = new System.Windows.Forms.TextBox();
            this.btnCheckExistanceFirewall = new System.Windows.Forms.Button();
            this.txtWebConnectionStatus = new System.Windows.Forms.TextBox();
            this.btnCheckWebCoonection = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTestAntivirus = new System.Windows.Forms.TextBox();
            this.btnCheckExistaneAntivirus = new System.Windows.Forms.Button();
            this.btnTestAntivirus = new System.Windows.Forms.Button();
            this.txtCheckExistaneAntivirus = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 228);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.txtbtnCheckFirewall);
            this.tabPage1.Controls.Add(this.btnCheckFirewall);
            this.tabPage1.Controls.Add(this.txtCheckExistanceFirewall);
            this.tabPage1.Controls.Add(this.btnCheckExistanceFirewall);
            this.tabPage1.Controls.Add(this.txtWebConnectionStatus);
            this.tabPage1.Controls.Add(this.btnCheckWebCoonection);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Проверка межсетевого экрана";
            // 
            // txtbtnCheckFirewall
            // 
            this.txtbtnCheckFirewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbtnCheckFirewall.Location = new System.Drawing.Point(304, 145);
            this.txtbtnCheckFirewall.Name = "txtbtnCheckFirewall";
            this.txtbtnCheckFirewall.Size = new System.Drawing.Size(327, 22);
            this.txtbtnCheckFirewall.TabIndex = 5;
            this.txtbtnCheckFirewall.Text = "...";
            // 
            // btnCheckFirewall
            // 
            this.btnCheckFirewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckFirewall.Location = new System.Drawing.Point(6, 136);
            this.btnCheckFirewall.Name = "btnCheckFirewall";
            this.btnCheckFirewall.Size = new System.Drawing.Size(269, 40);
            this.btnCheckFirewall.TabIndex = 4;
            this.btnCheckFirewall.Text = "Проверка работоспособности межсетевого экрана";
            this.btnCheckFirewall.UseVisualStyleBackColor = true;
            this.btnCheckFirewall.Click += new System.EventHandler(this.btnCheckFirewall_Click);
            // 
            // txtCheckExistanceFirewall
            // 
            this.txtCheckExistanceFirewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCheckExistanceFirewall.Location = new System.Drawing.Point(304, 84);
            this.txtCheckExistanceFirewall.Name = "txtCheckExistanceFirewall";
            this.txtCheckExistanceFirewall.Size = new System.Drawing.Size(327, 22);
            this.txtCheckExistanceFirewall.TabIndex = 3;
            this.txtCheckExistanceFirewall.Text = "...";
            // 
            // btnCheckExistanceFirewall
            // 
            this.btnCheckExistanceFirewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckExistanceFirewall.Location = new System.Drawing.Point(6, 75);
            this.btnCheckExistanceFirewall.Name = "btnCheckExistanceFirewall";
            this.btnCheckExistanceFirewall.Size = new System.Drawing.Size(269, 40);
            this.btnCheckExistanceFirewall.TabIndex = 2;
            this.btnCheckExistanceFirewall.Text = "Проверка наличия установленного межсетевого экрана";
            this.btnCheckExistanceFirewall.UseVisualStyleBackColor = true;
            this.btnCheckExistanceFirewall.Click += new System.EventHandler(this.btnCheckExistanceFirewall_Click);
            // 
            // txtWebConnectionStatus
            // 
            this.txtWebConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWebConnectionStatus.Location = new System.Drawing.Point(304, 29);
            this.txtWebConnectionStatus.Name = "txtWebConnectionStatus";
            this.txtWebConnectionStatus.Size = new System.Drawing.Size(327, 22);
            this.txtWebConnectionStatus.TabIndex = 1;
            this.txtWebConnectionStatus.Text = "...";
            // 
            // btnCheckWebCoonection
            // 
            this.btnCheckWebCoonection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckWebCoonection.Location = new System.Drawing.Point(6, 25);
            this.btnCheckWebCoonection.Name = "btnCheckWebCoonection";
            this.btnCheckWebCoonection.Size = new System.Drawing.Size(269, 31);
            this.btnCheckWebCoonection.TabIndex = 0;
            this.btnCheckWebCoonection.Text = "Проверка подключения к Интернету";
            this.btnCheckWebCoonection.UseVisualStyleBackColor = true;
            this.btnCheckWebCoonection.Click += new System.EventHandler(this.btnCheckWebCoonection_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.txtTestAntivirus);
            this.tabPage2.Controls.Add(this.btnCheckExistaneAntivirus);
            this.tabPage2.Controls.Add(this.btnTestAntivirus);
            this.tabPage2.Controls.Add(this.txtCheckExistaneAntivirus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Проверка антивирусного ПО";
            // 
            // txtTestAntivirus
            // 
            this.txtTestAntivirus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTestAntivirus.Location = new System.Drawing.Point(307, 125);
            this.txtTestAntivirus.Name = "txtTestAntivirus";
            this.txtTestAntivirus.Size = new System.Drawing.Size(327, 22);
            this.txtTestAntivirus.TabIndex = 11;
            this.txtTestAntivirus.Text = "...";
            // 
            // btnCheckExistaneAntivirus
            // 
            this.btnCheckExistaneAntivirus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckExistaneAntivirus.Location = new System.Drawing.Point(9, 43);
            this.btnCheckExistaneAntivirus.Name = "btnCheckExistaneAntivirus";
            this.btnCheckExistaneAntivirus.Size = new System.Drawing.Size(269, 42);
            this.btnCheckExistaneAntivirus.TabIndex = 6;
            this.btnCheckExistaneAntivirus.Text = "Проверка наличия установленного антивирусного ПО";
            this.btnCheckExistaneAntivirus.UseVisualStyleBackColor = true;
            this.btnCheckExistaneAntivirus.Click += new System.EventHandler(this.btnCheckExistaneAntivirus_Click);
            // 
            // btnTestAntivirus
            // 
            this.btnTestAntivirus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTestAntivirus.Location = new System.Drawing.Point(9, 116);
            this.btnTestAntivirus.Name = "btnTestAntivirus";
            this.btnTestAntivirus.Size = new System.Drawing.Size(269, 40);
            this.btnTestAntivirus.TabIndex = 10;
            this.btnTestAntivirus.Text = "Тестирование антивирусного ПО";
            this.btnTestAntivirus.UseVisualStyleBackColor = true;
            this.btnTestAntivirus.Click += new System.EventHandler(this.btnTestAntivirus_Click);
            // 
            // txtCheckExistaneAntivirus
            // 
            this.txtCheckExistaneAntivirus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCheckExistaneAntivirus.Location = new System.Drawing.Point(307, 53);
            this.txtCheckExistaneAntivirus.Name = "txtCheckExistaneAntivirus";
            this.txtCheckExistaneAntivirus.Size = new System.Drawing.Size(327, 22);
            this.txtCheckExistaneAntivirus.TabIndex = 7;
            this.txtCheckExistaneAntivirus.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод результатов";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(508, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вывести результаты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(508, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить результаты в файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(508, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(450, 161);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Проверка безопасности ПК";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtWebConnectionStatus;
        private System.Windows.Forms.Button btnCheckWebCoonection;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtbtnCheckFirewall;
        private System.Windows.Forms.Button btnCheckFirewall;
        private System.Windows.Forms.TextBox txtCheckExistanceFirewall;
        private System.Windows.Forms.Button btnCheckExistanceFirewall;
        private System.Windows.Forms.TextBox txtTestAntivirus;
        private System.Windows.Forms.Button btnCheckExistaneAntivirus;
        private System.Windows.Forms.Button btnTestAntivirus;
        private System.Windows.Forms.TextBox txtCheckExistaneAntivirus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

