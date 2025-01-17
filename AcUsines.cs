using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Opindus
{
	/// <summary>
	/// Description résumée de AcUsines.
	/// </summary>
	public class AcUsines : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private int Agence;
		bool Nouveau;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private System.Windows.Forms.Button btGroupes;
		private System.Windows.Forms.TextBox txDesignation;
		private System.Windows.Forms.TextBox txUsine;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private MTGCComboBox mtgcComboBox1;
		private MTGCComboBox mtgcComboBox2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AcUsines(int Agence)
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
			mtgcComboBox2.Items.Clear();
			dataSet11.Tables["T_groupes"].Clear();
			dataSet11.Tables["t_usine"].Clear();
			oleDbDataAdapter2.Fill(dataSet11);
			mtgcComboBox2.Sorted=true;
			DataTable Table = dataSet11.Tables["T_groupes"];
			foreach (DataRow row in Table.Rows)
			{
				mtgcComboBox2.Items.Add(new MTGCComboBoxItem(row["code"].ToString(),"","",""));
			}
			mtgcComboBox2.SelectedIndex=0;
			Nouveau=true;
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_usine"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["Code_usine"].ToString(),row["Designation"].ToString(),row["Code_groupe"].ToString(),""));
			}
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AcUsines));
			this.btSupprime = new System.Windows.Forms.Button();
			this.btEnregistre = new System.Windows.Forms.Button();
			this.btNouveau = new System.Windows.Forms.Button();
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
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.btGroupes = new System.Windows.Forms.Button();
			this.txDesignation = new System.Windows.Forms.TextBox();
			this.txUsine = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btSupprime
			// 
			this.btSupprime.BackColor = System.Drawing.Color.White;
			this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btSupprime.ForeColor = System.Drawing.Color.Red;
			this.btSupprime.Location = new System.Drawing.Point(296, 176);
			this.btSupprime.Name = "btSupprime";
			this.btSupprime.Size = new System.Drawing.Size(100, 23);
			this.btSupprime.TabIndex = 7;
			this.btSupprime.Text = "Supprime";
			this.btSupprime.Click += new System.EventHandler(this.btSupprime_Click);
			// 
			// btEnregistre
			// 
			this.btEnregistre.BackColor = System.Drawing.Color.White;
			this.btEnregistre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btEnregistre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEnregistre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btEnregistre.ForeColor = System.Drawing.Color.Blue;
			this.btEnregistre.Location = new System.Drawing.Point(128, 176);
			this.btEnregistre.Name = "btEnregistre";
			this.btEnregistre.Size = new System.Drawing.Size(100, 23);
			this.btEnregistre.TabIndex = 6;
			this.btEnregistre.Text = "Enregistre";
			this.btEnregistre.Click += new System.EventHandler(this.btEnregistre_Click);
			// 
			// btNouveau
			// 
			this.btNouveau.BackColor = System.Drawing.Color.White;
			this.btNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btNouveau.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btNouveau.ForeColor = System.Drawing.Color.Blue;
			this.btNouveau.Location = new System.Drawing.Point(16, 176);
			this.btNouveau.Name = "btNouveau";
			this.btNouveau.Size = new System.Drawing.Size(100, 23);
			this.btNouveau.TabIndex = 5;
			this.btNouveau.Text = "Nouveau";
			this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
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
																										new System.Data.Common.DataTableMapping("Table", "T_usine", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("Code_Groupe", "Code_Groupe"),
																																																				   new System.Data.Common.DataColumnMapping("Code_usine", "Code_usine"),
																																																				   new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_usine WHERE (Code_usine = ?) AND (Code_Groupe = ? OR ? IS NULL AND " +
				"Code_Groupe IS NULL) AND (Designation = ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_usine(Code_Groupe, Code_usine, Designation) VALUES (?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Code_Groupe"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Code_usine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Code_Groupe, Code_usine, Designation FROM T_usine ORDER BY Code_usine";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_usine SET Code_Groupe = ?, Code_usine = ?, Designation = ? WHERE (Code_u" +
				"sine = ?) AND (Code_Groupe = ? OR ? IS NULL AND Code_Groupe IS NULL) AND (Design" +
				"ation = ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Code_Groupe"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Code_usine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
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
																										new System.Data.Common.DataTableMapping("Table", "T_Groupes", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																					 new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = "DELETE FROM T_Groupes WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Desi" +
				"gnation IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO T_Groupes(Code, Designation) VALUES (?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Code, Designation FROM T_Groupes";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = "UPDATE T_Groupes SET Code = ?, Designation = ? WHERE (Code = ?) AND (Designation " +
				"= ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Location = new System.Drawing.Point(-5, 8);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Gainsboro;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(526, 243);
			this.tabControlEX1.TabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.TabIndex = 9;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.mtgcComboBox2);
			this.tabPageEX1.Controls.Add(this.mtgcComboBox1);
			this.tabPageEX1.Controls.Add(this.btGroupes);
			this.tabPageEX1.Controls.Add(this.txDesignation);
			this.tabPageEX1.Controls.Add(this.txUsine);
			this.tabPageEX1.Controls.Add(this.label4);
			this.tabPageEX1.Controls.Add(this.label3);
			this.tabPageEX1.Controls.Add(this.label2);
			this.tabPageEX1.Controls.Add(this.label1);
			this.tabPageEX1.Controls.Add(this.btNouveau);
			this.tabPageEX1.Controls.Add(this.btEnregistre);
			this.tabPageEX1.Controls.Add(this.btSupprime);
			this.tabPageEX1.Controls.Add(this.button2);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(518, 214);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Saisie";
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
			this.mtgcComboBox2.Location = new System.Drawing.Point(112, 88);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(256, 21);
			this.mtgcComboBox2.TabIndex = 1;
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 3;
			this.mtgcComboBox1.ColumnWidth = "50;150;50";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 270;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = true;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(112, 16);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(256, 21);
			this.mtgcComboBox1.TabIndex = 0;
			this.mtgcComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox1_KeyDown);
			// 
			// btGroupes
			// 
			this.btGroupes.BackColor = System.Drawing.Color.Lavender;
			this.btGroupes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btGroupes.ForeColor = System.Drawing.Color.Navy;
			this.btGroupes.Location = new System.Drawing.Point(388, 88);
			this.btGroupes.Name = "btGroupes";
			this.btGroupes.Size = new System.Drawing.Size(25, 20);
			this.btGroupes.TabIndex = 18;
			this.btGroupes.Text = "...";
			// 
			// txDesignation
			// 
			this.txDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txDesignation.Location = new System.Drawing.Point(112, 120);
			this.txDesignation.Name = "txDesignation";
			this.txDesignation.Size = new System.Drawing.Size(256, 20);
			this.txDesignation.TabIndex = 2;
			this.txDesignation.Text = "";
			// 
			// txUsine
			// 
			this.txUsine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txUsine.Location = new System.Drawing.Point(112, 53);
			this.txUsine.MaxLength = 3;
			this.txUsine.Name = "txUsine";
			this.txUsine.Size = new System.Drawing.Size(122, 20);
			this.txUsine.TabIndex = 0;
			this.txUsine.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "Désignation :";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 14);
			this.label3.TabIndex = 13;
			this.label3.Text = "Code groupe :";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "Code usine :";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Recherche :";
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
			this.button2.TabIndex = 10;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// AcUsines
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(515, 246);
			this.ControlBox = false;
			this.Controls.Add(this.tabControlEX1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "AcUsines";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Usines";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btGroupes_Click(object sender, System.EventArgs e)
		{
			AcGroupes WinGroupes = new AcGroupes(Agence);
			if(WinGroupes.ShowDialog()==DialogResult.OK)
			{
				mtgcComboBox2.Items.Clear();
				oleDbConnection1.Open();
				dataSet11.Clear();
				oleDbDataAdapter2.Fill(dataSet11);
				DataTable Table = dataSet11.Tables["T_groupes"];
				foreach (DataRow row in Table.Rows)
				{
					mtgcComboBox2.Items.Add(new MTGCComboBoxItem(row["Designation"].ToString(),"","",""));
				}
				mtgcComboBox2.SelectedIndex=0;
				oleDbConnection1.Close();
			}
		}


		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			oleDbDataAdapter1.Fill(dataSet11);
			oleDbDataAdapter2.Fill(dataSet11);
			DataTable Table = dataSet11.Tables["T_usine"];
			DataTable Table2 = dataSet11.Tables["T_groupes"];
			bool save=true;
			if(Nouveau)
			{
				foreach(DataRow row in Table.Rows)
				{
					if(row["Code_usine"].ToString().ToUpper().Equals(txUsine.Text.ToUpper()))
					{
						MessageBox.Show("Code déja présent dans la base","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						save=false;
					}
				}
			}
			if(save)
			{
				if(Nouveau)
				{
					dataSet11.Tables["t_groupes"].Clear();
					oleDbDataAdapter2.SelectCommand.CommandText="select * from t_groupes where code='"+mtgcComboBox2.Text+"'";
					oleDbDataAdapter2.Fill(dataSet11);
					if(dataSet11.Tables["t_groupes"].Rows.Count>0)
					{
						DataRow newrow = Table.NewRow();
						newrow["Code_usine"]=txUsine.Text.ToUpper();
						newrow["Code_groupe"]=dataSet11.Tables["t_groupes"].Rows[0]["Code"].ToString();
						newrow["Designation"]=txDesignation.Text.ToUpper();
						Table.Rows.Add(newrow);
						try
						{
							oleDbDataAdapter1.Update(dataSet11);
							MessageBox.Show("Enregistrement terminé.","I/O",MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						txUsine.Clear();
						txDesignation.Clear();
						mtgcComboBox2.SelectedIndex=0;
					}
					else 
					{
						MessageBox.Show("Groupe introuvable !");
					}
					
				}
				else
				{
					OleDbCommand Comm = new OleDbCommand();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="update t_usine set designation ='"+txDesignation.Text+"', code_groupe='"+mtgcComboBox2.Text+"' where code_usine='"+txUsine.Text+"'";
					try
					{
						Comm.ExecuteNonQuery();
						MessageBox.Show("Mise à jour terminée.","I/O",MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					MessageBox.Show("Mise à jour OK");
				}
			}
			oleDbConnection1.Close();
		}

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			Nouveau=true;
			txUsine.ReadOnly=false;
			txUsine.Clear();
			txDesignation.Clear();
			mtgcComboBox2.SelectedIndex=0;
		}

		private void btUsines_Click(object sender, System.EventArgs e)
		{
			mtgcComboBox2.SelectedIndex=0;
			SelectUsine WinSelUsines = new SelectUsine(Agence);
			this.Update();
			if(WinSelUsines.ShowDialog()==DialogResult.OK)
			{
				DataRow row = WinSelUsines.GetRow();
				txUsine.ReadOnly=true;
				txUsine.Text=row["Code_usine"].ToString();
				txDesignation.Text=row["Designation"].ToString();
				oleDbConnection1.Open();
				oleDbDataAdapter2.Fill(dataSet11);
				DataTable Table = dataSet11.Tables["T_groupes"];
				Nouveau=false;
				oleDbConnection1.Close();
			}
		}

		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			if(txDesignation.Text.Length==0&&txUsine.Text.Length==0)
				MessageBox.Show("Rien à supprimer !");
			else
			{
				if(MessageBox.Show("Suppression ?","Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
				{
					oleDbConnection1.Open();
					oleDbDataAdapter1.Fill(dataSet11);
					DataTable Table = dataSet11.Tables["T_usine"];
					foreach(DataRow row in Table.Rows)
					{
						if(row["Designation"].ToString().Equals(txDesignation.Text))
						{
							row.Delete();
						}
					}
					oleDbDataAdapter1.Update(dataSet11);
					oleDbConnection1.Close();
					txDesignation.Clear();
					txUsine.Clear();
					mtgcComboBox2.SelectedIndex=0;
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void btUsines_Click_1(object sender, System.EventArgs e)
		{
		
		}

		private void mtgcComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				dataSet11.Tables["t_usine"].Clear();
				oleDbSelectCommand1.CommandText="select * from t_usine where code_usine='"+mtgcComboBox1.Text+"'";
				try
				{
					oleDbDataAdapter1.Fill(dataSet11);
					if(dataSet11.Tables["t_usine"].Rows.Count>0)
					{
						txUsine.Text=dataSet11.Tables["t_usine"].Rows[0]["Code_usine"].ToString();
						txDesignation.Text=dataSet11.Tables["t_usine"].Rows[0]["designation"].ToString();
						mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(dataSet11.Tables["t_usine"].Rows[0]["code_groupe"].ToString());
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}

			}
		}

	}
}
