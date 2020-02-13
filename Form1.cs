using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4b
{
    public partial class frmRandom : Form
    {
        Random generator = new Random();

        
        int maxI;
        int minI;
        int randNumI;
        double randNumD;
        string randIS;
        double newDub;
        double finalDub;
        int zero;
        
      

        public frmRandom()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            
            maxI = System.Convert.ToInt32(txtMax.Text);
            minI = System.Convert.ToInt32(txtMin.Text);
            randNumI = generator.Next(minI, maxI);
            randIS = System.Convert.ToString(randNumI);
            lblNum.Text = randIS;
            
        
        }

        private void btnDbl_Click(object sender, EventArgs e)
        {
            
            maxI = System.Convert.ToInt32(txtMax.Text);
            minI = System.Convert.ToInt32(txtMin.Text);
            randNumI = generator.Next(minI, maxI);
            newDub = generator.NextDouble();
            randNumD = System.Convert.ToDouble(randNumI);
            zero = generator.Next(0, 2);
            finalDub = ((randNumD * newDub) + zero);
            randIS = System.Convert.ToString(finalDub);
            lblNum.Text = randIS;
            
          
        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }
    }
}
