using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kukushkinProject3A
{
    public partial class frmDebtRatio : Form
    {
        public frmDebtRatio()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtLiability.Text) < 0)
                    throw new Exception("Liabilities and Assets cannot be negative!");
            }
           
            catch (Exception NegativeValue)
            {
                MessageBox.Show("Values cannot be negative.");
                txtLiability.Clear();
                txtAssets.Clear();
               
                txtLiability.Focus();
            }
            
            try
            {
                decimal liability = Convert.ToDecimal(txtLiability.Text);
                decimal assets = Convert.ToDecimal(txtAssets.Text);

                decimal debtPercent = liability / assets;

                string fullName = txtName.Text.Trim();
                int firstBlank = fullName.IndexOf(" ");
                int lastChar = fullName.Length;
                
                string lastName = "";
                if (firstBlank == -1)
                    lastName = fullName;
                else
                    lastName = fullName.Substring(firstBlank + 1);

                MessageBox.Show("Mr. " + lastName + ", your Debt Ratio is " + debtPercent.ToString("p1"));
                
            }
            catch(FormatException)
            {
                MessageBox.Show(
                    "Please enter numeric values that represent" + "\n" + "currency as Liabilities and Assets", 
                    "Format Error");
                txtLiability.Clear();
                txtAssets.Clear();
                txtLiability.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "One of the amounts is too large." + "\n" + "Please enter a lower sum.",
                    "Overflow Error");
                txtLiability.Clear();
                txtAssets.Clear();
                txtLiability.Focus();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(
                    "Assets cannot be Zero." + "\n" + "Please adjust your entry.",
                    "ZeroDivision Error");
                txtLiability.Clear();
                txtAssets.Clear();
                txtLiability.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                txtLiability.Clear();
                txtAssets.Clear();
                txtLiability.Focus();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAssets_Click(object sender, EventArgs e)
        {

        }

        private void frmDebtRatio_Load(object sender, EventArgs e)
        {

        }
    }
}
