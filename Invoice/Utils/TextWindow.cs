using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktury.Utils
{
    public partial class TextWindow : Form
    {
        public TextWindow(string title)
        {
            InitializeComponent();
            this.Name = title;
            this.Text = title;
        }

        private void TextWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
