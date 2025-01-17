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
	/// Description résumée de EditionCommandes.
	/// </summary>
	public class EditionCommandes : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.Label label1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private int Agence;
		private System.Drawing.Printing.PrintDocument printDocument1;
		int Page;
		int countRow;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private OleDbTransaction Transac;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EditionCommandes(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
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

			oleDbSelectCommand1.CommandText="SELECT T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], T_fournisseurs.Nom, T_CDE_entete.Edite FROM T_fournisseurs INNER JOIN T_CDE_entete ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur] WHERE (((T_CDE_entete.Edite)=False)) ORDER BY [n° Commande]";
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{

			}
			foreach(DataRow row in dataSet11.Tables["t_cde_entete"].Rows)
			{
				listView1.Items.Add(row["N° commande"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Date commande"].ToString().Remove(10,9));
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["nom"].ToString());
			}
			try
			{
				oleDbDataAdapter3.Fill(dataSet11);
			}
			catch(Exception exp)
			{

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EditionCommandes));
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.button2 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dataSet11 = new Opindus.DataSet1();
			this.label1 = new System.Windows.Forms.Label();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.listView1 = new System.Windows.Forms.ListView();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Fournisseur";
			this.columnHeader3.Width = 460;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(216, 388);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Imprimer";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(152, 388);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
			this.numericUpDown1.TabIndex = 8;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 2,
																		 0,
																		 0,
																		 0});
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 388);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Nombre d\'impressions";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_CDE_entete", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("Code fournisseur", "Code fournisseur"),
																																																						new System.Data.Common.DataColumnMapping("Comment", "Comment"),
																																																						new System.Data.Common.DataColumnMapping("Date Commande", "Date Commande"),
																																																						new System.Data.Common.DataColumnMapping("Date livraison", "Date livraison"),
																																																						new System.Data.Common.DataColumnMapping("Edite", "Edite"),
																																																						new System.Data.Common.DataColumnMapping("Montant remise", "Montant remise"),
																																																						new System.Data.Common.DataColumnMapping("N° Commande", "N° Commande"),
																																																						new System.Data.Common.DataColumnMapping("Remise fournisseur", "Remise fournisseur"),
																																																						new System.Data.Common.DataColumnMapping("Signature", "Signature"),
																																																						new System.Data.Common.DataColumnMapping("Solde", "Solde"),
																																																						new System.Data.Common.DataColumnMapping("Total commande", "Total commande"),
																																																						new System.Data.Common.DataColumnMapping("Total net Commande", "Total net Commande"),
																																																						new System.Data.Common.DataColumnMapping("Total net Commande euros", "Total net Commande euros"),
																																																						new System.Data.Common.DataColumnMapping("total pieces commandees", "total pieces commandees"),
																																																						new System.Data.Common.DataColumnMapping("Total pieces recues", "Total pieces recues"),
																																																						new System.Data.Common.DataColumnMapping("Valide", "Valide")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM T_CDE_entete WHERE ([N° Commande] = ?) AND ([Code fournisseur] = ? OR ? IS NULL AND [Code fournisseur] IS NULL) AND ([Date Commande] = ? OR ? IS NULL AND [Date Commande] IS NULL) AND ([Date livraison] = ? OR ? IS NULL AND [Date livraison] IS NULL) AND (Edite = ?) AND ([Montant remise] = ? OR ? IS NULL AND [Montant remise] IS NULL) AND ([Remise fournisseur] = ? OR ? IS NULL AND [Remise fournisseur] IS NULL) AND (Signature = ? OR ? IS NULL AND Signature IS NULL) AND (Solde = ?) AND ([Total commande] = ? OR ? IS NULL AND [Total commande] IS NULL) AND ([Total net Commande] = ? OR ? IS NULL AND [Total net Commande] IS NULL) AND ([Total net Commande euros] = ? OR ? IS NULL AND [Total net Commande euros] IS NULL) AND ([Total pieces recues] = ? OR ? IS NULL AND [Total pieces recues] IS NULL) AND (Valide = ?) AND ([total pieces commandees] = ? OR ? IS NULL AND [total pieces commandees] IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Montant_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Montant remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Montant_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Montant remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Remise_fournisseur", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Remise fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Remise_fournisseur1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Remise fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Signature", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signature", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Signature1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signature", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Solde", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Solde", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande_euros", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande euros", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande_euros1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande euros", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces_recues", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces recues", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces_recues1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces recues", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_total_pieces_commandees", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "total pieces commandees", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_total_pieces_commandees1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "total pieces commandees", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO T_CDE_entete([Code fournisseur], Comment, [Date Commande], [Date livraison], Edite, [Montant remise], [N° Commande], [Remise fournisseur], Signature, Solde, [Total commande], [Total net Commande], [Total net Commande euros], [total pieces commandees], [Total pieces recues], Valide) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Code fournisseur"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Commande"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, "Date livraison"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Montant_remise", System.Data.OleDb.OleDbType.Double, 0, "Montant remise"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Remise_fournisseur", System.Data.OleDb.OleDbType.Double, 0, "Remise fournisseur"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Signature", System.Data.OleDb.OleDbType.VarWChar, 255, "Signature"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Solde", System.Data.OleDb.OleDbType.Boolean, 2, "Solde"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_commande", System.Data.OleDb.OleDbType.Double, 0, "Total commande"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_net_Commande", System.Data.OleDb.OleDbType.Double, 0, "Total net Commande"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_net_Commande_euros", System.Data.OleDb.OleDbType.Double, 0, "Total net Commande euros"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("total_pieces_commandees", System.Data.OleDb.OleDbType.Double, 0, "total pieces commandees"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces_recues", System.Data.OleDb.OleDbType.Double, 0, "Total pieces recues"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT [Code fournisseur], Comment, [Date Commande], [Date livraison], Edite, [Montant remise], [N° Commande], [Remise fournisseur], Signature, Solde, [Total commande], [Total net Commande], [Total net Commande euros], [total pieces commandees], [Total pieces recues], Valide FROM T_CDE_entete WHERE (Edite = false)";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE T_CDE_entete SET [Code fournisseur] = ?, Comment = ?, [Date Commande] = ?, [Date livraison] = ?, Edite = ?, [Montant remise] = ?, [N° Commande] = ?, [Remise fournisseur] = ?, Signature = ?, Solde = ?, [Total commande] = ?, [Total net Commande] = ?, [Total net Commande euros] = ?, [total pieces commandees] = ?, [Total pieces recues] = ?, Valide = ? WHERE ([N° Commande] = ?) AND ([Code fournisseur] = ? OR ? IS NULL AND [Code fournisseur] IS NULL) AND ([Date Commande] = ? OR ? IS NULL AND [Date Commande] IS NULL) AND ([Date livraison] = ? OR ? IS NULL AND [Date livraison] IS NULL) AND (Edite = ?) AND ([Montant remise] = ? OR ? IS NULL AND [Montant remise] IS NULL) AND ([Remise fournisseur] = ? OR ? IS NULL AND [Remise fournisseur] IS NULL) AND (Signature = ? OR ? IS NULL AND Signature IS NULL) AND (Solde = ?) AND ([Total commande] = ? OR ? IS NULL AND [Total commande] IS NULL) AND ([Total net Commande] = ? OR ? IS NULL AND [Total net Commande] IS NULL) AND ([Total net Commande euros] = ? OR ? IS NULL AND [Total net Commande euros] IS NULL) AND ([Total pieces recues] = ? OR ? IS NULL AND [Total pieces recues] IS NULL) AND (Valide = ?) AND ([total pieces commandees] = ? OR ? IS NULL AND [total pieces commandees] IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Code fournisseur"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Commande"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, "Date livraison"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Montant_remise", System.Data.OleDb.OleDbType.Double, 0, "Montant remise"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Remise_fournisseur", System.Data.OleDb.OleDbType.Double, 0, "Remise fournisseur"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Signature", System.Data.OleDb.OleDbType.VarWChar, 255, "Signature"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Solde", System.Data.OleDb.OleDbType.Boolean, 2, "Solde"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_commande", System.Data.OleDb.OleDbType.Double, 0, "Total commande"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_net_Commande", System.Data.OleDb.OleDbType.Double, 0, "Total net Commande"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_net_Commande_euros", System.Data.OleDb.OleDbType.Double, 0, "Total net Commande euros"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("total_pieces_commandees", System.Data.OleDb.OleDbType.Double, 0, "total pieces commandees"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces_recues", System.Data.OleDb.OleDbType.Double, 0, "Total pieces recues"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Montant_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Montant remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Montant_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Montant remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Remise_fournisseur", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Remise fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Remise_fournisseur1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Remise fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Signature", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signature", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Signature1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signature", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Solde", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Solde", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande_euros", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande euros", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande_euros1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande euros", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces_recues", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces recues", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces_recues1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces recues", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_total_pieces_commandees", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "total pieces commandees", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_total_pieces_commandees1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "total pieces commandees", System.Data.DataRowVersion.Original, null));
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Date";
			this.columnHeader2.Width = 90;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "N° CDE";
			this.columnHeader1.Width = 70;
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
			this.listView1.Location = new System.Drawing.Point(15, 20);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(640, 352);
			this.listView1.TabIndex = 5;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(608, 376);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 17;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// EditionCommandes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(670, 430);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EditionCommandes";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edition groupée des commandes";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e)
		{
			Commande WinCommande = new Commande(Agence);
			WinCommande.ShowDialog();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			for(int i=0;i<listView1.CheckedIndices.Count;i++)
			{
				for(int j=System.Convert.ToInt32(numericUpDown1.Value);j>0;j--)
				{
					dataSet11.Tables["t_cde_entete"].Clear();
					oleDbSelectCommand1.CommandText="SELECT T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], T_CDE_entete.Signature, T_CDE_entete.[Total commande], T_CDE_entete.[Total net Commande], T_CDE_Lignes.Designation, T_CDE_Lignes.[Prix achat], T_CDE_Lignes.[Total ligne], T_CDE_entete.[Montant remise], T_CDE_entete.[Remise fournisseur], T_fournisseurs.Nom, T_fournisseurs.[Adresse 1], T_fournisseurs.[Adresse 2], T_fournisseurs.[Code Postal], T_fournisseurs.Ville, T_fournisseurs.Pays, T_CDE_Lignes.Quantite, T_CDE_Lignes.[Date livraison], T_pieces_detachees.Code, T_CDE_entete.[N° Commande] FROM T_pieces_detachees INNER JOIN ((T_fournisseurs INNER JOIN T_CDE_entete ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur]) INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) ON T_pieces_detachees.Identificateur = T_CDE_Lignes.[Code piece] WHERE (((T_CDE_entete.[N° Commande])="+listView1.Items[listView1.CheckedIndices[i]].Text+"))";
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
					}
			
					Page=0;
					countRow=0;
					printDocument1.Print();
				}
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				OleDbCommand Comm = new OleDbCommand();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="update t_cde_entete set edite=True where [n° commande]="+dataSet11.Tables["t_cde_entete"].Rows[0]["n° commande"].ToString();
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(Exception excp)
					{
						try
						{
							Transac.Rollback();
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
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
			Dispose();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			
			Page+=1;
			int ypos=e.MarginBounds.Top+120;
			e.Graphics.DrawString("Facturation", new Font("Arial", 8, FontStyle.Underline|FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Le : "+DateTime.Now.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-70, ypos);
			ypos+=15;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["f_adresse1"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["f_cp"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["f_ville"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=15;
			e.Graphics.DrawString("T. "+dataSet11.Tables["parametres"].Rows[0]["f_tel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("F. "+dataSet11.Tables["parametres"].Rows[0]["f_fax"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+110, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["adresse 1"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=15;
			e.Graphics.DrawString("Livraison", new Font("Arial", 8, FontStyle.Underline|FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["adresse 2"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=15;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["l_adresse1"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["code postal"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["ville"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+180, ypos);
			ypos+=15;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["l_cp"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["l_ville"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["pays"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=40;
			e.Graphics.DrawString("Commande N° "+dataSet11.Tables["t_cde_entete"].Rows[0]["n° commande"].ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
			ypos+=25;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=2;
			e.Graphics.DrawString("Code", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Designation", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
			e.Graphics.DrawString("Quantité", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+280, ypos);
			e.Graphics.DrawString("Prix unitaire", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+380, ypos);
			e.Graphics.DrawString("Total ligne", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
			e.Graphics.DrawString("A livrer", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+570, ypos);
			ypos+=20;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=5;
			while(ypos<e.MarginBounds.Height-130&&countRow<dataSet11.Tables["t_cde_entete"].Rows.Count)
			{ 
				e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Code"].ToString(), 
					new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Designation"].ToString(), 
					new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
				e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Quantite"].ToString(), 
					new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
				e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Prix achat"].ToString()).ToString("c"), 
					new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+380, ypos);
				e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Total ligne"].ToString()).ToString("c"), 
					new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
				if(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Date livraison"].ToString().Length>0)
				{
					e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Date livraison"].ToString().Remove(10,9), 
						new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
				}
				ypos+=15;
				countRow+=1;
			}
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,e.MarginBounds.Height-100), new Point(e.MarginBounds.Right,e.MarginBounds.Height-100));
			ypos+=5;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["message_cde"].ToString(), 
				new Font("Arial", 6, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Height-90);
			e.Graphics.DrawString("Total H.T. ", 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-180, e.MarginBounds.Height-70);
			e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[0]["Total commande"].ToString()).ToString("c"), 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-40, e.MarginBounds.Height-70);
			e.Graphics.DrawString("Remise "+(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[0]["Remise fournisseur"].ToString())*100).ToString("0.00")+"%", 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-180, e.MarginBounds.Height-50);
			e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[0]["montant remise"].ToString()).ToString("c"), 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-40, e.MarginBounds.Height-50);
			e.Graphics.DrawString("Total net H.T. ", 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-180, e.MarginBounds.Height-30);
			e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[0]["Total net commande"].ToString()).ToString("c"), 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-40, e.MarginBounds.Height-30);
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["signature"].ToString(), 
				new Font("Arial", 6, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Height-10);
			if(countRow<dataSet11.Tables["t_cde_entete"].Rows.Count)
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
