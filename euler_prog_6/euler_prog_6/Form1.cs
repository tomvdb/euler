using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace euler_prog_6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      long sum_of_squares = 0;
      int natural_numbers = 100;
      long square_of_sum = 0;

      // sum of squares
      for (int c = 1; c <= natural_numbers; c++)
      {
        sum_of_squares += (c * c);
      }

      // square of sums
      for (int c = 1; c <= natural_numbers; c++)
      {
        square_of_sum += c;
      }

      square_of_sum = square_of_sum * square_of_sum;

      long diff = square_of_sum - sum_of_squares;

      listBox1.Items.Add(diff.ToString());


    }
  }
}
