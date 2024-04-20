namespace call_book
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listView1 = new ListView();
            Имя = new ColumnHeader();
            Телефон = new ColumnHeader();
            Адрес = new ColumnHeader();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Location = new Point(21, 223);
            button1.Name = "button1";
            button1.Size = new Size(163, 54);
            button1.TabIndex = 0;
            button1.Text = "Добавить контакт";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, -31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(903, 527);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 192, 128);
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(895, 492);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ф";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 28);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 164);
            label3.Name = "label3";
            label3.Size = new Size(68, 22);
            label3.TabIndex = 6;
            label3.Text = "Адрес";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 28);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 28);
            textBox1.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(255, 192, 128);
            listView1.Columns.AddRange(new ColumnHeader[] { Имя, Телефон, Адрес });
            listView1.GridLines = true;
            listView1.Location = new Point(291, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(604, 492);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Имя
            // 
            Имя.Text = "Имя";
            Имя.Width = 200;
            // 
            // Телефон
            // 
            Телефон.Text = "Телефон";
            Телефон.Width = 200;
            // 
            // Адрес
            // 
            Адрес.Text = "Адрес";
            Адрес.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 99);
            label2.Name = "label2";
            label2.Size = new Size(93, 22);
            label2.TabIndex = 2;
            label2.Text = "Телефон";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 22);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(895, 494);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Location = new Point(163, 405);
            button2.Name = "button2";
            button2.Size = new Size(122, 78);
            button2.TabIndex = 8;
            button2.Text = "Загрузить список контактов";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(900, 495);
            Controls.Add(tabControl1);
            Font = new Font("Toledo", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 0, 64);
            Name = "Form1";
            Text = "Контакты";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private ListView listView1;
        private ColumnHeader Имя;
        private ColumnHeader Телефон;
        private ColumnHeader Адрес;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
    }
}
