namespace Spannungsteiler_BS
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
            this.bt_Calculate = new System.Windows.Forms.Button();
            this.pb_CoordinateSystem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CoordinateSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Calculate
            // 
            this.bt_Calculate.Location = new System.Drawing.Point(379, 467);
            this.bt_Calculate.Name = "bt_Calculate";
            this.bt_Calculate.Size = new System.Drawing.Size(148, 59);
            this.bt_Calculate.TabIndex = 0;
            this.bt_Calculate.Text = "Zeichnen";
            this.bt_Calculate.UseVisualStyleBackColor = true;
            this.bt_Calculate.Click += new System.EventHandler(this.bt_Calculate_Click);
            // 
            // pb_CoordinateSystem
            // 
            this.pb_CoordinateSystem.BackColor = System.Drawing.Color.White;
            this.pb_CoordinateSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_CoordinateSystem.Location = new System.Drawing.Point(379, 61);
            this.pb_CoordinateSystem.Name = "pb_CoordinateSystem";
            this.pb_CoordinateSystem.Size = new System.Drawing.Size(430, 400);
            this.pb_CoordinateSystem.TabIndex = 1;
            this.pb_CoordinateSystem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 200);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_CoordinateSystem);
            this.Controls.Add(this.bt_Calculate);
            this.Name = "Form1";
            this.Text = "Spannungsteiler";
            ((System.ComponentModel.ISupportInitialize)(this.pb_CoordinateSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Calculate;
        private System.Windows.Forms.PictureBox pb_CoordinateSystem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

