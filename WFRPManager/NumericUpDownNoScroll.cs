using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRPManager
{
    public class NumericUpDownNoScroll : NumericUpDown
    {
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            
        }
    }
}
