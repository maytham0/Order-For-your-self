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
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            Form Frm1 = new PizzaForm();
            Frm1.ShowDialog();
        }

  
    }
}
