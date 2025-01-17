using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Opindus
{
	/// <summary>
	/// Description résumée de StatsGestion.
	/// </summary>
	public class StatsGestion : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton11;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private MTGCComboBox mtgcComboBox1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private MTGCComboBox mtgcComboBox2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Windows.Forms.RadioButton radioButton1;
		private OleDbCommand Comm;
		private System.Windows.Forms.Label label5;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private int Nb=0;
		private int Total=0;
		private int Crea=0;
		private int Sorties=0;
		private int NbRepa=0;
		private int NbType=0;
		private int NbFourn=0;
		private int NbRepar=0;
		private int NbRef=0;
		private int NbLignes=0;
		private int NbPieces=0;
		private int nbParcConnuMachines=0;
		private int NbTypesConnus=0;
		private int NbFournConnus=0;
		private int FinDePeriode=0;
		private int countRow;
		private int Page;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private OleDbDataAdapter DataAd;
		private DataSet ds;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StatsGestion(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			countRow=0;
			Page=0;
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
			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAd=new OleDbDataAdapter();
			ds=new DataSet();
			InitializeData();
			mtgcComboBox1.Focus();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(StatsGestion));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.radioButton11 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.button5 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(456, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Edition statistiques gestion client";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(432, 32);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(144, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Choix de la période";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.mtgcComboBox2);
			this.groupBox2.Controls.Add(this.radioButton11);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Location = new System.Drawing.Point(8, 96);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(432, 208);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(16, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(224, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Format de date incorrect";
			this.label5.Visible = false;
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(8, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 12;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Année :";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
			this.mtgcComboBox2.Location = new System.Drawing.Point(16, 56);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(121, 21);
			this.mtgcComboBox2.TabIndex = 11;
			// 
			// radioButton11
			// 
			this.radioButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton11.ForeColor = System.Drawing.Color.Black;
			this.radioButton11.Location = new System.Drawing.Point(8, 96);
			this.radioButton11.Name = "radioButton11";
			this.radioButton11.Size = new System.Drawing.Size(184, 24);
			this.radioButton11.TabIndex = 10;
			this.radioButton11.Text = "Libre choix de date :";
			this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(48, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Début";
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(184, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Fin";
			this.label3.Visible = false;
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(144, 160);
			this.textBox4.MaxLength = 8;
			this.textBox4.Name = "textBox4";
			this.textBox4.TabIndex = 1;
			this.textBox4.Text = "";
			this.textBox4.Visible = false;
			this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(16, 160);
			this.textBox3.MaxLength = 8;
			this.textBox3.Name = "textBox3";
			this.textBox3.TabIndex = 0;
			this.textBox3.Text = "";
			this.textBox3.Visible = false;
			this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Location = new System.Drawing.Point(8, 296);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(432, 32);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(136, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Client selectionné";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(8, 328);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(432, 20);
			this.textBox2.TabIndex = 0;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(8, 400);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Visualiser";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 4;
			this.mtgcComboBox1.ColumnWidth = "200;50;50;50";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 370;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = false;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(8, 40);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(432, 21);
			this.mtgcComboBox1.TabIndex = 8;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_clients", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																					 new System.Data.Common.DataColumnMapping("Ident", "Ident"),
																																																					 new System.Data.Common.DataColumnMapping("Groupe", "Groupe"),
																																																					 new System.Data.Common.DataColumnMapping("Usine", "Usine")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_clients WHERE (Ident = ?) AND (Groupe = ? OR ? IS NULL AND Groupe I" +
				"S NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Usine = ? OR ? IS NULL A" +
				"ND Usine IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_clients(Nom, Ident, Groupe, Usine) VALUES (?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Nom, Ident, Groupe, Usine FROM T_clients ORDER BY Nom";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_clients SET Nom = ?, Ident = ?, Groupe = ?, Usine = ? WHERE (Ident = ?) " +
				"AND (Groupe = ? OR ? IS NULL AND Groupe IS NULL) AND (Nom = ? OR ? IS NULL AND N" +
				"om IS NULL) AND (Usine = ? OR ? IS NULL AND Usine IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
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
			this.printPreviewDialog1.Location = new System.Drawing.Point(540, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(8, 360);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(120, 24);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Edition synthèse";
			// 
			// radioButton3
			// 
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(144, 360);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(136, 24);
			this.radioButton3.TabIndex = 10;
			this.radioButton3.Text = "Edition parc période";
			// 
			// radioButton4
			// 
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(304, 360);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(136, 24);
			this.radioButton4.TabIndex = 11;
			this.radioButton4.Text = "Edition dossier";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(392, 384);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 17;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(120, 400);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 18;
			this.button2.Text = "Imprimer";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// StatsGestion
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(450, 440);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.mtgcComboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "StatsGestion";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edition fiche commerciale";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.T_clients.Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["nom"].ToString(),row["Ident"].ToString(),row["Groupe"].ToString(),row["Usine"].ToString()));
			}
			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("Choisissez...","","",""));
			mtgcComboBox1.SelectedIndex=0;
			int Année=1997;
			for(;Année<=DateTime.Now.Year;Année++)
			{
				mtgcComboBox2.Items.Add(new MTGCComboBoxItem(Année.ToString(),"","",""));
			}
			mtgcComboBox2.SelectedIndex=mtgcComboBox2.Items.Count-1;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
			
		}

		private void textBox3_Enter(object sender, System.EventArgs e)
		{
			ChoixDate WinDate = new ChoixDate();
			WinDate.ShowDialog();
			textBox3.Text=WinDate.GetDate.ToShortDateString();
		}

		private void textBox4_Enter(object sender, System.EventArgs e)
		{
			ChoixDate WinDate = new ChoixDate();
			WinDate.ShowDialog();
			textBox4.Text=WinDate.GetDate.ToShortDateString();
		}

		private void radioButton11_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton11.Checked)
			{
				label2.Visible=true;
				label3.Visible=true;
				textBox3.Visible=true;
				textBox4.Visible=true;
			}
			else
			{
				label2.Visible=false;
				label3.Visible=false;
				textBox3.Visible=false;
				textBox4.Visible=false;
			}
		}

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			textBox2.Text=mtgcComboBox1.Text;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			countRow=0;
			Page=0;
			if(mtgcComboBox1.SelectedIndex>0)
			{
				if(radioButton1.Checked&&textBox2.TextLength>0)
				{
					if(radioButton2.Checked)
					{
						oleDbConnection1.Open();
						
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] GROUP BY T_clients.Nom HAVING (((T_clients.Nom)='"+textBox2.Text+"'))";
						try
						{
							Nb=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Nb=0;
						}

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], Min(T_devis_entete.Date) AS MinDeDate FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_parc_machine.[Date reforme] HAVING (((Min(T_devis_entete.Date))<#"+"01/01/"+mtgcComboBox2.Text+"#) AND ((T_parc_machine.[Date reforme]) Is Null))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Total=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Total=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_clients.Nom, T_parc_machine.[Code machine Opindus] HAVING (((T_clients.Nom)='"+textBox2.Text+"') AND ((Min(T_devis_entete.Date))>=#01/01/"+mtgcComboBox2.Text+"# And (Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Crea=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Crea=0;
						}
						ds.Clear();
				
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme])>=#01/01/"+mtgcComboBox2.Text+"# And (T_parc_machine.[Date reforme])<=#12/31/"+mtgcComboBox2.Text+"#))"; 
				
						try
						{
							Sorties=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Sorties=0;
						}

						FinDePeriode=Total+Crea-Sorties;

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Code machine Opindus]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRepa=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Type machine]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbType=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbType=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN (T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_type_machine.Fournisseur";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFourn=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFourn=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_devis_entete.Niveau HAVING (((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbRepar=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}

						Comm.CommandText="SELECT DISTINCT (t_devis_lignes.[Code piece]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_devis_entete.Niveau, t_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)<8))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRef=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRef=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(t_devis_lignes.idLigne) AS CompteDeidLigne FROM T_clients INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_clients.Ident = T_devis_entete.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbLignes=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbLignes=0;
						}

						Comm.CommandText="SELECT Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_clients INNER JOIN T_devis_entete ON T_clients.Ident = T_devis_entete.[Code Client]) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";

						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbPieces=System.Convert.ToInt32(ds.Tables["t_devis_entete"].Rows[0]["SommeDeQuantite"].ToString());
						}
						catch(Exception exp)
						{
							NbPieces=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_devis_entete.Niveau HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							nbParcConnuMachines=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							nbParcConnuMachines=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_parc_machine.[Type machine] HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbTypesConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbTypesConnus=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_type_machine.Fournisseur HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFournConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFournConnus=0;
						}
						ds.Clear();
						oleDbConnection1.Close();
					}
					else if(radioButton3.Checked)
					{
						Comm.CommandText="SELECT T_fournisseurs.Nom, T_type_machine.Code, T_parc_machine.[Date reforme] FROM ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date entree reelle])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_fournisseurs.Nom, T_type_machine.Code, T_parc_machine.[Date reforme] HAVING (((T_parc_machine.[Date reforme]) Is Null))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
					}
					else if(radioButton4.Checked)
					{
						oleDbConnection1.Open();
						
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] GROUP BY T_clients.Nom HAVING (((T_clients.Nom)='"+textBox2.Text+"'))";
						try
						{
							Nb=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Nb=0;
						}

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], Min(T_devis_entete.Date) AS MinDeDate FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_parc_machine.[Date reforme] HAVING (((Min(T_devis_entete.Date))<#"+"01/01/"+mtgcComboBox2.Text+"#) AND ((T_parc_machine.[Date reforme]) Is Null))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Total=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Total=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_clients.Nom, T_parc_machine.[Code machine Opindus] HAVING (((T_clients.Nom)='"+textBox2.Text+"') AND ((Min(T_devis_entete.Date))>=#01/01/"+mtgcComboBox2.Text+"# And (Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Crea=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Crea=0;
						}
						ds.Clear();
				
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme])>=#01/01/"+mtgcComboBox2.Text+"# And (T_parc_machine.[Date reforme])<=#12/31/"+mtgcComboBox2.Text+"#))"; 
				
						try
						{
							Sorties=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Sorties=0;
						}

						FinDePeriode=Total+Crea-Sorties;

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Code machine Opindus]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRepa=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Type machine]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbType=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbType=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN (T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_type_machine.Fournisseur";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFourn=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFourn=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_devis_entete.Niveau HAVING (((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbRepar=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}

						Comm.CommandText="SELECT DISTINCT (t_devis_lignes.[Code piece]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_devis_entete.Niveau, t_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)<8))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRef=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRef=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(t_devis_lignes.idLigne) AS CompteDeidLigne FROM T_clients INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_clients.Ident = T_devis_entete.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbLignes=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbLignes=0;
						}

						Comm.CommandText="SELECT Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_clients INNER JOIN T_devis_entete ON T_clients.Ident = T_devis_entete.[Code Client]) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";

						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbPieces=System.Convert.ToInt32(ds.Tables["t_devis_entete"].Rows[0]["SommeDeQuantite"].ToString());
						}
						catch(Exception exp)
						{
							NbPieces=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_devis_entete.Niveau HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							nbParcConnuMachines=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							nbParcConnuMachines=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_parc_machine.[Type machine] HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbTypesConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbTypesConnus=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_type_machine.Fournisseur HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFournConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFournConnus=0;
						}
						ds.Clear();
						oleDbConnection1.Close();

						Comm.CommandText="SELECT T_fournisseurs.Nom, T_type_machine.Code FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_fournisseurs.Nom, T_type_machine.Code";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
					}
				}
				else if(radioButton11.Checked&&textBox2.TextLength>0)
				{
					if(radioButton2.Checked)
					{
						oleDbConnection1.Open();
						
						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], Min(T_devis_entete.Date) AS MinDeDate FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text.Replace("'","''")+"')) GROUP BY T_parc_machine.[Code machine Opindus] HAVING (((Min(T_devis_entete.Date))<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#)) ORDER BY Min(T_devis_entete.Date)";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"nb");
						try
						{
							Nb=ds.Tables["nb"].Rows.Count;
						}
						catch(Exception exp)
						{
							Nb=0;
						}

						ds.Tables["nb"].Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], Min(T_devis_entete.Date) AS MinDeDate FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text.Replace("'","''")+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_parc_machine.[Date reforme] HAVING (((Min(T_devis_entete.Date))<#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"#) AND ((T_parc_machine.[Date reforme]) Is Null))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Total=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Total=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], Min(T_devis_entete.Date) AS MinDeDate FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text.Replace("'","''")+"')) GROUP BY T_parc_machine.[Code machine Opindus] HAVING (((Min(T_devis_entete.Date))>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (Min(T_devis_entete.Date))<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#)) ORDER BY Min(T_devis_entete.Date)";

						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Crea=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Crea=0;
						}
						ds.Clear();
				
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_parc_machine.[Date reforme])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#))"; 
				
						try
						{
							Sorties=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Sorties=0;
						}

						FinDePeriode=Total+Crea-Sorties;

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Code machine Opindus]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRepa=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Type machine]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbType=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbType=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN (T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_type_machine.Fournisseur";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFourn=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFourn=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text)+"#)) GROUP BY T_devis_entete.Niveau HAVING (((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbRepar=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}

						Comm.CommandText="SELECT DISTINCT (t_devis_lignes.[Code piece]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#)) GROUP BY T_devis_entete.Niveau, t_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)<8))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRef=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRef=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(t_devis_lignes.idLigne) AS CompteDeidLigne FROM T_clients INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_clients.Ident = T_devis_entete.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbLignes=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbLignes=0;
						}

						Comm.CommandText="SELECT Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_clients INNER JOIN T_devis_entete ON T_clients.Ident = T_devis_entete.[Code Client]) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7))";

						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbPieces=System.Convert.ToInt32(ds.Tables["t_devis_entete"].Rows[0]["SommeDeQuantite"].ToString());
						}
						catch(Exception exp)
						{
							NbPieces=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_devis_entete.Niveau HAVING (((Min(T_devis_entete.Date))<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							nbParcConnuMachines=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							nbParcConnuMachines=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_parc_machine.[Type machine] HAVING (((Min(T_devis_entete.Date))<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbTypesConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbTypesConnus=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_type_machine.Fournisseur HAVING (((Min(T_devis_entete.Date))<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFournConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFournConnus=0;
						}
						ds.Clear();
						oleDbConnection1.Close();
					}
					else if(radioButton3.Checked)
					{
						Comm.CommandText="SELECT T_fournisseurs.Nom, T_type_machine.Code, T_parc_machine.[Date reforme] FROM ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date entree reelle])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#)) GROUP BY T_fournisseurs.Nom, T_type_machine.Code, T_parc_machine.[Date reforme] HAVING (((T_parc_machine.[Date reforme]) Is Null))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
					}
					else if(radioButton4.Checked)
					{
						oleDbConnection1.Open();
						
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] GROUP BY T_clients.Nom HAVING (((T_clients.Nom)='"+textBox2.Text+"'))";
						try
						{
							Nb=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Nb=0;
						}

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], Min(T_devis_entete.Date) AS MinDeDate FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_parc_machine.[Date reforme] HAVING (((Min(T_devis_entete.Date))<#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"#) AND ((T_parc_machine.[Date reforme]) Is Null))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Total=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Total=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_clients.Nom, T_parc_machine.[Code machine Opindus] HAVING (((T_clients.Nom)='"+textBox2.Text+"') AND ((Min(T_devis_entete.Date))>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (Min(T_devis_entete.Date))<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Crea=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Crea=0;
						}
						ds.Clear();
				
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_parc_machine.[Date reforme])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#))"; 
				
						try
						{
							Sorties=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Sorties=0;
						}

						FinDePeriode=Total+Crea-Sorties;

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Code machine Opindus]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRepa=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Type machine]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbType=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbType=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN (T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_type_machine.Fournisseur";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFourn=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFourn=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#)) GROUP BY T_devis_entete.Niveau HAVING (((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbRepar=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}

						Comm.CommandText="SELECT DISTINCT (t_devis_lignes.[Code piece]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#)) GROUP BY T_devis_entete.Niveau, t_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)<8))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRef=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRef=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(t_devis_lignes.idLigne) AS CompteDeidLigne FROM T_clients INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_clients.Ident = T_devis_entete.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbLignes=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbLignes=0;
						}

						Comm.CommandText="SELECT Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_clients INNER JOIN T_devis_entete ON T_clients.Ident = T_devis_entete.[Code Client]) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox3.Text).Month+"/"+System.Convert.ToDateTime(textBox3.Text).Day+"/"+System.Convert.ToDateTime(textBox3.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7))";

						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbPieces=System.Convert.ToInt32(ds.Tables["t_devis_entete"].Rows[0]["SommeDeQuantite"].ToString());
						}
						catch(Exception exp)
						{
							NbPieces=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_devis_entete.Niveau HAVING (((Min(T_devis_entete.Date))<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#) AND ((T_devis_entete.Niveau)=7))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							nbParcConnuMachines=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							nbParcConnuMachines=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_parc_machine.[Type machine] HAVING (((Min(T_devis_entete.Date))<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbTypesConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbTypesConnus=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_type_machine.Fournisseur HAVING (((Min(T_devis_entete.Date))<=#"+System.Convert.ToDateTime(textBox4.Text).Month+"/"+System.Convert.ToDateTime(textBox4.Text).Day+"/"+System.Convert.ToDateTime(textBox4.Text).Year+"#))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFournConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFournConnus=0;
						}
						ds.Clear();
						oleDbConnection1.Close();

						Comm.CommandText="SELECT T_fournisseurs.Nom, T_type_machine.Code FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_fournisseurs.Nom, T_type_machine.Code";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
					}
				}
				oleDbConnection1.Close();
				if(radioButton2.Checked||radioButton3.Checked)
				{
					printPreviewDialog1.Document=printDocument1;
					printPreviewDialog1.ShowDialog();
				}
				else if(radioButton4.Checked)
				{
					radioButton2.Checked=true;
					printPreviewDialog1.Document=printDocument1;
					printPreviewDialog1.ShowDialog();
					radioButton3.Checked=true;
					printPreviewDialog1.Document=printDocument1;
					printPreviewDialog1.ShowDialog();
					radioButton4.Checked=true;
				}
			}
			else
				MessageBox.Show("Choisissez un client SVP");
		}

		private void textBox3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue!=8)
			{
				if(textBox3.TextLength.Equals(2))
				{
					textBox3.Text+="/";
					textBox3.Select(3,1);
				}
				else if(textBox3.TextLength.Equals(5))
				{
					textBox3.Text+="/";
					textBox3.Select(6,1);
				}
			}
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked)
				mtgcComboBox2.Enabled=true;
			else
				mtgcComboBox2.Enabled=false;
		}

		private void textBox4_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue!=8)
			{
				if(textBox4.TextLength.Equals(2))
				{
					textBox4.Text+="/";
					textBox4.Select(3,1);
				}
				else if(textBox4.TextLength.Equals(5))
				{
					textBox4.Text+="/";
					textBox4.Select(6,1);
				}
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			int ypos=e.MarginBounds.Top;
			Page+=1;
			e.Graphics.DrawString(textBox2.Text, new Font("Arial", 20, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left+120, ypos);
			ypos+=40;
			e.Graphics.DrawString("Statistiques gestion parc", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
			ypos+=40;
			if(radioButton1.Checked)
			{
				e.Graphics.DrawString("Période du 01/01/"+mtgcComboBox2.Text+" au 31/12/"+mtgcComboBox2.Text, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+120, ypos);
			}
			else
			{
				DateTime Date1=System.Convert.ToDateTime(textBox3.Text);
				DateTime Date2=System.Convert.ToDateTime(textBox4.Text);
				e.Graphics.DrawString("Période du "+Date1.ToShortDateString()+" au "+Date2.ToShortDateString(), new Font("Arial", 16, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+140, ypos);
			}
			ypos+=40;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			if(radioButton2.Checked)
			{
				ypos+=90;
				e.Graphics.DrawString("Synthèse du parc", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
				ypos+=20;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left,ypos,e.MarginBounds.Width,250);
				ypos+=40;
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+350,ypos), new Point(e.MarginBounds.Left+350,ypos+150));
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,400,30);
				e.Graphics.DrawString("Parc total connu", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(Nb.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+385, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,400,30);
				e.Graphics.DrawString("Parc en début de période", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(Total.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+385, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,400,30);
				e.Graphics.DrawString("Entrées dans la période", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(Crea.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+385, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,400,30);
				e.Graphics.DrawString("Sorties dans la période", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(Sorties.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+385, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,400,30);
				e.Graphics.DrawString("Parc en fin de période", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(FinDePeriode.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+385, ypos+5);
				ypos+=100;
				e.Graphics.DrawString("Synthèse des réparations", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+205, ypos);
				ypos+=20;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left,ypos,e.MarginBounds.Width,310);
				ypos+=40;
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+280,ypos), new Point(e.MarginBounds.Left+280,ypos+240));
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+380,ypos), new Point(e.MarginBounds.Left+380,ypos+120));
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+280,ypos,200,30);
				e.Graphics.DrawString("Réparations", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+280, ypos+5);
				e.Graphics.DrawString("Parc connu", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+382, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,430,30);
				e.Graphics.DrawString("Machines", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(NbRepa.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+315, ypos+5);
				e.Graphics.DrawString(nbParcConnuMachines.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+410, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,430,30);
				e.Graphics.DrawString("Types machines", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(NbType.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+315, ypos+5);
				e.Graphics.DrawString(NbTypesConnus.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+410, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,430,30);
				e.Graphics.DrawString("Fournisseurs", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(NbFourn.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+315, ypos+5);
				e.Graphics.DrawString(NbFournConnus.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+410, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,330,30);
				e.Graphics.DrawString("Réparations", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(NbRepar.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+315, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,330,30);
				e.Graphics.DrawString("Références gérées", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(NbRef.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+315, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,330,30);
				e.Graphics.DrawString("Lignes gérées", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(NbLignes.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+315, ypos+5);
				ypos+=30;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,330,30);
				e.Graphics.DrawString("Pièces mouvementées", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos+5);
				e.Graphics.DrawString(NbPieces.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+315, ypos+5);
			}
			else if (radioButton3.Checked)
			{
				e.Graphics.DrawString("Fournisseur", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString("Type", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos);
				e.Graphics.DrawString("Réparations", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
				e.Graphics.DrawString("Montant", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
				e.Graphics.DrawString("Montant Moy.", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+450, ypos);
				e.Graphics.DrawString("Parc", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos);
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
				ypos+=20;
				string ancienfourn=null;
				bool debut=true;
				int CptMachines=0;
				int Reparations=0;
				Decimal Montant=0;
				int Parc=0;
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["t_devis_entete"].Rows.Count)
				{
					try
					{
						if(debut)
							debut=false;
						else
						{
							ancienfourn=ds.Tables["t_devis_entete"].Rows[countRow-1]["Nom"].ToString();
						}
						if(ancienfourn!=ds.Tables["t_devis_entete"].Rows[countRow]["Nom"].ToString())
						{
							if(countRow>0)
							{
								ypos+=10;
								e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
								ypos+=5;
								if(CptMachines>0)
								{
									e.Graphics.DrawString(CptMachines.ToString()+" type(s)", 
										new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos); 
								}
								if(Reparations>0)
								{
									e.Graphics.DrawString(Reparations.ToString(), 
										new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos); 
								}
								if(Montant>0)
								{
									e.Graphics.DrawString(Montant.ToString(), 
										new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos); 
								}
								Decimal Moyenne=0;
								try
								{
									Moyenne=Montant/Reparations;
									e.Graphics.DrawString(Moyenne.ToString("0.00"), 
										new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+450, ypos);
								}
								catch(Exception exp)
								{
									Moyenne=0;
								}
								e.Graphics.DrawString(Parc.ToString(), 
									new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos); 
								ypos+=15;
								e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
								CptMachines=0;
								Parc=0;
								Reparations=0;
								Montant=0;
							}
							ypos+=10;
							e.Graphics.DrawString(ds.Tables["t_devis_entete"].Rows[countRow]["Nom"].ToString(), 
								new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos); 
							ypos+=15;
						}
						e.Graphics.DrawString(ds.Tables["t_devis_entete"].Rows[countRow]["Code"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos);
						Comm.CommandText="SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis], Sum(T_devis_entete.[Total devis]) AS [SommeDeTotal devis] FROM ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_type_machine.Code)='"+ds.Tables["t_devis_entete"].Rows[countRow]["Code"].ToString()+"') AND ((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#31/12/"+mtgcComboBox2.Text+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"compte");
						//Comm.CommandText="SELECT T_type_machine.[Code machine Opindus] FROM ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null) AND ((T_devis_entete.[Date entree reelle])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_parc_machine.[Type machine])='"+ds.Tables["t_devis_entete"].Rows[countRow]["Code"].ToString()+"')) GROUP BY T_type_machine.[Code machine Opindus]";
						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_parc_machine.[Type machine])='"+ds.Tables["t_devis_entete"].Rows[countRow]["Code"].ToString()+"') AND ((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date entree reelle])<=#12/31/"+mtgcComboBox2.Text+"#)) AND T_parc_machine.[Date reforme] IS NULL GROUP BY T_parc_machine.[Code machine Opindus]"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"parc");

						if(ds.Tables["compte"].Rows.Count>0)
						{
							e.Graphics.DrawString(ds.Tables["compte"].Rows[0]["CompteDeN° Devis"].ToString(), 
								new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
							e.Graphics.DrawString(ds.Tables["compte"].Rows[0]["SommeDeTotal devis"].ToString(), 
								new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
							Decimal Moyenne=0;
							try
							{
								Moyenne=System.Convert.ToDecimal(ds.Tables["compte"].Rows[0]["SommeDeTotal devis"].ToString())/System.Convert.ToDecimal(ds.Tables["compte"].Rows[0]["CompteDeN° Devis"].ToString());
								e.Graphics.DrawString(Moyenne.ToString("0.00"), 
									new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+450, ypos);
							}
							catch(Exception exp)
							{
								Moyenne=0;
							}
							e.Graphics.DrawString(ds.Tables["parc"].Rows.Count.ToString(), 
								new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos);
							Reparations+=System.Convert.ToInt32(ds.Tables["compte"].Rows[0]["CompteDeN° Devis"].ToString());
							try
							{
								Montant+=System.Convert.ToDecimal(ds.Tables["compte"].Rows[0]["SommeDeTotal devis"].ToString());
							}
							catch(Exception exp)
							{
								Montant+=0;
							}
							Parc+=System.Convert.ToInt32(ds.Tables["parc"].Rows.Count.ToString());
							ds.Tables["compte"].Clear();
							ds.Tables["parc"].Clear();
							
						}
						CptMachines++;
						ypos+=15;
						countRow+=1;
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
						MessageBox.Show(countRow.ToString());
					}
				}
				if(countRow==ds.Tables["t_devis_entete"].Rows.Count)
				{
					ypos+=10;
					e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=5;
					if(CptMachines>0)
					{
						e.Graphics.DrawString(CptMachines.ToString()+" type(s)", 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos); 
					}
					if(Reparations>0)
					{
						e.Graphics.DrawString(Reparations.ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos); 
					}
					if(Montant>0)
					{
						e.Graphics.DrawString(Montant.ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos); 
					}
					Decimal Moyenne=0;
					try
					{
						Moyenne=Montant/Reparations;
						e.Graphics.DrawString(Moyenne.ToString("0.00"), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+450, ypos);
					}
					catch(Exception exp)
					{
						Moyenne=0;
					}
					e.Graphics.DrawString(Parc.ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos); 
					ypos+=15;
					e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					CptMachines=0;
					Parc=0;
					Reparations=0;
					Montant=0;
				}
				ypos+=20;
				e.Graphics.DrawString(DateTime.Now.ToLongDateString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom);
				e.Graphics.DrawString("Page "+Page.ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-50, e.MarginBounds.Bottom);
				if(countRow<ds.Tables["t_devis_entete"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
					Page=0;
				}
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			countRow=0;
			Page=0;
			if(mtgcComboBox1.SelectedIndex>0)
			{
				if(radioButton1.Checked&&textBox2.TextLength>0)
				{
					if(radioButton2.Checked)
					{
						oleDbConnection1.Open();
						
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] GROUP BY T_clients.Nom HAVING (((T_clients.Nom)='"+textBox2.Text+"'))";
						try
						{
							Nb=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Nb=0;
						}

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], Min(T_devis_entete.Date) AS MinDeDate FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_parc_machine.[Date reforme] HAVING (((Min(T_devis_entete.Date))<#"+"01/01/"+mtgcComboBox2.Text+"#) AND ((T_parc_machine.[Date reforme]) Is Null))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Total=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Total=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_clients.Nom, T_parc_machine.[Code machine Opindus] HAVING (((T_clients.Nom)='"+textBox2.Text+"') AND ((Min(T_devis_entete.Date))>=#01/01/"+mtgcComboBox2.Text+"# And (Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Crea=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Crea=0;
						}
						ds.Clear();
				
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme])>=#01/01/"+mtgcComboBox2.Text+"# And (T_parc_machine.[Date reforme])<=#12/31/"+mtgcComboBox2.Text+"#))"; 
				
						try
						{
							Sorties=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Sorties=0;
						}

						FinDePeriode=Total+Crea-Sorties;

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Code machine Opindus]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRepa=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Type machine]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbType=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbType=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN (T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_type_machine.Fournisseur";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFourn=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFourn=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_devis_entete.Niveau HAVING (((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbRepar=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}

						Comm.CommandText="SELECT DISTINCT (t_devis_lignes.[Code piece]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_devis_entete.Niveau, t_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)<8))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRef=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRef=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(t_devis_lignes.idLigne) AS CompteDeidLigne FROM T_clients INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_clients.Ident = T_devis_entete.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbLignes=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbLignes=0;
						}

						Comm.CommandText="SELECT Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_clients INNER JOIN T_devis_entete ON T_clients.Ident = T_devis_entete.[Code Client]) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";

						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbPieces=System.Convert.ToInt32(ds.Tables["t_devis_entete"].Rows[0]["SommeDeQuantite"].ToString());
						}
						catch(Exception exp)
						{
							NbPieces=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_devis_entete.Niveau HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							nbParcConnuMachines=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							nbParcConnuMachines=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_parc_machine.[Type machine] HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbTypesConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbTypesConnus=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_type_machine.Fournisseur HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFournConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFournConnus=0;
						}
						ds.Clear();
						oleDbConnection1.Close();
					}
					else if(radioButton3.Checked)
					{
						Comm.CommandText="SELECT T_fournisseurs.Nom, T_type_machine.Code, T_parc_machine.[Date reforme] FROM ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date entree reelle])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_fournisseurs.Nom, T_type_machine.Code, T_parc_machine.[Date reforme] HAVING (((T_parc_machine.[Date reforme]) Is Null))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
					}
					else if(radioButton4.Checked)
					{
						oleDbConnection1.Open();
						
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] GROUP BY T_clients.Nom HAVING (((T_clients.Nom)='"+textBox2.Text+"'))";
						try
						{
							Nb=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Nb=0;
						}

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], Min(T_devis_entete.Date) AS MinDeDate FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_parc_machine.[Date reforme] HAVING (((Min(T_devis_entete.Date))<#"+"01/01/"+mtgcComboBox2.Text+"#) AND ((T_parc_machine.[Date reforme]) Is Null))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Total=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Total=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_clients.Nom, T_parc_machine.[Code machine Opindus] HAVING (((T_clients.Nom)='"+textBox2.Text+"') AND ((Min(T_devis_entete.Date))>=#01/01/"+mtgcComboBox2.Text+"# And (Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Crea=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Crea=0;
						}
						ds.Clear();
				
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme])>=#01/01/"+mtgcComboBox2.Text+"# And (T_parc_machine.[Date reforme])<=#12/31/"+mtgcComboBox2.Text+"#))"; 
				
						try
						{
							Sorties=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Sorties=0;
						}

						FinDePeriode=Total+Crea-Sorties;

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Code machine Opindus]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRepa=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Type machine]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbType=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbType=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN (T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_type_machine.Fournisseur";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFourn=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFourn=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_devis_entete.Niveau HAVING (((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbRepar=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}

						Comm.CommandText="SELECT DISTINCT (t_devis_lignes.[Code piece]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#)) GROUP BY T_devis_entete.Niveau, t_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)<8))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbRef=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRef=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(t_devis_lignes.idLigne) AS CompteDeidLigne FROM T_clients INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_clients.Ident = T_devis_entete.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#01/01/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";
				
						try
						{
							NbLignes=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbLignes=0;
						}

						Comm.CommandText="SELECT Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_clients INNER JOIN T_devis_entete ON T_clients.Ident = T_devis_entete.[Code Client]) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+mtgcComboBox2.Text+"# And (T_devis_entete.[Date reparation])<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";

						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbPieces=System.Convert.ToInt32(ds.Tables["t_devis_entete"].Rows[0]["SommeDeQuantite"].ToString());
						}
						catch(Exception exp)
						{
							NbPieces=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_devis_entete.Niveau HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#) AND ((T_devis_entete.Niveau)=7))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							nbParcConnuMachines=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							nbParcConnuMachines=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_parc_machine.[Type machine] HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbTypesConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbTypesConnus=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_type_machine.Fournisseur HAVING (((Min(T_devis_entete.Date))<=#12/31/"+mtgcComboBox2.Text+"#))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbFournConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFournConnus=0;
						}
						ds.Clear();
						oleDbConnection1.Close();

						Comm.CommandText="SELECT T_fournisseurs.Nom, T_type_machine.Code FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_fournisseurs.Nom, T_type_machine.Code";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
					}
				}
				else if(radioButton11.Checked)
				{
					try
					{
						DateTime Date1=System.Convert.ToDateTime(textBox3.Text);
						DateTime Date2=System.Convert.ToDateTime(textBox4.Text);
						oleDbConnection1.Open();
						OleDbDataAdapter DataAd=new OleDbDataAdapter();
						DataSet ds=new DataSet();
						Comm.Connection=oleDbConnection1;
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] GROUP BY T_clients.Nom HAVING (((T_clients.Nom)='"+textBox2.Text+"'))";
						try
						{
							Nb=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Nb=0;
						}

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], Min(T_devis_entete.Date) AS MinDeDate FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_parc_machine.[Date reforme] HAVING (((Min(T_devis_entete.Date))<#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"#) AND ((T_parc_machine.[Date reforme]) Is Null))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
					
						try
						{
							Total=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Total=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_clients.Nom, T_parc_machine.[Code machine Opindus] HAVING (((T_clients.Nom)='"+textBox2.Text+"') AND ((Min(T_devis_entete.Date))>=#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"# And (Min(T_devis_entete.Date))<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							Crea=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							Crea=0;
						}
						ds.Clear();
				
						Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme])>=#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"# And (T_parc_machine.[Date reforme])<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#))"; 
				
						try
						{
							Sorties=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							Sorties=0;
						}

						int FinDePeriode=Total+Crea-Sorties;

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"# And (T_devis_entete.[Date reparation])<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Code machine Opindus]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
			
						try
						{
							NbRepa=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"# And (T_devis_entete.[Date reparation])<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_parc_machine.[Type machine]";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
			
						try
						{
							NbType=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbType=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN (T_clients INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"# And (T_devis_entete.[Date reparation])<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#) AND ((T_devis_entete.Niveau)=7)) GROUP BY T_type_machine.Fournisseur";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
			
						try
						{
							NbFourn=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFourn=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"# And (T_devis_entete.[Date reparation])<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#)) GROUP BY T_devis_entete.Niveau HAVING (((T_devis_entete.Niveau)=7))";
		
						try
						{
							NbRepar=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbRepa=0;
						}

						Comm.CommandText="SELECT DISTINCT (t_devis_lignes.[Code piece]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"# And (T_devis_entete.[Date reparation])<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#)) GROUP BY T_devis_entete.Niveau, t_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)<8))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
		
						try
						{
							NbRef=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbRef=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT Count(t_devis_lignes.idLigne) AS CompteDeidLigne FROM T_clients INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_clients.Ident = T_devis_entete.[Code Client] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"# And (T_devis_entete.[Date reparation])<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#) AND ((T_devis_entete.Niveau)=7))";
			
						try
						{
							NbLignes=(int)Comm.ExecuteScalar();
						}
						catch(Exception exp)
						{
							NbLignes=0;
						}

						Comm.CommandText="SELECT Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_clients INNER JOIN T_devis_entete ON T_clients.Ident = T_devis_entete.[Code Client]) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Date1.Month+"/"+Date1.Day+"/"+Date1.Year+"# And (T_devis_entete.[Date reparation])<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#) AND ((T_devis_entete.Niveau)=7))";

						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
		
						try
						{
							NbPieces=System.Convert.ToInt32(ds.Tables["t_devis_entete"].Rows[0]["SommeDeQuantite"].ToString());
						}
						catch(Exception exp)
						{
							NbPieces=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"')) GROUP BY T_parc_machine.[Code machine Opindus], T_devis_entete.Niveau HAVING (((Min(T_devis_entete.Date))<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#) AND ((T_devis_entete.Niveau)=7))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							nbParcConnuMachines=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							nbParcConnuMachines=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_parc_machine.[Type machine] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_parc_machine.[Type machine] HAVING (((Min(T_devis_entete.Date))<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#))";
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
				
						try
						{
							NbTypesConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbTypesConnus=0;
						}
						ds.Clear();

						Comm.CommandText="SELECT T_type_machine.Fournisseur FROM T_type_machine INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox2.Text+"') AND ((T_parc_machine.[Date reforme]) Is Null)) GROUP BY T_type_machine.Fournisseur HAVING (((Min(T_devis_entete.Date))<=#"+Date2.Month+"/"+Date2.Day+"/"+Date2.Year+"#))"; 
						DataAd.SelectCommand=Comm;
						DataAd.Fill(ds,"t_devis_entete");
		
						try
						{
							NbFournConnus=ds.Tables["t_devis_entete"].Rows.Count;
						}
						catch(Exception exp)
						{
							NbFournConnus=0;
						}
						ds.Clear();
					}
					catch(Exception exp)
					{
						label5.Visible=true;
					}
				}
				oleDbConnection1.Close();
				if(radioButton2.Checked||radioButton3.Checked)
				{
					printDocument1.Print();
				}
				else if(radioButton4.Checked)
				{
					radioButton2.Checked=true;
					printDocument1.Print();
					radioButton3.Checked=true;
					printDocument1.Print();
					radioButton4.Checked=true;
				}
			}
			else
				MessageBox.Show("Choisissez un client SVP");
		}
	}
}
