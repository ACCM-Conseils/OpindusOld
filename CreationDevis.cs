using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Data.OleDb;

namespace Opindus
{
	/// <summary>
	/// Description résumée de CreationDevis.
	/// </summary>
	public class CreationDevis : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txTroncon;
		private System.Windows.Forms.TextBox txOrdre;
		private System.Windows.Forms.TextBox txComptable;
		private System.Windows.Forms.TextBox txCommande;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.TextBox txNumDevis;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txDate;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
		private System.Windows.Forms.TextBox txCodeClient;
		private System.Windows.Forms.TextBox txNomClient;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter6;
		private System.Windows.Forms.TextBox txType;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter7;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter8;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter9;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter10;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter11;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox4;
		private int Agence;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter12;
		private System.Windows.Forms.Button button3;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand8;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand8;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand8;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand8;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand9;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand9;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand9;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand9;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand10;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand10;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand10;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand10;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand11;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand11;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand11;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand11;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand12;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand12;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand12;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand12;
		private MTGCComboBox mtgcComboBox1;
		private MTGCComboBox mtgcComboBox2;
		private MTGCComboBox mtgcComboBox3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private MTGCComboBox mtgcComboBox4;
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private OleDbTransaction Transac;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CreationDevis(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			this.Cursor=Cursors.Default;
			InitializeComponent();

			DataAD=new OleDbDataAdapter();
			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			ds=new DataSet();

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
			
			txDate.Text=DateTime.Now.ToShortDateString();
			radioButton1.Checked=true;

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

		private void InitializeData()
		{
			Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], T_parc_machine.[Type machine], T_clients.Nom, T_clients.Ville FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] ORDER BY T_parc_machine.[Code machine Opindus]";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"T_parc_machine");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			mtgcComboBox4.SourceDataTable = ds.Tables["T_parc_machine"];
			mtgcComboBox4.SourceDataString = new string[]{"Code Machine Opindus","Type machine","Nom","ville"};
			mtgcComboBox4.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox4.SelectedIndex=0;
			ds.Tables["t_parc_machine"].Clear();

			Comm.CommandText="select Code, designation from t_emplacement_atelier order by Code";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_emplacement_atelier");

			mtgcComboBox3.SourceDataTable = ds.Tables["t_emplacement_atelier"];
			mtgcComboBox3.SourceDataString = new string[]{"Code","designation","",""};
			mtgcComboBox3.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox3.SelectedIndex=0;

			ds.Tables["t_emplacement_atelier"].Clear();

			Comm.CommandText="SELECT Code, Designation FROM T_causes_clients";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_causes_clients");
			
			mtgcComboBox1.SourceDataTable = ds.Tables["t_causes_clients"];
			mtgcComboBox1.SourceDataString = new string[]{"Code","designation","",""};

			ds.Tables["t_causes_clients"].Clear();

			Comm.CommandText="SELECT Code, Designation FROM T_causes_atelier";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"T_causes_atelier");

			mtgcComboBox2.SourceDataTable = ds.Tables["t_causes_atelier"];
			mtgcComboBox2.SourceDataString = new string[]{"Code","designation","",""};

			ds.Tables["t_causes_atelier"].Clear();

			mtgcComboBox2.SelectedIndex=0;
			mtgcComboBox1.SelectedIndex=0;

			Comm.CommandText="SELECT Max(T_devis_entete.[N° Devis]) AS [MaxDevis] FROM T_devis_entete";
			int NumDevis=0;
			oleDbConnection1.Open();
			NumDevis=(int)Comm.ExecuteScalar();
			oleDbConnection1.Close();
			NumDevis++;
			txNumDevis.Text=NumDevis.ToString();


			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select * from t_avancement order by id";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_avancement");
			textBox4.Text=ds.Tables["t_avancement"].Rows[0]["Libelle"].ToString();
			radioButton1.Checked=true;
			ds.Tables["t_avancement"].Clear();
		}
		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CreationDevis));
			this.button6 = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txCommande = new System.Windows.Forms.TextBox();
			this.txComptable = new System.Windows.Forms.TextBox();
			this.txOrdre = new System.Windows.Forms.TextBox();
			this.txTroncon = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mtgcComboBox4 = new MTGCComboBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txType = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txNomClient = new System.Windows.Forms.TextBox();
			this.txCodeClient = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dataSet11 = new Opindus.DataSet1();
			this.txNumDevis = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txDate = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter5 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter6 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter7 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter8 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter9 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand9 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand9 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand9 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand9 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter10 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand10 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand10 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand10 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand10 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter11 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand11 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand11 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand11 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand11 = new System.Data.OleDb.OleDbCommand();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.oleDbDataAdapter12 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand12 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand12 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand12 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand12 = new System.Data.OleDb.OleDbCommand();
			this.button3 = new System.Windows.Forms.Button();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.tabPageEX2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Lavender;
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Location = new System.Drawing.Point(224, 448);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(31, 21);
			this.button6.TabIndex = 21;
			this.button6.TabStop = false;
			this.button6.Text = "...";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label18.Location = new System.Drawing.Point(152, 336);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(174, 16);
			this.label18.TabIndex = 20;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label17.Location = new System.Drawing.Point(152, 252);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(178, 18);
			this.label17.TabIndex = 19;
			// 
			// txCommande
			// 
			this.txCommande.BackColor = System.Drawing.Color.White;
			this.txCommande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCommande.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txCommande.Location = new System.Drawing.Point(648, 448);
			this.txCommande.Name = "txCommande";
			this.txCommande.TabIndex = 11;
			this.txCommande.Text = "XXX";
			// 
			// txComptable
			// 
			this.txComptable.BackColor = System.Drawing.Color.White;
			this.txComptable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txComptable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txComptable.Location = new System.Drawing.Point(520, 448);
			this.txComptable.Name = "txComptable";
			this.txComptable.TabIndex = 10;
			this.txComptable.Text = "?";
			// 
			// txOrdre
			// 
			this.txOrdre.BackColor = System.Drawing.Color.White;
			this.txOrdre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txOrdre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txOrdre.Location = new System.Drawing.Point(392, 448);
			this.txOrdre.Name = "txOrdre";
			this.txOrdre.TabIndex = 9;
			this.txOrdre.Text = "XXX";
			// 
			// txTroncon
			// 
			this.txTroncon.BackColor = System.Drawing.Color.White;
			this.txTroncon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txTroncon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txTroncon.Location = new System.Drawing.Point(272, 448);
			this.txTroncon.Name = "txTroncon";
			this.txTroncon.Size = new System.Drawing.Size(90, 20);
			this.txTroncon.TabIndex = 8;
			this.txTroncon.Text = "?";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(648, 424);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "N° Commande ouverte";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(520, 424);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Imput. Comptable";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox2.Location = new System.Drawing.Point(373, 328);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(371, 48);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "?";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox1.Location = new System.Drawing.Point(373, 248);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(371, 48);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "?";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(392, 424);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Ordre Travail";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(272, 424);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "N° Tronçon";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 424);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Emplacement";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 312);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cause Atelier";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 229);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Cause client";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox3.Controls.Add(this.radioButton3);
			this.groupBox3.Controls.Add(this.radioButton2);
			this.groupBox3.Controls.Add(this.radioButton1);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Location = new System.Drawing.Point(16, 171);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(896, 48);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// radioButton3
			// 
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(326, 16);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "Contrôle";
			// 
			// radioButton2
			// 
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(232, 16);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "Garantie";
			// 
			// radioButton1
			// 
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(127, 15);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Réparation";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(16, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 16);
			this.label13.TabIndex = 0;
			this.label13.Text = "Type devis";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Location = new System.Drawing.Point(720, 7);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(192, 169);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Lavender;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(31, 32);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(131, 23);
			this.button4.TabIndex = 0;
			this.button4.TabStop = false;
			this.button4.Text = "Voir pré-devis";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.mtgcComboBox4);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.txType);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.txNomClient);
			this.groupBox1.Controls.Add(this.txCodeClient);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Location = new System.Drawing.Point(16, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(704, 169);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// mtgcComboBox4
			// 
			this.mtgcComboBox4.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox4.ColumnNum = 4;
			this.mtgcComboBox4.ColumnWidth = "200;200;200;200";
			this.mtgcComboBox4.DisplayMember = "Text";
			this.mtgcComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox4.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox4.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox4.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox4.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox4.DropDownWidth = 820;
			this.mtgcComboBox4.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox4.GridLineHorizontal = false;
			this.mtgcComboBox4.GridLineVertical = true;
			this.mtgcComboBox4.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox4.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox4.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox4.Location = new System.Drawing.Point(104, 13);
			this.mtgcComboBox4.ManagingFastMouseMoving = true;
			this.mtgcComboBox4.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox4.Name = "mtgcComboBox4";
			this.mtgcComboBox4.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox4.Size = new System.Drawing.Size(320, 21);
			this.mtgcComboBox4.TabIndex = 0;
			this.mtgcComboBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox4_KeyDown);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Lavender;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(448, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(31, 23);
			this.button5.TabIndex = 1;
			this.button5.Text = "...";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			this.button5.Enter += new System.EventHandler(this.button5_Enter);
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(294, 136);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(219, 23);
			this.label26.TabIndex = 17;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(72, 136);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(198, 23);
			this.label25.TabIndex = 16;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(94, 89);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(174, 14);
			this.label24.TabIndex = 15;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(94, 64);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(163, 17);
			this.label23.TabIndex = 14;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(94, 41);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(167, 14);
			this.label22.TabIndex = 13;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(347, 89);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(159, 15);
			this.label21.TabIndex = 12;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(271, 89);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(71, 16);
			this.label20.TabIndex = 11;
			this.label20.Text = "Fournisseur";
			// 
			// txType
			// 
			this.txType.BackColor = System.Drawing.Color.White;
			this.txType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txType.Location = new System.Drawing.Point(273, 62);
			this.txType.Name = "txType";
			this.txType.ReadOnly = true;
			this.txType.Size = new System.Drawing.Size(402, 20);
			this.txType.TabIndex = 2;
			this.txType.TabStop = false;
			this.txType.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(515, 42);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(159, 17);
			this.label19.TabIndex = 9;
			// 
			// txNomClient
			// 
			this.txNomClient.BackColor = System.Drawing.Color.White;
			this.txNomClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txNomClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txNomClient.Location = new System.Drawing.Point(193, 108);
			this.txNomClient.Name = "txNomClient";
			this.txNomClient.ReadOnly = true;
			this.txNomClient.Size = new System.Drawing.Size(483, 20);
			this.txNomClient.TabIndex = 8;
			this.txNomClient.TabStop = false;
			this.txNomClient.Text = "";
			// 
			// txCodeClient
			// 
			this.txCodeClient.BackColor = System.Drawing.Color.White;
			this.txCodeClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCodeClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txCodeClient.Location = new System.Drawing.Point(72, 108);
			this.txCodeClient.Name = "txCodeClient";
			this.txCodeClient.ReadOnly = true;
			this.txCodeClient.TabIndex = 7;
			this.txCodeClient.TabStop = false;
			this.txCodeClient.Text = "";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(510, 17);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(43, 17);
			this.label14.TabIndex = 6;
			this.label14.Text = "Type";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(16, 112);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 4;
			this.label12.Text = "Client";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(16, 88);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 16);
			this.label11.TabIndex = 3;
			this.label11.Text = "N° Serie";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(16, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 16);
			this.label10.TabIndex = 2;
			this.label10.Text = "Code MABEC";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 16);
			this.label9.TabIndex = 1;
			this.label9.Text = "Code client";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "Code opindus";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox3.Location = new System.Drawing.Point(16, 16);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(728, 232);
			this.textBox3.TabIndex = 0;
			this.textBox3.Text = "?";
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// txNumDevis
			// 
			this.txNumDevis.BackColor = System.Drawing.Color.White;
			this.txNumDevis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txNumDevis.Location = new System.Drawing.Point(72, 16);
			this.txNumDevis.Name = "txNumDevis";
			this.txNumDevis.Size = new System.Drawing.Size(80, 20);
			this.txNumDevis.TabIndex = 1;
			this.txNumDevis.TabStop = false;
			this.txNumDevis.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(24, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(48, 16);
			this.label15.TabIndex = 2;
			this.label15.Text = "Devis";
			// 
			// txDate
			// 
			this.txDate.BackColor = System.Drawing.Color.White;
			this.txDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txDate.Location = new System.Drawing.Point(216, 16);
			this.txDate.Name = "txDate";
			this.txDate.ReadOnly = true;
			this.txDate.Size = new System.Drawing.Size(88, 20);
			this.txDate.TabIndex = 3;
			this.txDate.TabStop = false;
			this.txDate.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(168, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(40, 23);
			this.label16.TabIndex = 4;
			this.label16.Text = "Date";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(16, 648);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 5;
			this.button1.TabStop = false;
			this.button1.Text = "Effacer les champs";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(144, 648);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 6;
			this.button2.TabStop = false;
			this.button2.Text = "Enregistrement";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_causes_atelier", new System.Data.Common.DataColumnMapping[] {
																																																							new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = "DELETE FROM T_causes_atelier WHERE (Code = ?) AND (Designation = ? OR ? IS NULL A" +
				"ND Designation IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO T_causes_atelier(Code, Designation) VALUES (?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Code, Designation FROM T_causes_atelier";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = "UPDATE T_causes_atelier SET Code = ?, Designation = ? WHERE (Code = ?) AND (Desig" +
				"nation = ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_causes_clients", new System.Data.Common.DataColumnMapping[] {
																																																							new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
			this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
			// 
			// oleDbDeleteCommand3
			// 
			this.oleDbDeleteCommand3.CommandText = "DELETE FROM T_causes_clients WHERE (Code = ?) AND (Designation = ? OR ? IS NULL A" +
				"ND Designation IS NULL)";
			this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand3
			// 
			this.oleDbInsertCommand3.CommandText = "INSERT INTO T_causes_clients(Code, Designation) VALUES (?, ?)";
			this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = "SELECT Code, Designation FROM T_causes_clients";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand3
			// 
			this.oleDbUpdateCommand3.CommandText = "UPDATE T_causes_clients SET Code = ?, Designation = ? WHERE (Code = ?) AND (Desig" +
				"nation = ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_parc_machine", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("Code machine Opindus", "Code machine Opindus")})});
			this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_parc_machine WHERE ([Code machine Opindus] = ?)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_parc_machine([Code machine Opindus]) VALUES (?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT [Code machine Opindus] FROM T_parc_machine ORDER BY [Code machine Opindus]" +
				"";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_parc_machine SET [Code machine Opindus] = ? WHERE ([Code machine Opindus" +
				"] = ?)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter5
			// 
			this.oleDbDataAdapter5.DeleteCommand = this.oleDbDeleteCommand5;
			this.oleDbDataAdapter5.InsertCommand = this.oleDbInsertCommand5;
			this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
			this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_clients", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Adresse_1", "Adresse_1"),
																																																					 new System.Data.Common.DataColumnMapping("Adresse_2", "Adresse_2"),
																																																					 new System.Data.Common.DataColumnMapping("Batiment", "Batiment"),
																																																					 new System.Data.Common.DataColumnMapping("Borne Date Refus reforme", "Borne Date Refus reforme"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee", "CA_Annee"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee_1", "CA_Annee_1"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee_2", "CA_Annee_2"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee_3", "CA_Annee_3"),
																																																					 new System.Data.Common.DataColumnMapping("CA_Annee_4", "CA_Annee_4"),
																																																					 new System.Data.Common.DataColumnMapping("code_GC", "code_GC"),
																																																					 new System.Data.Common.DataColumnMapping("Code_Postal", "Code_Postal"),
																																																					 new System.Data.Common.DataColumnMapping("Code_reglement", "Code_reglement"),
																																																					 new System.Data.Common.DataColumnMapping("Code_transport", "Code_transport"),
																																																					 new System.Data.Common.DataColumnMapping("Coef_Controle", "Coef_Controle"),
																																																					 new System.Data.Common.DataColumnMapping("Coef_DNR", "Coef_DNR"),
																																																					 new System.Data.Common.DataColumnMapping("Coef_transport", "Coef_transport"),
																																																					 new System.Data.Common.DataColumnMapping("Commentaire", "Commentaire"),
																																																					 new System.Data.Common.DataColumnMapping("Delai_garantie", "Delai_garantie"),
																																																					 new System.Data.Common.DataColumnMapping("Forfait_Controle", "Forfait_Controle"),
																																																					 new System.Data.Common.DataColumnMapping("Forfait_DNR", "Forfait_DNR"),
																																																					 new System.Data.Common.DataColumnMapping("Forfait_transport", "Forfait_transport"),
																																																					 new System.Data.Common.DataColumnMapping("Groupe", "Groupe"),
																																																					 new System.Data.Common.DataColumnMapping("Ident", "Ident"),
																																																					 new System.Data.Common.DataColumnMapping("N°_Cde_Ouverte", "N°_Cde_Ouverte"),
																																																					 new System.Data.Common.DataColumnMapping("N°_Client_facture", "N°_Client_facture"),
																																																					 new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee", "Nombre_rep_Annee"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee_1", "Nombre_rep_Annee_1"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee_2", "Nombre_rep_Annee_2"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee_3", "Nombre_rep_Annee_3"),
																																																					 new System.Data.Common.DataColumnMapping("Nombre_rep_Annee_4", "Nombre_rep_Annee_4"),
																																																					 new System.Data.Common.DataColumnMapping("Notre_Code_Fournisseur", "Notre_Code_Fournisseur"),
																																																					 new System.Data.Common.DataColumnMapping("Pays", "Pays"),
																																																					 new System.Data.Common.DataColumnMapping("Pourcentage_remise", "Pourcentage_remise"),
																																																					 new System.Data.Common.DataColumnMapping("Seuil_reparation", "Seuil_reparation"),
																																																					 new System.Data.Common.DataColumnMapping("telecopie", "telecopie"),
																																																					 new System.Data.Common.DataColumnMapping("Telephone", "Telephone"),
																																																					 new System.Data.Common.DataColumnMapping("telex", "telex"),
																																																					 new System.Data.Common.DataColumnMapping("Usine", "Usine"),
																																																					 new System.Data.Common.DataColumnMapping("Ville", "Ville")})});
			this.oleDbDataAdapter5.UpdateCommand = this.oleDbUpdateCommand5;
			// 
			// oleDbDeleteCommand5
			// 
			this.oleDbDeleteCommand5.CommandText = "DELETE FROM T_clients WHERE (Ident = ?) AND (Adresse_1 = ? OR ? IS NULL AND Adres" +
				"se_1 IS NULL) AND (Adresse_2 = ? OR ? IS NULL AND Adresse_2 IS NULL) AND (Batime" +
				"nt = ? OR ? IS NULL AND Batiment IS NULL) AND ([Borne Date Refus reforme] = ? OR" +
				" ? IS NULL AND [Borne Date Refus reforme] IS NULL) AND (CA_Annee = ? OR ? IS NUL" +
				"L AND CA_Annee IS NULL) AND (CA_Annee_1 = ? OR ? IS NULL AND CA_Annee_1 IS NULL)" +
				" AND (CA_Annee_2 = ? OR ? IS NULL AND CA_Annee_2 IS NULL) AND (CA_Annee_3 = ? OR" +
				" ? IS NULL AND CA_Annee_3 IS NULL) AND (CA_Annee_4 = ? OR ? IS NULL AND CA_Annee" +
				"_4 IS NULL) AND (Code_Postal = ? OR ? IS NULL AND Code_Postal IS NULL) AND (Code" +
				"_reglement = ? OR ? IS NULL AND Code_reglement IS NULL) AND (Code_transport = ? " +
				"OR ? IS NULL AND Code_transport IS NULL) AND (Coef_Controle = ? OR ? IS NULL AND" +
				" Coef_Controle IS NULL) AND (Coef_DNR = ? OR ? IS NULL AND Coef_DNR IS NULL) AND" +
				" (Coef_transport = ? OR ? IS NULL AND Coef_transport IS NULL) AND (Delai_garanti" +
				"e = ? OR ? IS NULL AND Delai_garantie IS NULL) AND (Forfait_Controle = ? OR ? IS" +
				" NULL AND Forfait_Controle IS NULL) AND (Forfait_DNR = ? OR ? IS NULL AND Forfai" +
				"t_DNR IS NULL) AND (Forfait_transport = ? OR ? IS NULL AND Forfait_transport IS " +
				"NULL) AND (Groupe = ? OR ? IS NULL AND Groupe IS NULL) AND (Nom = ? OR ? IS NULL" +
				" AND Nom IS NULL) AND (Nombre_rep_Annee = ? OR ? IS NULL AND Nombre_rep_Annee IS" +
				" NULL) AND (Nombre_rep_Annee_1 = ? OR ? IS NULL AND Nombre_rep_Annee_1 IS NULL) " +
				"AND (Nombre_rep_Annee_2 = ? OR ? IS NULL AND Nombre_rep_Annee_2 IS NULL) AND (No" +
				"mbre_rep_Annee_3 = ? OR ? IS NULL AND Nombre_rep_Annee_3 IS NULL) AND (Nombre_re" +
				"p_Annee_4 = ? OR ? IS NULL AND Nombre_rep_Annee_4 IS NULL) AND (Notre_Code_Fourn" +
				"isseur = ? OR ? IS NULL AND Notre_Code_Fournisseur IS NULL) AND ([N°_Cde_Ouverte" +
				"] = ? OR ? IS NULL AND [N°_Cde_Ouverte] IS NULL) AND ([N°_Client_facture] = ? OR" +
				" ? IS NULL AND [N°_Client_facture] IS NULL) AND (Pays = ? OR ? IS NULL AND Pays " +
				"IS NULL) AND (Pourcentage_remise = ? OR ? IS NULL AND Pourcentage_remise IS NULL" +
				") AND (Seuil_reparation = ? OR ? IS NULL AND Seuil_reparation IS NULL) AND (Tele" +
				"phone = ? OR ? IS NULL AND Telephone IS NULL) AND (Usine = ? OR ? IS NULL AND Us" +
				"ine IS NULL) AND (Ville = ? OR ? IS NULL AND Ville IS NULL) AND (code_GC = ? OR " +
				"? IS NULL AND code_GC IS NULL) AND (telecopie = ? OR ? IS NULL AND telecopie IS " +
				"NULL) AND (telex = ? OR ? IS NULL AND telex IS NULL)";
			this.oleDbDeleteCommand5.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture1", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand5
			// 
			this.oleDbInsertCommand5.CommandText = @"INSERT INTO T_clients(Adresse_1, Adresse_2, Batiment, [Borne Date Refus reforme], CA_Annee, CA_Annee_1, CA_Annee_2, CA_Annee_3, CA_Annee_4, code_GC, Code_Postal, Code_reglement, Code_transport, Coef_Controle, Coef_DNR, Coef_transport, Commentaire, Delai_garantie, Forfait_Controle, Forfait_DNR, Forfait_transport, Groupe, Ident, [N°_Cde_Ouverte], [N°_Client_facture], Nom, Nombre_rep_Annee, Nombre_rep_Annee_1, Nombre_rep_Annee_2, Nombre_rep_Annee_3, Nombre_rep_Annee_4, Notre_Code_Fournisseur, Pays, Pourcentage_remise, Seuil_reparation, telecopie, Telephone, telex, Usine, Ville) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand5.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_2"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Borne Date Refus reforme"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_1"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_2"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_3"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_4"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, "code_GC"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_reglement"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_transport"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, "Coef_Controle"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, "Coef_DNR"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_transport", System.Data.OleDb.OleDbType.Double, 0, "Coef_transport"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai_garantie"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait_Controle"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait_DNR"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait_transport"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, "N°_Cde_Ouverte"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, "N°_Client_facture"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_1"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_2"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_3"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_4"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, "Notre_Code_Fournisseur"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage_remise"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, "Seuil_reparation"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("telex", System.Data.OleDb.OleDbType.VarWChar, 255, "telex"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			// 
			// oleDbSelectCommand5
			// 
			this.oleDbSelectCommand5.CommandText = @"SELECT Adresse_1, Adresse_2, Batiment, [Borne Date Refus reforme], CA_Annee, CA_Annee_1, CA_Annee_2, CA_Annee_3, CA_Annee_4, code_GC, Code_Postal, Code_reglement, Code_transport, Coef_Controle, Coef_DNR, Coef_transport, Commentaire, Delai_garantie, Forfait_Controle, Forfait_DNR, Forfait_transport, Groupe, Ident, [N°_Cde_Ouverte], [N°_Client_facture], Nom, Nombre_rep_Annee, Nombre_rep_Annee_1, Nombre_rep_Annee_2, Nombre_rep_Annee_3, Nombre_rep_Annee_4, Notre_Code_Fournisseur, Pays, Pourcentage_remise, Seuil_reparation, telecopie, Telephone, telex, Usine, Ville FROM T_clients";
			this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand5
			// 
			this.oleDbUpdateCommand5.CommandText = "UPDATE T_clients SET Adresse_1 = ?, Adresse_2 = ?, Batiment = ?, [Borne Date Refu" +
				"s reforme] = ?, CA_Annee = ?, CA_Annee_1 = ?, CA_Annee_2 = ?, CA_Annee_3 = ?, CA" +
				"_Annee_4 = ?, code_GC = ?, Code_Postal = ?, Code_reglement = ?, Code_transport =" +
				" ?, Coef_Controle = ?, Coef_DNR = ?, Coef_transport = ?, Commentaire = ?, Delai_" +
				"garantie = ?, Forfait_Controle = ?, Forfait_DNR = ?, Forfait_transport = ?, Grou" +
				"pe = ?, Ident = ?, [N°_Cde_Ouverte] = ?, [N°_Client_facture] = ?, Nom = ?, Nombr" +
				"e_rep_Annee = ?, Nombre_rep_Annee_1 = ?, Nombre_rep_Annee_2 = ?, Nombre_rep_Anne" +
				"e_3 = ?, Nombre_rep_Annee_4 = ?, Notre_Code_Fournisseur = ?, Pays = ?, Pourcenta" +
				"ge_remise = ?, Seuil_reparation = ?, telecopie = ?, Telephone = ?, telex = ?, Us" +
				"ine = ?, Ville = ? WHERE (Ident = ?) AND (Adresse_1 = ? OR ? IS NULL AND Adresse" +
				"_1 IS NULL) AND (Adresse_2 = ? OR ? IS NULL AND Adresse_2 IS NULL) AND (Batiment" +
				" = ? OR ? IS NULL AND Batiment IS NULL) AND ([Borne Date Refus reforme] = ? OR ?" +
				" IS NULL AND [Borne Date Refus reforme] IS NULL) AND (CA_Annee = ? OR ? IS NULL " +
				"AND CA_Annee IS NULL) AND (CA_Annee_1 = ? OR ? IS NULL AND CA_Annee_1 IS NULL) A" +
				"ND (CA_Annee_2 = ? OR ? IS NULL AND CA_Annee_2 IS NULL) AND (CA_Annee_3 = ? OR ?" +
				" IS NULL AND CA_Annee_3 IS NULL) AND (CA_Annee_4 = ? OR ? IS NULL AND CA_Annee_4" +
				" IS NULL) AND (Code_Postal = ? OR ? IS NULL AND Code_Postal IS NULL) AND (Code_r" +
				"eglement = ? OR ? IS NULL AND Code_reglement IS NULL) AND (Code_transport = ? OR" +
				" ? IS NULL AND Code_transport IS NULL) AND (Coef_Controle = ? OR ? IS NULL AND C" +
				"oef_Controle IS NULL) AND (Coef_DNR = ? OR ? IS NULL AND Coef_DNR IS NULL) AND (" +
				"Coef_transport = ? OR ? IS NULL AND Coef_transport IS NULL) AND (Delai_garantie " +
				"= ? OR ? IS NULL AND Delai_garantie IS NULL) AND (Forfait_Controle = ? OR ? IS N" +
				"ULL AND Forfait_Controle IS NULL) AND (Forfait_DNR = ? OR ? IS NULL AND Forfait_" +
				"DNR IS NULL) AND (Forfait_transport = ? OR ? IS NULL AND Forfait_transport IS NU" +
				"LL) AND (Groupe = ? OR ? IS NULL AND Groupe IS NULL) AND (Nom = ? OR ? IS NULL A" +
				"ND Nom IS NULL) AND (Nombre_rep_Annee = ? OR ? IS NULL AND Nombre_rep_Annee IS N" +
				"ULL) AND (Nombre_rep_Annee_1 = ? OR ? IS NULL AND Nombre_rep_Annee_1 IS NULL) AN" +
				"D (Nombre_rep_Annee_2 = ? OR ? IS NULL AND Nombre_rep_Annee_2 IS NULL) AND (Nomb" +
				"re_rep_Annee_3 = ? OR ? IS NULL AND Nombre_rep_Annee_3 IS NULL) AND (Nombre_rep_" +
				"Annee_4 = ? OR ? IS NULL AND Nombre_rep_Annee_4 IS NULL) AND (Notre_Code_Fournis" +
				"seur = ? OR ? IS NULL AND Notre_Code_Fournisseur IS NULL) AND ([N°_Cde_Ouverte] " +
				"= ? OR ? IS NULL AND [N°_Cde_Ouverte] IS NULL) AND ([N°_Client_facture] = ? OR ?" +
				" IS NULL AND [N°_Client_facture] IS NULL) AND (Pays = ? OR ? IS NULL AND Pays IS" +
				" NULL) AND (Pourcentage_remise = ? OR ? IS NULL AND Pourcentage_remise IS NULL) " +
				"AND (Seuil_reparation = ? OR ? IS NULL AND Seuil_reparation IS NULL) AND (Teleph" +
				"one = ? OR ? IS NULL AND Telephone IS NULL) AND (Usine = ? OR ? IS NULL AND Usin" +
				"e IS NULL) AND (Ville = ? OR ? IS NULL AND Ville IS NULL) AND (code_GC = ? OR ? " +
				"IS NULL AND code_GC IS NULL) AND (telecopie = ? OR ? IS NULL AND telecopie IS NU" +
				"LL) AND (telex = ? OR ? IS NULL AND telex IS NULL)";
			this.oleDbUpdateCommand5.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_2"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Borne Date Refus reforme"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_1"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_2"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_3"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_4"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, "code_GC"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_reglement"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_transport"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, "Coef_Controle"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, "Coef_DNR"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_transport", System.Data.OleDb.OleDbType.Double, 0, "Coef_transport"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai_garantie"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait_Controle"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait_DNR"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait_transport"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, "N°_Cde_Ouverte"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, "N°_Client_facture"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_1"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_2"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_3"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_4"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, "Notre_Code_Fournisseur"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage_remise"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, "Seuil_reparation"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("telex", System.Data.OleDb.OleDbType.VarWChar, 255, "telex"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture1", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter6
			// 
			this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand6;
			this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand6;
			this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
			this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand6;
			// 
			// oleDbDeleteCommand6
			// 
			this.oleDbDeleteCommand6.CommandText = @"DELETE FROM T_type_machine WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbDeleteCommand6.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand6
			// 
			this.oleDbInsertCommand6.CommandText = @"INSERT INTO T_type_machine(Code, [Code famille], [Date creation], [Date MAJ controle], [Date MAJ DNR], [Date MAJ Transport], [Delai garantie], [Forfait controle], [Forfait DNR], [Forfait Transport], Fournisseur, [Maxi machine], [Mini machine], [Mise a jour tarif], [Nombre reparations], [Prix catalogue], Vitesse) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			// 
			// oleDbSelectCommand6
			// 
			this.oleDbSelectCommand6.CommandText = @"SELECT Code, [Code famille], [Date creation], [Date MAJ controle], [Date MAJ DNR], [Date MAJ Transport], [Delai garantie], [Forfait controle], [Forfait DNR], [Forfait Transport], Fournisseur, [Maxi machine], [Mini machine], [Mise a jour tarif], [Nombre reparations], [Prix catalogue], Vitesse FROM T_type_machine";
			this.oleDbSelectCommand6.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand6
			// 
			this.oleDbUpdateCommand6.CommandText = @"UPDATE T_type_machine SET Code = ?, [Code famille] = ?, [Date creation] = ?, [Date MAJ controle] = ?, [Date MAJ DNR] = ?, [Date MAJ Transport] = ?, [Delai garantie] = ?, [Forfait controle] = ?, [Forfait DNR] = ?, [Forfait Transport] = ?, Fournisseur = ?, [Maxi machine] = ?, [Mini machine] = ?, [Mise a jour tarif] = ?, [Nombre reparations] = ?, [Prix catalogue] = ?, Vitesse = ? WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbUpdateCommand6.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter7
			// 
			this.oleDbDataAdapter7.DeleteCommand = this.oleDbDeleteCommand7;
			this.oleDbDataAdapter7.InsertCommand = this.oleDbInsertCommand7;
			this.oleDbDataAdapter7.SelectCommand = this.oleDbSelectCommand7;
			this.oleDbDataAdapter7.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_famille_machine", new System.Data.Common.DataColumnMapping[] {
																																																							 new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							 new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_1", "E_champ_1"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_2", "E_champ_2"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_3", "E_champ_3"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_4", "E_champ_4"),
																																																							 new System.Data.Common.DataColumnMapping("Type", "Type")})});
			this.oleDbDataAdapter7.UpdateCommand = this.oleDbUpdateCommand7;
			// 
			// oleDbDeleteCommand7
			// 
			this.oleDbDeleteCommand7.CommandText = @"DELETE FROM T_famille_machine WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (E_champ_1 = ? OR ? IS NULL AND E_champ_1 IS NULL) AND (E_champ_2 = ? OR ? IS NULL AND E_champ_2 IS NULL) AND (E_champ_3 = ? OR ? IS NULL AND E_champ_3 IS NULL) AND (E_champ_4 = ? OR ? IS NULL AND E_champ_4 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbDeleteCommand7.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand7
			// 
			this.oleDbInsertCommand7.CommandText = "INSERT INTO T_famille_machine(Code, Designation, E_champ_1, E_champ_2, E_champ_3," +
				" E_champ_4, Type) VALUES (?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand7.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type"));
			// 
			// oleDbSelectCommand7
			// 
			this.oleDbSelectCommand7.CommandText = "SELECT Code, Designation, E_champ_1, E_champ_2, E_champ_3, E_champ_4, Type FROM T" +
				"_famille_machine";
			this.oleDbSelectCommand7.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand7
			// 
			this.oleDbUpdateCommand7.CommandText = @"UPDATE T_famille_machine SET Code = ?, Designation = ?, E_champ_1 = ?, E_champ_2 = ?, E_champ_3 = ?, E_champ_4 = ?, Type = ? WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (E_champ_1 = ? OR ? IS NULL AND E_champ_1 IS NULL) AND (E_champ_2 = ? OR ? IS NULL AND E_champ_2 IS NULL) AND (E_champ_3 = ? OR ? IS NULL AND E_champ_3 IS NULL) AND (E_champ_4 = ? OR ? IS NULL AND E_champ_4 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbUpdateCommand7.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter8
			// 
			this.oleDbDataAdapter8.DeleteCommand = this.oleDbDeleteCommand8;
			this.oleDbDataAdapter8.InsertCommand = this.oleDbInsertCommand8;
			this.oleDbDataAdapter8.SelectCommand = this.oleDbSelectCommand8;
			this.oleDbDataAdapter8.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_Groupes", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																					 new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
			this.oleDbDataAdapter8.UpdateCommand = this.oleDbUpdateCommand8;
			// 
			// oleDbDeleteCommand8
			// 
			this.oleDbDeleteCommand8.CommandText = "DELETE FROM T_Groupes WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Desi" +
				"gnation IS NULL)";
			this.oleDbDeleteCommand8.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand8
			// 
			this.oleDbInsertCommand8.CommandText = "INSERT INTO T_Groupes(Code, Designation) VALUES (?, ?)";
			this.oleDbInsertCommand8.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			// 
			// oleDbSelectCommand8
			// 
			this.oleDbSelectCommand8.CommandText = "SELECT Code, Designation FROM T_Groupes";
			this.oleDbSelectCommand8.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand8
			// 
			this.oleDbUpdateCommand8.CommandText = "UPDATE T_Groupes SET Code = ?, Designation = ? WHERE (Code = ?) AND (Designation " +
				"= ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbUpdateCommand8.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter9
			// 
			this.oleDbDataAdapter9.DeleteCommand = this.oleDbDeleteCommand9;
			this.oleDbDataAdapter9.InsertCommand = this.oleDbInsertCommand9;
			this.oleDbDataAdapter9.SelectCommand = this.oleDbSelectCommand9;
			this.oleDbDataAdapter9.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_usine", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("Code_Groupe", "Code_Groupe"),
																																																				   new System.Data.Common.DataColumnMapping("Code_usine", "Code_usine"),
																																																				   new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
			this.oleDbDataAdapter9.UpdateCommand = this.oleDbUpdateCommand9;
			// 
			// oleDbDeleteCommand9
			// 
			this.oleDbDeleteCommand9.CommandText = "DELETE FROM T_usine WHERE (Code_usine = ?) AND (Code_Groupe = ? OR ? IS NULL AND " +
				"Code_Groupe IS NULL) AND (Designation = ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbDeleteCommand9.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand9
			// 
			this.oleDbInsertCommand9.CommandText = "INSERT INTO T_usine(Code_Groupe, Code_usine, Designation) VALUES (?, ?, ?)";
			this.oleDbInsertCommand9.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Code_Groupe"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Code_usine"));
			this.oleDbInsertCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			// 
			// oleDbSelectCommand9
			// 
			this.oleDbSelectCommand9.CommandText = "SELECT Code_Groupe, Code_usine, Designation FROM T_usine";
			this.oleDbSelectCommand9.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand9
			// 
			this.oleDbUpdateCommand9.CommandText = "UPDATE T_usine SET Code_Groupe = ?, Code_usine = ?, Designation = ? WHERE (Code_u" +
				"sine = ?) AND (Code_Groupe = ? OR ? IS NULL AND Code_Groupe IS NULL) AND (Design" +
				"ation = ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbUpdateCommand9.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Code_Groupe"));
			this.oleDbUpdateCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Code_usine"));
			this.oleDbUpdateCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand9.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter10
			// 
			this.oleDbDataAdapter10.DeleteCommand = this.oleDbDeleteCommand10;
			this.oleDbDataAdapter10.InsertCommand = this.oleDbInsertCommand10;
			this.oleDbDataAdapter10.SelectCommand = this.oleDbSelectCommand10;
			this.oleDbDataAdapter10.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter10.UpdateCommand = this.oleDbUpdateCommand10;
			// 
			// oleDbDeleteCommand10
			// 
			this.oleDbDeleteCommand10.CommandText = @"DELETE FROM T_fournisseurs WHERE (Code = ?) AND (Activite = ? OR ? IS NULL AND Activite IS NULL) AND ([Adresse 1] = ? OR ? IS NULL AND [Adresse 1] IS NULL) AND ([Adresse 2] = ? OR ? IS NULL AND [Adresse 2] IS NULL) AND ([Chiffre affaire Annee_1] = ? OR ? IS NULL AND [Chiffre affaire Annee_1] IS NULL) AND ([Chiffre affaire Annee_2] = ? OR ? IS NULL AND [Chiffre affaire Annee_2] IS NULL) AND ([Chiffre affaire Annee_3] = ? OR ? IS NULL AND [Chiffre affaire Annee_3] IS NULL) AND ([Chiffre affaire Annee_4] = ? OR ? IS NULL AND [Chiffre affaire Annee_4] IS NULL) AND ([Chiffre affaire PV] = ? OR ? IS NULL AND [Chiffre affaire PV] IS NULL) AND ([Chiffre affaire en cours] = ? OR ? IS NULL AND [Chiffre affaire en cours] IS NULL) AND ([Code Postal] = ? OR ? IS NULL AND [Code Postal] IS NULL) AND ([Coef PA PV] = ? OR ? IS NULL AND [Coef PA PV] IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Pays = ? OR ? IS NULL AND Pays IS NULL) AND ([Pourcentage Remise] = ? OR ? IS NULL AND [Pourcentage Remise] IS NULL) AND (Telecopie = ? OR ? IS NULL AND Telecopie IS NULL) AND (Telephone = ? OR ? IS NULL AND Telephone IS NULL) AND (Telex = ? OR ? IS NULL AND Telex IS NULL) AND (Ville = ? OR ? IS NULL AND Ville IS NULL)";
			this.oleDbDeleteCommand10.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Activite", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Activite1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telex", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telex", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand10
			// 
			this.oleDbInsertCommand10.CommandText = @"INSERT INTO T_fournisseurs(Activite, [Adresse 1], [Adresse 2], [Chiffre affaire Annee_1], [Chiffre affaire Annee_2], [Chiffre affaire Annee_3], [Chiffre affaire Annee_4], [Chiffre affaire en cours], [Chiffre affaire PV], Code, [Code Postal], [Coef PA PV], Commentaire, Nom, Pays, [Pourcentage Remise], Telecopie, Telephone, Telex, Ville) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand10.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Activite", System.Data.OleDb.OleDbType.VarWChar, 255, "Activite"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 1"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 2"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_1"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_2"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_3"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_4"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire en cours"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire PV"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, "Coef PA PV"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage Remise"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telex", System.Data.OleDb.OleDbType.VarWChar, 255, "Telex"));
			this.oleDbInsertCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			// 
			// oleDbSelectCommand10
			// 
			this.oleDbSelectCommand10.CommandText = @"SELECT Activite, [Adresse 1], [Adresse 2], [Chiffre affaire Annee_1], [Chiffre affaire Annee_2], [Chiffre affaire Annee_3], [Chiffre affaire Annee_4], [Chiffre affaire en cours], [Chiffre affaire PV], Code, [Code Postal], [Coef PA PV], Commentaire, Nom, Pays, [Pourcentage Remise], Telecopie, Telephone, Telex, Ville FROM T_fournisseurs";
			this.oleDbSelectCommand10.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand10
			// 
			this.oleDbUpdateCommand10.CommandText = "UPDATE T_fournisseurs SET Activite = ?, [Adresse 1] = ?, [Adresse 2] = ?, [Chiffr" +
				"e affaire Annee_1] = ?, [Chiffre affaire Annee_2] = ?, [Chiffre affaire Annee_3]" +
				" = ?, [Chiffre affaire Annee_4] = ?, [Chiffre affaire en cours] = ?, [Chiffre af" +
				"faire PV] = ?, Code = ?, [Code Postal] = ?, [Coef PA PV] = ?, Commentaire = ?, N" +
				"om = ?, Pays = ?, [Pourcentage Remise] = ?, Telecopie = ?, Telephone = ?, Telex " +
				"= ?, Ville = ? WHERE (Code = ?) AND (Activite = ? OR ? IS NULL AND Activite IS N" +
				"ULL) AND ([Adresse 1] = ? OR ? IS NULL AND [Adresse 1] IS NULL) AND ([Adresse 2]" +
				" = ? OR ? IS NULL AND [Adresse 2] IS NULL) AND ([Chiffre affaire Annee_1] = ? OR" +
				" ? IS NULL AND [Chiffre affaire Annee_1] IS NULL) AND ([Chiffre affaire Annee_2]" +
				" = ? OR ? IS NULL AND [Chiffre affaire Annee_2] IS NULL) AND ([Chiffre affaire A" +
				"nnee_3] = ? OR ? IS NULL AND [Chiffre affaire Annee_3] IS NULL) AND ([Chiffre af" +
				"faire Annee_4] = ? OR ? IS NULL AND [Chiffre affaire Annee_4] IS NULL) AND ([Chi" +
				"ffre affaire PV] = ? OR ? IS NULL AND [Chiffre affaire PV] IS NULL) AND ([Chiffr" +
				"e affaire en cours] = ? OR ? IS NULL AND [Chiffre affaire en cours] IS NULL) AND" +
				" ([Code Postal] = ? OR ? IS NULL AND [Code Postal] IS NULL) AND ([Coef PA PV] = " +
				"? OR ? IS NULL AND [Coef PA PV] IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NU" +
				"LL) AND (Pays = ? OR ? IS NULL AND Pays IS NULL) AND ([Pourcentage Remise] = ? O" +
				"R ? IS NULL AND [Pourcentage Remise] IS NULL) AND (Telecopie = ? OR ? IS NULL AN" +
				"D Telecopie IS NULL) AND (Telephone = ? OR ? IS NULL AND Telephone IS NULL) AND " +
				"(Telex = ? OR ? IS NULL AND Telex IS NULL) AND (Ville = ? OR ? IS NULL AND Ville" +
				" IS NULL)";
			this.oleDbUpdateCommand10.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Activite", System.Data.OleDb.OleDbType.VarWChar, 255, "Activite"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 1"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 2"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_1"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_2"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_3"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_4"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire en cours"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire PV"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, "Coef PA PV"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage Remise"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telex", System.Data.OleDb.OleDbType.VarWChar, 255, "Telex"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Activite", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Activite1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telex", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telex", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand10.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter11
			// 
			this.oleDbDataAdapter11.DeleteCommand = this.oleDbDeleteCommand11;
			this.oleDbDataAdapter11.InsertCommand = this.oleDbInsertCommand11;
			this.oleDbDataAdapter11.SelectCommand = this.oleDbSelectCommand11;
			this.oleDbDataAdapter11.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										 new System.Data.Common.DataTableMapping("Table", "T_emplacement_atelier", new System.Data.Common.DataColumnMapping[] {
																																																								  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																								  new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																								  new System.Data.Common.DataColumnMapping("Occupe", "Occupe")})});
			this.oleDbDataAdapter11.UpdateCommand = this.oleDbUpdateCommand11;
			// 
			// oleDbDeleteCommand11
			// 
			this.oleDbDeleteCommand11.CommandText = "DELETE FROM T_emplacement_atelier WHERE (Code = ?) AND (Designation = ? OR ? IS N" +
				"ULL AND Designation IS NULL) AND (Occupe = ?)";
			this.oleDbDeleteCommand11.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Occupe", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Occupe", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand11
			// 
			this.oleDbInsertCommand11.CommandText = "INSERT INTO T_emplacement_atelier(Code, Designation, Occupe) VALUES (?, ?, ?)";
			this.oleDbInsertCommand11.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 10, "Code"));
			this.oleDbInsertCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbInsertCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Occupe", System.Data.OleDb.OleDbType.Boolean, 2, "Occupe"));
			// 
			// oleDbSelectCommand11
			// 
			this.oleDbSelectCommand11.CommandText = "SELECT Code, Designation, Occupe FROM T_emplacement_atelier";
			this.oleDbSelectCommand11.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand11
			// 
			this.oleDbUpdateCommand11.CommandText = "UPDATE T_emplacement_atelier SET Code = ?, Designation = ?, Occupe = ? WHERE (Cod" +
				"e = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (Occupe = " +
				"?)";
			this.oleDbUpdateCommand11.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 10, "Code"));
			this.oleDbUpdateCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Occupe", System.Data.OleDb.OleDbType.Boolean, 2, "Occupe"));
			this.oleDbUpdateCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand11.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Occupe", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Occupe", System.Data.DataRowVersion.Original, null));
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.Salmon;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.ForeColor = System.Drawing.Color.White;
			this.textBox4.Location = new System.Drawing.Point(320, 16);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(416, 20);
			this.textBox4.TabIndex = 8;
			this.textBox4.TabStop = false;
			this.textBox4.Text = "";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// oleDbDataAdapter12
			// 
			this.oleDbDataAdapter12.DeleteCommand = this.oleDbDeleteCommand12;
			this.oleDbDataAdapter12.InsertCommand = this.oleDbInsertCommand12;
			this.oleDbDataAdapter12.SelectCommand = this.oleDbSelectCommand12;
			this.oleDbDataAdapter12.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter12.UpdateCommand = this.oleDbUpdateCommand12;
			// 
			// oleDbDeleteCommand12
			// 
			this.oleDbDeleteCommand12.CommandText = "DELETE FROM T_devis_entete WHERE ([N° Devis] = ?) AND ([Accord Client] = ?) AND (" +
				"[Calcul Auto] = ?) AND ([Cause atelier] = ? OR ? IS NULL AND [Cause atelier] IS " +
				"NULL) AND ([Cause client] = ? OR ? IS NULL AND [Cause client] IS NULL) AND ([Cod" +
				"e Client] = ? OR ? IS NULL AND [Code Client] IS NULL) AND ([Code Materiel] = ? O" +
				"R ? IS NULL AND [Code Materiel] IS NULL) AND ([Commande generee] = ? OR ? IS NUL" +
				"L AND [Commande generee] IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NUL" +
				"L) AND ([Date Decision] = ? OR ? IS NULL AND [Date Decision] IS NULL) AND ([Date" +
				" Generation commande] = ? OR ? IS NULL AND [Date Generation commande] IS NULL) A" +
				"ND ([Date Reception pieces] = ? OR ? IS NULL AND [Date Reception pieces] IS NULL" +
				") AND ([Date entree reelle] = ? OR ? IS NULL AND [Date entree reelle] IS NULL) A" +
				"ND ([Date reparation] = ? OR ? IS NULL AND [Date reparation] IS NULL) AND ([Deta" +
				"il Client] = ? OR ? IS NULL AND [Detail Client] IS NULL) AND ([Detail atelier] =" +
				" ? OR ? IS NULL AND [Detail atelier] IS NULL) AND (Edite = ?) AND (Emplacement =" +
				" ? OR ? IS NULL AND Emplacement IS NULL) AND ([Forfait Controle] = ? OR ? IS NUL" +
				"L AND [Forfait Controle] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfa" +
				"it DNR] IS NULL) AND ([Forfait transport] = ? OR ? IS NULL AND [Forfait transpor" +
				"t] IS NULL) AND ([Imputation comptable] = ? OR ? IS NULL AND [Imputation comptab" +
				"le] IS NULL) AND ([Limite Devis] = ? OR ? IS NULL AND [Limite Devis] IS NULL) AN" +
				"D ([Message Pieds] = ? OR ? IS NULL AND [Message Pieds] IS NULL) AND (Niveau = ?" +
				" OR ? IS NULL AND Niveau IS NULL) AND ([N° Commande generee] = ? OR ? IS NULL AN" +
				"D [N° Commande generee] IS NULL) AND ([N° Commande ouverte] = ?) AND ([N° Tronco" +
				"n] = ?) AND ([Ordre Travail] = ?) AND ([Prix Reference] = ? OR ? IS NULL AND [Pr" +
				"ix Reference] IS NULL) AND ([Prix machine neuve] = ? OR ? IS NULL AND [Prix mach" +
				"ine neuve] IS NULL) AND (Reforme = ?) AND (Refus = ?) AND (Reparateur_D = ? OR ?" +
				" IS NULL AND Reparateur_D IS NULL) AND (Reparateur_R = ? OR ? IS NULL AND Repara" +
				"teur_R IS NULL) AND (Repare = ?) AND ([Seuil Client] = ? OR ? IS NULL AND [Seuil" +
				" Client] IS NULL) AND ([Seuil devis] = ? OR ? IS NULL AND [Seuil devis] IS NULL)" +
				" AND ([Total devis] = ? OR ? IS NULL AND [Total devis] IS NULL) AND ([Total devi" +
				"s euro] = ? OR ? IS NULL AND [Total devis euro] IS NULL) AND ([Total pieces] = ?" +
				" OR ? IS NULL AND [Total pieces] IS NULL) AND ([Type devis] = ? OR ? IS NULL AND" +
				" [Type devis] IS NULL) AND (Valide = ?) AND (edition_fax = ?) AND ([n° Bl] = ? O" +
				"R ? IS NULL AND [n° Bl] IS NULL)";
			this.oleDbDeleteCommand12.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Repare", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand12
			// 
			this.oleDbInsertCommand12.CommandText = @"INSERT INTO T_devis_entete([Accord Client], [Calcul Auto], [Cause atelier], [Cause client], [Code Client], [Code Materiel], [Commande generee], Comment, [Date], [Date Decision], [Date entree reelle], [Date Generation commande], [Date Reception pieces], [Date reparation], [Detail atelier], [Detail Client], Edite, edition_fax, Emplacement, [Forfait Controle], [Forfait DNR], [Forfait transport], [Imputation comptable], [Limite Devis], [Message Pieds], [n° Bl], [N° Commande generee], [N° Commande ouverte], [N° Devis], [N° Troncon], Niveau, [Ordre Travail], [Prix machine neuve], [Prix Reference], Reforme, Refus, Reparateur_D, Reparateur_R, Repare, [Seuil Client], [Seuil devis], [Total devis], [Total devis euro], [Total pieces], [Type devis], Valide) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand12.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"));
			this.oleDbInsertCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			// 
			// oleDbSelectCommand12
			// 
			this.oleDbSelectCommand12.CommandText = @"SELECT [Accord Client], [Calcul Auto], [Cause atelier], [Cause client], [Code Client], [Code Materiel], [Commande generee], Comment, [Date], [Date Decision], [Date entree reelle], [Date Generation commande], [Date Reception pieces], [Date reparation], [Detail atelier], [Detail Client], Edite, edition_fax, Emplacement, [Forfait Controle], [Forfait DNR], [Forfait transport], [Imputation comptable], [Limite Devis], [Message Pieds], [n° Bl], [N° Commande generee], [N° Commande ouverte], [N° Devis], [N° Troncon], Niveau, [Ordre Travail], [Prix machine neuve], [Prix Reference], Reforme, Refus, Reparateur_D, Reparateur_R, Repare, [Seuil Client], [Seuil devis], [Total devis], [Total devis euro], [Total pieces], [Type devis], Valide FROM T_devis_entete";
			this.oleDbSelectCommand12.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand12
			// 
			this.oleDbUpdateCommand12.CommandText = "UPDATE T_devis_entete SET [Accord Client] = ?, [Calcul Auto] = ?, [Cause atelier]" +
				" = ?, [Cause client] = ?, [Code Client] = ?, [Code Materiel] = ?, [Commande gene" +
				"ree] = ?, Comment = ?, [Date] = ?, [Date Decision] = ?, [Date entree reelle] = ?" +
				", [Date Generation commande] = ?, [Date Reception pieces] = ?, [Date reparation]" +
				" = ?, [Detail atelier] = ?, [Detail Client] = ?, Edite = ?, edition_fax = ?, Emp" +
				"lacement = ?, [Forfait Controle] = ?, [Forfait DNR] = ?, [Forfait transport] = ?" +
				", [Imputation comptable] = ?, [Limite Devis] = ?, [Message Pieds] = ?, [n° Bl] =" +
				" ?, [N° Commande generee] = ?, [N° Commande ouverte] = ?, [N° Devis] = ?, [N° Tr" +
				"oncon] = ?, Niveau = ?, [Ordre Travail] = ?, [Prix machine neuve] = ?, [Prix Ref" +
				"erence] = ?, Reforme = ?, Refus = ?, Reparateur_D = ?, Reparateur_R = ?, Repare " +
				"= ?, [Seuil Client] = ?, [Seuil devis] = ?, [Total devis] = ?, [Total devis euro" +
				"] = ?, [Total pieces] = ?, [Type devis] = ?, Valide = ? WHERE ([N° Devis] = ?) A" +
				"ND ([Accord Client] = ?) AND ([Calcul Auto] = ?) AND ([Cause atelier] = ? OR ? I" +
				"S NULL AND [Cause atelier] IS NULL) AND ([Cause client] = ? OR ? IS NULL AND [Ca" +
				"use client] IS NULL) AND ([Code Client] = ? OR ? IS NULL AND [Code Client] IS NU" +
				"LL) AND ([Code Materiel] = ? OR ? IS NULL AND [Code Materiel] IS NULL) AND ([Com" +
				"mande generee] = ? OR ? IS NULL AND [Commande generee] IS NULL) AND ([Date] = ? " +
				"OR ? IS NULL AND [Date] IS NULL) AND ([Date Decision] = ? OR ? IS NULL AND [Date" +
				" Decision] IS NULL) AND ([Date Generation commande] = ? OR ? IS NULL AND [Date G" +
				"eneration commande] IS NULL) AND ([Date Reception pieces] = ? OR ? IS NULL AND [" +
				"Date Reception pieces] IS NULL) AND ([Date entree reelle] = ? OR ? IS NULL AND [" +
				"Date entree reelle] IS NULL) AND ([Date reparation] = ? OR ? IS NULL AND [Date r" +
				"eparation] IS NULL) AND ([Detail Client] = ? OR ? IS NULL AND [Detail Client] IS" +
				" NULL) AND ([Detail atelier] = ? OR ? IS NULL AND [Detail atelier] IS NULL) AND " +
				"(Edite = ?) AND (Emplacement = ? OR ? IS NULL AND Emplacement IS NULL) AND ([For" +
				"fait Controle] = ? OR ? IS NULL AND [Forfait Controle] IS NULL) AND ([Forfait DN" +
				"R] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait transport] = ? OR ?" +
				" IS NULL AND [Forfait transport] IS NULL) AND ([Imputation comptable] = ? OR ? I" +
				"S NULL AND [Imputation comptable] IS NULL) AND ([Limite Devis] = ? OR ? IS NULL " +
				"AND [Limite Devis] IS NULL) AND ([Message Pieds] = ? OR ? IS NULL AND [Message P" +
				"ieds] IS NULL) AND (Niveau = ? OR ? IS NULL AND Niveau IS NULL) AND ([N° Command" +
				"e generee] = ? OR ? IS NULL AND [N° Commande generee] IS NULL) AND ([N° Commande" +
				" ouverte] = ?) AND ([N° Troncon] = ?) AND ([Ordre Travail] = ?) AND ([Prix Refer" +
				"ence] = ? OR ? IS NULL AND [Prix Reference] IS NULL) AND ([Prix machine neuve] =" +
				" ? OR ? IS NULL AND [Prix machine neuve] IS NULL) AND (Reforme = ?) AND (Refus =" +
				" ?) AND (Reparateur_D = ? OR ? IS NULL AND Reparateur_D IS NULL) AND (Reparateur" +
				"_R = ? OR ? IS NULL AND Reparateur_R IS NULL) AND (Repare = ?) AND ([Seuil Clien" +
				"t] = ? OR ? IS NULL AND [Seuil Client] IS NULL) AND ([Seuil devis] = ? OR ? IS N" +
				"ULL AND [Seuil devis] IS NULL) AND ([Total devis] = ? OR ? IS NULL AND [Total de" +
				"vis] IS NULL) AND ([Total devis euro] = ? OR ? IS NULL AND [Total devis euro] IS" +
				" NULL) AND ([Total pieces] = ? OR ? IS NULL AND [Total pieces] IS NULL) AND ([Ty" +
				"pe devis] = ? OR ? IS NULL AND [Type devis] IS NULL) AND (Valide = ?) AND (editi" +
				"on_fax = ?) AND ([n° Bl] = ? OR ? IS NULL AND [n° Bl] IS NULL)";
			this.oleDbUpdateCommand12.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Repare", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand12.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(848, 632);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 48);
			this.button3.TabIndex = 9;
			this.button3.TabStop = false;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Controls.Add(this.tabPageEX2);
			this.tabControlEX1.Location = new System.Drawing.Point(-5, 48);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(941, 576);
			this.tabControlEX1.TabColor = System.Drawing.Color.DarkGray;
			this.tabControlEX1.TabIndex = 1;
			this.tabControlEX1.TabStop = false;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.mtgcComboBox3);
			this.tabPageEX1.Controls.Add(this.mtgcComboBox2);
			this.tabPageEX1.Controls.Add(this.mtgcComboBox1);
			this.tabPageEX1.Controls.Add(this.label7);
			this.tabPageEX1.Controls.Add(this.label6);
			this.tabPageEX1.Controls.Add(this.textBox2);
			this.tabPageEX1.Controls.Add(this.textBox1);
			this.tabPageEX1.Controls.Add(this.label5);
			this.tabPageEX1.Controls.Add(this.label4);
			this.tabPageEX1.Controls.Add(this.label3);
			this.tabPageEX1.Controls.Add(this.label2);
			this.tabPageEX1.Controls.Add(this.label1);
			this.tabPageEX1.Controls.Add(this.groupBox2);
			this.tabPageEX1.Controls.Add(this.groupBox1);
			this.tabPageEX1.Controls.Add(this.button6);
			this.tabPageEX1.Controls.Add(this.label18);
			this.tabPageEX1.Controls.Add(this.label17);
			this.tabPageEX1.Controls.Add(this.txCommande);
			this.tabPageEX1.Controls.Add(this.txComptable);
			this.tabPageEX1.Controls.Add(this.txOrdre);
			this.tabPageEX1.Controls.Add(this.txTroncon);
			this.tabPageEX1.Controls.Add(this.groupBox3);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(933, 547);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Ouverture d\'un devis";
			// 
			// mtgcComboBox3
			// 
			this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox3.ColumnNum = 2;
			this.mtgcComboBox3.ColumnWidth = "50;200";
			this.mtgcComboBox3.DisplayMember = "Text";
			this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox3.DropDownWidth = 270;
			this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox3.GridLineHorizontal = false;
			this.mtgcComboBox3.GridLineVertical = true;
			this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox3.Location = new System.Drawing.Point(32, 448);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(176, 21);
			this.mtgcComboBox3.TabIndex = 7;
			// 
			// mtgcComboBox2
			// 
			this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox2.ColumnNum = 2;
			this.mtgcComboBox2.ColumnWidth = "50;200";
			this.mtgcComboBox2.DisplayMember = "Text";
			this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox2.DropDownWidth = 270;
			this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox2.GridLineHorizontal = false;
			this.mtgcComboBox2.GridLineVertical = true;
			this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox2.Location = new System.Drawing.Point(32, 336);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(104, 21);
			this.mtgcComboBox2.TabIndex = 5;
			this.mtgcComboBox2.Leave += new System.EventHandler(this.mtgcComboBox2_Leave);
			this.mtgcComboBox2.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox2_SelectedIndexChanged);
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(32, 251);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(104, 21);
			this.mtgcComboBox1.TabIndex = 3;
			this.mtgcComboBox1.Leave += new System.EventHandler(this.mtgcComboBox1_Leave);
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// tabPageEX2
			// 
			this.tabPageEX2.Controls.Add(this.textBox3);
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(772, 427);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Commentaires";
			// 
			// CreationDevis
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(924, 688);
			this.ControlBox = false;
			this.Controls.Add(this.tabControlEX1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.txDate);
			this.Controls.Add(this.txNumDevis);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "CreationDevis";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Creation d\'un devis";
			this.VisibleChanged += new System.EventHandler(this.CreationDevis_VisibleChanged);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.tabPageEX2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button3_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void cbCauseAtelier_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Comm.CommandText="SELECT Code, Designation FROM T_causes_atelier";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"T_causes_atelier");
			foreach(DataRow row2 in ds.Tables["T_causes_atelier"].Rows)
			{
				if(row2["Code"].ToString().Equals(mtgcComboBox2.Text))
					label18.Text=row2["Designation"].ToString();
			}
			ds.Tables["t_causes_atelier"].Clear();
		}

		private void cbCauseClient_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Comm.CommandText="SELECT Code, Designation FROM T_causes_clients";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"T_causes_clients");
			foreach(DataRow row3 in dataSet11.Tables["T_causes_clients"].Rows)
			{
				if(row3["Code"].ToString().Equals(mtgcComboBox1.Text))
					label17.Text=row3["Designation"].ToString();
			}
			ds.Tables["t_causes_clients"].Clear();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			txCodeClient.Clear();
			txCommande.Text="xxx";
			txComptable.Text="?";
			txDate.Text=DateTime.Now.ToShortDateString();
			txNomClient.Clear();
			txOrdre.Text="xxx";
			txTroncon.Text="?";
			txType.Clear();
			label25.Text="";
			label26.Text="";
			label19.Text="";
			label22.Text="";
			label23.Text="";
			label24.Text="";
			textBox3.Text="?";
			mtgcComboBox3.SelectedIndex=0;
			mtgcComboBox4.SelectedIndex=0;
			mtgcComboBox2.SelectedIndex=0;
			mtgcComboBox1.SelectedIndex=0;
			textBox1.Text="?";
			textBox2.Text="?";
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(txComptable.TextLength.Equals(0))
				txComptable.Text="?";
			Comm.CommandText="select [code machine opindus],[en reparation] from t_parc_machine where [code machine opindus]='"+mtgcComboBox4.Text+"'";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_parc_machine");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			if(ds.Tables["t_parc_machine"].Rows[0]["En reparation"].Equals(true))
			{
				MessageBox.Show("Machine déjà en réparation");
			}
			else
			{
                Comm.CommandText = "select [Type machine] from t_parc_machine where [code machine opindus]='" + mtgcComboBox4.Text + "'";
                DataAD.SelectCommand = Comm;
                try
                {
                    DataAD.Fill(ds, "t_parc_machine_type");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

                Comm.CommandText = "select [Forfait DNR] from t_type_machine where [code]='" + ds.Tables["t_parc_machine_type"].Rows[0]["Type machine"] + "'";
                DataAD.SelectCommand = Comm;
                try
                {
                    DataAD.Fill(ds, "t_type_machine");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }


				oleDbConnection1.Open();
				DataRow newrow = dataSet11.Tables["T_devis_entete"].NewRow();
				newrow["N° Devis"]=System.Convert.ToInt32(txNumDevis.Text);
				newrow["Date"]=System.Convert.ToDateTime(txDate.Text).ToLongDateString();
				newrow["Code client"]=System.Convert.ToInt32(txCodeClient.Text);
				newrow["Code materiel"]=mtgcComboBox4.Text;                
				foreach(DataRow row5 in dataSet11.Tables["t_emplacement_atelier"].Rows)
				{
					if(mtgcComboBox3.Text.Equals(row5["Code"]))
					{
						newrow["Emplacement"]=row5["Code"].ToString();
					}
				}
				newrow["Cause client"]=mtgcComboBox1.Text;
				newrow["Cause atelier"]=mtgcComboBox2.Text;
				newrow["Limite devis"]="0,00";
				newrow["Detail client"]=textBox1.Text.ToUpper();
				newrow["Detail atelier"]=textBox2.Text.ToUpper();
				if(mtgcComboBox3.Text.Length.Equals(0))
				{
					if(Agence.Equals(1))
						mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString("BOITE");
					else if(Agence.Equals(3))
						mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString("0000000001");
				}
				else
				{
					mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(mtgcComboBox3.Text);
					if(mtgcComboBox3.SelectedIndex>0)
						newrow["Emplacement"]=mtgcComboBox3.Text;
					else
					{
						if(Agence.Equals(1))
							mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString("BOITE");
						else if(Agence.Equals(3))
							mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString("0000000001");
					}
				}
				if(txTroncon.Text.Length.Equals(0))
					newrow["N° Troncon"]="?";
				else
					newrow["N° Troncon"]=txTroncon.Text.ToUpper();
				newrow["Ordre Travail"]=txOrdre.Text.ToUpper();
				newrow["Imputation comptable"]=txComptable.Text.ToUpper();
				newrow["N° Commande ouverte"]=txCommande.Text.ToUpper();
				newrow["Niveau"]=2;
				newrow["Comment"]=textBox3.Text.ToUpper();
				newrow["Calcul Auto"]="True";
                newrow["Total pieces"] = 0;
                newrow["Forfait DNR"] = ds.Tables["t_type_machine"].Rows[0]["Forfait DNR"];
				newrow["Forfait controle"]=0;
				newrow["Forfait transport"]=0;
				if(radioButton1.Checked)
					newrow["Type devis"]=1;
				else if(radioButton2.Checked)
					newrow["Type devis"]=2;
				else if(radioButton3.Checked)
					newrow["Type devis"]=3;
				dataSet11.Tables["t_devis_entete"].Rows.Add(newrow);
				try
				{
					oleDbDataAdapter12.Update(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				oleDbConnection1.Close();
				oleDbConnection1.Open();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="update t_parc_machine set [en reparation]=True where [code machine opindus]='"+mtgcComboBox4.Text+"'";
				Comm.ExecuteNonQuery();
				oleDbConnection1.Close();
				MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Vider();
				dataSet11.Tables["t_devis_entete"].Clear();
				oleDbDataAdapter12.SelectCommand.CommandText="select [n° devis] from t_devis_entete order by [n° devis]";
				oleDbDataAdapter12.Fill(dataSet11);
				int NumDevis=0;
				int cpt=dataSet11.Tables["T_Devis_entete"].Rows.Count;
				NumDevis=System.Convert.ToInt32(dataSet11.Tables["T_Devis_entete"].Rows[cpt-1]["N° Devis"].ToString())+1;
				txNumDevis.Text=NumDevis.ToString();
			}
			ds.Tables["t_parc_machine"].Clear();
			mtgcComboBox4.Focus();
		}

		private void Vider()
		{
			txCodeClient.Clear();
			txCommande.Text="xxx";
			txComptable.Text="?";
			txDate.Text=DateTime.Now.ToShortDateString();
			txNomClient.Clear();
			txOrdre.Text="xxx";
			txTroncon.Text="?";
			txType.Clear();
			label21.Text="";
			label25.Text="";
			label26.Text="";
			label19.Text="";
			label22.Text="";
			label23.Text="";
			label24.Text="";
			textBox3.Text="?";
			mtgcComboBox3.SelectedIndex=0;
			mtgcComboBox4.SelectedIndex=0;
			mtgcComboBox2.SelectedIndex=0;
			mtgcComboBox1.SelectedIndex=0;
			textBox1.Text="?";
			textBox2.Text="?";
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			if(mtgcComboBox4.SelectedIndex>0)
			{
				ParcMachine WinParc = new ParcMachine(Agence,mtgcComboBox4.Text);
				WinParc.ShowDialog();
			}
			else
			{
				ParcMachine WinParc = new ParcMachine(Agence,true);
				WinParc.ShowDialog();
			}
			this.Refresh();
			mtgcComboBox4.Items.Clear();
			Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], T_parc_machine.[Type machine], T_clients.Nom, T_clients.Ville FROM T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client] ORDER BY T_parc_machine.[Code machine Opindus]";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"T_parc_machine");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			mtgcComboBox4.SourceDataTable = ds.Tables["T_parc_machine"];
			mtgcComboBox4.SourceDataString = new string[]{"Code Machine Opindus","Type machine","Nom","ville"};
			mtgcComboBox4.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox4.SelectedIndex=0;

			ds.Tables["t_parc_machine"].Clear();

		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			Atelier WinAtelier = new Atelier(Agence);
			WinAtelier.ShowDialog();
			mtgcComboBox3.Items.Clear();
			dataSet11.Tables["t_emplacement_atelier"].Clear();
			oleDbDataAdapter11.SelectCommand.CommandText="select * from t_emplacement_atelier order by code asc";
			try
			{
				oleDbDataAdapter11.Fill(dataSet11);
				foreach(DataRow row in dataSet11.Tables["t_emplacement_atelier"].Rows)
				{
					mtgcComboBox3.Items.Add(new MTGCComboBoxItem(row["Code"].ToString(),row["designation"].ToString(),"",""));
				}
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
		}

		private void cbCauseClient_Leave(object sender, System.EventArgs e)
		{
		}

		private void cbCauseAtelier_Leave(object sender, System.EventArgs e)
		{
		
		}

		private void button3_Click_1(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_causes_clients"].Clear();
			oleDbDataAdapter3.SelectCommand.CommandText="select * from t_causes_clients where code="+mtgcComboBox1.Text;
			try
			{
				oleDbDataAdapter3.Fill(dataSet11);
				label17.Text=dataSet11.Tables["t_causes_clients"].Rows[0]["Designation"].ToString();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}

		}

		private void mtgcComboBox1_Leave(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_causes_clients"].Clear();
			oleDbDataAdapter3.SelectCommand.CommandText="select * from t_causes_clients where code="+mtgcComboBox1.Text;
			try
			{
				oleDbDataAdapter3.Fill(dataSet11);
				label17.Text=dataSet11.Tables["t_causes_clients"].Rows[0]["Designation"].ToString();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
		}

		private void mtgcComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_causes_atelier"].Clear();
			oleDbDataAdapter2.SelectCommand.CommandText="select * from t_causes_atelier where code="+mtgcComboBox2.Text;
			try
			{
				oleDbDataAdapter2.Fill(dataSet11);
				label18.Text=dataSet11.Tables["t_causes_atelier"].Rows[0]["Designation"].ToString();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
		}

		private void mtgcComboBox2_Leave(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_causes_atelier"].Clear();
			oleDbDataAdapter2.SelectCommand.CommandText="select * from t_causes_atelier where code="+mtgcComboBox2.Text;
			try
			{
				oleDbDataAdapter2.Fill(dataSet11);
				label18.Text=dataSet11.Tables["t_causes_atelier"].Rows[0]["Designation"].ToString();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
		}

		private void mtgcComboBox4_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				button2.Enabled=true;
				dataSet11.Clear();
				OleDbCommand Comm = new OleDbCommand();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="select t_parc_machine.[Code machine opindus],t_parc_machine.[Date fin garantie],t_type_machine.[fournisseur],t_parc_machine.[Type machine],t_parc_machine.[Code machine client],t_parc_machine.[Code mabec],t_parc_machine.[No Serie],t_parc_machine.[N° troncon],t_parc_machine.[code client],t_fournisseurs.[nom],t_fournisseurs.[Code],t_famille_machine.[designation],t_famille_machine.code,t_type_machine.[code famille],t_type_machine.code,t_clients.[nom],t_clients.[N°_Cde_Ouverte],t_groupes.Designation,t_usine.Designation from T_parc_machine,t_fournisseurs,t_famille_machine,t_type_machine,t_clients,t_groupes,t_usine where t_clients.usine=t_usine.[code_usine] and t_clients.groupe=t_groupes.code and t_clients.ident=t_parc_machine.[code client] and t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[code famille]=t_famille_machine.[Code] and t_type_machine.[fournisseur]=t_fournisseurs.code and [Code machine opindus]='"+mtgcComboBox4.Text+"'";
				oleDbDataAdapter4.SelectCommand=Comm;
				try
				{
					if(oleDbDataAdapter4.Fill(dataSet11)>0)
					{
						if(dataSet11.Tables["T_parc_machine"].Rows[0]["Date fin garantie"].ToString().Length>0)
						{
							DateTime fingar=System.Convert.ToDateTime(dataSet11.Tables["T_parc_machine"].Rows[0]["Date fin garantie"].ToString());
							if(fingar>DateTime.Today)
								radioButton2.Checked=true;
							else
								radioButton1.Checked=true;
						}
						if(dataSet11.Tables["T_parc_machine"].Rows.Count>0)
						{
							label19.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["Type machine"].ToString();
							label22.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["Code machine client"].ToString();
							label23.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["Code Mabec"].ToString();
							label24.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["No serie"].ToString();
							txTroncon.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["N° Troncon"].ToString();
							txCodeClient.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["Code client"].ToString();
							label21.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["t_fournisseurs.Nom"].ToString();
							txType.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["t_famille_machine.Designation"].ToString();
							label25.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["t_groupes.designation"].ToString();
							txNomClient.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["t_clients.Nom"].ToString();
							label26.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["t_usine.Designation"].ToString();
							txCommande.Text=dataSet11.Tables["T_parc_machine"].Rows[0]["N°_Cde_Ouverte"].ToString();
						}
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void CreationDevis_VisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible.Equals(true))
			{
				InitializeData();
			}
			else
				radioButton1.Checked=true;
		}

		private void button5_Enter(object sender, System.EventArgs e)
		{
			if(mtgcComboBox4.SelectedIndex>0)
			{
				button2.Enabled=true;
				Comm.CommandText="select t_parc_machine.[Code machine opindus],t_parc_machine.[Date fin garantie],t_type_machine.[fournisseur],t_parc_machine.[Type machine],t_parc_machine.[Code machine client],t_parc_machine.[Code mabec],t_parc_machine.[No Serie],t_parc_machine.[N° troncon],t_parc_machine.[code client],t_fournisseurs.[nom],t_fournisseurs.[Code],t_famille_machine.[designation],t_famille_machine.code,t_type_machine.[code famille],t_type_machine.code,t_clients.[nom],t_groupes.Designation,t_usine.Designation from T_parc_machine,t_fournisseurs,t_famille_machine,t_type_machine,t_clients,t_groupes,t_usine where t_clients.usine=t_usine.[code_usine] and t_clients.groupe=t_groupes.code and t_clients.ident=t_parc_machine.[code client] and t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[code famille]=t_famille_machine.[Code] and t_type_machine.[fournisseur]=t_fournisseurs.code and [Code machine opindus]='"+mtgcComboBox4.Text+"'";
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"T_parc_machine");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				if(ds.Tables["T_parc_machine"].Rows[0]["Date fin garantie"].ToString().Length>0)
				{
					DateTime fingar=System.Convert.ToDateTime(ds.Tables["T_parc_machine"].Rows[0]["Date fin garantie"].ToString());
					if(fingar>DateTime.Today)
						radioButton2.Checked=true;
					else
						radioButton1.Checked=true;
				}
				if(ds.Tables["T_parc_machine"].Rows.Count>0)
				{
					label19.Text=ds.Tables["T_parc_machine"].Rows[0]["Type machine"].ToString();
					label22.Text=ds.Tables["T_parc_machine"].Rows[0]["Code machine client"].ToString();
					label23.Text=ds.Tables["T_parc_machine"].Rows[0]["Code Mabec"].ToString();
					label24.Text=ds.Tables["T_parc_machine"].Rows[0]["No serie"].ToString();
					txTroncon.Text=ds.Tables["T_parc_machine"].Rows[0]["N° Troncon"].ToString();
					txCodeClient.Text=ds.Tables["T_parc_machine"].Rows[0]["Code client"].ToString();
					label21.Text=ds.Tables["T_parc_machine"].Rows[0]["t_fournisseurs.Nom"].ToString();
					txType.Text=ds.Tables["T_parc_machine"].Rows[0]["t_famille_machine.Designation"].ToString();
					label25.Text=ds.Tables["T_parc_machine"].Rows[0]["t_groupes.designation"].ToString();
					txNomClient.Text=ds.Tables["T_parc_machine"].Rows[0]["t_clients.Nom"].ToString();
					label26.Text=ds.Tables["T_parc_machine"].Rows[0]["t_usine.Designation"].ToString();
					ds.Tables["T_parc_machine"].Clear();
				}
			}
		}

	}
}
