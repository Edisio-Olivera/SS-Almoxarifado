using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SS_Almoxarifado.Views;

namespace SS_Almoxarifado
{
    public partial class tela_splash : Form
    {
        public tela_splash()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 20;

            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                frm_login login = new frm_login();
                login.ShowDialog();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
