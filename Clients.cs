using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using J4L.RChart;
using System.Threading;

namespace Opindus
{
	/// <summary>
	/// Description résumée de Clients.
	/// </summary>
	public class Clients : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txNom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txCodeGestion;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btCrea1;
		private System.Windows.Forms.Button btCrea2;
		private System.Windows.Forms.TextBox txBatiment;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txAdresse1;
		private System.Windows.Forms.TextBox txAdresse2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txVille;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txPays;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txTel;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txFax;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txIdent;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListView lvCorres;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button btNewCorres;
		private System.Windows.Forms.Button btSupCorres;
		private System.Windows.Forms.Button button3;
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
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txPourcentage;
		private System.Windows.Forms.TextBox txrRegl;
		private System.Windows.Forms.TextBox txTrans;
		private System.Windows.Forms.TextBox txFourn;
		private System.Windows.Forms.Button btRegl;
		private System.Windows.Forms.Button btTrans;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txSeuil;
		private System.Windows.Forms.TextBox txGarantie;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.TextBox txCde;
		private System.Windows.Forms.TextBox txForfaitDNR;
		private System.Windows.Forms.TextBox txControle;
		private System.Windows.Forms.TextBox txForfaitTrans;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox txCoefDNR;
		private System.Windows.Forms.TextBox txCoefControle;
		private System.Windows.Forms.TextBox txCoefTrans;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TextBox txBorne;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ListView lvDevis;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.Button button2;
		private ArrayList ListesDevis;
		private bool save;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox txCommentaire;
		private System.Windows.Forms.Button btMachineEnParc;
		private System.Windows.Forms.Button btMachineHorsParc;
		private System.Windows.Forms.ListView lvMachines;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.ListView lvInter;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader17;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private System.Windows.Forms.Label label33;
		private string Identite;
		private bool Nouveau;
		private DataRow row;
		private System.Windows.Forms.Label label34;
		private int Agence;
		private System.Windows.Forms.TextBox txCodePostal;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label36;
		private J4L.RChart.ChartControl chartControl2;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private MTGCComboBox cbRechercheClient;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private Dotnetrix.Controls.TabPageEX tabPageEX4;
		private Dotnetrix.Controls.TabPageEX tabPageEX5;
		private Dotnetrix.Controls.TabPageEX tabPageEX6;
		private Dotnetrix.Controls.TabPageEX tabPageEX7;
		private System.Windows.Forms.ColumnHeader columnHeader20;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Dotnetrix.Controls.TabControlEX tabControlEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX8;
		private Dotnetrix.Controls.TabPageEX tabPageEX9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Panel panel1;
		private J4L.RChart.ChartControl chartControl1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button7;
		private MTGCComboBox mtgcComboBox2;
		private System.ComponentModel.IContainer components;
		private MTGCComboBox mtgcComboBox3;
		private System.Windows.Forms.Button button8;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private DetailDevis WinDetailDevis;
		private int Page;
		private int countRow;
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private OleDbTransaction Transac;
		private System.Windows.Forms.Button btClients;
		private System.Windows.Forms.Button button6;
		private System.Drawing.Printing.PrintDocument printDocument2;
		Object oRien=System.Reflection.Missing.Value;
		private DataRow[] foundRows;

		
		public Clients(int Agence,bool New)
		{
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

			InitializeData();
			
			countRow=0;
			save=false;
			Nouveau=New;
			if(New)
			{
				Nettoyage();
				Activation();
				txNom.BackColor=Color.MistyRose;
				txNom.Focus();
				groupBox1.BackColor=Color.SteelBlue;
				cbRechercheClient.Visible=false;
				label1.Visible=false;
				label34.Visible=true;
				btNouveau.Enabled=false;
				int cpt=0;
				Nouveau=true;
				btEnregistre.Enabled=true;
				Comm.CommandText="SELECT Max(t_clients.Ident) AS MaxClient FROM T_clients";
				try
				{
					oleDbConnection1.Open();
					cpt=(int)Comm.ExecuteScalar();
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				finally
				{
					oleDbConnection1.Close();
				}
				cpt++;
				txIdent.Text=cpt.ToString();
			}
			tabControlEX1.SelectedTab=tabPageEX1;
			WinDetailDevis = new DetailDevis(Agence,"");
			txNom.Focus();
		}

		public Clients(int Agence,string Ident)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			DataAD=new OleDbDataAdapter();
			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			ds=new DataSet();

			this.Agence=Agence;
			if(Agence.Equals(1))
			{
				try
				{
					oleDbConnection1.ConnectionString=@"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
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

			Identite=Ident;
			
			InitClient(Identite);
			Nouveau=false;
			WinDetailDevis = new DetailDevis(Agence,"");
			tabControlEX1.SelectedTab=tabPageEX1;
			btEnregistre.Enabled=true;
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
			Page=0;
			countRow=0;
			cbRechercheClient.Items.Clear();
			mtgcComboBox1.Items.Clear();
			mtgcComboBox2.Items.Clear();
			ListesDevis = new ArrayList();

			Comm.CommandText="SELECT Code, Designation FROM T_Groupes ORDER BY Code";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_groupes");
			mtgcComboBox1.SourceDataTable=ds.Tables["t_groupes"];
			mtgcComboBox1.SourceDataString = new string[]{"Code","designation","",""};
			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox1.SelectedIndex=0;
			ds.Tables["t_groupes"].Clear();

			Comm.CommandText="SELECT Code_usine, Designation FROM T_usine ORDER BY Code_usine";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_usine");
			mtgcComboBox2.SourceDataTable=ds.Tables["t_usine"];
			mtgcComboBox2.SourceDataString = new string[]{"Code_usine","designation","",""};
			mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox2.SelectedIndex=0;
			ds.Tables["t_usine"].Clear();

			Comm.CommandText="select nom, adresse_1, code_postal, ville from t_clients order by nom";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_clients");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			cbRechercheClient.SourceDataTable=ds.Tables["t_clients"];
			cbRechercheClient.SourceDataString = new string[]{"nom","adresse_1","code_postal","ville"};
			cbRechercheClient.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			cbRechercheClient.SelectedIndex=0;
			ds.Tables["t_clients"].Clear();

		}
		private void InitClient(string Ident)
		{
			Comm.CommandText="select * from T_clients where Ident="+System.Convert.ToInt32(Ident);
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"T_clients");
			}
			catch (OleDbException exp)
			{
				MessageBox.Show(exp.Message);
			}
			DataTable Table = ds.Tables["T_clients"];
			Nettoyage();
			Activation();
			DataRow row = ds.Tables["T_clients"].Rows[0];
			txNom.Text=row["Nom"].ToString();
			txCodeGestion.Text=row["Code_GC"].ToString();
			txAdresse1.Text=row["Adresse_1"].ToString();
			txAdresse2.Text=row["Adresse_2"].ToString();
			txCodePostal.Text=row["Code_Postal"].ToString();
			txVille.Text=row["Ville"].ToString();
			txPays.Text=row["Pays"].ToString();
			txTel.Text=row["Telephone"].ToString();
			txFax.Text=row["telecopie"].ToString();
			txCodeGestion.Text=row["code_GC"].ToString();
			txIdent.Text=row["Ident"].ToString();
			mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindString(row["Groupe"].ToString());
			mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindStringExact(row["Usine"].ToString());
			txBatiment.Text=row["Batiment"].ToString();
			txPourcentage.Text=row["Pourcentage_remise"].ToString();
			txrRegl.Text=row["Code_reglement"].ToString();
			txTrans.Text=row["Code_transport"].ToString();
			txFourn.Text=row["Notre_code_fournisseur"].ToString();
			txCde.Text=row["N°_cde_ouverte"].ToString();
			txForfaitDNR.Text=row["Forfait_dnr"].ToString();
			txControle.Text=row["Forfait_controle"].ToString();
			txForfaitTrans.Text=row["Forfait_transport"].ToString();
			txCoefDNR.Text=row["Coef_dnr"].ToString();
			txCoefControle.Text=row["Coef_controle"].ToString();
			txCoefTrans.Text=row["Coef_transport"].ToString();
			txSeuil.Text=row["Seuil_reparation"].ToString();
			txGarantie.Text=row["Delai_garantie"].ToString();
			txBorne.Text=DateTime.Now.ToShortDateString();
			txCommentaire.Text=row["Commentaire"].ToString();
			this.Refresh();
			ds.Tables["t_clients"].Clear();

			Comm.CommandText="select * from T_clients_coressp where Ident = "+txIdent.Text;
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"T_clients_coressp");
			}
			catch (OleDbException exp)
			{
				MessageBox.Show(exp.Message);
			}
			Table = ds.Tables["T_clients_coressp"];
			foreach (DataRow rowSel in Table.Rows)
			{
				ListViewItem item = new ListViewItem(rowSel["Nom"].ToString());
				if(rowSel["Prenom"].ToString()!="?")
					item.SubItems.Add(rowSel["Prenom"].ToString());
				else
					item.SubItems.Add(" ");
				if(rowSel["E_mail"].ToString()!="?")
					item.SubItems.Add(rowSel["E_mail"].ToString());
				else
					item.SubItems.Add(" ");
				if(rowSel["Telephone"].ToString()!="?")
					item.SubItems.Add(rowSel["Telephone"].ToString());
				else
					item.SubItems.Add(" ");
				item.SubItems.Add(rowSel["Telecopie"].ToString());
				item.Tag=rowSel["Cle"].ToString();
				lvCorres.Items.Add(item);
			}
			ds.Tables["T_clients_coressp"].Clear();

			Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_famille_machine.Designation, T_devis_entete.Date, T_devis_entete.[Date Decision], T_devis_entete.[Date reparation], T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.Niveau FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Code Client])="+txIdent.Text+"))ORDER BY T_devis_entete.[N° Devis] DESC";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_devis_entete");
			}
			catch(OleDbException exep)
			{
				MessageBox.Show(exep.Message);
			}
			foreach(DataRow Row in ds.Tables["t_devis_entete"].Rows)
			{
				ListViewItem item = new ListViewItem(Row["Niveau"].ToString());
				item.SubItems.Add(Row["N° Devis"].ToString());
				if(Row["Date"].ToString().Length==0)
					item.SubItems.Add(" ");
				else
					item.SubItems.Add(System.Convert.ToDateTime(Row["Date"].ToString()).ToShortDateString());
				if(Row["Date decision"].ToString().Length==0)
					item.SubItems.Add(" ");
				else if(Row["Date decision"].ToString().Length>18)
					item.SubItems.Add(System.Convert.ToDateTime(Row["Date decision"].ToString()).ToShortDateString());
				if(Row["Date reparation"].ToString().Length==0)
					item.SubItems.Add(" ");
				else if(Row["Date reparation"].ToString().Length>18)
					item.SubItems.Add(System.Convert.ToDateTime(Row["Date reparation"].ToString()).ToShortDateString());
				item.SubItems.Add(Row["Code machine opindus"].ToString());
				item.SubItems.Add(Row["Type machine"].ToString());
				item.SubItems.Add(Row["Designation"].ToString());
				lvDevis.Items.Add(item);
			}
			ds.Tables["t_devis_entete"].Clear();

			Comm.CommandText="select T_parc_machine.[Code machine opindus],T_parc_machine.[Type machine],T_parc_machine.[Date dernier intervention],T_parc_machine.[Date dernier controle],T_parc_machine.[nombre semaine entre ctl],T_parc_machine.[nombre semaine entre inter],T_famille_machine.[Designation] from t_parc_machine, t_famille_machine, t_type_machine where T_parc_machine.[Code Client]="+txIdent.Text+" and T_parc_machine.[Type machine]=T_type_machine.[Code] and T_type_machine.[Code famille]=T_famille_machine.[Code]";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"T_parc_machine");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			int cpt2=0;
			foreach(DataRow row2 in ds.Tables["T_parc_machine"].Rows)
			{
				bool affiche=false;
				bool affiche2=false;
				TimeSpan jour=TimeSpan.FromDays(1);
				DateTime ProchainCtl=DateTime.Today-jour;
				DateTime ProchaineInter=DateTime.Today-jour;
				if((row2["nombre semaine entre inter"].ToString().Length>0)&&(row2["Date dernier intervention"].ToString().Length>0))
				{
					affiche=true;
					ProchaineInter=System.Convert.ToDateTime(row2["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(row2["nombre semaine entre ctl"].ToString()));
				}

				if((row2["nombre semaine entre ctl"].ToString().Length>0)&&(row2["Date dernier controle"].ToString().Length>0))
				{
					affiche2=true;
					ProchainCtl=System.Convert.ToDateTime(row2["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(row2["nombre semaine entre ctl"].ToString()));
				}
				if(ProchainCtl>=DateTime.Today||ProchaineInter>=DateTime.Today)
				{
					ListViewItem item = new ListViewItem(row2["Code machine opindus"].ToString());
					item.SubItems.Add(row2["Type machine"].ToString());
					item.SubItems.Add(row2["Designation"].ToString());
					if(row2["Date dernier intervention"].ToString().Length>0)
						item.SubItems.Add(System.Convert.ToDateTime(row2["Date dernier intervention"].ToString()).ToShortDateString());
					else
						item.SubItems.Add("");
					if(row2["Date dernier controle"].ToString().Length>0)
						item.SubItems.Add(System.Convert.ToDateTime(row2["Date dernier controle"].ToString()).ToShortDateString());
					else
						item.SubItems.Add("");
					if(affiche)
						item.SubItems.Add(ProchaineInter.ToShortDateString());
					else
						item.SubItems.Add("");
					if(affiche2)
						item.SubItems.Add(ProchainCtl.ToShortDateString());
					else
						item.SubItems.Add("");
					lvInter.Items.Add(item);					
				}
			}
			ds.Tables["t_parc_machine"].Clear();

			decimal Total_Annee_en_cours=0;
			decimal Total_Annee_1=0;
			decimal Total_Annee_2=0;
			decimal Total_Annee_3=0;
			decimal Total_Annee_4=0;
			int rep1=0;
			int rep2=0;
			int rep3=0;
			int rep4=0;
			int rep0=0;
			int annee_encours=DateTime.Now.Year;
			int annee_1=DateTime.Now.Year-1;
			int annee_2=DateTime.Now.Year-2;
			int annee_3=DateTime.Now.Year-3;
			int annee_4=DateTime.Now.Year-4;
            Comm.CommandText = "SELECT Sum(T_devis_entete.[Total devis]) AS [Expr1] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#1/1/" + annee_encours + "# And (T_devis_entete.[Date reparation])<=#12/31/" + annee_encours + "#) AND ((T_devis_entete.[Code Client])=" + txIdent.Text.Replace("'", "''") + ") AND ((T_devis_entete.Niveau)=7))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"n");
			if(ds.Tables["n"].Rows.Count>0)
			{
				try
				{
					Total_Annee_en_cours=System.Convert.ToDecimal(ds.Tables["n"].Rows[0]["Expr1"].ToString());
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
			}
            Comm.CommandText = "SELECT Sum(T_devis_entete.[Total devis]) AS [Expr1] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#1/1/" + annee_1 + "# And (T_devis_entete.[Date reparation])<=#12/31/" + annee_1 + "#) AND ((T_devis_entete.[Code Client])=" + txIdent.Text.Replace("'", "''") + ") AND ((T_devis_entete.Niveau)=7))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"n1");
			if(ds.Tables["n1"].Rows.Count>0)
			{
				try
				{
					Total_Annee_1=System.Convert.ToDecimal(ds.Tables["n1"].Rows[0]["Expr1"].ToString());
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
			}
            Comm.CommandText = "SELECT Sum(T_devis_entete.[Total devis]) AS [Expr1] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#1/1/" + annee_2 + "# And (T_devis_entete.[Date reparation])<=#12/31/" + annee_2 + "#) AND ((T_devis_entete.[Code Client])=" + txIdent.Text.Replace("'", "''") + ") AND ((T_devis_entete.Niveau)=7))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"n2");
			if(ds.Tables["n2"].Rows.Count>0)
			{
				try
				{
					Total_Annee_2=System.Convert.ToDecimal(ds.Tables["n2"].Rows[0]["Expr1"].ToString());
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
			}
            Comm.CommandText = "SELECT Sum(T_devis_entete.[Total devis]) AS [Expr1] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#1/1/" + annee_3 + "# And (T_devis_entete.[Date reparation])<=#12/31/" + annee_3 + "#) AND ((T_devis_entete.[Code Client])=" + txIdent.Text.Replace("'", "''") + ") AND ((T_devis_entete.Niveau)=7))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"n3");
			if(ds.Tables["n3"].Rows.Count>0)
			{
				try
				{
					Total_Annee_3=System.Convert.ToDecimal(ds.Tables["n3"].Rows[0]["Expr1"].ToString());
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
			}
            Comm.CommandText = "SELECT Sum(T_devis_entete.[Total devis]) AS [Expr1] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#1/1/" + annee_4 + "# And (T_devis_entete.[Date reparation])<=#12/31/" + annee_4 + "#) AND ((T_devis_entete.[Code Client])=" + txIdent.Text.Replace("'", "''") + ") AND ((T_devis_entete.Niveau)=7))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"n4");
			if(ds.Tables["n4"].Rows.Count>0)
			{
				try
				{
					Total_Annee_4=System.Convert.ToDecimal(ds.Tables["n4"].Rows[0]["Expr1"].ToString());
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
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
			ds.Tables["t_devis_entete"].Clear();

			Comm.CommandText="SELECT T_devis_entete.[Date reparation], T_devis_entete.[Code Client], T_devis_entete.[N° Devis], T_devis_entete.Niveau FROM T_devis_entete WHERE (((T_devis_entete.[Code Client])="+txIdent.Text+") AND ((T_devis_entete.Niveau)=7)) ORDER BY T_devis_entete.[Date reparation]";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_devis_entete");
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			foreach(DataRow rowDate in ds.Tables["t_devis_entete"].Rows)
			{
				if(rowDate["Date reparation"].ToString().Length>0)
				{
					if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_encours.ToString()))
					{
						rep0+=1;
					}
					else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_1.ToString()))
					{
						rep1+=1;
					}
					else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_2.ToString()))
					{
						rep2+=1;
					}
					else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_3.ToString()))
					{
						rep3+=1;
					}
					else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_4.ToString()))
					{
						rep4+=1;
					}
				}
			}
			ChartLoader chartLoader2= chartControl2.getChartLoader();
			// set chart parameters 
			chartLoader2.clearParams();
			chartLoader2.setParameter("TITLECHART",txNom.Text); 
			chartLoader2.setParameter("XLABEL","Années"); 
			chartLoader2.setParameter("YLABEL","Nombe annuel de réparations"); 
			chartLoader2.setParameter("XSCALE_MIN","0"); 
			chartLoader2.setParameter("XSCALE_MAX","5.5"); 
			chartLoader2.setParameter("YSCALE_MIN","0"); 
			chartLoader2.setParameter("LEGEND","FALSE");
			chartLoader2.setParameter("BIG_TICK_INTERVALX","1"); 
			chartLoader2.setParameter("XAXIS_LABELS","En cours|N-1|N-2|N-3|N-4"); 
			chartLoader2.setParameter("CERO_XAXIS","LINE"); 
			chartLoader2.setParameter("YAXIS_INTEGER","TRUE"); 
			chartLoader2.setParameter("SERIE_1","Réparations"); 
			chartLoader2.setParameter("SERIE_TYPE_1","BAR");
			chartLoader2.setParameter("CHART_BORDER","1|0|NORMAL");
			chartLoader2.setParameter("CHART_FILL","LIGHTGRAY");
			chartLoader2.setParameter("SERIE_FONT_1","Arial|PLAIN|10"); 
			string reparations=rep0.ToString()+"|"+rep1.ToString()+"|"+rep2.ToString()+"|"+rep3.ToString()+"|"+rep4.ToString();
			chartLoader2.setParameter("SERIE_DATA_1",reparations); 
			chartLoader2.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
			chartLoader2.setParameter("SERIE_BAR_STYLE_1","ff00"); 
			chartLoader2.setParameter("BARCHART_BARSPACE","20"); 
			chartLoader2.setParameter("LEFT_MARGIN","0.20"); 
			chartLoader.setParameter("YAXIS_AUTO_TICKS","10");
			chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","20");
			chartLoader2.setParameter("CHART_FILL","ffcc00"); 
			chartLoader2.setParameter("YLABEL_VERTICAL","TRUE"); 
			chartLoader2.setParameter("YAXIS_TICKATBASE","true");
			// create chart 
			chartControl2.buildChart();
			this.Refresh();
			chartControl2.Visible=true;
			ds.Tables["t_devis_entete"].Clear();
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Clients));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbRechercheClient = new MTGCComboBox();
			this.label34 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.btSupCorres = new System.Windows.Forms.Button();
			this.lvCorres = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
			this.btNewCorres = new System.Windows.Forms.Button();
			this.txIdent = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txFax = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txTel = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txPays = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txVille = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txAdresse2 = new System.Windows.Forms.TextBox();
			this.txAdresse1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txCodePostal = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.btCrea2 = new System.Windows.Forms.Button();
			this.btCrea1 = new System.Windows.Forms.Button();
			this.txBatiment = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btClients = new System.Windows.Forms.Button();
			this.txCodeGestion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txNom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label36 = new System.Windows.Forms.Label();
			this.chartControl2 = new J4L.RChart.ChartControl();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lvDevis = new System.Windows.Forms.ListView();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.lvInter = new System.Windows.Forms.ListView();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label29 = new System.Windows.Forms.Label();
			this.btTrans = new System.Windows.Forms.Button();
			this.btRegl = new System.Windows.Forms.Button();
			this.txFourn = new System.Windows.Forms.TextBox();
			this.txTrans = new System.Windows.Forms.TextBox();
			this.txrRegl = new System.Windows.Forms.TextBox();
			this.txPourcentage = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.txCoefTrans = new System.Windows.Forms.TextBox();
			this.txCoefControle = new System.Windows.Forms.TextBox();
			this.txCoefDNR = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.txForfaitTrans = new System.Windows.Forms.TextBox();
			this.txControle = new System.Windows.Forms.TextBox();
			this.txForfaitDNR = new System.Windows.Forms.TextBox();
			this.txCde = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.txBorne = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label33 = new System.Windows.Forms.Label();
			this.txGarantie = new System.Windows.Forms.TextBox();
			this.txSeuil = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.btMachineHorsParc = new System.Windows.Forms.Button();
			this.btMachineEnParc = new System.Windows.Forms.Button();
			this.lvMachines = new System.Windows.Forms.ListView();
			this.txCommentaire = new System.Windows.Forms.TextBox();
			this.btSupprime = new System.Windows.Forms.Button();
			this.btEnregistre = new System.Windows.Forms.Button();
			this.btNouveau = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX5 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
			this.button6 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.tabPageEX4 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.tabControlEX2 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX8 = new Dotnetrix.Controls.TabPageEX();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label35 = new System.Windows.Forms.Label();
			this.chartControl1 = new J4L.RChart.ChartControl();
			this.tabPageEX9 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX6 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX7 = new Dotnetrix.Controls.TabPageEX();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button7 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printDocument2 = new System.Drawing.Printing.PrintDocument();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.tabPageEX5.SuspendLayout();
			this.tabPageEX3.SuspendLayout();
			this.tabPageEX4.SuspendLayout();
			this.tabPageEX2.SuspendLayout();
			this.tabControlEX2.SuspendLayout();
			this.tabPageEX8.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPageEX9.SuspendLayout();
			this.tabPageEX6.SuspendLayout();
			this.tabPageEX7.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbRechercheClient);
			this.groupBox1.Controls.Add(this.label34);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(570, 40);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			// 
			// cbRechercheClient
			// 
			this.cbRechercheClient.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.cbRechercheClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbRechercheClient.ColumnNum = 4;
			this.cbRechercheClient.ColumnWidth = "200;200;100;150";
			this.cbRechercheClient.DisplayMember = "Text";
			this.cbRechercheClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbRechercheClient.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.cbRechercheClient.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.cbRechercheClient.DropDownForeColor = System.Drawing.Color.Black;
			this.cbRechercheClient.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.cbRechercheClient.DropDownWidth = 670;
			this.cbRechercheClient.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbRechercheClient.GridLineColor = System.Drawing.Color.LightGray;
			this.cbRechercheClient.GridLineHorizontal = false;
			this.cbRechercheClient.GridLineVertical = true;
			this.cbRechercheClient.HighlightBorderColor = System.Drawing.Color.Blue;
			this.cbRechercheClient.HighlightBorderOnMouseEvents = true;
			this.cbRechercheClient.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.cbRechercheClient.Location = new System.Drawing.Point(88, 12);
			this.cbRechercheClient.ManagingFastMouseMoving = true;
			this.cbRechercheClient.ManagingFastMouseMovingInterval = 30;
			this.cbRechercheClient.Name = "cbRechercheClient";
			this.cbRechercheClient.NormalBorderColor = System.Drawing.Color.Black;
			this.cbRechercheClient.Size = new System.Drawing.Size(466, 21);
			this.cbRechercheClient.TabIndex = 0;
			this.cbRechercheClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbRechercheClient_KeyDown);
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.SteelBlue;
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label34.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label34.Location = new System.Drawing.Point(192, 11);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(176, 16);
			this.label34.TabIndex = 22;
			this.label34.Text = "CREATION CLIENT";
			this.label34.Visible = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Recherche";
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox4.Controls.Add(this.button3);
			this.groupBox4.Controls.Add(this.btSupCorres);
			this.groupBox4.Controls.Add(this.lvCorres);
			this.groupBox4.Controls.Add(this.btNewCorres);
			this.groupBox4.ForeColor = System.Drawing.Color.Black;
			this.groupBox4.Location = new System.Drawing.Point(0, 216);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(912, 310);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Correspondants";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lavender;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(128, 272);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "Editer la fiche";
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btSupCorres
			// 
			this.btSupCorres.BackColor = System.Drawing.Color.Lavender;
			this.btSupCorres.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSupCorres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupCorres.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btSupCorres.ForeColor = System.Drawing.Color.Red;
			this.btSupCorres.Location = new System.Drawing.Point(797, 272);
			this.btSupCorres.Name = "btSupCorres";
			this.btSupCorres.Size = new System.Drawing.Size(100, 23);
			this.btSupCorres.TabIndex = 10;
			this.btSupCorres.Text = "Supprimer";
			this.btSupCorres.Visible = false;
			this.btSupCorres.Click += new System.EventHandler(this.btSupCorres_Click);
			// 
			// lvCorres
			// 
			this.lvCorres.BackColor = System.Drawing.Color.MintCream;
			this.lvCorres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvCorres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeader1,
																					   this.columnHeader2,
																					   this.columnHeader3,
																					   this.columnHeader4,
																					   this.columnHeader20});
			this.lvCorres.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvCorres.FullRowSelect = true;
			this.lvCorres.GridLines = true;
			this.lvCorres.LabelEdit = true;
			this.lvCorres.Location = new System.Drawing.Point(8, 24);
			this.lvCorres.MultiSelect = false;
			this.lvCorres.Name = "lvCorres";
			this.lvCorres.Size = new System.Drawing.Size(888, 232);
			this.lvCorres.TabIndex = 9;
			this.lvCorres.TabStop = false;
			this.lvCorres.View = System.Windows.Forms.View.Details;
			this.lvCorres.Visible = false;
			this.lvCorres.DoubleClick += new System.EventHandler(this.lvCorres_DoubleClick);
			this.lvCorres.SelectedIndexChanged += new System.EventHandler(this.lvCorres_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nom";
			this.columnHeader1.Width = 240;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Prénom";
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Email";
			this.columnHeader3.Width = 210;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tel";
			this.columnHeader4.Width = 130;
			// 
			// columnHeader20
			// 
			this.columnHeader20.Text = "Fax";
			this.columnHeader20.Width = 130;
			// 
			// btNewCorres
			// 
			this.btNewCorres.BackColor = System.Drawing.Color.Lavender;
			this.btNewCorres.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btNewCorres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btNewCorres.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btNewCorres.ForeColor = System.Drawing.Color.Blue;
			this.btNewCorres.Location = new System.Drawing.Point(8, 272);
			this.btNewCorres.Name = "btNewCorres";
			this.btNewCorres.Size = new System.Drawing.Size(100, 23);
			this.btNewCorres.TabIndex = 9;
			this.btNewCorres.Text = "Nouveau";
			this.btNewCorres.Visible = false;
			this.btNewCorres.Click += new System.EventHandler(this.button2_Click);
			// 
			// txIdent
			// 
			this.txIdent.BackColor = System.Drawing.SystemColors.Window;
			this.txIdent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txIdent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txIdent.Enabled = false;
			this.txIdent.ForeColor = System.Drawing.Color.Black;
			this.txIdent.Location = new System.Drawing.Point(624, 8);
			this.txIdent.Name = "txIdent";
			this.txIdent.ReadOnly = true;
			this.txIdent.Size = new System.Drawing.Size(87, 20);
			this.txIdent.TabIndex = 3;
			this.txIdent.Text = "";
			this.txIdent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(584, 8);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(36, 11);
			this.label14.TabIndex = 6;
			this.label14.Text = "Ident";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox3.Controls.Add(this.txFax);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.txTel);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.txPays);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.txVille);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.txAdresse2);
			this.groupBox3.Controls.Add(this.txAdresse1);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.txCodePostal);
			this.groupBox3.ForeColor = System.Drawing.Color.Black;
			this.groupBox3.Location = new System.Drawing.Point(384, 32);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(528, 191);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			// 
			// txFax
			// 
			this.txFax.BackColor = System.Drawing.SystemColors.Window;
			this.txFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txFax.Enabled = false;
			this.txFax.Location = new System.Drawing.Point(317, 144);
			this.txFax.MaxLength = 50;
			this.txFax.Name = "txFax";
			this.txFax.Size = new System.Drawing.Size(171, 20);
			this.txFax.TabIndex = 14;
			this.txFax.Text = "";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(284, 144);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(26, 17);
			this.label13.TabIndex = 12;
			this.label13.Text = "Fax";
			// 
			// txTel
			// 
			this.txTel.BackColor = System.Drawing.SystemColors.Window;
			this.txTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txTel.Enabled = false;
			this.txTel.Location = new System.Drawing.Point(84, 144);
			this.txTel.MaxLength = 50;
			this.txTel.Name = "txTel";
			this.txTel.Size = new System.Drawing.Size(184, 20);
			this.txTel.TabIndex = 13;
			this.txTel.Text = "";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(7, 144);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(63, 13);
			this.label12.TabIndex = 10;
			this.label12.Text = "Téléphone";
			// 
			// txPays
			// 
			this.txPays.BackColor = System.Drawing.SystemColors.Window;
			this.txPays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txPays.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txPays.Enabled = false;
			this.txPays.Location = new System.Drawing.Point(84, 112);
			this.txPays.Name = "txPays";
			this.txPays.Size = new System.Drawing.Size(404, 20);
			this.txPays.TabIndex = 9;
			this.txPays.TabStop = false;
			this.txPays.Text = "FRANCE";
			this.txPays.TextChanged += new System.EventHandler(this.txPays_TextChanged);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(7, 120);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(34, 15);
			this.label11.TabIndex = 8;
			this.label11.Text = "Pays";
			// 
			// txVille
			// 
			this.txVille.BackColor = System.Drawing.SystemColors.Window;
			this.txVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txVille.Enabled = false;
			this.txVille.Location = new System.Drawing.Point(220, 80);
			this.txVille.Name = "txVille";
			this.txVille.Size = new System.Drawing.Size(268, 20);
			this.txVille.TabIndex = 12;
			this.txVille.Text = "";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(176, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 16);
			this.label10.TabIndex = 6;
			this.label10.Text = "Ville";
			// 
			// txAdresse2
			// 
			this.txAdresse2.BackColor = System.Drawing.SystemColors.Window;
			this.txAdresse2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txAdresse2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txAdresse2.Enabled = false;
			this.txAdresse2.Location = new System.Drawing.Point(84, 48);
			this.txAdresse2.Name = "txAdresse2";
			this.txAdresse2.Size = new System.Drawing.Size(404, 20);
			this.txAdresse2.TabIndex = 10;
			this.txAdresse2.Text = "";
			// 
			// txAdresse1
			// 
			this.txAdresse1.BackColor = System.Drawing.SystemColors.Window;
			this.txAdresse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txAdresse1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txAdresse1.Enabled = false;
			this.txAdresse1.Location = new System.Drawing.Point(84, 18);
			this.txAdresse1.Name = "txAdresse1";
			this.txAdresse1.Size = new System.Drawing.Size(404, 20);
			this.txAdresse1.TabIndex = 9;
			this.txAdresse1.Text = "";
			this.txAdresse1.TextChanged += new System.EventHandler(this.txAdresse1_TextChanged);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 14);
			this.label9.TabIndex = 2;
			this.label9.Text = "Code Postal";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(7, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 14);
			this.label8.TabIndex = 1;
			this.label8.Text = "Adresse 2";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(7, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Adresse 1";
			// 
			// txCodePostal
			// 
			this.txCodePostal.BackColor = System.Drawing.SystemColors.Window;
			this.txCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCodePostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txCodePostal.Enabled = false;
			this.txCodePostal.Location = new System.Drawing.Point(84, 80);
			this.txCodePostal.MaxLength = 5;
			this.txCodePostal.Name = "txCodePostal";
			this.txCodePostal.Size = new System.Drawing.Size(70, 20);
			this.txCodePostal.TabIndex = 11;
			this.txCodePostal.Text = "";
			this.txCodePostal.TextChanged += new System.EventHandler(this.txCodePostal_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.mtgcComboBox2);
			this.groupBox2.Controls.Add(this.mtgcComboBox1);
			this.groupBox2.Controls.Add(this.btCrea2);
			this.groupBox2.Controls.Add(this.btCrea1);
			this.groupBox2.Controls.Add(this.txBatiment);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btClients);
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(8, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(378, 191);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			// 
			// mtgcComboBox2
			// 
			this.mtgcComboBox2.BackColor = System.Drawing.SystemColors.Window;
			this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox2.ColumnNum = 2;
			this.mtgcComboBox2.ColumnWidth = "50;121";
			this.mtgcComboBox2.DisplayMember = "Text";
			this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox2.DropDownWidth = 191;
			this.mtgcComboBox2.Enabled = false;
			this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox2.GridLineHorizontal = false;
			this.mtgcComboBox2.GridLineVertical = false;
			this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox2.Location = new System.Drawing.Point(80, 48);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(168, 21);
			this.mtgcComboBox2.TabIndex = 6;
			this.mtgcComboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox2_KeyDown);
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BackColor = System.Drawing.SystemColors.Window;
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 2;
			this.mtgcComboBox1.ColumnWidth = "50;121";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 191;
			this.mtgcComboBox1.Enabled = false;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = true;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(80, 17);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(168, 21);
			this.mtgcComboBox1.TabIndex = 4;
			this.mtgcComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox1_KeyDown);
			// 
			// btCrea2
			// 
			this.btCrea2.BackColor = System.Drawing.Color.Lavender;
			this.btCrea2.Enabled = false;
			this.btCrea2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btCrea2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btCrea2.ForeColor = System.Drawing.Color.Black;
			this.btCrea2.Location = new System.Drawing.Point(264, 47);
			this.btCrea2.Name = "btCrea2";
			this.btCrea2.Size = new System.Drawing.Size(80, 20);
			this.btCrea2.TabIndex = 7;
			this.btCrea2.Text = "Créer";
			this.btCrea2.Click += new System.EventHandler(this.btCrea2_Click);
			// 
			// btCrea1
			// 
			this.btCrea1.BackColor = System.Drawing.Color.Lavender;
			this.btCrea1.Enabled = false;
			this.btCrea1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btCrea1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btCrea1.ForeColor = System.Drawing.Color.Black;
			this.btCrea1.Location = new System.Drawing.Point(264, 18);
			this.btCrea1.Name = "btCrea1";
			this.btCrea1.Size = new System.Drawing.Size(80, 20);
			this.btCrea1.TabIndex = 5;
			this.btCrea1.Text = "Créer";
			this.btCrea1.Click += new System.EventHandler(this.btCrea1_Click);
			// 
			// txBatiment
			// 
			this.txBatiment.BackColor = System.Drawing.SystemColors.Window;
			this.txBatiment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txBatiment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txBatiment.Enabled = false;
			this.txBatiment.Location = new System.Drawing.Point(116, 80);
			this.txBatiment.Name = "txBatiment";
			this.txBatiment.Size = new System.Drawing.Size(132, 20);
			this.txBatiment.TabIndex = 8;
			this.txBatiment.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 15);
			this.label6.TabIndex = 2;
			this.label6.Text = "Batiment";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "Usine";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Groupe";
			// 
			// btClients
			// 
			this.btClients.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(127)), ((System.Byte)(224)));
			this.btClients.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClients.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btClients.ForeColor = System.Drawing.Color.White;
			this.btClients.Image = ((System.Drawing.Image)(resources.GetObject("btClients.Image")));
			this.btClients.Location = new System.Drawing.Point(264, 81);
			this.btClients.Name = "btClients";
			this.btClients.Size = new System.Drawing.Size(96, 96);
			this.btClients.TabIndex = 21;
			this.btClients.TabStop = false;
			this.btClients.Text = "&Clients";
			this.btClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txCodeGestion
			// 
			this.txCodeGestion.BackColor = System.Drawing.SystemColors.Window;
			this.txCodeGestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCodeGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txCodeGestion.Enabled = false;
			this.txCodeGestion.ForeColor = System.Drawing.Color.Black;
			this.txCodeGestion.Location = new System.Drawing.Point(425, 8);
			this.txCodeGestion.MaxLength = 10;
			this.txCodeGestion.Name = "txCodeGestion";
			this.txCodeGestion.Size = new System.Drawing.Size(146, 20);
			this.txCodeGestion.TabIndex = 2;
			this.txCodeGestion.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(328, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Code gestion";
			// 
			// txNom
			// 
			this.txNom.BackColor = System.Drawing.SystemColors.Window;
			this.txNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txNom.ForeColor = System.Drawing.Color.Black;
			this.txNom.Location = new System.Drawing.Point(64, 8);
			this.txNom.Name = "txNom";
			this.txNom.ReadOnly = true;
			this.txNom.Size = new System.Drawing.Size(241, 20);
			this.txNom.TabIndex = 1;
			this.txNom.Text = "";
			this.txNom.TextChanged += new System.EventHandler(this.txNom_TextChanged);
			this.txNom.Enter += new System.EventHandler(this.txNom_Enter);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(24, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nom";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.label36);
			this.panel2.Controls.Add(this.chartControl2);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(763, 359);
			this.panel2.TabIndex = 5;
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label36.Location = new System.Drawing.Point(22, 6);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(713, 23);
			this.label36.TabIndex = 0;
			this.label36.Text = "Statistiques des réparations sur 5 années";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chartControl2
			// 
			this.chartControl2.BackColor = System.Drawing.Color.White;
			this.chartControl2.Location = new System.Drawing.Point(24, 38);
			this.chartControl2.Name = "chartControl2";
			this.chartControl2.Size = new System.Drawing.Size(712, 313);
			this.chartControl2.TabIndex = 1;
			this.chartControl2.Text = "chartControl1";
			this.chartControl2.Visible = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Lavender;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Location = new System.Drawing.Point(280, 496);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(125, 28);
			this.button5.TabIndex = 5;
			this.button5.Text = "Tous niveaux 3 et <";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Lavender;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(144, 496);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(125, 28);
			this.button4.TabIndex = 4;
			this.button4.Text = "Niveau 3 de + de 90 j";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lavender;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(8, 496);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 28);
			this.button2.TabIndex = 3;
			this.button2.Text = "Tous les devis";
			this.button2.Click += new System.EventHandler(this.button2_Click_3);
			// 
			// lvDevis
			// 
			this.lvDevis.BackColor = System.Drawing.Color.MintCream;
			this.lvDevis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvDevis.CheckBoxes = true;
			this.lvDevis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.columnHeader12,
																					  this.columnHeader5,
																					  this.columnHeader6,
																					  this.columnHeader7,
																					  this.columnHeader8,
																					  this.columnHeader9,
																					  this.columnHeader10,
																					  this.columnHeader11});
			this.lvDevis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvDevis.FullRowSelect = true;
			this.lvDevis.GridLines = true;
			this.lvDevis.Location = new System.Drawing.Point(8, 40);
			this.lvDevis.MultiSelect = false;
			this.lvDevis.Name = "lvDevis";
			this.lvDevis.Size = new System.Drawing.Size(896, 448);
			this.lvDevis.TabIndex = 0;
			this.lvDevis.View = System.Windows.Forms.View.Details;
			this.lvDevis.DoubleClick += new System.EventHandler(this.lvDevis_DoubleClick);
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "N";
			this.columnHeader12.Width = 30;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Devis";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Date";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 80;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Décision";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 80;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Réparation";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader8.Width = 80;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Immatriculation";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 100;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Type machine";
			this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader10.Width = 100;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Famille";
			this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader11.Width = 190;
			// 
			// lvInter
			// 
			this.lvInter.BackColor = System.Drawing.Color.MintCream;
			this.lvInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvInter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.columnHeader13,
																					  this.columnHeader14,
																					  this.columnHeader15,
																					  this.columnHeader17,
																					  this.columnHeader18,
																					  this.columnHeader16,
																					  this.columnHeader19});
			this.lvInter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvInter.FullRowSelect = true;
			this.lvInter.GridLines = true;
			this.lvInter.Location = new System.Drawing.Point(8, 8);
			this.lvInter.Name = "lvInter";
			this.lvInter.Size = new System.Drawing.Size(896, 392);
			this.lvInter.TabIndex = 0;
			this.lvInter.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Code machine";
			this.columnHeader13.Width = 100;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Type";
			this.columnHeader14.Width = 90;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Description";
			this.columnHeader15.Width = 180;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "Dernière Inter";
			this.columnHeader17.Width = 100;
			// 
			// columnHeader18
			// 
			this.columnHeader18.Text = "Dernier contrôle";
			this.columnHeader18.Width = 110;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Prochaine Inter";
			this.columnHeader16.Width = 110;
			// 
			// columnHeader19
			// 
			this.columnHeader19.Text = "Prochain Contrôle";
			this.columnHeader19.Width = 130;
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox5.Controls.Add(this.label29);
			this.groupBox5.Controls.Add(this.btTrans);
			this.groupBox5.Controls.Add(this.btRegl);
			this.groupBox5.Controls.Add(this.txFourn);
			this.groupBox5.Controls.Add(this.txTrans);
			this.groupBox5.Controls.Add(this.txrRegl);
			this.groupBox5.Controls.Add(this.txPourcentage);
			this.groupBox5.Controls.Add(this.label19);
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Controls.Add(this.label17);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.ForeColor = System.Drawing.Color.Black;
			this.groupBox5.Location = new System.Drawing.Point(104, 48);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(357, 151);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(266, 26);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(25, 17);
			this.label29.TabIndex = 10;
			this.label29.Text = "%";
			// 
			// btTrans
			// 
			this.btTrans.BackColor = System.Drawing.Color.Lavender;
			this.btTrans.Enabled = false;
			this.btTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btTrans.Location = new System.Drawing.Point(274, 83);
			this.btTrans.Name = "btTrans";
			this.btTrans.Size = new System.Drawing.Size(25, 20);
			this.btTrans.TabIndex = 9;
			this.btTrans.Text = "...";
			this.btTrans.Click += new System.EventHandler(this.btTrans_Click);
			// 
			// btRegl
			// 
			this.btRegl.BackColor = System.Drawing.Color.Lavender;
			this.btRegl.Enabled = false;
			this.btRegl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRegl.Location = new System.Drawing.Point(274, 53);
			this.btRegl.Name = "btRegl";
			this.btRegl.Size = new System.Drawing.Size(25, 20);
			this.btRegl.TabIndex = 8;
			this.btRegl.Text = "...";
			this.btRegl.Click += new System.EventHandler(this.btRegl_Click);
			// 
			// txFourn
			// 
			this.txFourn.BackColor = System.Drawing.Color.White;
			this.txFourn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txFourn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txFourn.Enabled = false;
			this.txFourn.Location = new System.Drawing.Point(160, 115);
			this.txFourn.Name = "txFourn";
			this.txFourn.TabIndex = 7;
			this.txFourn.Text = "";
			this.txFourn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txTrans
			// 
			this.txTrans.BackColor = System.Drawing.Color.White;
			this.txTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txTrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txTrans.Enabled = false;
			this.txTrans.Location = new System.Drawing.Point(160, 82);
			this.txTrans.Name = "txTrans";
			this.txTrans.TabIndex = 6;
			this.txTrans.Text = "PP";
			this.txTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txrRegl
			// 
			this.txrRegl.BackColor = System.Drawing.Color.White;
			this.txrRegl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txrRegl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txrRegl.Enabled = false;
			this.txrRegl.Location = new System.Drawing.Point(160, 52);
			this.txrRegl.Name = "txrRegl";
			this.txrRegl.TabIndex = 5;
			this.txrRegl.Text = "TA";
			this.txrRegl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txPourcentage
			// 
			this.txPourcentage.BackColor = System.Drawing.Color.White;
			this.txPourcentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txPourcentage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txPourcentage.Enabled = false;
			this.txPourcentage.Location = new System.Drawing.Point(160, 22);
			this.txPourcentage.Name = "txPourcentage";
			this.txPourcentage.TabIndex = 4;
			this.txPourcentage.Text = "0";
			this.txPourcentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(20, 115);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(135, 15);
			this.label19.TabIndex = 3;
			this.label19.Text = "Notre code fournisseur";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(20, 85);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 19);
			this.label18.TabIndex = 2;
			this.label18.Text = "Code transport";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(20, 55);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 17);
			this.label17.TabIndex = 1;
			this.label17.Text = "Code règlement";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(20, 25);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(127, 23);
			this.label16.TabIndex = 0;
			this.label16.Text = "Pourcentage remise";
			// 
			// groupBox7
			// 
			this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox7.Controls.Add(this.txCoefTrans);
			this.groupBox7.Controls.Add(this.txCoefControle);
			this.groupBox7.Controls.Add(this.txCoefDNR);
			this.groupBox7.Controls.Add(this.label28);
			this.groupBox7.Controls.Add(this.label27);
			this.groupBox7.Controls.Add(this.label26);
			this.groupBox7.Controls.Add(this.txForfaitTrans);
			this.groupBox7.Controls.Add(this.txControle);
			this.groupBox7.Controls.Add(this.txForfaitDNR);
			this.groupBox7.Controls.Add(this.txCde);
			this.groupBox7.Controls.Add(this.label25);
			this.groupBox7.Controls.Add(this.label24);
			this.groupBox7.Controls.Add(this.label23);
			this.groupBox7.Controls.Add(this.label22);
			this.groupBox7.ForeColor = System.Drawing.Color.Black;
			this.groupBox7.Location = new System.Drawing.Point(104, 193);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(712, 157);
			this.groupBox7.TabIndex = 2;
			this.groupBox7.TabStop = false;
			// 
			// txCoefTrans
			// 
			this.txCoefTrans.BackColor = System.Drawing.Color.White;
			this.txCoefTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCoefTrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txCoefTrans.Enabled = false;
			this.txCoefTrans.Location = new System.Drawing.Point(505, 112);
			this.txCoefTrans.Name = "txCoefTrans";
			this.txCoefTrans.Size = new System.Drawing.Size(180, 20);
			this.txCoefTrans.TabIndex = 13;
			this.txCoefTrans.Text = "1,00";
			this.txCoefTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txCoefControle
			// 
			this.txCoefControle.BackColor = System.Drawing.Color.White;
			this.txCoefControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCoefControle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txCoefControle.Enabled = false;
			this.txCoefControle.Location = new System.Drawing.Point(505, 82);
			this.txCoefControle.Name = "txCoefControle";
			this.txCoefControle.Size = new System.Drawing.Size(180, 20);
			this.txCoefControle.TabIndex = 12;
			this.txCoefControle.Text = "1,00";
			this.txCoefControle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txCoefDNR
			// 
			this.txCoefDNR.BackColor = System.Drawing.Color.White;
			this.txCoefDNR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCoefDNR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txCoefDNR.Enabled = false;
			this.txCoefDNR.Location = new System.Drawing.Point(505, 52);
			this.txCoefDNR.Name = "txCoefDNR";
			this.txCoefDNR.Size = new System.Drawing.Size(180, 20);
			this.txCoefDNR.TabIndex = 11;
			this.txCoefDNR.Text = "1,00";
			this.txCoefDNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(390, 115);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(100, 17);
			this.label28.TabIndex = 10;
			this.label28.Text = "Coef Transport";
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.Location = new System.Drawing.Point(390, 85);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(100, 15);
			this.label27.TabIndex = 9;
			this.label27.Text = "Coef Contrôle";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.Location = new System.Drawing.Point(390, 55);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(100, 16);
			this.label26.TabIndex = 8;
			this.label26.Text = "Coef DNR";
			// 
			// txForfaitTrans
			// 
			this.txForfaitTrans.BackColor = System.Drawing.Color.White;
			this.txForfaitTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txForfaitTrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txForfaitTrans.Enabled = false;
			this.txForfaitTrans.Location = new System.Drawing.Point(160, 112);
			this.txForfaitTrans.Name = "txForfaitTrans";
			this.txForfaitTrans.Size = new System.Drawing.Size(180, 20);
			this.txForfaitTrans.TabIndex = 7;
			this.txForfaitTrans.Text = "0,00";
			this.txForfaitTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txControle
			// 
			this.txControle.BackColor = System.Drawing.Color.White;
			this.txControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txControle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txControle.Enabled = false;
			this.txControle.Location = new System.Drawing.Point(160, 82);
			this.txControle.Name = "txControle";
			this.txControle.Size = new System.Drawing.Size(180, 20);
			this.txControle.TabIndex = 6;
			this.txControle.Text = "0,00";
			this.txControle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txForfaitDNR
			// 
			this.txForfaitDNR.BackColor = System.Drawing.Color.White;
			this.txForfaitDNR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txForfaitDNR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txForfaitDNR.Enabled = false;
			this.txForfaitDNR.Location = new System.Drawing.Point(160, 52);
			this.txForfaitDNR.Name = "txForfaitDNR";
			this.txForfaitDNR.Size = new System.Drawing.Size(180, 20);
			this.txForfaitDNR.TabIndex = 5;
			this.txForfaitDNR.Text = "0,00";
			this.txForfaitDNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txCde
			// 
			this.txCde.BackColor = System.Drawing.Color.White;
			this.txCde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txCde.Enabled = false;
			this.txCde.Location = new System.Drawing.Point(160, 22);
			this.txCde.Name = "txCde";
			this.txCde.Size = new System.Drawing.Size(181, 20);
			this.txCde.TabIndex = 4;
			this.txCde.Text = "XXX";
			this.txCde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.Location = new System.Drawing.Point(20, 115);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(100, 15);
			this.label25.TabIndex = 3;
			this.label25.Text = "Forfait transport";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.Location = new System.Drawing.Point(20, 85);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(100, 18);
			this.label24.TabIndex = 2;
			this.label24.Text = "Forfait contrôle";
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.Location = new System.Drawing.Point(20, 55);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(100, 17);
			this.label23.TabIndex = 1;
			this.label23.Text = "Forfait DNR";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.Location = new System.Drawing.Point(20, 25);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(137, 13);
			this.label22.TabIndex = 0;
			this.label22.Text = "N° Commande ouverte";
			// 
			// groupBox8
			// 
			this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox8.Controls.Add(this.txBorne);
			this.groupBox8.Controls.Add(this.label30);
			this.groupBox8.ForeColor = System.Drawing.Color.Black;
			this.groupBox8.Location = new System.Drawing.Point(104, 344);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(712, 66);
			this.groupBox8.TabIndex = 3;
			this.groupBox8.TabStop = false;
			// 
			// txBorne
			// 
			this.txBorne.BackColor = System.Drawing.Color.White;
			this.txBorne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txBorne.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txBorne.Enabled = false;
			this.txBorne.Location = new System.Drawing.Point(171, 27);
			this.txBorne.Name = "txBorne";
			this.txBorne.TabIndex = 1;
			this.txBorne.Text = "";
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label30.Location = new System.Drawing.Point(20, 30);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(146, 14);
			this.label30.TabIndex = 0;
			this.label30.Text = "Borne date refus réforme";
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox6.Controls.Add(this.label33);
			this.groupBox6.Controls.Add(this.txGarantie);
			this.groupBox6.Controls.Add(this.txSeuil);
			this.groupBox6.Controls.Add(this.label21);
			this.groupBox6.Controls.Add(this.label20);
			this.groupBox6.ForeColor = System.Drawing.Color.Black;
			this.groupBox6.Location = new System.Drawing.Point(459, 48);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(357, 151);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(280, 40);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(24, 23);
			this.label33.TabIndex = 4;
			this.label33.Text = "%";
			// 
			// txGarantie
			// 
			this.txGarantie.BackColor = System.Drawing.Color.White;
			this.txGarantie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txGarantie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txGarantie.Enabled = false;
			this.txGarantie.Location = new System.Drawing.Point(176, 88);
			this.txGarantie.Name = "txGarantie";
			this.txGarantie.TabIndex = 3;
			this.txGarantie.Text = "90";
			this.txGarantie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txSeuil
			// 
			this.txSeuil.BackColor = System.Drawing.Color.White;
			this.txSeuil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txSeuil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txSeuil.Enabled = false;
			this.txSeuil.Location = new System.Drawing.Point(176, 40);
			this.txSeuil.Name = "txSeuil";
			this.txSeuil.TabIndex = 2;
			this.txSeuil.Text = "0,00";
			this.txSeuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.Location = new System.Drawing.Point(56, 88);
			this.label21.Name = "label21";
			this.label21.TabIndex = 1;
			this.label21.Text = "Délai garantie";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(56, 40);
			this.label20.Name = "label20";
			this.label20.TabIndex = 0;
			this.label20.Text = "Seuil réparation";
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label32.Location = new System.Drawing.Point(313, 193);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(271, 23);
			this.label32.TabIndex = 3;
			this.label32.Text = "Aucune machine hors parc.";
			this.label32.Visible = false;
			// 
			// btMachineHorsParc
			// 
			this.btMachineHorsParc.BackColor = System.Drawing.Color.Lavender;
			this.btMachineHorsParc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btMachineHorsParc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btMachineHorsParc.ForeColor = System.Drawing.Color.Black;
			this.btMachineHorsParc.Location = new System.Drawing.Point(132, 363);
			this.btMachineHorsParc.Name = "btMachineHorsParc";
			this.btMachineHorsParc.Size = new System.Drawing.Size(119, 35);
			this.btMachineHorsParc.TabIndex = 2;
			this.btMachineHorsParc.Text = "Machine hors parc";
			this.btMachineHorsParc.Click += new System.EventHandler(this.btMachineHorsParc_Click);
			// 
			// btMachineEnParc
			// 
			this.btMachineEnParc.BackColor = System.Drawing.Color.Lavender;
			this.btMachineEnParc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btMachineEnParc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btMachineEnParc.ForeColor = System.Drawing.Color.Black;
			this.btMachineEnParc.Location = new System.Drawing.Point(10, 363);
			this.btMachineEnParc.Name = "btMachineEnParc";
			this.btMachineEnParc.Size = new System.Drawing.Size(109, 35);
			this.btMachineEnParc.TabIndex = 1;
			this.btMachineEnParc.Text = "Machine en parc";
			this.btMachineEnParc.Click += new System.EventHandler(this.btMachineEnParc_Click);
			// 
			// lvMachines
			// 
			this.lvMachines.BackColor = System.Drawing.Color.MintCream;
			this.lvMachines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvMachines.FullRowSelect = true;
			this.lvMachines.GridLines = true;
			this.lvMachines.Location = new System.Drawing.Point(10, 17);
			this.lvMachines.Name = "lvMachines";
			this.lvMachines.Size = new System.Drawing.Size(900, 340);
			this.lvMachines.TabIndex = 0;
			this.lvMachines.View = System.Windows.Forms.View.Details;
			this.lvMachines.Visible = false;
			// 
			// txCommentaire
			// 
			this.txCommentaire.BackColor = System.Drawing.Color.MintCream;
			this.txCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCommentaire.Location = new System.Drawing.Point(8, 8);
			this.txCommentaire.Multiline = true;
			this.txCommentaire.Name = "txCommentaire";
			this.txCommentaire.Size = new System.Drawing.Size(896, 248);
			this.txCommentaire.TabIndex = 0;
			this.txCommentaire.Text = "";
			// 
			// btSupprime
			// 
			this.btSupprime.BackColor = System.Drawing.Color.White;
			this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSupprime.Enabled = false;
			this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btSupprime.ForeColor = System.Drawing.Color.Red;
			this.btSupprime.Location = new System.Drawing.Point(568, 640);
			this.btSupprime.Name = "btSupprime";
			this.btSupprime.Size = new System.Drawing.Size(100, 23);
			this.btSupprime.TabIndex = 11;
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
			this.btEnregistre.Location = new System.Drawing.Point(128, 640);
			this.btEnregistre.Name = "btEnregistre";
			this.btEnregistre.Size = new System.Drawing.Size(100, 23);
			this.btEnregistre.TabIndex = 13;
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
			this.btNouveau.Location = new System.Drawing.Point(16, 640);
			this.btNouveau.Name = "btNouveau";
			this.btNouveau.Size = new System.Drawing.Size(100, 23);
			this.btNouveau.TabIndex = 9;
			this.btNouveau.TabStop = false;
			this.btNouveau.Text = "Nouveau";
			this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
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
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Controls.Add(this.tabPageEX5);
			this.tabControlEX1.Controls.Add(this.tabPageEX3);
			this.tabControlEX1.Controls.Add(this.tabPageEX4);
			this.tabControlEX1.Controls.Add(this.tabPageEX2);
			this.tabControlEX1.Controls.Add(this.tabPageEX6);
			this.tabControlEX1.Controls.Add(this.tabPageEX7);
			this.tabControlEX1.ForeColor = System.Drawing.Color.Black;
			this.tabControlEX1.Location = new System.Drawing.Point(0, 56);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(930, 560);
			this.tabControlEX1.TabColor = System.Drawing.Color.Gray;
			this.tabControlEX1.TabIndex = 15;
			this.tabControlEX1.TabStop = false;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.txCodeGestion);
			this.tabPageEX1.Controls.Add(this.label3);
			this.tabPageEX1.Controls.Add(this.label2);
			this.tabPageEX1.Controls.Add(this.txIdent);
			this.tabPageEX1.Controls.Add(this.label14);
			this.tabPageEX1.Controls.Add(this.groupBox3);
			this.tabPageEX1.Controls.Add(this.txNom);
			this.tabPageEX1.Controls.Add(this.groupBox4);
			this.tabPageEX1.Controls.Add(this.groupBox2);
			this.tabPageEX1.ForeColor = System.Drawing.Color.Black;
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(922, 531);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Infos";
			// 
			// tabPageEX5
			// 
			this.tabPageEX5.Controls.Add(this.groupBox5);
			this.tabPageEX5.Controls.Add(this.groupBox6);
			this.tabPageEX5.Controls.Add(this.groupBox7);
			this.tabPageEX5.Controls.Add(this.groupBox8);
			this.tabPageEX5.ForeColor = System.Drawing.Color.Black;
			this.tabPageEX5.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX5.Name = "tabPageEX5";
			this.tabPageEX5.Size = new System.Drawing.Size(922, 531);
			this.tabPageEX5.TabIndex = 4;
			this.tabPageEX5.Text = "Autres infos";
			// 
			// tabPageEX3
			// 
			this.tabPageEX3.Controls.Add(this.button6);
			this.tabPageEX3.Controls.Add(this.button8);
			this.tabPageEX3.Controls.Add(this.mtgcComboBox3);
			this.tabPageEX3.Controls.Add(this.button5);
			this.tabPageEX3.Controls.Add(this.button4);
			this.tabPageEX3.Controls.Add(this.button2);
			this.tabPageEX3.Controls.Add(this.lvDevis);
			this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX3.Name = "tabPageEX3";
			this.tabPageEX3.Size = new System.Drawing.Size(922, 531);
			this.tabPageEX3.TabIndex = 2;
			this.tabPageEX3.Text = "Liste des devis";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Lavender;
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.Location = new System.Drawing.Point(712, 496);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(105, 28);
			this.button6.TabIndex = 8;
			this.button6.Text = "Edition Ferraillage";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Lavender;
			this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button8.Location = new System.Drawing.Point(592, 496);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(105, 28);
			this.button8.TabIndex = 7;
			this.button8.Text = "Edition FAX";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// mtgcComboBox3
			// 
			this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox3.ColumnNum = 2;
			this.mtgcComboBox3.ColumnWidth = "150;150";
			this.mtgcComboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.mtgcComboBox3.DisplayMember = "Text";
			this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox3.DropDownWidth = 320;
			this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox3.GridLineHorizontal = false;
			this.mtgcComboBox3.GridLineVertical = false;
			this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox3.Location = new System.Drawing.Point(8, 9);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(325, 21);
			this.mtgcComboBox3.TabIndex = 6;
			// 
			// tabPageEX4
			// 
			this.tabPageEX4.Controls.Add(this.lvInter);
			this.tabPageEX4.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX4.Name = "tabPageEX4";
			this.tabPageEX4.Size = new System.Drawing.Size(922, 531);
			this.tabPageEX4.TabIndex = 3;
			this.tabPageEX4.Text = "Prochains contrôles et interventions";
			// 
			// tabPageEX2
			// 
			this.tabPageEX2.Controls.Add(this.tabControlEX2);
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(922, 531);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Statistiques";
			// 
			// tabControlEX2
			// 
			this.tabControlEX2.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX2.BackColor = System.Drawing.Color.Transparent;
			this.tabControlEX2.Controls.Add(this.tabPageEX8);
			this.tabControlEX2.Controls.Add(this.tabPageEX9);
			this.tabControlEX2.Location = new System.Drawing.Point(72, 0);
			this.tabControlEX2.Name = "tabControlEX2";
			this.tabControlEX2.SelectedIndex = 0;
			this.tabControlEX2.SelectedTabColor = System.Drawing.Color.Silver;
			this.tabControlEX2.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX2.Size = new System.Drawing.Size(768, 388);
			this.tabControlEX2.TabColor = System.Drawing.Color.DarkGray;
			this.tabControlEX2.TabIndex = 4;
			this.tabControlEX2.UseVisualStyles = false;
			// 
			// tabPageEX8
			// 
			this.tabPageEX8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tabPageEX8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageEX8.BackgroundImage")));
			this.tabPageEX8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPageEX8.Controls.Add(this.button1);
			this.tabPageEX8.Controls.Add(this.panel1);
			this.tabPageEX8.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX8.Name = "tabPageEX8";
			this.tabPageEX8.Size = new System.Drawing.Size(760, 359);
			this.tabPageEX8.TabIndex = 0;
			this.tabPageEX8.Text = "Chiffre d\'affaires";
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(536, 368);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Impression";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label35);
			this.panel1.Controls.Add(this.chartControl1);
			this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(763, 361);
			this.panel1.TabIndex = 4;
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.White;
			this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label35.ForeColor = System.Drawing.Color.White;
			this.label35.Location = new System.Drawing.Point(22, 6);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(713, 23);
			this.label35.TabIndex = 0;
			this.label35.Text = "Statistiques du chiffre d\'affaires sur 5 années";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chartControl1
			// 
			this.chartControl1.BackColor = System.Drawing.Color.White;
			this.chartControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chartControl1.ForeColor = System.Drawing.Color.White;
			this.chartControl1.Location = new System.Drawing.Point(24, 38);
			this.chartControl1.Name = "chartControl1";
			this.chartControl1.Size = new System.Drawing.Size(712, 313);
			this.chartControl1.TabIndex = 1;
			this.chartControl1.Text = "chartControl1";
			this.chartControl1.Visible = false;
			// 
			// tabPageEX9
			// 
			this.tabPageEX9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPageEX9.Controls.Add(this.panel2);
			this.tabPageEX9.Cursor = System.Windows.Forms.Cursors.No;
			this.tabPageEX9.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX9.Name = "tabPageEX9";
			this.tabPageEX9.Size = new System.Drawing.Size(760, 359);
			this.tabPageEX9.TabIndex = 1;
			this.tabPageEX9.Text = "Réparations";
			// 
			// tabPageEX6
			// 
			this.tabPageEX6.Controls.Add(this.label32);
			this.tabPageEX6.Controls.Add(this.btMachineHorsParc);
			this.tabPageEX6.Controls.Add(this.btMachineEnParc);
			this.tabPageEX6.Controls.Add(this.lvMachines);
			this.tabPageEX6.ForeColor = System.Drawing.Color.Black;
			this.tabPageEX6.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX6.Name = "tabPageEX6";
			this.tabPageEX6.Size = new System.Drawing.Size(922, 531);
			this.tabPageEX6.TabIndex = 5;
			this.tabPageEX6.Text = "Liste des machines";
			// 
			// tabPageEX7
			// 
			this.tabPageEX7.Controls.Add(this.pictureBox3);
			this.tabPageEX7.Controls.Add(this.txCommentaire);
			this.tabPageEX7.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX7.Name = "tabPageEX7";
			this.tabPageEX7.Size = new System.Drawing.Size(922, 531);
			this.tabPageEX7.TabIndex = 6;
			this.tabPageEX7.Text = "Commentaires";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(928, 8);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(56, 56);
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(584, -8);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(64, 56);
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Black;
			this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
			this.button7.Location = new System.Drawing.Point(864, 624);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(48, 48);
			this.button7.TabIndex = 20;
			this.button7.TabStop = false;
			this.button7.Click += new System.EventHandler(this.button7_Click_1);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printDocument2
			// 
			this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
			// 
			// Clients
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(924, 688);
			this.ControlBox = false;
			this.Controls.Add(this.button7);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.tabControlEX1);
			this.Controls.Add(this.btSupprime);
			this.Controls.Add(this.btEnregistre);
			this.Controls.Add(this.btNouveau);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Clients";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clients";
			this.VisibleChanged += new System.EventHandler(this.Clients_VisibleChanged);
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.tabPageEX5.ResumeLayout(false);
			this.tabPageEX3.ResumeLayout(false);
			this.tabPageEX4.ResumeLayout(false);
			this.tabPageEX2.ResumeLayout(false);
			this.tabControlEX2.ResumeLayout(false);
			this.tabPageEX8.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabPageEX9.ResumeLayout(false);
			this.tabPageEX6.ResumeLayout(false);
			this.tabPageEX7.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void comboNom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}

		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void Nettoyage()
		{
			cbRechercheClient.Visible=true;
			label1.Visible=true;
			lvCorres.Items.Clear();
			lvMachines.Items.Clear();
			txAdresse1.Clear();
			txAdresse2.Clear();
			mtgcComboBox2.SelectedIndex=0;
			txCodeGestion.Clear();
			mtgcComboBox1.SelectedIndex=0;
			txNom.Clear();
			txBatiment.Clear();
			txVille.Clear();
			txCodePostal.Clear();
			txFax.Clear();
			txTel.Clear();
			txPays.Text="FRANCE";
			txIdent.Clear();
			txPourcentage.Text="0";
			txTrans.Text="PP";
			txrRegl.Text="TA";
			txForfaitDNR.Text="0,00";
			txForfaitTrans.Text="0,00";
			txCoefDNR.Text="1,00";
			txCoefTrans.Text="1,00";
			txCoefControle.Text="1,00";
			txCde.Clear();
			txFourn.Clear();
			txControle.Text="0,00";
			txSeuil.Text="0";
			txGarantie.Text="90";
			lvDevis.Items.Clear();
			txBorne.Clear();
			txCommentaire.Clear();
		}

		private void Activation()
		{
			btSupprime.Enabled=true;
			mtgcComboBox2.Enabled=true;
			txCodeGestion.Enabled=true;
			mtgcComboBox1.Enabled=true;
			txNom.ReadOnly=false;
			txBatiment.Enabled=true;
			btCrea1.Enabled=true;
			btCrea2.Enabled=true;
			mtgcComboBox1.Enabled=true;
			txAdresse1.Enabled=true;
			txAdresse2.Enabled=true;
			txVille.Enabled=true;
			txCodePostal.Enabled=true;
			txFax.Enabled=true;
			txTel.Enabled=true;
			txPays.Enabled=true;
			txIdent.Enabled=true;
			lvCorres.Visible=true;
			groupBox4.Visible=true;
			btSupCorres.Visible=true;
			btNewCorres.Visible=true;
			txPourcentage.Enabled=true;
			txrRegl.Enabled=true;
			txTrans.Enabled=true;
			txFourn.Enabled=true;
			btRegl.Enabled=true;
			btTrans.Enabled=true;
			txCde.Enabled=true;
			txForfaitDNR.Enabled=true;
			txControle.Enabled=true;
			txForfaitTrans.Enabled=true;
			txCoefControle.Enabled=true;
			txCoefDNR.Enabled=true;
			txCoefTrans.Enabled=true;
			txSeuil.Enabled=true;
			txGarantie.Enabled=true;
			txBorne.Enabled=true;
		}

		private void Desactivation()
		{
			btSupprime.Enabled=false;
			mtgcComboBox2.Enabled=false;
			txCodeGestion.Enabled=false;
			mtgcComboBox1.Enabled=false;
			txNom.ReadOnly=true;
			txBatiment.Enabled=false;
			btCrea1.Enabled=false;
			btCrea2.Enabled=false;
			mtgcComboBox1.Enabled=false;
			txAdresse1.Enabled=false;
			txAdresse2.Enabled=false;
			txVille.Enabled=false;
			txCodePostal.Enabled=false;
			txFax.Enabled=false;
			txTel.Enabled=false;
			txPays.Enabled=false;
			txIdent.Enabled=false;
			lvCorres.Visible=false;
			groupBox4.Visible=false;
			btSupCorres.Visible=false;
			btNewCorres.Visible=false;
			txPourcentage.Enabled=false;
			txrRegl.Enabled=false;
			txTrans.Enabled=false;
			txFourn.Enabled=false;
			btRegl.Enabled=false;
			btTrans.Enabled=false;
			txCde.Enabled=false;
			txForfaitDNR.Enabled=false;
			txControle.Enabled=false;
			txForfaitTrans.Enabled=false;
			txCoefControle.Enabled=false;
			txCoefDNR.Enabled=false;
			txCoefTrans.Enabled=false;
			txSeuil.Enabled=false;
			txGarantie.Enabled=false;
			txBorne.Enabled=false;
		}

		private void btCrea1_Click(object sender, System.EventArgs e)
		{
			AcGroupes WinAcGroupes = new AcGroupes(Agence);
			WinAcGroupes.ShowDialog();
			mtgcComboBox1.Items.Clear();
			Comm.CommandText="SELECT Code, Designation FROM T_Groupes ORDER BY Code";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_groupes");
			mtgcComboBox1.SourceDataTable=ds.Tables["t_groupes"];
			mtgcComboBox1.SourceDataString = new string[]{"Code","designation","",""};
			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox1.SelectedIndex=0;
			ds.Tables["t_groupes"].Clear();


		}

		private void btCrea2_Click(object sender, System.EventArgs e)
		{
			AcUsines WinAcUsines = new AcUsines(Agence);
			WinAcUsines.ShowDialog();	
			mtgcComboBox2.Items.Clear();
			Comm.CommandText="SELECT Code_usine, Designation FROM T_usine ORDER BY Code_usine";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_usine");
			mtgcComboBox2.SourceDataTable=ds.Tables["t_usine"];
			mtgcComboBox2.SourceDataString = new string[]{"Code_usine","designation","",""};
			mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox2.SelectedIndex=0;
			ds.Tables["t_usine"].Clear();
		}

		private void btCrea3_Click(object sender, System.EventArgs e)
		{
			AcGroupes WinAcGroupes = new AcGroupes(Agence);
			WinAcGroupes.ShowDialog();
		}

		private void btUsine_Click(object sender, System.EventArgs e)
		{
		}

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			groupBox1.BackColor=Color.SteelBlue;
			label34.Visible=true;
			Nouveau=true;
			Nettoyage();
			cbRechercheClient.SelectedIndex=0;
			cbRechercheClient.Visible=false;
			Activation();
			label1.Visible=false;
			btEnregistre.Enabled=true;
			txNom.BackColor=Color.MistyRose;
			txNom.Focus();
			int cpt=0;
			Comm.CommandText="SELECT Max(T_clients.Ident) AS MaxDeIdent FROM T_clients";
			try
			{
				oleDbConnection1.Open();
				cpt=System.Convert.ToInt32(Comm.ExecuteScalar());
				cpt++;
				txIdent.Text=cpt.ToString();
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
			Nouveau=false;
			OleDbCommand Requete = new OleDbCommand();
			OleDbDataAdapter Data1 = new OleDbDataAdapter();
			Requete.Connection=oleDbConnection1;
			DataSet ds = new DataSet();
			string com="select * from T_clients where Ident = "+txIdent.Text;
			Requete.CommandText=com;
			Data1.SelectCommand=Requete;
			try
			{
				Data1.Fill(ds,"T_clients");
			}
			catch (OleDbException exp)
			{
				MessageBox.Show(exp.Message);
			}
			if(ds.Tables["T_clients"].Rows.Count.Equals(0))
			{
				if(Save(true))
				{
					InfoCorres WinInfo = new InfoCorres(Agence,true,txNom.Text, txIdent.Text,txPays.Text);
					WinInfo.ShowDialog();
					lvCorres.Items.Clear();	
					com="select * from T_clients_coressp where Ident = "+txIdent.Text;
					Requete.CommandText=com;
					Data1.SelectCommand=Requete;
					try
					{
						Data1.Fill(ds,"T_clients_coressp");
					}
					catch (OleDbException exp)
					{
						MessageBox.Show(exp.Message);
					}
					DataTable Table = ds.Tables["T_clients_coressp"];
					foreach (DataRow rowSel in Table.Rows)
					{
						ListViewItem item = new ListViewItem(rowSel["Nom"].ToString());
						item.SubItems.Add(rowSel["Prenom"].ToString());
						item.SubItems.Add(rowSel["E_mail"].ToString());
						item.SubItems.Add(rowSel["Telephone"].ToString());
						item.SubItems.Add(rowSel["Telecopie"].ToString());
						item.Tag=rowSel["Cle"].ToString();
						lvCorres.Items.Add(item);
					}
					oleDbConnection1.Close();
				}
			}
			else
			{
				InfoCorres WinInfo = new InfoCorres(Agence,true,txNom.Text, txIdent.Text,txPays.Text);
				WinInfo.ShowDialog();
				lvCorres.Items.Clear();	
				com="select * from T_clients_coressp where Ident = "+txIdent.Text;
				Requete.CommandText=com;
				Data1.SelectCommand=Requete;
				try
				{
					Data1.Fill(ds,"T_clients_coressp");
				}
				catch (OleDbException exp)
				{
					MessageBox.Show(exp.Message);
				}
				DataTable Table = ds.Tables["T_clients_coressp"];
				foreach (DataRow rowSel in Table.Rows)
				{
					ListViewItem item = new ListViewItem(rowSel["Nom"].ToString());
					item.SubItems.Add(rowSel["Prenom"].ToString());
					item.SubItems.Add(rowSel["E_mail"].ToString());
					item.SubItems.Add(rowSel["Telephone"].ToString());
					item.SubItems.Add(rowSel["Telecopie"].ToString());
					item.Tag=rowSel["Cle"].ToString();
					lvCorres.Items.Add(item);
				}
				oleDbConnection1.Close();
			}
		}


		private void button3_Click(object sender, System.EventArgs e)
		{
			if(lvCorres.SelectedIndices.Count==0)
				MessageBox.Show("Veuillez selectionner une ligne !");
			else
			{
				ListViewItem Client = (ListViewItem)lvCorres.SelectedItems[0];
				Comm.CommandText="select * from T_clients_coressp where Cle = "+Client.Tag.ToString();
				DataAD.SelectCommand=Comm;
				try
				{
					if(DataAD.Fill(ds,"T_clients_coressp")>0)
					{
						DataTable Table = ds.Tables["T_clients_coressp"];
						NomCorres=ds.Tables["T_clients_coressp"].Rows[0]["Nom"].ToString();
						PrenomCorres=ds.Tables["T_clients_coressp"].Rows[0]["Prenom"].ToString();
						Mel=ds.Tables["T_clients_coressp"].Rows[0]["E_mail"].ToString();
						Tel=ds.Tables["T_clients_coressp"].Rows[0]["Telephone"].ToString();
						Fax=ds.Tables["T_clients_coressp"].Rows[0]["telecopie"].ToString();
						Service=ds.Tables["T_clients_coressp"].Rows[0]["Service"].ToString();
						Fonction=ds.Tables["T_clients_coressp"].Rows[0]["Fonction"].ToString();
						Note=ds.Tables["T_clients_coressp"].Rows[0]["Memo"].ToString();
						IDRow=ds.Tables["T_clients_coressp"].Rows[0]["Cle"].ToString();
						Pays=txPays.Text;
						ds.Tables["T_clients_coressp"].Clear();
						InfoCorres WinInfo = new InfoCorres(Agence,true,IDRow,txNom.Text, txIdent.Text, NomCorres, PrenomCorres, Mel, Tel, Fax, Service, Fonction, Note, Pays);
						WinInfo.ShowDialog();
					}
				}
				catch (OleDbException exp)
				{
					MessageBox.Show(exp.Message);
				}
				
				lvCorres.Items.Clear();
				Comm.CommandText="select * from T_clients_coressp where Ident="+System.Convert.ToInt32(txIdent.Text);
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"T_clients_coressp");
				}
				catch (OleDbException exp)
				{
					MessageBox.Show(exp.Message);
				}
				DataTable Table2 = ds.Tables["T_clients_coressp"];
				foreach (DataRow rowSel in Table2.Rows)
				{
					ListViewItem item = new ListViewItem(rowSel["Nom"].ToString());
					if(rowSel["Prenom"].ToString()!="?")
						item.SubItems.Add(rowSel["Prenom"].ToString());
					else
						item.SubItems.Add(" ");
					if(rowSel["E_mail"].ToString()!="?")
						item.SubItems.Add(rowSel["E_mail"].ToString());
					else
						item.SubItems.Add(" ");
					if(rowSel["Telephone"].ToString()!="?")
						item.SubItems.Add(rowSel["Telephone"].ToString());
					else
						item.SubItems.Add(" ");
					item.SubItems.Add(rowSel["Telecopie"].ToString());
					item.Tag=rowSel["Cle"].ToString();
					lvCorres.Items.Add(item);
				}
				ds.Tables["T_clients_coressp"].Clear();
			}
		}

		private void btSupCorres_Click(object sender, System.EventArgs e)
		{
			if(lvCorres.SelectedIndices.Count==0)
				MessageBox.Show("Veuillez selectionnez une ligne !");
			else
			{
				ListViewItem Item = (ListViewItem)lvCorres.SelectedItems[0];
				if(MessageBox.Show("Etes vous certain de vouloir supprimer l'utilisateur "+Item.Text+" ?","Attention",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
				{
					Comm.CommandText="DELETE FROM T_clients_coressp WHERE Cle="+Item.Tag.ToString();
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
					lvCorres.Items.Clear();
					Comm.CommandText="select * from T_clients_coressp where Ident = "+txIdent.Text;
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"T_clients_coressp");
					}
					catch (OleDbException exp)
					{
						MessageBox.Show(exp.Message);
					}
					DataTable Table = ds.Tables["T_clients_coressp"];
					foreach (DataRow rowSel in Table.Rows)
					{
						ListViewItem item = new ListViewItem(rowSel["Nom"].ToString());
						item.SubItems.Add(rowSel["Prenom"].ToString());
						item.SubItems.Add(rowSel["E_mail"].ToString());
						item.SubItems.Add(rowSel["Telephone"].ToString());
						item.SubItems.Add(rowSel["Telecopie"].ToString());
						item.Tag=rowSel["Cle"].ToString();
						lvCorres.Items.Add(item);
					}
					ds.Tables["T_clients_coressp"].Clear();
				}
			}
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			if(!Nouveau)
				Save(false);
			else
				Save(true);
		}
				

		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Supprimer le client ?","Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
			{
				Comm.CommandText="delete from t_clients where ident="+txIdent.Text;
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
						Nettoyage();
						Desactivation();
						cbRechercheClient.Text="";
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
				
			}

			
		}

		private void btRegl_Click(object sender, System.EventArgs e)
		{
			SelectReglement WinRegl = new SelectReglement(Agence);
			WinRegl.ShowDialog();
            txrRegl.Text=WinRegl.Reglement();
		}

		private void btTrans_Click(object sender, System.EventArgs e)
		{
			SelectTransport WinTrans = new SelectTransport(Agence);
			WinTrans.ShowDialog();
			txTrans.Text=WinTrans.TypeTrans;
		}

		private void lvDevis_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			SortColumn(e.Column);
		}

		class ListViewComparer : IComparer 
		{
			private int col;
			private bool m_bNumeric=true;

			public ListViewComparer() 
			{
				col=0;
			}
			public ListViewComparer(int column) 
			{
				col=column;
			}
			public int Compare(object y, object x) 
			{
				try
				{
					if(!(x is ListViewItem)&& !(y is ListViewItem))
						return 0;
					ListViewItem lv1 = (ListViewItem) x;
					ListViewItem lv2 = (ListViewItem) y;

					if(m_bNumeric)
						return (System.Convert.ToInt32(lv1.SubItems[col].Text)-System.Convert.ToInt32(lv2.SubItems[col].Text));
					else
						return string.Compare(lv1.SubItems[col].Text, lv2.SubItems[col].Text);
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				return 0;
			}
			public bool bNumeric
			{
				set
				{
					m_bNumeric= value;
				}
			}

			public int Column
			{
				set
				{
					col = value;
				}
			}
		}

			private void SortColumn( int iColumn)
			{
				ListViewComparer lvc = new ListViewComparer();

				try
				{
					string s1 = lvDevis.Items[1].SubItems[iColumn].Text.ToUpper().Trim();
					long lng = System.Convert.ToInt32(s1);
					lvc.bNumeric=true;
					lvc.Column=iColumn;
				
				}
				catch(Exception exp)
				{
					lvc.bNumeric=false;
					Console.WriteLine(exp.Message);
				}
				lvDevis.ListViewItemSorter = lvc;
			}


		private void button2_Click_3(object sender, System.EventArgs e)
		{
			lvDevis.Items.Clear();
			Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_famille_machine.Designation, T_devis_entete.Date, T_devis_entete.[Date Decision], T_devis_entete.[Date reparation], T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.Niveau FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Code Client])="+txIdent.Text+"))ORDER BY T_devis_entete.[N° Devis] DESC";
            DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_devis_entete");
			foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
			{
				lvDevis.Items.Add(row["Niveau"].ToString());
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["N° Devis"].ToString());
				try
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Date"].ToString().Remove(10,9));
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				try
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Date decision"].ToString().Remove(10,9));
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				try
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Date reparation"].ToString().Remove(10,9));
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Code materiel"].ToString());
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Type machine"].ToString());
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Designation"].ToString());
			}
			ds.Tables["t_devis_entete"].Clear();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			lvDevis.Items.Clear();
			TimeSpan Jours = new TimeSpan(90,0,0,0,0);
			DateTime Devis=DateTime.Now.Subtract(Jours);
			Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_famille_machine.Designation, T_devis_entete.Date, T_devis_entete.[Date Decision], T_devis_entete.[Date reparation], T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.Niveau FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Code Client])="+txIdent.Text+") AND ((T_devis_entete.Date)<#"+Devis+"#) AND ((T_devis_entete.Niveau)=3)) ORDER BY T_devis_entete.[N° Devis] DESC";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_devis_entete");
			foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
			{
				lvDevis.Items.Add(row["Niveau"].ToString());
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["N° Devis"].ToString());
				try
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Date"].ToString().Remove(10,9));
				}
				catch
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(" ");
				}
				try
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Date decision"].ToString().Remove(10,9));
				}
				catch
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(" ");
				}
				try
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Date reparation"].ToString().Remove(10,9));
				}
				catch
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(" ");
				}
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Code materiel"].ToString());
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Type machine"].ToString());
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Designation"].ToString());
			}
			ds.Tables["t_devis_entete"].Clear();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			lvDevis.Items.Clear();
			Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_famille_machine.Designation, T_devis_entete.Date, T_devis_entete.[Date Decision], T_devis_entete.[Date reparation], T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.Niveau FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Code Client])="+txIdent.Text+") AND ((T_devis_entete.Niveau)<=3)) ORDER BY T_devis_entete.[N° Devis] DESC";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_devis_entete");
			foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
			{
				lvDevis.Items.Add(row["Niveau"].ToString());
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["N° Devis"].ToString());
				try
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Date"].ToString().Remove(10,9));
				}
				catch
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(" ");
				}
				try
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Date decision"].ToString().Remove(10,9));
				}
				catch
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(" ");
				}
				try
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Date reparation"].ToString().Remove(10,9));
				}
				catch
				{
					lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(" ");
				}
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Code materiel"].ToString());
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Type machine"].ToString());
				lvDevis.Items[lvDevis.Items.Count-1].SubItems.Add(row["Designation"].ToString());
			}
			ds.Tables["t_devis_entete"].Clear();
		}

		private void lvDevis_DoubleClick(object sender, System.EventArgs e)
		{
			lvDevis.Items[lvDevis.SelectedIndices[0]].Checked=false;
			this.Refresh();
			if(lvDevis.SelectedIndices.Count>0)
				WinDetailDevis.Remplir(lvDevis.Items[lvDevis.SelectedIndices[0]].SubItems[1].Text);
		}

		private void btMachineEnParc_Click(object sender, System.EventArgs e)
		{
			lvMachines.Items.Clear();
			lvMachines.Columns.Clear();
			label32.Visible=false;
			ColumnHeader Col = new ColumnHeader();
			Col.Text="Code machine opindus";
			Col.Width=200;
			lvMachines.Columns.Add(Col);
			ColumnHeader Col2 = new ColumnHeader();
			Col2.Text="Code machine client";
			Col2.Width=200;
			lvMachines.Columns.Add(Col2);
			ColumnHeader Col3 = new ColumnHeader();
			Col3.Text="N° Serie";
			Col3.Width=150;
			lvMachines.Columns.Add(Col3);
			ColumnHeader Col4 = new ColumnHeader();
			Col4.Text="Type";
			Col4.Width=150;
			lvMachines.Columns.Add(Col4);
			lvMachines.Visible=true;

			Comm.CommandText="select * from t_parc_machine where [Code Client]="+txIdent.Text;
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_parc_machine");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			foreach(DataRow row in ds.Tables["t_parc_machine"].Rows)
			{
				ListViewItem item = new ListViewItem(row["code machine opindus"].ToString());
				item.SubItems.Add(row["code machine client"].ToString());
				item.SubItems.Add(row["No serie"].ToString());
				item.SubItems.Add(row["Type machine"].ToString());
				lvMachines.Items.Add(item);
			}
			ds.Tables["t_parc_machine"].Clear();
		}

		private void btMachineHorsParc_Click(object sender, System.EventArgs e)
		{
			lvMachines.Columns.Clear();
			lvMachines.Items.Clear();
			label32.Visible=false;
			ColumnHeader Col = new ColumnHeader();
			Col.Text="Code machine opindus";
			Col.Width=150;
			lvMachines.Columns.Add(Col);
			ColumnHeader Col2 = new ColumnHeader();
			Col2.Text="Code machine client";
			Col2.Width=150;
			lvMachines.Columns.Add(Col2);
			ColumnHeader Col3 = new ColumnHeader();
			Col3.Text="N° Serie";
			Col3.Width=130;
			lvMachines.Columns.Add(Col3);
			ColumnHeader Col4 = new ColumnHeader();
			Col4.Text="Type";
			Col4.Width=130;
			lvMachines.Columns.Add(Col4);
			ColumnHeader Col5 = new ColumnHeader();
			Col5.Text="Refus";
			Col5.Width=80;
			lvMachines.Columns.Add(Col5);
			ColumnHeader Col6 = new ColumnHeader();
			Col6.Text="Reforme";
			Col6.Width=80;
			lvMachines.Columns.Add(Col6);

			Comm.CommandText="select * from t_parc_machine where [Code Client]="+txIdent.Text;
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_parc_machine");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			foreach(DataRow row in ds.Tables["t_parc_machine"].Rows)
			{
				
				if(row["Date reforme"].ToString().Length>0)
				{
					ListViewItem item = new ListViewItem(row["code machine opindus"].ToString());
					
					item.SubItems.Add(row["code machine client"].ToString());
					item.SubItems.Add(row["No serie"].ToString());
					item.SubItems.Add(row["Type machine"].ToString());
					if(row["Date refus"].ToString().Length>0)
						item.SubItems.Add(row["Date refus"].ToString().Remove(10,9));
					else
						item.SubItems.Add(" ");
					if(row["Date reforme"].ToString().Length>0)
						item.SubItems.Add(row["Date reforme"].ToString().Remove(10,9));
					else
						item.SubItems.Add(" ");
					lvMachines.Items.Add(item);
				}
			}
			if(lvMachines.Items.Count.Equals(0))
				label32.Visible=true;
			oleDbConnection1.Close();
			lvMachines.Visible=true;

			ds.Tables["t_parc_machine"].Clear();
		}

		private bool Save(bool crea)
		{
			int Error=0;

			if(txNom.TextLength.Equals(0)&&Error.Equals(0))
			{
				txNom.BackColor=Color.MistyRose;
				Error=1;
				MessageBox.Show("Le champs nom ne peut être vide","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
				txNom.BackColor=Color.Empty;
			if(mtgcComboBox1.SelectedIndex.Equals(0)||mtgcComboBox2.SelectedIndex.Equals(0)&&Error.Equals(0))
			{
				MessageBox.Show("Les champs Groupe et usine sont obligatoire","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
				Error=1;
			}
			if((crea.Equals(false))&&(txrRegl.Text.Length.Equals(0)||txTrans.Text.Length.Equals(0))&&Error.Equals(0))
			{
				MessageBox.Show("Les champs Règlement et Transport sont obligatoire","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
				Error=1;
			}
			if(Error.Equals(0))
			{
				Comm.CommandText="SELECT ident FROM t_clients WHERE ident="+txIdent.Text;
				int Nb=0;
				try
				{
					oleDbConnection1.Open();
					Nb=System.Convert.ToInt32(Comm.ExecuteScalar());
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				finally
				{
					oleDbConnection1.Close();
				}
				if(Nb.Equals(0))
				{
					String SQL="";
					SQL+="INSERT INTO T_clients(ident,groupe,usine,nom";
					if(txCodeGestion.TextLength>0)
						SQL+=",Code_GC";
					if(txAdresse1.TextLength>0)
						SQL+=",Adresse_1";
					if(txAdresse2.TextLength>0)
						SQL+=",Adresse_2";
					if(txCodePostal.TextLength>0)
						SQL+=",Code_Postal";
					if(txVille.TextLength>0)
						SQL+=",Ville";
					if(txPays.TextLength>0)
						SQL+=",Pays";
					if(txTel.TextLength>0)
						SQL+=",Telephone";
					if(txFax.TextLength>0)
						SQL+=",Telecopie";
					if(txBatiment.TextLength>0)
						SQL+=",Batiment";
					if(txPourcentage.TextLength>0)
						SQL+=",Pourcentage_remise";
					if(txrRegl.TextLength>0)
						SQL+=",Code_reglement";
					if(txTrans.TextLength>0)
						SQL+=",Code_transport";
					if(txFourn.TextLength>0)
						SQL+=",Notre_code_fournisseur";
					if(txCde.TextLength>0)
						SQL+=",N°_cde_ouverte";
					if(txForfaitDNR.TextLength>0)
						SQL+=",Forfait_dnr";
					if(txControle.TextLength>0)
						SQL+=",Forfait_controle";
					if(txForfaitTrans.TextLength>0)
						SQL+=",Forfait_transport";
					if(txCoefDNR.TextLength>0)
						SQL+=",Coef_dnr";
					if(txCoefControle.TextLength>0)
						SQL+=",Coef_controle";
					if(txCoefTrans.TextLength>0)
						SQL+=",Coef_transport";
					if(txSeuil.TextLength>0)
						SQL+=",Seuil_reparation";
					if(txGarantie.TextLength>0)
						SQL+=",Delai_garantie";

					SQL+=") VALUES ("+txIdent.Text+",'"+mtgcComboBox1.Text+"','"+mtgcComboBox2.Text+"','"+txNom.Text.Replace("'","''")+"'";
					if(txCodeGestion.TextLength>0)
						SQL+=",'"+txCodeGestion.Text.Replace("'","''")+"'";
					if(txAdresse1.TextLength>0)
						SQL+=",'"+txAdresse1.Text.Replace("'","''")+"'";
					if(txAdresse2.TextLength>0)
						SQL+=",'"+txAdresse2.Text.Replace("'","''")+"'";
					if(txCodePostal.TextLength>0)
						SQL+=",'"+txCodePostal.Text.Replace("'","''")+"'";
					if(txVille.TextLength>0)
						SQL+=",'"+txVille.Text.Replace("'","''")+"'";
					if(txPays.TextLength>0)
						SQL+=",'"+txPays.Text.Replace("'","''")+"'";
					if(txTel.TextLength>0)
						SQL+=",'"+txTel.Text.Replace("'","''")+"'";
					if(txFax.TextLength>0)
						SQL+=",'"+txFax.Text.Replace("'","''")+"'";
					if(txBatiment.TextLength>0)
						SQL+=",'"+txBatiment.Text.Replace("'","''")+"'";
					if(txPourcentage.TextLength>0)
						SQL+=","+System.Convert.ToDecimal(txPourcentage.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txrRegl.TextLength>0)
						SQL+=",'"+txrRegl.Text.Replace("'","''")+"'";
					if(txTrans.TextLength>0)
						SQL+=",'"+txTrans.Text.Replace("'","''")+"'";
					if(txFourn.TextLength>0)
						SQL+=",'"+txFourn.Text.Replace("'","''")+"'";
					if(txCde.TextLength>0)
						SQL+=",'"+txCde.Text.Replace("'","''")+"'";
					if(txForfaitDNR.TextLength>0)
						SQL+=","+System.Convert.ToDecimal(txForfaitDNR.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txControle.TextLength>0)
						SQL+=","+System.Convert.ToDecimal(txControle.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txForfaitTrans.TextLength>0)
						SQL+=","+System.Convert.ToDecimal(txForfaitTrans.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txCoefDNR.TextLength>0)
						SQL+=","+System.Convert.ToDecimal(txCoefDNR.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txCoefControle.TextLength>0)
						SQL+=","+System.Convert.ToDecimal(txCoefControle.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txCoefTrans.TextLength>0)
						SQL+=","+System.Convert.ToDecimal(txCoefTrans.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txSeuil.TextLength>0)
						SQL+=","+System.Convert.ToDecimal(txSeuil.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txGarantie.TextLength>0)
						SQL+=","+System.Convert.ToDecimal(txGarantie.Text.Replace(".",",")).ToString().Replace(",",".");
					SQL+=")";
				
					Comm.CommandText=SQL;
					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
							cbRechercheClient.Items.Clear();
							Comm.CommandText="select nom, adresse_1, code_postal, ville from t_clients order by nom";
							DataAD.SelectCommand=Comm;
							try
							{
								DataAD.Fill(ds,"t_clients");
							}
							catch(Exception exp)
							{
								MessageBox.Show(exp.Message);
							}
							cbRechercheClient.SourceDataTable=ds.Tables["t_clients"];
							cbRechercheClient.SourceDataString = new string[]{"nom","adresse_1","code_postal","ville"};
							cbRechercheClient.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
							cbRechercheClient.SelectedIndex=0;
							ds.Tables["t_clients"].Clear();
							Nouveau=false;
							return true;
						}
						catch(OleDbException ex)
						{
							Transac.Rollback();
						}
					}
					catch(OleDbException exep)
					{
						MessageBox.Show(exep.Message);
						MessageBox.Show(Comm.CommandText);
					}
					finally
					{
						oleDbConnection1.Close();
					}
				}
				else
				{
					String SQL="";
					SQL="update t_clients set nom='"+txNom.Text.ToUpper()+"',groupe='"+mtgcComboBox1.Text+"',usine='"+mtgcComboBox2.Text+"'";
					if(txCodeGestion.TextLength>0)
						SQL+=",code_gc='"+txCodeGestion.Text.Replace("'","''")+"'";
					if(txAdresse1.TextLength>0)
						SQL+=",adresse_1='"+txAdresse1.Text.Replace("'","''")+"'";
					if(txAdresse2.TextLength>0)
						SQL+=",adresse_2='"+txAdresse2.Text.Replace("'","''")+"'";
					if(txCodePostal.TextLength>0)
						SQL+=",code_postal='"+txCodePostal.Text.Replace("'","''")+"'";
					if(txVille.TextLength>0)
						SQL+=",ville='"+txVille.Text.Replace("'","''")+"'";
					if(txPays.TextLength>0)
						SQL+=",pays='"+txPays.Text.Replace("'","''")+"'";
					if(txTel.TextLength>0)
						SQL+=",telephone='"+txTel.Text.Replace("'","''")+"'";
					if(txFax.TextLength>0)
						SQL+=",telecopie='"+txFax.Text.Replace("'","''")+"'";
					if(txBatiment.TextLength>0)
						SQL+=",batiment='"+txBatiment.Text.Replace("'","''")+"'";
					if(txTrans.TextLength>0)
						SQL+=",code_transport='"+txTrans.Text.Replace("'","''")+"'";
					if(txrRegl.TextLength>0)
						SQL+=",code_reglement='"+txrRegl.Text.Replace("'","''")+"'";
					if(txFourn.TextLength>0)
						SQL+=",notre_code_fournisseur='"+txFourn.Text.Replace("'","''")+"'";
					if(txCde.TextLength>0)
						SQL+=",N°_cde_ouverte='"+txCde.Text.Replace("'","''")+"'";
					if(txPourcentage.TextLength>0)
						SQL+=",pourcentage_remise="+System.Convert.ToDecimal(txPourcentage.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txForfaitDNR.TextLength>0)
						SQL+=",forfait_dnr="+System.Convert.ToDecimal(txForfaitDNR.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txControle.TextLength>0)
						SQL+=",forfait_controle="+System.Convert.ToDecimal(txControle.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txForfaitTrans.TextLength>0)
						SQL+=",forfait_transport="+System.Convert.ToDecimal(txForfaitTrans.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txCoefDNR.TextLength>0)
						SQL+=",coef_dnr="+System.Convert.ToDecimal(txCoefDNR.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txCoefControle.TextLength>0)
						SQL+=",coef_controle="+System.Convert.ToDecimal(txCoefControle.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txCoefTrans.TextLength>0)
						SQL+=",coef_transport="+System.Convert.ToDecimal(txCoefTrans.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txSeuil.TextLength>0)
						SQL+=",seuil_reparation="+System.Convert.ToDecimal(txSeuil.Text.Replace(".",",")).ToString().Replace(",",".");
					if(txGarantie.TextLength>0)
						SQL+=",delai_garantie="+System.Convert.ToDecimal(txGarantie.Text.Replace(".",",")).ToString().Replace(",",".");
					SQL+=" WHERE ident="+txIdent.Text;
					Comm.CommandText=SQL;
					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
							cbRechercheClient.Items.Clear();
							Comm.CommandText="select nom, adresse_1, code_postal, ville from t_clients order by nom";
							DataAD.SelectCommand=Comm;
							try
							{
								DataAD.Fill(ds,"t_clients");
							}
							catch(Exception exp)
							{
								MessageBox.Show(exp.Message);
							}
							cbRechercheClient.SourceDataTable=ds.Tables["t_clients"];
							cbRechercheClient.SourceDataString = new string[]{"nom","adresse_1","code_postal","ville"};
							cbRechercheClient.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
							cbRechercheClient.SelectedIndex=0;
							ds.Tables["t_clients"].Clear();
							Nettoyage();
							Desactivation();
							return true;
						}
						catch(OleDbException ex)
						{
							Transac.Rollback();
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
				}
			}
			return false;	
		}

		private void txNom_TextChanged(object sender, System.EventArgs e)
		{
			if(txNom.Text.Length!=0&&txAdresse1.Text.Length!=0)
			{
				btEnregistre.Enabled=true;
			}
		}

		private void txAdresse1_TextChanged(object sender, System.EventArgs e)
		{
			if(txNom.Text.Length!=0&&txAdresse1.Text.Length!=0)
			{
				btEnregistre.Enabled=true;
			}
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
			if(mtgcComboBox3.SelectedIndex.Equals(0)&&mtgcComboBox3.Items.Count>1)
			{
				MessageBox.Show("Veuillez choisir un correspondant SVP");
			}
			else
			{
				for(int i=0;i<lvDevis.CheckedIndices.Count;i++)
				{
					if(lvDevis.Items[lvDevis.CheckedIndices[i]].Text!="3")
					{
						MessageBox.Show("Attention certains devis ne sont pas en niveau 3");
						break;
					}
				}
				for(int i=0;i<lvDevis.CheckedIndices.Count;i++)
				{
					Comm.CommandText="SELECT T_devis_entete.[N° Commande ouverte], T_devis_entete.[Ordre Travail], T_devis_entete.[N° Devis], T_type_machine.Code, T_parc_machine.[Code machine Opindus], T_devis_entete.[Total devis] FROM T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[N° Devis])="+lvDevis.Items[lvDevis.CheckedIndices[i]].SubItems[1].Text+")) GROUP BY T_devis_entete.[N° Commande ouverte], T_devis_entete.[Ordre Travail], T_devis_entete.[N° Devis], T_type_machine.Code, T_parc_machine.[Code machine Opindus], T_devis_entete.[Total devis] ORDER BY T_devis_entete.[N° Commande ouverte], T_devis_entete.[Ordre Travail]"; 
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"devis");
				}
				foundRows=ds.Tables["devis"].Select("","[N° Commande ouverte], [Ordre Travail], [N° Devis] ASC");
				printDocument2.DefaultPageSettings.Landscape=false;
				printDocument2.DefaultPageSettings.Margins.Bottom=50;
				printDocument2.DefaultPageSettings.Margins.Left=50;
				printDocument2.DefaultPageSettings.Margins.Right=50;
				printPreviewDialog1.Document=printDocument2;
				printPreviewDialog1.ShowDialog();
			}
		}

		private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Page+=1;
			int ypos=e.MarginBounds.Top-50;
			if(Agence.Equals(1))
			{
				e.Graphics.DrawString("Opindus", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
				ypos+=35;
				e.Graphics.DrawString("1 rue Maurice Audibert", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+160, ypos);
				ypos+=35;
				e.Graphics.DrawString("69800 St Priest", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+210, ypos);
				ypos+=35;
				e.Graphics.DrawString("Tel : 04 78 21 73 14 Fax : 04 78 21 73 01", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+40, ypos);
			}
			else if(Agence.Equals(2))
			{
				e.Graphics.DrawString("Opindus", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
				ypos+=35;
				e.Graphics.DrawString("2 chemin des Deux Tilleuls", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+160, ypos);
				ypos+=35;
				e.Graphics.DrawString("59810 Lesquin", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+210, ypos);
				ypos+=35;
				e.Graphics.DrawString("Tel : 03 20 97 50 34 Fax : 03 20 86 24 94", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+40, ypos);
			}
			else if(Agence.Equals(3))
			{
				e.Graphics.DrawString("Opindus", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
				ypos+=70;
				e.Graphics.DrawString("76100 Rouen", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+210, ypos);
				ypos+=35;
				e.Graphics.DrawString("Tel : 04 78 21 73 14 Fax : 04 78 21 73 01", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+40, ypos);
			}
			ypos+=45;
			e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			if(Agence.Equals(1)||Agence.Equals(3))
				e.Graphics.DrawString("Emetteur : Madame PERRET LEBATEUX", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			else if(Agence.Equals(2))
				e.Graphics.DrawString("Emetteur : Service technique", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Date :"+DateTime.Now.ToShortDateString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-150, ypos);
			ypos+=20;
			e.Graphics.DrawString("Société :"+cbRechercheClient.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=20;
			if(mtgcComboBox3.SelectedIndex>0)
				e.Graphics.DrawString("Monsieur "+mtgcComboBox3.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			else
				e.Graphics.DrawString("Monsieur ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Fax : "+txFax.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-150, ypos);
			ypos+=25;
			e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=15;
			e.Graphics.DrawString("DERNIERE RELANCE AVANT FERRAILLAGE ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
			ypos+=30;
			e.Graphics.DrawString("Nous vous rappelons nos devis :", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=30;
			string anciennecommande=null;
			string ancienOR=null;
			bool debut=true;
			while(ypos<e.MarginBounds.Height-180&&countRow<foundRows.Length)
			{
				if(anciennecommande!=foundRows[countRow]["n° commande ouverte"].ToString())
				{	
					e.Graphics.DrawString("Commande : "+foundRows[countRow]["n° Commande ouverte"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
					ypos+=25;
				}
				if(ancienOR!=foundRows[countRow]["Ordre travail"].ToString()||anciennecommande!=foundRows[countRow]["n° commande ouverte"].ToString())
				{
					e.Graphics.DrawString("Ordre travail : "+foundRows[countRow]["Ordre travail"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					ancienOR=foundRows[countRow]["Ordre travail"].ToString();
					ypos+=25;
					e.Graphics.DrawString("N° Devis", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString("Type machine", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+75, ypos);
					e.Graphics.DrawString("Immatriculation", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
					e.Graphics.DrawString("Total devis €", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
					e.Graphics.DrawString("Bon pour accord", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos);
					ypos+=25;
					anciennecommande=foundRows[countRow]["n° commande ouverte"].ToString();
				}
				e.Graphics.DrawString(foundRows[countRow]["n° devis"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString(foundRows[countRow]["Code"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+75, ypos);
				e.Graphics.DrawString(foundRows[countRow]["Code machine opindus"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
				try
				{
					e.Graphics.DrawString(System.Convert.ToDecimal(foundRows[countRow]["Total devis"].ToString()).ToString("c"), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
					ypos+=25;
					e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

				countRow+=1;
			}
			ypos=850;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			e.Graphics.DrawString("pour lesquels nous n'avons reçu aucune réponse.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=30;
			e.Graphics.DrawString("Suivant nos conditions générales reprises sur le devis,", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=30;
			e.Graphics.DrawString("SANS REPONSE SOUS HUIT JOURS, NOUS PROCEDERONS AU FERRAILLAGE", new Font("Arial", 12, FontStyle.Underline), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=105;
			e.Graphics.DrawString("DANS L'ATTENTE DE VOTRE DECISION.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("MADAME PERRET-LEBATEUX.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left+350, ypos);
			ypos+=25;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=20;
			e.Graphics.DrawString("Réparations tous types, toutes marques Pneumatiques, Electriques, Hydrauliques.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left+30, ypos);
			ypos+=20;
			e.Graphics.DrawString("La maitrise des outils 'portatifs'.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left+200, ypos);
			if(countRow<foundRows.Length)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			//printForm1.BodyContainer=panel2;
			//printPreviewDialog1.Document=printForm1;
			//printPreviewDialog1.ShowDialog();
		}

		private void txCodePostal_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(txCodePostal.TextLength>0&&txCodePostal.Text!="?")
				{
					int x = Int32.Parse(txCodePostal.Text);
					errorProvider1.SetError(txCodePostal,"");
				}
			}
			catch(Exception exp)
			{
				errorProvider1.SetError(txCodePostal,"Code postal invalide");
				Console.WriteLine(exp.Message);
			}
		}

		private void cbRechercheClient_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13)&&cbRechercheClient.SelectedIndex>0)
			{
				ds.Clear();
				Nettoyage();
				Activation();
				this.Refresh();
				Comm.CommandText="SELECT T_clients.* FROM T_clients WHERE Nom='"+cbRechercheClient.Text.Replace("'","''")+"'"; 
				try
				{
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"t_clients");
					if(ds.Tables["t_clients"].Rows.Count>0)
					{
						row=ds.Tables["t_clients"].Rows[0];
						txNom.Text=cbRechercheClient.Text;
						txCodeGestion.Text=row["Code_GC"].ToString();
						txAdresse1.Text=row["Adresse_1"].ToString();
						txAdresse2.Text=row["Adresse_2"].ToString();
						txCodePostal.Text=row["Code_Postal"].ToString();
						txVille.Text=row["Ville"].ToString();
						txPays.Text=row["Pays"].ToString();
						txTel.Text=row["Telephone"].ToString();
						txFax.Text=row["telecopie"].ToString();
						txCodeGestion.Text=row["code_GC"].ToString();
						txIdent.Text=row["Ident"].ToString();
						mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindStringExact(row["Groupe"].ToString(),0);
						mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindStringExact(row["Usine"].ToString(),0);
						txBatiment.Text=row["Batiment"].ToString();
						txPourcentage.Text=row["Pourcentage_remise"].ToString();
						txrRegl.Text=row["Code_reglement"].ToString();
						txTrans.Text=row["Code_transport"].ToString();
						txFourn.Text=row["Notre_code_fournisseur"].ToString();
						txCde.Text=row["N°_cde_ouverte"].ToString();
						txForfaitDNR.Text=System.Convert.ToDecimal(row["Forfait_dnr"].ToString()).ToString("0.00");
						txControle.Text=System.Convert.ToDecimal(row["Forfait_controle"].ToString()).ToString("0.00");
						txForfaitTrans.Text=System.Convert.ToDecimal(row["Forfait_transport"].ToString()).ToString("0.00");
						txCoefDNR.Text=System.Convert.ToDecimal(row["Coef_dnr"].ToString()).ToString("0.00");
						txCoefControle.Text=System.Convert.ToDecimal(row["Coef_controle"].ToString()).ToString("0.00");
						txCoefTrans.Text=System.Convert.ToDecimal(row["Coef_transport"].ToString()).ToString("0.00");
						txSeuil.Text=row["Seuil_reparation"].ToString();
						txGarantie.Text=row["Delai_garantie"].ToString();
						txBorne.Text=DateTime.Now.ToShortDateString();
						txCommentaire.Text=row["Commentaire"].ToString();
						this.Refresh();
						ds.Tables["t_clients"].Clear();
						Comm.CommandText="select Cle,ident,nom,prenom,e_mail,telephone,telecopie from t_clients_coressp where ident="+txIdent.Text;
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"Corres");
						mtgcComboBox3.Items.Clear();
						mtgcComboBox3.Items.Add(new MTGCComboBoxItem("...","","",""));
						foreach (DataRow rowSel in ds.Tables["Corres"].Rows)
						{
							ListViewItem item = new ListViewItem(rowSel["Nom"].ToString(),0);
							if(rowSel["Prenom"].ToString()!="?")
								item.SubItems.Add(rowSel["Prenom"].ToString());
							else
								item.SubItems.Add(" ");
							if(rowSel["E_mail"].ToString()!="?")
								item.SubItems.Add(rowSel["E_mail"].ToString());
							else
								item.SubItems.Add(" ");
							if(rowSel["Telephone"].ToString()!="?")
								item.SubItems.Add(rowSel["Telephone"].ToString());
							else
								item.SubItems.Add(" ");
							item.SubItems.Add(rowSel["Telecopie"].ToString());
							item.Tag=rowSel["Cle"].ToString();
							lvCorres.Items.Add(item);
							mtgcComboBox3.Items.Add(new MTGCComboBoxItem(rowSel["Nom"].ToString(),rowSel["Prenom"].ToString(),"",""));
							
						}
						mtgcComboBox3.SelectedIndex=0;
						ds.Tables["Corres"].Clear();
						this.Refresh();
						
						Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.Niveau, T_devis_entete.[Date reparation], T_devis_entete.[Date Decision], T_parc_machine.*, T_famille_machine.*, T_type_machine.*, T_devis_entete.[Code Client] FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE T_devis_entete.[Code Client]="+txIdent.Text+" ORDER BY [N° devis] DESC";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"Devis");
						}
						catch(OleDbException exep)
						{
							MessageBox.Show(exep.Message);
						}
						foreach(DataRow Row in ds.Tables["Devis"].Rows)
						{
							ListViewItem item = new ListViewItem(Row["Niveau"].ToString());
							item.SubItems.Add(Row["N° Devis"].ToString());
							if(Row["Date"].ToString().Length==0)
								item.SubItems.Add(" ");
							else
								item.SubItems.Add(Row["Date"].ToString().Remove(10,9));
							if(Row["Date decision"].ToString().Length==0)
								item.SubItems.Add(" ");
							else if(Row["Date decision"].ToString().Length>18)
								item.SubItems.Add(Row["Date decision"].ToString().Remove(10,9));
							if(Row["Date reparation"].ToString().Length==0)
								item.SubItems.Add(" ");
							else if(Row["Date reparation"].ToString().Length>18)
								item.SubItems.Add(Row["Date reparation"].ToString().Remove(10,9));
							item.SubItems.Add(Row["Code machine opindus"].ToString());
							item.SubItems.Add(Row["Type machine"].ToString());
							item.SubItems.Add(Row["Designation"].ToString());
							lvDevis.Items.Add(item);
						}
						ds.Tables["Devis"].Clear();

						Comm.CommandText="SELECT * FROM t_devis_entete";
						DataAD.SelectCommand=Comm;
						try
						{
							if(DataAD.Fill(ds,"t_devis_entete")>0)
							{
								foreach(DataRow row2 in ds.Tables["t_devis_entete"].Rows)
								{
									bool affiche=false;
									bool affiche2=false;
									TimeSpan jour=TimeSpan.FromDays(1);
									DateTime ProchainCtl=DateTime.Today-jour;
									DateTime ProchaineInter=DateTime.Today-jour;
									if((row2["nombre semaine entre inter"].ToString().Length>0)&&(row2["Date dernier intervention"].ToString().Length>0))
									{
										affiche=true;
										ProchaineInter=System.Convert.ToDateTime(row2["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(row2["nombre semaine entre ctl"].ToString()));
									}

									if((row2["nombre semaine entre ctl"].ToString().Length>0)&&(row2["Date dernier controle"].ToString().Length>0))
									{
										affiche2=true;
										ProchainCtl=System.Convert.ToDateTime(row2["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(row2["nombre semaine entre ctl"].ToString()));
									}
									if(ProchainCtl>=DateTime.Today||ProchaineInter>=DateTime.Today)
									{
										ListViewItem item = new ListViewItem(row2["Code machine opindus"].ToString(),0);
								
										item.SubItems.Add(row2["Type machine"].ToString());
										item.SubItems.Add(row2["Designation"].ToString());
										if(row2["Date dernier intervention"].ToString().Length>0)
											item.SubItems.Add(row2["Date dernier intervention"].ToString().Remove(10,9));
										else
											item.SubItems.Add("");
										if(row2["Date dernier controle"].ToString().Length>0)
											item.SubItems.Add(row2["Date dernier controle"].ToString().Remove(10,9));
										else
											item.SubItems.Add("");
					
										if(affiche)
											item.SubItems.Add(ProchaineInter.ToShortDateString());
										else
											item.SubItems.Add("");
										if(affiche2)
											item.SubItems.Add(ProchainCtl.ToShortDateString());
										else
											item.SubItems.Add("");
										lvInter.Items.Add(item);
									}
								}
							}
						}
						catch
						{
						}
						
					}
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				
				Comm.CommandText="SELECT * FROM T_devis_entete WHERE T_devis_entete.[Code Client]="+txIdent.Text+" AND T_devis_entete.Niveau=7 ORDER BY T_devis_entete.[Date reparation]";
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"t_devis_entete");
					if(ds.Tables["t_devis_entete"].Rows.Count>0)
					{
						decimal Total_Annee_en_cours=0;
						decimal Total_Annee_1=0;
						decimal Total_Annee_2=0;
						decimal Total_Annee_3=0;
						decimal Total_Annee_4=0;
						int rep1=0;
						int rep2=0;
						int rep3=0;
						int rep4=0;
						int rep0=0;
						int annee_encours=DateTime.Now.Year;
						int annee_1=DateTime.Now.Year-1;
						int annee_2=DateTime.Now.Year-2;
						int annee_3=DateTime.Now.Year-3;
						int annee_4=DateTime.Now.Year-4;
						Comm.Connection=oleDbConnection1;
						Comm.CommandText="SELECT Sum(T_devis_entete.[Total devis]) AS [SommeDeTotal devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+txNom.Text.Replace("'","''")+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+annee_encours+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_encours+"#) AND ((T_devis_entete.Niveau)=7))";

						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n");
						if(ds.Tables["n"].Rows.Count>0)
						{
							try
							{
								Total_Annee_en_cours=System.Convert.ToDecimal(ds.Tables["n"].Rows[0]["SommeDeTotal devis"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
						Comm.CommandText="SELECT Sum(T_devis_entete.[Total devis]) AS [SommeDeTotal devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+txNom.Text.Replace("'","''")+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+annee_1+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_1+"#) AND ((T_devis_entete.Niveau)=7))"; 
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n1");
						if(ds.Tables["n1"].Rows.Count>0)
						{
							try
							{
								Total_Annee_1=System.Convert.ToDecimal(ds.Tables["n1"].Rows[0]["SommeDeTotal devis"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
						Comm.CommandText="SELECT Sum(T_devis_entete.[Total devis]) AS [SommeDeTotal devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+txNom.Text.Replace("'","''")+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+annee_2+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_2+"#) AND ((T_devis_entete.Niveau)=7))";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n2");
						if(ds.Tables["n2"].Rows.Count>0)
						{
							try
							{
								Total_Annee_2=System.Convert.ToDecimal(ds.Tables["n2"].Rows[0]["SommeDeTotal devis"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
						Comm.CommandText="SELECT Sum(T_devis_entete.[Total devis]) AS [SommeDeTotal devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+txNom.Text.Replace("'","''")+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+annee_3+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_3+"#) AND ((T_devis_entete.Niveau)=7))"; 
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n3");
						if(ds.Tables["n3"].Rows.Count>0)
						{
							try
							{
								Total_Annee_3=System.Convert.ToDecimal(ds.Tables["n3"].Rows[0]["SommeDeTotal devis"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
						Comm.CommandText="SELECT Sum(T_devis_entete.[Total devis]) AS [SommeDeTotal devis] FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_clients.Nom)='"+txNom.Text.Replace("'","''")+"') AND ((T_devis_entete.[Date reparation])>=#1/1/"+annee_4+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_4+"#) AND ((T_devis_entete.Niveau)=7))";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n4");
						if(ds.Tables["n4"].Rows.Count>0)
						{
							try
							{
								Total_Annee_4=System.Convert.ToDecimal(ds.Tables["n4"].Rows[0]["SommeDeTotal devis"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
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
						ds.Tables["t_devis_entete"].Clear();
						Comm.CommandText="SELECT T_devis_entete.[Date reparation], T_devis_entete.[Code Client], T_devis_entete.[N° Devis], T_devis_entete.Niveau FROM T_devis_entete WHERE (((T_devis_entete.[Code Client])="+txIdent.Text+") AND ((T_devis_entete.Niveau)=7)) ORDER BY T_devis_entete.[Date reparation]";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"t_devis_entete");
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						foreach(DataRow rowDate in ds.Tables["t_devis_entete"].Rows)
						{
							if(rowDate["Date reparation"].ToString().Length>0)
							{
								if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_encours.ToString()))
								{
									rep0+=1;
								}
								else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_1.ToString()))
								{
									rep1+=1;
								}
								else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_2.ToString()))
								{
									rep2+=1;
								}
								else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_3.ToString()))
								{
									rep3+=1;
								}
								else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_4.ToString()))
								{
									rep4+=1;
								}
							}
						}
						ChartLoader chartLoader2= chartControl2.getChartLoader();
						// set chart parameters 
						chartLoader2.clearParams();
						chartLoader2.setParameter("TITLECHART",txNom.Text); 
						chartLoader2.setParameter("XLABEL","Années"); 
						chartLoader2.setParameter("YLABEL","Nombe annuel de réparations"); 
						chartLoader2.setParameter("XSCALE_MIN","0"); 
						chartLoader2.setParameter("XSCALE_MAX","5.5"); 
						chartLoader2.setParameter("YSCALE_MIN","0"); 
						chartLoader2.setParameter("LEGEND","FALSE");
						chartLoader2.setParameter("BIG_TICK_INTERVALX","1"); 
						chartLoader2.setParameter("XAXIS_LABELS","En cours|N-1|N-2|N-3|N-4"); 
						chartLoader2.setParameter("CERO_XAXIS","LINE"); 
						chartLoader2.setParameter("YAXIS_INTEGER","TRUE"); 
						chartLoader2.setParameter("SERIE_1","Réparations"); 
						chartLoader2.setParameter("SERIE_TYPE_1","BAR");
						chartLoader2.setParameter("CHART_BORDER","1|0|NORMAL");
						chartLoader2.setParameter("CHART_FILL","LIGHTGRAY");
						chartLoader2.setParameter("SERIE_FONT_1","Arial|PLAIN|10"); 
						string reparations=rep0.ToString()+"|"+rep1.ToString()+"|"+rep2.ToString()+"|"+rep3.ToString()+"|"+rep4.ToString();
						chartLoader2.setParameter("SERIE_DATA_1",reparations); 
						chartLoader2.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
						chartLoader2.setParameter("SERIE_BAR_STYLE_1","ff00"); 
						chartLoader2.setParameter("BARCHART_BARSPACE","20"); 
						chartLoader2.setParameter("LEFT_MARGIN","0.20"); 
						chartLoader.setParameter("YAXIS_AUTO_TICKS","10");
						chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","20");
						chartLoader2.setParameter("CHART_FILL","ffcc00"); 
						chartLoader2.setParameter("YLABEL_VERTICAL","TRUE"); 
						chartLoader2.setParameter("YAXIS_TICKATBASE","true");
						// create chart 
						chartControl2.buildChart();
						this.Refresh();
						chartControl2.Visible=true;
						ds.Tables["t_devis_entete"].Clear();
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//printForm1.BodyContainer=panel1;
			//printPreviewDialog1.Document=printForm1;
			//printPreviewDialog1.ShowDialog();
		}

		private void button6_Click_1(object sender, System.EventArgs e)
		{
			//printForm1.BodyContainer=panel2;
			//printPreviewDialog1.Document=printForm1;
			//printPreviewDialog1.ShowDialog();
		}

		private void button7_Click_1(object sender, System.EventArgs e)
		{
			Nettoyage();
			Desactivation();
			this.Hide();
			label1.Visible=true;
			groupBox1.BackColor=Color.Transparent;
			label34.Visible=true;
			cbRechercheClient.SelectedIndex=-1;
			cbRechercheClient.Visible=true;
		}

		private void mtgcComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindStringExact(mtgcComboBox1.Text);
		}

		private void mtgcComboBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindStringExact(mtgcComboBox2.Text);
		}

		private void Clients_VisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible.Equals(true))
			{			
				if(txIdent.Text.Length.Equals(0))
				{
					Nouveau=true;
					oleDbConnection1.Open();
					Comm.CommandText="SELECT Count(T_Groupes.Code) AS CompteDeCode FROM T_Groupes";
					if(System.Convert.ToInt32(Comm.ExecuteScalar())!=mtgcComboBox1.Items.Count)
					{
						mtgcComboBox1.Items.Clear();
						Comm.CommandText="SELECT Code, Designation FROM T_Groupes ORDER BY Code";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"t_groupes");
						mtgcComboBox1.SourceDataTable=ds.Tables["t_groupes"];
						mtgcComboBox1.SourceDataString = new string[]{"Code","designation","",""};
						mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
						mtgcComboBox1.SelectedIndex=0;
						ds.Tables["t_groupes"].Clear();
					}	

					Comm.CommandText="SELECT Count(T_usine.Code_usine) AS CompteDeCode_usine FROM T_usine";
					if(System.Convert.ToInt32(Comm.ExecuteScalar())!=mtgcComboBox2.Items.Count)
					{
						mtgcComboBox2.Items.Clear();
						Comm.CommandText="SELECT Code_usine, Designation FROM T_usine ORDER BY Code_usine";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"t_usine");
						mtgcComboBox2.SourceDataTable=ds.Tables["t_usine"];
						mtgcComboBox2.SourceDataString = new string[]{"Code_usine","designation","",""};
						mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
						mtgcComboBox2.SelectedIndex=0;
						ds.Tables["t_usine"].Clear();
					}

					Comm.CommandText="SELECT Count(T_clients.Ident) AS CompteDeIdent FROM T_clients";
					if(System.Convert.ToInt32(Comm.ExecuteScalar())!=cbRechercheClient.Items.Count)
					{
						cbRechercheClient.Items.Clear();
						Comm.CommandText="select nom, adresse_1, code_postal, ville from t_clients order by nom";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"t_clients");
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						cbRechercheClient.SourceDataTable=ds.Tables["t_clients"];
						cbRechercheClient.SourceDataString = new string[]{"nom","adresse_1","code_postal","ville"};
						cbRechercheClient.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
						cbRechercheClient.SelectedIndex=0;
						ds.Tables["t_clients"].Clear();
					}
					oleDbConnection1.Close();
					txNom.Focus();
				}

			}
			else
			{
				Nettoyage();
				Desactivation();
			}
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			if(mtgcComboBox3.SelectedIndex.Equals(0)&&mtgcComboBox3.Items.Count>1)
			{
				MessageBox.Show("Veuillez choisir un correspondant SVP");
			}
			else
			{
				for(int i=0;i<lvDevis.CheckedIndices.Count;i++)
				{
					if(lvDevis.Items[lvDevis.CheckedIndices[i]].Text!="3")
					{
						MessageBox.Show("Attention certains devis ne sont pas en niveau 3");
						break;
					}
				}
				for(int i=0;i<lvDevis.CheckedIndices.Count;i++)
				{
					Comm.CommandText="SELECT T_devis_entete.[N° Commande ouverte], T_devis_entete.[Ordre Travail], T_devis_entete.[N° Devis], T_type_machine.Code, T_parc_machine.[Code machine Opindus], T_devis_entete.[Total devis] FROM T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[N° Devis])="+lvDevis.Items[lvDevis.CheckedIndices[i]].SubItems[1].Text+")) GROUP BY T_devis_entete.[N° Commande ouverte], T_devis_entete.[Ordre Travail], T_devis_entete.[N° Devis], T_type_machine.Code, T_parc_machine.[Code machine Opindus], T_devis_entete.[Total devis]"; 
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"devis");
				}
				
				foundRows=ds.Tables["devis"].Select("","[N° Commande ouverte], [Ordre Travail], [N° Devis] ASC");

				printDocument1.DefaultPageSettings.Landscape=false;
				printDocument1.DefaultPageSettings.Margins.Bottom=50;
				printDocument1.DefaultPageSettings.Margins.Left=50;
				printDocument1.DefaultPageSettings.Margins.Right=50;
				printPreviewDialog1.Document=printDocument1;
				printPreviewDialog1.ShowDialog();
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Page+=1;
			int ypos=e.MarginBounds.Top-50;
			if(Agence.Equals(1))
			{
				e.Graphics.DrawString("Opindus", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+340, ypos);
				ypos+=35;
				e.Graphics.DrawString("1 rue Maurice Audibert", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+260, ypos);
				ypos+=35;
				e.Graphics.DrawString("69800 St Priest", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+310, ypos);
				ypos+=35;
				e.Graphics.DrawString("Tel : 04 78 21 73 14 Fax : 04 78 21 73 01", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+140, ypos);
			}
			else if(Agence.Equals(2))
			{
				e.Graphics.DrawString("Opindus", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+340, ypos);
				ypos+=35;
				e.Graphics.DrawString("2 chemin des Deux Tilleuls", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+260, ypos);
				ypos+=35;
				e.Graphics.DrawString("59810 Lesquin", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+310, ypos);
				ypos+=35;
				e.Graphics.DrawString("Tel : 03 20 97 50 34 Fax : 03 20 86 24 94", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+140, ypos);
			}
			else if(Agence.Equals(3))
			{
				e.Graphics.DrawString("Opindus", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
				ypos+=70;
				e.Graphics.DrawString("76100 Rouen", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+210, ypos);
				ypos+=35;
				e.Graphics.DrawString("Tel : 04 78 21 73 14 Fax : 04 78 21 73 01", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left+40, ypos);
			}
			ypos+=45;
			e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			if(Agence.Equals(1)||Agence.Equals(3))
				e.Graphics.DrawString("Emetteur : Madame PERRET LEBATEUX", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			else if(Agence.Equals(2))
				e.Graphics.DrawString("Emetteur : Service après vente", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Date :"+DateTime.Now.ToShortDateString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-150, ypos);
			ypos+=20;
			e.Graphics.DrawString("Société :"+cbRechercheClient.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=20;
			Comm.CommandText="SELECT T_clients_Coressp.telecopie FROM T_clients_Coressp WHERE (((T_clients_Coressp.Nom)='"+mtgcComboBox3.Text.Replace("'","''")+"')) GROUP BY T_clients_Coressp.telecopie";
			if(mtgcComboBox3.SelectedIndex>0)
				e.Graphics.DrawString("Monsieur "+mtgcComboBox3.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			else
				e.Graphics.DrawString("Monsieur ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			try
			{
				oleDbConnection1.Open();
				e.Graphics.DrawString("Fax : "+System.Convert.ToString(Comm.ExecuteScalar()).ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-150, ypos);
				ypos+=25;

			}
			catch
			{
				oleDbConnection1.Open();
				e.Graphics.DrawString("Fax : Inconnu", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-150, ypos);
				ypos+=25;
			}
			finally
			{
				oleDbConnection1.Close();
			}
			
			e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=15;
			e.Graphics.DrawString("Texte : ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=30;
			e.Graphics.DrawString("Nous vous prions de trouver ci-après le récapitulatif des devis de réparations :", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=30;
			string anciennecommande=null;
			string ancienOR=null;
			bool debut=true;
			while(ypos<e.MarginBounds.Height-250&&countRow<foundRows.Length)
			{
					if(anciennecommande!=foundRows[countRow]["n° commande ouverte"].ToString())
					{	
						e.Graphics.DrawString("Commande : "+foundRows[countRow]["n° Commande ouverte"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
						ypos+=25;
					}
					if(ancienOR!=foundRows[countRow]["Ordre travail"].ToString()||anciennecommande!=foundRows[countRow]["n° commande ouverte"].ToString())
					{
						e.Graphics.DrawString("Ordre travail : "+foundRows[countRow]["Ordre travail"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						ancienOR=foundRows[countRow]["Ordre travail"].ToString();
						ypos+=25;
						e.Graphics.DrawString("N° Devis", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString("Type machine", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+75, ypos);
						e.Graphics.DrawString("Immatriculation", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
						e.Graphics.DrawString("Total devis €", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
						e.Graphics.DrawString("Bon pour accord", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos);
						ypos+=25;
						anciennecommande=foundRows[countRow]["n° commande ouverte"].ToString();
					}
					e.Graphics.DrawString(foundRows[countRow]["n° devis"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(foundRows[countRow]["Code"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+75, ypos);
					e.Graphics.DrawString(foundRows[countRow]["Code machine opindus"].ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
					try
					{
						e.Graphics.DrawString(System.Convert.ToDecimal(foundRows[countRow]["Total devis"].ToString()).ToString("c"), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
						ypos+=25;
						e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
					}
					catch(Exception ex)
					{
						Console.WriteLine(ex.Message);
						ypos+=25;
					}

				countRow+=1;
			}
			ypos=850;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=20;
			e.Graphics.DrawString("Etablissement d'un devis", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left+250, ypos);
			ypos+=15;
			e.Graphics.DrawString("* Nos prix s'entendent unitaires H.T. départ.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("* Matériel électrique et hydraulique : forfait expertise 20 € H.T. en cas de refus.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("* Matériel pneumatique : sans réponse ou refus, les frais sont à la charge du client (8 € H.T.)", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("La machine sera rendue demontée. Frais de retour à la charge du client.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("* Sans réponse du client SOUS TROIS MOIS, à compter de la prise en charge, la machine", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("ne sera plus récupérable.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("* Devis valable UN mois.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("* Garantie TROIS MOIS (pièces détachées et main d'oeuvre) dans le cas d'une utilisation", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("normale (1 poste).", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=30;
			e.Graphics.DrawString("DANS L'ATTENTE DE VOTRE DECISION.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("MADAME PERRET-LEBATEUX.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left+350, ypos);
			ypos+=25;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=20;
			e.Graphics.DrawString("Réparations tous types, toutes marques Pneumatiques, Electriques, Hydrauliques.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left+30, ypos);
			ypos+=20;
			e.Graphics.DrawString("La maitrise des outils 'portatifs'.", new Font("Arial", 11), Brushes.Black, e.MarginBounds.Left+200, ypos);
			if(countRow<foundRows.Length)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
			}
		}

		private void txNom_Enter(object sender, System.EventArgs e)
		{
			if(cbRechercheClient.SelectedIndex>0)
			{
				Nettoyage();
				Activation();
				this.Refresh();
				Comm.CommandText="SELECT T_clients.* FROM T_clients WHERE Nom='"+cbRechercheClient.Text.Replace("'","''")+"'"; 
				
				try
				{
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"t_clients");
					if(ds.Tables["t_clients"].Rows.Count>0)
					{
						row=ds.Tables["t_clients"].Rows[0];
						txNom.Text=cbRechercheClient.Text;
						txCodeGestion.Text=row["Code_GC"].ToString();
						txAdresse1.Text=row["Adresse_1"].ToString();
						txAdresse2.Text=row["Adresse_2"].ToString();
						txCodePostal.Text=row["Code_Postal"].ToString();
						txVille.Text=row["Ville"].ToString();
						txPays.Text=row["Pays"].ToString();
						txTel.Text=row["Telephone"].ToString();
						txFax.Text=row["telecopie"].ToString();
						txCodeGestion.Text=row["code_GC"].ToString();
						txIdent.Text=row["Ident"].ToString();
						mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindStringExact(row["Groupe"].ToString(),0);
						mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindStringExact(row["Usine"].ToString(),0);
						txBatiment.Text=row["Batiment"].ToString();
						txPourcentage.Text=row["Pourcentage_remise"].ToString();
						txrRegl.Text=row["Code_reglement"].ToString();
						txTrans.Text=row["Code_transport"].ToString();
						txFourn.Text=row["Notre_code_fournisseur"].ToString();
						txCde.Text=row["N°_cde_ouverte"].ToString();
						txForfaitDNR.Text=System.Convert.ToDecimal(row["Forfait_dnr"].ToString()).ToString("0.00");
						txControle.Text=System.Convert.ToDecimal(row["Forfait_controle"].ToString()).ToString("0.00");
						txForfaitTrans.Text=System.Convert.ToDecimal(row["Forfait_transport"].ToString()).ToString("0.00");
						txCoefDNR.Text=System.Convert.ToDecimal(row["Coef_dnr"].ToString()).ToString("0.00");
						txCoefControle.Text=System.Convert.ToDecimal(row["Coef_controle"].ToString()).ToString("0.00");
						txCoefTrans.Text=System.Convert.ToDecimal(row["Coef_transport"].ToString()).ToString("0.00");
						txSeuil.Text=row["Seuil_reparation"].ToString();
						txGarantie.Text=row["Delai_garantie"].ToString();
						txBorne.Text=DateTime.Now.ToShortDateString();
						txCommentaire.Text=row["Commentaire"].ToString();
						this.Refresh();
						Comm.CommandText="select Cle,ident,nom,prenom,e_mail,telephone,telecopie from t_clients_coressp where ident="+txIdent.Text;
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"Corres");
						mtgcComboBox3.Items.Clear();
						mtgcComboBox3.Items.Add(new MTGCComboBoxItem("...","","",""));
						foreach (DataRow rowSel in ds.Tables["Corres"].Rows)
						{
							ListViewItem item = new ListViewItem(rowSel["Nom"].ToString(),0);
							item.SubItems.Add(rowSel["Prenom"].ToString());
							item.SubItems.Add(rowSel["E_mail"].ToString());
							item.SubItems.Add(rowSel["Telephone"].ToString());
							item.SubItems.Add(rowSel["Telecopie"].ToString());
							item.Tag=rowSel["Cle"].ToString();
							lvCorres.Items.Add(item);
							mtgcComboBox3.Items.Add(new MTGCComboBoxItem(rowSel["Nom"].ToString(),rowSel["Prenom"].ToString(),"",""));
							
						}
						mtgcComboBox3.SelectedIndex=0;
						ds.Tables["Corres"].Clear();
						this.Refresh();
						
						Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.Niveau, T_devis_entete.[Date reparation], T_devis_entete.[Date Decision], T_parc_machine.*, T_famille_machine.*, T_type_machine.*, T_devis_entete.[Code Client] FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE T_devis_entete.[Code Client]="+txIdent.Text+" ORDER BY [N° devis] DESC";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"Devis");
						}
						catch(OleDbException exep)
						{
							MessageBox.Show(exep.Message);
						}
						foreach(DataRow Row in ds.Tables["Devis"].Rows)
						{
							ListViewItem item = new ListViewItem(Row["Niveau"].ToString());
							item.SubItems.Add(Row["N° Devis"].ToString());
							if(Row["Date"].ToString().Length==0)
								item.SubItems.Add(" ");
							else
								item.SubItems.Add(Row["Date"].ToString().Remove(10,9));
							if(Row["Date decision"].ToString().Length==0)
								item.SubItems.Add(" ");
							else if(Row["Date decision"].ToString().Length>18)
								item.SubItems.Add(Row["Date decision"].ToString().Remove(10,9));
							if(Row["Date reparation"].ToString().Length==0)
								item.SubItems.Add(" ");
							else if(Row["Date reparation"].ToString().Length>18)
								item.SubItems.Add(Row["Date reparation"].ToString().Remove(10,9));
							item.SubItems.Add(Row["Code machine opindus"].ToString());
							item.SubItems.Add(Row["Type machine"].ToString());
							item.SubItems.Add(Row["Designation"].ToString());
							lvDevis.Items.Add(item);
						}
						ds.Tables["Devis"].Clear();

						Comm.CommandText="SELECT * FROM t_devis_entete";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"t_devis_entete");
						}
						catch
						{
						}

						foreach(DataRow row2 in ds.Tables["t_devis_entete"].Rows)
						{
							bool affiche=false;
							bool affiche2=false;
							TimeSpan jour=TimeSpan.FromDays(1);
							DateTime ProchainCtl=DateTime.Today-jour;
							DateTime ProchaineInter=DateTime.Today-jour;
							if((row2["nombre semaine entre inter"].ToString().Length>0)&&(row2["Date dernier intervention"].ToString().Length>0))
							{
								affiche=true;
								ProchaineInter=System.Convert.ToDateTime(row2["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(row2["nombre semaine entre ctl"].ToString()));
							}

							if((row2["nombre semaine entre ctl"].ToString().Length>0)&&(row2["Date dernier controle"].ToString().Length>0))
							{
								affiche2=true;
								ProchainCtl=System.Convert.ToDateTime(row2["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(row2["nombre semaine entre ctl"].ToString()));
							}
							if(ProchainCtl>=DateTime.Today||ProchaineInter>=DateTime.Today)
							{
								ListViewItem item = new ListViewItem(row2["Code machine opindus"].ToString(),0);
								
								item.SubItems.Add(row2["Type machine"].ToString());
								item.SubItems.Add(row2["Designation"].ToString());
								if(row2["Date dernier intervention"].ToString().Length>0)
									item.SubItems.Add(row2["Date dernier intervention"].ToString().Remove(10,9));
								else
									item.SubItems.Add("");
								if(row2["Date dernier controle"].ToString().Length>0)
									item.SubItems.Add(row2["Date dernier controle"].ToString().Remove(10,9));
								else
									item.SubItems.Add("");
					
								if(affiche)
									item.SubItems.Add(ProchaineInter.ToShortDateString());
								else
									item.SubItems.Add("");
								if(affiche2)
									item.SubItems.Add(ProchainCtl.ToShortDateString());
								else
									item.SubItems.Add("");
								lvInter.Items.Add(item);
							}
						}
					}
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				ds.Tables["t_devis_entete"].Clear();
				Comm.CommandText="SELECT * FROM T_devis_entete WHERE T_devis_entete.[Code Client]="+txIdent.Text+" AND T_devis_entete.Niveau=7 ORDER BY T_devis_entete.[Date reparation]";
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"t_devis_entete");
					if(ds.Tables["t_devis_entete"].Rows.Count>0)
					{
						decimal Total_Annee_en_cours=0;
						decimal Total_Annee_1=0;
						decimal Total_Annee_2=0;
						decimal Total_Annee_3=0;
						decimal Total_Annee_4=0;
						int rep1=0;
						int rep2=0;
						int rep3=0;
						int rep4=0;
						int rep0=0;
						int annee_encours=DateTime.Now.Year;
						int annee_1=DateTime.Now.Year-1;
						int annee_2=DateTime.Now.Year-2;
						int annee_3=DateTime.Now.Year-3;
						int annee_4=DateTime.Now.Year-4;
						Comm.Connection=oleDbConnection1;
						Comm.CommandText="SELECT Sum(t_devis_lignes.Quantite*t_devis_lignes.[prix de vente]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#1/1/"+annee_encours+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_encours+"#)) GROUP BY T_clients.Nom HAVING t_clients.nom='"+txNom.Text.Replace("'","''")+"'"; 
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n");
						if(ds.Tables["n"].Rows.Count>0)
						{
							try
							{
								Total_Annee_en_cours=System.Convert.ToDecimal(ds.Tables["n"].Rows[0]["Expr1"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
						Comm.CommandText="SELECT T_clients.Nom, Sum(t_devis_lignes.Quantite*t_devis_lignes.[prix de vente]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#1/1/"+annee_1+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_1+"#)) GROUP BY T_clients.Nom HAVING t_clients.nom='"+txNom.Text.Replace("'","''")+"'"; 
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n1");
						if(ds.Tables["n1"].Rows.Count>0)
						{
							try
							{
								Total_Annee_1=System.Convert.ToDecimal(ds.Tables["n1"].Rows[0]["Expr1"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
						Comm.CommandText="SELECT T_clients.Nom, Sum(t_devis_lignes.Quantite*t_devis_lignes.[prix de vente]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#1/1/"+2+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_2+"#)) GROUP BY T_clients.Nom HAVING t_clients.nom='"+txNom.Text.Replace("'","''")+"'"; 
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n2");
						if(ds.Tables["n2"].Rows.Count>0)
						{
							try
							{
								Total_Annee_2=System.Convert.ToDecimal(ds.Tables["n2"].Rows[0]["Expr1"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
						Comm.CommandText="SELECT T_clients.Nom, Sum(t_devis_lignes.Quantite*t_devis_lignes.[prix de vente]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#1/1/"+annee_3+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_3+"#)) GROUP BY T_clients.Nom HAVING t_clients.nom='"+txNom.Text.Replace("'","''")+"'"; 
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n3");
						if(ds.Tables["n3"].Rows.Count>0)
						{
							try
							{
								Total_Annee_3=System.Convert.ToDecimal(ds.Tables["n3"].Rows[0]["Expr1"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
						Comm.CommandText="SELECT T_clients.Nom, Sum(t_devis_lignes.Quantite*t_devis_lignes.[prix de vente]) AS Expr1 FROM (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_devis_entete.[Date reparation])>=#1/1/"+annee_4+"# And (T_devis_entete.[Date reparation])<=#12/31/"+annee_4+"#)) GROUP BY T_clients.Nom HAVING t_clients.nom='"+txNom.Text.Replace("'","''")+"'"; 
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"n4");
						if(ds.Tables["n4"].Rows.Count>0)
						{
							try
							{
								Total_Annee_4=System.Convert.ToDecimal(ds.Tables["n4"].Rows[0]["Expr1"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
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
						ds.Tables["t_devis_entete"].Clear();
						Comm.CommandText="SELECT T_devis_entete.[Date reparation], T_devis_entete.[Code Client], T_devis_entete.[N° Devis], T_devis_entete.Niveau FROM T_devis_entete WHERE (((T_devis_entete.[Code Client])="+txIdent.Text+") AND ((T_devis_entete.Niveau)=7)) ORDER BY T_devis_entete.[Date reparation]";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"t_devis_entete");
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						foreach(DataRow rowDate in ds.Tables["t_devis_entete"].Rows)
						{
							if(rowDate["Date reparation"].ToString().Length>0)
							{
								if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_encours.ToString()))
								{
									rep0+=1;
								}
								else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_1.ToString()))
								{
									rep1+=1;
								}
								else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_2.ToString()))
								{
									rep2+=1;
								}
								else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_3.ToString()))
								{
									rep3+=1;
								}
								else if(System.Convert.ToDateTime(rowDate["Date reparation"].ToString()).Year.ToString().Equals(annee_4.ToString()))
								{
									rep4+=1;
								}
							}
						}
						ChartLoader chartLoader2= chartControl2.getChartLoader();
						// set chart parameters 
						chartLoader2.clearParams();
						chartLoader2.setParameter("TITLECHART",txNom.Text); 
						chartLoader2.setParameter("XLABEL","Années"); 
						chartLoader2.setParameter("YLABEL","Nombe annuel de réparations"); 
						chartLoader2.setParameter("XSCALE_MIN","0"); 
						chartLoader2.setParameter("XSCALE_MAX","5.5"); 
						chartLoader2.setParameter("YSCALE_MIN","0"); 
						chartLoader2.setParameter("LEGEND","FALSE");
						chartLoader2.setParameter("BIG_TICK_INTERVALX","1"); 
						chartLoader2.setParameter("XAXIS_LABELS","En cours|N-1|N-2|N-3|N-4"); 
						chartLoader2.setParameter("CERO_XAXIS","LINE"); 
						chartLoader2.setParameter("YAXIS_INTEGER","TRUE"); 
						chartLoader2.setParameter("SERIE_1","Réparations"); 
						chartLoader2.setParameter("SERIE_TYPE_1","BAR");
						chartLoader2.setParameter("CHART_BORDER","1|0|NORMAL");
						chartLoader2.setParameter("CHART_FILL","LIGHTGRAY");
						chartLoader2.setParameter("SERIE_FONT_1","Arial|PLAIN|10"); 
						string reparations=rep0.ToString()+"|"+rep1.ToString()+"|"+rep2.ToString()+"|"+rep3.ToString()+"|"+rep4.ToString();
						chartLoader2.setParameter("SERIE_DATA_1",reparations); 
						chartLoader2.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
						chartLoader2.setParameter("SERIE_BAR_STYLE_1","ff00"); 
						chartLoader2.setParameter("BARCHART_BARSPACE","20"); 
						chartLoader2.setParameter("LEFT_MARGIN","0.20"); 
						chartLoader.setParameter("YAXIS_AUTO_TICKS","10");
						chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","20");
						chartLoader2.setParameter("CHART_FILL","ffcc00"); 
						chartLoader2.setParameter("YLABEL_VERTICAL","TRUE"); 
						chartLoader2.setParameter("YAXIS_TICKATBASE","true");
						// create chart 
						chartControl2.buildChart();
						this.Refresh();
						chartControl2.Visible=true;
						ds.Tables["t_devis_entete"].Clear();

					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void lvCorres_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lvCorres.SelectedIndices.Count>0)
			{
				button3.Visible=true;
			}
			else
				button3.Visible=false;
		}

		private void lvCorres_DoubleClick(object sender, System.EventArgs e)
		{
			if(lvCorres.SelectedIndices.Count==0)
				MessageBox.Show("Veuillez selectionner une ligne !");
			else
			{
				ListViewItem Client = (ListViewItem)lvCorres.SelectedItems[0];
				Comm.CommandText="select * from T_clients_coressp where Cle = "+Client.Tag.ToString();
				DataAD.SelectCommand=Comm;
				try
				{
					if(DataAD.Fill(ds,"T_clients_coressp")>0)
					{
						DataTable Table = ds.Tables["T_clients_coressp"];
						NomCorres=ds.Tables["T_clients_coressp"].Rows[0]["Nom"].ToString();
						PrenomCorres=ds.Tables["T_clients_coressp"].Rows[0]["Prenom"].ToString();
						Mel=ds.Tables["T_clients_coressp"].Rows[0]["E_mail"].ToString();
						Tel=ds.Tables["T_clients_coressp"].Rows[0]["Telephone"].ToString();
						Fax=ds.Tables["T_clients_coressp"].Rows[0]["telecopie"].ToString();
						Service=ds.Tables["T_clients_coressp"].Rows[0]["Service"].ToString();
						Fonction=ds.Tables["T_clients_coressp"].Rows[0]["Fonction"].ToString();
						Note=ds.Tables["T_clients_coressp"].Rows[0]["Memo"].ToString();
						IDRow=ds.Tables["T_clients_coressp"].Rows[0]["Cle"].ToString();
						Pays=txPays.Text;
						ds.Tables["T_clients_coressp"].Clear();
						InfoCorres WinInfo = new InfoCorres(Agence,true,IDRow,txNom.Text, txIdent.Text, NomCorres, PrenomCorres, Mel, Tel, Fax, Service, Fonction, Note, Pays);
						WinInfo.ShowDialog();
					}
				}
				catch (OleDbException exp)
				{
					MessageBox.Show(exp.Message);
				}
				
				lvCorres.Items.Clear();
				Comm.CommandText="select * from T_clients_coressp where Ident="+System.Convert.ToInt32(txIdent.Text);
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"T_clients_coressp");
				}
				catch (OleDbException exp)
				{
					MessageBox.Show(exp.Message);
				}
				DataTable Table2 = ds.Tables["T_clients_coressp"];
				foreach (DataRow rowSel in Table2.Rows)
				{
					ListViewItem item = new ListViewItem(rowSel["Nom"].ToString());
					if(rowSel["Prenom"].ToString()!="?")
						item.SubItems.Add(rowSel["Prenom"].ToString());
					else
						item.SubItems.Add(" ");
					if(rowSel["E_mail"].ToString()!="?")
						item.SubItems.Add(rowSel["E_mail"].ToString());
					else
						item.SubItems.Add(" ");
					if(rowSel["Telephone"].ToString()!="?")
						item.SubItems.Add(rowSel["Telephone"].ToString());
					else
						item.SubItems.Add(" ");
					item.SubItems.Add(rowSel["Telecopie"].ToString());
					item.Tag=rowSel["Cle"].ToString();
					lvCorres.Items.Add(item);
				}
				ds.Tables["T_clients_coressp"].Clear();
			}
		}

		public class Machines
		{
			string Num=null;
			string Devis=null;
			string Date=null;
			string Decision=null;
			string Reparation=null;
			string Immat=null;
			string Type=null;
			string Famille=null;

			public Machines(string Num, string Devis, string Date, string Decision, string Reparation, string Immat, string Type, string Famille)
			{
				this.Num=Num;
				this.Devis=Devis;
				this.Date=Date;
				this.Decision=Decision;
				this.Reparation=Reparation;
				this.Immat=Immat;
				this.Type=Type;
				this.Famille=Famille;
			}


			public string GetNum
			{
				get
				{
					return Num;
				}
			}
			public string GetDevis
			{
				get
				{
					return Devis;
				}
			}
			public string GetDate
			{
				get
				{
					return Date;
				}
			}
			public string GetDecision
			{
				get
				{
					return Decision;
				}
			}
			public string GetReparation
			{
				get
				{
					return Reparation;
				}
			}
			public string GetImmat
			{
				get
				{
					return Immat;
				}
			}
			public string GetTy
			{
				get
				{
					return Type;
				}
			}
			public string GetFamille
			{
				get
				{
					return Famille;
				}
			}
		}
			
	}
}
