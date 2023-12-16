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
    public partial class Form_Setting : KryptonForm
    {
        public Form_Setting()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login form = new Form_Login();
            form.Show();
            this.Close();
        }

        private void btn_Changepass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_PasswordChanged form = new Form_PasswordChanged();
            form.Show();
            this.Close();
        }
    }
}
