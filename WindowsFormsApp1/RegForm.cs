using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void ComputeCost_CheckedChanged(object sender, EventArgs e)
        {
            decimal cost = 0;
            this.lblMsg.Text = " ";
            if (this.chBxSwim.Checked)
            {
                cost += 50;
            }
            if (this.chBxSnorkel.Checked)
            {
                cost += 25;
            }
            if (this.chBxDive.Checked)
            {
                cost += 100;
            }
            this.txtBxResult.Text = cost.ToString("C");

            if (this.radBeginner.Checked)
            {
                cost += 10;
                this.lblMsg.Text = "**Beginner -- $10 extra**";

            }
            else

                if (this.radAdvanced.Checked)
            {
                cost -= 15;
                this.lblMsg.Text = "**Advanced -- Discount $15**";
            }
            else
            {
                this.lblMsg.Text = "";
            }
            this.txtBxResult.Text = "Total :" + cost.ToString("C");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string finalResult =GetInstructor() + GetNumLesson() + txtBxResult.Text;

            MessageBox.Show(finalResult);
        }


        private string GetNumLesson()
        {
            string results = "Number of Lessons :";
            if (cmbLessons.SelectedIndex >= 0)
            {
                results += cmbLessons.SelectedItem + "\n";

            }
            else
            {
                results = "Please select lesson quantity! \n";
            }
            return results;
        }

        private string GetInstructor()
        {
            string results = "Instructor:";
            if (lstInstructor.SelectedItems.Count > 0)
            {
                results += lstInstructor.SelectedItem + "\n";
            }
            else
            {
                results = "**No Instructor Selected**\n";
            }

            return results;
        }
    }
    
 }
