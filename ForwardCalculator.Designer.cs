/*
 * Created by SharpDevelop.
 * User: Will 2nd
 * Date: 19/04/2016
 * Time: 18:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Forward_Calculator
{
	partial class ForwardCalculator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForwardCalculator));
			this.picb_ForwardCalculator = new System.Windows.Forms.PictureBox();
			this.saveF_Forward = new System.Windows.Forms.SaveFileDialog();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.lbl_Price = new System.Windows.Forms.Label();
			this.lbl_StockName = new System.Windows.Forms.Label();
			this.lbl_Days = new System.Windows.Forms.Label();
			this.lbl_Dividends = new System.Windows.Forms.Label();
			this.lbl_Bounds = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picb_ForwardCalculator)).BeginInit();
			this.SuspendLayout();
			// 
			// picb_ForwardCalculator
			// 
			this.picb_ForwardCalculator.Image = ((System.Drawing.Image)(resources.GetObject("picb_ForwardCalculator.Image")));
			this.picb_ForwardCalculator.Location = new System.Drawing.Point(-1, -1);
			this.picb_ForwardCalculator.Name = "picb_ForwardCalculator";
			this.picb_ForwardCalculator.Size = new System.Drawing.Size(438, 80);
			this.picb_ForwardCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picb_ForwardCalculator.TabIndex = 1;
			this.picb_ForwardCalculator.TabStop = false;
			this.picb_ForwardCalculator.Click += new System.EventHandler(this.picbClick);
			// 
			// saveF_Forward
			// 
			this.saveF_Forward.Filter = "\"png files (*.png)|*.png|All files (*.*)|*.*\"";
			this.saveF_Forward.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveF_ForwardFileOk);
			// 
			// lbl_Date
			// 
			this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Date.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_Date.Location = new System.Drawing.Point(256, 9);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(98, 52);
			this.lbl_Date.TabIndex = 5;
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Price
			// 
			this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Price.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_Price.Location = new System.Drawing.Point(174, 9);
			this.lbl_Price.Name = "lbl_Price";
			this.lbl_Price.Size = new System.Drawing.Size(76, 52);
			this.lbl_Price.TabIndex = 4;
			this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_StockName
			// 
			this.lbl_StockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_StockName.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_StockName.Location = new System.Drawing.Point(12, 9);
			this.lbl_StockName.Name = "lbl_StockName";
			this.lbl_StockName.Size = new System.Drawing.Size(156, 52);
			this.lbl_StockName.TabIndex = 3;
			this.lbl_StockName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Days
			// 
			this.lbl_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Days.Location = new System.Drawing.Point(12, 86);
			this.lbl_Days.Name = "lbl_Days";
			this.lbl_Days.Size = new System.Drawing.Size(175, 46);
			this.lbl_Days.TabIndex = 6;
			this.lbl_Days.Text = "___ Days";
			// 
			// lbl_Dividends
			// 
			this.lbl_Dividends.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Dividends.Location = new System.Drawing.Point(208, 86);
			this.lbl_Dividends.Name = "lbl_Dividends";
			this.lbl_Dividends.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_Dividends.Size = new System.Drawing.Size(217, 46);
			this.lbl_Dividends.TabIndex = 6;
			this.lbl_Dividends.Text = "__ Dividends";
			// 
			// lbl_Bounds
			// 
			this.lbl_Bounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Bounds.Location = new System.Drawing.Point(13, 166);
			this.lbl_Bounds.Name = "lbl_Bounds";
			this.lbl_Bounds.Size = new System.Drawing.Size(412, 200);
			this.lbl_Bounds.TabIndex = 7;
			this.lbl_Bounds.Text = "Upper: ----\r\n\r\nMedian: --\r\n\r\nLower: ----\r\n";
			this.lbl_Bounds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ForwardCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(437, 401);
			this.Controls.Add(this.lbl_Bounds);
			this.Controls.Add(this.lbl_Dividends);
			this.Controls.Add(this.lbl_Days);
			this.Controls.Add(this.lbl_Date);
			this.Controls.Add(this.lbl_Price);
			this.Controls.Add(this.lbl_StockName);
			this.Controls.Add(this.picb_ForwardCalculator);
			this.Name = "ForwardCalculator";
			this.Text = "ForwardCalculator";
			this.Load += new System.EventHandler(this.ForwardCalculatorLoad);
			((System.ComponentModel.ISupportInitialize)(this.picb_ForwardCalculator)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_Bounds;
		private System.Windows.Forms.Label lbl_Dividends;
		private System.Windows.Forms.Label lbl_Days;
		private System.Windows.Forms.Label lbl_StockName;
		private System.Windows.Forms.Label lbl_Price;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.SaveFileDialog saveF_Forward;
		private System.Windows.Forms.PictureBox picb_ForwardCalculator;
	}
}
