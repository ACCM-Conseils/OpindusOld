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
	/// Description résumée de Commande.
	/// </summary>
	public class Commande : System.Windows.Forms.Form
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.TextBox textBox13;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private MTGCComboBox mtgcComboBox2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private int Agence;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private MTGCComboBox mtgcComboBox9;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.Label label53;
		private MTGCComboBox mtgcComboBox5;
		private MTGCComboBox mtgcComboBox4;
		private MTGCComboBox mtgcComboBox3;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.TextBox textBox20;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter6;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private OleDbTransaction Transac;
		private DataSet ds;
		private System.Windows.Forms.TextBox txNbPieces;
		private System.Windows.Forms.TextBox txSignature;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox txUnite;
		private System.Windows.Forms.TextBox txNet;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter7;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button11;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter9;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand9;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand8;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand8;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand8;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter10;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private bool save;
		private int countRow;
		private int Page;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand10;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand9;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Windows.Forms.Button button13;
		private int NumLigne;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.TextBox txidpiece;
		int index3;

		public Commande(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			this.Agence=Agence;
			save=false;

			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAD = new OleDbDataAdapter();
			ds = new DataSet();

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

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Commande));
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txidpiece = new System.Windows.Forms.TextBox();
			this.button11 = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label22 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.txNet = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txSignature = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.button13 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.textBox35 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.mtgcComboBox9 = new MTGCComboBox();
			this.label58 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.mtgcComboBox5 = new MTGCComboBox();
			this.mtgcComboBox4 = new MTGCComboBox();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.label52 = new System.Windows.Forms.Label();
			this.label51 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.txUnite = new System.Windows.Forms.TextBox();
			this.button10 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.txNbPieces = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
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
			this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter5 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbDataAdapter6 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter7 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter9 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand9 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand8 = new System.Data.OleDb.OleDbCommand();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.oleDbDataAdapter10 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbInsertCommand9 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand10 = new System.Data.OleDb.OleDbCommand();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPageEX2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabPageEX3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Controls.Add(this.tabPageEX2);
			this.tabControlEX1.Controls.Add(this.tabPageEX3);
			this.tabControlEX1.Location = new System.Drawing.Point(-5, 8);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(941, 616);
			this.tabControlEX1.TabColor = System.Drawing.Color.DarkGray;
			this.tabControlEX1.TabIndex = 1;
			this.tabControlEX1.TabStop = false;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.tabPageEX1.Controls.Add(this.dateTimePicker2);
			this.tabPageEX1.Controls.Add(this.groupBox3);
			this.tabPageEX1.Controls.Add(this.groupBox2);
			this.tabPageEX1.Controls.Add(this.groupBox1);
			this.tabPageEX1.Controls.Add(this.checkBox3);
			this.tabPageEX1.Controls.Add(this.checkBox2);
			this.tabPageEX1.Controls.Add(this.checkBox1);
			this.tabPageEX1.Controls.Add(this.label2);
			this.tabPageEX1.Controls.Add(this.label1);
			this.tabPageEX1.Controls.Add(this.textBox1);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(933, 587);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Commande";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Enabled = false;
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(152, 24);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
			this.dateTimePicker2.TabIndex = 10;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox3.Controls.Add(this.txidpiece);
			this.groupBox3.Controls.Add(this.button11);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.textBox9);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Controls.Add(this.textBox12);
			this.groupBox3.Controls.Add(this.textBox11);
			this.groupBox3.Controls.Add(this.textBox10);
			this.groupBox3.Controls.Add(this.listView1);
			this.groupBox3.Location = new System.Drawing.Point(285, 160);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(632, 410);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			// 
			// txidpiece
			// 
			this.txidpiece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txidpiece.Location = new System.Drawing.Point(336, 256);
			this.txidpiece.Name = "txidpiece";
			this.txidpiece.Size = new System.Drawing.Size(56, 20);
			this.txidpiece.TabIndex = 11;
			this.txidpiece.Text = "";
			this.txidpiece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txidpiece.Visible = false;
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.Lavender;
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button11.ForeColor = System.Drawing.Color.Red;
			this.button11.Location = new System.Drawing.Point(248, 256);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 20);
			this.button11.TabIndex = 8;
			this.button11.Text = "Valider";
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(162, 240);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(66, 14);
			this.label16.TabIndex = 10;
			this.label16.Text = "Qte";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(17, 240);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(120, 15);
			this.label15.TabIndex = 9;
			this.label15.Text = "Code pièce";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox9
			// 
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Location = new System.Drawing.Point(161, 256);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(64, 20);
			this.textBox9.TabIndex = 7;
			this.textBox9.Text = "0";
			this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(16, 256);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(119, 20);
			this.textBox5.TabIndex = 6;
			this.textBox5.Text = "";
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Lavender;
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Red;
			this.button6.Location = new System.Drawing.Point(16, 296);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(120, 23);
			this.button6.TabIndex = 5;
			this.button6.Text = "Solder";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// textBox12
			// 
			this.textBox12.BackColor = System.Drawing.Color.DarkGray;
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Enabled = false;
			this.textBox12.Location = new System.Drawing.Point(118, 208);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(112, 20);
			this.textBox12.TabIndex = 3;
			this.textBox12.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.Color.DarkGray;
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Enabled = false;
			this.textBox11.Location = new System.Drawing.Point(229, 208);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(112, 20);
			this.textBox11.TabIndex = 2;
			this.textBox11.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.Color.DarkGray;
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Enabled = false;
			this.textBox10.Location = new System.Drawing.Point(340, 208);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(110, 20);
			this.textBox10.TabIndex = 1;
			this.textBox10.Text = "";
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.DarkGray;
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader3,
																						this.columnHeader4,
																						this.columnHeader7});
			this.listView1.Enabled = false;
			this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(8, 16);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(608, 184);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Code";
			this.columnHeader1.Width = 180;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Reception";
			this.columnHeader2.Width = 110;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Commande";
			this.columnHeader3.Width = 110;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Difference";
			this.columnHeader4.Width = 110;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "idpiece";
			this.columnHeader7.Width = 80;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.txNet);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.textBox8);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.txSignature);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(8, 160);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(271, 410);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(72, 161);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(24, 16);
			this.label22.TabIndex = 15;
			this.label22.Text = "%";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
			this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 32);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
			this.dateTimePicker1.TabIndex = 14;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Lavender;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.Enabled = false;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Blue;
			this.button4.Location = new System.Drawing.Point(144, 232);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(104, 44);
			this.button4.TabIndex = 13;
			this.button4.Text = "Valider";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lavender;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Enabled = false;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(144, 192);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 20);
			this.button3.TabIndex = 12;
			this.button3.Text = "Imprimer";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txNet
			// 
			this.txNet.BackColor = System.Drawing.Color.DarkGray;
			this.txNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txNet.Enabled = false;
			this.txNet.Location = new System.Drawing.Point(16, 232);
			this.txNet.Name = "txNet";
			this.txNet.Size = new System.Drawing.Size(96, 20);
			this.txNet.TabIndex = 11;
			this.txNet.Text = "0";
			this.txNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(16, 216);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(168, 16);
			this.label14.TabIndex = 10;
			this.label14.Text = "Total net commande";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.DarkGray;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Enabled = false;
			this.textBox8.Location = new System.Drawing.Point(16, 192);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(96, 20);
			this.textBox8.TabIndex = 9;
			this.textBox8.Text = "0";
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(16, 176);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 16);
			this.label13.TabIndex = 8;
			this.label13.Text = "Montant remise";
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.DarkGray;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Enabled = false;
			this.textBox7.Location = new System.Drawing.Point(16, 152);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(54, 20);
			this.textBox7.TabIndex = 7;
			this.textBox7.Text = "0";
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(16, 136);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(168, 16);
			this.label12.TabIndex = 6;
			this.label12.Text = "Remise fournisseur";
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.DarkGray;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Enabled = false;
			this.textBox6.Location = new System.Drawing.Point(16, 112);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(96, 20);
			this.textBox6.TabIndex = 5;
			this.textBox6.Text = "0";
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(16, 96);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 16);
			this.label11.TabIndex = 4;
			this.label11.Text = "Total commande";
			// 
			// txSignature
			// 
			this.txSignature.BackColor = System.Drawing.Color.DarkGray;
			this.txSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txSignature.Enabled = false;
			this.txSignature.Location = new System.Drawing.Point(16, 72);
			this.txSignature.Name = "txSignature";
			this.txSignature.Size = new System.Drawing.Size(232, 20);
			this.txSignature.TabIndex = 3;
			this.txSignature.Text = "MADAME PERRET LEBATEUX";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(16, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 16);
			this.label10.TabIndex = 2;
			this.label10.Text = "Signature";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = "Date livraison";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.textBox18);
			this.groupBox1.Controls.Add(this.mtgcComboBox2);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.mtgcComboBox1);
			this.groupBox1.Location = new System.Drawing.Point(8, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(909, 100);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fournisseur";
			// 
			// textBox18
			// 
			this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox18.Location = new System.Drawing.Point(728, 16);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(56, 20);
			this.textBox18.TabIndex = 10;
			this.textBox18.Text = "";
			// 
			// mtgcComboBox2
			// 
			this.mtgcComboBox2.BackColor = System.Drawing.Color.DarkGray;
			this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox2.ColumnNum = 4;
			this.mtgcComboBox2.ColumnWidth = "200;200;50;200";
			this.mtgcComboBox2.DisplayMember = "Text";
			this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox2.DropDownWidth = 670;
			this.mtgcComboBox2.Enabled = false;
			this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox2.GridLineHorizontal = false;
			this.mtgcComboBox2.GridLineVertical = false;
			this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox2.Location = new System.Drawing.Point(8, 24);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(304, 21);
			this.mtgcComboBox2.TabIndex = 9;
			this.mtgcComboBox2.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox2_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(392, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(304, 16);
			this.label8.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(336, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(336, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(384, 16);
			this.label6.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(336, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(368, 16);
			this.label5.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(336, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(336, 16);
			this.label4.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Correspondants";
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BackColor = System.Drawing.Color.DarkGray;
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
			this.mtgcComboBox1.Enabled = false;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = false;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(8, 64);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(304, 21);
			this.mtgcComboBox1.TabIndex = 2;
			// 
			// checkBox3
			// 
			this.checkBox3.BackColor = System.Drawing.Color.Transparent;
			this.checkBox3.Enabled = false;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(692, 24);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(72, 24);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.Text = "Soldée";
			// 
			// checkBox2
			// 
			this.checkBox2.BackColor = System.Drawing.Color.Transparent;
			this.checkBox2.Enabled = false;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(624, 24);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(64, 24);
			this.checkBox2.TabIndex = 5;
			this.checkBox2.Text = "Validée";
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Enabled = false;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(554, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(64, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Editée";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Date commande";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Numéro commande";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.DarkGray;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(16, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(112, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabPageEX2
			// 
			this.tabPageEX2.Controls.Add(this.button13);
			this.tabPageEX2.Controls.Add(this.button15);
			this.tabPageEX2.Controls.Add(this.button14);
			this.tabPageEX2.Controls.Add(this.textBox35);
			this.tabPageEX2.Controls.Add(this.button2);
			this.tabPageEX2.Controls.Add(this.textBox3);
			this.tabPageEX2.Controls.Add(this.mtgcComboBox9);
			this.tabPageEX2.Controls.Add(this.label58);
			this.tabPageEX2.Controls.Add(this.label53);
			this.tabPageEX2.Controls.Add(this.mtgcComboBox5);
			this.tabPageEX2.Controls.Add(this.mtgcComboBox4);
			this.tabPageEX2.Controls.Add(this.mtgcComboBox3);
			this.tabPageEX2.Controls.Add(this.label52);
			this.tabPageEX2.Controls.Add(this.label51);
			this.tabPageEX2.Controls.Add(this.label30);
			this.tabPageEX2.Controls.Add(this.label29);
			this.tabPageEX2.Controls.Add(this.numericUpDown2);
			this.tabPageEX2.Controls.Add(this.numericUpDown1);
			this.tabPageEX2.Controls.Add(this.label28);
			this.tabPageEX2.Controls.Add(this.label27);
			this.tabPageEX2.Controls.Add(this.textBox4);
			this.tabPageEX2.Controls.Add(this.textBox14);
			this.tabPageEX2.Controls.Add(this.label26);
			this.tabPageEX2.Controls.Add(this.textBox15);
			this.tabPageEX2.Controls.Add(this.textBox16);
			this.tabPageEX2.Controls.Add(this.txUnite);
			this.tabPageEX2.Controls.Add(this.button10);
			this.tabPageEX2.Controls.Add(this.textBox2);
			this.tabPageEX2.Controls.Add(this.textBox20);
			this.tabPageEX2.Controls.Add(this.txNbPieces);
			this.tabPageEX2.Controls.Add(this.label23);
			this.tabPageEX2.Controls.Add(this.listView2);
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(933, 587);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Détail";
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.Lavender;
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button13.Location = new System.Drawing.Point(21, 463);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(159, 23);
			this.button13.TabIndex = 64;
			this.button13.Text = "Supprimer la ligne";
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.White;
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button15.Location = new System.Drawing.Point(422, 131);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(60, 21);
			this.button15.TabIndex = 63;
			this.button15.TabStop = false;
			this.button15.Text = "Annuler";
			this.button15.Visible = false;
			this.button15.Click += new System.EventHandler(this.button15_Click);
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.MistyRose;
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button14.Location = new System.Drawing.Point(358, 131);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(60, 21);
			this.button14.TabIndex = 62;
			this.button14.TabStop = false;
			this.button14.Text = "Valider";
			this.button14.Visible = false;
			// 
			// textBox35
			// 
			this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox35.Location = new System.Drawing.Point(206, 131);
			this.textBox35.Name = "textBox35";
			this.textBox35.Size = new System.Drawing.Size(138, 20);
			this.textBox35.TabIndex = 61;
			this.textBox35.TabStop = false;
			this.textBox35.Text = "";
			this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox35.Visible = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lavender;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(206, 102);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 23);
			this.button2.TabIndex = 60;
			this.button2.TabStop = false;
			this.button2.Text = "Nouvelle référence";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(318, 103);
			this.textBox3.Name = "textBox3";
			this.textBox3.TabIndex = 59;
			this.textBox3.TabStop = false;
			this.textBox3.Text = "";
			this.textBox3.Visible = false;
			// 
			// mtgcComboBox9
			// 
			this.mtgcComboBox9.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox9.ColumnNum = 4;
			this.mtgcComboBox9.ColumnWidth = "50;150;200;200";
			this.mtgcComboBox9.DisplayMember = "Text";
			this.mtgcComboBox9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox9.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox9.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox9.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox9.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox9.DropDownWidth = 620;
			this.mtgcComboBox9.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox9.GridLineHorizontal = false;
			this.mtgcComboBox9.GridLineVertical = true;
			this.mtgcComboBox9.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox9.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox9.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox9.Location = new System.Drawing.Point(22, 63);
			this.mtgcComboBox9.ManagingFastMouseMoving = true;
			this.mtgcComboBox9.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox9.Name = "mtgcComboBox9";
			this.mtgcComboBox9.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox9.Size = new System.Drawing.Size(136, 21);
			this.mtgcComboBox9.TabIndex = 1;
			this.mtgcComboBox9.TabStop = false;
			this.mtgcComboBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox9_KeyDown);
			// 
			// label58
			// 
			this.label58.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label58.Location = new System.Drawing.Point(9, 47);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(100, 16);
			this.label58.TabIndex = 58;
			this.label58.Text = "Identificateur";
			// 
			// label53
			// 
			this.label53.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label53.Location = new System.Drawing.Point(206, 7);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(168, 16);
			this.label53.TabIndex = 57;
			this.label53.Text = "Désignation";
			// 
			// mtgcComboBox5
			// 
			this.mtgcComboBox5.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox5.ColumnNum = 2;
			this.mtgcComboBox5.ColumnWidth = "150;150";
			this.mtgcComboBox5.DisplayMember = "Text";
			this.mtgcComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox5.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox5.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox5.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox5.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox5.DropDownWidth = 320;
			this.mtgcComboBox5.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox5.GridLineHorizontal = false;
			this.mtgcComboBox5.GridLineVertical = true;
			this.mtgcComboBox5.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox5.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox5.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox5.Location = new System.Drawing.Point(22, 103);
			this.mtgcComboBox5.ManagingFastMouseMoving = true;
			this.mtgcComboBox5.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox5.Name = "mtgcComboBox5";
			this.mtgcComboBox5.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox5.Size = new System.Drawing.Size(136, 21);
			this.mtgcComboBox5.TabIndex = 2;
			this.mtgcComboBox5.TabStop = false;
			this.mtgcComboBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox5_KeyDown);
			// 
			// mtgcComboBox4
			// 
			this.mtgcComboBox4.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox4.ColumnNum = 2;
			this.mtgcComboBox4.ColumnWidth = "50;200";
			this.mtgcComboBox4.DisplayMember = "Text";
			this.mtgcComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox4.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox4.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox4.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox4.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox4.DropDownWidth = 270;
			this.mtgcComboBox4.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox4.GridLineHorizontal = false;
			this.mtgcComboBox4.GridLineVertical = false;
			this.mtgcComboBox4.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox4.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox4.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox4.Location = new System.Drawing.Point(510, 119);
			this.mtgcComboBox4.ManagingFastMouseMoving = true;
			this.mtgcComboBox4.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox4.Name = "mtgcComboBox4";
			this.mtgcComboBox4.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox4.Size = new System.Drawing.Size(104, 21);
			this.mtgcComboBox4.TabIndex = 5;
			this.mtgcComboBox4.TabStop = false;
			// 
			// mtgcComboBox3
			// 
			this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox3.ColumnNum = 4;
			this.mtgcComboBox3.ColumnWidth = "150;200;250;50";
			this.mtgcComboBox3.DisplayMember = "Text";
			this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox3.DropDownWidth = 670;
			this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox3.GridLineHorizontal = false;
			this.mtgcComboBox3.GridLineVertical = true;
			this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox3.Location = new System.Drawing.Point(22, 23);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(136, 21);
			this.mtgcComboBox3.TabIndex = 0;
			this.mtgcComboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox3_KeyDown);
			// 
			// label52
			// 
			this.label52.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label52.Location = new System.Drawing.Point(697, 7);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(56, 16);
			this.label52.TabIndex = 54;
			this.label52.Text = "Remise";
			this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label51
			// 
			this.label51.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label51.Location = new System.Drawing.Point(627, 7);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(56, 16);
			this.label51.TabIndex = 53;
			this.label51.Text = "Qté";
			this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label30.Location = new System.Drawing.Point(22, 87);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(136, 16);
			this.label30.TabIndex = 52;
			this.label30.Text = "Ancienne référence";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label29.Location = new System.Drawing.Point(22, 7);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(136, 16);
			this.label29.TabIndex = 51;
			this.label29.Text = "Code pièce";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown2.DecimalPlaces = 1;
			this.numericUpDown2.Increment = new System.Decimal(new int[] {
																			 1,
																			 0,
																			 0,
																			 65536});
			this.numericUpDown2.Location = new System.Drawing.Point(697, 23);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(56, 20);
			this.numericUpDown2.TabIndex = 4;
			this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown2.Enter += new System.EventHandler(this.numericUpDown2_Enter);
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
			this.numericUpDown2.Leave += new System.EventHandler(this.numericUpDown2_Leave);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown1.Location = new System.Drawing.Point(627, 23);
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown1_Enter);
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown1_Leave);
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(510, 103);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(104, 16);
			this.label28.TabIndex = 48;
			this.label28.Text = "Cause";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.Location = new System.Drawing.Point(681, 107);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(79, 16);
			this.label27.TabIndex = 47;
			this.label27.Text = "Total ligne :";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(769, 104);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(60, 20);
			this.textBox4.TabIndex = 46;
			this.textBox4.TabStop = false;
			this.textBox4.Text = "";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox14
			// 
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox14.Location = new System.Drawing.Point(206, 71);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(212, 20);
			this.textBox14.TabIndex = 45;
			this.textBox14.TabStop = false;
			this.textBox14.Text = "";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.Location = new System.Drawing.Point(193, 55);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(100, 16);
			this.label26.TabIndex = 44;
			this.label26.Text = "Code provisoire";
			// 
			// textBox15
			// 
			this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox15.Location = new System.Drawing.Point(769, 64);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(60, 20);
			this.textBox15.TabIndex = 6;
			this.textBox15.Text = "";
			this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
			this.textBox15.Leave += new System.EventHandler(this.textBox15_Leave);
			this.textBox15.Enter += new System.EventHandler(this.textBox15_Enter);
			// 
			// textBox16
			// 
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox16.Location = new System.Drawing.Point(422, 71);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(192, 20);
			this.textBox16.TabIndex = 42;
			this.textBox16.TabStop = false;
			this.textBox16.Text = "";
			// 
			// txUnite
			// 
			this.txUnite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txUnite.Location = new System.Drawing.Point(769, 24);
			this.txUnite.Name = "txUnite";
			this.txUnite.Size = new System.Drawing.Size(60, 20);
			this.txUnite.TabIndex = 41;
			this.txUnite.TabStop = false;
			this.txUnite.Text = "";
			this.txUnite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.Lavender;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Location = new System.Drawing.Point(166, 23);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(32, 20);
			this.button10.TabIndex = 50;
			this.button10.TabStop = false;
			this.button10.Text = "...";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(206, 23);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(408, 20);
			this.textBox2.TabIndex = 39;
			this.textBox2.TabStop = false;
			this.textBox2.Text = "";
			// 
			// textBox20
			// 
			this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox20.Location = new System.Drawing.Point(206, 103);
			this.textBox20.Name = "textBox20";
			this.textBox20.TabIndex = 49;
			this.textBox20.TabStop = false;
			this.textBox20.Text = "";
			this.textBox20.Visible = false;
			// 
			// txNbPieces
			// 
			this.txNbPieces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txNbPieces.Location = new System.Drawing.Point(717, 472);
			this.txNbPieces.Name = "txNbPieces";
			this.txNbPieces.ReadOnly = true;
			this.txNbPieces.TabIndex = 16;
			this.txNbPieces.TabStop = false;
			this.txNbPieces.Text = "0";
			this.txNbPieces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.Location = new System.Drawing.Point(717, 456);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(104, 16);
			this.label23.TabIndex = 15;
			this.label23.Text = "Nombre de pièces";
			// 
			// listView2
			// 
			this.listView2.BackColor = System.Drawing.Color.DarkGray;
			this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader5,
																						this.columnHeader6,
																						this.columnHeader8,
																						this.columnHeader9,
																						this.columnHeader10,
																						this.columnHeader11});
			this.listView2.Enabled = false;
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new System.Drawing.Point(21, 159);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(808, 292);
			this.listView2.TabIndex = 0;
			this.listView2.TabStop = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Code pièce";
			this.columnHeader5.Width = 80;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Désign. Pièce";
			this.columnHeader6.Width = 400;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Qté";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "P.A Brut";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 80;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "P.A.";
			this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader10.Width = 80;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Total ligne";
			this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader11.Width = 80;
			// 
			// tabPageEX3
			// 
			this.tabPageEX3.Controls.Add(this.pictureBox1);
			this.tabPageEX3.Controls.Add(this.textBox13);
			this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX3.Name = "tabPageEX3";
			this.tabPageEX3.Size = new System.Drawing.Size(933, 587);
			this.tabPageEX3.TabIndex = 2;
			this.tabPageEX3.Text = "Commentaires";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(753, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 56);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// textBox13
			// 
			this.textBox13.BackColor = System.Drawing.Color.DarkGray;
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox13.Enabled = false;
			this.textBox13.Location = new System.Drawing.Point(8, 62);
			this.textBox13.Multiline = true;
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(808, 208);
			this.textBox13.TabIndex = 0;
			this.textBox13.Text = "?";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.White;
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Blue;
			this.button7.Location = new System.Drawing.Point(16, 648);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(100, 23);
			this.button7.TabIndex = 2;
			this.button7.TabStop = false;
			this.button7.Text = "Nouvelle Cde";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.White;
			this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button8.Enabled = false;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.Blue;
			this.button8.Location = new System.Drawing.Point(128, 648);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(100, 23);
			this.button8.TabIndex = 3;
			this.button8.TabStop = false;
			this.button8.Text = "Enregistrer";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.White;
			this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button9.Enabled = false;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button9.ForeColor = System.Drawing.Color.Red;
			this.button9.Location = new System.Drawing.Point(520, 648);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(100, 23);
			this.button9.TabIndex = 4;
			this.button9.TabStop = false;
			this.button9.Text = "Supprimer";
			this.button9.Click += new System.EventHandler(this.button9_Click);
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
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_fournisseurs", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																						  new System.Data.Common.DataColumnMapping("Nom", "Nom")})});
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
			this.oleDbInsertCommand2.CommandText = "INSERT INTO T_fournisseurs(Code, Nom) VALUES (?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Code, Nom FROM T_fournisseurs ORDER BY Nom";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = "UPDATE T_fournisseurs SET Code = ?, Nom = ? WHERE (Code = ?) AND (Nom = ? OR ? IS" +
				" NULL AND Nom IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_pieces_detachees", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							  new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																							  new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																							  new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
																																																							  new System.Data.Common.DataColumnMapping("Identificateur", "Identificateur"),
																																																							  new System.Data.Common.DataColumnMapping("Prix Achat Brut", "Prix Achat Brut")})});
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = @"SELECT T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom, T_fournisseurs.Code AS Expr1, T_pieces_detachees.Identificateur, T_pieces_detachees.[Prix Achat Brut] FROM (T_pieces_detachees INNER JOIN T_fournisseurs ON T_pieces_detachees.[Code Fournisseur Principal] = T_fournisseurs.Code) ORDER BY T_pieces_detachees.Code";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand3;
			this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand3;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_fournisseurs_Corresp", new System.Data.Common.DataColumnMapping[] {
																																																								  new System.Data.Common.DataColumnMapping("Cle", "Cle"),
																																																								  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																								  new System.Data.Common.DataColumnMapping("E_mail", "E_mail"),
																																																								  new System.Data.Common.DataColumnMapping("Fonction", "Fonction"),
																																																								  new System.Data.Common.DataColumnMapping("Memo", "Memo"),
																																																								  new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																								  new System.Data.Common.DataColumnMapping("Prenom", "Prenom"),
																																																								  new System.Data.Common.DataColumnMapping("Service", "Service"),
																																																								  new System.Data.Common.DataColumnMapping("Telecopie", "Telecopie"),
																																																								  new System.Data.Common.DataColumnMapping("Telephone", "Telephone")})});
			this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand3;
			// 
			// oleDbDeleteCommand3
			// 
			this.oleDbDeleteCommand3.CommandText = @"DELETE FROM T_fournisseurs_Corresp WHERE (Cle = ?) AND (Code = ? OR ? IS NULL AND Code IS NULL) AND (E_mail = ? OR ? IS NULL AND E_mail IS NULL) AND (Fonction = ? OR ? IS NULL AND Fonction IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Prenom = ? OR ? IS NULL AND Prenom IS NULL) AND (Service = ? OR ? IS NULL AND Service IS NULL) AND (Telecopie = ? OR ? IS NULL AND Telecopie IS NULL) AND (Telephone = ? OR ? IS NULL AND Telephone IS NULL)";
			this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand3
			// 
			this.oleDbInsertCommand3.CommandText = "INSERT INTO T_fournisseurs_Corresp(Code, E_mail, Fonction, [Memo], Nom, Prenom, S" +
				"ervice, Telecopie, Telephone) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, "E_mail"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, "Fonction"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, "Prenom"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Service", System.Data.OleDb.OleDbType.VarWChar, 50, "Service"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = "SELECT Cle, Code, E_mail, Fonction, [Memo], Nom, Prenom, Service, Telecopie, Tele" +
				"phone FROM T_fournisseurs_Corresp";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand3
			// 
			this.oleDbUpdateCommand3.CommandText = @"UPDATE T_fournisseurs_Corresp SET Code = ?, E_mail = ?, Fonction = ?, [Memo] = ?, Nom = ?, Prenom = ?, Service = ?, Telecopie = ?, Telephone = ? WHERE (Cle = ?) AND (Code = ? OR ? IS NULL AND Code IS NULL) AND (E_mail = ? OR ? IS NULL AND E_mail IS NULL) AND (Fonction = ? OR ? IS NULL AND Fonction IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Prenom = ? OR ? IS NULL AND Prenom IS NULL) AND (Service = ? OR ? IS NULL AND Service IS NULL) AND (Telecopie = ? OR ? IS NULL AND Telecopie IS NULL) AND (Telephone = ? OR ? IS NULL AND Telephone IS NULL)";
			this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, "E_mail"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, "Fonction"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, "Prenom"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Service", System.Data.OleDb.OleDbType.VarWChar, 50, "Service"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter5
			// 
			this.oleDbDataAdapter5.DeleteCommand = this.oleDbDeleteCommand4;
			this.oleDbDataAdapter5.InsertCommand = this.oleDbInsertCommand4;
			this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
			this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_CDE_Lignes", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("Code piece", "Code piece"),
																																																						new System.Data.Common.DataColumnMapping("Date livraison", "Date livraison"),
																																																						new System.Data.Common.DataColumnMapping("Date reception1", "Date reception1"),
																																																						new System.Data.Common.DataColumnMapping("Date reception2", "Date reception2"),
																																																						new System.Data.Common.DataColumnMapping("Date reception3", "Date reception3"),
																																																						new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																						new System.Data.Common.DataColumnMapping("Id_Ligne", "Id_Ligne"),
																																																						new System.Data.Common.DataColumnMapping("N° Commande", "N° Commande"),
																																																						new System.Data.Common.DataColumnMapping("N° Devis", "N° Devis"),
																																																						new System.Data.Common.DataColumnMapping("Prix achat", "Prix achat"),
																																																						new System.Data.Common.DataColumnMapping("Quantite", "Quantite"),
																																																						new System.Data.Common.DataColumnMapping("Quantite devis1", "Quantite devis1"),
																																																						new System.Data.Common.DataColumnMapping("Quantite devis2", "Quantite devis2"),
																																																						new System.Data.Common.DataColumnMapping("Quantite devis3", "Quantite devis3"),
																																																						new System.Data.Common.DataColumnMapping("Quantite reception", "Quantite reception"),
																																																						new System.Data.Common.DataColumnMapping("Total ligne", "Total ligne"),
																																																						new System.Data.Common.DataColumnMapping("Total ligne reception", "Total ligne reception")})});
			this.oleDbDataAdapter5.UpdateCommand = this.oleDbUpdateCommand4;
			// 
			// oleDbDeleteCommand4
			// 
			this.oleDbDeleteCommand4.CommandText = @"DELETE FROM T_CDE_Lignes WHERE (Id_Ligne = ?) AND ([Code piece] = ? OR ? IS NULL AND [Code piece] IS NULL) AND ([Date livraison] = ? OR ? IS NULL AND [Date livraison] IS NULL) AND ([Date reception1] = ? OR ? IS NULL AND [Date reception1] IS NULL) AND ([Date reception2] = ? OR ? IS NULL AND [Date reception2] IS NULL) AND ([Date reception3] = ? OR ? IS NULL AND [Date reception3] IS NULL) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND ([N° Commande] = ? OR ? IS NULL AND [N° Commande] IS NULL) AND ([N° Devis] = ? OR ? IS NULL AND [N° Devis] IS NULL) AND ([Prix achat] = ? OR ? IS NULL AND [Prix achat] IS NULL) AND (Quantite = ? OR ? IS NULL AND Quantite IS NULL) AND ([Quantite devis1] = ? OR ? IS NULL AND [Quantite devis1] IS NULL) AND ([Quantite devis2] = ? OR ? IS NULL AND [Quantite devis2] IS NULL) AND ([Quantite devis3] = ? OR ? IS NULL AND [Quantite devis3] IS NULL) AND ([Quantite reception] = ? OR ? IS NULL AND [Quantite reception] IS NULL) AND ([Total ligne] = ? OR ? IS NULL AND [Total ligne] IS NULL) AND ([Total ligne reception] = ? OR ? IS NULL AND [Total ligne reception] IS NULL)";
			this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_Ligne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_Ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception11", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception2", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception21", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception3", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception31", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix achat", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix achat", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_reception", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite reception", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_reception1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite reception", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_ligne", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_ligne1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_ligne_reception", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total ligne reception", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_ligne_reception1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total ligne reception", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand4
			// 
			this.oleDbInsertCommand4.CommandText = @"INSERT INTO T_CDE_Lignes([Code piece], [Date livraison], [Date reception1], [Date reception2], [Date reception3], Designation, [N° Commande], [N° Devis], [Prix achat], Quantite, [Quantite devis1], [Quantite devis2], [Quantite devis3], [Quantite reception], [Total ligne], [Total ligne reception]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_piece", System.Data.OleDb.OleDbType.Integer, 0, "Code piece"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, "Date livraison"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reception1", System.Data.OleDb.OleDbType.DBDate, 0, "Date reception1"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reception2", System.Data.OleDb.OleDbType.DBDate, 0, "Date reception2"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reception3", System.Data.OleDb.OleDbType.DBDate, 0, "Date reception3"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_achat", System.Data.OleDb.OleDbType.Double, 0, "Prix achat"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite", System.Data.OleDb.OleDbType.Double, 0, "Quantite"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_devis1", System.Data.OleDb.OleDbType.Double, 0, "Quantite devis1"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_devis2", System.Data.OleDb.OleDbType.Double, 0, "Quantite devis2"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_devis3", System.Data.OleDb.OleDbType.Double, 0, "Quantite devis3"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_reception", System.Data.OleDb.OleDbType.Double, 0, "Quantite reception"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_ligne", System.Data.OleDb.OleDbType.Double, 0, "Total ligne"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_ligne_reception", System.Data.OleDb.OleDbType.Double, 0, "Total ligne reception"));
			// 
			// oleDbSelectCommand5
			// 
			this.oleDbSelectCommand5.CommandText = @"SELECT [Code piece], [Date livraison], [Date reception1], [Date reception2], [Date reception3], Designation, Id_Ligne, [N° Commande], [N° Devis], [Prix achat], Quantite, [Quantite devis1], [Quantite devis2], [Quantite devis3], [Quantite reception], [Total ligne], [Total ligne reception] FROM T_CDE_Lignes";
			this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand4
			// 
			this.oleDbUpdateCommand4.CommandText = @"UPDATE T_CDE_Lignes SET [Code piece] = ?, [Date livraison] = ?, [Date reception1] = ?, [Date reception2] = ?, [Date reception3] = ?, Designation = ?, [N° Commande] = ?, [N° Devis] = ?, [Prix achat] = ?, Quantite = ?, [Quantite devis1] = ?, [Quantite devis2] = ?, [Quantite devis3] = ?, [Quantite reception] = ?, [Total ligne] = ?, [Total ligne reception] = ? WHERE (Id_Ligne = ?) AND ([Code piece] = ? OR ? IS NULL AND [Code piece] IS NULL) AND ([Date livraison] = ? OR ? IS NULL AND [Date livraison] IS NULL) AND ([Date reception1] = ? OR ? IS NULL AND [Date reception1] IS NULL) AND ([Date reception2] = ? OR ? IS NULL AND [Date reception2] IS NULL) AND ([Date reception3] = ? OR ? IS NULL AND [Date reception3] IS NULL) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND ([N° Commande] = ? OR ? IS NULL AND [N° Commande] IS NULL) AND ([N° Devis] = ? OR ? IS NULL AND [N° Devis] IS NULL) AND ([Prix achat] = ? OR ? IS NULL AND [Prix achat] IS NULL) AND (Quantite = ? OR ? IS NULL AND Quantite IS NULL) AND ([Quantite devis1] = ? OR ? IS NULL AND [Quantite devis1] IS NULL) AND ([Quantite devis2] = ? OR ? IS NULL AND [Quantite devis2] IS NULL) AND ([Quantite devis3] = ? OR ? IS NULL AND [Quantite devis3] IS NULL) AND ([Quantite reception] = ? OR ? IS NULL AND [Quantite reception] IS NULL) AND ([Total ligne] = ? OR ? IS NULL AND [Total ligne] IS NULL) AND ([Total ligne reception] = ? OR ? IS NULL AND [Total ligne reception] IS NULL)";
			this.oleDbUpdateCommand4.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_piece", System.Data.OleDb.OleDbType.Integer, 0, "Code piece"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, "Date livraison"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reception1", System.Data.OleDb.OleDbType.DBDate, 0, "Date reception1"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reception2", System.Data.OleDb.OleDbType.DBDate, 0, "Date reception2"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reception3", System.Data.OleDb.OleDbType.DBDate, 0, "Date reception3"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_achat", System.Data.OleDb.OleDbType.Double, 0, "Prix achat"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite", System.Data.OleDb.OleDbType.Double, 0, "Quantite"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_devis1", System.Data.OleDb.OleDbType.Double, 0, "Quantite devis1"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_devis2", System.Data.OleDb.OleDbType.Double, 0, "Quantite devis2"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_devis3", System.Data.OleDb.OleDbType.Double, 0, "Quantite devis3"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_reception", System.Data.OleDb.OleDbType.Double, 0, "Quantite reception"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_ligne", System.Data.OleDb.OleDbType.Double, 0, "Total ligne"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_ligne_reception", System.Data.OleDb.OleDbType.Double, 0, "Total ligne reception"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_Ligne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_Ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_livraison1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date livraison", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception11", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception2", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception21", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception3", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reception31", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reception3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix achat", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix achat", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_devis31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite devis3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_reception", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite reception", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_reception1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite reception", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_ligne", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_ligne1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_ligne_reception", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total ligne reception", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_ligne_reception1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total ligne reception", System.Data.DataRowVersion.Original, null));
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(864, 632);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 48);
			this.button1.TabIndex = 7;
			this.button1.TabStop = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// oleDbDataAdapter6
			// 
			this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand5;
			this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand5;
			this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
			this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_causes", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																					new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
			this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand5;
			// 
			// oleDbDeleteCommand5
			// 
			this.oleDbDeleteCommand5.CommandText = "DELETE FROM T_causes WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Desig" +
				"nation IS NULL)";
			this.oleDbDeleteCommand5.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand5
			// 
			this.oleDbInsertCommand5.CommandText = "INSERT INTO T_causes(Code, Designation) VALUES (?, ?)";
			this.oleDbInsertCommand5.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			// 
			// oleDbSelectCommand6
			// 
			this.oleDbSelectCommand6.CommandText = "SELECT Code, Designation FROM T_causes";
			this.oleDbSelectCommand6.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand5
			// 
			this.oleDbUpdateCommand5.CommandText = "UPDATE T_causes SET Code = ?, Designation = ? WHERE (Code = ?) AND (Designation =" +
				" ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbUpdateCommand5.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter7
			// 
			this.oleDbDataAdapter7.DeleteCommand = this.oleDbDeleteCommand6;
			this.oleDbDataAdapter7.InsertCommand = this.oleDbInsertCommand6;
			this.oleDbDataAdapter7.SelectCommand = this.oleDbSelectCommand7;
			this.oleDbDataAdapter7.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_pieces_detachees_a_commander_preparation", new System.Data.Common.DataColumnMapping[] {
																																																													  new System.Data.Common.DataColumnMapping("Code Fournisseur", "Code Fournisseur"),
																																																													  new System.Data.Common.DataColumnMapping("Code Piece", "Code Piece"),
																																																													  new System.Data.Common.DataColumnMapping("N° Devis", "N° Devis"),
																																																													  new System.Data.Common.DataColumnMapping("NumLigne", "NumLigne"),
																																																													  new System.Data.Common.DataColumnMapping("Quantite a cde", "Quantite a cde"),
																																																													  new System.Data.Common.DataColumnMapping("Quantite Devis", "Quantite Devis"),
																																																													  new System.Data.Common.DataColumnMapping("Quantite propose", "Quantite propose")})});
			this.oleDbDataAdapter7.UpdateCommand = this.oleDbUpdateCommand6;
			// 
			// oleDbDeleteCommand6
			// 
			this.oleDbDeleteCommand6.CommandText = @"DELETE FROM T_pieces_detachees_a_commander_preparation WHERE (NumLigne = ?) AND ([Code Fournisseur] = ? OR ? IS NULL AND [Code Fournisseur] IS NULL) AND ([Code Piece] = ? OR ? IS NULL AND [Code Piece] IS NULL) AND ([N° Devis] = ? OR ? IS NULL AND [N° Devis] IS NULL) AND ([Quantite Devis] = ? OR ? IS NULL AND [Quantite Devis] IS NULL) AND ([Quantite a cde] = ? OR ? IS NULL AND [Quantite a cde] IS NULL) AND ([Quantite propose] = ? OR ? IS NULL AND [Quantite propose] IS NULL)";
			this.oleDbDeleteCommand6.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumLigne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NumLigne", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Piece", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Piece", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_a_cde", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite a cde", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_a_cde1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite a cde", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_propose", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite propose", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_propose1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite propose", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand6
			// 
			this.oleDbInsertCommand6.CommandText = "INSERT INTO T_pieces_detachees_a_commander_preparation([Code Fournisseur], [Code " +
				"Piece], [N° Devis], [Quantite a cde], [Quantite Devis], [Quantite propose]) VALU" +
				"ES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Code Fournisseur"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Piece", System.Data.OleDb.OleDbType.Integer, 0, "Code Piece"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_a_cde", System.Data.OleDb.OleDbType.Double, 0, "Quantite a cde"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Quantite Devis"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_propose", System.Data.OleDb.OleDbType.Double, 0, "Quantite propose"));
			// 
			// oleDbSelectCommand7
			// 
			this.oleDbSelectCommand7.CommandText = "SELECT [Code Fournisseur], [Code Piece], [N° Devis], NumLigne, [Quantite a cde], " +
				"[Quantite Devis], [Quantite propose] FROM T_pieces_detachees_a_commander_prepara" +
				"tion";
			this.oleDbSelectCommand7.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand6
			// 
			this.oleDbUpdateCommand6.CommandText = @"UPDATE T_pieces_detachees_a_commander_preparation SET [Code Fournisseur] = ?, [Code Piece] = ?, [N° Devis] = ?, [Quantite a cde] = ?, [Quantite Devis] = ?, [Quantite propose] = ? WHERE (NumLigne = ?) AND ([Code Fournisseur] = ? OR ? IS NULL AND [Code Fournisseur] IS NULL) AND ([Code Piece] = ? OR ? IS NULL AND [Code Piece] IS NULL) AND ([N° Devis] = ? OR ? IS NULL AND [N° Devis] IS NULL) AND ([Quantite Devis] = ? OR ? IS NULL AND [Quantite Devis] IS NULL) AND ([Quantite a cde] = ? OR ? IS NULL AND [Quantite a cde] IS NULL) AND ([Quantite propose] = ? OR ? IS NULL AND [Quantite propose] IS NULL)";
			this.oleDbUpdateCommand6.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Code Fournisseur"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Piece", System.Data.OleDb.OleDbType.Integer, 0, "Code Piece"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_a_cde", System.Data.OleDb.OleDbType.Double, 0, "Quantite a cde"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Quantite Devis"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite_propose", System.Data.OleDb.OleDbType.Double, 0, "Quantite propose"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumLigne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NumLigne", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Piece", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Piece", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_a_cde", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite a cde", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_a_cde1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite a cde", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_propose", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite propose", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite_propose1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite propose", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter9
			// 
			this.oleDbDataAdapter9.DeleteCommand = this.oleDbDeleteCommand8;
			this.oleDbDataAdapter9.InsertCommand = this.oleDbInsertCommand8;
			this.oleDbDataAdapter9.SelectCommand = this.oleDbSelectCommand9;
			this.oleDbDataAdapter9.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_CDE_Lignes_reception", new System.Data.Common.DataColumnMapping[] {
																																																								  new System.Data.Common.DataColumnMapping("Code piece", "Code piece"),
																																																								  new System.Data.Common.DataColumnMapping("Date", "Date"),
																																																								  new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																								  new System.Data.Common.DataColumnMapping("Id_Ligne", "Id_Ligne"),
																																																								  new System.Data.Common.DataColumnMapping("idReception", "idReception"),
																																																								  new System.Data.Common.DataColumnMapping("N° Commande", "N° Commande"),
																																																								  new System.Data.Common.DataColumnMapping("Quantite", "Quantite")})});
			this.oleDbDataAdapter9.UpdateCommand = this.oleDbUpdateCommand8;
			// 
			// oleDbDeleteCommand8
			// 
			this.oleDbDeleteCommand8.CommandText = @"DELETE FROM T_CDE_Lignes_reception WHERE (idReception = ?) AND ([Code piece] = ? OR ? IS NULL AND [Code piece] IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (Id_Ligne = ? OR ? IS NULL AND Id_Ligne IS NULL) AND ([N° Commande] = ? OR ? IS NULL AND [N° Commande] IS NULL) AND (Quantite = ? OR ? IS NULL AND Quantite IS NULL)";
			this.oleDbDeleteCommand8.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_idReception", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "idReception", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_Ligne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_Ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_Ligne1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_Ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand8
			// 
			this.oleDbInsertCommand8.CommandText = "INSERT INTO T_CDE_Lignes_reception([Code piece], [Date], Designation, Id_Ligne, [" +
				"N° Commande], Quantite) VALUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand8.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_piece", System.Data.OleDb.OleDbType.Integer, 0, "Code piece"));
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 30, "Designation"));
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Id_Ligne", System.Data.OleDb.OleDbType.Integer, 0, "Id_Ligne"));
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande"));
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite", System.Data.OleDb.OleDbType.Double, 0, "Quantite"));
			// 
			// oleDbSelectCommand9
			// 
			this.oleDbSelectCommand9.CommandText = "SELECT [Code piece], [Date], Designation, Id_Ligne, idReception, [N° Commande], Q" +
				"uantite FROM T_CDE_Lignes_reception";
			this.oleDbSelectCommand9.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand8
			// 
			this.oleDbUpdateCommand8.CommandText = @"UPDATE T_CDE_Lignes_reception SET [Code piece] = ?, [Date] = ?, Designation = ?, Id_Ligne = ?, [N° Commande] = ?, Quantite = ? WHERE (idReception = ?) AND ([Code piece] = ? OR ? IS NULL AND [Code piece] IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (Id_Ligne = ? OR ? IS NULL AND Id_Ligne IS NULL) AND ([N° Commande] = ? OR ? IS NULL AND [N° Commande] IS NULL) AND (Quantite = ? OR ? IS NULL AND Quantite IS NULL)";
			this.oleDbUpdateCommand8.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_piece", System.Data.OleDb.OleDbType.Integer, 0, "Code piece"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 30, "Designation"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Id_Ligne", System.Data.OleDb.OleDbType.Integer, 0, "Id_Ligne"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantite", System.Data.OleDb.OleDbType.Double, 0, "Quantite"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_idReception", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "idReception", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_Ligne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_Ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_Ligne1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_Ligne", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantite1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null));
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// oleDbDataAdapter10
			// 
			this.oleDbDataAdapter10.InsertCommand = this.oleDbInsertCommand9;
			this.oleDbDataAdapter10.SelectCommand = this.oleDbSelectCommand10;
			this.oleDbDataAdapter10.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										 new System.Data.Common.DataTableMapping("Table", "Parametres", new System.Data.Common.DataColumnMapping[] {
																																																					   new System.Data.Common.DataColumnMapping("e_mail", "e_mail"),
																																																					   new System.Data.Common.DataColumnMapping("F_adresse1", "F_adresse1"),
																																																					   new System.Data.Common.DataColumnMapping("F_adresse2", "F_adresse2"),
																																																					   new System.Data.Common.DataColumnMapping("F_cp", "F_cp"),
																																																					   new System.Data.Common.DataColumnMapping("F_fax", "F_fax"),
																																																					   new System.Data.Common.DataColumnMapping("F_tel", "F_tel"),
																																																					   new System.Data.Common.DataColumnMapping("F_ville", "F_ville"),
																																																					   new System.Data.Common.DataColumnMapping("L_adresse1", "L_adresse1"),
																																																					   new System.Data.Common.DataColumnMapping("L_adresse2", "L_adresse2"),
																																																					   new System.Data.Common.DataColumnMapping("L_cp", "L_cp"),
																																																					   new System.Data.Common.DataColumnMapping("L_fax", "L_fax"),
																																																					   new System.Data.Common.DataColumnMapping("L_tel", "L_tel"),
																																																					   new System.Data.Common.DataColumnMapping("L_ville", "L_ville"),
																																																					   new System.Data.Common.DataColumnMapping("Message_cde", "Message_cde"),
																																																					   new System.Data.Common.DataColumnMapping("signature", "signature"),
																																																					   new System.Data.Common.DataColumnMapping("Societe", "Societe")})});
			// 
			// oleDbInsertCommand9
			// 
			this.oleDbInsertCommand9.CommandText = "INSERT INTO Parametres(e_mail, F_adresse1, F_adresse2, F_cp, F_fax, F_tel, F_vill" +
				"e, L_adresse1, L_adresse2, L_cp, L_fax, L_tel, L_ville, Message_cde, signature, " +
				"Societe) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand9.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("e_mail", System.Data.OleDb.OleDbType.VarWChar, 50, "e_mail"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_adresse1", System.Data.OleDb.OleDbType.VarWChar, 50, "F_adresse1"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_adresse2", System.Data.OleDb.OleDbType.VarWChar, 50, "F_adresse2"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_cp", System.Data.OleDb.OleDbType.VarWChar, 50, "F_cp"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_fax", System.Data.OleDb.OleDbType.VarWChar, 50, "F_fax"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_tel", System.Data.OleDb.OleDbType.VarWChar, 50, "F_tel"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_ville", System.Data.OleDb.OleDbType.VarWChar, 50, "F_ville"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_adresse1", System.Data.OleDb.OleDbType.VarWChar, 50, "L_adresse1"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_adresse2", System.Data.OleDb.OleDbType.VarWChar, 50, "L_adresse2"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_cp", System.Data.OleDb.OleDbType.VarWChar, 50, "L_cp"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_fax", System.Data.OleDb.OleDbType.VarWChar, 50, "L_fax"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_tel", System.Data.OleDb.OleDbType.VarWChar, 50, "L_tel"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_ville", System.Data.OleDb.OleDbType.VarWChar, 50, "L_ville"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_cde", System.Data.OleDb.OleDbType.VarWChar, 0, "Message_cde"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("signature", System.Data.OleDb.OleDbType.VarWChar, 50, "signature"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Societe", System.Data.OleDb.OleDbType.VarWChar, 50, "Societe"));
			// 
			// oleDbSelectCommand10
			// 
			this.oleDbSelectCommand10.CommandText = "SELECT e_mail, F_adresse1, F_adresse2, F_cp, F_fax, F_tel, F_ville, L_adresse1, L" +
				"_adresse2, L_cp, L_fax, L_tel, L_ville, Message_cde, signature, Societe FROM Par" +
				"ametres";
			this.oleDbSelectCommand10.Connection = this.oleDbConnection1;
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
			// Commande
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(924, 688);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.tabControlEX1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Commande";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Commande";
			this.VisibleChanged += new System.EventHandler(this.Commande_VisibleChanged);
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPageEX2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabPageEX3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{
			Comm.CommandText="SELECT T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom,T_pieces_detachees.Identificateur FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_pieces_detachees");
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			mtgcComboBox3.SourceDataTable = ds.Tables["t_pieces_detachees"];
			mtgcComboBox3.SourceDataString = new string[] {"Code","Designation","Nom","Identificateur"}; 
			mtgcComboBox3.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox3.SelectedIndex=0;
			/*foreach(DataRow rowPiece in dataSet11.Tables["t_pieces_detachees"].Rows)
			{
				mtgcComboBox3.Items.Add(new MTGCComboBoxItem(rowPiece["Code"].ToString(),rowPiece["designation"].ToString(),rowPiece["Nom"].ToString(),rowPiece["Identificateur"].ToString()));
				if(rowPiece["Code_1"].ToString().Length>0)
				{
					mtgcComboBox5.Items.Add(new MTGCComboBoxItem(rowPiece["Code_1"].ToString(),rowPiece["Code"].ToString(),"",""));
				}
			}*/
			ds.Tables["t_pieces_detachees"].Clear();
			Comm.CommandText="SELECT T_pieces_detachees.Identificateur,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_pieces_detachees");
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			foreach(DataRow row in ds.Tables["t_pieces_detachees"].Rows)
			{
				MTGCComboBoxItem Item = new MTGCComboBoxItem(row["Identificateur"].ToString(),row["Designation"].ToString(),row["Nom"].ToString(),row["Code"].ToString());
				mtgcComboBox9.Items.Add(Item);
			}
			mtgcComboBox9.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox9.SelectedIndex=0;
			ds.Tables["t_pieces_detachees"].Clear();

			Comm.CommandText="SELECT Code, Designation FROM t_causes ORDER BY Designation";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_causes");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			mtgcComboBox4.SourceDataTable = ds.Tables["t_causes"];
			mtgcComboBox4.SourceDataString = new string[] {"Code","Designation","",""};
			ds.Tables["t_causes"].Clear();

			Comm.CommandText="SELECT T_fournisseurs.Nom, T_fournisseurs.[Adresse 1], T_fournisseurs.[Code Postal], T_fournisseurs.Ville FROM T_fournisseurs ORDER BY T_fournisseurs.Nom";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"Fourn");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			mtgcComboBox2.SourceDataTable = ds.Tables["Fourn"];
			mtgcComboBox2.SourceDataString = new string[] {"Nom","Adresse_1","Code Postal","Ville"};
			ds.Tables["Fourn"].Clear();

			tabControlEX1.SelectedTab=tabPageEX1;

			button9.Enabled=true;
		}

		public void Remplir(string NumCommande)
		{
			Activer();
			Vider();
			if(NumCommande.Length>0)
			{
				Comm.CommandText="SELECT T_CDE_entete.*, T_fournisseurs.Nom, T_CDE_entete.[N° Commande] FROM T_fournisseurs INNER JOIN T_CDE_entete ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur] WHERE (((T_CDE_entete.[N° Commande])="+NumCommande+"))";
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"t_cde_entete");
				}
				catch(Exception exp)
				{
				}
				dateTimePicker2.Text=ds.Tables["t_cde_entete"].Rows[0]["date commande"].ToString();
				mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(ds.Tables["t_cde_entete"].Rows[0]["nom"].ToString());
				
				Comm.CommandText="SELECT T_fournisseurs_Corresp.Nom, T_fournisseurs_Corresp.Prenom FROM T_fournisseurs_Corresp WHERE (((T_fournisseurs_Corresp.Code)="+ds.Tables["t_cde_entete"].Rows[0]["Code fournisseur"].ToString()+")) GROUP BY T_fournisseurs_Corresp.Nom, T_fournisseurs_Corresp.Prenom";
				DataAD.SelectCommand=Comm;
				try
				{
					if(DataAD.Fill(ds,"Corres")>0)
					{
						mtgcComboBox1.SourceDataTable = ds.Tables["Corres"];
						mtgcComboBox1.SourceDataString = new string[] {"Nom","Prenom","",""};
						mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
						ds.Tables["Corres"].Clear();
					}
				}
				catch(Exception exp)
				{
				}
				
				dateTimePicker1.Text=ds.Tables["t_cde_entete"].Rows[0]["date livraison"].ToString();
				txSignature.Text=ds.Tables["t_cde_entete"].Rows[0]["signature"].ToString();
				try
				{
					textBox6.Text=System.Convert.ToDecimal(ds.Tables["t_cde_entete"].Rows[0]["total commande"].ToString()).ToString("0.00");
				}
				catch(Exception exp)
				{
					textBox6.Text="0.00";
				}
				try
				{
					textBox8.Text=System.Convert.ToDecimal(ds.Tables["t_cde_entete"].Rows[0]["montant remise"].ToString()).ToString("0.00");
				}
				catch(Exception exp)
				{
					textBox8.Text="0.00";
				}
				try
				{
					txNet.Text=System.Convert.ToDecimal(ds.Tables["t_cde_entete"].Rows[0]["total net commande"].ToString()).ToString("0.00");
				}
				catch(Exception exp)
				{
					txNet.Text="0.00";
				}
				textBox13.Text=ds.Tables["t_cde_entete"].Rows[0]["Comment"].ToString();
				if(ds.Tables["t_cde_entete"].Rows[0]["Edite"].ToString().Equals("True"))
					checkBox1.Checked=true;
				if(ds.Tables["t_cde_entete"].Rows[0]["Valide"].ToString().Equals("True"))
					checkBox2.Checked=true;
				if(ds.Tables["t_cde_entete"].Rows[0]["Solde"].ToString().Equals("True"))
					checkBox3.Checked=true;
				txNbPieces.Text=ds.Tables["t_cde_entete"].Rows[0]["Total pieces commandees"].ToString();
				if(ds.Tables["t_cde_entete"].Rows[0]["Valide"].ToString().Equals("True"))
				{
					button6.Enabled=true;
					button4.Enabled=false;
					checkBox2.Checked=true;
				}
				if(ds.Tables["t_cde_entete"].Rows[0]["Solde"].ToString().Equals("True"))
				{
					checkBox3.Checked=true;
					mtgcComboBox3.Enabled=false;
					mtgcComboBox4.Enabled=false;
					mtgcComboBox5.Enabled=false;
					mtgcComboBox9.Enabled=false;
					button2.Enabled=false;
					button10.Enabled=false;
					textBox2.Enabled=false;
					textBox14.Enabled=false;
					textBox16.Enabled=false;
					numericUpDown1.Enabled=false;
					numericUpDown2.Enabled=false;
					txUnite.Enabled=false;
					textBox4.Enabled=false;
					textBox15.Enabled=false;
					listView2.Enabled=false;
					textBox13.Enabled=false;
					dateTimePicker1.Enabled=false;
					dateTimePicker2.Enabled=false;
					mtgcComboBox1.Enabled=false;
					mtgcComboBox2.Enabled=false;
				}
				textBox1.Text=NumCommande;
				ds.Tables["t_cde_entete"].Clear();

				Comm.CommandText="select * from t_cde_lignes where [n° commande]="+textBox1.Text;
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"t_cde_lignes");
					foreach(DataRow row in ds.Tables["t_cde_lignes"].Rows)
					{
						
						Comm.CommandText="select * from t_pieces_detachees where identificateur="+row["code piece"].ToString();
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"t_pieces_detachees");
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						Comm.CommandText="SELECT T_CDE_Lignes_reception.Id_Ligne, T_CDE_Lignes_reception.[Code piece], Sum(T_CDE_Lignes_reception.Quantite) AS SommeDeQuantite FROM T_CDE_Lignes_reception GROUP BY T_CDE_Lignes_reception.Id_Ligne, T_CDE_Lignes_reception.[Code piece] HAVING (((T_CDE_Lignes_reception.Id_Ligne)="+row["id_ligne"].ToString()+") AND ((T_CDE_Lignes_reception.[Code piece])="+row["code piece"].ToString()+"))";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"t_cde_lignes_reception");
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						ListViewItem Item = new ListViewItem(ds.Tables["t_pieces_detachees"].Rows[0]["code"].ToString());
						Item.SubItems.Add(row["designation"].ToString());
						Item.SubItems.Add(row["quantite"].ToString());
						try
						{
							Item.SubItems.Add(System.Convert.ToDecimal(ds.Tables["t_pieces_detachees"].Rows[0]["prix achat brut"].ToString()).ToString("0.00"));
						}
						catch(Exception exp)
						{
							Item.SubItems.Add("0.00");
							Console.WriteLine(exp.Message);
						}
						try
						{
							Item.SubItems.Add(System.Convert.ToDecimal(ds.Tables["t_pieces_detachees"].Rows[0]["prix achat brut"].ToString()).ToString("0.00"));
						}
						catch(Exception exp)
						{
							Item.SubItems.Add("0.00");
							Console.WriteLine(exp.Message);
						}
						try
						{
							Item.SubItems.Add(System.Convert.ToDecimal(row["total ligne"].ToString()).ToString("0.00"));
						}
						catch(Exception exp)
						{
							Item.SubItems.Add("0.00");
							Console.WriteLine(exp.Message);
						}
						listView2.Items.Add(Item);
						ListViewItem Item2 = new ListViewItem(ds.Tables["t_pieces_detachees"].Rows[0]["code"].ToString());
						if(ds.Tables["t_cde_lignes_reception"].Rows.Count>0)
							Item2.SubItems.Add(ds.Tables["t_cde_lignes_reception"].Rows[0]["SommeDeQuantite"].ToString());
						else
							Item2.SubItems.Add("0");
						Item2.SubItems.Add(row["quantite"].ToString());
						int Reste=0;
						if(ds.Tables["t_cde_lignes_reception"].Rows.Count>0)
						{
							Reste=System.Convert.ToInt32(row["quantite"].ToString())-System.Convert.ToInt32(ds.Tables["t_cde_lignes_reception"].Rows[0]["SommeDeQuantite"].ToString());
							Item2.SubItems.Add(Reste.ToString());
						}
						else
							Item2.SubItems.Add(row["quantite"].ToString());
						Item2.SubItems.Add(row["code piece"].ToString());
						Item2.Tag=row["id_ligne"].ToString();
						listView1.Items.Add(Item2);
						ds.Tables["t_pieces_detachees"].Clear();
						ds.Tables["t_cde_lignes_reception"].Clear();
					}
					ds.Tables["t_cde_lignes"].Clear();
				}
				catch(Exception exp)
				{

				}
				
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			Activer();
			oleDbConnection1.Open();
			Comm.CommandText="SELECT Max(T_CDE_entete.[N° Commande]) AS [MaxDeN° Commande] FROM T_CDE_entete";
			int Num=System.Convert.ToInt32(Comm.ExecuteScalar());
			Num++;
			oleDbConnection1.Close();
			textBox1.Text=Num.ToString();
			textBox1.BackColor=Color.MistyRose;
			button8.Enabled=true;

		}

		private void Activer()
		{
			textBox1.Enabled=true;
			textBox1.BackColor=Color.White;
			textBox3.Enabled=true;
			textBox3.BackColor=Color.White;
			textBox4.Enabled=true;
			textBox4.BackColor=Color.White;
			txSignature.Enabled=true;
			txSignature.BackColor=Color.White;
			textBox6.Enabled=true;
			textBox6.BackColor=Color.White;
			textBox7.Enabled=true;
			textBox7.BackColor=Color.White;
			textBox8.Enabled=true;
			textBox8.BackColor=Color.White;
			txNet.Enabled=true;
			txNet.BackColor=Color.White;
			textBox10.Enabled=true;
			textBox10.BackColor=Color.White;
			textBox11.Enabled=true;
			textBox11.BackColor=Color.White;
			textBox12.Enabled=true;
			textBox12.BackColor=Color.White;
			textBox13.Enabled=true;
			textBox13.BackColor=Color.White;
			textBox14.Enabled=true;
			textBox14.BackColor=Color.White;
			textBox15.Enabled=true;
			textBox15.BackColor=Color.White;
			textBox16.Enabled=true;
			textBox16.BackColor=Color.White;
			txUnite.Enabled=true;
			txUnite.BackColor=Color.White;
			mtgcComboBox1.Enabled=true;
			mtgcComboBox1.BackColor=Color.White;
			mtgcComboBox2.Enabled=true;
			mtgcComboBox2.BackColor=Color.White;
			mtgcComboBox3.Enabled=true;
			mtgcComboBox3.BackColor=Color.White;
			mtgcComboBox5.Enabled=true;
			mtgcComboBox5.BackColor=Color.White;
			mtgcComboBox9.Enabled=true;
			mtgcComboBox9.BackColor=Color.White;
			listView1.Enabled=true;
			listView1.BackColor=Color.White;
			listView2.Enabled=true;
			listView2.BackColor=Color.White;
			button3.Enabled=true;
			button4.Enabled=true;
			dateTimePicker1.Enabled=true;
			dateTimePicker2.Enabled=true;
			button8.Enabled=true;
			/*try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			if(textBox1.TextLength.Equals(0))
			{
				try
				{
					int Num=System.Convert.ToInt32(dataSet11.Tables["t_cde_entete"].Rows[dataSet11.Tables["t_cde_entete"].Rows.Count-1]["n° commande"].ToString())+1;
					textBox1.Text=Num.ToString();
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
			/*try
			{
				oleDbDataAdapter2.Fill(dataSet11);
			}
			catch(Exception exp)
			{

			}
			foreach(DataRow row in dataSet11.Tables["t_fournisseurs"].Rows)
			{
				mtgcComboBox2.Items.Add(new MTGCComboBoxItem(row["Nom"].ToString(),"","",""));
			}
			dataSet11.Tables["t_pieces_detachees"].Clear();
			oleDbDataAdapter3.SelectCommand.CommandText="SELECT T_pieces_detachees.Code,T_pieces_detachees.Code_1, T_pieces_detachees.Designation, T_fournisseurs.Nom,T_pieces_detachees.Identificateur FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
			try
			{
				oleDbDataAdapter3.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			foreach(DataRow rowPiece in dataSet11.Tables["t_pieces_detachees"].Rows)
			{
				mtgcComboBox3.Items.Add(new MTGCComboBoxItem(rowPiece["Code"].ToString(),rowPiece["designation"].ToString(),rowPiece["Nom"].ToString(),rowPiece["Identificateur"].ToString()));
				if(rowPiece["Code_1"].ToString().Length>0)
				{
					mtgcComboBox5.Items.Add(new MTGCComboBoxItem(rowPiece["Code_1"].ToString(),rowPiece["Code"].ToString(),"",""));
				}
			}
			dataSet11.Tables["t_pieces_detachees"].Clear();*/
			/*oleDbDataAdapter3.SelectCommand.CommandText="SELECT T_pieces_detachees.Identificateur,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
			try
			{
				oleDbDataAdapter3.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			foreach(DataRow rowPiece in dataSet11.Tables["t_pieces_detachees"].Rows)
			{
				mtgcComboBox9.Items.Add(new MTGCComboBoxItem(rowPiece["Identificateur"].ToString(),rowPiece["Code"].ToString(),rowPiece["designation"].ToString(),rowPiece["Nom"].ToString()));
			}
			tabControlEX1.SelectedTab=tabPageEX1;*/
			
		}

		private void mtgcComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_fournisseurs"].Clear();
			oleDbSelectCommand2.CommandText="select * from t_fournisseurs where nom='"+mtgcComboBox2.Text+"'";
			try
			{
				oleDbDataAdapter2.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			label4.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["nom"].ToString();
			label5.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["adresse 1"].ToString();
			label6.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["adresse 2"].ToString();
			label7.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["code postal"].ToString();
			label8.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["ville"].ToString();
			try
			{
				decimal remise=System.Convert.ToDecimal(dataSet11.Tables["t_fournisseurs"].Rows[0]["pourcentage remise"].ToString())*100;
				textBox7.Text=remise.ToString("0.00");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			textBox7.Text=textBox7.Text.Replace(".",",");
			textBox18.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["code"].ToString();
		}

		private void mtgcComboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox3.SelectedIndex!=-1)
			{
				dataSet11.Tables["t_pieces_detachees"].Clear();
				oleDbDataAdapter3.SelectCommand.CommandText="select * from t_pieces_detachees where code='"+mtgcComboBox3.Text+"'";
				try
				{
					oleDbDataAdapter3.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				textBox3.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["designation"].ToString();
				textBox16.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["designation"].ToString();
				try
				{
					Decimal PBrut=System.Convert.ToDecimal(dataSet11.Tables["t_pieces_detachees"].Rows[0]["prix achat brut"].ToString());
					textBox14.Text=PBrut.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				try
				{
					Decimal PNet=System.Convert.ToDecimal(dataSet11.Tables["t_pieces_detachees"].Rows[0]["prix achat net"].ToString());
					textBox15.Text=PNet.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				//Decimal Total=System.Convert.ToDecimal(textBox14.Text)*System.Convert.ToDecimal(textBox4.Text);
				//txUnite.Text=Total.ToString("0.00");
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(mtgcComboBox2.Text.Length.Equals(0))
			{
				MessageBox.Show("Veuillez choisir un fournisseur.","Info",MessageBoxButtons.OK,MessageBoxIcon.Question);
			}
			else
			{
				
				save=true;
				listView2.Items.Add(mtgcComboBox3.Text);
				listView2.Items[listView2.Items.Count-1].SubItems.Add(textBox3.Text);
				listView2.Items[listView2.Items.Count-1].SubItems.Add(textBox16.Text);
				listView2.Items[listView2.Items.Count-1].SubItems.Add(textBox4.Text);
				listView2.Items[listView2.Items.Count-1].SubItems.Add(textBox14.Text);
				listView2.Items[listView2.Items.Count-1].SubItems.Add(textBox15.Text);
				listView2.Items[listView2.Items.Count-1].SubItems.Add(txUnite.Text);
				try
				{
					int TotalPieces=System.Convert.ToInt32(txNbPieces.Text)+System.Convert.ToInt32(textBox4.Text);
					txNbPieces.Text=TotalPieces.ToString();
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				try
				{
					Decimal TotalCommande=System.Convert.ToDecimal(textBox6.Text)+System.Convert.ToDecimal(txUnite.Text);
					textBox6.Text=TotalCommande.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				textBox6.Text=textBox6.Text.Replace(".",",");
				Decimal remise=0;
				try
				{
					remise=(System.Convert.ToDecimal(textBox6.Text)*System.Convert.ToDecimal(textBox7.Text))/100;
					textBox8.Text=remise.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				try
				{
					Decimal TotalNet=System.Convert.ToDecimal(textBox6.Text)-System.Convert.ToDecimal(textBox8.Text);
					txNet.Text=TotalNet.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				dataSet11.Tables["t_cde_entete"].Clear();
				oleDbSelectCommand1.CommandText="select * from t_cde_entete where [n° commande]="+textBox1.Text;
				try
				{
					oleDbDataAdapter1.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				try
				{
					remise=System.Convert.ToDecimal(textBox7.Text)/100;
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				textBox6.Text=textBox6.Text.Replace(",",".");
				textBox7.Text=textBox7.Text.Replace(",",".");
				textBox8.Text=textBox8.Text.Replace(",",".");
				txNet.Text=txNet.Text.Replace(",",".");
				if(dataSet11.Tables["t_cde_entete"].Rows.Count.Equals(0))
				{
					oleDbConnection1.Open();
					OleDbTransaction Transac;
					OleDbCommand Comm = new OleDbCommand();
					Transac = oleDbConnection1.BeginTransaction();
					Comm.Transaction = Transac;
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="insert into t_cde_entete ([n° commande],[date commande], [code fournisseur], Signature, [date livraison],[remise fournisseur], [total commande], [Montant remise], [Total net commande],[total pieces commandees],comment) values ("+textBox1.Text+",'"+dateTimePicker2.Value.ToShortDateString()+"','"+textBox18.Text+"','"+txSignature.Text+"','"+dateTimePicker1.Value.ToShortDateString()+"',"+remise.ToString("0.00").Replace(",",".")+","+textBox6.Text+","+textBox8.Text+","+txNet.Text+","+txNbPieces.Text+",'"+textBox13.Text+"')";
					try
					{
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
						}
						catch(OleDbException excp)
						{
							try
							{
								Transac.Rollback();
							}
							catch(OleDbException ex)
							{
								MessageBox.Show(ex.Message);
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
					oleDbConnection1.Open();
					textBox6.Text=textBox6.Text.Replace(",",".");
					textBox7.Text=textBox7.Text.Replace(",",".");
					textBox8.Text=textBox8.Text.Replace(",",".");
					txNet.Text=txNet.Text.Replace(",",".");
					textBox15.Text=textBox15.Text.Replace(",",".");
					txUnite.Text=txUnite.Text.Replace(",",".");
					dataSet11.Tables["t_pieces_detachees"].Clear();
					oleDbSelectCommand3.CommandText="select * from t_pieces_detachees where code='"+mtgcComboBox3.Text+"'";
					try
					{
						oleDbDataAdapter3.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					Comm.CommandText="insert into t_cde_lignes ([N° commande],[code piece],designation,quantite,[prix achat],[total ligne]) values ("+textBox1.Text+","+dataSet11.Tables["t_pieces_detachees"].Rows[0]["identificateur"].ToString()+",'"+textBox16.Text+"',"+textBox4.Text+","+textBox15.Text+","+txUnite.Text+",')";
					Comm.Transaction=Transac;
					Transac = oleDbConnection1.BeginTransaction();
					try
					{
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
						}
						catch(OleDbException excp)
						{
							try
							{
								Transac.Rollback();
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
								Console.WriteLine(excp.Message);
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
				{
					oleDbConnection1.Open();
					OleDbCommand Comm = new OleDbCommand();
					Transac = oleDbConnection1.BeginTransaction();
					Comm.Transaction = Transac;
					Comm.Connection=oleDbConnection1;
					textBox7.Text=textBox7.Text.Replace(".",",");
					remise=System.Convert.ToDecimal(textBox7.Text)/100;
					Comm.CommandText="update t_cde_entete set [date commande]='"+dateTimePicker2.Value.ToShortDateString()+"', [code fournisseur]='"+textBox18.Text+"', Signature='"+txSignature.Text+"', [date livraison]='"+dateTimePicker1.Value.ToShortDateString()+"',[remise fournisseur]="+remise.ToString("0.00").Replace(",",".")+", [total commande]="+textBox6.Text+", [Montant remise]="+textBox8.Text+", [Total net commande]="+txNet.Text+",[total pieces commandees]="+txNbPieces.Text+",comment='"+textBox13.Text+"' where [n° commande]="+textBox1.Text;
					try
					{
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
						}
						catch(Exception excp)
						{
							try
							{
								Transac.Rollback();
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
								Console.WriteLine(excp.Message);
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
					Comm = new OleDbCommand();
					Comm.Connection=oleDbConnection1;
					textBox6.Text=textBox6.Text.Replace(",",".");
					textBox7.Text=textBox7.Text.Replace(",",".");
					textBox8.Text=textBox8.Text.Replace(",",".");
					txNet.Text=txNet.Text.Replace(",",".");
					textBox15.Text=textBox15.Text.Replace(",",".");
					txUnite.Text=txUnite.Text.Replace(",",".");
					dataSet11.Tables["t_pieces_detachees"].Clear();
					oleDbSelectCommand3.CommandText="select * from t_pieces_detachees where code='"+mtgcComboBox3.Text+"'";
					try
					{
						oleDbDataAdapter3.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					oleDbConnection1.Open();
					Transac=oleDbConnection1.BeginTransaction();
					Comm.CommandText="insert into t_cde_lignes ([N° commande],[code piece],designation,quantite,[prix achat],[total ligne],[date livraison]) values ("+textBox1.Text+","+dataSet11.Tables["t_pieces_detachees"].Rows[0]["identificateur"].ToString()+",'"+textBox16.Text+"',"+textBox4.Text+","+textBox15.Text+","+txUnite.Text+",'"+dateTimePicker1.Value.ToShortDateString()+"')";
					Comm.Transaction=Transac;
					try
					{
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
						}
						catch(Exception excp)
						{
							try
							{
								Transac.Rollback();
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
								Console.WriteLine(excp.Message);
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

				mtgcComboBox3.SelectedIndex=-1;
				textBox3.Clear();
				textBox14.Clear();
				textBox15.Clear();
				textBox16.Clear();
				txUnite.Clear();
				textBox6.Text=textBox6.Text.Replace(".",",");
				textBox7.Text=textBox7.Text.Replace(".",",");
				textBox8.Text=textBox8.Text.Replace(".",",");
				txNet.Text=txNet.Text.Replace(".",",");
				textBox15.Text=textBox15.Text.Replace(".",",");
				txUnite.Text=txUnite.Text.Replace(".",",");
				dataSet11.Tables["t_pieces_detachees"].Clear();
				save=false;
			}
		}

		private void textBox4_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				Decimal PBrut=System.Convert.ToDecimal(dataSet11.Tables["t_pieces_detachees"].Rows[0]["prix achat brut"].ToString());
				textBox14.Text=PBrut.ToString("0.00");
				textBox14.Text=textBox14.Text.Replace(".",",");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			try
			{
				Decimal PNet=System.Convert.ToDecimal(dataSet11.Tables["t_pieces_detachees"].Rows[0]["prix achat net"].ToString());
				textBox15.Text=PNet.ToString("0.00");
				textBox15.Text=textBox15.Text.Replace(".",",");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			try
			{
				Decimal Total=System.Convert.ToDecimal(textBox14.Text)*System.Convert.ToDecimal(textBox4.Text);
				txUnite.Text=Total.ToString("0.00");
				txUnite.Text=txUnite.Text.Replace(".",",");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			OleDbTransaction Transac;
			OleDbCommand Comm = new OleDbCommand();
			Transac = oleDbConnection1.BeginTransaction();
			Comm.Transaction = Transac;
			Comm.Connection=oleDbConnection1;
			Decimal remise=0;
			try
			{
				remise=System.Convert.ToDecimal(textBox7.Text)/100;
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			Comm.CommandText="update t_cde_entete set [date commande]='"+dateTimePicker2.Value.ToShortDateString()+"', [code fournisseur]='"+textBox18.Text+"', Signature='"+txSignature.Text+"', [date livraison]='"+dateTimePicker1.Value.ToShortDateString()+"',[remise fournisseur]="+remise.ToString("0.00").Replace(",",".")+", [total commande]="+textBox6.Text+", [Montant remise]="+textBox8.Text+", [Total net commande]="+txNet.Text+",[total pieces commandees]="+txNbPieces.Text+",comment='"+textBox13.Text+"' where [n° commande]="+textBox1.Text;
			try
			{
				Comm.ExecuteNonQuery();
				try
				{
					Transac.Commit();
				}
				catch(Exception excp)
				{
					try
					{
						Transac.Rollback();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
						Console.WriteLine(excp.Message);
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

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void mtgcComboBox3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			mtgcComboBox9.Text="";
			mtgcComboBox9.SelectedIndex=-1;
			mtgcComboBox5.Text="";
			mtgcComboBox5.SelectedIndex=-1;
			if(e.KeyValue.Equals(13))
			{
				if(mtgcComboBox3.SelectedIndex>=0)
				{	
					mtgcComboBox5.SelectedIndex=-1;
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select * from t_pieces_detachees where code='"+mtgcComboBox3.Text+"'";
					oleDbDataAdapter3.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter3.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox16.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox20.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
					textBox3.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
					string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString().Replace(".",",");
					try
					{
						decimal Prix = System.Convert.ToDecimal(Price);
						txUnite.Text=Prix.ToString("0.00");
						textBox15.Text=Prix.ToString("0.00");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					/*for(int i=0;i<comboBox2.Items.Count;i++)
						{
							if(comboBox2.Items[i].ToString().Equals(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code_1"].ToString()))
								comboBox2.SelectedIndex=i;
						}*/
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
					try
					{
						if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString())>(0.00)))
						{
							try
							{
								string Pourcent = numericUpDown2.Value.ToString().Trim(',');
								string Rem = "1,"+Pourcent;
								decimal remise = System.Convert.ToDecimal(Rem);
								decimal nombre = numericUpDown1.Value;
								decimal PV = System.Convert.ToDecimal(txUnite.Text);
								decimal Total = PV*nombre*remise;
								textBox4.Text=Total.ToString("0.00");
							}
							catch(Exception exp)
							{
								MessageBox.Show(exp.Message);
							}
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
		}

		private void mtgcComboBox9_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			mtgcComboBox3.Text="";
			mtgcComboBox3.SelectedIndex=-1;
			mtgcComboBox5.Text="";
			mtgcComboBox5.SelectedIndex=-1;
			if(e.KeyValue.Equals(13))
			{
				if(mtgcComboBox9.SelectedIndex>=0)
				{
					mtgcComboBox5.SelectedIndex=-1;
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select * from t_pieces_detachees where identificateur="+mtgcComboBox9.Text;
					oleDbDataAdapter3.SelectCommand=Comm;
					oleDbDataAdapter3.Fill(dataSet11);
					textBox3.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
					textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox16.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox20.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
					string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString().Replace(".",",");
					decimal Prix = System.Convert.ToDecimal(Price);
					txUnite.Text=Prix.ToString("0.00");
					textBox15.Text=Prix.ToString("0.00");
					/*for(int i=0;i<comboBox2.Items.Count;i++)
						{
							if(comboBox2.Items[i].ToString().Equals(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code_1"].ToString()))
								comboBox2.SelectedIndex=i;
						}*/
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
					try
					{
						if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString())>(0.00)))
						{
							string Pourcent = numericUpDown2.Value.ToString().Trim(',');
							string Rem = "1,"+Pourcent;
							decimal remise = System.Convert.ToDecimal(Rem);
							decimal nombre = numericUpDown1.Value;
							decimal PV = System.Convert.ToDecimal(txUnite.Text);
							decimal Total = PV*nombre*remise;
							textBox4.Text=Total.ToString("0.00");
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
		}

		private void mtgcComboBox5_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				mtgcComboBox3.Text="";
				mtgcComboBox3.SelectedIndex=-1;
				mtgcComboBox9.Text="";
				mtgcComboBox9.SelectedIndex=-1;
				if(e.KeyValue.Equals(13))
				{
					if(mtgcComboBox5.SelectedIndex>=0)
					{
						dataSet11.Tables["t_pieces_detachees"].Clear();
						Comm.Connection=oleDbConnection1;
						Comm.CommandText="select * from t_pieces_detachees where code_1='"+mtgcComboBox9.Text+"'";
						oleDbDataAdapter3.SelectCommand=Comm;
						textBox3.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
						oleDbDataAdapter3.Fill(dataSet11);
						txNbPieces.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
						textBox16.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
						textBox20.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
						string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString().Replace(".",",");
						decimal Prix = System.Convert.ToDecimal(Price);
						txUnite.Text=Prix.ToString("0.00");
						textBox15.Text=Prix.ToString("0.00");
						/*for(int i=0;i<comboBox2.Items.Count;i++)
							{
								if(comboBox2.Items[i].ToString().Equals(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code_1"].ToString()))
									comboBox2.SelectedIndex=i;
							}*/
						mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
						try
						{
							if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString())>(0.00)))
							{
								string Pourcent = numericUpDown2.Value.ToString().Trim(',');
								string Rem = "1,"+Pourcent;
								decimal remise = System.Convert.ToDecimal(Rem);
								decimal nombre = numericUpDown1.Value;
								decimal PV = System.Convert.ToDecimal(txUnite.Text);
								decimal Total = PV*nombre*remise;
								textBox4.Text=Total.ToString("0.00");
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

		private void numericUpDown1_Enter(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_pieces_detachees"].Clear();
			if(mtgcComboBox3.SelectedIndex>=0&&textBox3.TextLength.Equals(0))
			{
				mtgcComboBox9.SelectedIndex=-1;
				mtgcComboBox5.SelectedIndex=-1;
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="select * from t_pieces_detachees where code='"+mtgcComboBox3.Text+"'";
				oleDbDataAdapter3.SelectCommand=Comm;
				oleDbDataAdapter3.Fill(dataSet11);
				textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
				textBox16.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
				textBox20.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
				textBox3.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
				string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString().Replace(".",",");
				decimal Prix = System.Convert.ToDecimal(Price);
				txUnite.Text=Prix.ToString("0.00");
				textBox15.Text=Prix.ToString("0.00");
				/*for(int i=0;i<comboBox2.Items.Count;i++)
						{
							if(comboBox2.Items[i].ToString().Equals(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code_1"].ToString()))
								comboBox2.SelectedIndex=i;
				}*/
				mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
				try
				{
					if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString())>(0.00)))
					{
						string Pourcent = numericUpDown2.Value.ToString().Trim(',');
						string Rem = "1,"+Pourcent;
						decimal remise = System.Convert.ToDecimal(Rem);
						decimal nombre = numericUpDown1.Value;
						decimal PV = System.Convert.ToDecimal(txUnite.Text);
						decimal Total = PV*nombre*remise;
						textBox4.Text=Total.ToString("0.00");
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
			else if(mtgcComboBox9.SelectedIndex>=0&&textBox3.TextLength.Equals(0))
			{
				mtgcComboBox5.SelectedIndex=-1;
				mtgcComboBox3.SelectedIndex=-1;
				dataSet11.Tables["t_pieces_detachees"].Clear();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="select * from t_pieces_detachees where identificateur="+mtgcComboBox9.Text;
				oleDbDataAdapter3.SelectCommand=Comm;
				oleDbDataAdapter3.Fill(dataSet11);
				textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
				textBox16.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
				textBox20.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
				textBox7.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
				string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString().Replace(".",",");
				decimal Prix = System.Convert.ToDecimal(Price);
				txUnite.Text=Prix.ToString("0.00");
				textBox15.Text=Prix.ToString("0.00");
				/*for(int i=0;i<comboBox2.Items.Count;i++)
						{
							if(comboBox2.Items[i].ToString().Equals(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code_1"].ToString()))
								comboBox2.SelectedIndex=i;
						}*/
				mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
				try
				{
					if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString())>(0.00)))
					{
						string Pourcent = numericUpDown2.Value.ToString().Trim(',');
						string Rem = "1,"+Pourcent;
						decimal remise = System.Convert.ToDecimal(Rem);
						decimal nombre = numericUpDown1.Value;
						decimal PV = System.Convert.ToDecimal(txUnite.Text);
						decimal Total = PV*nombre*remise;
						textBox4.Text=Total.ToString("0.00");
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
			else if(mtgcComboBox5.SelectedIndex>=0&&textBox3.TextLength.Equals(0))
			{
				if(mtgcComboBox5.SelectedIndex>=0)
				{
					mtgcComboBox3.SelectedIndex=-1;
					mtgcComboBox9.SelectedIndex=-1;
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select * from t_pieces_detachees where code_1='"+mtgcComboBox9.Text+"'";
					oleDbDataAdapter3.SelectCommand=Comm;
					oleDbDataAdapter3.Fill(dataSet11);
					textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox16.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox20.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
					string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString().Replace(".",",");
					decimal Prix = System.Convert.ToDecimal(Price);
					txUnite.Text=Prix.ToString("0.00");
					textBox15.Text=Prix.ToString("0.00");
					/*for(int i=0;i<comboBox2.Items.Count;i++)
							{
								if(comboBox2.Items[i].ToString().Equals(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code_1"].ToString()))
									comboBox2.SelectedIndex=i;
							}*/
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
					try
					{
						if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat brut"].ToString())>(0.00)))
						{
							string Pourcent = numericUpDown2.Value.ToString().Trim(',');
							string Rem = "1,"+Pourcent;
							decimal remise = System.Convert.ToDecimal(Rem);
							decimal nombre = numericUpDown1.Value;
							decimal PV = System.Convert.ToDecimal(txUnite.Text);
							decimal Total = PV*nombre*remise;
							textBox4.Text=Total.ToString("0.00");
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			numericUpDown1.Select(0,numericUpDown1.Value.ToString().Length);
		}

		private void numericUpDown1_Leave(object sender, System.EventArgs e)
		{
			if(txNbPieces.TextLength>0)
			{
				try
				{
					string Pourcent = numericUpDown2.Value.ToString();
					Decimal Pourc = System.Convert.ToDecimal(Pourcent);
					Pourc/=100;
					Decimal Reduc = System.Convert.ToDecimal(txUnite.Text);
					Reduc *=Pourc;
					if(numericUpDown1.Value>0)
					{
						Decimal Prix = (System.Convert.ToDecimal(txUnite.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
						textBox4.Text=Prix.ToString("0.00");
						Prix = (System.Convert.ToDecimal(txUnite.Text)-Reduc);
						textBox15.Text=Prix.ToString("0.00");
					}
					else
					{
						Decimal Prix = (System.Convert.ToDecimal(txUnite.Text))*System.Convert.ToInt32(numericUpDown1.Value);
						textBox4.Text=Prix.ToString("0.00");
						Prix = (System.Convert.ToDecimal(txUnite.Text));
						textBox15.Text=Prix.ToString("0.00");
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				
			}
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			if(txNbPieces.TextLength>0)
			{
				try
				{
					string Pourcent = numericUpDown2.Value.ToString();
					Decimal Pourc = System.Convert.ToDecimal(Pourcent);
					Pourc/=100;
					Decimal Reduc = System.Convert.ToDecimal(txUnite.Text);
					Reduc *=Pourc;
					if(numericUpDown1.Value>0)
					{
						Decimal Prix = (System.Convert.ToDecimal(txUnite.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
						textBox4.Text=Prix.ToString("0.00");
						Prix = (System.Convert.ToDecimal(txUnite.Text)-Reduc);
						textBox15.Text=Prix.ToString("0.00");
					}
					else
					{
						Decimal Prix = (System.Convert.ToDecimal(txUnite.Text))*System.Convert.ToInt32(numericUpDown1.Value);
						textBox4.Text=Prix.ToString("0.00");
						Prix = (System.Convert.ToDecimal(txUnite.Text));
						textBox15.Text=Prix.ToString("0.00");
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void numericUpDown2_Enter(object sender, System.EventArgs e)
		{
			numericUpDown2.Select(0,numericUpDown2.Value.ToString().Length);
		}

		private void numericUpDown2_Leave(object sender, System.EventArgs e)
		{
			if(textBox2.TextLength>0)
			{
				try
				{
					string Pourcent = numericUpDown2.Value.ToString();
					Decimal Pourc = System.Convert.ToDecimal(Pourcent);
					Pourc/=100;
					Decimal Reduc = System.Convert.ToDecimal(txUnite.Text);
					Reduc *=Pourc;
					Decimal Prix = (System.Convert.ToDecimal(txUnite.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
					textBox4.Text=Prix.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
			else
				MessageBox.Show("Choisissez un pièce");
		}

		private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
		{
			if(txNbPieces.TextLength>0)
			{
				try
				{
					string Pourcent = numericUpDown2.Value.ToString();
					Decimal Pourc = System.Convert.ToDecimal(Pourcent);
					Pourc/=100;
					Decimal Reduc = System.Convert.ToDecimal(txUnite.Text);
					Reduc *=Pourc;
					Decimal Prix = (System.Convert.ToDecimal(txUnite.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
					textBox4.Text=Prix.ToString("0.00");
					Prix = (System.Convert.ToDecimal(txUnite.Text)-Reduc);
					textBox15.Text=Prix.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				
			}
		}

		private void textBox15_Enter(object sender, System.EventArgs e)
		{
			textBox15.Select(0,textBox15.Text.Length);
		}

		private void textBox15_Leave(object sender, System.EventArgs e)
		{
			if(mtgcComboBox2.SelectedIndex<0)
			{
				MessageBox.Show("Veuillez choisir un fournisseur SVP");
			}
			else
			{
				if(textBox2.TextLength>0)
				{
					string Cause=null;
					if(mtgcComboBox4.SelectedIndex==-1)
						Cause="";
					else
						Cause=mtgcComboBox4.Text;
					
					dataSet11.Tables["t_cde_lignes"].Clear();
					Decimal Pourcent=0;
					try
					{
				
						if(numericUpDown2.Value!=0)
							Pourcent=numericUpDown2.Value/100;
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					
					oleDbConnection1.Open();
				
					dataSet11.Tables["t_cde_entete"].Clear();
					oleDbDataAdapter1.SelectCommand.CommandText="Select * from t_cde_entete where [N° commande]="+textBox1.Text;
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					finally
					{
						oleDbConnection1.Close();
					}
					if(dataSet11.Tables["t_cde_entete"].Rows.Count.Equals(0))
					{
						oleDbConnection1.Open();
						DataRow newrow = dataSet11.Tables["t_cde_entete"].NewRow();
						newrow["N° Commande"]=textBox1.Text;
						newrow["Date commande"]=DateTime.Now.ToShortDateString();
						newrow["Code fournisseur"]=textBox18.Text;
						newrow["signature"]=txSignature.Text;
						newrow["Total commande"]=System.Convert.ToDouble(textBox6.Text);
						newrow["Remise fournisseur"]=System.Convert.ToDouble(textBox7.Text)/100;
						newrow["Montant remise"]=System.Convert.ToDouble(textBox8.Text);
						newrow["Total net commande"]=System.Convert.ToDouble(txNet.Text);
						dataSet11.Tables["t_cde_entete"].Rows.Add(newrow);
						try
						{
							oleDbDataAdapter1.Update(dataSet11);
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						finally
						{
							oleDbConnection1.Close();
						}
						oleDbConnection1.Open();
						DataRow newrow2 = dataSet11.Tables["t_cde_lignes"].NewRow();
						newrow2["N° commande"]=textBox1.Text;
						newrow2["Code piece"]=textBox20.Text;
						newrow2["Designation"]=textBox2.Text;
						newrow2["Quantite"]=numericUpDown1.Value;
						newrow2["Prix achat"]=System.Convert.ToDouble(textBox15.Text);
						newrow2["Total ligne"]=System.Convert.ToDouble(textBox4.Text);
						dataSet11.Tables["t_cde_lignes"].Rows.Add(newrow2);
						try
						{
							oleDbDataAdapter5.Update(dataSet11);
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
					{
						oleDbConnection1.Open();
						DataRow newrow2 = dataSet11.Tables["t_cde_lignes"].NewRow();
						newrow2["N° commande"]=textBox1.Text;
						newrow2["Code piece"]=textBox20.Text;
						newrow2["Designation"]=textBox2.Text;
						newrow2["Quantite"]=numericUpDown1.Value;
						newrow2["Prix achat"]=System.Convert.ToDouble(textBox15.Text);
						newrow2["Total ligne"]=System.Convert.ToDouble(textBox4.Text);
						dataSet11.Tables["t_cde_lignes"].Rows.Add(newrow2);
						try
						{
							oleDbDataAdapter5.Update(dataSet11);
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
					listView2.Items.Add(textBox3.Text);
					listView2.Items[listView2.Items.Count-1].SubItems.Add(textBox2.Text);
					listView2.Items[listView2.Items.Count-1].SubItems.Add(numericUpDown1.Value.ToString());
					listView2.Items[listView2.Items.Count-1].SubItems.Add(txUnite.Text);
					listView2.Items[listView2.Items.Count-1].SubItems.Add(textBox15.Text);
					listView2.Items[listView2.Items.Count-1].SubItems.Add(textBox4.Text);
					
					dataSet11.Tables["t_cde_lignes"].Clear();
					oleDbDataAdapter5.SelectCommand.CommandText="select [id_ligne] from t_cde_lignes";
					oleDbDataAdapter5.Fill(dataSet11);
					NumLigne=System.Convert.ToInt32(dataSet11.Tables["t_cde_lignes"].Rows[dataSet11.Tables["t_cde_lignes"].Rows.Count-1]["id_ligne"].ToString());
					
					listView1.Items.Add(textBox3.Text);
					listView1.Items[listView1.Items.Count-1].SubItems.Add("0");
					listView1.Items[listView1.Items.Count-1].SubItems.Add(numericUpDown1.Value.ToString());
					listView1.Items[listView1.Items.Count-1].SubItems.Add(numericUpDown1.Value.ToString());
					listView1.Items[listView1.Items.Count-1].SubItems.Add(NumLigne.ToString());
					
					int pieces=0;
					Double TotalCde=0;
					for(int i=0;i<listView1.Items.Count;i++)
					{
						TotalCde+=System.Convert.ToDouble(listView2.Items[i].SubItems[5].Text.Trim('€'));
						pieces+=System.Convert.ToInt32(listView2.Items[i].SubItems[2].Text);
					}

					txNbPieces.Text=pieces.ToString();
					textBox6.Text=TotalCde.ToString("0.00");
					Double Remise= (System.Convert.ToDouble(textBox6.Text)*System.Convert.ToDouble(textBox7.Text))/100;
					textBox8.Text=Remise.ToString("0.00");
					double TotalNet=TotalCde-Remise;
					txNet.Text=TotalNet.ToString("0.00");
					double remise=System.Convert.ToDouble(textBox7.Text)/100;
					Comm.CommandText="UPDATE t_cde_entete SET [Total commande]="+System.Convert.ToDouble(textBox6.Text).ToString().Replace(",",".")+",[Remise fournisseur]="+remise.ToString().Replace(",",".")+",[Montant remise]="+System.Convert.ToDouble(textBox8.Text).ToString().Replace(",",".")+",[Total net commande]="+System.Convert.ToDouble(txNet.Text).ToString().Replace(",",".")+" WHERE [N° Commande]="+textBox1.Text;
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
					mtgcComboBox4.SelectedIndex=-1;
					mtgcComboBox9.SelectedIndex=-1;
					mtgcComboBox5.SelectedIndex=-1;
					mtgcComboBox3.SelectedIndex=-1;

					textBox2.Clear();
					textBox14.Clear();
					textBox16.Clear();
					textBox3.Clear();
					textBox20.Clear();
					textBox35.Clear();
					textBox4.Text="0";
					textBox15.Text="0";
					txUnite.Text="0";
					numericUpDown1.Value=1;
					numericUpDown2.Value=0;
					Decimal Total=0;
					for(int i=0;i<listView1.Items.Count;i++)
					{
						Total+=System.Convert.ToDecimal(listView1.Items[i].SubItems[4].Text);
					}
					Decimal Relut=System.Convert.ToDecimal(textBox6.Text)-System.Convert.ToDecimal(textBox8.Text);
					txNet.Text=Relut.ToString("0.00");
					mtgcComboBox3.Text="";
					mtgcComboBox3.SelectedIndex=-1;
					mtgcComboBox5.Text="";
					mtgcComboBox5.SelectedIndex=-1;
					mtgcComboBox9.Text="";
				}
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count>0)
			{
				if(System.Convert.ToInt32(listView1.Items[listView1.SelectedIndices[0]].SubItems[3].Text)>0)
				{
					label15.Visible=true;
					label16.Visible=true;
					textBox5.Visible=true;
					textBox9.Visible=true;
					button11.Visible=true;
					textBox5.Text=listView1.Items[listView1.SelectedIndices[0]].Text;
					textBox9.Focus();
					textBox9.Select(0,textBox9.TextLength);
					int Diff=System.Convert.ToInt32(listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text)-System.Convert.ToInt32(textBox9.Text);
					if(Diff<0)
					{
						MessageBox.Show("Réception supérieure à la commande !");
					}
				}
				else
					MessageBox.Show("Pièces déja reçues");
			}
			else
				MessageBox.Show("Veuillez choisir une ligne SVP");
		}

		private void button12_Click(object sender, System.EventArgs e)
		{
			label15.Visible=false;
			label16.Visible=false;
			textBox5.Visible=false;
			textBox9.Visible=false;
			button11.Visible=false;
		}

		private void button11_Click(object sender, System.EventArgs e)
		{
			int Diff=System.Convert.ToInt32(listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text)-System.Convert.ToInt32(textBox9.Text);
			if(Diff<0)
			{
				MessageBox.Show("Réception supérieure à la commande !");
			}
			int Qte=System.Convert.ToInt32(textBox9.Text);
			Comm.CommandText="select [Quantite stock],[Quantite commande],[Quantite reserve],[Quantite disponible],[Quantite stock theorique] from t_pieces_detachees where code='"+textBox5.Text+"'";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"PD");
			int Stock=0;
			try
			{
				Stock=System.Convert.ToInt32(ds.Tables["PD"].Rows[0]["Quantite stock"].ToString());
			}
			catch
			{
				Stock=0;
			}
			int Commande=0;
			try
			{
				Commande=System.Convert.ToInt32(ds.Tables["PD"].Rows[0]["Quantite commande"].ToString());
			}
			catch
			{
				Commande=0;
			}
			int Reserve=0;
			try
			{
				Reserve=System.Convert.ToInt32(ds.Tables["PD"].Rows[0]["Quantite reserve"].ToString());
			}
			catch
			{
				Reserve=0;
			}
			int Dispo=0;
			try
			{
				Dispo=System.Convert.ToInt32(ds.Tables["PD"].Rows[0]["Quantite disponible"].ToString());
			}
			catch
			{
				Dispo=0;
			}
			int Theo=0;
			try
			{
				Theo=System.Convert.ToInt32(ds.Tables["PD"].Rows[0]["Quantite stock theorique"].ToString());
			}
			catch
			{
				Theo=0;
			}
			Stock+=Qte;
			Commande-=Qte;
			Dispo+=Qte;
			Theo=(Stock-Reserve)+Commande;
			ds.Tables["PD"].Clear();
			/*Comm.CommandText="select identificateur from t_pieces_detachees where code='"+textBox5.Text+"'";
			oleDbConnection1.Open();
			int id=System.Convert.ToInt32(Comm.ExecuteScalar());
			oleDbConnection1.Close();*/
			Comm.CommandText="update t_pieces_detachees set [Quantite stock]="+Stock.ToString()+", [Quantite commande]="+Commande.ToString()+", [Quantite disponible]="+Dispo.ToString()+", [Quantite stock theorique]="+Theo.ToString()+" where Identificateur="+txidpiece.Text;
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
				catch(OleDbException ex)
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
			Comm.CommandText="INSERT INTO t_cde_lignes_reception (id_ligne,[code piece],Quantite,daterecep) VALUES ("+listView1.Items[listView1.SelectedIndices[0]].Tag.ToString()+","+txidpiece.Text+","+System.Convert.ToInt32(textBox9.Text)+",'"+DateTime.Now.ToShortDateString()+"')";
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
				catch(OleDbException ex)
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
			listView2.Items.Clear();

			/*Comm.CommandText="select * from t_cde_lignes where [n° commande]="+textBox1.Text;
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_cde_lignes");
			foreach(DataRow row in ds.Tables["t_cde_lignes"].Rows)
			{
				Comm.CommandText="select code from t_pieces_detachees where identificateur="+row["code piece"].ToString();
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_pieces_detachees");

				Comm.CommandText="SELECT T_CDE_Lignes_reception.Id_Ligne, T_CDE_Lignes_reception.[Code piece], Sum(T_CDE_Lignes_reception.Quantite) AS SommeDeQuantite FROM T_CDE_Lignes_reception GROUP BY T_CDE_Lignes_reception.Id_Ligne, T_CDE_Lignes_reception.[Code piece] HAVING (((T_CDE_Lignes_reception.Id_Ligne)="+row["id_ligne"].ToString()+") AND ((T_CDE_Lignes_reception.[Code piece])="+row["code piece"].ToString()+"))";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_cde_lignes_reception");

				listView2.Items.Add(ds.Tables["t_pieces_detachees"].Rows[0]["code"].ToString());
				listView2.Items[listView2.Items.Count-1].SubItems.Add(row["designation"].ToString());
				listView2.Items[listView2.Items.Count-1].SubItems.Add(row["designation"].ToString());
				listView2.Items[listView2.Items.Count-1].SubItems.Add(row["quantite"].ToString());
				listView2.Items[listView2.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(row["prix achat"].ToString()).ToString("0.00"));
				listView2.Items[listView2.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(row["prix achat"].ToString()).ToString("0.00"));
				listView2.Items[listView2.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(row["total ligne"].ToString()).ToString("0.00"));
				listView1.Items.Add(ds.Tables["t_pieces_detachees"].Rows[0]["code"].ToString());
				if(ds.Tables["t_cde_lignes_reception"].Rows.Count>0)
					listView1.Items[listView1.Items.Count-1].SubItems.Add(ds.Tables["t_cde_lignes_reception"].Rows[0]["SommeDeQuantite"].ToString());
				else
					listView1.Items[listView1.Items.Count-1].SubItems.Add("0");
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["quantite"].ToString());
				int Reste=0;
				if(dataSet11.Tables["t_cde_lignes_reception"].Rows.Count>0)
				{
					Reste=System.Convert.ToInt32(row["quantite"].ToString())-System.Convert.ToInt32(dataSet11.Tables["t_cde_lignes_reception"].Rows[0]["SommeDeQuantite"].ToString());
					listView1.Items[listView1.Items.Count-1].SubItems.Add(Reste.ToString());
				}
				else
					listView1.Items[listView1.Items.Count-1].SubItems.Add(row["quantite"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["id_ligne"].ToString());
				ds.Tables["t_pieces_detachees"].Clear();
				ds.Tables["t_cde_lignes_reception"].Clear();
			}
			ds.Tables["t_cde_lignes"].Clear();*/
			Comm.CommandText="select * from t_cde_lignes where [n° commande]="+textBox1.Text;
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_cde_lignes");
				foreach(DataRow row in ds.Tables["t_cde_lignes"].Rows)
				{
					Comm.CommandText="select * from t_pieces_detachees where identificateur="+row["code piece"].ToString();
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_pieces_detachees");
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					Comm.CommandText="SELECT T_CDE_Lignes_reception.Id_Ligne, T_CDE_Lignes_reception.[Code piece], Sum(T_CDE_Lignes_reception.Quantite) AS SommeDeQuantite FROM T_CDE_Lignes_reception GROUP BY T_CDE_Lignes_reception.Id_Ligne, T_CDE_Lignes_reception.[Code piece] HAVING (((T_CDE_Lignes_reception.Id_Ligne)="+row["id_ligne"].ToString()+") AND ((T_CDE_Lignes_reception.[Code piece])="+row["code piece"].ToString()+"))";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_cde_lignes_reception");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					ListViewItem Item = new ListViewItem(ds.Tables["t_pieces_detachees"].Rows[0]["code"].ToString());
					Item.SubItems.Add(row["designation"].ToString());
					Item.SubItems.Add(row["quantite"].ToString());
					try
					{
						Item.SubItems.Add(System.Convert.ToDecimal(ds.Tables["t_pieces_detachees"].Rows[0]["prix achat brut"].ToString()).ToString("0.00"));
					}
					catch(Exception exp)
					{
						Item.SubItems.Add("0.00");
						Console.WriteLine(exp.Message);
					}
					try
					{
						Item.SubItems.Add(System.Convert.ToDecimal(ds.Tables["t_pieces_detachees"].Rows[0]["prix achat brut"].ToString()).ToString("0.00"));
					}
					catch(Exception exp)
					{
						Item.SubItems.Add("0.00");
						Console.WriteLine(exp.Message);
					}
					try
					{
						Item.SubItems.Add(System.Convert.ToDecimal(row["total ligne"].ToString()).ToString("0.00"));
					}
					catch(Exception exp)
					{
						Item.SubItems.Add("0.00");
						Console.WriteLine(exp.Message);
					}
					listView2.Items.Add(Item);
					ListViewItem Item2 = new ListViewItem(ds.Tables["t_pieces_detachees"].Rows[0]["code"].ToString());
					if(ds.Tables["t_cde_lignes_reception"].Rows.Count>0)
						Item2.SubItems.Add(ds.Tables["t_cde_lignes_reception"].Rows[0]["SommeDeQuantite"].ToString());
					else
						Item2.SubItems.Add("0");
					Item2.SubItems.Add(row["quantite"].ToString());
					int Reste=0;
					if(ds.Tables["t_cde_lignes_reception"].Rows.Count>0)
					{
						Reste=System.Convert.ToInt32(row["quantite"].ToString())-System.Convert.ToInt32(ds.Tables["t_cde_lignes_reception"].Rows[0]["SommeDeQuantite"].ToString());
						Item2.SubItems.Add(Reste.ToString());
					}
					else
						Item2.SubItems.Add(row["quantite"].ToString());
					Item2.SubItems.Add(row["code piece"].ToString());
					Item2.Tag=row["id_ligne"].ToString();
					listView1.Items.Add(Item2);
					ds.Tables["t_pieces_detachees"].Clear();
					ds.Tables["t_cde_lignes_reception"].Clear();
					ds.Tables["t_pieces_detachees"].Clear();
				}
				ds.Tables["t_cde_lignes"].Clear();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}			
			textBox9.Text="0";
			listView1.Focus();
			listView1.Items[index3].Selected=true;
			listView1.Items[index3].Focused=true;
			
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			Comm.CommandText="update t_cde_entete set valide=True where [n° commande]="+textBox1.Text;
            Comm.ExecuteNonQuery();            
			button6.Enabled=true;
			button4.Enabled=false;
			checkBox2.Checked=true;
			for(int i=0;i<listView1.Items.Count;i++)
			{
				dataSet11.Tables["t_pieces_detachees"].Clear();
				int Qte=System.Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
				Comm.CommandText="select * from t_pieces_detachees where code='"+listView1.Items[i].Text+"'";
				oleDbDataAdapter3.SelectCommand=Comm;
				oleDbDataAdapter3.Fill(dataSet11);
				int Commande=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite commande"].ToString());
				int Theorique=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite stock theorique"].ToString());
				Commande+=Qte;
				Theorique+=Qte;
				Comm.CommandText="update t_pieces_detachees set [Quantite commande]="+Commande.ToString()+", [Quantite stock theorique]="+Theorique.ToString()+" where Code='"+listView1.Items[i].Text+"'";
				Comm.ExecuteNonQuery();
			}
			oleDbConnection1.Close();
			MessageBox.Show("Commande validée","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			Comm.CommandText="update t_cde_entete set solde=True where [n° commande]="+textBox1.Text;
			Comm.ExecuteNonQuery();
			oleDbConnection1.Close();
			MessageBox.Show("Commande soldée","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
			checkBox3.Checked=true;
			mtgcComboBox3.Enabled=false;
			mtgcComboBox4.Enabled=false;
			mtgcComboBox5.Enabled=false;
			mtgcComboBox9.Enabled=false;
			button2.Enabled=false;
			button10.Enabled=false;
			textBox2.Enabled=false;
			textBox6.Enabled=false;
			textBox7.Enabled=false;
			txNet.Enabled=false;
			textBox8.Enabled=false;
			textBox14.Enabled=false;
			textBox16.Enabled=false;
			numericUpDown1.Enabled=false;
			numericUpDown2.Enabled=false;
			txUnite.Enabled=false;
			textBox4.Enabled=false;
			textBox15.Enabled=false;
			listView2.Enabled=false;
			textBox13.Enabled=false;
			dateTimePicker1.Enabled=false;
			dateTimePicker2.Enabled=false;
			mtgcComboBox1.Enabled=false;
			mtgcComboBox2.Enabled=false;
			button6.Enabled=false;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			oleDbDataAdapter10.Fill(dataSet11);
			dataSet11.Tables["t_cde_entete"].Clear();
			oleDbSelectCommand1.CommandText="SELECT T_CDE_entete.[N° Commande], T_CDE_entete.[Date Commande], T_CDE_entete.Signature, T_CDE_entete.[Total commande], T_CDE_entete.[Total net Commande], T_CDE_Lignes.Designation, T_CDE_Lignes.[Prix achat], T_CDE_Lignes.[Total ligne], T_CDE_Lignes.[Date livraison], T_CDE_entete.[Montant remise], T_CDE_entete.[Remise fournisseur], T_fournisseurs.Nom, T_fournisseurs.[Adresse 1], T_fournisseurs.[Adresse 2], T_fournisseurs.[Code Postal], T_fournisseurs.Ville, T_fournisseurs.Pays, T_CDE_Lignes.Quantite, T_CDE_Lignes.[Date livraison], T_pieces_detachees.Code, T_CDE_entete.[N° Commande] FROM T_pieces_detachees INNER JOIN ((T_fournisseurs INNER JOIN T_CDE_entete ON T_fournisseurs.Code = T_CDE_entete.[Code fournisseur]) INNER JOIN T_CDE_Lignes ON T_CDE_entete.[N° Commande] = T_CDE_Lignes.[N° Commande]) ON T_pieces_detachees.Identificateur = T_CDE_Lignes.[Code piece] WHERE (((T_CDE_entete.[N° Commande])="+textBox1.Text+"))";
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			Page=0;
			countRow=0;
			oleDbConnection1.Open();
			Comm.CommandText="update t_cde_entete set Edite=True where [n° commande]="+textBox1.Text;
			Comm.ExecuteNonQuery();
			oleDbConnection1.Close();
			checkBox1.Checked=true;
			button4.Enabled=true;
			printDocument1.Print();
			
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			
			int ypos=e.MarginBounds.Top+120;
			e.Graphics.DrawString("Facturation", new Font("Arial", 8, FontStyle.Underline|FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Le : "+DateTime.Now.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-70, ypos);
			ypos+=15;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["f_adresse1"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["f_cp"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["f_ville"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=15;
			e.Graphics.DrawString("T. "+dataSet11.Tables["parametres"].Rows[0]["f_tel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("F. "+dataSet11.Tables["parametres"].Rows[0]["f_fax"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+110, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["adresse 1"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=15;
			e.Graphics.DrawString("Livraison", new Font("Arial", 8, FontStyle.Underline|FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["adresse 2"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=15;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["l_adresse1"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["code postal"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["ville"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+180, ypos);
			ypos+=15;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["l_cp"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["l_ville"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+50, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[0]["pays"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Width/2+130, ypos);
			ypos+=40;
			e.Graphics.DrawString("Commande N° "+dataSet11.Tables["t_cde_entete"].Rows[0]["n° commande"].ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
			ypos+=25;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=2;
			e.Graphics.DrawString("Code", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Designation", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+90, ypos);
			e.Graphics.DrawString("Quantité", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
			e.Graphics.DrawString("Prix unitaire", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+385, ypos);
			e.Graphics.DrawString("Total ligne", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
			e.Graphics.DrawString("A livrer", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+570, ypos);
			ypos+=20;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=5;
			while(ypos<e.MarginBounds.Height-130&&countRow<dataSet11.Tables["t_cde_entete"].Rows.Count)
			{ 
				e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Code"].ToString(), 
					new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Designation"].ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+90, ypos);
				e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Quantite"].ToString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+340, ypos);
				e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Prix achat"].ToString()).ToString("c"), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+410, ypos);
				e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Total ligne"].ToString()).ToString("c"), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
				if(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Date livraison"].ToString().Length>0)
				{
					e.Graphics.DrawString(dataSet11.Tables["t_cde_entete"].Rows[countRow]["Date livraison"].ToString().Remove(10,9), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
				}
				ypos+=15;
				countRow+=1;
			}
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,e.MarginBounds.Height-100), new Point(e.MarginBounds.Right,e.MarginBounds.Height-100));
			ypos+=5;
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["message_cde"].ToString(), 
				new Font("Arial", 6, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Height-90);
			e.Graphics.DrawString("Total H.T. ", 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-180, e.MarginBounds.Height-70);
			e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[0]["Total commande"].ToString()).ToString("c"), 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-40, e.MarginBounds.Height-70);
			e.Graphics.DrawString("Remise "+(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[0]["Remise Fournisseur"].ToString())*100).ToString("0.00")+"%", 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-180, e.MarginBounds.Height-50);
			e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[0]["montant remise"].ToString()).ToString("c"), 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-40, e.MarginBounds.Height-50);
			e.Graphics.DrawString("Total net H.T. ", 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-180, e.MarginBounds.Height-30);
			e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_cde_entete"].Rows[0]["Total net commande"].ToString()).ToString("c"), 
				new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-40, e.MarginBounds.Height-30);
			e.Graphics.DrawString(dataSet11.Tables["parametres"].Rows[0]["signature"].ToString(), 
				new Font("Arial", 6, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Height-10);
			if(countRow<dataSet11.Tables["t_cde_entete"].Rows.Count)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
			}
		}

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			textBox35.Visible=true;
			button14.Visible=true;
			button15.Visible=true;
		}

		private void button15_Click(object sender, System.EventArgs e)
		{
			textBox35.Visible=false;
			button14.Visible=false;
			button15.Visible=false;
		}

		private void Vider()
		{
			mtgcComboBox3.SelectedIndex=-1;
			textBox3.Clear();
			textBox14.Clear();
			textBox15.Clear();
			textBox16.Clear();
			txUnite.Clear();
			textBox6.Text=textBox6.Text.Replace(".",",");
			textBox7.Text=textBox7.Text.Replace(".",",");
			textBox8.Text=textBox8.Text.Replace(".",",");
			txNet.Text=txNet.Text.Replace(".",",");
			textBox15.Text=textBox15.Text.Replace(".",",");
			txUnite.Text=txUnite.Text.Replace(".",",");
			dataSet11.Tables["t_pieces_detachees"].Clear();
			listView1.Items.Clear();
			listView2.Items.Clear();
			checkBox1.Checked=false;
			checkBox2.Checked=false;
			checkBox3.Checked=false;
			save=false;
		}

		

		private void button13_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Supprimer la ligne ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
			{
				if(listView2.SelectedIndices.Count>0)
				{
					dataSet11.Tables["t_cde_lignes"].Clear();
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.Connection=oleDbConnection1;
			
					Comm.CommandText="SELECT T_CDE_Lignes.[N° Commande], T_CDE_Lignes.Designation,T_CDE_Lignes.[id_ligne], T_CDE_Lignes.Quantite, T_CDE_Lignes.[Total ligne], T_pieces_detachees.Code, T_CDE_Lignes.[Code piece] FROM T_pieces_detachees INNER JOIN T_CDE_Lignes ON T_pieces_detachees.Identificateur = T_CDE_Lignes.[Code piece] WHERE (((T_CDE_Lignes.[N° Commande])="+textBox1.Text+") AND ((T_CDE_Lignes.Quantite)="+listView2.Items[listView2.SelectedIndices[0]].SubItems[2].Text+") AND ((T_pieces_detachees.Code)='"+listView2.Items[listView2.SelectedIndices[0]].Text+"'))";
					oleDbDataAdapter5.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter5.Fill(dataSet11,"t_cde_lignes");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Open();
					Transac=oleDbConnection1.BeginTransaction();
					Comm.CommandText="delete from t_cde_lignes where [id_ligne]="+dataSet11.Tables["t_cde_lignes"].Rows[0]["id_ligne"].ToString();
					Comm.Transaction=Transac;
					try
					{
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							listView1.Items[listView2.SelectedIndices[0]].Remove();
							listView2.Items[listView2.SelectedIndices[0]].Remove();
							int pieces=0;
							Double TotalCde=0;
							for(int i=0;i<listView1.Items.Count;i++)
							{
								TotalCde+=System.Convert.ToDouble(listView2.Items[i].SubItems[5].Text.Trim('€'));
								pieces+=System.Convert.ToInt32(listView2.Items[i].SubItems[2].Text);
							}

							txNbPieces.Text=pieces.ToString();
							textBox6.Text=TotalCde.ToString("0.00");
							Double Remise= (System.Convert.ToDouble(textBox6.Text)*System.Convert.ToDouble(textBox7.Text))/100;
							textBox8.Text=Remise.ToString("0.00");
							double TotalNet=TotalCde-Remise;
							txNet.Text=TotalNet.ToString("0.00");
							double remise=System.Convert.ToDouble(textBox7.Text)/100;
							Comm.CommandText="UPDATE t_cde_entete SET [Total commande]="+System.Convert.ToDouble(textBox6.Text).ToString().Replace(",",".")+",[Remise fournisseur]="+remise.ToString().Replace(",",".")+",[Montant remise]="+System.Convert.ToDouble(textBox8.Text).ToString().Replace(",",".")+",[Total net commande]="+System.Convert.ToDouble(txNet.Text).ToString().Replace(",",".")+" WHERE [N° Commande]="+textBox1.Text;
							try
							{
								oleDbConnection1.Close();
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
						}
						catch(Exception excp)
						{
							try
							{
								Transac.Rollback();
							}
							catch(Exception ex)
							{
								Console.WriteLine(excp.Message);
								MessageBox.Show(ex.Message);
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
			}
		}

		private void textBox15_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Supprimer la commande ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
			{
				oleDbConnection1.Open();
				Comm.CommandText="DELETE FROM t_cde_entete WHERE [N° commande]="+textBox1.Text;
				Transac= oleDbConnection1.BeginTransaction();
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
						this.Dispose();
					}
					catch(OleDbException exp)
					{
						Transac.Rollback();
					}
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally
				{
					oleDbConnection1.Close();
				}
			}
		}

		private void Commande_VisibleChanged(object sender, System.EventArgs e)
		{
		}

		private void listView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				textBox5.Text=listView1.Items[listView1.SelectedIndices[0]].Text;
				txidpiece.Text=listView1.Items[listView1.SelectedIndices[0]].SubItems[4].Text;
				textBox9.Focus();
				textBox9.Select(0,textBox9.TextLength);
				index3=listView1.SelectedIndices[0];
			}
		}
	}
}
