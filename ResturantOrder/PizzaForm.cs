using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantOrder
{
    public partial class PizzaForm : Form
    {
        public PizzaForm()
        {
            InitializeComponent();
        }

    
       private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (chkExtraChees.Checked)
            {
                lbToppings1.Text = chkExtraChees.Text;

                i += 5;
                lbTotolPrice.Text = Convert.ToString(i);

                

            }
            else

            {
                lbToppings1.Text = "";
                i -= 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }

          

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lbWheretoEat.Text = rbEatIn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Congfreion The Order ", "Confgrion",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                  {
                
                gbCrustType.Enabled = false;

                gbSize.Enabled = false;
                gbToppings.Enabled = false;

                gbWereEat.Enabled = false;
                groupBox1.Enabled = false;

                chkExtraChees.Checked = false;
                chkMushrooms.Checked = false;
                chkOlives.Checked = false;
                chkOnion.Checked = false;
                chkPeppers.Checked = false;
                chkTomatos.Checked = false;
                rbSmall.Checked = false; 
                rbMeduim.Checked = false;
                rbLarg.Checked = false;
                rbThine.Checked = false;
                rbThink.Checked = false;
                lbTotolPrice.Text = "20";
            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = rbSmall.Text;
            int i;
            i= Convert.ToInt32(lbTotolPrice.Text);
          
            if (rbSmall.Checked)
            {
                i += 3;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else
            {
                i-= 3;
                lbTotolPrice.Text = Convert.ToString(i);
            }
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text=rbMeduim.Text;
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (rbMeduim.Checked)
            {
                i += 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else
            {
                i -= 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = rbLarg.Text;
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (rbLarg.Checked)
            {
                i += 10;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else
            {
                i -= 10;
                lbTotolPrice.Text = Convert.ToString(i);
            }
        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {

        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lbWheretoEat.Text = rbTakeOut.Text;
            
            
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (chkOnion.Checked)
            {
                lbToppings2.Text = chkOnion.Text;

                i += 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else

            {
                lbToppings2.Text = "";
                i -= 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (chkMushrooms.Checked)
            {
                lbToppings3.Text = chkMushrooms.Text;

                i += 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else

            {
                lbToppings3.Text = "";
                i -= 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (chkOlives.Checked)
            {
                lbToppings4.Text = chkOlives.Text;

                i += 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else

            {
                lbToppings4.Text = "";
                i -= 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }

        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (chkTomatos.Checked)
            {
                lbToppings5.Text = chkTomatos.Text;

                i += 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else

            {
                lbToppings5.Text = "";
                i -= 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }

        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (chkPeppers.Checked)
            {
                lbToppings6.Text = chkPeppers.Text;

                i += 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else

            {
                lbToppings6.Text = "";
                i -= 5;
                lbTotolPrice.Text = Convert.ToString(i);
            }

        }

        private void lbToppings2_Click(object sender, EventArgs e)
        {

        }

        private void rbThine_CheckedChanged(object sender, EventArgs e)
        {
            lbCrust.Text = rbThine.Text;
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (rbThine.Checked)
            {
                i += 7;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else
            {
                i -= 7;
                lbTotolPrice.Text = Convert.ToString(i);
            }
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            lbCrust.Text = rbThink.Text;
            int i;
            i = Convert.ToInt32(lbTotolPrice.Text);
            if (rbThink.Checked)
            {
                i += 10;
                lbTotolPrice.Text = Convert.ToString(i);
            }
            else
            {
                i -= 10;
                lbTotolPrice.Text = Convert.ToString(i);
            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {

            gbCrustType.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled =true;

            gbWereEat.Enabled = true;
            groupBox1.Enabled = true;
        }
    }
}
