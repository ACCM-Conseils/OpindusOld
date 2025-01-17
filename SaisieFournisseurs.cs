using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using J4L.RChart;

namespace Opindus
{
	/// <summary>
	/// Description résumée de SaisieFournisseurs.
	/// </summary>
	public class SaisieFournisseurs : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txVille;
		private System.Windows.Forms.TextBox txCP;
		private System.Windows.Forms.TextBox txAdresse2;
		private System.Windows.Forms.TextBox txAdresse1;
		private System.Windows.Forms.TextBox txNom;
		private System.Windows.Forms.TextBox txPays;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txCode;
		private System.Windows.Forms.TextBox txTel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txFax;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Windows.Forms.Button btSupCorres;
		private System.Windows.Forms.Button btNewCorres;
		private System.Windows.Forms.TextBox txMemo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txRemise;
		private System.Windows.Forms.TextBox txPAPV;
		private System.Windows.Forms.Button btEdit;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private OleDbDataAdapter DataAD;
		private OleDbTransaction Transac;
		private OleDbCommand Comm;
		private DataSet ds;
		bool nouveau;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txActivite;
		private System.Windows.Forms.Label label14;
		private string NomCorres;
		private string PrenomCorres;
		private string Mel;
		private string Tel;
		private string Fax;
		private string Service;
		private string Fonction;
		private string Note;
		private string IDRow;
		private string Pays;
		private System.Windows.Forms.Label label15;
		private int Agence;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label16;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private MTGCComboBox cbRechercheFourn;
		private System.ComponentModel.IContainer components;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private J4L.RChart.ChartControl chartControl1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btQuitter;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btFourn;
        private ColumnHeader columnHeader5;
		private Dotnetrix.Controls.TabPageEX tabPageEX4;

		public SaisieFournisseurs(int Agence,bool Nouveau)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAD=new OleDbDataAdapter();
			ds=new DataSet();

			nouveau=false;
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

			dataSet11.Tables["t_fournisseurs"].Clear();
			oleDbSelectCommand2.CommandText="select code,nom,[adresse 1],[code postal],ville from t_fournisseurs order by nom";
			oleDbDataAdapter2.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_fournisseurs"].Rows)
			{
				cbRechercheFourn.Items.Add(new MTGCComboBoxItem(row["nom"].ToString(),row["adresse 1"].ToString(),row["code postal"].ToString(), row["ville"].ToString()));
			}
			tabControlEX1.SelectedTab=tabPageEX1;

			if(Nouveau)
			{
				txNom.BackColor=Color.MistyRose;
				btEnregistre.Enabled=true;
				nouveau=true;
				txNom.Text="";
				txNom.ReadOnly=false;
				txNom.Focus();
				txAdresse1.Text="";
				txAdresse2.Text="";
				txCP.Text="";
				txActivite.Text="";
				txVille.Text="";
				txCode.Text="";
				txTel.Text="";
				listView1.Items.Clear();
				txFax.Text="";
				txPays.Text="FRANCE";
				txRemise.Text="0";
				txPAPV.Text="0";
				dataSet11.Tables["t_fournisseurs"].Clear();
				oleDbConnection1.Open();
				oleDbDataAdapter2.SelectCommand.CommandText="select code,nom,[adresse 1],[code postal],ville from t_fournisseurs order by nom";
				try
				{
					oleDbDataAdapter2.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				int Cpt=0;
				foreach(DataRow row in dataSet11.Tables["T_fournisseurs"].Rows)
				{
					try
					{
						int cpt2=System.Convert.ToInt32(row["code"].ToString());
						if(cpt2>Cpt)
							Cpt=cpt2;
					}
					catch(Exception exp)
					{
					}
				}
				Cpt++;
				txCode.Text=Cpt.ToString();
				oleDbConnection1.Close();
				txNom.Enabled=true;
				txAdresse1.Enabled=true;
				txAdresse2.Enabled=true;
				txCP.Enabled=true;
				txActivite.Enabled=true;
				txVille.Enabled=true;
				txCode.Enabled=true;
				txTel.Enabled=true;
				txFax.Enabled=true;
				txPays.Enabled=true;
				txRemise.Enabled=true;
				txPAPV.Enabled=true;
				btNewCorres.Enabled=true;
				btSupCorres.Enabled=true;
				btEdit.Enabled=true;
			}
		}

		private void InitializeData()
		{
			tabControlEX1.SelectedTab=tabPageEX1;
			dataSet11.Tables["t_fournisseurs"].Clear();
			oleDbSelectCommand2.CommandText="select code,nom,[adresse 1],[code postal],ville from t_fournisseurs order by nom";
			oleDbDataAdapter2.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_fournisseurs"].Rows)
			{
				cbRechercheFourn.Items.Add(new MTGCComboBoxItem(row["nom"].ToString(),row["adresse 1"].ToString(),row["code postal"].ToString(), row["ville"].ToString()));
			}
			cbRechercheFourn.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			cbRechercheFourn.SelectedIndex=0;
		}

		public SaisieFournisseurs(int Agence, string Code)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			nouveau=false;
			Activer();
			txNom.ReadOnly=true;
			txAdresse1.ReadOnly=true;
			txAdresse2.ReadOnly=true;
			txCP.ReadOnly=true;
			txVille.ReadOnly=true;
			txCode.ReadOnly=true;
			txTel.ReadOnly=true;
			txActivite.ReadOnly=true;
			txFax.ReadOnly=true;
			txPays.ReadOnly=true;
			txRemise.ReadOnly=true;
			txPAPV.ReadOnly=true;
			btEnregistre.Enabled=false;
			btNewCorres.Enabled=false;
			btEdit.Enabled=false;
			btSupCorres.Enabled=false;
			btSupprime.Enabled=false;
			OleDbCommand Comm = new OleDbCommand();
			Comm.CommandText="select * from t_fournisseurs where Code='"+Code+"'";
			Comm.Connection=oleDbConnection1;
			oleDbDataAdapter1.SelectCommand=Comm;
			oleDbDataAdapter1.Fill(dataSet11,"T_fournisseurs");
			DataRow SelRow = dataSet11.Tables["T_fournisseurs"].Rows[0];
			txNom.Text=SelRow["Nom"].ToString();
			txAdresse1.Text=SelRow["Adresse 1"].ToString();
			txAdresse2.Text=SelRow["Adresse 2"].ToString();
			txCP.Text=SelRow["Code Postal"].ToString();
			txVille.Text=SelRow["Ville"].ToString();
			txActivite.Text=SelRow["Activite"].ToString();
			txTel.Text=SelRow["Telephone"].ToString();
			txFax.Text=SelRow["Telecopie"].ToString();
			txPays.Text=SelRow["Pays"].ToString();
			txCode.Text=SelRow["Code"].ToString();
			Decimal pourcent=System.Convert.ToDecimal(SelRow["Pourcentage remise"].ToString())*100;
			txRemise.Text=pourcent.ToString();
			txPAPV.Text=SelRow["Coef PA PV"].ToString();
			txMemo.Text=SelRow["Commentaire"].ToString();

			Comm = new OleDbCommand();
			Comm.CommandText="select * from t_fournisseurs_corresp where Code='"+txCode.Text+"'";
			Comm.Connection=oleDbConnection1;
			oleDbDataAdapter1.SelectCommand=Comm;
			oleDbDataAdapter1.Fill(dataSet11,"T_fournisseurs_corresp");
			foreach(DataRow row in dataSet11.Tables["T_fournisseurs_corresp"].Rows)
			{
				ListViewItem Corres= new ListViewItem(row["Nom"].ToString());
				if(row["Prenom"].ToString()!="?")
					Corres.SubItems.Add(row["Prenom"].ToString());
				else
					Corres.SubItems.Add(" ");
				if(row["Telephone"].ToString()!="?")
					Corres.SubItems.Add(row["Telephone"].ToString());
				else
					Corres.SubItems.Add(" ");
				if(row["Telecopie"].ToString()!="?")
					Corres.SubItems.Add(row["Telecopie"].ToString());
				else
					Corres.SubItems.Add(" ");
                if (row["E_mail"].ToString() != "?")
                    Corres.SubItems.Add(row["E_mail"].ToString());
                else
                    Corres.SubItems.Add(" ");
				Corres.Tag=row["cle"].ToString();
				listView1.Items.Add(Corres);
			}
			dataSet11.Tables["t_devis_entete"].Clear();
			oleDbConnection1.Close();
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="SELECT T_devis_entete.[Date reparation], T_devis_lignes.[Code piece], T_fournisseurs.Code, T_devis_entete.[N° Devis], T_pieces_detachees.[Prix Achat Net], T_devis_lignes.Quantite, T_pieces_detachees.Identificateur FROM (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece] WHERE (((T_fournisseurs.Code)='"+txCode.Text+"')) ORDER BY T_devis_entete.[Date reparation]";
			oleDbDataAdapter3.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter3.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				
			}
			decimal Total_Annee_en_cours=0;
			decimal Total_Annee_1=0;
			decimal Total_Annee_2=0;
			decimal Total_Annee_3=0;
			decimal Total_Annee_4=0;
			int annee_encours=DateTime.Now.Year;
			int annee_1=DateTime.Now.Year-1;
			int annee_2=DateTime.Now.Year-2;
			int annee_3=DateTime.Now.Year-3;
			int annee_4=DateTime.Now.Year-4;
			foreach(DataRow rowDate in dataSet11.Tables["t_cde_entete"].Rows)
			{
				if(rowDate["Date commande"].ToString().Length>0)
				{
					if(System.Convert.ToDateTime(rowDate["Date commande"].ToString()).Year.ToString().Equals(annee_encours.ToString()))
					{
						Total_Annee_en_cours+=System.Convert.ToDecimal(rowDate["Total net commande"].ToString());
					}
					else if(System.Convert.ToDateTime(rowDate["Date commande"].ToString()).Year.ToString().Equals(annee_1.ToString()))
					{
						Total_Annee_1+=System.Convert.ToDecimal(rowDate["Total net commande"].ToString());
					}
					else if(System.Convert.ToDateTime(rowDate["Date commande"].ToString()).Year.ToString().Equals(annee_2.ToString()))
					{
						Total_Annee_2+=System.Convert.ToDecimal(rowDate["Total net commande"].ToString());
					}
					else if(System.Convert.ToDateTime(rowDate["Date commande"].ToString()).Year.ToString().Equals(annee_3.ToString()))
					{
						Total_Annee_3+=System.Convert.ToDecimal(rowDate["Total net commande"].ToString());
					}
					else if(System.Convert.ToDateTime(rowDate["Date commande"].ToString()).Year.ToString().Equals(annee_4.ToString()))
					{
						Total_Annee_4+=System.Convert.ToDecimal(rowDate["Total net commande"].ToString());
					}
				}
			}
			//MessageBox.Show(Total_Annee_en_cours.ToString());
			ChartLoader chartLoader= chartControl1.getChartLoader();
			// set chart parameters 
			chartLoader.clearParams();
			chartLoader.setParameter("TITLECHART",txNom.Text); 
			chartLoader.setParameter("XLABEL","Années"); 
			chartLoader.setParameter("YLABEL","Chiffre d'affaires"); 
			chartLoader.setParameter("XSCALE_MIN","0"); 
			chartLoader.setParameter("XSCALE_MAX","5.5"); 
			chartLoader.setParameter("YSCALE_MIN","0"); 
			chartLoader.setParameter("BIG_TICK_INTERVALX","1");  
			chartLoader.setParameter("XAXIS_LABELS","En cours|N-1|N-2|N-3|N-4"); 
			chartLoader.setParameter("CERO_XAXIS","LINE"); 
			chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
			chartLoader.setParameter("SERIE_1","Chiffre d'affaires"); 
			chartLoader.setParameter("LEGEND","FALSE");
			chartLoader.setParameter("LEFT_MARGIN","0.20");
			chartLoader.setParameter("SERIE_TYPE_1","BAR");
			chartLoader.setParameter("YAXIS_AUTO_TICKS","10");
			chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","1000");
			chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
			chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
			chartLoader.setParameter("SERIE_FONT_1","Arial|PLAIN|8"); 
			string chiffres=Total_Annee_en_cours.ToString()+"|"+Total_Annee_1.ToString()+"|"+Total_Annee_2.ToString()+"|"+Total_Annee_3.ToString()+"|"+Total_Annee_4.ToString();
			chartLoader.setParameter("SERIE_DATA_1",chiffres); 
			chartLoader.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
			chartLoader.setParameter("SERIE_BAR_STYLE_1","ff"); 
			chartLoader.setParameter("BARCHART_BARSPACE","20"); 
			chartLoader.setParameter("BARCHART_BARWIDTH","50");
			chartLoader.setParameter("CHART_FILL","ffcc00"); 
			chartLoader.setParameter("YLABEL_VERTICAL","TRUE"); 
			chartLoader.setParameter("YAXIS_TICKATBASE","true");
			// create chart 
			chartControl1.buildChart();
			this.Refresh();
			chartControl1.Visible=true;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaisieFournisseurs));
            this.label14 = new System.Windows.Forms.Label();
            this.txActivite = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSupCorres = new System.Windows.Forms.Button();
            this.btNewCorres = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label9 = new System.Windows.Forms.Label();
            this.txFax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txPays = new System.Windows.Forms.TextBox();
            this.txVille = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txCP = new System.Windows.Forms.TextBox();
            this.txAdresse2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txAdresse1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txCode = new System.Windows.Forms.TextBox();
            this.txNom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl1 = new J4L.RChart.ChartControl();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txPAPV = new System.Windows.Forms.TextBox();
            this.txRemise = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txMemo = new System.Windows.Forms.TextBox();
            this.btSupprime = new System.Windows.Forms.Button();
            this.btEnregistre = new System.Windows.Forms.Button();
            this.btNouveau = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRechercheFourn = new MTGCComboBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
            this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btFourn = new System.Windows.Forms.Button();
            this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX4 = new Dotnetrix.Controls.TabPageEX();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.tabControlEX1.SuspendLayout();
            this.tabPageEX1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageEX3.SuspendLayout();
            this.tabPageEX2.SuspendLayout();
            this.tabPageEX4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(392, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 23);
            this.label14.TabIndex = 25;
            this.label14.Text = "Correspondants";
            // 
            // txActivite
            // 
            this.txActivite.BackColor = System.Drawing.Color.White;
            this.txActivite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txActivite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txActivite.Enabled = false;
            this.txActivite.Location = new System.Drawing.Point(560, 72);
            this.txActivite.Name = "txActivite";
            this.txActivite.Size = new System.Drawing.Size(320, 20);
            this.txActivite.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(512, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Activité";
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.White;
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Enabled = false;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.Blue;
            this.btEdit.Location = new System.Drawing.Point(144, 496);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(100, 23);
            this.btEdit.TabIndex = 22;
            this.btEdit.Text = "Editer la fiche";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btSupCorres
            // 
            this.btSupCorres.BackColor = System.Drawing.Color.White;
            this.btSupCorres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupCorres.Enabled = false;
            this.btSupCorres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupCorres.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupCorres.ForeColor = System.Drawing.Color.Red;
            this.btSupCorres.Location = new System.Drawing.Point(808, 496);
            this.btSupCorres.Name = "btSupCorres";
            this.btSupCorres.Size = new System.Drawing.Size(100, 23);
            this.btSupCorres.TabIndex = 21;
            this.btSupCorres.Text = "Supprimer";
            this.btSupCorres.UseVisualStyleBackColor = false;
            this.btSupCorres.Click += new System.EventHandler(this.btSupCorres_Click);
            // 
            // btNewCorres
            // 
            this.btNewCorres.BackColor = System.Drawing.Color.White;
            this.btNewCorres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNewCorres.Enabled = false;
            this.btNewCorres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewCorres.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewCorres.ForeColor = System.Drawing.Color.Blue;
            this.btNewCorres.Location = new System.Drawing.Point(16, 496);
            this.btNewCorres.Name = "btNewCorres";
            this.btNewCorres.Size = new System.Drawing.Size(100, 23);
            this.btNewCorres.TabIndex = 20;
            this.btNewCorres.Text = "Nouveau";
            this.btNewCorres.UseVisualStyleBackColor = false;
            this.btNewCorres.Click += new System.EventHandler(this.btNewCorres_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MintCream;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(896, 200);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenom";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Téléphone";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fax";
            this.columnHeader4.Width = 100;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Code";
            // 
            // txFax
            // 
            this.txFax.BackColor = System.Drawing.Color.White;
            this.txFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txFax.Enabled = false;
            this.txFax.Location = new System.Drawing.Point(560, 136);
            this.txFax.MaxLength = 50;
            this.txFax.Name = "txFax";
            this.txFax.Size = new System.Drawing.Size(168, 20);
            this.txFax.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(520, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fax";
            // 
            // txTel
            // 
            this.txTel.BackColor = System.Drawing.Color.White;
            this.txTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTel.Enabled = false;
            this.txTel.Location = new System.Drawing.Point(560, 104);
            this.txTel.MaxLength = 50;
            this.txTel.Name = "txTel";
            this.txTel.Size = new System.Drawing.Size(168, 20);
            this.txTel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Téléphone";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pays";
            // 
            // txPays
            // 
            this.txPays.BackColor = System.Drawing.Color.White;
            this.txPays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPays.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txPays.Enabled = false;
            this.txPays.Location = new System.Drawing.Point(88, 168);
            this.txPays.Name = "txPays";
            this.txPays.Size = new System.Drawing.Size(200, 20);
            this.txPays.TabIndex = 8;
            this.txPays.Text = "FRANCE";
            this.txPays.TextChanged += new System.EventHandler(this.txPays_TextChanged);
            // 
            // txVille
            // 
            this.txVille.BackColor = System.Drawing.Color.White;
            this.txVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txVille.Enabled = false;
            this.txVille.Location = new System.Drawing.Point(224, 136);
            this.txVille.Name = "txVille";
            this.txVille.Size = new System.Drawing.Size(264, 20);
            this.txVille.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ville";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Code postal";
            // 
            // txCP
            // 
            this.txCP.BackColor = System.Drawing.Color.White;
            this.txCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCP.Enabled = false;
            this.txCP.Location = new System.Drawing.Point(88, 136);
            this.txCP.MaxLength = 5;
            this.txCP.Name = "txCP";
            this.txCP.Size = new System.Drawing.Size(80, 20);
            this.txCP.TabIndex = 6;
            // 
            // txAdresse2
            // 
            this.txAdresse2.BackColor = System.Drawing.Color.White;
            this.txAdresse2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txAdresse2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txAdresse2.Enabled = false;
            this.txAdresse2.Location = new System.Drawing.Point(88, 104);
            this.txAdresse2.Name = "txAdresse2";
            this.txAdresse2.Size = new System.Drawing.Size(400, 20);
            this.txAdresse2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adresse2";
            // 
            // txAdresse1
            // 
            this.txAdresse1.BackColor = System.Drawing.Color.White;
            this.txAdresse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txAdresse1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txAdresse1.Enabled = false;
            this.txAdresse1.Location = new System.Drawing.Point(88, 72);
            this.txAdresse1.Name = "txAdresse1";
            this.txAdresse1.Size = new System.Drawing.Size(400, 20);
            this.txAdresse1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresse1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // txCode
            // 
            this.txCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCode.Enabled = false;
            this.txCode.Location = new System.Drawing.Point(560, 40);
            this.txCode.Name = "txCode";
            this.txCode.ReadOnly = true;
            this.txCode.Size = new System.Drawing.Size(56, 20);
            this.txCode.TabIndex = 2;
            // 
            // txNom
            // 
            this.txNom.BackColor = System.Drawing.Color.White;
            this.txNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txNom.Location = new System.Drawing.Point(88, 40);
            this.txNom.Name = "txNom";
            this.txNom.Size = new System.Drawing.Size(400, 20);
            this.txNom.TabIndex = 1;
            this.txNom.Enter += new System.EventHandler(this.txNom_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chartControl1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(48, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 401);
            this.panel1.TabIndex = 5;
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.White;
            this.chartControl1.Location = new System.Drawing.Point(67, 48);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(712, 313);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "chartControl2";
            this.chartControl1.Visible = false;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(63, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(713, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "Statistiques du chiffre d\'affaires sur 5 années";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txPAPV);
            this.groupBox1.Controls.Add(this.txRemise);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(16, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(204, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 23);
            this.label15.TabIndex = 5;
            this.label15.Text = "%";
            // 
            // txPAPV
            // 
            this.txPAPV.BackColor = System.Drawing.Color.LightYellow;
            this.txPAPV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPAPV.Enabled = false;
            this.txPAPV.Location = new System.Drawing.Point(140, 51);
            this.txPAPV.Name = "txPAPV";
            this.txPAPV.Size = new System.Drawing.Size(61, 20);
            this.txPAPV.TabIndex = 4;
            this.txPAPV.Text = "0";
            this.txPAPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txRemise
            // 
            this.txRemise.BackColor = System.Drawing.Color.LightYellow;
            this.txRemise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txRemise.Enabled = false;
            this.txRemise.Location = new System.Drawing.Point(140, 22);
            this.txRemise.Name = "txRemise";
            this.txRemise.Size = new System.Drawing.Size(60, 20);
            this.txRemise.TabIndex = 3;
            this.txRemise.Text = "0";
            this.txRemise.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Coef PA PV";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Pourcentage remise";
            // 
            // txMemo
            // 
            this.txMemo.BackColor = System.Drawing.Color.White;
            this.txMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txMemo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txMemo.Location = new System.Drawing.Point(16, 64);
            this.txMemo.Multiline = true;
            this.txMemo.Name = "txMemo";
            this.txMemo.Size = new System.Drawing.Size(902, 256);
            this.txMemo.TabIndex = 0;
            // 
            // btSupprime
            // 
            this.btSupprime.BackColor = System.Drawing.Color.White;
            this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupprime.Enabled = false;
            this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprime.ForeColor = System.Drawing.Color.Red;
            this.btSupprime.Location = new System.Drawing.Point(464, 656);
            this.btSupprime.Name = "btSupprime";
            this.btSupprime.Size = new System.Drawing.Size(100, 23);
            this.btSupprime.TabIndex = 15;
            this.btSupprime.TabStop = false;
            this.btSupprime.Text = "Supprimer";
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
            this.btEnregistre.Location = new System.Drawing.Point(136, 656);
            this.btEnregistre.Name = "btEnregistre";
            this.btEnregistre.Size = new System.Drawing.Size(100, 23);
            this.btEnregistre.TabIndex = 14;
            this.btEnregistre.TabStop = false;
            this.btEnregistre.Text = "Enregistrer";
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
            this.btNouveau.Location = new System.Drawing.Point(16, 656);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(100, 23);
            this.btNouveau.TabIndex = 13;
            this.btNouveau.TabStop = false;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.UseVisualStyleBackColor = false;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRechercheFourn);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 40);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // cbRechercheFourn
            // 
            this.cbRechercheFourn.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.cbRechercheFourn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbRechercheFourn.ColumnNum = 4;
            this.cbRechercheFourn.ColumnWidth = "200;200;50;200";
            this.cbRechercheFourn.DisplayMember = "Text";
            this.cbRechercheFourn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRechercheFourn.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.cbRechercheFourn.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbRechercheFourn.DropDownForeColor = System.Drawing.Color.Black;
            this.cbRechercheFourn.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.cbRechercheFourn.DropDownWidth = 670;
            this.cbRechercheFourn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRechercheFourn.GridLineColor = System.Drawing.Color.LightGray;
            this.cbRechercheFourn.GridLineHorizontal = false;
            this.cbRechercheFourn.GridLineVertical = true;
            this.cbRechercheFourn.HighlightBorderColor = System.Drawing.Color.Blue;
            this.cbRechercheFourn.HighlightBorderOnMouseEvents = true;
            this.cbRechercheFourn.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbRechercheFourn.Location = new System.Drawing.Point(97, 12);
            this.cbRechercheFourn.ManagingFastMouseMoving = true;
            this.cbRechercheFourn.ManagingFastMouseMovingInterval = 30;
            this.cbRechercheFourn.Name = "cbRechercheFourn";
            this.cbRechercheFourn.NormalBorderColor = System.Drawing.Color.Black;
            this.cbRechercheFourn.Size = new System.Drawing.Size(552, 21);
            this.cbRechercheFourn.TabIndex = 0;
            this.cbRechercheFourn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbRechercheFourn_KeyDown);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(8, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Recherche";
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
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Cle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_mail1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fonction1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prenom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Service", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Service1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO T_fournisseurs_Corresp(Code, E_mail, Fonction, [Memo], Nom, Prenom, S" +
                "ervice, Telecopie, Telephone) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"),
            new System.Data.OleDb.OleDbParameter("E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, "E_mail"),
            new System.Data.OleDb.OleDbParameter("Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, "Fonction"),
            new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"),
            new System.Data.OleDb.OleDbParameter("Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, "Prenom"),
            new System.Data.OleDb.OleDbParameter("Service", System.Data.OleDb.OleDbType.VarWChar, 50, "Service"),
            new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"),
            new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT Cle, Code, E_mail, Fonction, [Memo], Nom, Prenom, Service, Telecopie, Tele" +
                "phone FROM T_fournisseurs_Corresp";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"),
            new System.Data.OleDb.OleDbParameter("E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, "E_mail"),
            new System.Data.OleDb.OleDbParameter("Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, "Fonction"),
            new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"),
            new System.Data.OleDb.OleDbParameter("Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, "Prenom"),
            new System.Data.OleDb.OleDbParameter("Service", System.Data.OleDb.OleDbType.VarWChar, 50, "Service"),
            new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"),
            new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"),
            new System.Data.OleDb.OleDbParameter("Original_Cle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_mail", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_mail1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_mail", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fonction", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fonction1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fonction", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prenom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prenom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prenom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Service", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Service1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null)});
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
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = resources.GetString("oleDbInsertCommand2.CommandText");
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = resources.GetString("oleDbSelectCommand2.CommandText");
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = resources.GetString("oleDbDeleteCommand3.CommandText");
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = resources.GetString("oleDbInsertCommand3.CommandText");
            this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = resources.GetString("oleDbSelectCommand3.CommandText");
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // tabControlEX1
            // 
            this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
            this.tabControlEX1.Controls.Add(this.tabPageEX1);
            this.tabControlEX1.Controls.Add(this.tabPageEX3);
            this.tabControlEX1.Controls.Add(this.tabPageEX2);
            this.tabControlEX1.Controls.Add(this.tabPageEX4);
            this.tabControlEX1.Location = new System.Drawing.Point(-8, 56);
            this.tabControlEX1.Name = "tabControlEX1";
            this.tabControlEX1.SelectedIndex = 0;
            this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Gainsboro;
            this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
            this.tabControlEX1.Size = new System.Drawing.Size(944, 568);
            this.tabControlEX1.TabColor = System.Drawing.Color.Silver;
            this.tabControlEX1.TabIndex = 20;
            this.tabControlEX1.TabStop = false;
            this.tabControlEX1.UseVisualStyles = false;
            // 
            // tabPageEX1
            // 
            this.tabPageEX1.Controls.Add(this.groupBox3);
            this.tabPageEX1.Controls.Add(this.label14);
            this.tabPageEX1.Controls.Add(this.btEdit);
            this.tabPageEX1.Controls.Add(this.btSupCorres);
            this.tabPageEX1.Controls.Add(this.btNewCorres);
            this.tabPageEX1.Controls.Add(this.listView1);
            this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(936, 539);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Saisie";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btFourn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txCP);
            this.groupBox3.Controls.Add(this.txAdresse2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txAdresse1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txNom);
            this.groupBox3.Controls.Add(this.txPays);
            this.groupBox3.Controls.Add(this.txVille);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txTel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txFax);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txCode);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txActivite);
            this.groupBox3.Location = new System.Drawing.Point(16, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(896, 224);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // btFourn
            // 
            this.btFourn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.btFourn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFourn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFourn.ForeColor = System.Drawing.Color.White;
            this.btFourn.Image = ((System.Drawing.Image)(resources.GetObject("btFourn.Image")));
            this.btFourn.Location = new System.Drawing.Point(784, 112);
            this.btFourn.Name = "btFourn";
            this.btFourn.Size = new System.Drawing.Size(96, 96);
            this.btFourn.TabIndex = 24;
            this.btFourn.TabStop = false;
            this.btFourn.Text = "&Fournisseurs";
            this.btFourn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFourn.UseVisualStyleBackColor = false;
            // 
            // tabPageEX3
            // 
            this.tabPageEX3.Controls.Add(this.groupBox1);
            this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX3.Name = "tabPageEX3";
            this.tabPageEX3.Size = new System.Drawing.Size(936, 539);
            this.tabPageEX3.TabIndex = 2;
            this.tabPageEX3.Text = "Autres infos";
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.Controls.Add(this.panel1);
            this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(936, 539);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Statistiques";
            // 
            // tabPageEX4
            // 
            this.tabPageEX4.Controls.Add(this.pictureBox3);
            this.tabPageEX4.Controls.Add(this.txMemo);
            this.tabPageEX4.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX4.Name = "tabPageEX4";
            this.tabPageEX4.Size = new System.Drawing.Size(936, 539);
            this.tabPageEX4.TabIndex = 3;
            this.tabPageEX4.Text = "Commentaires";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(718, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 56);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(672, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 56);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btQuitter
            // 
            this.btQuitter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuitter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.ForeColor = System.Drawing.Color.Black;
            this.btQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btQuitter.Image")));
            this.btQuitter.Location = new System.Drawing.Point(856, 632);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(48, 48);
            this.btQuitter.TabIndex = 22;
            this.btQuitter.TabStop = false;
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 220;
            // 
            // SaisieFournisseurs
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(924, 688);
            this.ControlBox = false;
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControlEX1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btSupprime);
            this.Controls.Add(this.btEnregistre);
            this.Controls.Add(this.btNouveau);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SaisieFournisseurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saisie fournisseurs";
            this.VisibleChanged += new System.EventHandler(this.SaisieFournisseurs_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.tabControlEX1.ResumeLayout(false);
            this.tabPageEX1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageEX3.ResumeLayout(false);
            this.tabPageEX2.ResumeLayout(false);
            this.tabPageEX4.ResumeLayout(false);
            this.tabPageEX4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Activer()
		{
			txNom.Enabled=true;
			txAdresse1.Enabled=true;
			txAdresse2.Enabled=true;
			txCP.Enabled=true;
			txVille.Enabled=true;
			txCode.Enabled=true;
			txTel.Enabled=true;
			txActivite.Enabled=true;
			txFax.Enabled=true;
			txPays.Enabled=true;
			txRemise.Enabled=true;
			txPAPV.Enabled=true;
			btNewCorres.Enabled=true;
			btSupCorres.Enabled=true;
			btSupprime.Enabled=true;
			btEdit.Enabled=true;
		}
		private void Desactiver()
		{
			txNom.ReadOnly=true;
			txAdresse1.Enabled=false;
			txAdresse2.Enabled=false;
			txCP.Enabled=false;
			txVille.Enabled=false;
			txCode.Enabled=false;
			txTel.Enabled=false;
			txFax.Enabled=false;
			txPays.Enabled=false;
			txRemise.Enabled=false;
			txPAPV.Enabled=false;
			btNewCorres.Enabled=false;
			btSupCorres.Enabled=false;
			btEdit.Enabled=false;
		}

		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void btNewCorres_Click(object sender, System.EventArgs e)
		{
			txRemise.Text=txRemise.Text.Replace(".",",");
			txPAPV.Text=txPAPV.Text.Replace(".",",");
			OleDbCommand Requete = new OleDbCommand();
			OleDbDataAdapter Data1 = new OleDbDataAdapter();
			Requete.Connection=oleDbConnection1;
			DataSet ds = new DataSet();
			string com="select * from T_fournisseurs where Code ='"+txCode.Text+"'";
			Requete.CommandText=com;
			Data1.SelectCommand=Requete;
			try
			{
				Data1.Fill(ds,"T_Fournisseurs");
			}
			catch (OleDbException exp)
			{
				MessageBox.Show(exp.Message);
			}
			if(ds.Tables["T_Fournisseurs"].Rows.Count.Equals(0))
				Save();
			nouveau=false;
			InfoCorres WinNewCorresp = new InfoCorres(Agence,false, txNom.Text, txCode.Text,txPays.Text);
			WinNewCorresp.ShowDialog();
			listView1.Items.Clear();
			oleDbConnection1.Open();
			Requete.Connection=oleDbConnection1;
			ds.Clear();
			com="select * from T_fournisseurs_corresp where Code = '"+txCode.Text+"'";
			Requete.CommandText=com;
			oleDbDataAdapter1.SelectCommand=Requete;
			try
			{
				oleDbDataAdapter1.Fill(ds,"T_fournisseurs_corresp");
			}
			catch (OleDbException exp)
			{
				MessageBox.Show(exp.Message);
			}
			DataTable Table = ds.Tables["T_fournisseurs_corresp"];
			foreach (DataRow row in Table.Rows)
			{
				ListViewItem Corres= new ListViewItem(row["Nom"].ToString());
				if(row["Prenom"].ToString()!="?")
					Corres.SubItems.Add(row["Prenom"].ToString());
                else
                    Corres.SubItems.Add(" ");
				if(row["Telephone"].ToString()!="?")
					Corres.SubItems.Add(row["Telephone"].ToString());
                else
                    Corres.SubItems.Add(" ");
				if(row["Telecopie"].ToString()!="?")
					Corres.SubItems.Add(row["Telecopie"].ToString());
                else
                    Corres.SubItems.Add(" ");
                if (row["E_mail"].ToString() != "?")
                    Corres.SubItems.Add(row["E_mail"].ToString());
                else
                    Corres.SubItems.Add(" ");
				Corres.Tag=row["cle"].ToString();
				listView1.Items.Add(Corres);
			}
			oleDbConnection1.Close();
		}

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			txNom.BackColor=Color.MistyRose;
			btEnregistre.Enabled=true;
			nouveau=true;
			txNom.Text="";
			txNom.Focus();
			txAdresse1.Text="";
			txAdresse2.Text="";
			txCP.Text="";
			txActivite.Text="";
			txVille.Text="";
			txCode.Text="";
			txTel.Text="";
			listView1.Items.Clear();
			txFax.Text="";
			txPays.Text="FRANCE";
			txRemise.Text="0";
			txPAPV.Text="0";
			dataSet11.Tables["t_fournisseurs"].Clear();
			oleDbConnection1.Open();
			oleDbDataAdapter2.SelectCommand.CommandText="select code,nom,[adresse 1],[code postal],ville from t_fournisseurs order by nom";
			try
			{
				oleDbDataAdapter2.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			int Cpt=0;
			foreach(DataRow row in dataSet11.Tables["T_fournisseurs"].Rows)
			{
				try
				{
					int cpt2=System.Convert.ToInt32(row["code"].ToString());
					if(cpt2>Cpt)
						Cpt=cpt2;
				}
				catch(Exception exp)
				{
				}
			}
			Cpt++;
			txCode.Text=Cpt.ToString();
			oleDbConnection1.Close();
			txNom.ReadOnly=false;
			txAdresse1.Enabled=true;
			txAdresse2.Enabled=true;
			txCP.Enabled=true;
			txActivite.Enabled=true;
			txVille.Enabled=true;
			txCode.Enabled=true;
			txTel.Enabled=true;
			txFax.Enabled=true;
			txPays.Enabled=true;
			txRemise.Enabled=true;
			txPAPV.Enabled=true;
			btNewCorres.Enabled=true;
			btSupCorres.Enabled=true;
			btEdit.Enabled=true;
		}

		private void Save()
		{
			if(nouveau)
			{
				Comm.CommandText="SELECT nom FROM t_fournisseurs WHERE nom='"+txNom.Text.Replace("'","''")+"'";
				DataAD.SelectCommand=Comm;
				if(txNom.Text.Length.Equals(0))
				{
					MessageBox.Show("Champ Nom obligatoire","Attention",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else if(DataAD.Fill(ds,"Fourn")>0)
				{
					MessageBox.Show("Nom de fournisseur déjà existant, veuillez le modifier");
					ds.Tables["fourn"].Clear();
				}
				else
				{
					oleDbConnection1.Open();
					oleDbDataAdapter2.Fill(dataSet11);
					DataRow newrow = dataSet11.Tables["T_fournisseurs"].NewRow();
					newrow["Code"]=txCode.Text;
					newrow["Nom"]=txNom.Text.ToUpper();
					if(txAdresse1.Text.Length.Equals(0))
						newrow["Adresse 1"]="?";
					else
						newrow["Adresse 1"]=txAdresse1.Text.ToUpper();
					if(txAdresse2.Text.Length.Equals(0))
						newrow["Adresse 2"]="?";
					else
						newrow["Adresse 2"]=txAdresse2.Text.ToUpper();
					if(txCP.Text.Length.Equals(0))
						newrow["Code Postal"]="?";
					else
						newrow["Code Postal"]=txCP.Text.ToUpper();
					if(txVille.Text.Length.Equals(0))
						newrow["Ville"]="?";
					else
						newrow["Ville"]=txVille.Text.ToUpper();
					if(txPays.Text.Length.Equals(0))
						newrow["Pays"]="?";
					else
						newrow["Pays"]=txPays.Text.ToUpper();
					if(txTel.Text.Length.Equals(0))
						newrow["Telephone"]="?";
					else
						newrow["Telephone"]=txTel.Text.ToUpper();
					if(txFax.Text.Length.Equals(0))
						newrow["Telecopie"]="?";
					else
						newrow["Telecopie"]=txFax.Text.ToUpper();
					if(txActivite.Text.Length.Equals(0))
						newrow["Activite"]="?";
					else
						newrow["Activite"]=txActivite.Text.ToUpper();
					if(txMemo.Text.Length.Equals(0))
						newrow["Commentaire"]="?";
					else
						newrow["Commentaire"]=txMemo.Text.ToUpper();
					if(txRemise.Text.Length.Equals(0))
						newrow["Pourcentage remise"]=0;
					else
						newrow["Pourcentage remise"]=System.Convert.ToDouble(txRemise.Text.Replace(".",","));
					if(txPAPV.Text.Length.Equals(0))
						newrow["Coef PA PV"]=0;
					else
					{
						newrow["Coef PA PV"]=System.Convert.ToDecimal(txPAPV.Text.Replace(".",","));
					}
					dataSet11.Tables["T_Fournisseurs"].Rows.Add(newrow);
					try
					{
						oleDbDataAdapter2.Update(dataSet11);
						MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
						Nettoyer();
						Desactiver();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					nouveau=false;
				}
			}
			else
			{
				if(MessageBox.Show("Enregistrer les changements ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
				{
					oleDbConnection1.Open();
					OleDbCommand Comm = new OleDbCommand();
					string Nom;
					string Adresse1;
					string Adresse2;
					string CP;
					string Ville;
					string Pays;
					string Telephone;
					string Telecopie;
					string Activite;
					string Remise;
					string PAPV;
					string Memo;
					if(txNom.Text.Length.Equals(0))
						Nom="null";
					else
						Nom=txNom.Text.ToUpper();
					if(txAdresse1.Text.Length.Equals(0))
						Adresse1="?";
					else
						Adresse1=txAdresse1.Text.ToUpper();
					if(txAdresse2.Text.Length.Equals(0))
						Adresse2="?";
					else
						Adresse2=txAdresse2.Text.ToUpper();
					if(txCP.Text.Length.Equals(0))
						CP="?";
					else
						CP=txCP.Text.ToUpper();
					if(txVille.Text.Length.Equals(0))
						Ville="?";
					else
						Ville=txVille.Text.ToUpper();
					if(txPays.Text.Length.Equals(0))
						Pays="?";
					else
						Pays=txPays.Text.ToUpper();
					if(txTel.Text.Length.Equals(0))
						Telephone="?";
					else
						Telephone=txTel.Text.ToUpper();
					if(txFax.Text.Length.Equals(0))
						Telecopie="?";
					else
						Telecopie=txFax.Text.ToUpper();
					if(txActivite.Text.Length.Equals(0))
						Activite="?";
					else
						Activite=txActivite.Text.ToUpper();
					if(txMemo.Text.Length.Equals(0))
						Memo="?";
					else
						Memo=txMemo.Text.ToUpper();
					txRemise.Text=txRemise.Text.Replace(".",",");
					txPAPV.Text=txPAPV.Text.Replace(".",",");
					Double rem=(System.Convert.ToDouble(txRemise.Text)/100);
					Comm.CommandText="UPDATE T_fournisseurs SET [Nom]='"+Nom+"',[Adresse 1]='"+Adresse1.ToUpper().Replace("'","''")+"', [Adresse 2]='"+Adresse2.ToUpper().Replace("'","''")+"',[Code postal]='"+CP.ToUpper()+"',[Ville]='"+Ville.ToUpper().Replace("'","''")+"',[Pays]='"+Pays.ToUpper()+"',[Telephone]='"+Telephone.ToUpper()+"',[Telecopie]='"+Telecopie.ToUpper()+"',[Activite]='"+Activite.ToUpper()+"',[Pourcentage remise]="+rem.ToString().Replace(",",".")+",[Coef PA PV]="+txPAPV.Text.Replace(",",".")+",[Commentaire]='"+Memo.ToUpper()+"' where Code='"+txCode.Text+"'";
					Comm.Connection=oleDbConnection1;
					try
					{
						Comm.ExecuteNonQuery();
						MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
						Nettoyer();
						Desactiver();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
				}
			}
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			Save();
		}

		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Supprimer la fiche fournisseur ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
			{
				Comm.CommandText="DELETE FROM t_fournisseurs WHERE Code='"+txCode.Text+"'";
				try
				{
					oleDbConnection1.Open();
					Transac=oleDbConnection1.BeginTransaction();
					Comm.Transaction=Transac;
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
						MessageBox.Show("Suppression terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					catch(OleDbException ex)
					{
						MessageBox.Show("Erreur dans la base de données");
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
				Nettoyer();
				Desactiver();
			}
		}

		private void Nettoyer()
		{
			txNom.Text="";
			txNom.BackColor=Color.Empty;
			txAdresse1.Text="";
			txAdresse2.Text="";
			txCP.Text="";
			txVille.Text="";
			txCode.Text="";
			txTel.Text="";
			txFax.Text="";
			txPays.Text="FRANCE";
			txRemise.Text="0";
			txActivite.Text="";
			txPAPV.Text="0";
			listView1.Items.Clear();
			nouveau=false;
		}

		private void btSupCorres_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count==0)
				MessageBox.Show("Veuillez selectionnez une ligne !");
			else
			{
				System.Windows.Forms.ListView.SelectedIndexCollection index =listView1.SelectedIndices;
				for(int i=0;i<index.Count;i++)
				{
					if(MessageBox.Show("Etes vous certain de vouloir supprimer l'utilisateur "+listView1.Items[index[i]].Text+" ?","Attention",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
					{
						try
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							ListViewItem Item=(ListViewItem)listView1.SelectedItems[0];
							Comm.CommandText="DELETE FROM t_fournisseurs_corresp WHERE Cle="+Item.Tag.ToString();
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
						catch
						{
						}
						finally
						{
							oleDbConnection1.Close();
						}
						
						listView1.Items.Clear();
						oleDbConnection1.Open();
						OleDbDataAdapter Data1 = new OleDbDataAdapter();
						OleDbCommand Requete = new OleDbCommand();
						Requete.Connection=oleDbConnection1;
						DataSet ds = new DataSet();
						string com="select * from T_fournisseurs_corresp where Code = '"+txCode.Text+"'";
						Requete.CommandText=com;
						Data1.SelectCommand=Requete;
						try
						{
							Data1.Fill(ds,"T_fournisseurs_corresp");
						}
						catch (OleDbException exp)
						{
							MessageBox.Show(exp.Message);
						}
						DataTable Table = ds.Tables["T_fournisseurs_corresp"];
						foreach (DataRow row in Table.Rows)
						{
							ListViewItem Corres= new ListViewItem(row["Nom"].ToString());
							if(row["Prenom"].ToString()!="?")
								Corres.SubItems.Add(row["Prenom"].ToString());
                            else
                                Corres.SubItems.Add(" ");
							if(row["Telephone"].ToString()!="?")
								Corres.SubItems.Add(row["Telephone"].ToString());
                            else
                                Corres.SubItems.Add(" ");
							if(row["Telecopie"].ToString()!="?")
								Corres.SubItems.Add(row["Telecopie"].ToString());
                            else
                                Corres.SubItems.Add(" ");
                            if (row["E_mail"].ToString() != "?")
                                Corres.SubItems.Add(row["E_mail"].ToString());
                            else
                                Corres.SubItems.Add(" ");
							Corres.Tag=row["cle"].ToString();
							listView1.Items.Add(Corres);
						}
						oleDbConnection1.Close();
					}
				}
			}
		}

		private void btEdit_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count==0)
				MessageBox.Show("Veuillez selectionner une ligne !");
			else
			{
				oleDbConnection1.Open();
				ListViewItem Item = (ListViewItem)listView1.SelectedItems[0];
				string com="select * from T_fournisseurs_corresp where Cle = "+Item.Tag.ToString();
				OleDbCommand Requete = new OleDbCommand();
				Requete.Connection=oleDbConnection1;
				Requete.CommandText=com;
				oleDbDataAdapter1.SelectCommand=Requete;
				try
				{
					if(oleDbDataAdapter1.Fill(dataSet11)>0)
					{
						DataTable Table = dataSet11.Tables["T_fournisseurs_corresp"];
						NomCorres=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Nom"].ToString();
						PrenomCorres=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Prenom"].ToString();
						Mel=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["E_mail"].ToString();
						Tel=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Telephone"].ToString();
						Fax=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["telecopie"].ToString();
						Service=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Service"].ToString();
						Fonction=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Fonction"].ToString();
						Note=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Memo"].ToString();
						IDRow=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Cle"].ToString();
						InfoCorres WinInfo = new InfoCorres(Agence,false,IDRow,txNom.Text, txCode.Text, NomCorres, PrenomCorres, Mel, Tel, Fax, Service, Fonction, Note,Pays);
						oleDbConnection1.Close();
						WinInfo.ShowDialog();
						dataSet11.Tables["T_fournisseurs_corresp"].Clear();
					}
				}
				catch (OleDbException exp)
				{
					MessageBox.Show(exp.Message);
				}
				listView1.Items.Clear();
				this.Update();
				dataSet11.Clear();
				oleDbConnection1.Open();
				string com2="select * from T_fournisseurs_corresp where Code='"+txCode.Text+"'";
				Requete.CommandText=com2;
				Requete.Connection=oleDbConnection1;
				oleDbDataAdapter1.SelectCommand=Requete;
				try
				{
					oleDbDataAdapter1.Fill(dataSet11);
				}
				catch (OleDbException exp)
				{
					MessageBox.Show(exp.Message);
				}
				DataTable Table2 = dataSet11.Tables["T_fournisseurs_corresp"];
				foreach (DataRow row in Table2.Rows)
				{
					ListViewItem Corres= new ListViewItem(row["Nom"].ToString());
					if(row["Prenom"].ToString()!="?")
						Corres.SubItems.Add(row["Prenom"].ToString());
					else
						Corres.SubItems.Add(" ");
					if(row["Telephone"].ToString()!="?")
						Corres.SubItems.Add(row["Telephone"].ToString());
					else
						Corres.SubItems.Add(" ");
					if(row["Telecopie"].ToString()!="?")
						Corres.SubItems.Add(row["Telecopie"].ToString());
					else
						Corres.SubItems.Add(" ");
                    if (row["E_mail"].ToString() != "?")
                        Corres.SubItems.Add(row["E_mail"].ToString());
                    else
                        Corres.SubItems.Add(" ");
					Corres.Tag=row["cle"].ToString();
					listView1.Items.Add(Corres);
				}
				oleDbConnection1.Close();
			}
		}

		private void tabPage1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txPays_TextChanged(object sender, System.EventArgs e)
		{
			if(txPays.Text!="FRANCE")
			{
				txTel.MaxLength=20;
				txFax.MaxLength=20;
			}
			else
			{
				txTel.MaxLength=10;
				txFax.MaxLength=10;
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			//printForm1.BodyContainer=panel1;
			//printPreviewDialog1.Document=printForm1;
			//printPreviewDialog1.ShowDialog();
		}

		private void cbRechercheFourn_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13)&&cbRechercheFourn.SelectedIndex>0)
			{
				dataSet11.Tables["t_fournisseurs"].Clear();
				oleDbSelectCommand2.CommandText="select * from t_fournisseurs where nom='"+cbRechercheFourn.Text+"'";
				oleDbDataAdapter2.Fill(dataSet11);
				DataRow SelRow=dataSet11.Tables["t_fournisseurs"].Rows[0];
				Activer();
				listView1.Items.Clear();
				btEnregistre.Enabled=true;
				txNom.Text=SelRow["Nom"].ToString();
				txAdresse1.Text=SelRow["Adresse 1"].ToString();
				txAdresse2.Text=SelRow["Adresse 2"].ToString();
				txCP.Text=SelRow["Code Postal"].ToString();
				txVille.Text=SelRow["Ville"].ToString();
				txActivite.Text=SelRow["Activite"].ToString();
				txTel.Text=SelRow["Telephone"].ToString();
				txFax.Text=SelRow["Telecopie"].ToString();
				txPays.Text=SelRow["Pays"].ToString();
				txCode.Text=SelRow["Code"].ToString();
				Decimal pourcent=System.Convert.ToDecimal(SelRow["Pourcentage remise"].ToString())*100;
				txRemise.Text=pourcent.ToString();
				txPAPV.Text=SelRow["Coef PA PV"].ToString();
				txMemo.Text=SelRow["Commentaire"].ToString();
				dataSet11.Tables["t_fournisseurs_corresp"].Clear();
				this.Refresh();
				oleDbConnection1.Open();
				OleDbCommand Comm = new OleDbCommand();
				Comm.CommandText="select * from t_fournisseurs_corresp where code='"+txCode.Text+"'";
				Comm.Connection=oleDbConnection1;
				oleDbDataAdapter1.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter1.Fill(dataSet11,"T_fournisseurs_corresp");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				foreach(DataRow row in dataSet11.Tables["T_fournisseurs_corresp"].Rows)
				{
					ListViewItem Corres= new ListViewItem(row["Nom"].ToString());
					if(row["Prenom"].ToString()!="?")
						Corres.SubItems.Add(row["Prenom"].ToString());
					else
						Corres.SubItems.Add(" ");
					if(row["Telephone"].ToString()!="?")
						Corres.SubItems.Add(row["Telephone"].ToString());
					else
						Corres.SubItems.Add(" ");
					if(row["Telecopie"].ToString()!="?")
						Corres.SubItems.Add(row["Telecopie"].ToString());
					else
						Corres.SubItems.Add(" ");
                    if (row["E_mail"].ToString() != "?")
                        Corres.SubItems.Add(row["E_mail"].ToString());
                    else
                        Corres.SubItems.Add(" ");
					Corres.Tag=row["cle"].ToString();
					listView1.Items.Add(Corres);
				}
				oleDbConnection1.Close();
				this.Refresh();
				dataSet11.Tables["t_devis_entete"].Clear();
				oleDbConnection1.Close();
				int annee_encours=DateTime.Now.Year;
				int annee_1=DateTime.Now.Year-1;
				int annee_2=DateTime.Now.Year-2;
				int annee_3=DateTime.Now.Year-3;
				int annee_4=DateTime.Now.Year-4;
				decimal Total_Annee_en_cours=0;
				decimal Total_Annee_1=0;
				decimal Total_Annee_2=0;
				decimal Total_Annee_3=0;
				decimal Total_Annee_4=0;
				DataAD=new OleDbDataAdapter();
				ds= new DataSet();
				//Comm.CommandText="select Sum([Total Devis]) AS [SommeTotal] FROM T_devis_entete where T_devis_entete.[niveau]=7";
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_encours+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_encours+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				Decimal PrixAchat=0;
				Decimal Qte=0;
				Decimal TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
					Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
					TotalAchat+=PrixAchat*Qte;
					PrixAchat=0;
					Qte=0;
				}
				Total_Annee_en_cours=TotalAchat;
				ds.Tables["stats"].Clear();
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_1+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_1+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				PrixAchat=0;
				Qte=0;
				TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					try
					{
						PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
						Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
						TotalAchat+=PrixAchat*Qte;
						PrixAchat=0;
						Qte=0;
					}
					catch(Exception exp)
					{
						Console.WriteLine(rowDate.ToString());
					}
				}
				Total_Annee_1=TotalAchat;
				ds.Tables["stats"].Clear();
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_2+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_2+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				PrixAchat=0;
				Qte=0;
				TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					try
					{
					PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
					Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
					TotalAchat+=PrixAchat*Qte;
					PrixAchat=0;
					Qte=0;
					}
					catch(Exception exp)
					{
						Console.WriteLine(rowDate.ToString());
					}
				}
				Total_Annee_2=TotalAchat;
				ds.Tables["stats"].Clear();
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_3+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_3+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				PrixAchat=0;
				Qte=0;
				TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					try
					{
					PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
					Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
					TotalAchat+=PrixAchat*Qte;
					PrixAchat=0;
					Qte=0;
					}
					catch(Exception exp)
					{
						Console.WriteLine(rowDate.ToString());
					}
				}
				Total_Annee_3=TotalAchat;
				ds.Tables["stats"].Clear();
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_4+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_4+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				PrixAchat=0;
				Qte=0;
				TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					try
					{
					PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
					Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
					TotalAchat+=PrixAchat*Qte;
					PrixAchat=0;
					Qte=0;
					}
					catch(Exception exp)
					{
						Console.WriteLine(rowDate.ToString());
					}
				}
				Total_Annee_4=TotalAchat;
				ds.Tables["stats"].Clear();
				this.Refresh();
				ChartLoader chartLoader= chartControl1.getChartLoader();
				// set chart parameters 
				chartLoader.clearParams();
				chartLoader.setParameter("TITLECHART",txNom.Text); 
				chartLoader.setParameter("XLABEL","Années"); 
				chartLoader.setParameter("YLABEL","Chiffre d'affaires"); 
				chartLoader.setParameter("XSCALE_MIN","0"); 
				chartLoader.setParameter("XSCALE_MAX","5.5"); 
				chartLoader.setParameter("YSCALE_MIN","0"); 
				chartLoader.setParameter("BIG_TICK_INTERVALX","1");  
				chartLoader.setParameter("XAXIS_LABELS","En cours|N-1|N-2|N-3|N-4"); 
				chartLoader.setParameter("CERO_XAXIS","LINE"); 
				chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
				chartLoader.setParameter("SERIE_1","Chiffre d'affaires"); 
				chartLoader.setParameter("LEGEND","FALSE");
				chartLoader.setParameter("LEFT_MARGIN","0.20");
				chartLoader.setParameter("SERIE_TYPE_1","BAR");
				chartLoader.setParameter("YAXIS_AUTO_TICKS","10");
				chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","1000");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("SERIE_FONT_1","Arial|PLAIN|8"); 
				string chiffres=Total_Annee_en_cours.ToString()+"|"+Total_Annee_1.ToString()+"|"+Total_Annee_2.ToString()+"|"+Total_Annee_3.ToString()+"|"+Total_Annee_4.ToString();
				chartLoader.setParameter("SERIE_DATA_1",chiffres); 
				chartLoader.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
				chartLoader.setParameter("SERIE_BAR_STYLE_1","ff"); 
				chartLoader.setParameter("BARCHART_BARSPACE","20"); 
				chartLoader.setParameter("BARCHART_BARWIDTH","50");
				chartLoader.setParameter("CHART_FILL","ffcc00"); 
				chartLoader.setParameter("YLABEL_VERTICAL","TRUE"); 
				chartLoader.setParameter("YAXIS_TICKATBASE","true");
				// create chart 
				chartControl1.buildChart();
				this.Refresh();
				chartControl1.Visible=true;
			}
			/*catch(Exception exp)
			{
					decimal Total_Annee_en_cours=0;
					decimal Total_Annee_1=0;
					decimal Total_Annee_2=0;
					decimal Total_Annee_3=0;
					decimal Total_Annee_4=0;
					int annee_encours=DateTime.Now.Year;
					int annee_1=DateTime.Now.Year-1;
					int annee_2=DateTime.Now.Year-2;
					int annee_3=DateTime.Now.Year-3;
					int annee_4=DateTime.Now.Year-4;
					foreach(DataRow rowDate in dataSet11.Tables["t_devis_entete"].Rows)
					{
						if(rowDate["Date reparation"].ToString().Length>0)
						{
							if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_encours.ToString()))
							{
								Total_Annee_en_cours+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
							else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_1.ToString()))
							{
								Total_Annee_1+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
							else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_2.ToString()))
							{
								Total_Annee_2+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
							else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_3.ToString()))
							{
								Total_Annee_3+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
							else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_4.ToString()))
							{
								Total_Annee_4+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
						}
					}
					this.Refresh();
					//MessageBox.Show(Total_Annee_en_cours.ToString());
					ChartLoader chartLoader= chartControl1.getChartLoader();
					// set chart parameters 
					chartLoader.clearParams();
					chartLoader.setParameter("TITLECHART",txNom.Text); 
					chartLoader.setParameter("XLABEL","Années"); 
					chartLoader.setParameter("YLABEL","Chiffre d'affaires"); 
					chartLoader.setParameter("XSCALE_MIN","0"); 
					chartLoader.setParameter("XSCALE_MAX","5.5"); 
					chartLoader.setParameter("YSCALE_MIN","0"); 
					chartLoader.setParameter("BIG_TICK_INTERVALX","1");  
					chartLoader.setParameter("XAXIS_LABELS","En cours|N-1|N-2|N-3|N-4"); 
					chartLoader.setParameter("CERO_XAXIS","LINE"); 
					chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
					chartLoader.setParameter("SERIE_1","Chiffre d'affaires"); 
					chartLoader.setParameter("LEGEND","FALSE");
					chartLoader.setParameter("LEFT_MARGIN","0.20");
					chartLoader.setParameter("SERIE_TYPE_1","BAR");
					chartLoader.setParameter("YAXIS_AUTO_TICKS","10");
					chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","1000");
					chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
					chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
					chartLoader.setParameter("SERIE_FONT_1","Arial|PLAIN|8"); 
					string chiffres=Total_Annee_en_cours.ToString()+"|"+Total_Annee_1.ToString()+"|"+Total_Annee_2.ToString()+"|"+Total_Annee_3.ToString()+"|"+Total_Annee_4.ToString();
					chartLoader.setParameter("SERIE_DATA_1",chiffres); 
					chartLoader.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
					chartLoader.setParameter("SERIE_BAR_STYLE_1","ff"); 
					chartLoader.setParameter("BARCHART_BARSPACE","20"); 
					chartLoader.setParameter("BARCHART_BARWIDTH","50");
					chartLoader.setParameter("CHART_FILL","ffcc00"); 
					chartLoader.setParameter("YLABEL_VERTICAL","TRUE"); 
					chartLoader.setParameter("YAXIS_TICKATBASE","true");
					// create chart 
					chartControl1.buildChart();
					this.Refresh();
					chartControl1.Visible=true;
				}
				*/
		}

		private void SaisieFournisseurs_VisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible.Equals(true))
				InitializeData();
		}

		private void txNom_Enter(object sender, System.EventArgs e)
		{
			if(cbRechercheFourn.SelectedIndex>0)
			{
				dataSet11.Tables["t_fournisseurs"].Clear();
				oleDbSelectCommand2.CommandText="select * from t_fournisseurs where nom='"+cbRechercheFourn.Text+"'";
				oleDbDataAdapter2.Fill(dataSet11);
				DataRow SelRow=dataSet11.Tables["t_fournisseurs"].Rows[0];
				Activer();
				listView1.Items.Clear();
				btEnregistre.Enabled=true;
				txNom.Text=SelRow["Nom"].ToString();
				txAdresse1.Text=SelRow["Adresse 1"].ToString();
				txAdresse2.Text=SelRow["Adresse 2"].ToString();
				txCP.Text=SelRow["Code Postal"].ToString();
				txVille.Text=SelRow["Ville"].ToString();
				txActivite.Text=SelRow["Activite"].ToString();
				txTel.Text=SelRow["Telephone"].ToString();
				txFax.Text=SelRow["Telecopie"].ToString();
				txPays.Text=SelRow["Pays"].ToString();
				txCode.Text=SelRow["Code"].ToString();
				Decimal pourcent=System.Convert.ToDecimal(SelRow["Pourcentage remise"].ToString())*100;
				txRemise.Text=pourcent.ToString();
				txPAPV.Text=SelRow["Coef PA PV"].ToString();
				txMemo.Text=SelRow["Commentaire"].ToString();
				dataSet11.Tables["t_fournisseurs_corresp"].Clear();
				this.Refresh();
				oleDbConnection1.Open();
				OleDbCommand Comm = new OleDbCommand();
				Comm.CommandText="select * from t_fournisseurs_corresp where code='"+txCode.Text+"'";
				Comm.Connection=oleDbConnection1;
				oleDbDataAdapter1.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter1.Fill(dataSet11,"T_fournisseurs_corresp");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				foreach(DataRow row in dataSet11.Tables["T_fournisseurs_corresp"].Rows)
				{
					ListViewItem Corres= new ListViewItem(row["Nom"].ToString());
					Corres.SubItems.Add(row["Prenom"].ToString());
					Corres.SubItems.Add(row["Telephone"].ToString());
					Corres.SubItems.Add(row["Telecopie"].ToString());
					Corres.Tag=row["cle"].ToString();
					listView1.Items.Add(Corres);
				}
				oleDbConnection1.Close();
				this.Refresh();
				dataSet11.Tables["t_devis_entete"].Clear();
				oleDbConnection1.Close();
				int annee_encours=DateTime.Now.Year;
				int annee_1=DateTime.Now.Year-1;
				int annee_2=DateTime.Now.Year-2;
				int annee_3=DateTime.Now.Year-3;
				int annee_4=DateTime.Now.Year-4;
				decimal Total_Annee_en_cours=0;
				decimal Total_Annee_1=0;
				decimal Total_Annee_2=0;
				decimal Total_Annee_3=0;
				decimal Total_Annee_4=0;
				DataAD=new OleDbDataAdapter();
				ds= new DataSet();
				//Comm.CommandText="select Sum([Total Devis]) AS [SommeTotal] FROM T_devis_entete where T_devis_entete.[niveau]=7";
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_encours+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_encours+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				Decimal PrixAchat=0;
				Decimal Qte=0;
				Decimal TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
					Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
					TotalAchat+=PrixAchat*Qte;
					PrixAchat=0;
					Qte=0;
				}
				Total_Annee_en_cours=TotalAchat;
				ds.Tables["stats"].Clear();
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_1+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_1+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				PrixAchat=0;
				Qte=0;
				TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
					Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
					TotalAchat+=PrixAchat*Qte;
					PrixAchat=0;
					Qte=0;
				}
				Total_Annee_1=TotalAchat;
				ds.Tables["stats"].Clear();
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_2+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_2+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				PrixAchat=0;
				Qte=0;
				TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
					Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
					TotalAchat+=PrixAchat*Qte;
					PrixAchat=0;
					Qte=0;
				}
				Total_Annee_2=TotalAchat;
				ds.Tables["stats"].Clear();
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_3+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_3+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				PrixAchat=0;
				Qte=0;
				TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
					Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
					TotalAchat+=PrixAchat*Qte;
					PrixAchat=0;
					Qte=0;
				}
				Total_Annee_3=TotalAchat;
				ds.Tables["stats"].Clear();
				Comm.CommandText="SELECT T_fournisseurs.Nom, T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite FROM T_fournisseurs INNER JOIN (T_devis_entete INNER JOIN (T_pieces_detachees INNER JOIN T_devis_lignes ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE T_fournisseurs.Nom='"+txNom.Text+"' GROUP BY T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_lignes.[Prix achat net], T_devis_lignes.Quantite HAVING (((T_devis_entete.[Date reparation])>=#01/01/"+annee_4+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_4+"#))"; 

				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"stats");
				PrixAchat=0;
				Qte=0;
				TotalAchat=0;
				foreach(DataRow rowDate in ds.Tables["stats"].Rows)
				{
					PrixAchat=System.Convert.ToDecimal(rowDate["prix achat net"].ToString());
					Qte=System.Convert.ToDecimal(rowDate["Quantite"].ToString());
					TotalAchat+=PrixAchat*Qte;
					PrixAchat=0;
					Qte=0;
				}
				Total_Annee_4=TotalAchat;
				ds.Tables["stats"].Clear();
				this.Refresh();
				ChartLoader chartLoader= chartControl1.getChartLoader();
				// set chart parameters 
				chartLoader.clearParams();
				chartLoader.setParameter("TITLECHART",txNom.Text); 
				chartLoader.setParameter("XLABEL","Années"); 
				chartLoader.setParameter("YLABEL","Chiffre d'affaires"); 
				chartLoader.setParameter("XSCALE_MIN","0"); 
				chartLoader.setParameter("XSCALE_MAX","5.5"); 
				chartLoader.setParameter("YSCALE_MIN","0"); 
				chartLoader.setParameter("BIG_TICK_INTERVALX","1");  
				chartLoader.setParameter("XAXIS_LABELS","En cours|N-1|N-2|N-3|N-4"); 
				chartLoader.setParameter("CERO_XAXIS","LINE"); 
				chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
				chartLoader.setParameter("SERIE_1","Chiffre d'affaires"); 
				chartLoader.setParameter("LEGEND","FALSE");
				chartLoader.setParameter("LEFT_MARGIN","0.20");
				chartLoader.setParameter("SERIE_TYPE_1","BAR");
				chartLoader.setParameter("YAXIS_AUTO_TICKS","10");
				chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","1000");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("SERIE_FONT_1","Arial|PLAIN|8"); 
				string chiffres=Total_Annee_en_cours.ToString()+"|"+Total_Annee_1.ToString()+"|"+Total_Annee_2.ToString()+"|"+Total_Annee_3.ToString()+"|"+Total_Annee_4.ToString();
				chartLoader.setParameter("SERIE_DATA_1",chiffres); 
				chartLoader.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
				chartLoader.setParameter("SERIE_BAR_STYLE_1","ff"); 
				chartLoader.setParameter("BARCHART_BARSPACE","20"); 
				chartLoader.setParameter("BARCHART_BARWIDTH","50");
				chartLoader.setParameter("CHART_FILL","ffcc00"); 
				chartLoader.setParameter("YLABEL_VERTICAL","TRUE"); 
				chartLoader.setParameter("YAXIS_TICKATBASE","true");
				// create chart 
				chartControl1.buildChart();
				this.Refresh();
				chartControl1.Visible=true;
			}
			/*catch(Exception exp)
			{
					decimal Total_Annee_en_cours=0;
					decimal Total_Annee_1=0;
					decimal Total_Annee_2=0;
					decimal Total_Annee_3=0;
					decimal Total_Annee_4=0;
					int annee_encours=DateTime.Now.Year;
					int annee_1=DateTime.Now.Year-1;
					int annee_2=DateTime.Now.Year-2;
					int annee_3=DateTime.Now.Year-3;
					int annee_4=DateTime.Now.Year-4;
					foreach(DataRow rowDate in dataSet11.Tables["t_devis_entete"].Rows)
					{
						if(rowDate["Date reparation"].ToString().Length>0)
						{
							if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_encours.ToString()))
							{
								Total_Annee_en_cours+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
							else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_1.ToString()))
							{
								Total_Annee_1+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
							else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_2.ToString()))
							{
								Total_Annee_2+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
							else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_3.ToString()))
							{
								Total_Annee_3+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
							else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_4.ToString()))
							{
								Total_Annee_4+=System.Convert.ToDecimal(rowDate["Prix Achat Net"].ToString())*(System.Convert.ToDecimal(rowDate["Quantite"].ToString()));
							}
						}
					}
					this.Refresh();
					//MessageBox.Show(Total_Annee_en_cours.ToString());
					ChartLoader chartLoader= chartControl1.getChartLoader();
					// set chart parameters 
					chartLoader.clearParams();
					chartLoader.setParameter("TITLECHART",txNom.Text); 
					chartLoader.setParameter("XLABEL","Années"); 
					chartLoader.setParameter("YLABEL","Chiffre d'affaires"); 
					chartLoader.setParameter("XSCALE_MIN","0"); 
					chartLoader.setParameter("XSCALE_MAX","5.5"); 
					chartLoader.setParameter("YSCALE_MIN","0"); 
					chartLoader.setParameter("BIG_TICK_INTERVALX","1");  
					chartLoader.setParameter("XAXIS_LABELS","En cours|N-1|N-2|N-3|N-4"); 
					chartLoader.setParameter("CERO_XAXIS","LINE"); 
					chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
					chartLoader.setParameter("SERIE_1","Chiffre d'affaires"); 
					chartLoader.setParameter("LEGEND","FALSE");
					chartLoader.setParameter("LEFT_MARGIN","0.20");
					chartLoader.setParameter("SERIE_TYPE_1","BAR");
					chartLoader.setParameter("YAXIS_AUTO_TICKS","10");
					chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","1000");
					chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
					chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
					chartLoader.setParameter("SERIE_FONT_1","Arial|PLAIN|8"); 
					string chiffres=Total_Annee_en_cours.ToString()+"|"+Total_Annee_1.ToString()+"|"+Total_Annee_2.ToString()+"|"+Total_Annee_3.ToString()+"|"+Total_Annee_4.ToString();
					chartLoader.setParameter("SERIE_DATA_1",chiffres); 
					chartLoader.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
					chartLoader.setParameter("SERIE_BAR_STYLE_1","ff"); 
					chartLoader.setParameter("BARCHART_BARSPACE","20"); 
					chartLoader.setParameter("BARCHART_BARWIDTH","50");
					chartLoader.setParameter("CHART_FILL","ffcc00"); 
					chartLoader.setParameter("YLABEL_VERTICAL","TRUE"); 
					chartLoader.setParameter("YAXIS_TICKATBASE","true");
					// create chart 
					chartControl1.buildChart();
					this.Refresh();
					chartControl1.Visible=true;
				}
				*/
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count==0)
				MessageBox.Show("Veuillez selectionner une ligne !");
			else
			{
				oleDbConnection1.Open();
				ListViewItem Item = (ListViewItem)listView1.SelectedItems[0];
				string com="select * from T_fournisseurs_corresp where Cle = "+Item.Tag.ToString();
				OleDbCommand Requete = new OleDbCommand();
				Requete.Connection=oleDbConnection1;
				Requete.CommandText=com;
				oleDbDataAdapter1.SelectCommand=Requete;
				try
				{
					if(oleDbDataAdapter1.Fill(dataSet11)>0)
					{
						DataTable Table = dataSet11.Tables["T_fournisseurs_corresp"];
						NomCorres=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Nom"].ToString();
						PrenomCorres=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Prenom"].ToString();
						Mel=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["E_mail"].ToString();
						Tel=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Telephone"].ToString();
						Fax=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["telecopie"].ToString();
						Service=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Service"].ToString();
						Fonction=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Fonction"].ToString();
						Note=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Memo"].ToString();
						IDRow=dataSet11.Tables["T_fournisseurs_corresp"].Rows[0]["Cle"].ToString();
						InfoCorres WinInfo = new InfoCorres(Agence,false,IDRow,txNom.Text, txCode.Text, NomCorres, PrenomCorres, Mel, Tel, Fax, Service, Fonction, Note,Pays);
						oleDbConnection1.Close();
						WinInfo.ShowDialog();
						dataSet11.Tables["T_fournisseurs_corresp"].Clear();
					}
				}
				catch (OleDbException exp)
				{
					MessageBox.Show(exp.Message);
				}
				
				listView1.Items.Clear();
				this.Update();
				dataSet11.Clear();
				oleDbConnection1.Open();
				string com2="select * from T_fournisseurs_corresp where Code='"+txCode.Text+"'";
				Requete.CommandText=com2;
				Requete.Connection=oleDbConnection1;
				oleDbDataAdapter1.SelectCommand=Requete;
				try
				{
					oleDbDataAdapter1.Fill(dataSet11);
				}
				catch (OleDbException exp)
				{
					MessageBox.Show(exp.Message);
				}
				DataTable Table2 = dataSet11.Tables["T_fournisseurs_corresp"];
				foreach (DataRow row in Table2.Rows)
				{
					ListViewItem Corres= new ListViewItem(row["Nom"].ToString());
					if(row["Prenom"].ToString()!="?")
						Corres.SubItems.Add(row["Prenom"].ToString());
					else
						Corres.SubItems.Add(" ");
					if(row["Telephone"].ToString()!="?")
						Corres.SubItems.Add(row["Telephone"].ToString());
					else
						Corres.SubItems.Add(" ");
					if(row["Telecopie"].ToString()!="?")
						Corres.SubItems.Add(row["Telecopie"].ToString());
					else
						Corres.SubItems.Add(" ");
                    if (row["E_mail"].ToString() != "?")
                        Corres.SubItems.Add(row["E_mail"].ToString());
                    else
                        Corres.SubItems.Add(" ");
					Corres.Tag=row["cle"].ToString();
					listView1.Items.Add(Corres);
				}
				oleDbConnection1.Close();
				dataSet11.Tables["T_fournisseurs_corresp"].Clear();
			}
		}
	}

}