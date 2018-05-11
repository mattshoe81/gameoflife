using System;
using GameOfLife.Models;

namespace GameOfLife.Models {
	public class RefreshRateEventArgs : EventArgs { 

		public readonly int RefreshRate;

		public RefreshRateEventArgs(int refreshRate) {
			this.RefreshRate = refreshRate;
		}
	}
}
