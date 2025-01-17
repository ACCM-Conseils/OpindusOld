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
	/// Description résumée de EntreeSortie.
	/// </summary>
	public class EntreeSortie : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private int Agence;
		private System.Windows.Forms.TextBox textBox8;
		private MTGCComboBox mtgcComboBox1;
		private MTGCComboBox mtgcComboBox2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private DataRow Piece;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private MTGCComboBox mtgcComboBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EntreeSortie(int Agence)
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
			//
			// TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EntreeSortie));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.mtgcComboBox3);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.mtgcComboBox2);
			this.groupBox1.Controls.Add(this.mtgcComboBox1);
			this.groupBox1.Controls.Add(this.textBox8);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(696, 160);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(296, 120);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 51;
			this.textBox2.Text = "textBox2";
			this.textBox2.Visible = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 50;
			this.label5.Text = "Type";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.mtgcComboBox3.Location = new System.Drawing.Point(24, 80);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(88, 21);
			this.mtgcComboBox3.TabIndex = 49;
			this.mtgcComboBox3.TabStop = false;
			this.mtgcComboBox3.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox3_SelectedIndexChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(568, 32);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
			this.dateTimePicker1.TabIndex = 48;
			this.dateTimePicker1.TabStop = false;
			// 
			// mtgcComboBox2
			// 
			this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox2.ColumnNum = 3;
			this.mtgcComboBox2.ColumnWidth = "150;100;200";
			this.mtgcComboBox2.DisplayMember = "Text";
			this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox2.DropDownWidth = 470;
			this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox2.GridLineHorizontal = false;
			this.mtgcComboBox2.GridLineVertical = true;
			this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox2.Location = new System.Drawing.Point(160, 32);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(121, 21);
			this.mtgcComboBox2.TabIndex = 1;
			this.mtgcComboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox2_KeyDown);
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 2;
			this.mtgcComboBox1.ColumnWidth = "50;200";
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(24, 32);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(121, 21);
			this.mtgcComboBox1.TabIndex = 0;
			this.mtgcComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox1_KeyDown);
			// 
			// textBox8
			// 
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(120, 80);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(64, 20);
			this.textBox8.TabIndex = 3;
			this.textBox8.Text = "0";
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
			this.textBox8.Enter += new System.EventHandler(this.textBox8_Enter);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Blue;
			this.button4.Location = new System.Drawing.Point(492, 120);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(176, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Générer le mouvement";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(596, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(68, 16);
			this.label11.TabIndex = 43;
			this.label11.Text = "Dispo";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(508, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 16);
			this.label10.TabIndex = 42;
			this.label10.Text = "Réserve";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(420, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 16);
			this.label9.TabIndex = 41;
			this.label9.Text = "Commande";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox7
			// 
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(596, 80);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(72, 20);
			this.textBox7.TabIndex = 40;
			this.textBox7.TabStop = false;
			this.textBox7.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(508, 80);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(72, 20);
			this.textBox6.TabIndex = 39;
			this.textBox6.TabStop = false;
			this.textBox6.Text = "";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(324, 65);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 15);
			this.label8.TabIndex = 38;
			this.label8.Text = "Théorique";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(228, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 16);
			this.label7.TabIndex = 37;
			this.label7.Text = "Réel";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(420, 80);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(72, 20);
			this.textBox5.TabIndex = 36;
			this.textBox5.TabStop = false;
			this.textBox5.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(324, 80);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(80, 20);
			this.textBox4.TabIndex = 35;
			this.textBox4.TabStop = false;
			this.textBox4.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(228, 80);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(80, 20);
			this.textBox3.TabIndex = 34;
			this.textBox3.TabStop = false;
			this.textBox3.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(568, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 28;
			this.label4.Text = "Date mouvement";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(296, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(256, 20);
			this.textBox1.TabIndex = 27;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(300, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 26;
			this.label3.Text = "Désignation";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(160, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 25;
			this.label2.Text = "Code pièce";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 23;
			this.label1.Text = "Ident";
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
																																																							  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							  new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																							  new System.Data.Common.DataColumnMapping("Identificateur", "Identificateur")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_pieces_detachees WHERE (Identificateur = ?) AND (Code = ? OR ? IS N" +
				"ULL AND Code IS NULL) AND (Designation = ? OR ? IS NULL AND Designation IS NULL)" +
				"";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Identificateur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Identificateur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_pieces_detachees(Code, Designation, Identificateur) VALUES (?, ?, ?" +
				")";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 18, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Identificateur", System.Data.OleDb.OleDbType.Integer, 0, "Identificateur"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Code, Designation, Identificateur FROM T_pieces_detachees ORDER BY Identif" +
				"icateur";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_pieces_detachees SET Code = ?, Designation = ?, Identificateur = ? WHERE" +
				" (Identificateur = ?) AND (Code = ? OR ? IS NULL AND Code IS NULL) AND (Designat" +
				"ion = ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 18, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Identificateur", System.Data.OleDb.OleDbType.Integer, 0, "Identificateur"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Identificateur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Identificateur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(664, 176);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 48);
			this.button3.TabIndex = 27;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// EntreeSortie
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(728, 232);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "EntreeSortie";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Entrées et sorties";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_pieces_detachees"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["identificateur"].ToString(),row["Designation"].ToString(),"","")) ;
			}
			oleDbDataAdapter1.SelectCommand.CommandText="SELECT Code, Designation, Identificateur FROM T_pieces_detachees ORDER BY Code";
			dataSet11.Tables["t_pieces_detachees"].Clear();
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_pieces_detachees"].Rows)
			{
				mtgcComboBox2.Items.Add(new MTGCComboBoxItem(row["Code"].ToString(),row["Identificateur"].ToString(),row["Designation"].ToString(),""));
			}
			mtgcComboBox1.SelectedIndex=-1;
			mtgcComboBox2.SelectedIndex=-1;
			dateTimePicker1.Value=DateTime.Now;
			mtgcComboBox3.Items.Add(new MTGCComboBoxItem("Entrée","","",""));
			mtgcComboBox3.Items.Add(new MTGCComboBoxItem("Sortie","","",""));
			mtgcComboBox3.SelectedIndex=0;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if(textBox8.Text.Equals("0"))
				MessageBox.Show("Aucun mouvement à générer");
			else
			{
				oleDbConnection1.Open();
				OleDbCommand Comm = new OleDbCommand();
				Comm.CommandText = "update t_pieces_detachees set [quantite stock]="+System.Convert.ToInt32(textBox3.Text)+", [quantite stock theorique]="+System.Convert.ToInt32(textBox4.Text)+", [Quantite disponible]="+System.Convert.ToInt32(textBox7.Text)+", [date dernier mouvement]='"+dateTimePicker1.Value.ToShortDateString()+"' where identificateur ="+Piece["identificateur"].ToString();
				Comm.Connection=oleDbConnection1;
				try
				{
					Comm.ExecuteNonQuery();
					MessageBox.Show("Mouvement généré");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				oleDbConnection1.Close();
				mtgcComboBox1.SelectedIndex=-1;
				mtgcComboBox2.SelectedIndex=-1;
				mtgcComboBox3.SelectedIndex=0;
				textBox1.Clear();
				textBox3.Clear();
				textBox4.Clear();
				textBox5.Clear();
				textBox6.Clear();
				textBox7.Clear();
				textBox8.Clear();
			}
		}

		private void textBox8_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				int x = Int32.Parse(textBox8.Text);
				errorProvider1.SetError(textBox8,"");
				if(textBox8.TextLength>0)
				{
					if(mtgcComboBox3.Text.Equals("Entrée"))
					{
						int stockReel=System.Convert.ToInt32(Piece["quantite stock"].ToString());
						int stockTheo=System.Convert.ToInt32(Piece["quantite stock theorique"].ToString());
						int stockDispo=System.Convert.ToInt32(Piece["quantite disponible"].ToString());
						stockReel+=System.Convert.ToInt32(textBox8.Text);
						stockTheo+=System.Convert.ToInt32(textBox8.Text);
						stockDispo+=System.Convert.ToInt32(textBox8.Text);
						textBox3.Text=stockReel.ToString();
						textBox4.Text=stockTheo.ToString();
						textBox7.Text=stockDispo.ToString();
					}
					else if(mtgcComboBox3.Text.Equals("Sortie"))
					{
						int stockReel=System.Convert.ToInt32(Piece["quantite stock"].ToString());
						int stockTheo=System.Convert.ToInt32(Piece["quantite stock theorique"].ToString());
						int stockDispo=System.Convert.ToInt32(Piece["quantite disponible"].ToString());
						stockReel-=System.Convert.ToInt32(textBox8.Text);
						stockTheo-=System.Convert.ToInt32(textBox8.Text);
						stockDispo-=System.Convert.ToInt32(textBox8.Text);
						textBox3.Text=stockReel.ToString();
						textBox4.Text=stockTheo.ToString();
						textBox7.Text=stockDispo.ToString();
					}
				}

			}
			catch(Exception exp)
			{
				errorProvider1.SetError(textBox8,"Entree invalide");
			}
			
		}

		private void mtgcComboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(textBox8.TextLength>0&&(mtgcComboBox1.SelectedIndex!=-1||mtgcComboBox2.SelectedIndex!=-1))
			{
				if(mtgcComboBox3.Text.Equals("Entrée"))
				{
					int stockReel=System.Convert.ToInt32(Piece["quantite stock"].ToString());
					int stockTheo=System.Convert.ToInt32(Piece["quantite stock theorique"].ToString());
					int stockDispo=System.Convert.ToInt32(Piece["quantite disponible"].ToString());
					stockReel+=System.Convert.ToInt32(textBox8.Text);
					stockTheo+=System.Convert.ToInt32(textBox8.Text);
					stockDispo+=System.Convert.ToInt32(textBox8.Text);
					textBox3.Text=stockReel.ToString();
					textBox4.Text=stockTheo.ToString();
					textBox7.Text=stockDispo.ToString();
				}
				else if(mtgcComboBox3.Text.Equals("Sortie"))
				{
					int stockReel=System.Convert.ToInt32(Piece["quantite stock"].ToString());
					int stockTheo=System.Convert.ToInt32(Piece["quantite stock theorique"].ToString());
					int stockDispo=System.Convert.ToInt32(Piece["quantite disponible"].ToString());
					stockReel-=System.Convert.ToInt32(textBox8.Text);
					stockTheo-=System.Convert.ToInt32(textBox8.Text);
					stockDispo-=System.Convert.ToInt32(textBox8.Text);
					textBox3.Text=stockReel.ToString();
					textBox4.Text=stockTheo.ToString();
					textBox7.Text=stockDispo.ToString();
				}
			}
		}

		private void textBox8_Enter(object sender, System.EventArgs e)
		{
			textBox8.Select(0,textBox8.TextLength);
		}

		private void button3_Click_1(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void mtgcComboBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				if(mtgcComboBox2.SelectedIndex>=0)
				{
					oleDbDataAdapter1.SelectCommand.CommandText="select * from t_pieces_detachees where code='"+mtgcComboBox2.Text+"'";
					dataSet11.Tables["T_pieces_detachees"].Clear();
					oleDbDataAdapter1.Fill(dataSet11);
					Piece = dataSet11.Tables["T_pieces_detachees"].Rows[0];
					textBox1.Text=Piece["Designation"].ToString();
					textBox3.Text=Piece["Quantite stock"].ToString();
					textBox4.Text=Piece["Quantite stock theorique"].ToString();
					textBox5.Text=Piece["Quantite commande"].ToString();
					textBox6.Text=Piece["Quantite reserve"].ToString();
					textBox7.Text=Piece["Quantite disponible"].ToString();
					textBox2.Text=Piece["Identificateur"].ToString();
					mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindString(Piece["Identificateur"].ToString());
				}
			}
		}

		private void mtgcComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				if(mtgcComboBox1.SelectedIndex>=0)
				{
					oleDbDataAdapter1.SelectCommand.CommandText="select * from t_pieces_detachees where identificateur="+mtgcComboBox1.Text;
					dataSet11.Tables["T_pieces_detachees"].Clear();
					oleDbDataAdapter1.Fill(dataSet11);
					Piece = dataSet11.Tables["T_pieces_detachees"].Rows[0];
					textBox1.Text=Piece["Designation"].ToString();
					textBox3.Text=Piece["Quantite stock"].ToString();
					textBox4.Text=Piece["Quantite stock theorique"].ToString();
					textBox5.Text=Piece["Quantite commande"].ToString();
					textBox6.Text=Piece["Quantite reserve"].ToString();
					textBox7.Text=Piece["Quantite disponible"].ToString();
					textBox2.Text=Piece["Identificateur"].ToString();
					mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(Piece["Code"].ToString());
				}
			}

		}

	}
}
