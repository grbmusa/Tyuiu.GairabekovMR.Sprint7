using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GairabekovMR.Sprint7.Project.V13
{
    public partial class FormAbout_GMR : Form
    {
        bool but = false;
        public FormAbout_GMR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (but)
            {
                this.Close();

            }
            else
            {
                buttonExit_GMR.Text = "Закрывайте на свой страх и риск";
            }
            but = !but;
        }
    }
}
