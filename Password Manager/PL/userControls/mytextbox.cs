using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Password_Manager.PL.userControls;
using Password_Manager.DAL;

namespace Password_Manager.PL.userControls
{
    public partial class mytextbox : UserControl
    {

        public mytextbox()
        {
            InitializeComponent();
        }

        // Send txtbox value
        public string BoxText 
        { 
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public string txtBoxValue
        {
            get
            {
                return textBox1.Text;
            }
        }

        // Propreties

        [Description("Change Label's Text"),        Category("Advanced")]
        public bool IsText
        {
            get => TextOrCombo;
            set => TextOrCombo = value;
        }
        public bool TextOrCombo { get; set; }

        [Description("Change Label's Text"),        Category("Advanced")]
        public string LabelText
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        [Description("Change Label's Color"),       Category("Advanced")]
        public Color LabelColor
        {
            get => label1.ForeColor;
            set => label1.ForeColor = value;
        }

        [Description("Change Placeholder's Text"),  Category("Advanced")]
        public string GetPlaceholderText
        {
            get => PlaceholderTxt;
            set => PlaceholderTxt = value;
        }
        public string PlaceholderTxt { get; set; }

        [Description("Change Border Color: "),      Category("Advanced")]
        public Color GetBorderColor
        {
            get => chosenPaintColor;
            set => chosenPaintColor = value;
        }
        public Color chosenPaintColor { get; set; }

        // Propreties

        private void mytextbox_Load(object sender, EventArgs e)
        {
            textBox1.Font      = new Font("Work Sans", 12F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(184, 184, 184);
            textBox1.Text      = PlaceholderTxt;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == PlaceholderTxt)
            {
                textBox1.Font      = new Font("Work Sans", 12F, FontStyle.Regular, GraphicsUnit.Point); 
                textBox1.ForeColor = Color.Black;
                textBox1.Clear();
            }
            else
            {
                textBox1.Font      = new Font("Work Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text      = PlaceholderTxt;
                textBox1.Font      =  new Font("Work Sans", 12F, FontStyle.Italic, GraphicsUnit.Point);
                textBox1.ForeColor = Color.FromArgb(184, 184, 184);
            }
            else
            {
                textBox1.Font      = new Font("Work Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textboxPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.textboxPanel.ClientRectangle, chosenPaintColor, ButtonBorderStyle.Solid);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
