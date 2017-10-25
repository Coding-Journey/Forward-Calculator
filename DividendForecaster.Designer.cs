/*
 * Created by SharpDevelop.
 * User: Will 2nd
 * Date: 18/04/2016
 * Time: 18:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Forward_Calculator
{
	partial class DividendForecaster
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DividendForecaster));
			this.picb_dividend = new System.Windows.Forms.PictureBox();
			this.combob_Date = new System.Windows.Forms.ComboBox();
			this.radiob_Same = new System.Windows.Forms.RadioButton();
			this.lbl_DividendForecaster = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_Amount = new System.Windows.Forms.Label();
			this.lbl_Prediction = new System.Windows.Forms.Label();
			this.txtb_Amount = new System.Windows.Forms.TextBox();
			this.txtb_Prediction = new System.Windows.Forms.TextBox();
			this.lbl_Upper = new System.Windows.Forms.Label();
			this.radiob_Different = new System.Windows.Forms.RadioButton();
			this.lbl_Median = new System.Windows.Forms.Label();
			this.lbl_Lower = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picb_dividend)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// picb_dividend
			// 
			this.picb_dividend.Image = ((System.Drawing.Image)(resources.GetObject("picb_dividend.Image")));
			this.picb_dividend.Location = new System.Drawing.Point(0, -1);
			this.picb_dividend.Name = "picb_dividend";
			this.picb_dividend.Size = new System.Drawing.Size(438, 83);
			this.picb_dividend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picb_dividend.TabIndex = 0;
			this.picb_dividend.TabStop = false;
			this.picb_dividend.Click += new System.EventHandler(this.PicbDividendClick);
			// 
			// combob_Date
			// 
			this.combob_Date.FormattingEnabled = true;
			this.combob_Date.Location = new System.Drawing.Point(230, 9);
			this.combob_Date.Name = "combob_Date";
			this.combob_Date.Size = new System.Drawing.Size(128, 21);
			this.combob_Date.TabIndex = 1;
			// 
			// radiob_Same
			// 
			this.radiob_Same.Location = new System.Drawing.Point(303, 36);
			this.radiob_Same.Name = "radiob_Same";
			this.radiob_Same.Size = new System.Drawing.Size(55, 21);
			this.radiob_Same.TabIndex = 2;
			this.radiob_Same.TabStop = true;
			this.radiob_Same.Text = "Same";
			this.radiob_Same.UseVisualStyleBackColor = true;
			this.radiob_Same.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// lbl_DividendForecaster
			// 
			this.lbl_DividendForecaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DividendForecaster.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_DividendForecaster.Location = new System.Drawing.Point(12, 9);
			this.lbl_DividendForecaster.Name = "lbl_DividendForecaster";
			this.lbl_DividendForecaster.Size = new System.Drawing.Size(212, 52);
			this.lbl_DividendForecaster.TabIndex = 3;
			this.lbl_DividendForecaster.Text = "Dividend Forecaster";
			this.lbl_DividendForecaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbl_Amount);
			this.panel1.Controls.Add(this.lbl_Prediction);
			this.panel1.Controls.Add(this.txtb_Amount);
			this.panel1.Controls.Add(this.txtb_Prediction);
			this.panel1.Location = new System.Drawing.Point(0, 88);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(209, 301);
			this.panel1.TabIndex = 4;
			// 
			// lbl_Amount
			// 
			this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Amount.Location = new System.Drawing.Point(111, 13);
			this.lbl_Amount.Name = "lbl_Amount";
			this.lbl_Amount.Size = new System.Drawing.Size(91, 22);
			this.lbl_Amount.TabIndex = 1;
			this.lbl_Amount.Text = "Amount";
			this.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Prediction
			// 
			this.lbl_Prediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Prediction.Location = new System.Drawing.Point(12, 13);
			this.lbl_Prediction.Name = "lbl_Prediction";
			this.lbl_Prediction.Size = new System.Drawing.Size(85, 22);
			this.lbl_Prediction.TabIndex = 1;
			this.lbl_Prediction.Text = "Prediction";
			this.lbl_Prediction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtb_Amount
			// 
			this.txtb_Amount.Location = new System.Drawing.Point(111, 48);
			this.txtb_Amount.Multiline = true;
			this.txtb_Amount.Name = "txtb_Amount";
			this.txtb_Amount.Size = new System.Drawing.Size(91, 250);
			this.txtb_Amount.TabIndex = 0;
			this.txtb_Amount.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
			// 
			// txtb_Prediction
			// 
			this.txtb_Prediction.Location = new System.Drawing.Point(12, 48);
			this.txtb_Prediction.Multiline = true;
			this.txtb_Prediction.Name = "txtb_Prediction";
			this.txtb_Prediction.Size = new System.Drawing.Size(85, 250);
			this.txtb_Prediction.TabIndex = 0;
			this.txtb_Prediction.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
			// 
			// lbl_Upper
			// 
			this.lbl_Upper.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Upper.Location = new System.Drawing.Point(215, 155);
			this.lbl_Upper.Name = "lbl_Upper";
			this.lbl_Upper.Size = new System.Drawing.Size(210, 44);
			this.lbl_Upper.TabIndex = 5;
			this.lbl_Upper.Text = "Upper:";
			this.lbl_Upper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// radiob_Different
			// 
			this.radiob_Different.Location = new System.Drawing.Point(230, 36);
			this.radiob_Different.Name = "radiob_Different";
			this.radiob_Different.Size = new System.Drawing.Size(67, 21);
			this.radiob_Different.TabIndex = 2;
			this.radiob_Different.TabStop = true;
			this.radiob_Different.Text = "Different";
			this.radiob_Different.UseVisualStyleBackColor = true;
			this.radiob_Different.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// lbl_Median
			// 
			this.lbl_Median.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Median.Location = new System.Drawing.Point(215, 210);
			this.lbl_Median.Name = "lbl_Median";
			this.lbl_Median.Size = new System.Drawing.Size(210, 44);
			this.lbl_Median.TabIndex = 5;
			this.lbl_Median.Text = "Median:";
			this.lbl_Median.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Lower
			// 
			this.lbl_Lower.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Lower.Location = new System.Drawing.Point(215, 266);
			this.lbl_Lower.Name = "lbl_Lower";
			this.lbl_Lower.Size = new System.Drawing.Size(210, 44);
			this.lbl_Lower.TabIndex = 5;
			this.lbl_Lower.Text = "Lower:";
			this.lbl_Lower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DividendForecaster
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(437, 401);
			this.Controls.Add(this.lbl_Lower);
			this.Controls.Add(this.lbl_Median);
			this.Controls.Add(this.lbl_Upper);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbl_DividendForecaster);
			this.Controls.Add(this.radiob_Different);
			this.Controls.Add(this.radiob_Same);
			this.Controls.Add(this.combob_Date);
			this.Controls.Add(this.picb_dividend);
			this.MaximizeBox = false;
			this.Name = "DividendForecaster";
			this.Text = "DividendForecaster";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DividendForecasterFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.picb_dividend)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_Lower;
		private System.Windows.Forms.Label lbl_Median;
		private System.Windows.Forms.TextBox txtb_Prediction;
		private System.Windows.Forms.TextBox txtb_Amount;
		private System.Windows.Forms.Label lbl_Prediction;
		private System.Windows.Forms.Label lbl_Amount;
		private System.Windows.Forms.RadioButton radiob_Different;
		private System.Windows.Forms.Label lbl_Upper;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_DividendForecaster;
		private System.Windows.Forms.RadioButton radiob_Same;
		private System.Windows.Forms.ComboBox combob_Date;
		private System.Windows.Forms.PictureBox picb_dividend;
	}
}
