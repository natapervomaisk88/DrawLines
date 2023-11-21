namespace DrawLines
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
            colorDialog1 = new ColorDialog();
            linkLabel1 = new LinkLabel();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            trackBar1 = new TrackBar();
            Y2TextBox = new TextBox();
            label4 = new Label();
            Y1TextBox = new TextBox();
            label3 = new Label();
            X2TextBox = new TextBox();
            label2 = new Label();
            X1TextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(6, 51);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(74, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Choice color";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Controls.Add(Y2TextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Y1TextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(X2TextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(X1TextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Location = new Point(613, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // button2
            // 
            button2.Location = new Point(94, 385);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 385);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Paint";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 291);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 10;
            label5.Text = "Width Line";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(0, 320);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 9;
            trackBar1.Value = 1;
            // 
            // Y2TextBox
            // 
            Y2TextBox.Location = new Point(103, 235);
            Y2TextBox.Name = "Y2TextBox";
            Y2TextBox.Size = new Size(49, 23);
            Y2TextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(103, 204);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 7;
            label4.Text = "Y2";
            // 
            // Y1TextBox
            // 
            Y1TextBox.Location = new Point(103, 142);
            Y1TextBox.Name = "Y1TextBox";
            Y1TextBox.Size = new Size(49, 23);
            Y1TextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 108);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 5;
            label3.Text = "Y1";
            // 
            // X2TextBox
            // 
            X2TextBox.Location = new Point(6, 235);
            X2TextBox.Name = "X2TextBox";
            X2TextBox.Size = new Size(49, 23);
            X2TextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 204);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 3;
            label2.Text = "X2";
            // 
            // X1TextBox
            // 
            X1TextBox.Location = new Point(6, 142);
            X1TextBox.Name = "X1TextBox";
            X1TextBox.Size = new Size(49, 23);
            X1TextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 108);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 1;
            label1.Text = "X1";
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 426);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(100, 51);
            button3.Name = "button3";
            button3.Size = new Size(52, 38);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private TrackBar trackBar1;
        private TextBox Y2TextBox;
        private Label label4;
        private TextBox Y1TextBox;
        private Label label3;
        private TextBox X2TextBox;
        private Label label2;
        private TextBox X1TextBox;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}