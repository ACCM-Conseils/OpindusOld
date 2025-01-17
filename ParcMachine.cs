using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Opindus
{
	/// <summary>
	/// Description résumée de ParcMachine.
	/// </summary>
	public class ParcMachine : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ListView lvDevis;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.TextBox textBox30;
		private string Ident;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.ListBox listBox1;
		private int NbrPages;
		private int CurPage;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.TextBox textBox28;
		private System.Windows.Forms.Button button2;
		private bool NewMachine;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Button button5;
		private int Agence;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox textBox29;
		private MTGCComboBox mtgcComboBox1;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private Dotnetrix.Controls.TabPageEX tabPageEX4;
		private Dotnetrix.Controls.TabPageEX tabPageEX5;
		private Dotnetrix.Controls.TabPageEX tabPageEX6;
		private MTGCComboBox mtgcComboBox2;
		private MTGCComboBox mtgcComboBox3;
		private MTGCComboBox mtgcComboBox4;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox21;
		private MTGCComboBox mtgcComboBox5;
		private System.Windows.Forms.Button button6;
		private OleDbCommand Comm;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox18;
		private bool Nouveau;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private OleDbTransaction Transac;
        private OleDbDataAdapter DataAD;
        private DataSet ds;
		Object oRien=System.Reflection.Missing.Value;
		private System.Windows.Forms.Button btParc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
		/// <summary>
		/// 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ParcMachine(int Agence,bool res)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAD = new OleDbDataAdapter();
			ds = new DataSet();

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
			NbrPages=0;
			CurPage=0;
			this.Refresh();
			Nouveau=false;
			InitializeData();
			NewMachine=res;
			tabControlEX1.SelectedTab=tabPageEX1;
			btEnregistre.Enabled=true;
			if(NewMachine)
			{
				
				mtgcComboBox5.Enabled=true;
				textBox3.Text=DateTime.Today.ToShortDateString();
				label12.Visible=false;
				mtgcComboBox1.Visible=false;
				groupBox2.BackColor=Color.SteelBlue;
				label31.Visible=true;
				Nouveau=true;
				btNouveau.Enabled=true;
				Activer();
				VisibleOK();
				textBox1.BackColor=Color.MistyRose;
				textBox1.Focus();
			}
			
		}

		public ParcMachine(int Agence, string Machine)
		{
			
			InitializeComponent();

			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAD = new OleDbDataAdapter();
			ds = new DataSet();

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
			NbrPages=0;
			CurPage=0;
			this.Refresh();
			tabControlEX1.SelectedTab=tabPageEX1;
			btSupprime.Enabled=true;
			btEnregistre.Enabled=true;
			
			string typeMachine;
			Nouveau=false;
			InitializeData();
			Nettoyer();
			Activer();
			mtgcComboBox2.Enabled=true;
			mtgcComboBox5.Enabled=true;
			mtgcComboBox1.Enabled=true;
			string machine = Machine;
			Comm.CommandText="select t_affectation.[Affectation],t_site.[Site],t_parc_machine.[En parc],t_parc_machine.[site],t_parc_machine.[Affectation],t_parc_machine.[No dernier devis refus],t_parc_machine.[Date refus],t_parc_machine.[No dernier devis],t_parc_machine.[Code machine opindus],t_parc_machine.[type machine], t_parc_machine.[Code machine client],t_parc_machine.[No serie],t_parc_machine.[prix achat],t_parc_machine.[prix remplacement],t_parc_machine.[Date mise en service],t_parc_machine.[date fin garantie],t_parc_machine.[Date reforme],t_parc_machine.[Code mabec],t_parc_machine.[N° troncon],t_parc_machine.[Date dernier controle],t_parc_machine.[Date dernier intervention],t_parc_machine.[Nombre semaine entre ctl],t_parc_machine.[nombre semaine entre inter],t_famille_machine.[Designation],t_clients.[nom],t_clients.[ident],t_clients.[ville],t_fournisseurs.[nom],t_type_machine.[code famille] from t_affectation,t_parc_machine,t_type_machine,t_famille_machine,t_clients,t_fournisseurs,t_site where t_fournisseurs.[Code]=t_type_machine.[fournisseur] and t_parc_machine.[type machine]=t_type_machine.[code] and t_affectation.[ID]=t_parc_machine.[Affectation] and t_site.[ID]=t_parc_machine.[site] and t_type_machine.[code famille]=t_famille_machine.[code] and t_clients.[Ident]=t_parc_machine.[Code client] and t_parc_machine.[code machine opindus]='"+machine+"'";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_parc_machine");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			DataRow row = ds.Tables["T_parc_machine"].Rows[0];
			textBox1.Text=row["Code machine opindus"].ToString();
			textBox2.Text=row["Code machine client"].ToString();
			textBox6.Text=row["No serie"].ToString();
			textBox7.Text=System.Convert.ToDecimal(row["Prix achat"].ToString()).ToString("c");
			textBox8.Text=System.Convert.ToDecimal(row["Prix remplacement"].ToString()).ToString("c");
			textBox12.Text=row["Code mabec"].ToString();
			textBox13.Text=row["N° troncon"].ToString();



			if(row["Date mise en service"].ToString().Length>0)
			{
				textBox3.Text=System.Convert.ToDateTime(row["Date mise en service"].ToString()).ToShortDateString();
			}

			mtgcComboBox3.Focus();
			mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(row["t_parc_machine.Affectation"].ToString());
			mtgcComboBox4.Focus();
			mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(row["t_parc_machine.Site"].ToString());
			if(row["Date dernier controle"].ToString().Length>0)
			{
				textBox11.Text=System.Convert.ToDateTime(row["Date dernier controle"].ToString()).ToShortDateString();
			}

			textBox17.Text=row["Nombre semaine entre ctl"].ToString();
			if(row["Date dernier intervention"].ToString().Length>0)
			{
				textBox16.Text=System.Convert.ToDateTime(row["Date dernier intervention"].ToString()).ToShortDateString();
			}
			textBox19.Text=row["Nombre semaine entre inter"].ToString();
			mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(row["t_clients.nom"].ToString());
			Ident=row["ident"].ToString();
			label4.Text=row["Designation"].ToString()+" / "+row["t_fournisseurs.nom"].ToString();
			textBox29.Text=row["code famille"].ToString();
			textBox20.Text=row["No dernier devis"].ToString();
			textBox21.Text=row["No dernier devis refus"].ToString();
			typeMachine=row["Type machine"].ToString();
			if(row["En parc"].ToString().Equals("True"))
				checkBox1.Checked=true;
			if(row["Date refus"].ToString().Length>0)
			{
				textBox18.Text=System.Convert.ToDateTime(row["Date refus"].ToString()).ToShortDateString();
			}

			ds.Tables["t_parc_machine"].Clear();

			Comm.CommandText="select t_devis_entete.[N° Devis],t_devis_entete.[Date],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_devis_entete.[Date reparation],t_devis_entete.[Type devis] from t_devis_entete where [Code materiel]='"+textBox1.Text+"' order by 1 desc";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"T_devis_entete");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			

			int cpt2=0;
			foreach(DataRow row2 in ds.Tables["T_devis_entete"].Rows)
			{
				ListViewItem item = new ListViewItem(row2["N° Devis"].ToString());
				if(row2["Date"].ToString().Length>0)
					item.SubItems.Add(System.Convert.ToDateTime(row2["Date"].ToString()).ToShortDateString());
				else
					item.SubItems.Add("");
				if(row2["Date entree reelle"].ToString().Length>0)
					item.SubItems.Add(System.Convert.ToDateTime(row2["Date entree reelle"].ToString()).ToShortDateString());
				else
					item.SubItems.Add("");
				if(row2["Date decision"].ToString().Length>0)
					item.SubItems.Add(System.Convert.ToDateTime(row2["Date decision"].ToString()).ToShortDateString());
				else
					item.SubItems.Add("");
				if(row2["Date reparation"].ToString().Length>0)
					item.SubItems.Add(System.Convert.ToDateTime(row2["Date reparation"].ToString()).ToShortDateString());
				else
					item.SubItems.Add("");
				if(row2["Type devis"].ToString().Length>0)
					item.SubItems.Add(row2["Type devis"].ToString());
				else
					item.SubItems.Add("");
				lvDevis.Items.Add(item);
				if(cpt2>0)
				{
					if(lvDevis.Items[cpt2-1].BackColor==Color.MintCream)
						lvDevis.Items[cpt2].BackColor=Color.White;
					else if(lvDevis.Items[cpt2].BackColor==Color.White)
						lvDevis.Items[cpt2].BackColor=Color.MintCream;
				}
				cpt2++;
			}
			Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Total pieces]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_parc_machine");
			if(ds.Tables["t_parc_machine"].Rows.Count>0)
			{
				textBox23.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
				ds.Tables["t_parc_machine"].Clear();
				Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Forfait DNR]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_parc_machine");
				textBox24.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
				ds.Tables["t_parc_machine"].Clear();
				Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Forfait controle]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_parc_machine");
				textBox25.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
				ds.Tables["t_parc_machine"].Clear();
				Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Forfait transport]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_parc_machine");
				textBox26.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
				ds.Tables["t_parc_machine"].Clear();
				Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Total devis]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_parc_machine");
				textBox27.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
				ds.Tables["t_parc_machine"].Clear();
			}

            Comm.CommandText = "SELECT T_parc_machine_historique.Dateinter, T_parc_machine_historique.typeinterv, T_parc_machine_historique.N_Controle, T_parc_machine_historique.infos_3, T_parc_machine_historique.infos_4, T_parc_machine_historique.ind_k, T_parc_machine_historique.test_k, T_affectation.Affectation, T_site.Site FROM T_site INNER JOIN (T_affectation INNER JOIN (T_parc_machine INNER JOIN T_parc_machine_historique ON T_parc_machine.[Code machine Opindus] = T_parc_machine_historique.[Code machine Opindus]) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site where T_parc_machine_historique.[code machine opindus]='" + textBox1.Text + "'";
            DataAD.SelectCommand = Comm;
            DataAD.Fill(ds, "t_machines_histo");
            if (ds.Tables["t_machines_histo"].Rows.Count > 0)
            {
                foreach (DataRow Histo in ds.Tables["t_machines_histo"].Rows)
                {
                    if (Histo["typeinterv"].ToString().Equals("1"))
                    {
                        button3.Visible = true;
                    }
                }

            }

			/*Comm.CommandText="select t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_avancement.[libelle] from t_devis_entete,t_avancement where t_devis_entete.[Niveau]=t_avancement.[Id] and [Code materiel]='"+textBox1.Text+"' and Niveau<7";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_devis_entete");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			foreach(DataRow row5 in ds.Tables["t_devis_entete"].Rows)
			{
				if(System.Convert.ToInt32(row5["Niveau"].ToString())<7)
				{
					textBox5.BackColor=Color.Lavender;
					textBox5.ForeColor=Color.Black;
					textBox32.BackColor=Color.Lavender;
					textBox32.ForeColor=Color.Black;
					textBox32.Text=row5["N° Devis"].ToString();
					textBox5.Text=row5["Libelle"].ToString();
				}
			}
			ds.Tables["t_devis_entete"].Clear();*/
			mtgcComboBox2.Focus();
			mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(typeMachine);

			/*listView3.Items.Clear();
			DataSet ds2 = new DataSet();
			Comm.CommandText="select t_parc_machine.[code machine opindus],t_clients.nom,t_site.site,t_affectation.affectation from t_parc_machine,t_clients,t_site,t_affectation where t_parc_machine.site=t_site.id and t_parc_machine.affectation = t_affectation.id and t_parc_machine.[code client]=t_clients.ident and [Type machine]='"+mtgcComboBox2.Text+"'";
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(ds2);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			cpt2=0;
			foreach(DataRow rowType in ds2.Tables["t_parc_machine"].Rows)
			{
				
				listView3.Items.Add(rowType["Code machine opindus"].ToString());
				listView3.Items[listView3.Items.Count-1].SubItems.Add(rowType["nom"].ToString());
				listView3.Items[listView3.Items.Count-1].SubItems.Add(rowType["site"].ToString());
				listView3.Items[listView3.Items.Count-1].SubItems.Add(rowType["affectation"].ToString());
				if(cpt2>0)
				{
					if(listView3.Items[cpt2-1].BackColor==Color.MintCream)
						listView3.Items[cpt2].BackColor=Color.White;
					else if(listView3.Items[cpt2].BackColor==Color.White)
						listView3.Items[cpt2].BackColor=Color.MintCream;
				}
				cpt2++;
			}
			Comm.CommandText="select * from t_machines_histo where [code machine opindus]='"+textBox1.Text+"'";
			Comm.Connection=oleDbConnection1;
			oleDbDataAdapter6.SelectCommand=Comm;
			oleDbDataAdapter6.Fill(dataSet11);
			textBox4.Text="";
			textBox28.Text="";
			listBox1.Items.Clear();
			checkBox2.Checked=false;
			checkBox3.Checked=false;
			checkBox4.Checked=false;
			if(dataSet11.Tables["t_machines_histo"].Rows.Count>0)
			{
				numericUpDown1.Enabled=true;
				NbrPages=dataSet11.Tables["t_machines_histo"].Rows.Count;
				numericUpDown1.Maximum=NbrPages;
				numericUpDown1.Minimum=1;
				numericUpDown1.Value=1;
				textBox4.Text=dataSet11.Tables["t_machines_histo"].Rows[CurPage]["description"].ToString();
				textBox28.Text=dataSet11.Tables["t_machines_histo"].Rows[CurPage]["date"].ToString();
				listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_1"].ToString());
				listBox1.Items.Add("");
				listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_1_1"].ToString());
				listBox1.Items.Add("");
				listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_2"].ToString());
				listBox1.Items.Add("");
				listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_3"].ToString());
				listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_4"].ToString());
				listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_5"].ToString());
			}
			else
				numericUpDown1.Enabled=false;
			tabControlEX1.SelectedTab=tabPageEX1;
			dataSet11.Tables["t_devis_entete"].Clear();
			Comm.CommandText="SELECT T_devis_entete.[Code Materiel], T_devis_lignes.Cause, Sum(T_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis] GROUP BY T_devis_entete.[Code Materiel], T_devis_lignes.Cause, T_devis_entete.Niveau HAVING (((T_devis_entete.[Code Materiel])='"+textBox1.Text+"') AND ((T_devis_entete.Niveau)=7))";
			oleDbDataAdapter4.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter4.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			foreach(DataRow row3 in dataSet11.Tables["t_devis_entete"].Rows)
			{
				dataSet11.Tables["t_causes"].Clear();
				Comm.CommandText="select * from t_causes where Code="+row3["Cause"].ToString();
				oleDbDataAdapter9.SelectCommand=Comm;
				oleDbDataAdapter9.Fill(dataSet11);
				listView1.Items.Add(dataSet11.Tables["t_causes"].Rows[0]["Designation"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row3["SommeDeTotal ligne"].ToString());
			}*/
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParcMachine));
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.mtgcComboBox5 = new MTGCComboBox();
            this.mtgcComboBox2 = new MTGCComboBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btParc = new System.Windows.Forms.Button();
            this.mtgcComboBox4 = new MTGCComboBox();
            this.mtgcComboBox3 = new MTGCComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lvDevis = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtgcComboBox1 = new MTGCComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btSupprime = new System.Windows.Forms.Button();
            this.btEnregistre = new System.Windows.Forms.Button();
            this.btNouveau = new System.Windows.Forms.Button();
            this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
            this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPageEX5 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPageEX4 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX6 = new Dotnetrix.Controls.TabPageEX();
            this.button9 = new System.Windows.Forms.Button();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlEX1.SuspendLayout();
            this.tabPageEX1.SuspendLayout();
            this.tabPageEX5.SuspendLayout();
            this.tabPageEX2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPageEX4.SuspendLayout();
            this.tabPageEX3.SuspendLayout();
            this.tabPageEX6.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Enabled = false;
            this.textBox32.ForeColor = System.Drawing.Color.Black;
            this.textBox32.Location = new System.Drawing.Point(212, 215);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(130, 26);
            this.textBox32.TabIndex = 7;
            this.textBox32.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1368, 111);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(948, 58);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(150, 26);
            this.textBox10.TabIndex = 12;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(780, 58);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(150, 26);
            this.textBox9.TabIndex = 11;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(614, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 26);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(948, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Date réforme";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(783, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date fin garantie";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(612, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mise en service";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(554, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(24, 36);
            this.checkBox1.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(531, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 22);
            this.label18.TabIndex = 12;
            this.label18.Text = "En parc";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Prix remplacement";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Prix d\'achat";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "N° Serie";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(346, 58);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 26);
            this.textBox8.TabIndex = 9;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.Leave += new System.EventHandler(this.textBox8_Leave);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(180, 58);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 26);
            this.textBox7.TabIndex = 8;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(14, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 26);
            this.textBox6.TabIndex = 7;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(348, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(804, 26);
            this.textBox5.TabIndex = 3;
            this.textBox5.TabStop = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Enabled = false;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Blue;
            this.button10.Location = new System.Drawing.Point(12, 215);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(192, 29);
            this.button10.TabIndex = 2;
            this.button10.TabStop = false;
            this.button10.Text = "Voir devis en cours";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.mtgcComboBox5);
            this.groupBox1.Controls.Add(this.mtgcComboBox2);
            this.groupBox1.Controls.Add(this.textBox29);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(336, 82);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(312, 23);
            this.label32.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(240, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 69;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lavender;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(732, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 30);
            this.button6.TabIndex = 3;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // mtgcComboBox5
            // 
            this.mtgcComboBox5.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mtgcComboBox5.ColumnNum = 4;
            this.mtgcComboBox5.ColumnWidth = "200;200;200;50";
            this.mtgcComboBox5.DisplayMember = "Text";
            this.mtgcComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox5.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox5.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox5.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox5.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox5.DropDownWidth = 720;
            this.mtgcComboBox5.Enabled = false;
            this.mtgcComboBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtgcComboBox5.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox5.GridLineHorizontal = false;
            this.mtgcComboBox5.GridLineVertical = true;
            this.mtgcComboBox5.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox5.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox5.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox5.Location = new System.Drawing.Point(240, 47);
            this.mtgcComboBox5.ManagingFastMouseMoving = true;
            this.mtgcComboBox5.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox5.Name = "mtgcComboBox5";
            this.mtgcComboBox5.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox5.Size = new System.Drawing.Size(480, 27);
            this.mtgcComboBox5.TabIndex = 2;
            this.mtgcComboBox5.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox5_SelectedIndexChanged);
            // 
            // mtgcComboBox2
            // 
            this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mtgcComboBox2.ColumnNum = 3;
            this.mtgcComboBox2.ColumnWidth = "200;200;200";
            this.mtgcComboBox2.DisplayMember = "Text";
            this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox2.DropDownWidth = 620;
            this.mtgcComboBox2.Enabled = false;
            this.mtgcComboBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox2.GridLineHorizontal = false;
            this.mtgcComboBox2.GridLineVertical = true;
            this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox2.Location = new System.Drawing.Point(240, 129);
            this.mtgcComboBox2.ManagingFastMouseMoving = true;
            this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox2.Name = "mtgcComboBox2";
            this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox2.Size = new System.Drawing.Size(480, 27);
            this.mtgcComboBox2.TabIndex = 5;
            this.mtgcComboBox2.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox2_SelectedIndexChanged);
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(184, 129);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(38, 26);
            this.textBox29.TabIndex = 66;
            this.textBox29.Visible = false;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(648, 82);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(204, 17);
            this.label33.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lavender;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(732, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(236, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(150, 18);
            this.label30.TabIndex = 13;
            this.label30.Text = "Client";
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(236, 105);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(150, 18);
            this.label29.TabIndex = 12;
            this.label29.Text = "Type machine";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(240, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 17);
            this.label4.TabIndex = 11;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code machine client";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code machine Opindus";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.TabStop = false;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox31);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(898, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 194);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(84, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 33);
            this.button3.TabIndex = 5;
            this.button3.TabStop = false;
            this.button3.Text = "Fiches de vie (Graphiques)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.Color.MediumBlue;
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.ForeColor = System.Drawing.Color.White;
            this.textBox31.Location = new System.Drawing.Point(72, 22);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(344, 26);
            this.textBox31.TabIndex = 4;
            this.textBox31.TabStop = false;
            this.textBox31.Text = "Contrôles et suivi";
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Enabled = false;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(84, 107);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(302, 33);
            this.button8.TabIndex = 2;
            this.button8.TabStop = false;
            this.button8.Text = "Fiches de vie (Excel)";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Enabled = false;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(84, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(302, 34);
            this.button7.TabIndex = 1;
            this.button7.TabStop = false;
            this.button7.Text = "Caractéristiques et contrôles";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox5.Controls.Add(this.btParc);
            this.groupBox5.Controls.Add(this.mtgcComboBox4);
            this.groupBox5.Controls.Add(this.mtgcComboBox3);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.textBox15);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(12, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1368, 220);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // btParc
            // 
            this.btParc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.btParc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btParc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btParc.ForeColor = System.Drawing.Color.White;
            this.btParc.Image = ((System.Drawing.Image)(resources.GetObject("btParc.Image")));
            this.btParc.Location = new System.Drawing.Point(1200, 47);
            this.btParc.Name = "btParc";
            this.btParc.Size = new System.Drawing.Size(144, 140);
            this.btParc.TabIndex = 15;
            this.btParc.Text = "&Parc";
            this.btParc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btParc.UseVisualStyleBackColor = false;
            // 
            // mtgcComboBox4
            // 
            this.mtgcComboBox4.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox4.ColumnNum = 2;
            this.mtgcComboBox4.ColumnWidth = "50;200";
            this.mtgcComboBox4.DisplayMember = "Text";
            this.mtgcComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox4.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox4.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox4.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox4.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox4.DropDownWidth = 270;
            this.mtgcComboBox4.Enabled = false;
            this.mtgcComboBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtgcComboBox4.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox4.GridLineHorizontal = false;
            this.mtgcComboBox4.GridLineVertical = true;
            this.mtgcComboBox4.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox4.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox4.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox4.Location = new System.Drawing.Point(132, 164);
            this.mtgcComboBox4.ManagingFastMouseMoving = true;
            this.mtgcComboBox4.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox4.Name = "mtgcComboBox4";
            this.mtgcComboBox4.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox4.Size = new System.Drawing.Size(156, 27);
            this.mtgcComboBox4.TabIndex = 16;
            this.mtgcComboBox4.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox4_SelectedIndexChanged);
            // 
            // mtgcComboBox3
            // 
            this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox3.ColumnNum = 2;
            this.mtgcComboBox3.ColumnWidth = "50;200";
            this.mtgcComboBox3.DisplayMember = "Text";
            this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox3.DropDownWidth = 270;
            this.mtgcComboBox3.Enabled = false;
            this.mtgcComboBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox3.GridLineHorizontal = false;
            this.mtgcComboBox3.GridLineVertical = true;
            this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox3.Location = new System.Drawing.Point(132, 114);
            this.mtgcComboBox3.ManagingFastMouseMoving = true;
            this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox3.Name = "mtgcComboBox3";
            this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox3.Size = new System.Drawing.Size(156, 27);
            this.mtgcComboBox3.TabIndex = 15;
            this.mtgcComboBox3.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox3_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 23);
            this.label20.TabIndex = 10;
            this.label20.Text = "Site";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 20);
            this.label19.TabIndex = 9;
            this.label19.Text = "Affectation";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Enabled = false;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Blue;
            this.button11.Location = new System.Drawing.Point(984, 114);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(147, 79);
            this.button11.TabIndex = 8;
            this.button11.TabStop = false;
            this.button11.Text = "Affectations sites";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.White;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(309, 164);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(651, 26);
            this.textBox15.TabIndex = 7;
            this.textBox15.TabStop = false;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.White;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(308, 114);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(652, 26);
            this.textBox14.TabIndex = 6;
            this.textBox14.TabStop = false;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(308, 51);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(150, 26);
            this.textBox13.TabIndex = 14;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(332, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "N° Tronçon";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(128, 51);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(150, 26);
            this.textBox12.TabIndex = 13;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(150, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Code  MABEC";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox6.Controls.Add(this.textBox18);
            this.groupBox6.Controls.Add(this.textBox16);
            this.groupBox6.Controls.Add(this.textBox11);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.textBox21);
            this.groupBox6.Controls.Add(this.textBox20);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.textBox19);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textBox17);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(12, 555);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1368, 136);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(984, 70);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(150, 26);
            this.textBox18.TabIndex = 24;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(348, 70);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(150, 26);
            this.textBox16.TabIndex = 19;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(15, 70);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(150, 26);
            this.textBox11.TabIndex = 17;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(984, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(144, 23);
            this.label23.TabIndex = 13;
            this.label23.Text = "Date refus";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(856, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 22);
            this.label22.TabIndex = 12;
            this.label22.Text = "Dernier refusé";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(669, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 23);
            this.label21.TabIndex = 11;
            this.label21.Text = "Dernier devis";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Enabled = false;
            this.textBox21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(856, 70);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(116, 26);
            this.textBox21.TabIndex = 23;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Enabled = false;
            this.textBox20.ForeColor = System.Drawing.Color.Black;
            this.textBox20.Location = new System.Drawing.Point(670, 70);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(116, 26);
            this.textBox20.TabIndex = 21;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(512, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 23);
            this.label17.TabIndex = 7;
            this.label17.Text = "Durée entre inter";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Enabled = false;
            this.textBox19.Location = new System.Drawing.Point(516, 70);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(135, 26);
            this.textBox19.TabIndex = 20;
            this.textBox19.Text = "0";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(348, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Dernière intervention";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(188, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Durée entre ctl";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Dernier controle";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Enabled = false;
            this.textBox17.Location = new System.Drawing.Point(180, 70);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(150, 26);
            this.textBox17.TabIndex = 18;
            this.textBox17.Text = "0";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(798, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(182, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ajouter un évenement";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.Color.Lavender;
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Location = new System.Drawing.Point(24, 23);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(144, 26);
            this.textBox28.TabIndex = 6;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox4
            // 
            this.checkBox4.Enabled = false;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(24, 199);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(108, 35);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Autre";
            // 
            // checkBox3
            // 
            this.checkBox3.Enabled = false;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(24, 140);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 35);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Réparation";
            // 
            // checkBox2
            // 
            this.checkBox2.Enabled = false;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(24, 82);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 35);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Contrôle";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(180, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1146, 26);
            this.textBox4.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(180, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1146, 306);
            this.listBox1.TabIndex = 1;
            // 
            // lvDevis
            // 
            this.lvDevis.BackColor = System.Drawing.Color.MintCream;
            this.lvDevis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDevis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvDevis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDevis.FullRowSelect = true;
            this.lvDevis.GridLines = true;
            this.lvDevis.HideSelection = false;
            this.lvDevis.Location = new System.Drawing.Point(12, 12);
            this.lvDevis.MultiSelect = false;
            this.lvDevis.Name = "lvDevis";
            this.lvDevis.Size = new System.Drawing.Size(1368, 504);
            this.lvDevis.TabIndex = 1;
            this.lvDevis.UseCompatibleStateImageBehavior = false;
            this.lvDevis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "N° Devis";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date entrée réelle";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date décision";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date réparation";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Type devis";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 160;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.MintCream;
            this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader11,
            this.columnHeader12});
            this.listView3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(12, 12);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(1368, 573);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Code machine";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Client";
            this.columnHeader4.Width = 280;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Affectation";
            this.columnHeader11.Width = 160;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Site";
            this.columnHeader12.Width = 160;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(48, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(540, 328);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Cause";
            this.columnHeader13.Width = 270;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Total";
            this.columnHeader14.Width = 80;
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.Color.White;
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Location = new System.Drawing.Point(480, 70);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(108, 26);
            this.textBox27.TabIndex = 9;
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.White;
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(372, 70);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(108, 26);
            this.textBox26.TabIndex = 8;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.Color.White;
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(264, 70);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(108, 26);
            this.textBox25.TabIndex = 7;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.White;
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(156, 70);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(108, 26);
            this.textBox24.TabIndex = 6;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.White;
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Location = new System.Drawing.Point(48, 70);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(108, 26);
            this.textBox23.TabIndex = 5;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(468, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 23);
            this.label28.TabIndex = 4;
            this.label28.Text = "Total général";
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(360, 35);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(108, 23);
            this.label27.TabIndex = 3;
            this.label27.Text = "Total transp.";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(264, 35);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 23);
            this.label26.TabIndex = 2;
            this.label26.Text = "Total ctrl";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(156, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 23);
            this.label25.TabIndex = 1;
            this.label25.Text = "Total M.O";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(36, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 23);
            this.label24.TabIndex = 0;
            this.label24.Text = "Total pièces";
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.Color.MintCream;
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox30.Location = new System.Drawing.Point(12, 12);
            this.textBox30.Multiline = true;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(1368, 362);
            this.textBox30.TabIndex = 0;
            this.textBox30.Text = "?";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.mtgcComboBox1);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(9, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1371, 58);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // mtgcComboBox1
            // 
            this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox1.ColumnNum = 4;
            this.mtgcComboBox1.ColumnWidth = "121;121;150;150";
            this.mtgcComboBox1.DisplayMember = "Text";
            this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox1.DropDownWidth = 562;
            this.mtgcComboBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox1.GridLineHorizontal = false;
            this.mtgcComboBox1.GridLineVertical = true;
            this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox1.Location = new System.Drawing.Point(130, 18);
            this.mtgcComboBox1.ManagingFastMouseMoving = true;
            this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox1.Name = "mtgcComboBox1";
            this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.Size = new System.Drawing.Size(972, 27);
            this.mtgcComboBox1.TabIndex = 0;
            this.mtgcComboBox1.TabStop = false;
            this.mtgcComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox1_KeyDown);
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.SteelBlue;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label31.Location = new System.Drawing.Point(448, 22);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(264, 23);
            this.label31.TabIndex = 0;
            this.label31.Text = "CREATION MACHINE";
            this.label31.Visible = false;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Recherche";
            // 
            // btSupprime
            // 
            this.btSupprime.BackColor = System.Drawing.Color.White;
            this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupprime.Enabled = false;
            this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprime.ForeColor = System.Drawing.Color.Red;
            this.btSupprime.Location = new System.Drawing.Point(732, 947);
            this.btSupprime.Name = "btSupprime";
            this.btSupprime.Size = new System.Drawing.Size(150, 34);
            this.btSupprime.TabIndex = 21;
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
            this.btEnregistre.Location = new System.Drawing.Point(192, 947);
            this.btEnregistre.Name = "btEnregistre";
            this.btEnregistre.Size = new System.Drawing.Size(150, 34);
            this.btEnregistre.TabIndex = 22;
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
            this.btNouveau.Location = new System.Drawing.Point(24, 947);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(150, 34);
            this.btNouveau.TabIndex = 19;
            this.btNouveau.TabStop = false;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.UseVisualStyleBackColor = false;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // tabControlEX1
            // 
            this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
            this.tabControlEX1.Controls.Add(this.tabPageEX1);
            this.tabControlEX1.Controls.Add(this.tabPageEX5);
            this.tabControlEX1.Controls.Add(this.tabPageEX2);
            this.tabControlEX1.Controls.Add(this.tabPageEX4);
            this.tabControlEX1.Controls.Add(this.tabPageEX3);
            this.tabControlEX1.Controls.Add(this.tabPageEX6);
            this.tabControlEX1.ForeColor = System.Drawing.Color.Black;
            this.tabControlEX1.Location = new System.Drawing.Point(-12, 82);
            this.tabControlEX1.Name = "tabControlEX1";
            this.tabControlEX1.SelectedIndex = 0;
            this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
            this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
            this.tabControlEX1.Size = new System.Drawing.Size(1416, 830);
            this.tabControlEX1.TabColor = System.Drawing.Color.DarkGray;
            this.tabControlEX1.TabIndex = 23;
            this.tabControlEX1.TabStop = false;
            this.tabControlEX1.UseVisualStyles = false;
            // 
            // tabPageEX1
            // 
            this.tabPageEX1.Controls.Add(this.button4);
            this.tabPageEX1.Controls.Add(this.button10);
            this.tabPageEX1.Controls.Add(this.groupBox1);
            this.tabPageEX1.Controls.Add(this.textBox32);
            this.tabPageEX1.Controls.Add(this.groupBox4);
            this.tabPageEX1.Controls.Add(this.groupBox3);
            this.tabPageEX1.Controls.Add(this.textBox5);
            this.tabPageEX1.Controls.Add(this.groupBox5);
            this.tabPageEX1.Controls.Add(this.groupBox6);
            this.tabPageEX1.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(1408, 797);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Saisie";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 702);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 33);
            this.button4.TabIndex = 8;
            this.button4.Text = "ImportCAM";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // tabPageEX5
            // 
            this.tabPageEX5.Controls.Add(this.textBox27);
            this.tabPageEX5.Controls.Add(this.label26);
            this.tabPageEX5.Controls.Add(this.textBox26);
            this.tabPageEX5.Controls.Add(this.textBox25);
            this.tabPageEX5.Controls.Add(this.textBox24);
            this.tabPageEX5.Controls.Add(this.textBox23);
            this.tabPageEX5.Controls.Add(this.label27);
            this.tabPageEX5.Controls.Add(this.label28);
            this.tabPageEX5.Controls.Add(this.label25);
            this.tabPageEX5.Controls.Add(this.label24);
            this.tabPageEX5.Controls.Add(this.listView1);
            this.tabPageEX5.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX5.Name = "tabPageEX5";
            this.tabPageEX5.Size = new System.Drawing.Size(1408, 797);
            this.tabPageEX5.TabIndex = 4;
            this.tabPageEX5.Text = "Autres Infos";
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.Controls.Add(this.numericUpDown1);
            this.tabPageEX2.Controls.Add(this.checkBox4);
            this.tabPageEX2.Controls.Add(this.checkBox3);
            this.tabPageEX2.Controls.Add(this.listBox1);
            this.tabPageEX2.Controls.Add(this.checkBox2);
            this.tabPageEX2.Controls.Add(this.textBox4);
            this.tabPageEX2.Controls.Add(this.button2);
            this.tabPageEX2.Controls.Add(this.textBox28);
            this.tabPageEX2.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(1408, 797);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Historique";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(182, 387);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 44);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabPageEX4
            // 
            this.tabPageEX4.Controls.Add(this.listView3);
            this.tabPageEX4.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX4.Name = "tabPageEX4";
            this.tabPageEX4.Size = new System.Drawing.Size(1408, 797);
            this.tabPageEX4.TabIndex = 3;
            this.tabPageEX4.Text = "Correspondances Machines";
            // 
            // tabPageEX3
            // 
            this.tabPageEX3.Controls.Add(this.lvDevis);
            this.tabPageEX3.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX3.Name = "tabPageEX3";
            this.tabPageEX3.Size = new System.Drawing.Size(1408, 797);
            this.tabPageEX3.TabIndex = 2;
            this.tabPageEX3.Text = "Liste des devis";
            // 
            // tabPageEX6
            // 
            this.tabPageEX6.Controls.Add(this.textBox30);
            this.tabPageEX6.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX6.Name = "tabPageEX6";
            this.tabPageEX6.Size = new System.Drawing.Size(1408, 797);
            this.tabPageEX6.TabIndex = 5;
            this.tabPageEX6.Text = "Commentaires";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1284, 924);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 70);
            this.button9.TabIndex = 24;
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // ParcMachine
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 19);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1352, 781);
            this.ControlBox = false;
            this.Controls.Add(this.button9);
            this.Controls.Add(this.tabControlEX1);
            this.Controls.Add(this.btSupprime);
            this.Controls.Add(this.btEnregistre);
            this.Controls.Add(this.btNouveau);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ParcMachine";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parc machines";
            this.VisibleChanged += new System.EventHandler(this.ParcMachine_VisibleChanged);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControlEX1.ResumeLayout(false);
            this.tabPageEX1.ResumeLayout(false);
            this.tabPageEX1.PerformLayout();
            this.tabPageEX5.ResumeLayout(false);
            this.tabPageEX5.PerformLayout();
            this.tabPageEX2.ResumeLayout(false);
            this.tabPageEX2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPageEX4.ResumeLayout(false);
            this.tabPageEX3.ResumeLayout(false);
            this.tabPageEX6.ResumeLayout(false);
            this.tabPageEX6.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{
			mtgcComboBox1.Items.Clear();
			mtgcComboBox2.Items.Clear();
			mtgcComboBox5.Items.Clear();
			this.Refresh();
			

			try
			{
				Comm.CommandText="SELECT Affectation, ID FROM T_affectation";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"T_affectation");
				mtgcComboBox3.SourceDataString=new string[]{"ID","affectation","",""};
				mtgcComboBox3.SourceDataTable=ds.Tables["t_affectation"];
				ds.Tables["t_affectation"].Clear();
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}

			try
			{
				Comm.CommandText="SELECT affectation, ID, Site FROM T_site";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"T_affectation");
				mtgcComboBox4.SourceDataString=new string[]{"ID","site","",""};
				mtgcComboBox4.SourceDataTable=ds.Tables["t_affectation"];
				ds.Tables["t_affectation"].Clear();
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			mtgcComboBox3.SelectedIndex=0;
			mtgcComboBox4.SelectedIndex=0;

			Comm.CommandText="SELECT t_clients.Ident,T_clients.Nom, T_clients.Adresse_1, T_clients.Ville, T_clients.Code_postal FROM T_clients ORDER BY T_clients.Nom";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_clients");
			foreach(DataRow row in ds.Tables["t_clients"].Rows)
			{
				MTGCComboBoxItem Item = new MTGCComboBoxItem(row["nom"].ToString(),row["adresse_1"].ToString(),row["Code_postal"].ToString(),row["ville"].ToString());
				Item.Tag=row["Ident"].ToString();
				mtgcComboBox5.Items.Add(Item);
			}
			mtgcComboBox5.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox5.SelectedIndex=0;
			ds.Tables["t_clients"].Clear();
			
			Comm.CommandText="SELECT T_type_machine.Code, T_fournisseurs.Nom, T_famille_machine.Designation FROM T_famille_machine INNER JOIN (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) ON T_famille_machine.Code = T_type_machine.[Code famille] ORDER BY T_type_machine.Code";

			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_type_machine");
			}
			catch(Exception exp)
			{
			}
			mtgcComboBox2.SourceDataString=new string[]{"Code","Nom","Designation",""};
			mtgcComboBox2.SourceDataTable=ds.Tables["t_type_machine"];
			mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox2.SelectedIndex=0;
			ds.Tables["t_type_machine"].Clear();

			Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_famille_machine.Designation FROM T_famille_machine INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] order by T_parc_machine.[Code machine Opindus]";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_parc_machine");
			mtgcComboBox1.SourceDataString=new string[]{"Code machine opindus","Type machine","Nom","Designation"};
			mtgcComboBox1.SourceDataTable=ds.Tables["t_parc_machine"];
			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox1.SelectedIndex=0;
			ds.Tables["t_parc_machine"].Clear();
		}

		private void Activer()
		{
			button5.Enabled=true;
			button10.Enabled=true;
			button6.Enabled=true;
			button7.Enabled=true;
			button8.Enabled=true;
			button11.Enabled=true;
			textBox1.Enabled=true;
			textBox2.Enabled=true;
			textBox5.Enabled=true;
			textBox6.Enabled=true;
			textBox7.Enabled=true;
			textBox8.Enabled=true;
			textBox12.Enabled=true;
			textBox13.Enabled=true;
			textBox14.Enabled=true;
			textBox15.Enabled=true;
			textBox17.Enabled=true;
			textBox19.Enabled=true;
			textBox20.Enabled=true;
			textBox21.Enabled=true;
			textBox32.Enabled=true;
			mtgcComboBox2.Enabled=true;
			mtgcComboBox3.Enabled=true;
			mtgcComboBox4.Enabled=true;
			checkBox1.Enabled=true;
			btEnregistre.Enabled=true;
		}

		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			Clients WinInfoCli = new Clients(Agence,label3.Text);
			WinInfoCli.ShowDialog();
			this.Refresh();
		}

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			Nouveau=true;
			Nettoyer();
			btEnregistre.Enabled=true;
			VisibleOK();
			textBox1.Focus();
			button10.Enabled=false;
			textBox5.Enabled=false;
			textBox32.Enabled=false;
			textBox1.BackColor=Color.MistyRose;
			textBox1.ForeColor=Color.Black;
			textBox20.Enabled=false;
			mtgcComboBox5.Enabled=true;
			button6.Enabled=true;
			button1.Enabled=false;
			button7.Enabled=false;
			button8.Enabled=false;
			label12.Visible=false;
			mtgcComboBox1.Visible=false;
			groupBox2.BackColor=Color.SteelBlue;
			label31.Visible=true;
			textBox3.Text=DateTime.Today.ToShortDateString();
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(textBox20.Text.Length>0)
			{
				DetailDevis WinDetailDevis = new DetailDevis(Agence,textBox20.Text);
				WinDetailDevis.ShowDialog();
				this.Refresh();
			}
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			if(textBox32.TextLength>0)
			{
				DetailDevis WinDetailDevis = new DetailDevis(Agence,textBox32.Text);
				WinDetailDevis.ShowDialog();
				this.Refresh();
			}
			else
				MessageBox.Show("Aucun devis en cours","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void button11_Click(object sender, System.EventArgs e)
		{
			Emplacements WinEmplacements = new Emplacements(Agence);
			WinEmplacements.ShowDialog();
			this.Refresh();

			mtgcComboBox3.Items.Clear();
			Comm.CommandText="SELECT Affectation, ID FROM T_affectation";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"Affectation");
			mtgcComboBox3.SourceDataTable=ds.Tables["Affectation"];
			mtgcComboBox3.SourceDataString=new string[]{"ID","Affectation","",""};
			ds.Tables["Affectation"].Clear();

			mtgcComboBox4.Items.Clear();
			Comm.CommandText="SELECT affectation, ID, Site FROM T_site";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"Sites");
			mtgcComboBox4.SourceDataTable=ds.Tables["Sites"];
			mtgcComboBox4.SourceDataString=new string[]{"ID","Site","",""};
			ds.Tables["Sites"].Clear();
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus],t_famille_machine.code, T_parc_machine.[Type machine], T_famille_machine.Type FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_parc_machine.[Code machine Opindus])='"+textBox1.Text+"'))";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_famille_machine");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			if(ds.Tables["t_famille_machine"].Rows[0]["Type"].ToString().Equals("1"))
			{
				Caracteristiques WinCarac = new Caracteristiques(Agence,textBox1.Text,label3.Text);
				WinCarac.ShowDialog();
			}
			else if(ds.Tables["t_famille_machine"].Rows[0]["Type"].ToString().Equals("2"))
			{
				Caracteristiques2 WinCarac = new Caracteristiques2(Agence,textBox1.Text);
				WinCarac.ShowDialog();
			}
			else
			{
				Caracteristiques3 WinCarac = new Caracteristiques3(Agence,textBox1.Text);
				WinCarac.ShowDialog();
			}
			ds.Tables["t_famille_machine"].Clear();
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			int Error=0;

			if(textBox1.TextLength.Equals(0))
			{
				Error=1;
				textBox1.BackColor=Color.MistyRose;
				MessageBox.Show("Champ Code machine obligatoire","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
				textBox1.BackColor=Color.Empty;

			if(mtgcComboBox2.SelectedIndex.Equals(0))
			{
				Error=1;
				mtgcComboBox2.BackColor=Color.MistyRose;
				MessageBox.Show("Champ type machine obligatoire","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
				mtgcComboBox2.BackColor=Color.Empty;

			if(mtgcComboBox5.SelectedIndex.Equals(0))
			{
				Error=1;
				mtgcComboBox5.BackColor=Color.MistyRose;
				MessageBox.Show("Champ Client obligatoire","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
				mtgcComboBox5.BackColor=Color.Empty;
			if(textBox13.TextLength.Equals(0))
			{
				textBox13.Text="XXX";
			}
			if(Nouveau)
			{
				try
				{
					oleDbConnection1.Open();
					Comm.CommandText="select [code machine opindus] from t_parc_machine WHERE [Code machine opindus]='"+textBox1.Text.Replace("'","''")+"'";
					DataAD.SelectCommand=Comm;
					if(DataAD.Fill(ds,"exist")>0)
					{
						MessageBox.Show("Code machine déjà existant !");
						Error=1;
					}
					ds.Tables["exist"].Clear();
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				finally
				{
					oleDbConnection1.Close();
				}
				if(Error.Equals(0))
				{
					if(textBox17.TextLength.Equals(0))
						textBox17.Text="0";
					if(textBox19.TextLength.Equals(0))
						textBox19.Text="0";
					String SQL="";
					SQL+="INSERT INTO t_parc_machine ([Code machine opindus],[Code client],[Type machine],[En parc],Affectation,Site";
					if(textBox2.Text.Length>0)
						SQL+=", [Code machine client]";
					if(textBox6.Text.Length>0)
						SQL+=", [No Serie]";
					if(textBox12.Text.Length>0)
						SQL+=", [Code Mabec]";
					if(textBox13.Text.Length>0)
						SQL+=", [N° Troncon]";
					if(textBox7.Text.Length>0)
						SQL+=", [Prix achat]";
					if(textBox8.Text.Length>0)
						SQL+=", [Prix remplacement]";
					if(textBox17.Text.Length>0)
						SQL+=", [nombre semaine entre ctl]";
					if(textBox19.Text.Length>0)
						SQL+=", [nombre semaine entre inter]";
					SQL+=") VALUES ('"+textBox1.Text.Replace("'","''")+"',"+label3.Text+",'"+mtgcComboBox2.Text+"',"+checkBox1.Checked+","+mtgcComboBox3.Text+","+mtgcComboBox4.Text;
					if(textBox2.Text.Length>0)
						SQL+=",'"+textBox2.Text.Replace("'","''")+"'";
					if(textBox6.Text.Length>0)
						SQL+=",'"+textBox6.Text.Replace("'","''")+"'";
					if(textBox12.Text.Length>0)
						SQL+=",'"+textBox12.Text.Replace("'","''")+"'";
					if(textBox13.Text.Length>0)
						SQL+=",'"+textBox13.Text.Replace("'","''")+"'";
					if(textBox7.Text.Length>0)
						SQL+=","+textBox7.Text.Replace(",",".");
					if(textBox8.Text.Length>0)
						SQL+=","+textBox8.Text.Replace(",",".");
					if(textBox17.Text.Length>0)
						SQL+=","+textBox17.Text.Replace(",",".");
					if(textBox19.Text.Length>0)
						SQL+=","+textBox19.Text.Replace(",",".");
					SQL+=")";

					Comm.CommandText=SQL;

					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();

                        Comm.CommandText = "insert into t_parc_machine_historique ([Code machine opindus],Dateinter,description,typeinterv) VALUES ('" + textBox1.Text.Replace("'", "''") + "','" + DateTime.Now.ToShortDateString() + "','Création de la machine : " + textBox1.Text.Replace("'", "''") + "',3)";
                        Comm.ExecuteNonQuery();

						try
						{
							Transac.Commit();
							MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
							Nettoyer();
							mtgcComboBox1.SelectedIndex=0;
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
			else
			{
				if(Error.Equals(0))
				{
					if(textBox17.TextLength.Equals(0))
						textBox17.Text="0";
					if(textBox19.TextLength.Equals(0))
						textBox19.Text="0";
					String SQL="";
					SQL+="UPDATE t_parc_machine SET [Code client]="+label3.Text+",[Type machine]='"+mtgcComboBox2.Text+"',[En parc]="+checkBox1.Checked+",Affectation="+mtgcComboBox3.Text+",Site="+mtgcComboBox4.Text;
					if(textBox2.Text.Length>0)
						SQL+=", [Code machine client]='"+textBox2.Text.Replace("'","''")+"'";;
					if(textBox6.Text.Length>0)
						SQL+=", [No Serie]='"+textBox6.Text.Replace("'","''")+"'";;
					if(textBox12.Text.Length>0)
						SQL+=", [Code Mabec]='"+textBox12.Text.Replace("'","''")+"'";
					if(textBox13.Text.Length>0)
						SQL+=", [N° Troncon]='"+textBox13.Text.Replace("'","''")+"'";
					if(textBox7.Text.Length>0)
						SQL+=", [Prix achat]="+textBox7.Text.Replace(",",".");
					if(textBox8.Text.Length>0)
						SQL+=", [Prix remplacement]="+textBox8.Text.Replace(",",".");
					if(textBox17.Text.Length>0)
						SQL+=", [nombre semaine entre ctl]="+textBox17.Text.Replace(",",".");
					if(textBox19.Text.Length>0)
						SQL+=", [nombre semaine entre inter]="+textBox19.Text.Replace(",",".");
					SQL+=" WHERE [Code machine opindus]='"+textBox1.Text.Replace("'","''")+"'";
					Comm.CommandText=SQL;

					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						MTGCComboBoxItem Cli=(MTGCComboBoxItem)mtgcComboBox5.SelectedItem;
						Comm.CommandText="UPDATE t_devis_entete SET [code client]="+Cli.Tag.ToString()+" WHERE [code materiel]='"+textBox2.Text+"' AND [code client]="+Ident;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
							Nettoyer();
							mtgcComboBox1.SelectedIndex=0;
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
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			textBox2.Text=textBox1.Text;
		}


		private void textBox7_Leave(object sender, System.EventArgs e)
		{
			string prix=null;
			if(textBox7.Text.Length>0)
				textBox7.Text=System.Convert.ToDecimal(textBox7.Text.ToString().Replace(".",",")).ToString("0.00");
		}

		private void textBox8_Leave(object sender, System.EventArgs e)
		{
			string prix=null;
			if(textBox8.Text.Length>0)
				textBox8.Text=System.Convert.ToDecimal(textBox8.Text.ToString()).ToString("0.00");
		}

		private void btSupprime_Click(object sender, System.EventArgs e)
		{		
			if(MessageBox.Show("Supprimer la machine ?","Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
			{
				Comm.CommandText="DELETE FROM t_parc_machine WHERE [Code machine opindus]='"+textBox1.Text+"'";
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
						Nettoyer();
						NoVisible();
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
				Nettoyer();
			}
			Comm.CommandText="SELECT [Code machine opindus],[Type machine] FROM t_parc_machine";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_parc_machine");
			mtgcComboBox1.Items.Clear();
			mtgcComboBox1.SourceDataString=new string[]{"code machine opindus","Type machine","",""};
			mtgcComboBox1.SourceDataTable=ds.Tables["t_parc_machine"];
			mtgcComboBox1.SelectedIndex=-1;
			ds.Tables["t_parc_machine"].Clear();
		}
		private void Nettoyer()
		{
			btEnregistre.Enabled=false;
			textBox1.Clear();
			textBox1.BackColor=Color.Lavender;
			textBox2.Clear();
            textBox3.Clear();
			textBox5.Clear();
			textBox32.Clear();
			textBox5.BackColor=Color.Lavender;
			textBox32.BackColor=Color.Lavender;
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
			textBox12.Clear();
			textBox13.Text="XXX";
			textBox14.Clear();
			textBox15.Clear();
            textBox16.Clear();
            textBox18.Clear();
			textBox17.Text="0";
			textBox19.Text="0";
            textBox11.Clear();
			textBox20.Clear();
			textBox21.Clear();
			textBox23.Clear();
			textBox24.Clear();
			textBox25.Clear();
			textBox26.Clear();
			textBox27.Clear();
			textBox28.Clear();
			textBox30.Clear();
			textBox31.Clear();
			textBox32.Clear();
			mtgcComboBox2.SelectedIndex=0;
			mtgcComboBox5.SelectedIndex=0;
			label3.Text="";
			label4.Text="";
			label32.Text="";
			label33.Text="";
			listBox1.Items.Clear();
			listView1.Items.Clear();
			listView3.Items.Clear();
			lvDevis.Items.Clear();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			TypesMachines WinTypes=null;
			if(mtgcComboBox2.SelectedIndex.Equals(0))
			{
				WinTypes= new TypesMachines(Agence,true);
				WinTypes.ShowDialog();
			}
			else
			{
				try
				{
					WinTypes= new TypesMachines(Agence,mtgcComboBox2.Text);
					WinTypes.ShowDialog();
				}
				catch(Exception exp)
				{
					WinTypes= new TypesMachines(Agence,true);
					WinTypes.ShowDialog();
				}
			}
			this.Refresh();
			mtgcComboBox2.Items.Clear();
			Comm.CommandText="SELECT T_type_machine.Code, T_fournisseurs.Nom, T_famille_machine.Designation FROM T_famille_machine INNER JOIN (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) ON T_famille_machine.Code = T_type_machine.[Code famille] ORDER BY T_type_machine.Code";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_type_machine");
			mtgcComboBox2.SourceDataTable=ds.Tables["t_type_machine"];
			mtgcComboBox2.SourceDataString=new string[]{"Code","Nom","Designation",""};
			mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox2.SelectedIndex=0;
			ds.Tables["t_type_machine"].Clear();
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			SelectClients WinSelectCli = new SelectClients(Agence);
			if(WinSelectCli.ShowDialog()==DialogResult.OK)
			{
				DataRow row = WinSelectCli.GetRow();
				mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(row["Nom"].ToString());
			}
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			/*FicheDeVie WinFicheVie = new FicheDeVie(Agence,textBox1.Text);
			WinFicheVie.ShowDialog();*/

			Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Total devis], T_devis_entete.[Type devis], T_site.Site, T_affectation.Affectation FROM T_affectation INNER JOIN (T_site INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_site.ID = T_parc_machine.Site) ON (T_site.ID = T_affectation.ID) AND (T_affectation.ID = T_parc_machine.Affectation) WHERE (((T_parc_machine.[Code machine Opindus])='"+textBox1.Text+"')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Total devis], T_devis_entete.[Type devis], T_site.Site, T_affectation.Affectation";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"Vie");

			Microsoft.Office.Interop.Excel.Application oXL; 
			Microsoft.Office.Interop.Excel._Workbook oWB; 
			Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel._Worksheet oSheet2;
            Microsoft.Office.Interop.Excel._Worksheet oSheet3;
            Microsoft.Office.Interop.Excel._Worksheet oSheet4;
            Microsoft.Office.Interop.Excel._Worksheet oSheet5; 
			Microsoft.Office.Interop.Excel.Range oRng;

			oXL = new Microsoft.Office.Interop.Excel.Application();

            try
            {
                oXL.Application.Visible = false;
            }
            catch
            {
                oXL.Application.Visible = false;
            }
			
			oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\modeles\historique.xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);
			
			oWB = (Microsoft.Office.Interop.Excel._Workbook)oXL.Workbooks[1];
			oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1];
            oSheet2 = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[2];
            oSheet3 = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[3];
            oSheet4 = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[4];
            oSheet5 = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[5];

            Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date reparation], T_devis_entete.[Total devis], T_devis_entete.[Type devis], T_site.Site, T_affectation.Affectation FROM T_affectation INNER JOIN (T_site INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_site.ID = T_parc_machine.Site) ON (T_site.ID = T_affectation.ID) AND (T_affectation.ID = T_parc_machine.Affectation) WHERE (((T_parc_machine.[Code machine Opindus])='" + textBox1.Text + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date reparation], T_devis_entete.[Total devis], T_devis_entete.[Type devis], T_site.Site, T_affectation.Affectation";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"Devis");
			Decimal CumulRep=0;
			int Cell=10;
            int Cell2 = 10;
            int Cell3 = 10;
            int Cell4 = 10;
            int Cell5 = 10;
            Comm.CommandText = "SELECT T_parc_machine_historique.Dateinter, T_parc_machine_historique.typeinterv, T_parc_machine_historique.N_Controle, T_parc_machine_historique.infos_1, T_parc_machine_historique.infos_1_1, T_parc_machine_historique.infos_3, T_parc_machine_historique.infos_4, T_parc_machine_historique.ind_k, T_parc_machine_historique.test_k, T_parc_machine_historique.description, T_affectation.Affectation, T_site.Site FROM T_site INNER JOIN (T_affectation INNER JOIN (T_parc_machine INNER JOIN T_parc_machine_historique ON T_parc_machine.[Code machine Opindus] = T_parc_machine_historique.[Code machine Opindus]) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site where T_parc_machine_historique.[code machine opindus]='" + textBox1.Text + "'";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_machines_histo");
            Decimal Cumul = 0;
            Decimal Cumul2 = 0;
            Decimal CumulDepRep = 0;
            int CptRep = 1;
			if(ds.Tables["t_machines_histo"].Rows.Count>0)
			{
                foreach (DataRow Histo in ds.Tables["t_machines_histo"].Rows)
                {
                    oSheet.Cells[Cell, 1] = Histo["Dateinter"].ToString();
                    oSheet.Cells[Cell, 2] = Histo["Description"].ToString();
                    if (Histo["Description"].ToString().Length > 0 && Histo["typeinterv"].ToString().Equals("2"))
                    {
                        String Montant = Histo["infos_3"].ToString().Remove(0, 19);
                        Montant = Montant.Trim('€');
                        Decimal amount = System.Convert.ToDecimal(Montant);
                        Cumul += amount;
                        oSheet.Cells[Cell, 3] = amount.ToString("C");
                        
                        if (Histo["Description"].ToString().Equals("Réparation"))
                        {
                            Montant = Histo["infos_3"].ToString().Remove(0, 19);
                            Montant = Montant.Trim('€');
                            amount = System.Convert.ToDecimal(Montant);
                            Cumul2 += amount;
                            oSheet2.Cells[Cell2, 1] = Histo["Dateinter"].ToString();
                            oSheet2.Cells[Cell2, 2] = Histo["Description"].ToString();
                            oSheet2.Cells[Cell2, 3] = amount.ToString("C");
                            oSheet2.Cells[Cell2, 4] = Cumul2.ToString("C");
                            CumulDepRep += amount;
                            oSheet2.Cells[Cell2, 5] = CumulDepRep.ToString("C");
                            oSheet2.Cells[Cell2, 8] = CptRep.ToString();
                            oSheet2.Cells[Cell2, 13] = Histo["Affectation"].ToString();
                            oSheet2.Cells[Cell2, 14] = Histo["Site"].ToString();
                            Cell2++;
                        }
                    }
                    else if (Histo["Description"].ToString().Length > 0 && Histo["typeinterv"].ToString().Equals("1"))
                    {
                        oSheet5.Cells[Cell5, 1] = Histo["Dateinter"].ToString();
                        oSheet5.Cells[Cell5, 2] = "Contrôle N°: " + Histo["N_Controle"].ToString();
                        oSheet5.Cells[Cell5, 3] = Histo["infos_3"].ToString() + " Normalité : " + System.Convert.ToDecimal(Histo["test_k"].ToString()).ToString("0.000") + " (<" + Histo["ind_k"].ToString() + " pour normalité) " + Histo["infos_4"].ToString();
                        oSheet5.Cells[Cell5, 4] = Histo["Affectation"].ToString();
                        oSheet5.Cells[Cell5, 5] = Histo["Site"].ToString();
                        Cell5++;

                    }
                    else if (Histo["Description"].ToString().Length > 0 && Histo["typeinterv"].ToString().Equals("0"))
                    {
                        Decimal Rien = 0;
                        oSheet2.Cells[Cell2, 3] = Rien.ToString("C");
                        oSheet2.Cells[Cell2, 4] = Cumul2.ToString("C");
                        oSheet2.Cells[Cell2, 1] = Histo["Dateinter"].ToString();
                        oSheet2.Cells[Cell2, 2] = Histo["Description"].ToString();
                        oSheet.Cells[Cell, 3] = Rien.ToString("C");
                        Cell2++;

                    }
                    else if (Histo["Description"].ToString().Length > 0 && Histo["typeinterv"].ToString().Equals("3"))
                    {
                        if (Histo["Description"].ToString().Equals("Affectation"))
                        {
                            oSheet4.Cells[Cell4, 1] = Histo["Dateinter"].ToString();
                            oSheet4.Cells[Cell4, 2] = Histo["Description"].ToString();
                            oSheet4.Cells[Cell4, 3] = Histo["infos_1"].ToString();
                            oSheet4.Cells[Cell4, 4] = Histo["infos_1_1"].ToString();
                            Cell4++;
                        }
                    }
                    else
                    {
                        Decimal Rien = 0;
                        oSheet.Cells[Cell, 3] = Rien.ToString("C");
                    }
                    oSheet.Cells[Cell, 4] = Cumul.ToString("C");
                    oSheet.Cells[Cell, 5] = Histo["Affectation"].ToString();
                    oSheet.Cells[Cell, 6] = Histo["Site"].ToString();
                    Cell++;
                }
				
			}
            ds.Tables["t_machines_histo"].Clear();
			/*if(ds.Tables["Devis"].Rows.Count>0)
			{
				foreach(DataRow row in ds.Tables["Devis"].Rows)
				{
					oSheet.Cells[Cell,1] =row["date reparation"].ToString().Remove(10,9);
					if(row["type devis"].ToString().Equals("1"))
						oSheet.Cells[Cell,2] ="Rep. "+row["n° devis"].ToString();
					else if(row["type devis"].ToString().Equals("2"))
						oSheet.Cells[Cell,2] ="Gar. "+row["n° devis"].ToString();
					else
						oSheet.Cells[Cell,2] ="Ctrl. "+row["n° devis"].ToString();
					oSheet.Cells[Cell,3] =System.Convert.ToDecimal(row["total devis"].ToString()).ToString("c");
					if(row["type devis"].ToString().Equals("1"))
						CumulRep+=System.Convert.ToDecimal(row["Total devis"].ToString());
					oSheet.Cells[Cell,4] =CumulRep .ToString("c");
					oSheet.Cells[Cell,5] =row["Affectation"].ToString();
					oSheet.Cells[Cell,6] =row["Site"].ToString();
					//listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Comment"].ToString());
					Cell++;

				}
			}
			Cell=10;
			CumulRep=0;
			Decimal CumulCtrl=0;
			Decimal CumulTotal=0;
			int TotalRep=0;
			int TotalCtrl=0;

			oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[2];

			if(ds.Tables["Devis"].Rows.Count>0)
			{
				foreach(DataRow row in ds.Tables["Devis"].Rows)
				{
					oSheet.Cells[Cell,1] =row["date reparation"].ToString().Remove(10,9);
					if(row["type devis"].ToString().Equals("1"))
					{
						oSheet.Cells[Cell,2] ="Rep. "+row["n° devis"].ToString();
						TotalRep+=1;
					}
					else if(row["type devis"].ToString().Equals("2"))
					{
						oSheet.Cells[Cell,2] ="Gar. "+row["n° devis"].ToString();
						TotalRep+=1;
					}
					else
					{
						oSheet.Cells[Cell,2] ="Ctrl. "+row["n° devis"].ToString();
						TotalCtrl+=1;
					}
					oSheet.Cells[Cell,3] =System.Convert.ToDecimal(row["total devis"].ToString()).ToString("c");
					oSheet.Cells[Cell,4] =" ";
					if(row["type devis"].ToString().Equals("1"))
						CumulRep+=System.Convert.ToDecimal(row["Total devis"].ToString());
					else if(row["type devis"].ToString().Equals("3"))
						CumulCtrl+=System.Convert.ToDecimal(row["Total devis"].ToString());
					oSheet.Cells[Cell,6] =CumulRep.ToString("c");
					oSheet.Cells[Cell,8] =TotalRep.ToString();
					oSheet.Cells[Cell,10] =CumulCtrl.ToString("c");
					CumulTotal=CumulCtrl+CumulRep;
					oSheet.Cells[Cell,9] =CumulTotal.ToString("c");
					oSheet.Cells[Cell,12] =TotalCtrl.ToString();
					oSheet.Cells[Cell,13] =row["Affectation"].ToString();
					oSheet.Cells[Cell,14] =row["Site"].ToString();
					//listView2.Items[listView2.Items.Count-1].SubItems.Add(row["comment"].ToString());
                    Cell++;
				}
			}

			ds.Tables["Devis"].Clear();

            Cell = 10;

            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[5];

            if (ds.Tables["t_machines_histo"].Rows.Count > 0)
            {
                foreach (DataRow Histo in ds.Tables["t_machines_histo"].Rows)
                {
                    if (Histo["typeinterv"].ToString().Equals("1"))
                    {

                        oSheet.Cells[Cell, 1] = Histo["Dateinter"].ToString();
                        oSheet.Cells[Cell, 2] = "Contrôle N°: " + Histo["N_Controle"].ToString();
                        oSheet.Cells[Cell, 3] = Histo["infos_3"].ToString() + " Normalité : " + System.Convert.ToDecimal(Histo["test_k"].ToString()).ToString("0.000") + " (<" + Histo["ind_k"].ToString() + " pour normalité) " + Histo["infos_4"].ToString();
                        oSheet.Cells[Cell, 4] = Histo["Affectation"].ToString();
                        oSheet.Cells[Cell, 5] = Histo["Site"].ToString();
                        Cell++;
                    }
                }

            }*/

			oXL.Workbooks[1].SaveAs(@"C:\Program Files (x86)\Opindus\excel\historique.xls",Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,"","",false,false,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,null,null,null,null,null); 
			if(oXL != null)
			{
				oXL.Quit();
				System.Runtime.InteropServices.Marshal.ReleaseComObject (oXL);
				oXL = null;		
			}
			oXL = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                oXL.Application.Visible = true;
            }
            catch
            {
                oXL.Application.Visible = true;
            }
			oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\excel\historique.xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);

		}


		private void mtgcComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13)&&mtgcComboBox1.SelectedIndex>0)
			{
				Nettoyer();
				VisibleOK();
				mtgcComboBox3.SelectedIndex=0;
				mtgcComboBox4.SelectedIndex=0;
				btSupprime.Enabled=true;
				btEnregistre.Enabled=true;
				string typeMachine;
				Nouveau=false;
				Activer();
				Comm.CommandText="select t_affectation.[Affectation],t_site.[Site],t_parc_machine.[En parc],t_parc_machine.[site],t_parc_machine.[Affectation],t_parc_machine.[No dernier devis refus],t_parc_machine.[Date refus],t_parc_machine.[No dernier devis],t_parc_machine.[Code machine opindus],t_parc_machine.[type machine], t_parc_machine.[Code machine client],t_parc_machine.[No serie],t_parc_machine.[prix achat],t_parc_machine.[prix remplacement],t_parc_machine.[Date mise en service],t_parc_machine.[date fin garantie],t_parc_machine.[Date reforme],t_parc_machine.[Code mabec],t_parc_machine.[N° troncon],t_parc_machine.[Date dernier controle],t_parc_machine.[Date dernier intervention],t_parc_machine.[Nombre semaine entre ctl],t_parc_machine.[nombre semaine entre inter],t_famille_machine.[Designation],t_clients.[nom],t_clients.[ident],t_clients.[ville],t_fournisseurs.[nom], t_famille_machine.Type from t_affectation,t_parc_machine,t_type_machine,t_famille_machine,t_clients,t_fournisseurs,t_site where t_fournisseurs.[Code]=t_type_machine.[fournisseur] and t_parc_machine.[type machine]=t_type_machine.[code] and t_affectation.[ID]=t_parc_machine.[Affectation] and t_site.[ID]=t_parc_machine.[site] and t_type_machine.[code famille]=t_famille_machine.[code] and t_clients.[Ident]=t_parc_machine.[Code client] and t_parc_machine.[code machine opindus]='"+mtgcComboBox1.Text+"'";
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"t_parc_machine");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				if(ds.Tables["T_parc_machine"].Rows.Count>0)
				{
					
					DataRow row = ds.Tables["T_parc_machine"].Rows[0];
					typeMachine=row["type machine"].ToString();
					textBox1.Text=row["Code machine opindus"].ToString();
					textBox2.Text=row["Code machine client"].ToString();
					textBox6.Text=row["No serie"].ToString();
                    if (row["Type"].ToString().Equals("1") || row["Type"].ToString().Equals("2"))
                        button3.Visible = true;
					try
					{
					textBox7.Text=System.Convert.ToDecimal(row["Prix achat"].ToString()).ToString("0.00");
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					try
					{
						textBox8.Text=System.Convert.ToDecimal(row["Prix remplacement"].ToString()).ToString("0.00");
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					textBox12.Text=row["Code mabec"].ToString();
					textBox13.Text=row["N° troncon"].ToString();
					if(row["En parc"].ToString().Equals("True"))
						checkBox1.Checked=true;
					else
						checkBox1.Checked=false;
					if(row["Date reforme"].ToString().Length>0)
						textBox10.Text=System.Convert.ToDateTime(row["Date reforme"].ToString()).ToShortDateString();
					if(row["Date dernier controle"].ToString().Length>0)
						textBox11.Text=System.Convert.ToDateTime(row["Date dernier controle"].ToString()).ToShortDateString();
					if(row["Date mise en service"].ToString().Length>0)
						textBox3.Text=System.Convert.ToDateTime(row["Date mise en service"].ToString()).ToShortDateString();
					if(row["Date refus"].ToString().Length>0)
						textBox18.Text=System.Convert.ToDateTime(row["Date refus"].ToString()).ToShortDateString();
					if(row["Date dernier intervention"].ToString().Length>0)
						textBox16.Text=System.Convert.ToDateTime(row["Date dernier intervention"].ToString()).ToShortDateString();
					if(row["Date fin garantie"].ToString().Length>0)
						textBox9.Text=System.Convert.ToDateTime(row["Date fin garantie"].ToString()).ToShortDateString();

					textBox17.Text=row["Nombre semaine entre ctl"].ToString();
					
					textBox19.Text=row["Nombre semaine entre inter"].ToString();
					mtgcComboBox5.Focus();
					mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(row["t_clients.nom"].ToString());
					Ident=row["ident"].ToString();
					label3.Text=row["ident"].ToString();
					label32.Text=row["t_clients.nom"].ToString();
					label33.Text=row["ville"].ToString();
					label4.Text=row["Designation"].ToString()+" / "+row["t_fournisseurs.nom"].ToString();
					if(row["No dernier devis"].ToString()!="0")
						textBox20.Text=row["No dernier devis"].ToString();
					if(textBox20.TextLength>0)
						button1.Enabled=true;
					textBox21.Text=row["No dernier devis refus"].ToString();
					typeMachine=row["Type machine"].ToString();
					if(row["En parc"].ToString().Equals("True"))
						checkBox1.Checked=true;
					

					Comm.CommandText="select t_devis_entete.[N° Devis],t_devis_entete.[Date],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_devis_entete.[Date reparation],t_devis_entete.[Type devis] from t_devis_entete where [Code materiel]='"+textBox1.Text.Replace("'","''")+"' order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"T_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(row["t_parc_machine.Affectation"].ToString());
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(row["t_parc_machine.Site"].ToString());

					//mtgcComboBox2.Focus();
					mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(typeMachine);

					int cpt2=0;
					foreach(DataRow row2 in ds.Tables["T_devis_entete"].Rows)
					{
						ListViewItem item = new ListViewItem(row2["N° Devis"].ToString());
						
						if(row2["Date"].ToString().Length>0)
							item.SubItems.Add(row2["Date"].ToString().Remove(10,9));
						else
							item.SubItems.Add("");
						if(row2["Date entree reelle"].ToString().Length>0)
							item.SubItems.Add(row2["Date entree reelle"].ToString().Remove(10,9));
						else
							item.SubItems.Add("");
						if(row2["Date decision"].ToString().Length>0)
							item.SubItems.Add(row2["Date decision"].ToString().Remove(10,9));
						else
							item.SubItems.Add("");
						if(row2["Date reparation"].ToString().Length>0)
							item.SubItems.Add(row2["Date reparation"].ToString().Remove(10,9));
						else
							item.SubItems.Add("");
						if(row2["Type devis"].ToString().Length>0)
							item.SubItems.Add(row2["Type devis"].ToString());
						else
							item.SubItems.Add("");
						if(cpt2>0)
						{
							if(lvDevis.Items[cpt2-1].BackColor==Color.MintCream)
								lvDevis.Items[cpt2-1].BackColor=Color.White;
							else if(lvDevis.Items[cpt2].BackColor==Color.White)
								lvDevis.Items[cpt2].BackColor=Color.MintCream;
						}
						cpt2++;
						lvDevis.Items.Add(item);
					}

					if(ds.Tables["t_devis_entete"].Rows.Count>0)
					{
						Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Total pieces]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"t_parc_machine");
							if(ds.Tables["t_parc_machine"].Rows.Count>0)
							{
								textBox23.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
								Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Forfait DNR]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"t_parc_machine");
								textBox24.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
								Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Forfait controle]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"t_parc_machine");
								textBox25.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
								Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Forfait transport]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"t_parc_machine");
								textBox26.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
								Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Total devis]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"t_parc_machine");
								textBox27.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
							}
						}
						catch(Exception exp)
						{
							
						}
					}
					ds.Tables["t_parc_machine"].Clear();
					ds.Tables["t_devis_entete"].Clear();
					Comm.CommandText="select t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_avancement.[libelle] from t_devis_entete,t_avancement where t_devis_entete.[Niveau]=t_avancement.[Id] and [Code materiel]='"+textBox1.Text+"'";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					foreach(DataRow row5 in ds.Tables["t_devis_entete"].Rows)
					{
						if(System.Convert.ToInt32(row5["Niveau"].ToString())<7)
						{
							textBox5.BackColor=Color.Lavender;
							textBox32.BackColor=Color.Lavender;
							textBox32.Text=row5["N° Devis"].ToString();
							textBox5.Text=row5["Libelle"].ToString();
						}
					}
					
					listView3.Items.Clear();

					Comm.CommandText="select t_parc_machine.[code machine opindus],t_clients.nom,t_site.site,t_affectation.affectation from t_parc_machine,t_clients,t_site,t_affectation where t_parc_machine.site=t_site.id and t_parc_machine.affectation = t_affectation.id and t_parc_machine.[code client]=t_clients.ident and [Type machine]='"+mtgcComboBox2.Text+"'";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_parc_machine");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					cpt2=0;
					foreach(DataRow rowType in ds.Tables["t_parc_machine"].Rows)
					{
						
						listView3.Items.Add(rowType["Code machine opindus"].ToString());
						listView3.Items[listView3.Items.Count-1].SubItems.Add(rowType["nom"].ToString());
						listView3.Items[listView3.Items.Count-1].SubItems.Add(rowType["site"].ToString());
						listView3.Items[listView3.Items.Count-1].SubItems.Add(rowType["affectation"].ToString());
						if(cpt2>0)
						{
							if(listView3.Items[cpt2-1].BackColor==Color.MintCream)
								listView3.Items[cpt2].BackColor=Color.White;
							else if(listView3.Items[cpt2].BackColor==Color.White)
								listView3.Items[cpt2].BackColor=Color.MintCream;
						}
						cpt2++;
					}
					ds.Tables["t_parc_machine"].Clear();
					ds.Tables["t_devis_entete"].Clear();

					/*Comm.CommandText="select * from t_machines_histo where [code machine opindus]='"+textBox1.Text+"'";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"t_machines_histo");
					textBox4.Text="";
					textBox28.Text="";
					listBox1.Items.Clear();
					checkBox2.Checked=false;
					checkBox3.Checked=false;
					checkBox4.Checked=false;
					if(ds.Tables["t_machines_histo"].Rows.Count>0)
					{
						numericUpDown1.Enabled=true;
						NbrPages=System.Convert.ToInt32(ds.Tables["t_machines_histo"].Rows.Count.ToString());
						numericUpDown1.Maximum=NbrPages;
						numericUpDown1.Minimum=1;
						numericUpDown1.Value=1;
						textBox4.Text=ds.Tables["t_machines_histo"].Rows[CurPage]["description"].ToString();
						textBox28.Text=ds.Tables["t_machines_histo"].Rows[CurPage]["date"].ToString();
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_1"].ToString());
						listBox1.Items.Add("");
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_1_1"].ToString());
						listBox1.Items.Add("");
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_2"].ToString());
						listBox1.Items.Add("");
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_3"].ToString());
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_4"].ToString());
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_5"].ToString());
					}
					else
						numericUpDown1.Enabled=false;
					ds.Tables["t_machines_histo"].Clear();*/
					tabControlEX1.SelectedTab=tabPageEX1;

					Comm.CommandText="SELECT T_devis_entete.[Code Materiel], T_devis_lignes.Cause, Sum(T_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis] GROUP BY T_devis_entete.[Code Materiel], T_devis_lignes.Cause, T_devis_entete.Niveau HAVING (((T_devis_entete.[Code Materiel])='"+textBox1.Text+"') AND ((T_devis_entete.Niveau)=7))";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
					}
					foreach(DataRow row3 in ds.Tables["t_devis_entete"].Rows)
					{
						Comm.CommandText="select * from t_causes where Code="+row3["Cause"].ToString();
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"t_causes");
						listView1.Items.Add(ds.Tables["t_causes"].Rows[0]["Designation"].ToString());
						listView1.Items[listView1.Items.Count-1].SubItems.Add(row3["SommeDeTotal ligne"].ToString());
						ds.Tables["t_causes"].Clear();
					}
				}
				ds.Tables["t_devis_entete"].Clear();
				Comm.CommandText="SELECT ID,Affectation FROM t_affectation";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_affectation");
				foreach(DataRow row in ds.Tables["t_affectation"].Rows)
				{
					if(row["ID"].ToString().Equals(mtgcComboBox3.Text))
						textBox14.Text=row["Affectation"].ToString();
				}
				ds.Tables["t_affectation"].Clear();
				Comm.CommandText="SELECT ID,Site FROM t_site";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_site");
				foreach(DataRow row in ds.Tables["t_site"].Rows)
				{
					if(row["ID"].ToString().Equals(mtgcComboBox4.Text))
						textBox15.Text=row["Site"].ToString();
				}
				ds.Tables["t_site"].Clear();

                /*Comm.CommandText = "SELECT T_parc_machine_historique.Dateinter, T_parc_machine_historique.typeinterv, T_parc_machine_historique.N_Controle, T_parc_machine_historique.infos_3, T_parc_machine_historique.infos_4, T_parc_machine_historique.ind_k, T_parc_machine_historique.test_k, T_affectation.Affectation, T_site.Site FROM T_site INNER JOIN (T_affectation INNER JOIN (T_parc_machine INNER JOIN T_parc_machine_historique ON T_parc_machine.[Code machine Opindus] = T_parc_machine_historique.[Code machine Opindus]) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site where T_parc_machine_historique.[code machine opindus]='" + textBox1.Text + "'";
                DataAD.SelectCommand = Comm;
                DataAD.Fill(ds, "t_machines_histo");
                if (ds.Tables["t_machines_histo"].Rows.Count > 0)
                {
                    foreach (DataRow Histo in ds.Tables["t_machines_histo"].Rows)
                    {
                        if (Histo["typeinterv"].ToString().Equals("1"))
                        {
                            button3.Visible = true;
                        }
                    }

                }*/
			}
		}

		private void mtgcComboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Comm.CommandText="SELECT ID,Affectation FROM t_affectation";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_affectation");
			foreach(DataRow row in ds.Tables["t_affectation"].Rows)
			{
				if(row["ID"].ToString().Equals(mtgcComboBox3.Text))
					textBox14.Text=row["Affectation"].ToString();
			}
			ds.Tables["t_affectation"].Clear();
		}

		private void mtgcComboBox4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Comm.CommandText="SELECT ID,Site FROM t_site";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_site");
			foreach(DataRow row in ds.Tables["t_site"].Rows)
			{
				if(row["ID"].ToString().Equals(mtgcComboBox4.Text))
					textBox15.Text=row["Site"].ToString();
			}
			ds.Tables["t_site"].Clear();
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			Empty();
			NoVisible();
			this.Hide();
			tabControlEX1.SelectedTab=tabPageEX1;
			
			
		}

		private void button6_Click_1(object sender, System.EventArgs e)
		{
			if(mtgcComboBox5.SelectedIndex.Equals(0))
			{
				Clients WinClients = new Clients(Agence,true);
				WinClients.ShowDialog();
				this.Refresh();

				Comm.CommandText="SELECT t_clients.Ident,T_clients.Nom, T_clients.Adresse_1, T_clients.Ville, T_clients.Ident FROM T_clients ORDER BY T_clients.Nom";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_clients");
				mtgcComboBox5.Items.Clear();
				foreach(DataRow row in ds.Tables["t_clients"].Rows)
				{
					MTGCComboBoxItem Item = new MTGCComboBoxItem(row["nom"].ToString(),row["adresse_1"].ToString(),row["Code_postal"].ToString(),row["ville"].ToString());
					Item.Tag=row["Ident"].ToString();
					mtgcComboBox5.Items.Add(Item);
				}
				mtgcComboBox5.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
				mtgcComboBox5.SelectedIndex=0;
				ds.Tables["t_clients"].Clear();
				label3.Text="";
				label32.Text="";
				label33.Text="";
			}
			else
			{
				Clients WinClients = new Clients(Agence,label3.Text);
				WinClients.ShowDialog();
				this.Refresh();

				Comm.CommandText="SELECT t_clients.Ident,T_clients.Nom, T_clients.Adresse_1, T_clients.Ville, T_clients.Ident FROM T_clients ORDER BY T_clients.Nom";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_clients");
				mtgcComboBox5.Items.Clear();
				foreach(DataRow row in ds.Tables["t_clients"].Rows)
				{
					MTGCComboBoxItem Item = new MTGCComboBoxItem(row["nom"].ToString(),row["adresse_1"].ToString(),row["Code_postal"].ToString(),row["ville"].ToString());
					Item.Tag=row["t_clients.Ident"].ToString();
					mtgcComboBox5.Items.Add(Item);
				}
				mtgcComboBox5.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
				mtgcComboBox5.SelectedIndex=0;
				ds.Tables["t_clients"].Clear();
				label3.Text="";
				label32.Text="";
				label33.Text="";
			}
		}

		private void Empty()
		{
			mtgcComboBox1.SelectedIndex=-1;
			mtgcComboBox1.Text="";
			mtgcComboBox2.SelectedIndex=0;
			mtgcComboBox3.SelectedIndex=0;
			mtgcComboBox4.SelectedIndex=0;
			mtgcComboBox5.SelectedIndex=0;
			listBox1.Items.Clear();
			label3.Text="";
			label32.Text="";
			label4.Text="";
			label33.Text="";
			textBox1.Clear();
			textBox2.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			textBox12.Clear();
			textBox13.Clear();
			textBox14.Clear();
			textBox15.Clear();
			textBox17.Clear();
			textBox19.Clear();
			textBox20.Clear();
			textBox21.Clear();
			textBox23.Clear();
			textBox24.Clear();
			textBox25.Clear();
			textBox26.Clear();
			textBox27.Clear();
			textBox28.Clear();
			textBox29.Clear();
			textBox30.Clear();
			textBox31.Clear();
			textBox32.Clear();
			textBox32.BackColor=Color.Empty;
			textBox5.BackColor=Color.Empty;
			textBox1.BackColor=Color.Empty;
			lvDevis.Items.Clear();
			listView3.Items.Clear();
			groupBox2.BackColor=System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			label31.Visible=false;
			label12.Visible=true;
			mtgcComboBox1.Visible=true;
		}

		private void NoVisible()
		{
			mtgcComboBox2.Enabled=false;
			mtgcComboBox3.Enabled=false;
			mtgcComboBox4.Enabled=false;
			mtgcComboBox5.Enabled=false;
			listBox1.Enabled=false;
			textBox1.ReadOnly=true;
			textBox2.Enabled=false;
			textBox4.Enabled=false;
			textBox5.Enabled=false;
			textBox6.Enabled=false;
			textBox7.Enabled=false;
			textBox8.Enabled=false;
			textBox12.Enabled=false;
			textBox13.Enabled=false;
			textBox14.Enabled=false;
			textBox15.Enabled=false;
			textBox17.Enabled=false;
			textBox19.Enabled=false;
			textBox20.Enabled=false;
			textBox21.Enabled=false;
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
			lvDevis.Enabled=false;
			listView3.Enabled=false;
			button1.Enabled=false;
			button2.Enabled=false;
			button5.Enabled=false;
			button6.Enabled=false;
			button7.Enabled=false;
			button8.Enabled=false;
			button10.Enabled=false;
			button11.Enabled=false;
		}

		private void VisibleOK()
		{
			mtgcComboBox1.Visible=true;
			mtgcComboBox1.Enabled=true;
			mtgcComboBox2.Enabled=true;
			mtgcComboBox3.Enabled=true;
			mtgcComboBox4.Enabled=true;
			mtgcComboBox5.Enabled=true;
			listBox1.Enabled=true;
			textBox1.ReadOnly=false;
			textBox2.Enabled=true;
			textBox4.Enabled=true;
			textBox5.Enabled=true;
			textBox6.Enabled=true;
			textBox7.Enabled=true;
			textBox8.Enabled=true;
			textBox12.Enabled=true;
			textBox13.Enabled=true;
			textBox14.Enabled=true;
			textBox15.Enabled=true;
			textBox17.ReadOnly=false;
			textBox19.ReadOnly=false;
			textBox20.Enabled=true;
			textBox21.Enabled=true;
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
			lvDevis.Enabled=true;
			listView3.Enabled=true;
			btEnregistre.Enabled=true;
			button1.Enabled=true;
			button2.Enabled=true;
			button5.Enabled=true;
			button6.Enabled=true;
			button7.Enabled=true;
			button8.Enabled=true;
			button10.Enabled=true;
			button11.Enabled=true;
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			/*CurPage=System.Convert.ToInt32(numericUpDown1.Value)-1;
			checkBox2.Checked=false;
			checkBox3.Checked=false;
			checkBox4.Checked=false;
			textBox4.Text=dataSet11.Tables["t_machines_histo"].Rows[CurPage]["description"].ToString();
			if(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["date"].ToString().Length>0)
				textBox28.Text=dataSet11.Tables["t_machines_histo"].Rows[CurPage]["date"].ToString().Remove(10,9);
			listBox1.Items.Clear();
			listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_1"].ToString());
			listBox1.Items.Add("");
			listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_1_1"].ToString());
			listBox1.Items.Add("");
			listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_2"].ToString());
			listBox1.Items.Add("");
			listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_3"].ToString());
			listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_4"].ToString());
			listBox1.Items.Add(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["infos_5"].ToString());
			if(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["typeinterv"].ToString().Equals("1"))
				checkBox2.Checked=true;
			else if(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["typeinterv"].ToString().Equals("2"))
				checkBox3.Checked=true;
			else if(dataSet11.Tables["t_machines_histo"].Rows[CurPage]["typeinterv"].ToString().Equals("3"))
				checkBox4.Checked=true;*/
		}

		private void ParcMachine_VisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible.Equals(true))
			{
				Comm.CommandText="SELECT Count(T_parc_machine.[Code machine Opindus]) AS [CompteDeCode machine Opindus] FROM T_parc_machine";
				oleDbConnection1.Open();
				int Nb=(int)Comm.ExecuteScalar();
				oleDbConnection1.Close();
				if(Nb>mtgcComboBox1.Items.Count)
					InitializeData();
			}
		}

		private void mtgcComboBox5_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox5.SelectedIndex>0)
			{                
				MTGCComboBoxItem Item = (MTGCComboBoxItem)mtgcComboBox5.SelectedItem;
				label32.Text=Item.Text;
				label3.Text=Item.Tag.ToString();
				label33.Text=Item.Col3;
			}
		}

		private void mtgcComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MTGCComboBoxItem Item = (MTGCComboBoxItem)mtgcComboBox2.SelectedItem;
			label4.Text=Item.Col1+" / "+Item.Col2+" / "+Item.Col3;
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			if(mtgcComboBox1.SelectedIndex>0)
			{
				Nettoyer();
				VisibleOK();
				mtgcComboBox3.SelectedIndex=0;
				mtgcComboBox4.SelectedIndex=0;
				btSupprime.Enabled=true;
				btEnregistre.Enabled=true;
				string typeMachine;
				Nouveau=false;
				Activer();
				Comm.CommandText="select t_affectation.[Affectation],t_site.[Site],t_parc_machine.[En parc],t_parc_machine.[site],t_parc_machine.[Affectation],t_parc_machine.[No dernier devis refus],t_parc_machine.[Date refus],t_parc_machine.[No dernier devis],t_parc_machine.[Code machine opindus],t_parc_machine.[type machine], t_parc_machine.[Code machine client],t_parc_machine.[No serie],t_parc_machine.[prix achat],t_parc_machine.[prix remplacement],t_parc_machine.[Date mise en service],t_parc_machine.[date fin garantie],t_parc_machine.[Date reforme],t_parc_machine.[Code mabec],t_parc_machine.[N° troncon],t_parc_machine.[Date dernier controle],t_parc_machine.[Date dernier intervention],t_parc_machine.[Nombre semaine entre ctl],t_parc_machine.[nombre semaine entre inter],t_famille_machine.[Designation],t_clients.[nom],t_clients.[ident],t_clients.[ville],t_fournisseurs.[nom] from t_affectation,t_parc_machine,t_type_machine,t_famille_machine,t_clients,t_fournisseurs,t_site where t_fournisseurs.[Code]=t_type_machine.[fournisseur] and t_parc_machine.[type machine]=t_type_machine.[code] and t_affectation.[ID]=t_parc_machine.[Affectation] and t_site.[ID]=t_parc_machine.[site] and t_type_machine.[code famille]=t_famille_machine.[code] and t_clients.[Ident]=t_parc_machine.[Code client] and t_parc_machine.[code machine opindus]='"+mtgcComboBox1.Text+"'";
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"t_parc_machine");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				if(ds.Tables["T_parc_machine"].Rows.Count>0)
				{
					
					DataRow row = ds.Tables["T_parc_machine"].Rows[0];
					typeMachine=row["type machine"].ToString();
					textBox1.Text=row["Code machine opindus"].ToString();
					textBox2.Text=row["Code machine client"].ToString();
					textBox6.Text=row["No serie"].ToString();
					try
					{
						textBox7.Text=System.Convert.ToDecimal(row["Prix achat"].ToString()).ToString("0.00");
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					try
					{
						textBox8.Text=System.Convert.ToDecimal(row["Prix remplacement"].ToString()).ToString("0.00");
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					textBox12.Text=row["Code mabec"].ToString();
					textBox13.Text=row["N° troncon"].ToString();
					if(row["En parc"].ToString().Equals("True"))
						checkBox1.Checked=true;
					else
						checkBox1.Checked=false;
					if(row["Date reforme"].ToString().Length>0)
						textBox10.Text=System.Convert.ToDateTime(row["Date reforme"].ToString()).ToShortDateString();
					if(row["Date dernier controle"].ToString().Length>0)
						textBox11.Text=System.Convert.ToDateTime(row["Date dernier controle"].ToString()).ToShortDateString();
					if(row["Date mise en service"].ToString().Length>0)
						textBox3.Text=System.Convert.ToDateTime(row["Date mise en service"].ToString()).ToShortDateString();
					if(row["Date refus"].ToString().Length>0)
						textBox18.Text=System.Convert.ToDateTime(row["Date refus"].ToString()).ToShortDateString();
					if(row["Date dernier intervention"].ToString().Length>0)
						textBox16.Text=System.Convert.ToDateTime(row["Date dernier intervention"].ToString()).ToShortDateString();
					if(row["Date fin garantie"].ToString().Length>0)
						textBox9.Text=System.Convert.ToDateTime(row["Date fin garantie"].ToString()).ToShortDateString();

					textBox17.Text=row["Nombre semaine entre ctl"].ToString();
					
					textBox19.Text=row["Nombre semaine entre inter"].ToString();
					mtgcComboBox5.Focus();
					mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(row["t_clients.nom"].ToString());
					Ident=row["ident"].ToString();
					label3.Text=row["ident"].ToString();
					label32.Text=row["t_clients.nom"].ToString();
					label33.Text=row["ville"].ToString();
					label4.Text=row["Designation"].ToString()+" / "+row["t_fournisseurs.nom"].ToString();
					if(row["No dernier devis"].ToString()!="0")
						textBox20.Text=row["No dernier devis"].ToString();
					if(textBox20.TextLength>0)
						button1.Enabled=true;
					textBox21.Text=row["No dernier devis refus"].ToString();
					typeMachine=row["Type machine"].ToString();
					if(row["En parc"].ToString().Equals("True"))
						checkBox1.Checked=true;
					

					Comm.CommandText="select t_devis_entete.[N° Devis],t_devis_entete.[Date],t_devis_entete.[Date entree reelle],t_devis_entete.[Date decision],t_devis_entete.[Date reparation],t_devis_entete.[Type devis] from t_devis_entete where [Code materiel]='"+textBox1.Text.Replace("'","''")+"' order by 1 desc";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"T_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(row["t_parc_machine.Affectation"].ToString());
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(row["t_parc_machine.Site"].ToString());

					//mtgcComboBox2.Focus();
					mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(typeMachine);

					int cpt2=0;
					foreach(DataRow row2 in ds.Tables["T_devis_entete"].Rows)
					{
						ListViewItem item = new ListViewItem(row2["N° Devis"].ToString());
						
						if(row2["Date"].ToString().Length>0)
							item.SubItems.Add(row2["Date"].ToString().Remove(10,9));
						else
							item.SubItems.Add("");
						if(row2["Date entree reelle"].ToString().Length>0)
							item.SubItems.Add(row2["Date entree reelle"].ToString().Remove(10,9));
						else
							item.SubItems.Add("");
						if(row2["Date decision"].ToString().Length>0)
							item.SubItems.Add(row2["Date decision"].ToString().Remove(10,9));
						else
							item.SubItems.Add("");
						if(row2["Date reparation"].ToString().Length>0)
							item.SubItems.Add(row2["Date reparation"].ToString().Remove(10,9));
						else
							item.SubItems.Add("");
						if(row2["Type devis"].ToString().Length>0)
							item.SubItems.Add(row2["Type devis"].ToString());
						else
							item.SubItems.Add("");
						if(cpt2>0)
						{
							if(lvDevis.Items[cpt2-1].BackColor==Color.MintCream)
								lvDevis.Items[cpt2-1].BackColor=Color.White;
							else if(lvDevis.Items[cpt2].BackColor==Color.White)
								lvDevis.Items[cpt2].BackColor=Color.MintCream;
						}
						cpt2++;
						lvDevis.Items.Add(item);
					}

					if(ds.Tables["t_devis_entete"].Rows.Count>0)
					{
						Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Total pieces]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"t_parc_machine");
							if(ds.Tables["t_parc_machine"].Rows.Count>0)
							{
								textBox23.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
								Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Forfait DNR]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"t_parc_machine");
								textBox24.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
								Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Forfait controle]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"t_parc_machine");
								textBox25.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
								Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Forfait transport]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"t_parc_machine");
								textBox26.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
								Comm.CommandText="select t_parc_machine.[Code machine opindus],Sum(t_devis_entete.[Total devis]) from t_parc_machine,t_devis_entete where t_parc_machine.[Code machine opindus]=t_devis_entete.[Code materiel] group by t_parc_machine.[Code machine opindus] having t_parc_machine.[code machine opindus]='"+textBox1.Text+"'";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"t_parc_machine");
								textBox27.Text=System.Convert.ToDecimal(ds.Tables["t_parc_machine"].Rows[0]["expr1001"].ToString()).ToString("c");
								ds.Clear();
							}
						}
						catch(Exception exp)
						{
							
						}
					}
					ds.Tables["t_parc_machine"].Clear();
					ds.Tables["t_devis_entete"].Clear();
					Comm.CommandText="select t_devis_entete.[N° Devis],t_devis_entete.[Niveau],t_avancement.[libelle] from t_devis_entete,t_avancement where t_devis_entete.[Niveau]=t_avancement.[Id] and [Code materiel]='"+textBox1.Text+"'";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					foreach(DataRow row5 in ds.Tables["t_devis_entete"].Rows)
					{
						if(System.Convert.ToInt32(row5["Niveau"].ToString())<7)
						{
							textBox5.BackColor=Color.Lavender;
							textBox32.BackColor=Color.Lavender;
							textBox32.Text=row5["N° Devis"].ToString();
							textBox5.Text=row5["Libelle"].ToString();
						}
					}
					
					listView3.Items.Clear();

					Comm.CommandText="select t_parc_machine.[code machine opindus],t_clients.nom,t_site.site,t_affectation.affectation from t_parc_machine,t_clients,t_site,t_affectation where t_parc_machine.site=t_site.id and t_parc_machine.affectation = t_affectation.id and t_parc_machine.[code client]=t_clients.ident and [Type machine]='"+mtgcComboBox2.Text+"'";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_parc_machine");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					cpt2=0;
					foreach(DataRow rowType in ds.Tables["t_parc_machine"].Rows)
					{
						
						listView3.Items.Add(rowType["Code machine opindus"].ToString());
						listView3.Items[listView3.Items.Count-1].SubItems.Add(rowType["nom"].ToString());
						listView3.Items[listView3.Items.Count-1].SubItems.Add(rowType["site"].ToString());
						listView3.Items[listView3.Items.Count-1].SubItems.Add(rowType["affectation"].ToString());
						if(cpt2>0)
						{
							if(listView3.Items[cpt2-1].BackColor==Color.MintCream)
								listView3.Items[cpt2].BackColor=Color.White;
							else if(listView3.Items[cpt2].BackColor==Color.White)
								listView3.Items[cpt2].BackColor=Color.MintCream;
						}
						cpt2++;
					}
					ds.Tables["t_parc_machine"].Clear();
					ds.Tables["t_devis_entete"].Clear();

					/*Comm.CommandText="select * from t_machines_histo where [code machine opindus]='"+textBox1.Text+"'";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"t_machines_histo");
					textBox4.Text="";
					textBox28.Text="";
					listBox1.Items.Clear();
					checkBox2.Checked=false;
					checkBox3.Checked=false;
					checkBox4.Checked=false;
					if(ds.Tables["t_machines_histo"].Rows.Count>0)
					{
						numericUpDown1.Enabled=true;
						NbrPages=System.Convert.ToInt32(ds.Tables["t_machines_histo"].Rows.Count.ToString());
						numericUpDown1.Maximum=NbrPages;
						numericUpDown1.Minimum=1;
						numericUpDown1.Value=1;
						textBox4.Text=ds.Tables["t_machines_histo"].Rows[CurPage]["description"].ToString();
						textBox28.Text=ds.Tables["t_machines_histo"].Rows[CurPage]["date"].ToString();
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_1"].ToString());
						listBox1.Items.Add("");
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_1_1"].ToString());
						listBox1.Items.Add("");
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_2"].ToString());
						listBox1.Items.Add("");
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_3"].ToString());
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_4"].ToString());
						listBox1.Items.Add(ds.Tables["t_machines_histo"].Rows[CurPage]["infos_5"].ToString());
					}
					else
						numericUpDown1.Enabled=false;
					ds.Tables["t_machines_histo"].Clear();*/
					tabControlEX1.SelectedTab=tabPageEX1;

					Comm.CommandText="SELECT T_devis_entete.[Code Materiel], T_devis_lignes.Cause, Sum(T_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis] GROUP BY T_devis_entete.[Code Materiel], T_devis_lignes.Cause, T_devis_entete.Niveau HAVING (((T_devis_entete.[Code Materiel])='"+textBox1.Text+"') AND ((T_devis_entete.Niveau)=7))";
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"t_devis_entete");
					}
					catch(Exception exp)
					{
					}
					foreach(DataRow row3 in ds.Tables["t_devis_entete"].Rows)
					{
						Comm.CommandText="select * from t_causes where Code="+row3["Cause"].ToString();
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"t_causes");
						listView1.Items.Add(ds.Tables["t_causes"].Rows[0]["Designation"].ToString());
						listView1.Items[listView1.Items.Count-1].SubItems.Add(row3["SommeDeTotal ligne"].ToString());
						ds.Tables["t_causes"].Clear();
					}
				}
				ds.Tables["t_devis_entete"].Clear();
			}
		}

        private void button3_Click(object sender, EventArgs e)
        {
            FicheVieGraphique WinFiche = new FicheVieGraphique(Agence.ToString(),textBox1.Text);

            WinFiche.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Comm.Connection = oleDbConnection1;
            Comm.CommandText="SELECT T_controles_cam.* FROM T_controles_cam WHERE [N° Controle]>=2696";

            DataAD.SelectCommand = Comm;
            DataAD.Fill(ds, "CAM");

            try
            {
                oleDbConnection1.Open();
                Transac = oleDbConnection1.BeginTransaction();
                Comm.Transaction = Transac;

                Microsoft.Office.Interop.Excel.Application oXL;
                Microsoft.Office.Interop.Excel._Workbook oWB;
                oWB = null;
                Microsoft.Office.Interop.Excel._Worksheet oSheet;
                

                foreach (DataRow CAM in ds.Tables["CAM"].Rows)
                {
                    oXL = new Microsoft.Office.Interop.Excel.Application();
                    oXL.Application.Visible = false;

                    DataSet ds2 = new DataSet();
                    

                    Comm.CommandText = "SELECT T_parc_machine.[Code machine Opindus],T_parc_machine.[Date dernier controle], T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site FROM (T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_site INNER JOIN (T_affectation INNER JOIN T_parc_machine ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_parc_machine.[Code machine Opindus])='" + CAM["Code machine opindus"].ToString() + "'))";
                    DataAD.SelectCommand = Comm;
                    DataAD.Fill(ds2, "Machine");

                    Comm.CommandText = "SELECT [Code client] FROM t_parc_machine WHERE [Code machine client]='" + CAM["Code machine opindus"].ToString() + "'";

                    String IDCli = System.Convert.ToString(Comm.ExecuteScalar());

                    Comm.CommandText = "SELECT T_clients.Nom, T_clients.Adresse_1, T_clients.Adresse_2, T_clients.Code_Postal, T_clients.Ville FROM T_clients WHERE T_clients.Ident=" + IDCli;
                    DataAD.SelectCommand = Comm;
                    try
                    {
                        DataAD.Fill(ds, "client");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }

                    if (Directory.Exists(@"C:\Program Files (x86)\Opindus\Excel\" + CAM["Code machine opindus"].ToString() + @"\") == false)
                    {
                        DirectoryInfo repertoire = Directory.CreateDirectory(@"C:\Program Files (x86)\Opindus\Excel\" + CAM["Code machine opindus"].ToString() + @"\");
                    }

                        oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\modeles\controle_30.xls", oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien);

                        oWB = (Microsoft.Office.Interop.Excel._Workbook)oXL.Workbooks[1];
                        oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1];

                        oSheet.Cells[2, 2] = ds.Tables["Client"].Rows[0]["nom"].ToString();
                        oSheet.Cells[3, 2] = ds.Tables["Client"].Rows[0]["adresse_1"].ToString();
                        oSheet.Cells[4, 2] = ds.Tables["Client"].Rows[0]["adresse_2"].ToString();
                        oSheet.Cells[5, 2] = ds.Tables["Client"].Rows[0]["code_postal"].ToString() + " " + ds.Tables["Client"].Rows[0]["ville"].ToString();
                        oSheet.Cells[9, 2] = CAM["N° controle"].ToString();
                        oSheet.Cells[9, 17] = CAM["Date_controle"].ToString();
                        oSheet.Cells[10, 17] = CAM["Date_controle"].ToString();
                        oSheet.Cells[11, 17] = CAM["Operateur"].ToString();
                        oSheet.Cells[12, 17] = System.Convert.ToDateTime(ds2.Tables["Machine"].Rows[0]["Date dernier controle"].ToString()).ToShortDateString();
                        oSheet.Cells[10, 2] = ds2.Tables["Machine"].Rows[0]["Nom"].ToString();
                        oSheet.Cells[11, 2] = ds2.Tables["Machine"].Rows[0]["Type machine"].ToString();
                        if (textBox4.TextLength > 0)
                            oSheet.Cells[12, 2] = oSheet.Cells[12, 2] = ds2.Tables["Machine"].Rows[0]["Code machine opindus"].ToString() + " MABEC : " + ds2.Tables["Machine"].Rows[0]["Code mabec"].ToString().Replace(".", ",");
                        else
                            oSheet.Cells[12, 2] = ds2.Tables["Machine"].Rows[0]["Code machine opindus"].ToString();
                        oSheet.Cells[13, 2] = ds2.Tables["Machine"].Rows[0]["Affectation"].ToString();
                        oSheet.Cells[14, 2] = ds2.Tables["Machine"].Rows[0]["Site"].ToString();

                        Comm.CommandText = "SELECT (T_controles_cam.ets+' / '+T_parc_CAPTEURS.Chaine) as CHAINE FROM T_controles_cam INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE [T_controles_cam.N° Controle]=" + CAM["N° controle"].ToString();

                        oSheet.Cells[24, 1] = "Mesures effectuées avec le matériel de contrôle relié : " + System.Convert.ToString(Comm.ExecuteScalar());
                        oSheet.Cells[9, 10] = CAM["commentaire"].ToString();

                        try
                        {
                            Comm.CommandText = "SELECT T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse FROM T_type_machine WHERE (((T_type_machine.Code)='" + ds2.Tables["Machine"].Rows[0]["Code machine opindus"].ToString() + "')) GROUP BY T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse";
                            DataAD.SelectCommand = Comm;
                            DataAD.Fill(ds2, "t_type_machine");
                            if (ds2.Tables["t_type_machine"].Rows.Count > 0)
                            {
                                oSheet.Cells[16, 2] = ds.Tables["t_type_machine"].Rows[0]["mini machine"].ToString();
                                oSheet.Cells[17, 2] = ds.Tables["t_type_machine"].Rows[0]["maxi machine"].ToString();
                                oSheet.Cells[21, 2] = ds.Tables["t_type_machine"].Rows[0]["vitesse"].ToString();
                            }
                            else
                            {
                                Comm.CommandText = "SELECT T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse FROM T_type_machine_Vis WHERE (((T_type_machine_Vis.Code)='" + ds2.Tables["Machine"].Rows[0]["type machine"].ToString() + "')) GROUP BY T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse";
                                DataAD.SelectCommand = Comm;
                                try
                                {
                                    DataAD.Fill(ds, "t_type_machine_vis");
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                                if (ds.Tables["t_type_machine_vis"].Rows.Count > 0)
                                {
                                    oSheet.Cells[16, 2] = ds.Tables["t_type_machine_vis"].Rows[0]["C_mini"].ToString();
                                    oSheet.Cells[17, 2] = ds.Tables["t_type_machine_vis"].Rows[0]["C_maxi"].ToString();
                                    oSheet.Cells[21, 2] = ds.Tables["t_type_machine_vis"].Rows[0]["Vitesse"].ToString();
                                }
                                else
                                {
                                    oSheet.Cells[16, 2] = "0,00";
                                    oSheet.Cells[17, 2] = "0,00";
                                    oSheet.Cells[21, 2] = "0,00";
                                }
                            }
                        }
                        catch
                        {
                        }

                        if (CAM["mini-poste"].ToString().Length > 0)
                            if (System.Convert.ToDecimal(CAM["mini-poste"].ToString().Replace(".", ",")) > 0)
                                oSheet.Cells[18, 2] = System.Convert.ToDecimal(CAM["mini-poste"]).ToString("0.00");
                        if (CAM["maxi-poste"].ToString().Length > 0)
                            if (System.Convert.ToDecimal(CAM["maxi-poste"].ToString().Replace(".", ",")) > 0)
                                oSheet.Cells[19, 2] = System.Convert.ToDecimal(CAM["maxi-poste"]).ToString("0.00");
                        if (CAM["Vitesse_mesuree"].ToString().Length > 0)
                            if (System.Convert.ToDecimal(CAM["Vitesse_mesuree"].ToString().Replace(".", ",")) > 0)
                                oSheet.Cells[22, 2] = System.Convert.ToDecimal(CAM["Vitesse_mesuree"]).ToString("0.00");

                        ((Range)oSheet.Cells[17, 11]).NumberFormat="###,000";
                        ((Range)oSheet.Cells[17, 11]).Value2 = System.Convert.ToDecimal(CAM["val_001"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[17, 12]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[17, 12]).Value2 = System.Convert.ToDecimal(CAM["val_002"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[17, 13]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[17, 13]).Value2 = System.Convert.ToDecimal(CAM["val_003"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[17, 14]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[17, 14]).Value2 = System.Convert.ToDecimal(CAM["val_004"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[17, 15]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[17, 15]).Value2 = System.Convert.ToDecimal(CAM["val_005"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[18, 11]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[18, 11]).Value2 = System.Convert.ToDecimal(CAM["val_006"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[18, 12]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[18, 12]).Value2 = System.Convert.ToDecimal(CAM["val_007"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[18, 13]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[18, 13]).Value2 = System.Convert.ToDecimal(CAM["val_008"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[18, 14]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[18, 14]).Value2 = System.Convert.ToDecimal(CAM["val_009"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[18, 15]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[18, 15]).Value2 = System.Convert.ToDecimal(CAM["val_010"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[19, 11]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[19, 11]).Value2 = System.Convert.ToDecimal(CAM["val_011"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[19, 12]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[19, 12]).Value2 = System.Convert.ToDecimal(CAM["val_012"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[19, 13]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[19, 13]).Value2 = System.Convert.ToDecimal(CAM["val_013"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[19, 14]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[19, 14]).Value2 = System.Convert.ToDecimal(CAM["val_014"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[19, 15]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[19, 15]).Value2 = System.Convert.ToDecimal(CAM["val_015"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[20, 11]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[20, 11]).Value2 = System.Convert.ToDecimal(CAM["val_016"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[20, 12]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[20, 12]).Value2 = System.Convert.ToDecimal(CAM["val_017"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[20, 13]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[20, 13]).Value2 = System.Convert.ToDecimal(CAM["val_018"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[20, 14]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[20, 14]).Value2 = System.Convert.ToDecimal(CAM["val_019"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[20, 15]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[20, 15]).Value2 = System.Convert.ToDecimal(CAM["val_020"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[21, 11]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[21, 11]).Value2 = System.Convert.ToDecimal(CAM["val_021"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[21, 12]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[21, 12]).Value2 = System.Convert.ToDecimal(CAM["val_022"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[21, 13]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[21, 13]).Value2 = System.Convert.ToDecimal(CAM["val_023"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[21, 14]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[21, 14]).Value2 = System.Convert.ToDecimal(CAM["val_024"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[21, 15]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[21, 15]).Value2 = System.Convert.ToDecimal(CAM["val_025"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[22, 11]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[22, 11]).Value2 = System.Convert.ToDecimal(CAM["val_026"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[22, 12]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[22, 12]).Value2 = System.Convert.ToDecimal(CAM["val_027"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[22, 13]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[22, 13]).Value2 = System.Convert.ToDecimal(CAM["val_028"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[22, 14]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[22, 14]).Value2 = System.Convert.ToDecimal(CAM["val_029"].ToString().Replace(".", ",")).ToString("0.000");
                        ((Range)oSheet.Cells[22, 15]).NumberFormat = "###,000";
                        ((Range)oSheet.Cells[22, 15]).Value2 = System.Convert.ToDecimal(CAM["val_030"].ToString().Replace(".", ",")).ToString("0.000");

                        oXL.CalculateBeforeSave = true;

                        RunMacro(oXL, new Object[] { "Dem1" });
                        RunMacro(oXL, new Object[] { "Dem2" });
                        RunMacro(oXL, new Object[] { "Dem3" });
                        RunMacro(oXL, new Object[] { "Macro1" });
                        RunMacro(oXL, new Object[] { "Macro2" });
                        RunMacro(oXL, new Object[] { "enregistrement" });
                        RunMacro(oXL, new Object[] { "temp" });

                        /*oXL = new Microsoft.Office.Interop.Excel.Application();
                        oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\excel\" + CAM["Code machine opindus"].ToString() + @"\controle_30.xls", oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien);
                        oXL.Application.Visible = false;*/

                        /*Comm.CommandText="SELECT SUM(Val_001+Val_002+Val_003+Val_004+Val_005+Val_006+Val_007+Val_008+Val_009+Val_010+Val_011+Val_012+Val_013+Val_014+Val_015+Val_016+Val_017+Val_018+Val_019+Val_020+Val_021+Val_022+Val_023+Val_024+Val_025+Val_026+Val_028+Val_028+Val_029+Val_030) FROM T_controles_cam WHERE [N° Controle]="+CAM["N° Controle"].ToString();
                        Decimal MoyenneResult=System.Convert.ToDecimal(Comm.ExecuteScalar());*/
                        //, itmax, itmin, test_k, ind_k, pos_L, pos_C, N_controle

                        
                        Double Kolmo2 = System.Convert.ToDouble(((Range)oSheet.Cells[41, 3]).Text.ToString());
                        Decimal itMin = Decimal.Subtract(System.Convert.ToDecimal(((Range)oSheet.Cells[29, 3]).Value2.ToString()), Decimal.Divide(System.Convert.ToDecimal(((Range)oSheet.Cells[37, 11]).Value2.ToString()), new Decimal(2)));
                        Decimal itMax = Decimal.Add(System.Convert.ToDecimal(((Range)oSheet.Cells[29, 3]).Value2.ToString()), Decimal.Divide(System.Convert.ToDecimal(((Range)oSheet.Cells[37, 11]).Value2.ToString()), new Decimal(2)));

                        Comm.CommandText = "SELECT COUNT(ID) FROM t_parc_machine_historique WHERE [N_Controle]=" + CAM["N° controle"].ToString();

                        int Cpt = System.Convert.ToInt32(Comm.ExecuteScalar());

                        if (Cpt.Equals(0))
                            Comm.CommandText = "INSERT INTO T_Parc_machine_historique ([Code machine opindus], Dateinter, Description, infos_1, infos_1_1, infos_3, infos_4, infos_5, [typeinterv], [moyenne], [precision],itmax,itmin,test_k,ind_k,pos_L,pos_C,N_controle) VALUES ('" + CAM["Code machine opindus"].ToString() + "','" + System.Convert.ToDateTime(CAM["Date_controle"].ToString()).ToShortDateString() + "','Contrôle CAM 30 mesures','Contrôle n° " + CAM["N° Controle"].ToString() + " du " + System.Convert.ToDateTime(CAM["Date_controle"].ToString()).ToShortDateString() + " effectué par : " + CAM["Operateur"].ToString() + "','Résultats du contrôle :','Moyenne = " + System.Convert.ToDecimal(((Range)oSheet.Cells[29, 3]).Value2.ToString()).ToString("0.00").Replace(",", ".") + " Nm','Pour un CAM de : " + ((Range)oSheet.Cells[37, 12]).Value2.ToString().Replace(",", ".") + " la précision est de +/- : " + Decimal.Multiply(System.Convert.ToDecimal(((Range)oSheet.Cells[37, 10]).Value2.ToString()), new Decimal(100)).ToString("0.00").Replace(",", ".") + "% ce qui correspond à un intervalle de tolérance de : " + System.Convert.ToDecimal(((Range)oSheet.Cells[37, 11]).Value2.ToString()).ToString("0.00").Replace(",", ".") + " Nm " + ((Range)oSheet.Cells[37, 13]).Value2.ToString().Replace(",", ".") + "','Test de normalité (Kolmogorov): " + Kolmo2.ToString("0.000").Replace(",", ".") + " (<0.248 pour normalité)',1," + System.Convert.ToDecimal(((Range)oSheet.Cells[29, 3]).Value2.ToString()).ToString("0.000").Replace(",", ".") + "," + System.Convert.ToDouble(((Range)oSheet.Cells[37, 10]).Value2.ToString()).ToString().Replace(",", ".") + "," + itMax.ToString().Replace(",", ".") + "," + itMin.ToString().Replace(",", ".") + "," + Kolmo2.ToString().Replace(",", ".") + ",0.248,5,9," + CAM["N° controle"].ToString() + ")";
                        else
                            Comm.CommandText = "UPDATE T_parc_machine_historique SET infos_5='Test de normalité (Kolmogorov): " + Kolmo2.ToString("0.000").Replace(",", ".") + " (<0.248 pour normalité)', test_k=" + Kolmo2.ToString().Replace(",", ".") + " WHERE N_controle=" + CAM["N° controle"].ToString();

                        Comm.ExecuteNonQuery();

                        if (oXL != null)
                        {
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            GC.Collect();
                            GC.WaitForPendingFinalizers();

                            oWB.Close(null, null, null);
                            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(oWB);

                            oXL.Quit();
                            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(oXL);
                        }

                }

                try
                {
                    Transac.Commit();

                    oleDbConnection1.Close();
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

            

        }

        private void RunMacro(object oApp, object[] oRunArgs)
        {
            try
            {
                oApp.GetType().InvokeMember("Run",
                System.Reflection.BindingFlags.Default |
                System.Reflection.BindingFlags.InvokeMethod,
                null, oApp, oRunArgs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        } 
	}
}