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
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            var bytes = Properties.Resources.SourceHanSansTW_Bold;
            System.IntPtr pointer = Marshal.AllocCoTaskMem(bytes.Length);
            Marshal.Copy(bytes, 0, pointer, bytes.Length);
            privateFonts.AddMemoryFont(pointer, bytes.Length);
            this.Font = new Font(privateFonts.Families[0], 25);
        }
    }
}
