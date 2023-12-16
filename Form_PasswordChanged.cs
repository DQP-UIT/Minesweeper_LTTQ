using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Y2_MineLand
{
    public partial class Form_PasswordChanged : KryptonForm
    {
        public Form_PasswordChanged()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
