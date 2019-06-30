namespace ParseHtml
{
  partial class Form1
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
      this.searchButton = new System.Windows.Forms.Button();
      this.linkTextBox = new System.Windows.Forms.TextBox();
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.teamParseButton = new System.Windows.Forms.Button();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.vpParse = new System.Windows.Forms.Button();
      this.clearButton = new System.Windows.Forms.Button();
      this.tbPageCount = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // searchButton
      // 
      this.searchButton.BackColor = System.Drawing.SystemColors.Info;
      this.searchButton.Location = new System.Drawing.Point(13, 13);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(75, 23);
      this.searchButton.TabIndex = 0;
      this.searchButton.Text = "GO";
      this.searchButton.UseVisualStyleBackColor = false;
      this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
      // 
      // linkTextBox
      // 
      this.linkTextBox.Location = new System.Drawing.Point(94, 16);
      this.linkTextBox.Name = "linkTextBox";
      this.linkTextBox.Size = new System.Drawing.Size(789, 20);
      this.linkTextBox.TabIndex = 1;
      // 
      // webBrowser1
      // 
      this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webBrowser1.Location = new System.Drawing.Point(13, 73);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(1061, 582);
      this.webBrowser1.TabIndex = 2;
      this.webBrowser1.ScriptErrorsSuppressed = true;
      this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
      // 
      // teamParseButton
      // 
      this.teamParseButton.BackColor = System.Drawing.Color.Honeydew;
      this.teamParseButton.Location = new System.Drawing.Point(888, 42);
      this.teamParseButton.Name = "teamParseButton";
      this.teamParseButton.Size = new System.Drawing.Size(90, 23);
      this.teamParseButton.TabIndex = 3;
      this.teamParseButton.Text = "Team";
      this.teamParseButton.UseVisualStyleBackColor = false;
      this.teamParseButton.Click += new System.EventHandler(this.parseButton_Click);
      // 
      // vpParse
      // 
      this.vpParse.BackColor = System.Drawing.Color.AliceBlue;
      this.vpParse.Location = new System.Drawing.Point(984, 42);
      this.vpParse.Name = "vpParse";
      this.vpParse.Size = new System.Drawing.Size(90, 23);
      this.vpParse.TabIndex = 4;
      this.vpParse.Text = "Valued Partner";
      this.vpParse.UseVisualStyleBackColor = false;
      this.vpParse.Click += new System.EventHandler(this.vpParse_Click);
      // 
      // clearButton
      // 
      this.clearButton.BackColor = System.Drawing.SystemColors.Info;
      this.clearButton.Location = new System.Drawing.Point(12, 42);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(75, 23);
      this.clearButton.TabIndex = 5;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = false;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // tbPageCount
      // 
      this.tbPageCount.Location = new System.Drawing.Point(935, 15);
      this.tbPageCount.Name = "tbPageCount";
      this.tbPageCount.Size = new System.Drawing.Size(139, 20);
      this.tbPageCount.TabIndex = 6;
      this.tbPageCount.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(1086, 667);
      this.Controls.Add(this.tbPageCount);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.vpParse);
      this.Controls.Add(this.teamParseButton);
      this.Controls.Add(this.webBrowser1);
      this.Controls.Add(this.linkTextBox);
      this.Controls.Add(this.searchButton);
      this.Name = "Form1";
      this.Text = "Helper";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.TextBox linkTextBox;
    private System.Windows.Forms.WebBrowser webBrowser1;
    private System.Windows.Forms.Button teamParseButton;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Button vpParse;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.TextBox tbPageCount;
  }
}

