namespace pizza_APP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSizeSmall = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSizeLarg = new System.Windows.Forms.RadioButton();
            this.rbSizeMed = new System.Windows.Forms.RadioButton();
            this.gbcrust = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.ChbEx6 = new System.Windows.Forms.CheckBox();
            this.ChbEx5 = new System.Windows.Forms.CheckBox();
            this.ChbEx4 = new System.Windows.Forms.CheckBox();
            this.ChbEx3 = new System.Windows.Forms.CheckBox();
            this.ChbEx2 = new System.Windows.Forms.CheckBox();
            this.ChBEx1 = new System.Windows.Forms.CheckBox();
            this.gbeatwhere = new System.Windows.Forms.GroupBox();
            this.rbTakeAway = new System.Windows.Forms.RadioButton();
            this.rbyeseatHere = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSum = new System.Windows.Forms.GroupBox();
            this.LbTopSum = new System.Windows.Forms.Label();
            this.LbTotalPrice = new System.Windows.Forms.Label();
            this.labbel = new System.Windows.Forms.Label();
            this.LbeatHere = new System.Windows.Forms.Label();
            this.LbcrustSum = new System.Windows.Forms.Label();
            this.LbSizeSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.LBPizaNum = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbcrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbeatwhere.SuspendLayout();
            this.gbSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(204, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make your pizza ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F);
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 2);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 2);
            this.label3.TabIndex = 2;
            this.label3.Text = "_______________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 2);
            this.label4.TabIndex = 3;
            this.label4.Text = "_______________________________________________________________________";
            // 
            // rbSizeSmall
            // 
            this.rbSizeSmall.AutoSize = true;
            this.rbSizeSmall.BackColor = System.Drawing.Color.Transparent;
            this.rbSizeSmall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.rbSizeSmall.Location = new System.Drawing.Point(18, 27);
            this.rbSizeSmall.Name = "rbSizeSmall";
            this.rbSizeSmall.Size = new System.Drawing.Size(85, 24);
            this.rbSizeSmall.TabIndex = 4;
            this.rbSizeSmall.TabStop = true;
            this.rbSizeSmall.Tag = "10";
            this.rbSizeSmall.Text = "Small   ";
            this.rbSizeSmall.UseVisualStyleBackColor = false;
            this.rbSizeSmall.CheckedChanged += new System.EventHandler(this.rbSizeSmall_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbSize.Controls.Add(this.rbSizeLarg);
            this.gbSize.Controls.Add(this.rbSizeMed);
            this.gbSize.Controls.Add(this.rbSizeSmall);
            this.gbSize.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.Red;
            this.gbSize.Location = new System.Drawing.Point(60, 112);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(125, 168);
            this.gbSize.TabIndex = 7;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.Enter += new System.EventHandler(this.gbSize_Enter);
            // 
            // rbSizeLarg
            // 
            this.rbSizeLarg.AutoSize = true;
            this.rbSizeLarg.BackColor = System.Drawing.Color.Transparent;
            this.rbSizeLarg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.rbSizeLarg.Location = new System.Drawing.Point(18, 115);
            this.rbSizeLarg.Name = "rbSizeLarg";
            this.rbSizeLarg.Size = new System.Drawing.Size(94, 24);
            this.rbSizeLarg.TabIndex = 6;
            this.rbSizeLarg.TabStop = true;
            this.rbSizeLarg.Tag = "35";
            this.rbSizeLarg.Text = "Larg      ";
            this.rbSizeLarg.UseVisualStyleBackColor = false;
            this.rbSizeLarg.CheckedChanged += new System.EventHandler(this.rbSizeLarg_CheckedChanged);
            // 
            // rbSizeMed
            // 
            this.rbSizeMed.AutoSize = true;
            this.rbSizeMed.BackColor = System.Drawing.Color.Transparent;
            this.rbSizeMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.rbSizeMed.Location = new System.Drawing.Point(18, 74);
            this.rbSizeMed.Name = "rbSizeMed";
            this.rbSizeMed.Size = new System.Drawing.Size(89, 24);
            this.rbSizeMed.TabIndex = 5;
            this.rbSizeMed.TabStop = true;
            this.rbSizeMed.Tag = "20";
            this.rbSizeMed.Text = "Medeum";
            this.rbSizeMed.UseVisualStyleBackColor = false;
            this.rbSizeMed.CheckedChanged += new System.EventHandler(this.rbSizeMed_CheckedChanged);
            // 
            // gbcrust
            // 
            this.gbcrust.BackColor = System.Drawing.Color.Transparent;
            this.gbcrust.Controls.Add(this.rbThickCrust);
            this.gbcrust.Controls.Add(this.rbThinCrust);
            this.gbcrust.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcrust.ForeColor = System.Drawing.Color.Red;
            this.gbcrust.Location = new System.Drawing.Point(60, 308);
            this.gbcrust.Name = "gbcrust";
            this.gbcrust.Size = new System.Drawing.Size(125, 94);
            this.gbcrust.TabIndex = 8;
            this.gbcrust.TabStop = false;
            this.gbcrust.Text = "Crust type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.rbThickCrust.Location = new System.Drawing.Point(18, 58);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(99, 21);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "15";
            this.rbThickCrust.Text = "Thick crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.rbThinCrust.Location = new System.Drawing.Point(18, 26);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(93, 21);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.ChbEx6);
            this.gbToppings.Controls.Add(this.ChbEx5);
            this.gbToppings.Controls.Add(this.ChbEx4);
            this.gbToppings.Controls.Add(this.ChbEx3);
            this.gbToppings.Controls.Add(this.ChbEx2);
            this.gbToppings.Controls.Add(this.ChBEx1);
            this.gbToppings.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.Red;
            this.gbToppings.Location = new System.Drawing.Point(230, 112);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(338, 168);
            this.gbToppings.TabIndex = 9;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // ChbEx6
            // 
            this.ChbEx6.AutoSize = true;
            this.ChbEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.ChbEx6.Location = new System.Drawing.Point(180, 117);
            this.ChbEx6.Name = "ChbEx6";
            this.ChbEx6.Size = new System.Drawing.Size(89, 21);
            this.ChbEx6.TabIndex = 5;
            this.ChbEx6.Tag = "5";
            this.ChbEx6.Text = "Tomatous";
            this.ChbEx6.UseVisualStyleBackColor = true;
            this.ChbEx6.CheckedChanged += new System.EventHandler(this.ChbEx6_CheckedChanged);
            // 
            // ChbEx5
            // 
            this.ChbEx5.AutoSize = true;
            this.ChbEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.ChbEx5.Location = new System.Drawing.Point(180, 76);
            this.ChbEx5.Name = "ChbEx5";
            this.ChbEx5.Size = new System.Drawing.Size(107, 21);
            this.ChbEx5.TabIndex = 4;
            this.ChbEx5.Tag = "5";
            this.ChbEx5.Text = "Mashruooms";
            this.ChbEx5.UseVisualStyleBackColor = true;
            this.ChbEx5.CheckedChanged += new System.EventHandler(this.ChbEx5_CheckedChanged);
            // 
            // ChbEx4
            // 
            this.ChbEx4.AutoSize = true;
            this.ChbEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.ChbEx4.Location = new System.Drawing.Point(180, 29);
            this.ChbEx4.Name = "ChbEx4";
            this.ChbEx4.Size = new System.Drawing.Size(73, 21);
            this.ChbEx4.TabIndex = 3;
            this.ChbEx4.Tag = "5";
            this.ChbEx4.Text = "Olivers";
            this.ChbEx4.UseVisualStyleBackColor = true;
            this.ChbEx4.CheckedChanged += new System.EventHandler(this.ChbEx4_CheckedChanged);
            // 
            // ChbEx3
            // 
            this.ChbEx3.AutoSize = true;
            this.ChbEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.ChbEx3.Location = new System.Drawing.Point(21, 117);
            this.ChbEx3.Name = "ChbEx3";
            this.ChbEx3.Size = new System.Drawing.Size(108, 21);
            this.ChbEx3.TabIndex = 2;
            this.ChbEx3.Tag = "5";
            this.ChbEx3.Text = "Green papers";
            this.ChbEx3.UseVisualStyleBackColor = true;
            this.ChbEx3.CheckedChanged += new System.EventHandler(this.ChbEx3_CheckedChanged);
            // 
            // ChbEx2
            // 
            this.ChbEx2.AutoSize = true;
            this.ChbEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.ChbEx2.Location = new System.Drawing.Point(21, 76);
            this.ChbEx2.Name = "ChbEx2";
            this.ChbEx2.Size = new System.Drawing.Size(68, 21);
            this.ChbEx2.TabIndex = 1;
            this.ChbEx2.Tag = "5";
            this.ChbEx2.Text = "Onion";
            this.ChbEx2.UseVisualStyleBackColor = true;
            this.ChbEx2.CheckedChanged += new System.EventHandler(this.ChbEx2_CheckedChanged);
            // 
            // ChBEx1
            // 
            this.ChBEx1.AutoSize = true;
            this.ChBEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.ChBEx1.Location = new System.Drawing.Point(21, 29);
            this.ChBEx1.Name = "ChBEx1";
            this.ChBEx1.Size = new System.Drawing.Size(99, 21);
            this.ChBEx1.TabIndex = 0;
            this.ChBEx1.Tag = "5";
            this.ChBEx1.Text = "Extra chess";
            this.ChBEx1.UseVisualStyleBackColor = true;
            this.ChBEx1.CheckedChanged += new System.EventHandler(this.ChBEx1_CheckedChanged);
            // 
            // gbeatwhere
            // 
            this.gbeatwhere.BackColor = System.Drawing.Color.Transparent;
            this.gbeatwhere.Controls.Add(this.rbTakeAway);
            this.gbeatwhere.Controls.Add(this.rbyeseatHere);
            this.gbeatwhere.Controls.Add(this.label5);
            this.gbeatwhere.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbeatwhere.ForeColor = System.Drawing.Color.Red;
            this.gbeatwhere.Location = new System.Drawing.Point(230, 315);
            this.gbeatwhere.Name = "gbeatwhere";
            this.gbeatwhere.Size = new System.Drawing.Size(338, 94);
            this.gbeatwhere.TabIndex = 10;
            this.gbeatwhere.TabStop = false;
            this.gbeatwhere.Text = "Where do you want to eat";
            // 
            // rbTakeAway
            // 
            this.rbTakeAway.AutoSize = true;
            this.rbTakeAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.rbTakeAway.Location = new System.Drawing.Point(193, 51);
            this.rbTakeAway.Name = "rbTakeAway";
            this.rbTakeAway.Size = new System.Drawing.Size(50, 24);
            this.rbTakeAway.TabIndex = 2;
            this.rbTakeAway.TabStop = true;
            this.rbTakeAway.Tag = "0";
            this.rbTakeAway.Text = "No";
            this.rbTakeAway.UseVisualStyleBackColor = true;
            this.rbTakeAway.CheckedChanged += new System.EventHandler(this.rbTakeAway_CheckedChanged);
            // 
            // rbyeseatHere
            // 
            this.rbyeseatHere.AutoSize = true;
            this.rbyeseatHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.rbyeseatHere.Location = new System.Drawing.Point(34, 51);
            this.rbyeseatHere.Name = "rbyeseatHere";
            this.rbyeseatHere.Size = new System.Drawing.Size(55, 24);
            this.rbyeseatHere.TabIndex = 1;
            this.rbyeseatHere.TabStop = true;
            this.rbyeseatHere.Tag = "5";
            this.rbyeseatHere.Text = "Yes";
            this.rbyeseatHere.UseVisualStyleBackColor = true;
            this.rbyeseatHere.CheckedChanged += new System.EventHandler(this.rbyeseatHere_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.label5.Location = new System.Drawing.Point(31, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Are you want to eat here ?";
            // 
            // gbSum
            // 
            this.gbSum.BackColor = System.Drawing.Color.Transparent;
            this.gbSum.Controls.Add(this.LbTopSum);
            this.gbSum.Controls.Add(this.LbTotalPrice);
            this.gbSum.Controls.Add(this.labbel);
            this.gbSum.Controls.Add(this.LbeatHere);
            this.gbSum.Controls.Add(this.LbcrustSum);
            this.gbSum.Controls.Add(this.LbSizeSum);
            this.gbSum.Controls.Add(this.label7);
            this.gbSum.Controls.Add(this.label9);
            this.gbSum.Controls.Add(this.label10);
            this.gbSum.Controls.Add(this.label6);
            this.gbSum.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSum.ForeColor = System.Drawing.Color.Red;
            this.gbSum.Location = new System.Drawing.Point(614, 119);
            this.gbSum.Name = "gbSum";
            this.gbSum.Size = new System.Drawing.Size(200, 361);
            this.gbSum.TabIndex = 11;
            this.gbSum.TabStop = false;
            this.gbSum.Text = "Order summary";
            this.gbSum.Enter += new System.EventHandler(this.gbSum_Enter);
            // 
            // LbTopSum
            // 
            this.LbTopSum.Font = new System.Drawing.Font("Modern No. 20", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTopSum.ForeColor = System.Drawing.Color.Snow;
            this.LbTopSum.Location = new System.Drawing.Point(33, 108);
            this.LbTopSum.Name = "LbTopSum";
            this.LbTopSum.Size = new System.Drawing.Size(167, 78);
            this.LbTopSum.TabIndex = 5;
            this.LbTopSum.Text = "Toppings :";
            this.LbTopSum.Click += new System.EventHandler(this.LbTopSum_Click);
            // 
            // LbTotalPrice
            // 
            this.LbTotalPrice.AutoSize = true;
            this.LbTotalPrice.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalPrice.ForeColor = System.Drawing.Color.Snow;
            this.LbTotalPrice.Location = new System.Drawing.Point(82, 301);
            this.LbTotalPrice.Name = "LbTotalPrice";
            this.LbTotalPrice.Size = new System.Drawing.Size(20, 31);
            this.LbTotalPrice.TabIndex = 9;
            this.LbTotalPrice.Text = " ";
            this.LbTotalPrice.Click += new System.EventHandler(this.LbTotalPrice_Click);
            // 
            // labbel
            // 
            this.labbel.AutoSize = true;
            this.labbel.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labbel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.labbel.Location = new System.Drawing.Point(39, 260);
            this.labbel.Name = "labbel";
            this.labbel.Size = new System.Drawing.Size(110, 24);
            this.labbel.TabIndex = 8;
            this.labbel.Text = "Total Price";
            // 
            // LbeatHere
            // 
            this.LbeatHere.AutoSize = true;
            this.LbeatHere.Font = new System.Drawing.Font("Modern No. 20", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbeatHere.ForeColor = System.Drawing.Color.Snow;
            this.LbeatHere.Location = new System.Drawing.Point(35, 234);
            this.LbeatHere.Name = "LbeatHere";
            this.LbeatHere.Size = new System.Drawing.Size(79, 18);
            this.LbeatHere.TabIndex = 7;
            this.LbeatHere.Text = "Eat here ? ";
            // 
            // LbcrustSum
            // 
            this.LbcrustSum.AutoSize = true;
            this.LbcrustSum.Font = new System.Drawing.Font("Modern No. 20", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcrustSum.ForeColor = System.Drawing.Color.Snow;
            this.LbcrustSum.Location = new System.Drawing.Point(35, 202);
            this.LbcrustSum.Name = "LbcrustSum";
            this.LbcrustSum.Size = new System.Drawing.Size(56, 18);
            this.LbcrustSum.TabIndex = 6;
            this.LbcrustSum.Text = "Crust : ";
            // 
            // LbSizeSum
            // 
            this.LbSizeSum.AutoSize = true;
            this.LbSizeSum.Font = new System.Drawing.Font("Modern No. 20", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSizeSum.ForeColor = System.Drawing.Color.Snow;
            this.LbSizeSum.Location = new System.Drawing.Point(33, 73);
            this.LbSizeSum.Name = "LbSizeSum";
            this.LbSizeSum.Size = new System.Drawing.Size(48, 18);
            this.LbSizeSum.TabIndex = 4;
            this.LbSizeSum.Text = "Size : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 2);
            this.label7.TabIndex = 1;
            this.label7.Text = "__________________________--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(84, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 2);
            this.label9.TabIndex = 3;
            this.label9.Text = "__________________________--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(59, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 2);
            this.label10.TabIndex = 2;
            this.label10.Text = "__________________________--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.label6.Location = new System.Drawing.Point(39, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pizza Order";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Green;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 3;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(191, 448);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 49);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Green;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnPrint.FlatAppearance.BorderSize = 3;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(405, 448);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 49);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.AutoRoundedCorners = true;
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderRadius = 13;
            this.guna2NumericUpDown1.BorderThickness = 0;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(61, 462);
            this.guna2NumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2NumericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(82, 29);
            this.guna2NumericUpDown1.TabIndex = 14;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(154)))), ((int)(((byte)(11)))));
            this.guna2NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guna2NumericUpDown1.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // LBPizaNum
            // 
            this.LBPizaNum.AutoSize = true;
            this.LBPizaNum.BackColor = System.Drawing.Color.Transparent;
            this.LBPizaNum.Font = new System.Drawing.Font("Modern No. 20", 9.799999F);
            this.LBPizaNum.ForeColor = System.Drawing.Color.Red;
            this.LBPizaNum.Location = new System.Drawing.Point(57, 426);
            this.LBPizaNum.Name = "LBPizaNum";
            this.LBPizaNum.Size = new System.Drawing.Size(124, 20);
            this.LBPizaNum.TabIndex = 15;
            this.LBPizaNum.Text = "Number of pizza";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(866, 551);
            this.Controls.Add(this.LBPizaNum);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.Controls.Add(this.gbSum);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbeatwhere);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbcrust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSize);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pizza order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbcrust.ResumeLayout(false);
            this.gbcrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbeatwhere.ResumeLayout(false);
            this.gbeatwhere.PerformLayout();
            this.gbSum.ResumeLayout(false);
            this.gbSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSizeSmall;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbSizeLarg;
        private System.Windows.Forms.RadioButton rbSizeMed;
        private System.Windows.Forms.GroupBox gbcrust;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox ChbEx6;
        private System.Windows.Forms.CheckBox ChbEx5;
        private System.Windows.Forms.CheckBox ChbEx4;
        private System.Windows.Forms.CheckBox ChbEx3;
        private System.Windows.Forms.CheckBox ChbEx2;
        private System.Windows.Forms.CheckBox ChBEx1;
        private System.Windows.Forms.GroupBox gbeatwhere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbTakeAway;
        private System.Windows.Forms.RadioButton rbyeseatHere;
        private System.Windows.Forms.GroupBox gbSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbeatHere;
        private System.Windows.Forms.Label LbcrustSum;
        private System.Windows.Forms.Label LbTopSum;
        private System.Windows.Forms.Label LbSizeSum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label LbTotalPrice;
        private System.Windows.Forms.Label labbel;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.Label LBPizaNum;
    }
}