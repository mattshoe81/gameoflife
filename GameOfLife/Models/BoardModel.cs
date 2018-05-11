namespace GameOfLife.Models {
	public class BoardModel : IBoardModel {

		private const int DEFAULT_BOARD_SIZE = 20;

		public bool[,] Board { get; set; }

		public int BoardSize { get; set; } = DEFAULT_BOARD_SIZE;

		public int RefreshRate { get; set; } = 125;

		public BoardModel() {
			this.CreateNewModel(DEFAULT_BOARD_SIZE);
		}

		private void CreateNewModel(int boardSize) {
			this.BoardSize = boardSize;
			this.Board = new bool[this.BoardSize, this.BoardSize];
			for (int i = 0; i < this.BoardSize; i++) {
				for (int j = 0; j < this.BoardSize; j++) {
					Board[i, j] = false;
				}
			}
		}

		public void Reset() {
			this.CreateNewModel(this.BoardSize);
		}

	}
}
