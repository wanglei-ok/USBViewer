namespace USBViewer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbTrace = new System.Windows.Forms.ToolStripButton();
            this.tsbLog = new System.Windows.Forms.ToolStripButton();
            this.tsbEraser = new System.Windows.Forms.ToolStripSplitButton();
            this.eraserSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserAll = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTrace,
            this.tsbLog,
            this.tsbEraser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbTrace
            // 
            this.tsbTrace.Image = ((System.Drawing.Image)(resources.GetObject("tsbTrace.Image")));
            this.tsbTrace.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTrace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTrace.Name = "tsbTrace";
            this.tsbTrace.Size = new System.Drawing.Size(60, 69);
            this.tsbTrace.Text = "查看痕迹";
            this.tsbTrace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbTrace.Click += new System.EventHandler(this.tsbTrace_Click);
            // 
            // tsbLog
            // 
            this.tsbLog.Image = ((System.Drawing.Image)(resources.GetObject("tsbLog.Image")));
            this.tsbLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLog.Name = "tsbLog";
            this.tsbLog.Size = new System.Drawing.Size(60, 69);
            this.tsbLog.Text = "生成报告";
            this.tsbLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLog.Click += new System.EventHandler(this.tsbLog_Click);
            // 
            // tsbEraser
            // 
            this.tsbEraser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eraserSelected,
            this.eraserAll});
            this.tsbEraser.Enabled = false;
            this.tsbEraser.Image = ((System.Drawing.Image)(resources.GetObject("tsbEraser.Image")));
            this.tsbEraser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEraser.Name = "tsbEraser";
            this.tsbEraser.Size = new System.Drawing.Size(72, 69);
            this.tsbEraser.Text = "擦除痕迹";
            this.tsbEraser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEraser.ButtonClick += new System.EventHandler(this.tsbEraser_ButtonClick);
            // 
            // eraserSelected
            // 
            this.eraserSelected.Name = "eraserSelected";
            this.eraserSelected.Size = new System.Drawing.Size(148, 22);
            this.eraserSelected.Text = "擦除选中记录";
            this.eraserSelected.Click += new System.EventHandler(this.eraserSelected_Click);
            // 
            // eraserAll
            // 
            this.eraserAll.Name = "eraserAll";
            this.eraserAll.Size = new System.Drawing.Size(148, 22);
            this.eraserAll.Text = "擦除所有记录";
            this.eraserAll.Click += new System.EventHandler(this.eraserAll_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 378);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "USB Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbTrace;
        private System.Windows.Forms.ToolStripButton tsbLog;
        private System.Windows.Forms.ToolStripSplitButton tsbEraser;
        private System.Windows.Forms.ToolStripMenuItem eraserSelected;
        private System.Windows.Forms.ToolStripMenuItem eraserAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

