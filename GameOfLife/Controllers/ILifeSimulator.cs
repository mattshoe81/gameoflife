using GameOfLife.Models;
using GameOfLife.Views;

namespace GameOfLife.Controllers {
	public interface ILifeSimulator {

		void CommenceSimulation();

		void TerminateSimulation();
	}
}