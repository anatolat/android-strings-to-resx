using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AndroidStringsToResx.Resources;

namespace AndroidStringsToResx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = Strings.title;
            textBox2.Text = Strings.escaping_test;
        }

    }
}
