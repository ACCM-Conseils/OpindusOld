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
	/// Description résumée de Niveau3.
	/// </summary>
	public class Niveau3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private int Page;
		private int Agence;
		private int countRow;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Niveau3(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Niveau3));
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(120, 17);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Imprimer";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(8, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Visualiser";
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.printPreviewDialog1.Location = new System.Drawing.Point(148, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
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
																										new System.Data.Common.DataTableMapping("Table", "T_devis_entete", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("Accord Client", "Accord Client"),
																																																						  new System.Data.Common.DataColumnMapping("Calcul Auto", "Calcul Auto"),
																																																						  new System.Data.Common.DataColumnMapping("Cause atelier", "Cause atelier"),
																																																						  new System.Data.Common.DataColumnMapping("Cause client", "Cause client"),
																																																						  new System.Data.Common.DataColumnMapping("Code Client", "Code Client"),
																																																						  new System.Data.Common.DataColumnMapping("Code Materiel", "Code Materiel"),
																																																						  new System.Data.Common.DataColumnMapping("Commande generee", "Commande generee"),
																																																						  new System.Data.Common.DataColumnMapping("Comment", "Comment"),
																																																						  new System.Data.Common.DataColumnMapping("Date", "Date"),
																																																						  new System.Data.Common.DataColumnMapping("Date Decision", "Date Decision"),
																																																						  new System.Data.Common.DataColumnMapping("Date entree reelle", "Date entree reelle"),
																																																						  new System.Data.Common.DataColumnMapping("Date Generation commande", "Date Generation commande"),
																																																						  new System.Data.Common.DataColumnMapping("Date Reception pieces", "Date Reception pieces"),
																																																						  new System.Data.Common.DataColumnMapping("Date reparation", "Date reparation"),
																																																						  new System.Data.Common.DataColumnMapping("Detail atelier", "Detail atelier"),
																																																						  new System.Data.Common.DataColumnMapping("Detail Client", "Detail Client"),
																																																						  new System.Data.Common.DataColumnMapping("Edite", "Edite"),
																																																						  new System.Data.Common.DataColumnMapping("edition_fax", "edition_fax"),
																																																						  new System.Data.Common.DataColumnMapping("Emplacement", "Emplacement"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait Controle", "Forfait Controle"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait DNR", "Forfait DNR"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait transport", "Forfait transport"),
																																																						  new System.Data.Common.DataColumnMapping("Imputation comptable", "Imputation comptable"),
																																																						  new System.Data.Common.DataColumnMapping("Limite Devis", "Limite Devis"),
																																																						  new System.Data.Common.DataColumnMapping("Message Pieds", "Message Pieds"),
																																																						  new System.Data.Common.DataColumnMapping("n° Bl", "n° Bl"),
																																																						  new System.Data.Common.DataColumnMapping("N° Commande generee", "N° Commande generee"),
																																																						  new System.Data.Common.DataColumnMapping("N° Commande ouverte", "N° Commande ouverte"),
																																																						  new System.Data.Common.DataColumnMapping("N° Devis", "N° Devis"),
																																																						  new System.Data.Common.DataColumnMapping("N° Troncon", "N° Troncon"),
																																																						  new System.Data.Common.DataColumnMapping("Niveau", "Niveau"),
																																																						  new System.Data.Common.DataColumnMapping("Ordre Travail", "Ordre Travail"),
																																																						  new System.Data.Common.DataColumnMapping("Prix machine neuve", "Prix machine neuve"),
																																																						  new System.Data.Common.DataColumnMapping("Prix Reference", "Prix Reference"),
																																																						  new System.Data.Common.DataColumnMapping("Reforme", "Reforme"),
																																																						  new System.Data.Common.DataColumnMapping("Refus", "Refus"),
																																																						  new System.Data.Common.DataColumnMapping("Reparateur_D", "Reparateur_D"),
																																																						  new System.Data.Common.DataColumnMapping("Reparateur_R", "Reparateur_R"),
																																																						  new System.Data.Common.DataColumnMapping("Repare", "Repare"),
																																																						  new System.Data.Common.DataColumnMapping("Seuil Client", "Seuil Client"),
																																																						  new System.Data.Common.DataColumnMapping("Seuil devis", "Seuil devis"),
																																																						  new System.Data.Common.DataColumnMapping("Total devis", "Total devis"),
																																																						  new System.Data.Common.DataColumnMapping("Total devis euro", "Total devis euro"),
																																																						  new System.Data.Common.DataColumnMapping("Total pieces", "Total pieces"),
																																																						  new System.Data.Common.DataColumnMapping("Type devis", "Type devis"),
																																																						  new System.Data.Common.DataColumnMapping("Valide", "Valide")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_devis_entete WHERE ([N° Devis] = ?) AND ([Accord Client] = ?) AND (" +
				"[Calcul Auto] = ?) AND ([Cause atelier] = ? OR ? IS NULL AND [Cause atelier] IS " +
				"NULL) AND ([Cause client] = ? OR ? IS NULL AND [Cause client] IS NULL) AND ([Cod" +
				"e Client] = ? OR ? IS NULL AND [Code Client] IS NULL) AND ([Code Materiel] = ? O" +
				"R ? IS NULL AND [Code Materiel] IS NULL) AND ([Commande generee] = ? OR ? IS NUL" +
				"L AND [Commande generee] IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NUL" +
				"L) AND ([Date Decision] = ? OR ? IS NULL AND [Date Decision] IS NULL) AND ([Date" +
				" Generation commande] = ? OR ? IS NULL AND [Date Generation commande] IS NULL) A" +
				"ND ([Date Reception pieces] = ? OR ? IS NULL AND [Date Reception pieces] IS NULL" +
				") AND ([Date entree reelle] = ? OR ? IS NULL AND [Date entree reelle] IS NULL) A" +
				"ND ([Date reparation] = ? OR ? IS NULL AND [Date reparation] IS NULL) AND ([Deta" +
				"il Client] = ? OR ? IS NULL AND [Detail Client] IS NULL) AND ([Detail atelier] =" +
				" ? OR ? IS NULL AND [Detail atelier] IS NULL) AND (Edite = ?) AND (Emplacement =" +
				" ? OR ? IS NULL AND Emplacement IS NULL) AND ([Forfait Controle] = ? OR ? IS NUL" +
				"L AND [Forfait Controle] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfa" +
				"it DNR] IS NULL) AND ([Forfait transport] = ? OR ? IS NULL AND [Forfait transpor" +
				"t] IS NULL) AND ([Imputation comptable] = ? OR ? IS NULL AND [Imputation comptab" +
				"le] IS NULL) AND ([Limite Devis] = ? OR ? IS NULL AND [Limite Devis] IS NULL) AN" +
				"D ([Message Pieds] = ? OR ? IS NULL AND [Message Pieds] IS NULL) AND (Niveau = ?" +
				" OR ? IS NULL AND Niveau IS NULL) AND ([N° Commande generee] = ? OR ? IS NULL AN" +
				"D [N° Commande generee] IS NULL) AND ([N° Commande ouverte] = ?) AND ([N° Tronco" +
				"n] = ? OR ? IS NULL AND [N° Troncon] IS NULL) AND ([Ordre Travail] = ?) AND ([Pr" +
				"ix Reference] = ? OR ? IS NULL AND [Prix Reference] IS NULL) AND ([Prix machine " +
				"neuve] = ? OR ? IS NULL AND [Prix machine neuve] IS NULL) AND (Reforme = ?) AND " +
				"(Refus = ?) AND (Reparateur_D = ? OR ? IS NULL AND Reparateur_D IS NULL) AND (Re" +
				"parateur_R = ? OR ? IS NULL AND Reparateur_R IS NULL) AND (Repare = ?) AND ([Seu" +
				"il Client] = ? OR ? IS NULL AND [Seuil Client] IS NULL) AND ([Seuil devis] = ? O" +
				"R ? IS NULL AND [Seuil devis] IS NULL) AND ([Total devis] = ? OR ? IS NULL AND [" +
				"Total devis] IS NULL) AND ([Total devis euro] = ? OR ? IS NULL AND [Total devis " +
				"euro] IS NULL) AND ([Total pieces] = ? OR ? IS NULL AND [Total pieces] IS NULL) " +
				"AND ([Type devis] = ? OR ? IS NULL AND [Type devis] IS NULL) AND (Valide = ?) AN" +
				"D (edition_fax = ?) AND ([n° Bl] = ? OR ? IS NULL AND [n° Bl] IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Repare", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO T_devis_entete([Accord Client], [Calcul Auto], [Cause atelier], [Cause client], [Code Client], [Code Materiel], [Commande generee], Comment, [Date], [Date Decision], [Date entree reelle], [Date Generation commande], [Date Reception pieces], [Date reparation], [Detail atelier], [Detail Client], Edite, edition_fax, Emplacement, [Forfait Controle], [Forfait DNR], [Forfait transport], [Imputation comptable], [Limite Devis], [Message Pieds], [n° Bl], [N° Commande generee], [N° Commande ouverte], [N° Devis], [N° Troncon], Niveau, [Ordre Travail], [Prix machine neuve], [Prix Reference], Reforme, Refus, Reparateur_D, Reparateur_R, Repare, [Seuil Client], [Seuil devis], [Total devis], [Total devis euro], [Total pieces], [Type devis], Valide) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT [Accord Client], [Calcul Auto], [Cause atelier], [Cause client], [Code Client], [Code Materiel], [Commande generee], Comment, [Date], [Date Decision], [Date entree reelle], [Date Generation commande], [Date Reception pieces], [Date reparation], [Detail atelier], [Detail Client], Edite, edition_fax, Emplacement, [Forfait Controle], [Forfait DNR], [Forfait transport], [Imputation comptable], [Limite Devis], [Message Pieds], [n° Bl], [N° Commande generee], [N° Commande ouverte], [N° Devis], [N° Troncon], Niveau, [Ordre Travail], [Prix machine neuve], [Prix Reference], Reforme, Refus, Reparateur_D, Reparateur_R, Repare, [Seuil Client], [Seuil devis], [Total devis], [Total devis euro], [Total pieces], [Type devis], Valide FROM T_devis_entete";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_devis_entete SET [Accord Client] = ?, [Calcul Auto] = ?, [Cause atelier]" +
				" = ?, [Cause client] = ?, [Code Client] = ?, [Code Materiel] = ?, [Commande gene" +
				"ree] = ?, Comment = ?, [Date] = ?, [Date Decision] = ?, [Date entree reelle] = ?" +
				", [Date Generation commande] = ?, [Date Reception pieces] = ?, [Date reparation]" +
				" = ?, [Detail atelier] = ?, [Detail Client] = ?, Edite = ?, edition_fax = ?, Emp" +
				"lacement = ?, [Forfait Controle] = ?, [Forfait DNR] = ?, [Forfait transport] = ?" +
				", [Imputation comptable] = ?, [Limite Devis] = ?, [Message Pieds] = ?, [n° Bl] =" +
				" ?, [N° Commande generee] = ?, [N° Commande ouverte] = ?, [N° Devis] = ?, [N° Tr" +
				"oncon] = ?, Niveau = ?, [Ordre Travail] = ?, [Prix machine neuve] = ?, [Prix Ref" +
				"erence] = ?, Reforme = ?, Refus = ?, Reparateur_D = ?, Reparateur_R = ?, Repare " +
				"= ?, [Seuil Client] = ?, [Seuil devis] = ?, [Total devis] = ?, [Total devis euro" +
				"] = ?, [Total pieces] = ?, [Type devis] = ?, Valide = ? WHERE ([N° Devis] = ?) A" +
				"ND ([Accord Client] = ?) AND ([Calcul Auto] = ?) AND ([Cause atelier] = ? OR ? I" +
				"S NULL AND [Cause atelier] IS NULL) AND ([Cause client] = ? OR ? IS NULL AND [Ca" +
				"use client] IS NULL) AND ([Code Client] = ? OR ? IS NULL AND [Code Client] IS NU" +
				"LL) AND ([Code Materiel] = ? OR ? IS NULL AND [Code Materiel] IS NULL) AND ([Com" +
				"mande generee] = ? OR ? IS NULL AND [Commande generee] IS NULL) AND ([Date] = ? " +
				"OR ? IS NULL AND [Date] IS NULL) AND ([Date Decision] = ? OR ? IS NULL AND [Date" +
				" Decision] IS NULL) AND ([Date Generation commande] = ? OR ? IS NULL AND [Date G" +
				"eneration commande] IS NULL) AND ([Date Reception pieces] = ? OR ? IS NULL AND [" +
				"Date Reception pieces] IS NULL) AND ([Date entree reelle] = ? OR ? IS NULL AND [" +
				"Date entree reelle] IS NULL) AND ([Date reparation] = ? OR ? IS NULL AND [Date r" +
				"eparation] IS NULL) AND ([Detail Client] = ? OR ? IS NULL AND [Detail Client] IS" +
				" NULL) AND ([Detail atelier] = ? OR ? IS NULL AND [Detail atelier] IS NULL) AND " +
				"(Edite = ?) AND (Emplacement = ? OR ? IS NULL AND Emplacement IS NULL) AND ([For" +
				"fait Controle] = ? OR ? IS NULL AND [Forfait Controle] IS NULL) AND ([Forfait DN" +
				"R] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait transport] = ? OR ?" +
				" IS NULL AND [Forfait transport] IS NULL) AND ([Imputation comptable] = ? OR ? I" +
				"S NULL AND [Imputation comptable] IS NULL) AND ([Limite Devis] = ? OR ? IS NULL " +
				"AND [Limite Devis] IS NULL) AND ([Message Pieds] = ? OR ? IS NULL AND [Message P" +
				"ieds] IS NULL) AND (Niveau = ? OR ? IS NULL AND Niveau IS NULL) AND ([N° Command" +
				"e generee] = ? OR ? IS NULL AND [N° Commande generee] IS NULL) AND ([N° Commande" +
				" ouverte] = ?) AND ([N° Troncon] = ? OR ? IS NULL AND [N° Troncon] IS NULL) AND " +
				"([Ordre Travail] = ?) AND ([Prix Reference] = ? OR ? IS NULL AND [Prix Reference" +
				"] IS NULL) AND ([Prix machine neuve] = ? OR ? IS NULL AND [Prix machine neuve] I" +
				"S NULL) AND (Reforme = ?) AND (Refus = ?) AND (Reparateur_D = ? OR ? IS NULL AND" +
				" Reparateur_D IS NULL) AND (Reparateur_R = ? OR ? IS NULL AND Reparateur_R IS NU" +
				"LL) AND (Repare = ?) AND ([Seuil Client] = ? OR ? IS NULL AND [Seuil Client] IS " +
				"NULL) AND ([Seuil devis] = ? OR ? IS NULL AND [Seuil devis] IS NULL) AND ([Total" +
				" devis] = ? OR ? IS NULL AND [Total devis] IS NULL) AND ([Total devis euro] = ? " +
				"OR ? IS NULL AND [Total devis euro] IS NULL) AND ([Total pieces] = ? OR ? IS NUL" +
				"L AND [Total pieces] IS NULL) AND ([Type devis] = ? OR ? IS NULL AND [Type devis" +
				"] IS NULL) AND (Valide = ?) AND (edition_fax = ?) AND ([n° Bl] = ? OR ? IS NULL " +
				"AND [n° Bl] IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Repare", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
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
			this.button5.Location = new System.Drawing.Point(232, 4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 17;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Niveau3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(292, 56);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Niveau3";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Niveau 3 de + de 90 jours";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button3_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			Page+=1;
			int ypos=e.MarginBounds.Top+70;
				e.Graphics.DrawString("Niveau 3 de + 90 jours", new Font("Arial", 28, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, e.MarginBounds.Top);
			ypos+=5;
			e.Graphics.DrawString("Nom", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("N° Devis", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+250, ypos);
			e.Graphics.DrawString("Date", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+350, ypos);
			e.Graphics.DrawString("Code machine", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+450, ypos);
			e.Graphics.DrawString("Type machine", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+550, ypos);
			ypos+=17;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=5;
			string ancienfourn=null;
			bool debut=true;
			while(ypos<e.MarginBounds.Height&&(countRow<dataSet11.Tables["t_devis_entete"].Rows.Count)&&(dataSet11.Tables["t_devis_entete"].Rows.Count>0))
			{
				if(debut)
					debut=false;
				else
				{
					ancienfourn=dataSet11.Tables["t_devis_entete"].Rows[countRow-1]["Nom"].ToString();
				}
				TimeSpan dif=DateTime.Today-System.Convert.ToDateTime(dataSet11.Tables["t_devis_entete"].Rows[countRow]["Date"].ToString());
				if((ancienfourn!=dataSet11.Tables["t_devis_entete"].Rows[countRow]["Nom"].ToString())&&dif.Days>90)
				{
					ypos+=10;
					e.Graphics.DrawLine(new Pen(Color.Red, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=5;
					e.Graphics.DrawString(dataSet11.Tables["t_devis_entete"].Rows[countRow]["Nom"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos); 
					ypos+=20;
				}
				if(dif.Days>90)
				{
					e.Graphics.DrawString(dataSet11.Tables["t_devis_entete"].Rows[countRow]["N° Devis"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
					if(dataSet11.Tables["t_devis_entete"].Rows[countRow]["Date"].ToString().Length>0)
						e.Graphics.DrawString(dataSet11.Tables["t_devis_entete"].Rows[countRow]["Date"].ToString().Remove(10,9), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
					e.Graphics.DrawString(dataSet11.Tables["t_devis_entete"].Rows[countRow]["Code materiel"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+450, ypos);
					e.Graphics.DrawString(dataSet11.Tables["t_devis_entete"].Rows[countRow]["Type machine"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+550, ypos);
				
					ypos+=15;
				}
				countRow+=1;
			}
			ypos+=20;
			e.Graphics.DrawString(DateTime.Now.ToLongDateString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom-50);
			e.Graphics.DrawString("Page "+Page.ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-50, e.MarginBounds.Bottom-50);
			if(countRow<dataSet11.Tables["t_devis_entete"].Rows.Count)
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
			printDocument1.DefaultPageSettings.Landscape=false;
			printDocument1.DefaultPageSettings.Margins.Bottom=50;
			printPreviewDialog1.SetBounds(0,0,800,600);
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select t_clients.[Nom],t_devis_entete.[N° Devis], t_devis_entete.[Date],t_devis_entete.[Code materiel],t_parc_machine.[Type machine] from t_devis_entete,t_clients,t_parc_machine where t_parc_machine.[code machine opindus]=t_devis_entete.[Code materiel] and t_clients.ident=t_devis_entete.[Code client] and t_devis_entete.[Niveau]=3 order by 1,3,2";
			oleDbDataAdapter1.SelectCommand=Comm;
			oleDbDataAdapter1.Fill(dataSet11);
			printPreviewDialog1.Document=printDocument1;
			printPreviewDialog1.ShowDialog();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			printDocument1.DefaultPageSettings.Landscape=false;
			printDocument1.DefaultPageSettings.Margins.Bottom=50;
			printPreviewDialog1.SetBounds(0,0,800,600);
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select t_clients.[Nom],t_devis_entete.[N° Devis], t_devis_entete.[Date],t_devis_entete.[Code materiel],t_parc_machine.[Type machine] from t_devis_entete,t_clients,t_parc_machine where t_parc_machine.[code machine opindus]=t_devis_entete.[Code materiel] and t_clients.ident=t_devis_entete.[Code client] and t_devis_entete.[Niveau]=3 order by 1,3,2";
			oleDbDataAdapter1.SelectCommand=Comm;
			oleDbDataAdapter1.Fill(dataSet11);
			printDocument1.Print();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
