using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.PL.userControls
{
    public partial class PaintBorderPanel : UserControl
    {
        public PaintBorderPanel()
        {
            InitializeComponent();
        }



        [Description("Change Border Color: "), Category("Data")]
        public Color Value
        {
            get => chosenPaintColor;
            set => chosenPaintColor = value;
        }

        public  Color chosenPaintColor { get; set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, chosenPaintColor, ButtonBorderStyle.Solid);
        }

    }
}
