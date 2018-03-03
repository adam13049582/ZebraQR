/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 26.02.2018
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZebraQR
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox adres;
		private System.Windows.Forms.TextBox pwiersz;
		private System.Windows.Forms.TextBox owiersz;
		private System.Windows.Forms.TextBox sciezka;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button druk;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.PictureBox obraz;
		private System.Windows.Forms.PictureBox pictureBox1;

		
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
		/// 
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.adres = new System.Windows.Forms.TextBox();
			this.pwiersz = new System.Windows.Forms.TextBox();
			this.owiersz = new System.Windows.Forms.TextBox();
			this.sciezka = new System.Windows.Forms.TextBox();
			this.druk = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.Label();
			this.obraz = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.obraz)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// adres
			// 
			this.adres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.adres.Location = new System.Drawing.Point(235, 51);
			this.adres.Name = "adres";
			this.adres.Size = new System.Drawing.Size(459, 29);
			this.adres.TabIndex = 0;
			// 
			// pwiersz
			// 
			this.pwiersz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pwiersz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.pwiersz.Location = new System.Drawing.Point(235, 211);
			this.pwiersz.Name = "pwiersz";
			this.pwiersz.Size = new System.Drawing.Size(459, 29);
			this.pwiersz.TabIndex = 1;
			// 
			// owiersz
			// 
			this.owiersz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.owiersz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.owiersz.Location = new System.Drawing.Point(235, 306);
			this.owiersz.Name = "owiersz";
			this.owiersz.Size = new System.Drawing.Size(459, 29);
			this.owiersz.TabIndex = 2;
			// 
			// sciezka
			// 
			this.sciezka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.sciezka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sciezka.Location = new System.Drawing.Point(235, 127);
			this.sciezka.Name = "sciezka";
			this.sciezka.Size = new System.Drawing.Size(459, 29);
			this.sciezka.TabIndex = 3;
			// 
			// druk
			// 
			this.druk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.druk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.druk.Location = new System.Drawing.Point(233, 355);
			this.druk.Name = "druk";
			this.druk.Size = new System.Drawing.Size(459, 42);
			this.druk.TabIndex = 4;
			this.druk.Text = "DRUKUJ";
			this.druk.UseVisualStyleBackColor = true;
			this.druk.Click += new System.EventHandler(this.drukuj);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(235, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(458, 30);
			this.label1.TabIndex = 5;
			this.label1.Text = "Podaj adres IP drukarki:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(235, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(458, 30);
			this.label2.TabIndex = 6;
			this.label2.Text = "Podaj scieżkę do pliku Excel:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(235, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(458, 30);
			this.label3.TabIndex = 7;
			this.label3.Text = "Podaj numer pierwszego wiersza do wydruku:";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(236, 258);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(458, 45);
			this.label4.TabIndex = 8;
			this.label4.Text = "Podaj numer ostatniego wiersza do wydruku. Jeśli jest to ostatni wiersz tabeli mo" +
	"zesz wpisać słowo \"MAX\":";
			// 
			// status
			// 
			this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.status.Location = new System.Drawing.Point(233, 416);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(458, 24);
			this.status.TabIndex = 9;
			// 
			// obraz
			// 
			this.obraz.Image = ((System.Drawing.Image)(resources.GetObject("obraz.Image")));
			this.obraz.InitialImage = ((System.Drawing.Image)(resources.GetObject("obraz.InitialImage")));
			this.obraz.Location = new System.Drawing.Point(2, 94);
			this.obraz.Name = "obraz";
			this.obraz.Size = new System.Drawing.Size(225, 216);
			this.obraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.obraz.TabIndex = 10;
			this.obraz.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(748, 375);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(86, 86);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(846, 473);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.obraz);
			this.Controls.Add(this.status);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.druk);
			this.Controls.Add(this.sciezka);
			this.Controls.Add(this.owiersz);
			this.Controls.Add(this.pwiersz);
			this.Controls.Add(this.adres);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1200, 512);
			this.Name = "MainForm";
			this.Text = "ZebraQR";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close);
			((System.ComponentModel.ISupportInitialize)(this.obraz)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
