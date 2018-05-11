
namespace GameOfLife.Models {

	public interface IBoardModel {

		bool[,] Board { get; set; }

		int RefreshRate { get; set; }

		int BoardSize { get; set; }

		void Reset();
	}
}