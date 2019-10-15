using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RefrigeratorAppPractice3.Model;

namespace RefrigeratorAppPractice3
{
    public partial class Refrigerator : Form
    {
        RefrigeratorManager refrigerator = new RefrigeratorManager();

        public Refrigerator()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            refrigerator.MaximumWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);

            maxWeightTakeTextBox.Text="";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {


                int NoItem = Convert.ToInt32(itemTextBox.Text);
                double Weight = Convert.ToDouble(weightTextBox.Text);
                if (!(NoItem * Weight > refrigerator.MaximumWeight))
                {
                    refrigerator.NumberOfItem = Convert.ToInt32(itemTextBox.Text);
                    refrigerator.Weight = Convert.ToDouble(weightTextBox.Text);

                    currentWeightTextBox.Text = String.Format("{0:0.00}", refrigerator.CurrentWeight().ToString());
                    remainingWeightTextBox.Text = String.Format("{0:0.00}", refrigerator.RemainingWeight().ToString());
                }
                else
                {
                    MessageBox.Show("Your given Ammount can not entered beacause it will be over flown");
                    return;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
