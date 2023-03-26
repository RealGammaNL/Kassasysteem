namespace Kassasysteem
{
    partial class Cashregister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZuivelButton = new System.Windows.Forms.Button();
            this.GroenteButton = new System.Windows.Forms.Button();
            this.FruitButton = new System.Windows.Forms.Button();
            this.DrankButton = new System.Windows.Forms.Button();
            this.KaasButton = new System.Windows.Forms.Button();
            this.VleesButton = new System.Windows.Forms.Button();
            this.DelProdButton = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.BroodButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DelLineButton = new System.Windows.Forms.Button();
            this.placeholderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.PriceTotal = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.listview1 = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ZuivelButton
            // 
            this.ZuivelButton.Location = new System.Drawing.Point(369, 31);
            this.ZuivelButton.Margin = new System.Windows.Forms.Padding(2);
            this.ZuivelButton.Name = "ZuivelButton";
            this.ZuivelButton.Size = new System.Drawing.Size(100, 100);
            this.ZuivelButton.TabIndex = 0;
            this.ZuivelButton.Text = "Zuivel";
            this.ZuivelButton.UseVisualStyleBackColor = true;
            this.ZuivelButton.Click += new System.EventHandler(this.switchPanel);
            // 
            // GroenteButton
            // 
            this.GroenteButton.Location = new System.Drawing.Point(475, 31);
            this.GroenteButton.Margin = new System.Windows.Forms.Padding(2);
            this.GroenteButton.Name = "GroenteButton";
            this.GroenteButton.Size = new System.Drawing.Size(100, 100);
            this.GroenteButton.TabIndex = 2;
            this.GroenteButton.Text = "Groente";
            this.GroenteButton.UseVisualStyleBackColor = true;
            this.GroenteButton.Click += new System.EventHandler(this.switchPanel);
            // 
            // FruitButton
            // 
            this.FruitButton.Location = new System.Drawing.Point(581, 31);
            this.FruitButton.Margin = new System.Windows.Forms.Padding(2);
            this.FruitButton.Name = "FruitButton";
            this.FruitButton.Size = new System.Drawing.Size(100, 100);
            this.FruitButton.TabIndex = 3;
            this.FruitButton.Text = "Fruit";
            this.FruitButton.UseVisualStyleBackColor = true;
            this.FruitButton.Click += new System.EventHandler(this.switchPanel);
            // 
            // DrankButton
            // 
            this.DrankButton.Location = new System.Drawing.Point(899, 31);
            this.DrankButton.Margin = new System.Windows.Forms.Padding(2);
            this.DrankButton.Name = "DrankButton";
            this.DrankButton.Size = new System.Drawing.Size(100, 100);
            this.DrankButton.TabIndex = 15;
            this.DrankButton.Text = "Drank";
            this.DrankButton.UseVisualStyleBackColor = true;
            this.DrankButton.Click += new System.EventHandler(this.switchPanel);
            // 
            // KaasButton
            // 
            this.KaasButton.Location = new System.Drawing.Point(793, 31);
            this.KaasButton.Margin = new System.Windows.Forms.Padding(2);
            this.KaasButton.Name = "KaasButton";
            this.KaasButton.Size = new System.Drawing.Size(100, 100);
            this.KaasButton.TabIndex = 14;
            this.KaasButton.Text = "Kaas";
            this.KaasButton.UseVisualStyleBackColor = true;
            this.KaasButton.Click += new System.EventHandler(this.switchPanel);
            // 
            // VleesButton
            // 
            this.VleesButton.Location = new System.Drawing.Point(687, 31);
            this.VleesButton.Margin = new System.Windows.Forms.Padding(2);
            this.VleesButton.Name = "VleesButton";
            this.VleesButton.Size = new System.Drawing.Size(100, 100);
            this.VleesButton.TabIndex = 13;
            this.VleesButton.Text = "Vlees";
            this.VleesButton.UseVisualStyleBackColor = true;
            this.VleesButton.Click += new System.EventHandler(this.switchPanel);
            // 
            // DelProdButton
            // 
            this.DelProdButton.Location = new System.Drawing.Point(6, 277);
            this.DelProdButton.Margin = new System.Windows.Forms.Padding(2);
            this.DelProdButton.Name = "DelProdButton";
            this.DelProdButton.Size = new System.Drawing.Size(80, 80);
            this.DelProdButton.TabIndex = 25;
            this.DelProdButton.Text = "Delete Product";
            this.DelProdButton.UseVisualStyleBackColor = true;
            this.DelProdButton.Click += new System.EventHandler(this.DelProdButton_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(90, 277);
            this.button25.Margin = new System.Windows.Forms.Padding(2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(80, 80);
            this.button25.TabIndex = 26;
            this.button25.Text = "1";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(174, 277);
            this.button26.Margin = new System.Windows.Forms.Padding(2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(80, 80);
            this.button26.TabIndex = 27;
            this.button26.Text = "2";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(174, 361);
            this.button27.Margin = new System.Windows.Forms.Padding(2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(80, 80);
            this.button27.TabIndex = 30;
            this.button27.Text = "5";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(90, 361);
            this.button28.Margin = new System.Windows.Forms.Padding(2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(80, 80);
            this.button28.TabIndex = 29;
            this.button28.Text = "4";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(174, 445);
            this.button30.Margin = new System.Windows.Forms.Padding(2);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(80, 80);
            this.button30.TabIndex = 33;
            this.button30.Text = "8";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(90, 445);
            this.button31.Margin = new System.Windows.Forms.Padding(2);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(80, 80);
            this.button31.TabIndex = 32;
            this.button31.Text = "7";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(90, 529);
            this.button34.Margin = new System.Windows.Forms.Padding(2);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(80, 80);
            this.button34.TabIndex = 34;
            this.button34.Text = "x";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(174, 529);
            this.button36.Margin = new System.Windows.Forms.Padding(2);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(80, 80);
            this.button36.TabIndex = 36;
            this.button36.Text = "0";
            this.button36.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(258, 529);
            this.button37.Margin = new System.Windows.Forms.Padding(2);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(80, 80);
            this.button37.TabIndex = 40;
            this.button37.Text = ".";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(258, 445);
            this.button38.Margin = new System.Windows.Forms.Padding(2);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(80, 80);
            this.button38.TabIndex = 39;
            this.button38.Text = "9";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(258, 361);
            this.button39.Margin = new System.Windows.Forms.Padding(2);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(80, 80);
            this.button39.TabIndex = 38;
            this.button39.Text = "6";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(258, 277);
            this.button40.Margin = new System.Windows.Forms.Padding(2);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(80, 80);
            this.button40.TabIndex = 37;
            this.button40.Text = "3";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // BroodButton
            // 
            this.BroodButton.Location = new System.Drawing.Point(1005, 31);
            this.BroodButton.Margin = new System.Windows.Forms.Padding(2);
            this.BroodButton.Name = "BroodButton";
            this.BroodButton.Size = new System.Drawing.Size(100, 100);
            this.BroodButton.TabIndex = 47;
            this.BroodButton.Text = "Brood";
            this.BroodButton.UseVisualStyleBackColor = true;
            this.BroodButton.Click += new System.EventHandler(this.switchPanel);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(6, 529);
            this.CheckoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(80, 80);
            this.CheckoutButton.TabIndex = 54;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 445);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(80, 80);
            this.ClearButton.TabIndex = 53;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DelLineButton
            // 
            this.DelLineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelLineButton.Location = new System.Drawing.Point(6, 361);
            this.DelLineButton.Margin = new System.Windows.Forms.Padding(2);
            this.DelLineButton.Name = "DelLineButton";
            this.DelLineButton.Size = new System.Drawing.Size(80, 80);
            this.DelLineButton.TabIndex = 52;
            this.DelLineButton.Text = "Delete Line";
            this.DelLineButton.UseVisualStyleBackColor = true;
            this.DelLineButton.Click += new System.EventHandler(this.DelLineButton_Click);
            // 
            // placeholderPanel
            // 
            this.placeholderPanel.Location = new System.Drawing.Point(363, 138);
            this.placeholderPanel.Name = "placeholderPanel";
            this.placeholderPanel.Size = new System.Drawing.Size(745, 464);
            this.placeholderPanel.TabIndex = 75;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(11, 15);
            this.OrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(33, 13);
            this.OrderLabel.TabIndex = 76;
            this.OrderLabel.Text = "Order";
            // 
            // PriceTotal
            // 
            this.PriceTotal.AutoSize = true;
            this.PriceTotal.Location = new System.Drawing.Point(289, 15);
            this.PriceTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceTotal.Name = "PriceTotal";
            this.PriceTotal.Size = new System.Drawing.Size(37, 13);
            this.PriceTotal.TabIndex = 77;
            this.PriceTotal.Text = "€ 0.00";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(227, 15);
            this.TotalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(58, 13);
            this.TotalPriceLabel.TabIndex = 78;
            this.TotalPriceLabel.Text = "Total Price";
            // 
            // listview1
            // 
            this.listview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Amount,
            this.Price});
            this.listview1.FullRowSelect = true;
            this.listview1.GridLines = true;
            this.listview1.HideSelection = false;
            this.listview1.Location = new System.Drawing.Point(6, 31);
            this.listview1.Name = "listview1";
            this.listview1.Size = new System.Drawing.Size(332, 241);
            this.listview1.TabIndex = 79;
            this.listview1.UseCompatibleStateImageBehavior = false;
            this.listview1.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 179;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 70;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Price.Width = 72;
            // 
            // Cashregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 613);
            this.Controls.Add(this.listview1);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.PriceTotal);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.placeholderPanel);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DelLineButton);
            this.Controls.Add(this.BroodButton);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.DelProdButton);
            this.Controls.Add(this.DrankButton);
            this.Controls.Add(this.KaasButton);
            this.Controls.Add(this.VleesButton);
            this.Controls.Add(this.FruitButton);
            this.Controls.Add(this.GroenteButton);
            this.Controls.Add(this.ZuivelButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cashregister";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cashregister_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZuivelButton;
        private System.Windows.Forms.Button GroenteButton;
        private System.Windows.Forms.Button FruitButton;
        private System.Windows.Forms.Button DrankButton;
        private System.Windows.Forms.Button KaasButton;
        private System.Windows.Forms.Button VleesButton;
        private System.Windows.Forms.Button DelProdButton;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button BroodButton;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DelLineButton;
        private System.Windows.Forms.FlowLayoutPanel placeholderPanel;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Label PriceTotal;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.ListView listview1;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Price;
    }
}

