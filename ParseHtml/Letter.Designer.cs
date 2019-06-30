namespace ParseHtml
{
  partial class Letter
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
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.copyButton = new System.Windows.Forms.Button();
      this.titleTextBox = new System.Windows.Forms.TextBox();
      this.copyTitleButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // richTextBox1
      // 
      this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.richTextBox1.Location = new System.Drawing.Point(12, 38);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(772, 553);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      // 
      // copyButton
      // 
      this.copyButton.Location = new System.Drawing.Point(790, 307);
      this.copyButton.Name = "copyButton";
      this.copyButton.Size = new System.Drawing.Size(75, 23);
      this.copyButton.TabIndex = 1;
      this.copyButton.Text = "Copy Letter";
      this.copyButton.UseVisualStyleBackColor = true;
      this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
      // 
      // titleTextBox
      // 
      this.titleTextBox.Location = new System.Drawing.Point(12, 12);
      this.titleTextBox.Name = "titleTextBox";
      this.titleTextBox.Size = new System.Drawing.Size(771, 20);
      this.titleTextBox.TabIndex = 2;
      // 
      // copyTitleButton
      // 
      this.copyTitleButton.Location = new System.Drawing.Point(789, 9);
      this.copyTitleButton.Name = "copyTitleButton";
      this.copyTitleButton.Size = new System.Drawing.Size(75, 23);
      this.copyTitleButton.TabIndex = 3;
      this.copyTitleButton.Text = "Copy Title";
      this.copyTitleButton.UseVisualStyleBackColor = true;
      this.copyTitleButton.Click += new System.EventHandler(this.copyTitleButton_Click);
      // 
      // Letter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(899, 603);
      this.Controls.Add(this.copyTitleButton);
      this.Controls.Add(this.titleTextBox);
      this.Controls.Add(this.copyButton);
      this.Controls.Add(this.richTextBox1);
      this.Name = "Letter";
      this.Text = "Letter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button copyButton;
    public System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.Button copyTitleButton;
  }
}