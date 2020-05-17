using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_CustomFontSample001
{
    public sealed class FontsProxy
    {

        private FontsProxy() { }

        private PrivateFontCollection CreateFonts()
        {
            var result = new PrivateFontCollection();
            var bytes = Properties.Resources.SourceHanSansTW_Bold;
            System.IntPtr pointer = Marshal.AllocCoTaskMem(bytes.Length);
            Marshal.Copy(bytes, 0, pointer, bytes.Length);
            result.AddMemoryFont(pointer, bytes.Length);
            return result;
        }

        private static PrivateFontCollection _fontsCollection;

        public static FontFamily[] Fonts
        {
            get
            {
                if (_fontsCollection == null)
                {
                    _fontsCollection = new FontsProxy().CreateFonts();
                }
                return _fontsCollection.Families;
            }
        }
    }
}
