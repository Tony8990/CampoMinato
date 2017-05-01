/*
 * Creato da SharpDevelop.
 * Utente: Tony
 * Data: 01/05/2017
 * Ora: 16:05
 * 
 * Per modificare questo modello usa Strumenti | Opzioni | Codice | Modifica Intestazioni Standard
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campominato
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Button[,]btn;
		Panel panneloDin,retropanl;
		int difficolta,turni;
		int [,]mossenasco;
		bool [,]mosserivelate;
		bool f;
		int mine,minatro;
		Random r;
		string nome;
		int dimx,dimy;
		
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
		void btnEvent_MouseDown(object sender,MouseEventArgs e)
		{
			int X=-1;
			int Y=-1;
			for(int i=0;i<btn.GetLength(0)&& X<0;i++)
			{
				for(int j=0;j<btn.GetLength(1);j++)
				{
					if(btn[i,j]==(object)sender)
					{
						X=i;
						Y=j;
						break;
						
					}
				}
			}
			if(e.Button==MouseButtons.Right)
			{
				if(btn[X,Y].Text=="B"&&minatro>0)
				{
					btn[X,Y].Text="";
					mine++;
					
				}
				else
				{
					mine--;
					btn[X,Y].Text="B";
					if(mine<0)
					{
						
						
					}
				}
			}
		}
	}
}
