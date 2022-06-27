namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProffesion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWorkYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Должность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оклад = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Паспортные_данные = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Примечание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стаж_работы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(197, 369);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 0;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(53, 90);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(100, 23);
            this.textBoxFIO.TabIndex = 2;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(53, 147);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 23);
            this.textBoxStatus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Должность";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxProffesion
            // 
            this.textBoxProffesion.Location = new System.Drawing.Point(53, 214);
            this.textBoxProffesion.Name = "textBoxProffesion";
            this.textBoxProffesion.Size = new System.Drawing.Size(100, 23);
            this.textBoxProffesion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Квалификация";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(172, 214);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 23);
            this.textBoxPhone.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Телефон";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(172, 147);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmount.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Оклад";
            // 
            // textBoxWorkYear
            // 
            this.textBoxWorkYear.Location = new System.Drawing.Point(172, 90);
            this.textBoxWorkYear.Name = "textBoxWorkYear";
            this.textBoxWorkYear.Size = new System.Drawing.Size(100, 23);
            this.textBoxWorkYear.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Стаж работы";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(53, 283);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(100, 23);
            this.textBoxNote.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Примечание";
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(172, 283);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(100, 23);
            this.textBoxPassport.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Паспортные данные";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИО,
            this.Должность,
            this.Оклад,
            this.Телефон,
            this.Паспортные_данные,
            this.Примечание,
            this.Стаж_работы});
            this.dataGridView1.Location = new System.Drawing.Point(309, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(760, 234);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            // 
            // Должность
            // 
            this.Должность.HeaderText = "Должность";
            this.Должность.Name = "Должность";
            // 
            // Оклад
            // 
            this.Оклад.HeaderText = "Оклад";
            this.Оклад.Name = "Оклад";
            // 
            // Телефон
            // 
            this.Телефон.HeaderText = "Телефон";
            this.Телефон.Name = "Телефон";
            // 
            // Паспортные_данные
            // 
            this.Паспортные_данные.HeaderText = "Паспортные данные";
            this.Паспортные_данные.Name = "Паспортные_данные";
            // 
            // Примечание
            // 
            this.Примечание.HeaderText = "Примечание";
            this.Примечание.Name = "Примечание";
            // 
            // Стаж_работы
            // 
            this.Стаж_работы.HeaderText = "Стаж работы";
            this.Стаж_работы.Name = "Стаж_работы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWorkYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxProffesion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddClient;
        private Label label1;
        private TextBox textBoxFIO;
        private TextBox textBoxStatus;
        private Label label2;
        private TextBox textBoxProffesion;
        private Label label3;
        private TextBox textBoxPhone;
        private Label label4;
        private TextBox textBoxAmount;
        private Label label5;
        private TextBox textBoxWorkYear;
        private Label label6;
        private TextBox textBoxNote;
        private Label label8;
        private TextBox textBoxPassport;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ФИО;
        private DataGridViewTextBoxColumn Должность;
        private DataGridViewTextBoxColumn Оклад;
        private DataGridViewTextBoxColumn Телефон;
        private DataGridViewTextBoxColumn Паспортные_данные;
        private DataGridViewTextBoxColumn Примечание;
        private DataGridViewTextBoxColumn Стаж_работы;
    }
}