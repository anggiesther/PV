/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 4/19/2022
 * Time: 7:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace uts_pv
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label kode;
		private System.Windows.Forms.Label nama;
		private System.Windows.Forms.Label jual;
		private System.Windows.Forms.Label beli;
		private System.Windows.Forms.Label jumlah;
		private System.Windows.Forms.Label satuan;
		private System.Windows.Forms.TextBox kode_barang;
		private System.Windows.Forms.TextBox nama_barang;
		private System.Windows.Forms.TextBox harga_jual;
		private System.Windows.Forms.TextBox harga_beli;
		private System.Windows.Forms.TextBox jumlah_barang;
		private System.Windows.Forms.TextBox satuan_barang;
		private System.Windows.Forms.Button simpan;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button delete;
		
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
			this.kode = new System.Windows.Forms.Label();
			this.nama = new System.Windows.Forms.Label();
			this.jual = new System.Windows.Forms.Label();
			this.beli = new System.Windows.Forms.Label();
			this.jumlah = new System.Windows.Forms.Label();
			this.satuan = new System.Windows.Forms.Label();
			this.kode_barang = new System.Windows.Forms.TextBox();
			this.nama_barang = new System.Windows.Forms.TextBox();
			this.harga_jual = new System.Windows.Forms.TextBox();
			this.harga_beli = new System.Windows.Forms.TextBox();
			this.jumlah_barang = new System.Windows.Forms.TextBox();
			this.satuan_barang = new System.Windows.Forms.TextBox();
			this.simpan = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.delete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// kode
			// 
			this.kode.Location = new System.Drawing.Point(24, 21);
			this.kode.Name = "kode";
			this.kode.Size = new System.Drawing.Size(118, 23);
			this.kode.TabIndex = 0;
			this.kode.Text = "Kode Barang";
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(24, 61);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(111, 23);
			this.nama.TabIndex = 1;
			this.nama.Text = "Nama Barang";
			// 
			// jual
			// 
			this.jual.Location = new System.Drawing.Point(24, 101);
			this.jual.Name = "jual";
			this.jual.Size = new System.Drawing.Size(100, 23);
			this.jual.TabIndex = 2;
			this.jual.Text = "Harga Jual";
			// 
			// beli
			// 
			this.beli.Location = new System.Drawing.Point(24, 145);
			this.beli.Name = "beli";
			this.beli.Size = new System.Drawing.Size(100, 23);
			this.beli.TabIndex = 3;
			this.beli.Text = "Harga Beli";
			// 
			// jumlah
			// 
			this.jumlah.Location = new System.Drawing.Point(24, 186);
			this.jumlah.Name = "jumlah";
			this.jumlah.Size = new System.Drawing.Size(100, 23);
			this.jumlah.TabIndex = 4;
			this.jumlah.Text = "Jumlah";
			// 
			// satuan
			// 
			this.satuan.Location = new System.Drawing.Point(24, 230);
			this.satuan.Name = "satuan";
			this.satuan.Size = new System.Drawing.Size(100, 23);
			this.satuan.TabIndex = 5;
			this.satuan.Text = "Satuan";
			// 
			// kode_barang
			// 
			this.kode_barang.Location = new System.Drawing.Point(167, 18);
			this.kode_barang.Name = "kode_barang";
			this.kode_barang.Size = new System.Drawing.Size(170, 26);
			this.kode_barang.TabIndex = 6;
			// 
			// nama_barang
			// 
			this.nama_barang.Location = new System.Drawing.Point(167, 58);
			this.nama_barang.Name = "nama_barang";
			this.nama_barang.Size = new System.Drawing.Size(515, 26);
			this.nama_barang.TabIndex = 7;
			// 
			// harga_jual
			// 
			this.harga_jual.Location = new System.Drawing.Point(167, 98);
			this.harga_jual.Name = "harga_jual";
			this.harga_jual.Size = new System.Drawing.Size(170, 26);
			this.harga_jual.TabIndex = 8;
			// 
			// harga_beli
			// 
			this.harga_beli.Location = new System.Drawing.Point(167, 142);
			this.harga_beli.Name = "harga_beli";
			this.harga_beli.Size = new System.Drawing.Size(170, 26);
			this.harga_beli.TabIndex = 9;
			// 
			// jumlah_barang
			// 
			this.jumlah_barang.Location = new System.Drawing.Point(167, 183);
			this.jumlah_barang.Name = "jumlah_barang";
			this.jumlah_barang.Size = new System.Drawing.Size(170, 26);
			this.jumlah_barang.TabIndex = 10;
			// 
			// satuan_barang
			// 
			this.satuan_barang.Location = new System.Drawing.Point(167, 227);
			this.satuan_barang.Name = "satuan_barang";
			this.satuan_barang.Size = new System.Drawing.Size(170, 26);
			this.satuan_barang.TabIndex = 11;
			// 
			// simpan
			// 
			this.simpan.Location = new System.Drawing.Point(409, 224);
			this.simpan.Name = "simpan";
			this.simpan.Size = new System.Drawing.Size(107, 38);
			this.simpan.TabIndex = 12;
			this.simpan.Text = "Simpan";
			this.simpan.UseVisualStyleBackColor = true;
			this.simpan.Click += new System.EventHandler(this.SimpanClick);
			// 
			// update
			// 
			this.update.Location = new System.Drawing.Point(522, 224);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(111, 38);
			this.update.TabIndex = 13;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.UpdateClick);
			// 
			// insert
			// 
			this.insert.Location = new System.Drawing.Point(639, 224);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(110, 38);
			this.insert.TabIndex = 14;
			this.insert.Text = "Insert";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.InsertClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 287);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "DB: Kasir. Tabel: TBL_BARANG";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 313);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(795, 335);
			this.dataGridView1.TabIndex = 16;
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(522, 183);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(111, 35);
			this.delete.TabIndex = 17;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.DeleteClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 651);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.update);
			this.Controls.Add(this.simpan);
			this.Controls.Add(this.satuan_barang);
			this.Controls.Add(this.jumlah_barang);
			this.Controls.Add(this.harga_beli);
			this.Controls.Add(this.harga_jual);
			this.Controls.Add(this.nama_barang);
			this.Controls.Add(this.kode_barang);
			this.Controls.Add(this.satuan);
			this.Controls.Add(this.jumlah);
			this.Controls.Add(this.beli);
			this.Controls.Add(this.jual);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.kode);
			this.Name = "MainForm";
			this.Text = "uts_pv";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
