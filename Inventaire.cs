using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Opindus
{
	/// <summary>
	/// Description résumée de Inventaire.
	/// </summary>
	public class Inventaire : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.Button button3;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private int Agence;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private int Page;
		private int countRow;
		private System.Windows.Forms.Button button4;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.Label label5;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private Opindus.DataSet2 dataSet21;
		private Decimal TotalFourn;
		private Decimal TotalGeneral;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Inventaire(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			Page=0;
			countRow=0;
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
			TotalFourn=0;
			TotalGeneral=0;
			printDocument1.DefaultPageSettings.Landscape=true;
			printDocument1.DefaultPageSettings.Margins.Bottom=50;
			printPreviewDialog1.SetBounds(0,0,800,550);
			oleDbDataAdapter2.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_fournisseurs"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["nom"].ToString(),"","",""));
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Inventaire));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.button3 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.button4 = new System.Windows.Forms.Button();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.dataSet21 = new Opindus.DataSet2();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(80, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Inventaire";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(8, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(312, 256);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lavender;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(177, 222);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Impression";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lavender;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(8, 220);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Visualisation";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.mtgcComboBox1);
			this.groupBox4.Controls.Add(this.radioButton4);
			this.groupBox4.Controls.Add(this.radioButton3);
			this.groupBox4.Location = new System.Drawing.Point(8, 112);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(296, 96);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Type d\'édition";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "Fournisseur";
			this.label5.Visible = false;
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 1;
			this.mtgcComboBox1.ColumnWidth = "121";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 141;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = false;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(17, 64);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(263, 21);
			this.mtgcComboBox1.TabIndex = 2;
			this.mtgcComboBox1.Visible = false;
			// 
			// radioButton4
			// 
			this.radioButton4.Checked = true;
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(128, 24);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 1;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Totalité";
			// 
			// radioButton3
			// 
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(16, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 0;
			this.radioButton3.Text = "Sélection";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radioButton2);
			this.groupBox3.Controls.Add(this.radioButton1);
			this.groupBox3.Location = new System.Drawing.Point(8, 48);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(296, 56);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Type d\'inventaire";
			// 
			// radioButton2
			// 
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(128, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Inventaire > 0";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(16, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Inventaire total";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(72, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Inventaire instantané";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(72, 328);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Inventaire historique";
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(56, 360);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 22);
			this.comboBox1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 360);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Date";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.radioButton5);
			this.groupBox5.Controls.Add(this.radioButton6);
			this.groupBox5.Location = new System.Drawing.Point(8, 392);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(312, 56);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Type d\'édition";
			// 
			// radioButton5
			// 
			this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton5.Location = new System.Drawing.Point(128, 24);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.TabIndex = 1;
			this.radioButton5.Text = "Totalité";
			// 
			// radioButton6
			// 
			this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton6.Location = new System.Drawing.Point(16, 24);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.TabIndex = 0;
			this.radioButton6.Text = "Mouvement";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lavender;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(8, 472);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Edition";
			this.button3.Click += new System.EventHandler(this.button3_Click);
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
																										new System.Data.Common.DataTableMapping("Table", "T_pieces_detachees", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("Cause Principale", "Cause Principale"),
																																																							  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							  new System.Data.Common.DataColumnMapping("Code Famille", "Code Famille"),
																																																							  new System.Data.Common.DataColumnMapping("Code Fournisseur Principal", "Code Fournisseur Principal"),
																																																							  new System.Data.Common.DataColumnMapping("Code Unite", "Code Unite"),
																																																							  new System.Data.Common.DataColumnMapping("Code_1", "Code_1"),
																																																							  new System.Data.Common.DataColumnMapping("Correspondance Stock", "Correspondance Stock"),
																																																							  new System.Data.Common.DataColumnMapping("Date Dernier Mouvement", "Date Dernier Mouvement"),
																																																							  new System.Data.Common.DataColumnMapping("Date MAJ Tarif", "Date MAJ Tarif"),
																																																							  new System.Data.Common.DataColumnMapping("Delai Livraison", "Delai Livraison"),
																																																							  new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																							  new System.Data.Common.DataColumnMapping("Identificateur", "Identificateur"),
																																																							  new System.Data.Common.DataColumnMapping("pre_devis", "pre_devis"),
																																																							  new System.Data.Common.DataColumnMapping("Prix Achat Brut", "Prix Achat Brut"),
																																																							  new System.Data.Common.DataColumnMapping("Prix Achat Net", "Prix Achat Net"),
																																																							  new System.Data.Common.DataColumnMapping("Prix Vente", "Prix Vente"),
																																																							  new System.Data.Common.DataColumnMapping("Quantite Commande", "Quantite Commande"),
																																																							  new System.Data.Common.DataColumnMapping("Quantite Disponible", "Quantite Disponible"),
																																																							  new System.Data.Common.DataColumnMapping("Quantite Maxi", "Quantite Maxi"),
																																																							  new System.Data.Common.DataColumnMapping("Quantite Minimum", "Quantite Minimum"),
																																																							  new System.Data.Common.DataColumnMapping("Quantite Reserve", "Quantite Reserve"),
																																																							  new System.Data.Common.DataColumnMapping("Quantite Stock", "Quantite Stock"),
																																																							  new System.Data.Common.DataColumnMapping("Quantite stock theorique", "Quantite stock theorique"),
																																																							  new System.Data.Common.DataColumnMapping("Stock Alerte", "Stock Alerte")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_pieces_detachees WHERE (Identificateur = ?) AND ([Cause Principale]" +
				" = ? OR ? IS NULL AND [Cause Principale] IS NULL) AND (Code = ? OR ? IS NULL AND" +
				" Code IS NULL) AND ([Code Famille] = ? OR ? IS NULL AND [Code Famille] IS NULL) " +
				"AND ([Code Fournisseur Principal] = ? OR ? IS NULL AND [Code Fournisseur Princip" +
				"al] IS NULL) AND ([Code Unite] = ? OR ? IS NULL AND [Code Unite] IS NULL) AND (C" +
				"ode_1 = ? OR ? IS NULL AND Code_1 IS NULL) AND ([Correspondance Stock] = ? OR ? " +
				"IS NULL AND [Correspondance Stock] IS NULL) AND ([Date Dernier Mouvement] = ? OR" +
				" ? IS NULL AND [Date Dernier Mouvement] IS NULL) AND ([Date MAJ Tarif] = ? OR ? " +
				"IS NULL AND [Date MAJ Tarif] IS NULL) AND ([Delai Livraison] = ? OR ? IS NULL AN" +
				"D [Delai Livraison] IS NULL) AND (Designation = ? OR ? IS NULL AND Designation I" +
				"S NULL) AND ([Prix Achat Brut] = ? OR ? IS NULL AND [Prix Achat Brut] IS NULL) A" +
				"ND ([Prix Achat Net] = ? OR ? IS NULL AND [Prix Achat Net] IS NULL) AND ([Prix V" +
				"ente] = ? OR ? IS NULL AND [Prix Vente] IS NULL) AND ([Quantite Commande] = ? OR" +
				" ? IS NULL AND [Quantite Commande] IS NULL) AND ([Quantite Disponible] = ? OR ? " +
				"IS NULL AND [Quantite Disponible] IS NULL) AND ([Quantite Maxi] = ? OR ? IS NULL" +
				" AND [Quantite Maxi] IS NULL) AND ([Quantite Minimum] = ? OR ? IS NULL AND [Quan" +
				"tite Minimum] IS NULL) AND ([Quantite Reserve] = ? OR ? IS NULL AND [Quantite Re" +
				"serve] IS NULL) AND ([Quantite Stock] = ? OR ? IS NULL AND [Quantite Stock] IS N" +
				"ULL) AND ([Quantite stock theorique] = ? OR ? IS NULL AND [Quantite stock theori" +
				"que] IS NULL) AND ([Stock Alerte] = ? OR ? IS NULL AND [Stock Alerte] IS NULL) A" +
				"ND (pre_devis = ?)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Identificateur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Identificateur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_Principale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Unite1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_11", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Vente1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "pre_devis", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO T_pieces_detachees([Cause Principale], Code, [Code Famille], [Code Fournisseur Principal], [Code Unite], Code_1, [Correspondance Stock], [Date Dernier Mouvement], [Date MAJ Tarif], [Delai Livraison], Designation, Identificateur, pre_devis, [Prix Achat Brut], [Prix Achat Net], [Prix Vente], [Quantite Commande], [Quantite Disponible], [Quantite Maxi], [Quantite Minimum], [Quantite Reserve], [Quantite Stock], [Quantite stock theorique], [Stock Alerte]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, "Cause Principale"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 18, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, "Code Famille"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, "Code Fournisseur Principal"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, "Code Unite"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, "Code_1"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, "Correspondance Stock"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Mouvement"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Tarif"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai Livraison"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Identificateur", System.Data.OleDb.OleDbType.Integer, 0, "Identificateur"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, "pre_devis"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Brut"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Net"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, "Prix Vente"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, "Quantite Commande"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, "Quantite Disponible"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Quantite Maxi"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, "Quantite Minimum"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, "Quantite Reserve"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, "Quantite Stock"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, "Quantite stock theorique"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, "Stock Alerte"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT [Cause Principale], Code, [Code Famille], [Code Fournisseur Principal], [Code Unite], Code_1, [Correspondance Stock], [Date Dernier Mouvement], [Date MAJ Tarif], [Delai Livraison], Designation, Identificateur, pre_devis, [Prix Achat Brut], [Prix Achat Net], [Prix Vente], [Quantite Commande], [Quantite Disponible], [Quantite Maxi], [Quantite Minimum], [Quantite Reserve], [Quantite Stock], [Quantite stock theorique], [Stock Alerte] FROM T_pieces_detachees";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_pieces_detachees SET [Cause Principale] = ?, Code = ?, [Code Famille] = " +
				"?, [Code Fournisseur Principal] = ?, [Code Unite] = ?, Code_1 = ?, [Correspondan" +
				"ce Stock] = ?, [Date Dernier Mouvement] = ?, [Date MAJ Tarif] = ?, [Delai Livrai" +
				"son] = ?, Designation = ?, Identificateur = ?, pre_devis = ?, [Prix Achat Brut] " +
				"= ?, [Prix Achat Net] = ?, [Prix Vente] = ?, [Quantite Commande] = ?, [Quantite " +
				"Disponible] = ?, [Quantite Maxi] = ?, [Quantite Minimum] = ?, [Quantite Reserve]" +
				" = ?, [Quantite Stock] = ?, [Quantite stock theorique] = ?, [Stock Alerte] = ? W" +
				"HERE (Identificateur = ?) AND ([Cause Principale] = ? OR ? IS NULL AND [Cause Pr" +
				"incipale] IS NULL) AND (Code = ? OR ? IS NULL AND Code IS NULL) AND ([Code Famil" +
				"le] = ? OR ? IS NULL AND [Code Famille] IS NULL) AND ([Code Fournisseur Principa" +
				"l] = ? OR ? IS NULL AND [Code Fournisseur Principal] IS NULL) AND ([Code Unite] " +
				"= ? OR ? IS NULL AND [Code Unite] IS NULL) AND (Code_1 = ? OR ? IS NULL AND Code" +
				"_1 IS NULL) AND ([Correspondance Stock] = ? OR ? IS NULL AND [Correspondance Sto" +
				"ck] IS NULL) AND ([Date Dernier Mouvement] = ? OR ? IS NULL AND [Date Dernier Mo" +
				"uvement] IS NULL) AND ([Date MAJ Tarif] = ? OR ? IS NULL AND [Date MAJ Tarif] IS" +
				" NULL) AND ([Delai Livraison] = ? OR ? IS NULL AND [Delai Livraison] IS NULL) AN" +
				"D (Designation = ? OR ? IS NULL AND Designation IS NULL) AND ([Prix Achat Brut] " +
				"= ? OR ? IS NULL AND [Prix Achat Brut] IS NULL) AND ([Prix Achat Net] = ? OR ? I" +
				"S NULL AND [Prix Achat Net] IS NULL) AND ([Prix Vente] = ? OR ? IS NULL AND [Pri" +
				"x Vente] IS NULL) AND ([Quantite Commande] = ? OR ? IS NULL AND [Quantite Comman" +
				"de] IS NULL) AND ([Quantite Disponible] = ? OR ? IS NULL AND [Quantite Disponibl" +
				"e] IS NULL) AND ([Quantite Maxi] = ? OR ? IS NULL AND [Quantite Maxi] IS NULL) A" +
				"ND ([Quantite Minimum] = ? OR ? IS NULL AND [Quantite Minimum] IS NULL) AND ([Qu" +
				"antite Reserve] = ? OR ? IS NULL AND [Quantite Reserve] IS NULL) AND ([Quantite " +
				"Stock] = ? OR ? IS NULL AND [Quantite Stock] IS NULL) AND ([Quantite stock theor" +
				"ique] = ? OR ? IS NULL AND [Quantite stock theorique] IS NULL) AND ([Stock Alert" +
				"e] = ? OR ? IS NULL AND [Stock Alerte] IS NULL) AND (pre_devis = ?)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, "Cause Principale"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 18, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, "Code Famille"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, "Code Fournisseur Principal"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, "Code Unite"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, "Code_1"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, "Correspondance Stock"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Mouvement"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Tarif"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai Livraison"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Identificateur", System.Data.OleDb.OleDbType.Integer, 0, "Identificateur"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, "pre_devis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Brut"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Net"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, "Prix Vente"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, "Quantite Commande"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, "Quantite Disponible"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Quantite Maxi"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, "Quantite Minimum"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, "Quantite Reserve"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, "Quantite Stock"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, "Quantite stock theorique"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, "Stock Alerte"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Identificateur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Identificateur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_Principale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Unite1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_11", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Vente1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "pre_devis", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
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
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Lavender;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(192, 360);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 22);
			this.button4.TabIndex = 7;
			this.button4.Text = "Vider l\'historique";
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_fournisseurs", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																						  new System.Data.Common.DataColumnMapping("Code", "Code")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = "DELETE FROM T_fournisseurs WHERE (Code = ?) AND (Nom = ? OR ? IS NULL AND Nom IS " +
				"NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO T_fournisseurs(Nom, Code) VALUES (?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Nom, Code FROM T_fournisseurs ORDER BY Nom";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = "UPDATE T_fournisseurs SET Nom = ?, Code = ? WHERE (Code = ?) AND (Nom = ? OR ? IS" +
				" NULL AND Nom IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet21
			// 
			this.dataSet21.DataSetName = "DataSet2";
			this.dataSet21.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(272, 456);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 17;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click_1);
			// 
			// Inventaire
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(328, 512);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "Inventaire";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edition de l\'inventaire";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TotalGeneral=0;
			TotalFourn=0;
			countRow=0;
			Page=0;
			if(mtgcComboBox1.SelectedIndex>=0||radioButton4.Checked)
			{
				dataSet11.Tables["t_pieces_detachees"].Clear();
				if(radioButton1.Checked&&radioButton4.Checked)
				{
					oleDbDataAdapter1.SelectCommand.CommandText="SELECT T_pieces_detachees.*, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY T_fournisseurs.Nom, t_pieces_detachees.code";
					oleDbDataAdapter1.Fill(dataSet11);
					printPreviewDialog1.Document=printDocument1;
					printPreviewDialog1.ShowDialog();
				}
				else if(radioButton2.Checked&&radioButton4.Checked)
				{
					oleDbDataAdapter1.SelectCommand.CommandText="SELECT T_pieces_detachees.*, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE t_pieces_detachees.[Quantite stock]>0 ORDER BY T_fournisseurs.Nom, t_pieces_detachees.code";
					oleDbDataAdapter1.Fill(dataSet11);
					printPreviewDialog1.Document=printDocument1;
					printPreviewDialog1.ShowDialog();
				}
				else if(radioButton1.Checked&&radioButton3.Checked)
				{
					oleDbDataAdapter1.SelectCommand.CommandText="SELECT T_pieces_detachees.*, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.nom='"+mtgcComboBox1.Text+"'ORDER BY T_fournisseurs.Nom, t_pieces_detachees.code";
					oleDbDataAdapter1.Fill(dataSet11);
					printPreviewDialog1.Document=printDocument1;
					printPreviewDialog1.ShowDialog();
				}
				else if(radioButton2.Checked&&radioButton3.Checked)
				{
					oleDbDataAdapter1.SelectCommand.CommandText="SELECT T_pieces_detachees.*, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE t_pieces_detachees.[Quantite stock]>0 AND T_fournisseurs.nom='"+mtgcComboBox1.Text+"' ORDER BY T_fournisseurs.Nom, t_pieces_detachees.code";
					oleDbDataAdapter1.Fill(dataSet11);
					printPreviewDialog1.Document=printDocument1;
					printPreviewDialog1.ShowDialog();
				}
				
				dataSet11.Clear();
			}
			else
				MessageBox.Show("Veuillez selectionner un fournisseur");
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			
			e.Graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			int ypos=50;
			Page+=1;
			e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=5;
			e.Graphics.DrawString("Inventaire total", 
				new Font("Arial", 24, FontStyle.Bold), Brushes.Black, e.PageBounds.Width/2-100, ypos);
			ypos+=40;
			e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=20;
			e.Graphics.DrawString("Code pièce", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Ancienne référence", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+150, ypos); 
			e.Graphics.DrawString("Désignation", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+300, ypos); 
			e.Graphics.DrawString("Prix achat brut", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+550, ypos); 
			e.Graphics.DrawString("Prix achat net", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+650, ypos); 
			e.Graphics.DrawString("Quantité stock", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+750, ypos); 
			e.Graphics.DrawString("Valorisation", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+850, ypos); 
			ypos+=20;
			e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			string ancienfourn=null;
			bool debut=true;
			while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_pieces_detachees"].Rows.Count)
			{
				if(!debut)
				{
					ancienfourn=dataSet11.Tables["t_pieces_detachees"].Rows[countRow-1]["Nom"].ToString();
				}
				if(ancienfourn!=dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Nom"].ToString())
				{
					if(!debut)
					{
						ypos+=25;
						e.Graphics.DrawString("Total", 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+770, ypos);
						e.Graphics.DrawString(TotalFourn.ToString("c"), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos);
						TotalFourn=0;
					}
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=5;
					e.Graphics.DrawString(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Nom"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+400, ypos); 
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					
				}
				debut=false;
				ypos+=15;
				e.Graphics.DrawString(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Code"].ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Code_1"].ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos);
				e.Graphics.DrawString(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Designation"].ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
				if(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Prix achat brut"].ToString().Length>0)
				{
					e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Prix achat brut"].ToString()).ToString("C"), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+550, ypos);
				}
				else
				{
					e.Graphics.DrawString("0,00 €", 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+550, ypos);
				}
				Decimal PANet=0;
				Decimal Qte=0;
				Decimal Total=0;
				if(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Prix achat net"].ToString().Length>0)
				{
					try
					{
						e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Prix achat net"].ToString()).ToString("C"), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+650, ypos);
						PANet=System.Convert.ToDecimal(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Prix achat net"].ToString());
					}
					catch
					{
						e.Graphics.DrawString("0,00 €", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+650, ypos);
						PANet=0;
					}

				}
				else
				{
					e.Graphics.DrawString("0,00 €", 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+650, ypos);
					PANet=0;
				}
				if(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Quantite stock"].ToString().Length>0)
				{
					try
					{
						e.Graphics.DrawString(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Quantite stock"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+780, ypos);
						Qte=System.Convert.ToDecimal(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Quantite stock"].ToString());
					}
					catch
					{
						MessageBox.Show(dataSet11.Tables["t_pieces_detachees"].Rows[countRow]["Quantite stock"].ToString());
					}
				}
				else
				{
					e.Graphics.DrawString("0", 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+780, ypos);
				}
				Total=PANet*Qte;
				TotalFourn+=Total;
				TotalGeneral+=Total;
				e.Graphics.DrawString(Total.ToString("c"), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+850, ypos);
				if(countRow.Equals(dataSet11.Tables["t_pieces_detachees"].Rows.Count-1))
				{
					ypos+=25;
					e.Graphics.DrawString("Total ", 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+770, ypos);
					e.Graphics.DrawString(TotalFourn.ToString("c"), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos);
					TotalFourn=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=20;
					e.Graphics.DrawString("Total général", 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+770, ypos);
					e.Graphics.DrawString(TotalGeneral.ToString("c"), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos);
				}
				countRow+=1;
			}
			ypos+=20;
			e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom-50);
			if(countRow<dataSet11.Tables["t_pieces_detachees"].Rows.Count)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				TotalGeneral=0;
				TotalFourn=0;
				countRow=0;
				Page=0;
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked.Equals(true))
			{
				mtgcComboBox1.Visible=true;
				label5.Visible=true;
			}
			else
			{
				mtgcComboBox1.Visible=false;
				label5.Visible=false;
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button5_Click_1(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
            TotalGeneral = 0;
            TotalFourn = 0;
            countRow = 0;
            Page = 0;
            if (mtgcComboBox1.SelectedIndex >= 0 || radioButton4.Checked)
            {
                dataSet11.Tables["t_pieces_detachees"].Clear();
                if (radioButton1.Checked && radioButton4.Checked)
                {
                    oleDbDataAdapter1.SelectCommand.CommandText = "SELECT T_pieces_detachees.*, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY T_fournisseurs.Nom, t_pieces_detachees.code";
                    oleDbDataAdapter1.Fill(dataSet11);
                    printDocument1.Print();
                }
                else if (radioButton2.Checked && radioButton4.Checked)
                {
                    oleDbDataAdapter1.SelectCommand.CommandText = "SELECT T_pieces_detachees.*, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE t_pieces_detachees.[Quantite stock]>0 ORDER BY T_fournisseurs.Nom, t_pieces_detachees.code";
                    oleDbDataAdapter1.Fill(dataSet11);
                    printDocument1.Print();
                }
                else if (radioButton1.Checked && radioButton3.Checked)
                {
                    oleDbDataAdapter1.SelectCommand.CommandText = "SELECT T_pieces_detachees.*, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.nom='" + mtgcComboBox1.Text + "'ORDER BY T_fournisseurs.Nom, t_pieces_detachees.code";
                    oleDbDataAdapter1.Fill(dataSet11);
                    printDocument1.Print();
                }
                else if (radioButton2.Checked && radioButton3.Checked)
                {
                    oleDbDataAdapter1.SelectCommand.CommandText = "SELECT T_pieces_detachees.*, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE t_pieces_detachees.[Quantite stock]>0 AND T_fournisseurs.nom='" + mtgcComboBox1.Text + "' ORDER BY T_fournisseurs.Nom, t_pieces_detachees.code";
                    oleDbDataAdapter1.Fill(dataSet11);
                    printDocument1.Print();
                }

                dataSet11.Clear();
            }
            else
                MessageBox.Show("Veuillez selectionner un fournisseur");
		}
	}
}
