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
	/// Description résumée de Capteurs.
	/// </summary>
	public class Capteurs : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private int Agence;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.TextBox textBox14;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private bool Nouveau;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private MTGCComboBox mtgcComboBox1;
		private MTGCComboBox mtgcComboBox2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter6;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
		private MTGCComboBox mtgcComboBox3;
		private MTGCComboBox mtgcComboBox4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private OleDbTransaction Transac;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Capteurs(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			Nouveau=true;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Capteurs));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.mtgcComboBox4 = new MTGCComboBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
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
			this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter5 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
			this.button2 = new System.Windows.Forms.Button();
			this.oleDbDataAdapter6 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.tabPageEX2.SuspendLayout();
			this.tabPageEX3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox3.Controls.Add(this.textBox13);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.textBox12);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.textBox11);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Location = new System.Drawing.Point(40, 268);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(686, 71);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// textBox13
			// 
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox13.Location = new System.Drawing.Point(264, 38);
			this.textBox13.Name = "textBox13";
			this.textBox13.TabIndex = 5;
			this.textBox13.Text = "";
			this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(272, 19);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 15);
			this.label15.TabIndex = 4;
			this.label15.Text = "Valeur actuelle";
			// 
			// textBox12
			// 
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Location = new System.Drawing.Point(147, 38);
			this.textBox12.Name = "textBox12";
			this.textBox12.TabIndex = 3;
			this.textBox12.Text = "";
			this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(162, 19);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(73, 18);
			this.label14.TabIndex = 2;
			this.label14.Text = "Valeur limite";
			// 
			// textBox11
			// 
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Location = new System.Drawing.Point(29, 38);
			this.textBox11.Name = "textBox11";
			this.textBox11.TabIndex = 1;
			this.textBox11.Text = "";
			this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(23, 17);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(117, 17);
			this.label13.TabIndex = 0;
			this.label13.Text = "Nombre de mesures";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.dateTimePicker3);
			this.groupBox1.Controls.Add(this.dateTimePicker2);
			this.groupBox1.Controls.Add(this.textBox14);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(40, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(686, 72);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Checked = false;
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker3.Location = new System.Drawing.Point(372, 13);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.ShowCheckBox = true;
			this.dateTimePicker3.Size = new System.Drawing.Size(89, 20);
			this.dateTimePicker3.TabIndex = 8;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(133, 14);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(94, 20);
			this.dateTimePicker2.TabIndex = 7;
			// 
			// textBox14
			// 
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox14.Location = new System.Drawing.Point(467, 43);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(30, 20);
			this.textBox14.TabIndex = 6;
			this.textBox14.Text = "";
			this.textBox14.Visible = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Capteur";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(256, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Dernier contrôle";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mise en service";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(133, 43);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(327, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.mtgcComboBox4);
			this.groupBox2.Controls.Add(this.textBox10);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.textBox9);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBox8);
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Location = new System.Drawing.Point(40, 77);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(686, 183);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// mtgcComboBox4
			// 
			this.mtgcComboBox4.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox4.ColumnNum = 1;
			this.mtgcComboBox4.ColumnWidth = "121";
			this.mtgcComboBox4.DisplayMember = "Text";
			this.mtgcComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox4.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox4.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox4.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox4.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox4.DropDownWidth = 141;
			this.mtgcComboBox4.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox4.GridLineHorizontal = false;
			this.mtgcComboBox4.GridLineVertical = false;
			this.mtgcComboBox4.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox4.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox4.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox4.Location = new System.Drawing.Point(160, 80);
			this.mtgcComboBox4.ManagingFastMouseMoving = true;
			this.mtgcComboBox4.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox4.Name = "mtgcComboBox4";
			this.mtgcComboBox4.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox4.Size = new System.Drawing.Size(121, 21);
			this.mtgcComboBox4.TabIndex = 16;
			// 
			// textBox10
			// 
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Location = new System.Drawing.Point(552, 148);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(96, 20);
			this.textBox10.TabIndex = 15;
			this.textBox10.Text = "";
			this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(344, 151);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(138, 15);
			this.label12.TabIndex = 14;
			this.label12.Text = "Impulsion / Rotation";
			// 
			// textBox9
			// 
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Location = new System.Drawing.Point(552, 116);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(96, 20);
			this.textBox9.TabIndex = 13;
			this.textBox9.Text = "";
			this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(344, 119);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(144, 14);
			this.label11.TabIndex = 12;
			this.label11.Text = "Angle/Mesure - vitesse";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(344, 86);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(179, 16);
			this.label10.TabIndex = 11;
			this.label10.Text = "Valeur étalon. sens anti-horaire";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(344, 55);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(168, 17);
			this.label9.TabIndex = 10;
			this.label9.Text = "Valeur Etalon. sens horaire ";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(344, 23);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 16);
			this.label8.TabIndex = 9;
			this.label8.Text = "Capacité nominale";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(29, 85);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "Unité d\'étalonnage";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(29, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 15);
			this.label6.TabIndex = 7;
			this.label6.Text = "Référence";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(29, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 18);
			this.label5.TabIndex = 6;
			this.label5.Text = "N° Serie";
			// 
			// textBox8
			// 
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(552, 83);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(96, 20);
			this.textBox8.TabIndex = 4;
			this.textBox8.Text = "";
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox7
			// 
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(552, 51);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(96, 20);
			this.textBox7.TabIndex = 3;
			this.textBox7.Text = "";
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(552, 20);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(96, 20);
			this.textBox6.TabIndex = 2;
			this.textBox6.Text = "";
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(160, 50);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(120, 20);
			this.textBox5.TabIndex = 1;
			this.textBox5.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(160, 20);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(120, 20);
			this.textBox4.TabIndex = 0;
			this.textBox4.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(400, 8);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(100, 14);
			this.label20.TabIndex = 11;
			this.label20.Text = "Type";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(240, 10);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 12);
			this.label19.TabIndex = 10;
			this.label19.Text = "Responsable";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(120, 10);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(112, 12);
			this.label18.TabIndex = 9;
			this.label18.Text = "Valeur du compteur";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(565, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 21);
			this.button1.TabIndex = 17;
			this.button1.Text = "Ajouter";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(11, 10);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 12);
			this.label17.TabIndex = 7;
			this.label17.Text = "Date";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(10, 48);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 14);
			this.label16.TabIndex = 6;
			this.label16.Text = "Commentaire";
			// 
			// textBox17
			// 
			this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox17.Location = new System.Drawing.Point(12, 64);
			this.textBox17.Multiline = true;
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(687, 56);
			this.textBox17.TabIndex = 16;
			this.textBox17.Text = "";
			// 
			// textBox16
			// 
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox16.Location = new System.Drawing.Point(128, 25);
			this.textBox16.Name = "textBox16";
			this.textBox16.ReadOnly = true;
			this.textBox16.TabIndex = 13;
			this.textBox16.TabStop = false;
			this.textBox16.Text = "";
			this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader3,
																						this.columnHeader4,
																						this.columnHeader5});
			this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(13, 128);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(687, 249);
			this.listView1.TabIndex = 0;
			this.listView1.TabStop = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Date";
			this.columnHeader1.Width = 70;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Compteur";
			this.columnHeader2.Width = 110;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Responsable";
			this.columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Type";
			this.columnHeader4.Width = 90;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Commentaire";
			this.columnHeader5.Width = 255;
			// 
			// listView2
			// 
			this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader6,
																						this.columnHeader7,
																						this.columnHeader8,
																						this.columnHeader9,
																						this.columnHeader10});
			this.listView2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new System.Drawing.Point(16, 16);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(682, 352);
			this.listView2.TabIndex = 0;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Chaine";
			this.columnHeader6.Width = 250;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Date";
			this.columnHeader7.Width = 80;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Ctrl";
			this.columnHeader8.Width = 70;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Controle machine";
			this.columnHeader9.Width = 150;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Mes.";
			this.columnHeader10.Width = 110;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Recherche";
			// 
			// btSupprime
			// 
			this.btSupprime.BackColor = System.Drawing.Color.White;
			this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSupprime.Enabled = false;
			this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btSupprime.ForeColor = System.Drawing.Color.Red;
			this.btSupprime.Location = new System.Drawing.Point(544, 480);
			this.btSupprime.Name = "btSupprime";
			this.btSupprime.Size = new System.Drawing.Size(100, 23);
			this.btSupprime.TabIndex = 15;
			this.btSupprime.TabStop = false;
			this.btSupprime.Text = "Supprime";
			this.btSupprime.Click += new System.EventHandler(this.btSupprime_Click);
			// 
			// btEnregistre
			// 
			this.btEnregistre.BackColor = System.Drawing.Color.White;
			this.btEnregistre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btEnregistre.Enabled = false;
			this.btEnregistre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEnregistre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btEnregistre.ForeColor = System.Drawing.Color.Blue;
			this.btEnregistre.Location = new System.Drawing.Point(128, 480);
			this.btEnregistre.Name = "btEnregistre";
			this.btEnregistre.Size = new System.Drawing.Size(100, 23);
			this.btEnregistre.TabIndex = 17;
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
			this.btNouveau.Location = new System.Drawing.Point(16, 480);
			this.btNouveau.Name = "btNouveau";
			this.btNouveau.Size = new System.Drawing.Size(100, 23);
			this.btNouveau.TabIndex = 14;
			this.btNouveau.TabStop = false;
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
																										new System.Data.Common.DataTableMapping("Table", "T_parc_CAPTEURS", new System.Data.Common.DataColumnMapping[] {
																																																						   new System.Data.Common.DataColumnMapping("A_M_V", "A_M_V"),
																																																						   new System.Data.Common.DataColumnMapping("capacite_nom", "capacite_nom"),
																																																						   new System.Data.Common.DataColumnMapping("Chaine", "Chaine"),
																																																						   new System.Data.Common.DataColumnMapping("Date Dernier Controle", "Date Dernier Controle"),
																																																						   new System.Data.Common.DataColumnMapping("Date_MES", "Date_MES"),
																																																						   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																						   new System.Data.Common.DataColumnMapping("imp_rot", "imp_rot"),
																																																						   new System.Data.Common.DataColumnMapping("Refer", "Refer"),
																																																						   new System.Data.Common.DataColumnMapping("Serie", "Serie"),
																																																						   new System.Data.Common.DataColumnMapping("Unite_etal", "Unite_etal"),
																																																						   new System.Data.Common.DataColumnMapping("Val_Actuelle", "Val_Actuelle"),
																																																						   new System.Data.Common.DataColumnMapping("Val_Etal_Devis", "Val_Etal_Devis"),
																																																						   new System.Data.Common.DataColumnMapping("Val_Mes_Initiale", "Val_Mes_Initiale"),
																																																						   new System.Data.Common.DataColumnMapping("Val_Mes_limite", "Val_Mes_limite"),
																																																						   new System.Data.Common.DataColumnMapping("Val-Etal_Vis", "Val-Etal_Vis")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM T_parc_CAPTEURS WHERE (ID = ?) AND (A_M_V = ? OR ? IS NULL AND A_M_V IS NULL) AND (Chaine = ? OR ? IS NULL AND Chaine IS NULL) AND ([Date Dernier Controle] = ? OR ? IS NULL AND [Date Dernier Controle] IS NULL) AND (Date_MES = ? OR ? IS NULL AND Date_MES IS NULL) AND (Refer = ? OR ? IS NULL AND Refer IS NULL) AND (Serie = ? OR ? IS NULL AND Serie IS NULL) AND (Unite_etal = ? OR ? IS NULL AND Unite_etal IS NULL) AND ([Val-Etal_Vis] = ? OR ? IS NULL AND [Val-Etal_Vis] IS NULL) AND (Val_Actuelle = ? OR ? IS NULL AND Val_Actuelle IS NULL) AND (Val_Etal_Devis = ? OR ? IS NULL AND Val_Etal_Devis IS NULL) AND (Val_Mes_Initiale = ? OR ? IS NULL AND Val_Mes_Initiale IS NULL) AND (Val_Mes_limite = ? OR ? IS NULL AND Val_Mes_limite IS NULL) AND (capacite_nom = ? OR ? IS NULL AND capacite_nom IS NULL) AND (imp_rot = ? OR ? IS NULL AND imp_rot IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_A_M_V", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "A_M_V", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_A_M_V1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "A_M_V", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_MES", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_MES", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refer", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refer", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refer1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refer", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Serie", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Serie1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unite_etal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unite_etal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unite_etal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unite_etal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Vis", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val-Etal_Vis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Vis1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val-Etal_Vis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Actuelle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Actuelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Actuelle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Actuelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Devis", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Etal_Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Devis1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Etal_Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_Initiale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_Initiale", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_Initiale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_Initiale", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_limite", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_limite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_limite1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_limite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capacite_nom", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capacite_nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capacite_nom1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capacite_nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_imp_rot", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "imp_rot", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_imp_rot1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "imp_rot", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO T_parc_CAPTEURS(A_M_V, capacite_nom, Chaine, [Date Dernier Controle], Date_MES, imp_rot, Refer, Serie, Unite_etal, Val_Actuelle, Val_Etal_Devis, Val_Mes_Initiale, Val_Mes_limite, [Val-Etal_Vis]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("A_M_V", System.Data.OleDb.OleDbType.VarWChar, 3, "A_M_V"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("capacite_nom", System.Data.OleDb.OleDbType.VarWChar, 8, "capacite_nom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, "Date_MES"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("imp_rot", System.Data.OleDb.OleDbType.VarWChar, 4, "imp_rot"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refer", System.Data.OleDb.OleDbType.VarWChar, 10, "Refer"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Serie", System.Data.OleDb.OleDbType.VarWChar, 10, "Serie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Unite_etal", System.Data.OleDb.OleDbType.VarWChar, 5, "Unite_etal"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Actuelle", System.Data.OleDb.OleDbType.Integer, 0, "Val_Actuelle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Etal_Devis", System.Data.OleDb.OleDbType.VarWChar, 6, "Val_Etal_Devis"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Mes_Initiale", System.Data.OleDb.OleDbType.Integer, 0, "Val_Mes_Initiale"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Mes_limite", System.Data.OleDb.OleDbType.Integer, 0, "Val_Mes_limite"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Etal_Vis", System.Data.OleDb.OleDbType.VarWChar, 6, "Val-Etal_Vis"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT A_M_V, capacite_nom, Chaine, [Date Dernier Controle], Date_MES, ID, imp_ro" +
				"t, Refer, Serie, Unite_etal, Val_Actuelle, Val_Etal_Devis, Val_Mes_Initiale, Val" +
				"_Mes_limite, [Val-Etal_Vis] FROM T_parc_CAPTEURS";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE T_parc_CAPTEURS SET A_M_V = ?, capacite_nom = ?, Chaine = ?, [Date Dernier Controle] = ?, Date_MES = ?, imp_rot = ?, Refer = ?, Serie = ?, Unite_etal = ?, Val_Actuelle = ?, Val_Etal_Devis = ?, Val_Mes_Initiale = ?, Val_Mes_limite = ?, [Val-Etal_Vis] = ? WHERE (ID = ?) AND (A_M_V = ? OR ? IS NULL AND A_M_V IS NULL) AND (Chaine = ? OR ? IS NULL AND Chaine IS NULL) AND ([Date Dernier Controle] = ? OR ? IS NULL AND [Date Dernier Controle] IS NULL) AND (Date_MES = ? OR ? IS NULL AND Date_MES IS NULL) AND (Refer = ? OR ? IS NULL AND Refer IS NULL) AND (Serie = ? OR ? IS NULL AND Serie IS NULL) AND (Unite_etal = ? OR ? IS NULL AND Unite_etal IS NULL) AND ([Val-Etal_Vis] = ? OR ? IS NULL AND [Val-Etal_Vis] IS NULL) AND (Val_Actuelle = ? OR ? IS NULL AND Val_Actuelle IS NULL) AND (Val_Etal_Devis = ? OR ? IS NULL AND Val_Etal_Devis IS NULL) AND (Val_Mes_Initiale = ? OR ? IS NULL AND Val_Mes_Initiale IS NULL) AND (Val_Mes_limite = ? OR ? IS NULL AND Val_Mes_limite IS NULL) AND (capacite_nom = ? OR ? IS NULL AND capacite_nom IS NULL) AND (imp_rot = ? OR ? IS NULL AND imp_rot IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("A_M_V", System.Data.OleDb.OleDbType.VarWChar, 3, "A_M_V"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("capacite_nom", System.Data.OleDb.OleDbType.VarWChar, 8, "capacite_nom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, "Date_MES"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("imp_rot", System.Data.OleDb.OleDbType.VarWChar, 4, "imp_rot"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refer", System.Data.OleDb.OleDbType.VarWChar, 10, "Refer"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Serie", System.Data.OleDb.OleDbType.VarWChar, 10, "Serie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Unite_etal", System.Data.OleDb.OleDbType.VarWChar, 5, "Unite_etal"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Actuelle", System.Data.OleDb.OleDbType.Integer, 0, "Val_Actuelle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Etal_Devis", System.Data.OleDb.OleDbType.VarWChar, 6, "Val_Etal_Devis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Mes_Initiale", System.Data.OleDb.OleDbType.Integer, 0, "Val_Mes_Initiale"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Mes_limite", System.Data.OleDb.OleDbType.Integer, 0, "Val_Mes_limite"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Etal_Vis", System.Data.OleDb.OleDbType.VarWChar, 6, "Val-Etal_Vis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_A_M_V", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "A_M_V", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_A_M_V1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "A_M_V", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_MES", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_MES", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refer", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refer", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refer1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refer", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Serie", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Serie1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unite_etal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unite_etal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unite_etal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unite_etal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Vis", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val-Etal_Vis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Vis1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val-Etal_Vis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Actuelle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Actuelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Actuelle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Actuelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Devis", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Etal_Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Devis1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Etal_Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_Initiale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_Initiale", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_Initiale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_Initiale", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_limite", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_limite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_limite1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_limite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capacite_nom", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capacite_nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capacite_nom1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capacite_nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_imp_rot", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "imp_rot", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_imp_rot1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "imp_rot", System.Data.DataRowVersion.Original, null));
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
																										new System.Data.Common.DataTableMapping("Table", "T_unites_mesure", new System.Data.Common.DataColumnMapping[] {
																																																						   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																						   new System.Data.Common.DataColumnMapping("Unité", "Unité")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = "DELETE FROM T_unites_mesure WHERE (ID = ?) AND (Unité = ? OR ? IS NULL AND Unité " +
				"IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unité", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unité", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unité1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unité", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO T_unites_mesure(Unité) VALUES (?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Unité", System.Data.OleDb.OleDbType.VarWChar, 255, "Unité"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT ID, Unité FROM T_unites_mesure ORDER BY Unité";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = "UPDATE T_unites_mesure SET Unité = ? WHERE (ID = ?) AND (Unité = ? OR ? IS NULL A" +
				"ND Unité IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Unité", System.Data.OleDb.OleDbType.VarWChar, 255, "Unité"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unité", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unité", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unité1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unité", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_controles_dym", new System.Data.Common.DataColumnMapping[] {
																																																						   new System.Data.Common.DataColumnMapping("aspect", "aspect"),
																																																						   new System.Data.Common.DataColumnMapping("C_iso", "C_iso"),
																																																						   new System.Data.Common.DataColumnMapping("capteur", "capteur"),
																																																						   new System.Data.Common.DataColumnMapping("Code machine opindus", "Code machine opindus"),
																																																						   new System.Data.Common.DataColumnMapping("Commentaire", "Commentaire"),
																																																						   new System.Data.Common.DataColumnMapping("conf_carre", "conf_carre"),
																																																						   new System.Data.Common.DataColumnMapping("Couple_Maxi", "Couple_Maxi"),
																																																						   new System.Data.Common.DataColumnMapping("Couple_mini", "Couple_mini"),
																																																						   new System.Data.Common.DataColumnMapping("Date_controle", "Date_controle"),
																																																						   new System.Data.Common.DataColumnMapping("ets", "ets"),
																																																						   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																						   new System.Data.Common.DataColumnMapping("Indentification", "Indentification"),
																																																						   new System.Data.Common.DataColumnMapping("marquage", "marquage"),
																																																						   new System.Data.Common.DataColumnMapping("Modele", "Modele"),
																																																						   new System.Data.Common.DataColumnMapping("N° Controle", "N° Controle"),
																																																						   new System.Data.Common.DataColumnMapping("Operateur", "Operateur"),
																																																						   new System.Data.Common.DataColumnMapping("precision", "precision"),
																																																						   new System.Data.Common.DataColumnMapping("R_100", "R_100"),
																																																						   new System.Data.Common.DataColumnMapping("R_20", "R_20"),
																																																						   new System.Data.Common.DataColumnMapping("R_60", "R_60"),
																																																						   new System.Data.Common.DataColumnMapping("T_iso", "T_iso"),
																																																						   new System.Data.Common.DataColumnMapping("test_vide", "test_vide"),
																																																						   new System.Data.Common.DataColumnMapping("Val_001_100", "Val_001_100"),
																																																						   new System.Data.Common.DataColumnMapping("Val_001_20", "Val_001_20"),
																																																						   new System.Data.Common.DataColumnMapping("Val_001_60", "Val_001_60"),
																																																						   new System.Data.Common.DataColumnMapping("Val_002_100", "Val_002_100"),
																																																						   new System.Data.Common.DataColumnMapping("Val_002_20", "Val_002_20"),
																																																						   new System.Data.Common.DataColumnMapping("Val_002_60", "Val_002_60"),
																																																						   new System.Data.Common.DataColumnMapping("Val_003_100", "Val_003_100"),
																																																						   new System.Data.Common.DataColumnMapping("Val_003_20", "Val_003_20"),
																																																						   new System.Data.Common.DataColumnMapping("Val_003_60", "Val_003_60"),
																																																						   new System.Data.Common.DataColumnMapping("Val_004_100", "Val_004_100"),
																																																						   new System.Data.Common.DataColumnMapping("Val_004_20", "Val_004_20"),
																																																						   new System.Data.Common.DataColumnMapping("Val_004_60", "Val_004_60"),
																																																						   new System.Data.Common.DataColumnMapping("Val_005_100", "Val_005_100"),
																																																						   new System.Data.Common.DataColumnMapping("Val_005_20", "Val_005_20"),
																																																						   new System.Data.Common.DataColumnMapping("Val_005_60", "Val_005_60")})});
			this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
			// 
			// oleDbDeleteCommand3
			// 
			this.oleDbDeleteCommand3.CommandText = "DELETE FROM T_controles_dym WHERE (ID = ?) AND (C_iso = ? OR ? IS NULL AND C_iso " +
				"IS NULL) AND ([Code machine opindus] = ? OR ? IS NULL AND [Code machine opindus]" +
				" IS NULL) AND (Couple_Maxi = ? OR ? IS NULL AND Couple_Maxi IS NULL) AND (Couple" +
				"_mini = ? OR ? IS NULL AND Couple_mini IS NULL) AND (Date_controle = ? OR ? IS N" +
				"ULL AND Date_controle IS NULL) AND (Indentification = ?) AND (Modele = ? OR ? IS" +
				" NULL AND Modele IS NULL) AND ([N° Controle] = ? OR ? IS NULL AND [N° Controle] " +
				"IS NULL) AND (Operateur = ? OR ? IS NULL AND Operateur IS NULL) AND (R_100 = ? O" +
				"R ? IS NULL AND R_100 IS NULL) AND (R_20 = ? OR ? IS NULL AND R_20 IS NULL) AND " +
				"(R_60 = ? OR ? IS NULL AND R_60 IS NULL) AND (T_iso = ? OR ? IS NULL AND T_iso I" +
				"S NULL) AND (Val_001_100 = ? OR ? IS NULL AND Val_001_100 IS NULL) AND (Val_001_" +
				"20 = ? OR ? IS NULL AND Val_001_20 IS NULL) AND (Val_001_60 = ? OR ? IS NULL AND" +
				" Val_001_60 IS NULL) AND (Val_002_100 = ? OR ? IS NULL AND Val_002_100 IS NULL) " +
				"AND (Val_002_20 = ? OR ? IS NULL AND Val_002_20 IS NULL) AND (Val_002_60 = ? OR " +
				"? IS NULL AND Val_002_60 IS NULL) AND (Val_003_100 = ? OR ? IS NULL AND Val_003_" +
				"100 IS NULL) AND (Val_003_20 = ? OR ? IS NULL AND Val_003_20 IS NULL) AND (Val_0" +
				"03_60 = ? OR ? IS NULL AND Val_003_60 IS NULL) AND (Val_004_100 = ? OR ? IS NULL" +
				" AND Val_004_100 IS NULL) AND (Val_004_20 = ? OR ? IS NULL AND Val_004_20 IS NUL" +
				"L) AND (Val_004_60 = ? OR ? IS NULL AND Val_004_60 IS NULL) AND (Val_005_100 = ?" +
				" OR ? IS NULL AND Val_005_100 IS NULL) AND (Val_005_20 = ? OR ? IS NULL AND Val_" +
				"005_20 IS NULL) AND (Val_005_60 = ? OR ? IS NULL AND Val_005_60 IS NULL) AND (as" +
				"pect = ? OR ? IS NULL AND aspect IS NULL) AND (capteur = ? OR ? IS NULL AND capt" +
				"eur IS NULL) AND (conf_carre = ?) AND (ets = ? OR ? IS NULL AND ets IS NULL) AND" +
				" (marquage = ?) AND (precision = ? OR ? IS NULL AND precision IS NULL) AND (test" +
				"_vide = ? OR ? IS NULL AND test_vide IS NULL)";
			this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_opindus1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Indentification", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Indentification", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Modele", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Modele", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Modele1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Modele", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Operateur", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Operateur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Operateur1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Operateur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_T_iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_T_iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_aspect", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "aspect", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_aspect1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "aspect", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capteur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capteur1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_conf_carre", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "conf_carre", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ets", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ets", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ets1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ets", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_marquage", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "marquage", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_precision", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "precision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_precision1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "precision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_test_vide", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "test_vide", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_test_vide1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "test_vide", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand3
			// 
			this.oleDbInsertCommand3.CommandText = @"INSERT INTO T_controles_dym(aspect, C_iso, capteur, [Code machine opindus], Commentaire, conf_carre, Couple_Maxi, Couple_mini, Date_controle, ets, Indentification, marquage, Modele, [N° Controle], Operateur, precision, R_100, R_20, R_60, T_iso, test_vide, Val_001_100, Val_001_20, Val_001_60, Val_002_100, Val_002_20, Val_002_60, Val_003_100, Val_003_20, Val_003_60, Val_004_100, Val_004_20, Val_004_60, Val_005_100, Val_005_20, Val_005_60) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("aspect", System.Data.OleDb.OleDbType.VarWChar, 1, "aspect"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_iso", System.Data.OleDb.OleDbType.VarWChar, 5, "C_iso"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("capteur", System.Data.OleDb.OleDbType.Integer, 0, "capteur"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine opindus"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("conf_carre", System.Data.OleDb.OleDbType.Boolean, 2, "conf_carre"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Couple_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Couple_Maxi"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Couple_mini", System.Data.OleDb.OleDbType.Double, 0, "Couple_mini"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date_controle"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ets", System.Data.OleDb.OleDbType.VarWChar, 50, "ets"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Indentification", System.Data.OleDb.OleDbType.Boolean, 2, "Indentification"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("marquage", System.Data.OleDb.OleDbType.Boolean, 2, "marquage"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Modele", System.Data.OleDb.OleDbType.VarWChar, 19, "Modele"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Controle", System.Data.OleDb.OleDbType.Integer, 0, "N° Controle"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Operateur", System.Data.OleDb.OleDbType.VarWChar, 5, "Operateur"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("precision", System.Data.OleDb.OleDbType.Double, 0, "precision"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_100", System.Data.OleDb.OleDbType.Double, 0, "R_100"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_20", System.Data.OleDb.OleDbType.Double, 0, "R_20"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_60", System.Data.OleDb.OleDbType.Double, 0, "R_60"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("T_iso", System.Data.OleDb.OleDbType.VarWChar, 5, "T_iso"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("test_vide", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "test_vide"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_100", System.Data.OleDb.OleDbType.Double, 0, "Val_001_100"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_20", System.Data.OleDb.OleDbType.Double, 0, "Val_001_20"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_60", System.Data.OleDb.OleDbType.Double, 0, "Val_001_60"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_100", System.Data.OleDb.OleDbType.Double, 0, "Val_002_100"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_20", System.Data.OleDb.OleDbType.Double, 0, "Val_002_20"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_60", System.Data.OleDb.OleDbType.Double, 0, "Val_002_60"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_100", System.Data.OleDb.OleDbType.Double, 0, "Val_003_100"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_20", System.Data.OleDb.OleDbType.Double, 0, "Val_003_20"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_60", System.Data.OleDb.OleDbType.Double, 0, "Val_003_60"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_100", System.Data.OleDb.OleDbType.Double, 0, "Val_004_100"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_20", System.Data.OleDb.OleDbType.Double, 0, "Val_004_20"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_60", System.Data.OleDb.OleDbType.Double, 0, "Val_004_60"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_100", System.Data.OleDb.OleDbType.Double, 0, "Val_005_100"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_20", System.Data.OleDb.OleDbType.Double, 0, "Val_005_20"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_60", System.Data.OleDb.OleDbType.Double, 0, "Val_005_60"));
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = @"SELECT aspect, C_iso, capteur, [Code machine opindus], Commentaire, conf_carre, Couple_Maxi, Couple_mini, Date_controle, ets, ID, Indentification, marquage, Modele, [N° Controle], Operateur, precision, R_100, R_20, R_60, T_iso, test_vide, Val_001_100, Val_001_20, Val_001_60, Val_002_100, Val_002_20, Val_002_60, Val_003_100, Val_003_20, Val_003_60, Val_004_100, Val_004_20, Val_004_60, Val_005_100, Val_005_20, Val_005_60 FROM T_controles_dym";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand3
			// 
			this.oleDbUpdateCommand3.CommandText = "UPDATE T_controles_dym SET aspect = ?, C_iso = ?, capteur = ?, [Code machine opin" +
				"dus] = ?, Commentaire = ?, conf_carre = ?, Couple_Maxi = ?, Couple_mini = ?, Dat" +
				"e_controle = ?, ets = ?, Indentification = ?, marquage = ?, Modele = ?, [N° Cont" +
				"role] = ?, Operateur = ?, precision = ?, R_100 = ?, R_20 = ?, R_60 = ?, T_iso = " +
				"?, test_vide = ?, Val_001_100 = ?, Val_001_20 = ?, Val_001_60 = ?, Val_002_100 =" +
				" ?, Val_002_20 = ?, Val_002_60 = ?, Val_003_100 = ?, Val_003_20 = ?, Val_003_60 " +
				"= ?, Val_004_100 = ?, Val_004_20 = ?, Val_004_60 = ?, Val_005_100 = ?, Val_005_2" +
				"0 = ?, Val_005_60 = ? WHERE (ID = ?) AND (C_iso = ? OR ? IS NULL AND C_iso IS NU" +
				"LL) AND ([Code machine opindus] = ? OR ? IS NULL AND [Code machine opindus] IS N" +
				"ULL) AND (Couple_Maxi = ? OR ? IS NULL AND Couple_Maxi IS NULL) AND (Couple_mini" +
				" = ? OR ? IS NULL AND Couple_mini IS NULL) AND (Date_controle = ? OR ? IS NULL A" +
				"ND Date_controle IS NULL) AND (Indentification = ?) AND (Modele = ? OR ? IS NULL" +
				" AND Modele IS NULL) AND ([N° Controle] = ? OR ? IS NULL AND [N° Controle] IS NU" +
				"LL) AND (Operateur = ? OR ? IS NULL AND Operateur IS NULL) AND (R_100 = ? OR ? I" +
				"S NULL AND R_100 IS NULL) AND (R_20 = ? OR ? IS NULL AND R_20 IS NULL) AND (R_60" +
				" = ? OR ? IS NULL AND R_60 IS NULL) AND (T_iso = ? OR ? IS NULL AND T_iso IS NUL" +
				"L) AND (Val_001_100 = ? OR ? IS NULL AND Val_001_100 IS NULL) AND (Val_001_20 = " +
				"? OR ? IS NULL AND Val_001_20 IS NULL) AND (Val_001_60 = ? OR ? IS NULL AND Val_" +
				"001_60 IS NULL) AND (Val_002_100 = ? OR ? IS NULL AND Val_002_100 IS NULL) AND (" +
				"Val_002_20 = ? OR ? IS NULL AND Val_002_20 IS NULL) AND (Val_002_60 = ? OR ? IS " +
				"NULL AND Val_002_60 IS NULL) AND (Val_003_100 = ? OR ? IS NULL AND Val_003_100 I" +
				"S NULL) AND (Val_003_20 = ? OR ? IS NULL AND Val_003_20 IS NULL) AND (Val_003_60" +
				" = ? OR ? IS NULL AND Val_003_60 IS NULL) AND (Val_004_100 = ? OR ? IS NULL AND " +
				"Val_004_100 IS NULL) AND (Val_004_20 = ? OR ? IS NULL AND Val_004_20 IS NULL) AN" +
				"D (Val_004_60 = ? OR ? IS NULL AND Val_004_60 IS NULL) AND (Val_005_100 = ? OR ?" +
				" IS NULL AND Val_005_100 IS NULL) AND (Val_005_20 = ? OR ? IS NULL AND Val_005_2" +
				"0 IS NULL) AND (Val_005_60 = ? OR ? IS NULL AND Val_005_60 IS NULL) AND (aspect " +
				"= ? OR ? IS NULL AND aspect IS NULL) AND (capteur = ? OR ? IS NULL AND capteur I" +
				"S NULL) AND (conf_carre = ?) AND (ets = ? OR ? IS NULL AND ets IS NULL) AND (mar" +
				"quage = ?) AND (precision = ? OR ? IS NULL AND precision IS NULL) AND (test_vide" +
				" = ? OR ? IS NULL AND test_vide IS NULL)";
			this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("aspect", System.Data.OleDb.OleDbType.VarWChar, 1, "aspect"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_iso", System.Data.OleDb.OleDbType.VarWChar, 5, "C_iso"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("capteur", System.Data.OleDb.OleDbType.Integer, 0, "capteur"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine opindus"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("conf_carre", System.Data.OleDb.OleDbType.Boolean, 2, "conf_carre"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Couple_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Couple_Maxi"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Couple_mini", System.Data.OleDb.OleDbType.Double, 0, "Couple_mini"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date_controle"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ets", System.Data.OleDb.OleDbType.VarWChar, 50, "ets"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Indentification", System.Data.OleDb.OleDbType.Boolean, 2, "Indentification"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("marquage", System.Data.OleDb.OleDbType.Boolean, 2, "marquage"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Modele", System.Data.OleDb.OleDbType.VarWChar, 19, "Modele"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Controle", System.Data.OleDb.OleDbType.Integer, 0, "N° Controle"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Operateur", System.Data.OleDb.OleDbType.VarWChar, 5, "Operateur"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("precision", System.Data.OleDb.OleDbType.Double, 0, "precision"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_100", System.Data.OleDb.OleDbType.Double, 0, "R_100"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_20", System.Data.OleDb.OleDbType.Double, 0, "R_20"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_60", System.Data.OleDb.OleDbType.Double, 0, "R_60"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("T_iso", System.Data.OleDb.OleDbType.VarWChar, 5, "T_iso"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("test_vide", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "test_vide"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_100", System.Data.OleDb.OleDbType.Double, 0, "Val_001_100"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_20", System.Data.OleDb.OleDbType.Double, 0, "Val_001_20"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_60", System.Data.OleDb.OleDbType.Double, 0, "Val_001_60"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_100", System.Data.OleDb.OleDbType.Double, 0, "Val_002_100"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_20", System.Data.OleDb.OleDbType.Double, 0, "Val_002_20"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_60", System.Data.OleDb.OleDbType.Double, 0, "Val_002_60"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_100", System.Data.OleDb.OleDbType.Double, 0, "Val_003_100"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_20", System.Data.OleDb.OleDbType.Double, 0, "Val_003_20"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_60", System.Data.OleDb.OleDbType.Double, 0, "Val_003_60"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_100", System.Data.OleDb.OleDbType.Double, 0, "Val_004_100"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_20", System.Data.OleDb.OleDbType.Double, 0, "Val_004_20"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_60", System.Data.OleDb.OleDbType.Double, 0, "Val_004_60"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_100", System.Data.OleDb.OleDbType.Double, 0, "Val_005_100"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_20", System.Data.OleDb.OleDbType.Double, 0, "Val_005_20"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_60", System.Data.OleDb.OleDbType.Double, 0, "Val_005_60"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_opindus1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Indentification", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Indentification", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Modele", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Modele", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Modele1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Modele", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Operateur", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Operateur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Operateur1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Operateur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_T_iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_T_iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_aspect", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "aspect", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_aspect1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "aspect", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capteur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capteur1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_conf_carre", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "conf_carre", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ets", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ets", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ets1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ets", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_marquage", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "marquage", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_precision", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "precision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_precision1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "precision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_test_vide", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "test_vide", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_test_vide1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "test_vide", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand4;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_parc_CAPTEURS_FV", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("Date_verif", "Date_verif"),
																																																							  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																							  new System.Data.Common.DataColumnMapping("memo", "memo"),
																																																							  new System.Data.Common.DataColumnMapping("Responsable", "Responsable"),
																																																							  new System.Data.Common.DataColumnMapping("Type_verif", "Type_verif"),
																																																							  new System.Data.Common.DataColumnMapping("Val_cpt", "Val_cpt")})});
			// 
			// oleDbInsertCommand4
			// 
			this.oleDbInsertCommand4.CommandText = "INSERT INTO T_parc_CAPTEURS_FV(Date_verif, ID, [memo], Responsable, Type_verif, V" +
				"al_cpt) VALUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_verif", System.Data.OleDb.OleDbType.DBDate, 0, "Date_verif"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.Integer, 0, "ID"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("memo", System.Data.OleDb.OleDbType.VarWChar, 0, "memo"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Responsable", System.Data.OleDb.OleDbType.VarWChar, 50, "Responsable"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_verif", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type_verif"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_cpt", System.Data.OleDb.OleDbType.Integer, 0, "Val_cpt"));
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = "SELECT Date_verif, ID, [memo], Responsable, Type_verif, Val_cpt FROM T_parc_CAPTE" +
				"URS_FV";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter5
			// 
			this.oleDbDataAdapter5.DeleteCommand = this.oleDbDeleteCommand4;
			this.oleDbDataAdapter5.InsertCommand = this.oleDbInsertCommand5;
			this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
			this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_parc_CAPTEURS_stats", new System.Data.Common.DataColumnMapping[] {
																																																								 new System.Data.Common.DataColumnMapping("Chaine", "Chaine"),
																																																								 new System.Data.Common.DataColumnMapping("controle", "controle"),
																																																								 new System.Data.Common.DataColumnMapping("date", "date"),
																																																								 new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																								 new System.Data.Common.DataColumnMapping("Id_capteur", "Id_capteur"),
																																																								 new System.Data.Common.DataColumnMapping("machine", "machine"),
																																																								 new System.Data.Common.DataColumnMapping("nombre", "nombre")})});
			this.oleDbDataAdapter5.UpdateCommand = this.oleDbUpdateCommand4;
			// 
			// oleDbDeleteCommand4
			// 
			this.oleDbDeleteCommand4.CommandText = @"DELETE FROM T_parc_CAPTEURS_stats WHERE (ID = ?) AND (Chaine = ? OR ? IS NULL AND Chaine IS NULL) AND (Id_capteur = ? OR ? IS NULL AND Id_capteur IS NULL) AND (controle = ? OR ? IS NULL AND controle IS NULL) AND ([date] = ? OR ? IS NULL AND [date] IS NULL) AND (machine = ? OR ? IS NULL AND machine IS NULL) AND (nombre = ? OR ? IS NULL AND nombre IS NULL)";
			this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_capteur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_capteur1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_machine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_machine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand5
			// 
			this.oleDbInsertCommand5.CommandText = "INSERT INTO T_parc_CAPTEURS_stats(Chaine, controle, [date], Id_capteur, machine, " +
				"nombre) VALUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand5.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("controle", System.Data.OleDb.OleDbType.Integer, 0, "controle"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("date", System.Data.OleDb.OleDbType.DBDate, 0, "date"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Id_capteur", System.Data.OleDb.OleDbType.Integer, 0, "Id_capteur"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("machine", System.Data.OleDb.OleDbType.VarWChar, 50, "machine"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre", System.Data.OleDb.OleDbType.Integer, 0, "nombre"));
			// 
			// oleDbSelectCommand5
			// 
			this.oleDbSelectCommand5.CommandText = "SELECT Chaine, controle, [date], ID, Id_capteur, machine, nombre FROM T_parc_CAPT" +
				"EURS_stats";
			this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand4
			// 
			this.oleDbUpdateCommand4.CommandText = @"UPDATE T_parc_CAPTEURS_stats SET Chaine = ?, controle = ?, [date] = ?, Id_capteur = ?, machine = ?, nombre = ? WHERE (ID = ?) AND (Chaine = ? OR ? IS NULL AND Chaine IS NULL) AND (Id_capteur = ? OR ? IS NULL AND Id_capteur IS NULL) AND (controle = ? OR ? IS NULL AND controle IS NULL) AND ([date] = ? OR ? IS NULL AND [date] IS NULL) AND (machine = ? OR ? IS NULL AND machine IS NULL) AND (nombre = ? OR ? IS NULL AND nombre IS NULL)";
			this.oleDbUpdateCommand4.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("controle", System.Data.OleDb.OleDbType.Integer, 0, "controle"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("date", System.Data.OleDb.OleDbType.DBDate, 0, "date"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Id_capteur", System.Data.OleDb.OleDbType.Integer, 0, "Id_capteur"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("machine", System.Data.OleDb.OleDbType.VarWChar, 50, "machine"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre", System.Data.OleDb.OleDbType.Integer, 0, "nombre"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_capteur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Id_capteur1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id_capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_machine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_machine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre", System.Data.DataRowVersion.Original, null));
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Controls.Add(this.tabPageEX2);
			this.tabControlEX1.Controls.Add(this.tabPageEX3);
			this.tabControlEX1.Location = new System.Drawing.Point(-5, 40);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Gainsboro;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(780, 416);
			this.tabControlEX1.TabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.TabIndex = 18;
			this.tabControlEX1.UseVisualStyles = false;
			this.tabControlEX1.SelectedIndexChanged += new System.EventHandler(this.tabControlEX1_SelectedIndexChanged);
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.groupBox3);
			this.tabPageEX1.Controls.Add(this.groupBox2);
			this.tabPageEX1.Controls.Add(this.groupBox1);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(772, 387);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Saisie";
			// 
			// tabPageEX2
			// 
			this.tabPageEX2.Controls.Add(this.mtgcComboBox2);
			this.tabPageEX2.Controls.Add(this.mtgcComboBox1);
			this.tabPageEX2.Controls.Add(this.dateTimePicker1);
			this.tabPageEX2.Controls.Add(this.textBox16);
			this.tabPageEX2.Controls.Add(this.listView1);
			this.tabPageEX2.Controls.Add(this.label20);
			this.tabPageEX2.Controls.Add(this.label19);
			this.tabPageEX2.Controls.Add(this.label18);
			this.tabPageEX2.Controls.Add(this.button1);
			this.tabPageEX2.Controls.Add(this.label17);
			this.tabPageEX2.Controls.Add(this.label16);
			this.tabPageEX2.Controls.Add(this.textBox17);
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(772, 387);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Historique";
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
			this.mtgcComboBox2.Location = new System.Drawing.Point(400, 25);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(152, 21);
			this.mtgcComboBox2.TabIndex = 15;
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(240, 25);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(144, 21);
			this.mtgcComboBox1.TabIndex = 14;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(11, 25);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// tabPageEX3
			// 
			this.tabPageEX3.Controls.Add(this.listView2);
			this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX3.Name = "tabPageEX3";
			this.tabPageEX3.Size = new System.Drawing.Size(772, 387);
			this.tabPageEX3.TabIndex = 2;
			this.tabPageEX3.Text = "Historique des contrôles";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(696, 464);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 48);
			this.button2.TabIndex = 20;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// oleDbDataAdapter6
			// 
			this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand5;
			this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand6;
			this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
			this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_reparateurs", new System.Data.Common.DataColumnMapping[] {
																																																						 new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																						 new System.Data.Common.DataColumnMapping("Nom", "Nom")})});
			this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand5;
			// 
			// oleDbDeleteCommand5
			// 
			this.oleDbDeleteCommand5.CommandText = "DELETE FROM T_reparateurs WHERE (ID = ?) AND (Nom = ? OR ? IS NULL AND Nom IS NUL" +
				"L)";
			this.oleDbDeleteCommand5.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand6
			// 
			this.oleDbInsertCommand6.CommandText = "INSERT INTO T_reparateurs(ID, Nom) VALUES (?, ?)";
			this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 5, "ID"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom"));
			// 
			// oleDbSelectCommand6
			// 
			this.oleDbSelectCommand6.CommandText = "SELECT ID, Nom FROM T_reparateurs";
			this.oleDbSelectCommand6.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand5
			// 
			this.oleDbUpdateCommand5.CommandText = "UPDATE T_reparateurs SET ID = ?, Nom = ? WHERE (ID = ?) AND (Nom = ? OR ? IS NULL" +
				" AND Nom IS NULL)";
			this.oleDbUpdateCommand5.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 5, "ID"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			// 
			// mtgcComboBox3
			// 
			this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox3.ColumnNum = 1;
			this.mtgcComboBox3.ColumnWidth = "121";
			this.mtgcComboBox3.DisplayMember = "Text";
			this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox3.DropDownWidth = 141;
			this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox3.GridLineHorizontal = false;
			this.mtgcComboBox3.GridLineVertical = false;
			this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox3.Location = new System.Drawing.Point(128, 8);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(432, 21);
			this.mtgcComboBox3.TabIndex = 21;
			this.mtgcComboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox3_KeyDown);
			// 
			// Capteurs
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(770, 520);
			this.ControlBox = false;
			this.Controls.Add(this.mtgcComboBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControlEX1);
			this.Controls.Add(this.btSupprime);
			this.Controls.Add(this.btEnregistre);
			this.Controls.Add(this.btNouveau);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "Capteurs";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Capteurs";
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.tabPageEX2.ResumeLayout(false);
			this.tabPageEX3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{	
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_parc_capteurs"].Rows)
			{
				mtgcComboBox3.Items.Add(new MTGCComboBoxItem(row["chaine"].ToString(),"","",""));
			}
			oleDbDataAdapter2.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_unites_mesure"].Rows)
			{
				mtgcComboBox4.Items.Add(new MTGCComboBoxItem(row["unité"].ToString(),"","",""));
			}
			oleDbDataAdapter6.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_reparateurs"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["ID"].ToString(),"","",""));
			}
			mtgcComboBox2.Items.Add(new MTGCComboBoxItem("Etalonnage","","",""));
			mtgcComboBox2.Items.Add(new MTGCComboBoxItem("Vérification","","",""));
			mtgcComboBox2.SelectedIndex=0;
			
			
		}	

		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			if(Nouveau)
			{
				DataRow newRow = dataSet11.Tables["T_parc_capteurs"].NewRow();
				newRow["Date_MES"]=dateTimePicker2.Value.ToShortDateString();
				string Dernier=null;
				if(dateTimePicker3.Checked)
					Dernier=dateTimePicker3.Value.ToShortDateString();
				else
					Dernier="01/01/1970";
				newRow["Date dernier controle"]=Dernier;
				newRow["Chaine"]=textBox3.Text;
				newRow["val_mes_initiale"]=textBox11.Text;
				newRow["val_mes_limite"]=textBox12.Text;
				newRow["val_actuelle"]=textBox13.Text;
				if(textBox4.TextLength.Equals(0))
					textBox4.Text="?";
				newRow["Serie"]=textBox4.Text;
				if(textBox5.TextLength.Equals(0))
					textBox5.Text="?";
				newRow["Refer"]=textBox5.Text;
				newRow["unite_etal"]=mtgcComboBox4.Text;
				newRow["capacite_nom"]=textBox6.Text;
				newRow["val-etal_vis"]=textBox7.Text;
				newRow["val_etal_devis"]=textBox8.Text;
				newRow["A_M_V"]=textBox9.Text;
				newRow["imp_rot"]=textBox10.Text;
				dataSet11.Tables["t_parc_capteurs"].Rows.Add(newRow);
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				oleDbInsertCommand1.Transaction=Transac;
				try
				{
					oleDbDataAdapter1.Update(dataSet11);
					try
					{
						Transac.Commit();
						Nouveau=false;
					}
					catch(OleDbException excp)
					{
						Transac.Rollback();
						MessageBox.Show(excp.Message);
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
				if(textBox4.Text.Length==0)
					textBox4.Text="?";
				if(textBox5.Text.Length==0)
					textBox5.Text="?";
				if(textBox6.Text.Length==0)
					textBox6.Text="0";
				if(textBox7.Text.Length==0)
					textBox7.Text="0";
				if(textBox8.Text.Length==0)
					textBox8.Text="0";
				if(textBox9.Text.Length==0)
					textBox9.Text="0";
				if(textBox10.Text.Length==0)
					textBox10.Text="0";
				string Dernier=null;
				if(dateTimePicker2.Checked)
					Dernier=dateTimePicker2.Value.ToShortDateString();
				else
					Dernier="01/01/1970";
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				OleDbCommand Comm = new OleDbCommand();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="update t_parc_capteurs set [Date_Mes]='"+dateTimePicker1.Value.ToShortDateString()+"', [Date dernier controle]='"+Dernier+"', chaine='"+textBox3.Text+"', [val_mes_initiale]="+textBox11.Text+", [val_mes_limite]="+textBox12.Text+", [val_actuelle]="+textBox13.Text+", Serie='"+textBox4.Text+"', Refer='"+textBox5.Text+"', [unite_etal]='"+mtgcComboBox4.Text+"', [capacite_nom]='"+textBox6.Text+"', [val-etal_vis]='"+textBox7.Text+"', [val_etal_devis]='"+textBox8.Text+"', [A_M_V]='"+textBox9.Text+"', [imp_rot]='"+textBox10.Text+"' where ID="+textBox14.Text;
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
						MessageBox.Show("Mise à jour terminée");
										
					}
					catch(OleDbException excp)
					{
						Transac.Rollback();
						MessageBox.Show(excp.Message);
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
			mtgcComboBox3.Items.Clear();
			dataSet11.Tables["t_parc_capteurs"].Clear();
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_parc_capteurs"].Rows)
			{
				mtgcComboBox3.Items.Add(new MTGCComboBoxItem(row["chaine"].ToString(),"","",""));
			}
			mtgcComboBox3.SelectedIndex=-1;
			mtgcComboBox4.SelectedIndex=-1;
			dataSet11.Clear();
			oleDbDataAdapter4.Fill(dataSet11);
			oleDbDataAdapter5.Fill(dataSet11);
			dateTimePicker1.Value=DateTime.Now;
			dateTimePicker2.Value=DateTime.Now;
			dateTimePicker3.Value=DateTime.Now;
			dateTimePicker3.Checked=false;
			textBox3.Text="";
			textBox4.Text="";
			textBox5.Text="";
			textBox6.Text="";
			textBox7.Text="";
			textBox8.Text="";
			textBox9.Text="";
			textBox10.Text="";
			textBox11.Text="";
			textBox12.Text="";
			textBox13.Text="";
			textBox14.Text="";
			btSupprime.Enabled=false;
		}

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			Nouveau=true;
			mtgcComboBox3.SelectedIndex=-1;
			mtgcComboBox4.SelectedIndex=-1;
			dataSet11.Clear();
			oleDbDataAdapter4.Fill(dataSet11);
			oleDbDataAdapter5.Fill(dataSet11);
			dateTimePicker1.Value=DateTime.Now;
			dateTimePicker2.Value=DateTime.Now;
			dateTimePicker3.Checked=false;
			mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString("Nm");
			textBox3.Text="";
			textBox3.BackColor=Color.MistyRose;
			btEnregistre.Enabled=true;
			textBox4.Text="";
			textBox5.Text="";
			textBox6.Text="0";
			textBox7.Text="0";
			textBox8.Text="0";
			textBox9.Text="0";
			textBox10.Text="0";
			textBox11.Text="0";
			textBox12.Text="0";
			textBox13.Text="0";
			textBox14.Text="";
			OleDbCommand Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select Max(ID) from t_parc_capteurs";
			oleDbConnection1.Open();
			try
			{
				int IDCapteur=(int)Comm.ExecuteScalar()+1;
				textBox14.Text=IDCapteur.ToString();
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

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			listView1.Items.Add(dateTimePicker1.Value.ToShortDateString());
			listView1.Items[listView1.Items.Count-1].SubItems.Add(textBox16.Text);
			listView1.Items[listView1.Items.Count-1].SubItems.Add(mtgcComboBox1.Text);
			listView1.Items[listView1.Items.Count-1].SubItems.Add(mtgcComboBox2.Text);
			listView1.Items[listView1.Items.Count-1].SubItems.Add(textBox17.Text);
			DataRow newrow = dataSet11.Tables["t_parc_capteurs_fv"].NewRow();
			newrow["id"]=textBox14.Text;
			if(mtgcComboBox2.Text.Equals("Etalonnage"))
				newrow["type_verif"]="1";
			else
				newrow["type_verif"]="2";
			newrow["date_verif"]=dateTimePicker1.Value.ToShortDateString();
			newrow["val_cpt"]=textBox16.Text;
			newrow["responsable"]=mtgcComboBox1.Text;
			if(textBox17.Text.Length.Equals(0))
				newrow["memo"]="?";
			else
				newrow["memo"]=textBox17.Text;
			dataSet11.Tables["t_parc_capteurs_fv"].Rows.Add(newrow);
			try
			{
				oleDbDataAdapter4.Update(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
		}

		private void mtgcComboBox3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				if(mtgcComboBox3.SelectedIndex>=0)
				{
					btEnregistre.Enabled=true;
					btSupprime.Enabled=true;
					Nouveau=false;
					mtgcComboBox4.SelectedIndex=-1;
					dataSet11.Clear();
					oleDbDataAdapter4.Fill(dataSet11);
					oleDbDataAdapter5.Fill(dataSet11);
					dateTimePicker1.Value=DateTime.Now;
					dateTimePicker2.Value=DateTime.Now;
					dateTimePicker2.Checked=false;
					textBox3.Text="";
					textBox4.Text="";
					textBox5.Text="";
					textBox6.Text="";
					textBox7.Text="";
					textBox8.Text="";
					textBox9.Text="";
					textBox10.Text="";
					textBox11.Text="";
					textBox12.Text="";
					textBox13.Text="";
					textBox14.Text="";
					dataSet11.Tables["t_parc_capteurs"].Clear();
					OleDbCommand Comm = new OleDbCommand();
					Comm.CommandText="select * from t_parc_capteurs where chaine='"+mtgcComboBox3.Text+"'";
					Comm.Connection=oleDbConnection1;
					oleDbDataAdapter1.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					if(dataSet11.Tables["t_parc_capteurs"].Rows[0]["Date_MES"].ToString().Length>0)
						dateTimePicker2.Value=System.Convert.ToDateTime(dataSet11.Tables["t_parc_capteurs"].Rows[0]["Date_MES"].ToString());
					if(dataSet11.Tables["t_parc_capteurs"].Rows[0]["Date dernier controle"].ToString().Length>0)
					{
						if(dataSet11.Tables["t_parc_capteurs"].Rows[0]["Date dernier controle"].ToString().Equals("01/01/1970"))
							dateTimePicker3.Checked=false;
						else
							dateTimePicker3.Value=System.Convert.ToDateTime(dataSet11.Tables["t_parc_capteurs"].Rows[0]["Date dernier controle"].ToString());
					}
					textBox3.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["Chaine"].ToString();
					textBox4.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["Serie"].ToString();
					textBox5.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["Refer"].ToString();
					textBox6.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["capacite_nom"].ToString();
					textBox7.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["Val-etal_vis"].ToString();
					textBox8.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["Val_etal_devis"].ToString();
					textBox9.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["A_M_V"].ToString();
					textBox10.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["imp_rot"].ToString();
					textBox11.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["val_mes_initiale"].ToString();
					textBox12.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["val_mes_limite"].ToString();
					textBox13.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["val_actuelle"].ToString();
					textBox16.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["val_actuelle"].ToString();
					textBox14.Text=dataSet11.Tables["t_parc_capteurs"].Rows[0]["ID"].ToString();
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_parc_capteurs"].Rows[0]["unite_etal"].ToString());
					listView1.Items.Clear();
					listView2.Items.Clear();
					foreach(DataRow row in dataSet11.Tables["t_parc_capteurs_fv"].Rows)
					{
						if(row["ID"].ToString().Equals(textBox14.Text))
						{
							if(row["date_verif"].ToString().Length>0)
								listView1.Items.Add(row["date_verif"].ToString().Remove(10,9));
							else
								listView1.Items.Add("");
							listView1.Items[listView1.Items.Count-1].SubItems.Add(row["val_cpt"].ToString());
							listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Responsable"].ToString());
							if(row["type_verif"].ToString().Equals("1"))
								listView1.Items[listView1.Items.Count-1].SubItems.Add("Vérification");
							else
								listView1.Items[listView1.Items.Count-1].SubItems.Add("Etalonnage");
							listView1.Items[listView1.Items.Count-1].SubItems.Add(row["memo"].ToString());
						}
					}
					foreach(DataRow row in dataSet11.Tables["t_parc_capteurs_stats"].Rows)
					{
						if(row["ID_capteur"].ToString().Equals(textBox14.Text))
						{
							listView2.Items.Add(row["chaine"].ToString());
							if(row["date"].ToString().Length>0)
								listView2.Items[listView2.Items.Count-1].SubItems.Add(row["date"].ToString().Remove(10,9));
							else
								listView2.Items[listView2.Items.Count-1].SubItems.Add("");
							listView2.Items[listView2.Items.Count-1].SubItems.Add(row["Controle"].ToString());
							listView2.Items[listView2.Items.Count-1].SubItems.Add(row["machine"].ToString());
							listView2.Items[listView2.Items.Count-1].SubItems.Add(row["nombre"].ToString());
						}
					}
				}
			}
		}

		private void tabControlEX1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(textBox3.TextLength.Equals(0))
				textBox3.Text="?";
			if(Nouveau)
			{
				DataRow newRow = dataSet11.Tables["T_parc_capteurs"].NewRow();
				newRow["Date_MES"]=dateTimePicker2.Value.ToShortDateString();
				string Dernier=null;
				if(dateTimePicker3.Checked)
					Dernier=dateTimePicker3.Value.ToShortDateString();
				else
					Dernier="01/01/1970";
				newRow["Date dernier controle"]=Dernier;
				newRow["Chaine"]=textBox3.Text;
				newRow["val_mes_initiale"]=textBox11.Text;
				newRow["val_mes_limite"]=textBox12.Text;
				newRow["val_actuelle"]=textBox13.Text;
				if(textBox4.TextLength.Equals(0))
					textBox4.Text="?";
				newRow["Serie"]=textBox4.Text;
				if(textBox5.TextLength.Equals(0))
					textBox5.Text="?";
				newRow["Refer"]=textBox5.Text;
				newRow["unite_etal"]=mtgcComboBox4.Text;
				newRow["capacite_nom"]=textBox6.Text;
				newRow["val-etal_vis"]=textBox7.Text;
				newRow["val_etal_devis"]=textBox8.Text;
				newRow["A_M_V"]=textBox9.Text;
				newRow["imp_rot"]=textBox10.Text;
				dataSet11.Tables["t_parc_capteurs"].Rows.Add(newRow);
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				oleDbInsertCommand1.Transaction=Transac;
				try
				{
					oleDbDataAdapter1.Update(dataSet11);
					try
					{
						Transac.Commit();
						Nouveau=false;
					}
					catch(OleDbException excp)
					{
						Transac.Rollback();
						MessageBox.Show(excp.Message);
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

		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Supprimer l'enregistrement ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
			{
				OleDbCommand Comm = new OleDbCommand();
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.CommandText="delete * from t_parc_capteurs where ID="+textBox14.Text;
				Comm.Connection=oleDbConnection1;
				Comm.Transaction=Transac;
				
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
						mtgcComboBox3.Items.Clear();
						dataSet11.Clear();
						oleDbSelectCommand1.CommandText="select chaine from t_parc_capteurs";
						try
						{
							oleDbDataAdapter1.Fill(dataSet11);
						}
						catch(Exception exp)
						{

						}
						foreach(DataRow row in dataSet11.Tables["t_parc_capteurs"].Rows)
						{
							mtgcComboBox3.Items.Add(new MTGCComboBoxItem(row["chaine"].ToString(),"","",""));
						}
						mtgcComboBox3.SelectedIndex=-1;
						mtgcComboBox4.SelectedIndex=-1;
						
						oleDbDataAdapter4.Fill(dataSet11);
						oleDbDataAdapter5.Fill(dataSet11);
						dateTimePicker1.Value=DateTime.Now;
						dateTimePicker2.Value=DateTime.Now;
						dateTimePicker3.Value=DateTime.Now;
						dateTimePicker3.Checked=false;
						textBox3.Text="";
						textBox4.Text="";
						textBox5.Text="";
						textBox6.Text="";
						textBox7.Text="";
						textBox8.Text="";
						textBox9.Text="";
						textBox10.Text="";
						textBox11.Text="";
						textBox12.Text="";
						textBox13.Text="";
						textBox14.Text="";
						btSupprime.Enabled=false;
					}
					catch(OleDbException excp)
					{
						Transac.Rollback();
						MessageBox.Show(excp.Message);
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
}
