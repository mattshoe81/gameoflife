namespace GameOfLife.Views {
	partial class SizeForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.SizeTextBox = new System.Windows.Forms.TextBox();
			this.UpdateSizeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number of Columns:";
			// 
			// SizeTextBox
			// 
			this.SizeTextBox.Location = new System.Drawing.Point(343, 57);
			this.SizeTextBox.Name = "SizeTextBox";
			this.SizeTextBox.Size = new System.Drawing.Size(123, 38);
			this.SizeTextBox.TabIndex = 1;
			// 
			// UpdateSizeButton
			// 
			this.UpdateSizeButton.Location = new System.Drawing.Point(515, 48);
			this.UpdateSizeButton.Name = "UpdateSizeButton";
			this.UpdateSizeButton.Size = new System.Drawing.Size(150, 61);
			this.UpdateSizeButton.TabIndex = 2;
			this.UpdateSizeButton.Text = "Update";
			this.UpdateSizeButton.UseVisualStyleBackColor = true;
			this.UpdateSizeButton.Click += new System.EventHandler(this.UpdateSizeButton_Click);
			// 
			// SizeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 150);
			this.Controls.Add(this.UpdateSizeButton);
			this.Controls.Add(this.SizeTextBox);
			this.Controls.Add(this.label1);
			this.Name = "SizeForm";
			this.Text = "SizeForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SizeTextBox;
		private System.Windows.Forms.Button UpdateSizeButton;
	}
}