using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace GameOfLife.Models {

	public class Template {

		private const string BLINKER_RESOURCE = "GameOfLife.StaticFiles.Templates.Blinker.txt";
		private const string GLIDER_RESOURCE = "GameOfLife.StaticFiles.Templates.Glider.txt";
		private const string DIEHARD_RESOURCE = "GameOfLife.StaticFiles.Templates.Diehard.txt";
		private const string PULSAR_RESOURCE = "GameOfLife.StaticFiles.Templates.Pulsar.txt";
		private const string RPENTOMINO_RESOURCE = "GameOfLife.StaticFiles.Templates.R-Pentomino.txt";
		private const string BLOCKY_BLOCK_RESOURCE = "GameOfLife.StaticFiles.Templates.BlockyBlock.txt";
		private const string SPACESHIP_RESOURCE = "GameOfLife.StaticFiles.Templates.BlockyBlock.txt";

		private TemplateType typeOfTemplate;
		private int boardSize;
		private Assembly assembly;
		private string customTemplatePath;

		private void Initialize(TemplateType typeOfTemplate, string templatePath, int boardSize) {
			this.assembly = Assembly.GetExecutingAssembly();
			this.typeOfTemplate = typeOfTemplate;
			this.customTemplatePath = templatePath;
			this.boardSize = boardSize;
		}

		public Template(TemplateType typeOfTemplate) {
			this.Initialize(typeOfTemplate, "", 20);
		}

		public Template(TemplateType typeOfTemplate, int boardSize) {
			this.Initialize(typeOfTemplate, "", boardSize);
		}

		public Template(string templatePath) {
			this.Initialize(TemplateType.CUSTOM, "", 20);
		}

		public bool[,] GetBoard() {
			string[] lines = ReadTemplate(typeOfTemplate);
			bool[,] board = new bool[lines.Length, lines.Length];

			for (int row = 0; row < this.boardSize; row++) {
				for (int column = 0; column < this.boardSize; column++) {
					if (lines[row][column] == '1') {
						board[column, row] = true;
					} else {
						board[column, row] = false;
					}
				}
			}

			return board;
		}

		public static void GenerateBlankTemplate(string folderPath, int boardSize) {
			try {
				string fileName = "/GameOfLifeTemplate";
				string extension = ".txt";
				string file = folderPath + fileName + extension;
				int counter = 0;
				while (File.Exists(file)) {
					counter++;
					file = folderPath + fileName + counter + extension;
				}
				StreamWriter writer = new StreamWriter(file);
				for (int i = 0; i < boardSize; i++) {
					string line = "";
					for (int j = 0; j < boardSize; j++) {
						line += "0";
					}
					writer.WriteLine(line);
				}
				writer.Close();
			} catch {
				throw new IOException("Unable to generate template in the given location");
			}
		}

		private string[] ReadTemplate(TemplateType typeOfTemplate) {
			string[] lines;
			switch (this.typeOfTemplate) {
				case TemplateType.CUSTOM:
					lines = ReadCustomTemplate(this.customTemplatePath);
					break;
				case TemplateType.BLINKER:
					lines = ReadResource(BLINKER_RESOURCE);
					break;
				case TemplateType.GLIDER:
					lines = ReadResource(GLIDER_RESOURCE);
					break;
				case TemplateType.DIE_HARD:
					lines = ReadResource(DIEHARD_RESOURCE);
					break;
				case TemplateType.PULSAR:
					lines = ReadResource(PULSAR_RESOURCE);
					break;
				case TemplateType.RPENTOMINO:
					lines = ReadResource(RPENTOMINO_RESOURCE);
					break;
				case TemplateType.BLOCKY_BLOCK:
					lines = ReadResource(BLOCKY_BLOCK_RESOURCE);
					break;
				case TemplateType.SPACESHIP:
					lines = ReadResource(SPACESHIP_RESOURCE);
					break;
				default:
					lines = new string[0];
					break;
			}

			return lines;
		}

		private string[] ReadCustomTemplate(string templatePath) {
			string[] lines;
			try {
				lines = File.ReadAllLines(templatePath);
			} catch {
				lines = new string[0];
				throw new IOException("Unable to read resource");
			}
			return lines;
		}

		private string[] ReadResource(string resourceString) {
			string[] lines;
			try {
				StreamReader reader = new StreamReader(this.assembly.GetManifestResourceStream(resourceString));
				List<string> resourceText = new List<string>();
				while (!reader.EndOfStream) {
					resourceText.Add(reader.ReadLine());
				}
				lines = resourceText.ToArray();
			} catch {
				lines = new string[0];
				throw new IOException("Unable to read resource");
			}

			return lines;
		}


	}
}
