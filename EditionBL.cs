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
	/// Description résumée de EditionBL.
	/// </summary>
	public class EditionBL : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private int Agence;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button button2;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private int Page;
		private int countRow;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private OleDbCommand Comm;
		private OleDbTransaction Transac;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.Button button5;
		private String Devis;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EditionBL(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAD=new OleDbDataAdapter();
			ds=new DataSet();
			Page=0;
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
			InitializeData();
			oleDbSelectCommand1.CommandText="SELECT T_BL_entete.[N° BL], T_BL_entete.Date, T_clients.Nom, T_BL_entete.Edite FROM T_clients INNER JOIN T_BL_entete ON T_clients.Ident = T_BL_entete.[Code client] WHERE (((T_BL_entete.Edite)=False))";
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			foreach(DataRow row in dataSet11.Tables["t_devis_entete"].Rows)
			{
				listView1.Items.Add(row["N° BL"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Date"].ToString().Remove(10,9));
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["nom"].ToString());
			}
			try
			{
				oleDbDataAdapter3.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			printDocument1.DefaultPageSettings.Landscape=false;
			printDocument1.DefaultPageSettings.Margins.Bottom=50;
			printDocument1.DefaultPageSettings.Margins.Left=50;
			printDocument1.DefaultPageSettings.Margins.Right=50;
			printDocument1.DefaultPageSettings.Margins.Bottom=50;
			//printPreviewDialog1.SetBounds(0,0,800,600);

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EditionBL));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.button2 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.MintCream;
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader3});
			this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(16, 16);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(640, 352);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "N° BL";
			this.columnHeader1.Width = 70;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Date";
			this.columnHeader2.Width = 90;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Client";
			this.columnHeader3.Width = 460;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_BL_entete", new System.Data.Common.DataColumnMapping[] {
																																																					   new System.Data.Common.DataColumnMapping("Code client", "Code client"),
																																																					   new System.Data.Common.DataColumnMapping("Code TVA", "Code TVA"),
																																																					   new System.Data.Common.DataColumnMapping("Comment", "Comment"),
																																																					   new System.Data.Common.DataColumnMapping("Date", "Date"),
																																																					   new System.Data.Common.DataColumnMapping("Edite", "Edite"),
																																																					   new System.Data.Common.DataColumnMapping("N° BL", "N° BL"),
																																																					   new System.Data.Common.DataColumnMapping("N° Commande ouverte", "N° Commande ouverte"),
																																																					   new System.Data.Common.DataColumnMapping("OR", "OR"),
																																																					   new System.Data.Common.DataColumnMapping("Total bl", "Total bl"),
																																																					   new System.Data.Common.DataColumnMapping("Total bl Euros", "Total bl Euros"),
																																																					   new System.Data.Common.DataColumnMapping("transfere", "transfere"),
																																																					   new System.Data.Common.DataColumnMapping("transfert", "transfert")})});
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT [Code client], [Code TVA], Comment, [Date], Edite, [N° BL], [N° Commande o" +
				"uverte], [OR], [Total bl], [Total bl Euros], transfere, transfert FROM T_BL_ente" +
				"te WHERE (Edite = false)";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 384);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre d\'impressions";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(160, 384);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 2,
																		 0,
																		 0,
																		 0});
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lavender;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(224, 382);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Imprimer";
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Parametres", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("e_mail", "e_mail"),
																																																					  new System.Data.Common.DataColumnMapping("F_adresse1", "F_adresse1"),
																																																					  new System.Data.Common.DataColumnMapping("F_adresse2", "F_adresse2"),
																																																					  new System.Data.Common.DataColumnMapping("F_cp", "F_cp"),
																																																					  new System.Data.Common.DataColumnMapping("F_fax", "F_fax"),
																																																					  new System.Data.Common.DataColumnMapping("F_tel", "F_tel"),
																																																					  new System.Data.Common.DataColumnMapping("F_ville", "F_ville"),
																																																					  new System.Data.Common.DataColumnMapping("L_adresse1", "L_adresse1"),
																																																					  new System.Data.Common.DataColumnMapping("L_adresse2", "L_adresse2"),
																																																					  new System.Data.Common.DataColumnMapping("L_cp", "L_cp"),
																																																					  new System.Data.Common.DataColumnMapping("L_fax", "L_fax"),
																																																					  new System.Data.Common.DataColumnMapping("L_tel", "L_tel"),
																																																					  new System.Data.Common.DataColumnMapping("L_ville", "L_ville"),
																																																					  new System.Data.Common.DataColumnMapping("Message_cde", "Message_cde"),
																																																					  new System.Data.Common.DataColumnMapping("signature", "signature"),
																																																					  new System.Data.Common.DataColumnMapping("Societe", "Societe")})});
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Parametres(e_mail, F_adresse1, F_adresse2, F_cp, F_fax, F_tel, F_vill" +
				"e, L_adresse1, L_adresse2, L_cp, L_fax, L_tel, L_ville, Message_cde, signature, " +
				"Societe) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("e_mail", System.Data.OleDb.OleDbType.VarWChar, 50, "e_mail"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_adresse1", System.Data.OleDb.OleDbType.VarWChar, 50, "F_adresse1"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_adresse2", System.Data.OleDb.OleDbType.VarWChar, 50, "F_adresse2"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_cp", System.Data.OleDb.OleDbType.VarWChar, 50, "F_cp"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_fax", System.Data.OleDb.OleDbType.VarWChar, 50, "F_fax"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_tel", System.Data.OleDb.OleDbType.VarWChar, 50, "F_tel"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_ville", System.Data.OleDb.OleDbType.VarWChar, 50, "F_ville"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_adresse1", System.Data.OleDb.OleDbType.VarWChar, 50, "L_adresse1"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_adresse2", System.Data.OleDb.OleDbType.VarWChar, 50, "L_adresse2"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_cp", System.Data.OleDb.OleDbType.VarWChar, 50, "L_cp"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_fax", System.Data.OleDb.OleDbType.VarWChar, 50, "L_fax"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_tel", System.Data.OleDb.OleDbType.VarWChar, 50, "L_tel"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_ville", System.Data.OleDb.OleDbType.VarWChar, 50, "L_ville"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_cde", System.Data.OleDb.OleDbType.VarWChar, 0, "Message_cde"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("signature", System.Data.OleDb.OleDbType.VarWChar, 50, "signature"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Societe", System.Data.OleDb.OleDbType.VarWChar, 50, "Societe"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT e_mail, F_adresse1, F_adresse2, F_cp, F_fax, F_tel, F_ville, L_adresse1, L" +
				"_adresse2, L_cp, L_fax, L_tel, L_ville, Message_cde, signature, Societe FROM Par" +
				"ametres";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(609, 376);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 17;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// EditionBL
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(672, 432);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EditionBL";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edition groupée des BL";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
		private void InitializeData()
		{
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="SELECT T_BL_entete.[Code client], T_BL_entete.[Code TVA], T_BL_entete.Comment, T_BL_entete.[Date], T_BL_entete.Edite, T_BL_entete.[N° BL], T_BL_entete.[N° Commande ouverte], T_BL_entete.[OR], T_BL_entete.[Total bl], T_BL_entete.[Total bl Euros], T_BL_entete.transfere, T_BL_entete.transfert,t_clients.nom FROM T_BL_entete,T_clients WHERE t_bl_entete.[Code client]=t_clients.Ident and (Edite = false)";
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			foreach(DataRow row in dataSet11.Tables["t_bl_entete"].Rows)
			{
				listView1.Items.Add(row["N° BL"].ToString());
				if(row["Date"].ToString().Length>0)
					listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Date"].ToString().Remove(10,9));
				else
					listView1.Items[listView1.Items.Count-1].SubItems.Add("");
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Nom"].ToString());
			}
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e)
		{
			BL WinBL = new BL(Agence, listView1.Items[listView1.SelectedIndices[0]].Text);
			WinBL.ShowDialog();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			for(int i=0;i<listView1.CheckedIndices.Count;i++)
			{
					try
					{

                        Comm.CommandText = "SELECT T_clients.Nom, T_clients.Adresse_1, T_clients.Adresse_2, T_clients.Code_Postal, T_clients.Ville, T_clients.Pays, T_BL_entete.[N° BL], T_BL_entete.[OR], T_BL_entete.[N° Commande ouverte], T_BL_entete.[Total bl], T_BL_entete.Date,T_BL_entete.Comment FROM T_type_machine INNER JOIN ((T_clients INNER JOIN T_BL_entete ON T_clients.Ident = T_BL_entete.[Code client]) INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_BL_entete.Date, T_clients.Nom, T_clients.Adresse_1, T_clients.Adresse_2, T_clients.Code_Postal, T_clients.Ville, T_clients.Pays, T_BL_entete.[N° BL], T_BL_entete.[OR], T_BL_entete.[N° Commande ouverte], T_BL_entete.[Total bl],T_BL_entete.Comment HAVING (((T_BL_entete.[N° BL])=" + listView1.Items[listView1.CheckedIndices[i]].Text + "))"; 
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"t_bl_entete");
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.CommandText="update t_bl_entete set edite=True, transfert=True where [n° bl]="+ds.Tables["t_bl_entete"].Rows[0]["n° bl"].ToString();
						Comm.Transaction=Transac;
						try
						{
							Comm.ExecuteNonQuery();
							Transac.Commit();
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						finally
						{
							oleDbConnection1.Close();
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}	
				try
				{
					Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_BL_Lignes.[Code Mabec], T_BL_Lignes.[Type Materiel], T_BL_Lignes.[Code materiel], T_BL_Lignes.Fournisseur, T_BL_Lignes.Troncon, T_BL_Lignes.[Total ligne], T_BL_Lignes.Montant FROM (T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_BL_entete INNER JOIN T_BL_Lignes ON T_BL_entete.[N° BL] = T_BL_Lignes.[N° BL]) ON T_devis_entete.[N° Devis] = T_BL_Lignes.[N° Devis] WHERE (((T_BL_entete.[N° BL])="+listView1.Items[listView1.CheckedIndices[i]].Text+")) GROUP BY T_devis_entete.[N° Devis], T_BL_Lignes.[Code Mabec], T_BL_Lignes.[Type Materiel], T_BL_Lignes.[Code materiel], T_BL_Lignes.Fournisseur, T_BL_Lignes.Troncon, T_BL_Lignes.[Total ligne], T_BL_Lignes.Montant";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"t_bl_lignes");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}	
				for(int j=System.Convert.ToInt32(numericUpDown1.Value);j>0;j--)
				{
					Devis=listView1.Items[listView1.CheckedIndices[i]].Text;
					countRow=0;
					Page=0;
                    printDocument1.DefaultPageSettings.Landscape = false;
                    printDocument1.DefaultPageSettings.Margins.Bottom = 50;
                    printDocument1.DefaultPageSettings.Margins.Left = 50;
                    printDocument1.DefaultPageSettings.Margins.Right = 50;
                    printDocument1.DefaultPageSettings.Margins.Bottom = 50;
					printDocument1.Print();
				}
				ds.Clear();
			}
			
			Dispose();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Page+=1;
			int ypos=e.MarginBounds.Top+120;
			if(Agence.Equals(1))
                e.Graphics.DrawString("St Priest le : " + System.Convert.ToDateTime(ds.Tables["t_bl_entete"].Rows[0]["Date"].ToString()).ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width / 2 + 130, ypos);
			else if(Agence.Equals(2))
                e.Graphics.DrawString("Fretin le : " + System.Convert.ToDateTime(ds.Tables["t_bl_entete"].Rows[0]["Date"].ToString()).ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width / 2 + 130, ypos);
			else if(Agence.Equals(3))
                e.Graphics.DrawString("Rouen le : " + System.Convert.ToDateTime(ds.Tables["t_bl_entete"].Rows[0]["Date"].ToString()).ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width / 2 + 130, ypos);
			ypos+=15;
			ypos+=15;
			e.Graphics.DrawString(ds.Tables["t_bl_entete"].Rows[0]["nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=15;
			e.Graphics.DrawString(ds.Tables["t_bl_entete"].Rows[0]["adresse_1"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=15;
			e.Graphics.DrawString(ds.Tables["t_bl_entete"].Rows[0]["adresse_2"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=15;
			e.Graphics.DrawString(ds.Tables["t_bl_entete"].Rows[0]["code_postal"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			e.Graphics.DrawString(ds.Tables["t_bl_entete"].Rows[0]["ville"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+180, ypos);
			ypos+=15;
			e.Graphics.DrawString(ds.Tables["t_bl_entete"].Rows[0]["pays"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=20;
			e.Graphics.DrawString("BL N° "+ds.Tables["t_bl_entete"].Rows[0]["N° BL"].ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
			ypos+=25;
			e.Graphics.DrawString("Ordre Travail", new Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("N° Commande ouverte", new Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left+200, ypos);
			ypos+=25;
		    e.Graphics.DrawString(ds.Tables["t_bl_entete"].Rows[0]["OR"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(ds.Tables["t_bl_entete"].Rows[0]["N° commande ouverte"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
			ypos+=25;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=2;
			e.Graphics.DrawString("Devis", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("C. Mabec", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+40, ypos);
			e.Graphics.DrawString("Type matériel", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+130, ypos);
			e.Graphics.DrawString("Code matériel", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+290, ypos);
			e.Graphics.DrawString("Fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+390, ypos);
			e.Graphics.DrawString("Tronçon", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+550, ypos);
			e.Graphics.DrawString("Décision", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+610, ypos);
			e.Graphics.DrawString("Total ligne", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+670, ypos);
			ypos+=15;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=5;
			while(ypos<e.MarginBounds.Height-130&&countRow<ds.Tables["t_bl_lignes"].Rows.Count)
			{ 
				e.Graphics.DrawString(ds.Tables["t_bl_lignes"].Rows[countRow]["n° devis"].ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				if(ds.Tables["t_bl_lignes"].Rows[countRow]["code mabec"].ToString()!="?")
				{
					e.Graphics.DrawString(ds.Tables["t_bl_lignes"].Rows[countRow]["code mabec"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+40, ypos);
				}
				e.Graphics.DrawString(ds.Tables["t_bl_lignes"].Rows[countRow]["Type materiel"].ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+130, ypos);
				e.Graphics.DrawString(ds.Tables["t_bl_lignes"].Rows[countRow]["code materiel"].ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+290, ypos);
				e.Graphics.DrawString(ds.Tables["t_bl_lignes"].Rows[countRow]["fournisseur"].ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+390, ypos);
				e.Graphics.DrawString(ds.Tables["t_bl_lignes"].Rows[countRow]["Troncon"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+550, ypos);
				if(ds.Tables["t_bl_lignes"].Rows[countRow]["Montant"].ToString().Length>0&&ds.Tables["t_bl_lignes"].Rows[countRow]["Montant"].ToString()!="?")
				{
					e.Graphics.DrawString(ds.Tables["t_bl_lignes"].Rows[countRow]["Montant"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+610, ypos);
				}
				e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["t_bl_lignes"].Rows[countRow]["Total ligne"].ToString()).ToString("c")+" €", 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+670, ypos);
				ypos+=15;
				countRow+=1;
			}
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,e.MarginBounds.Height-100), new Point(e.MarginBounds.Right,e.MarginBounds.Height-100));
			ypos+=5;
			e.Graphics.DrawString("Nombre de machine(s) : "+ds.Tables["t_bl_lignes"].Rows.Count.ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, e.MarginBounds.Height-90);
			Comm.CommandText="SELECT Sum(T_BL_Lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM T_BL_Lignes WHERE (((T_BL_Lignes.[N° BL])="+Devis+"))";
			Decimal Total=0;
			try
			{
				oleDbConnection1.Open();
				Total=System.Convert.ToDecimal(Comm.ExecuteScalar());
				
			}
			catch
			{
				Total=0;
			}
			finally
			{
				oleDbConnection1.Close();
			}
			e.Graphics.DrawString("Total net H.T.   : "+Total.ToString("0.00")+" €", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+580, e.MarginBounds.Height-90);
			ypos+=15;
			e.Graphics.DrawString("Remarques :", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Height-70);
			ypos+=20;
			e.Graphics.DrawString(ds.Tables["t_bl_entete"].Rows[0]["Comment"].ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Height-70);
			if(countRow<ds.Tables["t_bl_lignes"].Rows.Count)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
