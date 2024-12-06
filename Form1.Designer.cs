namespace useComboBox
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblMandato = new Label();
			comboBox = new ComboBox();
			lblMonth = new Label();
			SuspendLayout();
			// 
			// lblMandato
			// 
			lblMandato.AccessibleName = "";
			lblMandato.AutoSize = true;
			lblMandato.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblMandato.Location = new Point(110, 38);
			lblMandato.Name = "lblMandato";
			lblMandato.Size = new Size(298, 37);
			lblMandato.TabIndex = 0;
			lblMandato.Text = "Seleccione un numero";
			lblMandato.TextAlign = ContentAlignment.TopCenter;
			// 
			// comboBox
			// 
			comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox.FormattingEnabled = true;
			comboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
			comboBox.Location = new Point(157, 103);
			comboBox.Name = "comboBox";
			comboBox.Size = new Size(191, 23);
			comboBox.TabIndex = 1;
			comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
			// 
			// lblMonth
			// 
			lblMonth.AutoSize = true;
			lblMonth.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblMonth.Location = new Point(177, 159);
			lblMonth.Name = "lblMonth";
			lblMonth.Size = new Size(155, 32);
			lblMonth.TabIndex = 2;
			lblMonth.Text = "Nombre Mes";
			lblMonth.TextAlign = ContentAlignment.TopCenter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(531, 261);
			Controls.Add(lblMonth);
			Controls.Add(comboBox);
			Controls.Add(lblMandato);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblMandato;
		private ComboBox comboBox;
		private Label lblMonth;
	}
}
