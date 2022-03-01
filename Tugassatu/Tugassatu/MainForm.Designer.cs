/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 01/03/2022
 * Time: 8:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugassatu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btntambah;
		private System.Windows.Forms.ListBox list;
		private System.Windows.Forms.Button btnhapus;
		private System.Windows.Forms.TextBox txtbox;
		private System.Windows.Forms.Label word;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btntambah = new System.Windows.Forms.Button();
			this.list = new System.Windows.Forms.ListBox();
			this.btnhapus = new System.Windows.Forms.Button();
			this.txtbox = new System.Windows.Forms.TextBox();
			this.word = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btntambah
			// 
			this.btntambah.BackColor = System.Drawing.Color.Black;
			this.btntambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btntambah.Location = new System.Drawing.Point(254, 118);
			this.btntambah.Name = "btntambah";
			this.btntambah.Size = new System.Drawing.Size(105, 32);
			this.btntambah.TabIndex = 1;
			this.btntambah.Text = "Tambah";
			this.btntambah.UseVisualStyleBackColor = false;
			this.btntambah.Click += new System.EventHandler(this.BtntambahClick);
			// 
			// list
			// 
			this.list.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.list.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.list.FormattingEnabled = true;
			this.list.ItemHeight = 22;
			this.list.Location = new System.Drawing.Point(31, 109);
			this.list.Name = "list";
			this.list.Size = new System.Drawing.Size(217, 158);
			this.list.TabIndex = 3;
			// 
			// btnhapus
			// 
			this.btnhapus.BackColor = System.Drawing.Color.Black;
			this.btnhapus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnhapus.Location = new System.Drawing.Point(254, 183);
			this.btnhapus.Name = "btnhapus";
			this.btnhapus.Size = new System.Drawing.Size(105, 33);
			this.btnhapus.TabIndex = 3;
			this.btnhapus.Text = "Hapus";
			this.btnhapus.UseVisualStyleBackColor = false;
			this.btnhapus.Click += new System.EventHandler(this.BtnhapusClick);
			// 
			// txtbox
			// 
			this.txtbox.BackColor = System.Drawing.Color.White;
			this.txtbox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbox.Location = new System.Drawing.Point(31, 66);
			this.txtbox.Multiline = true;
			this.txtbox.Name = "txtbox";
			this.txtbox.Size = new System.Drawing.Size(328, 28);
			this.txtbox.TabIndex = 5;
			// 
			// word
			// 
			this.word.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.word.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.word.ForeColor = System.Drawing.SystemColors.ControlText;
			this.word.Location = new System.Drawing.Point(85, 21);
			this.word.Name = "word";
			this.word.Size = new System.Drawing.Size(240, 42);
			this.word.TabIndex = 0;
			this.word.Text = "List Barang";
			this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(380, 300);
			this.Controls.Add(this.txtbox);
			this.Controls.Add(this.btnhapus);
			this.Controls.Add(this.list);
			this.Controls.Add(this.btntambah);
			this.Controls.Add(this.word);
			this.Name = "MainForm";
			this.Text = "Tugassatu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
