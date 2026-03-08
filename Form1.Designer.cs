namespace CS_Week01_25017084_MyBusinessCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("한컴 말랑말랑 Bold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(284, 59);
            label1.Name = "label1";
            label1.Size = new Size(192, 77);
            label1.TabIndex = 1;
            label1.Text = "최경서";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(284, 162);
            label2.Name = "label2";
            label2.Size = new Size(715, 43);
            label2.TabIndex = 2;
            label2.Text = "수원대학교 지능형SW융합대학 컴퓨터학부 컴퓨터SW";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(284, 223);
            label3.Name = "label3";
            label3.Size = new Size(375, 35);
            label3.TabIndex = 3;
            label3.Text = "kyungseo0612@suwon.ac.kr";
            // 
            // button1
            // 
            button1.Font = new Font("한컴 말랑말랑 Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(648, 423);
            button1.Name = "button1";
            button1.Size = new Size(305, 84);
            button1.TabIndex = 4;
            button1.Text = "배경색 랜덤 수정";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1048, 554);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
