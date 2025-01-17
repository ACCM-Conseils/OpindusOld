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
	/// Description résumée de InfoCorres.
	/// </summary>
	public class InfoCorres : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txNom;
		private System.Windows.Forms.TextBox txMel;
		private System.Windows.Forms.TextBox txService;
		private System.Windows.Forms.TextBox txNote;
		private System.Windows.Forms.TextBox txPrenom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txFonction;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txTel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txFax;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button btImprime;
		private System.Windows.Forms.Label label10;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		string Identite;
		string IDR;
		bool Modif;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private bool client;
		private System.Windows.Forms.Button button5;
		private int Agence;

		public InfoCorres(int Agence,bool cli, string Entreprise, string Ident,string Pays)
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
			this.client=cli;
			this.Agence=Agence;
			label10.Text=Entreprise;
			Identite=Ident;
			Modif=false;
			if(Pays!="FRANCE")
			{
				txTel.MaxLength=20;
				txFax.MaxLength=20;
			}

			//
			// TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
			//
		}
		
		public InfoCorres(int Agence,bool cli, string IDRow,string Entreprise, string Ident, string Nom, string Prenom, string Mess, string Tele, string NFax, string Service, string Fonction, string Note,string Pays)
		 {
			 //
			 // Requis pour la prise en charge du Concepteur Windows Forms
			 //
			InitializeComponent();
			this.client=cli;
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
			IDR=IDRow;
			Modif=true;
			Identite=Ident;
			label10.Text=Entreprise;
			button1.Text="Modifier";
			label3.Text="Fiche contact";
			if(Nom!="?")
				txNom.Text=Nom;
			if(Prenom!="?")
				txPrenom.Text=Prenom;
			if(Mess!="?")
				txMel.Text=Mess;
			if(Tele!="?")
				txTel.Text=Tele;
			if(NFax!="?")
				txFax.Text=NFax;
			if(Service!="?")
				txService.Text=Service;
			if(Fonction!="?")
				txFonction.Text=Fonction;
			if(Note!="?")
				txNote.Text=Note;
			if(Pays!="FRANCE")
			{
				txTel.MaxLength=20;
				txFax.MaxLength=20;
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(InfoCorres));
			this.txNom = new System.Windows.Forms.TextBox();
			this.txMel = new System.Windows.Forms.TextBox();
			this.txService = new System.Windows.Forms.TextBox();
			this.txNote = new System.Windows.Forms.TextBox();
			this.txPrenom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txFax = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txTel = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txFonction = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.btImprime = new System.Windows.Forms.Button();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// txNom
			// 
			this.txNom.BackColor = System.Drawing.Color.White;
			this.txNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txNom.Location = new System.Drawing.Point(16, 104);
			this.txNom.Name = "txNom";
			this.txNom.Size = new System.Drawing.Size(328, 20);
			this.txNom.TabIndex = 0;
			this.txNom.Text = "";
			// 
			// txMel
			// 
			this.txMel.BackColor = System.Drawing.Color.White;
			this.txMel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txMel.Location = new System.Drawing.Point(16, 184);
			this.txMel.Name = "txMel";
			this.txMel.Size = new System.Drawing.Size(328, 20);
			this.txMel.TabIndex = 2;
			this.txMel.Text = "";
			// 
			// txService
			// 
			this.txService.BackColor = System.Drawing.Color.White;
			this.txService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txService.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txService.Location = new System.Drawing.Point(16, 312);
			this.txService.Name = "txService";
			this.txService.Size = new System.Drawing.Size(328, 20);
			this.txService.TabIndex = 5;
			this.txService.Text = "";
			// 
			// txNote
			// 
			this.txNote.BackColor = System.Drawing.Color.White;
			this.txNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txNote.Location = new System.Drawing.Point(16, 392);
			this.txNote.Multiline = true;
			this.txNote.Name = "txNote";
			this.txNote.Size = new System.Drawing.Size(328, 88);
			this.txNote.TabIndex = 7;
			this.txNote.Text = "";
			// 
			// txPrenom
			// 
			this.txPrenom.BackColor = System.Drawing.Color.White;
			this.txPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txPrenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txPrenom.Location = new System.Drawing.Point(16, 144);
			this.txPrenom.Name = "txPrenom";
			this.txPrenom.Size = new System.Drawing.Size(328, 20);
			this.txPrenom.TabIndex = 1;
			this.txPrenom.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nom";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(248, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 48);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txFax);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txTel);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txFonction);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.txNom);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txService);
			this.groupBox1.Controls.Add(this.txNote);
			this.groupBox1.Controls.Add(this.txMel);
			this.groupBox1.Controls.Add(this.txPrenom);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 496);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(224, 32);
			this.label10.TabIndex = 18;
			// 
			// txFax
			// 
			this.txFax.BackColor = System.Drawing.Color.White;
			this.txFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txFax.Location = new System.Drawing.Point(16, 264);
			this.txFax.MaxLength = 0;
			this.txFax.Name = "txFax";
			this.txFax.Size = new System.Drawing.Size(184, 20);
			this.txFax.TabIndex = 4;
			this.txFax.Text = "";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 248);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 16;
			this.label9.Text = "Fax";
			// 
			// txTel
			// 
			this.txTel.BackColor = System.Drawing.Color.White;
			this.txTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txTel.Location = new System.Drawing.Point(16, 224);
			this.txTel.MaxLength = 10;
			this.txTel.Name = "txTel";
			this.txTel.Size = new System.Drawing.Size(184, 20);
			this.txTel.TabIndex = 3;
			this.txTel.Text = "";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 208);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 14;
			this.label8.Text = "Téléphone";
			// 
			// txFonction
			// 
			this.txFonction.BackColor = System.Drawing.Color.White;
			this.txFonction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txFonction.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txFonction.Location = new System.Drawing.Point(16, 352);
			this.txFonction.Name = "txFonction";
			this.txFonction.Size = new System.Drawing.Size(328, 20);
			this.txFonction.TabIndex = 6;
			this.txFonction.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(16, 336);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Fonction";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 376);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Note";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Service";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "Adresse de messagerie";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nouveau correspondant";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Prénom";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lavender;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(24, 520);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Enregistrer";
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
																										new System.Data.Common.DataTableMapping("Table", "T_clients_Coressp", new System.Data.Common.DataColumnMapping[] {
																																																							 new System.Data.Common.DataColumnMapping("Cle", "Cle"),
																																																							 new System.Data.Common.DataColumnMapping("E_mail", "E_mail"),
																																																							 new System.Data.Common.DataColumnMapping("Fonction", "Fonction"),
																																																							 new System.Data.Common.DataColumnMapping("Ident", "Ident"),
																																																							 new System.Data.Common.DataColumnMapping("Memo", "Memo"),
																																																							 new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																							 new System.Data.Common.DataColumnMapping("Prenom", "Prenom"),
																																																							 new System.Data.Common.DataColumnMapping("Service", "Service"),
																																																							 new System.Data.Common.DataColumnMapping("telecopie", "telecopie"),
																																																							 new System.Data.Common.DataColumnMapping("Telephone", "Telephone")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM T_clients_Coressp WHERE (Cle = ?) AND (E_mail = ? OR ? IS NULL AND E_mail IS NULL) AND (Fonction = ? OR ? IS NULL AND Fonction IS NULL) AND (Ident = ? OR ? IS NULL AND Ident IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Prenom = ? OR ? IS NULL AND Prenom IS NULL) AND (Service = ? OR ? IS NULL AND Service IS NULL) AND (Telephone = ? OR ? IS NULL AND Telephone IS NULL) AND (telecopie = ? OR ? IS NULL AND telecopie IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_clients_Coressp(E_mail, Fonction, Ident, [Memo], Nom, Prenom, Servi" +
				"ce, telecopie, Telephone) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, "E_mail"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, "Fonction"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 100, "Nom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, "Prenom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Service", System.Data.OleDb.OleDbType.VarWChar, 50, "Service"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Cle, E_mail, Fonction, Ident, [Memo], Nom, Prenom, Service, telecopie, Tel" +
				"ephone FROM T_clients_Coressp";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE T_clients_Coressp SET E_mail = ?, Fonction = ?, Ident = ?, [Memo] = ?, Nom = ?, Prenom = ?, Service = ?, telecopie = ?, Telephone = ? WHERE (Cle = ?) AND (E_mail = ? OR ? IS NULL AND E_mail IS NULL) AND (Fonction = ? OR ? IS NULL AND Fonction IS NULL) AND (Ident = ? OR ? IS NULL AND Ident IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Prenom = ? OR ? IS NULL AND Prenom IS NULL) AND (Service = ? OR ? IS NULL AND Service IS NULL) AND (Telephone = ? OR ? IS NULL AND Telephone IS NULL) AND (telecopie = ? OR ? IS NULL AND telecopie IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, "E_mail"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, "Fonction"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 100, "Nom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, "Prenom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Service", System.Data.OleDb.OleDbType.VarWChar, 50, "Service"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// btImprime
			// 
			this.btImprime.BackColor = System.Drawing.Color.Lavender;
			this.btImprime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btImprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btImprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btImprime.ForeColor = System.Drawing.Color.Blue;
			this.btImprime.Location = new System.Drawing.Point(136, 520);
			this.btImprime.Name = "btImprime";
			this.btImprime.Size = new System.Drawing.Size(100, 23);
			this.btImprime.TabIndex = 10;
			this.btImprime.Text = "Imprimer";
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM T_fournisseurs_Corresp WHERE (Cle = ?) AND (Code = ? OR ? IS NULL AND Code IS NULL) AND (E_mail = ? OR ? IS NULL AND E_mail IS NULL) AND (Fonction = ? OR ? IS NULL AND Fonction IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Prenom = ? OR ? IS NULL AND Prenom IS NULL) AND (Service = ? OR ? IS NULL AND Service IS NULL) AND (Telecopie = ? OR ? IS NULL AND Telecopie IS NULL) AND (Telephone = ? OR ? IS NULL AND Telephone IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO T_fournisseurs_Corresp(Code, E_mail, Fonction, [Memo], Nom, Prenom, S" +
				"ervice, Telecopie, Telephone) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, "E_mail"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, "Fonction"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, "Prenom"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Service", System.Data.OleDb.OleDbType.VarWChar, 50, "Service"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Cle, Code, E_mail, Fonction, [Memo], Nom, Prenom, Service, Telecopie, Tele" +
				"phone FROM T_fournisseurs_Corresp";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE T_fournisseurs_Corresp SET Code = ?, E_mail = ?, Fonction = ?, [Memo] = ?, Nom = ?, Prenom = ?, Service = ?, Telecopie = ?, Telephone = ? WHERE (Cle = ?) AND (Code = ? OR ? IS NULL AND Code IS NULL) AND (E_mail = ? OR ? IS NULL AND E_mail IS NULL) AND (Fonction = ? OR ? IS NULL AND Fonction IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Prenom = ? OR ? IS NULL AND Prenom IS NULL) AND (Service = ? OR ? IS NULL AND Service IS NULL) AND (Telecopie = ? OR ? IS NULL AND Telecopie IS NULL) AND (Telephone = ? OR ? IS NULL AND Telephone IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, "E_mail"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, "Fonction"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, "Prenom"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Service", System.Data.OleDb.OleDbType.VarWChar, 50, "Service"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_mail1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fonction1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prenom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Service1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(320, 512);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 17;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// InfoCorres
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(376, 568);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btImprime);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "InfoCorres";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Informations correspondant";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int error=0;
			if(txNom.TextLength.Equals(0))
			{
				txNom.BackColor=Color.MistyRose;
				error=1;
				MessageBox.Show("Champ nom obligatoire","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
				txNom.BackColor=Color.Empty;
			if(error.Equals(0))
			{
				if(client)
				{
					oleDbConnection1.Open();
					oleDbDataAdapter1.Fill(dataSet11);
					bool Trouve=false;
					if(!Modif)
					{
						DataTable Table = dataSet11.Tables["T_clients_coressp"];
						foreach(DataRow row in Table.Rows)
						{
							if(row["Nom"].ToString().Equals(txNom.Text.ToUpper())&&row["Ident"].ToString().Equals(Identite)&&row["Prenom"].ToString().Equals(txPrenom.Text.ToUpper()))
							{
								if(MessageBox.Show("Client déjà présent dans la base, modifier ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
								{
									IDR=row["Cle"].ToString();
									Trouve=true;
								}
								else
								{
									Trouve=true;
									break;
								}
							}
						}
						if(!Trouve)
						{
							DataRow newrow = Table.NewRow();
							if(txNom.Text.Length.Equals(0))
								newrow["Nom"]="?";
							else
								newrow["Nom"]=txNom.Text.ToUpper();
							if(txPrenom.Text.Length.Equals(0))
								newrow["Prenom"]="?";
							else
								newrow["Prenom"]=txPrenom.Text.ToUpper();
							if(txMel.Text.Length.Equals(0))
								newrow["E_mail"]="?";
							else
								newrow["E_mail"]=txMel.Text.ToUpper();
							if(txTel.Text.Length.Equals(0))
								newrow["Telephone"]="?";
							else
								newrow["Telephone"]=txTel.Text.ToUpper();
							if(txFax.Text.Length.Equals(0))
								newrow["Telecopie"]="?";
							else
								newrow["Telecopie"]=txFax.Text.ToUpper();
							if(txService.Text.Length.Equals(0))
								newrow["Service"]="?";
							else
								newrow["Service"]=txService.Text.ToUpper();
							if(txFonction.Text.Length.Equals(0))
								newrow["Fonction"]="?";
							else
								newrow["Fonction"]=txFonction.Text.ToUpper();
							if(txNote.Text.Length.Equals(0))
								newrow["Memo"]="?";
							else
								newrow["Memo"]=txNote.Text.ToUpper();
							newrow["Ident"]=System.Convert.ToInt32(Identite,10);
							Table.Rows.Add(newrow);
							try
							{
								oleDbDataAdapter1.Update(dataSet11);
								MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
							}
							catch(OleDbException exep)
							{
								MessageBox.Show(exep.Message);
							}		
						}
					}
					else if(Modif||Trouve)
					{
						OleDbCommand Comm = new OleDbCommand();
						Comm.Connection=oleDbConnection1;
						string Nom;
						string Prenom;
						string E_Mail;
						string Telephone;
						string Telecopie;
						string Service;
						string Fonction;
						string Memo;
						if(txNom.Text.Length.Equals(0))
							Nom="?";
						else
							Nom=txNom.Text.ToUpper();
						if(txPrenom.Text.Length.Equals(0))
							Prenom="?";
						else
							Prenom=txPrenom.Text.ToUpper();
						if(txMel.Text.Length.Equals(0))
							E_Mail="?";
						else
							E_Mail=txMel.Text.ToUpper();
						if(txTel.Text.Length.Equals(0))
							Telephone="?";
						else
							Telephone=txTel.Text.ToUpper();
						if(txFax.Text.Length.Equals(0))
							Telecopie="?";
						else
							Telecopie=txFax.Text.ToUpper();
						if(txService.Text.Length.Equals(0))
							Service="?";
						else
							Service=txService.Text.ToUpper();
						if(txFonction.Text.Length.Equals(0))
							Fonction="?";
						else
							Fonction=txFonction.Text.ToUpper();
						if(txNote.Text.Length.Equals(0))
							Memo="?";
						else
							Memo=txNote.Text.ToUpper();
						Comm.CommandText = "UPDATE T_clients_Coressp SET Nom='"+Nom+"',Prenom='"+Prenom+"',Service='"+Service+"',Fonction='"+Fonction+"',Telephone='"+Telephone+"',telecopie='"+Telecopie+"',E_Mail ='"+E_Mail+"'WHERE Cle="+System.Convert.ToInt32(IDR);
						try
						{
							Comm.ExecuteNonQuery();
							MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
					}
					oleDbConnection1.Close();
				}
				if(!client)
				{
					oleDbConnection1.Open();
					oleDbDataAdapter2.Fill(dataSet11);
					bool Trouve=false;
					if(!Modif)
					{
						DataTable Table = dataSet11.Tables["T_fournisseurs_corresp"];
						foreach(DataRow row in Table.Rows)
						{
							if(row["Nom"].ToString().Equals(txNom.Text.ToUpper())&&row["Code"].ToString().Equals(Identite)&&row["Prenom"].ToString().Equals(txPrenom.Text.ToUpper()))
							{
								if(MessageBox.Show("Client déjà présent dans la base, modifier ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
								{
									IDR=row["Cle"].ToString();
									Trouve=true;
								}
								else
								{
									Trouve=true;
									break;
								}
							}
						}
						if(!Trouve)
						{
							DataRow newrow = Table.NewRow();
							if(txNom.Text.Length.Equals(0))
								newrow["Nom"]="?";
							else
								newrow["Nom"]=txNom.Text.ToUpper();
							if(txPrenom.Text.Length.Equals(0))
								newrow["Prenom"]="?";
							else
								newrow["Prenom"]=txPrenom.Text.ToUpper();
							if(txMel.Text.Length.Equals(0))
								newrow["E_mail"]="?";
							else
								newrow["E_mail"]=txMel.Text.ToUpper();
							if(txTel.Text.Length.Equals(0))
								newrow["Telephone"]="?";
							else
								newrow["Telephone"]=txTel.Text.ToUpper();
							if(txFax.Text.Length.Equals(0))
								newrow["Telecopie"]="?";
							else
								newrow["Telecopie"]=txFax.Text.ToUpper();
							if(txService.Text.Length.Equals(0))
								newrow["Service"]="?";
							else
								newrow["Service"]=txService.Text.ToUpper();
							if(txFonction.Text.Length.Equals(0))
								newrow["Fonction"]="?";
							else
								newrow["Fonction"]=txFonction.Text.ToUpper();
							if(txNote.Text.Length.Equals(0))
								newrow["Memo"]="?";
							else
								newrow["Memo"]=txNote.Text.ToUpper();
							newrow["Code"]=Identite;
							Table.Rows.Add(newrow);
							try
							{
								oleDbDataAdapter2.Update(dataSet11);
								MessageBox.Show("Enregistrement terminé","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
							}
							catch(OleDbException exep)
							{
								MessageBox.Show(exep.Message);
							}		
						}
					}
					else if(Modif||Trouve)
					{
						OleDbCommand Comm = new OleDbCommand();
						Comm.Connection=oleDbConnection1;
						string Nom;
						string Prenom;
						string E_Mail;
						string Telephone;
						string Telecopie;
						string Service;
						string Fonction;
						string Memo;
						if(txNom.Text.Length.Equals(0))
							Nom="?";
						else
							Nom=txNom.Text.ToUpper();
						if(txPrenom.Text.Length.Equals(0))
							Prenom="?";
						else
							Prenom=txPrenom.Text.ToUpper();
						if(txMel.Text.Length.Equals(0))
							E_Mail="?";
						else
							E_Mail=txMel.Text.ToUpper();
						if(txTel.Text.Length.Equals(0))
							Telephone="?";
						else
							Telephone=txTel.Text.ToUpper();
						if(txFax.Text.Length.Equals(0))
							Telecopie="?";
						else
							Telecopie=txFax.Text.ToUpper();
						if(txService.Text.Length.Equals(0))
							Service="?";
						else
							Service=txService.Text.ToUpper();
						if(txFonction.Text.Length.Equals(0))
							Fonction="?";
						else
							Fonction=txFonction.Text.ToUpper();
						if(txNote.Text.Length.Equals(0))
							Memo="?";
						else
							Memo=txNote.Text.ToUpper();
						Comm.CommandText = "UPDATE T_fournisseurs_corresp SET Nom='"+Nom+"',Prenom='"+Prenom+"',Service='"+Service+"',Fonction='"+Fonction+"',Telephone='"+Telephone+"',telecopie='"+Telecopie+"',E_Mail ='"+E_Mail+"'WHERE Cle="+System.Convert.ToInt32(IDR);
						try
						{
							Comm.ExecuteNonQuery();
							MessageBox.Show("Mise à jour terminée","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
					}
					oleDbConnection1.Close();
				}
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
