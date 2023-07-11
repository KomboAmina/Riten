using Riten021.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riten021
{
    public partial class RitenWindow : Form
    {

        private RitenParser ritenParser=new RitenParser();

        public RitenWindow()
        {
            InitializeComponent();

            cmbFrequency.SelectedItem = "Monthly";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string FormatDouble(double rawVal = 0.00)
        {

            return String.Format("{0:0.000}", rawVal);

        }

        private void btnSimpleGenerate_Click(object sender, EventArgs e)
        {

            double simplePrincipal = ritenParser.getDouble(txtSimplePrincipal.Text);

            txtSimplePrincipal.Text = FormatDouble(simplePrincipal);

            double simpleRate = ritenParser.getFormattedRate(txtSimpleRate.Text);

            txtSimpleRate.Text = FormatDouble((simpleRate*100));

            int simpleTime = ritenParser.getInteger(txtSimpleTime.Text);

            txtSimpleTime.Text = simpleTime.ToString();

            SimpleInterest interester = new SimpleInterest(simplePrincipal, simpleRate, simpleTime);

            double simpleInterest = interester.getSimpleInterest();

            lblSimpleInterest.Text = FormatDouble(simpleInterest);

            double totalAmount = (simpleInterest>0) ? simpleInterest+simplePrincipal:0;

            lblSimpleTotal.Text = FormatDouble(totalAmount);

            double simpleFull = totalAmount + (simplePrincipal*simpleTime);

            lblSimpleFull.Text = FormatDouble(simpleFull);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double amount = ritenParser.getDouble(txtCompoundInitial.Text);

            txtCompoundInitial.Text = FormatDouble(amount);

            double deposit = ritenParser.getDouble(txtCompoundDeposit.Text);

            txtCompoundDeposit.Text = FormatDouble(deposit);

            double rate = ritenParser.getFormattedRate(txtCompoundRate.Text)*100;

            txtCompoundRate.Text = FormatDouble(rate);

            int years = ritenParser.getInteger(txtCompoundTime.Text);

            txtCompoundTime.Text = years.ToString();

            int frequency = ritenParser.getNumericalFrequency(cmbFrequency.Text);

            CompoundInterest interester = new CompoundInterest(deposit,rate,years,frequency);

            double compoundInterest = interester.getCompoundInterest();

            lblCompoundInterest.Text = FormatDouble(compoundInterest);

            double totalCompoundAmount = (compoundInterest>0) ? amount + compoundInterest + deposit:amount;

            lblCompoundTotal.Text = FormatDouble(totalCompoundAmount);

            double compoundFull = totalCompoundAmount+(deposit*frequency*years);

            lblCompoundFull.Text = FormatDouble(compoundFull);

        }
    }
}
