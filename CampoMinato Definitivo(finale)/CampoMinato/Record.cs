/*
 * Creato da SharpDevelop.
 * Utente: Tony
 * Data: 03/05/2017
 * Ora: 10:59
 * 
 * Per modificare questo modello usa Strumenti | Opzioni | Codice | Modifica Intestazioni Standard
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CampoMinato
{
	/// <summary>
	/// Description of Record.
	/// </summary>
	public partial class Record : Form
	{
		public Record(int lvl)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.FormBorderStyle= FormBorderStyle.Fixed3D;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			RecordLabel.Text=Punteggio.ID(lvl).Tutti();
			
		}
		
		void RecordLoad(object sender, EventArgs e)
		{
			
		}
	}
}
