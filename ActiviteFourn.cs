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
	/// Description résumée de ActiviteFourn.
	/// </summary>
	public class ActiviteFourn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		
		private System.Windows.Forms.Button button2;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private DataSet ds;
		private OleDbDataAdapter DataAD;
		private OleDbCommand Comm;
		private Opindus.DataSet1 dataSet11;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private int Page;
		private int countRow;
		private int cptEntree=0;
		private int cptSortie=0;
		private Decimal DNR;
		private Decimal MoyDNR;
		private Decimal CA;
        private int TotEntrees;
        private int TotSorties;
        private int GenEntrees;
        private int GenSorties;
		private Decimal TotCA;
        private Decimal GenCA;
        private Decimal TotDNR;
        private Decimal TotMoyDNR;
        private Decimal GenDNR;
		private string ancienmachine=null;
        private string ancienfourn = null;
        private int MaxRows = 0;
        private int countRow2 = 0;
        private DateTime Debut;
        private DateTime Fin;

		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ActiviteFourn(int Agence)
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
			Page=0;
			countRow=0;
			TotEntrees=0;
			TotSorties=0;
			cptEntree=0;
			cptSortie=0;
			DNR=0;
			CA=0;
			TotCA=0;
			ancienmachine=null;
			ds = new DataSet();
			DataAD = new OleDbDataAdapter();
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="SELECT Code,nom,[code postal],ville FROM t_fournisseurs ORDER BY nom";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"fournisseurs");
			mtgcComboBox1.SourceDataString=new string[]{"nom","code postal","ville",""};
			mtgcComboBox1.SourceDataTable=ds.Tables["fournisseurs"];
			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("Choisissez...","","",""));
			mtgcComboBox1.SelectedIndex=0;
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_fournisseurs"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["Nom"].ToString(), row["Code postal"].ToString(), row["Ville"].ToString(), ""));
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ActiviteFourn));
			this.label1 = new System.Windows.Forms.Label();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.button2 = new System.Windows.Forms.Button();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(232, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 32);
			this.label1.TabIndex = 11;
			this.label1.Text = "Activité fournisseurs";
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
																																																						  new System.Data.Common.DataColumnMapping("Code Postal", "Code Postal"),
																																																						  new System.Data.Common.DataColumnMapping("Ville", "Ville")})});
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
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_fournisseurs(Code, Nom, [Code Postal], Ville) VALUES (?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Code, Nom, [Code Postal], Ville FROM T_fournisseurs ORDER BY Nom";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_fournisseurs SET Code = ?, Nom = ?, [Code Postal] = ?, Ville = ? WHERE (" +
				"Code = ?) AND ([Code Postal] = ? OR ? IS NULL AND [Code Postal] IS NULL) AND (No" +
				"m = ? OR ? IS NULL AND Nom IS NULL) AND (Ville = ? OR ? IS NULL AND Ville IS NUL" +
				"L)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
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
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(640, 176);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 48);
			this.button2.TabIndex = 22;
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(288, 128);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(328, 21);
			this.mtgcComboBox1.TabIndex = 24;
			this.mtgcComboBox1.ValueMember = "Code";
			this.mtgcComboBox1.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(264, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(376, 88);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Choix de l\'impression";
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
			// radioButton1
			// 
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(72, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "Fournisseur";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(16, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 30;
			this.label5.Text = "Format de date incorrect";
			this.label5.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(136, 104);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 20);
			this.textBox2.TabIndex = 29;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(16, 104);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 28;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(136, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 27;
			this.label3.Text = "Fin";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 26;
			this.label2.Text = "Début";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(16, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 32;
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
			this.button3.Location = new System.Drawing.Point(128, 200);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 31;
			this.button3.Text = "Imprimer";
			this.button3.Click += new System.EventHandler(this.button3_Click);
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
			this.printPreviewDialog1.Location = new System.Drawing.Point(540, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// ActiviteFourn
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(704, 232);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mtgcComboBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ActiviteFourn";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Activité fournisseurs";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
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

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked)
				mtgcComboBox1.Visible=true;
			else
				mtgcComboBox1.Visible=false;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int Error=0;
			try
			{
				System.Convert.ToDateTime(textBox1.Text);
				System.Convert.ToDateTime(textBox2.Text);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
				//Error=1;
			}
            cptEntree = 0;
            cptSortie = 0;
            CA = 0;
            DNR = 0;
            MoyDNR = 0;
            TotCA = 0;
            TotDNR = 0;
            TotEntrees = 0;
            TotMoyDNR = 0;
            TotSorties = 0;
            GenCA = 0;
            GenDNR = 0;
            GenEntrees = 0;
            GenSorties = 0;
            countRow = 0;
            countRow2 = 0;
            ds.Clear();

			if(Error.Equals(0))
			{
				if(radioButton3.Checked)
				{
                    Debut = System.Convert.ToDateTime(textBox1.Text);
                    Fin = System.Convert.ToDateTime(textBox2.Text);

                    Comm.CommandText = "SELECT T_fournisseurs.Nom, T_type_machine.Code, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.Date, T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_parc_machine.[Code machine Opindus] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom, T_type_machine.Code, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.Date, T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_parc_machine.[Code machine Opindus] HAVING (((T_devis_entete.Date)>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.Date)<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) OR (((T_devis_entete.[Date reparation])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date reparation])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) ORDER BY T_fournisseurs.Nom, T_type_machine.Code";
                    DataAD.SelectCommand = Comm;
                    DataAD.Fill(ds, "Requete");
				}
				else
                {
                    Debut = System.Convert.ToDateTime(textBox1.Text);
                    Fin = System.Convert.ToDateTime(textBox2.Text);

                    MTGCComboBoxItem Fourn=(MTGCComboBoxItem)mtgcComboBox1.SelectedItem;
                    Comm.CommandText = "SELECT T_fournisseurs.Nom, T_type_machine.Code, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.Date, T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_parc_machine.[Code machine Opindus] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE t_fournisseurs.nom='" + Fourn.Col1.ToString() + "' GROUP BY T_fournisseurs.Nom, T_type_machine.Code, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.Date, T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_parc_machine.[Code machine Opindus] HAVING (((T_devis_entete.Date)>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.Date)<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) OR (((T_devis_entete.[Date reparation])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date reparation])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) ORDER BY T_fournisseurs.Nom, T_type_machine.Code";
                    DataAD.SelectCommand = Comm;
                    DataAD.Fill(ds, "Requete");
                }

                if (ds.Tables["Requete"].Rows.Count > 0)
				{
					printPreviewDialog1.Document=printDocument1;
					printPreviewDialog1.ShowDialog();
					countRow=0;
					Page=0;
				}
				else
					MessageBox.Show("Aucun enregistrement pour cette période");
			}
			else
				label5.Visible=true;
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Page+=1;
			int ypos=e.MarginBounds.Top;
			int AncienYpos=0;
			
			bool debut=true;
			e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=5;
			e.Graphics.DrawString("Activité fournisseurs du "+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+" au "+System.Convert.ToDateTime(textBox2.Text).ToShortDateString(), 
				new Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=25;
			e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			e.Graphics.DrawString("Nom", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Code type", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos);
			e.Graphics.DrawString("Entree", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
			e.Graphics.DrawString("Sortie", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
			e.Graphics.DrawString("DNR", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			e.Graphics.DrawString("DNR Moyen", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+475, ypos);
			e.Graphics.DrawString("CA", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+550, ypos);
			ypos+=15;
			e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=30;
			oleDbConnection1.Close();
			oleDbConnection1.Open();
            while (ypos < e.MarginBounds.Height && countRow < ds.Tables["Requete"].Rows.Count)
            {
                if (!debut)
                {
                    try
                    {
                        ancienmachine = ds.Tables["Requete"].Rows[countRow + 1]["Code"].ToString();
                    }
                    catch
                    {
                        ancienmachine = "";
                    }
                    try
                    {
                        ancienfourn = ds.Tables["Requete"].Rows[countRow + 1]["Nom"].ToString();
                    }
                    catch
                    {
                        ancienfourn = "";
                    }
                }
                else
                {
                    e.Graphics.DrawString(ds.Tables["Requete"].Rows[countRow]["Nom"].ToString(),
                    new Font("Arial", 8, FontStyle.Bold | FontStyle.Underline), Brushes.Black, e.MarginBounds.Left, ypos);
                    ypos += 20;
                    debut = false;
                    try
                    {
                        ancienmachine = ds.Tables["Requete"].Rows[countRow + 1]["Code"].ToString();
                    }
                    catch
                    {
                        ancienmachine = "";
                    }
                    try
                    {
                        ancienfourn = ds.Tables["Requete"].Rows[countRow + 1]["Nom"].ToString();
                    }
                    catch
                    {
                        ancienfourn = "";
                    }
                }

                if (ancienmachine != ds.Tables["Requete"].Rows[countRow]["Code"].ToString())
                {
                    try
                    {
                        if ((System.Convert.ToDateTime(ds.Tables["Requete"].Rows[countRow]["Date"].ToString()) >= Debut)&& (System.Convert.ToDateTime(ds.Tables["Requete"].Rows[countRow]["Date"].ToString()) <= Fin))
                        {
                            cptEntree += 1;
                            TotEntrees += 1;
                            GenEntrees += 1;
                        }
                    }
                    catch
                    {
                    }
                    try
                    {
                        if ((System.Convert.ToDateTime(ds.Tables["Requete"].Rows[countRow]["Date reparation"].ToString()) >= Debut) && (System.Convert.ToDateTime(ds.Tables["Requete"].Rows[countRow]["Date reparation"].ToString()) <= Fin))
                        {
                            if (ds.Tables["Requete"].Rows[countRow]["Niveau"].ToString().Equals("7"))
                            {
                                cptSortie += 1;
                                TotSorties += 1;
                                GenSorties += 1;
                            }
                            CA += System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Total devis"].ToString().Replace(".", ","));
                            TotCA += System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Total devis"].ToString().Replace(".", ","));
                            GenCA += System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Total devis"].ToString().Replace(".", ","));
                            DNR+=System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Forfait DNR"].ToString().Replace(".", ","));
                            TotDNR += System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Forfait DNR"].ToString().Replace(".", ","));
                            GenDNR += System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Forfait DNR"].ToString().Replace(".", ","));
                        }
                    }
                    catch
                    {
                    }

                    e.Graphics.DrawString(ds.Tables["Requete"].Rows[countRow]["Code"].ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 150, ypos);
                    e.Graphics.DrawString(cptEntree.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 300, ypos);
                    e.Graphics.DrawString(cptSortie.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                    if (cptSortie > 0)
                    {
                        e.Graphics.DrawString(CA.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 550, ypos);
                        e.Graphics.DrawString(DNR.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 400, ypos);
                        try
                        {
                            MoyDNR = DNR / System.Convert.ToDecimal(cptSortie);
                            e.Graphics.DrawString(MoyDNR.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 475, ypos);
                            TotMoyDNR += MoyDNR;
                        }
                        catch
                        {
                            e.Graphics.DrawString("0.00",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 475, ypos);
                        }
                    }
                    else
                    {
                        e.Graphics.DrawString("0.00",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 550, ypos);
                        e.Graphics.DrawString("0.00",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 400, ypos);
                        e.Graphics.DrawString("0.00",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 475, ypos);
                    }
                    cptEntree = 0;
                    cptSortie = 0;
                    CA = 0;
                    DNR = 0;
                    ypos += 20;
                }
                else
                {
                    try
                    {
                        if ((System.Convert.ToDateTime(ds.Tables["Requete"].Rows[countRow]["Date"].ToString()) >= Debut) && (System.Convert.ToDateTime(ds.Tables["Requete"].Rows[countRow]["Date"].ToString()) <= Fin))
                        {
                            cptEntree += 1;
                            TotEntrees += 1;
                            GenEntrees += 1;
                        }
                    }
                    catch
                    {
                    }
                    try
                    {
                        if ((System.Convert.ToDateTime(ds.Tables["Requete"].Rows[countRow]["Date reparation"].ToString()) >= Debut) && (System.Convert.ToDateTime(ds.Tables["Requete"].Rows[countRow]["Date reparation"].ToString()) <= Fin))
                        {
                            if (ds.Tables["Requete"].Rows[countRow]["Niveau"].ToString().Equals("7"))
                            {
                                cptSortie += 1;
                                TotSorties += 1;
                                GenSorties += 1;
                            }
                            CA += System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Total devis"].ToString().Replace(".", ","));
                            TotCA += System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Total devis"].ToString().Replace(".", ","));
                            GenCA += System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Total devis"].ToString().Replace(".", ","));
                            DNR+=System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Forfait DNR"].ToString().Replace(".", ","));
                            TotDNR+=System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Forfait DNR"].ToString().Replace(".", ","));
                            GenDNR+=System.Convert.ToDecimal(ds.Tables["Requete"].Rows[countRow]["Forfait DNR"].ToString().Replace(".", ","));
                        }
                    }
                    catch
                    {
                    }
                }

                if (ancienfourn != ds.Tables["Requete"].Rows[countRow]["Nom"].ToString()&&!debut)
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(e.MarginBounds.Left, ypos), new Point(e.MarginBounds.Right, ypos));
                    ypos += 10;
                    e.Graphics.DrawString("Total",
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                    e.Graphics.DrawString(TotEntrees.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 300, ypos);
                    e.Graphics.DrawString(TotSorties.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                    e.Graphics.DrawString(TotDNR.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 400, ypos);
                    e.Graphics.DrawString(TotCA.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 550, ypos);
                    try
                    {
                        Decimal MoyDNRTotal = Decimal.Divide(TotDNR, TotSorties);
                        e.Graphics.DrawString(MoyDNRTotal.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 475, ypos);
                    }
                    catch
                    {
                        e.Graphics.DrawString("0.00",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 475, ypos);
                    }
                    cptEntree = 0;
                    cptSortie = 0;
                    TotEntrees = 0;
                    TotSorties = 0;
                    CA = 0;
                    DNR = 0;
                    TotCA = 0;
                    TotDNR = 0;
                    DNR = 0;
                    MoyDNR = 0;
                    ypos += 30;
                    e.Graphics.DrawString(ancienfourn,
                    new Font("Arial", 8, FontStyle.Bold | FontStyle.Underline), Brushes.Black, e.MarginBounds.Left, ypos);
                    ypos += 20;
                }
                
                countRow++;
                debut = false;
            }
			
			
            if (countRow.Equals(ds.Tables["Requete"].Rows.Count))
            {
                /*e.Graphics.DrawString(ds.Tables["Requete"].Rows[countRow-1]["Code"].ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 150, ypos);
                e.Graphics.DrawString(cptEntree.ToString(),
                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 300, ypos);
                e.Graphics.DrawString(cptSortie.ToString(),
                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                if (cptSortie > 0)
                {
                    e.Graphics.DrawString(CA.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 550, ypos);
                    e.Graphics.DrawString(DNR.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 400, ypos);
                    try
                    {
                        MoyDNR = DNR / System.Convert.ToDecimal(cptSortie);
                        e.Graphics.DrawString(MoyDNR.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 475, ypos);
                        TotMoyDNR += MoyDNR;
                    }
                    catch
                    {
                        e.Graphics.DrawString("0.00",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 475, ypos);
                    }
                }
                else
                {
                    e.Graphics.DrawString("0.00",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 550, ypos);
                    e.Graphics.DrawString("0.00",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 400, ypos);
                    e.Graphics.DrawString("0.00",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 475, ypos);
                }
                cptEntree = 0;
                cptSortie = 0;
                CA = 0;
                DNR = 0;
                ypos += 20;*/

                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(e.MarginBounds.Left, ypos), new Point(e.MarginBounds.Right, ypos));
                ypos += 10;
                        e.Graphics.DrawString("Total général",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                        e.Graphics.DrawString(GenEntrees.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 300, ypos);
                        e.Graphics.DrawString(GenSorties.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                        e.Graphics.DrawString(GenDNR.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 400, ypos);
                        e.Graphics.DrawString(GenCA.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 550, ypos);
                        Decimal GenMoyDNR = GenDNR / System.Convert.ToDecimal(GenSorties);
                        e.Graphics.DrawString(GenMoyDNR.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 475, ypos);
            }
			e.Graphics.DrawString(DateTime.Now.ToLongDateString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom);
			e.Graphics.DrawString("Page "+Page.ToString(),
                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right - 50, e.MarginBounds.Bottom);
            if (countRow < ds.Tables["Requete"].Rows.Count)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			int Error=0;
			try
			{
				System.Convert.ToDateTime(textBox1.Text);
				System.Convert.ToDateTime(textBox2.Text);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
				Error=1;
			}
			if(Error.Equals(0))
			{
				if(radioButton3.Checked)
					Comm.CommandText="SELECT T_fournisseurs.Nom, T_type_machine.Code, T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom, T_type_machine.Code, T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis] HAVING (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#)) ORDER BY T_fournisseurs.Nom";
				else
					Comm.CommandText="SELECT T_fournisseurs.Nom, T_type_machine.Code, T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE t_fournisseurs.nom='"+mtgcComboBox1.Text+"' GROUP BY T_fournisseurs.Nom, T_type_machine.Code, T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis] HAVING (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#)) ORDER BY T_fournisseurs.Nom";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"Activite");
				if(ds.Tables["Activite"].Rows.Count>0)
				{
					printDocument1.Print();
					countRow=0;
					Page=0;
				}
				else
					MessageBox.Show("Aucun enregistrement pour cette période");
			}
			else
				label5.Visible=true;
		}

	}
}
