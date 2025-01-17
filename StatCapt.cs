using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Opindus
{
	/// <summary>
	/// Description résumée de StatCapt.
	/// </summary>
	public class StatCapt : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private int Agence;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private int Page;
		private int countRow;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		int NbrCam;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StatCapt(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			Page=0;
			NbrCam=0;
			countRow=0;
			this.Agence=Agence;
			if(Agence.Equals(1))
			{
				oleDbConnection1.ConnectionString=@"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			}
			else if(Agence.Equals(2))
			{
				oleDbConnection1.ConnectionString=@"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lille\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			}
			else if(Agence.Equals(3))
			{
				oleDbConnection1.ConnectionString=@"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Rouen\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			}
			printDocument1.DefaultPageSettings.Landscape=false;
			printDocument1.DefaultPageSettings.Margins.Bottom=50;
			printPreviewDialog1.SetBounds(0,0,800,600);

		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(StatCapt));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(16, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(488, 100);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Période";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(56, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 25;
			this.label5.Text = "Format de date incorrect";
			this.label5.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(208, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 20);
			this.textBox2.TabIndex = 24;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(58, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 23;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 19);
			this.label2.TabIndex = 22;
			this.label2.Text = "au";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(24, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 21;
			this.label1.Text = "Du";
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_parc_CAPTEURS", new System.Data.Common.DataColumnMapping[] {
																																																						   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																						   new System.Data.Common.DataColumnMapping("Chaine", "Chaine")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_parc_CAPTEURS WHERE (ID = ?) AND (Chaine = ? OR ? IS NULL AND Chain" +
				"e IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_parc_CAPTEURS(Chaine) VALUES (?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT ID, Chaine FROM T_parc_CAPTEURS";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_parc_CAPTEURS SET Chaine = ? WHERE (ID = ?) AND (Chaine = ? OR ? IS NULL" +
				" AND Chaine IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(159, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(16, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 21;
			this.button1.Text = "Visualiser";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(128, 168);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 22;
			this.button3.Text = "Imprimer";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(456, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 48);
			this.button2.TabIndex = 23;
			this.button2.TabStop = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// StatCapt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(522, 216);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "StatCapt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Statistiques capteurs";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Page+=1;
			int ypos=e.MarginBounds.Top;
			e.Graphics.DrawString("Edition Capteurs", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, e.MarginBounds.Top);
			ypos+=40;
			if(Agence.Equals(1))
				e.Graphics.DrawString("Agence : St Priest 69800", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
			else if(Agence.Equals(2))
				e.Graphics.DrawString("Agence : Lille", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
			else if(Agence.Equals(3))
				e.Graphics.DrawString("Agence : Rouen", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
			ypos+=25;
			e.Graphics.DrawString("Période du : "+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+" au "+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+210, ypos);
			ypos+=27;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=15;
			e.Graphics.DrawString("Nombre de contrôles sur période", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			ypos+=30;
			e.Graphics.DrawString("Contrôle CAM", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=30;
			string anciencapt=null;
			bool debut=true;
			while(ypos<e.MarginBounds.Height&&(countRow<dataSet11.Tables["t_controles_cam"].Rows.Count)&&(dataSet11.Tables["t_controles_cam"].Rows.Count>0))
			{
				if(debut)
					debut=false;
				else
				{
					anciencapt=dataSet11.Tables["t_controles_cam"].Rows[countRow-1]["Chaine"].ToString();
				}
				if(countRow.Equals(NbrCam))
				{
					ypos+=30;
					e.Graphics.DrawString("Contrôle DYN", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					ypos+=30;
				}
					if(anciencapt!=dataSet11.Tables["t_controles_cam"].Rows[countRow]["Chaine"].ToString())
				{
					e.Graphics.DrawString(dataSet11.Tables["t_controles_cam"].Rows[countRow]["Chaine"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(dataSet11.Tables["t_controles_cam"].Rows[countRow]["CompteDeCapteur"].ToString(),
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+470, ypos);
				}
				
				ypos+=15;
				countRow+=1;
			}
			ypos+=20;
			e.Graphics.DrawString(DateTime.Now.ToLongDateString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom-50);
			e.Graphics.DrawString("Page "+Page.ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-50, e.MarginBounds.Bottom-50);
			if(countRow<(dataSet11.Tables["t_controles_cam"].Rows.Count))
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Convert.ToDateTime(textBox1.Text);
				System.Convert.ToDateTime(textBox2.Text);
				label5.Visible=false;
				OleDbDataAdapter DataAD = new OleDbDataAdapter();
				OleDbCommand Comm = new OleDbCommand();
				Comm.Connection = oleDbConnection1;
				Comm.CommandText="SELECT T_parc_CAPTEURS.Chaine, Count(T_controles_cam.capteur) AS CompteDecapteur FROM T_parc_CAPTEURS INNER JOIN T_controles_cam ON T_parc_CAPTEURS.ID = T_controles_cam.capteur WHERE (((T_controles_cam.Date_controle)>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_controles_cam.Date_controle)<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#)) GROUP BY T_parc_CAPTEURS.Chaine ORDER BY T_parc_CAPTEURS.Chaine;";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(dataSet11,"t_controles_cam");
				NbrCam=dataSet11.Tables["t_controles_cam"].Rows.Count;

				OleDbDataAdapter DataAD2 = new OleDbDataAdapter();
				Comm.CommandText="SELECT T_parc_CAPTEURS.Chaine, Count(T_controles_dym.capteur) AS CompteDecapteur FROM T_parc_CAPTEURS INNER JOIN T_controles_dym ON T_parc_CAPTEURS.ID = T_controles_dym.capteur WHERE (((T_controles_dym.Date_controle)>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_controles_dym.Date_controle)<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#)) GROUP BY T_parc_CAPTEURS.Chaine ORDER BY T_parc_CAPTEURS.Chaine";
				DataAD2.SelectCommand=Comm;
				DataAD2.Fill(dataSet11,"t_controles_cam");


				printPreviewDialog1.Document=printDocument1;
				printPreviewDialog1.ShowDialog();
				countRow=0;
				Page=0;
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
				label5.Visible=true;
			}
			
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			OleDbDataAdapter DataAD = new OleDbDataAdapter();
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection = oleDbConnection1;
			Comm.CommandText="SELECT T_parc_CAPTEURS.Chaine, Count(T_controles_cam.capteur) AS CompteDecapteur FROM T_parc_CAPTEURS INNER JOIN T_controles_cam ON T_parc_CAPTEURS.ID = T_controles_cam.capteur WHERE (((T_controles_cam.Date_controle)>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_controles_cam.Date_controle)<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#)) GROUP BY T_parc_CAPTEURS.Chaine ORDER BY T_parc_CAPTEURS.Chaine;";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(dataSet11,"t_controles_cam");
			NbrCam=dataSet11.Tables["t_controles_cam"].Rows.Count;

			OleDbDataAdapter DataAD2 = new OleDbDataAdapter();
			Comm.CommandText="SELECT T_parc_CAPTEURS.Chaine, Count(T_controles_dym.capteur) AS CompteDecapteur FROM T_parc_CAPTEURS INNER JOIN T_controles_dym ON T_parc_CAPTEURS.ID = T_controles_dym.capteur WHERE (((T_controles_dym.Date_controle)>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_controles_dym.Date_controle)<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#)) GROUP BY T_parc_CAPTEURS.Chaine ORDER BY T_parc_CAPTEURS.Chaine";
			DataAD2.SelectCommand=Comm;
			DataAD2.Fill(dataSet11,"t_controles_cam");
			printDocument1.Print();
			countRow=0;
			Page=0;
		}

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue!=8)
			{
				if(textBox1.TextLength.Equals(2))
				{
					textBox1.Text+="/";
					textBox1.Select(3,1);
				}
				else if(textBox1.TextLength.Equals(5))
				{
					textBox1.Text+="/";
					textBox1.Select(6,1);
				}
				else if(textBox1.TextLength.Equals(7))
					textBox2.Focus();
			}
		}

		private void textBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue!=8)
			{
				if(textBox2.TextLength.Equals(2))
				{
					textBox2.Text+="/";
					textBox2.Select(3,1);
				}
				else if(textBox2.TextLength.Equals(5))
				{
					textBox2.Text+="/";
					textBox2.Select(6,1);
				}
			}
		}
	}
}
