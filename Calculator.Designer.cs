/*
 * Created by SharpDevelop.
 * User: Will 2nd
 * Date: 09/01/2016
 * Time: 14:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Forward_Calculator
{
	partial class Calculator
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
			this.txtb_TimePeriod = new System.Windows.Forms.TextBox();
			this.lbl_TimePeriod = new System.Windows.Forms.Label();
			this.lbl_Bounds = new System.Windows.Forms.Label();
			this.Updn_InterestRegion = new System.Windows.Forms.DomainUpDown();
			this.SuspendLayout();
			// 
			// txtb_TimePeriod
			// 
			this.txtb_TimePeriod.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtb_TimePeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtb_TimePeriod.Location = new System.Drawing.Point(121, 3);
			this.txtb_TimePeriod.Multiline = true;
			this.txtb_TimePeriod.Name = "txtb_TimePeriod";
			this.txtb_TimePeriod.Size = new System.Drawing.Size(100, 20);
			this.txtb_TimePeriod.TabIndex = 0;
			this.txtb_TimePeriod.TextChanged += new System.EventHandler(this.ValuesChanged);
			// 
			// lbl_TimePeriod
			// 
			this.lbl_TimePeriod.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lbl_TimePeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_TimePeriod.Location = new System.Drawing.Point(3, 3);
			this.lbl_TimePeriod.Name = "lbl_TimePeriod";
			this.lbl_TimePeriod.Size = new System.Drawing.Size(112, 20);
			this.lbl_TimePeriod.TabIndex = 1;
			this.lbl_TimePeriod.Text = "Time Period";
			// 
			// lbl_Bounds
			// 
			this.lbl_Bounds.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lbl_Bounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_Bounds.Location = new System.Drawing.Point(4, 26);
			this.lbl_Bounds.Name = "lbl_Bounds";
			this.lbl_Bounds.Size = new System.Drawing.Size(445, 115);
			this.lbl_Bounds.TabIndex = 3;
			// 
			// Updn_InterestRegion
			// 
			this.Updn_InterestRegion.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.Updn_InterestRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Updn_InterestRegion.Location = new System.Drawing.Point(329, 4);
			this.Updn_InterestRegion.Name = "Updn_InterestRegion";
			this.Updn_InterestRegion.Size = new System.Drawing.Size(120, 20);
			this.Updn_InterestRegion.TabIndex = 2;
			this.Updn_InterestRegion.Text = "Interest Region";
			this.Updn_InterestRegion.Visible = false;
			this.Updn_InterestRegion.TextChanged += new System.EventHandler(this.ValuesChanged);
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbl_Bounds);
			this.Controls.Add(this.Updn_InterestRegion);
			this.Controls.Add(this.lbl_TimePeriod);
			this.Controls.Add(this.txtb_TimePeriod);
			this.Name = "Calculator";
			this.Size = new System.Drawing.Size(452, 141);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DomainUpDown Updn_InterestRegion;
		private System.Windows.Forms.Label lbl_Bounds;
		private System.Windows.Forms.Label lbl_TimePeriod;
		private System.Windows.Forms.TextBox txtb_TimePeriod;
	}
}
