using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Models {
	public class Model {

		public bool[,] Board { get; set; }
		private int boardSize = 20;
		public int BoardSize {
			get => boardSize;
			set {
				this.boardSize = value;
				this.CreateNewModel();
			}
		}

		public Model() {
			this.CreateNewModel();
		}

		private void CreateNewModel() {
			this.Board = new bool[this.BoardSize, this.BoardSize];
			for (int i = 0; i < this.BoardSize; i++) {
				for (int j = 0; j < this.BoardSize; j++) {
					Board[i, j] = false;
				}
			}
		}

		public void Reset() {
			this.CreateNewModel();
		}

	}
}
