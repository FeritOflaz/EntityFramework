namespace WinFormsApp_TF
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBoxokulno = new TextBox();
            textBoxad = new TextBox();
            textBoxsoyad = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.Location = new Point(6, 260);
            button1.Name = "button1";
            button1.Size = new Size(199, 59);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(221, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(550, 325);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBoxokulno
            // 
            textBoxokulno.Location = new Point(54, 37);
            textBoxokulno.Name = "textBoxokulno";
            textBoxokulno.Size = new Size(100, 23);
            textBoxokulno.TabIndex = 2;
            // 
            // textBoxad
            // 
            textBoxad.Location = new Point(54, 101);
            textBoxad.Name = "textBoxad";
            textBoxad.Size = new Size(100, 23);
            textBoxad.TabIndex = 3;
            // 
            // textBoxsoyad
            // 
            textBoxsoyad.Location = new Point(54, 175);
            textBoxsoyad.Name = "textBoxsoyad";
            textBoxsoyad.Size = new Size(100, 23);
            textBoxsoyad.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Aquamarine;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxsoyad);
            groupBox1.Controls.Add(textBoxokulno);
            groupBox1.Controls.Add(textBoxad);
            groupBox1.Location = new Point(5, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 325);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 157);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 83);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 6;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Okul No";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(774, 337);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBoxokulno;
        private TextBox textBoxad;
        private TextBox textBoxsoyad;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}