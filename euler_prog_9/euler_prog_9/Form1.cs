using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace euler_prog_9
{
  public partial class Form1 : Form
  {

    private void findPythagoreanTriplet()
    {
      int a, b, c = 0;
      int temp;

      // a < b < c
      for (c = 0; c < 999; c++)
        for ( b = 0; b < c; b++ )
          for (a = 0; a < b; a++)
          {
            if ((a + b + c) == 1000)
            {
              if ((a * a) + (b * b) == (c * c))
              {
                //if (( Math.Sqrt(a) % 1 ) == 0  && ( Math.Sqrt(b) % 1 ) == 0 )
                listBox1.Items.Add(a.ToString() + "," + b.ToString() + "," + c.ToString());
                listBox1.Items.Add("Product : " + (a * b * c).ToString());
              }
            }
          }

      listBox1.Items.Add("Done");
    }

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      findPythagoreanTriplet();
    }
  }
}
