using WinFormsApp.Domain;

namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        FuelCollection fuels = new FuelCollection();
        List<Order> sessionOrders = new List<Order>();
        public FormMain()
        {
            InitializeComponent();
        }
        private void updateFuelPrice()
        {
            Fuel selectedFuel = fuels.fuelsList[cmFuelType.SelectedItem.ToString()];
            tbFuelPrice.Text = selectedFuel.GetPrice().ToString("F2");
        }

        private void updateStationTotalAmount(string amount)
        {
            lbStationTotalAmount.Text = amount;
            lbOrderTotalAmount.Text = (Double.Parse(lbStationTotalAmount.Text) + Double.Parse(lbCafeTotalAmount.Text)).ToString("F2");
        }
        private void updateCafeTotalAmount()
        {
            var hotdogAmount = udAmountHotDog.Value;
            var hamburgerAmount = udAmountHamburger.Value;
            var friesAmount = udAmountFries.Value;
            var cocaColaAmount = udAmountCocaCola.Value;

            var totalCafeAmount = hotdogAmount * 35 + hamburgerAmount * 50 + friesAmount * 10 + cocaColaAmount * 12;

            lbCafeTotalAmount.Text = totalCafeAmount.ToString("F2");
            lbOrderTotalAmount.Text = (Double.Parse(lbStationTotalAmount.Text) + Double.Parse(lbCafeTotalAmount.Text)).ToString("F2");
        }
        private void onMainFormLoad(object sender, EventArgs e)
        {
            var fuelTypes = new List<string>();

            fuels.AddFuel(new Fuel("98", 30.00));
            fuels.AddFuel(new Fuel("95", 25.60));
            fuels.AddFuel(new Fuel("92", 22.90));
            fuels.AddFuel(new Fuel("80", 25.00));

            foreach (string fuelType in fuels.fuelsList.Keys)
                fuelTypes.Add(fuelType);

            cmFuelType.DataSource = fuelTypes;
            cmFuelType.Update();

            updateFuelPrice();
        }
        private void onFuelTypeValueChanged(object sender, EventArgs e)
        {
            updateFuelPrice();
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
            if (String.IsNullOrEmpty(tbInputLiters.Text))
            {
                MessageBox.Show("Can't be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbInputLiters.Text = "0.00";
            }
            else
            {
                var fuelPrice = Double.Parse(tbFuelPrice.Text);
                var liters = Double.Parse(tbInputLiters.Text);
                updateStationTotalAmount((fuelPrice * liters).ToString("F2"));
            }
        }
        private void onAmountChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbInputAmount.Text))
            {
                MessageBox.Show("Can't be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbInputAmount.Text = "0.00";
            }
            else
            {
                var totalAmount = Double.Parse(tbInputAmount.Text);
                var pricePerLiter = Double.Parse(tbFuelPrice.Text);
                tbInputLiters.Text = (totalAmount / pricePerLiter).ToString("F2");
                updateStationTotalAmount(totalAmount.ToString("F2"));
            }
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
        private void onHotDogQuantityChanged(object sender, EventArgs e)
        {
            var hotdogQuantity = udAmountHotDog.Value;

            if (hotdogQuantity < 0)
            {
                MessageBox.Show("Field can't be less than 0!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                udAmountHotDog.Value = 0;
            }
            else
            {
                updateCafeTotalAmount();
            }
        }
        private void onHamburgerQuantityChanged(object sender, EventArgs e)
        {
            var hamburgerQuantity = udAmountHamburger.Value;

            if (hamburgerQuantity < 0)
            {
                MessageBox.Show("Field can't be less than 0!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                udAmountHamburger.Value = 0;
            }
            else
            {
                updateCafeTotalAmount();
            }
        }
        private void onFriesQuantityChanged(object sender, EventArgs e)
        {
            var friesQuantity = udAmountFries.Value;

            if (friesQuantity < 0)
            {
                MessageBox.Show("Field can't be less than 0!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                udAmountFries.Value = 0;
            }
            else
            {
                updateCafeTotalAmount();
            }
        }
        private void onCocaColaQuantityChanged(object sender, EventArgs e)
        {
            var cocaColaQuantity = udAmountCocaCola.Value;

            if (cocaColaQuantity < 0)
            {
                MessageBox.Show("Field can't be less than 0!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                udAmountCocaCola.Value = 0;
            }
            else
            {
                updateCafeTotalAmount();
            }
        }
        private void onCount(object sender, EventArgs e)
        {
            var stationTotal = Double.Parse(lbCafeTotalAmount.Text);
            var cafeTotal = Double.Parse(lbStationTotalAmount.Text);

            if(stationTotal <= 0 && cafeTotal <= 0)
            {
                MessageBox.Show("Order is empty!\nPlease, add some items.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                var newOrder = new Order(stationTotal + cafeTotal);
                sessionOrders.Add(newOrder);

                MessageBox.Show("Order added successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            var totalForSession = 0.0;
            foreach (var item in sessionOrders)
                totalForSession += item.TotalAmount;

            MessageBox.Show($"Total income: {totalForSession}", "Bye!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
