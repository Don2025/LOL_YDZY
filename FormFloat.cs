using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 云顶之奕助手
{
    public partial class FormFloat : Form
    {
        //全局变量 
        private Point ptMouseCurrrnetPos, ptMouseNewPos, ptFormPos, ptFormNewPos;
        private bool blnMouseDown = false;
        private Form1 parent;

        public FormFloat(Form1 main)
        {
            InitializeComponent();
            parent = main;
        }

        private void FormFloat_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Top = 100;
            this.Left = Screen.PrimaryScreen.Bounds.Width - 100;
            this.Width = 80;
            this.Height = 80;
        }

        private void FormFloat_MouseMove(object sender, MouseEventArgs e)
        {
            if (blnMouseDown)
            {
                ptMouseNewPos = Control.MousePosition;
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrrnetPos.X + ptFormPos.X;
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrrnetPos.Y + ptFormPos.Y;
                Location = ptFormNewPos;
                ptFormPos = ptFormNewPos;
                ptMouseCurrrnetPos = ptMouseNewPos;
            }
        }

        private void FormFloat_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                blnMouseDown = true;
                ptMouseCurrrnetPos = Control.MousePosition;
                ptFormPos = Location;
            }
        }

        private void FormFloat_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                blnMouseDown = false;
            }
        }

        private void FormFloat_MouseDoubleClick(object sender, MouseEventArgs e)   //双击恢复父窗体
        {
            parent.RestoreWindow();
            this.Hide();
        }

    }
}
