using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Globalization;
using Microsoft.Office.Interop.Excel;

namespace Opindus
{
	/// <summary>
	/// Description résumée de ControlesCAM.
	/// </summary>
	public class ControlesCAM : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.Label label15;
		private MTGCComboBox mtgcComboBox2;
		private MTGCComboBox mtgcComboBox3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.TextBox textBox28;
		private System.Windows.Forms.TextBox textBox29;
		private System.Windows.Forms.TextBox textBox30;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.TextBox textBox37;
		private System.Windows.Forms.TextBox textBox38;
		private System.Windows.Forms.TextBox textBox39;
		private System.Windows.Forms.TextBox textBox40;
		private System.Windows.Forms.TextBox textBox41;
		private System.Windows.Forms.TextBox textBox42;
		private System.Windows.Forms.TextBox textBox43;
		private System.Windows.Forms.TextBox textBox44;
		private System.Windows.Forms.TextBox textBox45;
		private System.Windows.Forms.TextBox textBox46;
		private System.Windows.Forms.TextBox textBox47;
		private System.Windows.Forms.TextBox textBox48;
		private System.Windows.Forms.TextBox textBox49;
		private System.Windows.Forms.TextBox textBox50;
		private System.Windows.Forms.TextBox textBox51;
		private System.Windows.Forms.TextBox textBox52;
		private System.Windows.Forms.TextBox textBox53;
		private System.Windows.Forms.TextBox textBox54;
		private System.Windows.Forms.TextBox textBox55;
		private System.Windows.Forms.TextBox textBox56;
		private System.Windows.Forms.TextBox textBox57;
		private System.Windows.Forms.TextBox textBox58;
		private System.Windows.Forms.TextBox textBox59;
		private System.Windows.Forms.TextBox textBox60;
		private System.Windows.Forms.TextBox textBox61;
		private System.Windows.Forms.TextBox textBox62;
		private System.Windows.Forms.TextBox textBox63;
		private System.Windows.Forms.TextBox textBox64;
		private System.Windows.Forms.TextBox textBox65;
		private System.Windows.Forms.TextBox textBox66;
		private System.Windows.Forms.TextBox textBox67;
		private System.Windows.Forms.TextBox textBox68;
		private System.Windows.Forms.TextBox textBox69;
		private System.Windows.Forms.TextBox textBox70;
		private System.Windows.Forms.TextBox textBox71;
		private System.Windows.Forms.TextBox textBox72;
		private System.Windows.Forms.TextBox textBox73;
		private System.Windows.Forms.TextBox textBox74;
		private System.Windows.Forms.TextBox textBox75;
		private System.Windows.Forms.TextBox textBox76;
		private System.Windows.Forms.TextBox textBox77;
		private System.Windows.Forms.TextBox textBox78;
		private System.Windows.Forms.TextBox textBox79;
		private System.Windows.Forms.TextBox textBox80;
		private System.Windows.Forms.TextBox textBox81;
		private System.Windows.Forms.TextBox textBox82;
		private System.Windows.Forms.TextBox textBox83;
		private System.Windows.Forms.TextBox textBox84;
		private System.Windows.Forms.TextBox textBox85;
		private System.Windows.Forms.TextBox textBox86;
		private System.Windows.Forms.TextBox textBox87;
		private System.Windows.Forms.TextBox textBox88;
		private System.Windows.Forms.TextBox textBox89;
		private System.Windows.Forms.TextBox textBox90;
		private System.Windows.Forms.TextBox textBox91;
		private System.Windows.Forms.TextBox textBox92;
		private System.Windows.Forms.TextBox textBox93;
		private System.Windows.Forms.TextBox textBox94;
		private System.Windows.Forms.TextBox textBox95;
		private System.Windows.Forms.TextBox textBox96;
		private System.Windows.Forms.TextBox textBox97;
		private System.Windows.Forms.TextBox textBox98;
		private System.Windows.Forms.TextBox textBox99;
		private System.Windows.Forms.TextBox textBox100;
		private System.Windows.Forms.TextBox textBox101;
		private System.Windows.Forms.TextBox textBox102;
		private System.Windows.Forms.TextBox textBox103;
		private System.Windows.Forms.TextBox textBox104;
		private System.Windows.Forms.TextBox textBox105;
		private System.Windows.Forms.TextBox textBox106;
		private System.Windows.Forms.TextBox textBox107;
		private System.Windows.Forms.TextBox textBox108;
		private System.Windows.Forms.TextBox textBox109;
		private System.Windows.Forms.TextBox textBox110;
		private System.Windows.Forms.TextBox textBox111;
		private System.Windows.Forms.TextBox textBox112;
		private System.Windows.Forms.TextBox textBox113;
		private System.Windows.Forms.TextBox textBox114;
		private System.Windows.Forms.TextBox textBox115;
		private System.Windows.Forms.TextBox textBox116;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox117;
		private System.Windows.Forms.Label label19;
		private int Agence;
		private bool save;
		private bool Nouveau;
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private DataSet MyData;
		private Decimal EcartType1;
		private Decimal EcartType2;
		private Decimal EcartTypeEstime;
		private Decimal EcartTypeInstantane;
		private Decimal Dispersion;
		private Decimal Moyenne;
		private Decimal Pourcent1;
		private Decimal Pourcent2;
		private Decimal Pourcent3;
		private Decimal Pourcent4;
		private Decimal Pourcent5;
		private Decimal Pourcent6;
		private Decimal Pourcent7;
		private Decimal Pourcent8;
		private Decimal CAM1;
		private Decimal CAM2;
		private Decimal CAM3;
		private Decimal CAM4;
		private Decimal CAM5;
		private Decimal CAM6;
		private Decimal CAM7;
		private Decimal CAM8;
		private Decimal MaxValeur;
		private Decimal MiniCmk;
		private Decimal MiniPpk;
		private Decimal PourcentMaxiMachine;
		private Decimal PourcentMaxiReglage;
		private Decimal MoyenneGroupe1;
		private Decimal MoyenneGroupe2;
		private Double EcartTypeGroupe1;
		private Double EcartTypeGroupe2;
		private Decimal TestDerive;
		private Decimal DiffAbs;
		private Double Kolmo;
		private Decimal MinPerf;
		private Decimal MaxPerf;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label49;
		private OleDbTransaction Transac;
		Object oRien=System.Reflection.Missing.Value;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox idcli;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
		private System.Windows.Forms.TextBox txDateDernierControle;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ControlesCAM(int Agence, string Machine)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			Nouveau=true;
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
			ds = new DataSet();
			DataAD = new OleDbDataAdapter();
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;

			try
			{
				Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus],T_parc_machine.[Date dernier controle], T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site FROM (T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_site INNER JOIN (T_affectation INNER JOIN T_parc_machine ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_parc_machine.[Code machine Opindus])='"+Machine+"'))";
				DataAD.SelectCommand=Comm;
				if(DataAD.Fill(ds,"T_famille_machine")>0)
				{
					textBox1.Text=ds.Tables["T_famille_machine"].Rows[0]["Code machine opindus"].ToString();
					textBox2.Text=ds.Tables["T_famille_machine"].Rows[0]["Nom"].ToString();
					textBox3.Text=ds.Tables["T_famille_machine"].Rows[0]["Type machine"].ToString();
					textBox4.Text=ds.Tables["T_famille_machine"].Rows[0]["Code mabec"].ToString();
					textBox5.Text=ds.Tables["T_famille_machine"].Rows[0]["Affectation"].ToString();
					textBox6.Text=ds.Tables["T_famille_machine"].Rows[0]["Site"].ToString();
					try
					{
						txDateDernierControle.Text=System.Convert.ToDateTime(ds.Tables["T_famille_machine"].Rows[0]["Date dernier controle"].ToString()).ToShortDateString();
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

			try
			{
				Comm.CommandText="SELECT chaine FROM t_parc_ets ORDER BY chaine";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_parc_ets");
				foreach(DataRow row in ds.Tables["t_parc_ets"].Rows)
				{
					mtgcComboBox2.Items.Add(new MTGCComboBoxItem(row["chaine"].ToString(),"","",""));
				}
				mtgcComboBox2.SelectedIndex=-1;
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			try
			{
				Comm.CommandText="SELECT chaine,id FROM t_parc_capteurs ORDER BY chaine";
				if(DataAD.Fill(ds,"t_parc_capteurs")>0)
				{			
					foreach(DataRow row in ds.Tables["t_parc_capteurs"].Rows)
					{
						mtgcComboBox3.Items.Add(new MTGCComboBoxItem(row["chaine"].ToString(),row["ID"].ToString(),"",""));
					}
					mtgcComboBox3.SelectedIndex=-1;
				}
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			try
			{
				Comm.CommandText="SELECT ID, Nom FROM T_reparateurs";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_reparateurs");
				foreach(DataRow row in ds.Tables["t_reparateurs"].Rows)
				{
					mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["ID"].ToString(),row["nom"].ToString(),"",""));
				}
				mtgcComboBox1.SelectedIndex=-1;
			}
			catch
			{
			}

			textBox8.Text=DateTime.Today.ToShortDateString();

			

			/*oleDbSelectCommand5.CommandText="select * from t_type_machine_vis where code='"+textBox3.Text+"'";
			oleDbDataAdapter5.Fill(ds);
			if(ds.Tables["t_type_machine_vis"].Rows.Count>0)
			{
				textBox9.Text=ds.Tables["t_type_machine_vis"].Rows[0]["c_mini"].ToString();
				textBox10.Text=ds.Tables["t_type_machine_vis"].Rows[0]["c_maxi"].ToString();
				textBox11.Text=ds.Tables["t_type_machine_vis"].Rows[0]["vitesse"].ToString();
			}
			else
			{
				
			}*/
			try
			{
				Comm.CommandText="SELECT T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse FROM T_type_machine WHERE (((T_type_machine.Code)='"+textBox1.Text+"')) GROUP BY T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse"; 
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_type_machine");
				if(ds.Tables["t_type_machine"].Rows.Count>0)
				{
					textBox9.Text=ds.Tables["t_type_machine"].Rows[0]["mini machine"].ToString();
					textBox10.Text=ds.Tables["t_type_machine"].Rows[0]["maxi machine"].ToString();
					textBox11.Text=ds.Tables["t_type_machine"].Rows[0]["vitesse"].ToString();
				}
				else
				{
					Comm.CommandText="SELECT T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse FROM T_type_machine_Vis WHERE (((T_type_machine_Vis.Code)='"+textBox3.Text+"')) GROUP BY T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_type_machine_vis");
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					if(ds.Tables["t_type_machine_vis"].Rows.Count>0)
					{
						textBox9.Text=ds.Tables["t_type_machine_vis"].Rows[0]["C_mini"].ToString();
						textBox10.Text=ds.Tables["t_type_machine_vis"].Rows[0]["C_maxi"].ToString();
						textBox11.Text=ds.Tables["t_type_machine_vis"].Rows[0]["Vitesse"].ToString();
					}
					else
					{
						textBox9.Text="0,00";
						textBox10.Text="0,00";
						textBox11.Text="0,00";
					}
				}
			}
			catch
			{
			}

			Comm.CommandText="select [N° Controle] from t_controles_cam order by id";
			OleDbDataAdapter Ad = new OleDbDataAdapter();
			Ad.SelectCommand=Comm;
			try
			{
				Ad.Fill(ds,"t_controles_cam");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			int nbr=System.Convert.ToInt32(ds.Tables["t_controles_cam"].Rows[ds.Tables["t_controles_cam"].Rows.Count-1]["N° Controle"].ToString())+1;
			textBox7.Text=nbr.ToString();
			save=false;

			Comm.CommandText="SELECT T_clients.Ident FROM T_controles_cam INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus] WHERE (((T_controles_cam.[Code machine opindus])='"+Machine+"')) GROUP BY T_clients.Ident";
			try
			{
				oleDbConnection1.Open();
				idcli.Text=System.Convert.ToInt32(Comm.ExecuteScalar()).ToString();
			}
			catch
			{
			}
			finally
			{
				oleDbConnection1.Close();
			}

		}

		public ControlesCAM(int Agence, int NumControle)
		{
			Nouveau=false;
			
			InitializeComponent();
			DataAD = new OleDbDataAdapter();
			ds = new DataSet();
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			button3.Enabled=true;
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

			try
			{
				Comm.CommandText="SELECT chaine FROM t_parc_ets ORDER BY chaine";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_parc_ets");
				foreach(DataRow row in ds.Tables["t_parc_ets"].Rows)
				{
					mtgcComboBox2.Items.Add(new MTGCComboBoxItem(row["chaine"].ToString(),"","",""));
				}
				mtgcComboBox2.SelectedIndex=-1;
			}
			catch
			{
			}
			try
			{
				Comm.CommandText="SELECT chaine,id FROM t_parc_capteurs ORDER BY chaine";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_parc_capteurs");
				foreach(DataRow row in ds.Tables["t_parc_capteurs"].Rows)
				{
					mtgcComboBox3.Items.Add(new MTGCComboBoxItem(row["chaine"].ToString(),row["ID"].ToString(),"",""));
				}
				mtgcComboBox3.SelectedIndex=-1;
			}
			catch
			{
			}
			try
			{
				Comm.CommandText="SELECT id,nom FROM t_reparateurs";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_reparateurs");
				foreach(DataRow row in ds.Tables["t_reparateurs"].Rows)
				{
					mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["ID"].ToString(),row["nom"].ToString(),"",""));
				}
				mtgcComboBox1.SelectedIndex=-1;
			}
			catch
			{
			}

			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046,"+ 
				" T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_051, T_controles_cam.Val_052, T_controles_cam.Val_053, T_controles_cam.Val_054, T_controles_cam.Val_055, T_controles_cam.Val_056, T_controles_cam.Val_057, T_controles_cam.Val_058, T_controles_cam.Val_059, T_controles_cam.Val_060, T_controles_cam.Val_061, T_controles_cam.Val_062, T_controles_cam.Val_063, T_controles_cam.Val_064, T_controles_cam.Val_065,"+
				" T_controles_cam.Val_066, T_controles_cam.Val_067, T_controles_cam.Val_068, T_controles_cam.Val_069, T_controles_cam.Val_070, T_controles_cam.Val_071, T_controles_cam.Val_072, T_controles_cam.Val_073, T_controles_cam.Val_074, T_controles_cam.Val_075, T_controles_cam.Val_076, T_controles_cam.Val_077, T_controles_cam.Val_078, T_controles_cam.Val_079, T_controles_cam.Val_080, T_controles_cam.Val_081, T_controles_cam.Val_082, T_controles_cam.Val_083, T_controles_cam.Val_084,"+
				" T_controles_cam.Val_085, T_controles_cam.Val_086, T_controles_cam.Val_087, T_controles_cam.Val_088, T_controles_cam.Val_089, T_controles_cam.Val_090, T_controles_cam.Val_091, T_controles_cam.Val_092, T_controles_cam.Val_093, T_controles_cam.Val_094, T_controles_cam.Val_095, T_controles_cam.Val_096, T_controles_cam.Val_097, T_controles_cam.Val_098, T_controles_cam.Val_099, T_controles_cam.Val_100, T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle.ToString()+"))";
			
			textBox12.Enabled=true;
			textBox13.Enabled=true;
			textBox14.Enabled=true;
			textBox117.Enabled=true;
			mtgcComboBox1.Enabled=true;
			mtgcComboBox2.Enabled=true;
			mtgcComboBox3.Enabled=true;
			button2.Enabled=true;

			MyData=new DataSet();
			try
			{
				DataAD.SelectCommand=Comm;
				DataAD.Fill(MyData,"T_controles_cam");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			if(MyData.Tables["t_controles_cam"].Rows.Count>0)
			{
				textBox1.Text=MyData.Tables["T_controles_cam"].Rows[0]["Code machine opindus"].ToString();
				textBox2.Text=MyData.Tables["T_controles_cam"].Rows[0]["Nom"].ToString();
				textBox3.Text=MyData.Tables["T_controles_cam"].Rows[0]["Type Machine"].ToString();
				textBox4.Text=MyData.Tables["T_controles_cam"].Rows[0]["Code mabec"].ToString();
				textBox5.Text=MyData.Tables["T_controles_cam"].Rows[0]["Affectation"].ToString();
				textBox6.Text=MyData.Tables["T_controles_cam"].Rows[0]["Site"].ToString();
				textBox7.Text=MyData.Tables["T_controles_cam"].Rows[0]["N° controle"].ToString();
				textBox8.Text=MyData.Tables["T_controles_cam"].Rows[0]["Date_controle"].ToString().Remove(10,9);
				textBox12.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["mini-poste"].ToString()).ToString("0.00");
				textBox13.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["maxi-poste"].ToString()).ToString("0.00");
				textBox14.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Vitesse_mesuree"].ToString()).ToString("0.00");
				textBox117.Text=MyData.Tables["T_controles_cam"].Rows[0]["Commentaire"].ToString();
				mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindString(MyData.Tables["T_controles_cam"].Rows[0]["Operateur"].ToString());
				mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(MyData.Tables["T_controles_cam"].Rows[0]["ets"].ToString());
				mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(MyData.Tables["T_controles_cam"].Rows[0]["chaine"].ToString());
				textBox16.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_001"].ToString()).ToString("0.00");
				textBox17.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_002"].ToString()).ToString("0.00");
				textBox18.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_003"].ToString()).ToString("0.00");
				textBox19.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_004"].ToString()).ToString("0.00");
				textBox20.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_005"].ToString()).ToString("0.00");
				textBox21.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_006"].ToString()).ToString("0.00");
				textBox22.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_007"].ToString()).ToString("0.00");
				textBox23.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_008"].ToString()).ToString("0.00");
				textBox24.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_009"].ToString()).ToString("0.00");
				textBox25.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_010"].ToString()).ToString("0.00");
				textBox35.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_011"].ToString()).ToString("0.00");
				textBox34.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_012"].ToString()).ToString("0.00");
				textBox33.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_013"].ToString()).ToString("0.00");
				textBox32.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_014"].ToString()).ToString("0.00");
				textBox31.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_015"].ToString()).ToString("0.00");
				textBox30.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_016"].ToString()).ToString("0.00");
				textBox29.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_017"].ToString()).ToString("0.00");
				textBox28.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_018"].ToString()).ToString("0.00");
				textBox27.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_019"].ToString()).ToString("0.00");
				textBox26.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_020"].ToString()).ToString("0.00");
				textBox45.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_021"].ToString()).ToString("0.00");
				textBox44.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_022"].ToString()).ToString("0.00");
				textBox43.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_023"].ToString()).ToString("0.00");
				textBox42.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_024"].ToString()).ToString("0.00");
				textBox41.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_025"].ToString()).ToString("0.00");
				textBox40.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_026"].ToString()).ToString("0.00");
				textBox39.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_027"].ToString()).ToString("0.00");
				textBox38.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_028"].ToString()).ToString("0.00");
				textBox37.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_029"].ToString()).ToString("0.00");
				textBox36.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_030"].ToString()).ToString("0.00");
				textBox55.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_031"].ToString()).ToString("0.00");
				textBox54.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_032"].ToString()).ToString("0.00");
				textBox53.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_033"].ToString()).ToString("0.00");
				textBox52.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_034"].ToString()).ToString("0.00");
				textBox51.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_035"].ToString()).ToString("0.00");
				textBox50.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_036"].ToString()).ToString("0.00");
				textBox49.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_037"].ToString()).ToString("0.00");
				textBox48.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_038"].ToString()).ToString("0.00");
				textBox47.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_039"].ToString()).ToString("0.00");
				textBox46.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_040"].ToString()).ToString("0.00");
				textBox65.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_041"].ToString()).ToString("0.00");
				textBox64.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_042"].ToString()).ToString("0.00");
				textBox63.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_043"].ToString()).ToString("0.00");
				textBox62.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_044"].ToString()).ToString("0.00");
				textBox61.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_045"].ToString()).ToString("0.00");
				textBox60.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_046"].ToString()).ToString("0.00");
				textBox59.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_047"].ToString()).ToString("0.00");
				textBox58.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_048"].ToString()).ToString("0.00");
				textBox57.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_049"].ToString()).ToString("0.00");
				textBox56.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_050"].ToString()).ToString("0.00");
				textBox75.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_051"].ToString()).ToString("0.00");
				textBox74.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_052"].ToString()).ToString("0.00");
				textBox73.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_053"].ToString()).ToString("0.00");
				textBox72.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_054"].ToString()).ToString("0.00");
				textBox71.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_055"].ToString()).ToString("0.00");
				textBox70.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_056"].ToString()).ToString("0.00");
				textBox69.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_057"].ToString()).ToString("0.00");
				textBox68.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_058"].ToString()).ToString("0.00");
				textBox67.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_059"].ToString()).ToString("0.00");
				textBox66.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_060"].ToString()).ToString("0.00");
				textBox85.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_061"].ToString()).ToString("0.00");
				textBox84.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_062"].ToString()).ToString("0.00");
				textBox83.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_063"].ToString()).ToString("0.00");
				textBox82.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_064"].ToString()).ToString("0.00");
				textBox81.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_065"].ToString()).ToString("0.00");
				textBox80.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_066"].ToString()).ToString("0.00");
				textBox79.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_067"].ToString()).ToString("0.00");
				textBox78.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_068"].ToString()).ToString("0.00");
				textBox77.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_069"].ToString()).ToString("0.00");
				textBox76.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_070"].ToString()).ToString("0.00");
				textBox95.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_071"].ToString()).ToString("0.00");
				textBox94.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_072"].ToString()).ToString("0.00");
				textBox93.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_073"].ToString()).ToString("0.00");
				textBox92.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_074"].ToString()).ToString("0.00");
				textBox91.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_075"].ToString()).ToString("0.00");
				textBox90.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_076"].ToString()).ToString("0.00");
				textBox89.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_077"].ToString()).ToString("0.00");
				textBox88.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_078"].ToString()).ToString("0.00");
				textBox87.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_079"].ToString()).ToString("0.00");
				textBox86.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_080"].ToString()).ToString("0.00");
				textBox105.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_081"].ToString()).ToString("0.00");
				textBox104.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_082"].ToString()).ToString("0.00");
				textBox103.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_083"].ToString()).ToString("0.00");
				textBox102.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_084"].ToString()).ToString("0.00");
				textBox101.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_085"].ToString()).ToString("0.00");
				textBox100.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_086"].ToString()).ToString("0.00");
				textBox99.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_087"].ToString()).ToString("0.00");
				textBox98.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_088"].ToString()).ToString("0.00");
				textBox97.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_089"].ToString()).ToString("0.00");
				textBox96.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_090"].ToString()).ToString("0.00");
				textBox115.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_091"].ToString()).ToString("0.00");
				textBox114.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_092"].ToString()).ToString("0.00");
				textBox113.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_093"].ToString()).ToString("0.00");
				textBox112.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_094"].ToString()).ToString("0.00");
				textBox111.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_095"].ToString()).ToString("0.00");
				textBox110.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_096"].ToString()).ToString("0.00");
				textBox109.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_097"].ToString()).ToString("0.00");
				textBox108.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_098"].ToString()).ToString("0.00");
				textBox107.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_099"].ToString()).ToString("0.00");
				textBox106.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["val_100"].ToString()).ToString("0.00");
				if(MyData.Tables["T_controles_cam"].Rows[0]["type_controle"].ToString().Equals("1"))
				{
					radioButton1.Checked=true;
					radioButton2.Checked=false;
					radioButton2.Enabled=false;
					radioButton3.Checked=false;
					radioButton3.Enabled=false;
				}
				else if(MyData.Tables["T_controles_cam"].Rows[0]["type_controle"].ToString().Equals("2"))
				{
					radioButton2.Checked=true;
					radioButton1.Checked=false;
					radioButton1.Enabled=false;
					radioButton3.Checked=false;
					radioButton3.Enabled=false;
				}
				else if(MyData.Tables["T_controles_cam"].Rows[0]["type_controle"].ToString().Equals("3"))
				{
					radioButton3.Checked=true;
					radioButton1.Checked=false;
					radioButton1.Enabled=false;
					radioButton2.Checked=false;
					radioButton2.Enabled=false;
				}
				Comm.CommandText="SELECT T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse FROM T_type_machine WHERE (((T_type_machine.Code)='"+textBox1.Text+"')) GROUP BY T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse"; 
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_type_machine");
				if(ds.Tables["t_type_machine"].Rows.Count>0)
				{
					textBox9.Text=ds.Tables["t_type_machine"].Rows[0]["mini machine"].ToString();
					textBox10.Text=ds.Tables["t_type_machine"].Rows[0]["maxi machine"].ToString();
					textBox11.Text=ds.Tables["t_type_machine"].Rows[0]["vitesse"].ToString();
				}
				else
				{
					Comm.CommandText="SELECT T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse FROM T_type_machine_Vis WHERE (((T_type_machine_Vis.Code)='"+textBox3.Text+"')) GROUP BY T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse";
					try
					{
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"t_type_machine_vis");
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					if(ds.Tables["t_type_machine_vis"].Rows.Count>0)
					{
						textBox9.Text=ds.Tables["t_type_machine_vis"].Rows[0]["C_mini"].ToString();
						textBox10.Text=ds.Tables["t_type_machine_vis"].Rows[0]["C_maxi"].ToString();
						textBox11.Text=ds.Tables["t_type_machine_vis"].Rows[0]["Vitesse"].ToString();
					}
					else
					{
						textBox9.Text="0,00";
						textBox10.Text="0,00";
						textBox11.Text="0,00";
					}
				}
			}
			Comm.CommandText="SELECT T_clients.Ident FROM T_controles_cam INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus] WHERE (((T_controles_cam.[N° Controle])="+NumControle+")) GROUP BY T_clients.Ident";
			try
			{
				oleDbConnection1.Open();
				idcli.Text=System.Convert.ToInt32(Comm.ExecuteScalar()).ToString();
				oleDbConnection1.Close();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}

			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ControlesCAM));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.idcli = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.textBox117 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label18 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label49 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.label45 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.textBox116 = new System.Windows.Forms.TextBox();
			this.textBox106 = new System.Windows.Forms.TextBox();
			this.textBox107 = new System.Windows.Forms.TextBox();
			this.textBox108 = new System.Windows.Forms.TextBox();
			this.textBox109 = new System.Windows.Forms.TextBox();
			this.textBox110 = new System.Windows.Forms.TextBox();
			this.textBox111 = new System.Windows.Forms.TextBox();
			this.textBox112 = new System.Windows.Forms.TextBox();
			this.textBox113 = new System.Windows.Forms.TextBox();
			this.textBox114 = new System.Windows.Forms.TextBox();
			this.textBox115 = new System.Windows.Forms.TextBox();
			this.textBox96 = new System.Windows.Forms.TextBox();
			this.textBox97 = new System.Windows.Forms.TextBox();
			this.textBox98 = new System.Windows.Forms.TextBox();
			this.textBox99 = new System.Windows.Forms.TextBox();
			this.textBox100 = new System.Windows.Forms.TextBox();
			this.textBox101 = new System.Windows.Forms.TextBox();
			this.textBox102 = new System.Windows.Forms.TextBox();
			this.textBox103 = new System.Windows.Forms.TextBox();
			this.textBox104 = new System.Windows.Forms.TextBox();
			this.textBox105 = new System.Windows.Forms.TextBox();
			this.textBox86 = new System.Windows.Forms.TextBox();
			this.textBox87 = new System.Windows.Forms.TextBox();
			this.textBox88 = new System.Windows.Forms.TextBox();
			this.textBox89 = new System.Windows.Forms.TextBox();
			this.textBox90 = new System.Windows.Forms.TextBox();
			this.textBox91 = new System.Windows.Forms.TextBox();
			this.textBox92 = new System.Windows.Forms.TextBox();
			this.textBox93 = new System.Windows.Forms.TextBox();
			this.textBox94 = new System.Windows.Forms.TextBox();
			this.textBox95 = new System.Windows.Forms.TextBox();
			this.textBox76 = new System.Windows.Forms.TextBox();
			this.textBox77 = new System.Windows.Forms.TextBox();
			this.textBox78 = new System.Windows.Forms.TextBox();
			this.textBox79 = new System.Windows.Forms.TextBox();
			this.textBox80 = new System.Windows.Forms.TextBox();
			this.textBox81 = new System.Windows.Forms.TextBox();
			this.textBox82 = new System.Windows.Forms.TextBox();
			this.textBox83 = new System.Windows.Forms.TextBox();
			this.textBox84 = new System.Windows.Forms.TextBox();
			this.textBox85 = new System.Windows.Forms.TextBox();
			this.textBox66 = new System.Windows.Forms.TextBox();
			this.textBox67 = new System.Windows.Forms.TextBox();
			this.textBox68 = new System.Windows.Forms.TextBox();
			this.textBox69 = new System.Windows.Forms.TextBox();
			this.textBox70 = new System.Windows.Forms.TextBox();
			this.textBox71 = new System.Windows.Forms.TextBox();
			this.textBox72 = new System.Windows.Forms.TextBox();
			this.textBox73 = new System.Windows.Forms.TextBox();
			this.textBox74 = new System.Windows.Forms.TextBox();
			this.textBox75 = new System.Windows.Forms.TextBox();
			this.textBox56 = new System.Windows.Forms.TextBox();
			this.textBox57 = new System.Windows.Forms.TextBox();
			this.textBox58 = new System.Windows.Forms.TextBox();
			this.textBox59 = new System.Windows.Forms.TextBox();
			this.textBox60 = new System.Windows.Forms.TextBox();
			this.textBox61 = new System.Windows.Forms.TextBox();
			this.textBox62 = new System.Windows.Forms.TextBox();
			this.textBox63 = new System.Windows.Forms.TextBox();
			this.textBox64 = new System.Windows.Forms.TextBox();
			this.textBox65 = new System.Windows.Forms.TextBox();
			this.textBox46 = new System.Windows.Forms.TextBox();
			this.textBox47 = new System.Windows.Forms.TextBox();
			this.textBox48 = new System.Windows.Forms.TextBox();
			this.textBox49 = new System.Windows.Forms.TextBox();
			this.textBox50 = new System.Windows.Forms.TextBox();
			this.textBox51 = new System.Windows.Forms.TextBox();
			this.textBox52 = new System.Windows.Forms.TextBox();
			this.textBox53 = new System.Windows.Forms.TextBox();
			this.textBox54 = new System.Windows.Forms.TextBox();
			this.textBox55 = new System.Windows.Forms.TextBox();
			this.textBox36 = new System.Windows.Forms.TextBox();
			this.textBox37 = new System.Windows.Forms.TextBox();
			this.textBox38 = new System.Windows.Forms.TextBox();
			this.textBox39 = new System.Windows.Forms.TextBox();
			this.textBox40 = new System.Windows.Forms.TextBox();
			this.textBox41 = new System.Windows.Forms.TextBox();
			this.textBox42 = new System.Windows.Forms.TextBox();
			this.textBox43 = new System.Windows.Forms.TextBox();
			this.textBox44 = new System.Windows.Forms.TextBox();
			this.textBox45 = new System.Windows.Forms.TextBox();
			this.textBox26 = new System.Windows.Forms.TextBox();
			this.textBox27 = new System.Windows.Forms.TextBox();
			this.textBox28 = new System.Windows.Forms.TextBox();
			this.textBox29 = new System.Windows.Forms.TextBox();
			this.textBox30 = new System.Windows.Forms.TextBox();
			this.textBox31 = new System.Windows.Forms.TextBox();
			this.textBox32 = new System.Windows.Forms.TextBox();
			this.textBox33 = new System.Windows.Forms.TextBox();
			this.textBox34 = new System.Windows.Forms.TextBox();
			this.textBox35 = new System.Windows.Forms.TextBox();
			this.textBox25 = new System.Windows.Forms.TextBox();
			this.textBox24 = new System.Windows.Forms.TextBox();
			this.textBox23 = new System.Windows.Forms.TextBox();
			this.textBox22 = new System.Windows.Forms.TextBox();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
			this.txDateDernierControle = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(504, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.White;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(104, 88);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(384, 20);
			this.textBox4.TabIndex = 7;
			this.textBox4.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(104, 64);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(384, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(104, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(384, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(104, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(384, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Code MABEC";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Type";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Marque";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Code machine";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.idcli);
			this.groupBox2.Location = new System.Drawing.Point(512, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(400, 120);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.White;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(20, 86);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(356, 20);
			this.textBox6.TabIndex = 39;
			this.textBox6.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.White;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(20, 38);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(356, 20);
			this.textBox5.TabIndex = 38;
			this.textBox5.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(20, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 37;
			this.label6.Text = "Site";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 18);
			this.label5.TabIndex = 36;
			this.label5.Text = "Affectation";
			// 
			// idcli
			// 
			this.idcli.Location = new System.Drawing.Point(328, 16);
			this.idcli.Name = "idcli";
			this.idcli.Size = new System.Drawing.Size(48, 20);
			this.idcli.TabIndex = 7;
			this.idcli.Text = "";
			this.idcli.Visible = false;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.textBox117);
			this.groupBox3.Controls.Add(this.textBox8);
			this.groupBox3.Controls.Add(this.textBox7);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.textBox15);
			this.groupBox3.Location = new System.Drawing.Point(8, 121);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(504, 207);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(16, 120);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 16);
			this.label19.TabIndex = 34;
			this.label19.Text = "Commentaires";
			// 
			// textBox117
			// 
			this.textBox117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox117.Enabled = false;
			this.textBox117.Location = new System.Drawing.Point(16, 144);
			this.textBox117.Multiline = true;
			this.textBox117.Name = "textBox117";
			this.textBox117.Size = new System.Drawing.Size(472, 40);
			this.textBox117.TabIndex = 33;
			this.textBox117.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.White;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(120, 48);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(120, 20);
			this.textBox8.TabIndex = 31;
			this.textBox8.Text = "";
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.White;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(120, 24);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(120, 20);
			this.textBox7.TabIndex = 30;
			this.textBox7.Text = "";
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 29;
			this.label8.Text = "Date contrôle";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(16, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 17);
			this.label7.TabIndex = 28;
			this.label7.Text = "Numéro contrôle";
			// 
			// textBox15
			// 
			this.textBox15.BackColor = System.Drawing.Color.SteelBlue;
			this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox15.ForeColor = System.Drawing.Color.White;
			this.textBox15.Location = new System.Drawing.Point(0, 80);
			this.textBox15.Name = "textBox15";
			this.textBox15.ReadOnly = true;
			this.textBox15.Size = new System.Drawing.Size(504, 22);
			this.textBox15.TabIndex = 32;
			this.textBox15.Text = "Fichier acquisition en cours";
			this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.mtgcComboBox3);
			this.groupBox4.Controls.Add(this.mtgcComboBox2);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.mtgcComboBox1);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.textBox14);
			this.groupBox4.Controls.Add(this.textBox13);
			this.groupBox4.Controls.Add(this.textBox12);
			this.groupBox4.Controls.Add(this.textBox11);
			this.groupBox4.Controls.Add(this.textBox10);
			this.groupBox4.Controls.Add(this.textBox9);
			this.groupBox4.Location = new System.Drawing.Point(512, 121);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(400, 207);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(16, 136);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 16);
			this.label17.TabIndex = 17;
			this.label17.Text = "Capteur";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(16, 96);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 16);
			this.label16.TabIndex = 16;
			this.label16.Text = "Chaine";
			// 
			// mtgcComboBox3
			// 
			this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox3.ColumnNum = 2;
			this.mtgcComboBox3.ColumnWidth = "270;50";
			this.mtgcComboBox3.DisplayMember = "Text";
			this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox3.DropDownWidth = 340;
			this.mtgcComboBox3.Enabled = false;
			this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox3.GridLineHorizontal = false;
			this.mtgcComboBox3.GridLineVertical = true;
			this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox3.Location = new System.Drawing.Point(16, 152);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(359, 21);
			this.mtgcComboBox3.TabIndex = 15;
			// 
			// mtgcComboBox2
			// 
			this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox2.ColumnNum = 1;
			this.mtgcComboBox2.ColumnWidth = "200";
			this.mtgcComboBox2.DisplayMember = "Text";
			this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox2.DropDownWidth = 270;
			this.mtgcComboBox2.Enabled = false;
			this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox2.GridLineHorizontal = false;
			this.mtgcComboBox2.GridLineVertical = false;
			this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox2.Location = new System.Drawing.Point(16, 112);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(360, 21);
			this.mtgcComboBox2.TabIndex = 14;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(303, 55);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(67, 17);
			this.label15.TabIndex = 13;
			this.label15.Text = "Opérateur";
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
			this.mtgcComboBox1.Enabled = false;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = false;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(289, 72);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(87, 21);
			this.mtgcComboBox1.TabIndex = 12;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(189, 56);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 16);
			this.label14.TabIndex = 11;
			this.label14.Text = "Vit. mesurée";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(15, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 16);
			this.label13.TabIndex = 10;
			this.label13.Text = "Mini poste";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(103, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(96, 16);
			this.label12.TabIndex = 9;
			this.label12.Text = "Maxi poste";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(192, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 16);
			this.label11.TabIndex = 8;
			this.label11.Text = "Vitesse";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(103, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 16);
			this.label10.TabIndex = 7;
			this.label10.Text = "Maxi Mach.";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(15, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 16);
			this.label9.TabIndex = 6;
			this.label9.Text = "Mini Mach.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox14
			// 
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox14.Enabled = false;
			this.textBox14.Location = new System.Drawing.Point(194, 72);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(90, 20);
			this.textBox14.TabIndex = 5;
			this.textBox14.Text = "0,00";
			this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox13
			// 
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox13.Enabled = false;
			this.textBox13.Location = new System.Drawing.Point(105, 72);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(90, 20);
			this.textBox13.TabIndex = 4;
			this.textBox13.Text = "0,00";
			this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox12
			// 
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Enabled = false;
			this.textBox12.Location = new System.Drawing.Point(16, 72);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(90, 20);
			this.textBox12.TabIndex = 3;
			this.textBox12.Text = "0,00";
			this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox11
			// 
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Location = new System.Drawing.Point(194, 32);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(90, 20);
			this.textBox11.TabIndex = 2;
			this.textBox11.Text = "";
			this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox10
			// 
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Location = new System.Drawing.Point(105, 32);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(90, 20);
			this.textBox10.TabIndex = 1;
			this.textBox10.Text = "";
			this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox9
			// 
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Location = new System.Drawing.Point(16, 32);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(90, 20);
			this.textBox9.TabIndex = 0;
			this.textBox9.Text = "";
			this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox16
			// 
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox16.Enabled = false;
			this.textBox16.ForeColor = System.Drawing.Color.Black;
			this.textBox16.Location = new System.Drawing.Point(72, 64);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(64, 20);
			this.textBox16.TabIndex = 4;
			this.textBox16.Text = "0,00";
			this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox16.Leave += new System.EventHandler(this.textBox16_Leave);
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.button3);
			this.groupBox5.Controls.Add(this.button4);
			this.groupBox5.Controls.Add(this.radioButton3);
			this.groupBox5.Controls.Add(this.radioButton2);
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Controls.Add(this.radioButton1);
			this.groupBox5.Controls.Add(this.button1);
			this.groupBox5.Controls.Add(this.button2);
			this.groupBox5.Location = new System.Drawing.Point(8, 320);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(88, 312);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(8, 160);
			this.button3.Name = "button3";
			this.button3.TabIndex = 37;
			this.button3.Text = "Edition";
			this.button3.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(20, 240);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(48, 48);
			this.button4.TabIndex = 36;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// radioButton3
			// 
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(16, 80);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 35;
			this.radioButton3.Text = "100";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(16, 56);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 34;
			this.radioButton2.Text = "50";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(11, 8);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 23);
			this.label18.TabIndex = 33;
			this.label18.Text = "Valeurs";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(16, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(44, 24);
			this.radioButton1.TabIndex = 33;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "30";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(8, 112);
			this.button1.Name = "button1";
			this.button1.TabIndex = 33;
			this.button1.Text = "Saisie";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Enabled = false;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(8, 136);
			this.button2.Name = "button2";
			this.button2.TabIndex = 33;
			this.button2.Text = "Enregistre";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox6.Controls.Add(this.label49);
			this.groupBox6.Controls.Add(this.label48);
			this.groupBox6.Controls.Add(this.label47);
			this.groupBox6.Controls.Add(this.label46);
			this.groupBox6.Controls.Add(this.label45);
			this.groupBox6.Controls.Add(this.label44);
			this.groupBox6.Controls.Add(this.label43);
			this.groupBox6.Controls.Add(this.label42);
			this.groupBox6.Controls.Add(this.label41);
			this.groupBox6.Controls.Add(this.label40);
			this.groupBox6.Controls.Add(this.label39);
			this.groupBox6.Controls.Add(this.label38);
			this.groupBox6.Controls.Add(this.label37);
			this.groupBox6.Controls.Add(this.label36);
			this.groupBox6.Controls.Add(this.label31);
			this.groupBox6.Controls.Add(this.label32);
			this.groupBox6.Controls.Add(this.label33);
			this.groupBox6.Controls.Add(this.label34);
			this.groupBox6.Controls.Add(this.label35);
			this.groupBox6.Controls.Add(this.label30);
			this.groupBox6.Controls.Add(this.label28);
			this.groupBox6.Controls.Add(this.label27);
			this.groupBox6.Controls.Add(this.label26);
			this.groupBox6.Controls.Add(this.label25);
			this.groupBox6.Controls.Add(this.label24);
			this.groupBox6.Controls.Add(this.label23);
			this.groupBox6.Controls.Add(this.label22);
			this.groupBox6.Controls.Add(this.label21);
			this.groupBox6.Controls.Add(this.label20);
			this.groupBox6.Controls.Add(this.textBox116);
			this.groupBox6.Controls.Add(this.textBox106);
			this.groupBox6.Controls.Add(this.textBox107);
			this.groupBox6.Controls.Add(this.textBox108);
			this.groupBox6.Controls.Add(this.textBox109);
			this.groupBox6.Controls.Add(this.textBox110);
			this.groupBox6.Controls.Add(this.textBox111);
			this.groupBox6.Controls.Add(this.textBox112);
			this.groupBox6.Controls.Add(this.textBox113);
			this.groupBox6.Controls.Add(this.textBox114);
			this.groupBox6.Controls.Add(this.textBox115);
			this.groupBox6.Controls.Add(this.textBox96);
			this.groupBox6.Controls.Add(this.textBox97);
			this.groupBox6.Controls.Add(this.textBox98);
			this.groupBox6.Controls.Add(this.textBox99);
			this.groupBox6.Controls.Add(this.textBox100);
			this.groupBox6.Controls.Add(this.textBox101);
			this.groupBox6.Controls.Add(this.textBox102);
			this.groupBox6.Controls.Add(this.textBox103);
			this.groupBox6.Controls.Add(this.textBox104);
			this.groupBox6.Controls.Add(this.textBox105);
			this.groupBox6.Controls.Add(this.textBox86);
			this.groupBox6.Controls.Add(this.textBox87);
			this.groupBox6.Controls.Add(this.textBox88);
			this.groupBox6.Controls.Add(this.textBox89);
			this.groupBox6.Controls.Add(this.textBox90);
			this.groupBox6.Controls.Add(this.textBox91);
			this.groupBox6.Controls.Add(this.textBox92);
			this.groupBox6.Controls.Add(this.textBox93);
			this.groupBox6.Controls.Add(this.textBox94);
			this.groupBox6.Controls.Add(this.textBox95);
			this.groupBox6.Controls.Add(this.textBox76);
			this.groupBox6.Controls.Add(this.textBox77);
			this.groupBox6.Controls.Add(this.textBox78);
			this.groupBox6.Controls.Add(this.textBox79);
			this.groupBox6.Controls.Add(this.textBox80);
			this.groupBox6.Controls.Add(this.textBox81);
			this.groupBox6.Controls.Add(this.textBox82);
			this.groupBox6.Controls.Add(this.textBox83);
			this.groupBox6.Controls.Add(this.textBox84);
			this.groupBox6.Controls.Add(this.textBox85);
			this.groupBox6.Controls.Add(this.textBox66);
			this.groupBox6.Controls.Add(this.textBox67);
			this.groupBox6.Controls.Add(this.textBox68);
			this.groupBox6.Controls.Add(this.textBox69);
			this.groupBox6.Controls.Add(this.textBox70);
			this.groupBox6.Controls.Add(this.textBox71);
			this.groupBox6.Controls.Add(this.textBox72);
			this.groupBox6.Controls.Add(this.textBox73);
			this.groupBox6.Controls.Add(this.textBox74);
			this.groupBox6.Controls.Add(this.textBox75);
			this.groupBox6.Controls.Add(this.textBox56);
			this.groupBox6.Controls.Add(this.textBox57);
			this.groupBox6.Controls.Add(this.textBox58);
			this.groupBox6.Controls.Add(this.textBox59);
			this.groupBox6.Controls.Add(this.textBox60);
			this.groupBox6.Controls.Add(this.textBox61);
			this.groupBox6.Controls.Add(this.textBox62);
			this.groupBox6.Controls.Add(this.textBox63);
			this.groupBox6.Controls.Add(this.textBox64);
			this.groupBox6.Controls.Add(this.textBox65);
			this.groupBox6.Controls.Add(this.textBox46);
			this.groupBox6.Controls.Add(this.textBox47);
			this.groupBox6.Controls.Add(this.textBox48);
			this.groupBox6.Controls.Add(this.textBox49);
			this.groupBox6.Controls.Add(this.textBox50);
			this.groupBox6.Controls.Add(this.textBox51);
			this.groupBox6.Controls.Add(this.textBox52);
			this.groupBox6.Controls.Add(this.textBox53);
			this.groupBox6.Controls.Add(this.textBox54);
			this.groupBox6.Controls.Add(this.textBox55);
			this.groupBox6.Controls.Add(this.textBox36);
			this.groupBox6.Controls.Add(this.textBox37);
			this.groupBox6.Controls.Add(this.textBox38);
			this.groupBox6.Controls.Add(this.textBox39);
			this.groupBox6.Controls.Add(this.textBox40);
			this.groupBox6.Controls.Add(this.textBox41);
			this.groupBox6.Controls.Add(this.textBox42);
			this.groupBox6.Controls.Add(this.textBox43);
			this.groupBox6.Controls.Add(this.textBox44);
			this.groupBox6.Controls.Add(this.textBox45);
			this.groupBox6.Controls.Add(this.textBox26);
			this.groupBox6.Controls.Add(this.textBox27);
			this.groupBox6.Controls.Add(this.textBox28);
			this.groupBox6.Controls.Add(this.textBox29);
			this.groupBox6.Controls.Add(this.textBox30);
			this.groupBox6.Controls.Add(this.textBox31);
			this.groupBox6.Controls.Add(this.textBox32);
			this.groupBox6.Controls.Add(this.textBox33);
			this.groupBox6.Controls.Add(this.textBox34);
			this.groupBox6.Controls.Add(this.textBox35);
			this.groupBox6.Controls.Add(this.textBox25);
			this.groupBox6.Controls.Add(this.textBox24);
			this.groupBox6.Controls.Add(this.textBox23);
			this.groupBox6.Controls.Add(this.textBox22);
			this.groupBox6.Controls.Add(this.textBox21);
			this.groupBox6.Controls.Add(this.textBox20);
			this.groupBox6.Controls.Add(this.textBox19);
			this.groupBox6.Controls.Add(this.textBox18);
			this.groupBox6.Controls.Add(this.textBox17);
			this.groupBox6.Controls.Add(this.textBox16);
			this.groupBox6.Controls.Add(this.label29);
			this.groupBox6.Location = new System.Drawing.Point(96, 320);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(816, 312);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			// 
			// label49
			// 
			this.label49.Location = new System.Drawing.Point(432, 280);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(32, 23);
			this.label49.TabIndex = 133;
			this.label49.Text = "E20 :";
			this.label49.Visible = false;
			// 
			// label48
			// 
			this.label48.Location = new System.Drawing.Point(40, 280);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(32, 23);
			this.label48.TabIndex = 132;
			this.label48.Text = "E19:";
			this.label48.Visible = false;
			// 
			// label47
			// 
			this.label47.Location = new System.Drawing.Point(432, 256);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(32, 23);
			this.label47.TabIndex = 131;
			this.label47.Text = "E18 :";
			this.label47.Visible = false;
			// 
			// label46
			// 
			this.label46.Location = new System.Drawing.Point(40, 256);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(32, 23);
			this.label46.TabIndex = 130;
			this.label46.Text = "E17 :";
			this.label46.Visible = false;
			// 
			// label45
			// 
			this.label45.Location = new System.Drawing.Point(432, 232);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(32, 23);
			this.label45.TabIndex = 129;
			this.label45.Text = "E16 :";
			this.label45.Visible = false;
			// 
			// label44
			// 
			this.label44.Location = new System.Drawing.Point(40, 232);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(32, 23);
			this.label44.TabIndex = 128;
			this.label44.Text = "E15 :";
			this.label44.Visible = false;
			// 
			// label43
			// 
			this.label43.Location = new System.Drawing.Point(432, 208);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(32, 23);
			this.label43.TabIndex = 127;
			this.label43.Text = "E14 :";
			this.label43.Visible = false;
			// 
			// label42
			// 
			this.label42.Location = new System.Drawing.Point(40, 208);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(32, 23);
			this.label42.TabIndex = 126;
			this.label42.Text = "E13:";
			this.label42.Visible = false;
			// 
			// label41
			// 
			this.label41.Location = new System.Drawing.Point(432, 184);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(32, 23);
			this.label41.TabIndex = 125;
			this.label41.Text = "E12 :";
			this.label41.Visible = false;
			// 
			// label40
			// 
			this.label40.Location = new System.Drawing.Point(40, 184);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(32, 23);
			this.label40.TabIndex = 124;
			this.label40.Text = "E11 :";
			this.label40.Visible = false;
			// 
			// label39
			// 
			this.label39.Location = new System.Drawing.Point(432, 160);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(32, 23);
			this.label39.TabIndex = 123;
			this.label39.Text = "E10 :";
			this.label39.Visible = false;
			// 
			// label38
			// 
			this.label38.Location = new System.Drawing.Point(40, 160);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(32, 23);
			this.label38.TabIndex = 122;
			this.label38.Text = "E9:";
			this.label38.Visible = false;
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(432, 136);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(32, 23);
			this.label37.TabIndex = 121;
			this.label37.Text = "E8 :";
			this.label37.Visible = false;
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(40, 136);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(32, 23);
			this.label36.TabIndex = 120;
			this.label36.Text = "E7 :";
			this.label36.Visible = false;
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(656, 40);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(64, 23);
			this.label31.TabIndex = 119;
			this.label31.Text = "M4";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(720, 40);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(64, 23);
			this.label32.TabIndex = 118;
			this.label32.Text = "M5";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(528, 40);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(64, 23);
			this.label33.TabIndex = 116;
			this.label33.Text = "M2";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(464, 40);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(64, 23);
			this.label34.TabIndex = 115;
			this.label34.Text = "M1";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(592, 40);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(64, 23);
			this.label35.TabIndex = 117;
			this.label35.Text = "M3";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(264, 40);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(64, 23);
			this.label30.TabIndex = 114;
			this.label30.Text = "M4";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(328, 40);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 23);
			this.label28.TabIndex = 113;
			this.label28.Text = "M5";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(136, 40);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(64, 23);
			this.label27.TabIndex = 112;
			this.label27.Text = "M2";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(72, 40);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(64, 23);
			this.label26.TabIndex = 111;
			this.label26.Text = "M1";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(432, 112);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(32, 23);
			this.label25.TabIndex = 110;
			this.label25.Text = "E6 :";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(40, 112);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(32, 23);
			this.label24.TabIndex = 109;
			this.label24.Text = "E5 :";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(432, 88);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(32, 23);
			this.label23.TabIndex = 108;
			this.label23.Text = "E4 :";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(40, 88);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(32, 23);
			this.label22.TabIndex = 107;
			this.label22.Text = "E3 :";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(432, 64);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(32, 23);
			this.label21.TabIndex = 106;
			this.label21.Text = "E2 :";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(40, 64);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(32, 23);
			this.label20.TabIndex = 105;
			this.label20.Text = "E1 :";
			// 
			// textBox116
			// 
			this.textBox116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox116.Location = new System.Drawing.Point(8, 16);
			this.textBox116.Name = "textBox116";
			this.textBox116.ReadOnly = true;
			this.textBox116.Size = new System.Drawing.Size(800, 20);
			this.textBox116.TabIndex = 104;
			this.textBox116.Text = "Contrôle 30 mesures";
			this.textBox116.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox106
			// 
			this.textBox106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox106.Enabled = false;
			this.textBox106.Location = new System.Drawing.Point(720, 280);
			this.textBox106.Name = "textBox106";
			this.textBox106.Size = new System.Drawing.Size(64, 20);
			this.textBox106.TabIndex = 103;
			this.textBox106.Text = "0,00";
			this.textBox106.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox106.Visible = false;
			this.textBox106.Leave += new System.EventHandler(this.textBox106_Leave);
			// 
			// textBox107
			// 
			this.textBox107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox107.Enabled = false;
			this.textBox107.Location = new System.Drawing.Point(656, 280);
			this.textBox107.Name = "textBox107";
			this.textBox107.Size = new System.Drawing.Size(64, 20);
			this.textBox107.TabIndex = 102;
			this.textBox107.Text = "0,00";
			this.textBox107.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox107.Visible = false;
			this.textBox107.Leave += new System.EventHandler(this.textBox107_Leave);
			// 
			// textBox108
			// 
			this.textBox108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox108.Enabled = false;
			this.textBox108.Location = new System.Drawing.Point(592, 280);
			this.textBox108.Name = "textBox108";
			this.textBox108.Size = new System.Drawing.Size(64, 20);
			this.textBox108.TabIndex = 101;
			this.textBox108.Text = "0,00";
			this.textBox108.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox108.Visible = false;
			this.textBox108.Leave += new System.EventHandler(this.textBox108_Leave);
			// 
			// textBox109
			// 
			this.textBox109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox109.Enabled = false;
			this.textBox109.Location = new System.Drawing.Point(528, 280);
			this.textBox109.Name = "textBox109";
			this.textBox109.Size = new System.Drawing.Size(64, 20);
			this.textBox109.TabIndex = 100;
			this.textBox109.Text = "0,00";
			this.textBox109.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox109.Visible = false;
			this.textBox109.Leave += new System.EventHandler(this.textBox109_Leave);
			// 
			// textBox110
			// 
			this.textBox110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox110.Enabled = false;
			this.textBox110.Location = new System.Drawing.Point(464, 280);
			this.textBox110.Name = "textBox110";
			this.textBox110.Size = new System.Drawing.Size(64, 20);
			this.textBox110.TabIndex = 99;
			this.textBox110.Text = "0,00";
			this.textBox110.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox110.Visible = false;
			this.textBox110.Leave += new System.EventHandler(this.textBox110_Leave);
			// 
			// textBox111
			// 
			this.textBox111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox111.Enabled = false;
			this.textBox111.Location = new System.Drawing.Point(328, 280);
			this.textBox111.Name = "textBox111";
			this.textBox111.Size = new System.Drawing.Size(64, 20);
			this.textBox111.TabIndex = 98;
			this.textBox111.Text = "0,00";
			this.textBox111.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox111.Visible = false;
			this.textBox111.Leave += new System.EventHandler(this.textBox111_Leave);
			// 
			// textBox112
			// 
			this.textBox112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox112.Enabled = false;
			this.textBox112.Location = new System.Drawing.Point(264, 280);
			this.textBox112.Name = "textBox112";
			this.textBox112.Size = new System.Drawing.Size(64, 20);
			this.textBox112.TabIndex = 97;
			this.textBox112.Text = "0,00";
			this.textBox112.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox112.Visible = false;
			this.textBox112.Leave += new System.EventHandler(this.textBox112_Leave);
			// 
			// textBox113
			// 
			this.textBox113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox113.Enabled = false;
			this.textBox113.Location = new System.Drawing.Point(200, 280);
			this.textBox113.Name = "textBox113";
			this.textBox113.Size = new System.Drawing.Size(64, 20);
			this.textBox113.TabIndex = 96;
			this.textBox113.Text = "0,00";
			this.textBox113.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox113.Visible = false;
			this.textBox113.Leave += new System.EventHandler(this.textBox113_Leave);
			// 
			// textBox114
			// 
			this.textBox114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox114.Enabled = false;
			this.textBox114.Location = new System.Drawing.Point(136, 280);
			this.textBox114.Name = "textBox114";
			this.textBox114.Size = new System.Drawing.Size(64, 20);
			this.textBox114.TabIndex = 95;
			this.textBox114.Text = "0,00";
			this.textBox114.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox114.Visible = false;
			this.textBox114.Leave += new System.EventHandler(this.textBox114_Leave);
			// 
			// textBox115
			// 
			this.textBox115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox115.Enabled = false;
			this.textBox115.Location = new System.Drawing.Point(72, 280);
			this.textBox115.Name = "textBox115";
			this.textBox115.Size = new System.Drawing.Size(64, 20);
			this.textBox115.TabIndex = 94;
			this.textBox115.Text = "0,00";
			this.textBox115.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox115.Visible = false;
			this.textBox115.Leave += new System.EventHandler(this.textBox115_Leave);
			// 
			// textBox96
			// 
			this.textBox96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox96.Enabled = false;
			this.textBox96.Location = new System.Drawing.Point(720, 256);
			this.textBox96.Name = "textBox96";
			this.textBox96.Size = new System.Drawing.Size(64, 20);
			this.textBox96.TabIndex = 93;
			this.textBox96.Text = "0,00";
			this.textBox96.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox96.Visible = false;
			this.textBox96.Leave += new System.EventHandler(this.textBox96_Leave);
			// 
			// textBox97
			// 
			this.textBox97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox97.Enabled = false;
			this.textBox97.Location = new System.Drawing.Point(656, 256);
			this.textBox97.Name = "textBox97";
			this.textBox97.Size = new System.Drawing.Size(64, 20);
			this.textBox97.TabIndex = 92;
			this.textBox97.Text = "0,00";
			this.textBox97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox97.Visible = false;
			this.textBox97.Leave += new System.EventHandler(this.textBox97_Leave);
			// 
			// textBox98
			// 
			this.textBox98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox98.Enabled = false;
			this.textBox98.Location = new System.Drawing.Point(592, 256);
			this.textBox98.Name = "textBox98";
			this.textBox98.Size = new System.Drawing.Size(64, 20);
			this.textBox98.TabIndex = 91;
			this.textBox98.Text = "0,00";
			this.textBox98.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox98.Visible = false;
			this.textBox98.Leave += new System.EventHandler(this.textBox98_Leave);
			// 
			// textBox99
			// 
			this.textBox99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox99.Enabled = false;
			this.textBox99.Location = new System.Drawing.Point(528, 256);
			this.textBox99.Name = "textBox99";
			this.textBox99.Size = new System.Drawing.Size(64, 20);
			this.textBox99.TabIndex = 90;
			this.textBox99.Text = "0,00";
			this.textBox99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox99.Visible = false;
			this.textBox99.Leave += new System.EventHandler(this.textBox99_Leave);
			// 
			// textBox100
			// 
			this.textBox100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox100.Enabled = false;
			this.textBox100.Location = new System.Drawing.Point(464, 256);
			this.textBox100.Name = "textBox100";
			this.textBox100.Size = new System.Drawing.Size(64, 20);
			this.textBox100.TabIndex = 89;
			this.textBox100.Text = "0,00";
			this.textBox100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox100.Visible = false;
			this.textBox100.Leave += new System.EventHandler(this.textBox100_Leave);
			// 
			// textBox101
			// 
			this.textBox101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox101.Enabled = false;
			this.textBox101.Location = new System.Drawing.Point(328, 256);
			this.textBox101.Name = "textBox101";
			this.textBox101.Size = new System.Drawing.Size(64, 20);
			this.textBox101.TabIndex = 88;
			this.textBox101.Text = "0,00";
			this.textBox101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox101.Visible = false;
			this.textBox101.Leave += new System.EventHandler(this.textBox101_Leave);
			// 
			// textBox102
			// 
			this.textBox102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox102.Enabled = false;
			this.textBox102.Location = new System.Drawing.Point(264, 256);
			this.textBox102.Name = "textBox102";
			this.textBox102.Size = new System.Drawing.Size(64, 20);
			this.textBox102.TabIndex = 87;
			this.textBox102.Text = "0,00";
			this.textBox102.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox102.Visible = false;
			this.textBox102.Leave += new System.EventHandler(this.textBox102_Leave);
			// 
			// textBox103
			// 
			this.textBox103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox103.Enabled = false;
			this.textBox103.Location = new System.Drawing.Point(200, 256);
			this.textBox103.Name = "textBox103";
			this.textBox103.Size = new System.Drawing.Size(64, 20);
			this.textBox103.TabIndex = 86;
			this.textBox103.Text = "0,00";
			this.textBox103.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox103.Visible = false;
			this.textBox103.Leave += new System.EventHandler(this.textBox103_Leave);
			// 
			// textBox104
			// 
			this.textBox104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox104.Enabled = false;
			this.textBox104.Location = new System.Drawing.Point(136, 256);
			this.textBox104.Name = "textBox104";
			this.textBox104.Size = new System.Drawing.Size(64, 20);
			this.textBox104.TabIndex = 85;
			this.textBox104.Text = "0,00";
			this.textBox104.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox104.Visible = false;
			this.textBox104.Leave += new System.EventHandler(this.textBox104_Leave);
			// 
			// textBox105
			// 
			this.textBox105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox105.Enabled = false;
			this.textBox105.Location = new System.Drawing.Point(72, 256);
			this.textBox105.Name = "textBox105";
			this.textBox105.Size = new System.Drawing.Size(64, 20);
			this.textBox105.TabIndex = 84;
			this.textBox105.Text = "0,00";
			this.textBox105.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox105.Visible = false;
			this.textBox105.Leave += new System.EventHandler(this.textBox105_Leave);
			// 
			// textBox86
			// 
			this.textBox86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox86.Enabled = false;
			this.textBox86.Location = new System.Drawing.Point(720, 232);
			this.textBox86.Name = "textBox86";
			this.textBox86.Size = new System.Drawing.Size(64, 20);
			this.textBox86.TabIndex = 83;
			this.textBox86.Text = "0,00";
			this.textBox86.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox86.Visible = false;
			this.textBox86.Leave += new System.EventHandler(this.textBox86_Leave);
			// 
			// textBox87
			// 
			this.textBox87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox87.Enabled = false;
			this.textBox87.Location = new System.Drawing.Point(656, 232);
			this.textBox87.Name = "textBox87";
			this.textBox87.Size = new System.Drawing.Size(64, 20);
			this.textBox87.TabIndex = 82;
			this.textBox87.Text = "0,00";
			this.textBox87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox87.Visible = false;
			this.textBox87.Leave += new System.EventHandler(this.textBox87_Leave);
			// 
			// textBox88
			// 
			this.textBox88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox88.Enabled = false;
			this.textBox88.Location = new System.Drawing.Point(592, 232);
			this.textBox88.Name = "textBox88";
			this.textBox88.Size = new System.Drawing.Size(64, 20);
			this.textBox88.TabIndex = 81;
			this.textBox88.Text = "0,00";
			this.textBox88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox88.Visible = false;
			this.textBox88.Leave += new System.EventHandler(this.textBox88_Leave);
			// 
			// textBox89
			// 
			this.textBox89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox89.Enabled = false;
			this.textBox89.Location = new System.Drawing.Point(528, 232);
			this.textBox89.Name = "textBox89";
			this.textBox89.Size = new System.Drawing.Size(64, 20);
			this.textBox89.TabIndex = 80;
			this.textBox89.Text = "0,00";
			this.textBox89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox89.Visible = false;
			this.textBox89.Leave += new System.EventHandler(this.textBox89_Leave);
			// 
			// textBox90
			// 
			this.textBox90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox90.Enabled = false;
			this.textBox90.Location = new System.Drawing.Point(464, 232);
			this.textBox90.Name = "textBox90";
			this.textBox90.Size = new System.Drawing.Size(64, 20);
			this.textBox90.TabIndex = 79;
			this.textBox90.Text = "0,00";
			this.textBox90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox90.Visible = false;
			this.textBox90.Leave += new System.EventHandler(this.textBox90_Leave);
			// 
			// textBox91
			// 
			this.textBox91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox91.Enabled = false;
			this.textBox91.Location = new System.Drawing.Point(328, 232);
			this.textBox91.Name = "textBox91";
			this.textBox91.Size = new System.Drawing.Size(64, 20);
			this.textBox91.TabIndex = 78;
			this.textBox91.Text = "0,00";
			this.textBox91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox91.Visible = false;
			this.textBox91.Leave += new System.EventHandler(this.textBox91_Leave);
			// 
			// textBox92
			// 
			this.textBox92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox92.Enabled = false;
			this.textBox92.Location = new System.Drawing.Point(264, 232);
			this.textBox92.Name = "textBox92";
			this.textBox92.Size = new System.Drawing.Size(64, 20);
			this.textBox92.TabIndex = 77;
			this.textBox92.Text = "0,00";
			this.textBox92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox92.Visible = false;
			this.textBox92.Leave += new System.EventHandler(this.textBox92_Leave);
			// 
			// textBox93
			// 
			this.textBox93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox93.Enabled = false;
			this.textBox93.Location = new System.Drawing.Point(200, 232);
			this.textBox93.Name = "textBox93";
			this.textBox93.Size = new System.Drawing.Size(64, 20);
			this.textBox93.TabIndex = 76;
			this.textBox93.Text = "0,00";
			this.textBox93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox93.Visible = false;
			this.textBox93.Leave += new System.EventHandler(this.textBox93_Leave);
			// 
			// textBox94
			// 
			this.textBox94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox94.Enabled = false;
			this.textBox94.Location = new System.Drawing.Point(136, 232);
			this.textBox94.Name = "textBox94";
			this.textBox94.Size = new System.Drawing.Size(64, 20);
			this.textBox94.TabIndex = 75;
			this.textBox94.Text = "0,00";
			this.textBox94.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox94.Visible = false;
			this.textBox94.Leave += new System.EventHandler(this.textBox94_Leave);
			// 
			// textBox95
			// 
			this.textBox95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox95.Enabled = false;
			this.textBox95.Location = new System.Drawing.Point(72, 232);
			this.textBox95.Name = "textBox95";
			this.textBox95.Size = new System.Drawing.Size(64, 20);
			this.textBox95.TabIndex = 74;
			this.textBox95.Text = "0,00";
			this.textBox95.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox95.Visible = false;
			this.textBox95.Leave += new System.EventHandler(this.textBox95_Leave);
			// 
			// textBox76
			// 
			this.textBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox76.Enabled = false;
			this.textBox76.Location = new System.Drawing.Point(720, 208);
			this.textBox76.Name = "textBox76";
			this.textBox76.Size = new System.Drawing.Size(64, 20);
			this.textBox76.TabIndex = 73;
			this.textBox76.Text = "0,00";
			this.textBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox76.Visible = false;
			this.textBox76.Leave += new System.EventHandler(this.textBox76_Leave);
			// 
			// textBox77
			// 
			this.textBox77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox77.Enabled = false;
			this.textBox77.Location = new System.Drawing.Point(656, 208);
			this.textBox77.Name = "textBox77";
			this.textBox77.Size = new System.Drawing.Size(64, 20);
			this.textBox77.TabIndex = 72;
			this.textBox77.Text = "0,00";
			this.textBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox77.Visible = false;
			this.textBox77.Leave += new System.EventHandler(this.textBox77_Leave);
			// 
			// textBox78
			// 
			this.textBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox78.Enabled = false;
			this.textBox78.Location = new System.Drawing.Point(592, 208);
			this.textBox78.Name = "textBox78";
			this.textBox78.Size = new System.Drawing.Size(64, 20);
			this.textBox78.TabIndex = 71;
			this.textBox78.Text = "0,00";
			this.textBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox78.Visible = false;
			this.textBox78.Leave += new System.EventHandler(this.textBox78_Leave);
			// 
			// textBox79
			// 
			this.textBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox79.Enabled = false;
			this.textBox79.Location = new System.Drawing.Point(528, 208);
			this.textBox79.Name = "textBox79";
			this.textBox79.Size = new System.Drawing.Size(64, 20);
			this.textBox79.TabIndex = 70;
			this.textBox79.Text = "0,00";
			this.textBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox79.Visible = false;
			this.textBox79.Leave += new System.EventHandler(this.textBox79_Leave);
			// 
			// textBox80
			// 
			this.textBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox80.Enabled = false;
			this.textBox80.Location = new System.Drawing.Point(464, 208);
			this.textBox80.Name = "textBox80";
			this.textBox80.Size = new System.Drawing.Size(64, 20);
			this.textBox80.TabIndex = 69;
			this.textBox80.Text = "0,00";
			this.textBox80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox80.Visible = false;
			this.textBox80.Leave += new System.EventHandler(this.textBox80_Leave);
			// 
			// textBox81
			// 
			this.textBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox81.Enabled = false;
			this.textBox81.Location = new System.Drawing.Point(328, 208);
			this.textBox81.Name = "textBox81";
			this.textBox81.Size = new System.Drawing.Size(64, 20);
			this.textBox81.TabIndex = 68;
			this.textBox81.Text = "0,00";
			this.textBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox81.Visible = false;
			this.textBox81.Leave += new System.EventHandler(this.textBox81_Leave);
			// 
			// textBox82
			// 
			this.textBox82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox82.Enabled = false;
			this.textBox82.Location = new System.Drawing.Point(264, 208);
			this.textBox82.Name = "textBox82";
			this.textBox82.Size = new System.Drawing.Size(64, 20);
			this.textBox82.TabIndex = 67;
			this.textBox82.Text = "0,00";
			this.textBox82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox82.Visible = false;
			this.textBox82.Leave += new System.EventHandler(this.textBox82_Leave);
			// 
			// textBox83
			// 
			this.textBox83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox83.Enabled = false;
			this.textBox83.Location = new System.Drawing.Point(200, 208);
			this.textBox83.Name = "textBox83";
			this.textBox83.Size = new System.Drawing.Size(64, 20);
			this.textBox83.TabIndex = 66;
			this.textBox83.Text = "0,00";
			this.textBox83.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox83.Visible = false;
			this.textBox83.Leave += new System.EventHandler(this.textBox83_Leave);
			// 
			// textBox84
			// 
			this.textBox84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox84.Enabled = false;
			this.textBox84.Location = new System.Drawing.Point(136, 208);
			this.textBox84.Name = "textBox84";
			this.textBox84.Size = new System.Drawing.Size(64, 20);
			this.textBox84.TabIndex = 65;
			this.textBox84.Text = "0,00";
			this.textBox84.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox84.Visible = false;
			this.textBox84.Leave += new System.EventHandler(this.textBox84_Leave);
			// 
			// textBox85
			// 
			this.textBox85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox85.Enabled = false;
			this.textBox85.Location = new System.Drawing.Point(72, 208);
			this.textBox85.Name = "textBox85";
			this.textBox85.Size = new System.Drawing.Size(64, 20);
			this.textBox85.TabIndex = 64;
			this.textBox85.Text = "0,00";
			this.textBox85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox85.Visible = false;
			this.textBox85.Leave += new System.EventHandler(this.textBox85_Leave);
			// 
			// textBox66
			// 
			this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox66.Enabled = false;
			this.textBox66.Location = new System.Drawing.Point(720, 184);
			this.textBox66.Name = "textBox66";
			this.textBox66.Size = new System.Drawing.Size(64, 20);
			this.textBox66.TabIndex = 63;
			this.textBox66.Text = "0,00";
			this.textBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox66.Visible = false;
			this.textBox66.Leave += new System.EventHandler(this.textBox66_Leave);
			// 
			// textBox67
			// 
			this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox67.Enabled = false;
			this.textBox67.Location = new System.Drawing.Point(656, 184);
			this.textBox67.Name = "textBox67";
			this.textBox67.Size = new System.Drawing.Size(64, 20);
			this.textBox67.TabIndex = 62;
			this.textBox67.Text = "0,00";
			this.textBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox67.Visible = false;
			this.textBox67.Leave += new System.EventHandler(this.textBox67_Leave);
			// 
			// textBox68
			// 
			this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox68.Enabled = false;
			this.textBox68.Location = new System.Drawing.Point(592, 184);
			this.textBox68.Name = "textBox68";
			this.textBox68.Size = new System.Drawing.Size(64, 20);
			this.textBox68.TabIndex = 61;
			this.textBox68.Text = "0,00";
			this.textBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox68.Visible = false;
			this.textBox68.Leave += new System.EventHandler(this.textBox68_Leave);
			// 
			// textBox69
			// 
			this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox69.Enabled = false;
			this.textBox69.Location = new System.Drawing.Point(528, 184);
			this.textBox69.Name = "textBox69";
			this.textBox69.Size = new System.Drawing.Size(64, 20);
			this.textBox69.TabIndex = 60;
			this.textBox69.Text = "0,00";
			this.textBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox69.Visible = false;
			this.textBox69.Leave += new System.EventHandler(this.textBox69_Leave);
			// 
			// textBox70
			// 
			this.textBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox70.Enabled = false;
			this.textBox70.Location = new System.Drawing.Point(464, 184);
			this.textBox70.Name = "textBox70";
			this.textBox70.Size = new System.Drawing.Size(64, 20);
			this.textBox70.TabIndex = 59;
			this.textBox70.Text = "0,00";
			this.textBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox70.Visible = false;
			this.textBox70.Leave += new System.EventHandler(this.textBox70_Leave);
			// 
			// textBox71
			// 
			this.textBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox71.Enabled = false;
			this.textBox71.Location = new System.Drawing.Point(328, 184);
			this.textBox71.Name = "textBox71";
			this.textBox71.Size = new System.Drawing.Size(64, 20);
			this.textBox71.TabIndex = 58;
			this.textBox71.Text = "0,00";
			this.textBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox71.Visible = false;
			this.textBox71.Leave += new System.EventHandler(this.textBox71_Leave);
			// 
			// textBox72
			// 
			this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox72.Enabled = false;
			this.textBox72.Location = new System.Drawing.Point(264, 184);
			this.textBox72.Name = "textBox72";
			this.textBox72.Size = new System.Drawing.Size(64, 20);
			this.textBox72.TabIndex = 57;
			this.textBox72.Text = "0,00";
			this.textBox72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox72.Visible = false;
			this.textBox72.Leave += new System.EventHandler(this.textBox72_Leave);
			// 
			// textBox73
			// 
			this.textBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox73.Enabled = false;
			this.textBox73.Location = new System.Drawing.Point(200, 184);
			this.textBox73.Name = "textBox73";
			this.textBox73.Size = new System.Drawing.Size(64, 20);
			this.textBox73.TabIndex = 56;
			this.textBox73.Text = "0,00";
			this.textBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox73.Visible = false;
			this.textBox73.Leave += new System.EventHandler(this.textBox73_Leave);
			// 
			// textBox74
			// 
			this.textBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox74.Enabled = false;
			this.textBox74.Location = new System.Drawing.Point(136, 184);
			this.textBox74.Name = "textBox74";
			this.textBox74.Size = new System.Drawing.Size(64, 20);
			this.textBox74.TabIndex = 55;
			this.textBox74.Text = "0,00";
			this.textBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox74.Visible = false;
			this.textBox74.Leave += new System.EventHandler(this.textBox74_Leave);
			// 
			// textBox75
			// 
			this.textBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox75.Enabled = false;
			this.textBox75.Location = new System.Drawing.Point(72, 184);
			this.textBox75.Name = "textBox75";
			this.textBox75.Size = new System.Drawing.Size(64, 20);
			this.textBox75.TabIndex = 54;
			this.textBox75.Text = "0,00";
			this.textBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox75.Visible = false;
			this.textBox75.Leave += new System.EventHandler(this.textBox75_Leave);
			// 
			// textBox56
			// 
			this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox56.Enabled = false;
			this.textBox56.Location = new System.Drawing.Point(720, 160);
			this.textBox56.Name = "textBox56";
			this.textBox56.Size = new System.Drawing.Size(64, 20);
			this.textBox56.TabIndex = 53;
			this.textBox56.Text = "0,00";
			this.textBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox56.Visible = false;
			this.textBox56.Leave += new System.EventHandler(this.textBox56_Leave);
			// 
			// textBox57
			// 
			this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox57.Enabled = false;
			this.textBox57.Location = new System.Drawing.Point(656, 160);
			this.textBox57.Name = "textBox57";
			this.textBox57.Size = new System.Drawing.Size(64, 20);
			this.textBox57.TabIndex = 52;
			this.textBox57.Text = "0,00";
			this.textBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox57.Visible = false;
			this.textBox57.Leave += new System.EventHandler(this.textBox57_Leave);
			// 
			// textBox58
			// 
			this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox58.Enabled = false;
			this.textBox58.Location = new System.Drawing.Point(592, 160);
			this.textBox58.Name = "textBox58";
			this.textBox58.Size = new System.Drawing.Size(64, 20);
			this.textBox58.TabIndex = 51;
			this.textBox58.Text = "0,00";
			this.textBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox58.Visible = false;
			this.textBox58.Leave += new System.EventHandler(this.textBox58_Leave);
			// 
			// textBox59
			// 
			this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox59.Enabled = false;
			this.textBox59.Location = new System.Drawing.Point(528, 160);
			this.textBox59.Name = "textBox59";
			this.textBox59.Size = new System.Drawing.Size(64, 20);
			this.textBox59.TabIndex = 50;
			this.textBox59.Text = "0,00";
			this.textBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox59.Visible = false;
			this.textBox59.Leave += new System.EventHandler(this.textBox59_Leave);
			// 
			// textBox60
			// 
			this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox60.Enabled = false;
			this.textBox60.Location = new System.Drawing.Point(464, 160);
			this.textBox60.Name = "textBox60";
			this.textBox60.Size = new System.Drawing.Size(64, 20);
			this.textBox60.TabIndex = 49;
			this.textBox60.Text = "0,00";
			this.textBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox60.Visible = false;
			this.textBox60.Leave += new System.EventHandler(this.textBox60_Leave);
			// 
			// textBox61
			// 
			this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox61.Enabled = false;
			this.textBox61.Location = new System.Drawing.Point(328, 160);
			this.textBox61.Name = "textBox61";
			this.textBox61.Size = new System.Drawing.Size(64, 20);
			this.textBox61.TabIndex = 48;
			this.textBox61.Text = "0,00";
			this.textBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox61.Visible = false;
			this.textBox61.Leave += new System.EventHandler(this.textBox61_Leave);
			// 
			// textBox62
			// 
			this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox62.Enabled = false;
			this.textBox62.Location = new System.Drawing.Point(264, 160);
			this.textBox62.Name = "textBox62";
			this.textBox62.Size = new System.Drawing.Size(64, 20);
			this.textBox62.TabIndex = 47;
			this.textBox62.Text = "0,00";
			this.textBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox62.Visible = false;
			this.textBox62.Leave += new System.EventHandler(this.textBox62_Leave);
			// 
			// textBox63
			// 
			this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox63.Enabled = false;
			this.textBox63.Location = new System.Drawing.Point(200, 160);
			this.textBox63.Name = "textBox63";
			this.textBox63.Size = new System.Drawing.Size(64, 20);
			this.textBox63.TabIndex = 46;
			this.textBox63.Text = "0,00";
			this.textBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox63.Visible = false;
			this.textBox63.Leave += new System.EventHandler(this.textBox63_Leave);
			// 
			// textBox64
			// 
			this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox64.Enabled = false;
			this.textBox64.Location = new System.Drawing.Point(136, 160);
			this.textBox64.Name = "textBox64";
			this.textBox64.Size = new System.Drawing.Size(64, 20);
			this.textBox64.TabIndex = 45;
			this.textBox64.Text = "0,00";
			this.textBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox64.Visible = false;
			this.textBox64.Leave += new System.EventHandler(this.textBox64_Leave);
			// 
			// textBox65
			// 
			this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox65.Enabled = false;
			this.textBox65.Location = new System.Drawing.Point(72, 160);
			this.textBox65.Name = "textBox65";
			this.textBox65.Size = new System.Drawing.Size(64, 20);
			this.textBox65.TabIndex = 44;
			this.textBox65.Text = "0,00";
			this.textBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox65.Visible = false;
			this.textBox65.Leave += new System.EventHandler(this.textBox65_Leave);
			// 
			// textBox46
			// 
			this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox46.Enabled = false;
			this.textBox46.Location = new System.Drawing.Point(720, 136);
			this.textBox46.Name = "textBox46";
			this.textBox46.Size = new System.Drawing.Size(64, 20);
			this.textBox46.TabIndex = 43;
			this.textBox46.Text = "0,00";
			this.textBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox46.Visible = false;
			this.textBox46.Leave += new System.EventHandler(this.textBox46_Leave);
			// 
			// textBox47
			// 
			this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox47.Enabled = false;
			this.textBox47.Location = new System.Drawing.Point(656, 136);
			this.textBox47.Name = "textBox47";
			this.textBox47.Size = new System.Drawing.Size(64, 20);
			this.textBox47.TabIndex = 42;
			this.textBox47.Text = "0,00";
			this.textBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox47.Visible = false;
			this.textBox47.Leave += new System.EventHandler(this.textBox47_Leave);
			// 
			// textBox48
			// 
			this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox48.Enabled = false;
			this.textBox48.Location = new System.Drawing.Point(592, 136);
			this.textBox48.Name = "textBox48";
			this.textBox48.Size = new System.Drawing.Size(64, 20);
			this.textBox48.TabIndex = 41;
			this.textBox48.Text = "0,00";
			this.textBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox48.Visible = false;
			this.textBox48.Leave += new System.EventHandler(this.textBox48_Leave);
			// 
			// textBox49
			// 
			this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox49.Enabled = false;
			this.textBox49.Location = new System.Drawing.Point(528, 136);
			this.textBox49.Name = "textBox49";
			this.textBox49.Size = new System.Drawing.Size(64, 20);
			this.textBox49.TabIndex = 40;
			this.textBox49.Text = "0,00";
			this.textBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox49.Visible = false;
			this.textBox49.Leave += new System.EventHandler(this.textBox49_Leave);
			// 
			// textBox50
			// 
			this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox50.Enabled = false;
			this.textBox50.Location = new System.Drawing.Point(464, 136);
			this.textBox50.Name = "textBox50";
			this.textBox50.Size = new System.Drawing.Size(64, 20);
			this.textBox50.TabIndex = 39;
			this.textBox50.Text = "0,00";
			this.textBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox50.Visible = false;
			this.textBox50.Leave += new System.EventHandler(this.textBox50_Leave);
			// 
			// textBox51
			// 
			this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox51.Enabled = false;
			this.textBox51.Location = new System.Drawing.Point(328, 136);
			this.textBox51.Name = "textBox51";
			this.textBox51.Size = new System.Drawing.Size(64, 20);
			this.textBox51.TabIndex = 38;
			this.textBox51.Text = "0,00";
			this.textBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox51.Visible = false;
			this.textBox51.Leave += new System.EventHandler(this.textBox51_Leave);
			// 
			// textBox52
			// 
			this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox52.Enabled = false;
			this.textBox52.Location = new System.Drawing.Point(264, 136);
			this.textBox52.Name = "textBox52";
			this.textBox52.Size = new System.Drawing.Size(64, 20);
			this.textBox52.TabIndex = 37;
			this.textBox52.Text = "0,00";
			this.textBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox52.Visible = false;
			this.textBox52.Leave += new System.EventHandler(this.textBox52_Leave);
			// 
			// textBox53
			// 
			this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox53.Enabled = false;
			this.textBox53.Location = new System.Drawing.Point(200, 136);
			this.textBox53.Name = "textBox53";
			this.textBox53.Size = new System.Drawing.Size(64, 20);
			this.textBox53.TabIndex = 36;
			this.textBox53.Text = "0,00";
			this.textBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox53.Visible = false;
			this.textBox53.Leave += new System.EventHandler(this.textBox53_Leave);
			// 
			// textBox54
			// 
			this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox54.Enabled = false;
			this.textBox54.Location = new System.Drawing.Point(136, 136);
			this.textBox54.Name = "textBox54";
			this.textBox54.Size = new System.Drawing.Size(64, 20);
			this.textBox54.TabIndex = 35;
			this.textBox54.Text = "0,00";
			this.textBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox54.Visible = false;
			this.textBox54.Leave += new System.EventHandler(this.textBox54_Leave);
			// 
			// textBox55
			// 
			this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox55.Enabled = false;
			this.textBox55.Location = new System.Drawing.Point(72, 136);
			this.textBox55.Name = "textBox55";
			this.textBox55.Size = new System.Drawing.Size(64, 20);
			this.textBox55.TabIndex = 34;
			this.textBox55.Text = "0,00";
			this.textBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox55.Visible = false;
			this.textBox55.Leave += new System.EventHandler(this.textBox55_Leave);
			// 
			// textBox36
			// 
			this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox36.Enabled = false;
			this.textBox36.Location = new System.Drawing.Point(720, 112);
			this.textBox36.Name = "textBox36";
			this.textBox36.Size = new System.Drawing.Size(64, 20);
			this.textBox36.TabIndex = 33;
			this.textBox36.Text = "0,00";
			this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox36.Leave += new System.EventHandler(this.textBox36_Leave);
			// 
			// textBox37
			// 
			this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox37.Enabled = false;
			this.textBox37.Location = new System.Drawing.Point(656, 112);
			this.textBox37.Name = "textBox37";
			this.textBox37.Size = new System.Drawing.Size(64, 20);
			this.textBox37.TabIndex = 32;
			this.textBox37.Text = "0,00";
			this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox37.Leave += new System.EventHandler(this.textBox37_Leave);
			// 
			// textBox38
			// 
			this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox38.Enabled = false;
			this.textBox38.Location = new System.Drawing.Point(592, 112);
			this.textBox38.Name = "textBox38";
			this.textBox38.Size = new System.Drawing.Size(64, 20);
			this.textBox38.TabIndex = 31;
			this.textBox38.Text = "0,00";
			this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox38.Leave += new System.EventHandler(this.textBox38_Leave);
			// 
			// textBox39
			// 
			this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox39.Enabled = false;
			this.textBox39.Location = new System.Drawing.Point(528, 112);
			this.textBox39.Name = "textBox39";
			this.textBox39.Size = new System.Drawing.Size(64, 20);
			this.textBox39.TabIndex = 30;
			this.textBox39.Text = "0,00";
			this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox39.Leave += new System.EventHandler(this.textBox39_Leave);
			// 
			// textBox40
			// 
			this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox40.Enabled = false;
			this.textBox40.Location = new System.Drawing.Point(464, 112);
			this.textBox40.Name = "textBox40";
			this.textBox40.Size = new System.Drawing.Size(64, 20);
			this.textBox40.TabIndex = 29;
			this.textBox40.Text = "0,00";
			this.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox40.Leave += new System.EventHandler(this.textBox40_Leave);
			// 
			// textBox41
			// 
			this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox41.Enabled = false;
			this.textBox41.Location = new System.Drawing.Point(328, 112);
			this.textBox41.Name = "textBox41";
			this.textBox41.Size = new System.Drawing.Size(64, 20);
			this.textBox41.TabIndex = 28;
			this.textBox41.Text = "0,00";
			this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox41.Leave += new System.EventHandler(this.textBox41_Leave);
			// 
			// textBox42
			// 
			this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox42.Enabled = false;
			this.textBox42.Location = new System.Drawing.Point(264, 112);
			this.textBox42.Name = "textBox42";
			this.textBox42.Size = new System.Drawing.Size(64, 20);
			this.textBox42.TabIndex = 27;
			this.textBox42.Text = "0,00";
			this.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox42.Leave += new System.EventHandler(this.textBox42_Leave);
			// 
			// textBox43
			// 
			this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox43.Enabled = false;
			this.textBox43.Location = new System.Drawing.Point(200, 112);
			this.textBox43.Name = "textBox43";
			this.textBox43.Size = new System.Drawing.Size(64, 20);
			this.textBox43.TabIndex = 26;
			this.textBox43.Text = "0,00";
			this.textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox43.Leave += new System.EventHandler(this.textBox43_Leave);
			// 
			// textBox44
			// 
			this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox44.Enabled = false;
			this.textBox44.Location = new System.Drawing.Point(136, 112);
			this.textBox44.Name = "textBox44";
			this.textBox44.Size = new System.Drawing.Size(64, 20);
			this.textBox44.TabIndex = 25;
			this.textBox44.Text = "0,00";
			this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox44.Leave += new System.EventHandler(this.textBox44_Leave);
			// 
			// textBox45
			// 
			this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox45.Enabled = false;
			this.textBox45.Location = new System.Drawing.Point(72, 112);
			this.textBox45.Name = "textBox45";
			this.textBox45.Size = new System.Drawing.Size(64, 20);
			this.textBox45.TabIndex = 24;
			this.textBox45.Text = "0,00";
			this.textBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox45.Leave += new System.EventHandler(this.textBox45_Leave);
			// 
			// textBox26
			// 
			this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox26.Enabled = false;
			this.textBox26.Location = new System.Drawing.Point(720, 88);
			this.textBox26.Name = "textBox26";
			this.textBox26.Size = new System.Drawing.Size(64, 20);
			this.textBox26.TabIndex = 23;
			this.textBox26.Text = "0,00";
			this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox26.Leave += new System.EventHandler(this.textBox26_Leave);
			// 
			// textBox27
			// 
			this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox27.Enabled = false;
			this.textBox27.Location = new System.Drawing.Point(656, 88);
			this.textBox27.Name = "textBox27";
			this.textBox27.Size = new System.Drawing.Size(64, 20);
			this.textBox27.TabIndex = 22;
			this.textBox27.Text = "0,00";
			this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox27.Leave += new System.EventHandler(this.textBox27_Leave);
			// 
			// textBox28
			// 
			this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox28.Enabled = false;
			this.textBox28.Location = new System.Drawing.Point(592, 88);
			this.textBox28.Name = "textBox28";
			this.textBox28.Size = new System.Drawing.Size(64, 20);
			this.textBox28.TabIndex = 21;
			this.textBox28.Text = "0,00";
			this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox28.Leave += new System.EventHandler(this.textBox28_Leave);
			// 
			// textBox29
			// 
			this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox29.Enabled = false;
			this.textBox29.Location = new System.Drawing.Point(528, 88);
			this.textBox29.Name = "textBox29";
			this.textBox29.Size = new System.Drawing.Size(64, 20);
			this.textBox29.TabIndex = 20;
			this.textBox29.Text = "0,00";
			this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox29.Leave += new System.EventHandler(this.textBox29_Leave);
			// 
			// textBox30
			// 
			this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox30.Enabled = false;
			this.textBox30.Location = new System.Drawing.Point(464, 88);
			this.textBox30.Name = "textBox30";
			this.textBox30.Size = new System.Drawing.Size(64, 20);
			this.textBox30.TabIndex = 19;
			this.textBox30.Text = "0,00";
			this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox30.Leave += new System.EventHandler(this.textBox30_Leave);
			// 
			// textBox31
			// 
			this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox31.Enabled = false;
			this.textBox31.Location = new System.Drawing.Point(328, 88);
			this.textBox31.Name = "textBox31";
			this.textBox31.Size = new System.Drawing.Size(64, 20);
			this.textBox31.TabIndex = 18;
			this.textBox31.Text = "0,00";
			this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox31.Leave += new System.EventHandler(this.textBox31_Leave);
			// 
			// textBox32
			// 
			this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox32.Enabled = false;
			this.textBox32.Location = new System.Drawing.Point(264, 88);
			this.textBox32.Name = "textBox32";
			this.textBox32.Size = new System.Drawing.Size(64, 20);
			this.textBox32.TabIndex = 17;
			this.textBox32.Text = "0,00";
			this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox32.Leave += new System.EventHandler(this.textBox32_Leave);
			// 
			// textBox33
			// 
			this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox33.Enabled = false;
			this.textBox33.Location = new System.Drawing.Point(200, 88);
			this.textBox33.Name = "textBox33";
			this.textBox33.Size = new System.Drawing.Size(64, 20);
			this.textBox33.TabIndex = 16;
			this.textBox33.Text = "0,00";
			this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox33.Leave += new System.EventHandler(this.textBox33_Leave);
			// 
			// textBox34
			// 
			this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox34.Enabled = false;
			this.textBox34.Location = new System.Drawing.Point(136, 88);
			this.textBox34.Name = "textBox34";
			this.textBox34.Size = new System.Drawing.Size(64, 20);
			this.textBox34.TabIndex = 15;
			this.textBox34.Text = "0,00";
			this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox34.Leave += new System.EventHandler(this.textBox34_Leave);
			// 
			// textBox35
			// 
			this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox35.Enabled = false;
			this.textBox35.Location = new System.Drawing.Point(72, 88);
			this.textBox35.Name = "textBox35";
			this.textBox35.Size = new System.Drawing.Size(64, 20);
			this.textBox35.TabIndex = 14;
			this.textBox35.Text = "0,00";
			this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox35.Leave += new System.EventHandler(this.textBox35_Leave);
			// 
			// textBox25
			// 
			this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox25.Enabled = false;
			this.textBox25.Location = new System.Drawing.Point(720, 64);
			this.textBox25.Name = "textBox25";
			this.textBox25.Size = new System.Drawing.Size(64, 20);
			this.textBox25.TabIndex = 13;
			this.textBox25.Text = "0,00";
			this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox25.Leave += new System.EventHandler(this.textBox25_Leave);
			// 
			// textBox24
			// 
			this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox24.Enabled = false;
			this.textBox24.Location = new System.Drawing.Point(656, 64);
			this.textBox24.Name = "textBox24";
			this.textBox24.Size = new System.Drawing.Size(64, 20);
			this.textBox24.TabIndex = 12;
			this.textBox24.Text = "0,00";
			this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox24.Leave += new System.EventHandler(this.textBox24_Leave);
			// 
			// textBox23
			// 
			this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox23.Enabled = false;
			this.textBox23.Location = new System.Drawing.Point(592, 64);
			this.textBox23.Name = "textBox23";
			this.textBox23.Size = new System.Drawing.Size(64, 20);
			this.textBox23.TabIndex = 11;
			this.textBox23.Text = "0,00";
			this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox23.Leave += new System.EventHandler(this.textBox23_Leave);
			// 
			// textBox22
			// 
			this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox22.Enabled = false;
			this.textBox22.Location = new System.Drawing.Point(528, 64);
			this.textBox22.Name = "textBox22";
			this.textBox22.Size = new System.Drawing.Size(64, 20);
			this.textBox22.TabIndex = 10;
			this.textBox22.Text = "0,00";
			this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox22.Leave += new System.EventHandler(this.textBox22_Leave);
			// 
			// textBox21
			// 
			this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox21.Enabled = false;
			this.textBox21.Location = new System.Drawing.Point(464, 64);
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new System.Drawing.Size(64, 20);
			this.textBox21.TabIndex = 9;
			this.textBox21.Text = "0,00";
			this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox21.Leave += new System.EventHandler(this.textBox21_Leave);
			// 
			// textBox20
			// 
			this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox20.Enabled = false;
			this.textBox20.Location = new System.Drawing.Point(328, 64);
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new System.Drawing.Size(64, 20);
			this.textBox20.TabIndex = 8;
			this.textBox20.Text = "0,00";
			this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox20.Leave += new System.EventHandler(this.textBox20_Leave);
			// 
			// textBox19
			// 
			this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox19.Enabled = false;
			this.textBox19.Location = new System.Drawing.Point(264, 64);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(64, 20);
			this.textBox19.TabIndex = 7;
			this.textBox19.Text = "0,00";
			this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox19.Leave += new System.EventHandler(this.textBox19_Leave);
			// 
			// textBox18
			// 
			this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox18.Enabled = false;
			this.textBox18.Location = new System.Drawing.Point(200, 64);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(64, 20);
			this.textBox18.TabIndex = 6;
			this.textBox18.Text = "0,00";
			this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox18.Leave += new System.EventHandler(this.textBox18_Leave);
			// 
			// textBox17
			// 
			this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox17.Enabled = false;
			this.textBox17.Location = new System.Drawing.Point(136, 64);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(64, 20);
			this.textBox17.TabIndex = 5;
			this.textBox17.Text = "0,00";
			this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox17.Leave += new System.EventHandler(this.textBox17_Leave);
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(200, 40);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(64, 23);
			this.label29.TabIndex = 113;
			this.label29.Text = "M3";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(307, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbSelectCommand6
			// 
			this.oleDbSelectCommand6.CommandText = @"SELECT Adresse_1, Adresse_2, Batiment, [Borne Date Refus reforme], CA_Annee, CA_Annee_1, CA_Annee_2, CA_Annee_3, CA_Annee_4, code_GC, Code_Postal, Code_reglement, Code_transport, Coef_Controle, Coef_DNR, Coef_transport, Commentaire, Delai_garantie, Forfait_Controle, Forfait_DNR, Forfait_transport, Groupe, Ident, [N°_Cde_Ouverte], [N°_Client_facture], Nom, Nombre_rep_Annee, Nombre_rep_Annee_1, Nombre_rep_Annee_2, Nombre_rep_Annee_3, Nombre_rep_Annee_4, Notre_Code_Fournisseur, Pays, Pourcentage_remise, Seuil_reparation, telecopie, Telephone, telex, Usine, Ville FROM T_clients";
			this.oleDbSelectCommand6.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand6
			// 
			this.oleDbInsertCommand6.CommandText = @"INSERT INTO T_clients(Adresse_1, Adresse_2, Batiment, [Borne Date Refus reforme], CA_Annee, CA_Annee_1, CA_Annee_2, CA_Annee_3, CA_Annee_4, code_GC, Code_Postal, Code_reglement, Code_transport, Coef_Controle, Coef_DNR, Coef_transport, Commentaire, Delai_garantie, Forfait_Controle, Forfait_DNR, Forfait_transport, Groupe, Ident, [N°_Cde_Ouverte], [N°_Client_facture], Nom, Nombre_rep_Annee, Nombre_rep_Annee_1, Nombre_rep_Annee_2, Nombre_rep_Annee_3, Nombre_rep_Annee_4, Notre_Code_Fournisseur, Pays, Pourcentage_remise, Seuil_reparation, telecopie, Telephone, telex, Usine, Ville) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_2"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Borne Date Refus reforme"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_1"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_2"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_3"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_4"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, "code_GC"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_reglement"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_transport"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, "Coef_Controle"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, "Coef_DNR"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_transport", System.Data.OleDb.OleDbType.Double, 0, "Coef_transport"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai_garantie"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait_Controle"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait_DNR"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait_transport"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, "N°_Cde_Ouverte"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, "N°_Client_facture"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_1"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_2"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_3"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_4"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, "Notre_Code_Fournisseur"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage_remise"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, "Seuil_reparation"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("telex", System.Data.OleDb.OleDbType.VarWChar, 255, "telex"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			// 
			// oleDbUpdateCommand6
			// 
			this.oleDbUpdateCommand6.CommandText = "UPDATE T_clients SET Adresse_1 = ?, Adresse_2 = ?, Batiment = ?, [Borne Date Refu" +
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
			this.oleDbUpdateCommand6.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_2"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Borne Date Refus reforme"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_1"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_2"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_3"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_4"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, "code_GC"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_reglement"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_transport"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, "Coef_Controle"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, "Coef_DNR"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_transport", System.Data.OleDb.OleDbType.Double, 0, "Coef_transport"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai_garantie"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait_Controle"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait_DNR"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait_transport"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, "N°_Cde_Ouverte"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, "N°_Client_facture"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_1"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_2"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_3"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_4"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, "Notre_Code_Fournisseur"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage_remise"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, "Seuil_reparation"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("telex", System.Data.OleDb.OleDbType.VarWChar, 255, "telex"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture1", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand6
			// 
			this.oleDbDeleteCommand6.CommandText = "DELETE FROM T_clients WHERE (Ident = ?) AND (Adresse_1 = ? OR ? IS NULL AND Adres" +
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
			this.oleDbDeleteCommand6.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CA_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_reglement1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_transport1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Client_facture1", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_code_GC1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "telex", System.Data.DataRowVersion.Original, null));
			// 
			// txDateDernierControle
			// 
			this.txDateDernierControle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.txDateDernierControle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txDateDernierControle.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.txDateDernierControle.Location = new System.Drawing.Point(808, 640);
			this.txDateDernierControle.Name = "txDateDernierControle";
			this.txDateDernierControle.TabIndex = 11;
			this.txDateDernierControle.TabStop = false;
			this.txDateDernierControle.Text = "";
			// 
			// ControlesCAM
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(924, 688);
			this.ControlBox = false;
			this.Controls.Add(this.txDateDernierControle);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ControlesCAM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controles CAM";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button4_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton2.Checked.Equals(true))
			{
				textBox116.Text="Contrôle 50 mesures";
				textBox16.Visible=true;
				textBox17.Visible=true;
				textBox18.Visible=true;
				textBox19.Visible=true;
				textBox20.Visible=true;
				textBox21.Visible=true;
				textBox22.Visible=true;
				textBox23.Visible=true;
				textBox24.Visible=true;
				textBox25.Visible=true;
				textBox26.Visible=true;
				textBox27.Visible=true;
				textBox28.Visible=true;
				textBox29.Visible=true;
				textBox30.Visible=true;
				textBox31.Visible=true;
				textBox32.Visible=true;
				textBox33.Visible=true;
				textBox34.Visible=true;
				textBox35.Visible=true;
				textBox36.Visible=true;
				textBox37.Visible=true;
				textBox38.Visible=true;
				textBox39.Visible=true;
				textBox40.Visible=true;
				textBox41.Visible=true;
				textBox42.Visible=true;
				textBox43.Visible=true;
				textBox44.Visible=true;
				textBox45.Visible=true;
				textBox46.Visible=true;
				textBox47.Visible=true;
				textBox48.Visible=true;
				textBox49.Visible=true;
				textBox50.Visible=true;
				textBox51.Visible=true;
				textBox52.Visible=true;
				textBox53.Visible=true;
				textBox54.Visible=true;
				textBox55.Visible=true;
				textBox56.Visible=true;
				textBox57.Visible=true;
				textBox58.Visible=true;
				textBox59.Visible=true;
				textBox60.Visible=true;
				textBox61.Visible=true;
				textBox62.Visible=true;
				textBox63.Visible=true;
				textBox64.Visible=true;
				textBox65.Visible=true;
				textBox66.Visible=false;
				textBox67.Visible=false;
				textBox68.Visible=false;
				textBox69.Visible=false;
				textBox70.Visible=false;
				textBox71.Visible=false;
				textBox72.Visible=false;
				textBox73.Visible=false;
				textBox74.Visible=false;
				textBox75.Visible=false;
				textBox76.Visible=false;
				textBox77.Visible=false;
				textBox78.Visible=false;
				textBox79.Visible=false;
				textBox80.Visible=false;
				textBox81.Visible=false;
				textBox82.Visible=false;
				textBox83.Visible=false;
				textBox84.Visible=false;
				textBox85.Visible=false;
				textBox86.Visible=false;
				textBox87.Visible=false;
				textBox88.Visible=false;
				textBox89.Visible=false;
				textBox90.Visible=false;
				textBox91.Visible=false;
				textBox92.Visible=false;
				textBox93.Visible=false;
				textBox94.Visible=false;
				textBox95.Visible=false;
				textBox96.Visible=false;
				textBox97.Visible=false;
				textBox98.Visible=false;
				textBox99.Visible=false;
				textBox100.Visible=false;
				textBox101.Visible=false;
				textBox102.Visible=false;
				textBox103.Visible=false;
				textBox104.Visible=false;
				textBox105.Visible=false;
				textBox106.Visible=false;
				textBox107.Visible=false;
				textBox108.Visible=false;
				textBox109.Visible=false;
				textBox110.Visible=false;
				textBox111.Visible=false;
				textBox112.Visible=false;
				textBox113.Visible=false;
				textBox114.Visible=false;
				textBox115.Visible=false;

				textBox16.Enabled=false;
				textBox17.Enabled=false;
				textBox18.Enabled=false;
				textBox19.Enabled=false;
				textBox20.Enabled=false;
				textBox21.Enabled=false;
				textBox22.Enabled=false;
				textBox23.Enabled=false;
				textBox24.Enabled=false;
				textBox25.Enabled=false;
				textBox26.Enabled=false;
				textBox27.Enabled=false;
				textBox28.Enabled=false;
				textBox29.Enabled=false;
				textBox30.Enabled=false;
				textBox31.Enabled=false;
				textBox32.Enabled=false;
				textBox33.Enabled=false;
				textBox34.Enabled=false;
				textBox35.Enabled=false;
				textBox36.Enabled=false;
				textBox37.Enabled=false;
				textBox38.Enabled=false;
				textBox39.Enabled=false;
				textBox40.Enabled=false;
				textBox41.Enabled=false;
				textBox42.Enabled=false;
				textBox43.Enabled=false;
				textBox44.Enabled=false;
				textBox45.Enabled=false;
				textBox46.Enabled=false;
				textBox47.Enabled=false;
				textBox48.Enabled=false;
				textBox49.Enabled=false;
				textBox50.Enabled=false;
				textBox51.Enabled=false;
				textBox52.Enabled=false;
				textBox53.Enabled=false;
				textBox54.Enabled=false;
				textBox55.Enabled=false;
				textBox56.Enabled=false;
				textBox57.Enabled=false;
				textBox58.Enabled=false;
				textBox59.Enabled=false;
				textBox60.Enabled=false;
				textBox61.Enabled=false;
				textBox62.Enabled=false;
				textBox63.Enabled=false;
				textBox64.Enabled=false;
				textBox65.Enabled=false;
				textBox66.Enabled=false;
				textBox67.Enabled=false;
				textBox68.Enabled=false;
				textBox69.Enabled=false;
				textBox70.Enabled=false;
				textBox71.Enabled=false;
				textBox72.Enabled=false;
				textBox73.Enabled=false;
				textBox74.Enabled=false;
				textBox75.Enabled=false;
				textBox76.Enabled=false;
				textBox77.Enabled=false;
				textBox78.Enabled=false;
				textBox79.Enabled=false;
				textBox80.Enabled=false;
				textBox81.Enabled=false;
				textBox82.Enabled=false;
				textBox83.Enabled=false;
				textBox84.Enabled=false;
				textBox85.Enabled=false;
				textBox86.Enabled=false;
				textBox87.Enabled=false;
				textBox88.Enabled=false;
				textBox89.Enabled=false;
				textBox90.Enabled=false;
				textBox91.Enabled=false;
				textBox92.Enabled=false;
				textBox93.Enabled=false;
				textBox94.Enabled=false;
				textBox95.Enabled=false;
				textBox96.Enabled=false;
				textBox97.Enabled=false;
				textBox98.Enabled=false;
				textBox99.Enabled=false;
				textBox100.Enabled=false;
				textBox101.Enabled=false;
				textBox102.Enabled=false;
				textBox103.Enabled=false;
				textBox104.Enabled=false;
				textBox105.Enabled=false;
				textBox106.Enabled=false;
				textBox107.Enabled=false;
				textBox108.Enabled=false;
				textBox109.Enabled=false;
				textBox110.Enabled=false;
				textBox111.Enabled=false;
				textBox112.Enabled=false;
				textBox113.Enabled=false;
				textBox114.Enabled=false;
				textBox115.Enabled=false;
				label36.Visible=true;
				label37.Visible=true;
				label38.Visible=true;
				label39.Visible=true;
			}
			else
			{
				label36.Visible=false;
				label37.Visible=false;
				label38.Visible=false;
				label39.Visible=false;
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked)
			{
				textBox116.Text="Contrôle 100 mesures";
				textBox16.Visible=true;
				textBox17.Visible=true;
				textBox18.Visible=true;
				textBox19.Visible=true;
				textBox20.Visible=true;
				textBox21.Visible=true;
				textBox22.Visible=true;
				textBox23.Visible=true;
				textBox24.Visible=true;
				textBox25.Visible=true;
				textBox26.Visible=true;
				textBox27.Visible=true;
				textBox28.Visible=true;
				textBox29.Visible=true;
				textBox30.Visible=true;
				textBox31.Visible=true;
				textBox32.Visible=true;
				textBox33.Visible=true;
				textBox34.Visible=true;
				textBox35.Visible=true;
				textBox36.Visible=true;
				textBox37.Visible=true;
				textBox38.Visible=true;
				textBox39.Visible=true;
				textBox40.Visible=true;
				textBox41.Visible=true;
				textBox42.Visible=true;
				textBox43.Visible=true;
				textBox44.Visible=true;
				textBox45.Visible=true;
				textBox46.Visible=true;
				textBox47.Visible=true;
				textBox48.Visible=true;
				textBox49.Visible=true;
				textBox50.Visible=true;
				textBox51.Visible=true;
				textBox52.Visible=true;
				textBox53.Visible=true;
				textBox54.Visible=true;
				textBox55.Visible=true;
				textBox56.Visible=true;
				textBox57.Visible=true;
				textBox58.Visible=true;
				textBox59.Visible=true;
				textBox60.Visible=true;
				textBox61.Visible=true;
				textBox62.Visible=true;
				textBox63.Visible=true;
				textBox64.Visible=true;
				textBox65.Visible=true;
				textBox66.Visible=true;
				textBox67.Visible=true;
				textBox68.Visible=true;
				textBox69.Visible=true;
				textBox70.Visible=true;
				textBox71.Visible=true;
				textBox72.Visible=true;
				textBox73.Visible=true;
				textBox74.Visible=true;
				textBox75.Visible=true;
				textBox76.Visible=true;
				textBox77.Visible=true;
				textBox78.Visible=true;
				textBox79.Visible=true;
				textBox80.Visible=true;
				textBox81.Visible=true;
				textBox82.Visible=true;
				textBox83.Visible=true;
				textBox84.Visible=true;
				textBox85.Visible=true;
				textBox86.Visible=true;
				textBox87.Visible=true;
				textBox88.Visible=true;
				textBox89.Visible=true;
				textBox90.Visible=true;
				textBox91.Visible=true;
				textBox92.Visible=true;
				textBox93.Visible=true;
				textBox94.Visible=true;
				textBox95.Visible=true;
				textBox96.Visible=true;
				textBox97.Visible=true;
				textBox98.Visible=true;
				textBox99.Visible=true;
				textBox100.Visible=true;
				textBox101.Visible=true;
				textBox102.Visible=true;
				textBox103.Visible=true;
				textBox104.Visible=true;
				textBox105.Visible=true;
				textBox106.Visible=true;
				textBox107.Visible=true;
				textBox108.Visible=true;
				textBox109.Visible=true;
				textBox110.Visible=true;
				textBox111.Visible=true;
				textBox112.Visible=true;
				textBox113.Visible=true;
				textBox114.Visible=true;
				textBox115.Visible=true;

				textBox16.Enabled=false;
				textBox17.Enabled=false;
				textBox18.Enabled=false;
				textBox19.Enabled=false;
				textBox20.Enabled=false;
				textBox21.Enabled=false;
				textBox22.Enabled=false;
				textBox23.Enabled=false;
				textBox24.Enabled=false;
				textBox25.Enabled=false;
				textBox26.Enabled=false;
				textBox27.Enabled=false;
				textBox28.Enabled=false;
				textBox29.Enabled=false;
				textBox30.Enabled=false;
				textBox31.Enabled=false;
				textBox32.Enabled=false;
				textBox33.Enabled=false;
				textBox34.Enabled=false;
				textBox35.Enabled=false;
				textBox36.Enabled=false;
				textBox37.Enabled=false;
				textBox38.Enabled=false;
				textBox39.Enabled=false;
				textBox40.Enabled=false;
				textBox41.Enabled=false;
				textBox42.Enabled=false;
				textBox43.Enabled=false;
				textBox44.Enabled=false;
				textBox45.Enabled=false;
				textBox46.Enabled=false;
				textBox47.Enabled=false;
				textBox48.Enabled=false;
				textBox49.Enabled=false;
				textBox50.Enabled=false;
				textBox51.Enabled=false;
				textBox52.Enabled=false;
				textBox53.Enabled=false;
				textBox54.Enabled=false;
				textBox55.Enabled=false;
				textBox56.Enabled=false;
				textBox57.Enabled=false;
				textBox58.Enabled=false;
				textBox59.Enabled=false;
				textBox60.Enabled=false;
				textBox61.Enabled=false;
				textBox62.Enabled=false;
				textBox63.Enabled=false;
				textBox64.Enabled=false;
				textBox65.Enabled=false;
				textBox66.Enabled=false;
				textBox67.Enabled=false;
				textBox68.Enabled=false;
				textBox69.Enabled=false;
				textBox70.Enabled=false;
				textBox71.Enabled=false;
				textBox72.Enabled=false;
				textBox73.Enabled=false;
				textBox74.Enabled=false;
				textBox75.Enabled=false;
				textBox76.Enabled=false;
				textBox77.Enabled=false;
				textBox78.Enabled=false;
				textBox79.Enabled=false;
				textBox80.Enabled=false;
				textBox81.Enabled=false;
				textBox82.Enabled=false;
				textBox83.Enabled=false;
				textBox84.Enabled=false;
				textBox85.Enabled=false;
				textBox86.Enabled=false;
				textBox87.Enabled=false;
				textBox88.Enabled=false;
				textBox89.Enabled=false;
				textBox90.Enabled=false;
				textBox91.Enabled=false;
				textBox92.Enabled=false;
				textBox93.Enabled=false;
				textBox94.Enabled=false;
				textBox95.Enabled=false;
				textBox96.Enabled=false;
				textBox97.Enabled=false;
				textBox98.Enabled=false;
				textBox99.Enabled=false;
				textBox100.Enabled=false;
				textBox101.Enabled=false;
				textBox102.Enabled=false;
				textBox103.Enabled=false;
				textBox104.Enabled=false;
				textBox105.Enabled=false;
				textBox106.Enabled=false;
				textBox107.Enabled=false;
				textBox108.Enabled=false;
				textBox109.Enabled=false;
				textBox110.Enabled=false;
				textBox111.Enabled=false;
				textBox112.Enabled=false;
				textBox113.Enabled=false;
				textBox114.Enabled=false;
				textBox115.Enabled=false;
				label36.Visible=true;
				label37.Visible=true;
				label38.Visible=true;
				label39.Visible=true;
				label40.Visible=true;
				label41.Visible=true;
				label42.Visible=true;
				label43.Visible=true;
				label44.Visible=true;
				label45.Visible=true;
				label46.Visible=true;
				label47.Visible=true;
				label48.Visible=true;
				label49.Visible=true;
			}
			else
			{
				label36.Visible=false;
				label37.Visible=false;
				label38.Visible=false;
				label39.Visible=false;
				label40.Visible=false;
				label41.Visible=false;
				label42.Visible=false;
				label43.Visible=false;
				label44.Visible=false;
				label45.Visible=false;
				label46.Visible=false;
				label47.Visible=false;
				label48.Visible=false;
				label49.Visible=false;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			bool Save=true;
			if(textBox9.TextLength.Equals(0)||textBox10.TextLength.Equals(0)||textBox11.TextLength.Equals(0))
			{
				if(MessageBox.Show("Attention, champs mini, maxi machine et vitesse non renseignés, continuer ?")==DialogResult.OK)
				{
					Save=true;
				}
				else
					Save=false;
			}
			if(Save)
			{
				if(textBox117.TextLength.Equals(0))
					textBox117.Text="?";
				if(mtgcComboBox1.SelectedIndex.Equals(-1))
					MessageBox.Show("Opérateur non présent");
				else if(mtgcComboBox2.SelectedIndex.Equals(-1))
					MessageBox.Show("Veuillez choisir une chaine SVP");
				else if(mtgcComboBox3.SelectedIndex.Equals(-1))
					MessageBox.Show("Veuillez choisir un capteur SVP");
				else
				{
					if(Nouveau.Equals(true))
					{
						ds.Tables["t_parc_capteurs"].Clear();
						Comm.CommandText="select * from t_parc_capteurs where chaine='"+mtgcComboBox3.Text+"'";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"t_parc_capteurs");
						int ID=System.Convert.ToInt32(ds.Tables["t_parc_capteurs"].Rows[0]["id"].ToString());
						if(radioButton1.Checked.Equals(true))
						{
							Comm.CommandText="insert into t_controles_cam ([n° controle],[code machine opindus],[mini-poste], [maxi-poste], [vitesse_mesuree], [date_controle], [type_controle], operateur,ets,capteur,[val_001],[val_002],[val_003],[val_004],[val_005],[val_006],[val_007],[val_008],[val_009],[val_010],[val_011],[val_012],[val_013],[val_014],[val_015],[val_016],[val_017],[val_018],[val_019],[val_020],[val_021],[val_022],[val_023],[val_024],[val_025],[val_026],[val_027],[val_028],[val_029],[val_030],[val_031],[val_032],[val_033],[val_034],[val_035],[val_036],[val_037],[val_038],[val_039],[val_040],[val_041],[val_042],[val_043],[val_044],[val_045],[val_046],[val_047],[val_048],[val_049],[val_050],[val_051],[val_052],[val_053],[val_054],[val_055],[val_056],[val_057],[val_058],[val_059],[val_060],[val_061],[val_062],[val_063],[val_064],[val_065],[val_066],[val_067],[val_068],[val_069],[val_070],[val_071],[val_072],[val_073],[val_074],[val_075],[val_076],[val_077],[val_078],[val_079],[val_080],[val_081],[val_082],[val_083],[val_084],[val_085],[val_086],[val_087],[val_088],[val_089],[val_090],[val_091],[val_092],[val_093],[val_094],[val_095],[val_096],[val_097],[val_098],[val_099],[val_100],commentaire)"+
								" values ("+textBox7.Text+",'"+textBox1.Text+"',"+textBox12.Text.Replace(",",".")+","+textBox13.Text.Replace(",",".")+","+textBox14.Text.Replace(",",".")+",'"+DateTime.Now.ToShortDateString()+"',1,'"+mtgcComboBox1.Text+"','"+mtgcComboBox2.Text+"',"+ID+","+textBox16.Text.Replace(",",".")+","+textBox17.Text.Replace(",",".")+","+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+","+textBox20.Text.Replace(",",".")+","+textBox21.Text.Replace(",",".")+","+textBox22.Text.Replace(",",".")+","+textBox23.Text.Replace(",",".")+","+textBox24.Text.Replace(",",".")+","+textBox25.Text.Replace(",",".")+","+textBox35.Text.Replace(",",".")+","+textBox34.Text.Replace(",",".")+","+textBox33.Text.Replace(",",".")+","+textBox32.Text.Replace(",",".")+","+textBox31.Text.Replace(",",".")+","+textBox30.Text.Replace(",",".")+","+textBox29.Text.Replace(",",".")+","+textBox28.Text.Replace(",",".")+","+textBox27.Text.Replace(",",".")+","+textBox26.Text.Replace(",",".")+","+textBox45.Text.Replace(",",".")+","+textBox44.Text.Replace(",",".")+","+textBox43.Text.Replace(",",".")+","+textBox42.Text.Replace(",",".")+","+textBox41.Text.Replace(",",".")+","+textBox40.Text.Replace(",",".")+
								","+textBox39.Text.Replace(",",".")+","+textBox38.Text.Replace(",",".")+","+textBox37.Text.Replace(",",".")+","+textBox36.Text.Replace(",",".")+","+textBox55.Text.Replace(",",".")+","+textBox54.Text.Replace(",",".")+","+textBox53.Text.Replace(",",".")+","+textBox52.Text.Replace(",",".")+","+textBox51.Text.Replace(",",".")+","+textBox50.Text.Replace(",",".")+","+textBox49.Text.Replace(",",".")+","+textBox48.Text.Replace(",",".")+","+textBox47.Text.Replace(",",".")+","+textBox46.Text.Replace(",",".")+","+textBox65.Text.Replace(",",".")+","+textBox64.Text.Replace(",",".")+","+textBox63.Text.Replace(",",".")+","+textBox62.Text.Replace(",",".")+","+textBox61.Text.Replace(",",".")+","+textBox60.Text.Replace(",",".")+","+textBox59.Text.Replace(",",".")+","+textBox58.Text.Replace(",",".")+","+textBox57.Text.Replace(",",".")+","+textBox56.Text.Replace(",",".")+","+textBox75.Text.Replace(",",".")+","+textBox74.Text.Replace(",",".")+","+textBox73.Text.Replace(",",".")+","+textBox72.Text.Replace(",",".")+","+textBox71.Text.Replace(",",".")+","+textBox70.Text.Replace(",",".")+","+textBox69.Text.Replace(",",".")+","+textBox68.Text.Replace(",",".")+","+textBox67.Text.Replace(",",".")+","+
								textBox66.Text.Replace(",",".")+","+textBox85.Text.Replace(",",".")+","+textBox84.Text.Replace(",",".")+","+textBox83.Text.Replace(",",".")+","+textBox82.Text.Replace(",",".")+","+textBox81.Text.Replace(",",".")+","+textBox80.Text.Replace(",",".")+","+textBox79.Text.Replace(",",".")+","+textBox78.Text.Replace(",",".")+","+textBox77.Text.Replace(",",".")+","+textBox76.Text.Replace(",",".")+","+textBox95.Text.Replace(",",".")+","+textBox94.Text.Replace(",",".")+","+textBox93.Text.Replace(",",".")+","+textBox92.Text.Replace(",",".")+","+textBox91.Text.Replace(",",".")+","+textBox90.Text.Replace(",",".")+","+textBox89.Text.Replace(",",".")+","+textBox88.Text.Replace(",",".")+","+textBox87.Text.Replace(",",".")+","+textBox86.Text.Replace(",",".")+","+textBox105.Text.Replace(",",".")+","+textBox104.Text.Replace(",",".")+","+textBox103.Text.Replace(",",".")+","+textBox102.Text.Replace(",",".")+","+textBox101.Text.Replace(",",".")+","+textBox100.Text.Replace(",",".")+","+textBox99.Text.Replace(",",".")+","+textBox98.Text.Replace(",",".")+","+textBox97.Text.Replace(",",".")+","+textBox96.Text.Replace(",",".")+","+textBox115.Text.Replace(",",".")+","+textBox114.Text.Replace(",",".")+","+
								textBox113.Text.Replace(",",".")+","+textBox112.Text.Replace(",",".")+","+textBox111.Text.Replace(",",".")+","+textBox110.Text.Replace(",",".")+","+textBox109.Text.Replace(",",".")+","+textBox108.Text.Replace(",",".")+","+textBox107.Text.Replace(",",".")+","+textBox106.Text.Replace(",",".")+",'"+textBox117.Text+"')";
						}
						else if(radioButton2.Checked.Equals(true))
						{
							Comm.CommandText="insert into t_controles_cam ([n° controle],[code machine opindus],[mini-poste], [maxi-poste], [vitesse_mesuree], [date_controle], [type_controle], operateur,ets,capteur,[val_001],[val_002],[val_003],[val_004],[val_005],[val_006],[val_007],[val_008],[val_009],[val_010],[val_011],[val_012],[val_013],[val_014],[val_015],[val_016],[val_017],[val_018],[val_019],[val_020],[val_021],[val_022],[val_023],[val_024],[val_025],[val_026],[val_027],[val_028],[val_029],[val_030],[val_031],[val_032],[val_033],[val_034],[val_035],[val_036],[val_037],[val_038],[val_039],[val_040],[val_041],[val_042],[val_043],[val_044],[val_045],[val_046],[val_047],[val_048],[val_049],[val_050],[val_051],[val_052],[val_053],[val_054],[val_055],[val_056],[val_057],[val_058],[val_059],[val_060],[val_061],[val_062],[val_063],[val_064],[val_065],[val_066],[val_067],[val_068],[val_069],[val_070],[val_071],[val_072],[val_073],[val_074],[val_075],[val_076],[val_077],[val_078],[val_079],[val_080],[val_081],[val_082],[val_083],[val_084],[val_085],[val_086],[val_087],[val_088],[val_089],[val_090],[val_091],[val_092],[val_093],[val_094],[val_095],[val_096],[val_097],[val_098],[val_099],[val_100],commentaire)"+
								" values ("+textBox7.Text+",'"+textBox1.Text+"',"+textBox12.Text.Replace(",",".")+","+textBox13.Text.Replace(",",".")+","+textBox14.Text.Replace(",",".")+",'"+DateTime.Now.ToShortDateString()+"',2,'"+mtgcComboBox1.Text+"','"+mtgcComboBox2.Text+"',"+ID+","+textBox16.Text.Replace(",",".")+","+textBox17.Text.Replace(",",".")+","+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+","+textBox20.Text.Replace(",",".")+","+textBox21.Text.Replace(",",".")+","+textBox22.Text.Replace(",",".")+","+textBox23.Text.Replace(",",".")+","+textBox24.Text.Replace(",",".")+","+textBox25.Text.Replace(",",".")+","+textBox35.Text.Replace(",",".")+","+textBox34.Text.Replace(",",".")+","+textBox33.Text.Replace(",",".")+","+textBox32.Text.Replace(",",".")+","+textBox31.Text.Replace(",",".")+","+textBox30.Text.Replace(",",".")+","+textBox29.Text.Replace(",",".")+","+textBox28.Text.Replace(",",".")+","+textBox27.Text.Replace(",",".")+","+textBox26.Text.Replace(",",".")+","+textBox45.Text.Replace(",",".")+","+textBox44.Text.Replace(",",".")+","+textBox43.Text.Replace(",",".")+","+textBox42.Text.Replace(",",".")+","+textBox41.Text.Replace(",",".")+","+textBox40.Text.Replace(",",".")+
								","+textBox39.Text.Replace(",",".")+","+textBox38.Text.Replace(",",".")+","+textBox37.Text.Replace(",",".")+","+textBox36.Text.Replace(",",".")+","+textBox55.Text.Replace(",",".")+","+textBox54.Text.Replace(",",".")+","+textBox53.Text.Replace(",",".")+","+textBox52.Text.Replace(",",".")+","+textBox51.Text.Replace(",",".")+","+textBox50.Text.Replace(",",".")+","+textBox49.Text.Replace(",",".")+","+textBox48.Text.Replace(",",".")+","+textBox47.Text.Replace(",",".")+","+textBox46.Text.Replace(",",".")+","+textBox65.Text.Replace(",",".")+","+textBox64.Text.Replace(",",".")+","+textBox63.Text.Replace(",",".")+","+textBox62.Text.Replace(",",".")+","+textBox61.Text.Replace(",",".")+","+textBox60.Text.Replace(",",".")+","+textBox59.Text.Replace(",",".")+","+textBox58.Text.Replace(",",".")+","+textBox57.Text.Replace(",",".")+","+textBox56.Text.Replace(",",".")+","+textBox75.Text.Replace(",",".")+","+textBox74.Text.Replace(",",".")+","+textBox73.Text.Replace(",",".")+","+textBox72.Text.Replace(",",".")+","+textBox71.Text.Replace(",",".")+","+textBox70.Text.Replace(",",".")+","+textBox69.Text.Replace(",",".")+","+textBox68.Text.Replace(",",".")+","+textBox67.Text.Replace(",",".")+","+
								textBox66.Text.Replace(",",".")+","+textBox85.Text.Replace(",",".")+","+textBox84.Text.Replace(",",".")+","+textBox83.Text.Replace(",",".")+","+textBox82.Text.Replace(",",".")+","+textBox81.Text.Replace(",",".")+","+textBox80.Text.Replace(",",".")+","+textBox79.Text.Replace(",",".")+","+textBox78.Text.Replace(",",".")+","+textBox77.Text.Replace(",",".")+","+textBox76.Text.Replace(",",".")+","+textBox95.Text.Replace(",",".")+","+textBox94.Text.Replace(",",".")+","+textBox93.Text.Replace(",",".")+","+textBox92.Text.Replace(",",".")+","+textBox91.Text.Replace(",",".")+","+textBox90.Text.Replace(",",".")+","+textBox89.Text.Replace(",",".")+","+textBox88.Text.Replace(",",".")+","+textBox87.Text.Replace(",",".")+","+textBox86.Text.Replace(",",".")+","+textBox105.Text.Replace(",",".")+","+textBox104.Text.Replace(",",".")+","+textBox103.Text.Replace(",",".")+","+textBox102.Text.Replace(",",".")+","+textBox101.Text.Replace(",",".")+","+textBox100.Text.Replace(",",".")+","+textBox99.Text.Replace(",",".")+","+textBox98.Text.Replace(",",".")+","+textBox97.Text.Replace(",",".")+","+textBox96.Text.Replace(",",".")+","+textBox115.Text.Replace(",",".")+","+textBox114.Text.Replace(",",".")+","+
								textBox113.Text.Replace(",",".")+","+textBox112.Text.Replace(",",".")+","+textBox111.Text.Replace(",",".")+","+textBox110.Text.Replace(",",".")+","+textBox109.Text.Replace(",",".")+","+textBox108.Text.Replace(",",".")+","+textBox107.Text.Replace(",",".")+","+textBox106.Text.Replace(",",".")+",'"+textBox117.Text+"')";
						}
						else if(radioButton3.Checked.Equals(true))
						{
							Comm.CommandText="insert into t_controles_cam ([n° controle],[code machine opindus],[mini-poste], [maxi-poste], [vitesse_mesuree], [date_controle], [type_controle], operateur,ets,capteur,[val_001],[val_002],[val_003],[val_004],[val_005],[val_006],[val_007],[val_008],[val_009],[val_010],[val_011],[val_012],[val_013],[val_014],[val_015],[val_016],[val_017],[val_018],[val_019],[val_020],[val_021],[val_022],[val_023],[val_024],[val_025],[val_026],[val_027],[val_028],[val_029],[val_030],[val_031],[val_032],[val_033],[val_034],[val_035],[val_036],[val_037],[val_038],[val_039],[val_040],[val_041],[val_042],[val_043],[val_044],[val_045],[val_046],[val_047],[val_048],[val_049],[val_050],[val_051],[val_052],[val_053],[val_054],[val_055],[val_056],[val_057],[val_058],[val_059],[val_060],[val_061],[val_062],[val_063],[val_064],[val_065],[val_066],[val_067],[val_068],[val_069],[val_070],[val_071],[val_072],[val_073],[val_074],[val_075],[val_076],[val_077],[val_078],[val_079],[val_080],[val_081],[val_082],[val_083],[val_084],[val_085],[val_086],[val_087],[val_088],[val_089],[val_090],[val_091],[val_092],[val_093],[val_094],[val_095],[val_096],[val_097],[val_098],[val_099],[val_100],commentaire)"+
								" values ("+textBox7.Text+",'"+textBox1.Text+"',"+textBox12.Text.Replace(",",".")+","+textBox13.Text.Replace(",",".")+","+textBox14.Text.Replace(",",".")+",'"+DateTime.Now.ToShortDateString()+"',3,'"+mtgcComboBox1.Text+"','"+mtgcComboBox2.Text+"',"+ID+","+textBox16.Text.Replace(",",".")+","+textBox17.Text.Replace(",",".")+","+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+","+textBox20.Text.Replace(",",".")+","+textBox21.Text.Replace(",",".")+","+textBox22.Text.Replace(",",".")+","+textBox23.Text.Replace(",",".")+","+textBox24.Text.Replace(",",".")+","+textBox25.Text.Replace(",",".")+","+textBox35.Text.Replace(",",".")+","+textBox34.Text.Replace(",",".")+","+textBox33.Text.Replace(",",".")+","+textBox32.Text.Replace(",",".")+","+textBox31.Text.Replace(",",".")+","+textBox30.Text.Replace(",",".")+","+textBox29.Text.Replace(",",".")+","+textBox28.Text.Replace(",",".")+","+textBox27.Text.Replace(",",".")+","+textBox26.Text.Replace(",",".")+","+textBox45.Text.Replace(",",".")+","+textBox44.Text.Replace(",",".")+","+textBox43.Text.Replace(",",".")+","+textBox42.Text.Replace(",",".")+","+textBox41.Text.Replace(",",".")+","+textBox40.Text.Replace(",",".")+
								","+textBox39.Text.Replace(",",".")+","+textBox38.Text.Replace(",",".")+","+textBox37.Text.Replace(",",".")+","+textBox36.Text.Replace(",",".")+","+textBox55.Text.Replace(",",".")+","+textBox54.Text.Replace(",",".")+","+textBox53.Text.Replace(",",".")+","+textBox52.Text.Replace(",",".")+","+textBox51.Text.Replace(",",".")+","+textBox50.Text.Replace(",",".")+","+textBox49.Text.Replace(",",".")+","+textBox48.Text.Replace(",",".")+","+textBox47.Text.Replace(",",".")+","+textBox46.Text.Replace(",",".")+","+textBox65.Text.Replace(",",".")+","+textBox64.Text.Replace(",",".")+","+textBox63.Text.Replace(",",".")+","+textBox62.Text.Replace(",",".")+","+textBox61.Text.Replace(",",".")+","+textBox60.Text.Replace(",",".")+","+textBox59.Text.Replace(",",".")+","+textBox58.Text.Replace(",",".")+","+textBox57.Text.Replace(",",".")+","+textBox56.Text.Replace(",",".")+","+textBox75.Text.Replace(",",".")+","+textBox74.Text.Replace(",",".")+","+textBox73.Text.Replace(",",".")+","+textBox72.Text.Replace(",",".")+","+textBox71.Text.Replace(",",".")+","+textBox70.Text.Replace(",",".")+","+textBox69.Text.Replace(",",".")+","+textBox68.Text.Replace(",",".")+","+textBox67.Text.Replace(",",".")+","+
								textBox66.Text.Replace(",",".")+","+textBox85.Text.Replace(",",".")+","+textBox84.Text.Replace(",",".")+","+textBox83.Text.Replace(",",".")+","+textBox82.Text.Replace(",",".")+","+textBox81.Text.Replace(",",".")+","+textBox80.Text.Replace(",",".")+","+textBox79.Text.Replace(",",".")+","+textBox78.Text.Replace(",",".")+","+textBox77.Text.Replace(",",".")+","+textBox76.Text.Replace(",",".")+","+textBox95.Text.Replace(",",".")+","+textBox94.Text.Replace(",",".")+","+textBox93.Text.Replace(",",".")+","+textBox92.Text.Replace(",",".")+","+textBox91.Text.Replace(",",".")+","+textBox90.Text.Replace(",",".")+","+textBox89.Text.Replace(",",".")+","+textBox88.Text.Replace(",",".")+","+textBox87.Text.Replace(",",".")+","+textBox86.Text.Replace(",",".")+","+textBox105.Text.Replace(",",".")+","+textBox104.Text.Replace(",",".")+","+textBox103.Text.Replace(",",".")+","+textBox102.Text.Replace(",",".")+","+textBox101.Text.Replace(",",".")+","+textBox100.Text.Replace(",",".")+","+textBox99.Text.Replace(",",".")+","+textBox98.Text.Replace(",",".")+","+textBox97.Text.Replace(",",".")+","+textBox96.Text.Replace(",",".")+","+textBox115.Text.Replace(",",".")+","+textBox114.Text.Replace(",",".")+","+
								textBox113.Text.Replace(",",".")+","+textBox112.Text.Replace(",",".")+","+textBox111.Text.Replace(",",".")+","+textBox110.Text.Replace(",",".")+","+textBox109.Text.Replace(",",".")+","+textBox108.Text.Replace(",",".")+","+textBox107.Text.Replace(",",".")+","+textBox106.Text.Replace(",",".")+",'"+textBox117.Text+"')";
						}
						try
						{
							oleDbConnection1.Open();
							Comm.ExecuteNonQuery();
							Comm.CommandText="UPDATE t_parc_machine SET [Date dernier controle]='"+DateTime.Now.Day.ToString()+"/"+DateTime.Now.Month.ToString()+"/"+DateTime.Now.Year.ToString()+"' WHERE [Code machine opindus]='"+textBox1.Text.Replace("'","''")+"'";
							Comm.ExecuteNonQuery();
						}
						catch
						{
						}
						finally
						{
							oleDbConnection1.Close();
						}
					}
					else
					{
						ds.Tables["t_parc_capteurs"].Clear();
						Comm.CommandText="select * from t_parc_capteurs where chaine='"+mtgcComboBox3.Text+"'";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"t_parc_capteurs");
						int ID=System.Convert.ToInt32(ds.Tables["t_parc_capteurs"].Rows[0]["id"].ToString());
						if(radioButton1.Checked.Equals(true))
						{
							Comm.CommandText="update t_controles_cam set [n° controle]="+textBox7.Text+",[code machine opindus]='"+textBox1.Text+"',[mini-poste]="+textBox12.Text.Replace(",",".")+", [maxi-poste]="+textBox13.Text.Replace(",",".")+", [vitesse_mesuree]="+textBox14.Text.Replace(",",".")+", [date_controle]='"+DateTime.Now.ToShortDateString()+"', [type_controle]=1, operateur='"+mtgcComboBox1.Text+"',ets='"+mtgcComboBox2.Text+"',capteur="+ID+",[val_001]="+textBox16.Text.Replace(",",".")+",[val_002]="+textBox17.Text.Replace(",",".")+",[val_003]="+textBox18.Text.Replace(",",".")+",[val_004]="+textBox19.Text.Replace(",",".")+",[val_005]="+textBox20.Text.Replace(",",".")+",[val_006]="+textBox21.Text.Replace(",",".")+",[val_007]="+textBox22.Text.Replace(",",".")+",[val_008]="+textBox23.Text.Replace(",",".")+",[val_009]="+textBox24.Text.Replace(",",".")+",[val_010]="+textBox25.Text.Replace(",",".")+",[val_011]="+textBox35.Text.Replace(",",".")+",[val_012]="+textBox34.Text.Replace(",",".")+",[val_013]="+textBox33.Text.Replace(",",".")+",[val_014]="+textBox32.Text.Replace(",",".")+",[val_015]="+textBox31.Text.Replace(",",".")+",[val_016]="+textBox30.Text.Replace(",",".")+",[val_017]="+
								textBox29.Text.Replace(",",".")+",[val_018]="+textBox28.Text.Replace(",",".")+",[val_019]="+textBox27.Text.Replace(",",".")+",[val_020]="+textBox26.Text.Replace(",",".")+",[val_021]="+textBox45.Text.Replace(",",".")+",[val_022]="+textBox44.Text.Replace(",",".")+",[val_023]="+textBox43.Text.Replace(",",".")+",[val_024]="+textBox42.Text.Replace(",",".")+",[val_025]="+textBox41.Text.Replace(",",".")+",[val_026]="+textBox40.Text.Replace(",",".")+",[val_027]="+textBox39.Text.Replace(",",".")+",[val_028]="+textBox38.Text.Replace(",",".")+",[val_029]="+textBox37.Text.Replace(",",".")+",[val_030]="+textBox36.Text.Replace(",",".")+",[val_031]="+textBox55.Text.Replace(",",".")+",[val_032]="+textBox54.Text.Replace(",",".")+",[val_033]="+textBox53.Text.Replace(",",".")+",[val_034]="+textBox52.Text.Replace(",",".")+",[val_035]="+textBox51.Text.Replace(",",".")+",[val_036]="+textBox50.Text.Replace(",",".")+",[val_037]="+textBox49.Text.Replace(",",".")+",[val_038]="+textBox48.Text.Replace(",",".")+",[val_039]="+textBox47.Text.Replace(",",".")+",[val_040]="+textBox46.Text.Replace(",",".")+",[val_041]="+textBox65.Text.Replace(",",".")+",[val_042]="+textBox64.Text.Replace(",",".")+",[val_043]="+
								textBox63.Text.Replace(",",".")+",[val_044]="+textBox62.Text.Replace(",",".")+",[val_045]="+textBox61.Text.Replace(",",".")+",[val_046]="+textBox60.Text.Replace(",",".")+",[val_047]="+textBox59.Text.Replace(",",".")+",[val_048]="+textBox58.Text.Replace(",",".")+",[val_049]="+textBox57.Text.Replace(",",".")+",[val_050]="+textBox56.Text.Replace(",",".")+",[val_051]="+textBox75.Text.Replace(",",".")+",[val_052]="+textBox74.Text.Replace(",",".")+",[val_053]="+textBox73.Text.Replace(",",".")+",[val_054]="+textBox72.Text.Replace(",",".")+",[val_055]="+textBox71.Text.Replace(",",".")+",[val_056]="+textBox70.Text.Replace(",",".")+",[val_057]="+textBox69.Text.Replace(",",".")+",[val_058]="+textBox68.Text.Replace(",",".")+",[val_059]="+textBox67.Text.Replace(",",".")+",[val_060]="+textBox66.Text.Replace(",",".")+",[val_061]="+textBox85.Text.Replace(",",".")+",[val_062]="+textBox84.Text.Replace(",",".")+",[val_063]="+textBox83.Text.Replace(",",".")+",[val_064]="+textBox82.Text.Replace(",",".")+",[val_065]="+textBox81.Text.Replace(",",".")+",[val_066]="+textBox80.Text.Replace(",",".")+",[val_067]="+textBox79.Text.Replace(",",".")+",[val_068]="+textBox78.Text.Replace(",",".")+",[val_069]="+
								textBox77.Text.Replace(",",".")+",[val_070]="+textBox76.Text.Replace(",",".")+",[val_071]="+textBox95.Text.Replace(",",".")+",[val_072]="+textBox94.Text.Replace(",",".")+",[val_073]="+textBox93.Text.Replace(",",".")+",[val_074]="+textBox92.Text.Replace(",",".")+",[val_075]="+textBox91.Text.Replace(",",".")+",[val_076]="+textBox90.Text.Replace(",",".")+",[val_077]="+textBox89.Text.Replace(",",".")+",[val_078]="+textBox88.Text.Replace(",",".")+",[val_079]="+textBox87.Text.Replace(",",".")+",[val_080]="+textBox86.Text.Replace(",",".")+",[val_081]="+textBox105.Text.Replace(",",".")+",[val_082]="+textBox104.Text.Replace(",",".")+",[val_083]="+textBox103.Text.Replace(",",".")+",[val_084]="+textBox102.Text.Replace(",",".")+",[val_085]="+textBox101.Text.Replace(",",".")+",[val_086]="+textBox100.Text.Replace(",",".")+",[val_087]="+textBox99.Text.Replace(",",".")+",[val_088]="+textBox98.Text.Replace(",",".")+",[val_089]="+textBox97.Text.Replace(",",".")+",[val_090]="+textBox96.Text.Replace(",",".")+",[val_091]="+textBox115.Text.Replace(",",".")+",[val_092]="+textBox114.Text.Replace(",",".")+",[val_093]="+textBox113.Text.Replace(",",".")+",[val_094]="+textBox112.Text.Replace(",",".")+",[val_095]="+
								textBox111.Text.Replace(",",".")+",[val_096]="+textBox110.Text.Replace(",",".")+",[val_097]="+textBox109.Text.Replace(",",".")+",[val_098]="+textBox108.Text.Replace(",",".")+",[val_099]="+textBox107.Text.Replace(",",".")+",[val_100]="+textBox106.Text.Replace(",",".")+", Commentaire='"+textBox117.Text+"' where [N° controle]="+textBox7.Text;
						}
						else if(radioButton2.Checked.Equals(true))
						{
							Comm.CommandText="update t_controles_cam set [n° controle]="+textBox7.Text+",[code machine opindus]='"+textBox1.Text+"',[mini-poste]="+textBox12.Text.Replace(",",".")+", [maxi-poste]="+textBox13.Text.Replace(",",".")+", [vitesse_mesuree]="+textBox14.Text.Replace(",",".")+", [date_controle]='"+DateTime.Now.ToShortDateString()+"', [type_controle]=2, operateur='"+mtgcComboBox1.Text+"',ets='"+mtgcComboBox2.Text+"',capteur="+ID+",[val_001]="+textBox16.Text.Replace(",",".")+",[val_002]="+textBox17.Text.Replace(",",".")+",[val_003]="+textBox18.Text.Replace(",",".")+",[val_004]="+textBox19.Text.Replace(",",".")+",[val_005]="+textBox20.Text.Replace(",",".")+",[val_006]="+textBox21.Text.Replace(",",".")+",[val_007]="+textBox22.Text.Replace(",",".")+",[val_008]="+textBox23.Text.Replace(",",".")+",[val_009]="+textBox24.Text.Replace(",",".")+",[val_010]="+textBox25.Text.Replace(",",".")+",[val_011]="+textBox35.Text.Replace(",",".")+",[val_012]="+textBox34.Text.Replace(",",".")+",[val_013]="+textBox33.Text.Replace(",",".")+",[val_014]="+textBox32.Text.Replace(",",".")+",[val_015]="+textBox31.Text.Replace(",",".")+",[val_016]="+textBox30.Text.Replace(",",".")+",[val_017]="+
								textBox29.Text.Replace(",",".")+",[val_018]="+textBox28.Text.Replace(",",".")+",[val_019]="+textBox27.Text.Replace(",",".")+",[val_020]="+textBox26.Text.Replace(",",".")+",[val_021]="+textBox45.Text.Replace(",",".")+",[val_022]="+textBox44.Text.Replace(",",".")+",[val_023]="+textBox43.Text.Replace(",",".")+",[val_024]="+textBox42.Text.Replace(",",".")+",[val_025]="+textBox41.Text.Replace(",",".")+",[val_026]="+textBox40.Text.Replace(",",".")+",[val_027]="+textBox39.Text.Replace(",",".")+",[val_028]="+textBox38.Text.Replace(",",".")+",[val_029]="+textBox37.Text.Replace(",",".")+",[val_030]="+textBox36.Text.Replace(",",".")+",[val_031]="+textBox55.Text.Replace(",",".")+",[val_032]="+textBox54.Text.Replace(",",".")+",[val_033]="+textBox53.Text.Replace(",",".")+",[val_034]="+textBox52.Text.Replace(",",".")+",[val_035]="+textBox51.Text.Replace(",",".")+",[val_036]="+textBox50.Text.Replace(",",".")+",[val_037]="+textBox49.Text.Replace(",",".")+",[val_038]="+textBox48.Text.Replace(",",".")+",[val_039]="+textBox47.Text.Replace(",",".")+",[val_040]="+textBox46.Text.Replace(",",".")+",[val_041]="+textBox65.Text.Replace(",",".")+",[val_042]="+textBox64.Text.Replace(",",".")+",[val_043]="+
								textBox63.Text.Replace(",",".")+",[val_044]="+textBox62.Text.Replace(",",".")+",[val_045]="+textBox61.Text.Replace(",",".")+",[val_046]="+textBox60.Text.Replace(",",".")+",[val_047]="+textBox59.Text.Replace(",",".")+",[val_048]="+textBox58.Text.Replace(",",".")+",[val_049]="+textBox57.Text.Replace(",",".")+",[val_050]="+textBox56.Text.Replace(",",".")+",[val_051]="+textBox75.Text.Replace(",",".")+",[val_052]="+textBox74.Text.Replace(",",".")+",[val_053]="+textBox73.Text.Replace(",",".")+",[val_054]="+textBox72.Text.Replace(",",".")+",[val_055]="+textBox71.Text.Replace(",",".")+",[val_056]="+textBox70.Text.Replace(",",".")+",[val_057]="+textBox69.Text.Replace(",",".")+",[val_058]="+textBox68.Text.Replace(",",".")+",[val_059]="+textBox67.Text.Replace(",",".")+",[val_060]="+textBox66.Text.Replace(",",".")+",[val_061]="+textBox85.Text.Replace(",",".")+",[val_062]="+textBox84.Text.Replace(",",".")+",[val_063]="+textBox83.Text.Replace(",",".")+",[val_064]="+textBox82.Text.Replace(",",".")+",[val_065]="+textBox81.Text.Replace(",",".")+",[val_066]="+textBox80.Text.Replace(",",".")+",[val_067]="+textBox79.Text.Replace(",",".")+",[val_068]="+textBox78.Text.Replace(",",".")+",[val_069]="+
								textBox77.Text.Replace(",",".")+",[val_070]="+textBox76.Text.Replace(",",".")+",[val_071]="+textBox95.Text.Replace(",",".")+",[val_072]="+textBox94.Text.Replace(",",".")+",[val_073]="+textBox93.Text.Replace(",",".")+",[val_074]="+textBox92.Text.Replace(",",".")+",[val_075]="+textBox91.Text.Replace(",",".")+",[val_076]="+textBox90.Text.Replace(",",".")+",[val_077]="+textBox89.Text.Replace(",",".")+",[val_078]="+textBox88.Text.Replace(",",".")+",[val_079]="+textBox87.Text.Replace(",",".")+",[val_080]="+textBox86.Text.Replace(",",".")+",[val_081]="+textBox105.Text.Replace(",",".")+",[val_082]="+textBox104.Text.Replace(",",".")+",[val_083]="+textBox103.Text.Replace(",",".")+",[val_084]="+textBox102.Text.Replace(",",".")+",[val_085]="+textBox101.Text.Replace(",",".")+",[val_086]="+textBox100.Text.Replace(",",".")+",[val_087]="+textBox99.Text.Replace(",",".")+",[val_088]="+textBox98.Text.Replace(",",".")+",[val_089]="+textBox97.Text.Replace(",",".")+",[val_090]="+textBox96.Text.Replace(",",".")+",[val_091]="+textBox115.Text.Replace(",",".")+",[val_092]="+textBox114.Text.Replace(",",".")+",[val_093]="+textBox113.Text.Replace(",",".")+",[val_094]="+textBox112.Text.Replace(",",".")+",[val_095]="+
								textBox111.Text.Replace(",",".")+",[val_096]="+textBox110.Text.Replace(",",".")+",[val_097]="+textBox109.Text.Replace(",",".")+",[val_098]="+textBox108.Text.Replace(",",".")+",[val_099]="+textBox107.Text.Replace(",",".")+",[val_100]="+textBox106.Text.Replace(",",".")+", Commentaire='"+textBox117.Text+"' where [N° controle]="+textBox7.Text;
						}
						else if(radioButton3.Checked.Equals(true))
						{
							Comm.CommandText="update t_controles_cam set [n° controle]="+textBox7.Text+",[code machine opindus]='"+textBox1.Text+"',[mini-poste]="+textBox12.Text.Replace(",",".")+", [maxi-poste]="+textBox13.Text.Replace(",",".")+", [vitesse_mesuree]="+textBox14.Text.Replace(",",".")+", [date_controle]='"+DateTime.Now.ToShortDateString()+"', [type_controle]=3, operateur='"+mtgcComboBox1.Text+"',ets='"+mtgcComboBox2.Text+"',capteur="+ID+",[val_001]="+textBox16.Text.Replace(",",".")+",[val_002]="+textBox17.Text.Replace(",",".")+",[val_003]="+textBox18.Text.Replace(",",".")+",[val_004]="+textBox19.Text.Replace(",",".")+",[val_005]="+textBox20.Text.Replace(",",".")+",[val_006]="+textBox21.Text.Replace(",",".")+",[val_007]="+textBox22.Text.Replace(",",".")+",[val_008]="+textBox23.Text.Replace(",",".")+",[val_009]="+textBox24.Text.Replace(",",".")+",[val_010]="+textBox25.Text.Replace(",",".")+",[val_011]="+textBox35.Text.Replace(",",".")+",[val_012]="+textBox34.Text.Replace(",",".")+",[val_013]="+textBox33.Text.Replace(",",".")+",[val_014]="+textBox32.Text.Replace(",",".")+",[val_015]="+textBox31.Text.Replace(",",".")+",[val_016]="+textBox30.Text.Replace(",",".")+",[val_017]="+
								textBox29.Text.Replace(",",".")+",[val_018]="+textBox28.Text.Replace(",",".")+",[val_019]="+textBox27.Text.Replace(",",".")+",[val_020]="+textBox26.Text.Replace(",",".")+",[val_021]="+textBox45.Text.Replace(",",".")+",[val_022]="+textBox44.Text.Replace(",",".")+",[val_023]="+textBox43.Text.Replace(",",".")+",[val_024]="+textBox42.Text.Replace(",",".")+",[val_025]="+textBox41.Text.Replace(",",".")+",[val_026]="+textBox40.Text.Replace(",",".")+",[val_027]="+textBox39.Text.Replace(",",".")+",[val_028]="+textBox38.Text.Replace(",",".")+",[val_029]="+textBox37.Text.Replace(",",".")+",[val_030]="+textBox36.Text.Replace(",",".")+",[val_031]="+textBox55.Text.Replace(",",".")+",[val_032]="+textBox54.Text.Replace(",",".")+",[val_033]="+textBox53.Text.Replace(",",".")+",[val_034]="+textBox52.Text.Replace(",",".")+",[val_035]="+textBox51.Text.Replace(",",".")+",[val_036]="+textBox50.Text.Replace(",",".")+",[val_037]="+textBox49.Text.Replace(",",".")+",[val_038]="+textBox48.Text.Replace(",",".")+",[val_039]="+textBox47.Text.Replace(",",".")+",[val_040]="+textBox46.Text.Replace(",",".")+",[val_041]="+textBox65.Text.Replace(",",".")+",[val_042]="+textBox64.Text.Replace(",",".")+",[val_043]="+
								textBox63.Text.Replace(",",".")+",[val_044]="+textBox62.Text.Replace(",",".")+",[val_045]="+textBox61.Text.Replace(",",".")+",[val_046]="+textBox60.Text.Replace(",",".")+",[val_047]="+textBox59.Text.Replace(",",".")+",[val_048]="+textBox58.Text.Replace(",",".")+",[val_049]="+textBox57.Text.Replace(",",".")+",[val_050]="+textBox56.Text.Replace(",",".")+",[val_051]="+textBox75.Text.Replace(",",".")+",[val_052]="+textBox74.Text.Replace(",",".")+",[val_053]="+textBox73.Text.Replace(",",".")+",[val_054]="+textBox72.Text.Replace(",",".")+",[val_055]="+textBox71.Text.Replace(",",".")+",[val_056]="+textBox70.Text.Replace(",",".")+",[val_057]="+textBox69.Text.Replace(",",".")+",[val_058]="+textBox68.Text.Replace(",",".")+",[val_059]="+textBox67.Text.Replace(",",".")+",[val_060]="+textBox66.Text.Replace(",",".")+",[val_061]="+textBox85.Text.Replace(",",".")+",[val_062]="+textBox84.Text.Replace(",",".")+",[val_063]="+textBox83.Text.Replace(",",".")+",[val_064]="+textBox82.Text.Replace(",",".")+",[val_065]="+textBox81.Text.Replace(",",".")+",[val_066]="+textBox80.Text.Replace(",",".")+",[val_067]="+textBox79.Text.Replace(",",".")+",[val_068]="+textBox78.Text.Replace(",",".")+",[val_069]="+
								textBox77.Text.Replace(",",".")+",[val_070]="+textBox76.Text.Replace(",",".")+",[val_071]="+textBox95.Text.Replace(",",".")+",[val_072]="+textBox94.Text.Replace(",",".")+",[val_073]="+textBox93.Text.Replace(",",".")+",[val_074]="+textBox92.Text.Replace(",",".")+",[val_075]="+textBox91.Text.Replace(",",".")+",[val_076]="+textBox90.Text.Replace(",",".")+",[val_077]="+textBox89.Text.Replace(",",".")+",[val_078]="+textBox88.Text.Replace(",",".")+",[val_079]="+textBox87.Text.Replace(",",".")+",[val_080]="+textBox86.Text.Replace(",",".")+",[val_081]="+textBox105.Text.Replace(",",".")+",[val_082]="+textBox104.Text.Replace(",",".")+",[val_083]="+textBox103.Text.Replace(",",".")+",[val_084]="+textBox102.Text.Replace(",",".")+",[val_085]="+textBox101.Text.Replace(",",".")+",[val_086]="+textBox100.Text.Replace(",",".")+",[val_087]="+textBox99.Text.Replace(",",".")+",[val_088]="+textBox98.Text.Replace(",",".")+",[val_089]="+textBox97.Text.Replace(",",".")+",[val_090]="+textBox96.Text.Replace(",",".")+",[val_091]="+textBox115.Text.Replace(",",".")+",[val_092]="+textBox114.Text.Replace(",",".")+",[val_093]="+textBox113.Text.Replace(",",".")+",[val_094]="+textBox112.Text.Replace(",",".")+",[val_095]="+
								textBox111.Text.Replace(",",".")+",[val_096]="+textBox110.Text.Replace(",",".")+",[val_097]="+textBox109.Text.Replace(",",".")+",[val_098]="+textBox108.Text.Replace(",",".")+",[val_099]="+textBox107.Text.Replace(",",".")+",[val_100]="+textBox106.Text.Replace(",",".")+", Commentaire='"+textBox117.Text+"' where [N° controle]="+textBox7.Text;
						}
						try
						{
							oleDbConnection1.Open();
							Comm.ExecuteNonQuery();
						}
						catch
						{
						}
						finally
						{
							oleDbConnection1.Close();
						}
					}
					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						
						try
						{
							Transac.Commit();
							if(Nouveau)
								MessageBox.Show("Enregistrement terminé");
							else
								MessageBox.Show("Mise à jour terminée");
							button3.Enabled=true;
						}
						catch(Exception exp)
						{
							Transac.Rollback();
							MessageBox.Show(exp.Message);
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
					button2.Enabled=false;
					textBox16.Enabled=false;
					textBox17.Enabled=false;
					textBox18.Enabled=false;
					textBox19.Enabled=false;
					textBox20.Enabled=false;
					textBox21.Enabled=false;
					textBox22.Enabled=false;
					textBox23.Enabled=false;
					textBox24.Enabled=false;
					textBox25.Enabled=false;
					textBox26.Enabled=false;
					textBox27.Enabled=false;
					textBox28.Enabled=false;
					textBox29.Enabled=false;
					textBox30.Enabled=false;
					textBox31.Enabled=false;
					textBox32.Enabled=false;
					textBox33.Enabled=false;
					textBox34.Enabled=false;
					textBox35.Enabled=false;
					textBox36.Enabled=false;
					textBox37.Enabled=false;
					textBox38.Enabled=false;
					textBox39.Enabled=false;
					textBox40.Enabled=false;
					textBox41.Enabled=false;
					textBox42.Enabled=false;
					textBox43.Enabled=false;
					textBox44.Enabled=false;
					textBox45.Enabled=false;
					textBox46.Enabled=false;
					textBox47.Enabled=false;
					textBox48.Enabled=false;
					textBox49.Enabled=false;
					textBox50.Enabled=false;
					textBox51.Enabled=false;
					textBox52.Enabled=false;
					textBox53.Enabled=false;
					textBox54.Enabled=false;
					textBox55.Enabled=false;
					textBox56.Enabled=false;
					textBox57.Enabled=false;
					textBox58.Enabled=false;
					textBox59.Enabled=false;
					textBox60.Enabled=false;
					textBox61.Enabled=false;
					textBox62.Enabled=false;
					textBox63.Enabled=false;
					textBox64.Enabled=false;
					textBox65.Enabled=false;
					textBox66.Enabled=false;
					textBox67.Enabled=false;
					textBox68.Enabled=false;
					textBox69.Enabled=false;
					textBox70.Enabled=false;
					textBox71.Enabled=false;
					textBox72.Enabled=false;
					textBox73.Enabled=false;
					textBox74.Enabled=false;
					textBox75.Enabled=false;
					textBox76.Enabled=false;
					textBox77.Enabled=false;
					textBox78.Enabled=false;
					textBox79.Enabled=false;
					textBox80.Enabled=false;
					textBox81.Enabled=false;
					textBox82.Enabled=false;
					textBox83.Enabled=false;
					textBox84.Enabled=false;
					textBox85.Enabled=false;
					textBox86.Enabled=false;
					textBox87.Enabled=false;
					textBox88.Enabled=false;
					textBox89.Enabled=false;
					textBox90.Enabled=false;
					textBox91.Enabled=false;
					textBox92.Enabled=false;
					textBox93.Enabled=false;
					textBox94.Enabled=false;
					textBox95.Enabled=false;
					textBox96.Enabled=false;
					textBox97.Enabled=false;
					textBox98.Enabled=false;
					textBox99.Enabled=false;
					textBox100.Enabled=false;
					textBox101.Enabled=false;
					textBox102.Enabled=false;
					textBox103.Enabled=false;
					textBox104.Enabled=false;
					textBox105.Enabled=false;
					textBox106.Enabled=false;
					textBox107.Enabled=false;
					textBox108.Enabled=false;
					textBox109.Enabled=false;
					textBox110.Enabled=false;
					textBox111.Enabled=false;
					textBox112.Enabled=false;
					textBox113.Enabled=false;
					textBox114.Enabled=false;
					textBox115.Enabled=false;
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked.Equals(true))
			{
				textBox16.Enabled=true;
				textBox17.Enabled=true;
				textBox18.Enabled=true;
				textBox19.Enabled=true;
				textBox20.Enabled=true;
				textBox21.Enabled=true;
				textBox22.Enabled=true;
				textBox23.Enabled=true;
				textBox24.Enabled=true;
				textBox25.Enabled=true;
				textBox26.Enabled=true;
				textBox27.Enabled=true;
				textBox28.Enabled=true;
				textBox29.Enabled=true;
				textBox30.Enabled=true;
				textBox31.Enabled=true;
				textBox32.Enabled=true;
				textBox33.Enabled=true;
				textBox34.Enabled=true;
				textBox35.Enabled=true;
				textBox36.Enabled=true;
				textBox37.Enabled=true;
				textBox38.Enabled=true;
				textBox39.Enabled=true;
				textBox40.Enabled=true;
				textBox41.Enabled=true;
				textBox42.Enabled=true;
				textBox43.Enabled=true;
				textBox44.Enabled=true;
				textBox45.Enabled=true;
			}
			else if(radioButton2.Checked.Equals(true))
			{
				textBox16.Enabled=true;
				textBox17.Enabled=true;
				textBox18.Enabled=true;
				textBox19.Enabled=true;
				textBox20.Enabled=true;
				textBox21.Enabled=true;
				textBox22.Enabled=true;
				textBox23.Enabled=true;
				textBox24.Enabled=true;
				textBox25.Enabled=true;
				textBox26.Enabled=true;
				textBox27.Enabled=true;
				textBox28.Enabled=true;
				textBox29.Enabled=true;
				textBox30.Enabled=true;
				textBox31.Enabled=true;
				textBox32.Enabled=true;
				textBox33.Enabled=true;
				textBox34.Enabled=true;
				textBox35.Enabled=true;
				textBox36.Enabled=true;
				textBox37.Enabled=true;
				textBox38.Enabled=true;
				textBox39.Enabled=true;
				textBox40.Enabled=true;
				textBox41.Enabled=true;
				textBox42.Enabled=true;
				textBox43.Enabled=true;
				textBox44.Enabled=true;
				textBox45.Enabled=true;
				textBox46.Enabled=true;
				textBox47.Enabled=true;
				textBox48.Enabled=true;
				textBox49.Enabled=true;
				textBox50.Enabled=true;
				textBox51.Enabled=true;
				textBox52.Enabled=true;
				textBox53.Enabled=true;
				textBox54.Enabled=true;
				textBox55.Enabled=true;
				textBox56.Enabled=true;
				textBox57.Enabled=true;
				textBox58.Enabled=true;
				textBox59.Enabled=true;
				textBox60.Enabled=true;
				textBox61.Enabled=true;
				textBox62.Enabled=true;
				textBox63.Enabled=true;
				textBox64.Enabled=true;
				textBox65.Enabled=true;
			}
			else
			{
				textBox16.Enabled=true;
				textBox17.Enabled=true;
				textBox18.Enabled=true;
				textBox19.Enabled=true;
				textBox20.Enabled=true;
				textBox21.Enabled=true;
				textBox22.Enabled=true;
				textBox23.Enabled=true;
				textBox24.Enabled=true;
				textBox25.Enabled=true;
				textBox26.Enabled=true;
				textBox27.Enabled=true;
				textBox28.Enabled=true;
				textBox29.Enabled=true;
				textBox30.Enabled=true;
				textBox31.Enabled=true;
				textBox32.Enabled=true;
				textBox33.Enabled=true;
				textBox34.Enabled=true;
				textBox35.Enabled=true;
				textBox36.Enabled=true;
				textBox37.Enabled=true;
				textBox38.Enabled=true;
				textBox39.Enabled=true;
				textBox40.Enabled=true;
				textBox41.Enabled=true;
				textBox42.Enabled=true;
				textBox43.Enabled=true;
				textBox44.Enabled=true;
				textBox45.Enabled=true;
				textBox46.Enabled=true;
				textBox47.Enabled=true;
				textBox48.Enabled=true;
				textBox49.Enabled=true;
				textBox50.Enabled=true;
				textBox51.Enabled=true;
				textBox52.Enabled=true;
				textBox53.Enabled=true;
				textBox54.Enabled=true;
				textBox55.Enabled=true;
				textBox56.Enabled=true;
				textBox57.Enabled=true;
				textBox58.Enabled=true;
				textBox59.Enabled=true;
				textBox60.Enabled=true;
				textBox61.Enabled=true;
				textBox62.Enabled=true;
				textBox63.Enabled=true;
				textBox64.Enabled=true;
				textBox65.Enabled=true;
				textBox66.Enabled=true;
				textBox67.Enabled=true;
				textBox68.Enabled=true;
				textBox69.Enabled=true;
				textBox70.Enabled=true;
				textBox71.Enabled=true;
				textBox72.Enabled=true;
				textBox73.Enabled=true;
				textBox74.Enabled=true;
				textBox75.Enabled=true;
				textBox76.Enabled=true;
				textBox77.Enabled=true;
				textBox78.Enabled=true;
				textBox79.Enabled=true;
				textBox80.Enabled=true;
				textBox81.Enabled=true;
				textBox82.Enabled=true;
				textBox83.Enabled=true;
				textBox84.Enabled=true;
				textBox85.Enabled=true;
				textBox86.Enabled=true;
				textBox87.Enabled=true;
				textBox88.Enabled=true;
				textBox89.Enabled=true;
				textBox90.Enabled=true;
				textBox91.Enabled=true;
				textBox92.Enabled=true;
				textBox93.Enabled=true;
				textBox94.Enabled=true;
				textBox95.Enabled=true;
				textBox96.Enabled=true;
				textBox97.Enabled=true;
				textBox98.Enabled=true;
				textBox99.Enabled=true;
				textBox100.Enabled=true;
				textBox101.Enabled=true;
				textBox102.Enabled=true;
				textBox103.Enabled=true;
				textBox104.Enabled=true;
				textBox105.Enabled=true;
				textBox106.Enabled=true;
				textBox107.Enabled=true;
				textBox108.Enabled=true;
				textBox109.Enabled=true;
				textBox110.Enabled=true;
				textBox111.Enabled=true;
				textBox112.Enabled=true;
				textBox113.Enabled=true;
				textBox114.Enabled=true;
				textBox115.Enabled=true;
			}
			textBox12.Enabled=true;
			textBox13.Enabled=true;
			textBox14.Enabled=true;
			textBox117.Enabled=true;
			mtgcComboBox1.Enabled=true;
			mtgcComboBox2.Enabled=true;
			mtgcComboBox3.Enabled=true;
			button2.Enabled=true;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked.Equals(true))
			{
				textBox116.Text="Contrôle 30 mesures";
				textBox16.Visible=true;
				textBox17.Visible=true;
				textBox18.Visible=true;
				textBox19.Visible=true;
				textBox20.Visible=true;
				textBox21.Visible=true;
				textBox22.Visible=true;
				textBox23.Visible=true;
				textBox24.Visible=true;
				textBox25.Visible=true;
				textBox26.Visible=true;
				textBox27.Visible=true;
				textBox28.Visible=true;
				textBox29.Visible=true;
				textBox30.Visible=true;
				textBox31.Visible=true;
				textBox32.Visible=true;
				textBox33.Visible=true;
				textBox34.Visible=true;
				textBox35.Visible=true;
				textBox36.Visible=true;
				textBox37.Visible=true;
				textBox38.Visible=true;
				textBox39.Visible=true;
				textBox40.Visible=true;
				textBox41.Visible=true;
				textBox42.Visible=true;
				textBox43.Visible=true;
				textBox44.Visible=true;
				textBox45.Visible=true;
				textBox46.Visible=false;
				textBox47.Visible=false;
				textBox48.Visible=false;
				textBox49.Visible=false;
				textBox50.Visible=false;
				textBox51.Visible=false;
				textBox52.Visible=false;
				textBox53.Visible=false;
				textBox54.Visible=false;
				textBox55.Visible=false;
				textBox56.Visible=false;
				textBox57.Visible=false;
				textBox58.Visible=false;
				textBox59.Visible=false;
				textBox60.Visible=false;
				textBox61.Visible=false;
				textBox62.Visible=false;
				textBox63.Visible=false;
				textBox64.Visible=false;
				textBox65.Visible=false;
				textBox66.Visible=false;
				textBox67.Visible=false;
				textBox68.Visible=false;
				textBox69.Visible=false;
				textBox70.Visible=false;
				textBox71.Visible=false;
				textBox72.Visible=false;
				textBox73.Visible=false;
				textBox74.Visible=false;
				textBox75.Visible=false;
				textBox76.Visible=false;
				textBox77.Visible=false;
				textBox78.Visible=false;
				textBox79.Visible=false;
				textBox80.Visible=false;
				textBox81.Visible=false;
				textBox82.Visible=false;
				textBox83.Visible=false;
				textBox84.Visible=false;
				textBox85.Visible=false;
				textBox86.Visible=false;
				textBox87.Visible=false;
				textBox88.Visible=false;
				textBox89.Visible=false;
				textBox90.Visible=false;
				textBox91.Visible=false;
				textBox92.Visible=false;
				textBox93.Visible=false;
				textBox94.Visible=false;
				textBox95.Visible=false;
				textBox96.Visible=false;
				textBox97.Visible=false;
				textBox98.Visible=false;
				textBox99.Visible=false;
				textBox100.Visible=false;
				textBox101.Visible=false;
				textBox102.Visible=false;
				textBox103.Visible=false;
				textBox104.Visible=false;
				textBox105.Visible=false;
				textBox106.Visible=false;
				textBox107.Visible=false;
				textBox108.Visible=false;
				textBox109.Visible=false;
				textBox110.Visible=false;
				textBox111.Visible=false;
				textBox112.Visible=false;
				textBox113.Visible=false;
				textBox114.Visible=false;
				textBox115.Visible=false;

				textBox16.Enabled=false;
				textBox17.Enabled=false;
				textBox18.Enabled=false;
				textBox19.Enabled=false;
				textBox20.Enabled=false;
				textBox21.Enabled=false;
				textBox22.Enabled=false;
				textBox23.Enabled=false;
				textBox24.Enabled=false;
				textBox25.Enabled=false;
				textBox26.Enabled=false;
				textBox27.Enabled=false;
				textBox28.Enabled=false;
				textBox29.Enabled=false;
				textBox30.Enabled=false;
				textBox31.Enabled=false;
				textBox32.Enabled=false;
				textBox33.Enabled=false;
				textBox34.Enabled=false;
				textBox35.Enabled=false;
				textBox36.Enabled=false;
				textBox37.Enabled=false;
				textBox38.Enabled=false;
				textBox39.Enabled=false;
				textBox40.Enabled=false;
				textBox41.Enabled=false;
				textBox42.Enabled=false;
				textBox43.Enabled=false;
				textBox44.Enabled=false;
				textBox45.Enabled=false;
				textBox46.Enabled=false;
				textBox47.Enabled=false;
				textBox48.Enabled=false;
				textBox49.Enabled=false;
				textBox50.Enabled=false;
				textBox51.Enabled=false;
				textBox52.Enabled=false;
				textBox53.Enabled=false;
				textBox54.Enabled=false;
				textBox55.Enabled=false;
				textBox56.Enabled=false;
				textBox57.Enabled=false;
				textBox58.Enabled=false;
				textBox59.Enabled=false;
				textBox60.Enabled=false;
				textBox61.Enabled=false;
				textBox62.Enabled=false;
				textBox63.Enabled=false;
				textBox64.Enabled=false;
				textBox65.Enabled=false;
				textBox66.Enabled=false;
				textBox67.Enabled=false;
				textBox68.Enabled=false;
				textBox69.Enabled=false;
				textBox70.Enabled=false;
				textBox71.Enabled=false;
				textBox72.Enabled=false;
				textBox73.Enabled=false;
				textBox74.Enabled=false;
				textBox75.Enabled=false;
				textBox76.Enabled=false;
				textBox77.Enabled=false;
				textBox78.Enabled=false;
				textBox79.Enabled=false;
				textBox80.Enabled=false;
				textBox81.Enabled=false;
				textBox82.Enabled=false;
				textBox83.Enabled=false;
				textBox84.Enabled=false;
				textBox85.Enabled=false;
				textBox86.Enabled=false;
				textBox87.Enabled=false;
				textBox88.Enabled=false;
				textBox89.Enabled=false;
				textBox90.Enabled=false;
				textBox91.Enabled=false;
				textBox92.Enabled=false;
				textBox93.Enabled=false;
				textBox94.Enabled=false;
				textBox95.Enabled=false;
				textBox96.Enabled=false;
				textBox97.Enabled=false;
				textBox98.Enabled=false;
				textBox99.Enabled=false;
				textBox100.Enabled=false;
				textBox101.Enabled=false;
				textBox102.Enabled=false;
				textBox103.Enabled=false;
				textBox104.Enabled=false;
				textBox105.Enabled=false;
				textBox106.Enabled=false;
				textBox107.Enabled=false;
				textBox108.Enabled=false;
				textBox109.Enabled=false;
				textBox110.Enabled=false;
				textBox111.Enabled=false;
				textBox112.Enabled=false;
				textBox113.Enabled=false;
				textBox114.Enabled=false;
				textBox115.Enabled=false;
			}
		}

		private void textBox16_Leave(object sender, System.EventArgs e)
		{
			if(textBox16.TextLength>0)
			{
				
				try
				{
					textBox16.Text=textBox16.Text.Replace(".",",");
					textBox16.Text=System.Convert.ToDecimal(textBox16.Text).ToString("0.000");
					textBox16.Text=textBox16.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox17_Leave(object sender, System.EventArgs e)
		{
			if(textBox17.TextLength>0)
			{
				
				try
				{
					textBox17.Text=textBox17.Text.Replace(".",",");
					textBox17.Text=System.Convert.ToDecimal(textBox17.Text).ToString("0.000");
					textBox17.Text=textBox17.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox18_Leave(object sender, System.EventArgs e)
		{
			if(textBox18.TextLength>0)
			{
				
				try
				{
					textBox18.Text=textBox18.Text.Replace(".",",");
					textBox18.Text=System.Convert.ToDecimal(textBox18.Text).ToString("0.000");
					textBox18.Text=textBox18.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox19_Leave(object sender, System.EventArgs e)
		{
			if(textBox19.TextLength>0)
			{
				
				try
				{
					textBox19.Text=textBox19.Text.Replace(".",",");
					textBox19.Text=System.Convert.ToDecimal(textBox19.Text).ToString("0.000");
					textBox19.Text=textBox19.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox20_Leave(object sender, System.EventArgs e)
		{
			if(textBox20.TextLength>0)
			{
				
				try
				{
					textBox20.Text=textBox20.Text.Replace(".",",");
					textBox20.Text=System.Convert.ToDecimal(textBox20.Text).ToString("0.000");
					textBox20.Text=textBox20.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox21_Leave(object sender, System.EventArgs e)
		{
			if(textBox21.TextLength>0)
			{
				
				try
				{
					textBox21.Text=textBox21.Text.Replace(".",",");
					textBox21.Text=System.Convert.ToDecimal(textBox21.Text).ToString("0.000");
					textBox21.Text=textBox21.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox22_Leave(object sender, System.EventArgs e)
		{
			if(textBox22.TextLength>0)
			{
				
				try
				{
					textBox22.Text=textBox22.Text.Replace(".",",");
					textBox22.Text=System.Convert.ToDecimal(textBox22.Text).ToString("0.000");
					textBox22.Text=textBox22.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox23_Leave(object sender, System.EventArgs e)
		{
			if(textBox23.TextLength>0)
			{
				
				try
				{
					textBox23.Text=textBox23.Text.Replace(".",",");
					textBox23.Text=System.Convert.ToDecimal(textBox23.Text).ToString("0.000");
					textBox23.Text=textBox23.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox24_Leave(object sender, System.EventArgs e)
		{
			if(textBox24.TextLength>0)
			{
				
				try
				{
					textBox24.Text=textBox24.Text.Replace(".",",");
					textBox24.Text=System.Convert.ToDecimal(textBox24.Text).ToString("0.000");
					textBox24.Text=textBox24.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox25_Leave(object sender, System.EventArgs e)
		{
			if(textBox25.TextLength>0)
			{
				
				try
				{
					textBox25.Text=textBox25.Text.Replace(".",",");
					textBox25.Text=System.Convert.ToDecimal(textBox25.Text).ToString("0.000");
					textBox25.Text=textBox25.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox35_Leave(object sender, System.EventArgs e)
		{
			if(textBox35.TextLength>0)
			{
				
				try
				{
					textBox35.Text=textBox35.Text.Replace(".",",");
					textBox35.Text=System.Convert.ToDecimal(textBox35.Text).ToString("0.000");
					textBox35.Text=textBox35.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox34_Leave(object sender, System.EventArgs e)
		{
			if(textBox34.TextLength>0)
			{
				
				try
				{
					textBox34.Text=textBox34.Text.Replace(".",",");
					textBox34.Text=System.Convert.ToDecimal(textBox34.Text).ToString("0.000");
					textBox34.Text=textBox34.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox33_Leave(object sender, System.EventArgs e)
		{
			if(textBox33.TextLength>0)
			{
				
				try
				{
					textBox33.Text=textBox33.Text.Replace(".",",");
					textBox33.Text=System.Convert.ToDecimal(textBox33.Text).ToString("0.000");
					textBox33.Text=textBox33.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox32_Leave(object sender, System.EventArgs e)
		{
			if(textBox32.TextLength>0)
			{
				
				try
				{
					textBox32.Text=textBox32.Text.Replace(".",",");
					textBox32.Text=System.Convert.ToDecimal(textBox32.Text).ToString("0.000");
					textBox32.Text=textBox32.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox31_Leave(object sender, System.EventArgs e)
		{
			if(textBox31.TextLength>0)
			{
				
				try
				{
					textBox31.Text=textBox31.Text.Replace(".",",");
					textBox31.Text=System.Convert.ToDecimal(textBox31.Text).ToString("0.000");
					textBox31.Text=textBox31.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox30_Leave(object sender, System.EventArgs e)
		{
			if(textBox30.TextLength>0)
			{
				
				try
				{
					textBox30.Text=textBox30.Text.Replace(".",",");
					textBox30.Text=System.Convert.ToDecimal(textBox30.Text).ToString("0.000");
					textBox30.Text=textBox30.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox29_Leave(object sender, System.EventArgs e)
		{
			if(textBox29.TextLength>0)
			{
				
				try
				{
					textBox29.Text=textBox29.Text.Replace(".",",");
					textBox29.Text=System.Convert.ToDecimal(textBox29.Text).ToString("0.000");
					textBox29.Text=textBox29.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox28_Leave(object sender, System.EventArgs e)
		{
			if(textBox28.TextLength>0)
			{
				
				try
				{
					textBox28.Text=textBox28.Text.Replace(".",",");
					textBox28.Text=System.Convert.ToDecimal(textBox28.Text).ToString("0.000");
					textBox28.Text=textBox28.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox27_Leave(object sender, System.EventArgs e)
		{
			if(textBox27.TextLength>0)
			{
				
				try
				{
					textBox27.Text=textBox27.Text.Replace(".",",");
					textBox27.Text=System.Convert.ToDecimal(textBox27.Text).ToString("0.000");
					textBox27.Text=textBox27.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox26_Leave(object sender, System.EventArgs e)
		{
			if(textBox26.TextLength>0)
			{
				
				try
				{
					textBox26.Text=textBox26.Text.Replace(".",",");
					textBox26.Text=System.Convert.ToDecimal(textBox26.Text).ToString("0.000");
					textBox26.Text=textBox26.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox45_Leave(object sender, System.EventArgs e)
		{
			if(textBox45.TextLength>0)
			{
				
				try
				{
					textBox45.Text=textBox45.Text.Replace(".",",");
					textBox45.Text=System.Convert.ToDecimal(textBox45.Text).ToString("0.000");
					textBox45.Text=textBox45.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox44_Leave(object sender, System.EventArgs e)
		{
			if(textBox44.TextLength>0)
			{
				
				try
				{
					textBox44.Text=textBox44.Text.Replace(".",",");
					textBox44.Text=System.Convert.ToDecimal(textBox44.Text).ToString("0.000");
					textBox44.Text=textBox44.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox43_Leave(object sender, System.EventArgs e)
		{
			if(textBox43.TextLength>0)
			{
				
				try
				{
					textBox43.Text=textBox43.Text.Replace(".",",");
					textBox43.Text=System.Convert.ToDecimal(textBox43.Text).ToString("0.000");
					textBox43.Text=textBox43.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox42_Leave(object sender, System.EventArgs e)
		{
			if(textBox42.TextLength>0)
			{
				
				try
				{
					textBox42.Text=textBox42.Text.Replace(".",",");
					textBox42.Text=System.Convert.ToDecimal(textBox42.Text).ToString("0.000");
					textBox42.Text=textBox42.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox41_Leave(object sender, System.EventArgs e)
		{
			if(textBox41.TextLength>0)
			{
				
				try
				{
					textBox41.Text=textBox41.Text.Replace(".",",");
					textBox41.Text=System.Convert.ToDecimal(textBox41.Text).ToString("0.000");
					textBox41.Text=textBox41.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox40_Leave(object sender, System.EventArgs e)
		{
			if(textBox40.TextLength>0)
			{
				
				try
				{
					textBox40.Text=textBox40.Text.Replace(".",",");
					textBox40.Text=System.Convert.ToDecimal(textBox40.Text).ToString("0.000");
					textBox40.Text=textBox40.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox39_Leave(object sender, System.EventArgs e)
		{
			if(textBox39.TextLength>0)
			{
				
				try
				{
					textBox39.Text=textBox39.Text.Replace(".",",");
					textBox39.Text=System.Convert.ToDecimal(textBox39.Text).ToString("0.000");
					textBox39.Text=textBox39.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox38_Leave(object sender, System.EventArgs e)
		{
			if(textBox38.TextLength>0)
			{
				
				try
				{
					textBox38.Text=textBox38.Text.Replace(".",",");
					textBox38.Text=System.Convert.ToDecimal(textBox38.Text).ToString("0.000");
					textBox38.Text=textBox38.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox37_Leave(object sender, System.EventArgs e)
		{
			if(textBox37.TextLength>0)
			{
				
				try
				{
					textBox37.Text=textBox37.Text.Replace(".",",");
					textBox37.Text=System.Convert.ToDecimal(textBox37.Text).ToString("0.000");
					textBox37.Text=textBox37.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox36_Leave(object sender, System.EventArgs e)
		{
			if(textBox36.TextLength>0)
			{
				
				try
				{
					textBox36.Text=textBox36.Text.Replace(".",",");
					textBox36.Text=System.Convert.ToDecimal(textBox36.Text).ToString("0.000");
					textBox36.Text=textBox36.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox55_Leave(object sender, System.EventArgs e)
		{
			if(textBox55.TextLength>0)
			{
				
				try
				{
					textBox55.Text=textBox55.Text.Replace(".",",");
					textBox55.Text=System.Convert.ToDecimal(textBox55.Text).ToString("0.000");
					textBox55.Text=textBox55.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox54_Leave(object sender, System.EventArgs e)
		{
			if(textBox54.TextLength>0)
			{
				
				try
				{
					textBox54.Text=textBox54.Text.Replace(".",",");
					textBox54.Text=System.Convert.ToDecimal(textBox54.Text).ToString("0.000");
					textBox54.Text=textBox54.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox53_Leave(object sender, System.EventArgs e)
		{
			if(textBox53.TextLength>0)
			{
				
				try
				{
					textBox53.Text=textBox53.Text.Replace(".",",");
					textBox53.Text=System.Convert.ToDecimal(textBox53.Text).ToString("0.000");
					textBox53.Text=textBox53.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox52_Leave(object sender, System.EventArgs e)
		{
			if(textBox52.TextLength>0)
			{
				
				try
				{
					textBox52.Text=textBox52.Text.Replace(".",",");
					textBox52.Text=System.Convert.ToDecimal(textBox52.Text).ToString("0.000");
					textBox52.Text=textBox52.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox51_Leave(object sender, System.EventArgs e)
		{
			if(textBox51.TextLength>0)
			{
				
				try
				{
					textBox51.Text=textBox51.Text.Replace(".",",");
					textBox51.Text=System.Convert.ToDecimal(textBox51.Text).ToString("0.000");
					textBox51.Text=textBox51.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox50_Leave(object sender, System.EventArgs e)
		{
			if(textBox50.TextLength>0)
			{
				
				try
				{
					textBox50.Text=textBox50.Text.Replace(".",",");
					textBox50.Text=System.Convert.ToDecimal(textBox50.Text).ToString("0.000");
					textBox50.Text=textBox50.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox49_Leave(object sender, System.EventArgs e)
		{
			if(textBox49.TextLength>0)
			{
				
				try
				{
					textBox49.Text=textBox49.Text.Replace(".",",");
					textBox49.Text=System.Convert.ToDecimal(textBox49.Text).ToString("0.000");
					textBox49.Text=textBox49.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox48_Leave(object sender, System.EventArgs e)
		{
			if(textBox48.TextLength>0)
			{
				
				try
				{
					textBox48.Text=textBox48.Text.Replace(".",",");
					textBox48.Text=System.Convert.ToDecimal(textBox48.Text).ToString("0.000");
					textBox48.Text=textBox48.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox47_Leave(object sender, System.EventArgs e)
		{
			if(textBox47.TextLength>0)
			{
				
				try
				{
					textBox47.Text=textBox47.Text.Replace(".",",");
					textBox47.Text=System.Convert.ToDecimal(textBox47.Text).ToString("0.000");
					textBox47.Text=textBox47.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox46_Leave(object sender, System.EventArgs e)
		{
			if(textBox46.TextLength>0)
			{
				
				try
				{
					textBox46.Text=textBox46.Text.Replace(".",",");
					textBox46.Text=System.Convert.ToDecimal(textBox46.Text).ToString("0.000");
					textBox46.Text=textBox46.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox65_Leave(object sender, System.EventArgs e)
		{
			if(textBox65.TextLength>0)
			{
				
				try
				{
					textBox65.Text=textBox65.Text.Replace(".",",");
					textBox65.Text=System.Convert.ToDecimal(textBox65.Text).ToString("0.000");
					textBox65.Text=textBox65.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox64_Leave(object sender, System.EventArgs e)
		{
			if(textBox64.TextLength>0)
			{
				
				try
				{
					textBox64.Text=textBox64.Text.Replace(".",",");
					textBox64.Text=System.Convert.ToDecimal(textBox64.Text).ToString("0.000");
					textBox64.Text=textBox64.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox63_Leave(object sender, System.EventArgs e)
		{
			if(textBox63.TextLength>0)
			{
				
				try
				{
					textBox63.Text=textBox63.Text.Replace(".",",");
					textBox63.Text=System.Convert.ToDecimal(textBox63.Text).ToString("0.000");
					textBox63.Text=textBox63.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox62_Leave(object sender, System.EventArgs e)
		{
			if(textBox62.TextLength>0)
			{
				
				try
				{
					textBox62.Text=textBox62.Text.Replace(".",",");
					textBox62.Text=System.Convert.ToDecimal(textBox62.Text).ToString("0.000");
					textBox62.Text=textBox62.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox61_Leave(object sender, System.EventArgs e)
		{
			if(textBox61.TextLength>0)
			{
				
				try
				{
					textBox61.Text=textBox61.Text.Replace(".",",");
					textBox61.Text=System.Convert.ToDecimal(textBox61.Text).ToString("0.000");
					textBox61.Text=textBox61.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox60_Leave(object sender, System.EventArgs e)
		{
			if(textBox60.TextLength>0)
			{
				
				try
				{
					textBox60.Text=textBox60.Text.Replace(".",",");
					textBox60.Text=System.Convert.ToDecimal(textBox60.Text).ToString("0.000");
					textBox60.Text=textBox60.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox59_Leave(object sender, System.EventArgs e)
		{
			if(textBox59.TextLength>0)
			{
				
				try
				{
					textBox59.Text=textBox59.Text.Replace(".",",");
					textBox59.Text=System.Convert.ToDecimal(textBox59.Text).ToString("0.000");
					textBox59.Text=textBox59.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox58_Leave(object sender, System.EventArgs e)
		{
			if(textBox58.TextLength>0)
			{
				
				try
				{
					textBox58.Text=textBox58.Text.Replace(".",",");
					textBox58.Text=System.Convert.ToDecimal(textBox58.Text).ToString("0.000");
					textBox58.Text=textBox58.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox57_Leave(object sender, System.EventArgs e)
		{
			if(textBox57.TextLength>0)
			{
				
				try
				{
					textBox57.Text=textBox57.Text.Replace(".",",");
					textBox57.Text=System.Convert.ToDecimal(textBox57.Text).ToString("0.000");
					textBox57.Text=textBox57.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox56_Leave(object sender, System.EventArgs e)
		{
			if(textBox56.TextLength>0)
			{
				
				try
				{
					textBox56.Text=textBox56.Text.Replace(".",",");
					textBox56.Text=System.Convert.ToDecimal(textBox56.Text).ToString("0.000");
					textBox56.Text=textBox56.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox75_Leave(object sender, System.EventArgs e)
		{
			if(textBox75.TextLength>0)
			{
				
				try
				{
					textBox75.Text=textBox75.Text.Replace(".",",");
					textBox75.Text=System.Convert.ToDecimal(textBox75.Text).ToString("0.000");
					textBox75.Text=textBox75.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox74_Leave(object sender, System.EventArgs e)
		{
			if(textBox74.TextLength>0)
			{
				
				try
				{
					textBox74.Text=textBox74.Text.Replace(".",",");
					textBox74.Text=System.Convert.ToDecimal(textBox74.Text).ToString("0.000");
					textBox74.Text=textBox74.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox73_Leave(object sender, System.EventArgs e)
		{
			if(textBox73.TextLength>0)
			{
				
				try
				{
					textBox73.Text=textBox73.Text.Replace(".",",");
					textBox73.Text=System.Convert.ToDecimal(textBox73.Text).ToString("0.000");
					textBox73.Text=textBox73.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox72_Leave(object sender, System.EventArgs e)
		{
			if(textBox72.TextLength>0)
			{
				
				try
				{
					textBox72.Text=textBox72.Text.Replace(".",",");
					textBox72.Text=System.Convert.ToDecimal(textBox72.Text).ToString("0.000");
					textBox72.Text=textBox72.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox71_Leave(object sender, System.EventArgs e)
		{
			if(textBox71.TextLength>0)
			{
				
				try
				{
					textBox71.Text=textBox71.Text.Replace(".",",");
					textBox71.Text=System.Convert.ToDecimal(textBox71.Text).ToString("0.000");
					textBox71.Text=textBox71.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox70_Leave(object sender, System.EventArgs e)
		{
			if(textBox70.TextLength>0)
			{
				
				try
				{
					textBox70.Text=textBox70.Text.Replace(".",",");
					textBox70.Text=System.Convert.ToDecimal(textBox70.Text).ToString("0.000");
					textBox70.Text=textBox70.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox69_Leave(object sender, System.EventArgs e)
		{
			if(textBox69.TextLength>0)
			{
				
				try
				{
					textBox69.Text=textBox69.Text.Replace(".",",");
					textBox69.Text=System.Convert.ToDecimal(textBox69.Text).ToString("0.000");
					textBox69.Text=textBox69.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox68_Leave(object sender, System.EventArgs e)
		{
			if(textBox68.TextLength>0)
			{
				
				try
				{
					textBox68.Text=textBox68.Text.Replace(".",",");
					textBox68.Text=System.Convert.ToDecimal(textBox68.Text).ToString("0.000");
					textBox68.Text=textBox68.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox67_Leave(object sender, System.EventArgs e)
		{
			if(textBox67.TextLength>0)
			{
				
				try
				{
					textBox67.Text=textBox67.Text.Replace(".",",");
					textBox67.Text=System.Convert.ToDecimal(textBox67.Text).ToString("0.000");
					textBox67.Text=textBox67.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox66_Leave(object sender, System.EventArgs e)
		{
			if(textBox66.TextLength>0)
			{
				
				try
				{
					textBox66.Text=textBox66.Text.Replace(".",",");
					textBox66.Text=System.Convert.ToDecimal(textBox66.Text).ToString("0.000");
					textBox66.Text=textBox66.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox85_Leave(object sender, System.EventArgs e)
		{
			if(textBox85.TextLength>0)
			{
				
				try
				{
					textBox85.Text=textBox85.Text.Replace(".",",");
					textBox85.Text=System.Convert.ToDecimal(textBox85.Text).ToString("0.000");
					textBox85.Text=textBox85.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox84_Leave(object sender, System.EventArgs e)
		{
			if(textBox84.TextLength>0)
			{
				
				try
				{
					textBox84.Text=textBox84.Text.Replace(".",",");
					textBox84.Text=System.Convert.ToDecimal(textBox84.Text).ToString("0.000");
					textBox84.Text=textBox84.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox83_Leave(object sender, System.EventArgs e)
		{
			if(textBox83.TextLength>0)
			{
				
				try
				{
					textBox83.Text=textBox83.Text.Replace(".",",");
					textBox83.Text=System.Convert.ToDecimal(textBox83.Text).ToString("0.000");
					textBox83.Text=textBox83.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox82_Leave(object sender, System.EventArgs e)
		{
			if(textBox82.TextLength>0)
			{
				
				try
				{
					textBox82.Text=textBox82.Text.Replace(".",",");
					textBox82.Text=System.Convert.ToDecimal(textBox82.Text).ToString("0.000");
					textBox82.Text=textBox82.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox81_Leave(object sender, System.EventArgs e)
		{
			if(textBox81.TextLength>0)
			{
				
				try
				{
					textBox81.Text=textBox81.Text.Replace(".",",");
					textBox81.Text=System.Convert.ToDecimal(textBox81.Text).ToString("0.000");
					textBox81.Text=textBox81.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox80_Leave(object sender, System.EventArgs e)
		{
			if(textBox80.TextLength>0)
			{
				
				try
				{
					textBox80.Text=textBox80.Text.Replace(".",",");
					textBox80.Text=System.Convert.ToDecimal(textBox80.Text).ToString("0.000");
					textBox80.Text=textBox80.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox79_Leave(object sender, System.EventArgs e)
		{
			if(textBox79.TextLength>0)
			{
				
				try
				{
					textBox79.Text=textBox79.Text.Replace(".",",");
					textBox79.Text=System.Convert.ToDecimal(textBox79.Text).ToString("0.000");
					textBox79.Text=textBox79.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox78_Leave(object sender, System.EventArgs e)
		{
			if(textBox78.TextLength>0)
			{
				
				try
				{
					textBox78.Text=textBox78.Text.Replace(".",",");
					textBox78.Text=System.Convert.ToDecimal(textBox78.Text).ToString("0.000");
					textBox78.Text=textBox78.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox77_Leave(object sender, System.EventArgs e)
		{
			if(textBox77.TextLength>0)
			{
				
				try
				{
					textBox77.Text=textBox77.Text.Replace(".",",");
					textBox77.Text=System.Convert.ToDecimal(textBox77.Text).ToString("0.000");
					textBox77.Text=textBox77.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox76_Leave(object sender, System.EventArgs e)
		{
			if(textBox76.TextLength>0)
			{
				
				try
				{
					textBox76.Text=textBox76.Text.Replace(".",",");
					textBox76.Text=System.Convert.ToDecimal(textBox76.Text).ToString("0.000");
					textBox76.Text=textBox76.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox95_Leave(object sender, System.EventArgs e)
		{
			if(textBox95.TextLength>0)
			{
				
				try
				{
					textBox95.Text=textBox95.Text.Replace(".",",");
					textBox95.Text=System.Convert.ToDecimal(textBox95.Text).ToString("0.000");
					textBox95.Text=textBox95.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox94_Leave(object sender, System.EventArgs e)
		{
			if(textBox94.TextLength>0)
			{
				
				try
				{
					textBox94.Text=textBox94.Text.Replace(".",",");
					textBox94.Text=System.Convert.ToDecimal(textBox94.Text).ToString("0.000");
					textBox94.Text=textBox94.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox93_Leave(object sender, System.EventArgs e)
		{
			if(textBox93.TextLength>0)
			{
				
				try
				{
					textBox93.Text=textBox93.Text.Replace(".",",");
					textBox93.Text=System.Convert.ToDecimal(textBox93.Text).ToString("0.000");
					textBox93.Text=textBox93.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox92_Leave(object sender, System.EventArgs e)
		{
			if(textBox92.TextLength>0)
			{
				
				try
				{
					textBox92.Text=textBox92.Text.Replace(".",",");
					textBox92.Text=System.Convert.ToDecimal(textBox92.Text).ToString("0.000");
					textBox92.Text=textBox92.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox91_Leave(object sender, System.EventArgs e)
		{
			if(textBox91.TextLength>0)
			{
				
				try
				{
					textBox91.Text=textBox91.Text.Replace(".",",");
					textBox91.Text=System.Convert.ToDecimal(textBox91.Text).ToString("0.000");
					textBox91.Text=textBox91.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox90_Leave(object sender, System.EventArgs e)
		{
			if(textBox90.TextLength>0)
			{
				
				try
				{
					textBox90.Text=textBox90.Text.Replace(".",",");
					textBox90.Text=System.Convert.ToDecimal(textBox90.Text).ToString("0.000");
					textBox90.Text=textBox90.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox89_Leave(object sender, System.EventArgs e)
		{
			if(textBox89.TextLength>0)
			{
				
				try
				{
					textBox89.Text=textBox89.Text.Replace(".",",");
					textBox89.Text=System.Convert.ToDecimal(textBox89.Text).ToString("0.000");
					textBox89.Text=textBox89.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox88_Leave(object sender, System.EventArgs e)
		{
			if(textBox88.TextLength>0)
			{
				
				try
				{
					textBox88.Text=textBox88.Text.Replace(".",",");
					textBox88.Text=System.Convert.ToDecimal(textBox88.Text).ToString("0.000");
					textBox88.Text=textBox88.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox87_Leave(object sender, System.EventArgs e)
		{
			if(textBox87.TextLength>0)
			{
				
				try
				{
					textBox87.Text=textBox87.Text.Replace(".",",");
					textBox87.Text=System.Convert.ToDecimal(textBox87.Text).ToString("0.000");
					textBox87.Text=textBox87.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox86_Leave(object sender, System.EventArgs e)
		{
			if(textBox86.TextLength>0)
			{
				
				try
				{
					textBox86.Text=textBox86.Text.Replace(".",",");
					textBox86.Text=System.Convert.ToDecimal(textBox86.Text).ToString("0.000");
					textBox86.Text=textBox86.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox105_Leave(object sender, System.EventArgs e)
		{
			if(textBox105.TextLength>0)
			{
				
				try
				{
					textBox105.Text=textBox105.Text.Replace(".",",");
					textBox105.Text=System.Convert.ToDecimal(textBox105.Text).ToString("0.000");
					textBox105.Text=textBox105.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox104_Leave(object sender, System.EventArgs e)
		{
			if(textBox104.TextLength>0)
			{
				
				try
				{
					textBox104.Text=textBox104.Text.Replace(".",",");
					textBox104.Text=System.Convert.ToDecimal(textBox104.Text).ToString("0.000");
					textBox104.Text=textBox104.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox103_Leave(object sender, System.EventArgs e)
		{
			if(textBox103.TextLength>0)
			{
				
				try
				{
					textBox103.Text=textBox103.Text.Replace(".",",");
					textBox103.Text=System.Convert.ToDecimal(textBox103.Text).ToString("0.000");
					textBox103.Text=textBox103.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox102_Leave(object sender, System.EventArgs e)
		{
			if(textBox102.TextLength>0)
			{
				
				try
				{
					textBox102.Text=textBox102.Text.Replace(".",",");
					textBox102.Text=System.Convert.ToDecimal(textBox102.Text).ToString("0.000");
					textBox102.Text=textBox102.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox101_Leave(object sender, System.EventArgs e)
		{
			if(textBox101.TextLength>0)
			{
				
				try
				{
					textBox101.Text=textBox101.Text.Replace(".",",");
					textBox101.Text=System.Convert.ToDecimal(textBox101.Text).ToString("0.000");
					textBox101.Text=textBox101.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox100_Leave(object sender, System.EventArgs e)
		{
			if(textBox100.TextLength>0)
			{
				
				try
				{
					textBox100.Text=textBox100.Text.Replace(".",",");
					textBox100.Text=System.Convert.ToDecimal(textBox100.Text).ToString("0.000");
					textBox100.Text=textBox100.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox99_Leave(object sender, System.EventArgs e)
		{
			if(textBox99.TextLength>0)
			{
				
				try
				{
					textBox99.Text=textBox99.Text.Replace(".",",");
					textBox99.Text=System.Convert.ToDecimal(textBox99.Text).ToString("0.000");
					textBox99.Text=textBox99.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox98_Leave(object sender, System.EventArgs e)
		{
			if(textBox98.TextLength>0)
			{
				
				try
				{
					textBox98.Text=textBox98.Text.Replace(".",",");
					textBox98.Text=System.Convert.ToDecimal(textBox98.Text).ToString("0.000");
					textBox98.Text=textBox98.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox97_Leave(object sender, System.EventArgs e)
		{
			if(textBox97.TextLength>0)
			{
				
				try
				{
					textBox97.Text=textBox97.Text.Replace(".",",");
					textBox97.Text=System.Convert.ToDecimal(textBox97.Text).ToString("0.000");
					textBox97.Text=textBox97.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox96_Leave(object sender, System.EventArgs e)
		{
			if(textBox96.TextLength>0)
			{
				
				try
				{
					textBox96.Text=textBox96.Text.Replace(".",",");
					textBox96.Text=System.Convert.ToDecimal(textBox96.Text).ToString("0.000");
					textBox96.Text=textBox96.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox115_Leave(object sender, System.EventArgs e)
		{
			if(textBox115.TextLength>0)
			{
				
				try
				{
					textBox115.Text=textBox115.Text.Replace(".",",");
					textBox115.Text=System.Convert.ToDecimal(textBox115.Text).ToString("0.000");
					textBox115.Text=textBox115.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox114_Leave(object sender, System.EventArgs e)
		{
			if(textBox114.TextLength>0)
			{
				
				try
				{
					textBox114.Text=textBox114.Text.Replace(".",",");
					textBox114.Text=System.Convert.ToDecimal(textBox114.Text).ToString("0.000");
					textBox114.Text=textBox114.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox113_Leave(object sender, System.EventArgs e)
		{
			if(textBox113.TextLength>0)
			{
				
				try
				{
					textBox113.Text=textBox113.Text.Replace(".",",");
					textBox113.Text=System.Convert.ToDecimal(textBox113.Text).ToString("0.000");
					textBox113.Text=textBox113.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox112_Leave(object sender, System.EventArgs e)
		{
			if(textBox112.TextLength>0)
			{
				
				try
				{
					textBox112.Text=textBox112.Text.Replace(".",",");
					textBox112.Text=System.Convert.ToDecimal(textBox112.Text).ToString("0.000");
					textBox112.Text=textBox112.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox111_Leave(object sender, System.EventArgs e)
		{
			if(textBox111.TextLength>0)
			{
				
				try
				{
					textBox111.Text=textBox111.Text.Replace(".",",");
					textBox111.Text=System.Convert.ToDecimal(textBox111.Text).ToString("0.000");
					textBox111.Text=textBox111.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox110_Leave(object sender, System.EventArgs e)
		{
			if(textBox110.TextLength>0)
			{
				
				try
				{
					textBox110.Text=textBox110.Text.Replace(".",",");
					textBox110.Text=System.Convert.ToDecimal(textBox110.Text).ToString("0.000");
					textBox110.Text=textBox110.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox109_Leave(object sender, System.EventArgs e)
		{
			if(textBox109.TextLength>0)
			{
				
				try
				{
					textBox109.Text=textBox109.Text.Replace(".",",");
					textBox109.Text=System.Convert.ToDecimal(textBox109.Text).ToString("0.000");
					textBox109.Text=textBox109.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox108_Leave(object sender, System.EventArgs e)
		{
			if(textBox108.TextLength>0)
			{
				
				try
				{
					textBox108.Text=textBox108.Text.Replace(".",",");
					textBox108.Text=System.Convert.ToDecimal(textBox108.Text).ToString("0.000");
					textBox108.Text=textBox108.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox107_Leave(object sender, System.EventArgs e)
		{
			if(textBox107.TextLength>0)
			{
				
				try
				{
					textBox107.Text=textBox107.Text.Replace(".",",");
					textBox107.Text=System.Convert.ToDecimal(textBox107.Text).ToString("0.000");
					textBox107.Text=textBox107.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void textBox106_Leave(object sender, System.EventArgs e)
		{
			if(textBox106.TextLength>0)
			{
				
				try
				{
					textBox106.Text=textBox106.Text.Replace(".",",");
					textBox106.Text=System.Convert.ToDecimal(textBox106.Text).ToString("0.000");
					textBox106.Text=textBox106.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}
		private void button5_Click(object sender, System.EventArgs e)
		{
			if(textBox9.TextLength.Equals(0)||textBox10.TextLength.Equals(0)||textBox11.TextLength.Equals(0)||textBox12.TextLength.Equals(0)||textBox13.TextLength.Equals(0)||textBox14.TextLength.Equals(0))
			{
				MessageBox.Show("Paramètres manquants !");
			}
			else
			{
				Comm.CommandText="SELECT T_clients.Nom, T_clients.Adresse_1, T_clients.Adresse_2, T_clients.Code_Postal, T_clients.Ville FROM T_clients WHERE T_clients.Ident="+idcli.Text+" GROUP BY T_clients.Nom, T_clients.Adresse_1, T_clients.Adresse_2, T_clients.Code_Postal, T_clients.Ville";
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"client");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}

                Microsoft.Office.Interop.Excel.Application oXL;                
                
				Microsoft.Office.Interop.Excel._Workbook oWB; 
				Microsoft.Office.Interop.Excel._Worksheet oSheet; 
				Microsoft.Office.Interop.Excel.Range oRng;

				oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.UseSystemSeparators = false;
                oXL.DecimalSeparator = ",";
                oXL.Application.Visible=false;

                if (Directory.Exists(@"C:\Program Files (x86)\Opindus\Excel\" + textBox1.Text.Replace("/", "-") + @"\") == false)
				{
					DirectoryInfo repertoire = Directory.CreateDirectory(@"C:\Program Files (x86)\Opindus\Excel\"+textBox1.Text.Replace("/","-")+@"\"); 
				}
			
				if(radioButton1.Checked)
				{
					oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\modeles\controle_30.xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);
			
					oWB = (Microsoft.Office.Interop.Excel._Workbook)oXL.Workbooks[1];
					oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1];
					
					oSheet.Cells[2,2] = ds.Tables["Client"].Rows[0]["nom"].ToString();
					oSheet.Cells[3,2] = ds.Tables["Client"].Rows[0]["adresse_1"].ToString();
					oSheet.Cells[4,2] = ds.Tables["Client"].Rows[0]["adresse_2"].ToString();
					oSheet.Cells[5,2] = ds.Tables["Client"].Rows[0]["code_postal"].ToString()+" "+ds.Tables["Client"].Rows[0]["ville"].ToString();
					oSheet.Cells[9,2] = textBox7.Text.Replace(".",",");
					oSheet.Cells[9,17] = textBox8.Text.Replace(".",",");
                    Range rg = (Range)oSheet.Cells[10,17];
                    rg.ClearFormats();
                    rg.NumberFormat = "MM/DD/YYYY";
                    String mois = DateTime.Now.ToShortDateString();
                    oSheet.Cells[10,17] = mois;
					oSheet.Cells[11,17] = mtgcComboBox1.Text.Replace(".",",");
					oSheet.Cells[12,17] = txDateDernierControle.Text;
					oSheet.Cells[10,2] = textBox2.Text.Replace(".",",");
					oSheet.Cells[11,2] = textBox3.Text.Replace(".",",");
					if(textBox4.TextLength>0)
						oSheet.Cells[12,2] = oSheet.Cells[12,2] = textBox1.Text.Replace(".",",")+" MABEC : "+ textBox4.Text.Replace(".",",");
					else
						oSheet.Cells[12,2] = textBox1.Text.Replace(".",",");
					oSheet.Cells[13,2] = textBox5.Text.Replace(".",",");
					oSheet.Cells[14,2] = textBox6.Text.Replace(".",",");
					oSheet.Cells[24,1] = "Mesures effectuées avec le matériel de contrôle relié : "+ mtgcComboBox2.Text+" / "+mtgcComboBox3.Text;
					oSheet.Cells[9,10] = textBox117.Text;
					
					if(textBox9.TextLength>0)
						if(System.Convert.ToDecimal(textBox9.Text.Replace(".",","))>0)
							oSheet.Cells[16,2] = textBox9.Text.Replace(".",",");
					if(textBox10.TextLength>0)
						if(System.Convert.ToDecimal(textBox10.Text.Replace(".",","))>0)
							oSheet.Cells[17,2] = textBox10.Text.Replace(".",",");
					if(textBox12.TextLength>0)
						if(System.Convert.ToDecimal(textBox12.Text.Replace(".",","))>0)
							oSheet.Cells[18,2] = textBox12.Text.Replace(".",",");
					if(textBox13.TextLength>0)
						if(System.Convert.ToDecimal(textBox13.Text.Replace(".",","))>0)
							oSheet.Cells[19,2] = textBox13.Text.Replace(".",",");
					if(textBox11.TextLength>0)
						if(System.Convert.ToDecimal(textBox11.Text.Replace(".",","))>0)
							oSheet.Cells[21,2] = textBox11.Text.Replace(".",",");
					if(textBox14.TextLength>0)
						if(System.Convert.ToDecimal(textBox14.Text.Replace(".",","))>0)
							oSheet.Cells[22,2] = textBox14.Text.Replace(".",",");

                    oSheet.Cells[17, 11] = System.Convert.ToDecimal(textBox16.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[17, 11]).NumberFormat = "###,000";
                    oSheet.Cells[17, 12] = System.Convert.ToDecimal(textBox17.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[17, 12]).NumberFormat = "###,000";
                    oSheet.Cells[17, 13] = System.Convert.ToDecimal(textBox18.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[17, 13]).NumberFormat = "###,000";
                    oSheet.Cells[17, 14] = System.Convert.ToDecimal(textBox19.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[17, 14]).NumberFormat = "###,000";
                    oSheet.Cells[17, 15] = System.Convert.ToDecimal(textBox20.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[17, 15]).NumberFormat = "###,000";
                    oSheet.Cells[18, 11] = System.Convert.ToDecimal(textBox21.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[18, 11]).NumberFormat = "###,000";
                    oSheet.Cells[18, 12] = System.Convert.ToDecimal(textBox22.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[18, 12]).NumberFormat = "###,000";
                    oSheet.Cells[18, 13] = System.Convert.ToDecimal(textBox23.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[18, 13]).NumberFormat = "###,000";
                    oSheet.Cells[18, 14] = System.Convert.ToDecimal(textBox24.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[18, 14]).NumberFormat = "###,000";
                    oSheet.Cells[18, 15] = System.Convert.ToDecimal(textBox25.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[18, 15]).NumberFormat = "###,000";
                    oSheet.Cells[19, 11] = System.Convert.ToDecimal(textBox35.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[19, 11]).NumberFormat = "###,000";
                    oSheet.Cells[19, 12] = System.Convert.ToDecimal(textBox34.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[19, 12]).NumberFormat = "###,000";
                    oSheet.Cells[19, 13] = System.Convert.ToDecimal(textBox33.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[19, 13]).NumberFormat = "###,000";
                    oSheet.Cells[19, 14] = System.Convert.ToDecimal(textBox32.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[19, 14]).NumberFormat = "###,000";
                    oSheet.Cells[19, 15] = System.Convert.ToDecimal(textBox31.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[19, 15]).NumberFormat = "###,000";
                    oSheet.Cells[20, 11] = System.Convert.ToDecimal(textBox30.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[20, 11]).NumberFormat = "###,000";
                    oSheet.Cells[20, 12] = System.Convert.ToDecimal(textBox29.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[20, 12]).NumberFormat = "###,000";
                    oSheet.Cells[20, 13] = System.Convert.ToDecimal(textBox28.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[20, 13]).NumberFormat = "###,000";
                    oSheet.Cells[20, 14] = System.Convert.ToDecimal(textBox27.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[20, 14]).NumberFormat = "###,000";
                    oSheet.Cells[20, 15] = System.Convert.ToDecimal(textBox26.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[20, 15]).NumberFormat = "###,000";
                    oSheet.Cells[21, 11] = System.Convert.ToDecimal(textBox45.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[21, 11]).NumberFormat = "###,000";
                    oSheet.Cells[21, 12] = System.Convert.ToDecimal(textBox44.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[21, 12]).NumberFormat = "###,000";
                    oSheet.Cells[21, 13] = System.Convert.ToDecimal(textBox43.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[21, 13]).NumberFormat = "###,000";
                    oSheet.Cells[21, 14] = System.Convert.ToDecimal(textBox42.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[21, 14]).NumberFormat = "###,000";
                    oSheet.Cells[21, 15] = System.Convert.ToDecimal(textBox41.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[21, 15]).NumberFormat = "###,000";
                    oSheet.Cells[22, 11] = System.Convert.ToDecimal(textBox40.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[22, 11]).NumberFormat = "###,000";
                    oSheet.Cells[22, 12] = System.Convert.ToDecimal(textBox39.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[22, 12]).NumberFormat = "###,000";
                    oSheet.Cells[22, 13] = System.Convert.ToDecimal(textBox38.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[22, 13]).NumberFormat = "###,000";
                    oSheet.Cells[22, 14] = System.Convert.ToDecimal(textBox37.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[22, 14]).NumberFormat = "###,000";
                    oSheet.Cells[22, 15] = System.Convert.ToDecimal(textBox36.Text.Replace(".", ",")).ToString("F3", new CultureInfo("fr-FR", false));
                    ((Range)oSheet.Cells[22, 15]).NumberFormat = "###,000";

                    oXL.Workbooks[1].SaveAs(@"C:\Program Files (x86)\Opindus\excel\" + textBox1.Text.Replace("/", "-") + @"\controle_30.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, "", "", false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null); 
					if(oXL != null)
					{
						oXL.Quit();
						System.Runtime.InteropServices.Marshal.ReleaseComObject (oXL);
						oXL = null;		
					}
					oXL = new Microsoft.Office.Interop.Excel.Application();
                    oXL.UseSystemSeparators = false;
                    oXL.DecimalSeparator = ",";
                    oXL.Application.Visible=true;
                    oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\excel\" + textBox1.Text.Replace("/", "-") + @"\controle_30.xls", oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien);
				}
				else if(radioButton2.Checked)
				{
					oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\modeles\controle_50.xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);
			
					oWB = (Microsoft.Office.Interop.Excel._Workbook)oXL.Workbooks[1];
					oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1];

					oSheet.Cells[9,2] = textBox7.Text.Replace(".",",");
					oSheet.Cells[9,17] = textBox8.Text.Replace(".",",");
					oSheet.Cells[11,17] = mtgcComboBox1.Text.Replace(".",",");
					oSheet.Cells[12,17] = txDateDernierControle.Text;
					oSheet.Cells[10,2] = textBox2.Text.Replace(".",",");
					oSheet.Cells[11,2] = textBox3.Text.Replace(".",",");
					oSheet.Cells[12,2] = textBox1.Text.Replace(".",",");
					oSheet.Cells[13,2] = textBox5.Text.Replace(".",",");
					oSheet.Cells[14,2] = textBox6.Text.Replace(".",",");
					oSheet.Cells[24,1] = "Mesures effectuées avec le matériel de contrôle relié : "+ mtgcComboBox2.Text+" / "+mtgcComboBox3.Text;
					oSheet.Cells[9,10] = textBox117.Text;

					if(textBox9.TextLength>0)
						if(System.Convert.ToInt32(textBox9.Text)>0)
							oSheet.Cells[16,2] = textBox9.Text.Replace(".",",");
					if(textBox10.TextLength>0)
						if(System.Convert.ToInt32(textBox10.Text)>0)
							oSheet.Cells[17,2] = textBox10.Text.Replace(".",",");
					if(textBox12.TextLength>0)
						if(System.Convert.ToInt32(textBox12.Text)>0)
							oSheet.Cells[18,2] = textBox12.Text.Replace(".",",");
					if(textBox13.TextLength>0)
						if(System.Convert.ToInt32(textBox13.Text)>0)
							oSheet.Cells[19,2] = textBox13.Text.Replace(".",",");
					if(textBox11.TextLength>0)
						if(System.Convert.ToInt32(textBox11.Text)>0)
							oSheet.Cells[21,2] = textBox11.Text.Replace(".",",");
					if(textBox14.TextLength>0)
						if(System.Convert.ToInt32(textBox14.Text)>0)
							oSheet.Cells[22,2] = textBox14.Text.Replace(".",",");

                    oSheet.Cells[17, 11] = System.Convert.ToDecimal(textBox16.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[17, 12] = System.Convert.ToDecimal(textBox17.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[17, 13] = System.Convert.ToDecimal(textBox18.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[17, 14] = System.Convert.ToDecimal(textBox19.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[17, 15] = System.Convert.ToDecimal(textBox20.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[18, 11] = System.Convert.ToDecimal(textBox21.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[18, 12] = System.Convert.ToDecimal(textBox22.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[18, 13] = System.Convert.ToDecimal(textBox23.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[18, 14] = System.Convert.ToDecimal(textBox24.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[18, 15] = System.Convert.ToDecimal(textBox25.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[19, 11] = System.Convert.ToDecimal(textBox35.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[19, 12] = System.Convert.ToDecimal(textBox34.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[19, 13] = System.Convert.ToDecimal(textBox33.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[19, 14] = System.Convert.ToDecimal(textBox32.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[19, 15] = System.Convert.ToDecimal(textBox31.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[20, 11] = System.Convert.ToDecimal(textBox30.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[20, 12] = System.Convert.ToDecimal(textBox29.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[20, 13] = System.Convert.ToDecimal(textBox28.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[20, 14] = System.Convert.ToDecimal(textBox27.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[20, 15] = System.Convert.ToDecimal(textBox26.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[21, 11] = System.Convert.ToDecimal(textBox45.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[21, 12] = System.Convert.ToDecimal(textBox44.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[21, 13] = System.Convert.ToDecimal(textBox43.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[21, 14] = System.Convert.ToDecimal(textBox42.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[21, 15] = System.Convert.ToDecimal(textBox41.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[22, 11] = System.Convert.ToDecimal(textBox40.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[22, 12] = System.Convert.ToDecimal(textBox39.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[22, 13] = System.Convert.ToDecimal(textBox38.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[22, 14] = System.Convert.ToDecimal(textBox37.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[22, 15] = System.Convert.ToDecimal(textBox36.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);

                    oSheet.Cells[23, 11] = System.Convert.ToDecimal(textBox55.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[23, 12] = System.Convert.ToDecimal(textBox54.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[23, 13] = System.Convert.ToDecimal(textBox53.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[23, 14] = System.Convert.ToDecimal(textBox52.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[23, 15] = System.Convert.ToDecimal(textBox51.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[24, 11] = System.Convert.ToDecimal(textBox50.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[24, 12] = System.Convert.ToDecimal(textBox49.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[24, 13] = System.Convert.ToDecimal(textBox48.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[24, 14] = System.Convert.ToDecimal(textBox47.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[24, 15] = System.Convert.ToDecimal(textBox46.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[25, 11] = System.Convert.ToDecimal(textBox65.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[25, 12] = System.Convert.ToDecimal(textBox64.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[25, 13] = System.Convert.ToDecimal(textBox63.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[25, 14] = System.Convert.ToDecimal(textBox62.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[25, 15] = System.Convert.ToDecimal(textBox61.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[26, 11] = System.Convert.ToDecimal(textBox60.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[26, 12] = System.Convert.ToDecimal(textBox59.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[26, 13] = System.Convert.ToDecimal(textBox58.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[26, 14] = System.Convert.ToDecimal(textBox57.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[26, 15] = System.Convert.ToDecimal(textBox56.Text.Replace(".", ",")).ToString("F3", CultureInfo.CurrentUICulture);

                    oXL.Workbooks[1].SaveAs(@"C:\Program Files (x86)\Opindus\excel\" + textBox1.Text.Replace("/", "-") + @"\controle_50.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, "", "", false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null); 
					if(oXL != null)
					{
						oXL.Quit();
						System.Runtime.InteropServices.Marshal.ReleaseComObject (oXL);
						oXL = null;		
					}
					oXL = new Microsoft.Office.Interop.Excel.Application();
                    oXL.UseSystemSeparators = false;
                    oXL.DecimalSeparator = ",";
                    oXL.Application.Visible=true;
                    oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\excel\" + textBox1.Text.Replace("/", "-") + @"\controle_50.xls", oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien);
				}
				else if(radioButton3.Checked)
				{
					oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\modeles\controle_100.xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);
			
					oWB = (Microsoft.Office.Interop.Excel._Workbook)oXL.Workbooks[1];
					oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1];

					oSheet.Cells[9,2] = textBox7.Text.Replace(".",",");
					oSheet.Cells[9,17] = textBox8.Text.Replace(".",",");
					oSheet.Cells[11,17] = mtgcComboBox1.Text.Replace(".",",");
					oSheet.Cells[12,17] = txDateDernierControle.Text;
					oSheet.Cells[10,2] = textBox2.Text.Replace(".",",");
					oSheet.Cells[11,2] = textBox3.Text.Replace(".",",");
					oSheet.Cells[12,2] = textBox1.Text.Replace(".",",");
					oSheet.Cells[13,2] = textBox5.Text.Replace(".",",");
					oSheet.Cells[14,2] = textBox6.Text.Replace(".",",");
					oSheet.Cells[24,1] = "Mesures effectuées avec le matériel de contrôle relié : "+ mtgcComboBox2.Text+" / "+mtgcComboBox3.Text;
					oSheet.Cells[9,10] = textBox117.Text;

					if(textBox9.TextLength>0)
						if(System.Convert.ToInt32(textBox9.Text)>0)
							oSheet.Cells[16,2] = textBox9.Text.Replace(".",",");
					if(textBox10.TextLength>0)
						if(System.Convert.ToInt32(textBox10.Text)>0)
							oSheet.Cells[17,2] = textBox10.Text.Replace(".",",");
					if(textBox12.TextLength>0)
						if(System.Convert.ToInt32(textBox12.Text)>0)
							oSheet.Cells[18,2] = textBox12.Text.Replace(".",",");
					if(textBox13.TextLength>0)
						if(System.Convert.ToInt32(textBox13.Text)>0)
							oSheet.Cells[19,2] = textBox13.Text.Replace(".",",");
					if(textBox11.TextLength>0)
						if(System.Convert.ToInt32(textBox11.Text)>0)
							oSheet.Cells[21,2] = textBox11.Text.Replace(".",",");
					if(textBox14.TextLength>0)
						if(System.Convert.ToInt32(textBox14.Text)>0)
							oSheet.Cells[22,2] = textBox14.Text.Replace(".",",");

					oSheet.Cells[17,11] = System.Convert.ToDecimal(textBox16.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
                    oSheet.Cells[17,12] = System.Convert.ToDecimal(textBox17.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[17,13] = System.Convert.ToDecimal(textBox18.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[17,14] = System.Convert.ToDecimal(textBox19.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[17,15] = System.Convert.ToDecimal(textBox20.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[18,11] = System.Convert.ToDecimal(textBox21.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[18,12] = System.Convert.ToDecimal(textBox22.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[18,13] = System.Convert.ToDecimal(textBox23.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[18,14] = System.Convert.ToDecimal(textBox24.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[18,15] = System.Convert.ToDecimal(textBox25.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[19,11] = System.Convert.ToDecimal(textBox35.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[19,12] = System.Convert.ToDecimal(textBox34.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[19,13] = System.Convert.ToDecimal(textBox33.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[19,14] = System.Convert.ToDecimal(textBox32.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[19,15] = System.Convert.ToDecimal(textBox31.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[20,11] = System.Convert.ToDecimal(textBox30.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[20,12] = System.Convert.ToDecimal(textBox29.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[20,13] = System.Convert.ToDecimal(textBox28.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[20,14] = System.Convert.ToDecimal(textBox27.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[20,15] = System.Convert.ToDecimal(textBox26.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[21,11] = System.Convert.ToDecimal(textBox45.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[21,12] = System.Convert.ToDecimal(textBox44.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[21,13] = System.Convert.ToDecimal(textBox43.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[21,14] = System.Convert.ToDecimal(textBox42.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[21,15] = System.Convert.ToDecimal(textBox41.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[22,11] = System.Convert.ToDecimal(textBox40.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[22,12] = System.Convert.ToDecimal(textBox39.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[22,13] = System.Convert.ToDecimal(textBox38.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[22,14] = System.Convert.ToDecimal(textBox37.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[22,15] = System.Convert.ToDecimal(textBox36.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);

					oSheet.Cells[23,11] = System.Convert.ToDecimal(textBox55.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[23,12] = System.Convert.ToDecimal(textBox54.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[23,13] = System.Convert.ToDecimal(textBox53.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[23,14] = System.Convert.ToDecimal(textBox52.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[23,15] = System.Convert.ToDecimal(textBox51.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[24,11] = System.Convert.ToDecimal(textBox50.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[24,12] = System.Convert.ToDecimal(textBox49.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[24,13] = System.Convert.ToDecimal(textBox48.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[24,14] = System.Convert.ToDecimal(textBox47.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[24,15] = System.Convert.ToDecimal(textBox46.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[25,11] = System.Convert.ToDecimal(textBox65.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[25,12] = System.Convert.ToDecimal(textBox64.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[25,13] = System.Convert.ToDecimal(textBox63.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[25,14] = System.Convert.ToDecimal(textBox62.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[25,15] = System.Convert.ToDecimal(textBox61.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[26,11] = System.Convert.ToDecimal(textBox60.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[26,12] = System.Convert.ToDecimal(textBox59.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[26,13] = System.Convert.ToDecimal(textBox58.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[26,14] = System.Convert.ToDecimal(textBox57.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[26,15] = System.Convert.ToDecimal(textBox56.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);

					oSheet.Cells[27,11] = System.Convert.ToDecimal(textBox75.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[27,12] = System.Convert.ToDecimal(textBox74.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[27,13] = System.Convert.ToDecimal(textBox73.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[27,14] = System.Convert.ToDecimal(textBox72.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[27,15] = System.Convert.ToDecimal(textBox71.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[28,11] = System.Convert.ToDecimal(textBox70.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[28,12] = System.Convert.ToDecimal(textBox79.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[28,13] = System.Convert.ToDecimal(textBox78.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[28,14] = System.Convert.ToDecimal(textBox77.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[28,15] = System.Convert.ToDecimal(textBox76.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[29,11] = System.Convert.ToDecimal(textBox85.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[29,12] = System.Convert.ToDecimal(textBox84.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[29,13] = System.Convert.ToDecimal(textBox83.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[29,14] = System.Convert.ToDecimal(textBox82.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[29,15] = System.Convert.ToDecimal(textBox81.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[30,11] = System.Convert.ToDecimal(textBox80.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[30,12] = System.Convert.ToDecimal(textBox79.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[30,13] = System.Convert.ToDecimal(textBox78.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[30,14] = System.Convert.ToDecimal(textBox77.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[30,15] = System.Convert.ToDecimal(textBox76.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);

					oSheet.Cells[31,11] = System.Convert.ToDecimal(textBox95.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[31,12] = System.Convert.ToDecimal(textBox94.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[31,13] = System.Convert.ToDecimal(textBox93.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[31,14] = System.Convert.ToDecimal(textBox92.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[31,15] = System.Convert.ToDecimal(textBox91.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[32,11] = System.Convert.ToDecimal(textBox90.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[32,12] = System.Convert.ToDecimal(textBox89.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[32,13] = System.Convert.ToDecimal(textBox88.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[32,14] = System.Convert.ToDecimal(textBox87.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[32,15] = System.Convert.ToDecimal(textBox86.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[33,11] = System.Convert.ToDecimal(textBox105.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[33,12] = System.Convert.ToDecimal(textBox104.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[33,13] = System.Convert.ToDecimal(textBox103.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[33,14] = System.Convert.ToDecimal(textBox102.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[33,15] = System.Convert.ToDecimal(textBox101.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[34,11] = System.Convert.ToDecimal(textBox100.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[34,12] = System.Convert.ToDecimal(textBox99.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[34,13] = System.Convert.ToDecimal(textBox98.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[34,14] = System.Convert.ToDecimal(textBox97.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[34,15] = System.Convert.ToDecimal(textBox96.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[35,11] = System.Convert.ToDecimal(textBox115.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[35,12] = System.Convert.ToDecimal(textBox114.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[35,13] = System.Convert.ToDecimal(textBox113.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[35,14] = System.Convert.ToDecimal(textBox112.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[35,15] = System.Convert.ToDecimal(textBox111.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[36,11] = System.Convert.ToDecimal(textBox110.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[36,12] = System.Convert.ToDecimal(textBox109.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[36,13] = System.Convert.ToDecimal(textBox108.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[36,14] = System.Convert.ToDecimal(textBox107.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);
					oSheet.Cells[36,15] = System.Convert.ToDecimal(textBox106.Text.Replace(".",",")).ToString("F3", CultureInfo.CurrentUICulture);



                    oXL.Workbooks[1].SaveAs(@"C:\Program Files (x86)\Opindus\excel\" + textBox1.Text.Replace("/", "-") + @"\controle_100.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, "", "", false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null); 
					if(oXL != null)
					{
						oXL.Quit();
						System.Runtime.InteropServices.Marshal.ReleaseComObject (oXL);
						oXL = null;		
					}
					oXL = new Microsoft.Office.Interop.Excel.Application();
                    oXL.UseSystemSeparators = false;
                    oXL.DecimalSeparator = ",";
                    oXL.Application.Visible=true;
                    oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\excel\" + textBox1.Text.Replace("/", "-") + @"\controle_100.xls", oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien);
					ds.Tables["client"].Clear();
				}
			
			}
			
		}
	}
}