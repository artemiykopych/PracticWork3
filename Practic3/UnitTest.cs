using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practic3;

namespace Practic3
{
    public partial class UnitTest : Form
    {
        public UnitTest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var calc = new Calculation_abc(Convert.ToInt32(a1.Text), Convert.ToInt32(b1.Text), Convert.ToInt32(c1.Text));
                result1.Text = calc.D().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var calc = new Calculation_ab(Convert.ToInt32(a2.Text), Convert.ToInt32(b2.Text));
                result2.Text = calc.Sun().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
