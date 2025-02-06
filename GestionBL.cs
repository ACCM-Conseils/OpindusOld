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
	/// Description résumée de GestionBL.
	/// </summary>
	public class GestionBL : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.ListView listView1;
		private int Agence;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GestionBL(int Agence)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionBL));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataSet11 = new Opindus.DataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Client";
            this.columnHeader4.Width = 310;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Edité";
            this.columnHeader5.Width = 50;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° BL";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 70;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
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
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_N__BL", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° BL", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_TVA", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code TVA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_TVA1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code TVA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_OR", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl_Euros", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl Euros", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl_Euros1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl Euros", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_transfere", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "transfere", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_transfert", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "transfert", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code_client", System.Data.OleDb.OleDbType.Integer, 0, "Code client"),
            new System.Data.OleDb.OleDbParameter("Code_TVA", System.Data.OleDb.OleDbType.SmallInt, 0, "Code TVA"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"),
            new System.Data.OleDb.OleDbParameter("N__BL", System.Data.OleDb.OleDbType.Integer, 0, "N° BL"),
            new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"),
            new System.Data.OleDb.OleDbParameter("OR", System.Data.OleDb.OleDbType.VarWChar, 20, "OR"),
            new System.Data.OleDb.OleDbParameter("Total_bl", System.Data.OleDb.OleDbType.Double, 0, "Total bl"),
            new System.Data.OleDb.OleDbParameter("Total_bl_Euros", System.Data.OleDb.OleDbType.Double, 0, "Total bl Euros"),
            new System.Data.OleDb.OleDbParameter("transfere", System.Data.OleDb.OleDbType.Boolean, 2, "transfere"),
            new System.Data.OleDb.OleDbParameter("transfert", System.Data.OleDb.OleDbType.Boolean, 2, "transfert")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT [Code client], [Code TVA], Comment, [Date], Edite, [N° BL], [N° Commande o" +
    "uverte], [OR], [Total bl], [Total bl Euros], transfere, transfert FROM T_BL_ente" +
    "te ORDER BY 1 DESC";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code_client", System.Data.OleDb.OleDbType.Integer, 0, "Code client"),
            new System.Data.OleDb.OleDbParameter("Code_TVA", System.Data.OleDb.OleDbType.SmallInt, 0, "Code TVA"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"),
            new System.Data.OleDb.OleDbParameter("N__BL", System.Data.OleDb.OleDbType.Integer, 0, "N° BL"),
            new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"),
            new System.Data.OleDb.OleDbParameter("OR", System.Data.OleDb.OleDbType.VarWChar, 20, "OR"),
            new System.Data.OleDb.OleDbParameter("Total_bl", System.Data.OleDb.OleDbType.Double, 0, "Total bl"),
            new System.Data.OleDb.OleDbParameter("Total_bl_Euros", System.Data.OleDb.OleDbType.Double, 0, "Total bl Euros"),
            new System.Data.OleDb.OleDbParameter("transfere", System.Data.OleDb.OleDbType.Boolean, 2, "transfere"),
            new System.Data.OleDb.OleDbParameter("transfert", System.Data.OleDb.OleDbType.Boolean, 2, "transfert"),
            new System.Data.OleDb.OleDbParameter("Original_N__BL", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° BL", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_TVA", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code TVA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_TVA1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code TVA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_OR", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl_Euros", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl Euros", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl_Euros1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl Euros", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_transfere", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "transfere", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_transfert", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "transfert", System.Data.DataRowVersion.Original, null)});
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "A transférer";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Transféré";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Commande";
            this.columnHeader3.Width = 80;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(1011, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 70);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichage";
            // 
            // radioButton4
            // 
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(216, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(90, 35);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Toutes";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Checked = true;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(24, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(168, 35);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Les 30 dernières";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MintCream;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1358, 803);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "OR";
            this.columnHeader8.Width = 150;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1298, 919);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 70);
            this.button5.TabIndex = 16;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // GestionBL
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 19);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1385, 1002);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GestionBL";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des bons de livraison";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
		private void InitializeData()
		{
			listView1.Items.Clear();
			dataSet11.Clear();
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="Select t_bl_entete.[N° BL],t_bl_entete.Date,t_bl_entete.[N° Commande ouverte],t_bl_entete.[OR],t_bl_entete.[Edite],t_bl_entete.[Transfere],t_bl_entete.[Transfert], t_clients.[nom] from t_bl_entete, t_clients where t_bl_entete.[Code client]=t_clients.Ident order by 1 desc";
			oleDbDataAdapter1.SelectCommand=Comm;
			int Cpt=0;
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			foreach(DataRow row in dataSet11.Tables["t_bl_entete"].Rows)
			{
				ListViewItem item = new ListViewItem(row["N° BL"].ToString());
				if(row["Date"].ToString().Length>0)
					item.SubItems.Add(row["Date"].ToString().Remove(10,9));
				else
					item.SubItems.Add("");
				item.SubItems.Add(row["N° commande ouverte"].ToString());
				item.SubItems.Add(row["Nom"].ToString());
				item.SubItems.Add(row["OR"].ToString());
				if(row["Edite"].ToString().Equals("True"))
					item.SubItems.Add("Oui");
				else
					item.SubItems.Add("Non");
				if(row["Transfert"].ToString().Equals("True"))
					item.SubItems.Add("Oui");
				else
					item.SubItems.Add("Non");
				if(row["Transfere"].ToString().Equals("True"))
					item.SubItems.Add("Oui");
				else
					item.SubItems.Add("Non");
				if(radioButton3.Checked)
				{
					if(Cpt==30)
						break;
				}
				Cpt++;
				listView1.Items.Add(item);
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			int Cpt=0;
			listView1.Items.Clear();
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_bl_entete"].Rows)
			{
				ListViewItem item = new ListViewItem(row["N° BL"].ToString());
				if(row["Date"].ToString().Length>0)
					item.SubItems.Add(row["Date"].ToString().Remove(10,9));
				else
					item.SubItems.Add("");
				item.SubItems.Add(row["N° Commande ouverte"].ToString());
				item.SubItems.Add(row["Nom"].ToString());
				item.SubItems.Add(row["OR"].ToString());
				if(row["Edite"].ToString().Equals("True"))
					item.SubItems.Add("Oui");
				else
					item.SubItems.Add("Non");		
				if(row["Transfert"].ToString().Equals("True"))
					item.SubItems.Add("Oui");
				else
					item.SubItems.Add("Non");
				if(row["Transfere"].ToString().Equals("True"))
					item.SubItems.Add("Oui");
				else
					item.SubItems.Add("Non");
				if(radioButton3.Checked)
				{
					if(Cpt==30)
					break;
				}
				Cpt++;
				listView1.Items.Add(item);
			}
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			int Cpt=0;
			listView1.Items.Clear();
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_bl_entete"].Rows)
			{
				ListViewItem item = new ListViewItem(row["N° BL"].ToString());
				if(row["Date"].ToString().Length>0)
					item.SubItems.Add(row["Date"].ToString().Remove(10,9));
				else
					item.SubItems.Add("");
				item.SubItems.Add(row["N° Commande ouverte"].ToString());
				item.SubItems.Add(row["Nom"].ToString());
				item.SubItems.Add(row["OR"].ToString());
				if(row["Edite"].ToString().Equals("True"))
					item.SubItems.Add("Oui");
				else
					item.SubItems.Add("Non");
				if(row["Transfert"].ToString().Equals("True"))
					item.SubItems.Add("Oui");
				else
					item.SubItems.Add("Non");
				if(row["Transfere"].ToString().Equals("True"))
					item.SubItems.Add("Oui");
				else
					item.SubItems.Add("Non");
				if(radioButton3.Checked)
				{
					if(Cpt==30)
						break;
				}
				Cpt++;
				listView1.Items.Add(item);
			}
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e)
		{
			BL WinBL = new BL(Agence, listView1.Items[listView1.SelectedIndices[0]].Text);
			WinBL.ShowDialog();
			InitializeData();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
