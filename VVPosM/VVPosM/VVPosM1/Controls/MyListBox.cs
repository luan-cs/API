using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VVPosM1.Controls
{
    public sealed class MyListBox:CheckedListBox
    {
       public MyListBox() {
            ItemHeight = 35;
        }
        public override int ItemHeight { get; set; }
    }
}
