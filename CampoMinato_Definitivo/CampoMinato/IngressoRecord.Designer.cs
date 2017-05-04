/*
 * Creato da SharpDevelop.
 * Utente: Tony
 * Data: 03/05/2017
 * Ora: 11:06
 * 
 * Per modificare questo modello usa Strumenti | Opzioni | Codice | Modifica Intestazioni Standard
 */
namespace CampoMinato
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Nome";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(36, 100);
			this.NameBox.MaxLength = 15;
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(153, 20);
			this.NameBox.TabIndex = 8;
			// 
			// ApplyButton
			// 
			this.ApplyButton.ForeColor = System.Drawing.Color.Black;
			this.ApplyButton.Location = new System.Drawing.Point(176, 161);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(75, 23);
			this.ApplyButton.TabIndex = 7;
			this.ApplyButton.Text = "Applica";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButtonClick);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(36, 161);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 6;
			this.CancelButton.Text = "Cancella";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Inserisci il tuo nome";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.ApplyButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Ingresso Record";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button ApplyButton;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.Label label2;
	}
}
