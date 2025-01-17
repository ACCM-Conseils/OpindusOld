using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Threading;
using System.Globalization;
using Microsoft.Office.Interop.Excel;

namespace Opindus
{
	/// <summary>
	/// Description résumée de DetailDevis.
	/// </summary>
	public class DetailDevis : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txCodeOpindus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txClient;
		private System.Windows.Forms.TextBox txTypeMachine;
		private System.Windows.Forms.TextBox txNumDevis;
		private System.Windows.Forms.TextBox txDate;
		private System.Windows.Forms.TextBox txEtat;
		private System.Windows.Forms.TextBox txCodeCli;
		private System.Windows.Forms.TextBox txMabec;
		private System.Windows.Forms.TextBox txDescription;
		private System.Windows.Forms.TextBox txSerie;
		private System.Windows.Forms.TextBox txFournisseur;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter6;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter7;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.TextBox txRemCauseAtelier;
		private System.Windows.Forms.TextBox txRemCauseClient;
		private System.Windows.Forms.TextBox txOrdre;
		private System.Windows.Forms.TextBox txCommande;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txBL;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox txTotalDevis;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter8;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand8;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand8;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand8;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand8;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private int Agence;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter9;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox txNetCommande;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.TextBox textBox28;
		private System.Windows.Forms.TextBox textBox29;
		private System.Windows.Forms.TextBox textBox30;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button button6;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private Dotnetrix.Controls.TabPageEX tabPageEX4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label52;
		private MTGCComboBox mtgcComboBox1;
		private MTGCComboBox mtgcComboBox2;
		private MTGCComboBox mtgcComboBox3;
		private MTGCComboBox mtgcComboBox4;
		private MTGCComboBox mtgcComboBox5;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.Label label54;
		private bool debut;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private MTGCComboBox mtgcComboBox6;
		private MTGCComboBox mtgcComboBox7;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter10;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private int Page;
		private int countRow;
		private System.Data.DataTable Table;
		private MTGCComboBox mtgcComboBox8;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand10;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand10;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand10;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand10;
		private System.Windows.Forms.Label label58;
		private MTGCComboBox mtgcComboBox9;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label label60;
		private OleDbCommand Comm;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Label label61;
		private System.Windows.Forms.Label label62;
		private System.Windows.Forms.TextBox txTroncon;
		private System.Windows.Forms.TextBox txComptable;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter12;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand12;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand12;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand12;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand12;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter13;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter11;
		private OleDbTransaction Transac;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand9;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand9;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand9;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand9;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand11;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand11;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand11;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand11;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand13;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand13;
		private System.Data.OleDb.OleDbConnection oleDbConnection2;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.TextBox textBox9;
		private MTGCComboBox mtgcComboBox10;
		private MTGCComboBox mtgcComboBox11;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		Object oRien=System.Reflection.Missing.Value;
		private MTGCComboBox mtgcComboBox12;
		private System.Windows.Forms.Label label63;
		private MTGCComboBox mtgcComboBox13;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox txPrixAchat;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox txDateEdit;
        private IContainer components;

		public DetailDevis(int Agence, string NumDevis)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
            txDateEdit.Text = DateTime.Now.ToShortDateString();
			Page=0;
			countRow=0;
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAD=new OleDbDataAdapter();
			DataAD.SelectCommand=Comm;
			ds = new DataSet();
			this.Agence=Agence;
			if(Agence.Equals(1))
			{
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			}
			else if(Agence.Equals(2))
			{
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lille\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			}
			else if(Agence.Equals(3))
			{
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Rouen\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			}
			try
			{
				oleDbDataAdapter8.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			mtgcComboBox1.SourceDataString=new string[]{"id","nom","",""};
			mtgcComboBox1.SourceDataTable=dataSet11.Tables["T_reparateurs"];
			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));

			mtgcComboBox2.SourceDataString=new string[]{"id","nom","",""};
			mtgcComboBox2.SourceDataTable=dataSet11.Tables["T_reparateurs"];
			mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));

			mtgcComboBox1.SelectedIndex=0;
			mtgcComboBox2.SelectedIndex=0;
			Comm.CommandText="select code, designation from t_emplacement_atelier";
			try
			{
				DataAD.Fill(ds,"t_emplacement_atelier");
				foreach(DataRow row in ds.Tables["t_emplacement_atelier"].Rows)
				{
					mtgcComboBox8.Items.Add(new MTGCComboBoxItem(row["code"].ToString(),row["designation"].ToString(),"",""));
				}
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			ds.Tables["t_emplacement_atelier"].Clear();
			try
			{
				oleDbDataAdapter10.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			mtgcComboBox4.SourceDataString=new string[]{"Code","Designation","",""};
			mtgcComboBox4.SourceDataTable=dataSet11.Tables["t_causes"];

			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select * from t_causes_clients";
			try
			{
				DataAD.Fill(dataSet11,"t_causes_clients");
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			mtgcComboBox6.SourceDataString=new string[]{"code","designation","",""};
			mtgcComboBox6.SourceDataTable=dataSet11.Tables["t_causes_clients"];

			Comm.CommandText="select * from t_causes_atelier";
			try
			{
				DataAD.Fill(dataSet11,"t_causes_atelier");
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			mtgcComboBox7.SourceDataString=new string[]{"code","designation","",""};
			mtgcComboBox7.SourceDataTable=dataSet11.Tables["t_causes_atelier"];
			
			dataSet11.Tables["t_pieces_detachees"].Clear();
			oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Identificateur,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
			try
			{
				oleDbDataAdapter9.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			mtgcComboBox9.SourceDataString=new string[]{"Identificateur","code","designation","nom"};
			mtgcComboBox9.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];
	
			dataSet11.Tables["t_pieces_detachees"].Clear();
			oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Code_1,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE Code_1 IS NOT NULL AND Code_1 NOT LIKE '?' ORDER BY 1"; 
			try
			{
				oleDbDataAdapter9.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}

			mtgcComboBox5.SourceDataString=new string[]{"code_1","code","Designation","Nom"};
			mtgcComboBox5.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];

			mtgcComboBox12.Items.Add(new MTGCComboBoxItem("...","","",""));
			mtgcComboBox12.Items.Add(new MTGCComboBoxItem("Fichier","","",""));
			mtgcComboBox12.Items.Add(new MTGCComboBoxItem("Excel","","",""));
			mtgcComboBox12.Items.Add(new MTGCComboBoxItem("Serveur","","",""));
			mtgcComboBox12.SelectedIndex=0;

			mtgcComboBox13.Items.Add(new MTGCComboBoxItem("...","","",""));
			mtgcComboBox13.Items.Add(new MTGCComboBoxItem("Fichier","","",""));
			mtgcComboBox13.Items.Add(new MTGCComboBoxItem("Serveur","","",""));
			mtgcComboBox13.SelectedIndex=0;

			if(NumDevis.Length>0)
			{
				InitializeData(NumDevis);
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
		public void Remplir(string NumDevis)
		{
			Vider();
			InitializeData(NumDevis);
			this.ShowDialog();
		}

		private void Vider()
		{
			textBox1.Clear();
			textBox1.Enabled=true;
			textBox2.Clear();
			textBox2.Enabled=true;
			textBox3.Clear();
			textBox3.Enabled=true;
			textBox4.Clear();
			textBox4.Enabled=true;
			textBox5.Clear();
			textBox5.Enabled=true;
			textBox6.Clear();
			textBox6.Enabled=true;
			textBox7.Clear();
			textBox7.Enabled=true;
			textBox8.Clear();
			textBox8.Enabled=true;
			textBox10.Clear();
			textBox10.Enabled=true;
			textBox11.Clear();
			textBox11.Enabled=true;
			textBox12.Clear();
			textBox12.Enabled=true;
			textBox13.Clear();
			textBox13.Enabled=true;
			textBox14.Clear();
			textBox14.Enabled=true;
			textBox15.Clear();
			textBox15.Enabled=true;
			textBox16.Clear();
			textBox16.Enabled=true;
			textBox17.Clear();
			textBox17.Enabled=true;
			textBox18.Clear();
			textBox18.Enabled=true;
			textBox19.Clear();
			textBox19.Enabled=true;
			textBox20.Clear();
			textBox20.Enabled=true;
			textBox21.Clear();
			textBox21.Enabled=true;
			textBox22.Clear();
			textBox22.Enabled=true;
			textBox23.Clear();
			textBox23.Enabled=true;
			textBox24.Text="0.00";
			textBox24.Enabled=true;
			textBox25.Clear();
			textBox25.Enabled=true;
			textBox26.Clear();
			textBox26.Enabled=true;
			textBox27.Clear();
			textBox27.Enabled=true;
			textBox28.Text="0";
			textBox28.Enabled=true;
			textBox29.Text="0";
			textBox29.Enabled=true;
			textBox30.Text="0";
			textBox30.Enabled=true;
			textBox31.Clear();
			textBox31.Enabled=true;
			textBox32.Clear();
			textBox32.Enabled=true;
			textBox33.Clear();
			textBox33.Enabled=true;
			textBox34.Clear();
			textBox34.Enabled=true;
			textBox35.Clear();
			textBox35.Enabled=true;
			txBL.Text="0";
			txClient.Clear();
			txCodeCli.Clear();
			txCodeOpindus.Clear();
			txCommande.Clear();
			txCommande.Enabled=true;
			txComptable.Clear();
			txComptable.Enabled=true;
			txDate.Clear();
			txDescription.Clear();
			txEtat.Clear();
			txFournisseur.Clear();
			txMabec.Clear();
			txMabec.Enabled=true;
			txNetCommande.Clear();
			txNumDevis.Clear();
			txOrdre.Clear();
			txOrdre.Enabled=true;
			txRemCauseAtelier.Clear();
			txRemCauseClient.Enabled=true;
			txRemCauseClient.Clear();
			txRemCauseAtelier.Enabled=true;
			txSerie.Clear();
			txTotalDevis.Clear();
			txTroncon.Clear();
			txTroncon.Enabled=true;
			txTypeMachine.Clear();
			mtgcComboBox1.Enabled=true;
			mtgcComboBox2.Enabled=true;
			mtgcComboBox3.Enabled=true;
			mtgcComboBox4.Enabled=true;
			mtgcComboBox5.Enabled=true;
			mtgcComboBox6.Enabled=true;
			mtgcComboBox7.Enabled=true;
			mtgcComboBox8.Enabled=true;
			mtgcComboBox9.Enabled=true;
			numericUpDown1.Enabled=true;
			numericUpDown2.Enabled=true;
			button1.Enabled=true;
			button2.Enabled=true;
			button3.Enabled=true;
			button4.Enabled=true;
			button5.Enabled=true;
			button6.Enabled=true;
			button7.Enabled=true;
			button8.Enabled=true;
			button9.Enabled=true;
			button10.Enabled=false;
			button11.Enabled=true;
			button12.Enabled=true;
			button13.Enabled=true;
			button14.Enabled=true;
			button15.Enabled=true;
			radioButton1.Enabled=true;
			radioButton2.Enabled=true;
			radioButton3.Enabled=true;
			listView1.Items.Clear();
			listView1.Enabled=true;

		}
		private void InitializeData(string NumDevis)
		{
			mtgcComboBox8.Items.Clear();
			Comm.CommandText="select code, designation from t_emplacement_atelier";
			try
			{
				DataAD.Fill(ds,"t_emplacement_atelier");
				foreach(DataRow row in ds.Tables["t_emplacement_atelier"].Rows)
				{
					mtgcComboBox8.Items.Add(new MTGCComboBoxItem(row["code"].ToString(),row["designation"].ToString(),"",""));
				}
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			ds.Tables["t_emplacement_atelier"].Clear();
			mtgcComboBox3.Items.Clear();
			dataSet11.Tables["t_pieces_detachees"].Clear();
			oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Identificateur,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 2"; 
			try
			{
				oleDbDataAdapter9.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			mtgcComboBox3.SourceDataString=new string[]{"code","designation","nom","Identificateur"};
			mtgcComboBox3.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];
			dataSet11.Tables["T_devis_entete"].Clear();
			string RequeteDevis="SELECT T_devis_entete.[N° Devis],T_devis_entete.[Calcul auto],T_devis_entete.[Forfait controle] AS DevisForfaitControle,T_devis_entete.[Forfait transport] AS DevisForfaitTransport, T_devis_entete.Date, T_devis_entete.[Code Materiel], T_devis_entete.[Forfait DNR] AS DNRDEVIS, T_devis_entete.[DNR machine], T_parc_machine.[No serie], T_parc_machine.[Type machine], T_parc_machine.[Code Client], T_parc_machine.[En reparation], T_fournisseurs.Nom, T_parc_machine.[Code Mabec], T_clients.Nom, T_clients.[N°_cde_ouverte], T_devis_entete.[Type devis], T_devis_entete.[Cause client], T_devis_entete.[Detail Client], T_devis_entete.[Cause atelier], T_devis_entete.[Detail atelier], T_devis_entete.[N° Troncon], T_devis_entete.[Ordre Travail], T_devis_entete.[Imputation comptable], T_devis_entete.[N° Commande ouverte], T_devis_entete.Niveau, T_devis_entete.Edite, T_devis_entete.[Accord Client], T_devis_entete.Refus, T_devis_entete.Reforme, T_devis_entete.Reparateur_D, T_devis_entete.Reparateur_R, T_devis_entete.Comment, T_devis_entete.[n° Bl], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_famille_machine.Designation, T_devis_entete.Emplacement, T_clients.Forfait_DNR, T_clients.Coef_DNR, T_clients.Forfait_Controle, T_clients.Coef_Controle, T_clients.Forfait_transport, T_clients.Coef_transport, T_clients.Seuil_reparation, T_parc_machine.[Prix Achat], T_parc_machine.[Prix remplacement], T_type_machine.[Forfait DNR] AS DNRMACHINE, T_type_machine.[Forfait Transport], T_type_machine.[Forfait controle], T_type_machine.[Prix catalogue] FROM (T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[N° Devis])="+NumDevis+"))";
			Comm.Connection=oleDbConnection1;
			Comm.CommandText=RequeteDevis;
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			
			Table = dataSet11.Tables["T_devis_entete"];
			txCommande.Text=Table.Rows[0]["N°_cde_ouverte"].ToString();
			txNumDevis.Text= Table.Rows[0]["N° Devis"].ToString();
			txDate.Text= Table.Rows[0]["Date"].ToString().Remove(10,9);
			mtgcComboBox8.SelectedIndex=mtgcComboBox8.FindString(Table.Rows[0]["Emplacement"].ToString());
			if(Table.Rows[0]["N° troncon"].ToString().Length>0)
				txTroncon.Text=Table.Rows[0]["N° troncon"].ToString();
			else
				txTroncon.Text="?";
			if(Table.Rows[0]["Imputation comptable"].ToString().Length>0)
				txComptable.Text=Table.Rows[0]["Imputation comptable"].ToString();
			else
				txComptable.Text="?";
			txOrdre.Text=Table.Rows[0]["Ordre Travail"].ToString();
			txCommande.Text=Table.Rows[0]["N° Commande ouverte"].ToString();
			txCodeOpindus.Text=Table.Rows[0]["Code materiel"].ToString();
			if(Table.Rows[0]["Total devis"].ToString().Length.Equals(0))
				txTotalDevis.Text="0.00";
			else
				txTotalDevis.Text=System.Convert.ToDecimal(Table.Rows[0]["Total devis"].ToString()).ToString("0.00");
			txMabec.Text=Table.Rows[0]["Code mabec"].ToString();
			if(Table.Rows[0]["n° bl"].ToString().Length.Equals(0))
				txBL.Text="0";
			else
			{
				txBL.Text=Table.Rows[0]["n° bl"].ToString();
			}
			textBox23.Text=Table.Rows[0]["comment"].ToString();
			txRemCauseClient.Text=Table.Rows[0]["Detail client"].ToString();
			txRemCauseAtelier.Text=Table.Rows[0]["Detail atelier"].ToString();
			tabControlEX1.SelectedTab=tabPageEX1;
			mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindString(Table.Rows[0]["Reparateur_D"].ToString());
			mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(Table.Rows[0]["Reparateur_R"].ToString());
			try
			{
				txTotalDevis.Text=System.Convert.ToDecimal(Table.Rows[0]["Total devis"].ToString()).ToString("0.00");
			}
			catch(Exception exp)
			{
				txTotalDevis.Text="0.00";
				Console.WriteLine(exp.Message);
			}
			txCodeCli.Text=Table.Rows[0]["Code Client"].ToString();
			txTypeMachine.Text=Table.Rows[0]["Type machine"].ToString();
			txDescription.Text=Table.Rows[0]["Designation"].ToString();
			txSerie.Text=Table.Rows[0]["No Serie"].ToString();
			txFournisseur.Text=Table.Rows[0]["t_fournisseurs.Nom"].ToString();
			txClient.Text= Table.Rows[0]["t_clients.Nom"].ToString();
			mtgcComboBox6.SelectedIndex=mtgcComboBox6.FindString(Table.Rows[0]["Cause Client"].ToString());
			mtgcComboBox7.SelectedIndex=mtgcComboBox7.FindString(Table.Rows[0]["Cause Atelier"].ToString());
			if(Table.Rows[0]["Type devis"].ToString()=="1")
				radioButton1.Checked=true;
			else if(Table.Rows[0]["Type devis"].ToString()=="2")
				radioButton2.Checked=true;
			else
				radioButton3.Checked=true;

			//Données clients et machines
			try
			{
                int niveau = System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString());

                if(niveau < 3)
                    textBox10.Text = System.Convert.ToDecimal(Table.Rows[0]["Forfait_DNR"].ToString()).ToString("0.00");
                else
                    textBox10.Text = System.Convert.ToDecimal(Table.Rows[0]["DNRDEVIS"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox10.Text="0,00";
			}
			try
			{
				textBox11.Text=System.Convert.ToDecimal(Table.Rows[0]["Coef_DNR"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox11.Text="0,00";
			}
			try
			{
                int niveau = System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString());

                if (niveau < 3)
                {
                    textBox12.Text = System.Convert.ToDecimal(Table.Rows[0]["DNRMACHINE"].ToString()).ToString("0.00");
                }
                else
                {
                    if(System.Convert.ToDecimal(Table.Rows[0]["DNR machine"].ToString()) > 0)
                        textBox12.Text = System.Convert.ToDecimal(Table.Rows[0]["DNR machine"].ToString()).ToString("0.00");
                    else
                        textBox12.Text = System.Convert.ToDecimal(Table.Rows[0]["DNRMACHINE"].ToString()).ToString("0.00");
                }

			}
			catch(Exception exp)
			{
				textBox12.Text="0,00";
			}
			try
			{
				textBox13.Text=System.Convert.ToDecimal(Table.Rows[0]["Forfait controle"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox13.Text="0,00";
			}
			try
			{
				textBox14.Text=System.Convert.ToDecimal(Table.Rows[0]["Coef_controle"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox14.Text="1,00";
			}
			try
			{
				textBox15.Text=System.Convert.ToDecimal(Table.Rows[0]["Forfait_controle"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox15.Text="0,00";
			}
			try
			{
				textBox16.Text=System.Convert.ToDecimal(Table.Rows[0]["Forfait transport"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox16.Text="0,00";
			}
			try
			{
				textBox17.Text=System.Convert.ToDecimal(Table.Rows[0]["Coef_transport"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox17.Text="1,00";
			}
			try
			{
				textBox18.Text=System.Convert.ToDecimal(Table.Rows[0]["Forfait_transport"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox18.Text="0,00";
			}
			try
			{
				textBox25.Text=System.Convert.ToDecimal(Table.Rows[0]["Prix catalogue"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox25.Text="0,00";
			}
			try
			{
				textBox26.Text=System.Convert.ToDecimal(Table.Rows[0]["Prix achat"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox26.Text="0,00";
			}
			try
			{
				textBox27.Text=System.Convert.ToDecimal(Table.Rows[0]["Prix remplacement"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox27.Text="0,00";
			}
			if(textBox26.Text.Length>0&&(System.Convert.ToDecimal(textBox26.Text)>0))
				textBox28.Text=textBox26.Text;
			else
				textBox28.Text=textBox25.Text;		
			try
			{
				textBox29.Text=System.Convert.ToDecimal(Table.Rows[0]["Seuil_reparation"].ToString()).ToString("0.00");
			}
			catch
			{
				textBox29.Text="0,00";
			}
			dataSet11.Tables["t_devis_lignes"].Clear();
			Comm.CommandText="Select * from t_devis_lignes where [N° Devis]="+System.Convert.ToInt32(txNumDevis.Text);
			oleDbDataAdapter11.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter11.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			foreach(DataRow Lignes in dataSet11.Tables["t_devis_lignes"].Rows)
			{
				dataSet11.Tables["t_pieces_detachees"].Clear();
				Comm.CommandText="select * from t_pieces_detachees where [Identificateur]="+Lignes["Code piece"].ToString();
				oleDbDataAdapter9.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				listView1.Items.Add(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Lignes["Designation"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Lignes["Quantite"].ToString());
				try
				{
					if(radioButton2.Checked!=true)
						listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDouble(Lignes["Prix de vente"].ToString()).ToString("c"));
					else
						listView1.Items[listView1.Items.Count-1].SubItems.Add("0,00€");
				}
				catch(Exception exp)
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add("0,00 €");
					Console.WriteLine(exp.Message);
				}
				try
				{
					if(radioButton2.Checked!=true)
						listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDouble(Lignes["Total ligne"].ToString()).ToString("c"));
					else
						listView1.Items[listView1.Items.Count-1].SubItems.Add("0,00€");
				}
				catch(Exception exp)
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add("0,00 €");
					Console.WriteLine(exp.Message);
				}
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Lignes["Cause"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Lignes["Code piece"].ToString());
			}
			Decimal Total=0;
			for(int i=0;i<listView1.Items.Count;i++)
			{
				Total+=System.Convert.ToDecimal(listView1.Items[i].SubItems[4].Text.Trim(' ','€'));
			}
			textBox34.Text=Total.ToString("0.00");
			textBox19.Text=Total.ToString("0.00");
			textBox7.Text=Total.ToString("0.00");
			
			
			//Fin clients et machines

			try
			{
				if(radioButton2.Checked!=true)
				{
					if(System.Convert.ToDecimal(textBox10.Text)>0)
						textBox31.Text=textBox10.Text;
					else
					{
						Decimal CoefCli=System.Convert.ToDecimal(textBox12.Text)*System.Convert.ToDecimal(textBox11.Text);
						textBox31.Text=CoefCli.ToString("0.00");
					}
				}
				else
					textBox31.Text="0,00";
			}
			catch(Exception exp)
			{
				textBox31.Text="0,00";
			}
			
			try
			{
				if(radioButton2.Checked!=true)
				{
					if(System.Convert.ToDecimal(textBox15.Text)>0)
						textBox32.Text=textBox15.Text;
					else
					{
						Decimal CoefCli=System.Convert.ToDecimal(textBox13.Text)*System.Convert.ToDecimal(textBox14.Text);
						textBox32.Text=CoefCli.ToString("0.00");
					}
				}
				else
					textBox32.Text="0,00";
			}
			catch(Exception exp)
			{
				textBox32.Text="0,00";
			}
			try
			{
				if(radioButton2.Checked!=true)
				{
					if(System.Convert.ToDecimal(textBox18.Text)>0)
						textBox33.Text=textBox18.Text;
					else
					{
						Decimal CoefCli=System.Convert.ToDecimal(textBox16.Text)*System.Convert.ToDecimal(textBox17.Text);
						textBox33.Text=CoefCli.ToString("0.00");
					}
				}
				else
					textBox33.Text="0,00";
			}
			catch(Exception exp)
			{
				textBox33.Text="0,00";
			}

			if(Table.Rows[0]["Calcul auto"].ToString().Equals("False"))
			{
				checkBox1.Checked=false;
			}
			else
			{
				checkBox1.Checked=true;
			}

			if(checkBox1.Checked)
			{
				textBox19.Text=textBox7.Text;
				textBox20.Text=textBox31.Text;
				textBox21.Text=textBox32.Text;
				textBox22.Text=textBox33.Text;
				textBox19.ReadOnly=true;
				textBox20.ReadOnly=true;
				textBox21.ReadOnly=true;
				textBox22.ReadOnly=true;
				Decimal TotalAuto=0;
				TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
				textBox24.Text=TotalAuto.ToString("0.00");
			}
			else
			{
				try
				{
					if(System.Convert.ToDecimal(Table.Rows[0]["DNRDEVIS"].ToString())>0)
                        textBox20.Text = System.Convert.ToDecimal(Table.Rows[0]["DNRDEVIS"].ToString()).ToString("0.00");
					else
						textBox20.Text="0,00";
				}
				catch
				{
					textBox20.Text="0,00";
				}
				try
				{
					if(System.Convert.ToDecimal(Table.Rows[0]["DevisForfaitControle"].ToString())>0)
						textBox21.Text=System.Convert.ToDecimal(Table.Rows[0]["DevisForfaitControle"].ToString()).ToString("0.00");
					else
						textBox21.Text="0,00";
				}
				catch
				{
					textBox21.Text="0,00";
				}
				try
				{
					if(System.Convert.ToDecimal(Table.Rows[0]["DevisForfaitTransport"].ToString())>0)
						textBox22.Text=System.Convert.ToDecimal(Table.Rows[0]["DevisForfaitTransport"].ToString()).ToString("0.00");
					else
						textBox22.Text="0,00";
				}
				catch
				{
					textBox22.Text="0,00";
				}
				textBox19.Text=textBox7.Text;

				textBox19.ReadOnly=false;
				textBox20.ReadOnly=false;
				textBox21.ReadOnly=false;
				textBox22.ReadOnly=false;
				Decimal TotalAuto=0;
				TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
				textBox24.Text=TotalAuto.ToString("0.00");
				
			}
		
			if(System.Convert.ToDecimal(textBox24.Text)>0&&System.Convert.ToDecimal(textBox28.Text)>0)
			{
				if(System.Convert.ToDecimal(textBox24.Text)!=0&&System.Convert.ToDecimal(textBox28.Text)!=0)
				{
					Decimal Limite=(System.Convert.ToDecimal(textBox24.Text)/System.Convert.ToDecimal(textBox28.Text))*100;
					textBox30.Text=Limite.ToString("0.00");
				}
			}
			else
				textBox30.Text="0,00";
			Comm.CommandText="select * from t_avancement order by id";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(dataSet11,"t_avancement");
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			txEtat.Text=dataSet11.Tables["t_avancement"].Rows[1]["Libelle"].ToString();
			
			if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(2))
			{
				txEtat.Text=dataSet11.Tables["t_avancement"].Rows[1]["Libelle"].ToString();
			}
			else if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(3))
			{
				txEtat.Text=dataSet11.Tables["t_avancement"].Rows[2]["Libelle"].ToString();
			}
			else if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(4))
			{
				txEtat.Text=dataSet11.Tables["t_avancement"].Rows[3]["Libelle"].ToString();
			}
			else if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(5))
			{
				txEtat.Text=dataSet11.Tables["t_avancement"].Rows[4]["Libelle"].ToString();
			}
			else if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(6))
			{
				txEtat.Text=dataSet11.Tables["t_avancement"].Rows[5]["Libelle"].ToString();
			}
			else if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(7))
			{
				txEtat.Text=dataSet11.Tables["t_avancement"].Rows[6]["Libelle"].ToString();
			}
			else if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(8))
			{
				txEtat.Text=dataSet11.Tables["t_avancement"].Rows[7]["Libelle"].ToString();
			}
			else if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(9))
			{
				txEtat.Text=dataSet11.Tables["t_avancement"].Rows[8]["Libelle"].ToString();
			}
			if(txBL.Text.Equals(0))
				button12.Enabled=false;
			else
				button12.Enabled=true;
			
			txBL.Text=Table.Rows[0]["n° bl"].ToString();
			button12.Enabled=true;
			

				if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString())>2)
				{
					button7.Enabled=true;
					button8.Enabled=true;
					button9.Enabled=true;
					mtgcComboBox12.Enabled=true;
					button18.Enabled=true;
				}
				if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString())>3)
				{
					txEtat.Text="Matériel en attente de commande";
					mtgcComboBox1.Enabled=false;
					mtgcComboBox6.Enabled=false;
					mtgcComboBox7.Enabled=false;
					txRemCauseAtelier.Enabled=false;
					txRemCauseClient.Enabled=false;
					button1.Enabled=false;
					button2.Enabled=false;
					txBL.Enabled=false;
					textBox2.Enabled=false;
					textBox3.Enabled=false;
					textBox4.Enabled=false;
					textBox5.Enabled=false;
					textBox8.Enabled=false;
					txNetCommande.Enabled=false;
					numericUpDown1.Enabled=false;
					numericUpDown2.Enabled=false;
					mtgcComboBox3.Enabled=false;
					mtgcComboBox4.Enabled=false;
					mtgcComboBox5.Enabled=false;
					mtgcComboBox9.Enabled=false;
					numericUpDown1.Enabled=false;
					numericUpDown2.Enabled=false;
					listView1.Enabled=false;
					button12.Enabled=false;
					button7.Enabled=false;
					button8.Enabled=false;
					button9.Enabled=false;
					button13.Enabled=false;
					button6.Enabled=false;
					button3.Enabled=false;
					textBox2.Enabled=false;
					textBox3.Enabled=false;
					textBox4.Enabled=false;
					textBox5.Enabled=false;
					textBox8.Enabled=false;
					txNetCommande.Enabled=false;
					textBox19.Enabled=false;
					textBox20.Enabled=false;
					textBox21.Enabled=false;
					textBox22.Enabled=false;
					textBox23.Enabled=false;
					button10.Enabled=true;
					mtgcComboBox2.Enabled=true;
					txTroncon.Enabled=false;
					txComptable.Enabled=false;
				}
			
				if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(6))
				{
					button10.Enabled=false;
					radioButton1.Enabled=false;
					radioButton2.Enabled=false;
					radioButton3.Enabled=false;
				}
				if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(7))
				{
					button10.Enabled=false;
					mtgcComboBox2.Enabled=false;
					radioButton1.Enabled=false;
					radioButton2.Enabled=false;
					radioButton3.Enabled=false;
					button11.Enabled=false;
				}
				if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(8)||System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString()).Equals(9))
				{
					txCommande.Enabled=false;
					txOrdre.Enabled=false;
					mtgcComboBox8.Enabled=false;
					button10.Enabled=false;
					button11.Enabled=false;
					mtgcComboBox2.Enabled=false;
					radioButton1.Enabled=false;
					radioButton2.Enabled=false;
					radioButton3.Enabled=false;
					textBox7.Text="0,00";
					textBox31.Text="0,00";
					textBox32.Text="0,00";
					textBox33.Text="0,00";
					textBox19.Text="0,00";
					textBox20.Text="0,00";
					textBox21.Text="0,00";
					textBox22.Text="0,00";

				}
				if(System.Convert.ToInt32(Table.Rows[0]["Niveau"].ToString())>5)
				{
					button10.Enabled=false;
				}
				if(button10.Enabled==true)
					button11.Enabled=false;

				/*if(System.Convert.ToDecimal(textBox10.Text)>0)
				{
					Decimal Coef=System.Convert.ToDecimal(textBox11.Text);
					Decimal DNR=System.Convert.ToDecimal(textBox10.Text);
					Decimal Tot=DNR*Coef;
					//textBox31.Text=Tot.ToString("0.00");
					if(textBox20.TextLength.Equals(0))
					{
						textBox20.Text=textBox31.Text;
						if(textBox12.Text.Length>0)
							textBox20.Text=textBox12.Text;
						if(textBox11.Text.Length>0&&System.Convert.ToDecimal(textBox11.Text)>0)
						{
							Decimal D=System.Convert.ToDecimal(textBox12.Text);
							Decimal P=System.Convert.ToDecimal(textBox11.Text);
							Decimal Res=D*P;
							textBox20.Text=Res.ToString("0.00");;
						}
					}
				}
				else
				{
					Decimal Coef=System.Convert.ToDecimal(textBox11.Text);
					Decimal DNR=System.Convert.ToDecimal(textBox12.Text);
					Decimal Tot=DNR*Coef;
					//textBox31.Text=Tot.ToString("0.00");
					if(textBox20.TextLength.Equals(0))
					{
						textBox20.Text=textBox31.Text;
						if(textBox12.Text.Length>0)
							textBox20.Text=textBox12.Text;
					
						if(textBox11.Text.Length>0&&System.Convert.ToDecimal(textBox11.Text)>0)
						{
							Decimal D=System.Convert.ToDecimal(textBox12.Text);
							Decimal P=System.Convert.ToDecimal(textBox11.Text);
							Decimal Res=D*P;
							textBox20.Text=Res.ToString("0.00");
						}
					}
				}*/

				/*if(System.Convert.ToDecimal(textBox15.Text)>0)
				{
					Decimal Coef=System.Convert.ToDecimal(textBox14.Text);
					Decimal DNR=System.Convert.ToDecimal(textBox15.Text);
					Decimal Tot=DNR*Coef;
					textBox32.Text=Tot.ToString("0.00");
					if(textBox21.TextLength.Equals(0))
						textBox21.Text=textBox32.Text;
				}
				else
				{
					Decimal Coef=System.Convert.ToDecimal(textBox14.Text);
					Decimal DNR=System.Convert.ToDecimal(textBox13.Text);
					Decimal Tot=DNR*Coef;
					textBox32.Text=Tot.ToString("0.00");
					if(textBox21.TextLength.Equals(0))
						textBox21.Text=textBox32.Text;
				}

				if(System.Convert.ToDecimal(textBox18.Text)>0)
				{
					Decimal Coef=System.Convert.ToDecimal(textBox17.Text);
					Decimal DNR=System.Convert.ToDecimal(textBox18.Text);
					Decimal Tot=DNR*Coef;
					textBox33.Text=Tot.ToString("0.00");
					if(textBox22.TextLength.Equals(0))
						textBox22.Text=textBox33.Text;
				}
				else
				{
					Decimal Coef=System.Convert.ToDecimal(textBox17.Text);
					Decimal DNR=System.Convert.ToDecimal(textBox16.Text);
					Decimal Tot=DNR*Coef;
					textBox33.Text=Tot.ToString("0.00");
					if(textBox22.TextLength.Equals(0))
						textBox22.Text=textBox33.Text;
				}*/		


			Comm.CommandText="SELECT * FROM T_unites";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(dataSet11,"pieces");
			mtgcComboBox11.SourceDataString=new string[]{"Code","Designation","",""};
			mtgcComboBox11.SourceDataTable=dataSet11.Tables["pieces"];
			dataSet11.Tables["pieces"].Clear();

			Comm.CommandText="SELECT * FROM T_famille_piece";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(dataSet11,"famille");
			mtgcComboBox10.SourceDataString=new string[]{"Code","Designation","",""};
			mtgcComboBox10.SourceDataTable=dataSet11.Tables["famille"];
			dataSet11.Tables["famille"].Clear();

		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailDevis));
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataSet11 = new Opindus.DataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txFournisseur = new System.Windows.Forms.TextBox();
            this.txSerie = new System.Windows.Forms.TextBox();
            this.txDescription = new System.Windows.Forms.TextBox();
            this.txMabec = new System.Windows.Forms.TextBox();
            this.txCodeCli = new System.Windows.Forms.TextBox();
            this.txTypeMachine = new System.Windows.Forms.TextBox();
            this.txClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txCodeOpindus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label62 = new System.Windows.Forms.Label();
            this.txComptable = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.mtgcComboBox8 = new MTGCComboBox();
            this.mtgcComboBox7 = new MTGCComboBox();
            this.mtgcComboBox6 = new MTGCComboBox();
            this.txRemCauseAtelier = new System.Windows.Forms.TextBox();
            this.txRemCauseClient = new System.Windows.Forms.TextBox();
            this.txTroncon = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txCommande = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txOrdre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mtgcComboBox2 = new MTGCComboBox();
            this.mtgcComboBox1 = new MTGCComboBox();
            this.txTotalDevis = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.txBL = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txNetCommande = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txNumDevis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txDate = new System.Windows.Forms.TextBox();
            this.txEtat = new System.Windows.Forms.TextBox();
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
            this.btSave = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.button6 = new System.Windows.Forms.Button();
            this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
            this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            this.txPrixAchat = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.mtgcComboBox11 = new MTGCComboBox();
            this.mtgcComboBox10 = new MTGCComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mtgcComboBox9 = new MTGCComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.mtgcComboBox5 = new MTGCComboBox();
            this.mtgcComboBox4 = new MTGCComboBox();
            this.mtgcComboBox3 = new MTGCComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.tabPageEX4 = new Dotnetrix.Controls.TabPageEX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.oleDbDataAdapter10 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand10 = new System.Data.OleDb.OleDbCommand();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.oleDbDataAdapter12 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand12 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand12 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand12 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand12 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter13 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand13 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand13 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter11 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand11 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand11 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand11 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand11 = new System.Data.OleDb.OleDbCommand();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.mtgcComboBox12 = new MTGCComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.mtgcComboBox13 = new MTGCComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.txDateEdit = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControlEX1.SuspendLayout();
            this.tabPageEX1.SuspendLayout();
            this.tabPageEX2.SuspendLayout();
            this.tabPageEX3.SuspendLayout();
            this.tabPageEX4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txFournisseur);
            this.groupBox1.Controls.Add(this.txSerie);
            this.groupBox1.Controls.Add(this.txDescription);
            this.groupBox1.Controls.Add(this.txMabec);
            this.groupBox1.Controls.Add(this.txCodeCli);
            this.groupBox1.Controls.Add(this.txTypeMachine);
            this.groupBox1.Controls.Add(this.txClient);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txCodeOpindus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(662, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(262, 20);
            this.label13.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(333, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 21);
            this.label12.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(340, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(4, 0);
            this.label11.TabIndex = 16;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(26, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 21);
            this.label10.TabIndex = 15;
            // 
            // txFournisseur
            // 
            this.txFournisseur.BackColor = System.Drawing.Color.White;
            this.txFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txFournisseur.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txFournisseur.Location = new System.Drawing.Point(526, 107);
            this.txFournisseur.Name = "txFournisseur";
            this.txFournisseur.ReadOnly = true;
            this.txFournisseur.Size = new System.Drawing.Size(390, 26);
            this.txFournisseur.TabIndex = 14;
            this.txFournisseur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSerie
            // 
            this.txSerie.BackColor = System.Drawing.Color.White;
            this.txSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txSerie.Location = new System.Drawing.Point(526, 64);
            this.txSerie.Name = "txSerie";
            this.txSerie.ReadOnly = true;
            this.txSerie.Size = new System.Drawing.Size(389, 26);
            this.txSerie.TabIndex = 13;
            this.txSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txDescription
            // 
            this.txDescription.BackColor = System.Drawing.Color.White;
            this.txDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txDescription.Location = new System.Drawing.Point(686, 23);
            this.txDescription.Name = "txDescription";
            this.txDescription.ReadOnly = true;
            this.txDescription.Size = new System.Drawing.Size(380, 26);
            this.txDescription.TabIndex = 12;
            this.txDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txMabec
            // 
            this.txMabec.BackColor = System.Drawing.Color.White;
            this.txMabec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txMabec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txMabec.Location = new System.Drawing.Point(168, 107);
            this.txMabec.Name = "txMabec";
            this.txMabec.ReadOnly = true;
            this.txMabec.Size = new System.Drawing.Size(180, 26);
            this.txMabec.TabIndex = 11;
            this.txMabec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txCodeCli
            // 
            this.txCodeCli.BackColor = System.Drawing.Color.White;
            this.txCodeCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCodeCli.Location = new System.Drawing.Point(168, 64);
            this.txCodeCli.Name = "txCodeCli";
            this.txCodeCli.ReadOnly = true;
            this.txCodeCli.Size = new System.Drawing.Size(180, 26);
            this.txCodeCli.TabIndex = 10;
            this.txCodeCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txTypeMachine
            // 
            this.txTypeMachine.BackColor = System.Drawing.Color.White;
            this.txTypeMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTypeMachine.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTypeMachine.Location = new System.Drawing.Point(526, 23);
            this.txTypeMachine.Name = "txTypeMachine";
            this.txTypeMachine.ReadOnly = true;
            this.txTypeMachine.Size = new System.Drawing.Size(148, 26);
            this.txTypeMachine.TabIndex = 9;
            this.txTypeMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txClient
            // 
            this.txClient.BackColor = System.Drawing.Color.White;
            this.txClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txClient.Location = new System.Drawing.Point(168, 152);
            this.txClient.Name = "txClient";
            this.txClient.ReadOnly = true;
            this.txClient.Size = new System.Drawing.Size(564, 26);
            this.txClient.TabIndex = 8;
            this.txClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fournisseur";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "N° Serie";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Type machine";
            // 
            // txCodeOpindus
            // 
            this.txCodeOpindus.BackColor = System.Drawing.Color.White;
            this.txCodeOpindus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCodeOpindus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCodeOpindus.Location = new System.Drawing.Point(168, 23);
            this.txCodeOpindus.Name = "txCodeOpindus";
            this.txCodeOpindus.ReadOnly = true;
            this.txCodeOpindus.Size = new System.Drawing.Size(180, 26);
            this.txCodeOpindus.TabIndex = 4;
            this.txCodeOpindus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Client";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Code MABEC";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Code client";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code Opindus";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(9, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1200, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(434, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 23);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Contrôle";
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(302, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Garantie";
            // 
            // radioButton1
            // 
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(156, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 23);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Réparation";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(24, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Type devis";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox3.Controls.Add(this.label62);
            this.groupBox3.Controls.Add(this.txComptable);
            this.groupBox3.Controls.Add(this.label61);
            this.groupBox3.Controls.Add(this.mtgcComboBox8);
            this.groupBox3.Controls.Add(this.mtgcComboBox7);
            this.groupBox3.Controls.Add(this.mtgcComboBox6);
            this.groupBox3.Controls.Add(this.txRemCauseAtelier);
            this.groupBox3.Controls.Add(this.txRemCauseClient);
            this.groupBox3.Controls.Add(this.txTroncon);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txCommande);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txOrdre);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(9, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(841, 328);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label62
            // 
            this.label62.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(660, 257);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(168, 24);
            this.label62.TabIndex = 22;
            this.label62.Text = "Imput. comptable";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txComptable
            // 
            this.txComptable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txComptable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txComptable.Location = new System.Drawing.Point(660, 281);
            this.txComptable.Name = "txComptable";
            this.txComptable.Size = new System.Drawing.Size(168, 26);
            this.txComptable.TabIndex = 21;
            this.txComptable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(480, 257);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(168, 24);
            this.label61.TabIndex = 20;
            this.label61.Text = "N° tronçon";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtgcComboBox8
            // 
            this.mtgcComboBox8.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox8.ColumnNum = 2;
            this.mtgcComboBox8.ColumnWidth = "100;200";
            this.mtgcComboBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtgcComboBox8.DisplayMember = "Text";
            this.mtgcComboBox8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox8.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox8.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox8.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox8.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox8.DropDownWidth = 320;
            this.mtgcComboBox8.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox8.GridLineHorizontal = false;
            this.mtgcComboBox8.GridLineVertical = false;
            this.mtgcComboBox8.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox8.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox8.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox8.Location = new System.Drawing.Point(24, 210);
            this.mtgcComboBox8.ManagingFastMouseMoving = true;
            this.mtgcComboBox8.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox8.Name = "mtgcComboBox8";
            this.mtgcComboBox8.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox8.Size = new System.Drawing.Size(204, 27);
            this.mtgcComboBox8.TabIndex = 19;
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
            this.mtgcComboBox7.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox7.GridLineHorizontal = false;
            this.mtgcComboBox7.GridLineVertical = true;
            this.mtgcComboBox7.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox7.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox7.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox7.Location = new System.Drawing.Point(144, 117);
            this.mtgcComboBox7.ManagingFastMouseMoving = true;
            this.mtgcComboBox7.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox7.Name = "mtgcComboBox7";
            this.mtgcComboBox7.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox7.Size = new System.Drawing.Size(144, 27);
            this.mtgcComboBox7.TabIndex = 18;
            this.mtgcComboBox7.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox7_SelectedIndexChanged);
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
            this.mtgcComboBox6.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox6.GridLineHorizontal = false;
            this.mtgcComboBox6.GridLineVertical = true;
            this.mtgcComboBox6.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox6.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox6.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox6.Location = new System.Drawing.Point(144, 35);
            this.mtgcComboBox6.ManagingFastMouseMoving = true;
            this.mtgcComboBox6.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox6.Name = "mtgcComboBox6";
            this.mtgcComboBox6.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox6.Size = new System.Drawing.Size(144, 27);
            this.mtgcComboBox6.TabIndex = 17;
            this.mtgcComboBox6.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox6_SelectedIndexChanged);
            // 
            // txRemCauseAtelier
            // 
            this.txRemCauseAtelier.BackColor = System.Drawing.Color.White;
            this.txRemCauseAtelier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txRemCauseAtelier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txRemCauseAtelier.Location = new System.Drawing.Point(384, 134);
            this.txRemCauseAtelier.Multiline = true;
            this.txRemCauseAtelier.Name = "txRemCauseAtelier";
            this.txRemCauseAtelier.Size = new System.Drawing.Size(420, 84);
            this.txRemCauseAtelier.TabIndex = 16;
            // 
            // txRemCauseClient
            // 
            this.txRemCauseClient.BackColor = System.Drawing.Color.White;
            this.txRemCauseClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txRemCauseClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txRemCauseClient.Location = new System.Drawing.Point(384, 35);
            this.txRemCauseClient.Multiline = true;
            this.txRemCauseClient.Name = "txRemCauseClient";
            this.txRemCauseClient.Size = new System.Drawing.Size(420, 83);
            this.txRemCauseClient.TabIndex = 15;
            // 
            // txTroncon
            // 
            this.txTroncon.BackColor = System.Drawing.Color.White;
            this.txTroncon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTroncon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTroncon.Location = new System.Drawing.Point(480, 281);
            this.txTroncon.Name = "txTroncon";
            this.txTroncon.Size = new System.Drawing.Size(168, 26);
            this.txTroncon.TabIndex = 14;
            this.txTroncon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(240, 257);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(228, 19);
            this.label21.TabIndex = 13;
            this.label21.Text = "N° Commande ouverte";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txCommande
            // 
            this.txCommande.BackColor = System.Drawing.Color.White;
            this.txCommande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCommande.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCommande.Location = new System.Drawing.Point(240, 281);
            this.txCommande.Name = "txCommande";
            this.txCommande.Size = new System.Drawing.Size(230, 26);
            this.txCommande.TabIndex = 12;
            this.txCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(206, 19);
            this.label20.TabIndex = 11;
            this.label20.Text = "Ordre travail";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(207, 22);
            this.label19.TabIndex = 10;
            this.label19.Text = "Emplacement";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txOrdre
            // 
            this.txOrdre.BackColor = System.Drawing.Color.White;
            this.txOrdre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txOrdre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txOrdre.Location = new System.Drawing.Point(24, 281);
            this.txOrdre.Name = "txOrdre";
            this.txOrdre.Size = new System.Drawing.Size(204, 26);
            this.txOrdre.TabIndex = 9;
            this.txOrdre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(300, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(300, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(144, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(226, 25);
            this.label18.TabIndex = 5;
            this.label18.Text = "label18";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(142, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(228, 26);
            this.label17.TabIndex = 4;
            this.label17.Text = "label17";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 34);
            this.label16.TabIndex = 1;
            this.label16.Text = "Cause client";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 42);
            this.label15.TabIndex = 0;
            this.label15.Text = "Cause Atelier";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox4.Controls.Add(this.mtgcComboBox2);
            this.groupBox4.Controls.Add(this.mtgcComboBox1);
            this.groupBox4.Controls.Add(this.txTotalDevis);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.txBL);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(849, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 328);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // mtgcComboBox2
            // 
            this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox2.ColumnNum = 2;
            this.mtgcComboBox2.ColumnWidth = "50;200";
            this.mtgcComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtgcComboBox2.DisplayMember = "Text";
            this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
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
            this.mtgcComboBox2.Location = new System.Drawing.Point(192, 152);
            this.mtgcComboBox2.ManagingFastMouseMoving = true;
            this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox2.Name = "mtgcComboBox2";
            this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox2.Size = new System.Drawing.Size(132, 27);
            this.mtgcComboBox2.TabIndex = 16;
            // 
            // mtgcComboBox1
            // 
            this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox1.ColumnNum = 2;
            this.mtgcComboBox1.ColumnWidth = "50;200";
            this.mtgcComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtgcComboBox1.DisplayMember = "Text";
            this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox1.DropDownWidth = 270;
            this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox1.GridLineHorizontal = false;
            this.mtgcComboBox1.GridLineVertical = false;
            this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox1.Location = new System.Drawing.Point(192, 70);
            this.mtgcComboBox1.ManagingFastMouseMoving = true;
            this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox1.Name = "mtgcComboBox1";
            this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.Size = new System.Drawing.Size(132, 27);
            this.mtgcComboBox1.TabIndex = 15;
            // 
            // txTotalDevis
            // 
            this.txTotalDevis.BackColor = System.Drawing.Color.White;
            this.txTotalDevis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTotalDevis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTotalDevis.Location = new System.Drawing.Point(192, 281);
            this.txTotalDevis.Name = "txTotalDevis";
            this.txTotalDevis.ReadOnly = true;
            this.txTotalDevis.Size = new System.Drawing.Size(136, 26);
            this.txTotalDevis.TabIndex = 14;
            this.txTotalDevis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(72, 284);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(102, 17);
            this.label25.TabIndex = 13;
            this.label25.Text = "Total devis";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(189, 197);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 21);
            this.label24.TabIndex = 12;
            this.label24.Text = "BL";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Lavender;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Enabled = false;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(288, 222);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 29);
            this.button12.TabIndex = 11;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // txBL
            // 
            this.txBL.BackColor = System.Drawing.Color.White;
            this.txBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txBL.Enabled = false;
            this.txBL.Location = new System.Drawing.Point(192, 222);
            this.txBL.Name = "txBL";
            this.txBL.ReadOnly = true;
            this.txBL.Size = new System.Drawing.Size(88, 26);
            this.txBL.TabIndex = 10;
            this.txBL.Text = "0";
            this.txBL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(189, 126);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 23);
            this.label23.TabIndex = 7;
            this.label23.Text = "Remontage";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(190, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 25);
            this.label22.TabIndex = 6;
            this.label22.Text = "Démontage";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Enabled = false;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Blue;
            this.button11.Location = new System.Drawing.Point(36, 210);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(112, 34);
            this.button11.TabIndex = 5;
            this.button11.Text = "Réparé";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Enabled = false;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Blue;
            this.button10.Location = new System.Drawing.Point(36, 175);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(112, 34);
            this.button10.TabIndex = 4;
            this.button10.Text = "Pièces OK";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Enabled = false;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Red;
            this.button9.Location = new System.Drawing.Point(36, 129);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 33);
            this.button9.TabIndex = 3;
            this.button9.Text = "Reformé";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Enabled = false;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(36, 94);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 33);
            this.button8.TabIndex = 2;
            this.button8.Text = "Refusé";
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
            this.button7.Location = new System.Drawing.Point(36, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 34);
            this.button7.TabIndex = 1;
            this.button7.Text = "Accord";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(288, 152);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 26);
            this.textBox6.TabIndex = 19;
            this.textBox6.TabStop = false;
            this.textBox6.Visible = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Lavender;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(8, 602);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(248, 34);
            this.button13.TabIndex = 18;
            this.button13.TabStop = false;
            this.button13.Text = "Supprimer la ligne";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(1008, 35);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(84, 26);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numericUpDown2.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown2.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(912, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 26);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown1_Enter);
            this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown1_Leave);
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(936, 129);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(156, 23);
            this.label28.TabIndex = 12;
            this.label28.Text = "Cause";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1100, 129);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(109, 23);
            this.label27.TabIndex = 11;
            this.label27.Text = "Total ligne :";
            // 
            // txNetCommande
            // 
            this.txNetCommande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNetCommande.Location = new System.Drawing.Point(1104, 152);
            this.txNetCommande.Name = "txNetCommande";
            this.txNetCommande.Size = new System.Drawing.Size(108, 26);
            this.txNetCommande.TabIndex = 10;
            this.txNetCommande.TabStop = false;
            this.txNetCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(288, 105);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(300, 26);
            this.textBox8.TabIndex = 9;
            this.textBox8.TabStop = false;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(288, 82);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(234, 23);
            this.label26.TabIndex = 8;
            this.label26.Text = "Ancienne référence";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(1104, 94);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(108, 26);
            this.textBox5.TabIndex = 7;
            this.textBox5.TabStop = false;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(612, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(288, 26);
            this.textBox4.TabIndex = 4;
            this.textBox4.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(1104, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(288, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(612, 26);
            this.textBox2.TabIndex = 20;
            this.textBox2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 246);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1204, 350);
            this.listView1.TabIndex = 0;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code pièce";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Designation pièce";
            this.columnHeader4.Width = 300;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qte";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "P.V. Pièce";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "P.V. Devis";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cause";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Code piece";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox7.Controls.Add(this.label57);
            this.groupBox7.Controls.Add(this.label56);
            this.groupBox7.Controls.Add(this.label55);
            this.groupBox7.Location = new System.Drawing.Point(12, 433);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(636, 187);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            // 
            // label57
            // 
            this.label57.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(12, 94);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(180, 23);
            this.label57.TabIndex = 2;
            this.label57.Text = "Date et signature :";
            this.label57.Visible = false;
            // 
            // label56
            // 
            this.label56.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(12, 47);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(504, 33);
            this.label56.TabIndex = 1;
            this.label56.Text = "Votre accord nous est donc indispensable.";
            this.label56.Visible = false;
            // 
            // label55
            // 
            this.label55.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(12, 23);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(612, 24);
            this.label55.TabIndex = 0;
            this.label55.Text = "Le total de la réparation depasse la limite autorisée.";
            this.label55.Visible = false;
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(300, 362);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(120, 24);
            this.label50.TabIndex = 16;
            this.label50.Text = "Limite devis";
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(156, 362);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(120, 24);
            this.label49.TabIndex = 15;
            this.label49.Text = "Limite client";
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(24, 362);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(150, 24);
            this.label48.TabIndex = 14;
            this.label48.Text = "Prix référence";
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Location = new System.Drawing.Point(300, 386);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(120, 26);
            this.textBox30.TabIndex = 13;
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox30.TextChanged += new System.EventHandler(this.textBox30_TextChanged);
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(168, 386);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(84, 26);
            this.textBox29.TabIndex = 12;
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Location = new System.Drawing.Point(24, 386);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(120, 26);
            this.textBox28.TabIndex = 11;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(660, 561);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(168, 34);
            this.label47.TabIndex = 9;
            this.label47.Text = "Prix remplacement";
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(660, 514);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(150, 34);
            this.label46.TabIndex = 8;
            this.label46.Text = "Prix achat";
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(660, 468);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(150, 33);
            this.label45.TabIndex = 7;
            this.label45.Text = "Prix catalogue";
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Location = new System.Drawing.Point(840, 561);
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(150, 26);
            this.textBox27.TabIndex = 6;
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(840, 514);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(150, 26);
            this.textBox26.TabIndex = 5;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(840, 468);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(150, 26);
            this.textBox25.TabIndex = 4;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(888, 386);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(108, 33);
            this.label44.TabIndex = 3;
            this.label44.Text = "Total devis";
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(1008, 374);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(150, 26);
            this.textBox24.TabIndex = 2;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox24.TextChanged += new System.EventHandler(this.textBox24_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox6.Controls.Add(this.textBox19);
            this.groupBox6.Controls.Add(this.textBox33);
            this.groupBox6.Controls.Add(this.textBox32);
            this.groupBox6.Controls.Add(this.textBox31);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.label42);
            this.groupBox6.Controls.Add(this.label41);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.textBox22);
            this.groupBox6.Controls.Add(this.textBox21);
            this.groupBox6.Controls.Add(this.textBox20);
            this.groupBox6.Location = new System.Drawing.Point(648, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(555, 339);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(360, 82);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(150, 26);
            this.textBox19.TabIndex = 13;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            this.textBox19.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox19_KeyDown_1);
            this.textBox19.Leave += new System.EventHandler(this.textBox19_Leave_1);
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox33.Location = new System.Drawing.Point(202, 257);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(150, 26);
            this.textBox33.TabIndex = 12;
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox32.Location = new System.Drawing.Point(202, 199);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(150, 26);
            this.textBox32.TabIndex = 11;
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox31.Location = new System.Drawing.Point(202, 140);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(150, 26);
            this.textBox31.TabIndex = 10;
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(202, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(150, 26);
            this.textBox7.TabIndex = 9;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(46, 257);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(150, 34);
            this.label43.TabIndex = 8;
            this.label43.Text = "Forfait transport";
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(46, 199);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(150, 33);
            this.label42.TabIndex = 7;
            this.label42.Text = "Forfait contrôle";
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(46, 140);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(150, 34);
            this.label41.TabIndex = 6;
            this.label41.Text = "Forfait DNR";
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(46, 82);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(150, 23);
            this.label40.TabIndex = 5;
            this.label40.Text = "Total pièces";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(46, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 35);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Calcul auto";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(358, 257);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(150, 26);
            this.textBox22.TabIndex = 3;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            this.textBox22.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox22_KeyDown);
            this.textBox22.Leave += new System.EventHandler(this.textBox22_Leave);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Location = new System.Drawing.Point(358, 199);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(150, 26);
            this.textBox21.TabIndex = 2;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            this.textBox21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox21_KeyDown);
            this.textBox21.Leave += new System.EventHandler(this.textBox21_Leave);
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(358, 140);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(150, 26);
            this.textBox20.TabIndex = 1;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox20.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            this.textBox20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox20_KeyDown);
            this.textBox20.Leave += new System.EventHandler(this.textBox20_Leave);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.textBox16);
            this.groupBox5.Controls.Add(this.textBox17);
            this.groupBox5.Controls.Add(this.textBox18);
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Controls.Add(this.textBox15);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(638, 339);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(396, 234);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(184, 23);
            this.label39.TabIndex = 17;
            this.label39.Text = "Transport type machine";
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(228, 234);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(168, 23);
            this.label38.TabIndex = 16;
            this.label38.Text = "Coef transport client";
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(60, 234);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(150, 23);
            this.label37.TabIndex = 15;
            this.label37.Text = "Transport client";
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(396, 140);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(180, 24);
            this.label36.TabIndex = 14;
            this.label36.Text = "Contrôle type machine";
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(228, 140);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(156, 24);
            this.label35.TabIndex = 13;
            this.label35.Text = "Coef contrôle client";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(60, 140);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(150, 24);
            this.label34.TabIndex = 12;
            this.label34.Text = "Contrôle client";
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(396, 47);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(156, 23);
            this.label33.TabIndex = 11;
            this.label33.Text = "DNR Type machine";
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(228, 47);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(150, 23);
            this.label32.TabIndex = 10;
            this.label32.Text = "Coef DNR client";
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(60, 47);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(150, 23);
            this.label31.TabIndex = 9;
            this.label31.Text = "DNR Client";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(396, 257);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(150, 26);
            this.textBox16.TabIndex = 8;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(228, 257);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(150, 26);
            this.textBox17.TabIndex = 7;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(60, 257);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(150, 26);
            this.textBox18.TabIndex = 6;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(396, 164);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(150, 26);
            this.textBox13.TabIndex = 5;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(228, 164);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(150, 26);
            this.textBox14.TabIndex = 4;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(60, 164);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(150, 26);
            this.textBox15.TabIndex = 3;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(396, 70);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(150, 26);
            this.textBox12.TabIndex = 2;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(228, 70);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(150, 26);
            this.textBox11.TabIndex = 1;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(60, 70);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(150, 26);
            this.textBox10.TabIndex = 0;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox23.Location = new System.Drawing.Point(8, 94);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(1200, 292);
            this.textBox23.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° Devis";
            // 
            // txNumDevis
            // 
            this.txNumDevis.BackColor = System.Drawing.Color.White;
            this.txNumDevis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNumDevis.Location = new System.Drawing.Point(120, 16);
            this.txNumDevis.Name = "txNumDevis";
            this.txNumDevis.ReadOnly = true;
            this.txNumDevis.Size = new System.Drawing.Size(150, 26);
            this.txNumDevis.TabIndex = 2;
            this.txNumDevis.TabStop = false;
            this.txNumDevis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // txDate
            // 
            this.txDate.BackColor = System.Drawing.Color.White;
            this.txDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDate.Location = new System.Drawing.Point(370, 15);
            this.txDate.Name = "txDate";
            this.txDate.ReadOnly = true;
            this.txDate.Size = new System.Drawing.Size(150, 26);
            this.txDate.TabIndex = 4;
            this.txDate.TabStop = false;
            this.txDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txEtat
            // 
            this.txEtat.BackColor = System.Drawing.Color.Salmon;
            this.txEtat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txEtat.ForeColor = System.Drawing.Color.White;
            this.txEtat.Location = new System.Drawing.Point(584, 15);
            this.txEtat.Name = "txEtat";
            this.txEtat.ReadOnly = true;
            this.txEtat.Size = new System.Drawing.Size(577, 26);
            this.txEtat.TabIndex = 5;
            this.txEtat.TabStop = false;
            this.txEtat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ident", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_reglement1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_transport1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Client_facture1", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pays", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pays", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_code_GC1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telex", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = resources.GetString("oleDbInsertCommand2.CommandText");
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"),
            new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_2"),
            new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"),
            new System.Data.OleDb.OleDbParameter("Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Borne Date Refus reforme"),
            new System.Data.OleDb.OleDbParameter("CA_Annee", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee"),
            new System.Data.OleDb.OleDbParameter("CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_1"),
            new System.Data.OleDb.OleDbParameter("CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_2"),
            new System.Data.OleDb.OleDbParameter("CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_3"),
            new System.Data.OleDb.OleDbParameter("CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_4"),
            new System.Data.OleDb.OleDbParameter("code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, "code_GC"),
            new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"),
            new System.Data.OleDb.OleDbParameter("Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_reglement"),
            new System.Data.OleDb.OleDbParameter("Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_transport"),
            new System.Data.OleDb.OleDbParameter("Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, "Coef_Controle"),
            new System.Data.OleDb.OleDbParameter("Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, "Coef_DNR"),
            new System.Data.OleDb.OleDbParameter("Coef_transport", System.Data.OleDb.OleDbType.Double, 0, "Coef_transport"),
            new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"),
            new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai_garantie"),
            new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait_Controle"),
            new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait_DNR"),
            new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait_transport"),
            new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"),
            new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"),
            new System.Data.OleDb.OleDbParameter("N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, "N°_Cde_Ouverte"),
            new System.Data.OleDb.OleDbParameter("N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, "N°_Client_facture"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_1"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_2"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_3"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_4"),
            new System.Data.OleDb.OleDbParameter("Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, "Notre_Code_Fournisseur"),
            new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"),
            new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage_remise"),
            new System.Data.OleDb.OleDbParameter("Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, "Seuil_reparation"),
            new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"),
            new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"),
            new System.Data.OleDb.OleDbParameter("telex", System.Data.OleDb.OleDbType.VarWChar, 255, "telex"),
            new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"),
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
            new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"),
            new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_2"),
            new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"),
            new System.Data.OleDb.OleDbParameter("Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Borne Date Refus reforme"),
            new System.Data.OleDb.OleDbParameter("CA_Annee", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee"),
            new System.Data.OleDb.OleDbParameter("CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_1"),
            new System.Data.OleDb.OleDbParameter("CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_2"),
            new System.Data.OleDb.OleDbParameter("CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_3"),
            new System.Data.OleDb.OleDbParameter("CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "CA_Annee_4"),
            new System.Data.OleDb.OleDbParameter("code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, "code_GC"),
            new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code_Postal"),
            new System.Data.OleDb.OleDbParameter("Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_reglement"),
            new System.Data.OleDb.OleDbParameter("Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, "Code_transport"),
            new System.Data.OleDb.OleDbParameter("Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, "Coef_Controle"),
            new System.Data.OleDb.OleDbParameter("Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, "Coef_DNR"),
            new System.Data.OleDb.OleDbParameter("Coef_transport", System.Data.OleDb.OleDbType.Double, 0, "Coef_transport"),
            new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"),
            new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai_garantie"),
            new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait_Controle"),
            new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait_DNR"),
            new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait_transport"),
            new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"),
            new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"),
            new System.Data.OleDb.OleDbParameter("N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, "N°_Cde_Ouverte"),
            new System.Data.OleDb.OleDbParameter("N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, "N°_Client_facture"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_1"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_2"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_3"),
            new System.Data.OleDb.OleDbParameter("Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, "Nombre_rep_Annee_4"),
            new System.Data.OleDb.OleDbParameter("Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, "Notre_Code_Fournisseur"),
            new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"),
            new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage_remise"),
            new System.Data.OleDb.OleDbParameter("Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, "Seuil_reparation"),
            new System.Data.OleDb.OleDbParameter("telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "telecopie"),
            new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"),
            new System.Data.OleDb.OleDbParameter("telex", System.Data.OleDb.OleDbType.VarWChar, 255, "telex"),
            new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"),
            new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"),
            new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ident", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Borne_Date_Refus_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Borne Date Refus reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CA_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CA_Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_Postal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_reglement", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_reglement1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_reglement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_transport", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_transport1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Coef_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coef_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai_garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait_transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_11", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_2", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_21", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_3", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_31", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_4", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_rep_Annee_41", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre_rep_Annee_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Notre_Code_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Notre_Code_Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Cde_Ouverte1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N°_Cde_Ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Client_facture", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Client_facture1", System.Data.OleDb.OleDbType.VarWChar, 11, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N°_Client_facture", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pays", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pays", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage_remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_reparation1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil_reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_code_GC", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_code_GC1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "code_GC", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telecopie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telex", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_Groupes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM T_Groupes WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Desi" +
    "gnation IS NULL)";
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO T_Groupes(Code, Designation) VALUES (?, ?)";
            this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation")});
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT Code, Designation FROM T_Groupes";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = "UPDATE T_Groupes SET Code = ?, Designation = ? WHERE (Code = ?) AND (Designation " +
    "= ? OR ? IS NULL AND Designation IS NULL)";
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter4
            // 
            this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand4;
            this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand4;
            this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
            this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_parc_machine", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Affectation", "Affectation"),
                        new System.Data.Common.DataColumnMapping("Code Client", "Code Client"),
                        new System.Data.Common.DataColumnMapping("Code Mabec", "Code Mabec"),
                        new System.Data.Common.DataColumnMapping("Code machine client", "Code machine client"),
                        new System.Data.Common.DataColumnMapping("Code machine Opindus", "Code machine Opindus"),
                        new System.Data.Common.DataColumnMapping("creation", "creation"),
                        new System.Data.Common.DataColumnMapping("Date dernier controle", "Date dernier controle"),
                        new System.Data.Common.DataColumnMapping("Date dernier intervention", "Date dernier intervention"),
                        new System.Data.Common.DataColumnMapping("Date fin garantie", "Date fin garantie"),
                        new System.Data.Common.DataColumnMapping("Date mise en service", "Date mise en service"),
                        new System.Data.Common.DataColumnMapping("Date reforme", "Date reforme"),
                        new System.Data.Common.DataColumnMapping("Date refus", "Date refus"),
                        new System.Data.Common.DataColumnMapping("En parc", "En parc"),
                        new System.Data.Common.DataColumnMapping("En reparation", "En reparation"),
                        new System.Data.Common.DataColumnMapping("Maxi machine", "Maxi machine"),
                        new System.Data.Common.DataColumnMapping("Memo", "Memo"),
                        new System.Data.Common.DataColumnMapping("Mini machine", "Mini machine"),
                        new System.Data.Common.DataColumnMapping("N_fichier_FVG", "N_fichier_FVG"),
                        new System.Data.Common.DataColumnMapping("N° Troncon", "N° Troncon"),
                        new System.Data.Common.DataColumnMapping("No controle", "No controle"),
                        new System.Data.Common.DataColumnMapping("No dernier devis", "No dernier devis"),
                        new System.Data.Common.DataColumnMapping("No dernier devis refus", "No dernier devis refus"),
                        new System.Data.Common.DataColumnMapping("No serie", "No serie"),
                        new System.Data.Common.DataColumnMapping("nombre semaine entre ctl", "nombre semaine entre ctl"),
                        new System.Data.Common.DataColumnMapping("nombre semaine entre inter", "nombre semaine entre inter"),
                        new System.Data.Common.DataColumnMapping("Prix Achat", "Prix Achat"),
                        new System.Data.Common.DataColumnMapping("Prix remplacement", "Prix remplacement"),
                        new System.Data.Common.DataColumnMapping("Site", "Site"),
                        new System.Data.Common.DataColumnMapping("Total casse", "Total casse"),
                        new System.Data.Common.DataColumnMapping("Total controle", "Total controle"),
                        new System.Data.Common.DataColumnMapping("Total general", "Total general"),
                        new System.Data.Common.DataColumnMapping("Total maintenance", "Total maintenance"),
                        new System.Data.Common.DataColumnMapping("Total MO", "Total MO"),
                        new System.Data.Common.DataColumnMapping("Total piece manque", "Total piece manque"),
                        new System.Data.Common.DataColumnMapping("Total transport", "Total transport"),
                        new System.Data.Common.DataColumnMapping("Total usure", "Total usure"),
                        new System.Data.Common.DataColumnMapping("Type machine", "Type machine")})});
            this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand4;
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = resources.GetString("oleDbDeleteCommand4.CommandText");
            this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Affectation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Affectation1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Mabec1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_client1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_refus1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_En_parc", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "En parc", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "En reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No serie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_serie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No serie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Site", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Site", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_MO", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_MO1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_casse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_casse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_general", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total general", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_general1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total general", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_maintenance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_usure", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_usure1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_machine1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = resources.GetString("oleDbInsertCommand4.CommandText");
            this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Affectation", System.Data.OleDb.OleDbType.Integer, 0, "Affectation"),
            new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"),
            new System.Data.OleDb.OleDbParameter("Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Mabec"),
            new System.Data.OleDb.OleDbParameter("Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine client"),
            new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"),
            new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Boolean, 2, "creation"),
            new System.Data.OleDb.OleDbParameter("Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier controle"),
            new System.Data.OleDb.OleDbParameter("Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier intervention"),
            new System.Data.OleDb.OleDbParameter("Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, "Date fin garantie"),
            new System.Data.OleDb.OleDbParameter("Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, "Date mise en service"),
            new System.Data.OleDb.OleDbParameter("Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Date reforme"),
            new System.Data.OleDb.OleDbParameter("Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, "Date refus"),
            new System.Data.OleDb.OleDbParameter("En_parc", System.Data.OleDb.OleDbType.Boolean, 2, "En parc"),
            new System.Data.OleDb.OleDbParameter("En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, "En reparation"),
            new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"),
            new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"),
            new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"),
            new System.Data.OleDb.OleDbParameter("N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, "N_fichier_FVG"),
            new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"),
            new System.Data.OleDb.OleDbParameter("No_controle", System.Data.OleDb.OleDbType.Integer, 0, "No controle"),
            new System.Data.OleDb.OleDbParameter("No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis"),
            new System.Data.OleDb.OleDbParameter("No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis refus"),
            new System.Data.OleDb.OleDbParameter("No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, "No serie"),
            new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre ctl"),
            new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre inter"),
            new System.Data.OleDb.OleDbParameter("Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat"),
            new System.Data.OleDb.OleDbParameter("Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, "Prix remplacement"),
            new System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.Integer, 0, "Site"),
            new System.Data.OleDb.OleDbParameter("Total_casse", System.Data.OleDb.OleDbType.Double, 0, "Total casse"),
            new System.Data.OleDb.OleDbParameter("Total_controle", System.Data.OleDb.OleDbType.Double, 0, "Total controle"),
            new System.Data.OleDb.OleDbParameter("Total_general", System.Data.OleDb.OleDbType.Double, 0, "Total general"),
            new System.Data.OleDb.OleDbParameter("Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, "Total maintenance"),
            new System.Data.OleDb.OleDbParameter("Total_MO", System.Data.OleDb.OleDbType.Double, 0, "Total MO"),
            new System.Data.OleDb.OleDbParameter("Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, "Total piece manque"),
            new System.Data.OleDb.OleDbParameter("Total_transport", System.Data.OleDb.OleDbType.Double, 0, "Total transport"),
            new System.Data.OleDb.OleDbParameter("Total_usure", System.Data.OleDb.OleDbType.Double, 0, "Total usure"),
            new System.Data.OleDb.OleDbParameter("Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, "Type machine")});
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
            new System.Data.OleDb.OleDbParameter("Affectation", System.Data.OleDb.OleDbType.Integer, 0, "Affectation"),
            new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"),
            new System.Data.OleDb.OleDbParameter("Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Mabec"),
            new System.Data.OleDb.OleDbParameter("Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine client"),
            new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"),
            new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Boolean, 2, "creation"),
            new System.Data.OleDb.OleDbParameter("Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier controle"),
            new System.Data.OleDb.OleDbParameter("Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier intervention"),
            new System.Data.OleDb.OleDbParameter("Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, "Date fin garantie"),
            new System.Data.OleDb.OleDbParameter("Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, "Date mise en service"),
            new System.Data.OleDb.OleDbParameter("Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Date reforme"),
            new System.Data.OleDb.OleDbParameter("Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, "Date refus"),
            new System.Data.OleDb.OleDbParameter("En_parc", System.Data.OleDb.OleDbType.Boolean, 2, "En parc"),
            new System.Data.OleDb.OleDbParameter("En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, "En reparation"),
            new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"),
            new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"),
            new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"),
            new System.Data.OleDb.OleDbParameter("N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, "N_fichier_FVG"),
            new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"),
            new System.Data.OleDb.OleDbParameter("No_controle", System.Data.OleDb.OleDbType.Integer, 0, "No controle"),
            new System.Data.OleDb.OleDbParameter("No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis"),
            new System.Data.OleDb.OleDbParameter("No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis refus"),
            new System.Data.OleDb.OleDbParameter("No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, "No serie"),
            new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre ctl"),
            new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre inter"),
            new System.Data.OleDb.OleDbParameter("Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat"),
            new System.Data.OleDb.OleDbParameter("Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, "Prix remplacement"),
            new System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.Integer, 0, "Site"),
            new System.Data.OleDb.OleDbParameter("Total_casse", System.Data.OleDb.OleDbType.Double, 0, "Total casse"),
            new System.Data.OleDb.OleDbParameter("Total_controle", System.Data.OleDb.OleDbType.Double, 0, "Total controle"),
            new System.Data.OleDb.OleDbParameter("Total_general", System.Data.OleDb.OleDbType.Double, 0, "Total general"),
            new System.Data.OleDb.OleDbParameter("Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, "Total maintenance"),
            new System.Data.OleDb.OleDbParameter("Total_MO", System.Data.OleDb.OleDbType.Double, 0, "Total MO"),
            new System.Data.OleDb.OleDbParameter("Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, "Total piece manque"),
            new System.Data.OleDb.OleDbParameter("Total_transport", System.Data.OleDb.OleDbType.Double, 0, "Total transport"),
            new System.Data.OleDb.OleDbParameter("Total_usure", System.Data.OleDb.OleDbType.Double, 0, "Total usure"),
            new System.Data.OleDb.OleDbParameter("Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, "Type machine"),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Affectation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Affectation1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Mabec1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_client1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_refus1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_En_parc", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "En parc", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "En reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No serie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_serie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No serie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Site", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Site", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_MO", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_MO1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_casse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_casse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_general", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total general", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_general1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total general", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_maintenance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_usure", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_usure1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_machine1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter5
            // 
            this.oleDbDataAdapter5.DeleteCommand = this.oleDbDeleteCommand5;
            this.oleDbDataAdapter5.InsertCommand = this.oleDbInsertCommand5;
            this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
            this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            this.oleDbDataAdapter5.UpdateCommand = this.oleDbUpdateCommand5;
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = resources.GetString("oleDbDeleteCommand5.CommandText");
            this.oleDbDeleteCommand5.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = resources.GetString("oleDbInsertCommand5.CommandText");
            this.oleDbInsertCommand5.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"),
            new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"),
            new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"),
            new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"),
            new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"),
            new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"),
            new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"),
            new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"),
            new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"),
            new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"),
            new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"),
            new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"),
            new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"),
            new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"),
            new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse")});
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = resources.GetString("oleDbSelectCommand5.CommandText");
            this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = resources.GetString("oleDbUpdateCommand5.CommandText");
            this.oleDbUpdateCommand5.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"),
            new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"),
            new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"),
            new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"),
            new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"),
            new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"),
            new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"),
            new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"),
            new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"),
            new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"),
            new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"),
            new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"),
            new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"),
            new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"),
            new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter6
            // 
            this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand6;
            this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand6;
            this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
            this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand6;
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = resources.GetString("oleDbDeleteCommand6.CommandText");
            this.oleDbDeleteCommand6.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = resources.GetString("oleDbInsertCommand6.CommandText");
            this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            this.oleDbDeleteCommand7.CommandText = resources.GetString("oleDbDeleteCommand7.CommandText");
            this.oleDbDeleteCommand7.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand7
            // 
            this.oleDbInsertCommand7.CommandText = "INSERT INTO T_famille_machine(Code, Designation, E_champ_1, E_champ_2, E_champ_3," +
    " E_champ_4, Type) VALUES (?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand7.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"),
            new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"),
            new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"),
            new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"),
            new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"),
            new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type")});
            // 
            // oleDbSelectCommand7
            // 
            this.oleDbSelectCommand7.CommandText = "SELECT Code, Designation, E_champ_1, E_champ_2, E_champ_3, E_champ_4, Type FROM T" +
    "_famille_machine";
            this.oleDbSelectCommand7.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand7
            // 
            this.oleDbUpdateCommand7.CommandText = resources.GetString("oleDbUpdateCommand7.CommandText");
            this.oleDbUpdateCommand7.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"),
            new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"),
            new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"),
            new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"),
            new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"),
            new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null)});
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.Blue;
            this.btSave.Location = new System.Drawing.Point(24, 772);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(150, 33);
            this.btSave.TabIndex = 6;
            this.btSave.TabStop = false;
            this.btSave.Text = "Enregistrement";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(204, 772);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 33);
            this.button4.TabIndex = 7;
            this.button4.TabStop = false;
            this.button4.Text = "Impression";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // oleDbDataAdapter8
            // 
            this.oleDbDataAdapter8.DeleteCommand = this.oleDbDeleteCommand8;
            this.oleDbDataAdapter8.InsertCommand = this.oleDbInsertCommand8;
            this.oleDbDataAdapter8.SelectCommand = this.oleDbSelectCommand8;
            this.oleDbDataAdapter8.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_reparateurs", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Nom", "Nom")})});
            this.oleDbDataAdapter8.UpdateCommand = this.oleDbUpdateCommand8;
            // 
            // oleDbDeleteCommand8
            // 
            this.oleDbDeleteCommand8.CommandText = "DELETE FROM T_reparateurs WHERE (ID = ?) AND (Nom = ? OR ? IS NULL AND Nom IS NUL" +
    "L)";
            this.oleDbDeleteCommand8.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand8
            // 
            this.oleDbInsertCommand8.CommandText = "INSERT INTO T_reparateurs(ID, Nom) VALUES (?, ?)";
            this.oleDbInsertCommand8.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 5, "ID"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom")});
            // 
            // oleDbSelectCommand8
            // 
            this.oleDbSelectCommand8.CommandText = "SELECT ID, Nom FROM T_reparateurs";
            this.oleDbSelectCommand8.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand8
            // 
            this.oleDbUpdateCommand8.CommandText = "UPDATE T_reparateurs SET ID = ?, Nom = ? WHERE (ID = ?) AND (Nom = ? OR ? IS NULL" +
    " AND Nom IS NULL)";
            this.oleDbUpdateCommand8.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 5, "ID"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter9
            // 
            this.oleDbDataAdapter9.DeleteCommand = this.oleDbDeleteCommand9;
            this.oleDbDataAdapter9.InsertCommand = this.oleDbInsertCommand9;
            this.oleDbDataAdapter9.SelectCommand = this.oleDbSelectCommand9;
            this.oleDbDataAdapter9.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            this.oleDbDataAdapter9.UpdateCommand = this.oleDbUpdateCommand9;
            // 
            // oleDbDeleteCommand9
            // 
            this.oleDbDeleteCommand9.CommandText = resources.GetString("oleDbDeleteCommand9.CommandText");
            this.oleDbDeleteCommand9.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // oleDbInsertCommand9
            // 
            this.oleDbInsertCommand9.CommandText = resources.GetString("oleDbInsertCommand9.CommandText");
            this.oleDbInsertCommand9.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // oleDbSelectCommand9
            // 
            this.oleDbSelectCommand9.CommandText = resources.GetString("oleDbSelectCommand9.CommandText");
            this.oleDbSelectCommand9.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand9
            // 
            this.oleDbUpdateCommand9.CommandText = resources.GetString("oleDbUpdateCommand9.CommandText");
            this.oleDbUpdateCommand9.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
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
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lavender;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(228, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 29);
            this.button6.TabIndex = 20;
            this.button6.TabStop = false;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // tabControlEX1
            // 
            this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
            this.tabControlEX1.Controls.Add(this.tabPageEX1);
            this.tabControlEX1.Controls.Add(this.tabPageEX2);
            this.tabControlEX1.Controls.Add(this.tabPageEX3);
            this.tabControlEX1.Controls.Add(this.tabPageEX4);
            this.tabControlEX1.Location = new System.Drawing.Point(-8, 56);
            this.tabControlEX1.Name = "tabControlEX1";
            this.tabControlEX1.SelectedIndex = 1;
            this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
            this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
            this.tabControlEX1.Size = new System.Drawing.Size(1240, 685);
            this.tabControlEX1.TabColor = System.Drawing.Color.DarkGray;
            this.tabControlEX1.TabIndex = 1;
            this.tabControlEX1.TabStop = false;
            this.tabControlEX1.UseVisualStyles = false;
            // 
            // tabPageEX1
            // 
            this.tabPageEX1.Controls.Add(this.groupBox1);
            this.tabPageEX1.Controls.Add(this.groupBox2);
            this.tabPageEX1.Controls.Add(this.groupBox3);
            this.tabPageEX1.Controls.Add(this.groupBox4);
            this.tabPageEX1.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(1232, 652);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Entête";
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.Controls.Add(this.txPrixAchat);
            this.tabPageEX2.Controls.Add(this.button16);
            this.tabPageEX2.Controls.Add(this.mtgcComboBox11);
            this.tabPageEX2.Controls.Add(this.mtgcComboBox10);
            this.tabPageEX2.Controls.Add(this.textBox9);
            this.tabPageEX2.Controls.Add(this.button15);
            this.tabPageEX2.Controls.Add(this.button14);
            this.tabPageEX2.Controls.Add(this.textBox35);
            this.tabPageEX2.Controls.Add(this.button3);
            this.tabPageEX2.Controls.Add(this.textBox1);
            this.tabPageEX2.Controls.Add(this.mtgcComboBox9);
            this.tabPageEX2.Controls.Add(this.label58);
            this.tabPageEX2.Controls.Add(this.label54);
            this.tabPageEX2.Controls.Add(this.textBox34);
            this.tabPageEX2.Controls.Add(this.label53);
            this.tabPageEX2.Controls.Add(this.mtgcComboBox5);
            this.tabPageEX2.Controls.Add(this.mtgcComboBox4);
            this.tabPageEX2.Controls.Add(this.mtgcComboBox3);
            this.tabPageEX2.Controls.Add(this.label52);
            this.tabPageEX2.Controls.Add(this.label51);
            this.tabPageEX2.Controls.Add(this.label30);
            this.tabPageEX2.Controls.Add(this.label29);
            this.tabPageEX2.Controls.Add(this.numericUpDown2);
            this.tabPageEX2.Controls.Add(this.numericUpDown1);
            this.tabPageEX2.Controls.Add(this.label28);
            this.tabPageEX2.Controls.Add(this.label27);
            this.tabPageEX2.Controls.Add(this.txNetCommande);
            this.tabPageEX2.Controls.Add(this.textBox8);
            this.tabPageEX2.Controls.Add(this.label26);
            this.tabPageEX2.Controls.Add(this.textBox5);
            this.tabPageEX2.Controls.Add(this.textBox4);
            this.tabPageEX2.Controls.Add(this.textBox3);
            this.tabPageEX2.Controls.Add(this.button6);
            this.tabPageEX2.Controls.Add(this.textBox2);
            this.tabPageEX2.Controls.Add(this.listView1);
            this.tabPageEX2.Controls.Add(this.textBox6);
            this.tabPageEX2.Controls.Add(this.button13);
            this.tabPageEX2.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(1232, 652);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Lignes";
            this.tabPageEX2.Click += new System.EventHandler(this.tabPageEX2_Click);
            // 
            // txPrixAchat
            // 
            this.txPrixAchat.Location = new System.Drawing.Point(1008, 94);
            this.txPrixAchat.Name = "txPrixAchat";
            this.txPrixAchat.Size = new System.Drawing.Size(84, 26);
            this.txPrixAchat.TabIndex = 40;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Lavender;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(804, 199);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 33);
            this.button16.TabIndex = 39;
            this.button16.Text = "Valider";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Visible = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // mtgcComboBox11
            // 
            this.mtgcComboBox11.BackColor = System.Drawing.Color.MistyRose;
            this.mtgcComboBox11.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox11.ColumnNum = 2;
            this.mtgcComboBox11.ColumnWidth = "50;200";
            this.mtgcComboBox11.DisplayMember = "Text";
            this.mtgcComboBox11.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox11.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox11.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox11.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox11.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox11.DropDownWidth = 270;
            this.mtgcComboBox11.ForeColor = System.Drawing.Color.White;
            this.mtgcComboBox11.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox11.GridLineHorizontal = false;
            this.mtgcComboBox11.GridLineVertical = false;
            this.mtgcComboBox11.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox11.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox11.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox11.Location = new System.Drawing.Point(600, 199);
            this.mtgcComboBox11.ManagingFastMouseMoving = true;
            this.mtgcComboBox11.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox11.Name = "mtgcComboBox11";
            this.mtgcComboBox11.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox11.Size = new System.Drawing.Size(180, 27);
            this.mtgcComboBox11.TabIndex = 38;
            this.mtgcComboBox11.ValueMember = "Code";
            this.mtgcComboBox11.Visible = false;
            // 
            // mtgcComboBox10
            // 
            this.mtgcComboBox10.BackColor = System.Drawing.Color.MistyRose;
            this.mtgcComboBox10.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox10.ColumnNum = 2;
            this.mtgcComboBox10.ColumnWidth = "50;200";
            this.mtgcComboBox10.DisplayMember = "Text";
            this.mtgcComboBox10.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox10.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox10.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox10.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox10.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox10.DropDownWidth = 270;
            this.mtgcComboBox10.ForeColor = System.Drawing.Color.White;
            this.mtgcComboBox10.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox10.GridLineHorizontal = false;
            this.mtgcComboBox10.GridLineVertical = false;
            this.mtgcComboBox10.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox10.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox10.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox10.Location = new System.Drawing.Point(276, 199);
            this.mtgcComboBox10.ManagingFastMouseMoving = true;
            this.mtgcComboBox10.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox10.Name = "mtgcComboBox10";
            this.mtgcComboBox10.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox10.Size = new System.Drawing.Size(300, 27);
            this.mtgcComboBox10.TabIndex = 37;
            this.mtgcComboBox10.ValueMember = "Code";
            this.mtgcComboBox10.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.MistyRose;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(12, 199);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(240, 26);
            this.textBox9.TabIndex = 36;
            this.textBox9.Visible = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Lavender;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(780, 152);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 31);
            this.button15.TabIndex = 35;
            this.button15.TabStop = false;
            this.button15.Text = "Annuler";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Visible = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.MistyRose;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(684, 152);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 31);
            this.button14.TabIndex = 34;
            this.button14.TabStop = false;
            this.button14.Text = "Valider";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Visible = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(456, 152);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(192, 26);
            this.textBox35.TabIndex = 33;
            this.textBox35.TabStop = false;
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox35.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(286, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 34);
            this.button3.TabIndex = 32;
            this.button3.TabStop = false;
            this.button3.Text = "Nouveau code";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(456, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 31;
            this.textBox1.TabStop = false;
            this.textBox1.Visible = false;
            // 
            // mtgcComboBox9
            // 
            this.mtgcComboBox9.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox9.ColumnNum = 4;
            this.mtgcComboBox9.ColumnWidth = "50;150;200;200";
            this.mtgcComboBox9.DisplayMember = "Text";
            this.mtgcComboBox9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox9.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox9.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox9.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox9.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox9.DropDownWidth = 620;
            this.mtgcComboBox9.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox9.GridLineHorizontal = false;
            this.mtgcComboBox9.GridLineVertical = true;
            this.mtgcComboBox9.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox9.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox9.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox9.Location = new System.Drawing.Point(12, 94);
            this.mtgcComboBox9.ManagingFastMouseMoving = true;
            this.mtgcComboBox9.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox9.Name = "mtgcComboBox9";
            this.mtgcComboBox9.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox9.Size = new System.Drawing.Size(204, 27);
            this.mtgcComboBox9.TabIndex = 2;
            this.mtgcComboBox9.TabStop = false;
            this.mtgcComboBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox9_KeyDown);
            // 
            // label58
            // 
            this.label58.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(12, 70);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(150, 24);
            this.label58.TabIndex = 30;
            this.label58.Text = "Identificateur";
            // 
            // label54
            // 
            this.label54.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(948, 609);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(99, 28);
            this.label54.TabIndex = 29;
            this.label54.Text = "Total devis";
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(1056, 605);
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(156, 26);
            this.textBox34.TabIndex = 28;
            this.textBox34.TabStop = false;
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(288, 12);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(252, 23);
            this.label53.TabIndex = 27;
            this.label53.Text = "Désignation";
            // 
            // mtgcComboBox5
            // 
            this.mtgcComboBox5.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox5.ColumnNum = 4;
            this.mtgcComboBox5.ColumnWidth = "150;150;200;200";
            this.mtgcComboBox5.DisplayMember = "Text";
            this.mtgcComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox5.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox5.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox5.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox5.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox5.DropDownWidth = 720;
            this.mtgcComboBox5.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox5.GridLineHorizontal = false;
            this.mtgcComboBox5.GridLineVertical = true;
            this.mtgcComboBox5.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox5.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox5.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox5.Location = new System.Drawing.Point(12, 152);
            this.mtgcComboBox5.ManagingFastMouseMoving = true;
            this.mtgcComboBox5.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox5.Name = "mtgcComboBox5";
            this.mtgcComboBox5.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox5.Size = new System.Drawing.Size(204, 27);
            this.mtgcComboBox5.TabIndex = 3;
            this.mtgcComboBox5.TabStop = false;
            this.mtgcComboBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox5_KeyDown);
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
            this.mtgcComboBox4.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox4.GridLineHorizontal = false;
            this.mtgcComboBox4.GridLineVertical = false;
            this.mtgcComboBox4.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox4.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox4.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox4.Location = new System.Drawing.Point(936, 152);
            this.mtgcComboBox4.ManagingFastMouseMoving = true;
            this.mtgcComboBox4.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox4.Name = "mtgcComboBox4";
            this.mtgcComboBox4.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox4.Size = new System.Drawing.Size(156, 27);
            this.mtgcComboBox4.TabIndex = 6;
            // 
            // mtgcComboBox3
            // 
            this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox3.ColumnNum = 4;
            this.mtgcComboBox3.ColumnWidth = "150;200;250;50";
            this.mtgcComboBox3.DisplayMember = "Text";
            this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox3.DropDownWidth = 670;
            this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox3.GridLineHorizontal = false;
            this.mtgcComboBox3.GridLineVertical = true;
            this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox3.Location = new System.Drawing.Point(12, 35);
            this.mtgcComboBox3.ManagingFastMouseMoving = true;
            this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox3.Name = "mtgcComboBox3";
            this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox3.Size = new System.Drawing.Size(204, 27);
            this.mtgcComboBox3.TabIndex = 1;
            this.mtgcComboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox3_KeyDown);
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(1008, 12);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(84, 23);
            this.label52.TabIndex = 24;
            this.label52.Text = "Remise";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(912, 12);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(84, 23);
            this.label51.TabIndex = 23;
            this.label51.Text = "Qté";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(12, 129);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(204, 23);
            this.label30.TabIndex = 22;
            this.label30.Text = "Ancienne référence";
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(12, 12);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(204, 23);
            this.label29.TabIndex = 30;
            this.label29.Text = "Code pièce";
            // 
            // tabPageEX3
            // 
            this.tabPageEX3.Controls.Add(this.label60);
            this.tabPageEX3.Controls.Add(this.label59);
            this.tabPageEX3.Controls.Add(this.groupBox7);
            this.tabPageEX3.Controls.Add(this.label50);
            this.tabPageEX3.Controls.Add(this.label49);
            this.tabPageEX3.Controls.Add(this.label48);
            this.tabPageEX3.Controls.Add(this.textBox30);
            this.tabPageEX3.Controls.Add(this.textBox29);
            this.tabPageEX3.Controls.Add(this.label47);
            this.tabPageEX3.Controls.Add(this.textBox28);
            this.tabPageEX3.Controls.Add(this.groupBox5);
            this.tabPageEX3.Controls.Add(this.label46);
            this.tabPageEX3.Controls.Add(this.label45);
            this.tabPageEX3.Controls.Add(this.textBox27);
            this.tabPageEX3.Controls.Add(this.textBox26);
            this.tabPageEX3.Controls.Add(this.textBox24);
            this.tabPageEX3.Controls.Add(this.textBox25);
            this.tabPageEX3.Controls.Add(this.label44);
            this.tabPageEX3.Controls.Add(this.groupBox6);
            this.tabPageEX3.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX3.Name = "tabPageEX3";
            this.tabPageEX3.Size = new System.Drawing.Size(1232, 652);
            this.tabPageEX3.TabIndex = 2;
            this.tabPageEX3.Text = "Pieds";
            // 
            // label60
            // 
            this.label60.Location = new System.Drawing.Point(420, 398);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(60, 33);
            this.label60.TabIndex = 19;
            this.label60.Text = "%";
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(252, 398);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(24, 33);
            this.label59.TabIndex = 18;
            this.label59.Text = "%";
            // 
            // tabPageEX4
            // 
            this.tabPageEX4.Controls.Add(this.pictureBox1);
            this.tabPageEX4.Controls.Add(this.textBox23);
            this.tabPageEX4.Location = new System.Drawing.Point(4, 29);
            this.tabPageEX4.Name = "tabPageEX4";
            this.tabPageEX4.Size = new System.Drawing.Size(1232, 652);
            this.tabPageEX4.TabIndex = 3;
            this.tabPageEX4.Text = "Commentaires";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1116, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 82);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1140, 750);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 70);
            this.button5.TabIndex = 13;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // oleDbDataAdapter10
            // 
            this.oleDbDataAdapter10.DeleteCommand = this.oleDbDeleteCommand10;
            this.oleDbDataAdapter10.InsertCommand = this.oleDbInsertCommand10;
            this.oleDbDataAdapter10.SelectCommand = this.oleDbSelectCommand10;
            this.oleDbDataAdapter10.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_causes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
            this.oleDbDataAdapter10.UpdateCommand = this.oleDbUpdateCommand10;
            // 
            // oleDbDeleteCommand10
            // 
            this.oleDbDeleteCommand10.CommandText = "DELETE FROM T_causes WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Desig" +
    "nation IS NULL)";
            this.oleDbDeleteCommand10.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand10.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand10
            // 
            this.oleDbInsertCommand10.CommandText = "INSERT INTO T_causes(Code, Designation) VALUES (?, ?)";
            this.oleDbInsertCommand10.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand10.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation")});
            // 
            // oleDbSelectCommand10
            // 
            this.oleDbSelectCommand10.CommandText = "SELECT Code, Designation FROM T_causes";
            this.oleDbSelectCommand10.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand10
            // 
            this.oleDbUpdateCommand10.CommandText = "UPDATE T_causes SET Code = ?, Designation = ? WHERE (Code = ?) AND (Designation =" +
    " ? OR ? IS NULL AND Designation IS NULL)";
            this.oleDbUpdateCommand10.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand10.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null)});
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // oleDbDataAdapter12
            // 
            this.oleDbDataAdapter12.DeleteCommand = this.oleDbDeleteCommand12;
            this.oleDbDataAdapter12.InsertCommand = this.oleDbInsertCommand12;
            this.oleDbDataAdapter12.SelectCommand = this.oleDbSelectCommand12;
            this.oleDbDataAdapter12.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_BL_entete", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code client", "Code client"),
                        new System.Data.Common.DataColumnMapping("Code TVA", "Code TVA"),
                        new System.Data.Common.DataColumnMapping("Comment", "Comment"),
                        new System.Data.Common.DataColumnMapping("Date", "Date"),
                        new System.Data.Common.DataColumnMapping("Edite", "Edite"),
                        new System.Data.Common.DataColumnMapping("N° BL", "N° BL"),
                        new System.Data.Common.DataColumnMapping("N° Commande ouverte", "N° Commande ouverte"),
                        new System.Data.Common.DataColumnMapping("OR", "OR"),
                        new System.Data.Common.DataColumnMapping("Total bl", "Total bl"),
                        new System.Data.Common.DataColumnMapping("Total bl Euros", "Total bl Euros"),
                        new System.Data.Common.DataColumnMapping("transfere", "transfere"),
                        new System.Data.Common.DataColumnMapping("transfert", "transfert")})});
            this.oleDbDataAdapter12.UpdateCommand = this.oleDbUpdateCommand12;
            // 
            // oleDbDeleteCommand12
            // 
            this.oleDbDeleteCommand12.CommandText = resources.GetString("oleDbDeleteCommand12.CommandText");
            this.oleDbDeleteCommand12.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand12.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_N__BL", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° BL", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_TVA", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code TVA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_TVA1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code TVA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_OR", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl_Euros", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl Euros", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl_Euros1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl Euros", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_transfere", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "transfere", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_transfert", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "transfert", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand12
            // 
            this.oleDbInsertCommand12.CommandText = resources.GetString("oleDbInsertCommand12.CommandText");
            this.oleDbInsertCommand12.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand12.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code_client", System.Data.OleDb.OleDbType.Integer, 0, "Code client"),
            new System.Data.OleDb.OleDbParameter("Code_TVA", System.Data.OleDb.OleDbType.SmallInt, 0, "Code TVA"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"),
            new System.Data.OleDb.OleDbParameter("N__BL", System.Data.OleDb.OleDbType.Integer, 0, "N° BL"),
            new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"),
            new System.Data.OleDb.OleDbParameter("OR", System.Data.OleDb.OleDbType.VarWChar, 20, "OR"),
            new System.Data.OleDb.OleDbParameter("Total_bl", System.Data.OleDb.OleDbType.Double, 0, "Total bl"),
            new System.Data.OleDb.OleDbParameter("Total_bl_Euros", System.Data.OleDb.OleDbType.Double, 0, "Total bl Euros"),
            new System.Data.OleDb.OleDbParameter("transfere", System.Data.OleDb.OleDbType.Boolean, 2, "transfere"),
            new System.Data.OleDb.OleDbParameter("transfert", System.Data.OleDb.OleDbType.Boolean, 2, "transfert")});
            // 
            // oleDbSelectCommand12
            // 
            this.oleDbSelectCommand12.CommandText = "SELECT [Code client], [Code TVA], Comment, [Date], Edite, [N° BL], [N° Commande o" +
    "uverte], [OR], [Total bl], [Total bl Euros], transfere, transfert FROM T_BL_ente" +
    "te";
            this.oleDbSelectCommand12.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand12
            // 
            this.oleDbUpdateCommand12.CommandText = resources.GetString("oleDbUpdateCommand12.CommandText");
            this.oleDbUpdateCommand12.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand12.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code_client", System.Data.OleDb.OleDbType.Integer, 0, "Code client"),
            new System.Data.OleDb.OleDbParameter("Code_TVA", System.Data.OleDb.OleDbType.SmallInt, 0, "Code TVA"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"),
            new System.Data.OleDb.OleDbParameter("N__BL", System.Data.OleDb.OleDbType.Integer, 0, "N° BL"),
            new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"),
            new System.Data.OleDb.OleDbParameter("OR", System.Data.OleDb.OleDbType.VarWChar, 20, "OR"),
            new System.Data.OleDb.OleDbParameter("Total_bl", System.Data.OleDb.OleDbType.Double, 0, "Total bl"),
            new System.Data.OleDb.OleDbParameter("Total_bl_Euros", System.Data.OleDb.OleDbType.Double, 0, "Total bl Euros"),
            new System.Data.OleDb.OleDbParameter("transfere", System.Data.OleDb.OleDbType.Boolean, 2, "transfere"),
            new System.Data.OleDb.OleDbParameter("transfert", System.Data.OleDb.OleDbType.Boolean, 2, "transfert"),
            new System.Data.OleDb.OleDbParameter("Original_N__BL", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° BL", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_TVA", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code TVA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_TVA1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code TVA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_OR", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl_Euros", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl Euros", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_bl_Euros1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total bl Euros", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_transfere", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "transfere", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_transfert", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "transfert", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter13
            // 
            this.oleDbDataAdapter13.InsertCommand = this.oleDbInsertCommand13;
            this.oleDbDataAdapter13.SelectCommand = this.oleDbSelectCommand13;
            this.oleDbDataAdapter13.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_BL_Lignes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code Mabec", "Code Mabec"),
                        new System.Data.Common.DataColumnMapping("Code materiel", "Code materiel"),
                        new System.Data.Common.DataColumnMapping("Code ventilation", "Code ventilation"),
                        new System.Data.Common.DataColumnMapping("Fournisseur", "Fournisseur"),
                        new System.Data.Common.DataColumnMapping("Montant", "Montant"),
                        new System.Data.Common.DataColumnMapping("N° BL", "N° BL"),
                        new System.Data.Common.DataColumnMapping("N° Devis", "N° Devis"),
                        new System.Data.Common.DataColumnMapping("Total ligne", "Total ligne"),
                        new System.Data.Common.DataColumnMapping("Troncon", "Troncon"),
                        new System.Data.Common.DataColumnMapping("Type Materiel", "Type Materiel")})});
            // 
            // oleDbInsertCommand13
            // 
            this.oleDbInsertCommand13.CommandText = "INSERT INTO T_BL_Lignes([Code Mabec], [Code materiel], [Code ventilation], Fourni" +
    "sseur, Montant, [N° BL], [N° Devis], [Total ligne], Troncon, [Type Materiel]) VA" +
    "LUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand13.Connection = this.oleDbConnection2;
            this.oleDbInsertCommand13.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Mabec"),
            new System.Data.OleDb.OleDbParameter("Code_materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code materiel"),
            new System.Data.OleDb.OleDbParameter("Code_ventilation", System.Data.OleDb.OleDbType.Integer, 0, "Code ventilation"),
            new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 50, "Fournisseur"),
            new System.Data.OleDb.OleDbParameter("Montant", System.Data.OleDb.OleDbType.VarWChar, 20, "Montant"),
            new System.Data.OleDb.OleDbParameter("N__BL", System.Data.OleDb.OleDbType.Integer, 0, "N° BL"),
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("Total_ligne", System.Data.OleDb.OleDbType.Double, 0, "Total ligne"),
            new System.Data.OleDb.OleDbParameter("Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "Troncon"),
            new System.Data.OleDb.OleDbParameter("Type_Materiel", System.Data.OleDb.OleDbType.VarWChar, 19, "Type Materiel")});
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = resources.GetString("oleDbConnection2.ConnectionString");
            // 
            // oleDbSelectCommand13
            // 
            this.oleDbSelectCommand13.CommandText = "SELECT [Code Mabec], [Code materiel], [Code ventilation], Fournisseur, Montant, [" +
    "N° BL], [N° Devis], [Total ligne], Troncon, [Type Materiel] FROM T_BL_Lignes";
            this.oleDbSelectCommand13.Connection = this.oleDbConnection2;
            // 
            // oleDbDataAdapter11
            // 
            this.oleDbDataAdapter11.DeleteCommand = this.oleDbDeleteCommand11;
            this.oleDbDataAdapter11.InsertCommand = this.oleDbInsertCommand11;
            this.oleDbDataAdapter11.SelectCommand = this.oleDbSelectCommand11;
            this.oleDbDataAdapter11.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "t_devis_lignes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Cause", "Cause"),
                        new System.Data.Common.DataColumnMapping("Code piece", "Code piece"),
                        new System.Data.Common.DataColumnMapping("Code piece provisoire", "Code piece provisoire"),
                        new System.Data.Common.DataColumnMapping("Designation", "Designation"),
                        new System.Data.Common.DataColumnMapping("idLigne", "idLigne"),
                        new System.Data.Common.DataColumnMapping("N° Devis", "N° Devis"),
                        new System.Data.Common.DataColumnMapping("Pourcentage remise", "Pourcentage remise"),
                        new System.Data.Common.DataColumnMapping("Prix achat net", "Prix achat net"),
                        new System.Data.Common.DataColumnMapping("Prix de vente", "Prix de vente"),
                        new System.Data.Common.DataColumnMapping("Quantite", "Quantite"),
                        new System.Data.Common.DataColumnMapping("Total ligne", "Total ligne")})});
            this.oleDbDataAdapter11.UpdateCommand = this.oleDbUpdateCommand11;
            // 
            // oleDbDeleteCommand11
            // 
            this.oleDbDeleteCommand11.CommandText = resources.GetString("oleDbDeleteCommand11.CommandText");
            this.oleDbDeleteCommand11.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand11.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_idLigne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idLigne", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_piece_provisoire", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code piece provisoire", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_piece_provisoire1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code piece provisoire", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_achat_net", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix achat net", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_achat_net1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix achat net", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_de_vente", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix de vente", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_de_vente1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix de vente", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_ligne", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total ligne", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_ligne1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total ligne", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand11
            // 
            this.oleDbInsertCommand11.CommandText = resources.GetString("oleDbInsertCommand11.CommandText");
            this.oleDbInsertCommand11.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand11.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Cause", System.Data.OleDb.OleDbType.Integer, 0, "Cause"),
            new System.Data.OleDb.OleDbParameter("Code_piece", System.Data.OleDb.OleDbType.Integer, 0, "Code piece"),
            new System.Data.OleDb.OleDbParameter("Code_piece_provisoire", System.Data.OleDb.OleDbType.VarWChar, 50, "Code piece provisoire"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"),
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Single, 0, "Pourcentage remise"),
            new System.Data.OleDb.OleDbParameter("Prix_achat_net", System.Data.OleDb.OleDbType.Double, 0, "Prix achat net"),
            new System.Data.OleDb.OleDbParameter("Prix_de_vente", System.Data.OleDb.OleDbType.Double, 0, "Prix de vente"),
            new System.Data.OleDb.OleDbParameter("Quantite", System.Data.OleDb.OleDbType.Integer, 0, "Quantite"),
            new System.Data.OleDb.OleDbParameter("Total_ligne", System.Data.OleDb.OleDbType.Double, 0, "Total ligne")});
            // 
            // oleDbSelectCommand11
            // 
            this.oleDbSelectCommand11.CommandText = "SELECT Cause, [Code piece], [Code piece provisoire], Designation, idLigne, [N° De" +
    "vis], [Pourcentage remise], [Prix achat net], [Prix de vente], Quantite, [Total " +
    "ligne] FROM t_devis_lignes";
            this.oleDbSelectCommand11.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand11
            // 
            this.oleDbUpdateCommand11.CommandText = resources.GetString("oleDbUpdateCommand11.CommandText");
            this.oleDbUpdateCommand11.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand11.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Cause", System.Data.OleDb.OleDbType.Integer, 0, "Cause"),
            new System.Data.OleDb.OleDbParameter("Code_piece", System.Data.OleDb.OleDbType.Integer, 0, "Code piece"),
            new System.Data.OleDb.OleDbParameter("Code_piece_provisoire", System.Data.OleDb.OleDbType.VarWChar, 50, "Code piece provisoire"),
            new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"),
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("Pourcentage_remise", System.Data.OleDb.OleDbType.Single, 0, "Pourcentage remise"),
            new System.Data.OleDb.OleDbParameter("Prix_achat_net", System.Data.OleDb.OleDbType.Double, 0, "Prix achat net"),
            new System.Data.OleDb.OleDbParameter("Prix_de_vente", System.Data.OleDb.OleDbType.Double, 0, "Prix de vente"),
            new System.Data.OleDb.OleDbParameter("Quantite", System.Data.OleDb.OleDbType.Integer, 0, "Quantite"),
            new System.Data.OleDb.OleDbParameter("Total_ligne", System.Data.OleDb.OleDbType.Double, 0, "Total ligne"),
            new System.Data.OleDb.OleDbParameter("Original_idLigne", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idLigne", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_piece", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_piece1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code piece", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_piece_provisoire", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code piece provisoire", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_piece_provisoire1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code piece provisoire", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Pourcentage_remise1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pourcentage remise", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_achat_net", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix achat net", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_achat_net1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix achat net", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_de_vente", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix de vente", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_de_vente1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix de vente", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantite1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_ligne", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total ligne", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_ligne1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total ligne", System.Data.DataRowVersion.Original, null)});
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.Enabled = false;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Location = new System.Drawing.Point(740, 772);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(60, 30);
            this.button18.TabIndex = 15;
            this.button18.TabStop = false;
            this.button18.Text = "Ok";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.Enabled = false;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(1052, 772);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 30);
            this.button19.TabIndex = 16;
            this.button19.TabStop = false;
            this.button19.Text = "Ok";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // mtgcComboBox12
            // 
            this.mtgcComboBox12.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox12.ColumnNum = 1;
            this.mtgcComboBox12.ColumnWidth = "121";
            this.mtgcComboBox12.DisplayMember = "Text";
            this.mtgcComboBox12.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox12.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox12.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox12.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox12.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox12.DropDownWidth = 141;
            this.mtgcComboBox12.Enabled = false;
            this.mtgcComboBox12.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox12.GridLineHorizontal = false;
            this.mtgcComboBox12.GridLineVertical = false;
            this.mtgcComboBox12.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox12.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox12.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox12.Location = new System.Drawing.Point(386, 772);
            this.mtgcComboBox12.ManagingFastMouseMoving = true;
            this.mtgcComboBox12.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox12.Name = "mtgcComboBox12";
            this.mtgcComboBox12.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox12.Size = new System.Drawing.Size(216, 27);
            this.mtgcComboBox12.TabIndex = 17;
            this.mtgcComboBox12.TabStop = false;
            // 
            // label63
            // 
            this.label63.Location = new System.Drawing.Point(386, 748);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(150, 24);
            this.label63.TabIndex = 18;
            this.label63.Text = "Export";
            // 
            // mtgcComboBox13
            // 
            this.mtgcComboBox13.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox13.ColumnNum = 1;
            this.mtgcComboBox13.ColumnWidth = "121";
            this.mtgcComboBox13.DisplayMember = "Text";
            this.mtgcComboBox13.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox13.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox13.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox13.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox13.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox13.DropDownWidth = 141;
            this.mtgcComboBox13.Enabled = false;
            this.mtgcComboBox13.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox13.GridLineHorizontal = false;
            this.mtgcComboBox13.GridLineVertical = false;
            this.mtgcComboBox13.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox13.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox13.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox13.Location = new System.Drawing.Point(820, 772);
            this.mtgcComboBox13.ManagingFastMouseMoving = true;
            this.mtgcComboBox13.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox13.Name = "mtgcComboBox13";
            this.mtgcComboBox13.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox13.Size = new System.Drawing.Size(216, 27);
            this.mtgcComboBox13.TabIndex = 19;
            this.mtgcComboBox13.TabStop = false;
            // 
            // label64
            // 
            this.label64.Location = new System.Drawing.Point(820, 748);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(150, 24);
            this.label64.TabIndex = 20;
            this.label64.Text = "Import";
            // 
            // txDateEdit
            // 
            this.txDateEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDateEdit.Location = new System.Drawing.Point(615, 772);
            this.txDateEdit.Name = "txDateEdit";
            this.txDateEdit.Size = new System.Drawing.Size(108, 26);
            this.txDateEdit.TabIndex = 21;
            this.txDateEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txDateEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDateEdit_KeyDown);
            // 
            // label65
            // 
            this.label65.Location = new System.Drawing.Point(610, 748);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(150, 24);
            this.label65.TabIndex = 22;
            this.label65.Text = "Date édition";
            // 
            // DetailDevis
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 19);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1374, 822);
            this.ControlBox = false;
            this.Controls.Add(this.label65);
            this.Controls.Add(this.txDateEdit);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.mtgcComboBox13);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.mtgcComboBox12);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControlEX1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txEtat);
            this.Controls.Add(this.txDate);
            this.Controls.Add(this.txNumDevis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DetailDevis";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détail du devis";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControlEX1.ResumeLayout(false);
            this.tabPageEX1.ResumeLayout(false);
            this.tabPageEX2.ResumeLayout(false);
            this.tabPageEX2.PerformLayout();
            this.tabPageEX3.ResumeLayout(false);
            this.tabPageEX3.PerformLayout();
            this.tabPageEX4.ResumeLayout(false);
            this.tabPageEX4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			if(textBox2.TextLength>0)
			{
				try
				{
					string Pourcent = numericUpDown2.Value.ToString();
					Decimal Pourc = System.Convert.ToDecimal(Pourcent);
					Pourc/=100;
					Decimal Reduc = System.Convert.ToDecimal(textBox3.Text);
					Reduc *=Pourc;
					if(numericUpDown1.Value>0)
					{
						Decimal Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
						txNetCommande.Text=Prix.ToString("0.00");
						Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc);
						textBox5.Text=Prix.ToString("0.00");
					}
					else
					{
						Decimal Prix = (System.Convert.ToDecimal(textBox3.Text))*System.Convert.ToInt32(numericUpDown1.Value);
						txNetCommande.Text=Prix.ToString("0.00");
						Prix = (System.Convert.ToDecimal(textBox3.Text));
						textBox5.Text=Prix.ToString("0.00");
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
		{
			if(textBox2.TextLength>0)
			{
				try
				{
					string Pourcent = numericUpDown2.Value.ToString();
					Decimal Pourc = System.Convert.ToDecimal(Pourcent);
					Pourc/=100;
					Decimal Reduc = System.Convert.ToDecimal(textBox3.Text);
					Reduc *=Pourc;
					Decimal Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
					txNetCommande.Text=Prix.ToString("0.00");
					Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc);
					textBox5.Text=Prix.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				
			}
		}

		private void numericUpDown1_Leave(object sender, System.EventArgs e)
		{
			if(textBox2.TextLength>0)
			{
				try
				{
					string Pourcent = numericUpDown2.Value.ToString();
					Decimal Pourc = System.Convert.ToDecimal(Pourcent);
					Pourc/=100;
					Decimal Reduc = System.Convert.ToDecimal(textBox3.Text);
					Reduc *=Pourc;
					if(numericUpDown1.Value>0)
					{
						Decimal Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
						txNetCommande.Text=Prix.ToString("0.00");
						Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc);
						textBox5.Text=Prix.ToString("0.00");
					}
					else
					{
						Decimal Prix = (System.Convert.ToDecimal(textBox3.Text))*System.Convert.ToInt32(numericUpDown1.Value);
						txNetCommande.Text=Prix.ToString("0.00");
						Prix = (System.Convert.ToDecimal(textBox3.Text));
						textBox5.Text=Prix.ToString("0.00");
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				
			}
		}

		private void numericUpDown2_Leave(object sender, System.EventArgs e)
		{
			if(textBox2.TextLength>0)
			{
				try
				{
					string Pourcent = numericUpDown2.Value.ToString();
					Decimal Pourc = System.Convert.ToDecimal(Pourcent);
					Pourc/=100;
					Decimal Reduc = System.Convert.ToDecimal(textBox3.Text);
					Reduc *=Pourc;
					Decimal Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
					txNetCommande.Text=Prix.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
			else
				MessageBox.Show("Choisissez un pièce");
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			
		}

		private void listView1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button13_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Supprimer la ligne ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
			{
				dataSet11.Tables["t_devis_lignes"].Clear();
				dataSet11.Tables["t_pieces_detachees"].Clear();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="select * from t_devis_lignes where [N° devis]="+txNumDevis.Text+" and [Code piece]="+listView1.Items[listView1.SelectedIndices[0]].SubItems[6].Text+" and Quantite="+listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
				oleDbDataAdapter11.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter11.Fill(dataSet11,"t_devis_lignes");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.CommandText="delete from t_devis_lignes where [idligne]="+dataSet11.Tables["t_devis_lignes"].Rows[0]["idligne"].ToString();
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(Exception excp)
					{
						try
						{
							Transac.Rollback();
							Console.WriteLine(excp.Message);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
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
			listView1.Items.Clear();
			dataSet11.Tables["t_devis_lignes"].Clear();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="Select * from t_devis_lignes where [N° Devis]="+System.Convert.ToInt32(txNumDevis.Text);
			oleDbDataAdapter11.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter11.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			foreach(DataRow Lignes in dataSet11.Tables["t_devis_lignes"].Rows)
			{
				dataSet11.Tables["t_pieces_detachees"].Clear();
				Comm.CommandText="select * from t_pieces_detachees where [Identificateur]="+Lignes["Code piece"].ToString();
				oleDbDataAdapter9.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				listView1.Items.Add(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Lignes["Designation"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Lignes["Quantite"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Lignes["Prix de vente"].ToString());
				try
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(Lignes["Total ligne"].ToString()).ToString("0.00"));
				}
				catch(Exception exp)
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add("0.00");
					Console.WriteLine(exp.Message);
				}
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Lignes["Cause"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Lignes["Code piece"].ToString());
			}
			Decimal Total=0;
			for(int i=0;i<listView1.Items.Count;i++)
			{
				Total+=System.Convert.ToDecimal(listView1.Items[i].SubItems[4].Text.Trim(' ','€'));
			}
			textBox34.Text=Total.ToString("0.00");
			textBox19.Text=Total.ToString("0.00");
			textBox7.Text=Total.ToString("0.00");
		}

		private void tabPage3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			decimal Total=0;
			for(int i=0;i<listView1.Items.Count;i++)
			{
				Total=Total+System.Convert.ToDecimal(listView1.Items[i].SubItems[8].Text.Trim('€',' '));
			}
			textBox7.Text=Total.ToString();
			textBox19.Text=Total.ToString();
		}

		private void numericUpDown2_Enter(object sender, System.EventArgs e)
		{
			numericUpDown2.Select(0,numericUpDown2.Value.ToString().Length);
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked)
			{
				textBox19.Text=textBox7.Text;
				textBox20.Text=textBox31.Text;
				textBox21.Text=textBox32.Text;
				textBox22.Text=textBox33.Text;
				textBox19.ReadOnly=true;
				textBox20.ReadOnly=true;
				textBox21.ReadOnly=true;
				textBox22.ReadOnly=true;
				Decimal TotalAuto=0;
				TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
				textBox24.Text=TotalAuto.ToString("0.00");
			}
			else
			{
                if (Table.Rows[0]["DNRDEVIS"].ToString().Length > 0)
                    textBox20.Text = System.Convert.ToDecimal(Table.Rows[0]["DNRDEVIS"].ToString()).ToString("0.00");
				else
					textBox20.Text="0,00";
				if(Table.Rows[0]["DevisForfaitControle"].ToString().Length>0)
					textBox21.Text=System.Convert.ToDecimal(Table.Rows[0]["DevisForfaitControle"].ToString()).ToString("0.00");
				else
					textBox21.Text="0,00";
				if(Table.Rows[0]["DevisForfaitTransport"].ToString().Length>0)
					textBox22.Text=System.Convert.ToDecimal(Table.Rows[0]["DevisForfaitTransport"].ToString()).ToString("0.00");
				else
					textBox22.Text="0,00";
				textBox19.Text=textBox7.Text;

				textBox19.ReadOnly=false;
				textBox20.ReadOnly=false;
				textBox21.ReadOnly=false;
				textBox22.ReadOnly=false;
				Decimal TotalAuto=0;
				TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
				textBox24.Text=TotalAuto.ToString("0.00");
				
			}
		}

		private void button6_Click_1(object sender, System.EventArgs e)
		{
			if(mtgcComboBox3.SelectedIndex>0)
			{
				Pieces WinPieces = new Pieces(Agence, mtgcComboBox3.Text);
				WinPieces.ShowDialog();
				this.Refresh();
				
				mtgcComboBox3.Items.Clear();
				dataSet11.Tables["t_pieces_detachees"].Clear();
				oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Identificateur,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 2"; 
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{
				}
				mtgcComboBox3.SourceDataString=new string[]{"code","designation","nom","Identificateur"};
				mtgcComboBox3.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];
				mtgcComboBox5.Items.Clear();
				mtgcComboBox9.Items.Clear();
				/*Comm.CommandText="SELECT T_pieces_detachees.Code,T_pieces_detachees.Code_1, T_pieces_detachees.Designation, T_fournisseurs.Nom,T_pieces_detachees.Identificateur FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(dataSet11,"pieces");
					mtgcComboBox3.SourceDataString=new string[]{"Code","Code_1","Designation","Nom"};
					mtgcComboBox3.SourceDataTable=dataSet11.Tables["pieces"];
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}*/

				oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Identificateur,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{
				}
				mtgcComboBox9.SourceDataString=new string[]{"Identificateur","code","designation","nom"};
				mtgcComboBox9.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];
				dataSet11.Tables["t_pieces_detachees"].Clear();

				if(mtgcComboBox3.Text.Length>0)
				{	
					mtgcComboBox9.Text="";
					mtgcComboBox9.SelectedIndex=-1;
					mtgcComboBox5.Text="";
					mtgcComboBox5.SelectedIndex=-1;
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select * from t_pieces_detachees where code='"+mtgcComboBox3.Text+"'";
					oleDbDataAdapter9.SelectCommand=Comm;
					oleDbDataAdapter9.Fill(dataSet11);
					textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox4.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox6.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
					textBox8.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["code_1"].ToString();
					textBox1.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
					string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString().Replace(".",",");
					decimal Prix = System.Convert.ToDecimal(Price);
					textBox3.Text=Prix.ToString("0.00");
					textBox5.Text=Prix.ToString("0.00");
					mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["code_1"].ToString());
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
					mtgcComboBox9.SelectedIndex=mtgcComboBox9.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString());
					try
					{
						if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString())>(0.00)))
						{
							string Pourcent = numericUpDown2.Value.ToString().Trim(',');
							string Rem = "1,"+Pourcent;
							decimal remise = System.Convert.ToDecimal(Rem);
							decimal nombre = numericUpDown1.Value;
							decimal PV = System.Convert.ToDecimal(textBox3.Text);
							decimal Total = PV*nombre*remise;
							txNetCommande.Text=Total.ToString("0.00");
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					button3.Enabled=true;
				}
				if(mtgcComboBox3.Text.Equals("******************"))
				{
					textBox9.Visible=true;
					textBox9.Focus();
					mtgcComboBox10.Visible=true;
					mtgcComboBox11.Visible=true;
					button16.Visible=true;
				}
			}
			else
			{
				Pieces WinPieces = new Pieces(Agence,"");
				WinPieces.ShowDialog();
				dataSet11.Tables["t_pieces_detachees"].Clear();
				mtgcComboBox3.Items.Clear();
				mtgcComboBox5.Items.Clear();
				mtgcComboBox9.Items.Clear();
				dataSet11.Tables["t_pieces_detachees"].Clear();
				oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Identificateur,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 2"; 
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{
				}
				mtgcComboBox3.SourceDataString=new string[]{"code","designation","nom","Identificateur"};
				mtgcComboBox3.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];

				oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Identificateur,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{
				}
				mtgcComboBox9.SourceDataString=new string[]{"Identificateur","code","designation","nom"};
				mtgcComboBox9.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];
			}
		}

		private void button5_Click_1(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void numericUpDown1_Enter(object sender, System.EventArgs e)
		{
			if(mtgcComboBox3.SelectedIndex>=0&&textBox3.TextLength.Equals(0))
			{
				mtgcComboBox9.SelectedIndex=-1;
				mtgcComboBox5.SelectedIndex=-1;
				dataSet11.Tables["t_pieces_detachees"].Clear();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="select * from t_pieces_detachees where code='"+mtgcComboBox3.Text+"'";
				oleDbDataAdapter9.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{

				}
				textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
				textBox4.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
				textBox6.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
				textBox1.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
                txPrixAchat.Text = dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat net"].ToString();
				try
				{
					string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString().Replace(".",",");
					decimal Prix = System.Convert.ToDecimal(Price);
					textBox3.Text=Prix.ToString("0.00");
					textBox5.Text=Prix.ToString("0.00");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}

				mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
				try
				{
					if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString())>(0.00)))
					{
						try
						{
							string Pourcent = numericUpDown2.Value.ToString().Trim(',');
							string Rem = "1,"+Pourcent;
							decimal remise = System.Convert.ToDecimal(Rem);
							decimal nombre = numericUpDown1.Value;
							decimal PV = System.Convert.ToDecimal(textBox3.Text);
							decimal Total = PV*nombre*remise;
							txNetCommande.Text=Total.ToString("0.00");
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
			else if(mtgcComboBox9.SelectedIndex>=0&&textBox3.TextLength.Equals(0))
			{
				mtgcComboBox5.SelectedIndex=-1;
				mtgcComboBox3.SelectedIndex=-1;
				dataSet11.Tables["t_pieces_detachees"].Clear();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="select * from t_pieces_detachees where identificateur="+mtgcComboBox9.Text;
				oleDbDataAdapter9.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
					textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox4.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox6.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
					textBox7.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
                    txPrixAchat.Text = dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat net"].ToString();
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
					try
					{
						string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString().Replace(".",",");
						decimal Prix = System.Convert.ToDecimal(Price);
						textBox3.Text=Prix.ToString("0.00");
						textBox5.Text=Prix.ToString("0.00");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
				catch(Exception exp)
				{

				}
				
				try
				{
					if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString())>(0.00)))
					{
						try
						{
							string Pourcent = numericUpDown2.Value.ToString().Trim(',');
							string Rem = "1,"+Pourcent;
							decimal remise = System.Convert.ToDecimal(Rem);
							decimal nombre = numericUpDown1.Value;
							decimal PV = System.Convert.ToDecimal(textBox3.Text);
							decimal Total = PV*nombre*remise;
							txNetCommande.Text=Total.ToString("0.00");
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
			else if(mtgcComboBox5.SelectedIndex>=0&&textBox3.TextLength.Equals(0))
			{
				if(mtgcComboBox5.SelectedIndex>=0)
				{
					mtgcComboBox3.SelectedIndex=-1;
					mtgcComboBox9.SelectedIndex=-1;
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select * from t_pieces_detachees where code_1='"+mtgcComboBox9.Text+"'";
					oleDbDataAdapter9.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter9.Fill(dataSet11);
						textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
						textBox4.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
						textBox6.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
                        txPrixAchat.Text = dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat net"].ToString();
						string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString().Replace(".",",");
						decimal Prix = System.Convert.ToDecimal(Price);
						textBox3.Text=Prix.ToString("0.00");
						textBox5.Text=Prix.ToString("0.00");
						mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
					}
					catch(Exception exp)
					{

					}
					try
					{
						if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString())>(0.00)))
						{
							try
							{
								string Pourcent = numericUpDown2.Value.ToString().Trim(',');
								string Rem = "1,"+Pourcent;
								decimal remise = System.Convert.ToDecimal(Rem);
								decimal nombre = numericUpDown1.Value;
								decimal PV = System.Convert.ToDecimal(textBox3.Text);
								decimal Total = PV*nombre*remise;
								txNetCommande.Text=Total.ToString("0.00");
							}
							catch(Exception exp)
							{
								MessageBox.Show(exp.Message);
							}
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
			numericUpDown1.Select(0,numericUpDown1.Value.ToString().Length);
		}

		private void mtgcComboBox5_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox5.SelectedIndex>=0)
			{
				
			}
		}

		private void textBox19_TextChanged(object sender, System.EventArgs e)
		{
			if(textBox19.TextLength>0)
			{
				try
				{
					if(!debut)
					{
						Decimal TotalAuto=0;
						TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
						textBox24.Text=TotalAuto.ToString("0.00");
						if(textBox20.TextLength.Equals(0))
						{
							if(textBox12.Text.Length>0)
								textBox20.Text=textBox12.Text;
							if(textBox11.Text.Length>0&&System.Convert.ToDecimal(textBox11.Text)>0)
							{
								Decimal DNR=System.Convert.ToDecimal(textBox12.Text);
								Decimal P=System.Convert.ToDecimal(textBox11.Text);
								Decimal Res=DNR*P;
								textBox20.Text=Res.ToString();
							}
						}
					}
				}
				catch(Exception exp)
				{
					
				}
			}
		}

		private void textBox20_TextChanged(object sender, System.EventArgs e)
		{
			if(textBox20.TextLength>0)
			{
				try
				{
					if(!debut)
					{
						Decimal TotalAuto=0;
						TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
						textBox24.Text=TotalAuto.ToString("0.00");
					}
				}
				catch(Exception exp)
				{
					
				}
			}
		}

		private void textBox21_TextChanged(object sender, System.EventArgs e)
		{
			if(textBox21.TextLength>0)
			{
				try
				{
					if(!debut)
					{
						Decimal TotalAuto=0;
						TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
						textBox24.Text=TotalAuto.ToString("0.00");
					}
				}
				catch(Exception exp)
				{
					
				}

			}
		}

		private void textBox22_TextChanged(object sender, System.EventArgs e)
		{
			if(textBox22.TextLength>0)
			{
				try
				{
					if(!debut)
					{
						Decimal TotalAuto=0;
						TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
						TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
						textBox24.Text=TotalAuto.ToString("0.00");
					}
				}
				catch(Exception exp)
				{
					
				}
			}
		}

		private void textBox24_TextChanged(object sender, System.EventArgs e)
		{
			if(textBox24.TextLength>0)
			{
				textBox24.Text=textBox24.Text;
			}
			if(System.Convert.ToDecimal(textBox24.Text.Replace(".",","))>0&&System.Convert.ToDecimal(textBox28.Text.Replace(".",","))>0)
			{
				if(System.Convert.ToDecimal(textBox24.Text.Replace(".",","))!=0&&System.Convert.ToDecimal(textBox28.Text.Replace(".",","))!=0)
				{
					Decimal Limite=(System.Convert.ToDecimal(textBox24.Text.Replace(".",","))/System.Convert.ToDecimal(textBox28.Text.Replace(".",",")))*100;
					textBox30.Text=Limite.ToString("0.00");
				}
			}
			else
				textBox30.Text="0.00";
			txTotalDevis.Text=textBox24.Text;
		}

		private void textBox19_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				textBox19.Text=System.Convert.ToDecimal(textBox19.Text.Replace('.',',')).ToString("0.00");
				if(!debut)
				{
					Decimal TotalAuto=0;
					TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
					textBox24.Text=TotalAuto.ToString("0.00");
				}
			}
		}

		private void textBox19_Leave(object sender, System.EventArgs e)
		{
			textBox19.Text=System.Convert.ToDecimal(textBox19.Text.Replace('.',',')).ToString("0.00");
			if(!debut)
			{
				Decimal TotalAuto=0;
				TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
				textBox24.Text=TotalAuto.ToString("0.00");
			}
		}

		private void textBox20_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				textBox20.Text=System.Convert.ToDecimal(textBox20.Text.Replace('.',',')).ToString("0.00");
				if(!debut)
				{
					Decimal TotalAuto=0;
					TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
					textBox24.Text=TotalAuto.ToString("0.00");
				}
			}
		}

		private void textBox20_Leave(object sender, System.EventArgs e)
		{
			textBox20.Text=System.Convert.ToDecimal(textBox20.Text.Replace('.',',')).ToString("0.00");
			if(!debut)
			{
				Decimal TotalAuto=0;
				TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
				textBox24.Text=TotalAuto.ToString("0.00");
			}
		}

		private void textBox21_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				textBox21.Text=System.Convert.ToDecimal(textBox21.Text.Replace('.',',')).ToString("0.00");
				if(!debut)
				{
					Decimal TotalAuto=0;
					TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
					textBox24.Text=TotalAuto.ToString("0.00");
				}
			}
		}

		private void textBox21_Leave(object sender, System.EventArgs e)
		{
			textBox21.Text=System.Convert.ToDecimal(textBox21.Text.Replace('.',',')).ToString("0.00");
			if(!debut)
			{
				Decimal TotalAuto=0;
				TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
				textBox24.Text=TotalAuto.ToString("0.00");
			}
		}

		private void textBox22_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				textBox22.Text=System.Convert.ToDecimal(textBox22.Text.Replace('.',',')).ToString("0.00");
				if(!debut)
				{
					Decimal TotalAuto=0;
					TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
					TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
					textBox24.Text=TotalAuto.ToString("0.00");
				}
			}
		}

		private void textBox22_Leave(object sender, System.EventArgs e)
		{
			textBox22.Text=System.Convert.ToDecimal(textBox22.Text.Replace('.',',')).ToString("0.00");
			if(!debut)
			{
				Decimal TotalAuto=0;
				TotalAuto+=System.Convert.ToDecimal(textBox19.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox20.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox21.Text);
				TotalAuto+=System.Convert.ToDecimal(textBox22.Text);
				textBox24.Text=TotalAuto.ToString("0.00");
			}
		}

		private void btSave_Click(object sender, System.EventArgs e)
		{
			Save(true);
		}

		private void Save(bool Save)
		{
			int Type=0;
			if(radioButton1.Checked)
				Type=1;
			else if(radioButton2.Checked)
				Type=2;
			else if(radioButton3.Checked)
				Type=3;
				
			if(txRemCauseAtelier.TextLength.Equals(0))
				txRemCauseAtelier.Text="?";
			if(txRemCauseClient.TextLength.Equals(0))
				txRemCauseClient.Text="?";
			if(mtgcComboBox8.Text.Length.Equals(0))
				mtgcComboBox8.Text="BOITE";
			oleDbConnection1.Open();
			Transac=oleDbConnection1.BeginTransaction();
			bool CalculAuto=true;
			if(checkBox1.Checked.Equals(false))
				CalculAuto=false;
			if(txBL.TextLength.Equals(0))
				txBL.Text="0";
			if(listView1.Items.Count>0)
			{
				Comm.Connection=oleDbConnection1;
				
				if(mtgcComboBox1.Text.Length>0)
                    Comm.CommandText = "update t_devis_entete set [type devis]=" + Type.ToString() + ", [cause client]=" + mtgcComboBox6.Text + ", [cause atelier]=" + mtgcComboBox7.Text + ",[detail client]='" + txRemCauseClient.Text + "', [detail atelier]='" + txRemCauseAtelier.Text + "', emplacement='" + mtgcComboBox8.Text + "', [ordre travail]='" + txOrdre.Text + "', [N° commande ouverte]='" + txCommande.Text + "', [reparateur_d]='" + mtgcComboBox1.Text + "', [N° bl]=" + txBL.Text + ",[N° troncon]='" + txTroncon.Text + "', [imputation comptable]='" + txComptable.Text + "', [total devis]=" + txTotalDevis.Text.Replace(",", ".").Trim('€') + ", [calcul auto]=" + CalculAuto.ToString() + ", [forfait controle]=" + textBox21.Text.Replace(",", ".") + ", [forfait transport]=" + textBox22.Text.Replace(",", ".") + ", [forfait DNR]=" + textBox20.Text.Replace(",", ".") + ", [DNR machine]=" + textBox12.Text.Replace(",", ".") + ", [Total pieces]=" + textBox7.Text.Replace(",", ".") + " where [n° devis]=" + txNumDevis.Text;
				else
                    Comm.CommandText = "update t_devis_entete set [type devis]=" + Type.ToString() + ", [cause client]=" + mtgcComboBox6.Text + ", [cause atelier]=" + mtgcComboBox7.Text + ",[detail client]='" + txRemCauseClient.Text + "', [detail atelier]='" + txRemCauseAtelier.Text + "', emplacement='" + mtgcComboBox8.Text + "', [ordre travail]='" + txOrdre.Text + "', [N° commande ouverte]='" + txCommande.Text + "', [N° bl]=" + txBL.Text + ",[N° troncon]='" + txTroncon.Text + "', [imputation comptable]='" + txComptable.Text + "', [total devis]=" + txTotalDevis.Text.Replace(",", ".").Trim('€') + ", [calcul auto]=" + CalculAuto.ToString() + ", [forfait controle]=" + textBox21.Text.Replace(",", ".") + ", [forfait transport]=" + textBox22.Text.Replace(",", ".") + ", [forfait DNR]=" + textBox20.Text.Replace(",", ".") + ", [DNR machine]=" + textBox12.Text.Replace(",", ".") + ", [Total pieces]=" + textBox7.Text.Replace(",", ".") + " where [n° devis]=" + txNumDevis.Text;
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
						if(Save)
							MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
						dataSet11.Tables["T_devis_entete"].Clear();
						string RequeteDevis="SELECT T_devis_entete.[N° Devis],T_devis_entete.[Calcul auto],T_devis_entete.[Forfait controle],T_devis_entete.[Forfait transport], T_devis_entete.Date, T_devis_entete.[Code Materiel], T_devis_entete.[Forfait DNR], T_parc_machine.[No serie], T_parc_machine.[Type machine], T_parc_machine.[Code Client], T_parc_machine.[En reparation], T_fournisseurs.Nom, T_parc_machine.[Code Mabec], T_clients.Nom, T_devis_entete.[Type devis], T_devis_entete.[Cause client], T_devis_entete.[Detail Client], T_devis_entete.[Cause atelier], T_devis_entete.[Detail atelier], T_devis_entete.[N° Troncon], T_devis_entete.[Ordre Travail], T_devis_entete.[Imputation comptable], T_devis_entete.[N° Commande ouverte], T_devis_entete.Niveau, T_devis_entete.Edite, T_devis_entete.[Accord Client], T_devis_entete.Refus, T_devis_entete.Reforme, T_devis_entete.Reparateur_D, T_devis_entete.Reparateur_R, T_devis_entete.Comment, T_devis_entete.[n° Bl], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_famille_machine.Designation, T_devis_entete.Emplacement, T_clients.Forfait_DNR, T_clients.Coef_DNR, T_clients.Forfait_Controle, T_clients.Coef_Controle, T_clients.Forfait_transport, T_clients.Coef_transport, T_clients.Seuil_reparation, T_parc_machine.[Prix Achat], T_parc_machine.[Prix remplacement], T_type_machine.[Forfait DNR], T_type_machine.[Forfait Transport], T_type_machine.[Forfait controle], T_type_machine.[Prix catalogue] FROM (T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[N° Devis])="+txNumDevis.Text+"))";
						Comm.Connection=oleDbConnection1;
						Comm.CommandText=RequeteDevis;
						oleDbDataAdapter1.SelectCommand=Comm;
						try
						{
							oleDbDataAdapter1.Fill(dataSet11);
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
					}
					catch(Exception exp)
					{
						try
						{
							Transac.Rollback();
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
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
				if(mtgcComboBox1.Text.Length>0)
                    Comm.CommandText = "update t_devis_entete set [type devis]=" + Type.ToString() + ", [cause client]=" + mtgcComboBox6.Text + ", [cause atelier]=" + mtgcComboBox7.Text + ",[detail client]='" + txRemCauseClient.Text + "', [detail atelier]='" + txRemCauseClient.Text + "', emplacement='" + mtgcComboBox8.Text + "', [ordre travail]='" + txOrdre.Text + "', [N° commande ouverte]='" + txCommande.Text + "', [reparateur_d]='" + mtgcComboBox1.Text + "',[N° troncon]='" + txTroncon.Text + "', [imputation comptable]='" + txComptable.Text + "', [DNR machine]=" + textBox12.Text.Replace(",", ".") + " where [n° devis]=" + txNumDevis.Text;
				else
					Comm.CommandText="update t_devis_entete set [type devis]="+Type.ToString()+", [cause client]="+mtgcComboBox6.Text+", [cause atelier]="+mtgcComboBox7.Text+",[detail client]='"+txRemCauseClient.Text+"', [detail atelier]='"+txRemCauseClient.Text+"', emplacement='"+mtgcComboBox8.Text+"', [ordre travail]='"+txOrdre.Text+"', [N° commande ouverte]='"+txCommande.Text+"', [N° troncon]='"+txTroncon.Text+"', [imputation comptable]='"+txComptable.Text+"' where [n° devis]="+txNumDevis.Text;
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
						if(Save)
							MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
						dataSet11.Tables["T_devis_entete"].Clear();
						string RequeteDevis="SELECT T_devis_entete.[N° Devis],T_devis_entete.[Calcul auto],T_devis_entete.[Forfait controle],T_devis_entete.[Forfait transport], T_devis_entete.Date, T_devis_entete.[Code Materiel], T_devis_entete.[Forfait DNR], T_parc_machine.[No serie], T_parc_machine.[Type machine], T_parc_machine.[Code Client], T_parc_machine.[En reparation], T_fournisseurs.Nom, T_parc_machine.[Code Mabec], T_clients.Nom, T_devis_entete.[Type devis], T_devis_entete.[Cause client], T_devis_entete.[Detail Client], T_devis_entete.[Cause atelier], T_devis_entete.[Detail atelier], T_devis_entete.[N° Troncon], T_devis_entete.[Ordre Travail], T_devis_entete.[Imputation comptable], T_devis_entete.[N° Commande ouverte], T_devis_entete.Niveau, T_devis_entete.Edite, T_devis_entete.[Accord Client], T_devis_entete.Refus, T_devis_entete.Reforme, T_devis_entete.Reparateur_D, T_devis_entete.Reparateur_R, T_devis_entete.Comment, T_devis_entete.[n° Bl], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_famille_machine.Designation, T_devis_entete.Emplacement, T_clients.Forfait_DNR, T_clients.Coef_DNR, T_clients.Forfait_Controle, T_clients.Coef_Controle, T_clients.Forfait_transport, T_clients.Coef_transport, T_clients.Seuil_reparation, T_parc_machine.[Prix Achat], T_parc_machine.[Prix remplacement], T_type_machine.[Forfait DNR], T_type_machine.[Forfait Transport], T_type_machine.[Forfait controle], T_type_machine.[Prix catalogue] FROM (T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[N° Devis])="+txNumDevis.Text+"))";
						Comm.Connection=oleDbConnection1;
						Comm.CommandText=RequeteDevis;
						oleDbDataAdapter1.SelectCommand=Comm;
						try
						{
							oleDbDataAdapter1.Fill(dataSet11);
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
					}
					catch(Exception exp)
					{
						try
						{
							Transac.Rollback();
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
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

		private void button4_Click(object sender, System.EventArgs e)
		{
			Page=0;
			countRow=0;
			bool Ok=true;
			if(mtgcComboBox8.Text.Length.Equals(0))
				mtgcComboBox8.Text="BOITE";
			if(mtgcComboBox1.SelectedIndex.Equals(0))
			{
				MessageBox.Show("Veuillez choisir un démonteur SVP");
				Ok=false;
			}
			if(listView1.Items.Count.Equals(0))
			{
				MessageBox.Show("Le devis doit contenir au moins une ligne");
				Ok=false;
			}
			if(Ok)
			{
				Comm.Connection=oleDbConnection1;
				int Type=0;
				if(radioButton1.Checked.Equals(true))
					Type=1;
				else if(radioButton2.Checked.Equals(true))
					Type=2;
				else if(radioButton3.Checked.Equals(true))
					Type=3;
				if(txRemCauseAtelier.TextLength.Equals(0))
					txRemCauseAtelier.Text="?";
				if(txRemCauseClient.TextLength.Equals(0))
					txRemCauseClient.Text="?";
				if(txBL.TextLength.Equals(0))
					txBL.Text="0";
				bool CalculAuto=true;
				if(checkBox1.Checked.Equals(false))
					CalculAuto=false;
				oleDbConnection1.Open();
				Comm.CommandText="select niveau from t_devis_entete where [N° devis]="+txNumDevis.Text;
				int Niveau=(int)Comm.ExecuteScalar();
				oleDbConnection1.Close();
				if(Niveau.Equals(2))
				{
					Decimal Seuil=0;
					try
					{
						Seuil=System.Convert.ToDecimal(textBox30.Text.Replace(".",","))/100;
					}
					catch(Exception exp)
					{
					}
					oleDbConnection1.Open();
					Transac=oleDbConnection1.BeginTransaction();
					
					Comm.CommandText="update t_devis_entete set [type devis]="+Type.ToString()+",[date entree reelle]='"+DateTime.Now.ToShortDateString()+"', [Niveau]=3, [DNR machine]=" + textBox12.Text.Replace(",", ".")+",[Edite]=true, [cause client]="+mtgcComboBox6.Text+", [cause atelier]="+mtgcComboBox7.Text+",[detail client]='"+txRemCauseClient.Text+"', [detail atelier]='"+txRemCauseClient.Text+"', emplacement='"+mtgcComboBox8.Text+"', [ordre travail]='"+txOrdre.Text+"', [N° commande ouverte]='"+txCommande.Text+"', [reparateur_d]='"+mtgcComboBox1.Text+"', [N° bl]="+txBL.Text+",[N° troncon]='"+txTroncon.Text+"', [imputation comptable]='"+txComptable.Text+"', [total devis]="+txTotalDevis.Text.Replace(",",".")+", [calcul auto]="+CalculAuto.ToString()+", [forfait controle]="+textBox21.Text.Replace(",",".")+", [forfait transport]="+textBox22.Text.Replace(",",".")+", [forfait DNR]="+textBox20.Text.Replace(",",".")+", [Total pieces]="+textBox7.Text.Replace(",",".")+" where [n° devis]="+txNumDevis.Text;
					Comm.Transaction=Transac;
					try
					{
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							txEtat.Text="Matériel en attente accord client";
							button7.Enabled=true;
							button8.Enabled=true;
							button9.Enabled=true;
							button10.Enabled=true;
							MessageBox.Show("Mise à jour terminée");
							mtgcComboBox12.Enabled=true;
							button18.Enabled=true;
						}
						catch(OleDbException excp)
						{
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
					Decimal Seuil=0;
					try
					{
						Seuil=System.Convert.ToDecimal(textBox30.Text.Replace(".",","))/100;
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					oleDbConnection1.Open();
					Transac=oleDbConnection1.BeginTransaction();
					Comm.CommandText="update t_devis_entete set [reparateur_d]='"+mtgcComboBox1.Text+"', [limite devis]="+Seuil.ToString().Replace(",",".")+", [total devis]="+txTotalDevis.Text.Replace(",",".")+", [calcul auto]="+CalculAuto.ToString()+", [forfait controle]="+textBox21.Text.Replace(",",".")+", [forfait transport]="+textBox22.Text.Replace(",",".")+", [forfait DNR]="+textBox20.Text.Replace(",",".")+", [Total pieces]="+textBox7.Text.Replace(",",".")+" where [n° devis]="+txNumDevis.Text;
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
				dataSet11.Tables["t_devis_lignes"].Clear();
				Comm.CommandText="SELECT T_devis_entete.[N° Devis],T_devis_entete.[Forfait transport], T_devis_entete.[Forfait controle], T_devis_entete.[Forfait DNR], T_devis_lignes.[Code piece], T_devis_lignes.Designation, T_devis_lignes.Quantite, T_devis_lignes.[Prix de vente], T_devis_lignes.[Total ligne], T_devis_lignes.Cause, T_devis_entete.[Ordre Travail], T_devis_entete.[N° Commande ouverte], T_devis_entete.Date, T_clients.Nom, T_clients.Adresse_1, T_clients.Adresse_2, T_clients.Code_Postal, T_clients.Ville, T_clients.Pays, T_parc_machine.[Code machine Opindus], T_parc_machine.[Code machine client], T_parc_machine.[Code Mabec], T_type_machine.Code, T_fournisseurs.Nom, T_famille_machine.Designation, T_pieces_detachees.Code, T_pieces_detachees.Designation, T_parc_machine.[Prix Achat], T_type_machine.[Prix catalogue], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Detail client], T_devis_entete.[Detail atelier], T_clients.Forfait_DNR, T_clients.Forfait_Controle, T_clients.Forfait_transport, T_type_machine.[Forfait DNR], T_type_machine.[Forfait Transport], T_type_machine.[Forfait controle], T_clients.Seuil_reparation FROM T_pieces_detachees INNER JOIN (T_famille_machine INNER JOIN (T_fournisseurs INNER JOIN (T_type_machine INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece] WHERE (((T_devis_entete.[N° Devis])="+txNumDevis.Text+"))"; 
				Comm.Connection=oleDbConnection1;
				OleDbDataAdapter DataAD = new OleDbDataAdapter();
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(dataSet11,"T_devis_lignes");
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				
				dataSet11.Tables["t_devis_entete"].Clear();
				Comm.CommandText="SELECT Sum(T_devis_entete.[Total devis]) AS [SommeDeTotal devis], T_devis_entete.[Code Materiel], Min(T_devis_entete.[Date reparation]) AS [MinDeDate reparation] FROM T_devis_entete GROUP BY T_devis_entete.Niveau, T_devis_entete.[Code Materiel] HAVING (((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Code Materiel])='"+txCodeOpindus.Text+"'))";
				try
				{
					DataAD.Fill(dataSet11,"T_devis_entete");
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				dataSet11.Tables["t_avancement"].Clear();
				Comm.CommandText="select * from t_avancement order by id";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(dataSet11,"t_avancement");
				txEtat.Text=dataSet11.Tables["t_avancement"].Rows[2]["Libelle"].ToString();
				printDocument1.DefaultPageSettings.Landscape=false;
				printDocument1.DefaultPageSettings.Margins.Bottom=50;
				printDocument1.DefaultPageSettings.Margins.Left=50;
				printDocument1.DefaultPageSettings.Margins.Right=50;
				printDocument1.Print();
				OleDbCommand RequeteDev = new OleDbCommand();
				dataSet11.Tables["T_devis_entete"].Clear();
				string RequeteDevis="SELECT T_devis_entete.[N° Devis],T_devis_entete.[Calcul auto],T_devis_entete.[Forfait controle],T_devis_entete.[Forfait transport], T_devis_entete.Date, T_devis_entete.[Code Materiel], T_devis_entete.[Forfait DNR], T_parc_machine.[No serie], T_parc_machine.[Type machine], T_parc_machine.[Code Client], T_parc_machine.[En reparation], T_fournisseurs.Nom, T_parc_machine.[Code Mabec], T_clients.Nom, T_devis_entete.[Type devis], T_devis_entete.[Cause client], T_devis_entete.[Detail Client], T_devis_entete.[Cause atelier], T_devis_entete.[Detail atelier], T_devis_entete.[N° Troncon], T_devis_entete.[Ordre Travail], T_devis_entete.[Imputation comptable], T_devis_entete.[N° Commande ouverte], T_devis_entete.Niveau, T_devis_entete.Edite, T_devis_entete.[Accord Client], T_devis_entete.Refus, T_devis_entete.Reforme, T_devis_entete.Reparateur_D, T_devis_entete.Reparateur_R, T_devis_entete.Comment, T_devis_entete.[n° Bl], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_famille_machine.Designation, T_devis_entete.Emplacement, T_clients.Forfait_DNR, T_clients.Coef_DNR, T_clients.Forfait_Controle, T_clients.Coef_Controle, T_clients.Forfait_transport, T_clients.Coef_transport, T_clients.Seuil_reparation, T_parc_machine.[Prix Achat], T_parc_machine.[Prix remplacement], T_type_machine.[Forfait DNR], T_type_machine.[Forfait Transport], T_type_machine.[Forfait controle], T_type_machine.[Prix catalogue] FROM (T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[N° Devis])="+txNumDevis.Text+"))";
				RequeteDev.Connection=oleDbConnection1;
				RequeteDev.CommandText=RequeteDevis;
				oleDbDataAdapter1.SelectCommand=RequeteDev;
				try
				{
					oleDbDataAdapter1.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
			}
		}

		private void mtgcComboBox6_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_causes_clients"].Clear();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select code,designation from t_causes_clients where code ="+mtgcComboBox6.Text;
			OleDbDataAdapter DataAD = new OleDbDataAdapter();
			DataAD.SelectCommand=Comm;
			DataAD.Fill(dataSet11,"T_causes_clients");
			label17.Text=dataSet11.Tables["t_causes_clients"].Rows[0]["Designation"].ToString();
		}

		private void mtgcComboBox7_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_causes_atelier"].Clear();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select code,designation from t_causes_atelier where code ="+mtgcComboBox7.Text;
			OleDbDataAdapter DataAD = new OleDbDataAdapter();
			DataAD.SelectCommand=Comm;
			DataAD.Fill(dataSet11,"T_causes_atelier");
			label18.Text=dataSet11.Tables["t_causes_atelier"].Rows[0]["Designation"].ToString();
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Close();
			oleDbConnection1.Open();
			Comm.CommandText="select edite from t_devis_entete where [n° devis]="+txNumDevis.Text;
			bool Edite=false;
			try
			{
				Edite=(bool)Comm.ExecuteScalar();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			oleDbConnection1.Close();
			if(!Edite)
			{
				MessageBox.Show("Devis non édité");
			}
			else
			{
				bool ACommander=false;
				
				for(int i=0;i<listView1.Items.Count;i++)
				{
					oleDbConnection1.Open();
					OleDbTransaction transac= oleDbConnection1.BeginTransaction();
					Comm.Transaction=transac;
					int Qte=0;

					try
					{
						Qte=System.Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
					}
					catch
					{
					}
					string code=listView1.Items[i].SubItems[6].Text;
					dataSet11.Tables["t_pieces_detachees"].Clear();
					
					Comm.CommandText="select * from t_pieces_detachees where Identificateur="+code+"";
					oleDbDataAdapter9.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter9.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					if(dataSet11.Tables["t_pieces_detachees"].Rows.Count>0)
					{
						int Reserve=0;
						int Reel=0;
						int Dispo=0;
						int Cde=0;
						int Theo=0;

						try
						{
							Reserve=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite Reserve"].ToString());
						}
						catch
						{
						}
						Reserve+=Qte;
						
						Comm.CommandText="update t_pieces_detachees set [Quantite Reserve]="+Reserve.ToString()+" where identificateur="+dataSet11.Tables["t_pieces_detachees"].Rows[0]["identificateur"].ToString();
						Comm.ExecuteNonQuery();

						try
						{
							Reel=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite Stock"].ToString());
						}
						catch
						{
						}
					
						Dispo=Reel-Reserve;

						try
						{
							Cde=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite Commande"].ToString());
						}
						catch
						{
						}

						Theo=Dispo+Cde;

						Comm.CommandText="update t_pieces_detachees set [Quantite Stock theorique]="+Theo.ToString()+", [Quantite disponible]="+Dispo+" where identificateur="+dataSet11.Tables["t_pieces_detachees"].Rows[0]["identificateur"].ToString();
						Comm.ExecuteNonQuery();

						int ACder=0;
						int Mini=0;

						try
						{
							Mini=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite Minimum"].ToString());
						}
						catch
						{
						}

						if(Theo<0)
						{
							ACder+=Math.Abs(Theo);
							ACder+=Mini;
                            ACommander = true;
						}

                        dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Clear();
						Comm.CommandText="select * from t_pieces_detachees_a_commander_preparation where [Code piece]="+code+" AND [Quantite propose]>0 AND [Quantite a cde]>0";
						OleDbDataAdapter AD = new OleDbDataAdapter();
						AD.SelectCommand=Comm;
						AD.Fill(dataSet11,"t_pieces_detachees_a_commander_preparation");
						if(dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Rows.Count>0)
						{
							int QteDevis=0;
							int idligne=0;

							try
							{
								QteDevis=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Rows[0]["Quantite Devis"].ToString());
							}
							catch
							{
							}
							QteDevis+=Qte;

							try
							{
								idligne=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Rows[0]["idligne"].ToString());
							}
							catch
							{
							}

							Comm.CommandText="update t_pieces_detachees_a_commander_preparation set [Quantite devis]="+QteDevis+",[Quantite propose]="+ACder+",[quantite a cde]="+ACder+" where idligne="+idligne;
							Comm.ExecuteNonQuery();

						}
						else
						{
							Comm.CommandText="insert into t_pieces_detachees_a_commander_preparation ([N° devis],[Code piece],[Code fournisseur],[Quantite devis],[Quantite propose],[quantite a cde]) values ("+txNumDevis.Text+",'"+code+"','"+dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code fournisseur principal"].ToString()+"',"+Qte.ToString()+","+ACder.ToString()+","+ACder.ToString()+")";
							Comm.ExecuteNonQuery();
						}

						transac.Commit();

						dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Clear();

						/*int StockTheo=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite stock theorique"].ToString());
						int Dispo=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite disponible"].ToString());
						int StockMini=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite minimum"].ToString());
						if(StockTheo<Qte)
						{
							ACommander=true;
							int Commande=Math.Abs(Qte-StockTheo)+StockMini;
							Comm.CommandText="insert into t_pieces_detachees_a_commander_preparation ([N° devis],[Code piece],[Code fournisseur],[Quantite devis],[Quantite propose],[quantite a cde]) values ("+txNumDevis.Text+",'"+code+"','"+dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code fournisseur principal"].ToString()+"',"+Qte.ToString()+","+Commande.ToString()+","+Commande.ToString()+")";
							Comm.ExecuteNonQuery();
							int sto=StockTheo-Qte;
							Dispo=Dispo-Qte;
							int Acommander=Qte+System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite reserve"].ToString());
							Comm.CommandText="update t_pieces_detachees set [quantite stock theorique]="+sto.ToString()+", [quantite reserve]="+Acommander.ToString()+", [quantite disponible]="+Dispo.ToString()+" where identificateur="+dataSet11.Tables["t_pieces_detachees"].Rows[0]["identificateur"].ToString();
							Comm.ExecuteNonQuery();
							transac.Commit();
						}
						else
						{
							if((StockTheo-Qte)<StockMini)
							{
								ACommander=true;
								int Commande=StockMini-(StockTheo-Qte);
								Comm.CommandText="insert into t_pieces_detachees_a_commander_preparation ([N° devis],[Code piece],[Code fournisseur],[Quantite devis],[Quantite propose],[quantite a cde]) values ("+txNumDevis.Text+",'"+code+"',"+dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code fournisseur principal"].ToString()+","+Qte.ToString()+","+Commande.ToString()+","+Commande.ToString()+")";
								Comm.ExecuteNonQuery();
								int sto=StockTheo-Qte;
								int Acommander=Qte+System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite reserve"].ToString());
								Comm.CommandText="update t_pieces_detachees set [quantite stock theorique]="+sto.ToString()+", [quantite reserve]="+Acommander.ToString()+", [quantite disponible]="+Dispo.ToString()+" where identificateur="+dataSet11.Tables["t_pieces_detachees"].Rows[0]["identificateur"].ToString();
								try
								{
									Comm.ExecuteNonQuery();
								}
								catch(Exception exp)
								{
									MessageBox.Show(Comm.CommandText);
									Console.WriteLine(exp.Message);
								}
								transac.Commit();
							}
							else
							{
								int sto=StockTheo-Qte;
								int Acommander=Qte+System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite reserve"].ToString());
								Comm.CommandText="update t_pieces_detachees set [quantite stock theorique]="+sto.ToString()+", [quantite reserve]="+Acommander.ToString()+", [quantite disponible]="+Dispo.ToString()+" where identificateur="+dataSet11.Tables["t_pieces_detachees"].Rows[0]["identificateur"].ToString();
							
								try
								{
									Comm.ExecuteNonQuery();
								}
								catch(Exception exp)
								{
									MessageBox.Show(Comm.CommandText);
									Console.WriteLine(exp.Message);
								}

								
							}
						}*/
					
					}
					oleDbConnection1.Close();
				}

				txEtat.Text="Matériel en attente de commande";
				mtgcComboBox1.Enabled=false;
				radioButton1.Enabled=false;
				radioButton2.Enabled=false;
				radioButton3.Enabled=false;
				mtgcComboBox3.Enabled=false;
				mtgcComboBox5.Enabled=false;
				mtgcComboBox9.Enabled=false;
				listView1.Enabled=false;
				mtgcComboBox6.Enabled=false;
				mtgcComboBox7.Enabled=false;
				txRemCauseAtelier.Enabled=false;
				txRemCauseClient.Enabled=false;
				button1.Enabled=false;
				button2.Enabled=false;
				txBL.Enabled=false;
				button12.Enabled=false;
				button7.Enabled=false;
				button8.Enabled=false;
				button9.Enabled=false;
				button10.Enabled=true;
				//button11.Enabled=true;
				button6.Enabled=false;
				button3.Enabled=false;
				numericUpDown1.Enabled=false;
				numericUpDown2.Enabled=false;
				textBox19.Enabled=false;
				textBox20.Enabled=false;
				textBox21.Enabled=false;
				textBox22.Enabled=false;
				//txOrdre.Enabled=false;
				//txCommande.Enabled=false;
				txTroncon.Enabled=false;
				txComptable.Enabled=false;
				mtgcComboBox2.Enabled=true;
				Comm.CommandText="select * from t_pieces_detachees_a_commander_preparation where [n° devis]="+txNumDevis.Text;
				OleDbDataAdapter DataAD = new OleDbDataAdapter();
				DataAD.SelectCommand=Comm;
				DataAD.Fill(dataSet11,"t_pieces_detachees_a_commander_preparation");
				bool Solde=true;
				if(dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Rows.Count>0)
				{
					foreach(DataRow row in dataSet11.Tables["t_pieces_detachees_a_commander_preparation"].Rows)
					{
						if(System.Convert.ToInt32(row["Quantite a cde"].ToString())>0)
							Solde=false;
					}
				}
				if(Solde)
				{
					button10.Enabled=false;
				}
				oleDbConnection1.Close();
                if (!ACommander)
                {
                    oleDbConnection1.Open();
                    OleDbTransaction transac = oleDbConnection1.BeginTransaction();
                    Comm.Transaction = transac;
                    Comm.CommandText = "UPDATE t_devis_entete SET [niveau]=5, [Date Generation Commande]='" + DateTime.Now.ToShortDateString() + "', [Date Reception pieces]='" + DateTime.Now.ToShortDateString() + "' WHERE [n° devis]=" + txNumDevis.Text;
                    try
                    {
                        Comm.ExecuteNonQuery();

                        Comm.CommandText = "insert into t_parc_machine_historique ([Code machine opindus],Dateinter,description,typeinterv,infos_1,infos_1_1,infos_3) VALUES ('" + txCodeOpindus.Text.Replace("'", "''") + "','" + DateTime.Now.ToShortDateString() + "','Réparation',2,'Devis N° : "+txNumDevis.Text+" du "+txDate.Text+"','Décision : REPARATION','Montant du devis : "+textBox24.Text.Replace(",",".")+" €')";
                        Comm.ExecuteNonQuery();

                        transac.Commit();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(Comm.CommandText);
                        Console.WriteLine(exp.Message);
                    }

                    oleDbConnection1.Close();
                }
                else
                {
                    oleDbConnection1.Open();
                    OleDbTransaction transac = oleDbConnection1.BeginTransaction();
                    Comm.Transaction = transac;
                    Comm.CommandText = "UPDATE t_devis_entete SET [niveau]=4 WHERE [n° devis]=" + txNumDevis.Text;
                    try
                    {
                        Comm.ExecuteNonQuery();
                        transac.Commit();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(Comm.CommandText);
                        Console.WriteLine(exp.Message);
                    }

                    oleDbConnection1.Close();
                }
				oleDbConnection1.Open();
				OleDbTransaction transac2= oleDbConnection1.BeginTransaction();
				Comm.Transaction=transac2;
				Comm.CommandText="update t_devis_entete set [Accord client]=True, [Date decision]='"+DateTime.Now.ToShortDateString()+"' ,[n° commande ouverte]='"+txCommande.Text+"' where [n° devis]="+txNumDevis.Text;
				try
				{
					Comm.ExecuteNonQuery();
					transac2.Commit();
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
					MessageBox.Show(Comm.CommandText);
				}
				finally
				{
					oleDbConnection1.Close();
				}
			}
			
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			Save(false);
			oleDbConnection1.Open();
			Transac=oleDbConnection1.BeginTransaction();
			Comm.Connection=oleDbConnection1;
			Comm.Transaction=Transac;
			Comm.CommandText="UPDATE t_parc_machine SET [Date refus]='"+DateTime.Now.ToShortDateString()+"', [No dernier devis]="+txNumDevis.Text+", [en reparation]=False WHERE [code machine opindus]='"+txCodeOpindus.Text+"'";
			try
			{
				Comm.ExecuteNonQuery();
				try
				{
					Transac.Commit();
				}
				catch(OleDbException ex)
				{
					Transac.Rollback();
					Console.Write(ex.Message);
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
			oleDbConnection1.Open();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="update t_devis_entete set [niveau]=9 , [Total pieces]=0,[Forfait DNR]=0,[Forfait transport]=0,[Forfait controle]=0,[Total devis]=0,Refus=True, [Date decision]='"+DateTime.Now.ToShortDateString()+"', [Date reparation]='"+DateTime.Now.ToShortDateString()+"' where [n° devis]="+txNumDevis.Text;
			try
			{
                Comm.ExecuteNonQuery();

                Comm.CommandText = "update t_devis_lignes set [Quantite]=0 , [Prix de vente]=0,[Prix achat net]=0,[Total ligne]=0 where [N° Devis]=" + txNumDevis.Text;

                Comm.ExecuteNonQuery();

                Comm.CommandText = "insert into t_parc_machine_historique ([Code machine opindus],Dateinter,description,typeinterv,infos_1,infos_1_1,infos_3) VALUES ('" + txCodeOpindus.Text.Replace("'", "''") + "','" + DateTime.Now.ToShortDateString() + "','Devis refusé',0,'Devis N° : " + txNumDevis.Text + " du " + txDate.Text + "','Décision : REFUS','Montant du devis : 0,,00 €')";
                Comm.ExecuteNonQuery();

				MessageBox.Show("Mise à jour terminée");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			finally
			{
				oleDbConnection1.Close();
			}
			try
			{
				oleDbDataAdapter12.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			int BLExiste=0;
			Comm.CommandText="SELECT T_BL_entete.[N° BL], T_BL_entete.[Total bl] FROM T_BL_entete WHERE (((T_BL_entete.[Code client])="+txCodeCli.Text+") AND ((T_BL_entete.[N° Commande ouverte])='"+txCommande.Text+"') AND ((T_BL_entete.[OR])='"+txOrdre.Text+"') AND ((T_BL_entete.Edite)=False)) GROUP BY T_BL_entete.[N° BL], T_BL_entete.[Total bl]";
			//MessageBox.Show(Comm.CommandText);
			DataAD.SelectCommand=Comm;
				
			try
			{
				if(DataAD.Fill(ds,"BLEX")>0)
					BLExiste=System.Convert.ToInt32(ds.Tables["BLEX"].Rows[0]["n° bl"].ToString());
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			
			int NumBL=0;
			if(BLExiste.Equals(0))
			{
				Comm.CommandText="SELECT Max(T_BL_entete.[N° BL]) AS [MaxDeN° BL] FROM T_BL_entete";
				try
				{
					oleDbConnection1.Open();
					NumBL=System.Convert.ToInt32(Comm.ExecuteScalar())+1;
					oleDbConnection1.Close();
					Comm.CommandText="INSERT INTO t_bl_entete ([N° BL],[Date],[Code client],[n° commande ouverte],[OR],[Total BL],[Code TVA]) VALUES ("+NumBL+",'"+DateTime.Now.ToShortDateString()+"',"+txCodeCli.Text+",'"+txCommande.Text+"','"+txOrdre.Text+"',0,1)";
					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							button12.Enabled=true;
							txBL.Text=NumBL.ToString();
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
				catch
				{
					MessageBox.Show("Erreur dans la base de données");
				}
				
			}
			else
			{
				NumBL=BLExiste;
				button12.Enabled=true;
				txBL.Text=NumBL.ToString();
				Double BLTotal=System.Convert.ToDouble(ds.Tables["BLEX"].Rows[0]["Total bl"].ToString());
				Double Total=System.Convert.ToDouble(txTotalDevis.Text.Trim('€'))+BLTotal;
				dataSet11.Tables["t_bl_entete"].Clear();
				Comm.CommandText="select * from t_bl_entete where [n° bl]="+txBL.Text;
				oleDbDataAdapter12.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter12.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				Double TotalBL=System.Convert.ToDouble(dataSet11.Tables["t_bl_entete"].Rows[0]["Total bl"].ToString());
				TotalBL+=Total;
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.CommandText="update t_bl_entete set [Total BL]=0 where [n° bl]="+txBL.Text;
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(OleDbException exp)
					{
						MessageBox.Show(exp.Message);
					}
					finally
					{
						oleDbConnection1.Close();
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
					MessageBox.Show(Comm.CommandText);
				}
			}
			ds.Tables["BLEX"].Clear();
			if(txMabec.TextLength.Equals(0))
				 txMabec.Text="?";
			if(txTroncon.TextLength.Equals(0))
				txTroncon.Text="?";
			Comm.CommandText="INSERT INTO t_bl_lignes ([N° BL],[N° devis],[Code mabec],[Type materiel],[Code materiel],[Fournisseur],[Montant],[Troncon],[Total ligne],[Code ventilation]) VALUES ("+txBL.Text+","+txNumDevis.Text+",'"+txMabec.Text+"','"+txTypeMachine.Text+"','"+txCodeOpindus.Text+"','"+txFournisseur.Text+"','Refusé','"+txTroncon.Text+"',0,1)";

			try
			{
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.Transaction=Transac;
				Comm.ExecuteNonQuery();
				try
				{
					Transac.Commit();
					button12.Enabled=true;
					txBL.Text=NumBL.ToString();
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
			oleDbConnection1.Open();
			Transac=oleDbConnection1.BeginTransaction();
			Comm.CommandText="update t_devis_entete set [N° Bl]="+txBL.Text+" where [n° devis]="+txNumDevis.Text;
			Comm.Transaction=Transac;
			try
			{
				Comm.ExecuteNonQuery();
				try
				{
					Transac.Commit();
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
			button7.Enabled=false;
			button8.Enabled=false;
			button9.Enabled=false;
			button10.Enabled=false;
			textBox34.Text="0.00";
			txTotalDevis.Text="0.00";
			txEtat.Text="Devis refusé";
			mtgcComboBox1.Enabled=false;
			mtgcComboBox2.Enabled=false;
			txCommande.Enabled=false;
			mtgcComboBox8.Enabled=false;
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Page+=1;
			int ypos=e.MarginBounds.Top+80;
			string Ville=null;
			if(Agence.Equals(1))
				Ville="St Priest";
			else if(Agence.Equals(2))
				Ville="Fretin";
			else
				Ville="Rouen";
			e.Graphics.DrawString(Ville+" le "+DateTime.Now.ToShortDateString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-150, ypos);
			ypos+=40;
			e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+50,ypos,200,100);
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["T_clients.Nom"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
			ypos+=10;
			e.Graphics.DrawString("Dépenses déjà engagées avant ce devis :", new System.Drawing.Font("Arial", 6, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+60, ypos);
			ypos+=10;
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["Adresse_1"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
			ypos+=10;
			if(dataSet11.Tables["t_devis_entete"].Rows.Count>0)
			{
				if(dataSet11.Tables["t_devis_entete"].Rows[0]["SommeDeTotal devis"].ToString().Length>0)
					e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_devis_entete"].Rows[0]["SommeDeTotal devis"].ToString()).ToString("c"), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+60, ypos);
				else
					e.Graphics.DrawString("0,00 €", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+60, ypos);
			}
			ypos+=10;
			if(dataSet11.Tables["t_devis_lignes"].Rows[0]["Adresse_2"].ToString()!="?")
				e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["Adresse_2"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
			ypos+=10;
			e.Graphics.DrawString("Date de première intervention :", new System.Drawing.Font("Arial", 6, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+60, ypos);
			ypos+=10;
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["Code_postal"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["Ville"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			ypos+=10;
			if(dataSet11.Tables["t_devis_entete"].Rows.Count>0)
			{
				if(dataSet11.Tables["t_devis_entete"].Rows[0]["mindedate reparation"].ToString().Length>0)
					e.Graphics.DrawString(System.Convert.ToDateTime(dataSet11.Tables["t_devis_entete"].Rows[0]["mindedate reparation"].ToString()).ToShortDateString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+60, ypos);
				else
					e.Graphics.DrawString("Jamais entrée", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+60, ypos);
			}
			ypos+=10;
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["Pays"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
			ypos+=40;
			e.Graphics.DrawString("Devis N° "+dataSet11.Tables["t_devis_lignes"].Rows[0]["N° Devis"].ToString(), new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
			ypos+=40;
			e.Graphics.DrawString("Code Machine Opindus", new System.Drawing.Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Votre Code Machine", new System.Drawing.Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left+150, ypos);
			e.Graphics.DrawString("Type Machine", new System.Drawing.Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left+300, ypos);
			e.Graphics.DrawString("Fournisseur", new System.Drawing.Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left+450, ypos);
			ypos+=20;
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["Code machine opindus"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["Code machine client"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["t_type_machine.Code"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["T_fournisseurs.Nom"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+450, ypos);
			ypos+=20;
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["T_famille_machine.Designation"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
			ypos+=20;
			e.Graphics.DrawString("Ordre Travail", new System.Drawing.Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("N° Commande Ouverte", new System.Drawing.Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left+200, ypos);
			e.Graphics.DrawString("Code Mabec", new System.Drawing.Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left+450, ypos);
			ypos+=20;
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["Ordre travail"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["N° commande ouverte"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[0]["Code Mabec"].ToString(), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+450, ypos);
			ypos+=40;
			e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left,ypos,300,50);
			e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+330,ypos,300,50);
			ypos+=5;
			if(txRemCauseClient.Text.Length>1)
				e.Graphics.DrawString(txRemCauseClient.Text, new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+10, ypos);
			if(txRemCauseAtelier.Text.Length>1)
				e.Graphics.DrawString(txRemCauseAtelier.Text, new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+340, ypos);
			ypos+=65;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new System.Drawing.Point(e.MarginBounds.Left,ypos), new System.Drawing.Point(e.MarginBounds.Right,ypos));
			ypos+=5;
			e.Graphics.DrawString("Code", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Désignation", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+90, ypos);
			e.Graphics.DrawString("Quantité", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+340, ypos);
			e.Graphics.DrawString("Prix Vente", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			e.Graphics.DrawString("Total ligne", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
			e.Graphics.DrawString("Cause", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
			ypos+=15;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new System.Drawing.Point(e.MarginBounds.Left,ypos), new System.Drawing.Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			while(ypos<850&&countRow<dataSet11.Tables["t_devis_lignes"].Rows.Count)
			{

				e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[countRow]["t_pieces_detachees.Code"].ToString(), 
					new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[countRow]["T_devis_lignes.Designation"].ToString(), 
					new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+90, ypos);
				e.Graphics.DrawString(dataSet11.Tables["t_devis_lignes"].Rows[countRow]["Quantite"].ToString(), 
					new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+350, ypos);
				try
				{
					e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow]["Prix de vente"].ToString()).ToString("c"), 
						new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+410, ypos);
				}
				catch(Exception exp)
				{
					e.Graphics.DrawString("0,00 €", 
						new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+410, ypos);
					Console.WriteLine(exp.Message);
				}
				try
				{
					e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow]["Total ligne"].ToString()).ToString("c"), 
						new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+490, ypos);
				}
				catch(Exception exp)
				{
					e.Graphics.DrawString("0,00 €", 
						new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+490, ypos);
					Console.WriteLine(exp.Message);
				}
				oleDbConnection1.Open();
				Comm.CommandText="select designation from t_causes where Code="+dataSet11.Tables["t_devis_lignes"].Rows[countRow]["Cause"].ToString();
				string Cause = (string)Comm.ExecuteScalar();
				oleDbConnection1.Close();
				e.Graphics.DrawString(Cause, 
					new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
				ypos+=15;
				countRow+=1;
			}
			ypos=900;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new System.Drawing.Point(e.MarginBounds.Left,ypos), new System.Drawing.Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			Decimal PrixMachine=0;
			e.Graphics.DrawString("Pourcentage de la réparation", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			
			if(textBox28.TextLength>0)
				PrixMachine=System.Convert.ToDecimal(textBox28.Text);
			Decimal ForfaitDNR=0;
            if (dataSet11.Tables["t_devis_lignes"].Rows[countRow - 1]["Forfait_DNR"].ToString().Length > 0)
			{
                /*if (System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow - 1]["Forfait_DNR"].ToString()) > 0)
                    ForfaitDNR = System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow - 1]["Forfait_DNR"].ToString());
                else if (System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow - 1]["T_type_machine.Forfait DNR"].ToString()) > 0)
                    ForfaitDNR = System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow - 1]["T_type_machine.Forfait DNR"].ToString());
                else*/
                ForfaitDNR = System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow - 1]["T_devis_entete.Forfait DNR"].ToString());

			}
			Decimal ForfaitControle=0;
			if(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["T_devis_entete.Forfait controle"].ToString().Length>0)
			{
				if(System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["T_devis_entete.Forfait controle"].ToString())>0)
					ForfaitControle=System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["T_devis_entete.Forfait controle"].ToString());
				else
					ForfaitControle=System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["T_devis_entete.Forfait controle"].ToString());
			}
			Decimal ForfaitTransport=0;
			if(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["T_devis_entete.Forfait Transport"].ToString().Length>0)
			{
				if(System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["T_devis_entete.Forfait Transport"].ToString())>0)
					ForfaitTransport=System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["T_devis_entete.Forfait Transport"].ToString());
				else
					ForfaitTransport=System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["T_devis_entete.Forfait Transport"].ToString());
			}
			Decimal Total=System.Convert.ToDecimal(textBox24.Text);
			Decimal Pourcent=0;
			if(Total!=0&&PrixMachine!=0)
				Pourcent= (Total/PrixMachine)*100;
			else
				Pourcent=0;
			e.Graphics.DrawString(Pourcent.ToString("0.00")+"%", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
			e.Graphics.DrawString("Total H.T. pièces", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			e.Graphics.DrawString(System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["Total pieces"].ToString()).ToString("c"), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+520, ypos);
			ypos+=20;
			e.Graphics.DrawString("Prix achat", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(PrixMachine.ToString("c"), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
			e.Graphics.DrawString("Forfait DNR", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			e.Graphics.DrawString(ForfaitDNR.ToString("c"), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+520, ypos);
			ypos+=20;
			e.Graphics.DrawString("Seuil client", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(System.Convert.ToDecimal(textBox29.Text)+"%", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
			e.Graphics.DrawString("Forfait contrôle", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			e.Graphics.DrawString(ForfaitControle.ToString("c"), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+520, ypos);
			ypos+=20;
			e.Graphics.DrawString("Forfait transport", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			e.Graphics.DrawString(ForfaitTransport.ToString("c"), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+520, ypos);
			ypos+=20;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new System.Drawing.Point(e.MarginBounds.Left+400,ypos), new System.Drawing.Point(e.MarginBounds.Right,ypos));
			ypos+=20;
			e.Graphics.DrawString("Total H.T.", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			e.Graphics.DrawString(Total.ToString("c"), new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+520, ypos);
			ypos+=10;
			if(Pourcent>=System.Convert.ToDecimal(dataSet11.Tables["t_devis_lignes"].Rows[countRow-1]["Seuil_reparation"].ToString()))
			{
				e.Graphics.DrawString("Le total de la réparation depasse la limite autorisée.", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=15;
				e.Graphics.DrawString("Votre accord nous est donc indispensable.", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString("Date et signature :", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			}
			else
			{
				e.Graphics.DrawString("Le total de la réparation est inferieure à la limite autorisée,", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=15;
				e.Graphics.DrawString("la réparation est donc lancée.", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString("Date et signature :", new System.Drawing.Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			}
			if(countRow<dataSet11.Tables["t_devis_lignes"].Rows.Count)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
			}
		}

		private void mtgcComboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}

		private void mtgcComboBox3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if(e.KeyValue.Equals(13))
			{
				if(mtgcComboBox3.SelectedIndex>=0)
				{	
					mtgcComboBox9.Text="";
					mtgcComboBox9.SelectedIndex=-1;
					mtgcComboBox5.Text="";
					mtgcComboBox5.SelectedIndex=-1;
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select * from t_pieces_detachees where code='"+mtgcComboBox3.Text+"'";
					oleDbDataAdapter9.SelectCommand=Comm;
					oleDbDataAdapter9.Fill(dataSet11);
					textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox4.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox6.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
					textBox8.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["code_1"].ToString();
					textBox1.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
                    txPrixAchat.Text = dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix achat net"].ToString();
					string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString().Replace(".",",");
					decimal Prix = System.Convert.ToDecimal(Price);
					textBox3.Text=Prix.ToString("0.00");
					textBox5.Text=Prix.ToString("0.00");
					mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["code_1"].ToString());
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
					mtgcComboBox9.SelectedIndex=mtgcComboBox9.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString());
					try
					{
						if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString())>(0.00)))
						{
							string Pourcent = numericUpDown2.Value.ToString().Trim(',');
							string Rem = "1,"+Pourcent;
							decimal remise = System.Convert.ToDecimal(Rem);
							decimal nombre = numericUpDown1.Value;
							decimal PV = System.Convert.ToDecimal(textBox3.Text);
							decimal Total = PV*nombre*remise;
							txNetCommande.Text=Total.ToString("0.00");
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					button3.Enabled=true;
				}
				if(mtgcComboBox3.Text.Equals("******************"))
				{
					textBox9.Visible=true;
					textBox9.Focus();
					mtgcComboBox10.Visible=true;
					mtgcComboBox11.Visible=true;
					button16.Visible=true;
				}
			}
		}

		private void mtgcComboBox9_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				mtgcComboBox3.Text="";
				mtgcComboBox3.SelectedIndex=-1;
				mtgcComboBox5.Text="";
				mtgcComboBox5.SelectedIndex=-1;
				if(mtgcComboBox9.SelectedIndex>=0)
				{
					mtgcComboBox5.SelectedIndex=-1;
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select * from t_pieces_detachees where identificateur="+mtgcComboBox9.Text;
					oleDbDataAdapter9.SelectCommand=Comm;
					oleDbDataAdapter9.Fill(dataSet11);
					textBox1.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
					textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox4.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox6.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
					string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString().Replace(".",",");
					decimal Prix = System.Convert.ToDecimal(Price);
					textBox3.Text=Prix.ToString("0.00");
					textBox5.Text=Prix.ToString("0.00");
					mtgcComboBox5.SelectedIndex=mtgcComboBox5.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code_1"].ToString());
					mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString());
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
					try
					{
						if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString())>(0.00)))
						{
							string Pourcent = numericUpDown2.Value.ToString().Trim(',');
							string Rem = "1,"+Pourcent;
							decimal remise = System.Convert.ToDecimal(Rem);
							decimal nombre = numericUpDown1.Value;
							decimal PV = System.Convert.ToDecimal(textBox3.Text);
							decimal Total = PV*nombre*remise;
							txNetCommande.Text=Total.ToString("0.00");
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					button3.Enabled=true;
				}
			}
		}

		private void mtgcComboBox5_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				if(mtgcComboBox5.SelectedIndex>=0)
				{
					mtgcComboBox3.Text="";
					mtgcComboBox3.SelectedIndex=-1;
					mtgcComboBox9.Text="";
					mtgcComboBox9.SelectedIndex=-1;
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select * from t_pieces_detachees where code_1='"+mtgcComboBox5.Text+"'";
					oleDbDataAdapter9.SelectCommand=Comm;
						
					oleDbDataAdapter9.Fill(dataSet11);
					textBox1.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString();
					textBox2.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox4.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Designation"].ToString();
					textBox6.Text=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString();
					string Price=dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString().Replace(".",",");
					decimal Prix = System.Convert.ToDecimal(Price);
					textBox3.Text=Prix.ToString("0.00");
					textBox5.Text=Prix.ToString("0.00");
					mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Cause principale"].ToString());
					mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString());
					mtgcComboBox9.SelectedIndex=mtgcComboBox9.FindString(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Identificateur"].ToString());
					try
					{
						if((System.Convert.ToDouble(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Prix vente"].ToString())>(0.00)))
						{
							string Pourcent = numericUpDown2.Value.ToString().Trim(',');
							string Rem = "1,"+Pourcent;
							decimal remise = System.Convert.ToDecimal(Rem);
							decimal nombre = numericUpDown1.Value;
							decimal PV = System.Convert.ToDecimal(textBox3.Text);
							decimal Total = PV*nombre*remise;
							txNetCommande.Text=Total.ToString("0.00");
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
			}
		}

		private void textBox30_TextChanged(object sender, System.EventArgs e)
		{
			if(textBox30.Text.Length>0&&textBox29.Text.Length>0)
			{
				if((System.Convert.ToDecimal(textBox30.Text.Replace(".",","))>=System.Convert.ToDecimal(textBox29.Text.Replace(".",","))))
				{
					label55.Visible=true;
					label56.Visible=true;
					label57.Visible=true;
					label55.Text="Le total de la réparation depasse la limite autorisée.";
					label56.Text="Votre accord nous est donc indispensable.";
					label57.Text="Date et signature :";
				}
				else
				{
					label55.Visible=true;
					label56.Visible=true;
					label57.Visible=true;
					label55.Text="Le total de la réparation est inferieure à la limite autorisée,";
					label56.Text="la réparation est donc lancée.";
					label57.Text="Date et signature :";
				}
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			textBox35.Visible=true;
			textBox35.Focus();
			button14.Visible=true;
			button15.Visible=true;
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="update t_devis_entete set [niveau]=6, [date reception pieces]='"+DateTime.Now.ToShortDateString()+"' where [n° devis]="+txNumDevis.Text;
			try
			{
				Comm.ExecuteNonQuery();
				txEtat.Text="Matériel en attente de Remontage";
				MessageBox.Show("Mise à jour terminée");
				button11.Enabled=true;
				button10.Enabled=false;
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			oleDbConnection1.Close();
		}

		private void button11_Click(object sender, System.EventArgs e)
		{
			if(mtgcComboBox2.SelectedIndex>0)
			{
				Save(false);
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				DateTime FinGarantie = DateTime.Now.AddDays(90);
				Comm.Connection=oleDbConnection1;
				Comm.Transaction=Transac;
				Comm.CommandText="update t_parc_machine set [date fin garantie]='"+FinGarantie.ToShortDateString()+"' where [code machine opindus]='"+txCodeOpindus.Text+"'";
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(OleDbException excp)
					{
						MessageBox.Show(excp.Message);
					}
					finally
					{
						oleDbConnection1.Close();
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.CommandText="update t_devis_entete set [niveau]=7, [Reparateur_R]='"+mtgcComboBox2.Text+"', [Date reparation]='"+DateTime.Now.ToShortDateString()+"' where [n° devis]="+txNumDevis.Text;
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(OleDbException excp)
					{
						MessageBox.Show(excp.Message);
					}
					finally
					{
						oleDbConnection1.Close();
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.CommandText="update t_parc_machine set [En reparation]=False, [Date dernier intervention]='"+DateTime.Now.ToShortDateString()+"', [No dernier devis]="+txNumDevis.Text+" where [code machine opindus]='"+txCodeOpindus.Text+"'";
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(OleDbException excp)
					{
						MessageBox.Show(excp.Message);
					}
					finally
					{
						oleDbConnection1.Close();
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				dataSet11.Tables["t_devis_lignes"].Clear();
				Comm.CommandText="select * from t_devis_lignes where [N° devis]="+txNumDevis.Text;
				oleDbDataAdapter11.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter11.Fill(dataSet11);
				}
				catch(Exception exp)
				{

				}
				foreach(DataRow row in dataSet11.Tables["t_devis_lignes"].Rows)
				{
					dataSet11.Tables["t_pieces_detachees"].Clear();
					Comm.CommandText="select * from t_pieces_detachees where Identificateur="+row["Code piece"].ToString();
					oleDbDataAdapter9.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter9.Fill(dataSet11);
					}
					catch(Exception exp)
					{

					}
					try
					{
						int Resa=0;
						try
						{
							Resa=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite reserve"].ToString())-System.Convert.ToInt32(row["Quantite"].ToString());
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						int Stock=0;
						try
						{
							Stock=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite stock"].ToString())-System.Convert.ToInt32(row["Quantite"].ToString());
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						int Commande=0;
						try
						{
							Commande=System.Convert.ToInt32(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Quantite commande"].ToString());
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						int Theo=(Stock-Resa)+Commande;
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.CommandText="update t_pieces_detachees set [quantite reserve]="+Resa.ToString()+", [quantite stock]="+Stock.ToString()+", [quantite stock theorique]="+Theo.ToString()+", [date dernier mouvement]='"+DateTime.Now.ToShortDateString()+"' where [identificateur]="+row["Code piece"].ToString();
						Comm.Transaction=Transac;
						try
						{
							Comm.ExecuteNonQuery();
							try
							{
								Transac.Commit();
							}
							catch(OleDbException excp)
							{
								MessageBox.Show(excp.Message);
							}
							finally
							{
								oleDbConnection1.Close();
							}

						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show("Probleme pieces");
					}
				}
				try
				{
					oleDbDataAdapter12.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				int BLExiste=0;
				Comm.CommandText="SELECT T_BL_entete.[N° BL], T_BL_entete.[Total bl euros] FROM T_BL_entete WHERE (((T_BL_entete.[Code client])="+txCodeCli.Text+") AND ((T_BL_entete.[N° Commande ouverte])='"+txCommande.Text+"') AND ((T_BL_entete.[OR])='"+txOrdre.Text+"') AND ((T_BL_entete.Edite)=False)) GROUP BY T_BL_entete.[N° BL], T_BL_entete.[Total bl euros]";
				//MessageBox.Show(Comm.CommandText);
				DataAD.SelectCommand=Comm;
				
				try
				{
					DataAD.Fill(ds,"BLEX");
					BLExiste=System.Convert.ToInt32(ds.Tables["BLEX"].Rows[0]["n° bl"].ToString());
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				
				int NumBL=0;
				if(BLExiste.Equals(0))
				{
					try
					{
                        oleDbConnection1.Open();
                        Comm.CommandText = "SELECT MAX([N° BL]) FROM T_BL_Entete";
                        Comm.Transaction = Transac;
                        try
                        {
                            NumBL = System.Convert.ToInt32(Comm.ExecuteScalar());
                            NumBL++;
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                            MessageBox.Show(Comm.CommandText);
                        }
                        finally
                        {
                            oleDbConnection1.Close();
                        }
						
					}
					catch(Exception exp)
					{
						MessageBox.Show("Erreur Num BL");
					}
					DataRow newRow =dataSet11.Tables["t_bl_entete"].NewRow();
					newRow["N° BL"]=NumBL;
					newRow["Date"]=DateTime.Now.ToShortDateString();
					newRow["Code client"]=txCodeCli.Text;
					newRow["n° commande ouverte"]=txCommande.Text;
					newRow["OR"]=txOrdre.Text;
					newRow["Total BL"]=txTotalDevis.Text;
					newRow["Total BL euros"]=txTotalDevis.Text.Trim('€');
					newRow["Code TVA"]=1;
					newRow["Comment"]="?";
					dataSet11.Tables["t_bl_entete"].Rows.Add(newRow);
					button12.Enabled=true;
					txBL.Text=NumBL.ToString();
					oleDbConnection1.Open();
					Transac=oleDbConnection1.BeginTransaction();
					oleDbInsertCommand12.Transaction=Transac;
					try
					{
						oleDbDataAdapter12.Update(dataSet11);
						try
						{
							Transac.Commit();
						}
						catch(OleDbException excp)
						{
							MessageBox.Show(excp.Message);
						}
						finally
						{
							oleDbConnection1.Close();
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				}
				else
				{
					NumBL=BLExiste;
					button12.Enabled=true;
					txBL.Text=NumBL.ToString();

					oleDbConnection1.Open();
					Transac=oleDbConnection1.BeginTransaction();
					Comm.CommandText="update t_bl_entete set [Total BL]="+txTotalDevis.ToString().Replace(",",".")+" where [n° bl]="+txBL.Text;
					Comm.Transaction=Transac;
					try
					{
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
						}
						catch(OleDbException exp)
						{
							MessageBox.Show(exp.Message);
						}
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
						MessageBox.Show(Comm.CommandText);
					}
				}
				try
				{
					oleDbDataAdapter13.Fill(dataSet11);
				}
				catch(Exception exp)
				{

				}
				finally
				{
					oleDbConnection1.Close();
				}
				DataRow newRow2 =dataSet11.Tables["t_bl_lignes"].NewRow();
				newRow2["N° BL"]=NumBL;
				newRow2["N° Devis"]=txNumDevis.Text;
				if(txMabec.TextLength>0)
					newRow2["Code mabec"]=txMabec.Text;
				else
					newRow2["Code mabec"]="?";
				newRow2["Type materiel"]=txTypeMachine.Text;
				newRow2["Code materiel"]=txCodeOpindus.Text;
				newRow2["Fournisseur"]=txFournisseur.Text;
				if(txTroncon.TextLength>0)
					newRow2["Troncon"]=txTroncon.Text;
				else
					newRow2["Troncon"]="?";
				newRow2["Total ligne"]=txTotalDevis.Text.Trim('€');
				newRow2["Montant"]="?";
				newRow2["Code ventilation"]=1;
				dataSet11.Tables["t_bl_lignes"].Rows.Add(newRow2);
				oleDbConnection1.Open();
				oleDbInsertCommand13.Connection=oleDbConnection1;
				Transac=oleDbConnection1.BeginTransaction();
				oleDbInsertCommand13.Transaction=Transac;
				try
				{
					oleDbDataAdapter13.Update(dataSet11);
					try
					{
						Transac.Commit();
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
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.CommandText="update t_devis_entete set [N° Bl]="+txBL.Text+" where [n° devis]="+txNumDevis.Text;
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
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
				button11.Enabled=false;
				txEtat.Text="Matériel réparé";
				mtgcComboBox2.Enabled=false;
				mtgcComboBox12.Enabled=true;
				button18.Enabled=true;
				ds.Tables["BLEX"].Clear();
				
			}
			else
				MessageBox.Show("Veuillez indiquer un remonteur SVP");
		}

		private void button15_Click(object sender, System.EventArgs e)
		{
			button14.Visible=false;
			button15.Visible=false;
			textBox35.Visible=false;
		}

		private void button14_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Confirmez vous le changement ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
			{
				string Ancien=textBox1.Text;
				string ID=textBox6.Text;
				string Nouveau=textBox35.Text;
				oleDbConnection1.Open();
				Comm.CommandText="update t_pieces_detachees set code='"+Nouveau+"', code_1='"+Ancien+"' where identificateur="+ID;
				Comm.ExecuteNonQuery();
				oleDbConnection1.Close();
				mtgcComboBox3.Items.Clear();
				mtgcComboBox5.Items.Clear();
				mtgcComboBox9.Items.Clear();
				dataSet11.Tables["t_pieces_detachees"].Clear();
				oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Code,T_pieces_detachees.Code_1, T_pieces_detachees.Designation, T_fournisseurs.Nom,T_pieces_detachees.Identificateur FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				mtgcComboBox3.SourceDataString=new string[]{"code","designation","nom","Identificateur"};
				mtgcComboBox3.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];
				dataSet11.Tables["t_pieces_detachees"].Clear();
				oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Identificateur,T_pieces_detachees.Code, T_pieces_detachees.Designation, T_fournisseurs.Nom FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				mtgcComboBox9.SourceDataString=new string[]{"Identificateur","code","designation","nom"};
				mtgcComboBox9.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];

				mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(Nouveau);
				textBox8.Text=Ancien;
				textBox1.Text=Nouveau;
				button14.Visible=false;
				button15.Visible=false;
				textBox35.Visible=false;
				MessageBox.Show("Enregistrement terminé");
			}
		}

		private void button12_Click(object sender, System.EventArgs e)
		{
			BL WinBL = new BL(Agence, txBL.Text);
			WinBL.ShowDialog();
			this.Refresh();
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			Save(false);
			oleDbConnection1.Open();
			Transac=oleDbConnection1.BeginTransaction();
			Comm.Connection=oleDbConnection1;
			Comm.Transaction=Transac;
            Comm.CommandText = "UPDATE t_parc_machine SET [Date reforme]='" + DateTime.Now.ToShortDateString() + "' , [No dernier devis]=" + txNumDevis.Text + ", [en reparation]=False WHERE [code machine opindus]='" + txCodeOpindus.Text + "'";
			try
			{
				Comm.ExecuteNonQuery();
				try
				{
					Transac.Commit();
				}
				catch(OleDbException ex)
				{
					Transac.Rollback();
					Console.Write(ex.Message);
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
			oleDbConnection1.Open();
			Comm.Connection=oleDbConnection1;
			Transac=oleDbConnection1.BeginTransaction();
			Comm.Transaction=Transac;
			Comm.CommandText="update t_devis_entete set [niveau]=8, [Total pieces]=0,[Forfait DNR]=0,[Forfait transport]=0,[Forfait controle]=0,[Total devis]=0,Reforme=True,[Date decision]='"+DateTime.Now.ToShortDateString()+"', [Date reparation]='"+DateTime.Now.ToShortDateString()+"' where [n° devis]="+txNumDevis.Text;
			try
			{
				Comm.ExecuteNonQuery();

                Comm.CommandText = "update t_devis_lignes set [Quantite]=0 , [Prix de vente]=0,[Prix achat net]=0,[Total ligne]=0 where [N° Devis]=" + txNumDevis.Text;

                Comm.ExecuteNonQuery();

                Comm.CommandText = "insert into t_parc_machine_historique ([Code machine opindus],Dateinter,description,typeinterv,infos_1,infos_1_1,infos_3) VALUES ('" + txCodeOpindus.Text.Replace("'", "''") + "','" + DateTime.Now.ToShortDateString() + "','Machine réformée',0,'Devis N° : " + txNumDevis.Text + " du " + txDate.Text + "','Décision : REFORME','Montant du devis : 0,,00 €')";
                Comm.ExecuteNonQuery();

				try
				{
					Transac.Commit();
					MessageBox.Show("Mise à jour terminée");
				}
				catch(OleDbException ex)
				{
					Transac.Rollback();
					Console.Write(ex.Message);
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

			int BLExiste=0;
			Comm.CommandText="SELECT T_BL_entete.[N° BL], T_BL_entete.[Total bl] FROM T_BL_entete WHERE (((T_BL_entete.[Code client])="+txCodeCli.Text+") AND ((T_BL_entete.[N° Commande ouverte])='"+txCommande.Text+"') AND ((T_BL_entete.[OR])='"+txOrdre.Text+"') AND ((T_BL_entete.Edite)=False)) GROUP BY T_BL_entete.[N° BL], T_BL_entete.[Total bl]";
			//MessageBox.Show(Comm.CommandText);
			DataAD.SelectCommand=Comm;
				
			try
			{
				DataAD.Fill(ds,"BLEX");
				BLExiste=System.Convert.ToInt32(ds.Tables["BLEX"].Rows[0]["n° bl"].ToString());
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			
			int NumBL=0;
			if(BLExiste.Equals(0))
			{
				Comm.CommandText="SELECT Max(T_BL_entete.[N° BL]) AS [MaxDeN° BL] FROM T_BL_entete";
				try
				{
					oleDbConnection1.Open();
					NumBL=System.Convert.ToInt32(Comm.ExecuteScalar())+1;
					oleDbConnection1.Close();
					Comm.CommandText="INSERT INTO t_bl_entete ([N° BL],[Date],[Code client],[n° commande ouverte],[OR],[Total BL],[Code TVA]) VALUES ("+NumBL+",'"+DateTime.Now.ToShortDateString()+"',"+txCodeCli.Text+",'"+txCommande.Text+"','"+txOrdre.Text+"',0,1)";
					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						MessageBox.Show(Comm.CommandText);
						try
						{
							Transac.Commit();
							button12.Enabled=true;
							txBL.Text=NumBL.ToString();
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
				catch
				{
					MessageBox.Show("Erreur dans la base de données");
				}
			}
			else
			{
				NumBL=BLExiste;
				button12.Enabled=true;
				txBL.Text=NumBL.ToString();
				Double BLTotal=System.Convert.ToDouble(ds.Tables["BLEX"].Rows[0]["Total bl"].ToString());
				Double Total=System.Convert.ToDouble(txTotalDevis.Text.Trim('€'))+BLTotal;
				dataSet11.Tables["t_bl_entete"].Clear();
				Comm.CommandText="select * from t_bl_entete where [n° bl]="+txBL.Text;
				oleDbDataAdapter12.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter12.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				Double TotalBL=System.Convert.ToDouble(dataSet11.Tables["t_bl_entete"].Rows[0]["Total bl"].ToString());
				TotalBL+=Total;
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.CommandText="update t_bl_entete set [Total BL]=0 where [n° bl]="+txBL.Text;
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(OleDbException exp)
					{
						Transac.Rollback();
						MessageBox.Show(exp.Message);
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
					MessageBox.Show(Comm.CommandText);
				}
				finally
				{
					oleDbConnection1.Close();
				}
			}
			ds.Tables["BLEX"].Clear();
			if(txMabec.TextLength.Equals(0))
				txMabec.Text="?";
			if(txTroncon.TextLength.Equals(0))
				txTroncon.Text="?";
			Comm.CommandText="INSERT INTO t_bl_lignes ([N° BL],[N° devis],[Code mabec],[Type materiel],[Code materiel],[Fournisseur],[Montant],[Troncon],[Total ligne],[Code ventilation]) VALUES ("+txBL.Text+","+txNumDevis.Text+",'"+txMabec.Text+"','"+txTypeMachine.Text+"','"+txCodeOpindus.Text+"','"+txFournisseur.Text+"','Reformé','"+txTroncon.Text+"',0,1)";

			try
			{
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.Transaction=Transac;
				Comm.ExecuteNonQuery();
				MessageBox.Show(Comm.CommandText);
				try
				{
					Transac.Commit();
					button12.Enabled=true;
					txBL.Text=NumBL.ToString();
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

			oleDbConnection1.Open();
			Transac=oleDbConnection1.BeginTransaction();
			Comm.CommandText="update t_devis_entete set [N° Bl]="+txBL.Text+" where [n° devis]="+txNumDevis.Text;
			Comm.Transaction=Transac;
			try
			{
				Comm.ExecuteNonQuery();
				try
				{
					Transac.Commit();
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
			button7.Enabled=false;
			button8.Enabled=false;
			button9.Enabled=false;
			button10.Enabled=false;
			button11.Enabled=false;
			textBox34.Text="0.00";
			txTotalDevis.Text="0.00";
			txEtat.Text="Matériel réformé";
			mtgcComboBox1.Enabled=false;
			mtgcComboBox2.Enabled=false;
			txCommande.Enabled=false;
			mtgcComboBox8.Enabled=false;
		}

		private void textBox3_Leave(object sender, System.EventArgs e)
		{
			if(textBox2.TextLength>0)
			{
				try
				{
				
					textBox2.Text=textBox2.Text.Replace(".",",");
					textBox3.Text=textBox3.Text.Replace(".",",");
					textBox5.Text=textBox5.Text.Replace(".",",");
					txNetCommande.Text=txNetCommande.Text.Replace(".",",");
					string P = numericUpDown2.Value.ToString();
					Decimal Pourc = System.Convert.ToDecimal(P);
					Pourc/=100;
					Decimal Reduc = System.Convert.ToDecimal(textBox3.Text);
					Reduc *=Pourc;
					Decimal Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
					txNetCommande.Text=Prix.ToString("0.00");
					Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc);
					textBox5.Text=Prix.ToString("0.00");
					
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				string Cause=null;
				if(mtgcComboBox4.SelectedIndex==-1)
					Cause="";
				else
					Cause=mtgcComboBox4.Text;
				string Provisoire=null;
				if(textBox8.Text.Length>0)
					Provisoire=textBox8.Text;
				else
					Provisoire="?";
				listView1.Items.Add(textBox1.Text);
				listView1.Items[listView1.Items.Count-1].SubItems.Add(textBox2.Text);
				listView1.Items[listView1.Items.Count-1].SubItems.Add(numericUpDown1.Value.ToString());
				try
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(textBox3.Text).ToString("0.00"));
				}
				catch(Exception exp)
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add("0.00");
					Console.WriteLine(exp.Message);

				}
				try
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(txNetCommande.Text).ToString("0.00"));
				}
				catch(Exception exp)
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add("0.00");
					Console.WriteLine(exp.Message);

				}
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Cause);
				listView1.Items[listView1.Items.Count-1].SubItems.Add(textBox6.Text);
				dataSet11.Tables["t_devis_lignes"].Clear();
				Comm.Connection=oleDbConnection1;
				Decimal Pourcent=0;
				try
				{
				
						if(numericUpDown2.Value!=0)
						Pourcent=numericUpDown2.Value/100;
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				
				textBox3.Text=textBox3.Text.Replace(",",".");
				textBox5.Text=textBox5.Text.Replace(",",".");
				txNetCommande.Text=txNetCommande.Text.Replace(",",".");
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
                Comm.CommandText = "insert into t_devis_lignes ([N° devis],[Code piece],[Code piece provisoire],[Designation],[Cause],[Quantite],[Pourcentage remise],[Prix de vente],[Prix achat net],[Total ligne]) values (" + txNumDevis.Text + "," + textBox6.Text + ",'" + Provisoire + "','" + textBox2.Text.Replace("'", "''") + "'," + Cause.ToString() + "," + numericUpDown1.Value + "," + Pourcent.ToString().Replace(",", ".") + "," + textBox3.Text + "," + ((txPrixAchat.Text.Length > 0) ? txPrixAchat.Text.Replace(",",".") : "0") +"," + txNetCommande.Text + ")";
				Comm.Transaction=Transac;
				try
				{
							Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(Exception excp)
					{
						try
						{
							Transac.Rollback();
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
							Console.WriteLine(excp.Message);
						}
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
				Decimal Total=0;
				for(int i=0;i<listView1.Items.Count;i++)
				{
					Total+=System.Convert.ToDecimal(listView1.Items[i].SubItems[4].Text.Trim('€'));
				}
				textBox34.Text=Total.ToString("0.00");
				textBox19.Text=Total.ToString("0.00");
				textBox7.Text=Total.ToString("0.00");
				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.CommandText="update T_devis_entete set [Total devis]="+textBox34.Text.Replace(",",".")+", [total pieces]="+textBox19.Text.Replace(",",".")+", [Forfait DNR]="+textBox20.Text.Replace(",",".")+", [Forfait controle]="+textBox21.Text.Replace(",",".")+", [Forfait transport]="+textBox22.Text.Replace(",",".")+" where [n° devis]="+txNumDevis.Text;
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(Exception exp)
					{
						try
						{
							Transac.Rollback();
						}
						catch(Exception excp)
						{
							MessageBox.Show(excp.Message);
						}
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
				mtgcComboBox4.SelectedIndex=-1;
				mtgcComboBox5.SelectedIndex=-1;
				mtgcComboBox3.SelectedIndex=-1;
				textBox2.Clear();
				textBox3.Clear();
				textBox4.Clear();
				textBox5.Clear();
				textBox8.Clear();
				txNetCommande.Clear();
				numericUpDown1.Value=1;
				numericUpDown2.Value=0;
				mtgcComboBox3.Text="";
				mtgcComboBox3.SelectedIndex=-1;
				mtgcComboBox5.Text="";
				mtgcComboBox5.SelectedIndex=-1;
				mtgcComboBox9.Text="";
				mtgcComboBox9.SelectedIndex=-1;
				button3.Enabled=false;
			}
		}

		private void textBox3_Enter(object sender, System.EventArgs e)
		{
			textBox3.Select(0,textBox3.Text.Length);
		}

		private void textBox3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{	
				if(textBox2.TextLength>0)
				{
					try
					{
						textBox2.Text=textBox2.Text.Replace(".",",");
						string Pourcent = numericUpDown2.Value.ToString();
						Decimal Pourc = System.Convert.ToDecimal(Pourcent);
						Pourc/=100;
						Decimal Reduc = System.Convert.ToDecimal(textBox3.Text);
						Reduc *=Pourc;
						Decimal Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc)*System.Convert.ToInt32(numericUpDown1.Value);
						txNetCommande.Text=Prix.ToString("0.00");
						Prix = (System.Convert.ToDecimal(textBox3.Text)-Reduc);
						textBox5.Text=Prix.ToString("0.00");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
				
				}
			}
		}

		private void textBox19_Leave_1(object sender, System.EventArgs e)
		{
			textBox19.Text=System.Convert.ToDecimal(textBox19.Text.Replace('.',',')).ToString("0.00");
		}

		private void textBox19_KeyDown_1(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				textBox19.Text=System.Convert.ToDecimal(textBox19.Text.Replace('.',',')).ToString("0.00");
			}
		}

		private void mtgcComboBox3_Enter(object sender, System.EventArgs e)
		{
			if(mtgcComboBox3.Items.Count.Equals(0))
			{
				dataSet11.Tables["t_pieces_detachees"].Clear();
				oleDbDataAdapter9.SelectCommand.CommandText="SELECT T_pieces_detachees.Code,T_pieces_detachees.Code_1, T_pieces_detachees.Designation, T_fournisseurs.Nom,T_pieces_detachees.Identificateur FROM T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] ORDER BY 1"; 
				try
				{
					oleDbDataAdapter9.Fill(dataSet11);
				}
				catch(Exception exp)
				{
				}
				mtgcComboBox3.SourceDataString=new string[]{"Code","designation","nom","identificateur"};
				mtgcComboBox3.SourceDataTable=dataSet11.Tables["t_pieces_detachees"];
			}
		}

		private void button16_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Valider la création ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
			{
				string Provisoire=null;
				if(textBox8.Text.Length>0)
					Provisoire=textBox8.Text;
				else
					Provisoire="?";
				string Cause="";
				if(mtgcComboBox4.SelectedIndex==-1)
					Cause="";
				else
					Cause=mtgcComboBox4.Text;
				Decimal Pourcent=0;
				try
				{
				
					if(numericUpDown2.Value!=0)
						Pourcent=numericUpDown2.Value/100;
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				textBox3.Text=textBox3.Text.Replace(".",",");
				txNetCommande.Text=txNetCommande.Text.Replace(".",",");
				listView1.Items.Add(textBox9.Text);
				listView1.Items[listView1.Items.Count-1].SubItems.Add(textBox2.Text);
				listView1.Items[listView1.Items.Count-1].SubItems.Add(numericUpDown1.Value.ToString());
				try
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(textBox3.Text).ToString("0.00").Replace(".",","));
				}
				catch(Exception exp)
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add("0.00");
					Console.WriteLine(exp.Message);

				}
				try
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(txNetCommande.Text).ToString("0.00").Replace(".",","));
				}
				catch(Exception exp)
				{
					listView1.Items[listView1.Items.Count-1].SubItems.Add("0.00");
					Console.WriteLine(exp.Message);

				}
				listView1.Items[listView1.Items.Count-1].SubItems.Add(Cause);
				listView1.Items[listView1.Items.Count-1].SubItems.Add(textBox6.Text);

				oleDbConnection1.Open();
				Transac=oleDbConnection1.BeginTransaction();
				Comm.CommandText="insert into t_devis_lignes ([N° devis],[Code piece],[Code piece provisoire],[Designation],[Cause],[Quantite],[Pourcentage remise],[Prix de vente],[Prix achat net],[Total ligne]) values ("+txNumDevis.Text+","+textBox6.Text+",'"+Provisoire+"','"+textBox9.Text+"',"+Cause.ToString()+","+numericUpDown1.Value+","+Pourcent.ToString().Replace(",",".")+",0.00,0.00,0.00)";
				MessageBox.Show(Comm.CommandText);
				Comm.Transaction=Transac;
				try
				{
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
					}
					catch(Exception excp)
					{
						try
						{
							Transac.Rollback();
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
							Console.WriteLine(excp.Message);
						}
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
				textBox9.Visible=false;
				mtgcComboBox10.Visible=false;
				mtgcComboBox11.Visible=false;
				button16.Visible=false;
			}
		}

		private void tabPageEX2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button19_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button18_Click(object sender, System.EventArgs e)
		{
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");

			if(mtgcComboBox12.SelectedIndex.Equals(0))
			{
				MessageBox.Show("Veuillez choisir une option","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			if(mtgcComboBox12.SelectedIndex.Equals(1))
			{
				if(Directory.Exists(@"C:\Program Files (x86)\Opindus\Fichier\Devis\"+txCodeOpindus.Text+@"\")==false)
				{
					DirectoryInfo repertoire = Directory.CreateDirectory(@"C:\Program Files (x86)\Opindus\Fichier\Devis\"+txCodeOpindus.Text+@"\"); 
				}
				string path = @"C:\Program Files (x86)\Opindus\Fichier\Devis\"+txCodeOpindus.Text+@"\"+txNumDevis.Text+".csv";
				StreamWriter writer = new StreamWriter(path,false);
				try
				{
					String Ligne = txOrdre.Text+";"+textBox19.Text+";"+textBox20.Text+";"+textBox21.Text+";"+textBox22.Text+";"+txNumDevis.Text+";";
					writer.WriteLine(Ligne);
					MessageBox.Show("Transfert terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				finally
				{
					writer.Close();
				}
			}
			else if(mtgcComboBox12.SelectedIndex.Equals(2))
			{
                

				Comm.CommandText="SELECT Sum(T_devis_entete.[Total devis]) AS [SommeDeTotal devis] FROM T_devis_entete GROUP BY T_devis_entete.Niveau, T_devis_entete.[Code Materiel] HAVING (((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Code Materiel])='"+txCodeOpindus.Text+"'))";
				DataAD.SelectCommand=Comm;
				Decimal Depense=0;
                String MinDateReparation = "";
                String MachineCli = "";
				try
				{
					oleDbConnection1.Open();
					Depense = System.Convert.ToDecimal(Comm.ExecuteScalar());

                    Comm.CommandText = "SELECT [Code machine client] FROM T_parc_machine WHERE [Code machine opindus]='" + txCodeOpindus.Text.Replace("'", "''") + "'";

                    MachineCli = System.Convert.ToString(Comm.ExecuteScalar());
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				finally
				{
					oleDbConnection1.Close();
				}

                Comm.CommandText = "SELECT Min(T_devis_entete.[Date reparation]) FROM T_devis_entete GROUP BY T_devis_entete.Niveau, T_devis_entete.[Code Materiel] HAVING (((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Code Materiel])='" + txCodeOpindus.Text + "'))";
                try
                {
                    oleDbConnection1.Open();
                    MinDateReparation = System.Convert.ToString(Comm.ExecuteScalar());
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
                finally
                {
                    oleDbConnection1.Close();
                }

				Microsoft.Office.Interop.Excel.Application oXL; 
				Microsoft.Office.Interop.Excel._Workbook oWB; 
				Microsoft.Office.Interop.Excel._Worksheet oSheet; 
				Microsoft.Office.Interop.Excel.Range oRng;

				oXL = new Microsoft.Office.Interop.Excel.Application();
				oXL.Application.Visible=false;

				if(Directory.Exists(@"C:\Program Files (x86)\Opindus\Excel\Devis\"+txClient.Text+@"\")==false)
				{
					DirectoryInfo repertoire = Directory.CreateDirectory(@"C:\Program Files (x86)\Opindus\Excel\Devis\"+txClient.Text+@"\"); 
				}
			
				oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\modeles\Devis.xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);
			
				oWB = (Microsoft.Office.Interop.Excel._Workbook)oXL.Workbooks[1];
				oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1];

				Comm.CommandText="SELECT T_clients.Nom, T_clients.Adresse_1, T_clients.Adresse_2, T_clients.Code_Postal, T_clients.Ville, T_clients.Pays FROM T_clients WHERE (((T_clients.Ident)="+txCodeCli.Text+")) GROUP BY T_clients.Nom, T_clients.Adresse_1, T_clients.Adresse_2, T_clients.Code_Postal, T_clients.Ville, T_clients.Pays";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"Client");

                oSheet.Cells[6, 1] = Depense;
                oSheet.Cells[7,1] = "Date de première";
                oSheet.Cells[8, 1] = "intervention :";
                if (MinDateReparation.Length > 0)
                    oSheet.Cells[9, 1] = System.Convert.ToDateTime(MinDateReparation).ToShortDateString();
                else
                    oSheet.Cells[9, 1] = "Jamais entrée";
				oSheet.Cells[4,3] = ds.Tables["Client"].Rows[0]["Nom"].ToString();
				oSheet.Cells[5,3] = ds.Tables["Client"].Rows[0]["Adresse_1"].ToString();
				oSheet.Cells[6,3] = ds.Tables["Client"].Rows[0]["Adresse_2"].ToString();
				oSheet.Cells[7,3] = ds.Tables["Client"].Rows[0]["Code_Postal"].ToString()+" "+ds.Tables["Client"].Rows[0]["Ville"].ToString();
				oSheet.Cells[8,3] = ds.Tables["Client"].Rows[0]["Pays"].ToString();
				ds.Tables["Client"].Clear();
                /*Range rg = (Range)oSheet.Range["E2", "F2"];
                rg.ClearFormats();
                rg.NumberFormat = "MM/DD/YYYY";
                String mois = txDateEdit.Text;*/
                oSheet.Cells[2, 5] = txDateEdit.Text;
                /*String mois = DateTime.Now.ToString("dd") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yyyy");
                oSheet.Cells[2, 5] = mois;*/
				oSheet.Cells[14,1] = txCodeOpindus.Text;
                if (MachineCli.Length > 0)
                    oSheet.Cells[14, 2] = MachineCli;
                else
                    oSheet.Cells[14, 2] = txCodeOpindus.Text;
				oSheet.Cells[14,3] = txTypeMachine.Text;
				oSheet.Cells[15,3] = txDescription.Text;
				oSheet.Cells[14,5] = txFournisseur.Text;
				oSheet.Cells[11,3] = txNumDevis.Text;
				oSheet.Cells[17,1] = txOrdre.Text;
				oSheet.Cells[17,2] = txCommande.Text;
                oSheet.Cells[18, 1] = txRemCauseClient.Text;
				oSheet.Cells[18,4] = txRemCauseAtelier.Text;
				oSheet.Cells[17,5] = txMabec.Text;
                oSheet.Cells[57,6] = textBox19.Text;
				oSheet.Cells[58,6] = textBox20.Text;
				oSheet.Cells[59,6] = textBox21.Text;
				oSheet.Cells[60,6] = textBox22.Text;
                oSheet.Cells[61,6] = textBox24.Text;
				oSheet.Cells[61,1] = label55.Text;
				oSheet.Cells[62,1] = label56.Text;
				oSheet.Cells[64,1] = label57.Text;
				oSheet.Cells[6,1] = Depense.ToString("c");

				Decimal PrixMachine=0;

				if(textBox28.TextLength>0)
					PrixMachine=System.Convert.ToDecimal(textBox28.Text);
				
				Decimal Total=0;
				try
				{
					Total=System.Convert.ToDecimal(textBox24.Text);
				}
				catch

				{
				}
				Decimal Pourcent=0;
				if(Total!=0&&PrixMachine!=0)
					Pourcent= (Total/PrixMachine)*100;
				else
					Pourcent=0;

				oSheet.Cells[57,2] = Pourcent.ToString("0.00")+"%";
				oSheet.Cells[58,2] = PrixMachine.ToString("c");
				oSheet.Cells[59,2] = textBox29.Text+"%";

				/*Comm.CommandText="SELECT T_pieces_detachees.Code, t_devis_lignes.Designation, t_devis_lignes.Quantite, t_devis_lignes.[Prix de vente], t_devis_lignes.[Total ligne], T_causes.Designation FROM T_pieces_detachees INNER JOIN (T_devis_entete INNER JOIN (t_devis_lignes INNER JOIN T_causes ON t_devis_lignes.Cause = T_causes.Code) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_pieces_detachees.Identificateur = t_devis_lignes.[Code piece] WHERE (((T_devis_entete.[N° Devis])="+txNumDevis.Text+")) GROUP BY T_pieces_detachees.Code, t_devis_lignes.Designation, t_devis_lignes.Quantite, t_devis_lignes.[Prix de vente], t_devis_lignes.[Total ligne], T_causes.Designation";

				//Comm.CommandText="SELECT t_devis_lignes.[Code piece], t_devis_lignes.Designation, t_devis_lignes.Quantite, t_devis_lignes.[Prix de vente], t_devis_lignes.[Total ligne], T_causes.Designation FROM (T_devis_entete INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) INNER JOIN T_causes ON t_devis_lignes.Cause = T_causes.Code WHERE (((T_devis_entete.[N° Devis])="+txNumDevis.Text+")) GROUP BY t_devis_lignes.[Code piece], t_devis_lignes.Designation, t_devis_lignes.Quantite, t_devis_lignes.[Prix de vente], t_devis_lignes.[Total ligne], T_causes.Designation"; 
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"Lignes");

				int Cell=20;
				foreach(DataRow row in ds.Tables["Lignes"].Rows)
				{
					oSheet.Cells[Cell,1] = row["Code"].ToString();
					oSheet.Cells[Cell,2] = row["t_devis_lignes.Designation"].ToString();
					oSheet.Cells[Cell,3] = row["Quantite"].ToString();
					oSheet.Cells[Cell,4] = row["Prix de vente"].ToString();
					oSheet.Cells[Cell,5] = row["Total ligne"].ToString();
					oSheet.Cells[Cell,6] = row["T_causes.Designation"].ToString();
					Cell++;
				}*/

                dataSet11.t_devis_lignes.Clear();

                Comm.CommandText = "SELECT T_devis_lignes.*, T_causes.Designation AS Desi FROM T_devis_lignes INNER JOIN T_causes ON T_devis_lignes.Cause = T_causes.Code where [N° Devis]=" + System.Convert.ToInt32(txNumDevis.Text);
                oleDbDataAdapter11.SelectCommand = Comm;
                try
                {
                    oleDbDataAdapter11.Fill(dataSet11);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }

                int Cell = 20;

                foreach (DataRow Lignes in dataSet11.Tables["t_devis_lignes"].Rows)
                {
                    dataSet11.Tables["t_pieces_detachees"].Clear();
                    Comm.CommandText = "select * from t_pieces_detachees where [Identificateur]=" + Lignes["Code piece"].ToString();
                    oleDbDataAdapter9.SelectCommand = Comm;
                    try
                    {
                        oleDbDataAdapter9.Fill(dataSet11);
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine(exp.Message);
                    }

                    DataRow row = dataSet11.Tables["t_pieces_detachees"].Rows[0];

                    oSheet.Cells[Cell, 1] = row["Code"].ToString();
                    oSheet.Cells[Cell, 2] = Lignes["Designation"].ToString();
                    oSheet.Cells[Cell, 3] = Lignes["Quantite"].ToString();
                    oSheet.Cells[Cell, 4] = Lignes["Prix de vente"].ToString();
                    oSheet.Cells[Cell, 5] = Lignes["Total ligne"].ToString();
                    oSheet.Cells[Cell, 6] = Lignes["Desi"].ToString();
                    Cell++;

                    /*listView1.Items.Add(dataSet11.Tables["t_pieces_detachees"].Rows[0]["Code"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Lignes["Designation"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Lignes["Quantite"].ToString());
                    try
                    {
                        if (radioButton2.Checked != true)
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(System.Convert.ToDouble(Lignes["Prix de vente"].ToString()).ToString("c"));
                        else
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add("0,00€");
                    }
                    catch (Exception exp)
                    {
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add("0,00 €");
                        Console.WriteLine(exp.Message);
                    }
                    try
                    {
                        if (radioButton2.Checked != true)
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(System.Convert.ToDouble(Lignes["Total ligne"].ToString()).ToString("c"));
                        else
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add("0,00€");
                    }
                    catch (Exception exp)
                    {
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add("0,00 €");
                        Console.WriteLine(exp.Message);
                    }
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Lignes["Cause"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Lignes["Code piece"].ToString());*/
                }

                dataSet11.Tables["t_devis_lignes"].Clear();

				oXL.Workbooks[1].SaveAs(@"C:\Program Files (x86)\Opindus\Excel\Devis\"+txClient.Text+@"\"+txNumDevis.Text+".xls",Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,"","",false,false,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,null,null,null,null,null); 
				if(oXL != null)
				{
					oXL.Quit();
					System.Runtime.InteropServices.Marshal.ReleaseComObject (oXL);
					oXL = null;		
				}
				oXL = new Microsoft.Office.Interop.Excel.Application();
				oXL.Application.Visible=true;
				oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\Excel\Devis\"+txClient.Text+@"\"+txNumDevis.Text+".xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);
			}
		}

		private void button17_Click(object sender, System.EventArgs e)
		{
		
		}

        private void txDateEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 8)
            {
                if (txDateEdit.TextLength.Equals(2))
                {
                    txDateEdit.Text += "/";
                    txDateEdit.Select(3, 1);
                }
                else if (txDateEdit.TextLength.Equals(5))
                {
                    txDateEdit.Text += "/";
                    txDateEdit.Select(6, 1);
                }
                else if (txDateEdit.TextLength.Equals(7))
                    button18.Focus();
            }
        }
	}
}
