namespace WinFormsApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tpCashier = new TabPage();
            btPrintOrder = new Button();
            lbItems = new ListBox();
            btDeleteItem = new Button();
            btEditItem = new Button();
            btAddItem = new Button();
            groupBox1 = new GroupBox();
            lbCurrency = new Label();
            dateTimePicker = new DateTimePicker();
            udQuantity = new NumericUpDown();
            lbDate = new Label();
            lbTotalPrice = new Label();
            tbTotalPrice = new TextBox();
            tbPricePerUnit = new TextBox();
            lbPricePerUnit = new Label();
            lbQuantity = new Label();
            lbName = new Label();
            tbName = new TextBox();
            lbDescription = new Label();
            tbDescription = new TextBox();
            TabPages = new TabControl();
            tpOrders = new TabPage();
            btOrdersDelete = new Button();
            btOrdersView = new Button();
            lbOrders = new ListBox();
            tpCashier.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udQuantity).BeginInit();
            TabPages.SuspendLayout();
            tpOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tpCashier
            // 
            tpCashier.Controls.Add(btPrintOrder);
            tpCashier.Controls.Add(lbItems);
            tpCashier.Controls.Add(btDeleteItem);
            tpCashier.Controls.Add(btEditItem);
            tpCashier.Controls.Add(btAddItem);
            tpCashier.Controls.Add(groupBox1);
            tpCashier.Location = new Point(4, 29);
            tpCashier.Name = "tpCashier";
            tpCashier.Padding = new Padding(3);
            tpCashier.Size = new Size(828, 428);
            tpCashier.TabIndex = 0;
            tpCashier.Text = "Cashier";
            tpCashier.UseVisualStyleBackColor = true;
            // 
            // btPrintOrder
            // 
            btPrintOrder.Enabled = false;
            btPrintOrder.FlatAppearance.BorderColor = Color.Silver;
            btPrintOrder.FlatStyle = FlatStyle.Flat;
            btPrintOrder.Font = new Font("Segoe UI Historic", 20.2909088F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPrintOrder.Location = new Point(6, 255);
            btPrintOrder.Name = "btPrintOrder";
            btPrintOrder.Size = new Size(468, 165);
            btPrintOrder.TabIndex = 5;
            btPrintOrder.Text = "PRINT ORDER";
            btPrintOrder.UseVisualStyleBackColor = true;
            btPrintOrder.Click += onPrintOrder;
            // 
            // lbItems
            // 
            lbItems.BackColor = SystemColors.Menu;
            lbItems.BorderStyle = BorderStyle.None;
            lbItems.Cursor = Cursors.Hand;
            lbItems.Font = new Font("Segoe UI Historic", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItems.FormattingEnabled = true;
            lbItems.ItemHeight = 15;
            lbItems.Location = new Point(480, 15);
            lbItems.Name = "lbItems";
            lbItems.Size = new Size(345, 405);
            lbItems.TabIndex = 4;
            // 
            // btDeleteItem
            // 
            btDeleteItem.BackColor = Color.Tomato;
            btDeleteItem.FlatAppearance.BorderSize = 0;
            btDeleteItem.FlatAppearance.MouseDownBackColor = Color.Tomato;
            btDeleteItem.FlatStyle = FlatStyle.Flat;
            btDeleteItem.Font = new Font("Segoe UI Historic", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeleteItem.Location = new Point(327, 206);
            btDeleteItem.Name = "btDeleteItem";
            btDeleteItem.Size = new Size(147, 43);
            btDeleteItem.TabIndex = 3;
            btDeleteItem.Text = "DELETE ITEM";
            btDeleteItem.UseVisualStyleBackColor = false;
            btDeleteItem.Click += onDeleteButton;
            // 
            // btEditItem
            // 
            btEditItem.BackColor = Color.SkyBlue;
            btEditItem.FlatAppearance.BorderSize = 0;
            btEditItem.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            btEditItem.FlatStyle = FlatStyle.Flat;
            btEditItem.Font = new Font("Segoe UI Historic", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEditItem.Location = new Point(166, 206);
            btEditItem.Name = "btEditItem";
            btEditItem.Size = new Size(147, 43);
            btEditItem.TabIndex = 2;
            btEditItem.Text = "EDIT ITEM";
            btEditItem.UseVisualStyleBackColor = false;
            btEditItem.Click += onEditItem;
            // 
            // btAddItem
            // 
            btAddItem.BackColor = Color.LightGreen;
            btAddItem.FlatAppearance.BorderSize = 0;
            btAddItem.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btAddItem.FlatStyle = FlatStyle.Flat;
            btAddItem.Font = new Font("Segoe UI Historic", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddItem.Location = new Point(6, 206);
            btAddItem.Name = "btAddItem";
            btAddItem.Size = new Size(147, 43);
            btAddItem.TabIndex = 1;
            btAddItem.Text = "ADD ITEM";
            btAddItem.UseVisualStyleBackColor = false;
            btAddItem.Click += onAddItem;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbCurrency);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(udQuantity);
            groupBox1.Controls.Add(lbDate);
            groupBox1.Controls.Add(lbTotalPrice);
            groupBox1.Controls.Add(tbTotalPrice);
            groupBox1.Controls.Add(tbPricePerUnit);
            groupBox1.Controls.Add(lbPricePerUnit);
            groupBox1.Controls.Add(lbQuantity);
            groupBox1.Controls.Add(lbName);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(lbDescription);
            groupBox1.Controls.Add(tbDescription);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item";
            // 
            // lbCurrency
            // 
            lbCurrency.AutoSize = true;
            lbCurrency.Location = new Point(199, 126);
            lbCurrency.Name = "lbCurrency";
            lbCurrency.Size = new Size(40, 20);
            lbCurrency.TabIndex = 13;
            lbCurrency.Text = "UAH";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI Historic", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Location = new Point(91, 156);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(268, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // udQuantity
            // 
            udQuantity.Enabled = false;
            udQuantity.Location = new Point(91, 90);
            udQuantity.Name = "udQuantity";
            udQuantity.Size = new Size(102, 27);
            udQuantity.TabIndex = 3;
            udQuantity.ValueChanged += onQuantityChange;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(0, 161);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(41, 20);
            lbDate.TabIndex = 10;
            lbDate.Text = "Date";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Location = new Point(0, 125);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(79, 20);
            lbTotalPrice.TabIndex = 9;
            lbTotalPrice.Text = "Total Price";
            // 
            // tbTotalPrice
            // 
            tbTotalPrice.BackColor = SystemColors.ButtonHighlight;
            tbTotalPrice.Enabled = false;
            tbTotalPrice.Location = new Point(91, 123);
            tbTotalPrice.Name = "tbTotalPrice";
            tbTotalPrice.ReadOnly = true;
            tbTotalPrice.Size = new Size(102, 27);
            tbTotalPrice.TabIndex = 5;
            // 
            // tbPricePerUnit
            // 
            tbPricePerUnit.Enabled = false;
            tbPricePerUnit.Location = new Point(313, 89);
            tbPricePerUnit.Name = "tbPricePerUnit";
            tbPricePerUnit.Size = new Size(149, 27);
            tbPricePerUnit.TabIndex = 4;
            tbPricePerUnit.TextChanged += onPricePerUnitChange;
            // 
            // lbPricePerUnit
            // 
            lbPricePerUnit.AutoSize = true;
            lbPricePerUnit.Location = new Point(209, 92);
            lbPricePerUnit.Name = "lbPricePerUnit";
            lbPricePerUnit.Size = new Size(98, 20);
            lbPricePerUnit.TabIndex = 6;
            lbPricePerUnit.Text = "Price per Unit";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(0, 92);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(65, 20);
            lbQuantity.TabIndex = 5;
            lbQuantity.Text = "Quantity";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(0, 28);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 3;
            lbName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(91, 25);
            tbName.Name = "tbName";
            tbName.Size = new Size(371, 27);
            tbName.TabIndex = 1;
            tbName.TextChanged += onNameChange;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(0, 60);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(85, 20);
            lbDescription.TabIndex = 1;
            lbDescription.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(91, 57);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(371, 27);
            tbDescription.TabIndex = 2;
            // 
            // TabPages
            // 
            TabPages.Controls.Add(tpCashier);
            TabPages.Controls.Add(tpOrders);
            TabPages.Cursor = Cursors.Hand;
            TabPages.Font = new Font("Segoe UI Symbol", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPages.Location = new Point(-4, -1);
            TabPages.Multiline = true;
            TabPages.Name = "TabPages";
            TabPages.SelectedIndex = 0;
            TabPages.Size = new Size(836, 461);
            TabPages.TabIndex = 0;
            TabPages.Tag = "";
            // 
            // tpOrders
            // 
            tpOrders.BorderStyle = BorderStyle.Fixed3D;
            tpOrders.Controls.Add(btOrdersDelete);
            tpOrders.Controls.Add(btOrdersView);
            tpOrders.Controls.Add(lbOrders);
            tpOrders.Font = new Font("Segoe UI Historic", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpOrders.Location = new Point(4, 29);
            tpOrders.Name = "tpOrders";
            tpOrders.Size = new Size(828, 428);
            tpOrders.TabIndex = 2;
            tpOrders.Text = "Orders";
            tpOrders.UseVisualStyleBackColor = true;
            // 
            // btOrdersDelete
            // 
            btOrdersDelete.BackColor = Color.Red;
            btOrdersDelete.FlatAppearance.BorderSize = 0;
            btOrdersDelete.FlatStyle = FlatStyle.Flat;
            btOrdersDelete.Font = new Font("Segoe UI Historic", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btOrdersDelete.Location = new Point(625, 357);
            btOrdersDelete.Name = "btOrdersDelete";
            btOrdersDelete.Size = new Size(184, 59);
            btOrdersDelete.TabIndex = 2;
            btOrdersDelete.Text = "Delete";
            btOrdersDelete.UseVisualStyleBackColor = false;
            btOrdersDelete.Click += onOrdersDelete;
            // 
            // btOrdersView
            // 
            btOrdersView.BackColor = SystemColors.ActiveCaption;
            btOrdersView.FlatAppearance.BorderSize = 0;
            btOrdersView.FlatStyle = FlatStyle.Flat;
            btOrdersView.Font = new Font("Segoe UI Historic", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btOrdersView.Location = new Point(435, 357);
            btOrdersView.Name = "btOrdersView";
            btOrdersView.Size = new Size(184, 59);
            btOrdersView.TabIndex = 1;
            btOrdersView.Text = "View/Edit";
            btOrdersView.UseVisualStyleBackColor = false;
            btOrdersView.MouseClick += onOrderView;
            // 
            // lbOrders
            // 
            lbOrders.FormattingEnabled = true;
            lbOrders.ItemHeight = 20;
            lbOrders.Location = new Point(-4, -1);
            lbOrders.Name = "lbOrders";
            lbOrders.Size = new Size(836, 344);
            lbOrders.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 456);
            Controls.Add(TabPages);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Application";
            tpCashier.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udQuantity).EndInit();
            TabPages.ResumeLayout(false);
            tpOrders.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tpCashier;
        private TabPage tpOrders;
        private ListBox lbItems;
        private Button btDeleteItem;
        private Button btEditItem;
        private Button btAddItem;
        private GroupBox groupBox1;
        private Label lbCurrency;
        private DateTimePicker dateTimePicker;
        private NumericUpDown udQuantity;
        private Label lbDate;
        private Label lbTotalPrice;
        private TextBox tbTotalPrice;
        private TextBox tbPricePerUnit;
        private Label lbPricePerUnit;
        private Label lbQuantity;
        private Label lbName;
        private TextBox tbName;
        private Label lbDescription;
        private TextBox tbDescription;
        private TabControl TabPages;
        private Button btPrintOrder;
        private ListBox lbOrders;
        private Button btOrdersView;
        private Button btOrdersDelete;
    }
}
