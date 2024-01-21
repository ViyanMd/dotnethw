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
            gbStation = new GroupBox();
            gbStationToPay = new GroupBox();
            lbStationTotalAmount = new Label();
            lbStationTotalCurrency = new Label();
            label2 = new Label();
            label1 = new Label();
            tbInputAmount = new TextBox();
            tbInputLiters = new TextBox();
            gbRadio = new GroupBox();
            rbAmount = new RadioButton();
            rbQuantity = new RadioButton();
            tbFuelPrice = new TextBox();
            lbCurrency = new Label();
            lbFuelPrice = new Label();
            lbFuel = new Label();
            cmFuelType = new ComboBox();
            gbMiniCafe = new GroupBox();
            gbCafeToPay = new GroupBox();
            lbCafeTotalAmount = new Label();
            lbCafeTotalCurrency = new Label();
            udAmountCocaCola = new NumericUpDown();
            udAmountFries = new NumericUpDown();
            udAmountHamburger = new NumericUpDown();
            udAmountHotDog = new NumericUpDown();
            tbPriceCocaCola = new TextBox();
            tbPriceFries = new TextBox();
            tbPriceHamburger = new TextBox();
            tbPriceHotDog = new TextBox();
            lbCafeQuantity = new Label();
            lbCafePrices = new Label();
            cbCocaCola = new CheckBox();
            cbFries = new CheckBox();
            cbHamburger = new CheckBox();
            cbHotDog = new CheckBox();
            gbCheckout = new GroupBox();
            btCount = new Button();
            lbOrderTotalAmount = new Label();
            lbOrderTotalCurrency = new Label();
            gbStation.SuspendLayout();
            gbStationToPay.SuspendLayout();
            gbRadio.SuspendLayout();
            gbMiniCafe.SuspendLayout();
            gbCafeToPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udAmountCocaCola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udAmountFries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udAmountHamburger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udAmountHotDog).BeginInit();
            gbCheckout.SuspendLayout();
            SuspendLayout();
            // 
            // gbStation
            // 
            gbStation.BackColor = Color.LightGray;
            gbStation.Controls.Add(gbStationToPay);
            gbStation.Controls.Add(label2);
            gbStation.Controls.Add(label1);
            gbStation.Controls.Add(tbInputAmount);
            gbStation.Controls.Add(tbInputLiters);
            gbStation.Controls.Add(gbRadio);
            gbStation.Controls.Add(tbFuelPrice);
            gbStation.Controls.Add(lbCurrency);
            gbStation.Controls.Add(lbFuelPrice);
            gbStation.Controls.Add(lbFuel);
            gbStation.Controls.Add(cmFuelType);
            gbStation.Font = new Font("Microsoft Tai Le", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbStation.Location = new Point(12, 12);
            gbStation.Name = "gbStation";
            gbStation.Size = new Size(290, 366);
            gbStation.TabIndex = 0;
            gbStation.TabStop = false;
            gbStation.Text = "Gas Station";
            // 
            // gbStationToPay
            // 
            gbStationToPay.Controls.Add(lbStationTotalAmount);
            gbStationToPay.Controls.Add(lbStationTotalCurrency);
            gbStationToPay.Location = new Point(6, 253);
            gbStationToPay.Name = "gbStationToPay";
            gbStationToPay.Size = new Size(278, 107);
            gbStationToPay.TabIndex = 10;
            gbStationToPay.TabStop = false;
            gbStationToPay.Text = "To Pay";
            // 
            // lbStationTotalAmount
            // 
            lbStationTotalAmount.AutoSize = true;
            lbStationTotalAmount.Font = new Font("Microsoft Tai Le", 20.2909088F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStationTotalAmount.Location = new Point(89, 39);
            lbStationTotalAmount.Name = "lbStationTotalAmount";
            lbStationTotalAmount.Size = new Size(79, 40);
            lbStationTotalAmount.TabIndex = 12;
            lbStationTotalAmount.Text = "0.00";
            // 
            // lbStationTotalCurrency
            // 
            lbStationTotalCurrency.AutoSize = true;
            lbStationTotalCurrency.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStationTotalCurrency.Location = new Point(229, 54);
            lbStationTotalCurrency.Name = "lbStationTotalCurrency";
            lbStationTotalCurrency.Size = new Size(40, 19);
            lbStationTotalCurrency.TabIndex = 11;
            lbStationTotalCurrency.Text = "UAH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 156);
            label2.Name = "label2";
            label2.Size = new Size(16, 19);
            label2.TabIndex = 9;
            label2.Text = "L";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 208);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 8;
            label1.Text = "UAH";
            // 
            // tbInputAmount
            // 
            tbInputAmount.Font = new Font("Microsoft Tai Le", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbInputAmount.Location = new Point(145, 204);
            tbInputAmount.Name = "tbInputAmount";
            tbInputAmount.Size = new Size(84, 25);
            tbInputAmount.TabIndex = 7;
            // 
            // tbInputLiters
            // 
            tbInputLiters.Font = new Font("Microsoft Tai Le", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbInputLiters.Location = new Point(145, 152);
            tbInputLiters.Name = "tbInputLiters";
            tbInputLiters.Size = new Size(84, 25);
            tbInputLiters.TabIndex = 6;
            // 
            // gbRadio
            // 
            gbRadio.Controls.Add(rbAmount);
            gbRadio.Controls.Add(rbQuantity);
            gbRadio.Location = new Point(6, 134);
            gbRadio.Name = "gbRadio";
            gbRadio.Size = new Size(133, 102);
            gbRadio.TabIndex = 5;
            gbRadio.TabStop = false;
            // 
            // rbAmount
            // 
            rbAmount.AutoSize = true;
            rbAmount.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAmount.Location = new Point(6, 70);
            rbAmount.Name = "rbAmount";
            rbAmount.Size = new Size(80, 23);
            rbAmount.TabIndex = 1;
            rbAmount.TabStop = true;
            rbAmount.Text = "Amount";
            rbAmount.UseVisualStyleBackColor = true;
            // 
            // rbQuantity
            // 
            rbQuantity.AutoSize = true;
            rbQuantity.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbQuantity.Location = new Point(6, 18);
            rbQuantity.Name = "rbQuantity";
            rbQuantity.Size = new Size(83, 23);
            rbQuantity.TabIndex = 0;
            rbQuantity.TabStop = true;
            rbQuantity.Text = "Quantity";
            rbQuantity.UseVisualStyleBackColor = true;
            // 
            // tbFuelPrice
            // 
            tbFuelPrice.BackColor = SystemColors.Window;
            tbFuelPrice.Enabled = false;
            tbFuelPrice.Font = new Font("Microsoft Tai Le", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFuelPrice.Location = new Point(95, 79);
            tbFuelPrice.Name = "tbFuelPrice";
            tbFuelPrice.Size = new Size(134, 25);
            tbFuelPrice.TabIndex = 4;
            // 
            // lbCurrency
            // 
            lbCurrency.AutoSize = true;
            lbCurrency.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCurrency.Location = new Point(235, 85);
            lbCurrency.Name = "lbCurrency";
            lbCurrency.Size = new Size(40, 19);
            lbCurrency.TabIndex = 3;
            lbCurrency.Text = "UAH";
            // 
            // lbFuelPrice
            // 
            lbFuelPrice.AutoSize = true;
            lbFuelPrice.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFuelPrice.Location = new Point(6, 85);
            lbFuelPrice.Name = "lbFuelPrice";
            lbFuelPrice.Size = new Size(41, 19);
            lbFuelPrice.TabIndex = 2;
            lbFuelPrice.Text = "Price";
            // 
            // lbFuel
            // 
            lbFuel.AutoSize = true;
            lbFuel.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFuel.Location = new Point(6, 35);
            lbFuel.Name = "lbFuel";
            lbFuel.Size = new Size(72, 19);
            lbFuel.TabIndex = 1;
            lbFuel.Text = "Fuel Type";
            // 
            // cmFuelType
            // 
            cmFuelType.Font = new Font("Microsoft Tai Le", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmFuelType.FormattingEnabled = true;
            cmFuelType.Location = new Point(95, 29);
            cmFuelType.Name = "cmFuelType";
            cmFuelType.Size = new Size(134, 26);
            cmFuelType.TabIndex = 0;
            // 
            // gbMiniCafe
            // 
            gbMiniCafe.BackColor = Color.LightGray;
            gbMiniCafe.Controls.Add(gbCafeToPay);
            gbMiniCafe.Controls.Add(udAmountCocaCola);
            gbMiniCafe.Controls.Add(udAmountFries);
            gbMiniCafe.Controls.Add(udAmountHamburger);
            gbMiniCafe.Controls.Add(udAmountHotDog);
            gbMiniCafe.Controls.Add(tbPriceCocaCola);
            gbMiniCafe.Controls.Add(tbPriceFries);
            gbMiniCafe.Controls.Add(tbPriceHamburger);
            gbMiniCafe.Controls.Add(tbPriceHotDog);
            gbMiniCafe.Controls.Add(lbCafeQuantity);
            gbMiniCafe.Controls.Add(lbCafePrices);
            gbMiniCafe.Controls.Add(cbCocaCola);
            gbMiniCafe.Controls.Add(cbFries);
            gbMiniCafe.Controls.Add(cbHamburger);
            gbMiniCafe.Controls.Add(cbHotDog);
            gbMiniCafe.Font = new Font("Microsoft Tai Le", 11.7818184F, FontStyle.Bold);
            gbMiniCafe.Location = new Point(308, 12);
            gbMiniCafe.Name = "gbMiniCafe";
            gbMiniCafe.Size = new Size(290, 366);
            gbMiniCafe.TabIndex = 1;
            gbMiniCafe.TabStop = false;
            gbMiniCafe.Text = "Mini Cafe";
            // 
            // gbCafeToPay
            // 
            gbCafeToPay.Controls.Add(lbCafeTotalAmount);
            gbCafeToPay.Controls.Add(lbCafeTotalCurrency);
            gbCafeToPay.Location = new Point(6, 253);
            gbCafeToPay.Name = "gbCafeToPay";
            gbCafeToPay.Size = new Size(278, 107);
            gbCafeToPay.TabIndex = 13;
            gbCafeToPay.TabStop = false;
            gbCafeToPay.Text = "To Pay";
            // 
            // lbCafeTotalAmount
            // 
            lbCafeTotalAmount.AutoSize = true;
            lbCafeTotalAmount.Font = new Font("Microsoft Tai Le", 20.2909088F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCafeTotalAmount.Location = new Point(89, 39);
            lbCafeTotalAmount.Name = "lbCafeTotalAmount";
            lbCafeTotalAmount.Size = new Size(79, 40);
            lbCafeTotalAmount.TabIndex = 12;
            lbCafeTotalAmount.Text = "0.00";
            // 
            // lbCafeTotalCurrency
            // 
            lbCafeTotalCurrency.AutoSize = true;
            lbCafeTotalCurrency.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCafeTotalCurrency.Location = new Point(229, 54);
            lbCafeTotalCurrency.Name = "lbCafeTotalCurrency";
            lbCafeTotalCurrency.Size = new Size(40, 19);
            lbCafeTotalCurrency.TabIndex = 11;
            lbCafeTotalCurrency.Text = "UAH";
            // 
            // udAmountCocaCola
            // 
            udAmountCocaCola.Location = new Point(215, 150);
            udAmountCocaCola.Name = "udAmountCocaCola";
            udAmountCocaCola.Size = new Size(64, 30);
            udAmountCocaCola.TabIndex = 16;
            // 
            // udAmountFries
            // 
            udAmountFries.Location = new Point(215, 117);
            udAmountFries.Name = "udAmountFries";
            udAmountFries.Size = new Size(64, 30);
            udAmountFries.TabIndex = 15;
            // 
            // udAmountHamburger
            // 
            udAmountHamburger.Location = new Point(215, 84);
            udAmountHamburger.Name = "udAmountHamburger";
            udAmountHamburger.Size = new Size(64, 30);
            udAmountHamburger.TabIndex = 14;
            // 
            // udAmountHotDog
            // 
            udAmountHotDog.Location = new Point(215, 51);
            udAmountHotDog.Name = "udAmountHotDog";
            udAmountHotDog.Size = new Size(64, 30);
            udAmountHotDog.TabIndex = 13;
            // 
            // tbPriceCocaCola
            // 
            tbPriceCocaCola.Enabled = false;
            tbPriceCocaCola.Location = new Point(141, 149);
            tbPriceCocaCola.Name = "tbPriceCocaCola";
            tbPriceCocaCola.Size = new Size(54, 30);
            tbPriceCocaCola.TabIndex = 12;
            // 
            // tbPriceFries
            // 
            tbPriceFries.Enabled = false;
            tbPriceFries.Location = new Point(141, 116);
            tbPriceFries.Name = "tbPriceFries";
            tbPriceFries.Size = new Size(54, 30);
            tbPriceFries.TabIndex = 11;
            // 
            // tbPriceHamburger
            // 
            tbPriceHamburger.Enabled = false;
            tbPriceHamburger.Location = new Point(141, 83);
            tbPriceHamburger.Name = "tbPriceHamburger";
            tbPriceHamburger.Size = new Size(54, 30);
            tbPriceHamburger.TabIndex = 10;
            // 
            // tbPriceHotDog
            // 
            tbPriceHotDog.Enabled = false;
            tbPriceHotDog.Location = new Point(141, 50);
            tbPriceHotDog.Name = "tbPriceHotDog";
            tbPriceHotDog.Size = new Size(54, 30);
            tbPriceHotDog.TabIndex = 9;
            // 
            // lbCafeQuantity
            // 
            lbCafeQuantity.AutoSize = true;
            lbCafeQuantity.Font = new Font("Microsoft Tai Le", 7.85454559F);
            lbCafeQuantity.Location = new Point(215, 29);
            lbCafeQuantity.Name = "lbCafeQuantity";
            lbCafeQuantity.Size = new Size(53, 16);
            lbCafeQuantity.TabIndex = 8;
            lbCafeQuantity.Text = "Quantity";
            lbCafeQuantity.Click += lbCafeQuantity_Click;
            // 
            // lbCafePrices
            // 
            lbCafePrices.AutoSize = true;
            lbCafePrices.Font = new Font("Microsoft Tai Le", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCafePrices.Location = new Point(141, 29);
            lbCafePrices.Name = "lbCafePrices";
            lbCafePrices.Size = new Size(33, 16);
            lbCafePrices.TabIndex = 7;
            lbCafePrices.Text = "Price";
            lbCafePrices.Click += label4_Click;
            // 
            // cbCocaCola
            // 
            cbCocaCola.AutoSize = true;
            cbCocaCola.Font = new Font("Microsoft Tai Le", 9.818182F);
            cbCocaCola.Location = new Point(19, 154);
            cbCocaCola.Name = "cbCocaCola";
            cbCocaCola.Size = new Size(97, 23);
            cbCocaCola.TabIndex = 6;
            cbCocaCola.Text = "Coca-Cola";
            cbCocaCola.UseVisualStyleBackColor = true;
            // 
            // cbFries
            // 
            cbFries.AutoSize = true;
            cbFries.Font = new Font("Microsoft Tai Le", 9.818182F);
            cbFries.Location = new Point(19, 121);
            cbFries.Name = "cbFries";
            cbFries.Size = new Size(58, 23);
            cbFries.TabIndex = 5;
            cbFries.Text = "Fries";
            cbFries.UseVisualStyleBackColor = true;
            // 
            // cbHamburger
            // 
            cbHamburger.AutoSize = true;
            cbHamburger.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbHamburger.Location = new Point(19, 88);
            cbHamburger.Name = "cbHamburger";
            cbHamburger.Size = new Size(104, 23);
            cbHamburger.TabIndex = 4;
            cbHamburger.Text = "Hamburger";
            cbHamburger.UseVisualStyleBackColor = true;
            // 
            // cbHotDog
            // 
            cbHotDog.AutoSize = true;
            cbHotDog.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbHotDog.Location = new Point(19, 55);
            cbHotDog.Name = "cbHotDog";
            cbHotDog.Size = new Size(88, 23);
            cbHotDog.TabIndex = 3;
            cbHotDog.Text = "Hot-Dog";
            cbHotDog.UseVisualStyleBackColor = true;
            // 
            // gbCheckout
            // 
            gbCheckout.BackColor = Color.LightGray;
            gbCheckout.Controls.Add(lbOrderTotalAmount);
            gbCheckout.Controls.Add(lbOrderTotalCurrency);
            gbCheckout.Controls.Add(btCount);
            gbCheckout.Font = new Font("Microsoft Tai Le", 11.7818184F, FontStyle.Bold);
            gbCheckout.Location = new Point(12, 384);
            gbCheckout.Name = "gbCheckout";
            gbCheckout.Size = new Size(586, 129);
            gbCheckout.TabIndex = 2;
            gbCheckout.TabStop = false;
            gbCheckout.Text = "Checkout";
            // 
            // btCount
            // 
            btCount.BackColor = SystemColors.GradientActiveCaption;
            btCount.FlatAppearance.BorderSize = 0;
            btCount.FlatStyle = FlatStyle.Flat;
            btCount.Location = new Point(6, 29);
            btCount.Name = "btCount";
            btCount.Size = new Size(183, 94);
            btCount.TabIndex = 0;
            btCount.Text = "COUNT";
            btCount.UseVisualStyleBackColor = false;
            // 
            // lbOrderTotalAmount
            // 
            lbOrderTotalAmount.AutoSize = true;
            lbOrderTotalAmount.Font = new Font("Microsoft Tai Le", 20.2909088F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrderTotalAmount.Location = new Point(333, 53);
            lbOrderTotalAmount.Name = "lbOrderTotalAmount";
            lbOrderTotalAmount.Size = new Size(79, 40);
            lbOrderTotalAmount.TabIndex = 14;
            lbOrderTotalAmount.Text = "0.00";
            // 
            // lbOrderTotalCurrency
            // 
            lbOrderTotalCurrency.AutoSize = true;
            lbOrderTotalCurrency.Font = new Font("Microsoft Tai Le", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbOrderTotalCurrency.Location = new Point(473, 68);
            lbOrderTotalCurrency.Name = "lbOrderTotalCurrency";
            lbOrderTotalCurrency.Size = new Size(40, 19);
            lbOrderTotalCurrency.TabIndex = 13;
            lbOrderTotalCurrency.Text = "UAH";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(609, 525);
            Controls.Add(gbCheckout);
            Controls.Add(gbMiniCafe);
            Controls.Add(gbStation);
            Name = "FormMain";
            Text = "BestOil";
            gbStation.ResumeLayout(false);
            gbStation.PerformLayout();
            gbStationToPay.ResumeLayout(false);
            gbStationToPay.PerformLayout();
            gbRadio.ResumeLayout(false);
            gbRadio.PerformLayout();
            gbMiniCafe.ResumeLayout(false);
            gbMiniCafe.PerformLayout();
            gbCafeToPay.ResumeLayout(false);
            gbCafeToPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udAmountCocaCola).EndInit();
            ((System.ComponentModel.ISupportInitialize)udAmountFries).EndInit();
            ((System.ComponentModel.ISupportInitialize)udAmountHamburger).EndInit();
            ((System.ComponentModel.ISupportInitialize)udAmountHotDog).EndInit();
            gbCheckout.ResumeLayout(false);
            gbCheckout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbStation;
        private GroupBox gbMiniCafe;
        private GroupBox gbCheckout;
        private ComboBox cmFuelType;
        private Label lbCurrency;
        private Label lbFuelPrice;
        private Label lbFuel;
        private GroupBox gbRadio;
        private RadioButton rbAmount;
        private RadioButton rbQuantity;
        private TextBox tbFuelPrice;
        private Label label2;
        private Label label1;
        private TextBox tbInputAmount;
        private TextBox tbInputLiters;
        private GroupBox gbStationToPay;
        private Label lbStationTotalAmount;
        private Label lbStationTotalCurrency;
        private CheckBox cbCocaCola;
        private CheckBox cbFries;
        private CheckBox cbHamburger;
        private CheckBox cbHotDog;
        private Label lbCafeQuantity;
        private Label lbCafePrices;
        private TextBox tbPriceHamburger;
        private TextBox tbPriceHotDog;
        private GroupBox gbCafeToPay;
        private Label lbCafeTotalAmount;
        private Label lbCafeTotalCurrency;
        private NumericUpDown udAmountCocaCola;
        private NumericUpDown udAmountFries;
        private NumericUpDown udAmountHamburger;
        private NumericUpDown udAmountHotDog;
        private TextBox tbPriceCocaCola;
        private TextBox tbPriceFries;
        private Button btCount;
        private Label lbOrderTotalAmount;
        private Label lbOrderTotalCurrency;
    }
}
