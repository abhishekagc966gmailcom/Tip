using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalc
{
    internal class Class1
    {
        //these two values are for bill amount
        public string textboxValue="";
        public double d;

        //these two values are for tip percent
        public string tip_percent="";
        public double tip_percent_double;

        //these two values are for tip percent
        public string no_of_ppl="";
        public int no_of_ppl_int;

        //This variable stores tipPerPerson
        public double tipPerPerson = 0;

        

        //Method used to calculate  total tip amount
        public  double findTipAmount(double billAmount,double tipPercent,int totalPerson)
        {

            double totalTipAmount= billAmount*tipPercent;
            totalTipAmount /=100;
            

            

            return totalTipAmount;

        }
        



        }
}
