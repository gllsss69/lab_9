using System;
using System.Windows.Forms;

namespace lab_9
{
    public partial class Form1 : Form
    {
        private const decimal BusFare = 8.00m;
        private const decimal TrolleybusFare = 7.00m;
        private const decimal MetroFare = 6.00m;
        private const decimal PrivilegedDiscount = 0.5m; // 50% off

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal fare = GetSelectedFare();

            if (chkPrivileged.Checked)
            {
                fare = fare * (1 - PrivilegedDiscount);
            }

            lblResult.Text = $"Результат: {fare:F2} UAH";
        }

        private decimal GetSelectedFare()
        {
            if (radioBus.Checked)
                return BusFare;
            if (radioTrolley.Checked)
                return TrolleybusFare;
            if (radioMetro.Checked)
                return MetroFare;

            // fallback
            return BusFare;
        }
    }
}
