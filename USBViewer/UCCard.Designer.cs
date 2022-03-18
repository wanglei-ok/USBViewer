namespace USBViewer
{
    partial class UCCard
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClassGUID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDevInstId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(20, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(92, 37);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 12);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Service:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(92, 61);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(47, 12);
            this.lblService.TabIndex = 1;
            this.lblService.Text = "Service";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "ClassGUID:";
            // 
            // lblClassGUID
            // 
            this.lblClassGUID.AutoSize = true;
            this.lblClassGUID.Location = new System.Drawing.Point(92, 85);
            this.lblClassGUID.Name = "lblClassGUID";
            this.lblClassGUID.Size = new System.Drawing.Size(59, 12);
            this.lblClassGUID.TabIndex = 1;
            this.lblClassGUID.Text = "ClassGUID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Driver:";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(92, 109);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(41, 12);
            this.lblDriver.TabIndex = 1;
            this.lblDriver.Text = "Driver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "HID:";
            // 
            // lblHID
            // 
            this.lblHID.AutoSize = true;
            this.lblHID.Location = new System.Drawing.Point(92, 133);
            this.lblHID.Name = "lblHID";
            this.lblHID.Size = new System.Drawing.Size(23, 12);
            this.lblHID.TabIndex = 1;
            this.lblHID.Text = "HID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "DevInstId:";
            // 
            // lblDevInstId
            // 
            this.lblDevInstId.Location = new System.Drawing.Point(92, 157);
            this.lblDevInstId.Name = "lblDevInstId";
            this.lblDevInstId.Size = new System.Drawing.Size(275, 37);
            this.lblDevInstId.TabIndex = 1;
            this.lblDevInstId.Text = "DevInstId";
            // 
            // UCCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDevInstId);
            this.Controls.Add(this.lblHID);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblClassGUID);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Name = "UCCard";
            this.Size = new System.Drawing.Size(377, 206);
            this.Load += new System.EventHandler(this.UCCard_Load);
            this.Click += new System.EventHandler(this.UCCard_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblClass;
        public System.Windows.Forms.Label lblService;
        public System.Windows.Forms.Label lblClassGUID;
        public System.Windows.Forms.Label lblDriver;
        public System.Windows.Forms.Label lblHID;
        public System.Windows.Forms.Label lblDevInstId;
        public System.Windows.Forms.Label lblName;
    }
}
