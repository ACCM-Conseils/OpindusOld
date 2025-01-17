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
	/// Description résumée de PreparationCommande.
	/// </summary>
	public class PreparationCommande : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox4;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button4;
		private OleDbCommand Comm;
		private System.Windows.Forms.Button button3;
		private OleDbDataAdapter DataAD;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private OleDbTransaction Transac;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PreparationCommande(int Agence)
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
			DataAD = new OleDbDataAdapter();
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
            Comm.CommandText = "SELECT T_fournisseurs.Nom, T_pieces_detachees.Code,T_pieces_detachees_a_commander_preparation.idLigne,T_pieces_detachees_a_commander_preparation.[n° devis], Max(T_pieces_detachees_a_commander_preparation.[Quantite a cde]) AS [MaxDeQuantite a cde], T_pieces_detachees.[Quantite Stock], T_pieces_detachees.[Quantite Reserve], Max(T_pieces_detachees_a_commander_preparation.[Quantite propose]) AS [MaxDeQuantite propose], T_pieces_detachees.[Quantite Commande], T_pieces_detachees.[Quantite stock theorique], T_pieces_detachees.[Quantite Maxi], T_pieces_detachees.[Quantite Minimum], T_pieces_detachees.[Stock Alerte], T_pieces_detachees.[Quantite Disponible], T_pieces_detachees.[Prix Achat Brut] FROM T_fournisseurs INNER JOIN (T_pieces_detachees_a_commander_preparation INNER JOIN T_pieces_detachees ON T_pieces_detachees_a_commander_preparation.[Code Piece] = T_pieces_detachees.Identificateur) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] GROUP BY T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.[Quantite Stock],T_pieces_detachees_a_commander_preparation.idLigne, T_pieces_detachees.[Quantite Reserve], T_pieces_detachees.[Quantite Commande], T_pieces_detachees.[Quantite stock theorique], T_pieces_detachees.[Quantite Maxi], T_pieces_detachees.[Quantite Minimum], T_pieces_detachees.[Stock Alerte],T_pieces_detachees_a_commander_preparation.[n° devis], T_pieces_detachees.[Quantite Disponible], T_pieces_detachees.[Prix Achat Brut] HAVING (((Max(T_pieces_detachees_a_commander_preparation.[Quantite a cde]))>0)) ORDER BY T_fournisseurs.Nom";

			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			string Fourn=null;
			foreach(DataRow row in dataSet11.Tables["T_pieces_detachees_a_commander_preparation"].Rows)
			{
				if(row["Nom"].ToString()!=Fourn)
				{
					listBox1.Items.Add(row["Nom"].ToString());
					Fourn=row["Nom"].ToString();
				}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreparationCommande));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataSet11 = new Opindus.DataSet1();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
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
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(8, 248);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(816, 232);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stock";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rés.";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cde";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Théor.";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Min";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Maxi";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Alerte";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Dispo";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Propos.";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 70;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "A cder";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Références :";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(151, 500);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(7, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lancer commande";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Commande N°";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(223, 537);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            new System.Data.Common.DataTableMapping("Table", "t_pieces_detachees_a_commander_preparation", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code Fournisseur", "Code Fournisseur"),
                        new System.Data.Common.DataColumnMapping("Code Piece", "Code Piece"),
                        new System.Data.Common.DataColumnMapping("idLigne", "idLigne"),
                        new System.Data.Common.DataColumnMapping("N° Devis", "N° Devis"),
                        new System.Data.Common.DataColumnMapping("Quantite a cde", "Quantite a cde"),
                        new System.Data.Common.DataColumnMapping("Quantite Devis", "Quantite Devis"),
                        new System.Data.Common.DataColumnMapping("Quantite propose", "Quantite propose")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_idLigne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idLigne", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Piece", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Piece", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_a_cde", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite a cde", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_a_cde1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite a cde", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_propose", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite propose", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_propose1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite propose", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO t_pieces_detachees_a_commander_preparation([Code Fournisseur], [Code " +
                "Piece], [N° Devis], [Quantite a cde], [Quantite Devis], [Quantite propose]) VALU" +
                "ES (?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 50, "Code Fournisseur"),
            new System.Data.OleDb.OleDbParameter("Code_Piece", System.Data.OleDb.OleDbType.Integer, 0, "Code Piece"),
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("Quantite_a_cde", System.Data.OleDb.OleDbType.Integer, 0, "Quantite a cde"),
            new System.Data.OleDb.OleDbParameter("Quantite_Devis", System.Data.OleDb.OleDbType.Integer, 0, "Quantite Devis"),
            new System.Data.OleDb.OleDbParameter("Quantite_propose", System.Data.OleDb.OleDbType.Integer, 0, "Quantite propose")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT [Code Fournisseur], [Code Piece], idLigne, [N° Devis], [Quantite a cde], [" +
                "Quantite Devis], [Quantite propose] FROM t_pieces_detachees_a_commander_preparat" +
                "ion WHERE ([Quantite a cde] > 0)";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 50, "Code Fournisseur"),
            new System.Data.OleDb.OleDbParameter("Code_Piece", System.Data.OleDb.OleDbType.Integer, 0, "Code Piece"),
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("Quantite_a_cde", System.Data.OleDb.OleDbType.Integer, 0, "Quantite a cde"),
            new System.Data.OleDb.OleDbParameter("Quantite_Devis", System.Data.OleDb.OleDbType.Integer, 0, "Quantite Devis"),
            new System.Data.OleDb.OleDbParameter("Quantite_propose", System.Data.OleDb.OleDbType.Integer, 0, "Quantite propose"),
            new System.Data.OleDb.OleDbParameter("Original_idLigne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idLigne", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Piece", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Piece", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_a_cde", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite a cde", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_a_cde1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite a cde", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_propose", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite propose", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_propose1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite propose", System.Data.DataRowVersion.Original, null)});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(8, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 226);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(432, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 232);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(669, 488);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(559, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 20);
            this.button4.TabIndex = 14;
            this.button4.Text = "Modifier";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(776, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 48);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // PreparationCommande
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(831, 569);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PreparationCommande";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commandes à préparer";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button3_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			ListeCommandes WinListeCommandes = new ListeCommandes(Agence);
			WinListeCommandes.ShowDialog();
			this.Refresh();
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			listView1.Items.Clear();
			foreach(DataRow row in dataSet11.Tables["T_pieces_detachees_a_commander_preparation"].Rows)
			{
				if(row["Nom"].ToString().Equals(listBox1.Items[listBox1.SelectedIndex].ToString()))
				{
					ListViewItem Ligne = new ListViewItem(row["Code"].ToString());
					Ligne.SubItems.Add(row["Quantite stock"].ToString());
					Ligne.SubItems.Add(row["Quantite reserve"].ToString());
					Ligne.SubItems.Add(row["Quantite commande"].ToString());
                    int Dispo = System.Convert.ToInt32(row["Quantite stock"].ToString()) - System.Convert.ToInt32(row["Quantite reserve"].ToString());
                    int Theo = Dispo + System.Convert.ToInt32(row["Quantite commande"].ToString());
					Ligne.SubItems.Add(Theo.ToString());
					Ligne.SubItems.Add(row["Quantite minimum"].ToString());
					Ligne.SubItems.Add(row["Quantite Maxi"].ToString());
					Ligne.SubItems.Add(row["Stock alerte"].ToString());
					Ligne.SubItems.Add(Dispo.ToString());
                    int Maxi = System.Convert.ToInt32(row["Quantite Maxi"].ToString());
                    int Mini = System.Convert.ToInt32(row["Quantite minimum"].ToString());
                    int Propo = 0;
                    if (Theo < Mini)
                    {
                        Propo = Maxi - Theo;
                    }
                    Ligne.SubItems.Add(Propo.ToString());
                    Ligne.SubItems.Add(Propo.ToString());
					Ligne.Tag=row["idligne"].ToString();

                    if(Propo>0)
					    listView1.Items.Add(Ligne);
					
				}
			}
			textBox3.Text=listView1.Items.Count.ToString();
		}

		private void listView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				try
				{
					textBox1.Visible=true;
					textBox1.Text=listView1.Items[listView1.SelectedIndices[0]].SubItems[10].Text;
					textBox1.Focus();
					textBox1.Select(0,textBox1.TextLength);
					button4.Visible=true;
				}
				catch(Exception exp)
				{
				}
			}
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			button4.Visible=false;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			Comm.CommandText="update t_pieces_detachees_a_commander_preparation set [Quantite a cde]="+textBox1.Text+" where idligne="+listView1.Items[listView1.SelectedIndices[0]].Tag.ToString();
			
			Comm.ExecuteNonQuery();
			MessageBox.Show("Mise à jour terminée");
			button4.Visible=false;
			textBox1.Visible=false;
			oleDbConnection1.Close();
			listView1.Items[listView1.SelectedIndices[0]].SubItems[10].Text=textBox1.Text;
			dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Clear();
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="SELECT T_fournisseurs.Nom, T_pieces_detachees_a_commander_preparation.[idligne],T_pieces_detachees_a_commander_preparation.[N° Devis], T_pieces_detachees_a_commander_preparation.[Code Piece], T_pieces_detachees_a_commander_preparation.[Quantite Devis], T_pieces_detachees_a_commander_preparation.[Quantite propose], T_pieces_detachees_a_commander_preparation.[Quantite a cde] FROM T_pieces_detachees_a_commander_preparation INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON T_pieces_detachees_a_commander_preparation.[Code Piece] = T_pieces_detachees.Identificateur WHERE ([Quantite a cde]>0) ORDER BY T_fournisseurs.Nom";
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
		}

		private void button3_Click_1(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(listBox1.SelectedIndex>=0)
			{
				oleDbConnection1.Open();
				Transac= oleDbConnection1.BeginTransaction();
				Comm.Transaction=Transac;
				oleDbUpdateCommand1.Transaction=Transac;
				try
				{
					dataSet11.Tables["t_cde_entete"].Clear();
					Comm.CommandText="select * from parametres";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(dataSet11,"parametres");
					}
					catch(Exception exp)
					{

					}
					Comm.CommandText="select [n° commande] from t_cde_entete order by [n° commande]";
					DataAD.Fill(dataSet11,"t_cde_entete");
					int Cde=System.Convert.ToInt32(dataSet11.Tables["t_cde_entete"].Rows[dataSet11.Tables["t_cde_entete"].Rows.Count-1]["N° Commande"].ToString());
					Cde++;
					textBox4.Text=Cde.ToString();
					dataSet11.Tables["t_fournisseurs"].Clear();
				
					Comm.CommandText="select [code],[Pourcentage remise] from t_fournisseurs where nom='"+listBox1.Items[listBox1.SelectedIndex].ToString()+"'";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(dataSet11,"t_fournisseurs");
					}
					catch(Exception exp)
					{
						
					}
					Comm.CommandText="insert into t_cde_entete ([N° commande],[Date commande],[Code Fournisseur],signature,[total pieces commandees]) values ("+Cde.ToString()+",'"+DateTime.Now.ToShortDateString()+"','"+dataSet11.Tables["t_fournisseurs"].Rows[0]["Code"].ToString()+"','"+dataSet11.Tables["parametres"].Rows[0]["signature"].ToString()+"',"+textBox3.Text+")";
					try
					{
						Comm.ExecuteNonQuery();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
			
					Decimal TotalCommande=0;
					for(int i=0;i<listView1.Items.Count;i++)
					{
						dataSet11.Tables["t_pieces_detachees"].Clear();
						Comm.CommandText="select Identificateur,Designation,[Prix achat brut],[Delai livraison] from t_pieces_detachees where [Code]='"+listView1.Items[i].Text+"'";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(dataSet11,"T_pieces_detachees");
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						int Jours=0;
						try
						{
							Jours=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Delai livraison"].ToString())*7;
						}
						catch
						{
							Jours=0;
						}
						DateTime Delai=DateTime.Now.AddDays(Jours);
						int Qte=System.Convert.ToInt32(listView1.Items[i].SubItems[10].Text);
						Decimal Total = System.Convert.ToDecimal(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString())*Qte;
						Comm.CommandText="insert into t_cde_lignes ([n° commande],[Code piece],Designation,Quantite,[Prix achat],[Total ligne],[Date livraison]) values ("+textBox4.Text+","+dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString()+",'"+dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString()+"',"+listView1.Items[i].SubItems[10].Text+","+dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString().Replace(",",".")+","+Total.ToString().Replace(",",".")+",'"+Delai.ToShortDateString()+"')";
						TotalCommande+=Total;
						try
						{
							Comm.ExecuteNonQuery();
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
					}
					string Taux=dataSet11.Tables["t_fournisseurs"].Rows[0]["pourcentage remise"].ToString();
					Decimal Tx=System.Convert.ToDecimal(Taux);
					Decimal Remise=TotalCommande*Tx;
					Decimal Net=TotalCommande-Remise;
					dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Clear();
					Comm.CommandText="update t_cde_entete set [Total commande]="+TotalCommande.ToString().Replace(",",".")+", [remise fournisseur]="+dataSet11.Tables["t_fournisseurs"].Rows[0]["pourcentage remise"].ToString().Replace(",",".")+", [Montant remise]="+Remise.ToString().Replace(",",".")+", [Total net commande]="+Net.ToString().Replace(",",".")+" where [N° commande]="+textBox4.Text;
					try
					{
						Comm.ExecuteNonQuery();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Clear();
					Comm.CommandText="select * from t_pieces_detachees_a_commander_preparation where [Code fournisseur]='"+dataSet11.Tables["t_fournisseurs"].Rows[0]["Code"].ToString()+"' AND [Quantite a cde]>0";
					try
					{
						DataAD.Fill(dataSet11,"t_pieces_detachees_a_commander_preparation");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					string NumDevis=null;
				
					foreach(DataRow row in dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Rows)
					{
						Comm.CommandText="update t_pieces_detachees_a_commander_preparation set [Quantite propose]=0, [Quantite a cde]=0 where idligne="+row["idligne"].ToString();
						try
						{
							Comm.ExecuteNonQuery();
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						NumDevis=row["N° devis"].ToString();
                        Comm.CommandText = "update t_devis_entete set [date generation commande]='" + DateTime.Now.ToShortDateString() + "',[niveau]=5 where [N° devis]=" + NumDevis;
						try
						{
							Comm.ExecuteNonQuery();
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						
					}
					try
					{
						Transac.Commit();
					}
					catch(OleDbException excp)
					{
						Transac.Rollback();
					}
					listBox1.Items.Clear();
					listView1.Items.Clear();
					dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Clear();
					Comm.CommandText="SELECT T_fournisseurs.Nom, T_pieces_detachees.Code, Max(T_pieces_detachees_a_commander_preparation.[Quantite a cde]) AS [MaxDeQuantite a cde], T_pieces_detachees.[Quantite Stock], T_pieces_detachees.[Quantite Reserve], Max(T_pieces_detachees_a_commander_preparation.[Quantite propose]) AS [MaxDeQuantite propose], T_pieces_detachees.[Quantite Commande], T_pieces_detachees.[Quantite stock theorique], T_pieces_detachees.[Quantite Maxi], T_pieces_detachees.[Quantite Minimum], T_pieces_detachees.[Stock Alerte], T_pieces_detachees.[Quantite Disponible], T_pieces_detachees.[Prix Achat Brut] FROM T_fournisseurs INNER JOIN (T_pieces_detachees_a_commander_preparation INNER JOIN T_pieces_detachees ON T_pieces_detachees_a_commander_preparation.[Code Piece] = T_pieces_detachees.Identificateur) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] GROUP BY T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.[Quantite Stock], T_pieces_detachees.[Quantite Reserve], T_pieces_detachees.[Quantite Commande], T_pieces_detachees.[Quantite stock theorique], T_pieces_detachees.[Quantite Maxi], T_pieces_detachees.[Quantite Minimum], T_pieces_detachees.[Stock Alerte], T_pieces_detachees.[Quantite Disponible], T_pieces_detachees.[Prix Achat Brut] HAVING (((Max(T_pieces_detachees_a_commander_preparation.[Quantite a cde]))>0)) ORDER BY T_fournisseurs.Nom";
					oleDbDataAdapter1.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
					}
					string Fourn=null;
				
					foreach(DataRow row in dataSet11.Tables["T_pieces_detachees_a_commander_preparation"].Rows)
					{
						if(row["Nom"].ToString()!=Fourn)
						{
							listBox1.Items.Add(row["Nom"].ToString());
							Fourn=row["Nom"].ToString();
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
			else
				MessageBox.Show("Veuillez selectionner un fournisseur");
		}
	}
}
