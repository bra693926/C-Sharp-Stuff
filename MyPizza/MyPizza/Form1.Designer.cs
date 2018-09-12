namespace MyPizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputlabel = new System.Windows.Forms.Label();
            this.onioncheckBox = new System.Windows.Forms.CheckBox();
            this.peppercheckBox = new System.Windows.Forms.CheckBox();
            this.pepperonicheckBox = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.deliverRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SausagecheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Order Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dining options";
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Location = new System.Drawing.Point(187, 234);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(35, 13);
            this.outputlabel.TabIndex = 3;
            this.outputlabel.Text = "label4";
            // 
            // onioncheckBox
            // 
            this.onioncheckBox.AutoSize = true;
            this.onioncheckBox.Location = new System.Drawing.Point(70, 128);
            this.onioncheckBox.Name = "onioncheckBox";
            this.onioncheckBox.Size = new System.Drawing.Size(59, 17);
            this.onioncheckBox.TabIndex = 4;
            this.onioncheckBox.Text = "Onions";
            this.onioncheckBox.UseVisualStyleBackColor = true;
            this.onioncheckBox.CheckedChanged += new System.EventHandler(this.onioncheckBox_CheckedChanged_1);
            // 
            // peppercheckBox
            // 
            this.peppercheckBox.AutoSize = true;
            this.peppercheckBox.Location = new System.Drawing.Point(70, 151);
            this.peppercheckBox.Name = "peppercheckBox";
            this.peppercheckBox.Size = new System.Drawing.Size(65, 17);
            this.peppercheckBox.TabIndex = 5;
            this.peppercheckBox.Text = "Peppers";
            this.peppercheckBox.UseVisualStyleBackColor = true;
            this.peppercheckBox.CheckedChanged += new System.EventHandler(this.peppercheckBox_CheckedChanged_1);
            // 
            // pepperonicheckBox
            // 
            this.pepperonicheckBox.AutoSize = true;
            this.pepperonicheckBox.Location = new System.Drawing.Point(70, 174);
            this.pepperonicheckBox.Name = "pepperonicheckBox";
            this.pepperonicheckBox.Size = new System.Drawing.Size(74, 17);
            this.pepperonicheckBox.TabIndex = 6;
            this.pepperonicheckBox.Text = "Pepperoni";
            this.pepperonicheckBox.UseVisualStyleBackColor = true;
            this.pepperonicheckBox.CheckedChanged += new System.EventHandler(this.pepperonicheckBox_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(190, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pickup";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // deliverRadioButton
            // 
            this.deliverRadioButton.AutoSize = true;
            this.deliverRadioButton.Location = new System.Drawing.Point(190, 152);
            this.deliverRadioButton.Name = "deliverRadioButton";
            this.deliverRadioButton.Size = new System.Drawing.Size(63, 17);
            this.deliverRadioButton.TabIndex = 8;
            this.deliverRadioButton.TabStop = true;
            this.deliverRadioButton.Text = "Delivery";
            this.deliverRadioButton.UseVisualStyleBackColor = true;
            this.deliverRadioButton.CheckedChanged += new System.EventHandler(this.deliverRadioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(190, 175);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Dine in";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // SausagecheckBox
            // 
            this.SausagecheckBox.AutoSize = true;
            this.SausagecheckBox.Location = new System.Drawing.Point(70, 197);
            this.SausagecheckBox.Name = "SausagecheckBox";
            this.SausagecheckBox.Size = new System.Drawing.Size(68, 17);
            this.SausagecheckBox.TabIndex = 10;
            this.SausagecheckBox.Text = "Sausage";
            this.SausagecheckBox.UseVisualStyleBackColor = true;
            this.SausagecheckBox.CheckedChanged += new System.EventHandler(this.SausagecheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyPizza.Properties.Resources.Pizza;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SausagecheckBox);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.deliverRadioButton);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pepperonicheckBox);
            this.Controls.Add(this.peppercheckBox);
            this.Controls.Add(this.onioncheckBox);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza order Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.CheckBox onioncheckBox;
        private System.Windows.Forms.CheckBox peppercheckBox;
        private System.Windows.Forms.CheckBox pepperonicheckBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton deliverRadioButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox SausagecheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

