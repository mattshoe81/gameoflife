using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Models;
using GameOfLife.Views;
using System.Threading;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GameOfLife.Controllers {
	public class Controller {

		private Model model;
		private BoardView view;
		private const int BOARD_SIZE = 20;
		private int RefreshInterval = 125;
		private System.Threading.Timer timer;
		private Assembly assembly;

		public Controller(Model model, BoardView view) {
			this.model = model;
			this.view = view;
			this.assembly = Assembly.GetExecutingAssembly();
		}

		public void HandlePanelClick(int column, int row) {
			this.model.Board[column, row] = !this.model.Board[column, row];
			this.view.UpdateCellState(column, row, this.model.Board[column, row]);
		}

		public void HandleBeginClick() {
			if (timer != null) {
				timer.Dispose();
			}
			timer = new System.Threading.Timer(BeginEvolution, this, 0, RefreshInterval);
		}

		private static void BeginEvolution(object obj) {
			Controller controller = (Controller) obj;
			bool[,] nextGeneration = controller.SpawnNextGeneration(controller.model.Board);
			if (controller.IsEmpty(nextGeneration)) {
				controller.Reset();
			} else {
				controller.model.Board = nextGeneration;
				for (int i = 0; i < BOARD_SIZE; i++) {
					for (int j = 0; j < BOARD_SIZE; j++) {
						controller.view.UpdateCellState(i, j, controller.model.Board[i, j]);
					}
				}
			}
		}

		private bool IsEmpty(bool[,] generation) {
			foreach (bool child in generation) {
				if (child) {
					return false;
				}
			}

			return true;
		}

		private bool[,] SpawnNextGeneration(bool[,] board) {
			bool[,] nextGeneration = new bool[BOARD_SIZE, BOARD_SIZE];

			for (int row = 0; row < BOARD_SIZE; row++) {
				for (int column = 0; column < BOARD_SIZE; column++) {
					bool alive = board[column, row];
					int numberOfNeighbors = this.CountNeighbors(new int[] { column, row }, board);
					if (alive) {
						if (numberOfNeighbors > 3 || numberOfNeighbors < 2) {
							alive = false;
						}
					} else {
						if (numberOfNeighbors == 3) {
							alive = true;
						}
					}
					
					nextGeneration[column, row] = alive;
				}
			}

			return nextGeneration;
		}

		private int CountNeighbors(int[] location, bool[,] board) {
			int column = location[0];
			int row = location[1];
			int neighbors = 0;
			int[] north = { column, row - 1 };
			int[] northEast = { column + 1, row - 1 };
			int[] east = { column + 1, row };
			int[] southEast = { column + 1, row + 1 };
			int[] south = { column, row + 1 };
			int[] southWest = { column - 1, row + 1 };
			int[] west = { column - 1, row };
			int[] northWest = { column - 1, row - 1 };
			int[][] positions = { north, northEast, east, southEast, south, southWest, west, northWest }; 
			foreach (int[] neighbor in positions) {
				if ((neighbor[0] >= 0 && neighbor[0] < BOARD_SIZE)
						&& (neighbor[1] >= 0 && neighbor[1] < BOARD_SIZE)) {
					bool alive = board[neighbor[0], neighbor[1]];
					if (alive) {
						neighbors++;
					}
				}
			}

			return neighbors;
		}

		public void Reset() {
			if (timer != null) {
				timer.Dispose();
			}
			this.model.Reset();
			this.view.Reset();
		}

		public void SetRefreshInterval(int ms) {
			this.RefreshInterval = ms;
		}

		public void LoadFile(string filePath) {
			string[] lines = File.ReadAllLines(filePath);
			UpdateBoardFromStringArray(lines);
		}

		private void UpdateBoardFromStringArray(string[] lines) {
			for (int row = 0; row < BOARD_SIZE; row++) {
				for (int column = 0; column < BOARD_SIZE; column++) {
					if (lines[row][column] == '1') {
						this.model.Board[column, row] = true;
						this.view.UpdateCellState(column, row, true);
					} else {
						this.model.Board[column, row] = false;
						this.view.UpdateCellState(column, row, false);
					}
				}
			}
		}

		public void LoadTemplate(string resourceName) {
			try {
				

				StreamReader reader = new StreamReader(this.assembly.GetManifestResourceStream(resourceName));
				List<string> resourceText = new List<string>();
				while (!reader.EndOfStream) {
					resourceText.Add(reader.ReadLine());
				}
				string[] lines = resourceText.ToArray();
				this.UpdateBoardFromStringArray(lines);
			} catch {
				MessageBox.Show("Error reading resource");
			}
			

		}

		public void MakeBlinker() {
			this.LoadTemplate("GameOfLife.Controllers.Templates.Blinker.txt");
		}

		public void MakeGlider() {
			this.LoadTemplate("GameOfLife.Controllers.Templates.Glider.txt");
		}

		public void MakeDiehard() {
			this.LoadTemplate("GameOfLife.Controllers.Templates.Diehard.txt");
		}

		public void MakePulsar() {
			this.LoadTemplate("GameOfLife.Controllers.Templates.Pulsar.txt");
		}
	}
}
