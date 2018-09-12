//File Name: Chap12

//Written By: Brandon Truong

//Date: 08/02/2015
namespace Chap12
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
            this.Garlicbread = new System.Windows.Forms.RadioButton();
            this.Shrimpcocktail = new System.Windows.Forms.RadioButton();
            this.Stuffedmushrooms = new System.Windows.Forms.RadioButton();
            this.Lasagna = new System.Windows.Forms.RadioButton();
            this.Linguini = new System.Windows.Forms.RadioButton();
            this.Spaghetti = new System.Windows.Forms.RadioButton();
            this.Chocolatetruffle = new System.Windows.Forms.RadioButton();
            this.Tiramisu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Canoli = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Garlicbread
            // 
            this.Garlicbread.AutoSize = true;
            this.Garlicbread.Location = new System.Drawing.Point(17, 28);
            this.Garlicbread.Name = "Garlicbread";
            this.Garlicbread.Size = new System.Drawing.Size(98, 17);
            this.Garlicbread.TabIndex = 0;
            this.Garlicbread.Text = "Garlic Bread $4";
            this.Garlicbread.UseVisualStyleBackColor = true;
            this.Garlicbread.CheckedChanged += new System.EventHandler(this.Garlicbread_CheckedChanged);
            // 
            // Shrimpcocktail
            // 
            this.Shrimpcocktail.AutoSize = true;
            this.Shrimpcocktail.Location = new System.Drawing.Point(17, 51);
            this.Shrimpcocktail.Name = "Shrimpcocktail";
            this.Shrimpcocktail.Size = new System.Drawing.Size(113, 17);
            this.Shrimpcocktail.TabIndex = 1;
            this.Shrimpcocktail.Text = "Shrimp Cocktail $5";
            this.Shrimpcocktail.UseVisualStyleBackColor = true;
            this.Shrimpcocktail.CheckedChanged += new System.EventHandler(this.Shrimpcocktail_CheckedChanged);
            // 
            // Stuffedmushrooms
            // 
            this.Stuffedmushrooms.AutoSize = true;
            this.Stuffedmushrooms.Location = new System.Drawing.Point(17, 74);
            this.Stuffedmushrooms.Name = "Stuffedmushrooms";
            this.Stuffedmushrooms.Size = new System.Drawing.Size(131, 17);
            this.Stuffedmushrooms.TabIndex = 2;
            this.Stuffedmushrooms.Text = "Stuffed Mushrooms $6";
            this.Stuffedmushrooms.UseVisualStyleBackColor = true;
            this.Stuffedmushrooms.CheckedChanged += new System.EventHandler(this.Stuffedmushrooms_CheckedChanged);
            // 
            // Lasagna
            // 
            this.Lasagna.AutoSize = true;
            this.Lasagna.Location = new System.Drawing.Point(6, 19);
            this.Lasagna.Name = "Lasagna";
            this.Lasagna.Size = new System.Drawing.Size(168, 17);
            this.Lasagna.TabIndex = 3;
            this.Lasagna.Text = "Lasagna with Meat sauce $24";
            this.Lasagna.UseVisualStyleBackColor = true;
            this.Lasagna.CheckedChanged += new System.EventHandler(this.Lasagna_CheckedChanged);
            // 
            // Linguini
            // 
            this.Linguini.AutoSize = true;
            this.Linguini.Location = new System.Drawing.Point(6, 42);
            this.Linguini.Name = "Linguini";
            this.Linguini.Size = new System.Drawing.Size(164, 17);
            this.Linguini.TabIndex = 4;
            this.Linguini.Text = "Linguini with clam sauce $ 25";
            this.Linguini.UseVisualStyleBackColor = true;
            this.Linguini.CheckedChanged += new System.EventHandler(this.Linguini_CheckedChanged);
            // 
            // Spaghetti
            // 
            this.Spaghetti.AutoSize = true;
            this.Spaghetti.Location = new System.Drawing.Point(6, 63);
            this.Spaghetti.Name = "Spaghetti";
            this.Spaghetti.Size = new System.Drawing.Size(188, 17);
            this.Spaghetti.TabIndex = 5;
            this.Spaghetti.Text = "Spaghetti with marinara sauce $26";
            this.Spaghetti.UseVisualStyleBackColor = true;
            this.Spaghetti.CheckedChanged += new System.EventHandler(this.Spaghetti_CheckedChanged);
            // 
            // Chocolatetruffle
            // 
            this.Chocolatetruffle.AutoSize = true;
            this.Chocolatetruffle.Location = new System.Drawing.Point(6, 50);
            this.Chocolatetruffle.Name = "Chocolatetruffle";
            this.Chocolatetruffle.Size = new System.Drawing.Size(117, 17);
            this.Chocolatetruffle.TabIndex = 7;
            this.Chocolatetruffle.Text = "Chocolate truffle $8";
            this.Chocolatetruffle.UseVisualStyleBackColor = true;
            this.Chocolatetruffle.CheckedChanged += new System.EventHandler(this.Chocolatetruffle_CheckedChanged);
            // 
            // Tiramisu
            // 
            this.Tiramisu.AutoSize = true;
            this.Tiramisu.Location = new System.Drawing.Point(6, 73);
            this.Tiramisu.Name = "Tiramisu";
            this.Tiramisu.Size = new System.Drawing.Size(85, 17);
            this.Tiramisu.TabIndex = 8;
            this.Tiramisu.Text = "Tira mi su $9";
            this.Tiramisu.UseVisualStyleBackColor = true;
            this.Tiramisu.CheckedChanged += new System.EventHandler(this.Tiramisu_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Canoli);
            this.groupBox1.Controls.Add(this.Tiramisu);
            this.groupBox1.Controls.Add(this.Chocolatetruffle);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dessert";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lasagna);
            this.groupBox2.Controls.Add(this.Linguini);
            this.groupBox2.Controls.Add(this.Spaghetti);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 123);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Dish";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Garlicbread);
            this.groupBox3.Controls.Add(this.Shrimpcocktail);
            this.groupBox3.Controls.Add(this.Stuffedmushrooms);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 118);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appetizers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // Canoli
            // 
            this.Canoli.AutoSize = true;
            this.Canoli.Location = new System.Drawing.Point(6, 27);
            this.Canoli.Name = "Canoli";
            this.Canoli.Size = new System.Drawing.Size(69, 17);
            this.Canoli.TabIndex = 6;
            this.Canoli.Text = "Canoli $7";
            this.Canoli.UseVisualStyleBackColor = true;
            this.Canoli.CheckedChanged += new System.EventHandler(this.Canoli_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Today\'s Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Garlicbread;
        private System.Windows.Forms.RadioButton Shrimpcocktail;
        private System.Windows.Forms.RadioButton Stuffedmushrooms;
        private System.Windows.Forms.RadioButton Lasagna;
        private System.Windows.Forms.RadioButton Linguini;
        private System.Windows.Forms.RadioButton Spaghetti;
        private System.Windows.Forms.RadioButton Chocolatetruffle;
        private System.Windows.Forms.RadioButton Tiramisu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Canoli;
    }
}

