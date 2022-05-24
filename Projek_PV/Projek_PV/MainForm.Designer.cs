/*
 * Created by SharpDevelop.
 * User: Windows 10
 * Date: 5/23/2022
 * Time: 1:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projek_PV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label judul;
		private System.Windows.Forms.Label nisn;
		private System.Windows.Forms.Label nama;
		private System.Windows.Forms.Label kelas;
		private System.Windows.Forms.Label jurusan;
		private System.Windows.Forms.Label bulan;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Label biaya;
		private System.Windows.Forms.TextBox textBoxnisn;
		private System.Windows.Forms.TextBox textBoxnama;
		private System.Windows.Forms.ComboBox comboBoxkelas;
		private System.Windows.Forms.ComboBox comboBoxjurusan;
		private System.Windows.Forms.TextBox textBoxbiaya;
		private System.Windows.Forms.ComboBox comboBoxbulan;
		private System.Windows.Forms.ComboBox comboBoxstatus;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label foto;
		private System.Windows.Forms.Label cari;
		private System.Windows.Forms.TextBox formpencarian;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnopen;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		
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
			this.judul = new System.Windows.Forms.Label();
			this.nisn = new System.Windows.Forms.Label();
			this.nama = new System.Windows.Forms.Label();
			this.kelas = new System.Windows.Forms.Label();
			this.jurusan = new System.Windows.Forms.Label();
			this.bulan = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.Label();
			this.biaya = new System.Windows.Forms.Label();
			this.textBoxnisn = new System.Windows.Forms.TextBox();
			this.textBoxnama = new System.Windows.Forms.TextBox();
			this.comboBoxkelas = new System.Windows.Forms.ComboBox();
			this.comboBoxjurusan = new System.Windows.Forms.ComboBox();
			this.textBoxbiaya = new System.Windows.Forms.TextBox();
			this.comboBoxbulan = new System.Windows.Forms.ComboBox();
			this.comboBoxstatus = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.foto = new System.Windows.Forms.Label();
			this.cari = new System.Windows.Forms.Label();
			this.formpencarian = new System.Windows.Forms.TextBox();
			this.insert = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.refresh = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnopen = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// judul
			// 
			this.judul.BackColor = System.Drawing.Color.Transparent;
			this.judul.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.judul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.judul.Location = new System.Drawing.Point(483, 13);
			this.judul.Name = "judul";
			this.judul.Size = new System.Drawing.Size(304, 48);
			this.judul.TabIndex = 0;
			this.judul.Text = "SMA NANA CERIA";
			this.judul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nisn
			// 
			this.nisn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nisn.Location = new System.Drawing.Point(90, 69);
			this.nisn.Name = "nisn";
			this.nisn.Size = new System.Drawing.Size(100, 23);
			this.nisn.TabIndex = 1;
			this.nisn.Text = "NISN";
			// 
			// nama
			// 
			this.nama.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nama.Location = new System.Drawing.Point(90, 112);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(100, 23);
			this.nama.TabIndex = 2;
			this.nama.Text = "Nama";
			// 
			// kelas
			// 
			this.kelas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kelas.Location = new System.Drawing.Point(90, 158);
			this.kelas.Name = "kelas";
			this.kelas.Size = new System.Drawing.Size(100, 23);
			this.kelas.TabIndex = 3;
			this.kelas.Text = "Kelas";
			// 
			// jurusan
			// 
			this.jurusan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jurusan.Location = new System.Drawing.Point(90, 205);
			this.jurusan.Name = "jurusan";
			this.jurusan.Size = new System.Drawing.Size(100, 23);
			this.jurusan.TabIndex = 4;
			this.jurusan.Text = "Jurusan";
			// 
			// bulan
			// 
			this.bulan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bulan.Location = new System.Drawing.Point(90, 254);
			this.bulan.Name = "bulan";
			this.bulan.Size = new System.Drawing.Size(100, 23);
			this.bulan.TabIndex = 5;
			this.bulan.Text = "Bulan";
			// 
			// status
			// 
			this.status.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.status.Location = new System.Drawing.Point(90, 301);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(100, 23);
			this.status.TabIndex = 6;
			this.status.Text = "Status";
			// 
			// biaya
			// 
			this.biaya.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.biaya.Location = new System.Drawing.Point(90, 354);
			this.biaya.Name = "biaya";
			this.biaya.Size = new System.Drawing.Size(112, 26);
			this.biaya.TabIndex = 7;
			this.biaya.Text = "Besar Biaya";
			// 
			// textBoxnisn
			// 
			this.textBoxnisn.Location = new System.Drawing.Point(221, 66);
			this.textBoxnisn.Name = "textBoxnisn";
			this.textBoxnisn.Size = new System.Drawing.Size(332, 26);
			this.textBoxnisn.TabIndex = 8;
			// 
			// textBoxnama
			// 
			this.textBoxnama.Location = new System.Drawing.Point(221, 109);
			this.textBoxnama.Name = "textBoxnama";
			this.textBoxnama.Size = new System.Drawing.Size(332, 26);
			this.textBoxnama.TabIndex = 9;
			// 
			// comboBoxkelas
			// 
			this.comboBoxkelas.FormattingEnabled = true;
			this.comboBoxkelas.Location = new System.Drawing.Point(221, 158);
			this.comboBoxkelas.Name = "comboBoxkelas";
			this.comboBoxkelas.Size = new System.Drawing.Size(166, 28);
			this.comboBoxkelas.TabIndex = 10;
			// 
			// comboBoxjurusan
			// 
			this.comboBoxjurusan.FormattingEnabled = true;
			this.comboBoxjurusan.Location = new System.Drawing.Point(221, 202);
			this.comboBoxjurusan.Name = "comboBoxjurusan";
			this.comboBoxjurusan.Size = new System.Drawing.Size(166, 28);
			this.comboBoxjurusan.TabIndex = 11;
			// 
			// textBoxbiaya
			// 
			this.textBoxbiaya.Location = new System.Drawing.Point(221, 351);
			this.textBoxbiaya.Name = "textBoxbiaya";
			this.textBoxbiaya.Size = new System.Drawing.Size(166, 26);
			this.textBoxbiaya.TabIndex = 12;
			this.textBoxbiaya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxbiayaKeyPress);
			// 
			// comboBoxbulan
			// 
			this.comboBoxbulan.FormattingEnabled = true;
			this.comboBoxbulan.Location = new System.Drawing.Point(221, 251);
			this.comboBoxbulan.Name = "comboBoxbulan";
			this.comboBoxbulan.Size = new System.Drawing.Size(166, 28);
			this.comboBoxbulan.TabIndex = 13;
			// 
			// comboBoxstatus
			// 
			this.comboBoxstatus.FormattingEnabled = true;
			this.comboBoxstatus.Location = new System.Drawing.Point(221, 298);
			this.comboBoxstatus.Name = "comboBoxstatus";
			this.comboBoxstatus.Size = new System.Drawing.Size(166, 28);
			this.comboBoxstatus.TabIndex = 14;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(27, 398);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1134, 282);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// foto
			// 
			this.foto.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.foto.Location = new System.Drawing.Point(850, 111);
			this.foto.Name = "foto";
			this.foto.Size = new System.Drawing.Size(57, 30);
			this.foto.TabIndex = 16;
			this.foto.Text = "Foto";
			this.foto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cari
			// 
			this.cari.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cari.Location = new System.Drawing.Point(743, 227);
			this.cari.Name = "cari";
			this.cari.Size = new System.Drawing.Size(100, 23);
			this.cari.TabIndex = 17;
			this.cari.Text = "Cari";
			// 
			// formpencarian
			// 
			this.formpencarian.Location = new System.Drawing.Point(743, 253);
			this.formpencarian.Name = "formpencarian";
			this.formpencarian.Size = new System.Drawing.Size(362, 26);
			this.formpencarian.TabIndex = 18;
			this.formpencarian.TextChanged += new System.EventHandler(this.FormpencarianTextChanged);
			// 
			// insert
			// 
			this.insert.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insert.Location = new System.Drawing.Point(743, 289);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(111, 43);
			this.insert.TabIndex = 19;
			this.insert.Text = "Insert";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.InsertClick);
			// 
			// delete
			// 
			this.delete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(743, 337);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(111, 43);
			this.delete.TabIndex = 20;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.DeleteClick);
			// 
			// update
			// 
			this.update.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(994, 289);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(111, 43);
			this.update.TabIndex = 21;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.UpdateClick);
			// 
			// refresh
			// 
			this.refresh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refresh.Location = new System.Drawing.Point(994, 337);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(111, 43);
			this.refresh.TabIndex = 22;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = true;
			this.refresh.Click += new System.EventHandler(this.RefreshClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pictureBox1.Location = new System.Drawing.Point(952, 66);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(153, 164);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// btnopen
			// 
			this.btnopen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnopen.Location = new System.Drawing.Point(828, 144);
			this.btnopen.Name = "btnopen";
			this.btnopen.Size = new System.Drawing.Size(106, 37);
			this.btnopen.TabIndex = 24;
			this.btnopen.Text = "Open";
			this.btnopen.UseVisualStyleBackColor = true;
			this.btnopen.Click += new System.EventHandler(this.BtnopenClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSalmon;
			this.ClientSize = new System.Drawing.Size(1188, 692);
			this.Controls.Add(this.btnopen);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.formpencarian);
			this.Controls.Add(this.cari);
			this.Controls.Add(this.foto);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.comboBoxstatus);
			this.Controls.Add(this.comboBoxbulan);
			this.Controls.Add(this.textBoxbiaya);
			this.Controls.Add(this.comboBoxjurusan);
			this.Controls.Add(this.comboBoxkelas);
			this.Controls.Add(this.textBoxnama);
			this.Controls.Add(this.textBoxnisn);
			this.Controls.Add(this.biaya);
			this.Controls.Add(this.status);
			this.Controls.Add(this.bulan);
			this.Controls.Add(this.jurusan);
			this.Controls.Add(this.kelas);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.nisn);
			this.Controls.Add(this.judul);
			this.Name = "MainForm";
			this.Text = "Projek_PV";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
