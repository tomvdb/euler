using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace euler_prog_4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public bool isPalindrome(int number)
    {
      string temp = "";

      // reverse the string
      for (int c = number.ToString().Length-1; c >= 0; c--)
        temp += number.ToString()[c];

      if (Convert.ToInt32(temp) == number)
        return true;

      return false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int highest = 0;

      for ( int a = 0; a < 1000; a++ )
        for (int b = 0; b < 1000; b++)
        {
          int product = a * b;
          if (isPalindrome(product))
            if (product > highest)
              highest = product;
        }

      listBox1.Items.Add("Highest Palindrome: " + highest.ToString());
    }
  }
}
