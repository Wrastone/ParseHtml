using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseHtml
{
  public partial class Letter : Form
  {
    public Letter()
    {
      InitializeComponent();
    }

    private void copyButton_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(richTextBox1.Text);
    }

    private void copyTitleButton_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(titleTextBox.Text);
    }
  }
}
