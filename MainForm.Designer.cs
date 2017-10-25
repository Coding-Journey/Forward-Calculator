/*
 * Created by SharpDevelop.
 * User: Will 2nd
 * Date: 09/01/2016
 * Time: 13:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Forward_Calculator
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.upDn_Days = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.picb_SelectStock = new System.Windows.Forms.PictureBox();
			this.picb_DividendForecast = new System.Windows.Forms.PictureBox();
			this.picb_CalculateForward = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.upDn_Days)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picb_SelectStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picb_DividendForecast)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picb_CalculateForward)).BeginInit();
			this.SuspendLayout();
			// 
			// upDn_Days
			// 
			this.upDn_Days.Location = new System.Drawing.Point(144, 10);
			this.upDn_Days.Maximum = new decimal(new int[] {
									360,
									0,
									0,
									0});
			this.upDn_Days.Name = "upDn_Days";
			this.upDn_Days.Size = new System.Drawing.Size(120, 20);
			this.upDn_Days.TabIndex = 1;
			this.upDn_Days.ValueChanged += new System.EventHandler(this.UpDn_DaysValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Time until Maturity (Days)";
			// 
			// picb_SelectStock
			// 
			this.picb_SelectStock.Image = ((System.Drawing.Image)(resources.GetObject("picb_SelectStock.Image")));
			this.picb_SelectStock.Location = new System.Drawing.Point(12, 36);
			this.picb_SelectStock.Name = "picb_SelectStock";
			this.picb_SelectStock.Size = new System.Drawing.Size(200, 200);
			this.picb_SelectStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picb_SelectStock.TabIndex = 3;
			this.picb_SelectStock.TabStop = false;
			this.picb_SelectStock.Click += new System.EventHandler(this.OptionSelected);
			// 
			// picb_DividendForecast
			// 
			this.picb_DividendForecast.Image = ((System.Drawing.Image)(resources.GetObject("picb_DividendForecast.Image")));
			this.picb_DividendForecast.Location = new System.Drawing.Point(218, 36);
			this.picb_DividendForecast.Name = "picb_DividendForecast";
			this.picb_DividendForecast.Size = new System.Drawing.Size(200, 200);
			this.picb_DividendForecast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picb_DividendForecast.TabIndex = 4;
			this.picb_DividendForecast.TabStop = false;
			this.picb_DividendForecast.Click += new System.EventHandler(this.OptionSelected);
			// 
			// picb_CalculateForward
			// 
			this.picb_CalculateForward.Image = ((System.Drawing.Image)(resources.GetObject("picb_CalculateForward.Image")));
			this.picb_CalculateForward.Location = new System.Drawing.Point(424, 36);
			this.picb_CalculateForward.Name = "picb_CalculateForward";
			this.picb_CalculateForward.Size = new System.Drawing.Size(200, 200);
			this.picb_CalculateForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picb_CalculateForward.TabIndex = 5;
			this.picb_CalculateForward.TabStop = false;
			this.picb_CalculateForward.Click += new System.EventHandler(this.OptionSelected);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(629, 241);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.upDn_Days);
			this.Controls.Add(this.picb_SelectStock);
			this.Controls.Add(this.picb_CalculateForward);
			this.Controls.Add(this.picb_DividendForecast);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "FoCal";
			((System.ComponentModel.ISupportInitialize)(this.upDn_Days)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picb_SelectStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picb_DividendForecast)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picb_CalculateForward)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox picb_CalculateForward;
		private System.Windows.Forms.PictureBox picb_DividendForecast;
		private System.Windows.Forms.PictureBox picb_SelectStock;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown upDn_Days;
	}
}
