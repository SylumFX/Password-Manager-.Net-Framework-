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
    public partial class PIN_Code : UserControl
    {
        public PIN_Code()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;
        private void PIN_Code_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);

            if (backSpace)
            {
                if (value == "notBk")
                {
                    if (string.IsNullOrEmpty(PassBox_4.Texts))
                        PassBox_3.Focus();
                    if (string.IsNullOrEmpty(PassBox_3.Texts))
                        PassBox_2.Focus();
                    if (string.IsNullOrEmpty(PassBox_2.Texts))
                        PassBox_1.Focus();
                }
            }
            else
            {

                if (!string.IsNullOrEmpty(PassBox_1.Texts))
                    PassBox_2.Focus();
                if (!string.IsNullOrEmpty(PassBox_2.Texts))
                    PassBox_3.Focus();
                if (!string.IsNullOrEmpty(PassBox_3.Texts))
                    PassBox_4.Focus();

                value = "notBk";

            }
        }

        bool backSpace = false;
        string value = "notBk";

        private void PIN_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);

            int INTvalue;
            bool tr = int.TryParse(e.KeyChar.ToString(), out INTvalue);

            if (e.KeyChar == (char)Keys.Back)
                backSpace = true;
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            
            if (tr && backSpace)
            {
                if (!string.IsNullOrEmpty(PassBox_4.Texts))
                    value = "notBk";

                if (string.IsNullOrEmpty(PassBox_4.Texts) && !string.IsNullOrEmpty(PassBox_3.Texts))
                {
                    PassBox_4.Texts = INTvalue.ToString();
                    PassBox_4.Focus();
                    value = "notBk";
                }
                else if (!string.IsNullOrEmpty(PassBox_2.Texts) && string.IsNullOrEmpty(PassBox_3.Texts) && string.IsNullOrEmpty(PassBox_4.Texts))
                {
                    PassBox_3.Focus();
                    PassBox_3.Texts = INTvalue.ToString();
                    value = "notBk";
                }
                else if (!string.IsNullOrEmpty(PassBox_1.Texts) && string.IsNullOrEmpty(PassBox_2.Texts) && string.IsNullOrEmpty(PassBox_3.Texts) && string.IsNullOrEmpty(PassBox_4.Texts))
                {
                    PassBox_2.Focus();
                    PassBox_2.Texts = INTvalue.ToString();
                    value = "notBk";
                }
                else if (string.IsNullOrEmpty(PassBox_1.Texts) && string.IsNullOrEmpty(PassBox_2.Texts) && string.IsNullOrEmpty(PassBox_3.Texts) && string.IsNullOrEmpty(PassBox_4.Texts))
                {
                    PassBox_1.Texts = INTvalue.ToString();
                    PassBox_2.Focus();
                    value = "notBk";
                }

            }
        }


        [Category("Advanced")]
        public Color BorderColor
        {
            get { return PassBox_1.BorderColor; }
            set
            {
                PassBox_1.BorderColor = value;
                PassBox_2.BorderColor = value;
                PassBox_3.BorderColor = value;
                PassBox_4.BorderColor = value;
            }
        }
        [Category("Advanced")]
        public int BorderSize
        {
            get { return PassBox_1.BorderSize; }
            set
            {
                if (value >= 1)
                {

                    PassBox_1.BorderSize = value;
                    PassBox_2.BorderSize = value;
                    PassBox_3.BorderSize = value;
                    PassBox_4.BorderSize = value;

                    this.Invalidate();
                }
            }
        }

        public string Value
        {
            get { return PassBox_1.Texts + PassBox_2.Texts + PassBox_3.Texts + PassBox_4.Texts; }
        }

    }
}
