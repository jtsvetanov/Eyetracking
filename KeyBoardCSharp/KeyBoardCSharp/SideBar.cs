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
  public partial class SideBar : Form
  {
    public SideBar()
    {
      InitializeComponent();
    }


    Form1 form1 = new Form1();
    ShowButton form2 = new ShowButton();
    private void SideBar_Load(object sender, EventArgs e)
    {
      this.Width = 82;
      int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
      int y = Screen.PrimaryScreen.WorkingArea.Height / 3;
      this.TopMost = true;
      this.Location = new Point(x, y);
      this.Opacity = 0.9;
      form1.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      System.Environment.Exit(1);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (form1.Visible)
      {
        //form2.Show();
        form1.Hide();
      }
        

      else if (!form1.Visible)
      {
        form1.Show();
        //form2.Hide();
      }
        
    }

    private void button3_Click(object sender, EventArgs e)
    {

    }
  }
}
