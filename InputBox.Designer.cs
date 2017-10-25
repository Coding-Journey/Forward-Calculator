/*
 * Created by SharpDevelop.
 * User: Will 2nd
 * Date: 17/04/2016
 * Time: 19:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Forward_Calculator
{
	partial class InputBox
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
			this.txt_StockName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txt_StockName
			// 
			this.txt_StockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_StockName.Location = new System.Drawing.Point(3, 12);
			this.txt_StockName.Name = "txt_StockName";
			this.txt_StockName.Size = new System.Drawing.Size(202, 38);
			this.txt_StockName.TabIndex = 0;
			this.txt_StockName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
			// 
			// InputBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(210, 60);
			this.Controls.Add(this.txt_StockName);
			this.Name = "InputBox";
			this.Text = "InputBox";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txt_StockName;
	}
}
