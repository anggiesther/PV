/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 2/25/2022
 * Time: 10:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace belajar
{
	class ProgramHW
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Nama kamu siapa?");
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu " + nama);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}