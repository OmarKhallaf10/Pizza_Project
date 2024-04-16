namespace Pizza_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gpPizzSize = new System.Windows.Forms.GroupBox();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMidum = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.gpCrustSize = new System.Windows.Forms.GroupBox();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.rdThick = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chbGreenPapper = new System.Windows.Forms.CheckBox();
            this.chbTomatos = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbMashroom = new System.Windows.Forms.CheckBox();
            this.chbExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbSummry = new System.Windows.Forms.GroupBox();
            this.lblWehreToEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.labl3 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gpPizzSize.SuspendLayout();
            this.gpCrustSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbSummry.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(217, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gpPizzSize
            // 
            this.gpPizzSize.BackColor = System.Drawing.Color.DarkOrange;
            this.gpPizzSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpPizzSize.Controls.Add(this.rdLarge);
            this.gpPizzSize.Controls.Add(this.rdMidum);
            this.gpPizzSize.Controls.Add(this.rdSmall);
            this.gpPizzSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpPizzSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpPizzSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpPizzSize.Location = new System.Drawing.Point(76, 162);
            this.gpPizzSize.Name = "gpPizzSize";
            this.gpPizzSize.Size = new System.Drawing.Size(210, 142);
            this.gpPizzSize.TabIndex = 10;
            this.gpPizzSize.TabStop = false;
            this.gpPizzSize.Text = "Size";
            this.gpPizzSize.Enter += new System.EventHandler(this.gpPizzSize_Enter);
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(10, 116);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(63, 20);
            this.rdLarge.TabIndex = 7;
            this.rdLarge.Tag = "40";
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // rdMidum
            // 
            this.rdMidum.AutoSize = true;
            this.rdMidum.Checked = true;
            this.rdMidum.Location = new System.Drawing.Point(10, 77);
            this.rdMidum.Name = "rdMidum";
            this.rdMidum.Size = new System.Drawing.Size(68, 20);
            this.rdMidum.TabIndex = 6;
            this.rdMidum.TabStop = true;
            this.rdMidum.Tag = "30";
            this.rdMidum.Text = "Midum";
            this.rdMidum.UseVisualStyleBackColor = true;
            this.rdMidum.CheckedChanged += new System.EventHandler(this.rdMidum_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(10, 38);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(62, 20);
            this.rdSmall.TabIndex = 5;
            this.rdSmall.Tag = "20";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // gpCrustSize
            // 
            this.gpCrustSize.Controls.Add(this.rdThin);
            this.gpCrustSize.Controls.Add(this.rdThick);
            this.gpCrustSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpCrustSize.Location = new System.Drawing.Point(76, 374);
            this.gpCrustSize.Name = "gpCrustSize";
            this.gpCrustSize.Size = new System.Drawing.Size(215, 123);
            this.gpCrustSize.TabIndex = 11;
            this.gpCrustSize.TabStop = false;
            this.gpCrustSize.Text = "Crust Type";
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Checked = true;
            this.rdThin.Location = new System.Drawing.Point(8, 68);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(87, 20);
            this.rdThin.TabIndex = 9;
            this.rdThin.TabStop = true;
            this.rdThin.Tag = "0";
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = true;
            this.rdThin.CheckedChanged += new System.EventHandler(this.rdThin_CheckedChanged);
            // 
            // rdThick
            // 
            this.rdThick.AutoSize = true;
            this.rdThick.Location = new System.Drawing.Point(8, 31);
            this.rdThick.Name = "rdThick";
            this.rdThick.Size = new System.Drawing.Size(94, 20);
            this.rdThick.TabIndex = 8;
            this.rdThick.Tag = "10";
            this.rdThick.Text = "Thick Crust";
            this.rdThick.UseVisualStyleBackColor = true;
            this.rdThick.CheckedChanged += new System.EventHandler(this.rdThick_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chbGreenPapper);
            this.gbToppings.Controls.Add(this.chbTomatos);
            this.gbToppings.Controls.Add(this.chbOlives);
            this.gbToppings.Controls.Add(this.chbOnion);
            this.gbToppings.Controls.Add(this.chbMashroom);
            this.gbToppings.Controls.Add(this.chbExtraChees);
            this.gbToppings.Location = new System.Drawing.Point(373, 162);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(274, 164);
            this.gbToppings.TabIndex = 18;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chbGreenPapper
            // 
            this.chbGreenPapper.AutoSize = true;
            this.chbGreenPapper.Location = new System.Drawing.Point(137, 107);
            this.chbGreenPapper.Name = "chbGreenPapper";
            this.chbGreenPapper.Size = new System.Drawing.Size(121, 20);
            this.chbGreenPapper.TabIndex = 23;
            this.chbGreenPapper.Tag = "5";
            this.chbGreenPapper.Text = "Green Peppers";
            this.chbGreenPapper.UseVisualStyleBackColor = true;
            this.chbGreenPapper.CheckedChanged += new System.EventHandler(this.chbGreenPapper_CheckedChanged);
            // 
            // chbTomatos
            // 
            this.chbTomatos.AutoSize = true;
            this.chbTomatos.Location = new System.Drawing.Point(18, 107);
            this.chbTomatos.Name = "chbTomatos";
            this.chbTomatos.Size = new System.Drawing.Size(83, 20);
            this.chbTomatos.TabIndex = 22;
            this.chbTomatos.Tag = "5";
            this.chbTomatos.Text = "Tomatos";
            this.chbTomatos.UseVisualStyleBackColor = true;
            this.chbTomatos.CheckedChanged += new System.EventHandler(this.chbTomatos_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(137, 67);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(67, 20);
            this.chbOlives.TabIndex = 21;
            this.chbOlives.Tag = "5";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(137, 29);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(64, 20);
            this.chbOnion.TabIndex = 20;
            this.chbOnion.Tag = "5";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.chbOnion_CheckedChanged);
            // 
            // chbMashroom
            // 
            this.chbMashroom.AutoSize = true;
            this.chbMashroom.Location = new System.Drawing.Point(18, 67);
            this.chbMashroom.Name = "chbMashroom";
            this.chbMashroom.Size = new System.Drawing.Size(99, 20);
            this.chbMashroom.TabIndex = 19;
            this.chbMashroom.Tag = "5";
            this.chbMashroom.Text = "Mushrooms";
            this.chbMashroom.UseVisualStyleBackColor = true;
            this.chbMashroom.CheckedChanged += new System.EventHandler(this.chbMashroom_CheckedChanged);
            // 
            // chbExtraChees
            // 
            this.chbExtraChees.AutoSize = true;
            this.chbExtraChees.Location = new System.Drawing.Point(18, 29);
            this.chbExtraChees.Name = "chbExtraChees";
            this.chbExtraChees.Size = new System.Drawing.Size(101, 20);
            this.chbExtraChees.TabIndex = 18;
            this.chbExtraChees.Tag = "5";
            this.chbExtraChees.Text = "Extra Chees";
            this.chbExtraChees.UseVisualStyleBackColor = true;
            this.chbExtraChees.CheckedChanged += new System.EventHandler(this.chbExtraChees_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(373, 374);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(239, 122);
            this.gbWhereToEat.TabIndex = 19;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(130, 43);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(16, 43);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(347, 544);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(159, 44);
            this.btnOrder.TabIndex = 20;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(592, 544);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 44);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbSummry
            // 
            this.gbSummry.Controls.Add(this.lblWehreToEat);
            this.gbSummry.Controls.Add(this.label5);
            this.gbSummry.Controls.Add(this.lblToppings);
            this.gbSummry.Controls.Add(this.label4);
            this.gbSummry.Controls.Add(this.label3);
            this.gbSummry.Controls.Add(this.lblCrust);
            this.gbSummry.Controls.Add(this.labl3);
            this.gbSummry.Controls.Add(this.lblSize);
            this.gbSummry.Controls.Add(this.label2);
            this.gbSummry.Controls.Add(this.lblPrice);
            this.gbSummry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSummry.Location = new System.Drawing.Point(776, 146);
            this.gbSummry.Name = "gbSummry";
            this.gbSummry.Size = new System.Drawing.Size(298, 423);
            this.gbSummry.TabIndex = 23;
            this.gbSummry.TabStop = false;
            this.gbSummry.Text = "Order Summry";
            // 
            // lblWehreToEat
            // 
            this.lblWehreToEat.AutoSize = true;
            this.lblWehreToEat.Location = new System.Drawing.Point(158, 271);
            this.lblWehreToEat.Name = "lblWehreToEat";
            this.lblWehreToEat.Size = new System.Drawing.Size(56, 22);
            this.lblWehreToEat.TabIndex = 35;
            this.lblWehreToEat.Text = "Eat In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Where to eat:";
            // 
            // lblToppings
            // 
            this.lblToppings.Location = new System.Drawing.Point(22, 183);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(265, 76);
            this.lblToppings.TabIndex = 33;
            this.lblToppings.Text = "NoToppings.";
            this.lblToppings.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Toppings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total Price:";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Location = new System.Drawing.Point(86, 90);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(94, 22);
            this.lblCrust.TabIndex = 30;
            this.lblCrust.Text = "Thin Crust";
            // 
            // labl3
            // 
            this.labl3.AutoSize = true;
            this.labl3.Location = new System.Drawing.Point(22, 90);
            this.labl3.Name = "labl3";
            this.labl3.Size = new System.Drawing.Size(58, 22);
            this.labl3.TabIndex = 29;
            this.labl3.Text = "Crust:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(97, 45);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 22);
            this.lblSize.TabIndex = 28;
            this.lblSize.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Size: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPrice.Location = new System.Drawing.Point(87, 337);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(120, 83);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.Tag = "40";
            this.lblPrice.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1101, 628);
            this.Controls.Add(this.gbSummry);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gpCrustSize);
            this.Controls.Add(this.gpPizzSize);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpPizzSize.ResumeLayout(false);
            this.gpPizzSize.PerformLayout();
            this.gpCrustSize.ResumeLayout(false);
            this.gpCrustSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbSummry.ResumeLayout(false);
            this.gbSummry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpPizzSize;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMidum;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox gpCrustSize;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.RadioButton rdThick;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chbGreenPapper;
        private System.Windows.Forms.CheckBox chbTomatos;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbMashroom;
        private System.Windows.Forms.CheckBox chbExtraChees;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbSummry;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label labl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWehreToEat;
        private System.Windows.Forms.Label label5;
    }
}

