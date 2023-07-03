using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RitenDuo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //simple interest
        float defaultRate = 10;
        int defaultYears = 1;
        float defaultPrincipal = 1;

        //compound interest
        float defaultCompoundRate = 9;
        float defaultCapital = 0;

        public MainWindow()
        {
            InitializeComponent();

            TxtSimpleInterest.Text = GetInterestString();
            HandleAboutFormulae();
            HandleAboutInfo();
        }

        private void HandleAboutFormulae()
        {
            string SimpleString = "Simple Interest (SI): \n\n"+
                "\tSI=P*R*T\n"+
                "\t\tPrincipal: Currency\n\t\tRate: (%)\n\t\tT: Time (in Years)\n\n";

            string CompoundString = "Compound Interest (CI): \n\n"+
                "\t1. A = P(1 + r/n)^nt\n"+
                "\t2. CI=A - P\n"+
                "\t\tA: Amount\n\t\tP: Principal\n\t\tr: Rate (%)\n\t\tn: Frequency\n"+
                "\t\tt: Time (in Years)";

            lblFormulae.Text = SimpleString+"\n"+CompoundString;

        }

        private void HandleAboutInfo()
        {

            string info = "'Riten' means 'benefit' in Japanese."+
                "I am not good at naming things, so this will have to do for now.\n\n"+
                "Version: 0.2.0\n"+
                "Built: July 4th 2023\n\n"+
                "In: CSharp (WPF) \n"+
                "By: Amina Kombo (www.aminakombo.work)\n"+
                "GitHub Repo: https://github.com/KomboAmina/Riten";

            lblAbout.Text = info;

        }

        private float GetRate()
        {

            float rate;

            if (float.TryParse(TxtRate.Text, out rate))
            {

                if (rate<0 || rate>100) {
                    rate = defaultRate;
                    TxtRate.Text = defaultRate.ToString();
                }

                return rate;
            }
            else
            {
                TxtRate.Text = defaultRate.ToString();
                return defaultRate;
            }

        }

        private float GetPrincipal()
        {
            float principal;

            if (float.TryParse(TxtPrincipal.Text, out principal)) {
                if (principal<0) {
                    principal = defaultPrincipal;
                    TxtPrincipal.Text = defaultPrincipal.ToString();
                }
                return principal;
            }
            else {
                return defaultPrincipal;
            }

        }

        private float GetRawSavings()
        {

            float principal = GetPrincipal();
            int years = 12*GetYears();

            return years * principal;

        }

        private int GetYears()
        {

            int years;

            if (Int32.TryParse(TxtTime.Text, out years))
            {
                return years;
            }
            else
            {
                TxtTime.Text = defaultYears.ToString();
                return defaultYears;
            }

        }

        private float GetSimpleInterest()
        {

            float rate = GetRate();
            float principal = GetPrincipal();
            int years = GetYears();

            float simpleInterest=principal * rate * years;
            return simpleInterest / 100;

        }

        private void ShowSimpleInterest()
        {
            TxtSimpleInterest.Text = GetInterestString();
            TxtSimpleGain.Text = GetSimpleGainString();

        }

        private void TxtPrincipal_TextChanged(object sender, TextChangedEventArgs e)
        {
            float principal = GetPrincipal();
        }

        private void TxtRate_TextChanged(object sender, TextChangedEventArgs e)
        {
            float rate = GetRate();
        }

        private void TxtTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            int year = GetYears();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            ShowSimpleInterest();
        }

        private string GetInterestString()
        {

            string interestString;

            float simpleInterest = GetSimpleInterest();

            interestString = FormatDouble(Convert.ToDouble(simpleInterest));

            return interestString;

        }

        private string GetSimpleGainString()
        {
            float simpleInterest = GetSimpleInterest();
            float rawSavings = GetRawSavings();
            double total = simpleInterest + rawSavings;
            return "Raw Savings: "+FormatDouble(Convert.ToDouble(rawSavings))+
                "\nTotal (with Interest): "+
                FormatDouble(Convert.ToDouble(total));
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            TxtPrincipal.Text = defaultPrincipal.ToString();
            TxtRate.Text = defaultRate.ToString();
            TxtTime.Text = defaultYears.ToString();
            ShowSimpleInterest();
        }

        private float GetCompoundPrincipal()
        {
            float principal;

            if (float.TryParse(TxtPrincipalC.Text, out principal)) {

                if (principal<0) {
                    principal = defaultPrincipal;
                    TxtPrincipalC.Text = principal.ToString();
                }

                return principal;
            }
            else {
                principal = defaultPrincipal;
                TxtPrincipalC.Text = principal.ToString();
                return defaultPrincipal;
            }

        }

        private float GetCapital()
        {

            float capital;

            if (float.TryParse(TxtCapitalC.Text, out capital)) {
                return capital;
            }
            else
            {
                TxtCapitalC.Text = defaultCapital.ToString();
                return defaultCapital;
            }

        }

        private float GetCompoundRate()
        {

            float rate;

            if (float.TryParse(TxtRateC.Text, out rate))
            {

                if (rate < 0 || rate > 100)
                {
                    rate = defaultRate;
                    TxtRateC.Text = defaultRate.ToString();
                }

                return rate;
            }
            else
            {
                TxtRateC.Text = defaultRate.ToString();
                return defaultRate;
            }

        }

        private int GetCompoundYears()
        {

            int years;

            if (Int32.TryParse(TxtTimeC.Text, out years))
            {
                return years;
            }
            else
            {
                TxtTimeC.Text = defaultYears.ToString();
                return defaultYears;
            }

        }

        private int GetFrequency()
        {
            int frequency=1;
            string chosen = CmbFrequency.Text;

            switch (chosen) {
                case "Annually":
                    frequency = 1;
                    break;
                case "Semiannually":
                    frequency = 2;
                    break;
                case "Quarterly":
                    frequency = 4;
                    break;
                case "Monthly":
                    frequency = 12;
                    break;
                case "Daily":
                    frequency = 365;
                    break;
            }

            return frequency;
        }

        private void TxtPrincipalC_TextChanged(object sender, TextChangedEventArgs e)
        {
            float principal = GetCompoundPrincipal();
        }

        private void TxtCapitalC_TextChanged(object sender, TextChangedEventArgs e)
        {
            float capital = GetCapital();
        }

        private void TxtRateC_TextChanged(object sender, TextChangedEventArgs e)
        {
            float rate = GetCompoundRate();
        }

        private void TxtTimeC_TextChanged(object sender, TextChangedEventArgs e)
        {
            int year = GetCompoundYears();
        }

        private double GetCompoundInterest()
        {

            double compoundInterest=0;
            float principal = GetCompoundPrincipal();
            float rate = GetCompoundRate();
            int years = GetCompoundYears();
            int n = GetFrequency();
            //n=1

            //A = P(1+r/n)^nt
            
            int raisePower = n * years;

            if (raisePower>0) {

                /*for (int x=1; x<=years; x++) {

                    double calcRate = (rate/100) / n;
                    cinter=Convert.ToDouble(1+calcRate);

                    compoundInterest+=principal*(Math.Pow(cinter,raisePower));

                }*/
                compoundInterest = (principal*Math.Pow((1+(rate/(n*100))),raisePower));

            }

            compoundInterest -= principal;

            return compoundInterest;

        }

        private double GetRawCompoundSavings()
        {

            double savings = 0;
            float capital = GetCapital();

            int years = GetCompoundYears();
            double principal = GetCompoundPrincipal();
            int frequency = GetFrequency();

            savings = capital+Convert.ToDouble(principal*years*frequency);

            return savings;

        }

        private string FormatDouble(double rawVal=0.00) {

            return String.Format("{0:0.000}",rawVal);

        }

        private void ShowCompoundInterest()
        {
            double compoundInterest = GetCompoundInterest();
            double principal = GetCompoundPrincipal();
            double capital = GetCapital();
            TxtCompoundInterest.Text = FormatDouble(compoundInterest+principal);

            double total = Convert.ToDouble(compoundInterest+GetRawCompoundSavings()+capital);

            TxtCompoundGain.Text = "Compound Interest: "+FormatDouble(compoundInterest)+
                "\nTotal: "+FormatDouble(total)+
                "\nRaw Savings: "+FormatDouble(GetRawCompoundSavings());

        }

        private void BtnCalculateC_Click(object sender, RoutedEventArgs e)
        {
            ShowCompoundInterest();
        }
    }
}
