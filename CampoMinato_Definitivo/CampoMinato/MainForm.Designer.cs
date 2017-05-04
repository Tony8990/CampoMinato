/*
 * Created by SharpDevelop.
 * User: Tony
 * Date: 30/04/2017
 * Time: 11:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CampoMinato
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.btnprinci = new System.Windows.Forms.Button();
			this.btnnorm = new System.Windows.Forms.Button();
			this.btnpuntpri = new System.Windows.Forms.Button();
			this.btnesp = new System.Windows.Forms.Button();
			this.btnpuntipro = new System.Windows.Forms.Button();
			this.btnpuntinorm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label1.Location = new System.Drawing.Point(63, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(320, 75);
			this.label1.TabIndex = 0;
			this.label1.Text = "CAMPO MINATO";
			// 
			// btnprinci
			// 
			this.btnprinci.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnprinci.ForeColor = System.Drawing.Color.Red;
			this.btnprinci.Location = new System.Drawing.Point(26, 124);
			this.btnprinci.Name = "btnprinci";
			this.btnprinci.Size = new System.Drawing.Size(288, 50);
			this.btnprinci.TabIndex = 1;
			this.btnprinci.Text = "Principiante";
			this.btnprinci.UseVisualStyleBackColor = true;
			this.btnprinci.Click += new System.EventHandler(this.BtnprinciClick);
			// 
			// btnnorm
			// 
			this.btnnorm.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnnorm.ForeColor = System.Drawing.Color.Red;
			this.btnnorm.Location = new System.Drawing.Point(26, 180);
			this.btnnorm.Name = "btnnorm";
			this.btnnorm.Size = new System.Drawing.Size(288, 50);
			this.btnnorm.TabIndex = 2;
			this.btnnorm.Text = "Normale";
			this.btnnorm.UseVisualStyleBackColor = true;
			this.btnnorm.Click += new System.EventHandler(this.BtnnormClick);
			// 
			// btnpuntpri
			// 
			this.btnpuntpri.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnpuntpri.ForeColor = System.Drawing.Color.Red;
			this.btnpuntpri.Location = new System.Drawing.Point(343, 124);
			this.btnpuntpri.Name = "btnpuntpri";
			this.btnpuntpri.Size = new System.Drawing.Size(86, 50);
			this.btnpuntpri.TabIndex = 3;
			this.btnpuntpri.Text = "Punteggio PRI";
			this.btnpuntpri.UseVisualStyleBackColor = true;
			this.btnpuntpri.Click += new System.EventHandler(this.BtnpuntpriClick);
			// 
			// btnesp
			// 
			this.btnesp.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnesp.ForeColor = System.Drawing.Color.Red;
			this.btnesp.Location = new System.Drawing.Point(26, 236);
			this.btnesp.Name = "btnesp";
			this.btnesp.Size = new System.Drawing.Size(288, 50);
			this.btnesp.TabIndex = 6;
			this.btnesp.Text = "Esperto";
			this.btnesp.UseVisualStyleBackColor = true;
			this.btnesp.Click += new System.EventHandler(this.BtnespClick);
			// 
			// btnpuntipro
			// 
			this.btnpuntipro.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnpuntipro.ForeColor = System.Drawing.Color.Red;
			this.btnpuntipro.Location = new System.Drawing.Point(343, 236);
			this.btnpuntipro.Name = "btnpuntipro";
			this.btnpuntipro.Size = new System.Drawing.Size(86, 50);
			this.btnpuntipro.TabIndex = 7;
			this.btnpuntipro.Text = "Punteggio PRO";
			this.btnpuntipro.UseVisualStyleBackColor = true;
			this.btnpuntipro.Click += new System.EventHandler(this.BtnpuntiproClick);
			// 
			// btnpuntinorm
			// 
			this.btnpuntinorm.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnpuntinorm.ForeColor = System.Drawing.Color.Red;
			this.btnpuntinorm.Location = new System.Drawing.Point(343, 182);
			this.btnpuntinorm.Name = "btnpuntinorm";
			this.btnpuntinorm.Size = new System.Drawing.Size(86, 50);
			this.btnpuntinorm.TabIndex = 8;
			this.btnpuntinorm.Text = "Punteggio NORM";
			this.btnpuntinorm.UseVisualStyleBackColor = true;
			this.btnpuntinorm.Click += new System.EventHandler(this.BtnpuntinormClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(441, 312);
			this.Controls.Add(this.btnpuntinorm);
			this.Controls.Add(this.btnpuntipro);
			this.Controls.Add(this.btnesp);
			this.Controls.Add(this.btnpuntpri);
			this.Controls.Add(this.btnnorm);
			this.Controls.Add(this.btnprinci);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "CampoMinato";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnpuntinorm;
		private System.Windows.Forms.Button btnpuntipro;
		private System.Windows.Forms.Button btnesp;
		private System.Windows.Forms.Button btnpuntpri;
		private System.Windows.Forms.Button btnnorm;
		private System.Windows.Forms.Button btnprinci;
		private System.Windows.Forms.Label label1;
	}
}
