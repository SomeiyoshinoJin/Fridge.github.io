using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fusen
{
    public partial class Form1 : Form
    {
        private int mouseX; 
        private int mouseY;
        public Form1()
        {
            InitializeComponent();
        }

        private void textFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.mouseX = e.X;
                this.mouseY = e.Y;
            }
        }

        private void textFusenMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (colorDialogFusen.ShowDialog() == DialogResult.OK)
            {
                textFusenMemo.BackColor = colorDialogFusen.Color;
            }
        }

        private void textFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            System.Drawing.Point p = new System.Drawing.Point(50, 10);
            //this.contextMenuStrip1.Show(this.button1, p);
            this.contextMenuStrip1.Show(Cursor.Position,ToolStripDropDownDirection.AboveLeft);
        }

        private void 終了ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
                this.Close();
        }

        private void 貼り付けVToolStripMenuItem_Click(object sender, EventArgs e) //フォントにしました。
        {
            textFusenMemo.Font = new Font("Ink Free", 24);
        }

        private void コピーCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void 明朝体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textFusenMemo.Font = new Font("BIZ UDP明朝", 24);
        }

        private void InkFreeVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textFusenMemo.Font = new Font("Ink Free", 20);
        }

        private void メイリオCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textFusenMemo.Font = new Font("メイリオ", 12);
        }

        private void ImpactCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textFusenMemo.Font = new Font("Impact", 15);
        }
    }
}
