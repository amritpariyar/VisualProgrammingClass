namespace Calculator
{
  partial class Dashboard
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.stopwatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.unitConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopwatchToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.unitConverterToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(840, 33);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // stopwatchToolStripMenuItem
      // 
      this.stopwatchToolStripMenuItem.Name = "stopwatchToolStripMenuItem";
      this.stopwatchToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
      this.stopwatchToolStripMenuItem.Text = "Stopwatch";
      this.stopwatchToolStripMenuItem.Click += new System.EventHandler(this.stopwatchToolStripMenuItem_Click);
      // 
      // calculatorToolStripMenuItem
      // 
      this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
      this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
      this.calculatorToolStripMenuItem.Text = "Calculator";
      this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
      // 
      // unitConverterToolStripMenuItem
      // 
      this.unitConverterToolStripMenuItem.Name = "unitConverterToolStripMenuItem";
      this.unitConverterToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
      this.unitConverterToolStripMenuItem.Text = "Unit Converter";
      this.unitConverterToolStripMenuItem.Click += new System.EventHandler(this.unitConverterToolStripMenuItem_Click);
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(840, 736);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Dashboard";
      this.Text = "Dashboard";
      this.Load += new System.EventHandler(this.Dashboard_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem stopwatchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem unitConverterToolStripMenuItem;
  }
}