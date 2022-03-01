using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugassatu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		
	}
		void BtntambahClick(object sender, EventArgs e)
		{
			list.Items.Add(txtbox.Text);
			txtbox.Clear();
		}
		void BtnhapusClick(object sender, EventArgs e)
		{
			list.Items.RemoveAt(list.SelectedIndex);
		}
	
//		void BtnClick(object sender, EventArgs e)
//		{
//			MessageBox.Show("Hello World!");
//		}
//		
		
}
}














