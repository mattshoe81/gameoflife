using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Models {

	class TemplateEventArgs :EventArgs {

		public readonly TemplateType TypeOfTemplate;

		public TemplateEventArgs(TemplateType typeOfTemplate) {
			this.TypeOfTemplate = typeOfTemplate;
		}
	}
}
