
using useComboBox.Models;

namespace useComboBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Data data = new Data();
			lblMonth.Text = data.GetData[comboBox.SelectedIndex].ToString();
		}
	}
}
