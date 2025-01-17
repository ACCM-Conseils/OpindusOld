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
	/// Description résumée de Pieces.
	/// </summary>
	public class Pieces : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.ListView listView1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
		private bool Nouveau;
		private string TVA;
		private string ta;
		private int Agence;
        private static bool alreadyLoaded = false;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox5;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private MTGCComboBox mtgcComboBox1;
		private MTGCComboBox mtgcComboBox2;
		private MTGCComboBox mtgcComboBox3;
		private MTGCComboBox mtgcComboBox4;
		private MTGCComboBox mtgcComboBox5;
		private MTGCComboBox mtgcComboBox6;
		private MTGCComboBox mtgcComboBox7;
		private OleDbCommand Comm;
		private System.Windows.Forms.Button button9;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter6;
		private bool Premier;
		private string CodePiece;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox txDateModif;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
		private System.Windows.Forms.Button btPieces;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private OleDbTransaction Transac;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Pieces(int Agence, string Code)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			Premier=true;
			Nouveau=false;
			CodePiece=Code;
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
			DataAD = new OleDbDataAdapter();
			ds = new DataSet();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pieces));
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txDateModif = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtgcComboBox6 = new MTGCComboBox();
            this.mtgcComboBox5 = new MTGCComboBox();
            this.mtgcComboBox4 = new MTGCComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtgcComboBox3 = new MTGCComboBox();
            this.mtgcComboBox2 = new MTGCComboBox();
            this.mtgcComboBox1 = new MTGCComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter5 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
            this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            this.btPieces = new System.Windows.Forms.Button();
            this.mtgcComboBox7 = new MTGCComboBox();
            this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
            this.button9 = new System.Windows.Forms.Button();
            this.oleDbDataAdapter6 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.tabControlEX1.SuspendLayout();
            this.tabPageEX1.SuspendLayout();
            this.tabPageEX2.SuspendLayout();
            this.tabPageEX3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(416, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 18);
            this.label6.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(806, 344);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Pré devis";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(24, 352);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 16);
            this.label23.TabIndex = 10;
            this.label23.Text = "Cause principale";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox20);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txDateModif);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(20, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 149);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(176, 112);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 35;
            this.textBox20.TabStop = false;
            this.textBox20.Text = "0,00";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(176, 64);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 34;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "0,00";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(176, 20);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "0,00";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyDown);
            this.textBox8.Leave += new System.EventHandler(this.textBox8_Leave_1);
            this.textBox8.Enter += new System.EventHandler(this.textBox8_Enter);
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(280, 112);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(15, 15);
            this.label34.TabIndex = 30;
            this.label34.Text = "€";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(280, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 15);
            this.label17.TabIndex = 29;
            this.label17.Text = "€";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(280, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "€";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(536, 64);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(20, 19);
            this.label33.TabIndex = 17;
            this.label33.Text = "%";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(472, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 15);
            this.label22.TabIndex = 11;
            this.label22.Text = "0";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(472, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 17);
            this.label21.TabIndex = 10;
            this.label21.Text = "0";
            // 
            // txDateModif
            // 
            this.txDateModif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDateModif.Enabled = false;
            this.txDateModif.Location = new System.Drawing.Point(472, 21);
            this.txDateModif.Name = "txDateModif";
            this.txDateModif.ReadOnly = true;
            this.txDateModif.Size = new System.Drawing.Size(116, 20);
            this.txDateModif.TabIndex = 9;
            this.txDateModif.TabStop = false;
            this.txDateModif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(360, 112);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 15);
            this.label20.TabIndex = 8;
            this.label20.Text = "Coef PA PV";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(360, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 18);
            this.label19.TabIndex = 7;
            this.label19.Text = "Remise";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(360, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "Date MAJ Tarif";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Prix vente";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Prix achat net";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Prix achat brut";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtgcComboBox6);
            this.groupBox2.Controls.Add(this.mtgcComboBox5);
            this.groupBox2.Controls.Add(this.mtgcComboBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Location = new System.Drawing.Point(20, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 168);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // mtgcComboBox6
            // 
            this.mtgcComboBox6.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox6.ColumnNum = 2;
            this.mtgcComboBox6.ColumnWidth = "50;200";
            this.mtgcComboBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtgcComboBox6.DisplayMember = "Text";
            this.mtgcComboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox6.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox6.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox6.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox6.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox6.DropDownWidth = 270;
            this.mtgcComboBox6.Enabled = false;
            this.mtgcComboBox6.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox6.GridLineHorizontal = false;
            this.mtgcComboBox6.GridLineVertical = false;
            this.mtgcComboBox6.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox6.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox6.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox6.Location = new System.Drawing.Point(176, 128);
            this.mtgcComboBox6.ManagingFastMouseMoving = true;
            this.mtgcComboBox6.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox6.Name = "mtgcComboBox6";
            this.mtgcComboBox6.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox6.Size = new System.Drawing.Size(208, 21);
            this.mtgcComboBox6.TabIndex = 7;
            this.mtgcComboBox6.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox6_SelectedIndexChanged);
            // 
            // mtgcComboBox5
            // 
            this.mtgcComboBox5.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox5.ColumnNum = 2;
            this.mtgcComboBox5.ColumnWidth = "50;200";
            this.mtgcComboBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtgcComboBox5.DisplayMember = "Text";
            this.mtgcComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox5.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox5.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox5.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox5.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox5.DropDownWidth = 270;
            this.mtgcComboBox5.Enabled = false;
            this.mtgcComboBox5.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox5.GridLineHorizontal = false;
            this.mtgcComboBox5.GridLineVertical = false;
            this.mtgcComboBox5.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox5.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox5.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox5.Location = new System.Drawing.Point(176, 98);
            this.mtgcComboBox5.ManagingFastMouseMoving = true;
            this.mtgcComboBox5.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox5.Name = "mtgcComboBox5";
            this.mtgcComboBox5.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox5.Size = new System.Drawing.Size(208, 21);
            this.mtgcComboBox5.TabIndex = 6;
            this.mtgcComboBox5.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox5_SelectedIndexChanged);
            // 
            // mtgcComboBox4
            // 
            this.mtgcComboBox4.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox4.ColumnNum = 1;
            this.mtgcComboBox4.ColumnWidth = "121";
            this.mtgcComboBox4.DisplayMember = "Text";
            this.mtgcComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox4.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox4.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox4.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox4.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox4.DropDownWidth = 141;
            this.mtgcComboBox4.Enabled = false;
            this.mtgcComboBox4.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox4.GridLineHorizontal = false;
            this.mtgcComboBox4.GridLineVertical = false;
            this.mtgcComboBox4.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox4.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox4.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox4.Location = new System.Drawing.Point(176, 42);
            this.mtgcComboBox4.ManagingFastMouseMoving = true;
            this.mtgcComboBox4.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox4.Name = "mtgcComboBox4";
            this.mtgcComboBox4.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox4.Size = new System.Drawing.Size(560, 21);
            this.mtgcComboBox4.TabIndex = 3;
            this.mtgcComboBox4.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox4_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(144, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(24, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.TabStop = false;
            this.textBox5.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(744, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 21);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(408, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 17);
            this.label5.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(408, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 15);
            this.label4.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Code unité";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Famille";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(424, 70);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(136, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "0";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Désignation";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Délai livraison";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fournisseur";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(176, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(560, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Correspondance stock";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(176, 72);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(136, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "?";
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(433, 65);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(80, 20);
            this.textBox19.TabIndex = 18;
            this.textBox19.Text = "0";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(324, 66);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 16);
            this.label32.TabIndex = 17;
            this.label32.Text = "Stock théorique";
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(205, 253);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(110, 20);
            this.textBox18.TabIndex = 16;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox18.Enter += new System.EventHandler(this.textBox18_Enter);
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(53, 253);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(136, 16);
            this.label31.TabIndex = 15;
            this.label31.Text = "Date dernier mouvement";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(205, 225);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(80, 20);
            this.textBox17.TabIndex = 14;
            this.textBox17.Text = "0";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(53, 225);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(112, 16);
            this.label30.TabIndex = 13;
            this.label30.Text = "Quantité disponible";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(205, 197);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(80, 20);
            this.textBox16.TabIndex = 12;
            this.textBox16.Text = "0";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(53, 197);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 16);
            this.label29.TabIndex = 11;
            this.label29.Text = "Quantité réserve";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(205, 170);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(80, 20);
            this.textBox15.TabIndex = 10;
            this.textBox15.Text = "0";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(53, 170);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(135, 16);
            this.label28.TabIndex = 9;
            this.label28.Text = "Quantité commande";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(205, 143);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(80, 20);
            this.textBox14.TabIndex = 8;
            this.textBox14.Text = "0";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(53, 143);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 16);
            this.label27.TabIndex = 7;
            this.label27.Text = "Quantité maxi";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(205, 116);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(80, 20);
            this.textBox13.TabIndex = 6;
            this.textBox13.Text = "0";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(53, 116);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 16);
            this.label26.TabIndex = 5;
            this.label26.Text = "Stock alerte";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(205, 90);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(80, 20);
            this.textBox12.TabIndex = 4;
            this.textBox12.Text = "0";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(205, 64);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(80, 20);
            this.textBox11.TabIndex = 3;
            this.textBox11.Text = "0";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(54, 92);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 15);
            this.label25.TabIndex = 2;
            this.label25.Text = "Quantité minimale";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(54, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 18);
            this.label24.TabIndex = 1;
            this.label24.Text = "Quantité stock";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(205, 38);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(308, 20);
            this.textBox10.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(900, 267);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° Devis";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qté";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtgcComboBox3);
            this.groupBox1.Controls.Add(this.mtgcComboBox2);
            this.groupBox1.Controls.Add(this.mtgcComboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // mtgcComboBox3
            // 
            this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox3.ColumnNum = 2;
            this.mtgcComboBox3.ColumnWidth = "150;200";
            this.mtgcComboBox3.DisplayMember = "Text";
            this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox3.DropDownWidth = 370;
            this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox3.GridLineHorizontal = false;
            this.mtgcComboBox3.GridLineVertical = true;
            this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox3.Location = new System.Drawing.Point(640, 16);
            this.mtgcComboBox3.ManagingFastMouseMoving = true;
            this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox3.Name = "mtgcComboBox3";
            this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox3.Size = new System.Drawing.Size(264, 21);
            this.mtgcComboBox3.TabIndex = 11;
            this.mtgcComboBox3.TabStop = false;
            this.mtgcComboBox3.Enter += new System.EventHandler(this.mtgcComboBox3_Enter);
            this.mtgcComboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox3_KeyDown);
            // 
            // mtgcComboBox2
            // 
            this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox2.ColumnNum = 3;
            this.mtgcComboBox2.ColumnWidth = "100;250;100";
            this.mtgcComboBox2.DisplayMember = "Text";
            this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox2.DropDownWidth = 470;
            this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox2.GridLineHorizontal = false;
            this.mtgcComboBox2.GridLineVertical = true;
            this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox2.Location = new System.Drawing.Point(328, 16);
            this.mtgcComboBox2.ManagingFastMouseMoving = true;
            this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox2.Name = "mtgcComboBox2";
            this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox2.Size = new System.Drawing.Size(264, 21);
            this.mtgcComboBox2.TabIndex = 1;
            this.mtgcComboBox2.TabStop = false;
            this.mtgcComboBox2.Enter += new System.EventHandler(this.mtgcComboBox2_Enter);
            this.mtgcComboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox2_KeyDown);
            // 
            // mtgcComboBox1
            // 
            this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox1.ColumnNum = 3;
            this.mtgcComboBox1.ColumnWidth = "150;200;150";
            this.mtgcComboBox1.DisplayMember = "Text";
            this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox1.DropDownWidth = 520;
            this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox1.GridLineHorizontal = false;
            this.mtgcComboBox1.GridLineVertical = true;
            this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox1.Location = new System.Drawing.Point(32, 16);
            this.mtgcComboBox1.ManagingFastMouseMoving = true;
            this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox1.Name = "mtgcComboBox1";
            this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.Size = new System.Drawing.Size(248, 21);
            this.mtgcComboBox1.TabIndex = 9;
            this.mtgcComboBox1.TabStop = false;
            this.mtgcComboBox1.Enter += new System.EventHandler(this.mtgcComboBox1_Enter);
            this.mtgcComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ancienne Ref";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identificateur";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(712, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(192, 20);
            this.textBox3.TabIndex = 50;
            this.textBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(400, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(88, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            // 
            // btSupprime
            // 
            this.btSupprime.BackColor = System.Drawing.Color.White;
            this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupprime.Enabled = false;
            this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprime.ForeColor = System.Drawing.Color.Red;
            this.btSupprime.Location = new System.Drawing.Point(488, 648);
            this.btSupprime.Name = "btSupprime";
            this.btSupprime.Size = new System.Drawing.Size(100, 23);
            this.btSupprime.TabIndex = 25;
            this.btSupprime.TabStop = false;
            this.btSupprime.Text = "Supprime";
            this.btSupprime.UseVisualStyleBackColor = false;
            this.btSupprime.Click += new System.EventHandler(this.btSupprime_Click);
            // 
            // btEnregistre
            // 
            this.btEnregistre.BackColor = System.Drawing.Color.White;
            this.btEnregistre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnregistre.Enabled = false;
            this.btEnregistre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnregistre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistre.ForeColor = System.Drawing.Color.Blue;
            this.btEnregistre.Location = new System.Drawing.Point(128, 648);
            this.btEnregistre.Name = "btEnregistre";
            this.btEnregistre.Size = new System.Drawing.Size(100, 23);
            this.btEnregistre.TabIndex = 9;
            this.btEnregistre.TabStop = false;
            this.btEnregistre.Text = "Enregistre";
            this.btEnregistre.UseVisualStyleBackColor = false;
            this.btEnregistre.Click += new System.EventHandler(this.btEnregistre_Click);
            // 
            // btNouveau
            // 
            this.btNouveau.BackColor = System.Drawing.Color.White;
            this.btNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNouveau.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNouveau.ForeColor = System.Drawing.Color.Blue;
            this.btNouveau.Location = new System.Drawing.Point(16, 648);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(100, 23);
            this.btNouveau.TabIndex = 23;
            this.btNouveau.TabStop = false;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.UseVisualStyleBackColor = false;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
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
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Identificateur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Identificateur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_Principale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Unite1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_11", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Vente1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pre_devis", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, "Cause Principale"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 18, "Code"),
            new System.Data.OleDb.OleDbParameter("Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, "Code Famille"),
            new System.Data.OleDb.OleDbParameter("Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, "Code Fournisseur Principal"),
            new System.Data.OleDb.OleDbParameter("Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, "Code Unite"),
            new System.Data.OleDb.OleDbParameter("Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, "Code_1"),
            new System.Data.OleDb.OleDbParameter("Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, "Correspondance Stock"),
            new System.Data.OleDb.OleDbParameter("Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Mouvement"),
            new System.Data.OleDb.OleDbParameter("Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Tarif"),
            new System.Data.OleDb.OleDbParameter("Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai Livraison"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"),
            new System.Data.OleDb.OleDbParameter("Identificateur", System.Data.OleDb.OleDbType.Integer, 0, "Identificateur"),
            new System.Data.OleDb.OleDbParameter("pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, "pre_devis"),
            new System.Data.OleDb.OleDbParameter("Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Brut"),
            new System.Data.OleDb.OleDbParameter("Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Net"),
            new System.Data.OleDb.OleDbParameter("Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, "Prix Vente"),
            new System.Data.OleDb.OleDbParameter("Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, "Quantite Commande"),
            new System.Data.OleDb.OleDbParameter("Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, "Quantite Disponible"),
            new System.Data.OleDb.OleDbParameter("Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Quantite Maxi"),
            new System.Data.OleDb.OleDbParameter("Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, "Quantite Minimum"),
            new System.Data.OleDb.OleDbParameter("Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, "Quantite Reserve"),
            new System.Data.OleDb.OleDbParameter("Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, "Quantite Stock"),
            new System.Data.OleDb.OleDbParameter("Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, "Quantite stock theorique"),
            new System.Data.OleDb.OleDbParameter("Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, "Stock Alerte")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, "Cause Principale"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 18, "Code"),
            new System.Data.OleDb.OleDbParameter("Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, "Code Famille"),
            new System.Data.OleDb.OleDbParameter("Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, "Code Fournisseur Principal"),
            new System.Data.OleDb.OleDbParameter("Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, "Code Unite"),
            new System.Data.OleDb.OleDbParameter("Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, "Code_1"),
            new System.Data.OleDb.OleDbParameter("Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, "Correspondance Stock"),
            new System.Data.OleDb.OleDbParameter("Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Mouvement"),
            new System.Data.OleDb.OleDbParameter("Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Tarif"),
            new System.Data.OleDb.OleDbParameter("Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai Livraison"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"),
            new System.Data.OleDb.OleDbParameter("Identificateur", System.Data.OleDb.OleDbType.Integer, 0, "Identificateur"),
            new System.Data.OleDb.OleDbParameter("pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, "pre_devis"),
            new System.Data.OleDb.OleDbParameter("Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Brut"),
            new System.Data.OleDb.OleDbParameter("Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat Net"),
            new System.Data.OleDb.OleDbParameter("Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, "Prix Vente"),
            new System.Data.OleDb.OleDbParameter("Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, "Quantite Commande"),
            new System.Data.OleDb.OleDbParameter("Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, "Quantite Disponible"),
            new System.Data.OleDb.OleDbParameter("Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Quantite Maxi"),
            new System.Data.OleDb.OleDbParameter("Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, "Quantite Minimum"),
            new System.Data.OleDb.OleDbParameter("Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, "Quantite Reserve"),
            new System.Data.OleDb.OleDbParameter("Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, "Quantite Stock"),
            new System.Data.OleDb.OleDbParameter("Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, "Quantite stock theorique"),
            new System.Data.OleDb.OleDbParameter("Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, "Stock Alerte"),
            new System.Data.OleDb.OleDbParameter("Original_Identificateur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Identificateur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_Principale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_Principale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause Principale", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Famille", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Fournisseur_Principal1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Fournisseur Principal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Unite", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Unite1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Unite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_11", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Correspondance_Stock1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correspondance Stock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Mouvement1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Dernier Mouvement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ Tarif", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_Livraison1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai Livraison", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Brut1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat Brut", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat_Net1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat Net", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Vente", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Vente1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Vente", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Commande1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Disponible1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Disponible", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Minimum1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Minimum", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Reserve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Reserve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_Stock1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite Stock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite_stock_theorique1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite stock theorique", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Stock_Alerte1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Stock Alerte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_pre_devis", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pre_devis", System.Data.DataRowVersion.Original, null)});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_famille_piece", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = "DELETE FROM T_famille_piece WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AN" +
                "D Designation IS NULL)";
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO T_famille_piece(Code, Designation) VALUES (?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation")});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT Code, Designation FROM T_famille_piece";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = "UPDATE T_famille_piece SET Code = ?, Designation = ? WHERE (Code = ?) AND (Design" +
                "ation = ? OR ? IS NULL AND Designation IS NULL)";
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_unites", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM T_unites WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Desig" +
                "nation IS NULL)";
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO T_unites(Code, Designation) VALUES (?, ?)";
            this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation")});
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT Code, Designation FROM T_unites";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = "UPDATE T_unites SET Code = ?, Designation = ? WHERE (Code = ?) AND (Designation =" +
                " ? OR ? IS NULL AND Designation IS NULL)";
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter4
            // 
            this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand4;
            this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand4;
            this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
            this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_fournisseurs", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Activite", "Activite"),
                        new System.Data.Common.DataColumnMapping("Adresse 1", "Adresse 1"),
                        new System.Data.Common.DataColumnMapping("Adresse 2", "Adresse 2"),
                        new System.Data.Common.DataColumnMapping("Chiffre affaire Annee_1", "Chiffre affaire Annee_1"),
                        new System.Data.Common.DataColumnMapping("Chiffre affaire Annee_2", "Chiffre affaire Annee_2"),
                        new System.Data.Common.DataColumnMapping("Chiffre affaire Annee_3", "Chiffre affaire Annee_3"),
                        new System.Data.Common.DataColumnMapping("Chiffre affaire Annee_4", "Chiffre affaire Annee_4"),
                        new System.Data.Common.DataColumnMapping("Chiffre affaire en cours", "Chiffre affaire en cours"),
                        new System.Data.Common.DataColumnMapping("Chiffre affaire PV", "Chiffre affaire PV"),
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Code Postal", "Code Postal"),
                        new System.Data.Common.DataColumnMapping("Coef PA PV", "Coef PA PV"),
                        new System.Data.Common.DataColumnMapping("Commentaire", "Commentaire"),
                        new System.Data.Common.DataColumnMapping("Nom", "Nom"),
                        new System.Data.Common.DataColumnMapping("Pays", "Pays"),
                        new System.Data.Common.DataColumnMapping("Pourcentage Remise", "Pourcentage Remise"),
                        new System.Data.Common.DataColumnMapping("Telecopie", "Telecopie"),
                        new System.Data.Common.DataColumnMapping("Telephone", "Telephone"),
                        new System.Data.Common.DataColumnMapping("Telex", "Telex"),
                        new System.Data.Common.DataColumnMapping("Ville", "Ville")})});
            this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand4;
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = resources.GetString("oleDbDeleteCommand4.CommandText");
            this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Activite", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Activite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Activite1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Activite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pays", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pays", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = resources.GetString("oleDbInsertCommand4.CommandText");
            this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Activite", System.Data.OleDb.OleDbType.VarWChar, 255, "Activite"),
            new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 1"),
            new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 2"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_1"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_2"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_3"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_4"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire en cours"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire PV"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"),
            new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"),
            new System.Data.OleDb.OleDbParameter("Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, "Coef PA PV"),
            new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"),
            new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"),
            new System.Data.OleDb.OleDbParameter("Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage Remise"),
            new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"),
            new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"),
            new System.Data.OleDb.OleDbParameter("Telex", System.Data.OleDb.OleDbType.VarWChar, 255, "Telex"),
            new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville")});
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = resources.GetString("oleDbSelectCommand4.CommandText");
            this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = resources.GetString("oleDbUpdateCommand4.CommandText");
            this.oleDbUpdateCommand4.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Activite", System.Data.OleDb.OleDbType.VarWChar, 255, "Activite"),
            new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 1"),
            new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 2"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_1"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_2"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_3"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_4"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire en cours"),
            new System.Data.OleDb.OleDbParameter("Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire PV"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"),
            new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"),
            new System.Data.OleDb.OleDbParameter("Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, "Coef PA PV"),
            new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"),
            new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"),
            new System.Data.OleDb.OleDbParameter("Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage Remise"),
            new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"),
            new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"),
            new System.Data.OleDb.OleDbParameter("Telex", System.Data.OleDb.OleDbType.VarWChar, 255, "Telex"),
            new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Activite", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Activite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Activite1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Activite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pays", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pays", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter5
            // 
            this.oleDbDataAdapter5.DeleteCommand = this.oleDbDeleteCommand5;
            this.oleDbDataAdapter5.InsertCommand = this.oleDbInsertCommand5;
            this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
            this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_causes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
            this.oleDbDataAdapter5.UpdateCommand = this.oleDbUpdateCommand5;
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = "DELETE FROM T_causes WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Desig" +
                "nation IS NULL)";
            this.oleDbDeleteCommand5.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO T_causes(Code, Designation) VALUES (?, ?)";
            this.oleDbInsertCommand5.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation")});
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT Code, Designation FROM T_causes";
            this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = "UPDATE T_causes SET Code = ?, Designation = ? WHERE (Code = ?) AND (Designation =" +
                " ? OR ? IS NULL AND Designation IS NULL)";
            this.oleDbUpdateCommand5.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
            // 
            // tabControlEX1
            // 
            this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
            this.tabControlEX1.Controls.Add(this.tabPageEX1);
            this.tabControlEX1.Controls.Add(this.tabPageEX2);
            this.tabControlEX1.Controls.Add(this.tabPageEX3);
            this.tabControlEX1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlEX1.Location = new System.Drawing.Point(-8, 80);
            this.tabControlEX1.Name = "tabControlEX1";
            this.tabControlEX1.SelectedIndex = 0;
            this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Gainsboro;
            this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
            this.tabControlEX1.Size = new System.Drawing.Size(944, 536);
            this.tabControlEX1.TabColor = System.Drawing.Color.Silver;
            this.tabControlEX1.TabIndex = 27;
            this.tabControlEX1.TabStop = false;
            this.tabControlEX1.UseVisualStyles = false;
            // 
            // tabPageEX1
            // 
            this.tabPageEX1.Controls.Add(this.btPieces);
            this.tabPageEX1.Controls.Add(this.mtgcComboBox7);
            this.tabPageEX1.Controls.Add(this.label23);
            this.tabPageEX1.Controls.Add(this.groupBox2);
            this.tabPageEX1.Controls.Add(this.label6);
            this.tabPageEX1.Controls.Add(this.checkBox1);
            this.tabPageEX1.Controls.Add(this.groupBox3);
            this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(936, 507);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Saisie";
            // 
            // btPieces
            // 
            this.btPieces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.btPieces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPieces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPieces.ForeColor = System.Drawing.Color.White;
            this.btPieces.Image = ((System.Drawing.Image)(resources.GetObject("btPieces.Image")));
            this.btPieces.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPieces.Location = new System.Drawing.Point(816, 392);
            this.btPieces.Name = "btPieces";
            this.btPieces.Size = new System.Drawing.Size(96, 96);
            this.btPieces.TabIndex = 14;
            this.btPieces.TabStop = false;
            this.btPieces.Text = "P&ièces détachées";
            this.btPieces.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPieces.UseVisualStyleBackColor = false;
            // 
            // mtgcComboBox7
            // 
            this.mtgcComboBox7.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox7.ColumnNum = 2;
            this.mtgcComboBox7.ColumnWidth = "50;200";
            this.mtgcComboBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtgcComboBox7.DisplayMember = "Text";
            this.mtgcComboBox7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox7.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox7.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox7.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox7.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox7.DropDownWidth = 270;
            this.mtgcComboBox7.Enabled = false;
            this.mtgcComboBox7.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox7.GridLineHorizontal = false;
            this.mtgcComboBox7.GridLineVertical = false;
            this.mtgcComboBox7.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox7.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox7.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox7.Location = new System.Drawing.Point(136, 352);
            this.mtgcComboBox7.ManagingFastMouseMoving = true;
            this.mtgcComboBox7.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox7.Name = "mtgcComboBox7";
            this.mtgcComboBox7.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox7.Size = new System.Drawing.Size(264, 21);
            this.mtgcComboBox7.TabIndex = 10;
            this.mtgcComboBox7.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox7_SelectedIndexChanged);
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.Controls.Add(this.label31);
            this.tabPageEX2.Controls.Add(this.textBox17);
            this.tabPageEX2.Controls.Add(this.label30);
            this.tabPageEX2.Controls.Add(this.textBox16);
            this.tabPageEX2.Controls.Add(this.label29);
            this.tabPageEX2.Controls.Add(this.textBox15);
            this.tabPageEX2.Controls.Add(this.label28);
            this.tabPageEX2.Controls.Add(this.textBox14);
            this.tabPageEX2.Controls.Add(this.label27);
            this.tabPageEX2.Controls.Add(this.textBox13);
            this.tabPageEX2.Controls.Add(this.label26);
            this.tabPageEX2.Controls.Add(this.textBox12);
            this.tabPageEX2.Controls.Add(this.textBox11);
            this.tabPageEX2.Controls.Add(this.label25);
            this.tabPageEX2.Controls.Add(this.label24);
            this.tabPageEX2.Controls.Add(this.textBox10);
            this.tabPageEX2.Controls.Add(this.textBox19);
            this.tabPageEX2.Controls.Add(this.label32);
            this.tabPageEX2.Controls.Add(this.textBox18);
            this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(936, 507);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Stock";
            // 
            // tabPageEX3
            // 
            this.tabPageEX3.Controls.Add(this.listView1);
            this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX3.Name = "tabPageEX3";
            this.tabPageEX3.Size = new System.Drawing.Size(936, 507);
            this.tabPageEX3.TabIndex = 2;
            this.tabPageEX3.Text = "Réservation";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(856, 632);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 48);
            this.button9.TabIndex = 28;
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // oleDbDataAdapter6
            // 
            this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand6;
            this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand6;
            this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
            this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_devis_entete", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Accord Client", "Accord Client"),
                        new System.Data.Common.DataColumnMapping("Calcul Auto", "Calcul Auto"),
                        new System.Data.Common.DataColumnMapping("Cause atelier", "Cause atelier"),
                        new System.Data.Common.DataColumnMapping("Cause client", "Cause client"),
                        new System.Data.Common.DataColumnMapping("Code Client", "Code Client"),
                        new System.Data.Common.DataColumnMapping("Code Materiel", "Code Materiel"),
                        new System.Data.Common.DataColumnMapping("Commande generee", "Commande generee"),
                        new System.Data.Common.DataColumnMapping("Comment", "Comment"),
                        new System.Data.Common.DataColumnMapping("Date", "Date"),
                        new System.Data.Common.DataColumnMapping("Date Decision", "Date Decision"),
                        new System.Data.Common.DataColumnMapping("Date entree reelle", "Date entree reelle"),
                        new System.Data.Common.DataColumnMapping("Date Generation commande", "Date Generation commande"),
                        new System.Data.Common.DataColumnMapping("Date Reception pieces", "Date Reception pieces"),
                        new System.Data.Common.DataColumnMapping("Date reparation", "Date reparation"),
                        new System.Data.Common.DataColumnMapping("Detail atelier", "Detail atelier"),
                        new System.Data.Common.DataColumnMapping("Detail Client", "Detail Client"),
                        new System.Data.Common.DataColumnMapping("Edite", "Edite"),
                        new System.Data.Common.DataColumnMapping("edition_fax", "edition_fax"),
                        new System.Data.Common.DataColumnMapping("Emplacement", "Emplacement"),
                        new System.Data.Common.DataColumnMapping("Forfait Controle", "Forfait Controle"),
                        new System.Data.Common.DataColumnMapping("Forfait DNR", "Forfait DNR"),
                        new System.Data.Common.DataColumnMapping("Forfait transport", "Forfait transport"),
                        new System.Data.Common.DataColumnMapping("Imputation comptable", "Imputation comptable"),
                        new System.Data.Common.DataColumnMapping("Limite Devis", "Limite Devis"),
                        new System.Data.Common.DataColumnMapping("Message Pieds", "Message Pieds"),
                        new System.Data.Common.DataColumnMapping("n° Bl", "n° Bl"),
                        new System.Data.Common.DataColumnMapping("N° Commande generee", "N° Commande generee"),
                        new System.Data.Common.DataColumnMapping("N° Commande ouverte", "N° Commande ouverte"),
                        new System.Data.Common.DataColumnMapping("N° Devis", "N° Devis"),
                        new System.Data.Common.DataColumnMapping("N° Troncon", "N° Troncon"),
                        new System.Data.Common.DataColumnMapping("Niveau", "Niveau"),
                        new System.Data.Common.DataColumnMapping("Ordre Travail", "Ordre Travail"),
                        new System.Data.Common.DataColumnMapping("Prix machine neuve", "Prix machine neuve"),
                        new System.Data.Common.DataColumnMapping("Prix Reference", "Prix Reference"),
                        new System.Data.Common.DataColumnMapping("Reforme", "Reforme"),
                        new System.Data.Common.DataColumnMapping("Refus", "Refus"),
                        new System.Data.Common.DataColumnMapping("Reparateur_D", "Reparateur_D"),
                        new System.Data.Common.DataColumnMapping("Reparateur_R", "Reparateur_R"),
                        new System.Data.Common.DataColumnMapping("Repare", "Repare"),
                        new System.Data.Common.DataColumnMapping("Seuil Client", "Seuil Client"),
                        new System.Data.Common.DataColumnMapping("Seuil devis", "Seuil devis"),
                        new System.Data.Common.DataColumnMapping("Total devis", "Total devis"),
                        new System.Data.Common.DataColumnMapping("Total devis euro", "Total devis euro"),
                        new System.Data.Common.DataColumnMapping("Total pieces", "Total pieces"),
                        new System.Data.Common.DataColumnMapping("Type devis", "Type devis"),
                        new System.Data.Common.DataColumnMapping("Valide", "Valide")})});
            this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand6;
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = resources.GetString("oleDbDeleteCommand6.CommandText");
            this.oleDbDeleteCommand6.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Repare", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Valide", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = resources.GetString("oleDbInsertCommand6.CommandText");
            this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"),
            new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"),
            new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"),
            new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"),
            new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"),
            new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"),
            new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"),
            new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"),
            new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"),
            new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"),
            new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"),
            new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"),
            new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"),
            new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"),
            new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"),
            new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"),
            new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"),
            new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"),
            new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"),
            new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"),
            new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"),
            new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"),
            new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"),
            new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"),
            new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"),
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"),
            new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"),
            new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"),
            new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"),
            new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"),
            new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"),
            new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"),
            new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"),
            new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"),
            new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"),
            new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"),
            new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"),
            new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"),
            new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"),
            new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"),
            new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"),
            new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide")});
            // 
            // oleDbSelectCommand6
            // 
            this.oleDbSelectCommand6.CommandText = resources.GetString("oleDbSelectCommand6.CommandText");
            this.oleDbSelectCommand6.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand6
            // 
            this.oleDbUpdateCommand6.CommandText = resources.GetString("oleDbUpdateCommand6.CommandText");
            this.oleDbUpdateCommand6.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"),
            new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"),
            new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"),
            new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"),
            new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"),
            new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"),
            new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"),
            new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"),
            new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"),
            new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"),
            new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"),
            new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"),
            new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"),
            new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"),
            new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"),
            new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"),
            new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"),
            new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"),
            new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"),
            new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"),
            new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"),
            new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"),
            new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"),
            new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"),
            new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"),
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"),
            new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"),
            new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"),
            new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"),
            new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"),
            new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"),
            new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"),
            new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"),
            new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"),
            new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"),
            new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"),
            new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"),
            new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"),
            new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"),
            new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"),
            new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"),
            new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Repare", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Valide", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null)});
            // 
            // Pieces
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(924, 688);
            this.ControlBox = false;
            this.Controls.Add(this.button9);
            this.Controls.Add(this.tabControlEX1);
            this.Controls.Add(this.btSupprime);
            this.Controls.Add(this.btEnregistre);
            this.Controls.Add(this.btNouveau);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Pieces";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pièces détachées";
            this.VisibleChanged += new System.EventHandler(this.Pieces_VisibleChanged);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.tabControlEX1.ResumeLayout(false);
            this.tabPageEX1.ResumeLayout(false);
            this.tabPageEX2.ResumeLayout(false);
            this.tabPageEX2.PerformLayout();
            this.tabPageEX3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{
			dataSet11.Clear();
			listView1.Items.Clear();

			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox1.SelectedIndex=0;

			mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox2.SelectedIndex=0;

			mtgcComboBox3.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox3.SelectedIndex=0;
			
			Comm.CommandText="select code,nom from t_fournisseurs order by nom asc";
			Comm.Connection=oleDbConnection1;
			this.Refresh();
			oleDbDataAdapter4.SelectCommand=Comm;
			oleDbDataAdapter4.Fill(dataSet11);
			mtgcComboBox4.SourceDataString=new string[] {"nom","","",""};
			mtgcComboBox4.SourceDataTable=dataSet11.Tables["t_fournisseurs"];
			mtgcComboBox4.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox4.SelectedIndex=0;
			oleDbDataAdapter2.Fill(dataSet11);
			oleDbDataAdapter3.Fill(dataSet11);
			mtgcComboBox5.SourceDataString=new string[] {"code","Designation","",""};
			mtgcComboBox5.SourceDataTable=dataSet11.Tables["t_famille_piece"];
			mtgcComboBox5.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox5.SelectedIndex=0;
			mtgcComboBox6.SourceDataString=new string[] {"code","Designation","",""};
			mtgcComboBox6.SourceDataTable=dataSet11.Tables["t_unites"];
			mtgcComboBox6.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox6.SelectedIndex=0;
			oleDbDataAdapter5.Fill(dataSet11);
			mtgcComboBox7.SourceDataString=new string[] {"code","designation","",""};
			mtgcComboBox7.SourceDataTable=dataSet11.Tables["t_causes"];
			mtgcComboBox1.SelectedIndex=0;
			
			mtgcComboBox3.SelectedIndex=0;
            
            
            string path = @"C:\Program Files (x86)\Opindus\Opindus.ini";
			StreamReader reader = new StreamReader(path);
			string rubrique=null;
			try
			{
				rubrique=reader.ReadLine();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			if(rubrique.Equals("[0]"))
				TVA=reader.ReadLine().Remove(0,4);
			ta=TVA[0].ToString()+TVA[1].ToString()+TVA[3].ToString();
			TVA="1,"+ta;
			reader.Close();
			if(CodePiece.Length>0)
			{
					mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(CodePiece);
			}
			tabControlEX1.SelectedTab=tabPageEX1;
			if(CodePiece.Length>0)
			{
				Enable();
				btEnregistre.Enabled=true;
				btSupprime.Enabled=true;
				mtgcComboBox1.SelectedIndex=0;
				mtgcComboBox3.SelectedIndex=0;
				Comm.CommandText="select * from t_pieces_detachees where t_pieces_detachees.code='"+CodePiece+"'";
				oleDbDataAdapter1.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter1.Fill(dataSet11,"t_pieces_detachees");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				DataRow select = dataSet11.Tables["t_pieces_detachees"].Rows[0];
				textBox1.Text=select["identificateur"].ToString();
				textBox2.Text=select["Code"].ToString();
				textBox3.Text=select["Code_1"].ToString();
				textBox10.Text=select["designation"].ToString();
				textBox4.Text=select["designation"].ToString();
				textBox6.Text=select["correspondance stock"].ToString();
				textBox7.Text=select["delai livraison"].ToString();
				if(select["prix achat brut"].ToString().Length>0)
					textBox8.Text=Convert.ToDecimal(select["prix achat brut"]).ToString("0.00");
				textBox11.Text=select["quantite stock"].ToString();
				textBox12.Text=select["quantite minimum"].ToString();
				textBox13.Text=select["stock alerte"].ToString();
				textBox14.Text=select["quantite maxi"].ToString();
				textBox15.Text=select["quantite commande"].ToString();
				textBox16.Text=select["quantite reserve"].ToString();
				textBox17.Text=select["quantite disponible"].ToString();
				textBox19.Text=select["quantite stock theorique"].ToString();
				if(select["date dernier mouvement"].ToString().Length>0)
					textBox18.Text=select["date dernier mouvement"].ToString().Remove(10,9);
				if(select["date maj tarif"].ToString().Length>0)
					txDateModif.Text=select["date maj tarif"].ToString().Remove(10,9);
				mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(select["code famille"].ToString());
				mtgcComboBox6.SelectedIndex=mtgcComboBox6.FindString(select["code unite"].ToString());
				dataSet11.Tables["t_fournisseurs"].Clear();
				Comm.CommandText="select * from t_fournisseurs where code='"+select["Code fournisseur principal"].ToString()+"'";
				oleDbDataAdapter4.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter4.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_fournisseurs"].Rows[0]["nom"].ToString());
				label22.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Coef PA PV"].ToString();
				Decimal remise = System.Convert.ToDecimal(dataSet11.Tables["t_fournisseurs"].Rows[0]["Pourcentage remise"].ToString())*100;
				label21.Text=remise.ToString();
				if(select["pre_devis"].ToString().Equals("True"))
					checkBox1.Checked=true;
				mtgcComboBox7.SelectedIndex=mtgcComboBox7.FindString(select["cause principale"].ToString());
				
				oleDbDataAdapter5.Fill(dataSet11);

				remise = System.Convert.ToDecimal(label21.Text);
				int remise2 = 100-System.Convert.ToInt32(remise);
				string calcul="0,"+remise2.ToString();
				Decimal taux=System.Convert.ToDecimal(calcul); 
				if(remise2.Equals(100))
					taux=1;
				Decimal prix = System.Convert.ToDecimal(textBox8.Text);
				Decimal net = taux*prix;
				textBox9.Text=net.ToString("0.00");
				Decimal PAPV = System.Convert.ToDecimal(label22.Text);
				Decimal PrixVente = PAPV*(System.Convert.ToDecimal(textBox8.Text));
				textBox20.Text=PrixVente.ToString("0.00");
				dataSet11.Tables["t_devis_entete"].Clear();
				Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Niveau, T_clients.Nom, T_devis_lignes.[Code piece], Sum(T_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident GROUP BY T_devis_entete.[N° Devis], T_devis_entete.Niveau, T_clients.Nom, T_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)>3 And (T_devis_entete.Niveau)<8) AND ((T_devis_lignes.[Code piece])="+textBox1.Text+")) ORDER BY T_devis_entete.[N° devis] DESC"; 
				oleDbDataAdapter6.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter6.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				listView1.Items.Clear();
				foreach(DataRow row in dataSet11.Tables["t_devis_entete"].Rows)
				{
					ListViewItem listViewItem1 = new ListViewItem(new string[] {row["N° devis"].ToString(),row["nom"].ToString(),row["SommeDeQuantite"].ToString()});
					listView1.Items.Add(listViewItem1);
				}
                
            }
		}

		private void comboBox5_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox5.SelectedIndex!=-1)
			{
				dataSet11.Tables["t_famille_piece"].Clear();
				Comm.CommandText="select * from t_famille_piece where code="+mtgcComboBox5.Text;
				oleDbDataAdapter2.SelectCommand=Comm;
				oleDbDataAdapter2.Fill(dataSet11);
				if(dataSet11.Tables["t_famille_piece"].Rows.Count>0)
					label4.Text=dataSet11.Tables["t_famille_piece"].Rows[0]["designation"].ToString().ToUpper();
			}
		}


		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			Enable();
			txDateModif.Text=DateTime.Now.ToShortDateString();
			textBox8.ReadOnly=true;
			textBox2.BackColor=Color.MistyRose;
			btEnregistre.Enabled=true;
			btSupprime.Enabled=true;
			Nettoyage();
			button1.Enabled=true;
			mtgcComboBox4.Enabled=true;
			Nouveau=true;
			Comm.CommandText="SELECT Max(T_pieces_detachees.Identificateur) AS MaxDeIdentificateur FROM T_pieces_detachees";
			try
			{
				oleDbConnection1.Open();
				int Max=System.Convert.ToInt32(Comm.ExecuteScalar())+1;
				textBox1.Text=Max.ToString();
			}
			catch
			{
				MessageBox.Show("Erreur dans la base de données");
			}
			finally
			{
				oleDbConnection1.Close();
			}
			mtgcComboBox7.SelectedIndex=3;
		}

		private void Enable()
		{
			checkBox1.Enabled=true;
			textBox1.ReadOnly=true;
			textBox2.ReadOnly=false;
			textBox3.ReadOnly=false;
			textBox4.ReadOnly=false;
			textBox6.ReadOnly=false;
			textBox7.ReadOnly=false;
			//textBox8.ReadOnly=false;;
			txDateModif.Enabled=true;
			textBox10.ReadOnly=false;
			textBox11.ReadOnly=false;
			textBox12.ReadOnly=false;
			textBox13.ReadOnly=false;
			textBox14.ReadOnly=false;
			textBox15.ReadOnly=false;
			textBox16.ReadOnly=false;
			textBox17.ReadOnly=false;
			textBox18.ReadOnly=false;
			textBox19.ReadOnly=false;
			mtgcComboBox7.Enabled=true;
			mtgcComboBox5.Enabled=true;
			mtgcComboBox6.Enabled=true;
			mtgcComboBox4.Enabled=true;
			button1.Enabled=true;
		}

		private void Nettoyage()
		{
			label4.Text="";
			label5.Text="";
			label6.Text="";
			label21.Text="0,00";
			label22.Text="0,00";
			textBox1.Text="";
			textBox2.Text="";
			textBox4.Text="";
			textBox6.Text="?";
			textBox7.Text="?";
			txDateModif.Text="";
			textBox10.Text="";
			textBox11.Text="0";
			textBox12.Text="0";
			textBox13.Text="0";
			textBox14.Text="0";
			textBox15.Text="0";
			textBox16.Text="0";
			textBox17.Text="0";
			textBox18.Text="";
			textBox19.Text="0";
			//textBox20.Text="0,00";
			mtgcComboBox1.SelectedIndex=0;
			mtgcComboBox2.SelectedIndex=0;
			mtgcComboBox3.SelectedIndex=0;
			mtgcComboBox4.SelectedIndex=0;
			mtgcComboBox5.SelectedIndex=0;
			mtgcComboBox6.SelectedIndex=0;
			textBox8.Text="0,00";
			textBox9.Text="0,00";
			textBox20.Text="0,00";
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			if(textBox12.Text.Trim().Length.Equals(0))
				textBox12.Text="0";
			if(textBox14.Text.Trim().Length.Equals(0))
				textBox14.Text="0";
			if(textBox4.Text.Length.Equals(0))
			{
				MessageBox.Show("Champ désignation obligatoire");
			}
			else if(mtgcComboBox4.SelectedIndex.Equals(0))
			{
				MessageBox.Show("Veuillez choisir un fournisseur");
			}
			else if(mtgcComboBox5.SelectedIndex.Equals(0))
			{
				MessageBox.Show("Veuillez choisir un code famille");
			}
			else if(mtgcComboBox6.SelectedIndex.Equals(0))
			{
				MessageBox.Show("Veuillez choisir un code unité");
			}
			else if(textBox2.Text.Length.Equals(0))
			{
				MessageBox.Show("Champ code obligatoire");
			}
			else
			{
				if(Nouveau)
				{
					dataSet11.Clear();
					oleDbConnection1.Open();

					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
					}
					Comm.CommandText="select Code from t_fournisseurs where nom='"+mtgcComboBox4.Text+"'";
					oleDbDataAdapter4.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter4.Fill(dataSet11,"t_fournisseurs");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					if(textBox6.Text.Length.Equals(0))
						textBox6.Text="?";
					if(textBox7.Text.Length.Equals(0))
						textBox7.Text="?";
					DataRow newrow = dataSet11.Tables["t_pieces_detachees"].NewRow();
					newrow["Identificateur"]=textBox1.Text;
					newrow["Code"]=textBox2.Text;
					if(textBox3.TextLength.Equals(0))
						newrow["Code_1"]="?";
					else
						newrow["Code_1"]=textBox3.Text;
					newrow["Designation"]=textBox4.Text.ToUpper();
					newrow["Code fournisseur principal"]=textBox5.Text;
					newrow["Correspondance stock"]=textBox6.Text;
					if(textBox7.Text.Length>0&&textBox7.Text!="?")
						newrow["Delai livraison"]=System.Convert.ToInt32(textBox7.Text);
					newrow["Code famille"]=System.Convert.ToInt32(mtgcComboBox5.Text);
					newrow["Code unite"]=System.Convert.ToInt32(mtgcComboBox6.Text);
					newrow["Prix achat brut"]=textBox8.Text;
					newrow["Prix achat net"]=textBox9.Text;
					newrow["Prix vente"]=textBox20.Text;
					if(mtgcComboBox7.SelectedIndex!=-1)
						newrow["Cause principale"]=mtgcComboBox7.Text;
					newrow["Quantite stock"]=System.Convert.ToInt32(textBox11.Text);
					newrow["Quantite stock theorique"]=System.Convert.ToInt32(textBox19.Text);
					newrow["Quantite minimum"]=System.Convert.ToInt32(textBox12.Text);
					newrow["Stock alerte"]=System.Convert.ToInt32(textBox13.Text);
					newrow["Quantite maxi"]=System.Convert.ToInt32(textBox14.Text);
					newrow["Quantite commande"]=System.Convert.ToInt32(textBox15.Text);
					newrow["Quantite reserve"]=System.Convert.ToInt32(textBox16.Text);
					newrow["Quantite disponible"]=System.Convert.ToInt32(textBox17.Text);
					if(txDateModif.Text.Length>0)
						newrow["Date MAJ tarif"]=System.Convert.ToDateTime(txDateModif.Text);
					if(textBox18.Text.Length>0)
						newrow["Date dernier mouvement"]=System.Convert.ToDateTime(textBox18.Text);
					dataSet11.Tables["t_pieces_detachees"].Rows.Add(newrow);
					try
					{
						oleDbDataAdapter1.Update(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
					Nettoyage();
					Comm.CommandText="SELECT MAX(identificateur) FROM t_pieces_detachees";
					try
					{
						oleDbConnection1.Open();
						int Max=System.Convert.ToInt32(Comm.ExecuteScalar())+1;
						textBox1.Text=Max.ToString();
					}
					catch
					{
						MessageBox.Show("Erreur dans la base de données");
					}
					finally
					{
						oleDbConnection1.Close();
					}
				}
				else
				{
					if(textBox3.TextLength.Equals(0))
						textBox3.Text="?";
					dataSet11.Tables["t_fournisseurs"].Clear();
					Comm.CommandText="select Code from t_fournisseurs where nom='"+mtgcComboBox4.Text+"'";
					oleDbDataAdapter4.SelectCommand=Comm;
					bool PreDevis=checkBox1.Checked;
					try
					{
						oleDbDataAdapter4.Fill(dataSet11,"t_fournisseurs");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					if(textBox6.Text.Length.Equals(0))
						textBox6.Text="?";
					if(textBox7.Text.Length.Equals(0))
						textBox7.Text="0";
					Comm.CommandText="update t_pieces_detachees set [Code]='"+textBox2.Text.ToUpper()+"',[Code_1]='"+textBox3.Text.ToUpper()+"',[Designation]='"+textBox4.Text.ToUpper()+"',[code fournisseur principal]='"+dataSet11.Tables["t_fournisseurs"].Rows[0]["code"].ToString()+"',[correspondance stock]='"+textBox6.Text+"',[delai livraison]="+textBox7.Text+",[Code famille]="+mtgcComboBox5.Text+",[code unite]='"+mtgcComboBox6.Text+"',[cause principale]="+mtgcComboBox7.Text+",[pre_devis]="+PreDevis.ToString()+", [Date MAJ tarif]='"+txDateModif.Text+"', [Quantite minimum]="+textBox12.Text+", [Quantite maxi]="+textBox14.Text+" where Identificateur="+textBox1.Text;
					oleDbConnection1.Open();
					try
					{
						Comm.ExecuteNonQuery();
					}
					catch(Exception exp)
					{

						MessageBox.Show(exp.Message);
					}
					string MAJ1="update t_pieces_detachees set [prix achat brut]="+textBox8.Text.Replace(",",".")+" where Identificateur="+textBox1.Text;
					MAJ1=MAJ1.Replace(",",".");
					Comm.CommandText=MAJ1;
					
					try
					{
						Comm.ExecuteNonQuery();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					string MAJ2="update t_pieces_detachees set [prix achat net]="+textBox9.Text.Replace(",",".")+" where Identificateur="+textBox1.Text;
					MAJ2=MAJ2.Replace(",",".");
					Comm.CommandText=MAJ2;
					try
					{
						Comm.ExecuteNonQuery();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					string MAJ3="update t_pieces_detachees set [prix vente]="+textBox20.Text.Replace(",",".")+" where Identificateur="+textBox1.Text;
					MAJ3=MAJ3.Replace(",",".");
					Comm.CommandText=MAJ3;
					try
					{
						Comm.ExecuteNonQuery();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					
					MessageBox.Show("Mise à jour terminée");
					oleDbConnection1.Close();
					Nettoyage();
					Comm.CommandText="SELECT Max(T_pieces_detachees.Identificateur) AS MaxDeIdentificateur FROM T_pieces_detachees";
					try
					{
						oleDbConnection1.Open();
						int Max=System.Convert.ToInt32(Comm.ExecuteScalar())+1;
						textBox1.Text=Max.ToString();
					}
					catch
					{
						MessageBox.Show("Erreur dans la base de données");
					}
					finally
					{
						oleDbConnection1.Close();
					}
				}
			}
		}

		private void textBox4_TextChanged(object sender, System.EventArgs e)
		{
						textBox10.Text=textBox4.Text;
		}

		private void textBox18_Enter(object sender, System.EventArgs e)
		{
			ChoixDate WinDate = new ChoixDate();
			if(WinDate.ShowDialog()==DialogResult.OK)
				textBox18.Text=WinDate.GetDate.ToShortDateString();
		}

		private void textBox8_Leave(object sender, System.EventArgs e)
		{
			/*Decimal Prix=System.Convert.ToDecimal(textBox8.Text);
			Decimal taxe= System.Convert.ToDecimal(TVA);
			Decimal Total=Prix*taxe;
			textBox5.Text=Total.ToString("c");
			textBox8.Text=System.Convert.ToDecimal(textBox8.Text).ToString("c");*/
		}

		private void textBox20_Leave(object sender, System.EventArgs e)
		{
			//textBox20.Text=System.Convert.ToDecimal(textBox20.Text).ToString("c");
		}

		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			Comm.CommandText="select * from t_pieces_detachees";
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(dataSet11,"t_pieces_detachees");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			DataTable Table = dataSet11.Tables["T_pieces_detachees"];
			
			if(MessageBox.Show("Supprimer la pièce ?","Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
			{
				foreach (DataRow row in Table.Rows)
				{
					if(row["Identificateur"].ToString().Equals(textBox1.Text))
					{
						MessageBox.Show("Trouvé !");
						row.Delete();
						oleDbDataAdapter1.Update(dataSet11);
						break;
					}
				}
				Nettoyage();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			SaisieFournisseurs WinFourn=null;
			if(textBox5.TextLength>0)
				WinFourn = new SaisieFournisseurs(Agence, textBox5.Text);
			else
				WinFourn = new SaisieFournisseurs(Agence,true);
			WinFourn.ShowDialog();
			dataSet11.Tables["t_fournisseurs"].Clear();
			Comm.CommandText="select * from t_fournisseurs order by nom asc";
			mtgcComboBox4.Items.Clear();
			oleDbDataAdapter4.SelectCommand=Comm;
			oleDbDataAdapter4.Fill(dataSet11);
			mtgcComboBox4.SourceDataTable=dataSet11.Tables["t_fournisseurs"];
			mtgcComboBox4.SourceDataString=new string[]{"nom","","",""};
			mtgcComboBox4.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox4.SelectedIndex=0;
		}

		private void mtgcComboBox4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_fournisseurs"].Clear();
			if(mtgcComboBox4.SelectedIndex>=0)
			{
				oleDbDataAdapter4.SelectCommand.CommandText="select * from t_fournisseurs where nom='"+mtgcComboBox4.Text+"'";
				oleDbDataAdapter4.Fill(dataSet11);
				if(dataSet11.Tables["t_fournisseurs"].Rows.Count>0)
				{
					textBox5.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["code"].ToString();
					label22.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Coef PA PV"].ToString();
					Decimal remise = System.Convert.ToDecimal(dataSet11.Tables["t_fournisseurs"].Rows[0]["Pourcentage remise"].ToString())*100;
					label21.Text=remise.ToString();
					textBox8.ReadOnly=false;
				}
			}
		}

		private void mtgcComboBox5_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox5.SelectedIndex>0)
			{
				dataSet11.Tables["t_famille_piece"].Clear();
				Comm.CommandText="select * from t_famille_piece where code="+mtgcComboBox5.Text;
				oleDbDataAdapter2.SelectCommand=Comm;
				oleDbDataAdapter2.Fill(dataSet11);
				if(dataSet11.Tables["t_famille_piece"].Rows.Count>0)
					label4.Text=dataSet11.Tables["t_famille_piece"].Rows[0]["designation"].ToString().ToUpper();
			}
		}

		private void mtgcComboBox6_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox6.SelectedIndex>0)
			{
				dataSet11.Tables["t_unites"].Clear();
				Comm.CommandText="select * from t_unites where code='"+mtgcComboBox6.Text+"'";
				oleDbDataAdapter3.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter3.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				label5.Text=dataSet11.Tables["t_unites"].Rows[0]["designation"].ToString().ToUpper();
			}
		}

		private void mtgcComboBox7_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox7.SelectedIndex>=0)
			{
				oleDbDataAdapter5.Fill(dataSet11);
				foreach(DataRow rowCauses in dataSet11.Tables["t_causes"].Rows)
				{
					if(rowCauses["Code"].ToString().Equals(mtgcComboBox7.Text))
					{
						label6.Text=rowCauses["Designation"].ToString();
					}
				}
			}
		}

		private void mtgcComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				button1.Enabled=true;
				textBox8.Text="0,00";
				textBox9.Text="0,00";
				textBox20.Text="0,00";
				dataSet11.Clear();
				int cpt=0;
				if(mtgcComboBox1.SelectedIndex>0)
				{
					Enable();
					btEnregistre.Enabled=true;
					btSupprime.Enabled=true;
					mtgcComboBox2.SelectedIndex=0;
					mtgcComboBox3.SelectedIndex=0;
					Comm.CommandText="select * from t_pieces_detachees where t_pieces_detachees.identificateur="+mtgcComboBox1.Text;
					oleDbDataAdapter1.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter1.Fill(dataSet11,"t_pieces_detachees");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					DataRow select = dataSet11.Tables["t_pieces_detachees"].Rows[0];
					textBox1.Text=select["identificateur"].ToString();
					textBox2.Text=select["Code"].ToString();
					textBox3.Text=select["Code_1"].ToString();
					textBox10.Text=select["designation"].ToString();
					textBox4.Text=select["designation"].ToString();
					textBox6.Text=select["correspondance stock"].ToString();
					textBox7.Text=select["delai livraison"].ToString();
					if(select["prix achat brut"].ToString().Length>0)
						textBox8.Text=Convert.ToDecimal(select["prix achat brut"]).ToString("0.00");
					textBox11.Text=select["quantite stock"].ToString();
					textBox12.Text=select["quantite minimum"].ToString();
					textBox13.Text=select["stock alerte"].ToString();
					textBox14.Text=select["quantite maxi"].ToString();
					textBox15.Text=select["quantite commande"].ToString();
					textBox16.Text=select["quantite reserve"].ToString();
					textBox17.Text=select["quantite disponible"].ToString();
					if(select["date dernier mouvement"].ToString().Length>0)
						textBox18.Text=select["date dernier mouvement"].ToString().Remove(10,9);
					if(select["date maj tarif"].ToString().Length>0)
						txDateModif.Text=select["date maj tarif"].ToString().Remove(10,9);
					mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(select["code famille"].ToString());
					mtgcComboBox6.SelectedIndex=mtgcComboBox6.FindString(select["code unite"].ToString());
			
					dataSet11.Tables["t_fournisseurs"].Clear();
					Comm.CommandText="select * from t_fournisseurs where code='"+select["Code fournisseur principal"].ToString()+"'";
					oleDbDataAdapter4.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter4.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_fournisseurs"].Rows[0]["nom"].ToString());
					label22.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Coef PA PV"].ToString();
					Decimal remise = System.Convert.ToDecimal(dataSet11.Tables["t_fournisseurs"].Rows[0]["Pourcentage remise"].ToString())*100;
					label21.Text=remise.ToString();
					if(select["pre_devis"].ToString().Equals("True"))
						checkBox1.Checked=true;
					oleDbDataAdapter5.Fill(dataSet11);
					mtgcComboBox7.SelectedIndex=mtgcComboBox7.FindString(select["cause principale"].ToString());
					remise = System.Convert.ToDecimal(label21.Text);
					int remise2 = 100-System.Convert.ToInt32(remise);
					string calcul="0,"+remise2.ToString();
					Decimal taux=System.Convert.ToDecimal(calcul); 
					if(remise2.Equals(100))
						taux=1;
					Decimal prix = System.Convert.ToDecimal(textBox8.Text);
					Decimal net = taux*prix;
					textBox9.Text=net.ToString("0.00");
					Decimal PAPV = System.Convert.ToDecimal(label22.Text);
					Decimal PrixVente = PAPV*(System.Convert.ToDecimal(textBox8.Text));
					textBox20.Text=PrixVente.ToString("0.00");
					dataSet11.Tables["t_devis_entete"].Clear();
					Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Niveau, T_clients.Nom, T_devis_lignes.[Code piece], Sum(T_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident GROUP BY T_devis_entete.[N° Devis], T_devis_entete.Niveau, T_clients.Nom, T_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)>3 And (T_devis_entete.Niveau)<8) AND ((T_devis_lignes.[Code piece])="+textBox1.Text+")) ORDER BY T_devis_entete.[N° devis] DESC"; 
					oleDbDataAdapter6.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter6.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					listView1.Items.Clear();
					foreach(DataRow row in dataSet11.Tables["t_devis_entete"].Rows)
					{
						ListViewItem listViewItem1 = new ListViewItem(new string[] {row["N° devis"].ToString(),row["nom"].ToString(),row["SommeDeQuantite"].ToString()});
						listView1.Items.Add(listViewItem1);
					}
				}
			}
		}

		private void mtgcComboBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
			        button1.Enabled=true;
			textBox8.Text="0,00";
			textBox9.Text="0,00";
			textBox20.Text="0,00";
			dataSet11.Clear();
			int cpt=0;
				if(mtgcComboBox2.SelectedIndex>0)
				{
					    Enable();
					btEnregistre.Enabled=true;
					btSupprime.Enabled=true;
					mtgcComboBox1.SelectedIndex=0;
					mtgcComboBox3.SelectedIndex=0;
					Comm.CommandText="select * from t_pieces_detachees where t_pieces_detachees.code='"+mtgcComboBox2.Text.ToUpper()+"'";
					oleDbDataAdapter1.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter1.Fill(dataSet11,"t_pieces_detachees");
						DataRow select = dataSet11.Tables["t_pieces_detachees"].Rows[0];
						textBox1.Text=select["identificateur"].ToString();
						textBox2.Text=select["Code"].ToString();
						textBox3.Text=select["Code_1"].ToString();
						textBox10.Text=select["designation"].ToString();
						textBox4.Text=select["designation"].ToString();
						textBox6.Text=select["correspondance stock"].ToString();
						textBox7.Text=select["delai livraison"].ToString();
						if(select["prix achat brut"].ToString().Length>0)
							textBox8.Text=Convert.ToDecimal(select["prix achat brut"]).ToString("0.00");
						textBox11.Text=select["quantite stock"].ToString();
						textBox12.Text=select["quantite minimum"].ToString();
						textBox13.Text=select["stock alerte"].ToString();
						textBox14.Text=select["quantite maxi"].ToString();
						textBox15.Text=select["quantite commande"].ToString();
						textBox16.Text=select["quantite reserve"].ToString();
						textBox17.Text=select["quantite disponible"].ToString();
						mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindStringExact(select["Code famille"].ToString());						
						mtgcComboBox6.SelectedIndex=mtgcComboBox6.FindStringExact(select["Code unite"].ToString());
						textBox19.Text=select["quantite stock theorique"].ToString();
						if(select["date dernier mouvement"].ToString().Length>0)
							textBox18.Text=select["date dernier mouvement"].ToString().Remove(10,9);
						if(select["date maj tarif"].ToString().Length>0)
							txDateModif.Text=select["date maj tarif"].ToString().Remove(10,9);
						dataSet11.Tables["t_fournisseurs"].Clear();
						Comm.CommandText="select * from t_fournisseurs where code='"+select["Code fournisseur principal"].ToString()+"'";
						oleDbDataAdapter4.SelectCommand=Comm;
						try
						{
							oleDbDataAdapter4.Fill(dataSet11);
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindStringExact(dataSet11.Tables["t_fournisseurs"].Rows[0]["nom"].ToString());
						label22.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Coef PA PV"].ToString();
						Decimal remise = System.Convert.ToDecimal(dataSet11.Tables["t_fournisseurs"].Rows[0]["Pourcentage remise"].ToString())*100;
						label21.Text=remise.ToString();
						if(select["pre_devis"].ToString().Equals("True"))
							checkBox1.Checked=true;
						mtgcComboBox7.SelectedIndex=mtgcComboBox7.FindString(select["cause principale"].ToString());
				
						oleDbDataAdapter5.Fill(dataSet11);

						remise = System.Convert.ToDecimal(label21.Text);
						int remise2 = 100-System.Convert.ToInt32(remise);
						string calcul="0,"+remise2.ToString();
						Decimal taux=System.Convert.ToDecimal(calcul); 
						if(remise2.Equals(100))
							taux=1;
						Decimal prix = System.Convert.ToDecimal(textBox8.Text);
						Decimal net = taux*prix;
						textBox9.Text=net.ToString("0.00");
						Decimal PAPV = System.Convert.ToDecimal(label22.Text);
						Decimal PrixVente = PAPV*(System.Convert.ToDecimal(textBox8.Text));
						textBox20.Text=PrixVente.ToString("0.00");
						dataSet11.Tables["t_devis_entete"].Clear();
						Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Niveau, T_clients.Nom, T_devis_lignes.[Code piece], Sum(T_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident GROUP BY T_devis_entete.[N° Devis], T_devis_entete.Niveau, T_clients.Nom, T_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)>3 And (T_devis_entete.Niveau)<8) AND ((T_devis_lignes.[Code piece])="+textBox1.Text+")) ORDER BY T_devis_entete.[N° devis] DESC"; 
						oleDbDataAdapter6.SelectCommand=Comm;
						try
						{
							oleDbDataAdapter6.Fill(dataSet11);
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						listView1.Items.Clear();
						foreach(DataRow row in dataSet11.Tables["t_devis_entete"].Rows)
						{
							ListViewItem listViewItem1 = new ListViewItem(new string[] {row["N° devis"].ToString(),row["nom"].ToString(),row["SommeDeQuantite"].ToString()});
								listView1.Items.Add(listViewItem1);
						}
					}
					catch(Exception exp)
					{
						
					}
				}
			}
			}

		private void mtgcComboBox3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				button1.Enabled=true;
				textBox8.Text="0,00";
				textBox9.Text="0,00";
				textBox20.Text="0,00";
				dataSet11.Clear();
				int cpt=0;
				if(mtgcComboBox3.SelectedIndex>0)
				{
					Enable();
					btEnregistre.Enabled=true;
					btSupprime.Enabled=true;
					mtgcComboBox1.SelectedIndex=0;
					mtgcComboBox2.SelectedIndex=0;
					Comm.CommandText="select * from t_pieces_detachees where t_pieces_detachees.code_1='"+mtgcComboBox3.Text+"'";
					oleDbDataAdapter1.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter1.Fill(dataSet11,"t_pieces_detachees");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					DataRow select = dataSet11.Tables["t_pieces_detachees"].Rows[0];
					textBox1.Text=select["identificateur"].ToString();
					textBox2.Text=select["Code"].ToString();
					textBox3.Text=select["Code_1"].ToString();
					textBox10.Text=select["designation"].ToString();
					textBox4.Text=select["designation"].ToString();
					textBox6.Text=select["correspondance stock"].ToString();
					textBox7.Text=select["delai livraison"].ToString();
					if(select["prix achat brut"].ToString().Length>0)
						textBox8.Text=System.Convert.ToDecimal(select["prix achat brut"]).ToString("0.00");
					textBox11.Text=select["quantite stock"].ToString();
					textBox12.Text=select["quantite minimum"].ToString();
					textBox13.Text=select["stock alerte"].ToString();
					textBox14.Text=select["quantite maxi"].ToString();
					textBox15.Text=select["quantite commande"].ToString();
					textBox16.Text=select["quantite reserve"].ToString();
					textBox17.Text=select["quantite disponible"].ToString();
					if(select["date dernier mouvement"].ToString().Length>0)
						textBox18.Text=select["date dernier mouvement"].ToString().Remove(10,9);
					if(select["date maj tarif"].ToString().Length>0)
						txDateModif.Text=select["date maj tarif"].ToString().Remove(10,9);
					mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(select["code famille"].ToString());
					mtgcComboBox6.SelectedIndex=mtgcComboBox6.FindString(select["code unite"].ToString());
					dataSet11.Tables["t_fournisseurs"].Clear();
					Comm.CommandText="select * from t_fournisseurs where code='"+select["Code fournisseur principal"].ToString()+"'";
					oleDbDataAdapter4.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter4.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_fournisseurs"].Rows[0]["nom"].ToString());
					label22.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Coef PA PV"].ToString();
					Decimal remise = System.Convert.ToDecimal(dataSet11.Tables["t_fournisseurs"].Rows[0]["Pourcentage remise"].ToString())*100;
					label21.Text=remise.ToString();
					if(select["pre_devis"].ToString().Equals("True"))
						checkBox1.Checked=true;
					oleDbDataAdapter5.Fill(dataSet11);
					mtgcComboBox7.SelectedIndex=mtgcComboBox7.FindString(select["Cause principale"].ToString());
					remise = System.Convert.ToDecimal(label21.Text);
					int remise2 = 100-System.Convert.ToInt32(remise);
					string calcul="0,"+remise2.ToString();
					Decimal taux=System.Convert.ToDecimal(calcul); 
					if(remise2.Equals(100))
						taux=1;
					Decimal prix = System.Convert.ToDecimal(textBox8.Text);
					Decimal net = taux*prix;
					textBox9.Text=net.ToString("0.00");
					Decimal PAPV = System.Convert.ToDecimal(label22.Text);
					Decimal PrixVente = PAPV*(System.Convert.ToDecimal(textBox8.Text));
					textBox20.Text=PrixVente.ToString("0.00");
					dataSet11.Tables["t_devis_entete"].Clear();
					Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Niveau, T_clients.Nom, T_devis_lignes.[Code piece], Sum(T_devis_lignes.Quantite) AS SommeDeQuantite FROM (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident GROUP BY T_devis_entete.[N° Devis], T_devis_entete.Niveau, T_clients.Nom, T_devis_lignes.[Code piece] HAVING (((T_devis_entete.Niveau)>3 And (T_devis_entete.Niveau)<8) AND ((T_devis_lignes.[Code piece])="+textBox1.Text+")) ORDER BY T_devis_entete.[N° devis] DESC"; 
					oleDbDataAdapter6.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter6.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					listView1.Items.Clear();
					foreach(DataRow row in dataSet11.Tables["t_devis_entete"].Rows)
					{
						ListViewItem listViewItem1 = new ListViewItem(new string[] {row["N° devis"].ToString(),row["nom"].ToString(),row["SommeDeQuantite"].ToString()});
						listView1.Items.Add(listViewItem1);
					}
				}
			}
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
            Empty();
            this.Hide();
        }

        private void Empty()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = "?";
            textBox7.Text = "0";
            textBox8.Text = "0,00";
            textBox9.Text = "0,00";
            textBox20.Text = "0,00";
            label21.Text = "0";
            label22.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = string.Empty;
            textBox19.Text = "0";
            textBox10.Text = string.Empty;
            txDateModif.Text = string.Empty;
            mtgcComboBox1.SelectedIndex = 0;
            mtgcComboBox2.SelectedIndex = 0;
            mtgcComboBox3.SelectedIndex = 0;
            mtgcComboBox4.SelectedIndex = 0;
            mtgcComboBox5.Items.Clear();
            mtgcComboBox6.Items.Clear();
            listView1.Items.Clear();
        }

        private void Pieces_VisibleChanged(object sender, System.EventArgs e)
		{
		}

		private void textBox8_Leave_1(object sender, System.EventArgs e)
		{
			txDateModif.Text=DateTime.Now.ToShortDateString();
			textBox8.Text=textBox8.Text.Replace(".",",");
			textBox8.Text=System.Convert.ToDecimal(textBox8.Text).ToString("0.00");
			Decimal remise = System.Convert.ToDecimal(label21.Text);
			int remise2 = 100-System.Convert.ToInt32(remise);
			string calcul="0,"+remise2.ToString();
			Decimal taux=System.Convert.ToDecimal(calcul);
			if(remise2.Equals(100))
				taux=1;
			Decimal prix = System.Convert.ToDecimal(textBox8.Text);
			Decimal net = taux*prix;
			textBox9.Text=net.ToString("0.00");
			Decimal PAPV = System.Convert.ToDecimal(label22.Text);
			Decimal PrixVente = PAPV*prix;
			textBox20.Text=PrixVente.ToString("0.00");
			Comm.CommandText="update t_pieces_detachees set [prix achat brut]="+textBox8.Text.Replace(",",".")+" where Identificateur="+textBox1.Text;
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
		}

		private void textBox8_Enter(object sender, System.EventArgs e)
		{
			textBox8.Select(0,textBox8.Text.Length);
		}

		private void textBox8_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				txDateModif.Text=DateTime.Now.ToShortDateString();
				textBox8.Text=textBox8.Text.Replace(".",",");
				textBox8.Text=System.Convert.ToDecimal(textBox8.Text).ToString("0.00");
				Decimal remise = System.Convert.ToDecimal(label21.Text);
				int remise2 = 100-System.Convert.ToInt32(remise);
				string calcul="0,"+remise2.ToString();
				Decimal taux=System.Convert.ToDecimal(calcul);
				if(remise2.Equals(100))
					taux=1;
				Decimal prix = System.Convert.ToDecimal(textBox8.Text);
				Decimal net = taux*prix;
				textBox9.Text=net.ToString("0.00");
				Decimal PAPV = System.Convert.ToDecimal(label22.Text);
				Decimal PrixVente = PAPV*prix;
				textBox20.Text=PrixVente.ToString("0.00");
				Comm.CommandText="update t_pieces_detachees set [prix achat brut]="+textBox8.Text.Replace(",",".")+" where Identificateur="+textBox1.Text;
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

			}
		}

		private void mtgcComboBox1_Enter(object sender, System.EventArgs e)
		{
			if(mtgcComboBox1.Items.Count<2)
			{
				
			}
			
		}

		private void mtgcComboBox2_Enter(object sender, System.EventArgs e)
		{
			if(mtgcComboBox2.Items.Count<2)
			{
				
			}

		}

		private void mtgcComboBox3_Enter(object sender, System.EventArgs e)
		{
			if(mtgcComboBox3.Items.Count<2)
			{
				
			}
		}
	}
}
