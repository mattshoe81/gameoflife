﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfLife.Views;
using GameOfLife.Controllers;
using GameOfLife.Models;

namespace GameOfLife {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Model model = new Model();
			BoardView view = new BoardView();
			Controller controller = new Controller(model, view);
			view.RegisterObserver(controller);
			Application.Run(view);
		}
	}
}
