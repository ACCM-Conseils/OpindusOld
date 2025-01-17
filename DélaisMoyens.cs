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
	/// Description résumée de DélaisMoyens.
	/// </summary>
	public class DélaisMoyens : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button1;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private DataSet ds;
		private OleDbDataAdapter DataAD;
		private OleDbCommand Comm;
		private System.Windows.Forms.Button button4;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.Button button2;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private int Page;
		private int countRow;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private Decimal Moyenne;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DélaisMoyens(int Agence)
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
			Comm.CommandText="SELECT code,nom,[code postal],ville FROM t_fournisseurs ORDER BY nom";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"fournisseurs");
			mtgcComboBox1.SourceDataString=new string[]{"nom","code postal","ville",""};
			mtgcComboBox1.SourceDataTable=ds.Tables["fournisseurs"];
			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("Choisissez...","","",""));
			mtgcComboBox1.SelectedIndex=0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DélaisMoyens));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.button4 = new System.Windows.Forms.Button();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(112, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Edition délais moyens commandes fournisseurs ";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(48, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Début";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(176, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fin";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(256, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(376, 56);
			this.groupBox1.TabIndex = 7;
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
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(128, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Imprimer";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(584, 176);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(48, 48);
			this.button4.TabIndex = 10;
			this.button4.Click += new System.EventHandler(this.button4_Click);
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(256, 136);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(376, 21);
			this.mtgcComboBox1.TabIndex = 11;
			this.mtgcComboBox1.ValueMember = "Code";
			this.mtgcComboBox1.Visible = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(16, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Visualiser";
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			this.printPreviewDialog1.Location = new System.Drawing.Point(290, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
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
			this.oleDbSelectCommand1.CommandText = @"SELECT [Code fournisseur], Comment, [Date Commande], [Date livraison], Edite, [Montant remise], [N° Commande], [Remise fournisseur], Signature, Solde, [Total commande], [Total net Commande], [Total net Commande euros], [total pieces commandees], [Total pieces recues], Valide FROM T_CDE_entete";
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
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(144, 104);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 20);
			this.textBox2.TabIndex = 24;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(24, 104);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 23;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(24, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 25;
			this.label5.Text = "Format de date incorrect";
			this.label5.Visible = false;
			// 
			// DélaisMoyens
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(650, 240);
			this.ControlBox = false;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.mtgcComboBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DélaisMoyens";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Délais Moyens";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			int Error=0;
			Page=0;
			countRow=0;
			dataSet11.Clear();
			DateTime Debut=DateTime.Now;
			DateTime Fin=DateTime.Now;
			try
			{
				label5.Visible=false;
				Debut=System.Convert.ToDateTime(textBox1.Text);
				Fin=System.Convert.ToDateTime(textBox2.Text);
				if(radioButton3.Checked)
                    oleDbSelectCommand1.CommandText = "SELECT T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], Max(T_CDE_Lignes_reception.daterecep) AS MaxDeDate FROM T_fournisseurs INNER JOIN ((T_CDE_entete INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) INNER JOIN T_CDE_Lignes_reception ON T_CDE_Lignes.Id_Ligne = T_CDE_Lignes_reception.Id_Ligne) ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur] GROUP BY T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande] HAVING (((T_CDE_entete.[Date Commande])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_CDE_entete.[Date Commande])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) ORDER BY T_fournisseurs.Nom";
				if(radioButton1.Checked)
				{
					if(mtgcComboBox1.SelectedIndex>0)
                        oleDbSelectCommand1.CommandText = "SELECT T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], Max(T_CDE_Lignes_reception.Daterecep) AS MaxDeDate FROM ((T_fournisseurs INNER JOIN T_CDE_entete ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur]) INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) INNER JOIN T_CDE_Lignes_reception ON T_CDE_Lignes.Id_Ligne = T_CDE_Lignes_reception.Id_Ligne GROUP BY T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande] HAVING (((T_CDE_entete.[Date Commande])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_CDE_entete.[Date Commande])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text + "')";
					else
					{
						MessageBox.Show("Veuillez choisir un fournisseur");
						Error=1;
					}
				}
				if(Error.Equals(0))
				{
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					int TotalNbJours=0;
					foreach(DataRow row in dataSet11.Tables["t_cde_entete"].Rows)
					{
						try
						{
							TimeSpan Diff=System.Convert.ToDateTime(row["MaxDeDate"].ToString())-System.Convert.ToDateTime(row["Date commande"].ToString());
							if(Diff.Days.Equals(0))
								TotalNbJours+=1;
							else
								TotalNbJours+=Diff.Days;
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						
					}
					if(dataSet11.Tables["t_cde_entete"].Rows.Count>0)
					{
						Moyenne=(Decimal)TotalNbJours/(Decimal)dataSet11.Tables["t_cde_entete"].Rows.Count;
						printPreviewDialog1.Document=printDocument1;
						printPreviewDialog1.ShowDialog();
						countRow=0;
						Page=0;
					}
					else
						MessageBox.Show("Aucun enregistrement pour cette periode");
					
				}
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
				label5.Visible=true;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			/*int Error=0;
			Page=0;
			countRow=0;
			dataSet11.Clear();
			DateTime Debut=DateTime.Now;
			DateTime Fin=DateTime.Now;
			try
			{
                label5.Visible = false;
                Debut = System.Convert.ToDateTime(textBox1.Text);
                Fin = System.Convert.ToDateTime(textBox2.Text);
                if (radioButton3.Checked)
                    oleDbSelectCommand1.CommandText = "SELECT T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], Max(T_CDE_Lignes_reception.daterecep) AS MaxDeDate FROM T_fournisseurs INNER JOIN ((T_CDE_entete INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) INNER JOIN T_CDE_Lignes_reception ON T_CDE_Lignes.Id_Ligne = T_CDE_Lignes_reception.Id_Ligne) ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur] GROUP BY T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande] HAVING (((T_CDE_entete.[Date Commande])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_CDE_entete.[Date Commande])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) ORDER BY T_fournisseurs.Nom";
                if (radioButton1.Checked)
                {
                    if (mtgcComboBox1.SelectedIndex > 0)
                        oleDbSelectCommand1.CommandText = "SELECT T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], Max(T_CDE_Lignes_reception.Daterecep) AS MaxDeDate FROM ((T_fournisseurs INNER JOIN T_CDE_entete ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur]) INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) INNER JOIN T_CDE_Lignes_reception ON T_CDE_Lignes.Id_Ligne = T_CDE_Lignes_reception.Id_Ligne GROUP BY T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande] HAVING (((Max(T_CDE_Lignes_reception.Daterecep))>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (Max(T_CDE_Lignes_reception.Daterecep))<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text + "')";
                    else
                    {
                        MessageBox.Show("Veuillez choisir un fournisseur");
                        Error = 1;
                    }
                }
				if(Error.Equals(0))
				{
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);

					}
					Comm.CommandText="SELECT T_CDE_entete.[N° Commande] FROM T_fournisseurs INNER JOIN (T_CDE_entete INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur] WHERE (((T_fournisseurs.Nom)='"+mtgcComboBox1.Text+"') AND ((T_CDE_Lignes.[Date livraison])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_CDE_Lignes.[Date livraison])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#)) GROUP BY T_CDE_entete.[N° Commande]";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"Commandes");
					Comm.CommandText="SELECT T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], T_CDE_Lignes.[Date livraison] FROM T_fournisseurs INNER JOIN (T_CDE_entete INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur] WHERE (((T_fournisseurs.Nom)='"+mtgcComboBox1.Text+"')) GROUP BY T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], T_CDE_Lignes.[Date livraison] HAVING (((T_CDE_Lignes.[Date livraison])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_CDE_Lignes.[Date livraison])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#))";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"Delais");
					int TotalNbJours=0;
					foreach(DataRow row in ds.Tables["Delais"].Rows)
					{
						TimeSpan Diff=System.Convert.ToDateTime(row["Date livraison"].ToString())-System.Convert.ToDateTime(row["Date commande"].ToString());
						if(Diff.Days.Equals(0))
							TotalNbJours+=1;
						else
							TotalNbJours+=Diff.Days;
					}
					if(ds.Tables["Delais"].Rows.Count>0)
					{
						Moyenne=(Decimal)TotalNbJours/(Decimal)ds.Tables["Delais"].Rows.Count;
						printDocument1.Print();
						countRow=0;
						Page=0;
					}
					else
						MessageBox.Show("Aucun enregistrement pour cette période");
				}
			}
			catch(Exception exp)
			{
				label5.Visible=true;
			}*/
            int Error = 0;
            Page = 0;
            countRow = 0;
            dataSet11.Clear();
            DateTime Debut = DateTime.Now;
            DateTime Fin = DateTime.Now;
            try
            {
                label5.Visible = false;
                Debut = System.Convert.ToDateTime(textBox1.Text);
                Fin = System.Convert.ToDateTime(textBox2.Text);
                if (radioButton3.Checked)
                    oleDbSelectCommand1.CommandText = "SELECT T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], Max(T_CDE_Lignes_reception.daterecep) AS MaxDeDate FROM T_fournisseurs INNER JOIN ((T_CDE_entete INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) INNER JOIN T_CDE_Lignes_reception ON T_CDE_Lignes.Id_Ligne = T_CDE_Lignes_reception.Id_Ligne) ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur] GROUP BY T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande] HAVING (((T_CDE_entete.[Date Commande])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_CDE_entete.[Date Commande])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) ORDER BY T_fournisseurs.Nom";
                if (radioButton1.Checked)
                {
                    if (mtgcComboBox1.SelectedIndex > 0)
                        oleDbSelectCommand1.CommandText = "SELECT T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], Max(T_CDE_Lignes_reception.Daterecep) AS MaxDeDate FROM ((T_fournisseurs INNER JOIN T_CDE_entete ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur]) INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) INNER JOIN T_CDE_Lignes_reception ON T_CDE_Lignes.Id_Ligne = T_CDE_Lignes_reception.Id_Ligne GROUP BY T_fournisseurs.Nom, T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande] HAVING (((Max(T_CDE_Lignes_reception.Daterecep))>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (Max(T_CDE_Lignes_reception.Daterecep))<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#)) AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text + "')";
                    else
                    {
                        MessageBox.Show("Veuillez choisir un fournisseur");
                        Error = 1;
                    }
                }
                if (Error.Equals(0))
                {
                    try
                    {
                        oleDbDataAdapter1.Fill(dataSet11);
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine(exp.Message);
                    }
                    int TotalNbJours = 0;
                    foreach (DataRow row in dataSet11.Tables["t_cde_entete"].Rows)
                    {
                        try
                        {
                            TimeSpan Diff = System.Convert.ToDateTime(row["MaxDeDate"].ToString()) - System.Convert.ToDateTime(row["Date commande"].ToString());
                            if (Diff.Days.Equals(0))
                                TotalNbJours += 1;
                            else
                                TotalNbJours += Diff.Days;
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                        }

                    }
                    if (dataSet11.Tables["t_cde_entete"].Rows.Count > 0)
                    {
                        Moyenne = (Decimal)TotalNbJours / (Decimal)dataSet11.Tables["t_cde_entete"].Rows.Count;
                        printDocument1.Print();
                        countRow = 0;
                        Page = 0;
                    }
                    else
                        MessageBox.Show("Aucun enregistrement pour cette periode");

                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                label5.Visible = true;
            }
		
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}


		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Page+=1;
			int ypos=e.MarginBounds.Top;
			if(radioButton3.Checked)
			{
				e.Graphics.DrawString("Délais moyens par commande", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+120, e.MarginBounds.Top);
				ypos+=40;
				e.Graphics.DrawString("Période du "+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+" au "+System.Convert.ToDateTime(textBox2.Text).ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
				ypos+=70;
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
				ypos+=10;
				e.Graphics.DrawString("Fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString("Nb Commandes", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+280, ypos);
				e.Graphics.DrawString("Délais moyen", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
				ypos+=15;
				string ancienFourn=dataSet11.Tables["t_cde_entete"].Rows[0]["Nom"].ToString();
				int cpt=0;
				int NbrJours=0;
				TimeSpan Diff= new TimeSpan(0,0,0,0,0);
				while(ypos<e.MarginBounds.Height&&(countRow<dataSet11.Tables["t_cde_entete"].Rows.Count)&&(dataSet11.Tables["t_cde_entete"].Rows.Count>0))
				{
					if(ancienFourn==dataSet11.Tables["t_cde_entete"].Rows[countRow]["Nom"].ToString())
					{
						TimeSpan Difference=System.Convert.ToDateTime(dataSet11.Tables["t_cde_entete"].Rows[countRow]["MaxDeDate"].ToString())-System.Convert.ToDateTime(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Date commande"].ToString());
						NbrJours+=Difference.Days;	
						cpt++;
					}
					else
					{
						e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[countRow-1]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						if(cpt.Equals(0))
							cpt=1;
						Decimal Moy=System.Convert.ToDecimal(NbrJours)/System.Convert.ToDecimal(cpt);
						e.Graphics.DrawString(cpt.ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
						e.Graphics.DrawString(Moy.ToString("0.00"), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
						ypos+=15;
						NbrJours=0;
						cpt=0;
						ancienFourn=dataSet11.Tables["t_cde_entete"].Rows[countRow]["Nom"].ToString();
						TimeSpan Difference=System.Convert.ToDateTime(dataSet11.Tables["t_cde_entete"].Rows[countRow]["MaxDeDate"].ToString())-System.Convert.ToDateTime(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Date commande"].ToString());
						NbrJours+=Difference.Days;
						cpt++;
					}
					countRow+=1;
				}
			}
			else if(radioButton1.Checked)
			{
				e.Graphics.DrawString("Délais moyens par commande", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+120, e.MarginBounds.Top);
				ypos+=40;
				e.Graphics.DrawString("Période du "+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+" au "+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
				ypos+=40;
				e.Graphics.DrawString("Fournisseur : "+mtgcComboBox1.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=30;
				e.Graphics.DrawString("Nombre de commandes : "+dataSet11.Tables["t_cde_entete"].Rows.Count.ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=30;
				e.Graphics.DrawString("Délai moyen global : "+Moyenne.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=40;
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
				ypos+=40;
				e.Graphics.DrawString("N° Commande", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString("Délai moyen", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
				ypos+=40;
				int NumCommande=0;
				int NbLignes=0;
				Decimal TotalJours=0;
				bool Debut=true;
				Decimal MoyenneJours=0;
				TimeSpan Diff=new TimeSpan(0,0,0,0,0);
				while(ypos<e.MarginBounds.Height&&(countRow<dataSet11.Tables["t_cde_entete"].Rows.Count)&&(dataSet11.Tables["t_cde_entete"].Rows.Count>0))
				{
					if(NumCommande!=System.Convert.ToInt32(dataSet11.Tables["t_cde_entete"].Rows[countRow]["N° commande"].ToString()))
					{
						Diff=System.Convert.ToDateTime(dataSet11.Tables["t_cde_entete"].Rows[countRow]["MaxDeDate"].ToString())-System.Convert.ToDateTime(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Date commande"].ToString());
						if(Diff.Days.Equals(0))
							TotalJours+=1;
						else
							TotalJours+=Diff.Days;
						NbLignes++;
						MoyenneJours=(Decimal)TotalJours/(Decimal)NbLignes;
						e.Graphics.DrawString(dataSet11.Tables["T_CDE_entete"].Rows[countRow]["N° Commande"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString(MoyenneJours.ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+220, ypos);
						ypos+=15;
						TotalJours=0;
						NbLignes=0;
						NumCommande=System.Convert.ToInt32(dataSet11.Tables["t_cde_entete"].Rows[countRow]["N° commande"].ToString());
					}
					else
					{
						Diff=System.Convert.ToDateTime(dataSet11.Tables["t_cde_entete"].Rows[countRow]["MaxDeDate"].ToString())-System.Convert.ToDateTime(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Date commande"].ToString());
						if(Diff.Days.Equals(0))
							TotalJours+=1;
						else
							TotalJours+=Diff.Days;
						NbLignes++;
					}
					countRow+=1;
				}
			}
			e.Graphics.DrawString(DateTime.Now.ToLongDateString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom-50);
			e.Graphics.DrawString("Page "+Page.ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-50, e.MarginBounds.Bottom-50);
			if(countRow<dataSet11.Tables["t_CDE_entete"].Rows.Count)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
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

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked)
				mtgcComboBox1.Visible=true;
			else
				mtgcComboBox1.Visible=false;
		}

	}
}
