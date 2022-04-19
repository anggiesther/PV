﻿/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 4/19/2022
 * Time: 7:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace uts_pv
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		MySqlConnection co = new MySqlConnection("Server = Localhost; Database = uts_pv; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
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
		
		public void readdata(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from kasir1";
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
		
		public void insertdata(){
			try{
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "insert into kasir1 values('"+kode_barang.Text+"','"+nama_barang.Text+"','"+harga_beli.Text+"','"+harga_jual.Text+"','"+jumlah_barang.Text+"','"+satuan_barang.Text+"')";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readdata();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void updatedata(){
			try{
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "update kasir1 set KodeBarang = '"+kode_barang.Text+"',NamaBarang = '"+nama_barang.Text+"',HargaBeli = '"+harga_beli.Text+"',HargaJual = '"+harga_jual.Text+"',JumlahBarang = '"+jumlah_barang.Text+"',SatuanBarang = '"+satuan_barang.Text+"' where KodeBarang = '"+kode_barang.Text+"'";
				myadapter.SelectCommand = mycommand;
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
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "delete from kasir1 where KodeBarang = '"+kode_barang.Text+"'";
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
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			kode_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			nama_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			harga_beli.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();	
			harga_jual.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			jumlah_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();	
			satuan_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
		}
		
		void SimpanClick(object sender, EventArgs e)
		{
			insertdata();
		}
		void UpdateClick(object sender, EventArgs e)
		{
			updatedata();
		}
		void InsertClick(object sender, EventArgs e)
		{
			insertdata();
		}
		void DeleteClick(object sender, EventArgs e)
		{
			deletedata();
		}
	}
}
