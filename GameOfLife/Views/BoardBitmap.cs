using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Views {
	public class BoardBitmap {

		private BitmapData boardData;
		private Bitmap board;

		private int bytes;
		private byte[] pixels;
		private int componentCount;

		public enum CellState {
			ALIVE,
			DEAD
		}

		private void CreateNewBoard(int width, int height) {
			this.board = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			//this.LockBoard();
			for (int row = 0; row < height; row++) {
				for (int column = 0; column < width; column++) {
					//this.SetPixel(column, row, CellState.DEAD);
					this.board.SetPixel(column, row, Color.Red);
				}
			}
			//this.UnlockBoard();
		}

		public BoardBitmap(int width, int height) {
			this.CreateNewBoard(width, height);
		}

		public void LockBoard() {
			Rectangle rect = new Rectangle(0, 0, this.board.Width, this.board.Height);

			this.boardData = this.board.LockBits(rect, ImageLockMode.ReadWrite, this.board.PixelFormat);
			
			bytes = Math.Abs(this.boardData.Stride) * this.board.Height;
			this.pixels = new byte[bytes];

		}

		public void UnlockBoard() {
			IntPtr pointer = this.boardData.Scan0;
			System.Runtime.InteropServices.Marshal.Copy(pointer, pixels, 0, bytes);
			this.board.UnlockBits(this.boardData);
		}

		public CellState GetPixel(int column, int row) {

			this.componentCount = System.Drawing.Bitmap.GetPixelFormatSize(this.board.PixelFormat) / 8;

			int index = this.StartingIndex(column, row);

			byte b = this.pixels[index];
			byte g = this.pixels[index + 1];
			byte r = this.pixels[index + 2];
			Color color = Color.FromArgb(r, g, b);
			CellState state = CellState.DEAD;
			if (color.Equals(Color.Black)) {
				state = CellState.ALIVE;
			} else if (color.Equals(Color.White)) {
				state = CellState.DEAD;
			}

			return state;			
		}

		public void SetPixel(int column, int row, CellState state) {
			Color color = Color.Red;
			if (state == CellState.ALIVE) {
				color = Color.Red;
			}

			int index = this.StartingIndex(column, row);
			this.pixels[index] = color.B;
			this.pixels[index + 1] = color.G;
			this.pixels[index + 2] = color.R;
		}

		private int StartingIndex(int column, int row) {
			return ((row * this.board.Width) + column) * this.componentCount;
		}

		public void SetPixelFromClick(int column, int row) {
			if (this.board.GetPixel(column, row).Equals(Color.Black)) {
				this.board.SetPixel(column, row, Color.White);
			} else {
				this.board.SetPixel(column, row, Color.Black);
			}
		}

		public Bitmap GetBoard() {
			return this.board;
		}

	}
}
