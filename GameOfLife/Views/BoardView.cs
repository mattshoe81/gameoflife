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
using System.Drawing.Imaging;

namespace GameOfLife.Views {
	public partial class BoardView : Form {

		private Controller controller;
		public BoardBitmap board;

		public void RegisterObserver(Controller controller) {
			this.controller = controller;
		}

		public BoardView() {
			InitializeComponent();
			this.board = new BoardBitmap(this.pictureBox1.Width, this.pictureBox1.Height);
			this.pictureBox1.Image = this.board.GetBoard();
		}
		

		protected void BoardPanel_Click(object sender, EventArgs e) {
			BoardPanel panel = (BoardPanel) sender;
			this.controller.HandlePanelClick(panel.Row, panel.Column);
		}

		public void UpdateCellState(int column, int row, bool selected) {
		}

		private void beginButton_Click(object sender, EventArgs e) {
			this.controller.HandleBeginClick();
		}

		private void resetButton_Click(object sender, EventArgs e) {
			this.controller.Reset();
		}

		public void Reset() {
		}

		private void loadFileToolStripMenuItem_Click(object sender, EventArgs e) {
			this.LoadFileDialog.ShowDialog();
			string filePath = LoadFileDialog.FileName;
			if (File.Exists(filePath)) { 
				this.controller.LoadFile(filePath);
			}
		
		}

		private void lifeSpan60_Click(object sender, EventArgs e) {
			this.controller.SetRefreshInterval(60);
		}

		private void lifeSpan125_Click(object sender, EventArgs e) {
			this.controller.SetRefreshInterval(125);
		}

		private void lifeSpan250_Click(object sender, EventArgs e) {
			this.controller.SetRefreshInterval(250);
		}

		private void lifeSpan375_Click(object sender, EventArgs e) {
			this.controller.SetRefreshInterval(375);
		}

		private void lifeSpan500_Click(object sender, EventArgs e) {
			this.controller.SetRefreshInterval(500);
		}

		private void lifeSpan625_Click(object sender, EventArgs e) {
			this.controller.SetRefreshInterval(625);
		}

		private void lifeSpan750_Click(object sender, EventArgs e) {
			this.controller.SetRefreshInterval(750);
		}

		private void lifeSpan875_Click(object sender, EventArgs e) {
			this.controller.SetRefreshInterval(875);
		}

		private void lifeSpan1000_Click(object sender, EventArgs e) {
			this.controller.SetRefreshInterval(1000);
		}

		private void blinkerToolStripMenuItem_Click(object sender, EventArgs e) {
			this.controller.MakeTemplate("GameOfLife.Controllers.Templates.Blinker.txt");
		}

		private void gliderToolStripMenuItem_Click(object sender, EventArgs e) {
			this.controller.MakeTemplate("GameOfLife.Controllers.Templates.Glider.txt");
		}

		private void diehardToolStripMenuItem_Click(object sender, EventArgs e) {
			this.controller.MakeTemplate("GameOfLife.Controllers.Templates.Diehard.txt");
		}

		private void pulsarToolStripMenuItem_Click(object sender, EventArgs e) {
			this.controller.MakeTemplate("GameOfLife.Controllers.Templates.Pulsar.txt");
		}

		private void rPentominoToolStripMenuItem_Click(object sender, EventArgs e) {
			this.controller.MakeTemplate("GameOfLife.Controllers.Templates.R-Pentomino.txt");
		}

		private void blockyBlockToolStripMenuItem_Click(object sender, EventArgs e) {
			this.controller.MakeTemplate("GameOfLife.Controllers.Templates.BlockyBlock.txt");
		}

		private void spaceShipToolStripMenuItem_Click(object sender, EventArgs e) {
			this.controller.MakeTemplate("GameOfLife.Controllers.Templates.Spaceship.txt");
		}

		private void generateTemplateToolStripMenuItem_Click(object sender, EventArgs e) {
			this.TemplateFolderDialog.ShowDialog();
			try {
				string folderPath = this.TemplateFolderDialog.SelectedPath;
				this.controller.GenerateUserTemplate(folderPath);
			} catch {
				MessageBox.Show("Unable to generate template in the given location", "Error: Invalid location");
			}
		}

		private void generateTemplateToolStripMenuItem1_Click(object sender, EventArgs e) {
			this.TemplateFolderDialog.ShowDialog();
			try {
				string folderPath = this.TemplateFolderDialog.SelectedPath;
				this.controller.GenerateUserTemplate(folderPath);
			} catch {
				MessageBox.Show("Unable to generate template in the given location", "Error: Invalid location");
			}
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
			HowToForm howToForm = new HowToForm();
			howToForm.Show();
		}

		private void BoardView_Load(object sender, EventArgs e) {

		}

		private void sizeToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("This feature is not yet supported");
			//SizeForm sizeForm = new SizeForm(this.controller);
			//sizeForm.Show();
		}

		public void UpdateBoardSize(int boardSize) {

		}

		private void pictureBox1_MouseClick(object sender, MouseEventArgs e) {
			this.controller.UpdatePixel(e.X, e.Y);
			this.pictureBox1.Image = this.board.GetBoard();
		}
	}
}
