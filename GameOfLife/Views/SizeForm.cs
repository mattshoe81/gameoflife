using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfLife.Controllers;

namespace GameOfLife.Views {
	public partial class SizeForm : Form {

		private Controller controller;

		public SizeForm(Controller controller) {
			InitializeComponent();
			this.controller = controller;
		}

		private void UpdateSizeButton_Click(object sender, EventArgs e) {
			int size = 20;
			try {
				size = int.Parse(this.SizeTextBox.Text);
				this.Close();
				this.controller.UpdateBoardSize(size);
			} catch {
				MessageBox.Show("Size must be an integer greater than 0");
			}
		}
	}
}
