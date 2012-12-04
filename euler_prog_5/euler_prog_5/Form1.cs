using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace euler_prog_5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int n = 0;
      int range = 20;

      bool dividedAll = false;

      while (dividedAll == false)
      {
        dividedAll = true;
        n++;

        for (int c = 1; c <= range; c++)
        {
          if (n % c != 0)
          {
            dividedAll = false;
            break;
          }
        }
      }

      listBox1.Items.Add("Highest number divisible by 1 to " + range.ToString() + " is " + n.ToString());
    }
  }
}
