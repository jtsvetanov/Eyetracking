using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardCSharp
{
  public partial class ShowButton : Form
  {
    public ShowButton()
    {
      InitializeComponent();
    }

    private void ShowButton_Load(object sender, EventArgs e)
    {
      int x = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
      int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
      this.Location = new Point(x, y);
      this.TopMost = true;
    }
    Form1 form1 = new Form1();
    private void button1_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      form1.Show();
    }
  }
}
