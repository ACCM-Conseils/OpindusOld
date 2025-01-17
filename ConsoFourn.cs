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
	/// Description résumée de ConsoFourn.
	/// </summary>
	public class ConsoFourn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private int Page;
		private int countRow;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.GroupBox groupBox1;
		private MTGCComboBox mtgcComboBox2;
		private MTGCComboBox mtgcComboBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private DataSet ds;
		private OleDbDataAdapter DataAD;
		private OleDbCommand Comm;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private string NomFourn;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ConsoFourn(int Agence)
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
			ds = new DataSet();
			DataAD = new OleDbDataAdapter();
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_fournisseurs"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["Nom"].ToString(), row["Code postal"].ToString(), row["Ville"].ToString(), ""));
			}
			
			mtgcComboBox2.Items.Add(new MTGCComboBoxItem("Tous types machine","","",""));
			mtgcComboBox2.Items.Add(new MTGCComboBoxItem("Pièces","","",""));
			mtgcComboBox2.Items.Add(new MTGCComboBoxItem("Type machine selectionné","","",""));
			Comm.CommandText="SELECT nom FROM t_fournisseurs ORDER BY nom";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"fournisseurs");
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ConsoFourn));
			this.label1 = new System.Windows.Forms.Label();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.button7 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(120, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(448, 32);
			this.label1.TabIndex = 19;
			this.label1.Text = "Consommation pièces fournisseurs";
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
																										new System.Data.Common.DataTableMapping("Table", "T_fournisseurs", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																						  new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																						  new System.Data.Common.DataColumnMapping("Ville", "Ville"),
																																																						  new System.Data.Common.DataColumnMapping("Code Postal", "Code Postal")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_fournisseurs WHERE (Code = ?) AND ([Code Postal] = ? OR ? IS NULL A" +
				"ND [Code Postal] IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Ville " +
				"= ? OR ? IS NULL AND Ville IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_fournisseurs(Code, Nom, Ville, [Code Postal]) VALUES (?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Code, Nom, Ville, [Code Postal] FROM T_fournisseurs ORDER BY Nom";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_fournisseurs SET Code = ?, Nom = ?, Ville = ?, [Code Postal] = ? WHERE (" +
				"Code = ?) AND ([Code Postal] = ? OR ? IS NULL AND [Code Postal] IS NULL) AND (No" +
				"m = ? OR ? IS NULL AND Nom IS NULL) AND (Ville = ? OR ? IS NULL AND Ville IS NUL" +
				"L)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM T_CDE_entete WHERE ([N° Commande] = ?) AND ([Code fournisseur] = ? OR ? IS NULL AND [Code fournisseur] IS NULL) AND ([Date Commande] = ? OR ? IS NULL AND [Date Commande] IS NULL) AND ([Date livraison] = ? OR ? IS NULL AND [Date livraison] IS NULL) AND (Edite = ?) AND ([Montant remise] = ? OR ? IS NULL AND [Montant remise] IS NULL) AND ([Remise fournisseur] = ? OR ? IS NULL AND [Remise fournisseur] IS NULL) AND (Signature = ? OR ? IS NULL AND Signature IS NULL) AND (Solde = ?) AND ([Total commande] = ? OR ? IS NULL AND [Total commande] IS NULL) AND ([Total net Commande] = ? OR ? IS NULL AND [Total net Commande] IS NULL) AND ([Total net Commande euros] = ? OR ? IS NULL AND [Total net Commande euros] IS NULL) AND ([Total pieces recues] = ? OR ? IS NULL AND [Total pieces recues] IS NULL) AND (Valide = ?) AND ([total pieces commandees] = ? OR ? IS NULL AND [total pieces commandees] IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Montant_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Montant remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Montant_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Montant remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Remise_fournisseur", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Remise fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Remise_fournisseur1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Remise fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Signature", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signature", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Signature1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signature", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Solde", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Solde", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande_euros", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande euros", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande_euros1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande euros", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces_recues", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces recues", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces_recues1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces recues", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_total_pieces_commandees", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "total pieces commandees", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_total_pieces_commandees1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "total pieces commandees", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = @"INSERT INTO T_CDE_entete([Code fournisseur], Comment, [Date Commande], [Date livraison], Edite, [Montant remise], [N° Commande], [Remise fournisseur], Signature, Solde, [Total commande], [Total net Commande], [Total net Commande euros], [total pieces commandees], [Total pieces recues], Valide) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Code fournisseur"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Commande"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, "Date livraison"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Montant_remise", System.Data.OleDb.OleDbType.Double, 0, "Montant remise"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Remise_fournisseur", System.Data.OleDb.OleDbType.Double, 0, "Remise fournisseur"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Signature", System.Data.OleDb.OleDbType.VarWChar, 255, "Signature"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Solde", System.Data.OleDb.OleDbType.Boolean, 2, "Solde"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_commande", System.Data.OleDb.OleDbType.Double, 0, "Total commande"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_net_Commande", System.Data.OleDb.OleDbType.Double, 0, "Total net Commande"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_net_Commande_euros", System.Data.OleDb.OleDbType.Double, 0, "Total net Commande euros"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("total_pieces_commandees", System.Data.OleDb.OleDbType.Double, 0, "total pieces commandees"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces_recues", System.Data.OleDb.OleDbType.Double, 0, "Total pieces recues"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = @"SELECT [Code fournisseur], Comment, [Date Commande], [Date livraison], Edite, [Montant remise], [N° Commande], [Remise fournisseur], Signature, Solde, [Total commande], [Total net Commande], [Total net Commande euros], [total pieces commandees], [Total pieces recues], Valide FROM T_CDE_entete";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE T_CDE_entete SET [Code fournisseur] = ?, Comment = ?, [Date Commande] = ?, [Date livraison] = ?, Edite = ?, [Montant remise] = ?, [N° Commande] = ?, [Remise fournisseur] = ?, Signature = ?, Solde = ?, [Total commande] = ?, [Total net Commande] = ?, [Total net Commande euros] = ?, [total pieces commandees] = ?, [Total pieces recues] = ?, Valide = ? WHERE ([N° Commande] = ?) AND ([Code fournisseur] = ? OR ? IS NULL AND [Code fournisseur] IS NULL) AND ([Date Commande] = ? OR ? IS NULL AND [Date Commande] IS NULL) AND ([Date livraison] = ? OR ? IS NULL AND [Date livraison] IS NULL) AND (Edite = ?) AND ([Montant remise] = ? OR ? IS NULL AND [Montant remise] IS NULL) AND ([Remise fournisseur] = ? OR ? IS NULL AND [Remise fournisseur] IS NULL) AND (Signature = ? OR ? IS NULL AND Signature IS NULL) AND (Solde = ?) AND ([Total commande] = ? OR ? IS NULL AND [Total commande] IS NULL) AND ([Total net Commande] = ? OR ? IS NULL AND [Total net Commande] IS NULL) AND ([Total net Commande euros] = ? OR ? IS NULL AND [Total net Commande euros] IS NULL) AND ([Total pieces recues] = ? OR ? IS NULL AND [Total pieces recues] IS NULL) AND (Valide = ?) AND ([total pieces commandees] = ? OR ? IS NULL AND [total pieces commandees] IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Code fournisseur"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Commande"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, "Date livraison"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Montant_remise", System.Data.OleDb.OleDbType.Double, 0, "Montant remise"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Remise_fournisseur", System.Data.OleDb.OleDbType.Double, 0, "Remise fournisseur"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Signature", System.Data.OleDb.OleDbType.VarWChar, 255, "Signature"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Solde", System.Data.OleDb.OleDbType.Boolean, 2, "Solde"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_commande", System.Data.OleDb.OleDbType.Double, 0, "Total commande"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_net_Commande", System.Data.OleDb.OleDbType.Double, 0, "Total net Commande"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_net_Commande_euros", System.Data.OleDb.OleDbType.Double, 0, "Total net Commande euros"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("total_pieces_commandees", System.Data.OleDb.OleDbType.Double, 0, "total pieces commandees"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces_recues", System.Data.OleDb.OleDbType.Double, 0, "Total pieces recues"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Montant_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Montant remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Montant_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Montant remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Remise_fournisseur", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Remise fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Remise_fournisseur1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Remise fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Signature", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signature", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Signature1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Signature", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Solde", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Solde", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande_euros", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande euros", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_net_Commande_euros1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total net Commande euros", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces_recues", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces recues", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces_recues1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces recues", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_total_pieces_commandees", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "total pieces commandees", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_total_pieces_commandees1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "total pieces commandees", System.Data.DataRowVersion.Original, null));
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
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Black;
			this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
			this.button7.Location = new System.Drawing.Point(648, 176);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(48, 48);
			this.button7.TabIndex = 38;
			this.button7.TabStop = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(16, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 45;
			this.label5.Text = "Format de date incorrect";
			this.label5.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(136, 80);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 20);
			this.textBox2.TabIndex = 44;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(16, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 43;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(168, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 42;
			this.label3.Text = "Fin";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 41;
			this.label2.Text = "Début";
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 3;
			this.mtgcComboBox1.ColumnWidth = "200;50;150";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 141;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = true;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(16, 56);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(360, 21);
			this.mtgcComboBox1.TabIndex = 40;
			this.mtgcComboBox1.ValueMember = "Code";
			this.mtgcComboBox1.Visible = false;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Controls.Add(this.mtgcComboBox1);
			this.groupBox2.Location = new System.Drawing.Point(304, 72);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(392, 88);
			this.groupBox2.TabIndex = 39;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Choix de l\'impression";
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(184, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(144, 24);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Totalité synthèse";
			// 
			// radioButton4
			// 
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(72, 24);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 0;
			this.radioButton4.Text = "Fournisseur";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.mtgcComboBox3);
			this.groupBox1.Controls.Add(this.mtgcComboBox2);
			this.groupBox1.Location = new System.Drawing.Point(16, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 104);
			this.groupBox1.TabIndex = 46;
			this.groupBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(248, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Type machine";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(256, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Selection";
			// 
			// mtgcComboBox3
			// 
			this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox3.ColumnNum = 1;
			this.mtgcComboBox3.ColumnWidth = "121";
			this.mtgcComboBox3.DisplayMember = "Text";
			this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox3.DropDownWidth = 141;
			this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox3.GridLineHorizontal = false;
			this.mtgcComboBox3.GridLineVertical = false;
			this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox3.Location = new System.Drawing.Point(8, 72);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(256, 21);
			this.mtgcComboBox3.TabIndex = 1;
			this.mtgcComboBox3.Visible = false;
			// 
			// mtgcComboBox2
			// 
			this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox2.ColumnNum = 1;
			this.mtgcComboBox2.ColumnWidth = "121";
			this.mtgcComboBox2.DisplayMember = "Text";
			this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox2.DropDownWidth = 141;
			this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox2.GridLineHorizontal = false;
			this.mtgcComboBox2.GridLineVertical = false;
			this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox2.Location = new System.Drawing.Point(10, 32);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(254, 21);
			this.mtgcComboBox2.TabIndex = 0;
			this.mtgcComboBox2.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox2_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(320, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 48;
			this.button1.Text = "Visualiser";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(432, 184);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 47;
			this.button3.Text = "Imprimer";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ConsoFourn
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(706, 232);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ConsoFourn";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consommation pièces fournisseurs";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}


		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			Page+=1;
			int ypos=e.MarginBounds.Top;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,e.MarginBounds.Top), new Point(e.MarginBounds.Right,e.MarginBounds.Top));
			ypos+=5;
			if(mtgcComboBox2.SelectedIndex.Equals(0))
			{
				e.Graphics.DrawString("Consommation pièces par type machine pour le founisseur", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString(NomFourn, new Font("Arial", 12, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString("Du "+textBox1.Text+" au "+textBox2.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			}
			else
			{
				e.Graphics.DrawString("Consommation pièces pour le fournisseur", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString(NomFourn, new Font("Arial", 12, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString("Du "+textBox1.Text+" au "+textBox2.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			}
			ypos+=30;
			string AncienFourn=null;
			string AncienType=null;
			bool debut=true;
			int cpt=0;
			if(mtgcComboBox2.SelectedIndex.Equals(0))
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["Select"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						AncienFourn=ds.Tables["Select"].Rows[countRow-1]["Nom"].ToString();
						AncienType=ds.Tables["Select"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(AncienFourn!=ds.Tables["Select"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+200, ypos);
						ypos+=25;
						e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
						e.Graphics.DrawString("Code pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString("Désignation", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
						e.Graphics.DrawString("quantité", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
					}
					if(AncienType!=ds.Tables["Select"].Rows[countRow]["Type machine"].ToString())
					{
						cpt=0;
						Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_entete.[N° Devis] FROM T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_parc_machine.[Type machine])='"+ds.Tables["Select"].Rows[countRow]["Type machine"].ToString()+"')) GROUP BY T_fournisseurs.Nom, T_devis_entete.[N° Devis] HAVING (((T_fournisseurs.Nom)='"+NomFourn.Replace("'","''")+"'))";

						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"Devis");
						}
						catch(Exception ex)
						{
							Console.WriteLine(ex.Message);
						}
						cpt=ds.Tables["devis"].Rows.Count;
						ds.Tables["devis"].Clear();
						e.Graphics.DrawString("Type machine :      "+ds.Tables["Select"].Rows[countRow]["Type machine"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString("Désignation :      "+ds.Tables["Select"].Rows[countRow]["T_famille_machine.Designation"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+200, ypos);
						e.Graphics.DrawString("Nbre devis :      "+cpt.ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Blue, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
						e.Graphics.DrawString("Code pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString("Désignation pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
						e.Graphics.DrawString("quantité", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
					}
					
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Code"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["t_pieces_detachees.Designation"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["SommeDeQuantite"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+530, ypos);
					Decimal Pourcent=System.Convert.ToDecimal(ds.Tables["Select"].Rows[countRow]["SommeDeQuantite"].ToString())/cpt;
					Pourcent=Pourcent*100;
					e.Graphics.DrawString(Pourcent.ToString("0.00")+"%",
						new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+550, ypos);
					ypos+=15;
					countRow+=1;
				}
			}
			else if(mtgcComboBox2.SelectedIndex.Equals(1)||mtgcComboBox2.SelectedIndex.Equals(2))
			{
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
				ypos+=10;
				e.Graphics.DrawString("Code pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString("Désignation", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
				e.Graphics.DrawString("quantité", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
				ypos+=15;
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
				ypos+=10;
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["Select"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						AncienFourn=ds.Tables["Select"].Rows[countRow-1]["Nom"].ToString();
					}
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Code"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Designation"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["SommeDeQuantite"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+530, ypos);
					ypos+=15;
					countRow+=1;
				}
			}
			ypos+=15;
			e.Graphics.DrawString(DateTime.Now.ToLongDateString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Page "+Page.ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-50, ypos);
			if(countRow<ds.Tables["Select"].Rows.Count)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox1.SelectedIndex>0)
			{
				
				groupBox1.Visible=true;
				label4.Visible=true;
				label6.Visible=true;
				mtgcComboBox2.Visible=true;
				button1.Visible=true;
				ds.Clear();
				mtgcComboBox3.Items.Clear();
				if(mtgcComboBox1.SelectedIndex>0)
					Comm.CommandText="SELECT T_type_machine.Code FROM T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_fournisseurs.Nom)='"+mtgcComboBox1.Text+"')) GROUP BY T_type_machine.Code";
				else
					Comm.CommandText="SELECT T_type_machine.Code FROM T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur ORDER BY T_type_machine.Code";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"types");
				mtgcComboBox3.SourceDataString=new string[]{"Code","","",""};
				mtgcComboBox3.SourceDataTable=ds.Tables["types"];
				mtgcComboBox3.Visible=true;
			}
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

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton4.Checked)
			{
				mtgcComboBox1.Visible=true;
			}
			else
				mtgcComboBox1.Visible=false;
		}

		private void mtgcComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox2.SelectedIndex.Equals(2))
			{
				ds.Clear();
				mtgcComboBox3.Items.Clear();
				if(mtgcComboBox1.SelectedIndex>0)
					Comm.CommandText="SELECT T_type_machine.Code FROM T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_fournisseurs.Nom)='"+mtgcComboBox1.Text+"')) GROUP BY T_type_machine.Code";
				else
					Comm.CommandText="SELECT T_type_machine.Code FROM T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur ORDER BY T_type_machine.Code";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"types");
				mtgcComboBox3.SourceDataString=new string[]{"Code","","",""};
				mtgcComboBox3.SourceDataTable=ds.Tables["types"];
				mtgcComboBox3.Visible=true;
			}
			else
				mtgcComboBox3.Visible=false;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(mtgcComboBox2.SelectedIndex.Equals(0))
			{
				if(radioButton3.Checked)
				{
					foreach(DataRow row in ds.Tables["fournisseurs"].Rows)
					{
						try
						{
							NomFourn=row["nom"].ToString();
							Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+NomFourn.Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code"; 
							DataAD.SelectCommand=Comm;
							DataAD.Fill(ds,"Select");
							if(ds.Tables["Select"].Rows.Count>0)
							{
								if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
								{
									Page=0;
									countRow=0;
									printPreviewDialog1.Document=printDocument1;
									printPreviewDialog1.ShowDialog();
									countRow=0;
									Page=0;
									ds.Tables["Select"].Clear();
								}
								else
									break;
							}
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}
				else if(radioButton4.Checked)
				{
					Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+mtgcComboBox1.Text+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code"; 
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							Page=0;
							countRow=0;
							NomFourn=mtgcComboBox1.Text;
							printPreviewDialog1.Document=printDocument1;
							printPreviewDialog1.ShowDialog();
							ds.Tables["Select"].Clear();
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			else if(mtgcComboBox2.SelectedIndex.Equals(1))
			{
				if(radioButton3.Checked)
				{
					foreach(DataRow row in ds.Tables["fournisseurs"].Rows)
					{
						try
						{
							
							Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+row["nom"].ToString().Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation ORDER BY T_pieces_detachees.Code,T_fournisseurs.Nom, T_parc_machine.[Type machine]";
							DataAD.SelectCommand=Comm;
							DataAD.Fill(ds,"Select");
							if(ds.Tables["Select"].Rows.Count>0)
							{
								if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
								{
									NomFourn=row["nom"].ToString();
									Page=0;
									countRow=0;
									printPreviewDialog1.Document=printDocument1;
									printPreviewDialog1.ShowDialog();
									ds.Tables["Select"].Clear();
								}
								else
									break;
							}
							else
								MessageBox.Show("Aucun résultat");
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}
				else if(radioButton4.Checked)
				{
					Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation ORDER BY T_pieces_detachees.Code,T_fournisseurs.Nom, T_parc_machine.[Type machine]";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							Page=0;
							countRow=0;
							NomFourn=mtgcComboBox1.Text;
							printPreviewDialog1.Document=printDocument1;
							printPreviewDialog1.ShowDialog();
							ds.Tables["Select"].Clear();
						}
						else
							MessageBox.Show("Aucun résultat");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			else if(mtgcComboBox2.SelectedIndex.Equals(2))
			{
				if(radioButton3.Checked)
				{
					foreach(DataRow row in ds.Tables["fournisseurs"].Rows)
					{
						try
						{
							Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+row["nom"].ToString().Replace("'","''")+"') AND ((T_parc_machine.[Type machine])='"+mtgcComboBox3.Text+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code ORDER BY T_pieces_detachees.Code,T_fournisseurs.Nom, T_parc_machine.[Type machine]";
							DataAD.SelectCommand=Comm;
							DataAD.Fill(ds,"Select");
							if(ds.Tables["Select"].Rows.Count>0)
							{
								if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
								{
									NomFourn=row["nom"].ToString();
									Page=0;
									countRow=0;
									printPreviewDialog1.Document=printDocument1;
									printPreviewDialog1.ShowDialog();
									ds.Tables["Select"].Clear();
								}
								else
									break;
							}
							else
							{
								MessageBox.Show("Aucun résultat");
							}
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}
				else if(radioButton4.Checked)
				{
					Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"') AND ((T_parc_machine.[Type machine])='"+mtgcComboBox3.Text+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code ORDER BY T_pieces_detachees.Code,T_fournisseurs.Nom, T_parc_machine.[Type machine]";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							Page=0;
							countRow=0;
							NomFourn=mtgcComboBox1.Text;
							printPreviewDialog1.Document=printDocument1;
							printPreviewDialog1.ShowDialog();
							ds.Tables["Select"].Clear();
						}
						else
						{
							MessageBox.Show("Aucun résultat");
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("Veuillez effectuer une sélection SVP");
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if(mtgcComboBox2.SelectedIndex.Equals(0))
			{
				if(radioButton3.Checked)
				{
					foreach(DataRow row in ds.Tables["fournisseurs"].Rows)
					{
						try
						{
							NomFourn=row["nom"].ToString();
							Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+NomFourn.Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code"; 
							DataAD.SelectCommand=Comm;
							DataAD.Fill(ds,"Select");
							if(ds.Tables["Select"].Rows.Count>0)
							{
								if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
								{
									Page=0;
									countRow=0;
									printDocument1.Print();
									countRow=0;
									Page=0;
									ds.Tables["Select"].Clear();
								}
								else
									break;
							}
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}
				else if(radioButton4.Checked)
				{
					Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+mtgcComboBox1.Text+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code"; 
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							Page=0;
							countRow=0;
							NomFourn=mtgcComboBox1.Text;
							printDocument1.Print();
							ds.Tables["Select"].Clear();
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			else if(mtgcComboBox2.SelectedIndex.Equals(1))
			{
				if(radioButton3.Checked)
				{
					foreach(DataRow row in ds.Tables["fournisseurs"].Rows)
					{
						try
						{
							
							Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+row["nom"].ToString().Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation ORDER BY T_pieces_detachees.Code,T_fournisseurs.Nom, T_parc_machine.[Type machine]";
							DataAD.SelectCommand=Comm;
							DataAD.Fill(ds,"Select");
							if(ds.Tables["Select"].Rows.Count>0)
							{
								if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
								{
									NomFourn=row["nom"].ToString();
									Page=0;
									countRow=0;
									printDocument1.Print();
									ds.Tables["Select"].Clear();
								}
								else
									break;
							}
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}
				else if(radioButton4.Checked)
				{
					Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation ORDER BY T_pieces_detachees.Code,T_fournisseurs.Nom, T_parc_machine.[Type machine]";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							Page=0;
							countRow=0;
							NomFourn=mtgcComboBox1.Text;
							printDocument1.Print();
							ds.Tables["Select"].Clear();
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			else if(mtgcComboBox2.SelectedIndex.Equals(2))
			{
				if(radioButton3.Checked)
				{
					foreach(DataRow row in ds.Tables["fournisseurs"].Rows)
					{
						try
						{
							Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+row["nom"].ToString().Replace("'","''")+"') AND ((T_parc_machine.[Type machine])='"+mtgcComboBox3.Text+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code ORDER BY T_pieces_detachees.Code,T_fournisseurs.Nom, T_parc_machine.[Type machine]";
							DataAD.SelectCommand=Comm;
							DataAD.Fill(ds,"Select");
							if(ds.Tables["Select"].Rows.Count>0)
							{
								if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
								{
									NomFourn=row["nom"].ToString();
									Page=0;
									countRow=0;
									printDocument1.Print();
									ds.Tables["Select"].Clear();
								}
								else
									break;
							}
							else
							{
								MessageBox.Show("Aucun résultat");
							}
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}
				else if(radioButton4.Checked)
				{
					Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#) AND ((T_fournisseurs.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"') AND ((T_parc_machine.[Type machine])='"+mtgcComboBox3.Text+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code ORDER BY T_pieces_detachees.Code,T_fournisseurs.Nom, T_parc_machine.[Type machine]";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							Page=0;
							countRow=0;
							NomFourn=mtgcComboBox1.Text;
							printDocument1.Print();
							ds.Tables["Select"].Clear();
						}
						else
						{
							MessageBox.Show("Aucun résultat");
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("Veuillez effectuer une sélection SVP");
			}
		}
	}
}
