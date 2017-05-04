﻿/*
 * Creato da SharpDevelop.
 * Utente: Tony
 * Data: 01/05/2017
 * Ora: 15:29
 * 
 * Per modificare questo modello usa Strumenti | Opzioni | Codice | Modifica Intestazioni Standard
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace CampoMinato
{
	/// <summary>
	/// Description of Punteggio.
	/// </summary>
	/// 
	class Punteggio
	{
		int puntegioentri=10;
		static Punteggio pri;
		public static Punteggio Principianti
		{
			get
			{
				if(pri==null)
				{
					pri=new Punteggio(0);
				}
				return pri;
				
			}
			
		}
		static Punteggio norm;
		public static Punteggio Normale
		{
			get
			{
				if(norm==null)
				{
					norm=new Punteggio(1);
				}
				return norm;
			}
		}
		
		static Punteggio expert;
		public static Punteggio Expert
		{
			get
			{
				if(expert==null)
				{
					expert=new Punteggio(1);
				}
				return expert;
			}
		}
		public static Punteggio ID(int id)
		{
			switch(id)
			{
				case 0:
					return Punteggio.Principianti;
				case 1:
					return Punteggio.Normale;
				case 2:
					return Punteggio.Expert;
			}
			return null;
		}
		class Score
		{
			public string Bombe;
			public string numMosse;
			public string Stato;
			public string Nome;
			public string Tempo;
			public Score(string n,string t,string s,string b,string nm)
			{
				Bombe=b;
				numMosse=nm;
			 	Nome=n;
			 	Tempo=t;
			 	Stato=s;
			}
			
			public string UnScore()
			{
				return string.Format("{0};{1};{2};{3};{4}"+Environment.NewLine,Nome,Tempo,Stato,Environment.NewLine,Bombe,numMosse);
			}
			public string AsString()
			{
				return string.Format("{0} {1} {2} "+Environment.NewLine,Nome,Tempo,Stato);
			}
			public static Score Carica(string n)
			{
				string[] rec = n.Split(';');
				
				
				return new Score(rec[0],rec[1],rec[2],rec[3],rec[4]);
			}
			
		}
		List<Score> Punti;
		string Livello;
		~Punteggio()
		{
			File.WriteAllText("./Punteggio/"+Livello+".json",string.Join("",Punti.Select(entry=>entry.UnScore())));
			
		}
		
		public Punteggio(int lvl)
		{
			switch(lvl)
			{
				case 0:
					Livello="Principiante";
					break;
					
				case 1:
					Livello="Normale";
					break;
				
				case 2:
					Livello="Esperto";
					break;
				default:
					break;
					
					
			}
			if(!Directory.Exists("./Punteggio"))
				Directory.CreateDirectory("./Punteggio");
			
			if(!File.Exists("./Punteggio/"+Livello+".json"))
				File.Create("./Punteggio/"+Livello+".json").Close();
			
			Punti=File.ReadAllLines("Punteggio/"+Livello+".json").Select(line => Score.Carica(line)).Take(puntegioentri).ToList();
			
			
		}
		public bool Controlla()
		{
			return Punti.Count > 0;
		}
		/*public string Stato(bool stato)
		{
			switch(stato) 
			{
				case true:
					return string a = "Completato";
				case false:
					return string b = "Sconfitta";
				default:
					break;
			}
		}*/
		public string Tutti()
		{
			
		  return string.Join("",Punti.OrderBy(min =>
		   {
			int [] arg = min.Tempo.Split(':').Select(s=>int.Parse(s)).ToArray();
		    return arg[0]*60*1000+arg[1]*1000+arg[2]*10;
			                                     }).Take(puntegioentri).Select((min,ind)=>string.Format("{0} {1,15} {2} {3} {4} {5} "+Environment.NewLine,ind+1,min.Nome,min.Tempo,min.Stato,min.Bombe,min.numMosse)));
			
			
		}
		public string Tempomin()
		{
			return Punti.Count>=puntegioentri ? Punti.Last().Tempo:"60:60:99";
			
		}
		public void Add(string nome,string tempo,string stato,string bombe,string mosse)
		{
			
			
			Punti.Add(new Score(nome,tempo,stato,bombe,mosse));
	        
			Punti=Punti.OrderBy(record=>{
			                      	int[] arg = record.Tempo.Split(':').Select(h=> int.Parse(h)).ToArray();
			                      	return arg[0]*60*1000+arg[1]*1000+arg[2]*10;
			                      	
			                      }).Take(puntegioentri).ToList();
			
		}
		
	}
}
