using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Views;
using GameOfLife.Models;

namespace GameOfLife.Controllers {

	public class LifeSimulator : ILifeSimulator {

		private IBoardModel boardModel;
		private IBoardView boardView;
		private IBoardController boardController;
		private static System.Threading.Timer timer;

		public LifeSimulator(IBoardModel boardModel, IBoardView boardView, IBoardController boardController) {
			this.boardModel = boardModel;
			this.boardView = boardView;
			this.boardController = boardController;
		}

		public static void DisposeSimulator() {
			LifeSimulator.timer?.Dispose();
		}

		public void CommenceSimulation() {
			if (timer != null) {
				timer.Dispose();
			}
			timer = new System.Threading.Timer(BeginEvolution, this, 0, boardModel.RefreshRate);
		}

		public void TerminateSimulation() {
			timer.Dispose();
		}

		private static void BeginEvolution(object obj) {
			LifeSimulator generator = (LifeSimulator) obj;
			bool[,] nextGeneration = generator.SpawnNextGeneration(generator.boardModel.Board);
			if (generator.IsEmpty(nextGeneration)) {
				generator.boardController.Reset();
			} else {
				generator.boardModel.Board = nextGeneration;
				for (int i = 0; i < generator.boardModel.BoardSize; i++) {
					for (int j = 0; j < generator.boardModel.BoardSize; j++) {
						generator.boardView.UpdateCellState(i, j, generator.boardModel.Board[i, j]);
					}
				}
			}
		}

		private bool[,] SpawnNextGeneration(bool[,] board) {
			bool[,] nextGeneration = new bool[this.boardModel.BoardSize, this.boardModel.BoardSize];

			for (int row = 0; row < this.boardModel.BoardSize; row++) {
				for (int column = 0; column < this.boardModel.BoardSize; column++) {
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

		private bool IsEmpty(bool[,] generation) {
			foreach (bool child in generation) {
				if (child) {
					return false;
				}
			}

			return true;
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
				if ((neighbor[0] >= 0 && neighbor[0] < this.boardModel.BoardSize)
						&& (neighbor[1] >= 0 && neighbor[1] < this.boardModel.BoardSize)) {
					bool alive = board[neighbor[0], neighbor[1]];
					if (alive) {
						neighbors++;
					}
				}
			}

			return neighbors;
		}

	}
}
