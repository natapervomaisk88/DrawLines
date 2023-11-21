using System.Diagnostics;

namespace DrawLines
{
    public partial class Form1 : Form
    {
        Color colorLine = Color.Black;
        Graphics gr;
        public Form1()
        {
            InitializeComponent();
            button3.BackColor = colorLine;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                colorLine = colorDialog1.Color;
                button3.BackColor = colorLine;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (X1TextBox.Text != string.Empty
                && X2TextBox.Text != string.Empty
                && Y1TextBox.Text != string.Empty
                && Y2TextBox.Text != string.Empty)
            {
                if (int.TryParse(X1TextBox.Text, out int x1)
                    && int.TryParse(X2TextBox.Text, out int x2)
                    && int.TryParse(Y1TextBox.Text, out int y1)
                    && int.TryParse(Y2TextBox.Text, out int y2))
                {

                    gr = e.Graphics;
                    Pen pen = new Pen(colorLine, trackBar1.Value);
                    gr.DrawLine(pen, x1, y1, x2, y2);


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            //this.Invalidate();
        }
    }
}