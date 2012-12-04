using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace euler_prog_12
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // calculate triangular numbers
      int n = 1;

      int factorCount = 0;
      int highest = 0;
      while (factorCount < 501)
      {
        int triangularNumber = (n * (n + 1));

        if (triangularNumber % 2 == 0)
        {
          triangularNumber = triangularNumber / 2;
          // listBox1.Items.Add(triangularNumber.ToString());

          string data = triangularNumber.ToString() + ": ";
          factorCount = 0;
          // find factors
          for (int c = 1; c <= triangularNumber; c++)
          {
            if (triangularNumber % c == 0)
            {
              //data += " " + c.ToString() + " ";
              factorCount++;
            }

          }

          int i = listBox1.Items.Add(data + "(" + factorCount.ToString() + ")");
          if (factorCount > highest)
          {
            highest = factorCount;
            //listBox1.Items.Add("************* Highest :" + highest.ToString());
            label1.Text = highest.ToString();
            label1.Refresh();

          }
          listBox1.TopIndex = i;
          listBox1.Refresh();
        }



        n++;

      }

    }
  }
}
