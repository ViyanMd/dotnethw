using WinFormsApp.Domain;

namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        Fuel fuel = new Fuel();
        double stationTotal = 0.00;
        double cafeTotal = 0.00;
        List<Order> AllOrders = new List<Order>();
        public FormMain()
        {
            InitializeComponent();
        }
        private void onMainFormLoad(object sender, EventArgs e)
        {
            fuel.Add("95", 25.00);
            fuel.Add("92", 23.00);
            fuel.Add("80", 20.00);

            cmFuelType.SelectedIndex = 0;
            var selectedItem = cmFuelType.SelectedItem.ToString();
            tbFuelPrice.Text = fuel.GetPrice(selectedItem).ToString();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void lbCafeQuantity_Click(object sender, EventArgs e)
        {

        }
        private void onValueChanged(object sender, EventArgs e)
        {
            var selectedItemPrice = fuel.GetPrice(cmFuelType.SelectedItem.ToString());

            if (String.IsNullOrEmpty(selectedItemPrice.ToString()))
                MessageBox.Show("Fuel type is wrong!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                tbFuelPrice.Text = selectedItemPrice.ToString();

        }

        private void onQuantityCheckedChanged(object sender, EventArgs e)
        {
            if (rbQuantity.Checked)
            {
                tbInputLiters.Enabled = true;
                tbInputAmount.Enabled = false;
            }
        }

        private void onAmountCheckedChanged(object sender, EventArgs e)
        {
            if (rbAmount.Checked)
            {
                tbInputLiters.Enabled = false;
                tbInputAmount.Enabled = true;
            }
        }
        private void onQuantityChanged(object sender, EventArgs e)
        {
            var fuelPrice = Double.Parse(tbFuelPrice.Text);
            var liters = Double.Parse(tbInputLiters.Text);
            lbStationTotalAmount.Text = (fuelPrice * liters).ToString();
        }
        private void onAmountChanged(object sender, EventArgs e)
        {
            var totalAmount = Double.Parse(tbInputAmount.Text);
            var pricePerLiter = Double.Parse(tbFuelPrice.Text);
            tbInputLiters.Text = (totalAmount / pricePerLiter).ToString();
            lbStationTotalAmount.Text = totalAmount.ToString("F2");
        }

        private void onFriesCheckedChanged(object sender, EventArgs e)
        {
            if (cbFries.Checked)
                udAmountFries.Enabled = true;
            else
                udAmountFries.Enabled = false;

        }

        private void onHDCheckedChanged(object sender, EventArgs e)
        {
            if (cbHotDog.Checked)
                udAmountHotDog.Enabled = true;
            else
                udAmountHotDog.Enabled = false;
        }

        private void onHamburgerCheckedChanged(object sender, EventArgs e)
        {
            if (cbHamburger.Checked)
                udAmountHamburger.Enabled = true;
            else
                udAmountHamburger.Enabled = false;
        }

        private void onCocaColaCheckedChanged(object sender, EventArgs e)
        {
            if (cbCocaCola.Checked)
                udAmountCocaCola.Enabled = true;
            else
                udAmountCocaCola.Enabled = false;
        }


        private void onCount(object sender, EventArgs e)
        {
            stationTotal = Double.Parse(lbStationTotalAmount.Text);

            cafeTotal += Double.Parse(udAmountHotDog.Value.ToString()) * Double.Parse(tbPriceHotDog.Text);
            cafeTotal += Double.Parse(udAmountHamburger.Value.ToString()) * Double.Parse(tbPriceHamburger.Text);
            cafeTotal += Double.Parse(udAmountFries.Value.ToString()) * Double.Parse(tbPriceFries.Text);
            cafeTotal += Double.Parse(udAmountCocaCola.Value.ToString()) * Double.Parse(tbPriceCocaCola.Text);

            AllOrders.Add(new Order(stationTotal + cafeTotal));

            MessageBox.Show($"Success! Total is {stationTotal}");
        }

        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var totalForSession = 0.0;
            foreach (var item in AllOrders)
                totalForSession += item.TotalAmount;

            MessageBox.Show($"Total income: {totalForSession}", "Bye!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
