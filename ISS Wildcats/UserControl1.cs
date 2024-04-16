using System;
using System.Drawing;
using System.Windows.Forms;

namespace ISS_Wildcats
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            this.Visible = false;

            // Attach event handlers for all labels

            // Attach special hover and leave event handlers for labels 1, 7, 8, 9, 10, and 11
            label1.MouseHover += SpecialLabel_MouseHover;
            label1.MouseLeave += SpecialLabel_MouseLeave;
            label7.MouseHover += SpecialLabel_MouseHover;
            label7.MouseLeave += SpecialLabel_MouseLeave;
            label8.MouseHover += SpecialLabel_MouseHover;
            label8.MouseLeave += SpecialLabel_MouseLeave;
            label9.MouseHover += SpecialLabel_MouseHover;
            label9.MouseLeave += SpecialLabel_MouseLeave;
            label10.MouseHover += SpecialLabel_MouseHover;
            label10.MouseLeave += SpecialLabel_MouseLeave;
            label11.MouseHover += SpecialLabel_MouseHover;
            label11.MouseLeave += SpecialLabel_MouseLeave;
            this.Dock = DockStyle.Right;
        }



        private void SpecialLabel_MouseHover(object sender, EventArgs e)
        {

            if (sender is Label label)
            {
                label.Font = new Font("Segoe UI", 15);
            }

        }

        private void SpecialLabel_MouseLeave(object sender, EventArgs e)
        {

            if (sender is Label label)
            {
                label.Font = new Font("Segoe UI", 11);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.panel3.Visible = false;
        }
    }
}
