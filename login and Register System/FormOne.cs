using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login_and_Register_System;


namespace Splash
{
    public partial class FormSplash : System.Windows.Forms.Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }
        int counter;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 200)
            {
                timer1.Enabled = false;
                this.Hide();
                frmLogin f = new frmLogin();
                f.Show();
            }
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
