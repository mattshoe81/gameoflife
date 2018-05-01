using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Models {
	public class Model {

		public bool[,] Board { get; set; }

		public int BoardSize = 20;

		public Model() {
			this.CreateNewModel();
		}

		private void CreateNewModel() {
			this.Board = new bool[20, 20];
			for (int i = 0; i < 20; i++) {
				for (int j = 0; j < 20; j++) {
					Board[i, j] = false;
				}
			}
		}

		public void Reset() {
			this.CreateNewModel();
		}

	}
}
