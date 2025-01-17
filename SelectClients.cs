using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Opindus
{
	/// <summary>
	/// Description résumée de SelectClients.
	/// </summary>
	public class SelectClients : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button button1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private DataRow rowSelect;
		private System.Windows.Forms.TextBox textBox1;
		private int SelectedText;
		private System.Windows.Forms.Button button3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private int Agence;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SelectClients(int Agence)
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

		private void InitializeData()
		{
			oleDbConnection1.Open();
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			DataTable Table = dataSet11.Tables["T_clients"];
			foreach (DataRow row in Table.Rows)
			{
				listView1.Items.Add(row["Ident"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Nom"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Code_Postal"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Ville"].ToString());
			}
			oleDbConnection1.Close();
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SelectClients));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.MintCream;
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader3,
																						this.columnHeader4});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(8, 8);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(528, 224);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Client N°";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nom du client";
			this.columnHeader2.Width = 180;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "CP";
			this.columnHeader3.Width = 50;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ville";
			this.columnHeader4.Width = 235;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(192, 248);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "Confirmer";
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
																										new System.Data.Common.DataTableMapping("Table", "T_clients", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Adresse_1", "Adresse_1"),
																																																					 new System.Data.Common.DataColumnMapping("Adresse_2", "Adresse_2"),
																																																					 new System.Data.Common.DataColumnMapping("Batiment", "Batiment"),
																																																					 new System.Data.Common.DataColumnMapping("Borne Date Refus reforme", "Borne Date Refus reforme"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee", "CA_Annee"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee_1", "CA_Annee_1"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee_2", "CA_Annee_2"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee_3", "CA_Annee_3"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee_4", "CA_Annee_4"),
																																																					 new System.Data.Common.DataColumnMapping("code_GC", "code_GC"),
																																																					 new System.Data.Common.DataColumnMapping("Code_Postal", "Code_Postal"),
																																																					 new System.Data.Common.DataColumnMapping("Code_reglement", "Code_reglement"),
																																																					 new System.Data.Common.DataColumnMapping("Code_transport", "Code_transport"),
																																																					 new System.Data.Common.DataColumnMapping("Coef_Controle", "Coef_Controle"),
																																																					 new System.Data.Common.DataColumnMapping("Coef_DNR", "Coef_DNR"),
																																																					 new System.Data.Common.DataColumnMapping("Coef_transport", "Coef_transport"),
																																																					 new System.Data.Common.DataColumnMapping("Commentaire", "Commentaire"),
																																																					 new System.Data.Common.DataColumnMapping("Delai_garantie", "Delai_garantie"),
																																																					 new System.Data.Common.DataColumnMapping("Forfait_Controle", "Forfait_Controle"),
																																																					 new System.Data.Common.DataColumnMapping("Forfait_DNR", "Forfait_DNR"),
																																																					 new System.Data.Common.DataColumnMapping("Forfait_transport", "Forfait_transport"),
																																																					 new System.Data.Common.DataColumnMapping("Groupe", "Groupe"),
																																																					 new System.Data.Common.DataColumnMapping("Ident", "Ident"),
																																																					 new System.Data.Common.DataColumnMapping("N°_Cde_Ouverte", "N°_Cde_Ouverte"),
																																																					 new System.Data.Common.DataColumnMapping("N°_Client_facture", "N°_Client_facture"),
																																																					 new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee", "Nombre_rep_Annee"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee_1", "Nombre_rep_Annee_1"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee_2", "Nombre_rep_Annee_2"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee_3", "Nombre_rep_Annee_3"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee_4", "Nombre_rep_Annee_4"),
																																																					 new System.Data.Common.DataColumnMapping("Notre_Code_Fournisseur", "Notre_Code_Fournisseur"),
																																																					 new System.Data.Common.DataColumnMapping("Pays", "Pays"),
																																																					 new System.Data.Common.DataColumnMapping("Pourcentage_remise", "Pourcentage_remise"),
																																																					 new System.Data.Common.DataColumnMapping("Seuil_reparation", "Seuil_reparation"),
																																																					 new System.Data.Common.DataColumnMapping("telecopie", "telecopie"),
																																																					 new System.Data.Common.DataColumnMapping("Telephone", "Telephone"),
																																																					 new System.Data.Common.DataColumnMapping("telex", "telex"),
																																																					 new System.Data.Common.DataColumnMapping("Usine", "Usine"),
																																																					 new System.Data.Common.DataColumnMapping("Ville", "Ville")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_clients WHERE (Ident = ?) AND (Adresse_1 = ? OR ? IS NULL AND Adres" +
				"se_1 IS NULL) AND (Adresse_2 = ? OR ? IS NULL AND Adresse_2 IS NULL) AND (Batime" +
				"nt = ? OR ? IS NULL AND Batiment IS NULL) AND ([Borne Date Refus reforme] = ? OR" +
				" ? IS NULL AND [Borne Date Refus reforme] IS NULL) AND (CA_Annee = ? OR ? IS NUL" +
				"L AND CA_Annee IS NULL) AND (CA_Annee_1 = ? OR ? IS NULL AND CA_Annee_1 IS NULL)" +
				" AND (CA_Annee_2 = ? OR ? IS NULL AND CA_Annee_2 IS NULL) AND (CA_Annee_3 = ? OR" +
				" ? IS NULL AND CA_Annee_3 IS NULL) AND (CA_Annee_4 = ? OR ? IS NULL AND CA_Annee" +
				"_4 IS NULL) AND (Code_Postal = ? OR ? IS NULL AND Code_Postal IS NULL) AND (Code" +
				"_reglement = ? OR ? IS NULL AND Code_reglement IS NULL) AND (Code_transport = ? " +
				"OR ? IS NULL AND Code_transport IS NULL) AND (Coef_Controle = ? OR ? IS NULL AND" +
				" Coef_Controle IS NULL) AND (Coef_DNR = ? OR ? IS NULL AND Coef_DNR IS NULL) AND" +
				" (Coef_transport = ? OR ? IS NULL AND Coef_transport IS NULL) AND (Delai_garanti" +
				"e = ? OR ? IS NULL AND Delai_garantie IS NULL) AND (Forfait_Controle = ? OR ? IS" +
				" NULL AND Forfait_Controle IS NULL) AND (Forfait_DNR = ? OR ? IS NULL AND Forfai" +
				"t_DNR IS NULL) AND (Forfait_transport = ? OR ? IS NULL AND Forfait_transport IS " +
				"NULL) AND (Groupe = ? OR ? IS NULL AND Groupe IS NULL) AND (Nom = ? OR ? IS NULL" +
				" AND Nom IS NULL) AND (Nombre_rep_Annee = ? OR ? IS NULL AND Nombre_rep_Annee IS" +
				" NULL) AND (Nombre_rep_Annee_1 = ? OR ? IS NULL AND Nombre_rep_Annee_1 IS NULL) " +
				"AND (Nombre_rep_Annee_2 = ? OR ? IS NULL AND Nombre_rep_Annee_2 IS NULL) AND (No" +
				"mbre_rep_Annee_3 = ? OR ? IS NULL AND Nombre_rep_Annee_3 IS NULL) AND (Nombre_re" +
				"p_Annee_4 = ? OR ? IS NULL AND Nombre_rep_Annee_4 IS NULL) AND (Notre_Code_Fourn" +
				"isseur = ? OR ? IS NULL AND Notre_Code_Fournisseur IS NULL) AND ([N°_Cde_Ouverte" +
				"] = ? OR ? IS NULL AND [N°_Cde_Ouverte] IS NULL) AND ([N°_Client_facture] = ? OR" +
				" ? IS NULL AND [N°_Client_facture] IS NULL) AND (Pays = ? OR ? IS NULL AND Pays " +
				"IS NULL) AND (Pourcentage_remise = ? OR ? IS NULL AND Pourcentage_remise IS NULL" +
				") AND (Seuil_reparation = ? OR ? IS NULL AND Seuil_reparation IS NULL) AND (Tele" +
				"phone = ? OR ? IS NULL AND Telephone IS NULL) AND (Usine = ? OR ? IS NULL AND Us" +
				"ine IS NULL) AND (Ville = ? OR ? IS NULL AND Ville IS NULL) AND (code_GC = ? OR " +
				"? IS NULL AND code_GC IS NULL) AND (telecopie = ? OR ? IS NULL AND telecopie IS " +
				"NULL) AND (telex = ? OR ? IS NULL AND telex IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture1", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO T_clients(Adresse_1, Adresse_2, Batiment, [Borne Date Refus reforme], CA_Annee, CA_Annee_1, CA_Annee_2, CA_Annee_3, CA_Annee_4, code_GC, Code_Postal, Code_reglement, Code_transport, Coef_Controle, Coef_DNR, Coef_transport, Commentaire, Delai_garantie, Forfait_Controle, Forfait_DNR, Forfait_transport, Groupe, Ident, [N°_Cde_Ouverte], [N°_Client_facture], Nom, Nombre_rep_Annee, Nombre_rep_Annee_1, Nombre_rep_Annee_2, Nombre_rep_Annee_3, Nombre_rep_Annee_4, Notre_Code_Fournisseur, Pays, Pourcentage_remise, Seuil_reparation, telecopie, Telephone, telex, Usine, Ville) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_2"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Borne Date Refus reforme"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_1"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_2"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_3"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_4"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, "code_GC"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_reglement"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, "Coef_Controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, "Coef_DNR"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_transport", System.Data.OleDb.OleDbType.Double, 0, "Coef_transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai_garantie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait_Controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait_DNR"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait_transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, "N°_Cde_Ouverte"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, "N°_Client_facture"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_1"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_2"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_3"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_4"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, "Notre_Code_Fournisseur"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage_remise"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, "Seuil_reparation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("telex", System.Data.OleDb.OleDbType.VarWChar, 255, "telex"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT Adresse_1, Adresse_2, Batiment, [Borne Date Refus reforme], CA_Annee, CA_Annee_1, CA_Annee_2, CA_Annee_3, CA_Annee_4, code_GC, Code_Postal, Code_reglement, Code_transport, Coef_Controle, Coef_DNR, Coef_transport, Commentaire, Delai_garantie, Forfait_Controle, Forfait_DNR, Forfait_transport, Groupe, Ident, [N°_Cde_Ouverte], [N°_Client_facture], Nom, Nombre_rep_Annee, Nombre_rep_Annee_1, Nombre_rep_Annee_2, Nombre_rep_Annee_3, Nombre_rep_Annee_4, Notre_Code_Fournisseur, Pays, Pourcentage_remise, Seuil_reparation, telecopie, Telephone, telex, Usine, Ville FROM T_clients ORDER BY Nom";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_clients SET Adresse_1 = ?, Adresse_2 = ?, Batiment = ?, [Borne Date Refu" +
				"s reforme] = ?, CA_Annee = ?, CA_Annee_1 = ?, CA_Annee_2 = ?, CA_Annee_3 = ?, CA" +
				"_Annee_4 = ?, code_GC = ?, Code_Postal = ?, Code_reglement = ?, Code_transport =" +
				" ?, Coef_Controle = ?, Coef_DNR = ?, Coef_transport = ?, Commentaire = ?, Delai_" +
				"garantie = ?, Forfait_Controle = ?, Forfait_DNR = ?, Forfait_transport = ?, Grou" +
				"pe = ?, Ident = ?, [N°_Cde_Ouverte] = ?, [N°_Client_facture] = ?, Nom = ?, Nombr" +
				"e_rep_Annee = ?, Nombre_rep_Annee_1 = ?, Nombre_rep_Annee_2 = ?, Nombre_rep_Anne" +
				"e_3 = ?, Nombre_rep_Annee_4 = ?, Notre_Code_Fournisseur = ?, Pays = ?, Pourcenta" +
				"ge_remise = ?, Seuil_reparation = ?, telecopie = ?, Telephone = ?, telex = ?, Us" +
				"ine = ?, Ville = ? WHERE (Ident = ?) AND (Adresse_1 = ? OR ? IS NULL AND Adresse" +
				"_1 IS NULL) AND (Adresse_2 = ? OR ? IS NULL AND Adresse_2 IS NULL) AND (Batiment" +
				" = ? OR ? IS NULL AND Batiment IS NULL) AND ([Borne Date Refus reforme] = ? OR ?" +
				" IS NULL AND [Borne Date Refus reforme] IS NULL) AND (CA_Annee = ? OR ? IS NULL " +
				"AND CA_Annee IS NULL) AND (CA_Annee_1 = ? OR ? IS NULL AND CA_Annee_1 IS NULL) A" +
				"ND (CA_Annee_2 = ? OR ? IS NULL AND CA_Annee_2 IS NULL) AND (CA_Annee_3 = ? OR ?" +
				" IS NULL AND CA_Annee_3 IS NULL) AND (CA_Annee_4 = ? OR ? IS NULL AND CA_Annee_4" +
				" IS NULL) AND (Code_Postal = ? OR ? IS NULL AND Code_Postal IS NULL) AND (Code_r" +
				"eglement = ? OR ? IS NULL AND Code_reglement IS NULL) AND (Code_transport = ? OR" +
				" ? IS NULL AND Code_transport IS NULL) AND (Coef_Controle = ? OR ? IS NULL AND C" +
				"oef_Controle IS NULL) AND (Coef_DNR = ? OR ? IS NULL AND Coef_DNR IS NULL) AND (" +
				"Coef_transport = ? OR ? IS NULL AND Coef_transport IS NULL) AND (Delai_garantie " +
				"= ? OR ? IS NULL AND Delai_garantie IS NULL) AND (Forfait_Controle = ? OR ? IS N" +
				"ULL AND Forfait_Controle IS NULL) AND (Forfait_DNR = ? OR ? IS NULL AND Forfait_" +
				"DNR IS NULL) AND (Forfait_transport = ? OR ? IS NULL AND Forfait_transport IS NU" +
				"LL) AND (Groupe = ? OR ? IS NULL AND Groupe IS NULL) AND (Nom = ? OR ? IS NULL A" +
				"ND Nom IS NULL) AND (Nombre_rep_Annee = ? OR ? IS NULL AND Nombre_rep_Annee IS N" +
				"ULL) AND (Nombre_rep_Annee_1 = ? OR ? IS NULL AND Nombre_rep_Annee_1 IS NULL) AN" +
				"D (Nombre_rep_Annee_2 = ? OR ? IS NULL AND Nombre_rep_Annee_2 IS NULL) AND (Nomb" +
				"re_rep_Annee_3 = ? OR ? IS NULL AND Nombre_rep_Annee_3 IS NULL) AND (Nombre_rep_" +
				"Annee_4 = ? OR ? IS NULL AND Nombre_rep_Annee_4 IS NULL) AND (Notre_Code_Fournis" +
				"seur = ? OR ? IS NULL AND Notre_Code_Fournisseur IS NULL) AND ([N°_Cde_Ouverte] " +
				"= ? OR ? IS NULL AND [N°_Cde_Ouverte] IS NULL) AND ([N°_Client_facture] = ? OR ?" +
				" IS NULL AND [N°_Client_facture] IS NULL) AND (Pays = ? OR ? IS NULL AND Pays IS" +
				" NULL) AND (Pourcentage_remise = ? OR ? IS NULL AND Pourcentage_remise IS NULL) " +
				"AND (Seuil_reparation = ? OR ? IS NULL AND Seuil_reparation IS NULL) AND (Teleph" +
				"one = ? OR ? IS NULL AND Telephone IS NULL) AND (Usine = ? OR ? IS NULL AND Usin" +
				"e IS NULL) AND (Ville = ? OR ? IS NULL AND Ville IS NULL) AND (code_GC = ? OR ? " +
				"IS NULL AND code_GC IS NULL) AND (telecopie = ? OR ? IS NULL AND telecopie IS NU" +
				"LL) AND (telex = ? OR ? IS NULL AND telex IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_2"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Borne Date Refus reforme"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_1"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_2"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_3"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_4"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, "code_GC"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_reglement"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, "Coef_Controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, "Coef_DNR"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_transport", System.Data.OleDb.OleDbType.Double, 0, "Coef_transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai_garantie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait_Controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait_DNR"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait_transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, "N°_Cde_Ouverte"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, "N°_Client_facture"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_1"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_2"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_3"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_4"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, "Notre_Code_Fournisseur"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage_remise"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, "Seuil_reparation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("telex", System.Data.OleDb.OleDbType.VarWChar, 255, "telex"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture1", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LightYellow;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(8, 248);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(168, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(280, 248);
			this.button3.Name = "button3";
			this.button3.TabIndex = 3;
			this.button3.Text = "Nouveau";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(488, 240);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 17;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// SelectClients
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(542, 296);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "SelectClients";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Selection des clients";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		public DataRow GetRow()
		{
			return rowSelect;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DataTable Table = dataSet11.Tables["T_clients"];
			foreach (DataRow row in Table.Rows)
			{
				if(listView1.SelectedIndices.Count==0)
				{
					if((row["Ident"].ToString().Equals(listView1.Items[SelectedText].Text)))
					{
						rowSelect=row;
					}
				}
				else
				{
					if((row["Ident"].ToString().Equals(listView1.Items[listView1.SelectedIndices[0]].Text)))
					{
						rowSelect=row;
					}
				}	
			} 
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			for(int i=0;i<listView1.Items.Count;i++)
			{
				int LongeurMotListe=listView1.Items[i].SubItems[1].Text.Length;
				int LongeurMotRecherche=textBox1.Text.Length;
				int reste=LongeurMotListe-LongeurMotRecherche;
				string MotCoupe=null;
				if(LongeurMotRecherche>=LongeurMotListe)
					MotCoupe=listView1.Items[i].SubItems[1].Text;
				else
					MotCoupe= listView1.Items[i].SubItems[1].Text.Remove(LongeurMotRecherche, reste);
				listView1.Items[i].ForeColor=Color.Black;
				if(MotCoupe.Equals(textBox1.Text.ToUpper())&&textBox1.Text.Length>0)
				{
					listView1.Items[i].EnsureVisible();
					listView1.Items[i].ForeColor=Color.Red;
					SelectedText=i;
				}
			}
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e)
		{
			dataSet11.Clear();
			oleDbDataAdapter1.Fill(dataSet11);
			DataTable Table = dataSet11.Tables["T_clients"];
			foreach (DataRow row in Table.Rows)
			{
				if(listView1.SelectedIndices.Count==0)
				{
					if((row["Ident"].ToString().Equals(listView1.Items[SelectedText].Text)))
					{
						rowSelect=row;
					}
				}
				else
				{
					if((row["Ident"].ToString().Equals(listView1.Items[listView1.SelectedIndices[0]].Text)))
					{
						rowSelect=row;
					}
				}

				
			}
			DialogResult=DialogResult.OK;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Clients WinClients = new Clients(Agence,true);
			WinClients.ShowDialog();
			listView1.Items.Clear();
			DataSet ds = new DataSet();
			oleDbDataAdapter1.Fill(ds);
			DataTable Table = ds.Tables["T_clients"];
			foreach (DataRow row in Table.Rows)
			{
				listView1.Items.Add(row["Ident"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Nom"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Code_Postal"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Ville"].ToString());
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
}
}
