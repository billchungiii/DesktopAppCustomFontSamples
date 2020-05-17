using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_CustomFontSample001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Font = new Font(FontsProxy.Fonts[0], 15);
        }
    }
}
