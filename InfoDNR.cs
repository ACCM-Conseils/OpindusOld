using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Opindus
{
	/// <summary>
	/// Description résumée de InfoDNR.
	/// </summary>
	public class InfoDNR : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private int Page;
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
		private int Agence;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InfoDNR(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
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

			//
			// TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(InfoDNR));
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
			this.button2.BackColor = System.Drawing.Color.Lavender;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(120, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Imprimer";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lavender;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(8, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 3;
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
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=ReadWrite;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_type_machine", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																						  new System.Data.Common.DataColumnMapping("Code famille", "Code famille"),
																																																						  new System.Data.Common.DataColumnMapping("Date creation", "Date creation"),
																																																						  new System.Data.Common.DataColumnMapping("Date MAJ controle", "Date MAJ controle"),
																																																						  new System.Data.Common.DataColumnMapping("Date MAJ DNR", "Date MAJ DNR"),
																																																						  new System.Data.Common.DataColumnMapping("Date MAJ Transport", "Date MAJ Transport"),
																																																						  new System.Data.Common.DataColumnMapping("Delai garantie", "Delai garantie"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait controle", "Forfait controle"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait DNR", "Forfait DNR"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait Transport", "Forfait Transport"),
																																																						  new System.Data.Common.DataColumnMapping("Fournisseur", "Fournisseur"),
																																																						  new System.Data.Common.DataColumnMapping("Maxi machine", "Maxi machine"),
																																																						  new System.Data.Common.DataColumnMapping("Mini machine", "Mini machine"),
																																																						  new System.Data.Common.DataColumnMapping("Mise a jour tarif", "Mise a jour tarif"),
																																																						  new System.Data.Common.DataColumnMapping("Nombre reparations", "Nombre reparations"),
																																																						  new System.Data.Common.DataColumnMapping("Prix catalogue", "Prix catalogue"),
																																																						  new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM T_type_machine WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO T_type_machine(Code, [Code famille], [Date creation], [Date MAJ controle], [Date MAJ DNR], [Date MAJ Transport], [Delai garantie], [Forfait controle], [Forfait DNR], [Forfait Transport], Fournisseur, [Maxi machine], [Mini machine], [Mise a jour tarif], [Nombre reparations], [Prix catalogue], Vitesse) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT Code, [Code famille], [Date creation], [Date MAJ controle], [Date MAJ DNR], [Date MAJ Transport], [Delai garantie], [Forfait controle], [Forfait DNR], [Forfait Transport], Fournisseur, [Maxi machine], [Mini machine], [Mise a jour tarif], [Nombre reparations], [Prix catalogue], Vitesse FROM T_type_machine";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE T_type_machine SET Code = ?, [Code famille] = ?, [Date creation] = ?, [Date MAJ controle] = ?, [Date MAJ DNR] = ?, [Date MAJ Transport] = ?, [Delai garantie] = ?, [Forfait controle] = ?, [Forfait DNR] = ?, [Forfait Transport] = ?, Fournisseur = ?, [Maxi machine] = ?, [Mini machine] = ?, [Mise a jour tarif] = ?, [Nombre reparations] = ?, [Prix catalogue] = ?, Vitesse = ? WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
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
			// InfoDNR
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(292, 56);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "InfoDNR";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Informations DNR";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{
			Page=0;
			countRow=0;
			oleDbConnection1.Open();
			OleDbCommand Comm = new OleDbCommand();
			Comm.CommandText="select T_type_machine.[Code],t_fournisseurs.[nom],T_type_machine.[Forfait DNR],T_type_machine.[Date MAJ DNR] from t_type_machine,t_fournisseurs where t_type_machine.[fournisseur]=t_fournisseurs.[Code] order by 2,1 ASC";
			Comm.Connection=oleDbConnection1;
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			oleDbConnection1.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			printDocument1.DefaultPageSettings.Landscape=false;
			printDocument1.DefaultPageSettings.Margins.Bottom=50;
			printPreviewDialog1.SetBounds(0,0,800,600);
			printPreviewDialog1.Document=printDocument1;
			printPreviewDialog1.ShowDialog();
			countRow=0;
			Page=0;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			printDocument1.DefaultPageSettings.Landscape=false;
			printDocument1.DefaultPageSettings.Margins.Bottom=50;
			printDocument1.Print();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Page+=1;
			int ypos=e.MarginBounds.Top+50;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,e.MarginBounds.Top), new Point(e.MarginBounds.Right,e.MarginBounds.Top));
			e.Graphics.DrawString("Fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, e.MarginBounds.Top+5);
			e.Graphics.DrawString("Code", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+150, e.MarginBounds.Top+5);
			e.Graphics.DrawString("Forfait DNR", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+335, e.MarginBounds.Top+5);
			e.Graphics.DrawString("Date MAJ DNR", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+535, e.MarginBounds.Top+5);
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,e.MarginBounds.Top+25), new Point(e.MarginBounds.Right,e.MarginBounds.Top+25));
			ypos+=5;
			string ancienfourn=null;
			bool debut=true;
			while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_type_machine"].Rows.Count)
			{
				try
				{
					if(debut)
						debut=false;
					else
					{
						ancienfourn=dataSet11.Tables["t_type_machine"].Rows[countRow-1]["Nom"].ToString();
					}
					if(ancienfourn!=dataSet11.Tables["t_type_machine"].Rows[countRow]["Nom"].ToString())
					{
						ypos+=10;
						e.Graphics.DrawLine(new Pen(Color.Red, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=5;
						e.Graphics.DrawString(dataSet11.Tables["t_type_machine"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos); 
					}
					e.Graphics.DrawString(dataSet11.Tables["t_type_machine"].Rows[countRow]["Code"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos);
					if(dataSet11.Tables["t_type_machine"].Rows[countRow]["Forfait DNR"].ToString().Length>0)
					{
						e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_type_machine"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
					}
					else
					{
						e.Graphics.DrawString("0.00", 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
					}
					if(dataSet11.Tables["t_type_machine"].Rows[countRow]["Date MAJ DNR"].ToString().Length>0)
					{
						e.Graphics.DrawString(dataSet11.Tables["t_type_machine"].Rows[countRow]["Date MAJ DNR"].ToString().Remove(10,9), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+550, ypos);
					}
					ypos+=15;
					countRow+=1;
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
					MessageBox.Show(countRow.ToString());
				}
			}
			ypos+=20;
			e.Graphics.DrawString(DateTime.Now.ToLongDateString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Page "+Page.ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-50, ypos);
			if(countRow<dataSet11.Tables["t_type_machine"].Rows.Count)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				Page=0;
				countRow=0;
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
