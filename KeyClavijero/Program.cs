/*
 * Created by SharpDevelop.
 * User: A11001153
 * Date: 17-Apr-18
 * Time: 11:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace KeyClavijero
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			
			Clipboard.SetText("a18000357");
			Console.Beep();
			System.Environment.Exit(1);
		}
		
	}
}
