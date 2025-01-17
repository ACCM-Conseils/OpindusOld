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
	/// Description résumée de AutresMAJ.
	/// </summary>
	public class AutresMAJ : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ListView listView3;
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
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Button button4;
		private int index;
		private int index2;
		private int index3;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private System.Windows.Forms.Button button1;
		private MTGCComboBox mtgcComboBox1;
		private OleDbTransaction Transac;
		private System.Windows.Forms.TextBox txrem;
		private System.Windows.Forms.TextBox txPAPV;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AutresMAJ(int Agence)
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
			tabControlEX1.SelectedTab=tabPageEX1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AutresMAJ));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txPAPV = new System.Windows.Forms.TextBox();
			this.txrem = new System.Windows.Forms.TextBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.listView3 = new System.Windows.Forms.ListView();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
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
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.tabPageEX2.SuspendLayout();
			this.tabPageEX3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txPAPV);
			this.groupBox1.Controls.Add(this.txrem);
			this.groupBox1.Controls.Add(this.mtgcComboBox1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(895, 80);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txPAPV
			// 
			this.txPAPV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txPAPV.Location = new System.Drawing.Point(792, 48);
			this.txPAPV.Name = "txPAPV";
			this.txPAPV.Size = new System.Drawing.Size(32, 20);
			this.txPAPV.TabIndex = 7;
			this.txPAPV.Text = "";
			this.txPAPV.Visible = false;
			// 
			// txrem
			// 
			this.txrem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txrem.Location = new System.Drawing.Point(832, 48);
			this.txrem.Name = "txrem";
			this.txrem.Size = new System.Drawing.Size(32, 20);
			this.txrem.TabIndex = 6;
			this.txrem.Text = "";
			this.txrem.Visible = false;
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(144, 15);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(720, 21);
			this.mtgcComboBox1.TabIndex = 5;
			this.mtgcComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox1_KeyDown);
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(440, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(96, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.TabStop = false;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(144, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(280, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nom";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Recherche fournisseur";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lavender;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(384, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 20);
			this.button2.TabIndex = 1;
			this.button2.Text = "Valider";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(208, 16);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(152, 20);
			this.textBox3.TabIndex = 0;
			this.textBox3.Text = "";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader3});
			this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HoverSelection = true;
			this.listView1.Location = new System.Drawing.Point(24, 48);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(880, 432);
			this.listView1.TabIndex = 0;
			this.listView1.TabStop = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
			this.listView1.Leave += new System.EventHandler(this.listView1_Leave);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Code type";
			this.columnHeader1.Width = 180;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Prix catalogue";
			this.columnHeader2.Width = 180;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Mise à jour tarif";
			this.columnHeader3.Width = 180;
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(208, 16);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(176, 20);
			this.textBox4.TabIndex = 2;
			this.textBox4.Text = "";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lavender;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(392, 16);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 20);
			this.button3.TabIndex = 3;
			this.button3.Text = "Valider";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// listView2
			// 
			this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader4,
																						this.columnHeader5,
																						this.columnHeader6});
			this.listView2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.HoverSelection = true;
			this.listView2.Location = new System.Drawing.Point(24, 48);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(880, 432);
			this.listView2.TabIndex = 1;
			this.listView2.TabStop = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			this.listView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView2_KeyDown);
			this.listView2.Leave += new System.EventHandler(this.listView2_Leave);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Code pièce";
			this.columnHeader4.Width = 180;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Désignation";
			this.columnHeader5.Width = 180;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Prix achat brut";
			this.columnHeader6.Width = 180;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Lavender;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(504, 16);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 20);
			this.button4.TabIndex = 7;
			this.button4.Text = "Valider";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.Color.White;
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Location = new System.Drawing.Point(404, 16);
			this.textBox9.Name = "textBox9";
			this.textBox9.ReadOnly = true;
			this.textBox9.Size = new System.Drawing.Size(91, 20);
			this.textBox9.TabIndex = 6;
			this.textBox9.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(304, 16);
			this.textBox8.Name = "textBox8";
			this.textBox8.TabIndex = 5;
			this.textBox8.Text = "";
			this.textBox8.Leave += new System.EventHandler(this.textBox8_Leave);
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.White;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(244, 16);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(60, 20);
			this.textBox7.TabIndex = 4;
			this.textBox7.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(164, 16);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(80, 20);
			this.textBox6.TabIndex = 3;
			this.textBox6.Text = "";
			this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(104, 16);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(60, 20);
			this.textBox5.TabIndex = 2;
			this.textBox5.Text = "";
			this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
			this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
			// 
			// listView3
			// 
			this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader7,
																						this.columnHeader8,
																						this.columnHeader9,
																						this.columnHeader10,
																						this.columnHeader11,
																						this.columnHeader12,
																						this.columnHeader13});
			this.listView3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView3.FullRowSelect = true;
			this.listView3.GridLines = true;
			this.listView3.Location = new System.Drawing.Point(24, 48);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(872, 432);
			this.listView3.TabIndex = 1;
			this.listView3.View = System.Windows.Forms.View.Details;
			this.listView3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView3_KeyDown);
			this.listView3.Leave += new System.EventHandler(this.listView3_Leave);
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Code pièce";
			this.columnHeader7.Width = 80;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "En stock";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "En réserve";
			this.columnHeader9.Width = 80;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Dispo";
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "En commande";
			this.columnHeader11.Width = 100;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Stock théo";
			this.columnHeader12.Width = 90;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Désignation";
			this.columnHeader13.Width = 350;
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
																																																						  new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																						  new System.Data.Common.DataColumnMapping("Code", "Code")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_fournisseurs WHERE (Code = ?) AND (Nom = ? OR ? IS NULL AND Nom IS " +
				"NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_fournisseurs(Nom, Code) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Nom, Code FROM T_fournisseurs ORDER BY Nom";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_fournisseurs SET Nom = ?, Code = ? WHERE (Code = ?) AND (Nom = ? OR ? IS" +
				" NULL AND Nom IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
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
																										new System.Data.Common.DataTableMapping("Table", "T_type_machine", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																						  new System.Data.Common.DataColumnMapping("Code famille", "Code famille"),
																																																						  new System.Data.Common.DataColumnMapping("Date creation", "Date creation"),
																																																						  new System.Data.Common.DataColumnMapping("Date MAJ controle", "Date MAJ controle"),
																																																						  new System.Data.Common.DataColumnMapping("Date MAJ DNR", "Date MAJ DNR"),
																																																						  new System.Data.Common.DataColumnMapping("Date MAJ Transport", "Date MAJ Transport"),
																																																						  new System.Data.Common.DataColumnMapping("Delai garantie", "Delai garantie"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait controle", "Forfait controle"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait DNR", "Forfait DNR"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait Transport", "Forfait Transport"),
																																																						  new System.Data.Common.DataColumnMapping("Fournisseur", "Fournisseur"),
																																																						  new System.Data.Common.DataColumnMapping("Maxi machine", "Maxi machine"),
																																																						  new System.Data.Common.DataColumnMapping("Mini machine", "Mini machine"),
																																																						  new System.Data.Common.DataColumnMapping("Mise a jour tarif", "Mise a jour tarif"),
																																																						  new System.Data.Common.DataColumnMapping("Nombre reparations", "Nombre reparations"),
																																																						  new System.Data.Common.DataColumnMapping("Prix catalogue", "Prix catalogue"),
																																																						  new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM T_type_machine WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = @"INSERT INTO T_type_machine(Code, [Code famille], [Date creation], [Date MAJ controle], [Date MAJ DNR], [Date MAJ Transport], [Delai garantie], [Forfait controle], [Forfait DNR], [Forfait Transport], Fournisseur, [Maxi machine], [Mini machine], [Mise a jour tarif], [Nombre reparations], [Prix catalogue], Vitesse) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = @"SELECT Code, [Code famille], [Date creation], [Date MAJ controle], [Date MAJ DNR], [Date MAJ Transport], [Delai garantie], [Forfait controle], [Forfait DNR], [Forfait Transport], Fournisseur, [Maxi machine], [Mini machine], [Mise a jour tarif], [Nombre reparations], [Prix catalogue], Vitesse FROM T_type_machine";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE T_type_machine SET Code = ?, [Code famille] = ?, [Date creation] = ?, [Date MAJ controle] = ?, [Date MAJ DNR] = ?, [Date MAJ Transport] = ?, [Delai garantie] = ?, [Forfait controle] = ?, [Forfait DNR] = ?, [Forfait Transport] = ?, Fournisseur = ?, [Maxi machine] = ?, [Mini machine] = ?, [Mise a jour tarif] = ?, [Nombre reparations] = ?, [Prix catalogue] = ?, Vitesse = ? WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
																																																							  new System.Data.Common.DataColumnMapping("Stock Alerte", "Stock Alerte"),
																																																							  new System.Data.Common.DataColumnMapping("Expr1", "Expr1")})});
			this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Controls.Add(this.tabPageEX2);
			this.tabControlEX1.Controls.Add(this.tabPageEX3);
			this.tabControlEX1.Location = new System.Drawing.Point(-5, 88);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 2;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(935, 531);
			this.tabControlEX1.TabColor = System.Drawing.Color.DarkGray;
			this.tabControlEX1.TabIndex = 4;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.button2);
			this.tabPageEX1.Controls.Add(this.textBox3);
			this.tabPageEX1.Controls.Add(this.listView1);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(927, 502);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Types machines";
			// 
			// tabPageEX2
			// 
			this.tabPageEX2.Controls.Add(this.textBox4);
			this.tabPageEX2.Controls.Add(this.button3);
			this.tabPageEX2.Controls.Add(this.listView2);
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(927, 502);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Tarifs pièces détachées";
			// 
			// tabPageEX3
			// 
			this.tabPageEX3.Controls.Add(this.textBox7);
			this.tabPageEX3.Controls.Add(this.textBox6);
			this.tabPageEX3.Controls.Add(this.listView3);
			this.tabPageEX3.Controls.Add(this.button4);
			this.tabPageEX3.Controls.Add(this.textBox9);
			this.tabPageEX3.Controls.Add(this.textBox8);
			this.tabPageEX3.Controls.Add(this.textBox5);
			this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX3.Name = "tabPageEX3";
			this.tabPageEX3.Size = new System.Drawing.Size(927, 502);
			this.tabPageEX3.TabIndex = 2;
			this.tabPageEX3.Text = "Stock pièces détachées";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(862, 628);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 48);
			this.button1.TabIndex = 7;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = @"SELECT [Cause Principale], Code, [Code Famille], [Code Fournisseur Principal], [Code Unite], Code_1, [Correspondance Stock], [Date Dernier Mouvement], [Date MAJ Tarif], [Delai Livraison], Designation, Identificateur, pre_devis, [Prix Achat Brut], [Prix Achat Net], [Prix Vente], [Quantite Commande], [Quantite Disponible], [Quantite Maxi], [Quantite Minimum], [Quantite Reserve], [Quantite Stock], [Quantite stock theorique], [Stock Alerte], Identificateur AS Expr1 FROM T_pieces_detachees";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand3
			// 
			this.oleDbInsertCommand3.CommandText = @"INSERT INTO T_pieces_detachees([Cause Principale], Code, [Code Famille], [Code Fournisseur Principal], [Code Unite], Code_1, [Correspondance Stock], [Date Dernier Mouvement], [Date MAJ Tarif], [Delai Livraison], Designation, Identificateur, pre_devis, [Prix Achat Brut], [Prix Achat Net], [Prix Vente], [Quantite Commande], [Quantite Disponible], [Quantite Maxi], [Quantite Minimum], [Quantite Reserve], [Quantite Stock], [Quantite stock theorique], [Stock Alerte]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, "Cause Principale"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 18, "Code"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, "Code Famille"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, "Code Fournisseur Principal"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, "Code Unite"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, "Code_1"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, "Correspondance Stock"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Mouvement"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Tarif"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai Livraison"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Identificateur", System.Data.OleDb.OleDbType.Integer, 0, "Expr1"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, "pre_devis"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Brut"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Net"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, "Prix Vente"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, "Quantite Commande"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, "Quantite Disponible"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Quantite Maxi"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, "Quantite Minimum"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, "Quantite Reserve"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, "Quantite Stock"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, "Quantite stock theorique"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, "Stock Alerte"));
			// 
			// oleDbUpdateCommand3
			// 
			this.oleDbUpdateCommand3.CommandText = "UPDATE T_pieces_detachees SET [Cause Principale] = ?, Code = ?, [Code Famille] = " +
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
			this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, "Cause Principale"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 18, "Code"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, "Code Famille"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, "Code Fournisseur Principal"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, "Code Unite"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, "Code_1"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, "Correspondance Stock"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Mouvement"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Tarif"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai Livraison"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Identificateur", System.Data.OleDb.OleDbType.Integer, 0, "Expr1"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, "pre_devis"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Brut"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Net"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, "Prix Vente"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, "Quantite Commande"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, "Quantite Disponible"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Quantite Maxi"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, "Quantite Minimum"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, "Quantite Reserve"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, "Quantite Stock"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, "Quantite stock theorique"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, "Stock Alerte"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Identificateur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_Principale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Unite1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_11", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Vente1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "pre_devis", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand3
			// 
			this.oleDbDeleteCommand3.CommandText = "DELETE FROM T_pieces_detachees WHERE (Identificateur = ?) AND ([Cause Principale]" +
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
			this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Identificateur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_Principale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Unite1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_11", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Vente1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "pre_devis", System.Data.DataRowVersion.Original, null));
			// 
			// AutresMAJ
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(924, 688);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControlEX1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AutresMAJ";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autres mise à jour fournisseurs";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AutresMAJ_KeyDown);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.tabPageEX2.ResumeLayout(false);
			this.tabPageEX3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void InitializeData()
		{
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["T_fournisseurs"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["Nom"].ToString(),"","",""));
			}
			index=0;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			textBox3.Text=textBox3.Text.Replace(",",".");
			
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection = oleDbConnection1;
			Comm.CommandText = "update t_type_machine set [prix catalogue]="+textBox3.Text+", [mise a jour tarif]='"+DateTime.Today.ToShortDateString()+"' where [code]='"+listView1.Items[listView1.SelectedIndices[0]].Text+"'";
			try
			{
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.Transaction=Transac;
				Comm.ExecuteNonQuery();
				try
				{
					Transac.Commit();
				}
				catch
				{
					Transac.Rollback();
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
			listView1.Items.Clear();
			dataSet11.Tables["t_fournisseurs"].Clear();
			
			Comm = new OleDbCommand();
			Comm.Connection = oleDbConnection1;
			Comm.CommandText = "select * from t_fournisseurs where nom='"+mtgcComboBox1.Text+"'";
			oleDbDataAdapter1.SelectCommand=Comm;
			oleDbDataAdapter1.Fill(dataSet11);
			textBox1.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Nom"].ToString();
			textBox2.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Code"].ToString();
			dataSet11.Tables["t_type_machine"].Clear();
			Comm.CommandText="select * from t_type_machine where fournisseur='"+textBox2.Text+"'";
			oleDbDataAdapter2.SelectCommand=Comm;
			oleDbDataAdapter2.Fill(dataSet11);
			listView1.Items.Clear();
			foreach(DataRow row in dataSet11.Tables["t_type_machine"].Rows)
			{
				listView1.Items.Add(row["Code"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(row["Prix catalogue"].ToString()).ToString("c"));
				if(row["Mise a jour tarif"].ToString().Length>0)
					listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Mise a jour tarif"].ToString().Remove(10,9));
			}
			this.Update();
			index3+=1;
			listView1.Focus();
			listView1.Items[index3].Selected=true;
			listView1.Items[index3].Focused=true;
			oleDbConnection1.Close();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Decimal remise = System.Convert.ToDecimal(txrem.Text);
			remise*=100;
			int remise2 = 100-System.Convert.ToInt32(remise);
			string calcul="0,"+remise2.ToString();
			Decimal taux=System.Convert.ToDecimal(calcul);
			if(remise2.Equals(100))
				taux=1;
			Decimal prix = System.Convert.ToDecimal(textBox4.Text.Replace(".",","));
			Decimal net = taux*prix;
			Decimal PAPV = System.Convert.ToDecimal(txPAPV.Text);
			Decimal PrixVente = PAPV*prix;
			
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection = oleDbConnection1;
			Comm.CommandText = "update t_pieces_detachees set [prix achat brut]="+textBox4.Text.Replace(",",".")+", [prix achat net]="+net.ToString().Replace(",",".")+",[prix vente]="+PrixVente.ToString().Replace(",",".")+",[Date MAJ Tarif]='"+DateTime.Today.ToShortDateString()+"' where [Identificateur]="+listView2.Items[listView2.SelectedIndices[0]].Tag.ToString();
			try
			{
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.Transaction=Transac;
				Comm.ExecuteNonQuery();
				try
				{
					Transac.Commit();
				}
				catch
				{
					Transac.Rollback();
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
			listView2.Items.Clear();
			dataSet11.Tables["t_pieces_detachees"].Clear();
			
			Comm = new OleDbCommand();
			Comm.CommandText="select * from t_pieces_detachees where [code fournisseur principal]='"+textBox2.Text+"' ORDER BY Code";
			Comm.Connection=oleDbConnection1;
			oleDbDataAdapter3.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter3.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			listView2.Items.Clear();
			foreach(DataRow row2 in dataSet11.Tables["t_pieces_detachees"].Rows)
			{
				ListViewItem Piece= new ListViewItem(row2["Code"].ToString());
				Piece.SubItems.Add(row2["Designation"].ToString());
				if(row2["Prix achat brut"].ToString().Length>0)
					Piece.SubItems.Add(System.Convert.ToDecimal(row2["Prix achat brut"].ToString()).ToString("c"));
				else
					Piece.SubItems.Add("0,00 €");
				Piece.Tag=row2["Identificateur"].ToString();
				listView2.Items.Add(Piece);
				//listView2.Items.Add(row2["Code"].ToString());
				//listView2.Items[listView2.Items.Count-1].SubItems.Add(row2["Designation"].ToString());
				//listView2.Items[listView2.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(row2["Prix achat brut"].ToString()).ToString("c"));
			}
			this.Update();
			index2+=1;
			listView2.Focus();
			listView2.Items[index2].Selected=true;
			listView2.Items[index2].Focused=true;
			oleDbConnection1.Close();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection = oleDbConnection1;
			Comm.CommandText = "update t_pieces_detachees set [quantite stock]="+System.Convert.ToDecimal(textBox5.Text)+", [quantite reserve]="+System.Convert.ToDecimal(textBox6.Text)+", [quantite disponible]="+System.Convert.ToDecimal(textBox7.Text)+", [quantite commande]="+System.Convert.ToDecimal(textBox8.Text)+", [quantite stock theorique]="+System.Convert.ToDecimal(textBox9.Text)+" where [Identificateur]="+listView3.Items[listView3.SelectedIndices[0]].Tag.ToString();
			try
			{
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.Transaction=Transac;
				Comm.ExecuteNonQuery();
				try
				{
					Transac.Commit();
				}
				catch
				{
					Transac.Rollback();
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
			listView3.Items.Clear();
			dataSet11.Tables["t_pieces_detachees"].Clear();
			Comm.CommandText="select * from t_pieces_detachees where [code fournisseur principal]='"+textBox2.Text+"' ORDER BY Code";
			oleDbDataAdapter3.SelectCommand=Comm;
			oleDbDataAdapter3.Fill(dataSet11);

			
			foreach(DataRow row2 in dataSet11.Tables["t_pieces_detachees"].Rows)
			{
				int qtedispo=0;
				int qtecde=0;

				ListViewItem piece = new ListViewItem(row2["Code"].ToString());
				//listView3.Items.Add(row2["Code"].ToString());
				try
				{
					//listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite stock"].ToString());
					piece.SubItems.Add(row2["Quantite stock"].ToString());
				}
				catch
				{
					//listView3.Items[listView3.Items.Count-1].SubItems.Add("0");
					piece.SubItems.Add("0");
				}
				try
				{
					//listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite reserve"].ToString());
					piece.SubItems.Add(row2["Quantite reserve"].ToString());
				}
				catch
				{
					//listView3.Items[listView3.Items.Count-1].SubItems.Add("0");
					piece.SubItems.Add("0");
				}
				try
				{
					//listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite disponible"].ToString());
					piece.SubItems.Add(row2["Quantite disponible"].ToString());
					qtedispo=System.Convert.ToInt32(row2["Quantite disponible"].ToString());
				}
				catch
				{
					//listView3.Items[listView3.Items.Count-1].SubItems.Add("0");
					piece.SubItems.Add("0");
				}
				try
				{
					//listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite commande"].ToString());
					piece.SubItems.Add(row2["Quantite commande"].ToString());
					qtecde=System.Convert.ToInt32(row2["Quantite commande"].ToString());
				}
				catch
				{
					//listView3.Items[listView3.Items.Count-1].SubItems.Add("0");
					piece.SubItems.Add("0");
				}
				int Theo=qtecde+qtedispo;
				//listView3.Items[listView3.Items.Count-1].SubItems.Add(Theo.ToString());
				piece.SubItems.Add(Theo.ToString());

				piece.Tag=row2["Identificateur"].ToString();
				listView3.Items.Add(piece);
				/*listView3.Items.Add(piece);
				listView3.Items.Add(row2["Code"].ToString());
				listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite stock"].ToString());
				listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite reserve"].ToString());
				listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite disponible"].ToString());
				listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite commande"].ToString());
				int Theo=System.Convert.ToInt32(row2["Quantite commande"].ToString())+System.Convert.ToInt32(row2["Quantite disponible"].ToString());
				listView3.Items[listView3.Items.Count-1].SubItems.Add(Theo.ToString());*/
			}
			this.Update();
			index+=1;
			listView3.Focus();
			listView3.Items[index].Selected=true;
			listView3.Items[index].Focused=true;
			
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			/*textBox3.Text=listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text.Trim('€',' ');
			textBox3.SelectAll();*/
		}

		private void AutresMAJ_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
				listView1.Items[listView1.SelectedIndices[0]+1].Selected=true;
	}

		private void textBox5_Enter(object sender, System.EventArgs e)
		{
			textBox5.SelectAll();
			this.Update();
		}

		private void listView3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue==13)
			{
				textBox5.Text=listView3.Items[listView3.SelectedIndices[0]].SubItems[1].Text;
				textBox6.Text=listView3.Items[listView3.SelectedIndices[0]].SubItems[2].Text;
				textBox7.Text=listView3.Items[listView3.SelectedIndices[0]].SubItems[3].Text;
				textBox8.Text=listView3.Items[listView3.SelectedIndices[0]].SubItems[4].Text;
				textBox9.Text=listView3.Items[listView3.SelectedIndices[0]].SubItems[5].Text;
				index=listView3.SelectedIndices[0];
				textBox5.Focus();
				textBox5.SelectionLength=textBox5.Text.Length;
				textBox5.SelectAll();
			}
		}

		private void listView3_Leave(object sender, System.EventArgs e)
		{
			if(listView3.SelectedIndices.Count>0)
				index=(int)listView3.SelectedIndices[0];
		}

		private void listView2_Leave(object sender, System.EventArgs e)
		{
			if(listView2.SelectedIndices.Count>0)
				index2=(int)listView2.SelectedIndices[0];
		}

		private void listView1_Leave(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count>0)
				index3=(int)listView1.SelectedIndices[0];
		}

		private void listView2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue==13)
			{
				textBox4.Text=listView2.Items[listView2.SelectedIndices[0]].SubItems[2].Text.Trim('€',' ');
				index2=listView2.SelectedIndices[0];
				textBox4.Focus();
				textBox4.SelectionLength=textBox4.Text.Length;
				textBox4.SelectAll();
			}
		}

		private void listView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue==13)
			{
				textBox3.Text=listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text.Trim('€',' ');
				index3=listView1.SelectedIndices[0];
				textBox3.Focus();
				textBox3.SelectionLength=textBox3.Text.Length;
				textBox3.SelectAll();
			}
		}

		private void textBox5_Leave(object sender, System.EventArgs e)
		{
			int QteTheo=System.Convert.ToInt32(textBox5.Text)+System.Convert.ToInt32(textBox8.Text)-System.Convert.ToInt32(textBox6.Text);
			int QteDispo=System.Convert.ToInt32(textBox5.Text)-System.Convert.ToInt32(textBox6.Text);
			textBox7.Text=QteDispo.ToString();
			textBox9.Text=QteTheo.ToString();
		}

		private void textBox6_Leave(object sender, System.EventArgs e)
		{
			int QteTheo=System.Convert.ToInt32(textBox5.Text)+System.Convert.ToInt32(textBox8.Text)-System.Convert.ToInt32(textBox6.Text);
			int QteDispo=System.Convert.ToInt32(textBox5.Text)-System.Convert.ToInt32(textBox6.Text);
			textBox7.Text=QteDispo.ToString();
			textBox9.Text=QteTheo.ToString();
		}

		private void textBox8_Leave(object sender, System.EventArgs e)
		{
			int QteTheo=System.Convert.ToInt32(textBox5.Text)+System.Convert.ToInt32(textBox8.Text)-System.Convert.ToInt32(textBox6.Text);
			int QteDispo=System.Convert.ToInt32(textBox5.Text)-System.Convert.ToInt32(textBox6.Text);
			textBox7.Text=QteDispo.ToString();
			textBox9.Text=QteTheo.ToString();
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void mtgcComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
					dataSet11.Clear();
				OleDbCommand Comm = new OleDbCommand();
				Comm.Connection = oleDbConnection1;
				Comm.CommandText = "select * from t_fournisseurs where nom='"+mtgcComboBox1.Text+"'";
				oleDbDataAdapter1.SelectCommand=Comm;
				oleDbDataAdapter1.Fill(dataSet11);
				textBox1.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Nom"].ToString();
				textBox2.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Code"].ToString();
				txrem.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["pourcentage remise"].ToString();
				txPAPV.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Coef PA PV"].ToString();
				Comm.CommandText="select * from t_type_machine where fournisseur='"+textBox2.Text+"'";
				oleDbDataAdapter2.SelectCommand=Comm;
				oleDbDataAdapter2.Fill(dataSet11);
				listView1.Items.Clear();
				foreach(DataRow row in dataSet11.Tables["t_type_machine"].Rows)
				{
					listView1.Items.Add(row["Code"].ToString());
					try
					{
						listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(row["Prix catalogue"].ToString()).ToString("c"));
					}
					catch
					{
						listView1.Items[listView1.Items.Count-1].SubItems.Add("0,00 €");
					}
					if(row["Mise a jour tarif"].ToString().Length>0)
						listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Mise a jour tarif"].ToString().Remove(10,9));
				}
				Comm.CommandText="select * from t_pieces_detachees where [code fournisseur principal]='"+textBox2.Text+"' ORDER BY Code";
				oleDbDataAdapter3.SelectCommand=Comm;
				oleDbDataAdapter3.Fill(dataSet11);
				listView2.Items.Clear();
				foreach(DataRow row2 in dataSet11.Tables["t_pieces_detachees"].Rows)
				{
					ListViewItem Piece= new ListViewItem(row2["Code"].ToString());
					Piece.SubItems.Add(row2["Designation"].ToString());
					if(row2["Prix achat brut"].ToString().Length>0)
						Piece.SubItems.Add(System.Convert.ToDecimal(row2["Prix achat brut"].ToString()).ToString("c"));
					else
						Piece.SubItems.Add("0,00 €");
					Piece.Tag=row2["Identificateur"].ToString();
					listView2.Items.Add(Piece);
					/*listView2.Items.Add(row2["Code"].ToString());
					listView2.Items[listView2.Items.Count-1].SubItems.Add(row2["Designation"].ToString());
					if(row2["Prix achat brut"].ToString().Length>0)
						listView2.Items[listView2.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(row2["Prix achat brut"].ToString()).ToString("c"));
					else
						listView2.Items[listView2.Items.Count-1].SubItems.Add("0,00 €");*/
				}
				listView3.Items.Clear();
				int	 qtecde=0;
				int qtedispo=0;
				foreach(DataRow row2 in dataSet11.Tables["t_pieces_detachees"].Rows)
				{
					ListViewItem piece = new ListViewItem(row2["Code"].ToString());
					//listView3.Items.Add(row2["Code"].ToString());
					try
					{
						//listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite stock"].ToString());
						piece.SubItems.Add(row2["Quantite stock"].ToString());
					}
					catch
					{
						//listView3.Items[listView3.Items.Count-1].SubItems.Add("0");
						piece.SubItems.Add("0");
					}
					try
					{
						//listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite reserve"].ToString());
						piece.SubItems.Add(row2["Quantite reserve"].ToString());
					}
					catch
					{
						//listView3.Items[listView3.Items.Count-1].SubItems.Add("0");
						piece.SubItems.Add("0");
					}
					try
					{
						//listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite disponible"].ToString());
						piece.SubItems.Add(row2["Quantite disponible"].ToString());
						qtedispo=System.Convert.ToInt32(row2["Quantite disponible"].ToString());
					}
					catch
					{
						//listView3.Items[listView3.Items.Count-1].SubItems.Add("0");
						piece.SubItems.Add("0");
					}
					try
					{
						//listView3.Items[listView3.Items.Count-1].SubItems.Add(row2["Quantite commande"].ToString());
						piece.SubItems.Add(row2["Quantite commande"].ToString());
						qtecde=System.Convert.ToInt32(row2["Quantite commande"].ToString());
					}
					catch
					{
						//listView3.Items[listView3.Items.Count-1].SubItems.Add("0");
						piece.SubItems.Add("0");
					}
					int Theo=qtecde+qtedispo;
					//listView3.Items[listView3.Items.Count-1].SubItems.Add(Theo.ToString());
					piece.SubItems.Add(Theo.ToString());

					piece.Tag=row2["Identificateur"].ToString();
					listView3.Items.Add(piece);
				}
			}
			}

	}
}
