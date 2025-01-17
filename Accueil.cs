using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;
using Microsoft.Office.Interop;


namespace Opindus
{
	/// <summary>
	/// Description résumée de Form1.
	/// </summary>
	/// 
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btClients;
		private System.Windows.Forms.Button btFourn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btParc;
		private System.Windows.Forms.Button btPieces;
		private System.Windows.Forms.Button btParSociete;
		private System.Windows.Forms.Button btGroupe;
		private System.Windows.Forms.Button btCauses;
		private System.Windows.Forms.Button btUsines;
		private System.Windows.Forms.Button btReglements;
		private System.Windows.Forms.Button btTransports;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btParcs;
		private System.Windows.Forms.Button btDNR;
        private System.Windows.Forms.Button btInfos;
		private System.Windows.Forms.Button btDNRTMach;
		private System.Windows.Forms.Button btMajPDCoef;
		private System.Windows.Forms.Button btAutresMAJ;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button txDevisGestion;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.Button button32;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.Button button35;
		private System.Windows.Forms.Button button36;
		private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Button button38;
		private System.Windows.Forms.Button button39;
		private System.Windows.Forms.Button button40;
		private System.Windows.Forms.Button button42;
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button44;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem Quitter;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label2;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private Dotnetrix.Controls.TabPageEX tabPageEX4;
		private Dotnetrix.Controls.TabPageEX tabPageEX5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
		private int Agence;
		private GestionDevis WinGestDevis;
		private Pieces WinPieces;
		private CreationDevis WinCreationDevis;
		private ParcMachine WinParc;
		private Clients WinCli;
		private GestionCommandes WinGestCom;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private Loading WinLoad;
		private OleDbCommand Comm;
		private DataSet ds;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private OleDbDataAdapter DataAD;
        private Button button5;
		Object oRien=System.Reflection.Missing.Value;


		public Form1()
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			
			WinLoad = new Loading();
			WinLoad.Show();
            InitializeComponent();
            oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Init\Init.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			Comm=new OleDbCommand();
			ds=new DataSet();
			DataAD=new OleDbDataAdapter();
			Comm.CommandText="SELECT * FROM Init";
			Comm.Connection=oleDbConnection1;
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"param");
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			if(ds.Tables["param"].Rows[0]["base"].ToString().Equals("1"))
			{
				radioButton1.Checked=true;
				Agence=1;
				label2.Text="Agence de Lyon";
				this.Refresh();
			}
			else if(ds.Tables["param"].Rows[0]["base"].ToString().Equals("2"))
			{
				radioButton2.Checked=true;
				Agence=2;
				label2.Text="Agence de Fretin";
				this.Refresh();
			}
			else if(ds.Tables["param"].Rows[0]["base"].ToString().Equals("3"))
			{
				radioButton3.Checked=true;
				Agence=3;
				label2.Text="Agence de Rouen";
				this.Refresh();
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
				if (components != null) 
				{
					String Base="0";
					if(radioButton1.Checked)
						Base="1";
					else if(radioButton2.Checked)
						Base="2";
					else if(radioButton3.Checked)
						Base="3";
					components.Dispose();
                    oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Init\Init.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
					Comm=new OleDbCommand();
					ds=new DataSet();
					DataAD=new OleDbDataAdapter();
					oleDbConnection1.Open();
					Comm.CommandText="UPDATE Init SET base="+Base;
					Comm.Connection=oleDbConnection1;
					Comm.ExecuteNonQuery();
					oleDbConnection1.Close();
					
				}
			}
			base.Dispose( disposing );
		}

		private void InitializeData()
		{
			DateTime Date = DateTime.Now;
			this.label1.Text= Date.ToLongDateString();
			Agence=0;
			if(radioButton1.Checked.Equals(true))
				Agence=1;
			else if(radioButton2.Checked.Equals(true))
				Agence=2;
			else if(radioButton3.Checked.Equals(true))
				Agence=3;
            if (Agence.Equals(1))
            {
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
            }
            else if (Agence.Equals(2))
            {
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lille\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
            }
            else if (Agence.Equals(3))
            {
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Rouen\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
            }
            Comm = new OleDbCommand();
            Comm.Connection = oleDbConnection1;
            timer1.Start();
			tabControlEX1.SelectedTab=tabPageEX1;
			WinGestDevis = new GestionDevis(Agence);
			WinLoad.Add();
			WinCreationDevis = new CreationDevis(Agence);
			WinLoad.Add();
			WinParc = new ParcMachine(Agence,false);
			WinLoad.Add();
			WinCli = new Clients(Agence,false);
			WinLoad.Add();
			WinGestCom = new GestionCommandes(Agence);
            WinPieces = new Pieces(Agence, "");
            
            Control[] ctrl =  WinPieces.Controls.Find("mtgcComboBox2", true);
            MTGCComboBox mt = (MTGCComboBox)ctrl[0];
            mt.Items.Clear();
            Comm.CommandText = "select Code,designation,Identificateur from t_pieces_detachees order by Code ASC";
            DataAD.SelectCommand = Comm;
            DataAD.Fill(ds, "pieces");

            foreach (DataRow row in ds.Tables["pieces"].Rows)
            {
                mt.Items.Add(new MTGCComboBoxItem(row["Code"].ToString().ToUpper(), row["Designation"].ToString().ToUpper(), row["Identificateur"].ToString(), ""));
            }
            mt.Items.Insert(0, new MTGCComboBoxItem("...", "", "", ""));
            ds.Tables["pieces"].Clear();

            ctrl = WinPieces.Controls.Find("mtgcComboBox1", true);
            MTGCComboBox mt1 = (MTGCComboBox)ctrl[0];
            mt1.Items.Clear();
            Comm.CommandText = "select identificateur,designation,Code from t_pieces_detachees order by Identificateur";
            DataAD.SelectCommand = Comm;
            DataAD.Fill(ds, "pieces");
            foreach (DataRow row in ds.Tables["pieces"].Rows)
            {
                mt1.Items.Add(new MTGCComboBoxItem(row["Identificateur"].ToString(), row["Designation"].ToString(), row["Code"].ToString(), ""));
            }
            mt1.Items.Insert(0, new MTGCComboBoxItem("...", "", "", ""));
            mt1.SelectedIndex = 0;
            ds.Tables["pieces"].Clear();

            ctrl = WinPieces.Controls.Find("mtgcComboBox3", true);
            MTGCComboBox mt2 = (MTGCComboBox)ctrl[0];
            mt2.Items.Clear();
            Comm.CommandText = "select Code_1,designation from t_pieces_detachees where code_1 IS NOT NULL AND code_1 NOT LIKE '?' order by Code_1";
            DataAD.SelectCommand = Comm;
            DataAD.Fill(ds, "pieces");
            foreach (DataRow row in ds.Tables["pieces"].Rows)
            {
                mt2.Items.Add(new MTGCComboBoxItem(row["Code_1"].ToString(), row["Designation"].ToString(), "", ""));
            }
            mt2.Items.Insert(0, new MTGCComboBoxItem("...", "", "", ""));
            mt2.SelectedIndex = 0;
            ds.Tables["pieces"].Clear();

            mt.SelectedIndex = 0;

            WinLoad.Add();
            WinLoad.Dispose();
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.label3 = new System.Windows.Forms.Label();
            this.btInfos = new System.Windows.Forms.Button();
            this.btDNR = new System.Windows.Forms.Button();
            this.btParcs = new System.Windows.Forms.Button();
            this.btTransports = new System.Windows.Forms.Button();
            this.btReglements = new System.Windows.Forms.Button();
            this.btUsines = new System.Windows.Forms.Button();
            this.btCauses = new System.Windows.Forms.Button();
            this.btGroupe = new System.Windows.Forms.Button();
            this.btClients = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAutresMAJ = new System.Windows.Forms.Button();
            this.btMajPDCoef = new System.Windows.Forms.Button();
            this.btDNRTMach = new System.Windows.Forms.Button();
            this.btFourn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btParc = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btPieces = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btParSociete = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txDevisGestion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button46 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.button40 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button41 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.Quitter = new System.Windows.Forms.MenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataSet11 = new Opindus.DataSet1();
            this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
            this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX4 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX5 = new Dotnetrix.Controls.TabPageEX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.tabControlEX1.SuspendLayout();
            this.tabPageEX1.SuspendLayout();
            this.tabPageEX2.SuspendLayout();
            this.tabPageEX4.SuspendLayout();
            this.tabPageEX3.SuspendLayout();
            this.tabPageEX5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenu = this.contextMenu1;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btInfos);
            this.groupBox1.Controls.Add(this.btDNR);
            this.groupBox1.Controls.Add(this.btParcs);
            this.groupBox1.Controls.Add(this.btTransports);
            this.groupBox1.Controls.Add(this.btReglements);
            this.groupBox1.Controls.Add(this.btUsines);
            this.groupBox1.Controls.Add(this.btCauses);
            this.groupBox1.Controls.Add(this.btGroupe);
            this.groupBox1.Controls.Add(this.btClients);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // contextMenu1
            // 
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(472, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Clients";
            // 
            // btInfos
            // 
            this.btInfos.BackColor = System.Drawing.Color.White;
            this.btInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInfos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfos.ForeColor = System.Drawing.Color.Black;
            this.btInfos.Location = new System.Drawing.Point(216, 72);
            this.btInfos.Name = "btInfos";
            this.btInfos.Size = new System.Drawing.Size(90, 32);
            this.btInfos.TabIndex = 8;
            this.btInfos.Text = "Infos Clients";
            this.btInfos.UseVisualStyleBackColor = false;
            this.btInfos.Click += new System.EventHandler(this.btInfos_Click);
            // 
            // btDNR
            // 
            this.btDNR.BackColor = System.Drawing.Color.White;
            this.btDNR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDNR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDNR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDNR.ForeColor = System.Drawing.Color.Black;
            this.btDNR.Location = new System.Drawing.Point(120, 72);
            this.btDNR.Name = "btDNR";
            this.btDNR.Size = new System.Drawing.Size(90, 32);
            this.btDNR.TabIndex = 7;
            this.btDNR.Text = "Coef DNR";
            this.btDNR.UseVisualStyleBackColor = false;
            this.btDNR.Click += new System.EventHandler(this.btDNR_Click);
            // 
            // btParcs
            // 
            this.btParcs.BackColor = System.Drawing.Color.White;
            this.btParcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btParcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParcs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParcs.ForeColor = System.Drawing.Color.Black;
            this.btParcs.Location = new System.Drawing.Point(600, 32);
            this.btParcs.Name = "btParcs";
            this.btParcs.Size = new System.Drawing.Size(90, 32);
            this.btParcs.TabIndex = 6;
            this.btParcs.Text = "Parc";
            this.btParcs.UseVisualStyleBackColor = false;
            this.btParcs.Click += new System.EventHandler(this.btParcs_Click);
            // 
            // btTransports
            // 
            this.btTransports.BackColor = System.Drawing.Color.White;
            this.btTransports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTransports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransports.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransports.ForeColor = System.Drawing.Color.Black;
            this.btTransports.Location = new System.Drawing.Point(504, 32);
            this.btTransports.Name = "btTransports";
            this.btTransports.Size = new System.Drawing.Size(90, 32);
            this.btTransports.TabIndex = 5;
            this.btTransports.Text = "Transports";
            this.btTransports.UseVisualStyleBackColor = false;
            this.btTransports.Click += new System.EventHandler(this.btTransports_Click);
            // 
            // btReglements
            // 
            this.btReglements.BackColor = System.Drawing.Color.White;
            this.btReglements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReglements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReglements.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReglements.ForeColor = System.Drawing.Color.Black;
            this.btReglements.Location = new System.Drawing.Point(408, 32);
            this.btReglements.Name = "btReglements";
            this.btReglements.Size = new System.Drawing.Size(90, 32);
            this.btReglements.TabIndex = 4;
            this.btReglements.Text = "Reglements";
            this.btReglements.UseVisualStyleBackColor = false;
            this.btReglements.Click += new System.EventHandler(this.btReglements_Click);
            // 
            // btUsines
            // 
            this.btUsines.BackColor = System.Drawing.Color.White;
            this.btUsines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUsines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsines.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsines.ForeColor = System.Drawing.Color.Black;
            this.btUsines.Location = new System.Drawing.Point(216, 32);
            this.btUsines.Name = "btUsines";
            this.btUsines.Size = new System.Drawing.Size(90, 32);
            this.btUsines.TabIndex = 3;
            this.btUsines.Text = "Usines";
            this.btUsines.UseVisualStyleBackColor = false;
            this.btUsines.Click += new System.EventHandler(this.btUsines_Click);
            // 
            // btCauses
            // 
            this.btCauses.BackColor = System.Drawing.Color.White;
            this.btCauses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCauses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCauses.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCauses.ForeColor = System.Drawing.Color.Black;
            this.btCauses.Location = new System.Drawing.Point(312, 32);
            this.btCauses.Name = "btCauses";
            this.btCauses.Size = new System.Drawing.Size(90, 32);
            this.btCauses.TabIndex = 2;
            this.btCauses.Text = "Causes";
            this.btCauses.UseVisualStyleBackColor = false;
            this.btCauses.Click += new System.EventHandler(this.btCauses_Click);
            // 
            // btGroupe
            // 
            this.btGroupe.BackColor = System.Drawing.Color.White;
            this.btGroupe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGroupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGroupe.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGroupe.ForeColor = System.Drawing.Color.Black;
            this.btGroupe.Location = new System.Drawing.Point(120, 32);
            this.btGroupe.Name = "btGroupe";
            this.btGroupe.Size = new System.Drawing.Size(90, 32);
            this.btGroupe.TabIndex = 1;
            this.btGroupe.Text = "Groupes";
            this.btGroupe.UseVisualStyleBackColor = false;
            this.btGroupe.Click += new System.EventHandler(this.btGroupe_Click);
            // 
            // btClients
            // 
            this.btClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.btClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClients.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClients.ForeColor = System.Drawing.Color.White;
            this.btClients.Image = ((System.Drawing.Image)(resources.GetObject("btClients.Image")));
            this.btClients.Location = new System.Drawing.Point(8, 16);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(96, 96);
            this.btClients.TabIndex = 0;
            this.btClients.Text = "&Clients";
            this.btClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btClients.UseVisualStyleBackColor = false;
            this.btClients.Click += new System.EventHandler(this.btClients_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btAutresMAJ);
            this.groupBox2.Controls.Add(this.btMajPDCoef);
            this.groupBox2.Controls.Add(this.btDNRTMach);
            this.groupBox2.Controls.Add(this.btFourn);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.Location = new System.Drawing.Point(8, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(472, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fournisseurs";
            // 
            // btAutresMAJ
            // 
            this.btAutresMAJ.BackColor = System.Drawing.Color.White;
            this.btAutresMAJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAutresMAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAutresMAJ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAutresMAJ.ForeColor = System.Drawing.Color.Black;
            this.btAutresMAJ.Location = new System.Drawing.Point(312, 48);
            this.btAutresMAJ.Name = "btAutresMAJ";
            this.btAutresMAJ.Size = new System.Drawing.Size(90, 32);
            this.btAutresMAJ.TabIndex = 5;
            this.btAutresMAJ.Text = "Autres MAJ";
            this.btAutresMAJ.UseVisualStyleBackColor = false;
            this.btAutresMAJ.Click += new System.EventHandler(this.btAutresMAJ_Click);
            // 
            // btMajPDCoef
            // 
            this.btMajPDCoef.BackColor = System.Drawing.Color.White;
            this.btMajPDCoef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMajPDCoef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMajPDCoef.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMajPDCoef.ForeColor = System.Drawing.Color.Black;
            this.btMajPDCoef.Location = new System.Drawing.Point(216, 48);
            this.btMajPDCoef.Name = "btMajPDCoef";
            this.btMajPDCoef.Size = new System.Drawing.Size(90, 32);
            this.btMajPDCoef.TabIndex = 4;
            this.btMajPDCoef.Text = "MAJ PD Coef";
            this.btMajPDCoef.UseVisualStyleBackColor = false;
            this.btMajPDCoef.Click += new System.EventHandler(this.btMajPDCoef_Click);
            // 
            // btDNRTMach
            // 
            this.btDNRTMach.BackColor = System.Drawing.Color.White;
            this.btDNRTMach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDNRTMach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDNRTMach.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDNRTMach.ForeColor = System.Drawing.Color.Black;
            this.btDNRTMach.Location = new System.Drawing.Point(120, 48);
            this.btDNRTMach.Name = "btDNRTMach";
            this.btDNRTMach.Size = new System.Drawing.Size(90, 32);
            this.btDNRTMach.TabIndex = 3;
            this.btDNRTMach.Text = "DNR T. Mach.";
            this.btDNRTMach.UseVisualStyleBackColor = false;
            this.btDNRTMach.Click += new System.EventHandler(this.btDNRTMach_Click);
            // 
            // btFourn
            // 
            this.btFourn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.btFourn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFourn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFourn.ForeColor = System.Drawing.Color.White;
            this.btFourn.Image = ((System.Drawing.Image)(resources.GetObject("btFourn.Image")));
            this.btFourn.Location = new System.Drawing.Point(8, 16);
            this.btFourn.Name = "btFourn";
            this.btFourn.Size = new System.Drawing.Size(96, 96);
            this.btFourn.TabIndex = 1;
            this.btFourn.Text = "&Fournisseurs";
            this.btFourn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFourn.UseVisualStyleBackColor = false;
            this.btFourn.Click += new System.EventHandler(this.btFourn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.btParc);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox3.Location = new System.Drawing.Point(8, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 123);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(472, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parc machines";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(504, 48);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 32);
            this.button14.TabIndex = 6;
            this.button14.Text = "Stat. Capt.";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(600, 48);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 32);
            this.button13.TabIndex = 5;
            this.button13.Text = "Maj DNR";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(408, 48);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 32);
            this.button12.TabIndex = 4;
            this.button12.Text = "Capteurs";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(312, 48);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 32);
            this.button11.TabIndex = 3;
            this.button11.Text = "Chaines";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(216, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 32);
            this.button10.TabIndex = 2;
            this.button10.Text = "Familles";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(120, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 32);
            this.button9.TabIndex = 1;
            this.button9.Text = "Types";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btParc
            // 
            this.btParc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.btParc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btParc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btParc.ForeColor = System.Drawing.Color.White;
            this.btParc.Image = ((System.Drawing.Image)(resources.GetObject("btParc.Image")));
            this.btParc.Location = new System.Drawing.Point(8, 16);
            this.btParc.Name = "btParc";
            this.btParc.Size = new System.Drawing.Size(96, 96);
            this.btParc.TabIndex = 0;
            this.btParc.Text = "&Parc";
            this.btParc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btParc.UseVisualStyleBackColor = false;
            this.btParc.Click += new System.EventHandler(this.btParc_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.btPieces);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox4.Location = new System.Drawing.Point(8, 355);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(706, 123);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(472, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pièces détachées";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Location = new System.Drawing.Point(312, 48);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 35);
            this.button18.TabIndex = 5;
            this.button18.Text = "Inventaire";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Black;
            this.button17.Location = new System.Drawing.Point(216, 48);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(90, 35);
            this.button17.TabIndex = 4;
            this.button17.Text = "Stock négatif";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(120, 48);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 35);
            this.button15.TabIndex = 2;
            this.button15.Text = "Ent / Sort";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btPieces
            // 
            this.btPieces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.btPieces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPieces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPieces.ForeColor = System.Drawing.Color.White;
            this.btPieces.Image = ((System.Drawing.Image)(resources.GetObject("btPieces.Image")));
            this.btPieces.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPieces.Location = new System.Drawing.Point(8, 16);
            this.btPieces.Name = "btPieces";
            this.btPieces.Size = new System.Drawing.Size(96, 96);
            this.btPieces.TabIndex = 0;
            this.btPieces.Text = "P&ièces détachées";
            this.btPieces.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPieces.UseVisualStyleBackColor = false;
            this.btPieces.Click += new System.EventHandler(this.btPieces_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btParSociete);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox5.Location = new System.Drawing.Point(8, 471);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(706, 123);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(472, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Configuration";
            // 
            // btParSociete
            // 
            this.btParSociete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.btParSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btParSociete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btParSociete.ForeColor = System.Drawing.Color.White;
            this.btParSociete.Image = ((System.Drawing.Image)(resources.GetObject("btParSociete.Image")));
            this.btParSociete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btParSociete.Location = new System.Drawing.Point(8, 16);
            this.btParSociete.Name = "btParSociete";
            this.btParSociete.Size = new System.Drawing.Size(96, 96);
            this.btParSociete.TabIndex = 0;
            this.btParSociete.Text = "Param. &Société";
            this.btParSociete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btParSociete.UseVisualStyleBackColor = false;
            this.btParSociete.Click += new System.EventHandler(this.btParSociete_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.White;
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.Enabled = false;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.Black;
            this.button22.Location = new System.Drawing.Point(16, 136);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(168, 23);
            this.button22.TabIndex = 12;
            this.button22.Text = "Connexion";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(40, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(180, 19);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "Agence de Rouen";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Checked = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(40, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(180, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Agence de Fretin";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(40, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(180, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "Agence de Lyon";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(32, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Connexions agences";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.txDevisGestion);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(8, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(705, 123);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(585, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Devis";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(8, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 96);
            this.button7.TabIndex = 16;
            this.button7.Text = "&Devis";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(504, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 29);
            this.label19.TabIndex = 15;
            this.label19.Text = "Devis";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(248, 64);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 37);
            this.button8.TabIndex = 8;
            this.button8.Text = "Niveau 3 +90 j";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(144, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 37);
            this.button6.TabIndex = 6;
            this.button6.Text = "Niveaux";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(560, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Réparateurs";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(456, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Att. démont.";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(352, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Avancement";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txDevisGestion
            // 
            this.txDevisGestion.BackColor = System.Drawing.Color.White;
            this.txDevisGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txDevisGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txDevisGestion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDevisGestion.ForeColor = System.Drawing.Color.Black;
            this.txDevisGestion.Location = new System.Drawing.Point(248, 15);
            this.txDevisGestion.Name = "txDevisGestion";
            this.txDevisGestion.Size = new System.Drawing.Size(100, 37);
            this.txDevisGestion.TabIndex = 1;
            this.txDevisGestion.Text = "Gestion";
            this.txDevisGestion.UseVisualStyleBackColor = false;
            this.txDevisGestion.Click += new System.EventHandler(this.txDevisGestion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(144, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Création";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button16);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.button23);
            this.groupBox8.Controls.Add(this.button24);
            this.groupBox8.Controls.Add(this.button25);
            this.groupBox8.Controls.Add(this.button26);
            this.groupBox8.Controls.Add(this.button27);
            this.groupBox8.Controls.Add(this.button28);
            this.groupBox8.Location = new System.Drawing.Point(8, 8);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(705, 123);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(8, 15);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(96, 96);
            this.button16.TabIndex = 17;
            this.button16.Text = "Comm&andes";
            this.button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(504, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 32);
            this.label20.TabIndex = 15;
            this.label20.Text = "Commandes";
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.Black;
            this.button23.Location = new System.Drawing.Point(144, 64);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 37);
            this.button23.TabIndex = 11;
            this.button23.Text = "Lignes Cde";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.White;
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.Color.Black;
            this.button24.Location = new System.Drawing.Point(560, 15);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(100, 37);
            this.button24.TabIndex = 10;
            this.button24.Text = "Cde en cours";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.White;
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.Black;
            this.button25.Location = new System.Drawing.Point(456, 15);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(100, 37);
            this.button25.TabIndex = 9;
            this.button25.Text = "Entrée directe";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.White;
            this.button26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.Color.Black;
            this.button26.Location = new System.Drawing.Point(352, 15);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 37);
            this.button26.TabIndex = 8;
            this.button26.Text = "Edition groupée";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.Color.Black;
            this.button27.Location = new System.Drawing.Point(248, 15);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(100, 37);
            this.button27.TabIndex = 7;
            this.button27.Text = "Gestion";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.White;
            this.button28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.Color.Black;
            this.button28.Location = new System.Drawing.Point(144, 15);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(100, 37);
            this.button28.TabIndex = 6;
            this.button28.Text = "Préparation";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button19);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.button29);
            this.groupBox9.Controls.Add(this.button30);
            this.groupBox9.Controls.Add(this.button31);
            this.groupBox9.Location = new System.Drawing.Point(8, 8);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(704, 123);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.Location = new System.Drawing.Point(8, 16);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(96, 96);
            this.button19.TabIndex = 18;
            this.button19.Text = "&Livraisons";
            this.button19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(464, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(230, 32);
            this.label21.TabIndex = 14;
            this.label21.Text = "Bons de livraison";
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.White;
            this.button29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.Color.Black;
            this.button29.Location = new System.Drawing.Point(352, 40);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(100, 37);
            this.button29.TabIndex = 11;
            this.button29.Text = "Transfert GC";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.White;
            this.button30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ForeColor = System.Drawing.Color.Black;
            this.button30.Location = new System.Drawing.Point(248, 40);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(100, 37);
            this.button30.TabIndex = 10;
            this.button30.Text = "Edition groupée";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.White;
            this.button31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.Color.Black;
            this.button31.Location = new System.Drawing.Point(144, 40);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(100, 37);
            this.button31.TabIndex = 9;
            this.button31.Text = "Gestion";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Controls.Add(this.button46);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Controls.Add(this.button40);
            this.groupBox12.Controls.Add(this.button42);
            this.groupBox12.Controls.Add(this.button43);
            this.groupBox12.Controls.Add(this.button44);
            this.groupBox12.Location = new System.Drawing.Point(8, 240);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(705, 123);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(472, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 32);
            this.label12.TabIndex = 22;
            this.label12.Text = "Stats fournisseurs";
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.button46.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button46.ForeColor = System.Drawing.Color.White;
            this.button46.Image = ((System.Drawing.Image)(resources.GetObject("button46.Image")));
            this.button46.Location = new System.Drawing.Point(8, 16);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(96, 96);
            this.button46.TabIndex = 21;
            this.button46.Text = "Fournisseurs";
            this.button46.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button46.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Silver;
            this.label24.Location = new System.Drawing.Point(400, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(316, 33);
            this.label24.TabIndex = 17;
            this.label24.Text = "Statistiques fournisseurs";
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.White;
            this.button40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.ForeColor = System.Drawing.Color.Black;
            this.button40.Location = new System.Drawing.Point(456, 40);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(100, 37);
            this.button40.TabIndex = 15;
            this.button40.Text = "Stat n / n-4";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.Color.White;
            this.button42.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.ForeColor = System.Drawing.Color.Black;
            this.button42.Location = new System.Drawing.Point(352, 40);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(100, 37);
            this.button42.TabIndex = 13;
            this.button42.Text = "Consommation";
            this.button42.UseVisualStyleBackColor = false;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button43
            // 
            this.button43.BackColor = System.Drawing.Color.White;
            this.button43.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button43.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button43.ForeColor = System.Drawing.Color.Black;
            this.button43.Location = new System.Drawing.Point(248, 40);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(100, 37);
            this.button43.TabIndex = 12;
            this.button43.Text = "Activité";
            this.button43.UseVisualStyleBackColor = false;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.White;
            this.button44.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.ForeColor = System.Drawing.Color.Black;
            this.button44.Location = new System.Drawing.Point(144, 40);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(100, 37);
            this.button44.TabIndex = 11;
            this.button44.Text = "Délai moyen";
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.button35);
            this.groupBox11.Controls.Add(this.button36);
            this.groupBox11.Controls.Add(this.button37);
            this.groupBox11.Controls.Add(this.button38);
            this.groupBox11.Controls.Add(this.button39);
            this.groupBox11.Controls.Add(this.button45);
            this.groupBox11.Location = new System.Drawing.Point(8, 124);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(705, 123);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(472, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "Stats clients";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Silver;
            this.label23.Location = new System.Drawing.Point(400, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(271, 32);
            this.label23.TabIndex = 17;
            this.label23.Text = "Statistiques clients";
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.White;
            this.button35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.ForeColor = System.Drawing.Color.Black;
            this.button35.Location = new System.Drawing.Point(560, 40);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(100, 37);
            this.button35.TabIndex = 15;
            this.button35.Text = "Stat n / n-4";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.White;
            this.button36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.Black;
            this.button36.Location = new System.Drawing.Point(456, 40);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(100, 37);
            this.button36.TabIndex = 14;
            this.button36.Text = "Stats gestion";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.White;
            this.button37.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.ForeColor = System.Drawing.Color.Black;
            this.button37.Location = new System.Drawing.Point(352, 40);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(100, 37);
            this.button37.TabIndex = 13;
            this.button37.Text = "Consommation";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.White;
            this.button38.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.ForeColor = System.Drawing.Color.Black;
            this.button38.Location = new System.Drawing.Point(248, 40);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(100, 37);
            this.button38.TabIndex = 12;
            this.button38.Text = "Activité";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.White;
            this.button39.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.ForeColor = System.Drawing.Color.Black;
            this.button39.Location = new System.Drawing.Point(144, 40);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(100, 37);
            this.button39.TabIndex = 11;
            this.button39.Text = "Dép. mach.";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.button45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button45.ForeColor = System.Drawing.Color.White;
            this.button45.Image = ((System.Drawing.Image)(resources.GetObject("button45.Image")));
            this.button45.Location = new System.Drawing.Point(8, 16);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(96, 96);
            this.button45.TabIndex = 20;
            this.button45.Text = "Clients";
            this.button45.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button45.UseVisualStyleBackColor = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.button41);
            this.groupBox10.Controls.Add(this.label22);
            this.groupBox10.Controls.Add(this.button32);
            this.groupBox10.Controls.Add(this.button33);
            this.groupBox10.Controls.Add(this.button34);
            this.groupBox10.ForeColor = System.Drawing.Color.Black;
            this.groupBox10.Location = new System.Drawing.Point(8, 8);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(705, 123);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(472, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "Stats devis";
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.button41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button41.ForeColor = System.Drawing.Color.White;
            this.button41.Image = ((System.Drawing.Image)(resources.GetObject("button41.Image")));
            this.button41.Location = new System.Drawing.Point(8, 16);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(96, 96);
            this.button41.TabIndex = 19;
            this.button41.Text = "Devis";
            this.button41.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button41.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Silver;
            this.label22.Location = new System.Drawing.Point(408, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(241, 32);
            this.label22.TabIndex = 16;
            this.label22.Text = "Statistiques devis";
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.White;
            this.button32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.ForeColor = System.Drawing.Color.Black;
            this.button32.Location = new System.Drawing.Point(352, 40);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(100, 37);
            this.button32.TabIndex = 14;
            this.button32.Text = "Ret garanties";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.White;
            this.button33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.ForeColor = System.Drawing.Color.Black;
            this.button33.Location = new System.Drawing.Point(248, 40);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(100, 37);
            this.button33.TabIndex = 13;
            this.button33.Text = "Activité Rép.";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.White;
            this.button34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.ForeColor = System.Drawing.Color.Black;
            this.button34.Location = new System.Drawing.Point(144, 40);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(100, 37);
            this.button34.TabIndex = 12;
            this.button34.Text = "Stat. devis";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.Quitter});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "?";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "A Propos";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // Quitter
            // 
            this.Quitter.Index = 1;
            this.Quitter.Text = "Quitter";
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(684, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 44);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agence de Lyon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
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
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
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
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControlEX1
            // 
            this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
            this.tabControlEX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.tabControlEX1.Controls.Add(this.tabPageEX1);
            this.tabControlEX1.Controls.Add(this.tabPageEX2);
            this.tabControlEX1.Controls.Add(this.tabPageEX4);
            this.tabControlEX1.Controls.Add(this.tabPageEX3);
            this.tabControlEX1.Controls.Add(this.tabPageEX5);
            this.tabControlEX1.ForeColor = System.Drawing.Color.Black;
            this.tabControlEX1.Location = new System.Drawing.Point(-1, 40);
            this.tabControlEX1.Name = "tabControlEX1";
            this.tabControlEX1.SelectedIndex = 0;
            this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Gainsboro;
            this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
            this.tabControlEX1.Size = new System.Drawing.Size(726, 630);
            this.tabControlEX1.TabColor = System.Drawing.Color.Silver;
            this.tabControlEX1.TabIndex = 4;
            this.tabControlEX1.UseVisualStyles = false;
            // 
            // tabPageEX1
            // 
            this.tabPageEX1.Controls.Add(this.groupBox1);
            this.tabPageEX1.Controls.Add(this.groupBox2);
            this.tabPageEX1.Controls.Add(this.groupBox3);
            this.tabPageEX1.Controls.Add(this.groupBox4);
            this.tabPageEX1.Controls.Add(this.groupBox5);
            this.tabPageEX1.ForeColor = System.Drawing.Color.Black;
            this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(718, 601);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Accueil";
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.Controls.Add(this.groupBox6);
            this.tabPageEX2.ForeColor = System.Drawing.Color.Black;
            this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(718, 601);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Devis";
            // 
            // tabPageEX4
            // 
            this.tabPageEX4.Controls.Add(this.groupBox9);
            this.tabPageEX4.ForeColor = System.Drawing.Color.Black;
            this.tabPageEX4.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX4.Name = "tabPageEX4";
            this.tabPageEX4.Size = new System.Drawing.Size(718, 601);
            this.tabPageEX4.TabIndex = 3;
            this.tabPageEX4.Text = "Livraisons";
            // 
            // tabPageEX3
            // 
            this.tabPageEX3.Controls.Add(this.groupBox8);
            this.tabPageEX3.ForeColor = System.Drawing.Color.Black;
            this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX3.Name = "tabPageEX3";
            this.tabPageEX3.Size = new System.Drawing.Size(718, 601);
            this.tabPageEX3.TabIndex = 2;
            this.tabPageEX3.Text = "Commandes";
            // 
            // tabPageEX5
            // 
            this.tabPageEX5.Controls.Add(this.groupBox10);
            this.tabPageEX5.Controls.Add(this.groupBox11);
            this.tabPageEX5.Controls.Add(this.groupBox12);
            this.tabPageEX5.ForeColor = System.Drawing.Color.Black;
            this.tabPageEX5.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX5.Name = "tabPageEX5";
            this.tabPageEX5.Size = new System.Drawing.Size(718, 601);
            this.tabPageEX5.TabIndex = 4;
            this.tabPageEX5.Text = "Statistiques";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Location = new System.Drawing.Point(724, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 606);
            this.panel1.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(48, 496);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Calculatrice";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(64, 424);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(48, 392);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 16);
            this.label17.TabIndex = 16;
            this.label17.Text = "Messagerie";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(64, 320);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(48, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Internet";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(64, 216);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(48, 556);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 12;
            this.label15.Text = "label15";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(408, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 32);
            this.button5.TabIndex = 9;
            this.button5.Text = "Infos Fournisseurs";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(924, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlEX1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil Opindus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.tabControlEX1.ResumeLayout(false);
            this.tabPageEX1.ResumeLayout(false);
            this.tabPageEX2.ResumeLayout(false);
            this.tabPageEX4.ResumeLayout(false);
            this.tabPageEX3.ResumeLayout(false);
            this.tabPageEX5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			System.Windows.Forms.Application.Run(new Form1());
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btClients_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			WinCli.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btGroupe_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			AcGroupes WinAcGroup = new AcGroupes(Agence);
			WinAcGroup.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btUsines_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			AcUsines WinAcUsines = new AcUsines(Agence);
			WinAcUsines.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btCauses_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			AcCauses WinAcCauses = new AcCauses(Agence);
			WinAcCauses.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btReglements_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			AcReglements WinAcReglements = new AcReglements(Agence);
			WinAcReglements.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btTransports_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			AcTransports WinAcTransports = new AcTransports(Agence);
			WinAcTransports.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			
			WinCreationDevis.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
			
		}

		private void btParcs_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			SelectClients WinSelectClient = new SelectClients(Agence);
			if(WinSelectClient.ShowDialog()==DialogResult.OK)
			{
				this.Refresh();
				DataRow client = WinSelectClient.GetRow();
				this.Refresh();
				ImpressionParc WinImpressionParc = new ImpressionParc(Agence,client);
				WinImpressionParc.ShowDialog();
			}
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btDNR_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			CoefDNR WinCoefDNR = new CoefDNR(Agence);
			WinCoefDNR.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
			WinCoefDNR.Dispose();
		}

		private void btInfos_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			InfosClients WinInfoCli = new InfosClients(Agence);
			WinInfoCli.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
			WinInfoCli.Dispose();
		}

		private void btFourn_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			SaisieFournisseurs WinSaisieFournisseur = new SaisieFournisseurs(Agence,false);
			WinSaisieFournisseur.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btInfoFour_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			InfoFourn WinInfoFourn = new InfoFourn(Agence);
			WinInfoFourn.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
			WinInfoFourn.Dispose();
		}

		private void btDNRTMach_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			InfoDNR WinInfoDNR = new InfoDNR(Agence);
			WinInfoDNR.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
			WinInfoDNR.Dispose();
		}

		private void btParc_Click(object sender, System.EventArgs e)
		{
			WinParc.ShowDialog();
		}

		private void btPieces_Click(object sender, System.EventArgs e)
		{
            WinPieces.ShowDialog();
        }

		private void button9_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			TypesMachines WinTypes = new TypesMachines(Agence,false);
			WinTypes.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			FamillesMachines WinFamilles = new FamillesMachines(Agence,"");
			WinFamilles.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button11_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			ChainesMesures WinChaines = new ChainesMesures(Agence);
			WinChaines.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button12_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Capteurs WinCapteurs = new Capteurs(Agence);
			WinCapteurs.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button13_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			majDNR WinMajDnr = new majDNR(Agence);
			WinMajDnr.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button18_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Inventaire WinInvent = new Inventaire(Agence);
			WinInvent.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button17_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Negatif WinNegatif = new Negatif(Agence);
			WinNegatif.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
			WinNegatif.Dispose();
		}

		private void button21_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Administration WinAdmin = new Administration();
			WinAdmin.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button14_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			StatCapt WinStatCapt = new StatCapt(Agence);
			WinStatCapt.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btParSociete_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			ParamSociete WinParam = new ParamSociete(Agence);
			WinParam.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void txDevisGestion_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			WinGestDevis.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			AvancementDevis WinAvancement = new AvancementDevis(Agence);
			WinAvancement.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Reparateurs WinReparateurs = new Reparateurs(Agence);
			WinReparateurs.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button15_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			EntreeSortie WinEntreeSortie = new EntreeSortie(Agence);
			WinEntreeSortie.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void Quitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Apropos WinApropos = new Apropos();
			WinApropos.ShowDialog();
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton2.Checked)
			{
				button22.Enabled=true;
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked)
			{
				button22.Enabled=true;
			}
		}

		private void button22_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			if(radioButton1.Checked)
			{
                WinLoad = new Loading();

                InitializeData();

                Agence =1;
				label2.Text="Agence de Lyon";
				WinCli.Dispose();
				WinCli = new Clients(Agence,false);
				WinGestDevis.Dispose();
				WinGestDevis = new GestionDevis(Agence);
				WinCreationDevis.Dispose();
				WinCreationDevis = new CreationDevis(Agence);
				WinParc.Dispose();
				WinParc = new ParcMachine(Agence,false);
				WinGestCom.Dispose();
				WinGestCom = new GestionCommandes(Agence);
                
                MessageBox.Show("Connexion OK");
			}
			else if(radioButton2.Checked)
			{
                WinLoad = new Loading();

                InitializeData();

                Agence =2;
				label2.Text="Agence de Fretin";
				WinCli = new Clients(Agence,false);
				WinGestDevis.Dispose();
				WinGestDevis = new GestionDevis(Agence);
				WinCreationDevis.Dispose();
				WinCreationDevis = new CreationDevis(Agence);
				WinParc.Dispose();
				WinParc = new ParcMachine(Agence,false);
				WinGestCom.Dispose();
				WinGestCom = new GestionCommandes(Agence);
                Control[] ctrl = WinPieces.Controls.Find("mtgcComboBox1", true);
                MTGCComboBox mt1 = (MTGCComboBox)ctrl[0];
                mt1.Items.Clear();
                Comm.CommandText = "select identificateur,designation,Code from t_pieces_detachees order by Identificateur";
                DataAD.SelectCommand = Comm;
                DataAD.Fill(ds, "pieces");
                foreach (DataRow row in ds.Tables["pieces"].Rows)
                {
                    mt1.Items.Add(new MTGCComboBoxItem(row["Identificateur"].ToString(), row["Designation"].ToString(), row["Code"].ToString(), ""));
                }
                mt1.Items.Insert(0, new MTGCComboBoxItem("...", "", "", ""));
                mt1.SelectedIndex = 0;
                ds.Tables["pieces"].Clear();
                MessageBox.Show("Connexion OK");
			}
			else if(radioButton3.Checked)
			{
                WinLoad = new Loading();

                InitializeData();

                Agence =3;
				label2.Text="Agence de Rouen";
				WinCli = new Clients(Agence,false);
				WinGestDevis.Dispose();
				WinGestDevis = new GestionDevis(Agence);
				WinCreationDevis.Dispose();
				WinCreationDevis = new CreationDevis(Agence);
				WinParc.Dispose();
				WinParc = new ParcMachine(Agence,false);
				WinGestCom.Dispose();
				WinGestCom = new GestionCommandes(Agence);
                Control[] ctrl = WinPieces.Controls.Find("mtgcComboBox1", true);
                MTGCComboBox mt1 = (MTGCComboBox)ctrl[0];
                mt1.Items.Clear();
                Comm.CommandText = "select identificateur,designation,Code from t_pieces_detachees order by Identificateur";
                DataAD.SelectCommand = Comm;
                DataAD.Fill(ds, "pieces");
                foreach (DataRow row in ds.Tables["pieces"].Rows)
                {
                    mt1.Items.Add(new MTGCComboBoxItem(row["Identificateur"].ToString(), row["Designation"].ToString(), row["Code"].ToString(), ""));
                }
                mt1.Items.Insert(0, new MTGCComboBoxItem("...", "", "", ""));
                mt1.SelectedIndex = 0;
                ds.Tables["pieces"].Clear();
                MessageBox.Show("Connexion OK");
			}
			this.Cursor=Cursors.Arrow;
		}

		private void button28_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			PreparationCommande WinPrepaCde = new PreparationCommande(Agence);
			WinPrepaCde.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button27_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			WinGestCom.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button25_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Commande WinCommande = new Commande(Agence);
			WinCommande.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Niveaux WinNiveaux = new Niveaux(Agence);
			WinNiveaux.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btMajPDCoef_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			MAJPDCoef WinMajPD = new MAJPDCoef(Agence);
			WinMajPD.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void btAutresMAJ_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			AutresMAJ WinAutresMAJ = new AutresMAJ(Agence);
			WinAutresMAJ.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Demontage WinDemontage = new Demontage(Agence);
			WinDemontage.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Niveau3 WinDevis3 = new Niveau3(Agence);
			WinDevis3.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button31_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			GestionBL WinGestBL = new GestionBL(Agence);
			WinGestBL.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button30_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			EditionBL WinEditBL = new EditionBL(Agence);
			WinEditBL.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button29_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			TransfertBL WinTransfertBL = new TransfertBL(Agence);
			WinTransfertBL.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button26_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			EditionCommandes WinEditCommande = new EditionCommandes(Agence);
			WinEditCommande.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button34_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			StatsDevis WinStatDevis = new StatsDevis(Agence);
			WinStatDevis.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button33_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			ActiviteRep WinActivite = new ActiviteRep(Agence);
			WinActivite.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button32_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			ActiviteRepGar WinActiviteGar = new ActiviteRepGar(Agence);
			WinActiviteGar.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button39_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			DepensesMachines WinDepMach = new DepensesMachines(Agence);
			WinDepMach.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button38_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			ActiviteCli WinActCli = new ActiviteCli(Agence);
			WinActCli.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button37_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			ConsoClients WinConso = new ConsoClients(Agence);
			WinConso.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button36_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			StatsGestion WinStatGestion = new StatsGestion(Agence);
			WinStatGestion.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button35_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			StatsCARep WinStatsRep = new StatsCARep(Agence);
			WinStatsRep.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button44_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			DélaisMoyens WinDelais = new DélaisMoyens(Agence);
			WinDelais.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button43_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			ActiviteFourn WinActFourn = new ActiviteFourn(Agence);
			WinActFourn.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button40_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			StatsCAFourn WinStatsCAFourn = new StatsCAFourn(Agence);
			WinStatsCAFourn.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button42_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			ConsoFourn WinConsoFourn = new ConsoFourn(Agence);
			WinConsoFourn.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
            this.Cursor = Cursors.WaitCursor;
            InfoFourn WinInfoFourn = new InfoFourn(Agence);
            WinInfoFourn.ShowDialog();
            this.Refresh();
            this.Cursor = Cursors.Arrow;
            WinInfoFourn.Dispose();
		}

		private void button24_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			CommandesEnCours WinCommandesEnCours = new CommandesEnCours(Agence);
			WinCommandesEnCours.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button23_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			LignesCommandesEnCours WinCommandeEnCours = new LignesCommandesEnCours(Agence);
			WinCommandeEnCours.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			MessageBox.Show("!!!");
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			label15.Text=DateTime.Now.ToLongTimeString();
		}

		private void pictureBox5_Click(object sender, System.EventArgs e)
		{
			Process myProcess = new Process();
			myProcess.StartInfo.FileName = @"C:\Program Files (x86)\Internet Explorer\iexplore.exe";
			myProcess.StartInfo.CreateNoWindow = true;
			myProcess.Start();

		}

		private void pictureBox6_Click(object sender, System.EventArgs e)
		{
			Process myProcess = new Process();
			myProcess.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft Office\OFFICE11\Outlook.exe";
			myProcess.StartInfo.CreateNoWindow = true;
			myProcess.Start();
		}

		private void pictureBox7_Click(object sender, System.EventArgs e)
		{
			Process myProcess = new Process();
			myProcess.StartInfo.FileName = @"C:\WINDOWS\system32\calc.exe";
			myProcess.StartInfo.CreateNoWindow = true;
			myProcess.Start();
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			contextMenu1.MenuItems.Clear();
			if(contextMenu1.SourceControl==groupBox1)
			{
				System.Windows.Forms.MenuItem menuItem1 = new System.Windows.Forms.MenuItem("Clients", new EventHandler(this.Clients_Clicked));
				//MenuItem menuItem2 = new MenuItem("Groupes", new EventHandler(this.Groupes_Clicked));
				//MenuItem menuItem3 = new MenuItem("Usines", new EventHandler(this.Usines_Clicked));
				//MenuItem menuItem4 = new MenuItem("Causes", new EventHandler(this.Causes_Clicked));
				contextMenu1.MenuItems.Add(menuItem1);
				//contextMenu1.MenuItems.Add(menuItem2);
				//contextMenu1.MenuItems.Add(menuItem3);
				//contextMenu1.MenuItems.Add(menuItem4);
			}
		}

		private void Clients_Clicked(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			Clients WinCli = new Clients(Agence,false);
			WinCli.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			CreationDevis WinCreationDevis = new CreationDevis(Agence);
			this.Cursor=Cursors.WaitCursor;
			WinCreationDevis.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button16_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			GestionCommandes WinGestionCde = new GestionCommandes(Agence);
			WinGestionCde.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void button47_Click(object sender, System.EventArgs e)
		{
			this.Cursor=Cursors.WaitCursor;
			MAJTarifs WinMajTarifs = new MAJTarifs(Agence);
			WinMajTarifs.ShowDialog();
			this.Refresh();
			this.Cursor=Cursors.Arrow;
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			int ypos=e.MarginBounds.Top;
			e.Graphics.DrawString("Opindus", new System.Drawing.Font("Arial", 24, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, e.MarginBounds.Top);
			ypos+=40;
			if(Agence.Equals(1))
				e.Graphics.DrawString("1 rue Maurice Audibert", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+195, ypos);
			else if(Agence.Equals(2))
				e.Graphics.DrawString("", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+195, ypos);
			else if(Agence.Equals(3))
				e.Graphics.DrawString("", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+195, ypos);
			ypos+=40;
			if(Agence.Equals(1))
				e.Graphics.DrawString("69800 St Priest", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			else if(Agence.Equals(2))
				e.Graphics.DrawString("", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			else if(Agence.Equals(3))
				e.Graphics.DrawString("", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			ypos+=40;
			if(Agence.Equals(1))
				e.Graphics.DrawString("Tel : 04 78 21 73 14 Fax : 04 78 21 73 01", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+120, ypos);
			else if(Agence.Equals(2))
				e.Graphics.DrawString("", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+120, ypos);
			else if(Agence.Equals(3))
				e.Graphics.DrawString("", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+120, ypos);
			ypos+=30;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new System.Drawing.Point(e.MarginBounds.Left,ypos), new System.Drawing.Point(e.MarginBounds.Right,ypos));
			ypos+=20;
			e.Graphics.DrawString("Emetteur : Madame Perret Lebateux", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Date : "+DateTime.Today.ToShortDateString(), new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+450, ypos);
			ypos+=30;
			e.Graphics.DrawString("Société", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=30;
			e.Graphics.DrawString("Monsieur", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=30;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new System.Drawing.Point(e.MarginBounds.Left,ypos), new System.Drawing.Point(e.MarginBounds.Right,ypos));
			ypos+=8;
			e.Graphics.DrawString("Objet : demande de prix et délais", new System.Drawing.Font("Arial", 24, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+45, ypos);
			ypos+=43;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new System.Drawing.Point(e.MarginBounds.Left,ypos), new System.Drawing.Point(e.MarginBounds.Right,ypos));
			ypos+=30;
			e.Graphics.DrawString("Référence", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Désignation", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos);
			e.Graphics.DrawString("Quantité", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			e.Graphics.DrawString("Prix €", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
			e.Graphics.DrawString("Délai", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+580, ypos);
			ypos+=600;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new System.Drawing.Point(e.MarginBounds.Left,ypos), new System.Drawing.Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			e.Graphics.DrawString("Réparation tous types, toutes marques Pneumatiques, Electriques, Hydrauliques.", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=20;
			e.Graphics.DrawString("La maitrise des outils portatifs.", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
		
		}


	}


}
