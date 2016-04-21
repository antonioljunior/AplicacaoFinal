using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ComponentesVisuais
{
    public class MeuTextBox : TextBox
    {
        public MeuTextBox()
        {
            this.Text = "Meu text box";
            this.BackColor = Color.Gray;
        }
    }
}
