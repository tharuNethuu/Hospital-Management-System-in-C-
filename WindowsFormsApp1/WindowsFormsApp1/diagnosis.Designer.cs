namespace WindowsFormsApp1
{
    partial class diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diagnosis));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(121, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient Registration System";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(32, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 73);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 76);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(553, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "📝 Diagnosis Dashboard ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox1.Location = new System.Drawing.Point(149, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Diagnosis ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "Select Gender";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox2.Location = new System.Drawing.Point(149, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Medicines";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox3.Location = new System.Drawing.Point(149, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Diagnosis";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox4.Location = new System.Drawing.Point(149, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(186, 20);
            this.textBox4.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Symptoms";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(138, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 37);
            this.button4.TabIndex = 30;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(235, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 37);
            this.button3.TabIndex = 29;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(138, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 26);
            this.button2.TabIndex = 28;
            this.button2.Text = " HOME";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 171);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SlateGray;
            this.label11.Location = new System.Drawing.Point(358, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "Patients List";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(397, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 273);
            this.panel3.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Book", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(287, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 12);
            this.label14.TabIndex = 35;
            this.label14.Text = "Patient Registration by EasyCare";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(229, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Medicines:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Symptoms:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Diagnosis:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Patient Name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Diagnosis Summary";
            // 
            // diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 597);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "diagnosis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
    }
}