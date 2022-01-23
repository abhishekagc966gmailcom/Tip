using System.Globalization;
namespace TipCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Class1 tipCalcfunc = new Class1();
        private void billamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
}




        private void tippercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }



        private void numberofpeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }








        


        

        private void increment_Click(object sender, EventArgs e)
        {
            tipCalcfunc.textboxValue = billamount.Text;

            if (string.IsNullOrEmpty(billamount.Text))
            {
                tipCalcfunc.d = 0.00;

            }
            else
            {
                tipCalcfunc.d = double.Parse(tipCalcfunc.textboxValue);
            }


            //// Retrieve as decimal
            //decimal valueDec = decimal.Parse(textboxValue);
            tipCalcfunc.d += 1.00;
            tipCalcfunc.textboxValue = tipCalcfunc.d.ToString();
            billamount.Text = tipCalcfunc.textboxValue;


        }

        private void decrement_Click(object sender, EventArgs e)
        {
            tipCalcfunc.textboxValue = billamount.Text;

            if (string.IsNullOrEmpty(billamount.Text))
            {
                tipCalcfunc.d = 0.00;

            }
            else
            {
                tipCalcfunc.d = double.Parse(tipCalcfunc.textboxValue);
            }



            if (tipCalcfunc.d >= 1)
            {
                tipCalcfunc.d -= 1.00;
            }
            tipCalcfunc.textboxValue = tipCalcfunc.d.ToString();
            billamount.Text = tipCalcfunc.textboxValue;

        }

        private void incrementpercent_Click(object sender, EventArgs e)
        {

            tipCalcfunc.tip_percent = tippercent.Text;

            if (string.IsNullOrEmpty(tippercent.Text))
            {
                tipCalcfunc.tip_percent_double = 0.00;

            }
            else
            {
                tipCalcfunc.tip_percent_double = double.Parse(tipCalcfunc.tip_percent);
            }


            if (tipCalcfunc.tip_percent_double <= 99)
            {
                tipCalcfunc.tip_percent_double += 1.00;
            }

            tipCalcfunc.tip_percent = tipCalcfunc.tip_percent_double.ToString();
            tippercent.Text = tipCalcfunc.tip_percent;

        }

        private void decrementpercent_Click(object sender, EventArgs e)
        {
            tipCalcfunc.tip_percent = tippercent.Text;
            

            if (string.IsNullOrEmpty(tippercent.Text))
            {
                tipCalcfunc.tip_percent_double = 0.00;

            }

            else if((tipCalcfunc.tip_percent_double = double.Parse(tipCalcfunc.tip_percent))>100.00)
            {
                MessageBox.Show("Tip % cannot exceed 100%");
               
                    
               
             
            }


         

            if (tipCalcfunc.tip_percent_double >= 1 && tipCalcfunc.tip_percent_double<=100.00)
            {
                tipCalcfunc.tip_percent_double -= 1.00;
            }
            tipCalcfunc.tip_percent = tipCalcfunc.tip_percent_double.ToString();
            tippercent.Text = tipCalcfunc.tip_percent;

        }

        private void incrementppl_Click(object sender, EventArgs e)
        {

            tipCalcfunc.no_of_ppl = numberofpeople.Text;

            if (string.IsNullOrEmpty(numberofpeople.Text))
            {
                tipCalcfunc.no_of_ppl_int = 1;

            }
            
            else
            {
                try
                {
                    tipCalcfunc.no_of_ppl_int = int.Parse(tipCalcfunc.no_of_ppl);
                }
                catch (Exception) {
                MessageBox.Show("Way Too More people");
                    return;
                }


                tipCalcfunc.no_of_ppl_int += 1;


            }
          


            tipCalcfunc.no_of_ppl = tipCalcfunc.no_of_ppl_int.ToString();
            numberofpeople.Text = tipCalcfunc.no_of_ppl;

        }

        private void decrementppl_Click(object sender, EventArgs e)
        {
            tipCalcfunc.no_of_ppl = numberofpeople.Text;

            if (string.IsNullOrEmpty(numberofpeople.Text))
            {
                tipCalcfunc.no_of_ppl_int = 0;

            }
            else
            {
                try
                {
                    tipCalcfunc.no_of_ppl_int = int.Parse(tipCalcfunc.no_of_ppl);
                }
                catch (Exception)
                {
                    MessageBox.Show("Way Too More people");
                    return;
                }
                
            }


          
            if (tipCalcfunc.no_of_ppl_int >= 1)
            {
                tipCalcfunc.no_of_ppl_int -= 1;

            }

            tipCalcfunc.no_of_ppl = tipCalcfunc.no_of_ppl_int.ToString();
            numberofpeople.Text = tipCalcfunc.no_of_ppl;

        }



        private void calculate_Click_1(object sender, EventArgs e)
        {
            //If conditions below handles the case if No input is provided
            //we set the value to its given default value

            if (string.IsNullOrEmpty(billamount.Text))
            {
                billamount.Text="0.00";
            }
            if (string.IsNullOrEmpty(tippercent.Text))
            {

                tippercent.Text = "0.00";
            }
            if (string.IsNullOrEmpty(numberofpeople.Text))
            {
                numberofpeople.Text = "1";
            }


            
            tipCalcfunc.d=double.Parse(billamount.Text);
            tipCalcfunc.tip_percent_double=double.Parse(tippercent.Text);
            
          
                try
                {
                    tipCalcfunc.no_of_ppl_int = int.Parse(numberofpeople.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Number of people is Way too large");
                }
           
            
            //If block below handles the case if tip percent is exceeding 100%
            //Pops a message and exits the function

            if (tipCalcfunc.tip_percent_double > 100.00)
            {
                MessageBox.Show("Maximum Tip Cannot exceed Bill Amount\nPlease decrease Tip %");
                return;
            }

            double value= tipCalcfunc.findTipAmount(tipCalcfunc.d, tipCalcfunc.tip_percent_double, tipCalcfunc.no_of_ppl_int);
            double totalbill = tipCalcfunc.d + value;

            double totalbillperperson=0.00;

            //if number of people is zero then value will not be calculated
            if (tipCalcfunc.no_of_ppl_int == 0)
            {
                MessageBox.Show("Number of Person Should be Greater Than Zero");
                return;
              
            }
            else {
                totalbillperperson = totalbill / tipCalcfunc.no_of_ppl_int;
                tipCalcfunc.tipPerPerson = (value / tipCalcfunc.no_of_ppl_int);
            }
   
        
            CultureInfo culture;
            string specifier = "G";
            culture = CultureInfo.CreateSpecificCulture("eu-ES");
            
            tipperpersonlabel.Text = "$ "+tipCalcfunc.tipPerPerson.ToString(specifier,CultureInfo.InvariantCulture);
            totalperperson.Text="$ "+totalbillperperson.ToString(specifier,CultureInfo.InvariantCulture);
           


        }


        //This method is executed when clear button is pressed in application
        //Resets all the values to Zero

        private void clear_Click(object sender, EventArgs e)
        {
            billamount.Text = "0.00";
            tippercent.Text = "0.00";
            numberofpeople.Text = "0";
            tipperpersonlabel.Text = "0.00";
            totalperperson.Text= "0.00";
        }
    }
}