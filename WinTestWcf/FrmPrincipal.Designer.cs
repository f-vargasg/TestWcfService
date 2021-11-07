namespace WinTestWcf
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.dgrData = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlstrTest = new System.Windows.Forms.ToolStripButton();
            this.tlstrExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrData
            // 
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrData.Location = new System.Drawing.Point(-1, 41);
            this.dgrData.Name = "dgrData";
            this.dgrData.Size = new System.Drawing.Size(676, 426);
            this.dgrData.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrExit,
            this.tlstrTest});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlstrTest
            // 
            this.tlstrTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrTest.Image = ((System.Drawing.Image)(resources.GetObject("tlstrTest.Image")));
            this.tlstrTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrTest.Name = "tlstrTest";
            this.tlstrTest.Size = new System.Drawing.Size(23, 22);
            this.tlstrTest.Text = "toolStripButton1";
            this.tlstrTest.ToolTipText = "Test";
            this.tlstrTest.Click += new System.EventHandler(this.tlstrTest_Click);
            // 
            // tlstrExit
            // 
            this.tlstrExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrExit.Image = ((System.Drawing.Image)(resources.GetObject("tlstrExit.Image")));
            this.tlstrExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrExit.Name = "tlstrExit";
            this.tlstrExit.Size = new System.Drawing.Size(23, 22);
            this.tlstrExit.Text = "toolStripButton2";
            this.tlstrExit.Click += new System.EventHandler(this.tlstrExit_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 470);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgrData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlstrExit;
        private System.Windows.Forms.ToolStripButton tlstrTest;
    }
}

