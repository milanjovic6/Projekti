
using System;
using System.Windows.Forms;

namespace FoodRandomizer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFoodADD = new System.Windows.Forms.TextBox();
            this.rb_ADD = new FoodRandomizer.RoundedButton();
            this.roundedButton1 = new FoodRandomizer.RoundedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 41);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbFoodADD
            // 
            this.tbFoodADD.Location = new System.Drawing.Point(12, 68);
            this.tbFoodADD.Name = "tbFoodADD";
            this.tbFoodADD.Size = new System.Drawing.Size(100, 20);
            this.tbFoodADD.TabIndex = 0;
            this.tbFoodADD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFoodADD_KeyPress);
            // 
            // rb_ADD
            // 
            this.rb_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ADD.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rb_ADD.Location = new System.Drawing.Point(19, 12);
            this.rb_ADD.Name = "rb_ADD";
            this.rb_ADD.Size = new System.Drawing.Size(84, 50);
            this.rb_ADD.TabIndex = 3;
            this.rb_ADD.Text = "Add new food";
            this.rb_ADD.UseVisualStyleBackColor = true;
            this.rb_ADD.Click += new System.EventHandler(this.rbADD_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.roundedButton1.Location = new System.Drawing.Point(187, 250);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(160, 71);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "Randomize";
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 541);
            this.Controls.Add(this.tbFoodADD);
            this.Controls.Add(this.rb_ADD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randomizer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton roundedButton1;
        private System.Windows.Forms.Label label1;
        private RoundedButton rb_ADD;
        private TextBox tbFoodADD;
    }
}