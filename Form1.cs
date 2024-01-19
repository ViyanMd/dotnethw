using WinFormsApp.Domain;

namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        private List<Item> ItemsList = new List<Item>();
        private List<Order> OrdersList = new List<Order>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void updateItemsList()
        {
            lbItems.DataSource = null;
            lbItems.DataSource = ItemsList;
        }

        private void updateOrdersList()
        {
            lbOrders.DataSource = null;
            lbOrders.DataSource = OrdersList;
        }

        private void onNameChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text))
            {
                udQuantity.Value = 0;
                udQuantity.Enabled = false;
            }
            else
            {
                udQuantity.Enabled = true;
            }
        }

        private void onQuantityChange(object sender, EventArgs e)
        {
            if (udQuantity.Value != 0)
            {
                tbPricePerUnit.Enabled = true;
                if (!String.IsNullOrEmpty(tbPricePerUnit.Text))
                    tbTotalPrice.Text = ((int)udQuantity.Value * Int32.Parse(tbPricePerUnit.Text)).ToString();
            }
        }

        private void onPricePerUnitChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPricePerUnit.Text))
                tbTotalPrice.Text = "0";
            else
                tbTotalPrice.Text = ((int)udQuantity.Value * Int32.Parse(tbPricePerUnit.Text)).ToString();
        }
        private void onAddItem(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbName.Text))
                    throw new Exception("Name is empty!");
                if (String.IsNullOrEmpty(tbDescription.Text))
                    throw new Exception("Description is missing!");
                if (udQuantity.Value == 0)
                    throw new Exception("Quantity not specified!");
                if (String.IsNullOrEmpty(tbPricePerUnit.Text))
                    throw new Exception("Price Per Unit is missing!");

                var item = new Item(tbName.Text, tbDescription.Text, Int32.Parse(tbPricePerUnit.Text), (int)udQuantity.Value, dateTimePicker.Value);


                ItemsList.Add(item);
                updateItemsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ItemsList.Count > 0)
                btPrintOrder.Enabled = true;
        }
        private void onEditItem(object sender, EventArgs e)
        {
            var index = lbItems.SelectedIndex;
            var item = (Item)lbItems.SelectedItem;

            try
            {
                item.ChangeName(tbName.Text);
                item.ChangeDescription(tbDescription.Text);
                item.ChangeQuantity((int)udQuantity.Value);
                item.ChangePrice(Int32.Parse(tbPricePerUnit.Text));
                item.ChangeDate(dateTimePicker.Value);

                ItemsList[index] = item;

                updateItemsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void onDeleteButton(object sender, EventArgs e)
        {
            ItemsList.Remove(ItemsList[lbItems.SelectedIndex]);
            updateItemsList();
        }

        private void onPrintOrder(object sender, EventArgs e)
        {
            if (lbItems.Items.Count == 0)
                MessageBox.Show("Order is empty. Please, add some items", "Opps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Order order = new Order(ItemsList, dateTimePicker.Value);
                OrdersList.Add(order);

                updateOrdersList();

                MessageBox.Show("Order has been placed! To view or modify it, go to 'Orders' tab.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void onOrderView(object sender, MouseEventArgs e)
        {
            var selectedItem = (Order)lbOrders.SelectedItem;

            if (lbOrders.SelectedItem == null)
            {
                MessageBox.Show("No order selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                ItemsList = selectedItem.getOrderList();

                updateItemsList();

                TabPages.SelectedTab = TabPages.TabPages["tpCashier"];
            }
        }

        private void onOrdersDelete(object sender, EventArgs e)
        {
            if (lbOrders.SelectedItem == null)
            {
                MessageBox.Show("List is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var index = lbOrders.SelectedIndex;
                OrdersList.RemoveAt(index);
                updateOrdersList();
            }

        }
    }
}
