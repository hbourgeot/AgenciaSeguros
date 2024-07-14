using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaSeguros
{
  public partial class Form1 : Form
  {
    private bool showPassword = false;

    private bool getShowPassword()
    {
      return showPassword;
    }

    private void setShowPassword(bool value)
    {
      showPassword = value;
    }

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      setShowPassword(!getShowPassword());
      if(getShowPassword())
      {
        button1.Text = "Ocultar";
        maskedTextBox1.UseSystemPasswordChar = false;
      } else
      {
        button1.Text = "Mostrar";
        maskedTextBox1.UseSystemPasswordChar = true;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void button3_Click(object sender, EventArgs e)
    {

    }
  }
}
