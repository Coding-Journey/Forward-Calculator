/*
 * Created by SharpDevelop.
 * User: Will 2nd
 * Date: 09/01/2016
 * Time: 17:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Forward_Calculator
{
	partial class DividendTable
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.txtb_Prediction = new System.Windows.Forms.TextBox();
			this.txtb_Amount = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtb_Prediction
			// 
			this.txtb_Prediction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtb_Prediction.Location = new System.Drawing.Point(4, 4);
			this.txtb_Prediction.Multiline = true;
			this.txtb_Prediction.Name = "txtb_Prediction";
			this.txtb_Prediction.Size = new System.Drawing.Size(91, 132);
			this.txtb_Prediction.TabIndex = 0;
			this.txtb_Prediction.Text = "Prediction";
			this.txtb_Prediction.TextChanged += new System.EventHandler(this.TextChanged);
			// 
			// txtb_Amount
			// 
			this.txtb_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtb_Amount.Location = new System.Drawing.Point(99, 4);
			this.txtb_Amount.Multiline = true;
			this.txtb_Amount.Name = "txtb_Amount";
			this.txtb_Amount.Size = new System.Drawing.Size(91, 132);
			this.txtb_Amount.TabIndex = 0;
			this.txtb_Amount.Text = "Amount";
			this.txtb_Amount.TextChanged += new System.EventHandler(this.TextChanged);
			// 
			// DividendTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtb_Amount);
			this.Controls.Add(this.txtb_Prediction);
			this.Name = "DividendTable";
			this.Size = new System.Drawing.Size(193, 146);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtb_Amount;
		private System.Windows.Forms.TextBox txtb_Prediction;
	}
}
