namespace PracticWork12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += new MouseEventHandler(this.pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button1
            // 
            button1.Location = new Point(12, 380);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 1;
            button1.Text = "Открыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.Location = new Point(512, 380);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 2;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new EventHandler(this.button2_Click);
            // 
            // button3
            // 
            button3.Location = new Point(130, 380);
            button3.Name = "button3";
            button3.Size = new Size(100, 30);
            button3.TabIndex = 3;
            button3.Text = "Ч/Б";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new EventHandler(this.button3_Click);
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(250, 380);
            trackBar1.Maximum = 255;
            trackBar1.Minimum = 0;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(240, 45);
            trackBar1.TabIndex = 4;
            trackBar1.Value = 128;
            trackBar1.Scroll += new EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 425);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Порог: 128";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 451);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += new EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TrackBar trackBar1;
        private Label label1;
    }
}