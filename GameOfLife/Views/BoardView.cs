using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfLife.Controllers;
using System.IO;
using GameOfLife.Models;

namespace GameOfLife.Views {
	public partial class BoardView : Form, IBoardView {

		/// <summary>
		/// Reference to the controller
		/// </summary>
		private IBoardController controller;

		/// <summary>
		/// Registers the controller reference to pass events.
		/// </summary>
		/// <param name="controller"></param>
		public void RegisterObserver(IBoardController controller) {
			this.controller = controller;
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		public BoardView() {
			InitializeComponent();
			// Show cell borders in the tablelayoutpanel representing the board
			this.Board.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			// Disallow resizing of window
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			// Assign repetitive click events in one neat, tidy place
			this.AssignLifeSpanClickEvents();
			this.AssignTemplateClickEvents();
			/*
			 * Initialize every cell in the board by adding a custom Panel, "BoardPanel", to it and
			 * setting the panel to fill the cell, color it white, and set its click event 
			 */
			for (int i = 0; i < Board.ColumnCount; i++) {
				for (int j = 0; j < Board.RowCount; j++) {
					BoardPanel panel = new BoardPanel(i, j);
					panel.Click += BoardPanel_Click;
					panel.Margin = Padding.Empty;
					panel.Dock = DockStyle.Fill;
					panel.BackColor = Color.White;
					Board.Controls.Add(panel);
					this.Board.SetCellPosition(panel, new TableLayoutPanelCellPosition(i, j));
				}
			}			
		}

		private void AssignLifeSpanClickEvents() {
			this.LifeSpan60MenuItem.Click += (sender, args) => { RefreshRateChange_Click(sender, new RefreshRateEventArgs(60)); };
			this.LifeSpan125MenuItem.Click += (sender, args) => { RefreshRateChange_Click(sender, new RefreshRateEventArgs(125)); };
			this.LifeSpan250MenuItem.Click += (sender, args) => { RefreshRateChange_Click(sender, new RefreshRateEventArgs(250)); };
			this.LifeSpan375MenuItem.Click += (sender, args) => { RefreshRateChange_Click(sender, new RefreshRateEventArgs(375)); };
			this.LifeSpan500MenuItem.Click += (sender, args) => { RefreshRateChange_Click(sender, new RefreshRateEventArgs(500)); };
			this.LifeSpan625MenuItem.Click += (sender, args) => { RefreshRateChange_Click(sender, new RefreshRateEventArgs(625)); };
			this.LifeSpan750MenuItem.Click += (sender, args) => { RefreshRateChange_Click(sender, new RefreshRateEventArgs(750)); };
			this.LifeSpan875MenuItem.Click += (sender, args) => { RefreshRateChange_Click(sender, new RefreshRateEventArgs(875)); };
			this.LifeSpan100MenuItem.Click += (sender, args) => { RefreshRateChange_Click(sender, new RefreshRateEventArgs(1000)); };

		}

		private void AssignTemplateClickEvents() {
			this.BlinkerMenuItem.Click += (sender, args) => { this.Template_Click(sender, new TemplateEventArgs(TemplateType.BLINKER)); };
			this.GliderMenuItem.Click += (sender, args) => { this.Template_Click(sender, new TemplateEventArgs(TemplateType.GLIDER)); };
			this.DiehardMenuItem.Click += (sender, args) => { this.Template_Click(sender, new TemplateEventArgs(TemplateType.DIE_HARD)); };
			this.PulsarMenuItem.Click += (sender, args) => { this.Template_Click(sender, new TemplateEventArgs(TemplateType.PULSAR)); };
			this.RPentominoMenuItem.Click += (sender, args) => { this.Template_Click(sender, new TemplateEventArgs(TemplateType.RPENTOMINO)); };
			this.BlockyBlockMenuItem.Click += (sender, args) => { this.Template_Click(sender, new TemplateEventArgs(TemplateType.BLOCKY_BLOCK)); };
			this.SpaceShipMenuItem.Click += (sender, args) => { this.Template_Click(sender, new TemplateEventArgs(TemplateType.SPACESHIP)); };

		}

		protected void BoardPanel_Click(object sender, EventArgs e) {
			BoardPanel panel = (BoardPanel) sender;
			this.controller.HandleBoardCellClick(panel.Row, panel.Column);
		}

		public void UpdateCellState(int column, int row, bool selected) {
			BoardPanel panel = (BoardPanel) this.Board.GetControlFromPosition(column, row);
			if (selected) {
				panel.BackColor = Color.Black;
			} else {
				panel.BackColor = Color.White;
			}
		}

		public void Reset() {
			foreach (BoardPanel panel in this.Board.Controls) {
				panel.BackColor = Color.White;
			}
		}

		private void LoadFileMenuItem_Click(object sender, EventArgs e) {
			this.LoadFileDialog.ShowDialog();
			string filePath = LoadFileDialog.FileName;
			if (File.Exists(filePath)) {
				this.controller.HandleLoadCustomTemplate(filePath);
			}
		}

		private void RefreshRateChange_Click(object sender, RefreshRateEventArgs e) {
			this.controller.HandleRefreshRateChange(e.RefreshRate);
		}

		private void Template_Click(object sender, TemplateEventArgs e) {
			this.controller.HandleLoadTemplate(e.TypeOfTemplate);
		}

		private void GenerateTemplateMenuItem_Click(object sender, EventArgs e) {
			this.TemplateFolderDialog.ShowDialog();
			try {
				string folderPath = this.TemplateFolderDialog.SelectedPath;
				this.controller.HandleGenerateBlankTemplate(folderPath);
			} catch {
				MessageBox.Show("Unable to generate template in the given location", "Error: Invalid location");
			}
		}

		private void HelpMenuItem_Click(object sender, EventArgs e) {
			HowToForm howToForm = new HowToForm();
			howToForm.Show();
		}

		private void BeginButton_Click(object sender, EventArgs e) {
			this.controller.HandleBeginButtonClick();
		}

		private void ResetButton_Click(object sender, EventArgs e) {
			this.controller.Reset();
		}
	}
}
