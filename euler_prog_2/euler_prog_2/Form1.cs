using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace euler_prog_2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //uint val = 13195;
      long val = 600851475143;

      for (long c = 1; c < val; c++)
      {
        long valueToCheck = c;
        bool prime = true;

        for (long d = 2; d < valueToCheck; d++)
        {
          if (c % d == 0)
            prime = false;
        }

        if (prime)
        {
          if (val % c == 0)
          {
            listBox1.Items.Add(c.ToString());
            Application.DoEvents();
          }
        }
          
      }

      listBox1.Items.Add("Done");
    }
  }
}
