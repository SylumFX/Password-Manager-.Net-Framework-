using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Password_Manager.PL.userControls
{
    internal class CustomFlowPanelLayout : FlowLayoutPanel
    {
        public CustomFlowPanelLayout() : base()
        {
            //this.DoubleBuffered = true;
            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        protected override void OnScroll(ScrollEventArgs se)
        {

        }
    }
}
