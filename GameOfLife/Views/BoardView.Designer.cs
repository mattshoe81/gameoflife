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
			this.board = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.lifeSpan60 = new System.Windows.Forms.ToolStripMenuItem();
			this.lifeSpan125 = new System.Windows.Forms.ToolStripMenuItem();
			this.lifeSpan250 = new System.Windows.Forms.ToolStripMenuItem();
			this.lifeSpan375 = new System.Windows.Forms.ToolStripMenuItem();
			this.lifeSpan500 = new System.Windows.Forms.ToolStripMenuItem();
			this.lifeSpan625 = new System.Windows.Forms.ToolStripMenuItem();
			this.lifeSpan750 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.resetButton = new System.Windows.Forms.Button();
			this.beginButton = new System.Windows.Forms.Button();
			this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blinkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.diehardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pulsarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rPentominoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blockyBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spaceShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// board
			// 
			this.board.ColumnCount = 20;
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.Dock = System.Windows.Forms.DockStyle.Top;
			this.board.ForeColor = System.Drawing.SystemColors.ControlText;
			this.board.Location = new System.Drawing.Point(0, 52);
			this.board.Name = "board";
			this.board.RowCount = 20;
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.board.Size = new System.Drawing.Size(1168, 980);
			this.board.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.generationsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1168, 52);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 48);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadFileToolStripMenuItem
			// 
			this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
			this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(250, 46);
			this.loadFileToolStripMenuItem.Text = "Load File";
			this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
			// 
			// generationsToolStripMenuItem
			// 
			this.generationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.templatesToolStripMenuItem});
			this.generationsToolStripMenuItem.Name = "generationsToolStripMenuItem";
			this.generationsToolStripMenuItem.Size = new System.Drawing.Size(190, 48);
			this.generationsToolStripMenuItem.Text = "Generations";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lifeSpan60,
            this.lifeSpan125,
            this.lifeSpan250,
            this.lifeSpan375,
            this.lifeSpan500,
            this.lifeSpan625,
            this.lifeSpan750,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(396, 46);
			this.toolStripMenuItem1.Text = "LifeSpan";
			// 
			// lifeSpan60
			// 
			this.lifeSpan60.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lifeSpan60.Name = "lifeSpan60";
			this.lifeSpan60.Size = new System.Drawing.Size(252, 46);
			this.lifeSpan60.Text = "60 ms";
			this.lifeSpan60.Click += new System.EventHandler(this.lifeSpan60_Click);
			// 
			// lifeSpan125
			// 
			this.lifeSpan125.Name = "lifeSpan125";
			this.lifeSpan125.Size = new System.Drawing.Size(252, 46);
			this.lifeSpan125.Text = "125 ms";
			this.lifeSpan125.Click += new System.EventHandler(this.lifeSpan125_Click);
			// 
			// lifeSpan250
			// 
			this.lifeSpan250.Name = "lifeSpan250";
			this.lifeSpan250.Size = new System.Drawing.Size(252, 46);
			this.lifeSpan250.Text = "250 ms";
			// 
			// lifeSpan375
			// 
			this.lifeSpan375.Name = "lifeSpan375";
			this.lifeSpan375.Size = new System.Drawing.Size(252, 46);
			this.lifeSpan375.Text = "375 ms";
			this.lifeSpan375.Click += new System.EventHandler(this.lifeSpan375_Click);
			// 
			// lifeSpan500
			// 
			this.lifeSpan500.Name = "lifeSpan500";
			this.lifeSpan500.Size = new System.Drawing.Size(252, 46);
			this.lifeSpan500.Text = "500 ms";
			this.lifeSpan500.Click += new System.EventHandler(this.lifeSpan500_Click);
			// 
			// lifeSpan625
			// 
			this.lifeSpan625.Name = "lifeSpan625";
			this.lifeSpan625.Size = new System.Drawing.Size(252, 46);
			this.lifeSpan625.Text = "625 ms";
			this.lifeSpan625.Click += new System.EventHandler(this.lifeSpan625_Click);
			// 
			// lifeSpan750
			// 
			this.lifeSpan750.Name = "lifeSpan750";
			this.lifeSpan750.Size = new System.Drawing.Size(252, 46);
			this.lifeSpan750.Text = "750 ms";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(252, 46);
			this.toolStripMenuItem9.Text = "875 ms";
			this.toolStripMenuItem9.Click += new System.EventHandler(this.lifeSpan875_Click);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(252, 46);
			this.toolStripMenuItem10.Text = "1 second";
			this.toolStripMenuItem10.Click += new System.EventHandler(this.lifeSpan1000_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.resetButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.beginButton, 1, 0);
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
			// resetButton
			// 
			this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resetButton.Location = new System.Drawing.Point(3, 3);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(578, 94);
			this.resetButton.TabIndex = 0;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// beginButton
			// 
			this.beginButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.beginButton.Location = new System.Drawing.Point(587, 3);
			this.beginButton.Name = "beginButton";
			this.beginButton.Size = new System.Drawing.Size(578, 94);
			this.beginButton.TabIndex = 1;
			this.beginButton.Text = "Let there be life!";
			this.beginButton.UseVisualStyleBackColor = true;
			this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
			// 
			// templatesToolStripMenuItem
			// 
			this.templatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blinkerToolStripMenuItem,
            this.gliderToolStripMenuItem,
            this.diehardToolStripMenuItem,
            this.pulsarToolStripMenuItem,
            this.rPentominoToolStripMenuItem,
            this.blockyBlockToolStripMenuItem,
            this.spaceShipToolStripMenuItem});
			this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
			this.templatesToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
			this.templatesToolStripMenuItem.Text = "Samples";
			// 
			// blinkerToolStripMenuItem
			// 
			this.blinkerToolStripMenuItem.Name = "blinkerToolStripMenuItem";
			this.blinkerToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
			this.blinkerToolStripMenuItem.Text = "Blinker";
			this.blinkerToolStripMenuItem.Click += new System.EventHandler(this.blinkerToolStripMenuItem_Click);
			// 
			// gliderToolStripMenuItem
			// 
			this.gliderToolStripMenuItem.Name = "gliderToolStripMenuItem";
			this.gliderToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
			this.gliderToolStripMenuItem.Text = "Glider";
			this.gliderToolStripMenuItem.Click += new System.EventHandler(this.gliderToolStripMenuItem_Click);
			// 
			// diehardToolStripMenuItem
			// 
			this.diehardToolStripMenuItem.Name = "diehardToolStripMenuItem";
			this.diehardToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
			this.diehardToolStripMenuItem.Text = "Diehard";
			this.diehardToolStripMenuItem.Click += new System.EventHandler(this.diehardToolStripMenuItem_Click);
			// 
			// pulsarToolStripMenuItem
			// 
			this.pulsarToolStripMenuItem.Name = "pulsarToolStripMenuItem";
			this.pulsarToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
			this.pulsarToolStripMenuItem.Text = "Pulsar";
			this.pulsarToolStripMenuItem.Click += new System.EventHandler(this.pulsarToolStripMenuItem_Click);
			// 
			// rPentominoToolStripMenuItem
			// 
			this.rPentominoToolStripMenuItem.Name = "rPentominoToolStripMenuItem";
			this.rPentominoToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
			this.rPentominoToolStripMenuItem.Text = "R-Pentomino";
			this.rPentominoToolStripMenuItem.Click += new System.EventHandler(this.rPentominoToolStripMenuItem_Click);
			// 
			// blockyBlockToolStripMenuItem
			// 
			this.blockyBlockToolStripMenuItem.Name = "blockyBlockToolStripMenuItem";
			this.blockyBlockToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
			this.blockyBlockToolStripMenuItem.Text = "Blocky Block";
			this.blockyBlockToolStripMenuItem.Click += new System.EventHandler(this.blockyBlockToolStripMenuItem_Click);
			// 
			// spaceShipToolStripMenuItem
			// 
			this.spaceShipToolStripMenuItem.Name = "spaceShipToolStripMenuItem";
			this.spaceShipToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
			this.spaceShipToolStripMenuItem.Text = "SpaceShip";
			this.spaceShipToolStripMenuItem.Click += new System.EventHandler(this.spaceShipToolStripMenuItem_Click);
			// 
			// BoardView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1168, 1135);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.board);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "BoardView";
			this.Text = "Conway\'s Game of Life";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		

		private System.Windows.Forms.TableLayoutPanel board;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button beginButton;
		private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog LoadFileDialog;
		private System.Windows.Forms.ToolStripMenuItem generationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem lifeSpan60;
		private System.Windows.Forms.ToolStripMenuItem lifeSpan125;
		private System.Windows.Forms.ToolStripMenuItem lifeSpan250;
		private System.Windows.Forms.ToolStripMenuItem lifeSpan375;
		private System.Windows.Forms.ToolStripMenuItem lifeSpan500;
		private System.Windows.Forms.ToolStripMenuItem lifeSpan625;
		private System.Windows.Forms.ToolStripMenuItem lifeSpan750;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blinkerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gliderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem diehardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pulsarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rPentominoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blockyBlockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem spaceShipToolStripMenuItem;
	}
}

