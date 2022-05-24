/*
 * Created by SharpDevelop.
 * User: Windows 10
 * Date: 5/23/2022
 * Time: 1:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace Projek_PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		MySqlConnection co = new MySqlConnection("Server = Localhost; Database = projek_pv; Uid = root");
		//MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		Bitmap img;
		string pathimg;
		
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			readdata();
			bersihkan();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void readdata(){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from siswa";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void insertdata(string SourceFilePath){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "insert into siswa values('"+textBoxnisn.Text+"','"+textBoxnama.Text+"','"+comboBoxkelas.Text+"','"+comboBoxjurusan.Text+"','"+comboBoxbulan.Text+"','"+comboBoxstatus.Text+"','"+textBoxbiaya.Text+"',?Picture)";
				myadapter.SelectCommand = mycommand;
				System.IO.FileStream fs = new System.IO.FileStream(SourceFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
				Byte[] b = new Byte[fs.Length];
				fs.Read(b, 0, b.Length);
				fs.Close();
				MySqlParameter P = new MySqlParameter("?Picture", MySqlDbType.LongBlob, b.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, b);
				mycommand.Parameters.Add(P);
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukkan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readdata();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void updatedata(string SourceFilePath){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "update siswa set NISN = '"+textBoxnisn.Text+"',Nama = '"+textBoxnama.Text+"',Kelas = '"+comboBoxkelas.Text+"',Jurusan = '"+comboBoxjurusan.Text+"',Bulan = '"+comboBoxbulan.Text+"',Status = '"+comboBoxstatus.Text+"',Biaya = '"+textBoxbiaya.Text+"',Foto = ?Picture where NISN = '"+textBoxnisn.Text+"'";
				myadapter.SelectCommand = mycommand;
				System.IO.FileStream fs = new System.IO.FileStream(SourceFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
				Byte[] b = new Byte[fs.Length];
				fs.Read(b, 0, b.Length);
				fs.Close();
				MySqlParameter P = new MySqlParameter("?Picture", MySqlDbType.LongBlob, b.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, b);
				mycommand.Parameters.Add(P);
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readdata();
				}
				co.Close();
			}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
		}
		
		public void deletedata(){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "delete from siswa where Nama = '"+textBoxnama.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readdata();
				}
				co.Close();
			}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
		}
		
		public void bersihkan(){
			MySqlCommand mycommand = new MySqlCommand();
			textBoxnisn.Text = "";
			textBoxnama.Text = "";
			comboBoxkelas.Text = "";
			comboBoxjurusan.Text = "";
			comboBoxbulan.Text = "";
			comboBoxstatus.Text = "";
			textBoxbiaya.Text = "0";
			formpencarian.Text = "";
			readdata();
		}
		
		public void finddata(){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				co.Open();
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from siswa where NIK like '%"+formpencarian.Text+"%' or Nama like '%"+formpencarian.Text+"%'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void BtnopenClick(object sender, EventArgs e)
		{
			if(DialogResult.OK ==openFileDialog1.ShowDialog())
			{
				img = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Image=img;
				pathimg=openFileDialog1.FileName.ToString();
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxnisn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBoxnama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			comboBoxkelas.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			comboBoxjurusan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			comboBoxbulan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			comboBoxstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			textBoxbiaya.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			
			try
			{
				MySqlDataAdapter dataAdapter = new MySqlDataAdapter(new MySqlCommand("SELECT Foto from siswa WHERE nisn = "+textBoxnisn.Text, co));
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				if(dataSet.Tables[0].Rows.Count == 1)
				{
					Byte[] data = new Byte[0];
					data = (Byte[])(dataSet.Tables[0].Rows[0]["datagambar"]);
					MemoryStream mem = new MemoryStream(data);
					pictureBox1.Image = Image.FromStream(mem);
				}
					co.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void InsertClick(object sender, EventArgs e)
		{
			insertdata(pathimg);
		}
		
		void UpdateClick(object sender, EventArgs e)
		{
			updatedata(pathimg);
		}
		
		void DeleteClick(object sender, EventArgs e)
		{
			deletedata();
		}
		
		void RefreshClick(object sender, EventArgs e)
		{
			Refresh();
			bersihkan();
		}
		
		void FormpencarianTextChanged(object sender, EventArgs e)
		{
			finddata();
		}
		
		void TextBoxbiayaKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBoxkelas.Items.Add("X");
			comboBoxkelas.Items.Add("XI");
			comboBoxkelas.Items.Add("XII");
			comboBoxjurusan.Items.Add("IPA");
			comboBoxjurusan.Items.Add("IPS");
			comboBoxbulan.Items.Add("JANUARI");
			comboBoxbulan.Items.Add("FEBRUARI");
			comboBoxbulan.Items.Add("MARET");
			comboBoxbulan.Items.Add("APRIL");
			comboBoxbulan.Items.Add("MEI");
			comboBoxbulan.Items.Add("JUNI");
			comboBoxbulan.Items.Add("JULI");
			comboBoxbulan.Items.Add("AGUSTUS");
			comboBoxbulan.Items.Add("SEPTEMBER");
			comboBoxbulan.Items.Add("OKTOBER");
			comboBoxbulan.Items.Add("NOVEMBER");
			comboBoxbulan.Items.Add("DESEMBER");
			comboBoxstatus.Items.Add("LUNAS");
			comboBoxstatus.Items.Add("BELUM LUNAS");
		}
	}
}
