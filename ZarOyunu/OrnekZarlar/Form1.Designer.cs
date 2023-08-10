namespace OrnekZarlar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            total2 = new TextBox();
            total1 = new TextBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ımageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            TextZar1 = new TextBox();
            TextZar2 = new TextBox();
            buttonZar = new Button();
            buttonSkor = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonBasla = new Button();
            buttonBitir = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(total2);
            groupBox1.Controls.Add(total1);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 317);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oyuncular";
            // 
            // total2
            // 
            total2.Enabled = false;
            total2.Location = new Point(239, 266);
            total2.Name = "total2";
            total2.Size = new Size(182, 27);
            total2.TabIndex = 4;
            total2.Text = "0";
            // 
            // total1
            // 
            total1.Enabled = false;
            total1.Location = new Point(6, 266);
            total1.Name = "total1";
            total1.Size = new Size(182, 27);
            total1.TabIndex = 2;
            total1.Text = "0";
            // 
            // listBox2
            // 
            listBox2.Enabled = false;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(239, 56);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(182, 204);
            listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.Enabled = false;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(6, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 204);
            listBox1.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(239, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Oyuncu2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Oyuncu1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(12, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 222);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Zarlar";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(239, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "zar_1.jpg");
            ımageList1.Images.SetKeyName(1, "zar_2.jpg");
            ımageList1.Images.SetKeyName(2, "zar_3.jpg");
            ımageList1.Images.SetKeyName(3, "zar_4.jpg");
            ımageList1.Images.SetKeyName(4, "zar_5.jpg");
            ımageList1.Images.SetKeyName(5, "zar_6.jpg");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(518, 370);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Zar 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 407);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Zar 2:";
            // 
            // TextZar1
            // 
            TextZar1.Enabled = false;
            TextZar1.Location = new Point(570, 367);
            TextZar1.Name = "TextZar1";
            TextZar1.Size = new Size(125, 27);
            TextZar1.TabIndex = 4;
            // 
            // TextZar2
            // 
            TextZar2.Enabled = false;
            TextZar2.Location = new Point(570, 407);
            TextZar2.Name = "TextZar2";
            TextZar2.Size = new Size(125, 27);
            TextZar2.TabIndex = 5;
            // 
            // buttonZar
            // 
            buttonZar.Enabled = false;
            buttonZar.Location = new Point(518, 477);
            buttonZar.Name = "buttonZar";
            buttonZar.Size = new Size(94, 29);
            buttonZar.TabIndex = 6;
            buttonZar.Text = "Zar At";
            buttonZar.UseVisualStyleBackColor = true;
            buttonZar.Click += button1_Click;
            // 
            // buttonSkor
            // 
            buttonSkor.Enabled = false;
            buttonSkor.Location = new Point(649, 477);
            buttonSkor.Name = "buttonSkor";
            buttonSkor.Size = new Size(94, 29);
            buttonSkor.TabIndex = 7;
            buttonSkor.Text = "Skor Ekle";
            buttonSkor.UseVisualStyleBackColor = true;
            buttonSkor.Click += buttonSkor_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // buttonBasla
            // 
            buttonBasla.Location = new Point(518, 68);
            buttonBasla.Name = "buttonBasla";
            buttonBasla.Size = new Size(107, 76);
            buttonBasla.TabIndex = 8;
            buttonBasla.Text = "Başlat";
            buttonBasla.UseVisualStyleBackColor = true;
            buttonBasla.Click += buttonBasla_Click;
            // 
            // buttonBitir
            // 
            buttonBitir.Enabled = false;
            buttonBitir.Location = new Point(649, 68);
            buttonBitir.Name = "buttonBitir";
            buttonBitir.Size = new Size(107, 76);
            buttonBitir.TabIndex = 9;
            buttonBitir.Text = "Bitir";
            buttonBitir.UseVisualStyleBackColor = true;
            buttonBitir.Click += buttonBitir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(804, 569);
            Controls.Add(buttonBitir);
            Controls.Add(buttonBasla);
            Controls.Add(buttonSkor);
            Controls.Add(buttonZar);
            Controls.Add(TextZar2);
            Controls.Add(TextZar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox total2;
        private TextBox total1;
        private ListBox listBox2;
        private ListBox listBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
        private Label label1;
        private Label label2;
        private TextBox TextZar1;
        private TextBox TextZar2;
        private Button buttonZar;
        private Button buttonSkor;
        private System.Windows.Forms.Timer timer1;
        private Button buttonBasla;
        private Button buttonBitir;
    }
}