
namespace Fusen
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textFusenMemo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InkFreeVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImpactCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogFusen = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFusenMemo
            // 
            this.textFusenMemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textFusenMemo.ContextMenuStrip = this.contextMenuStrip1;
            this.textFusenMemo.Location = new System.Drawing.Point(0, 0);
            this.textFusenMemo.Multiline = true;
            this.textFusenMemo.Name = "textFusenMemo";
            this.textFusenMemo.Size = new System.Drawing.Size(680, 293);
            this.textFusenMemo.TabIndex = 0;
            this.textFusenMemo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFusenMemo_KeyDown);
            this.textFusenMemo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textFusenMemo_MouseDoubleClick);
            this.textFusenMemo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textFusenMemo_MouseDown);
            this.textFusenMemo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textFusenMemo_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem,
            this.InkFreeVToolStripMenuItem,
            this.ImpactCToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 120);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "明朝体";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.明朝体ToolStripMenuItem_Click);
            // 
            // InkFreeVToolStripMenuItem
            // 
            this.InkFreeVToolStripMenuItem.Name = "InkFreeVToolStripMenuItem";
            this.InkFreeVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.InkFreeVToolStripMenuItem.Text = "InkFree(&V)";
            this.InkFreeVToolStripMenuItem.Click += new System.EventHandler(this.InkFreeVToolStripMenuItem_Click);
            // 
            // ImpactCToolStripMenuItem
            // 
            this.ImpactCToolStripMenuItem.Name = "ImpactCToolStripMenuItem";
            this.ImpactCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ImpactCToolStripMenuItem.Text = "Impact(&C)";
            this.ImpactCToolStripMenuItem.Click += new System.EventHandler(this.ImpactCToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 終了ToolStripMenuItem1
            // 
            this.終了ToolStripMenuItem1.Name = "終了ToolStripMenuItem1";
            this.終了ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem1.Text = "終了";
            this.終了ToolStripMenuItem1.Click += new System.EventHandler(this.終了ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 292);
            this.Controls.Add(this.textFusenMemo);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFusenMemo;
        private System.Windows.Forms.ColorDialog colorDialogFusen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InkFreeVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImpactCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem1;
    }
}

