using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useComboBox.Models
{
	public class Data
	{
		private List<string> getData = new List<string>() {
			"Enero",
			"Febrero",
			"Marzo",
			"Abril",
			"Mayo",
			"Junio",
			"Julio",
			"Agosto",
			"Septiembre",
			"Octubre",
			"Noviembre",
			"Diciembre"
		};
		
		public List<string> GetData
		{
			get
			{
				return getData;
			}
		}
	}
}
