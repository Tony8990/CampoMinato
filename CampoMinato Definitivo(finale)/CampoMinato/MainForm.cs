/*
 * Created by SharpDevelop.
 * User: Tony
 * Date: 30/04/2017
 * Time: 11:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

using System.IO;


namespace CampoMinato
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.FormBorderStyle= FormBorderStyle.Fixed3D;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			
		}
		public void PunteggioElevato()
		{
			btnpuntpri.Enabled=Punteggio.Principianti.Controlla();
			btnpuntinorm.Enabled=Punteggio.Normale.Controlla();
			btnpuntipro.Enabled=Punteggio.Expert.Controlla();
			
			
		}
		
		
		private void BtnprinciClick(object sender, EventArgs e)
		{
			this.Hide();
		    Thread t = new Thread(new ThreadStart(() => Application.Run(new Campo(new Point(9,9)))));
			t.Start();
			t.Join();
			PunteggioElevato();
			this.Show();
		
		}
		
		
		private void BtnnormClick(object sender, EventArgs e)
		{   
			this.Hide();
			Thread t = new Thread(new ThreadStart(() => Application.Run(new Campo(new Point(16,16)))));
			t.Start();
			t.Join();
			PunteggioElevato();
			this.Show();
			
		}
		
		private void BtnespClick(object sender, EventArgs e)
		{
			this.Hide();
			Thread t = new Thread(new ThreadStart(() => Application.Run(new Campo(new Point(30,30)))));
			t.Start();
			t.Join();
			PunteggioElevato();
			this.Show();
			
		}
		
		void BtnpuntpriClick(object sender, EventArgs e)
		{
			this.Hide();
			Thread t =new Thread(new ThreadStart(()=> Application.Run(new Record(0))));
			t.Start();
			t.Join();
			this.Show();
			
		}
		
		void BtnpuntinormClick(object sender, EventArgs e)
		{
			
			this.Hide();
			Thread t =new Thread(new ThreadStart(()=> Application.Run(new Record(1))));
			t.Start();
			t.Join();
			this.Show();
		}
		
		void BtnpuntiproClick(object sender, EventArgs e)
		{
			
			this.Hide();
			Thread t =new Thread(new ThreadStart(()=> Application.Run(new Record(2))));
			t.Start();
			t.Join();
			this.Show();
			
		}
	}
}
