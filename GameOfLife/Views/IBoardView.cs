using System.Windows.Forms;
using GameOfLife.Controllers;

namespace GameOfLife.Views {
	public interface IBoardView {

		void RegisterObserver(IBoardController controller);
		void Reset();
		void UpdateCellState(int column, int row, bool selected);
	}
}