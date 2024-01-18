using WinFormsApp.Domain;

namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        List<Item> ItemsList = new List<Item>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void updateItemsList()
        {
            Items.DataSource = null;
            Items.DataSource = ItemsList;
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
                if (dateTimePicker.Value > DateTime.Today)
                    throw new Exception("Can't place an ItemsList in the future!");

                var item = new Item(tbName.Text, tbDescription.Text, Int32.Parse(tbPricePerUnit.Text), (int)udQuantity.Value, dateTimePicker.Value);


                ItemsList.Add(item);
                updateItemsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void onEditItem(object sender, EventArgs e)
        {
            var index = Items.SelectedIndex;
            var item = (Item)Items.SelectedItem;

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
            ItemsList.Remove(ItemsList[Items.SelectedIndex]);
            updateItemsList();
        }

        private void onPrintOrder(object sender, EventArgs e)
        {

        }

    }
}
