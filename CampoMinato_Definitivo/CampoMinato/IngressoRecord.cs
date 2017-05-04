/*
 * Creato da SharpDevelop.
 * Utente: Tony
 * Data: 03/05/2017
 * Ora: 11:06
 * 
 * Per modificare questo modello usa Strumenti | Opzioni | Codice | Modifica Intestazioni Standard
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace CampoMinato
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		int Livello;
		string Tempo;
		public Form1(int lvl,string tmp)
		{
			Livello=lvl;
			Tempo=tmp;
			InitializeComponent();
			CancelButton.Click += CancelButtonClick;
            ApplyButton.Click += ApplyButtonClick;
            NameBox.KeyDown += NameBox_KeyDown;
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
			
			
		}
		
		
		void Applica()
        {
            if (NameBox.Text != "")
            {
                Punteggio.ID(Livello).Add(NameBox.Text,Tempo);
            }
            this.Hide();

            Thread t = new Thread(
                new ThreadStart(
            		() => Application.Run(new Record(Livello))));

            t.Start();
            t.Join();

            this.Close();
        }
		 void NameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                Applica();
        }
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
			
		}
		
		void ApplyButtonClick(object sender, EventArgs e)
		{
			Applica();
		}
	}
}
