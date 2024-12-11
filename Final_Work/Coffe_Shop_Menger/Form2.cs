

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CPPGroupProject2.Frontend.Forms
{
    public partial class FormPictureBox : Form
    {
        public PictureBox Image { get { return this.pictureBoxRandomPicture; } }
        public FormPictureBox()
        {
            InitializeComponent();
        }

        private void pictureBoxRandomPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
