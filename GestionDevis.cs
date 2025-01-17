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
	/// Description résumée de GestionDevis.
	/// </summary>
	public class GestionDevis : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private int Agence;
		private System.Windows.Forms.Button button5;
		private bool Debut;
		private DetailDevis WinDetail;
		private System.Windows.Forms.Label label2;
		private MTGCComboBox mtgcComboBox1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private OleDbTransaction Transac;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GestionDevis(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			
			InitializeComponent();

			Debut=true;

			DataAD=new OleDbDataAdapter();
			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			ds=new DataSet();

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
			this.Refresh();

			WinDetail = new DetailDevis(Agence,"");

			Comm.CommandText="SELECT Nom, Adresse_1, Code_Postal, Ville FROM T_clients ORDER BY 1";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"T_clients");
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			mtgcComboBox1.SourceDataTable = ds.Tables["T_clients"];
			mtgcComboBox1.SourceDataString = new string[]{"nom","adresse_1","code_postal","ville"};
			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("Tous","","",""));
			mtgcComboBox1.SelectedIndex=0;

			ds.Tables["t_clients"].Clear();

			Debut=false;

			Comm.CommandText="Select COUNT(t_devis_entete.[N° Devis]) from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]<7) order by 1 desc";
			oleDbConnection1.Open();
			if(System.Convert.ToInt32(Comm.ExecuteScalar())!=listView1.Items.Count)
				InitializeData();
			oleDbConnection1.Close();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDevis));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataSet11 = new Opindus.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mtgcComboBox1 = new MTGCComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(8, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1008, 488);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° Devis";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Machine";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Entrée";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Décision";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Client";
            this.columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cde";
            this.columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Réception";
            this.columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Réparation";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Edité";
            this.columnHeader11.Width = 45;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Accord";
            this.columnHeader12.Width = 55;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Refus";
            this.columnHeader13.Width = 45;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Refor.";
            this.columnHeader14.Width = 45;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_devis_entete", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("N° Devis", "N° Devis")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_devis_entete WHERE ([N° Devis] = ?)";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO T_devis_entete([N° Devis]) VALUES (?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT [N° Devis] FROM T_devis_entete";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE T_devis_entete SET [N° Devis] = ? WHERE ([N° Devis] = ?)";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null)});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtre client";
            // 
            // radioButton1
            // 
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(24, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Soldés";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(520, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Niveau devis";
            // 
            // radioButton2
            // 
            this.radioButton2.Checked = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(112, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non soldés";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_clients", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Ident", "Ident"),
                        new System.Data.Common.DataColumnMapping("Nom", "Nom"),
                        new System.Data.Common.DataColumnMapping("Adresse_1", "Adresse_1"),
                        new System.Data.Common.DataColumnMapping("Code_Postal", "Code_Postal"),
                        new System.Data.Common.DataColumnMapping("Ville", "Ville")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ident", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO T_clients(Ident, Nom, Adresse_1, Code_Postal, Ville) VALUES (?, ?, ?," +
    " ?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"),
            new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"),
            new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"),
            new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville")});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT Ident, Nom, Adresse_1, Code_Postal, Ville FROM T_clients ORDER BY 2";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"),
            new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"),
            new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"),
            new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"),
            new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ident", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null)});
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(768, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 48);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichage";
            // 
            // radioButton4
            // 
            this.radioButton4.Checked = true;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(152, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 24);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Tous";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(24, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 24);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "Les 30 derniers";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(960, 560);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 48);
            this.button5.TabIndex = 14;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(416, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Patientez...";
            this.label2.Visible = false;
            // 
            // mtgcComboBox1
            // 
            this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox1.ColumnNum = 4;
            this.mtgcComboBox1.ColumnWidth = "220;200;80;150";
            this.mtgcComboBox1.DisplayMember = "Text";
            this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox1.DropDownWidth = 670;
            this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox1.GridLineHorizontal = false;
            this.mtgcComboBox1.GridLineVertical = false;
            this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox1.Location = new System.Drawing.Point(8, 32);
            this.mtgcComboBox1.ManagingFastMouseMoving = true;
            this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox1.Name = "mtgcComboBox1";
            this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.Size = new System.Drawing.Size(288, 21);
            this.mtgcComboBox1.TabIndex = 16;
            this.mtgcComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox1_KeyDown);
            // 
            // GestionDevis
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1026, 681);
            this.ControlBox = false;
            this.Controls.Add(this.mtgcComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GestionDevis";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des devis";
            this.VisibleChanged += new System.EventHandler(this.GestionDevis_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{
			listView1.Items.Clear();
			
			if(mtgcComboBox1.Text.Equals("Tous"))
			{
				if(radioButton2.Checked&&radioButton3.Checked)
				{
					Comm.CommandText="Select TOP 30 t_devis_entete.[N° Devis],t_devis_entete.[Date],t_devis_entete.[Code Materiel],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_parc_machine.[type machine],t_clients.[Nom],t_devis_entete.[Date generation commande],t_devis_entete.[Date reception pieces],t_devis_entete.[Date reparation],t_devis_entete.[Edite],t_devis_entete.[Accord client],t_devis_entete.[Refus],t_devis_entete.[Reforme] from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]<7) order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
				else if(radioButton2.Checked&&radioButton4.Checked)
				{
					Comm.CommandText="Select t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_devis_entete.[Date],t_devis_entete.[Reforme],t_devis_entete.[Refus],t_devis_entete.[Accord client],t_devis_entete.[Edite],t_devis_entete.[Date reparation],t_devis_entete.[Date reception pieces],t_devis_entete.[Date generation commande],t_devis_entete.[Code Materiel],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_parc_machine.[type machine],t_clients.[Nom] from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]<7) order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
				else if(radioButton1.Checked&&radioButton3.Checked)
				{
					Comm.CommandText="Select TOP 30 t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_devis_entete.[Date],t_devis_entete.[Reforme],t_devis_entete.[Refus],t_devis_entete.[Accord client],t_devis_entete.[Edite],t_devis_entete.[Date reparation],t_devis_entete.[Date reception pieces],t_devis_entete.[Date generation commande],t_devis_entete.[Code Materiel],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_parc_machine.[type machine],t_clients.[Nom] from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]>=7) order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
				else if(radioButton1.Checked&&radioButton4.Checked)
				{
					Comm.CommandText="Select t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_devis_entete.[Date],t_devis_entete.[Reforme],t_devis_entete.[Refus],t_devis_entete.[Accord client],t_devis_entete.[Edite],t_devis_entete.[Date reparation],t_devis_entete.[Date reception pieces],t_devis_entete.[Date generation commande],t_devis_entete.[Code Materiel],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_parc_machine.[type machine],t_clients.[Nom] from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]>=7) order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			else
			{
				if(radioButton2.Checked&&radioButton3.Checked)
				{
					Comm.CommandText="Select TOP 30 t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_devis_entete.[Date],t_devis_entete.[Reforme],t_devis_entete.[Refus],t_devis_entete.[Accord client],t_devis_entete.[Edite],t_devis_entete.[Date reparation],t_devis_entete.[Date reception pieces],t_devis_entete.[Date generation commande],t_devis_entete.[Code Materiel],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_parc_machine.[type machine],t_clients.[Nom] from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]<7) AND t_clients.[Nom]='"+mtgcComboBox1.Text+"' order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
				else if(radioButton2.Checked&&radioButton4.Checked)
				{
					Comm.CommandText="Select t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_devis_entete.[Date],t_devis_entete.[Reforme],t_devis_entete.[Refus],t_devis_entete.[Accord client],t_devis_entete.[Edite],t_devis_entete.[Date reparation],t_devis_entete.[Date reception pieces],t_devis_entete.[Date generation commande],t_devis_entete.[Code Materiel],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_parc_machine.[type machine],t_clients.[Nom] from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]<7) AND t_clients.[Nom]='"+mtgcComboBox1.Text+"' order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
				else if(radioButton1.Checked&&radioButton3.Checked)
				{
					Comm.CommandText="Select TOP 30 t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_devis_entete.[Date],t_devis_entete.[Reforme],t_devis_entete.[Refus],t_devis_entete.[Accord client],t_devis_entete.[Edite],t_devis_entete.[Date reparation],t_devis_entete.[Date reception pieces],t_devis_entete.[Date generation commande],t_devis_entete.[Code Materiel],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_parc_machine.[type machine],t_clients.[Nom] from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]>=7) AND t_clients.[Nom]='"+mtgcComboBox1.Text+"' order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
				else if(radioButton1.Checked&&radioButton4.Checked)
				{
					Comm.CommandText="Select t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_devis_entete.[Date],t_devis_entete.[Reforme],t_devis_entete.[Refus],t_devis_entete.[Accord client],t_devis_entete.[Edite],t_devis_entete.[Date reparation],t_devis_entete.[Date reception pieces],t_devis_entete.[Date generation commande],t_devis_entete.[Code Materiel],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_parc_machine.[type machine],t_clients.[Nom] from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]>=7) AND t_clients.[Nom]='"+mtgcComboBox1.Text+"' order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			DataTable Table = ds.Tables["t_devis_entete"];
			int cpt2=0;
			label2.Visible=true;
			this.Refresh();
			foreach(DataRow row in Table.Rows)
			{
				
					string Devis=row["N° Devis"].ToString();
					string Date="";
					try
					{
						Date=System.Convert.ToDateTime(row["Date"].ToString()).ToShortDateString();
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					string CodeMat=row["Code materiel"].ToString();
					string Date2="";
					try
					{
						Date2=System.Convert.ToDateTime(row["Date entree reelle"].ToString()).ToShortDateString();
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}	
				string Date3="";
				try
				{
					Date3=System.Convert.ToDateTime(row["Date decision"].ToString()).ToShortDateString();
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				string type=row["Type machine"].ToString();
				string nom=row["Nom"].ToString();
				string Commande="";
				try
				{
					Commande=System.Convert.ToDateTime(row["Date generation commande"].ToString()).ToShortDateString();
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				
				string Date4="";
				try
				{
					Date4=System.Convert.ToDateTime(row["Date reception pieces"].ToString()).ToShortDateString();
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				string Date5="";
				try
				{
					Date5=System.Convert.ToDateTime(row["Date reparation"].ToString()).ToShortDateString();
				}
				catch(Exception exp)
				{
				}
				string Edite="";
				if(row["Edite"].ToString().Equals("True"))
					Edite="Oui";
				else
					Edite="Non";
				string Accord="";
				if(row["Accord client"].ToString().Equals("True"))
					Accord="Oui";
				else
					Accord="Non";
				string Refus="";
				if(row["Refus"].ToString().Equals("True"))
					Refus="Oui";
				else
					Refus="Non";
				string Reforme="";
				if(row["Reforme"].ToString().Equals("True"))
						Reforme="Oui";
				else
						Reforme="Non";
				ListViewItem listViewItem1 = new ListViewItem(new string[] {Devis,Date,CodeMat,Date2,Date3,type,nom,Commande,Date4,Date5,Edite,Accord,Refus,Reforme});
				listView1.Items.Add(listViewItem1);
				if(cpt2>0)
				{
					if(listView1.Items[cpt2-1].BackColor==Color.MintCream)
						listView1.Items[cpt2].BackColor=Color.White;
					else if(listView1.Items[cpt2].BackColor==Color.White)
						listView1.Items[cpt2].BackColor=Color.MintCream;
				}
				cpt2++;
				if((cpt2/30)==1)
					listView1.Refresh();
			}
			label2.Visible=false;
			ds.Tables["t_devis_entete"].Clear();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked&&!Debut)
			{
				InitializeData();
			}
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton2.Checked&&!Debut)
			{
				InitializeData();	
			}
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton4.Checked&&!Debut)
			{
				InitializeData();
			}
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e)
		{
			
			if(listView1.SelectedIndices.Count>0)
				WinDetail.Remplir(listView1.Items[listView1.SelectedIndices[0]].Text);
			this.Refresh();
			radioButton2.Checked=true;
			radioButton4.Checked=true;
			Comm.CommandText="Select COUNT(t_devis_entete.[N° Devis]) from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]<7) order by 1 desc";
			oleDbConnection1.Open();
			InitializeData();
			oleDbConnection1.Close();
		}

		private void mtgcComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				InitializeData();
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void GestionDevis_VisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible.Equals(true))
			{
				radioButton2.Checked=true;
				radioButton4.Checked=true;
				Comm.CommandText="Select COUNT(t_devis_entete.[N° Devis]) from t_devis_entete, t_parc_machine, t_clients where t_devis_entete.[Code materiel]=t_parc_machine.[code machine opindus] and t_clients.[Ident]=t_devis_entete.[code client] AND (t_devis_entete.[Niveau]<7) order by 1 desc";
				oleDbConnection1.Open();
				if(System.Convert.ToInt32(Comm.ExecuteScalar())!=listView1.Items.Count)
					InitializeData();
				oleDbConnection1.Close();
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked&&!Debut)
			{
				InitializeData();
			}
		}


	}
}

