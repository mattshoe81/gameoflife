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
		private int boardSize = 20;
		private int RefreshInterval = 125;
		private System.Threading.Timer timer;
		private Assembly assembly;
		private readonly string[] templateLines; 
		private const string BLANK_LINE = "00000000000000000000";

		public Controller(Model model, BoardView view) {
			this.model = model;
			this.view = view;
			this.assembly = Assembly.GetExecutingAssembly();
			this.boardSize = this.model.BoardSize;
			templateLines = new string[this.boardSize];
			for (int k = 0; k < this.boardSize; k++) {
				templateLines[k] = BLANK_LINE;
			}
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
				for (int i = 0; i <controller.boardSize; i++) {
					for (int j = 0; j < controller.boardSize; j++) {
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
			bool[,] nextGeneration = new bool[boardSize, boardSize];

			for (int row = 0; row < boardSize; row++) {
				for (int column = 0; column < boardSize; column++) {
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
				if ((neighbor[0] >= 0 && neighbor[0] < boardSize)
						&& (neighbor[1] >= 0 && neighbor[1] < boardSize)) {
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
			try {
				string[] lines = File.ReadAllLines(filePath);
				UpdateBoardFromStringArray(lines);
			} catch {
				MessageBox.Show("File is not in correct format. \n\nFile must have .txt extension and mustcontain only a  20x20 matrix of 1 and 0 where 1 indicates a black cell and 0 indicates a white cell.\n\nThere must not be any whitespace or characters other than 1 or 0.", "Unable to load template");
			}
			
		}

		private void UpdateBoardFromStringArray(string[] lines) {
			for (int row = 0; row < boardSize; row++) {
				for (int column = 0; column < boardSize; column++) {
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

		public void MakeTemplate(string resourceName) {
			this.LoadTemplate(resourceName);
		}

		public void GenerateUserTemplate(string folderPath) {
			try {
				string fileName = "/GameOfLifeTemplate";
				string extension = ".txt";
				string file = folderPath + fileName + extension;
				int counter = 0;
				while (File.Exists(file)) {
					counter++;
					file = folderPath + fileName + counter + extension;
				}
				StreamWriter writer = new StreamWriter(file);
				foreach (string line in templateLines) {
					writer.WriteLine(line);
				}
				writer.Close();
			} catch {
				MessageBox.Show("Unable to generate template in the given location", "Error: Invalid location");
			}
		}
	}
}
