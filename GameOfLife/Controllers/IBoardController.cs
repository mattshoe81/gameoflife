namespace GameOfLife.Controllers {

	public interface IBoardController {
		
		void HandleGenerateBlankTemplate(string folderPath);
		void HandleBeginButtonClick();
		void HandleBoardCellClick(int column, int row);
		void HandleRefreshRateChange(int ms);
		void HandleLoadTemplate(TemplateType typeOfTemplate);
		void HandleLoadCustomTemplate(string templatePath);
		void Reset();

	}
}