/*
 * Created by SharpDevelop.
 * User: Will 2nd
 * Date: 16/04/2016
 * Time: 18:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Forward_Calculator
{
	partial class StockViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockViewer));
			this.picb_Refresh = new System.Windows.Forms.PictureBox();
			this.picb_Chart = new System.Windows.Forms.PictureBox();
			this.openF_stock = new System.Windows.Forms.OpenFileDialog();
			this.lbl_StockName = new System.Windows.Forms.Label();
			this.lbl_Price = new System.Windows.Forms.Label();
			this.lbl_Dividend = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picb_Refresh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picb_Chart)).BeginInit();
			this.SuspendLayout();
			// 
			// picb_Refresh
			// 
			this.picb_Refresh.BackColor = System.Drawing.Color.Transparent;
			this.picb_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("picb_Refresh.Image")));
			this.picb_Refresh.Location = new System.Drawing.Point(-2, -1);
			this.picb_Refresh.Name = "picb_Refresh";
			this.picb_Refresh.Size = new System.Drawing.Size(440, 80);
			this.picb_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picb_Refresh.TabIndex = 0;
			this.picb_Refresh.TabStop = false;
			this.picb_Refresh.Click += new System.EventHandler(this.Picb_RefreshClick);
			// 
			// picb_Chart
			// 
			this.picb_Chart.Image = ((System.Drawing.Image)(resources.GetObject("picb_Chart.Image")));
			this.picb_Chart.Location = new System.Drawing.Point(-1, 76);
			this.picb_Chart.Name = "picb_Chart";
			this.picb_Chart.Size = new System.Drawing.Size(438, 326);
			this.picb_Chart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picb_Chart.TabIndex = 1;
			this.picb_Chart.TabStop = false;
			// 
			// openF_stock
			// 
			this.openF_stock.Filter = "\"Xml files (*.xml)|*.xml|All files (*.*)|*.*\"";
			this.openF_stock.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenF_stockFileOk);
			// 
			// lbl_StockName
			// 
			this.lbl_StockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_StockName.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_StockName.Location = new System.Drawing.Point(12, 9);
			this.lbl_StockName.Name = "lbl_StockName";
			this.lbl_StockName.Size = new System.Drawing.Size(156, 52);
			this.lbl_StockName.TabIndex = 2;
			this.lbl_StockName.Text = "label1";
			this.lbl_StockName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Price
			// 
			this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Price.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_Price.Location = new System.Drawing.Point(174, 9);
			this.lbl_Price.Name = "lbl_Price";
			this.lbl_Price.Size = new System.Drawing.Size(87, 52);
			this.lbl_Price.TabIndex = 2;
			this.lbl_Price.Text = "label1";
			this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Dividend
			// 
			this.lbl_Dividend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Dividend.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_Dividend.Location = new System.Drawing.Point(267, 9);
			this.lbl_Dividend.Name = "lbl_Dividend";
			this.lbl_Dividend.Size = new System.Drawing.Size(87, 52);
			this.lbl_Dividend.TabIndex = 2;
			this.lbl_Dividend.Text = "label1";
			this.lbl_Dividend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StockViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(437, 401);
			this.Controls.Add(this.lbl_Dividend);
			this.Controls.Add(this.lbl_Price);
			this.Controls.Add(this.lbl_StockName);
			this.Controls.Add(this.picb_Refresh);
			this.Controls.Add(this.picb_Chart);
			this.MaximizeBox = false;
			this.Name = "StockViewer";
			this.Text = "StockViewer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockViewerFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.picb_Refresh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picb_Chart)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_Dividend;
		private System.Windows.Forms.Label lbl_Price;
		private System.Windows.Forms.Label lbl_StockName;
		private System.Windows.Forms.OpenFileDialog openF_stock;
		private System.Windows.Forms.PictureBox picb_Chart;
		private System.Windows.Forms.PictureBox picb_Refresh;
	}
}
