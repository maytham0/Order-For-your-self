namespace ResturantOrder
{
    partial class PizzaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbWereEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.rbThine = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbToppings6 = new System.Windows.Forms.Label();
            this.lbToppings5 = new System.Windows.Forms.Label();
            this.lbToppings4 = new System.Windows.Forms.Label();
            this.lbToppings3 = new System.Windows.Forms.Label();
            this.lbToppings2 = new System.Windows.Forms.Label();
            this.lbTotolPrice = new System.Windows.Forms.Label();
            this.lbWheretoEat = new System.Windows.Forms.Label();
            this.lbCrust = new System.Windows.Forms.Label();
            this.lbToppings1 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbToppings.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbWereEat.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 393);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkPeppers);
            this.gbToppings.Controls.Add(this.chkTomatos);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbToppings.Location = new System.Drawing.Point(641, 29);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(180, 245);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(6, 200);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(176, 29);
            this.chkPeppers.TabIndex = 5;
            this.chkPeppers.Tag = "int i=5";
            this.chkPeppers.Text = "Green Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Location = new System.Drawing.Point(6, 166);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(114, 29);
            this.chkTomatos.TabIndex = 4;
            this.chkTomatos.Tag = "int i=5";
            this.chkTomatos.Text = "Tomatos";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(6, 132);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(91, 29);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Tag = "int i=5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 98);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(143, 29);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Tag = "int i=5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(6, 64);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(88, 29);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Tag = "int i=5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(6, 30);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(149, 29);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "int i=5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSize.Location = new System.Drawing.Point(443, 29);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(179, 142);
            this.gbSize.TabIndex = 2;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(6, 97);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(73, 29);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.Tag = "int i=5";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(6, 63);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(105, 29);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.Tag = "int i=5";
            this.rbMeduim.Text = "meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(6, 29);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(83, 29);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbWereEat
            // 
            this.gbWereEat.Controls.Add(this.rbTakeOut);
            this.gbWereEat.Controls.Add(this.rbEatIn);
            this.gbWereEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWereEat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbWereEat.Location = new System.Drawing.Point(443, 186);
            this.gbWereEat.Name = "gbWereEat";
            this.gbWereEat.Size = new System.Drawing.Size(158, 110);
            this.gbWereEat.TabIndex = 3;
            this.gbWereEat.TabStop = false;
            this.gbWereEat.Text = "Were To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(6, 60);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(105, 28);
            this.rbTakeOut.TabIndex = 2;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(6, 26);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(75, 28);
            this.rbEatIn.TabIndex = 1;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThink);
            this.gbCrustType.Controls.Add(this.rbThine);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCrustType.Location = new System.Drawing.Point(637, 282);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(184, 107);
            this.gbCrustType.TabIndex = 4;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.Location = new System.Drawing.Point(6, 56);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(123, 28);
            this.rbThink.TabIndex = 2;
            this.rbThink.Text = "Think Crust";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rbThine
            // 
            this.rbThine.AutoSize = true;
            this.rbThine.Location = new System.Drawing.Point(6, 28);
            this.rbThine.Name = "rbThine";
            this.rbThine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbThine.Size = new System.Drawing.Size(125, 28);
            this.rbThine.TabIndex = 1;
            this.rbThine.Text = "Thine Crust";
            this.rbThine.UseVisualStyleBackColor = true;
            this.rbThine.CheckedChanged += new System.EventHandler(this.rbThine_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(453, 302);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(129, 62);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(453, 370);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(129, 62);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset Form";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Brown;
            this.groupBox1.Controls.Add(this.lbToppings6);
            this.groupBox1.Controls.Add(this.lbToppings5);
            this.groupBox1.Controls.Add(this.lbToppings4);
            this.groupBox1.Controls.Add(this.lbToppings3);
            this.groupBox1.Controls.Add(this.lbToppings2);
            this.groupBox1.Controls.Add(this.lbTotolPrice);
            this.groupBox1.Controls.Add(this.lbWheretoEat);
            this.groupBox1.Controls.Add(this.lbCrust);
            this.groupBox1.Controls.Add(this.lbToppings1);
            this.groupBox1.Controls.Add(this.lbSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 331);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lbToppings6
            // 
            this.lbToppings6.AutoSize = true;
            this.lbToppings6.Location = new System.Drawing.Point(200, 134);
            this.lbToppings6.Name = "lbToppings6";
            this.lbToppings6.Size = new System.Drawing.Size(0, 23);
            this.lbToppings6.TabIndex = 16;
            // 
            // lbToppings5
            // 
            this.lbToppings5.AutoSize = true;
            this.lbToppings5.Location = new System.Drawing.Point(131, 134);
            this.lbToppings5.Name = "lbToppings5";
            this.lbToppings5.Size = new System.Drawing.Size(0, 23);
            this.lbToppings5.TabIndex = 15;
            // 
            // lbToppings4
            // 
            this.lbToppings4.AutoSize = true;
            this.lbToppings4.Location = new System.Drawing.Point(24, 134);
            this.lbToppings4.Name = "lbToppings4";
            this.lbToppings4.Size = new System.Drawing.Size(0, 23);
            this.lbToppings4.TabIndex = 14;
            // 
            // lbToppings3
            // 
            this.lbToppings3.AutoSize = true;
            this.lbToppings3.Location = new System.Drawing.Point(200, 97);
            this.lbToppings3.Name = "lbToppings3";
            this.lbToppings3.Size = new System.Drawing.Size(0, 23);
            this.lbToppings3.TabIndex = 13;
            // 
            // lbToppings2
            // 
            this.lbToppings2.AutoSize = true;
            this.lbToppings2.Location = new System.Drawing.Point(131, 97);
            this.lbToppings2.Name = "lbToppings2";
            this.lbToppings2.Size = new System.Drawing.Size(0, 23);
            this.lbToppings2.TabIndex = 12;
            this.lbToppings2.Click += new System.EventHandler(this.lbToppings2_Click);
            // 
            // lbTotolPrice
            // 
            this.lbTotolPrice.AutoSize = true;
            this.lbTotolPrice.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotolPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTotolPrice.Location = new System.Drawing.Point(127, 258);
            this.lbTotolPrice.Name = "lbTotolPrice";
            this.lbTotolPrice.Size = new System.Drawing.Size(51, 47);
            this.lbTotolPrice.TabIndex = 11;
            this.lbTotolPrice.Tag = "20";
            this.lbTotolPrice.Text = "20";
            // 
            // lbWheretoEat
            // 
            this.lbWheretoEat.AutoSize = true;
            this.lbWheretoEat.Location = new System.Drawing.Point(153, 213);
            this.lbWheretoEat.Name = "lbWheretoEat";
            this.lbWheretoEat.Size = new System.Drawing.Size(0, 23);
            this.lbWheretoEat.TabIndex = 10;
            // 
            // lbCrust
            // 
            this.lbCrust.AutoSize = true;
            this.lbCrust.Location = new System.Drawing.Point(131, 184);
            this.lbCrust.Name = "lbCrust";
            this.lbCrust.Size = new System.Drawing.Size(0, 23);
            this.lbCrust.TabIndex = 9;
            // 
            // lbToppings1
            // 
            this.lbToppings1.AutoSize = true;
            this.lbToppings1.Location = new System.Drawing.Point(24, 94);
            this.lbToppings1.Name = "lbToppings1";
            this.lbToppings1.Size = new System.Drawing.Size(0, 23);
            this.lbToppings1.TabIndex = 8;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(100, 34);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(0, 23);
            this.lbSize.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Totle Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Crust Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Where To Eat :";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(838, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbWereEat);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PizzaForm";
            this.Text = "PizzaForm";
            this.Load += new System.EventHandler(this.PizzaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbWereEat.ResumeLayout(false);
            this.gbWereEat.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbWereEat;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.RadioButton rbThine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotolPrice;
        private System.Windows.Forms.Label lbWheretoEat;
        private System.Windows.Forms.Label lbCrust;
        private System.Windows.Forms.Label lbToppings1;
        private System.Windows.Forms.Label lbToppings6;
        private System.Windows.Forms.Label lbToppings5;
        private System.Windows.Forms.Label lbToppings4;
        private System.Windows.Forms.Label lbToppings3;
        private System.Windows.Forms.Label lbToppings2;
    }
}