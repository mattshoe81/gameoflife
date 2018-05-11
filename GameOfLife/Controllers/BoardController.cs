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
	/// <summary>
	/// Class to handle button clicks, routing the logic to the appropriate class to handle the desired behavior.
	/// </summary>
	public class BoardController : IBoardController {

		private IBoardModel boardModel;
		private IBoardView boardView;

		public BoardController(IBoardModel model, IBoardView view) {
			this.boardModel = model;
			this.boardView = view;
		}

		public void Reset() {
			this.boardModel.Reset();
			this.boardView.Reset();
			LifeSimulator.DisposeSimulator();
		}

		public void HandleBoardCellClick(int column, int row) {
			this.boardModel.Board[column, row] = !this.boardModel.Board[column, row];
			this.boardView.UpdateCellState(column, row, this.boardModel.Board[column, row]);
		}

		public void HandleBeginButtonClick() {
			ILifeSimulator simulator = new LifeSimulator(boardModel, boardView, this);
			simulator.CommenceSimulation();
		}

		public void HandleRefreshRateChange(int ms) {
			this.boardModel.RefreshRate = ms;
		}

		public void HandleLoadTemplate(TemplateType typeOfTemplate) {
			Template template = new Template(typeOfTemplate);
			try {
				this.boardModel.Board = template.GetBoard();
				this.UpdateViewToMatchModel(this.boardModel, this.boardView);
			} catch (IOException e) {
				MessageBox.Show(e.Message);
			}			
		}

		public void HandleLoadCustomTemplate(string templatePath) {
			Template template = new Template(templatePath);
			try {
				this.boardModel.Board = template.GetBoard();
				this.UpdateViewToMatchModel(this.boardModel, this.boardView);
			} catch (IOException e) {
				MessageBox.Show(e.Message);
			}
		}

		public void HandleGenerateBlankTemplate(string folderPath) {
			Template.GenerateBlankTemplate(folderPath, this.boardModel.BoardSize);
		}

		private void UpdateViewToMatchModel(IBoardModel model, IBoardView view) {
			for (int row = 0; row < this.boardModel.BoardSize; row++) {
				for (int column = 0; column < this.boardModel.BoardSize; column++) {
					this.boardView.UpdateCellState(column, row, this.boardModel.Board[column, row]);
				}
			}
		}
	}
}
