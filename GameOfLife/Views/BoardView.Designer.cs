using GameOfLife.Models;

namespace GameOfLife.Views {
	partial class BoardView {
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
			this.Board = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadTemplateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GenerateTemplateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.LifeSpan60MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LifeSpan125MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LifeSpan250MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LifeSpan375MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LifeSpan500MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LifeSpan625MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LifeSpan750MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LifeSpan875MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LifeSpan100MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BlinkerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GliderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DiehardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PulsarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RPentominoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BlockyBlockMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SpaceShipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ResetButton = new System.Windows.Forms.Button();
			this.BeginButton = new System.Windows.Forms.Button();
			this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.TemplateFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Board
			// 
			this.Board.ColumnCount = 20;
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.Dock = System.Windows.Forms.DockStyle.Top;
			this.Board.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Board.Location = new System.Drawing.Point(0, 49);
			this.Board.Name = "Board";
			this.Board.RowCount = 20;
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.Board.Size = new System.Drawing.Size(1168, 980);
			this.Board.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.generationsToolStripMenuItem,
            this.HelpMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1168, 49);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadTemplateMenuItem,
            this.GenerateTemplateMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// LoadTemplateMenuItem
			// 
			this.LoadTemplateMenuItem.Name = "LoadTemplateMenuItem";
			this.LoadTemplateMenuItem.Size = new System.Drawing.Size(396, 46);
			this.LoadTemplateMenuItem.Text = "Load Template";
			this.LoadTemplateMenuItem.ToolTipText = "Load a template file which will automatically populate the board.";
			this.LoadTemplateMenuItem.Click += new System.EventHandler(this.LoadFileMenuItem_Click);
			// 
			// GenerateTemplateMenuItem
			// 
			this.GenerateTemplateMenuItem.Name = "GenerateTemplateMenuItem";
			this.GenerateTemplateMenuItem.Size = new System.Drawing.Size(396, 46);
			this.GenerateTemplateMenuItem.Text = "Generate Template";
			this.GenerateTemplateMenuItem.ToolTipText = "Generates a blank template in the selected folder";
			this.GenerateTemplateMenuItem.Click += new System.EventHandler(this.GenerateTemplateMenuItem_Click);
			// 
			// generationsToolStripMenuItem
			// 
			this.generationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.templatesToolStripMenuItem});
			this.generationsToolStripMenuItem.Name = "generationsToolStripMenuItem";
			this.generationsToolStripMenuItem.Size = new System.Drawing.Size(190, 45);
			this.generationsToolStripMenuItem.Text = "Generations";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LifeSpan60MenuItem,
            this.LifeSpan125MenuItem,
            this.LifeSpan250MenuItem,
            this.LifeSpan375MenuItem,
            this.LifeSpan500MenuItem,
            this.LifeSpan625MenuItem,
            this.LifeSpan750MenuItem,
            this.LifeSpan875MenuItem,
            this.LifeSpan100MenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(396, 46);
			this.toolStripMenuItem1.Text = "LifeSpan";
			this.toolStripMenuItem1.ToolTipText = "How often a new generation is spawned, in milliseconds.";
			// 
			// LifeSpan60MenuItem
			// 
			this.LifeSpan60MenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LifeSpan60MenuItem.Name = "LifeSpan60MenuItem";
			this.LifeSpan60MenuItem.Size = new System.Drawing.Size(396, 46);
			this.LifeSpan60MenuItem.Text = "60 ms";
			// 
			// LifeSpan125MenuItem
			// 
			this.LifeSpan125MenuItem.Name = "LifeSpan125MenuItem";
			this.LifeSpan125MenuItem.Size = new System.Drawing.Size(396, 46);
			this.LifeSpan125MenuItem.Text = "125 ms";
			// 
			// LifeSpan250MenuItem
			// 
			this.LifeSpan250MenuItem.Name = "LifeSpan250MenuItem";
			this.LifeSpan250MenuItem.Size = new System.Drawing.Size(396, 46);
			this.LifeSpan250MenuItem.Text = "250 ms";
			// 
			// LifeSpan375MenuItem
			// 
			this.LifeSpan375MenuItem.Name = "LifeSpan375MenuItem";
			this.LifeSpan375MenuItem.Size = new System.Drawing.Size(396, 46);
			this.LifeSpan375MenuItem.Text = "375 ms";
			// 
			// LifeSpan500MenuItem
			// 
			this.LifeSpan500MenuItem.Name = "LifeSpan500MenuItem";
			this.LifeSpan500MenuItem.Size = new System.Drawing.Size(396, 46);
			this.LifeSpan500MenuItem.Text = "500 ms";
			// 
			// LifeSpan625MenuItem
			// 
			this.LifeSpan625MenuItem.Name = "LifeSpan625MenuItem";
			this.LifeSpan625MenuItem.Size = new System.Drawing.Size(396, 46);
			this.LifeSpan625MenuItem.Text = "625 ms";
			// 
			// LifeSpan750MenuItem
			// 
			this.LifeSpan750MenuItem.Name = "LifeSpan750MenuItem";
			this.LifeSpan750MenuItem.Size = new System.Drawing.Size(396, 46);
			this.LifeSpan750MenuItem.Text = "750 ms";
			// 
			// LifeSpan875MenuItem
			// 
			this.LifeSpan875MenuItem.Name = "LifeSpan875MenuItem";
			this.LifeSpan875MenuItem.Size = new System.Drawing.Size(396, 46);
			this.LifeSpan875MenuItem.Text = "875 ms";
			// 
			// LifeSpan100MenuItem
			// 
			this.LifeSpan100MenuItem.Name = "LifeSpan100MenuItem";
			this.LifeSpan100MenuItem.Size = new System.Drawing.Size(396, 46);
			this.LifeSpan100MenuItem.Text = "1 second";
			// 
			// templatesToolStripMenuItem
			// 
			this.templatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlinkerMenuItem,
            this.GliderMenuItem,
            this.DiehardMenuItem,
            this.PulsarMenuItem,
            this.RPentominoMenuItem,
            this.BlockyBlockMenuItem,
            this.SpaceShipMenuItem});
			this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
			this.templatesToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
			this.templatesToolStripMenuItem.Text = "Samples";
			this.templatesToolStripMenuItem.ToolTipText = "Predefined configurations that will automatically populate the board.";
			// 
			// BlinkerMenuItem
			// 
			this.BlinkerMenuItem.Name = "BlinkerMenuItem";
			this.BlinkerMenuItem.Size = new System.Drawing.Size(396, 46);
			this.BlinkerMenuItem.Text = "Blinker";
			// 
			// GliderMenuItem
			// 
			this.GliderMenuItem.Name = "GliderMenuItem";
			this.GliderMenuItem.Size = new System.Drawing.Size(396, 46);
			this.GliderMenuItem.Text = "Glider";
			// 
			// DiehardMenuItem
			// 
			this.DiehardMenuItem.Name = "DiehardMenuItem";
			this.DiehardMenuItem.Size = new System.Drawing.Size(396, 46);
			this.DiehardMenuItem.Text = "Diehard";
			// 
			// PulsarMenuItem
			// 
			this.PulsarMenuItem.Name = "PulsarMenuItem";
			this.PulsarMenuItem.Size = new System.Drawing.Size(396, 46);
			this.PulsarMenuItem.Text = "Pulsar";
			// 
			// RPentominoMenuItem
			// 
			this.RPentominoMenuItem.Name = "RPentominoMenuItem";
			this.RPentominoMenuItem.Size = new System.Drawing.Size(396, 46);
			this.RPentominoMenuItem.Text = "R-Pentomino";
			// 
			// BlockyBlockMenuItem
			// 
			this.BlockyBlockMenuItem.Name = "BlockyBlockMenuItem";
			this.BlockyBlockMenuItem.Size = new System.Drawing.Size(396, 46);
			this.BlockyBlockMenuItem.Text = "Blocky Block";
			// 
			// SpaceShipMenuItem
			// 
			this.SpaceShipMenuItem.Name = "SpaceShipMenuItem";
			this.SpaceShipMenuItem.Size = new System.Drawing.Size(396, 46);
			this.SpaceShipMenuItem.Text = "SpaceShip";
			// 
			// HelpMenuItem
			// 
			this.HelpMenuItem.Name = "HelpMenuItem";
			this.HelpMenuItem.Size = new System.Drawing.Size(92, 45);
			this.HelpMenuItem.Text = "Help";
			this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.ResetButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.BeginButton, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1035);
			this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 100);
			this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 100);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 100);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// ResetButton
			// 
			this.ResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResetButton.Location = new System.Drawing.Point(3, 3);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(578, 94);
			this.ResetButton.TabIndex = 0;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// BeginButton
			// 
			this.BeginButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BeginButton.Location = new System.Drawing.Point(587, 3);
			this.BeginButton.Name = "BeginButton";
			this.BeginButton.Size = new System.Drawing.Size(578, 94);
			this.BeginButton.TabIndex = 1;
			this.BeginButton.Text = "Let there be life!";
			this.BeginButton.UseVisualStyleBackColor = true;
			this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
			// 
			// BoardView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1168, 1135);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.Board);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "BoardView";
			this.Text = "Conway\'s Game of Life";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		

		private System.Windows.Forms.TableLayoutPanel Board;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button BeginButton;
		private System.Windows.Forms.ToolStripMenuItem LoadTemplateMenuItem;
		private System.Windows.Forms.OpenFileDialog LoadFileDialog;
		private System.Windows.Forms.ToolStripMenuItem generationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem LifeSpan60MenuItem;
		private System.Windows.Forms.ToolStripMenuItem LifeSpan125MenuItem;
		private System.Windows.Forms.ToolStripMenuItem LifeSpan250MenuItem;
		private System.Windows.Forms.ToolStripMenuItem LifeSpan375MenuItem;
		private System.Windows.Forms.ToolStripMenuItem LifeSpan500MenuItem;
		private System.Windows.Forms.ToolStripMenuItem LifeSpan625MenuItem;
		private System.Windows.Forms.ToolStripMenuItem LifeSpan750MenuItem;
		private System.Windows.Forms.ToolStripMenuItem LifeSpan875MenuItem;
		private System.Windows.Forms.ToolStripMenuItem LifeSpan100MenuItem;
		private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem BlinkerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GliderMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DiehardMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PulsarMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RPentominoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem BlockyBlockMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SpaceShipMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
		private System.Windows.Forms.FolderBrowserDialog TemplateFolderDialog;
		private System.Windows.Forms.ToolStripMenuItem GenerateTemplateMenuItem;
	}
}

