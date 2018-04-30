using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Views {
	class BoardPanel : System.Windows.Forms.Panel {

		public readonly int Row;

		public readonly int Column;

		public BoardPanel(int row, int column) {
			this.Row = row;
			this.Column = column;
		}
	}
}
