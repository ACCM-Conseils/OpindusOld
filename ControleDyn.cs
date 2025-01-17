using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Microsoft.CSharp;

namespace Opindus
{
	/// <summary>
	/// Description résumée de ControleDyn.
	/// </summary>
	public class ControleDyn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private MTGCComboBox mtgcComboBox1;
		private MTGCComboBox mtgcComboBox2;
		private MTGCComboBox mtgcComboBox3;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.GroupBox groupBox15;
		private System.Windows.Forms.GroupBox groupBox16;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.GroupBox groupBox17;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.GroupBox groupBox19;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.GroupBox groupBox20;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.GroupBox groupBox21;
		private System.Windows.Forms.TextBox textBox28;
		private System.Windows.Forms.GroupBox groupBox22;
		private System.Windows.Forms.TextBox textBox29;
		private System.Windows.Forms.GroupBox groupBox23;
		private System.Windows.Forms.GroupBox groupBox24;
		private System.Windows.Forms.TextBox textBox30;
		private System.Windows.Forms.GroupBox groupBox25;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.GroupBox groupBox26;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.GroupBox groupBox27;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.GroupBox groupBox28;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.GroupBox groupBox29;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.GroupBox groupBox30;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.TextBox textBox37;
		private System.Windows.Forms.TextBox textBox38;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox textBox39;
		private System.Windows.Forms.TextBox textBox40;
		private System.Windows.Forms.TextBox textBox41;
		private System.Windows.Forms.TextBox textBox42;
		private System.Windows.Forms.GroupBox groupBox31;
		private System.Windows.Forms.GroupBox groupBox32;
		private System.Windows.Forms.GroupBox groupBox33;
		private System.Windows.Forms.GroupBox groupBox34;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private MTGCComboBox mtgcComboBox4;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
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
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		private OleDbTransaction Transac;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private bool save;
		private OleDbCommand Comm;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		Object oRien=System.Reflection.Missing.Value;
		private System.Windows.Forms.TextBox txidcli;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ControleDyn(int Agence, string Machine)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			Comm=new OleDbCommand();

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

			oleDbSelectCommand1.CommandText="SELECT T_parc_machine.[Code machine Opindus], T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site FROM T_famille_machine INNER JOIN ((T_site INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_site.ID = T_parc_machine.Site) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_parc_machine.[Code machine Opindus])='"+Machine+"'))"; 
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			
			save=false;
			textBox1.Text=dataSet11.Tables["T_famille_machine"].Rows[0]["Code machine opindus"].ToString();
			textBox2.Text=dataSet11.Tables["T_famille_machine"].Rows[0]["Nom"].ToString();
			textBox3.Text=dataSet11.Tables["T_famille_machine"].Rows[0]["Type machine"].ToString();
			textBox4.Text=dataSet11.Tables["T_famille_machine"].Rows[0]["Code mabec"].ToString();
			textBox5.Text=dataSet11.Tables["T_famille_machine"].Rows[0]["Affectation"].ToString();
			textBox6.Text=dataSet11.Tables["T_famille_machine"].Rows[0]["Site"].ToString();
			textBox8.Text=DateTime.Today.ToShortDateString();

			oleDbDataAdapter2.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_parc_ets"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["chaine"].ToString(),"","",""));
			}
			oleDbDataAdapter3.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_reparateurs"].Rows)
			{
				mtgcComboBox3.Items.Add(new MTGCComboBoxItem(row["ID"].ToString(),row["nom"].ToString(),"",""));
			}
			oleDbDataAdapter4.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_parc_capteurs"].Rows)
			{
				MTGCComboBoxItem Item = new MTGCComboBoxItem(row["chaine"].ToString(),"","","");
				Item.Tag=row["ID"].ToString();
				mtgcComboBox2.Items.Add(Item);
			}

			mtgcComboBox1.SelectedIndex=0;
			mtgcComboBox2.SelectedIndex=0;
			mtgcComboBox3.SelectedIndex=0;

			oleDbSelectCommand5.CommandText="SELECT T_type_machine_dyn.C_mini, T_type_machine_dyn.C_maxi, T_type_machine_dyn_iso.Type, T_type_machine_dyn_iso.classe, T_type_machine_dyn_iso.precision FROM T_type_machine_dyn_iso INNER JOIN T_type_machine_dyn ON T_type_machine_dyn_iso.ID = T_type_machine_dyn.idIso WHERE (((T_type_machine_dyn.Code)='"+textBox3.Text+"')) GROUP BY T_type_machine_dyn.C_mini, T_type_machine_dyn.C_maxi, T_type_machine_dyn_iso.Type, T_type_machine_dyn_iso.classe, T_type_machine_dyn_iso.precision";
			try
			{
				oleDbDataAdapter5.Fill(dataSet11);
				if(dataSet11.Tables["t_type_machine_dyn"].Rows.Count>0)
				{
					textBox10.Text=dataSet11.Tables["t_type_machine_dyn"].Rows[0]["type"].ToString();
					textBox11.Text=dataSet11.Tables["t_type_machine_dyn"].Rows[0]["classe"].ToString();
					textBox12.Text=System.Convert.ToDecimal(dataSet11.Tables["t_type_machine_dyn"].Rows[0]["c_mini"].ToString()).ToString("0.00");
					textBox13.Text=System.Convert.ToDecimal(dataSet11.Tables["t_type_machine_dyn"].Rows[0]["c_maxi"].ToString()).ToString("0.00");
					try
					{
						Decimal precision=System.Convert.ToDecimal(dataSet11.Tables["t_type_machine_dyn"].Rows[0]["precision"].ToString())*100;
						textBox14.Text=precision.ToString("0.00")+"%";
					}
					catch(Exception exp)
					{
						textBox14.Text="0.00";
						Console.WriteLine(exp.Message);
					}
					textBox30.Text=System.Convert.ToDecimal(textBox13.Text).ToString("0.00");
					decimal Plein=System.Convert.ToDecimal(textBox30.Text);
					decimal moitie=Decimal.Multiply(Plein,new decimal(0.6));
					decimal petit=Decimal.Multiply(Plein,new decimal(0.2));
					textBox23.Text=moitie.ToString("0.00");
					textBox22.Text=petit.ToString("0.00");
				}
				mtgcComboBox4.Items.Add(new MTGCComboBoxItem("1","","",""));
				mtgcComboBox4.Items.Add(new MTGCComboBoxItem("2","","",""));
				mtgcComboBox4.Items.Add(new MTGCComboBoxItem("3","","",""));
				mtgcComboBox4.Items.Add(new MTGCComboBoxItem("4","","",""));
				mtgcComboBox4.SelectedIndex=3;

				dataSet11.Clear();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			try
			{
				oleDbConnection1.Open();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="SELECT Max(T_controles_dym.[N° Controle]) AS [MaxDeN° Controle] FROM T_controles_dym";
				int nbr=System.Convert.ToInt32(Comm.ExecuteScalar());
				nbr++;
				textBox7.Text=nbr.ToString();
			}
			catch(Exception exp)
			{
				int nbr=1;
				textBox7.Text=nbr.ToString();
			}
			finally
			{
				oleDbConnection1.Close();
			}
			
		}

		public ControleDyn(int Agence, int NumControle, string client)
		{
			InitializeComponent();

			Comm=new OleDbCommand();
			
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
			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			txidcli.Text=client;
			dataSet11.Clear();
			oleDbSelectCommand6.CommandText="select * from t_controles_dym where [n° controle]="+NumControle.ToString();
			oleDbDataAdapter6.Fill(dataSet11);

			textBox16.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["r_20"].ToString()).ToString("0.00");
			textBox17.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_001_20"].ToString()).ToString("0.00");
			textBox18.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_002_20"].ToString()).ToString("0.00");
			textBox19.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_003_20"].ToString()).ToString("0.00");
			textBox20.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_004_20"].ToString()).ToString("0.00");
			textBox21.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_005_20"].ToString()).ToString("0.00");

			textBox29.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["r_60"].ToString()).ToString("0.00");
			textBox28.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_001_60"].ToString()).ToString("0.00");
			textBox27.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_002_60"].ToString()).ToString("0.00");
			textBox26.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_003_60"].ToString()).ToString("0.00");
			textBox25.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_004_60"].ToString()).ToString("0.00");
			textBox24.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_005_60"].ToString()).ToString("0.00");

			textBox36.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["r_100"].ToString()).ToString("0.00");
			textBox35.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_001_100"].ToString()).ToString("0.00");
			textBox34.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_002_100"].ToString()).ToString("0.00");
			textBox33.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_003_100"].ToString()).ToString("0.00");
			textBox32.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_004_100"].ToString()).ToString("0.00");
			textBox31.Text=System.Convert.ToDecimal(dataSet11.Tables["t_controles_dym"].Rows[0]["val_005_100"].ToString()).ToString("0.00");

			textBox9.Text=dataSet11.Tables["t_controles_dym"].Rows[0]["commentaire"].ToString();
			oleDbDataAdapter2.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_parc_ets"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["chaine"].ToString(),"","",""));
			}
			oleDbDataAdapter3.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_reparateurs"].Rows)
			{
				mtgcComboBox3.Items.Add(new MTGCComboBoxItem(row["ID"].ToString(),row["nom"].ToString(),"",""));
			}
			oleDbDataAdapter4.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_parc_capteurs"].Rows)
			{
				MTGCComboBoxItem Item = new MTGCComboBoxItem(row["chaine"].ToString(),"","","");
				Item.Tag=row["ID"].ToString();
				mtgcComboBox2.Items.Add(Item);
			}
			
			mtgcComboBox1.Enabled=true;
			mtgcComboBox2.Enabled=true;
			mtgcComboBox3.Enabled=true;
			mtgcComboBox4.Enabled=true;

			mtgcComboBox4.Items.Add(new MTGCComboBoxItem("1","","",""));
			mtgcComboBox4.Items.Add(new MTGCComboBoxItem("2","","",""));
			mtgcComboBox4.Items.Add(new MTGCComboBoxItem("3","","",""));
			mtgcComboBox4.Items.Add(new MTGCComboBoxItem("4","","",""));
			mtgcComboBox4.SelectedIndex=3;

			mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindString(dataSet11.Tables["t_controles_dym"].Rows[0]["ets"].ToString());
			foreach(MTGCComboBoxItem Item in mtgcComboBox2.Items)
			{
				if(Item.Tag.ToString().Equals(dataSet11.Tables["t_controles_dym"].Rows[0]["capteur"].ToString()))
					mtgcComboBox2.SelectedItem=Item;
			}
			mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(dataSet11.Tables["t_controles_dym"].Rows[0]["Operateur"].ToString());
			mtgcComboBox4.SelectedIndex=mtgcComboBox4.FindString(dataSet11.Tables["t_controles_dym"].Rows[0]["aspect"].ToString());

			textBox1.Text=dataSet11.Tables["t_controles_dym"].Rows[0]["Code machine opindus"].ToString();
			textBox7.Text=dataSet11.Tables["t_controles_dym"].Rows[0]["N° controle"].ToString();
			textBox8.Text=dataSet11.Tables["t_controles_dym"].Rows[0]["date_controle"].ToString().Remove(10,9);

			DataSet MyData= new DataSet();
			Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_famille_machine.Designation, T_parc_machine.[No serie], T_parc_machine.[Code Mabec], T_parc_machine.[Date mise en service], T_parc_machine.[Date reforme], T_fournisseurs.Nom, T_famille_machine.Designation, T_affectation.Affectation, T_site.Site FROM (T_site INNER JOIN (T_famille_machine INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_site.ID = T_parc_machine.Site) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID WHERE (((T_parc_machine.[Code machine Opindus])='"+textBox1.Text+"'))";
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(MyData,"t_famille_machine");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			textBox2.Text=MyData.Tables["T_famille_machine"].Rows[0]["Nom"].ToString();
			textBox3.Text=MyData.Tables["T_famille_machine"].Rows[0]["Type machine"].ToString();
			textBox4.Text=MyData.Tables["T_famille_machine"].Rows[0]["Code mabec"].ToString();
			textBox5.Text=MyData.Tables["T_famille_machine"].Rows[0]["Affectation"].ToString();
			textBox6.Text=MyData.Tables["T_famille_machine"].Rows[0]["Site"].ToString();

			oleDbSelectCommand5.CommandText="SELECT T_type_machine_dyn.C_mini, T_type_machine_dyn.C_maxi, T_type_machine_dyn_iso.Type, T_type_machine_dyn_iso.classe, T_type_machine_dyn_iso.precision FROM T_type_machine_dyn_iso INNER JOIN T_type_machine_dyn ON T_type_machine_dyn_iso.ID = T_type_machine_dyn.idIso WHERE (((T_type_machine_dyn.Code)='"+textBox3.Text+"')) GROUP BY T_type_machine_dyn.C_mini, T_type_machine_dyn.C_maxi, T_type_machine_dyn_iso.Type, T_type_machine_dyn_iso.classe, T_type_machine_dyn_iso.precision";
			try
			{
				oleDbDataAdapter5.Fill(dataSet11);
			}
			catch(Exception exp)
			{
			}
			if(dataSet11.Tables["t_type_machine_dyn"].Rows.Count>0)
			{
				textBox10.Text=dataSet11.Tables["t_type_machine_dyn"].Rows[0]["type"].ToString();
				textBox11.Text=dataSet11.Tables["t_type_machine_dyn"].Rows[0]["classe"].ToString();
				textBox12.Text=System.Convert.ToDecimal(dataSet11.Tables["t_type_machine_dyn"].Rows[0]["c_mini"].ToString()).ToString("0.00");
				textBox13.Text=System.Convert.ToDecimal(dataSet11.Tables["t_type_machine_dyn"].Rows[0]["c_maxi"].ToString()).ToString("0.00");
				try
				{
					Decimal precision=System.Convert.ToDecimal(dataSet11.Tables["t_type_machine_dyn"].Rows[0]["precision"].ToString())*100;
					textBox14.Text=precision.ToString("0.00")+"%";
				}
				catch(Exception exp)
				{
					textBox14.Text="0.00";
					Console.WriteLine(exp.Message);
				}
			}
			if(dataSet11.Tables["t_controles_dym"].Rows[0]["indentification"].ToString().Equals("True"))
				checkBox1.Checked=true;
			else
				checkBox1.Checked=false;
			if(dataSet11.Tables["t_controles_dym"].Rows[0]["marquage"].ToString().Equals("True"))
				checkBox2.Checked=true;
			else
				checkBox2.Checked=false;
			if(dataSet11.Tables["t_controles_dym"].Rows[0]["conf_carre"].ToString().Equals("True"))
				checkBox3.Checked=true;
			else
				checkBox3.Checked=false;
			button3.Enabled=true;
			textBox30.Text=System.Convert.ToDecimal(textBox13.Text).ToString("0.00");
			decimal Plein=System.Convert.ToDecimal(textBox30.Text);
			decimal moitie=Decimal.Multiply(Plein,new decimal(0.6));
			decimal petit=Decimal.Multiply(Plein,new decimal(0.2));
			textBox23.Text=moitie.ToString("0.00");
			textBox22.Text=petit.ToString("0.00");
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ControleDyn));
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
			this.txidcli = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.dataSet11 = new Opindus.DataSet1();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.textBox42 = new System.Windows.Forms.TextBox();
			this.textBox41 = new System.Windows.Forms.TextBox();
			this.textBox40 = new System.Windows.Forms.TextBox();
			this.textBox39 = new System.Windows.Forms.TextBox();
			this.textBox38 = new System.Windows.Forms.TextBox();
			this.textBox37 = new System.Windows.Forms.TextBox();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.textBox22 = new System.Windows.Forms.TextBox();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.groupBox17 = new System.Windows.Forms.GroupBox();
			this.textBox24 = new System.Windows.Forms.TextBox();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.textBox25 = new System.Windows.Forms.TextBox();
			this.groupBox15 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.groupBox16 = new System.Windows.Forms.GroupBox();
			this.textBox23 = new System.Windows.Forms.TextBox();
			this.groupBox19 = new System.Windows.Forms.GroupBox();
			this.textBox26 = new System.Windows.Forms.TextBox();
			this.groupBox20 = new System.Windows.Forms.GroupBox();
			this.textBox27 = new System.Windows.Forms.TextBox();
			this.groupBox21 = new System.Windows.Forms.GroupBox();
			this.textBox28 = new System.Windows.Forms.TextBox();
			this.groupBox22 = new System.Windows.Forms.GroupBox();
			this.textBox29 = new System.Windows.Forms.TextBox();
			this.groupBox23 = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.groupBox24 = new System.Windows.Forms.GroupBox();
			this.textBox30 = new System.Windows.Forms.TextBox();
			this.groupBox25 = new System.Windows.Forms.GroupBox();
			this.textBox31 = new System.Windows.Forms.TextBox();
			this.groupBox26 = new System.Windows.Forms.GroupBox();
			this.textBox32 = new System.Windows.Forms.TextBox();
			this.groupBox27 = new System.Windows.Forms.GroupBox();
			this.textBox33 = new System.Windows.Forms.TextBox();
			this.groupBox28 = new System.Windows.Forms.GroupBox();
			this.textBox34 = new System.Windows.Forms.TextBox();
			this.groupBox29 = new System.Windows.Forms.GroupBox();
			this.textBox35 = new System.Windows.Forms.TextBox();
			this.groupBox30 = new System.Windows.Forms.GroupBox();
			this.textBox36 = new System.Windows.Forms.TextBox();
			this.groupBox31 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox32 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.groupBox33 = new System.Windows.Forms.GroupBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.groupBox34 = new System.Windows.Forms.GroupBox();
			this.mtgcComboBox4 = new MTGCComboBox();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
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
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.groupBox19.SuspendLayout();
			this.groupBox20.SuspendLayout();
			this.groupBox21.SuspendLayout();
			this.groupBox22.SuspendLayout();
			this.groupBox23.SuspendLayout();
			this.groupBox24.SuspendLayout();
			this.groupBox25.SuspendLayout();
			this.groupBox26.SuspendLayout();
			this.groupBox27.SuspendLayout();
			this.groupBox28.SuspendLayout();
			this.groupBox29.SuspendLayout();
			this.groupBox30.SuspendLayout();
			this.groupBox31.SuspendLayout();
			this.groupBox32.SuspendLayout();
			this.groupBox33.SuspendLayout();
			this.groupBox34.SuspendLayout();
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
			this.groupBox1.Size = new System.Drawing.Size(504, 121);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.White;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(128, 88);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(360, 20);
			this.textBox4.TabIndex = 23;
			this.textBox4.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(128, 64);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(360, 20);
			this.textBox3.TabIndex = 22;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(128, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(360, 20);
			this.textBox2.TabIndex = 21;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(128, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(360, 20);
			this.textBox1.TabIndex = 20;
			this.textBox1.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Code Mabec";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Type";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Marque";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
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
			this.groupBox2.Controls.Add(this.txidcli);
			this.groupBox2.Location = new System.Drawing.Point(512, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(400, 121);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.White;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(16, 88);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(368, 20);
			this.textBox6.TabIndex = 35;
			this.textBox6.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.White;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(16, 40);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(368, 20);
			this.textBox5.TabIndex = 24;
			this.textBox5.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "Site";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 18);
			this.label5.TabIndex = 0;
			this.label5.Text = "Affectation";
			// 
			// txidcli
			// 
			this.txidcli.BackColor = System.Drawing.Color.White;
			this.txidcli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txidcli.Location = new System.Drawing.Point(352, 16);
			this.txidcli.Name = "txidcli";
			this.txidcli.ReadOnly = true;
			this.txidcli.Size = new System.Drawing.Size(32, 20);
			this.txidcli.TabIndex = 37;
			this.txidcli.Text = "";
			this.txidcli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox3.Controls.Add(this.textBox9);
			this.groupBox3.Controls.Add(this.textBox8);
			this.groupBox3.Controls.Add(this.textBox7);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Location = new System.Drawing.Point(8, 122);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(504, 134);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// textBox9
			// 
			this.textBox9.AcceptsReturn = true;
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Enabled = false;
			this.textBox9.Location = new System.Drawing.Point(112, 72);
			this.textBox9.Multiline = true;
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(376, 48);
			this.textBox9.TabIndex = 28;
			this.textBox9.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.White;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(112, 48);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(120, 20);
			this.textBox8.TabIndex = 27;
			this.textBox8.Text = "";
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.White;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(112, 24);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(120, 20);
			this.textBox7.TabIndex = 26;
			this.textBox7.Text = "";
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 1;
			this.label8.Text = "Date contrôle";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Numéro contrôle";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = "Commentaires";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox4.Controls.Add(this.mtgcComboBox3);
			this.groupBox4.Controls.Add(this.mtgcComboBox2);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.textBox14);
			this.groupBox4.Controls.Add(this.textBox13);
			this.groupBox4.Controls.Add(this.textBox12);
			this.groupBox4.Controls.Add(this.textBox11);
			this.groupBox4.Controls.Add(this.textBox10);
			this.groupBox4.Controls.Add(this.mtgcComboBox1);
			this.groupBox4.Location = new System.Drawing.Point(512, 120);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(400, 136);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			// 
			// mtgcComboBox3
			// 
			this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox3.ColumnNum = 2;
			this.mtgcComboBox3.ColumnWidth = "50;121";
			this.mtgcComboBox3.DisplayMember = "Text";
			this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox3.DropDownWidth = 191;
			this.mtgcComboBox3.Enabled = false;
			this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox3.GridLineHorizontal = false;
			this.mtgcComboBox3.GridLineVertical = true;
			this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox3.Location = new System.Drawing.Point(102, 104);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(272, 21);
			this.mtgcComboBox3.TabIndex = 36;
			// 
			// mtgcComboBox2
			// 
			this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox2.ColumnNum = 1;
			this.mtgcComboBox2.ColumnWidth = "270";
			this.mtgcComboBox2.DisplayMember = "Text";
			this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox2.DropDownWidth = 290;
			this.mtgcComboBox2.Enabled = false;
			this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox2.GridLineHorizontal = false;
			this.mtgcComboBox2.GridLineVertical = true;
			this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox2.Location = new System.Drawing.Point(102, 80);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(272, 21);
			this.mtgcComboBox2.TabIndex = 35;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(16, 104);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 16);
			this.label17.TabIndex = 12;
			this.label17.Text = "Opérateur";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(16, 80);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(48, 16);
			this.label16.TabIndex = 11;
			this.label16.Text = "Capteur";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(16, 56);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 16);
			this.label15.TabIndex = 10;
			this.label15.Text = "Chaine";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(312, 8);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 16);
			this.label14.TabIndex = 9;
			this.label14.Text = "Précision";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(248, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 16);
			this.label13.TabIndex = 8;
			this.label13.Text = "C. Maxi";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(176, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 7;
			this.label12.Text = "C. Mini";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(104, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 16);
			this.label11.TabIndex = 6;
			this.label11.Text = "Cl. ISO";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(24, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.TabIndex = 5;
			this.label10.Text = "Type ISO";
			// 
			// textBox14
			// 
			this.textBox14.BackColor = System.Drawing.Color.White;
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox14.Location = new System.Drawing.Point(304, 24);
			this.textBox14.Name = "textBox14";
			this.textBox14.ReadOnly = true;
			this.textBox14.Size = new System.Drawing.Size(70, 20);
			this.textBox14.TabIndex = 33;
			this.textBox14.Text = "";
			this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox13
			// 
			this.textBox13.BackColor = System.Drawing.Color.White;
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox13.Location = new System.Drawing.Point(232, 24);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(70, 20);
			this.textBox13.TabIndex = 32;
			this.textBox13.Text = "";
			this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
			// 
			// textBox12
			// 
			this.textBox12.BackColor = System.Drawing.Color.White;
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Location = new System.Drawing.Point(160, 24);
			this.textBox12.Name = "textBox12";
			this.textBox12.ReadOnly = true;
			this.textBox12.Size = new System.Drawing.Size(70, 20);
			this.textBox12.TabIndex = 31;
			this.textBox12.Text = "";
			this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.Color.White;
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Location = new System.Drawing.Point(88, 24);
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(70, 20);
			this.textBox11.TabIndex = 30;
			this.textBox11.Text = "";
			this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.Color.White;
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Location = new System.Drawing.Point(16, 24);
			this.textBox10.Name = "textBox10";
			this.textBox10.ReadOnly = true;
			this.textBox10.Size = new System.Drawing.Size(70, 20);
			this.textBox10.TabIndex = 29;
			this.textBox10.Text = "";
			this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(102, 56);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(272, 21);
			this.mtgcComboBox1.TabIndex = 34;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox5.Controls.Add(this.button3);
			this.groupBox5.Controls.Add(this.button2);
			this.groupBox5.Controls.Add(this.button1);
			this.groupBox5.Location = new System.Drawing.Point(8, 251);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(216, 261);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Enabled = false;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(32, 96);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(144, 23);
			this.button3.TabIndex = 8;
			this.button3.TabStop = false;
			this.button3.Text = "Edition";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Enabled = false;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(32, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 23);
			this.button2.TabIndex = 7;
			this.button2.TabStop = false;
			this.button2.Text = "Enregistrer";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(32, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 23);
			this.button1.TabIndex = 6;
			this.button1.TabStop = false;
			this.button1.Text = "Saisie";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(864, 624);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(48, 48);
			this.button4.TabIndex = 9;
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox6.Controls.Add(this.textBox42);
			this.groupBox6.Controls.Add(this.textBox41);
			this.groupBox6.Controls.Add(this.textBox40);
			this.groupBox6.Controls.Add(this.textBox39);
			this.groupBox6.Controls.Add(this.textBox38);
			this.groupBox6.Controls.Add(this.textBox37);
			this.groupBox6.Controls.Add(this.groupBox14);
			this.groupBox6.Controls.Add(this.groupBox13);
			this.groupBox6.Controls.Add(this.groupBox12);
			this.groupBox6.Controls.Add(this.groupBox11);
			this.groupBox6.Controls.Add(this.groupBox10);
			this.groupBox6.Controls.Add(this.groupBox9);
			this.groupBox6.Controls.Add(this.groupBox8);
			this.groupBox6.Controls.Add(this.groupBox7);
			this.groupBox6.Controls.Add(this.groupBox17);
			this.groupBox6.Controls.Add(this.groupBox18);
			this.groupBox6.Controls.Add(this.groupBox15);
			this.groupBox6.Controls.Add(this.groupBox16);
			this.groupBox6.Controls.Add(this.groupBox19);
			this.groupBox6.Controls.Add(this.groupBox20);
			this.groupBox6.Controls.Add(this.groupBox21);
			this.groupBox6.Controls.Add(this.groupBox22);
			this.groupBox6.Controls.Add(this.groupBox23);
			this.groupBox6.Controls.Add(this.groupBox24);
			this.groupBox6.Controls.Add(this.groupBox25);
			this.groupBox6.Controls.Add(this.groupBox26);
			this.groupBox6.Controls.Add(this.groupBox27);
			this.groupBox6.Controls.Add(this.groupBox28);
			this.groupBox6.Controls.Add(this.groupBox29);
			this.groupBox6.Controls.Add(this.groupBox30);
			this.groupBox6.Controls.Add(this.groupBox31);
			this.groupBox6.Controls.Add(this.groupBox32);
			this.groupBox6.Controls.Add(this.groupBox33);
			this.groupBox6.Controls.Add(this.groupBox34);
			this.groupBox6.Location = new System.Drawing.Point(224, 251);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(688, 261);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			// 
			// textBox42
			// 
			this.textBox42.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox42.ForeColor = System.Drawing.Color.Navy;
			this.textBox42.Location = new System.Drawing.Point(487, 153);
			this.textBox42.Name = "textBox42";
			this.textBox42.Size = new System.Drawing.Size(141, 20);
			this.textBox42.TabIndex = 29;
			this.textBox42.TabStop = false;
			this.textBox42.Text = "Aspect";
			this.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox41
			// 
			this.textBox41.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox41.ForeColor = System.Drawing.Color.Navy;
			this.textBox41.Location = new System.Drawing.Point(346, 153);
			this.textBox41.Name = "textBox41";
			this.textBox41.Size = new System.Drawing.Size(142, 20);
			this.textBox41.TabIndex = 28;
			this.textBox41.TabStop = false;
			this.textBox41.Text = "Carré";
			this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox40
			// 
			this.textBox40.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox40.ForeColor = System.Drawing.Color.Navy;
			this.textBox40.Location = new System.Drawing.Point(206, 153);
			this.textBox40.Name = "textBox40";
			this.textBox40.Size = new System.Drawing.Size(141, 20);
			this.textBox40.TabIndex = 27;
			this.textBox40.TabStop = false;
			this.textBox40.Text = "Marquage";
			this.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox39
			// 
			this.textBox39.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox39.ForeColor = System.Drawing.Color.Navy;
			this.textBox39.Location = new System.Drawing.Point(65, 153);
			this.textBox39.Name = "textBox39";
			this.textBox39.Size = new System.Drawing.Size(142, 20);
			this.textBox39.TabIndex = 26;
			this.textBox39.TabStop = false;
			this.textBox39.Text = "Identification";
			this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox38
			// 
			this.textBox38.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox38.ForeColor = System.Drawing.Color.Navy;
			this.textBox38.Location = new System.Drawing.Point(206, 25);
			this.textBox38.Name = "textBox38";
			this.textBox38.Size = new System.Drawing.Size(71, 20);
			this.textBox38.TabIndex = 25;
			this.textBox38.TabStop = false;
			this.textBox38.Text = "Réglages";
			this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox37
			// 
			this.textBox37.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox37.ForeColor = System.Drawing.Color.Navy;
			this.textBox37.Location = new System.Drawing.Point(276, 25);
			this.textBox37.Name = "textBox37";
			this.textBox37.Size = new System.Drawing.Size(351, 20);
			this.textBox37.TabIndex = 24;
			this.textBox37.TabStop = false;
			this.textBox37.Text = "Mesures";
			this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox14
			// 
			this.groupBox14.Controls.Add(this.label18);
			this.groupBox14.Location = new System.Drawing.Point(66, 39);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(72, 40);
			this.groupBox14.TabIndex = 7;
			this.groupBox14.TabStop = false;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(16, 14);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(48, 23);
			this.label18.TabIndex = 26;
			this.label18.Text = "20%";
			// 
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.textBox22);
			this.groupBox13.Location = new System.Drawing.Point(136, 39);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(72, 40);
			this.groupBox13.TabIndex = 6;
			this.groupBox13.TabStop = false;
			// 
			// textBox22
			// 
			this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox22.Location = new System.Drawing.Point(10, 12);
			this.textBox22.Name = "textBox22";
			this.textBox22.ReadOnly = true;
			this.textBox22.Size = new System.Drawing.Size(48, 21);
			this.textBox22.TabIndex = 0;
			this.textBox22.TabStop = false;
			this.textBox22.Text = "";
			this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.textBox21);
			this.groupBox12.Location = new System.Drawing.Point(556, 39);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(72, 40);
			this.groupBox12.TabIndex = 5;
			this.groupBox12.TabStop = false;
			// 
			// textBox21
			// 
			this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox21.Location = new System.Drawing.Point(10, 12);
			this.textBox21.Name = "textBox21";
			this.textBox21.ReadOnly = true;
			this.textBox21.Size = new System.Drawing.Size(48, 21);
			this.textBox21.TabIndex = 6;
			this.textBox21.Text = "0,00";
			this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox21.Leave += new System.EventHandler(this.textBox21_Leave);
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.textBox20);
			this.groupBox11.Location = new System.Drawing.Point(486, 39);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(72, 40);
			this.groupBox11.TabIndex = 4;
			this.groupBox11.TabStop = false;
			// 
			// textBox20
			// 
			this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox20.Location = new System.Drawing.Point(10, 12);
			this.textBox20.Name = "textBox20";
			this.textBox20.ReadOnly = true;
			this.textBox20.Size = new System.Drawing.Size(48, 21);
			this.textBox20.TabIndex = 5;
			this.textBox20.Text = "0,00";
			this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox20.Leave += new System.EventHandler(this.textBox20_Leave);
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.textBox19);
			this.groupBox10.Location = new System.Drawing.Point(416, 39);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(72, 40);
			this.groupBox10.TabIndex = 3;
			this.groupBox10.TabStop = false;
			// 
			// textBox19
			// 
			this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox19.Location = new System.Drawing.Point(10, 12);
			this.textBox19.Name = "textBox19";
			this.textBox19.ReadOnly = true;
			this.textBox19.Size = new System.Drawing.Size(48, 21);
			this.textBox19.TabIndex = 4;
			this.textBox19.Text = "0,00";
			this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox19.Leave += new System.EventHandler(this.textBox19_Leave);
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.textBox18);
			this.groupBox9.Location = new System.Drawing.Point(346, 39);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(72, 40);
			this.groupBox9.TabIndex = 2;
			this.groupBox9.TabStop = false;
			// 
			// textBox18
			// 
			this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox18.Location = new System.Drawing.Point(10, 12);
			this.textBox18.Name = "textBox18";
			this.textBox18.ReadOnly = true;
			this.textBox18.Size = new System.Drawing.Size(48, 21);
			this.textBox18.TabIndex = 3;
			this.textBox18.Text = "0,00";
			this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox18.Leave += new System.EventHandler(this.textBox18_Leave);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.textBox17);
			this.groupBox8.Location = new System.Drawing.Point(276, 39);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(72, 40);
			this.groupBox8.TabIndex = 1;
			this.groupBox8.TabStop = false;
			// 
			// textBox17
			// 
			this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox17.Location = new System.Drawing.Point(10, 12);
			this.textBox17.Name = "textBox17";
			this.textBox17.ReadOnly = true;
			this.textBox17.Size = new System.Drawing.Size(48, 21);
			this.textBox17.TabIndex = 2;
			this.textBox17.Text = "0,00";
			this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox17.Leave += new System.EventHandler(this.textBox17_Leave);
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.textBox16);
			this.groupBox7.Location = new System.Drawing.Point(206, 39);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(72, 40);
			this.groupBox7.TabIndex = 0;
			this.groupBox7.TabStop = false;
			// 
			// textBox16
			// 
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox16.Location = new System.Drawing.Point(10, 12);
			this.textBox16.Name = "textBox16";
			this.textBox16.ReadOnly = true;
			this.textBox16.Size = new System.Drawing.Size(48, 21);
			this.textBox16.TabIndex = 1;
			this.textBox16.Text = "0,00";
			this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox16.Leave += new System.EventHandler(this.textBox16_Leave);
			// 
			// groupBox17
			// 
			this.groupBox17.Controls.Add(this.textBox24);
			this.groupBox17.Location = new System.Drawing.Point(556, 72);
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.Size = new System.Drawing.Size(72, 40);
			this.groupBox17.TabIndex = 13;
			this.groupBox17.TabStop = false;
			// 
			// textBox24
			// 
			this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox24.Location = new System.Drawing.Point(10, 12);
			this.textBox24.Name = "textBox24";
			this.textBox24.ReadOnly = true;
			this.textBox24.Size = new System.Drawing.Size(48, 21);
			this.textBox24.TabIndex = 12;
			this.textBox24.Text = "0,00";
			this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox24.Leave += new System.EventHandler(this.textBox24_Leave);
			// 
			// groupBox18
			// 
			this.groupBox18.Controls.Add(this.textBox25);
			this.groupBox18.Location = new System.Drawing.Point(486, 72);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(72, 40);
			this.groupBox18.TabIndex = 12;
			this.groupBox18.TabStop = false;
			// 
			// textBox25
			// 
			this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox25.Location = new System.Drawing.Point(10, 12);
			this.textBox25.Name = "textBox25";
			this.textBox25.ReadOnly = true;
			this.textBox25.Size = new System.Drawing.Size(48, 21);
			this.textBox25.TabIndex = 11;
			this.textBox25.Text = "0,00";
			this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox25.Leave += new System.EventHandler(this.textBox25_Leave);
			// 
			// groupBox15
			// 
			this.groupBox15.Controls.Add(this.label19);
			this.groupBox15.Location = new System.Drawing.Point(66, 72);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Size = new System.Drawing.Size(72, 40);
			this.groupBox15.TabIndex = 15;
			this.groupBox15.TabStop = false;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(16, 14);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(53, 23);
			this.label19.TabIndex = 26;
			this.label19.Text = "60%";
			// 
			// groupBox16
			// 
			this.groupBox16.Controls.Add(this.textBox23);
			this.groupBox16.Location = new System.Drawing.Point(136, 72);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Size = new System.Drawing.Size(72, 40);
			this.groupBox16.TabIndex = 14;
			this.groupBox16.TabStop = false;
			// 
			// textBox23
			// 
			this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox23.Location = new System.Drawing.Point(10, 12);
			this.textBox23.Name = "textBox23";
			this.textBox23.ReadOnly = true;
			this.textBox23.Size = new System.Drawing.Size(48, 21);
			this.textBox23.TabIndex = 6;
			this.textBox23.TabStop = false;
			this.textBox23.Text = "";
			this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox19
			// 
			this.groupBox19.Controls.Add(this.textBox26);
			this.groupBox19.Location = new System.Drawing.Point(416, 72);
			this.groupBox19.Name = "groupBox19";
			this.groupBox19.Size = new System.Drawing.Size(72, 40);
			this.groupBox19.TabIndex = 11;
			this.groupBox19.TabStop = false;
			// 
			// textBox26
			// 
			this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox26.Location = new System.Drawing.Point(10, 12);
			this.textBox26.Name = "textBox26";
			this.textBox26.ReadOnly = true;
			this.textBox26.Size = new System.Drawing.Size(48, 21);
			this.textBox26.TabIndex = 10;
			this.textBox26.Text = "0,00";
			this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox26.Leave += new System.EventHandler(this.textBox26_Leave);
			// 
			// groupBox20
			// 
			this.groupBox20.Controls.Add(this.textBox27);
			this.groupBox20.Location = new System.Drawing.Point(346, 72);
			this.groupBox20.Name = "groupBox20";
			this.groupBox20.Size = new System.Drawing.Size(72, 40);
			this.groupBox20.TabIndex = 10;
			this.groupBox20.TabStop = false;
			// 
			// textBox27
			// 
			this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox27.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox27.Location = new System.Drawing.Point(10, 12);
			this.textBox27.Name = "textBox27";
			this.textBox27.ReadOnly = true;
			this.textBox27.Size = new System.Drawing.Size(48, 21);
			this.textBox27.TabIndex = 9;
			this.textBox27.Text = "0,00";
			this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox27.Leave += new System.EventHandler(this.textBox27_Leave);
			// 
			// groupBox21
			// 
			this.groupBox21.Controls.Add(this.textBox28);
			this.groupBox21.Location = new System.Drawing.Point(276, 72);
			this.groupBox21.Name = "groupBox21";
			this.groupBox21.Size = new System.Drawing.Size(72, 40);
			this.groupBox21.TabIndex = 9;
			this.groupBox21.TabStop = false;
			// 
			// textBox28
			// 
			this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox28.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox28.Location = new System.Drawing.Point(10, 12);
			this.textBox28.Name = "textBox28";
			this.textBox28.ReadOnly = true;
			this.textBox28.Size = new System.Drawing.Size(48, 21);
			this.textBox28.TabIndex = 8;
			this.textBox28.Text = "0,00";
			this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox28.Leave += new System.EventHandler(this.textBox28_Leave);
			// 
			// groupBox22
			// 
			this.groupBox22.Controls.Add(this.textBox29);
			this.groupBox22.Location = new System.Drawing.Point(206, 72);
			this.groupBox22.Name = "groupBox22";
			this.groupBox22.Size = new System.Drawing.Size(72, 40);
			this.groupBox22.TabIndex = 8;
			this.groupBox22.TabStop = false;
			// 
			// textBox29
			// 
			this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox29.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox29.Location = new System.Drawing.Point(10, 12);
			this.textBox29.Name = "textBox29";
			this.textBox29.ReadOnly = true;
			this.textBox29.Size = new System.Drawing.Size(48, 21);
			this.textBox29.TabIndex = 7;
			this.textBox29.Text = "0,00";
			this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox29.Leave += new System.EventHandler(this.textBox29_Leave);
			// 
			// groupBox23
			// 
			this.groupBox23.Controls.Add(this.label20);
			this.groupBox23.Location = new System.Drawing.Point(66, 105);
			this.groupBox23.Name = "groupBox23";
			this.groupBox23.Size = new System.Drawing.Size(72, 40);
			this.groupBox23.TabIndex = 23;
			this.groupBox23.TabStop = false;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(11, 14);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(52, 23);
			this.label20.TabIndex = 26;
			this.label20.Text = "100%";
			// 
			// groupBox24
			// 
			this.groupBox24.Controls.Add(this.textBox30);
			this.groupBox24.Location = new System.Drawing.Point(136, 105);
			this.groupBox24.Name = "groupBox24";
			this.groupBox24.Size = new System.Drawing.Size(72, 40);
			this.groupBox24.TabIndex = 22;
			this.groupBox24.TabStop = false;
			// 
			// textBox30
			// 
			this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox30.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox30.Location = new System.Drawing.Point(10, 12);
			this.textBox30.Name = "textBox30";
			this.textBox30.ReadOnly = true;
			this.textBox30.Size = new System.Drawing.Size(48, 21);
			this.textBox30.TabIndex = 13;
			this.textBox30.TabStop = false;
			this.textBox30.Text = "";
			this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox25
			// 
			this.groupBox25.Controls.Add(this.textBox31);
			this.groupBox25.Location = new System.Drawing.Point(556, 105);
			this.groupBox25.Name = "groupBox25";
			this.groupBox25.Size = new System.Drawing.Size(72, 40);
			this.groupBox25.TabIndex = 21;
			this.groupBox25.TabStop = false;
			// 
			// textBox31
			// 
			this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox31.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox31.Location = new System.Drawing.Point(10, 12);
			this.textBox31.Name = "textBox31";
			this.textBox31.ReadOnly = true;
			this.textBox31.Size = new System.Drawing.Size(48, 21);
			this.textBox31.TabIndex = 19;
			this.textBox31.Text = "0,00";
			this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox31.Leave += new System.EventHandler(this.textBox31_Leave);
			// 
			// groupBox26
			// 
			this.groupBox26.Controls.Add(this.textBox32);
			this.groupBox26.Location = new System.Drawing.Point(486, 105);
			this.groupBox26.Name = "groupBox26";
			this.groupBox26.Size = new System.Drawing.Size(72, 40);
			this.groupBox26.TabIndex = 20;
			this.groupBox26.TabStop = false;
			// 
			// textBox32
			// 
			this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox32.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox32.Location = new System.Drawing.Point(10, 12);
			this.textBox32.Name = "textBox32";
			this.textBox32.ReadOnly = true;
			this.textBox32.Size = new System.Drawing.Size(48, 21);
			this.textBox32.TabIndex = 18;
			this.textBox32.Text = "0,00";
			this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox32.Leave += new System.EventHandler(this.textBox32_Leave);
			// 
			// groupBox27
			// 
			this.groupBox27.Controls.Add(this.textBox33);
			this.groupBox27.Location = new System.Drawing.Point(416, 105);
			this.groupBox27.Name = "groupBox27";
			this.groupBox27.Size = new System.Drawing.Size(72, 40);
			this.groupBox27.TabIndex = 19;
			this.groupBox27.TabStop = false;
			// 
			// textBox33
			// 
			this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox33.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox33.Location = new System.Drawing.Point(10, 12);
			this.textBox33.Name = "textBox33";
			this.textBox33.ReadOnly = true;
			this.textBox33.Size = new System.Drawing.Size(48, 21);
			this.textBox33.TabIndex = 17;
			this.textBox33.Text = "0,00";
			this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox33.Leave += new System.EventHandler(this.textBox33_Leave);
			// 
			// groupBox28
			// 
			this.groupBox28.Controls.Add(this.textBox34);
			this.groupBox28.Location = new System.Drawing.Point(346, 105);
			this.groupBox28.Name = "groupBox28";
			this.groupBox28.Size = new System.Drawing.Size(72, 40);
			this.groupBox28.TabIndex = 18;
			this.groupBox28.TabStop = false;
			// 
			// textBox34
			// 
			this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox34.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox34.Location = new System.Drawing.Point(10, 12);
			this.textBox34.Name = "textBox34";
			this.textBox34.ReadOnly = true;
			this.textBox34.Size = new System.Drawing.Size(48, 21);
			this.textBox34.TabIndex = 16;
			this.textBox34.Text = "0,00";
			this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox34.Leave += new System.EventHandler(this.textBox34_Leave);
			// 
			// groupBox29
			// 
			this.groupBox29.Controls.Add(this.textBox35);
			this.groupBox29.Location = new System.Drawing.Point(276, 105);
			this.groupBox29.Name = "groupBox29";
			this.groupBox29.Size = new System.Drawing.Size(72, 40);
			this.groupBox29.TabIndex = 17;
			this.groupBox29.TabStop = false;
			// 
			// textBox35
			// 
			this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox35.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox35.Location = new System.Drawing.Point(10, 12);
			this.textBox35.Name = "textBox35";
			this.textBox35.ReadOnly = true;
			this.textBox35.Size = new System.Drawing.Size(48, 21);
			this.textBox35.TabIndex = 15;
			this.textBox35.Text = "0,00";
			this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox35.Leave += new System.EventHandler(this.textBox35_Leave);
			// 
			// groupBox30
			// 
			this.groupBox30.Controls.Add(this.textBox36);
			this.groupBox30.Location = new System.Drawing.Point(206, 105);
			this.groupBox30.Name = "groupBox30";
			this.groupBox30.Size = new System.Drawing.Size(72, 40);
			this.groupBox30.TabIndex = 16;
			this.groupBox30.TabStop = false;
			// 
			// textBox36
			// 
			this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox36.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox36.Location = new System.Drawing.Point(10, 12);
			this.textBox36.Name = "textBox36";
			this.textBox36.ReadOnly = true;
			this.textBox36.Size = new System.Drawing.Size(48, 21);
			this.textBox36.TabIndex = 14;
			this.textBox36.Text = "0,00";
			this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox36.Leave += new System.EventHandler(this.textBox36_Leave);
			// 
			// groupBox31
			// 
			this.groupBox31.Controls.Add(this.checkBox1);
			this.groupBox31.Location = new System.Drawing.Point(65, 167);
			this.groupBox31.Name = "groupBox31";
			this.groupBox31.Size = new System.Drawing.Size(143, 54);
			this.groupBox31.TabIndex = 30;
			this.groupBox31.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Enabled = false;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(62, 17);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(21, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.TabStop = false;
			// 
			// groupBox32
			// 
			this.groupBox32.Controls.Add(this.checkBox2);
			this.groupBox32.Location = new System.Drawing.Point(205, 167);
			this.groupBox32.Name = "groupBox32";
			this.groupBox32.Size = new System.Drawing.Size(143, 54);
			this.groupBox32.TabIndex = 31;
			this.groupBox32.TabStop = false;
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Enabled = false;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(64, 16);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(21, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.TabStop = false;
			// 
			// groupBox33
			// 
			this.groupBox33.Controls.Add(this.checkBox3);
			this.groupBox33.Location = new System.Drawing.Point(346, 167);
			this.groupBox33.Name = "groupBox33";
			this.groupBox33.Size = new System.Drawing.Size(143, 54);
			this.groupBox33.TabIndex = 32;
			this.groupBox33.TabStop = false;
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Enabled = false;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(64, 16);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(21, 24);
			this.checkBox3.TabIndex = 1;
			this.checkBox3.TabStop = false;
			// 
			// groupBox34
			// 
			this.groupBox34.Controls.Add(this.mtgcComboBox4);
			this.groupBox34.Location = new System.Drawing.Point(486, 167);
			this.groupBox34.Name = "groupBox34";
			this.groupBox34.Size = new System.Drawing.Size(143, 54);
			this.groupBox34.TabIndex = 33;
			this.groupBox34.TabStop = false;
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
			this.mtgcComboBox4.Enabled = false;
			this.mtgcComboBox4.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox4.GridLineHorizontal = false;
			this.mtgcComboBox4.GridLineVertical = false;
			this.mtgcComboBox4.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox4.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox4.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox4.Location = new System.Drawing.Point(40, 16);
			this.mtgcComboBox4.ManagingFastMouseMoving = true;
			this.mtgcComboBox4.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox4.Name = "mtgcComboBox4";
			this.mtgcComboBox4.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox4.Size = new System.Drawing.Size(64, 21);
			this.mtgcComboBox4.TabIndex = 0;
			this.mtgcComboBox4.TabStop = false;
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
																										new System.Data.Common.DataTableMapping("Table", "T_famille_machine", new System.Data.Common.DataColumnMapping[] {
																																																							 new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							 new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_1", "E_champ_1"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_2", "E_champ_2"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_3", "E_champ_3"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_4", "E_champ_4"),
																																																							 new System.Data.Common.DataColumnMapping("Type", "Type")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM T_famille_machine WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (E_champ_1 = ? OR ? IS NULL AND E_champ_1 IS NULL) AND (E_champ_2 = ? OR ? IS NULL AND E_champ_2 IS NULL) AND (E_champ_3 = ? OR ? IS NULL AND E_champ_3 IS NULL) AND (E_champ_4 = ? OR ? IS NULL AND E_champ_4 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_famille_machine(Code, Designation, E_champ_1, E_champ_2, E_champ_3," +
				" E_champ_4, Type) VALUES (?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Code, Designation, E_champ_1, E_champ_2, E_champ_3, E_champ_4, Type FROM T" +
				"_famille_machine";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE T_famille_machine SET Code = ?, Designation = ?, E_champ_1 = ?, E_champ_2 = ?, E_champ_3 = ?, E_champ_4 = ?, Type = ? WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (E_champ_1 = ? OR ? IS NULL AND E_champ_1 IS NULL) AND (E_champ_2 = ? OR ? IS NULL AND E_champ_2 IS NULL) AND (E_champ_3 = ? OR ? IS NULL AND E_champ_3 IS NULL) AND (E_champ_4 = ? OR ? IS NULL AND E_champ_4 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_parc_ETS", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("Chaine", "Chaine"),
																																																					  new System.Data.Common.DataColumnMapping("Date Dernier Controle", "Date Dernier Controle"),
																																																					  new System.Data.Common.DataColumnMapping("Date MES", "Date MES"),
																																																					  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																					  new System.Data.Common.DataColumnMapping("Marque", "Marque"),
																																																					  new System.Data.Common.DataColumnMapping("N° Serie", "N° Serie"),
																																																					  new System.Data.Common.DataColumnMapping("Type", "Type")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM T_parc_ETS WHERE (ID = ?) AND (Chaine = ? OR ? IS NULL AND Chaine IS NULL) AND ([Date Dernier Controle] = ? OR ? IS NULL AND [Date Dernier Controle] IS NULL) AND ([Date MES] = ? OR ? IS NULL AND [Date MES] IS NULL) AND (Marque = ? OR ? IS NULL AND Marque IS NULL) AND ([N° Serie] = ? OR ? IS NULL AND [N° Serie] IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MES", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MES", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Marque", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Marque", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Marque1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Marque", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Serie", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Serie1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO T_parc_ETS(Chaine, [Date Dernier Controle], [Date MES], Marque, [N° S" +
				"erie], Type) VALUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Controle"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, "Date MES"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Marque", System.Data.OleDb.OleDbType.VarWChar, 50, "Marque"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Serie", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Serie"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.VarWChar, 50, "Type"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Chaine, [Date Dernier Controle], [Date MES], ID, Marque, [N° Serie], Type " +
				"FROM T_parc_ETS";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE T_parc_ETS SET Chaine = ?, [Date Dernier Controle] = ?, [Date MES] = ?, Marque = ?, [N° Serie] = ?, Type = ? WHERE (ID = ?) AND (Chaine = ? OR ? IS NULL AND Chaine IS NULL) AND ([Date Dernier Controle] = ? OR ? IS NULL AND [Date Dernier Controle] IS NULL) AND ([Date MES] = ? OR ? IS NULL AND [Date MES] IS NULL) AND (Marque = ? OR ? IS NULL AND Marque IS NULL) AND ([N° Serie] = ? OR ? IS NULL AND [N° Serie] IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Controle"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, "Date MES"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Marque", System.Data.OleDb.OleDbType.VarWChar, 50, "Marque"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Serie", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Serie"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.VarWChar, 50, "Type"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MES", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MES", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Marque", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Marque", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Marque1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Marque", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Serie", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Serie1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_reparateurs", new System.Data.Common.DataColumnMapping[] {
																																																						 new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																						 new System.Data.Common.DataColumnMapping("Nom", "Nom")})});
			this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
			// 
			// oleDbDeleteCommand3
			// 
			this.oleDbDeleteCommand3.CommandText = "DELETE FROM T_reparateurs WHERE (ID = ?) AND (Nom = ? OR ? IS NULL AND Nom IS NUL" +
				"L)";
			this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand3
			// 
			this.oleDbInsertCommand3.CommandText = "INSERT INTO T_reparateurs(ID, Nom) VALUES (?, ?)";
			this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 5, "ID"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom"));
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = "SELECT ID, Nom FROM T_reparateurs";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand3
			// 
			this.oleDbUpdateCommand3.CommandText = "UPDATE T_reparateurs SET ID = ?, Nom = ? WHERE (ID = ?) AND (Nom = ? OR ? IS NULL" +
				" AND Nom IS NULL)";
			this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 5, "ID"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand4;
			this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand4;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand4;
			// 
			// oleDbDeleteCommand4
			// 
			this.oleDbDeleteCommand4.CommandText = @"DELETE FROM T_parc_CAPTEURS WHERE (ID = ?) AND (A_M_V = ? OR ? IS NULL AND A_M_V IS NULL) AND (Chaine = ? OR ? IS NULL AND Chaine IS NULL) AND ([Date Dernier Controle] = ? OR ? IS NULL AND [Date Dernier Controle] IS NULL) AND (Date_MES = ? OR ? IS NULL AND Date_MES IS NULL) AND (Refer = ? OR ? IS NULL AND Refer IS NULL) AND (Serie = ? OR ? IS NULL AND Serie IS NULL) AND (Unite_etal = ? OR ? IS NULL AND Unite_etal IS NULL) AND ([Val-Etal_Vis] = ? OR ? IS NULL AND [Val-Etal_Vis] IS NULL) AND (Val_Actuelle = ? OR ? IS NULL AND Val_Actuelle IS NULL) AND (Val_Etal_Devis = ? OR ? IS NULL AND Val_Etal_Devis IS NULL) AND (Val_Mes_Initiale = ? OR ? IS NULL AND Val_Mes_Initiale IS NULL) AND (Val_Mes_limite = ? OR ? IS NULL AND Val_Mes_limite IS NULL) AND (capacite_nom = ? OR ? IS NULL AND capacite_nom IS NULL) AND (imp_rot = ? OR ? IS NULL AND imp_rot IS NULL)";
			this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_A_M_V", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "A_M_V", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_A_M_V1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "A_M_V", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_MES", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_MES", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refer", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refer", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refer1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refer", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Serie", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Serie1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unite_etal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unite_etal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unite_etal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unite_etal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Vis", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val-Etal_Vis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Vis1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val-Etal_Vis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Actuelle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Actuelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Actuelle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Actuelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Devis", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Etal_Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Devis1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Etal_Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_Initiale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_Initiale", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_Initiale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_Initiale", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_limite", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_limite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_limite1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_limite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capacite_nom", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capacite_nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capacite_nom1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capacite_nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_imp_rot", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "imp_rot", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_imp_rot1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "imp_rot", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand4
			// 
			this.oleDbInsertCommand4.CommandText = @"INSERT INTO T_parc_CAPTEURS(A_M_V, capacite_nom, Chaine, [Date Dernier Controle], Date_MES, imp_rot, Refer, Serie, Unite_etal, Val_Actuelle, Val_Etal_Devis, Val_Mes_Initiale, Val_Mes_limite, [Val-Etal_Vis]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("A_M_V", System.Data.OleDb.OleDbType.VarWChar, 3, "A_M_V"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("capacite_nom", System.Data.OleDb.OleDbType.VarWChar, 8, "capacite_nom"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Controle"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, "Date_MES"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("imp_rot", System.Data.OleDb.OleDbType.VarWChar, 4, "imp_rot"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refer", System.Data.OleDb.OleDbType.VarWChar, 10, "Refer"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Serie", System.Data.OleDb.OleDbType.VarWChar, 10, "Serie"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Unite_etal", System.Data.OleDb.OleDbType.VarWChar, 5, "Unite_etal"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Actuelle", System.Data.OleDb.OleDbType.Integer, 0, "Val_Actuelle"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Etal_Devis", System.Data.OleDb.OleDbType.VarWChar, 6, "Val_Etal_Devis"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Mes_Initiale", System.Data.OleDb.OleDbType.Integer, 0, "Val_Mes_Initiale"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Mes_limite", System.Data.OleDb.OleDbType.Integer, 0, "Val_Mes_limite"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Etal_Vis", System.Data.OleDb.OleDbType.VarWChar, 6, "Val-Etal_Vis"));
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = "SELECT A_M_V, capacite_nom, Chaine, [Date Dernier Controle], Date_MES, ID, imp_ro" +
				"t, Refer, Serie, Unite_etal, Val_Actuelle, Val_Etal_Devis, Val_Mes_Initiale, Val" +
				"_Mes_limite, [Val-Etal_Vis] FROM T_parc_CAPTEURS";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand4
			// 
			this.oleDbUpdateCommand4.CommandText = @"UPDATE T_parc_CAPTEURS SET A_M_V = ?, capacite_nom = ?, Chaine = ?, [Date Dernier Controle] = ?, Date_MES = ?, imp_rot = ?, Refer = ?, Serie = ?, Unite_etal = ?, Val_Actuelle = ?, Val_Etal_Devis = ?, Val_Mes_Initiale = ?, Val_Mes_limite = ?, [Val-Etal_Vis] = ? WHERE (ID = ?) AND (A_M_V = ? OR ? IS NULL AND A_M_V IS NULL) AND (Chaine = ? OR ? IS NULL AND Chaine IS NULL) AND ([Date Dernier Controle] = ? OR ? IS NULL AND [Date Dernier Controle] IS NULL) AND (Date_MES = ? OR ? IS NULL AND Date_MES IS NULL) AND (Refer = ? OR ? IS NULL AND Refer IS NULL) AND (Serie = ? OR ? IS NULL AND Serie IS NULL) AND (Unite_etal = ? OR ? IS NULL AND Unite_etal IS NULL) AND ([Val-Etal_Vis] = ? OR ? IS NULL AND [Val-Etal_Vis] IS NULL) AND (Val_Actuelle = ? OR ? IS NULL AND Val_Actuelle IS NULL) AND (Val_Etal_Devis = ? OR ? IS NULL AND Val_Etal_Devis IS NULL) AND (Val_Mes_Initiale = ? OR ? IS NULL AND Val_Mes_Initiale IS NULL) AND (Val_Mes_limite = ? OR ? IS NULL AND Val_Mes_limite IS NULL) AND (capacite_nom = ? OR ? IS NULL AND capacite_nom IS NULL) AND (imp_rot = ? OR ? IS NULL AND imp_rot IS NULL)";
			this.oleDbUpdateCommand4.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("A_M_V", System.Data.OleDb.OleDbType.VarWChar, 3, "A_M_V"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("capacite_nom", System.Data.OleDb.OleDbType.VarWChar, 8, "capacite_nom"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, "Chaine"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date Dernier Controle"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, "Date_MES"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("imp_rot", System.Data.OleDb.OleDbType.VarWChar, 4, "imp_rot"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refer", System.Data.OleDb.OleDbType.VarWChar, 10, "Refer"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Serie", System.Data.OleDb.OleDbType.VarWChar, 10, "Serie"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Unite_etal", System.Data.OleDb.OleDbType.VarWChar, 5, "Unite_etal"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Actuelle", System.Data.OleDb.OleDbType.Integer, 0, "Val_Actuelle"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Etal_Devis", System.Data.OleDb.OleDbType.VarWChar, 6, "Val_Etal_Devis"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Mes_Initiale", System.Data.OleDb.OleDbType.Integer, 0, "Val_Mes_Initiale"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Mes_limite", System.Data.OleDb.OleDbType.Integer, 0, "Val_Mes_limite"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_Etal_Vis", System.Data.OleDb.OleDbType.VarWChar, 6, "Val-Etal_Vis"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_A_M_V", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "A_M_V", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_A_M_V1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "A_M_V", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chaine1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chaine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Dernier_Controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Dernier Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_MES", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MES1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_MES", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refer", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refer", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refer1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refer", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Serie", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Serie1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unite_etal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unite_etal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unite_etal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unite_etal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Vis", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val-Etal_Vis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Vis1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val-Etal_Vis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Actuelle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Actuelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Actuelle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Actuelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Devis", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Etal_Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Etal_Devis1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Etal_Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_Initiale", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_Initiale", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_Initiale1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_Initiale", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_limite", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_limite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_Mes_limite1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_Mes_limite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capacite_nom", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capacite_nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capacite_nom1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capacite_nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_imp_rot", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "imp_rot", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_imp_rot1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "imp_rot", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter5
			// 
			this.oleDbDataAdapter5.DeleteCommand = this.oleDbDeleteCommand5;
			this.oleDbDataAdapter5.InsertCommand = this.oleDbInsertCommand5;
			this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
			this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_type_machine_dyn", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("C_maxi", "C_maxi"),
																																																							  new System.Data.Common.DataColumnMapping("C_mini", "C_mini"),
																																																							  new System.Data.Common.DataColumnMapping("Classe_Iso", "Classe_Iso"),
																																																							  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							  new System.Data.Common.DataColumnMapping("Precision", "Precision"),
																																																							  new System.Data.Common.DataColumnMapping("Type_Iso", "Type_Iso")})});
			this.oleDbDataAdapter5.UpdateCommand = this.oleDbUpdateCommand5;
			// 
			// oleDbDeleteCommand5
			// 
			this.oleDbDeleteCommand5.CommandText = @"DELETE FROM T_type_machine_dyn WHERE (Code = ?) AND (C_maxi = ? OR ? IS NULL AND C_maxi IS NULL) AND (C_mini = ? OR ? IS NULL AND C_mini IS NULL) AND (Classe_Iso = ? OR ? IS NULL AND Classe_Iso IS NULL) AND (Precision = ? OR ? IS NULL AND Precision IS NULL) AND (Type_Iso = ? OR ? IS NULL AND Type_Iso IS NULL)";
			this.oleDbDeleteCommand5.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Classe_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Classe_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Classe_Iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Classe_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Precision", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Precision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Precision1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Precision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_Iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type_Iso", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand5
			// 
			this.oleDbInsertCommand5.CommandText = "INSERT INTO T_type_machine_dyn(C_maxi, C_mini, Classe_Iso, Code, Precision, Type_" +
				"Iso) VALUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand5.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_mini", System.Data.OleDb.OleDbType.Double, 0, "C_mini"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Classe_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, "Classe_Iso"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Precision", System.Data.OleDb.OleDbType.Double, 0, "Precision"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, "Type_Iso"));
			// 
			// oleDbSelectCommand5
			// 
			this.oleDbSelectCommand5.CommandText = "SELECT C_maxi, C_mini, Classe_Iso, Code, Precision, Type_Iso FROM T_type_machine_" +
				"dyn";
			this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand5
			// 
			this.oleDbUpdateCommand5.CommandText = @"UPDATE T_type_machine_dyn SET C_maxi = ?, C_mini = ?, Classe_Iso = ?, Code = ?, Precision = ?, Type_Iso = ? WHERE (Code = ?) AND (C_maxi = ? OR ? IS NULL AND C_maxi IS NULL) AND (C_mini = ? OR ? IS NULL AND C_mini IS NULL) AND (Classe_Iso = ? OR ? IS NULL AND Classe_Iso IS NULL) AND (Precision = ? OR ? IS NULL AND Precision IS NULL) AND (Type_Iso = ? OR ? IS NULL AND Type_Iso IS NULL)";
			this.oleDbUpdateCommand5.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_mini", System.Data.OleDb.OleDbType.Double, 0, "C_mini"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Classe_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, "Classe_Iso"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Precision", System.Data.OleDb.OleDbType.Double, 0, "Precision"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, "Type_Iso"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Classe_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Classe_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Classe_Iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Classe_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Precision", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Precision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Precision1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Precision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_Iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type_Iso", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter6
			// 
			this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand6;
			this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand6;
			this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
			this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand6;
			// 
			// oleDbDeleteCommand6
			// 
			this.oleDbDeleteCommand6.CommandText = "DELETE FROM T_controles_dym WHERE (ID = ?) AND (C_iso = ? OR ? IS NULL AND C_iso " +
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
			this.oleDbDeleteCommand6.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_opindus1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Indentification", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Indentification", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Modele", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Modele", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Modele1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Modele", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Operateur", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Operateur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Operateur1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Operateur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_T_iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_T_iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_100", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_20", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_60", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_aspect", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "aspect", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_aspect1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "aspect", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capteur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capteur1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_conf_carre", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "conf_carre", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ets", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ets", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ets1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ets", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_marquage", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "marquage", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_precision", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "precision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_precision1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "precision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_test_vide", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "test_vide", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_test_vide1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "test_vide", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand6
			// 
			this.oleDbInsertCommand6.CommandText = @"INSERT INTO T_controles_dym(aspect, C_iso, capteur, [Code machine opindus], Commentaire, conf_carre, Couple_Maxi, Couple_mini, Date_controle, ets, Indentification, marquage, Modele, [N° Controle], Operateur, precision, R_100, R_20, R_60, T_iso, test_vide, Val_001_100, Val_001_20, Val_001_60, Val_002_100, Val_002_20, Val_002_60, Val_003_100, Val_003_20, Val_003_60, Val_004_100, Val_004_20, Val_004_60, Val_005_100, Val_005_20, Val_005_60) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("aspect", System.Data.OleDb.OleDbType.VarWChar, 1, "aspect"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_iso", System.Data.OleDb.OleDbType.VarWChar, 5, "C_iso"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("capteur", System.Data.OleDb.OleDbType.Integer, 0, "capteur"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine opindus"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("conf_carre", System.Data.OleDb.OleDbType.Boolean, 2, "conf_carre"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Couple_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Couple_Maxi"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Couple_mini", System.Data.OleDb.OleDbType.Double, 0, "Couple_mini"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date_controle"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ets", System.Data.OleDb.OleDbType.VarWChar, 50, "ets"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Indentification", System.Data.OleDb.OleDbType.Boolean, 2, "Indentification"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("marquage", System.Data.OleDb.OleDbType.Boolean, 2, "marquage"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Modele", System.Data.OleDb.OleDbType.VarWChar, 19, "Modele"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Controle", System.Data.OleDb.OleDbType.Integer, 0, "N° Controle"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Operateur", System.Data.OleDb.OleDbType.VarWChar, 5, "Operateur"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("precision", System.Data.OleDb.OleDbType.Double, 0, "precision"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_100", System.Data.OleDb.OleDbType.Double, 0, "R_100"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_20", System.Data.OleDb.OleDbType.Double, 0, "R_20"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_60", System.Data.OleDb.OleDbType.Double, 0, "R_60"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("T_iso", System.Data.OleDb.OleDbType.VarWChar, 5, "T_iso"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("test_vide", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "test_vide"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_100", System.Data.OleDb.OleDbType.Double, 0, "Val_001_100"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_20", System.Data.OleDb.OleDbType.Double, 0, "Val_001_20"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_60", System.Data.OleDb.OleDbType.Double, 0, "Val_001_60"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_100", System.Data.OleDb.OleDbType.Double, 0, "Val_002_100"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_20", System.Data.OleDb.OleDbType.Double, 0, "Val_002_20"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_60", System.Data.OleDb.OleDbType.Double, 0, "Val_002_60"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_100", System.Data.OleDb.OleDbType.Double, 0, "Val_003_100"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_20", System.Data.OleDb.OleDbType.Double, 0, "Val_003_20"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_60", System.Data.OleDb.OleDbType.Double, 0, "Val_003_60"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_100", System.Data.OleDb.OleDbType.Double, 0, "Val_004_100"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_20", System.Data.OleDb.OleDbType.Double, 0, "Val_004_20"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_60", System.Data.OleDb.OleDbType.Double, 0, "Val_004_60"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_100", System.Data.OleDb.OleDbType.Double, 0, "Val_005_100"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_20", System.Data.OleDb.OleDbType.Double, 0, "Val_005_20"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_60", System.Data.OleDb.OleDbType.Double, 0, "Val_005_60"));
			// 
			// oleDbSelectCommand6
			// 
			this.oleDbSelectCommand6.CommandText = @"SELECT aspect, C_iso, capteur, [Code machine opindus], Commentaire, conf_carre, Couple_Maxi, Couple_mini, Date_controle, ets, ID, Indentification, marquage, Modele, [N° Controle], Operateur, precision, R_100, R_20, R_60, T_iso, test_vide, Val_001_100, Val_001_20, Val_001_60, Val_002_100, Val_002_20, Val_002_60, Val_003_100, Val_003_20, Val_003_60, Val_004_100, Val_004_20, Val_004_60, Val_005_100, Val_005_20, Val_005_60 FROM T_controles_dym ORDER BY ID";
			this.oleDbSelectCommand6.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand6
			// 
			this.oleDbUpdateCommand6.CommandText = "UPDATE T_controles_dym SET aspect = ?, C_iso = ?, capteur = ?, [Code machine opin" +
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
			this.oleDbUpdateCommand6.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("aspect", System.Data.OleDb.OleDbType.VarWChar, 1, "aspect"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_iso", System.Data.OleDb.OleDbType.VarWChar, 5, "C_iso"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("capteur", System.Data.OleDb.OleDbType.Integer, 0, "capteur"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine opindus"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("conf_carre", System.Data.OleDb.OleDbType.Boolean, 2, "conf_carre"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Couple_Maxi", System.Data.OleDb.OleDbType.Double, 0, "Couple_Maxi"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Couple_mini", System.Data.OleDb.OleDbType.Double, 0, "Couple_mini"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date_controle"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ets", System.Data.OleDb.OleDbType.VarWChar, 50, "ets"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Indentification", System.Data.OleDb.OleDbType.Boolean, 2, "Indentification"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("marquage", System.Data.OleDb.OleDbType.Boolean, 2, "marquage"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Modele", System.Data.OleDb.OleDbType.VarWChar, 19, "Modele"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Controle", System.Data.OleDb.OleDbType.Integer, 0, "N° Controle"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Operateur", System.Data.OleDb.OleDbType.VarWChar, 5, "Operateur"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("precision", System.Data.OleDb.OleDbType.Double, 0, "precision"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_100", System.Data.OleDb.OleDbType.Double, 0, "R_100"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_20", System.Data.OleDb.OleDbType.Double, 0, "R_20"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("R_60", System.Data.OleDb.OleDbType.Double, 0, "R_60"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("T_iso", System.Data.OleDb.OleDbType.VarWChar, 5, "T_iso"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("test_vide", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "test_vide"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_100", System.Data.OleDb.OleDbType.Double, 0, "Val_001_100"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_20", System.Data.OleDb.OleDbType.Double, 0, "Val_001_20"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_001_60", System.Data.OleDb.OleDbType.Double, 0, "Val_001_60"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_100", System.Data.OleDb.OleDbType.Double, 0, "Val_002_100"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_20", System.Data.OleDb.OleDbType.Double, 0, "Val_002_20"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_002_60", System.Data.OleDb.OleDbType.Double, 0, "Val_002_60"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_100", System.Data.OleDb.OleDbType.Double, 0, "Val_003_100"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_20", System.Data.OleDb.OleDbType.Double, 0, "Val_003_20"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_003_60", System.Data.OleDb.OleDbType.Double, 0, "Val_003_60"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_100", System.Data.OleDb.OleDbType.Double, 0, "Val_004_100"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_20", System.Data.OleDb.OleDbType.Double, 0, "Val_004_20"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_004_60", System.Data.OleDb.OleDbType.Double, 0, "Val_004_60"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_100", System.Data.OleDb.OleDbType.Double, 0, "Val_005_100"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_20", System.Data.OleDb.OleDbType.Double, 0, "Val_005_20"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Val_005_60", System.Data.OleDb.OleDbType.Double, 0, "Val_005_60"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_opindus1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_Maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_Maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_Maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Couple_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Couple_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date_controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Indentification", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Indentification", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Modele", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Modele", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Modele1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Modele", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Operateur", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Operateur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Operateur1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Operateur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_R_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "R_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_T_iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_T_iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T_iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_001_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_001_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_002_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_002_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_003_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_003_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_004_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_004_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_100", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_1001", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_100", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_20", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_201", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_20", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_60", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Val_005_601", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Val_005_60", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_aspect", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "aspect", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_aspect1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "aspect", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capteur", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_capteur1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "capteur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_conf_carre", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "conf_carre", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ets", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ets", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ets1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ets", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_marquage", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "marquage", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_precision", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "precision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_precision1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "precision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_test_vide", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "test_vide", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_test_vide1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "test_vide", System.Data.DataRowVersion.Original, null));
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(261, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// ControleDyn
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(924, 688);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.button4);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ControleDyn";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controle Dynamométrique";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox14.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox17.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.groupBox16.ResumeLayout(false);
			this.groupBox19.ResumeLayout(false);
			this.groupBox20.ResumeLayout(false);
			this.groupBox21.ResumeLayout(false);
			this.groupBox22.ResumeLayout(false);
			this.groupBox23.ResumeLayout(false);
			this.groupBox24.ResumeLayout(false);
			this.groupBox25.ResumeLayout(false);
			this.groupBox26.ResumeLayout(false);
			this.groupBox27.ResumeLayout(false);
			this.groupBox28.ResumeLayout(false);
			this.groupBox29.ResumeLayout(false);
			this.groupBox30.ResumeLayout(false);
			this.groupBox31.ResumeLayout(false);
			this.groupBox32.ResumeLayout(false);
			this.groupBox33.ResumeLayout(false);
			this.groupBox34.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button4_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Ecriture();
		}

		private void Ecriture()
		{
			textBox16.ReadOnly=false;
			textBox17.ReadOnly=false;
			textBox18.ReadOnly=false;
			textBox19.ReadOnly=false;
			textBox20.ReadOnly=false;
			textBox21.ReadOnly=false;
			textBox24.ReadOnly=false;
			textBox25.ReadOnly=false;
			textBox26.ReadOnly=false;
			textBox27.ReadOnly=false;
			textBox28.ReadOnly=false;
			textBox29.ReadOnly=false;
			textBox31.ReadOnly=false;
			textBox32.ReadOnly=false;
			textBox33.ReadOnly=false;
			textBox34.ReadOnly=false;
			textBox35.ReadOnly=false;
			textBox36.ReadOnly=false;
			checkBox1.Enabled=true;
			checkBox2.Enabled=true;
			checkBox3.Enabled=true;
			mtgcComboBox1.Enabled=true;
			mtgcComboBox2.Enabled=true;
			mtgcComboBox3.Enabled=true;
			mtgcComboBox4.Enabled=true;
			textBox9.Enabled=true;
			button1.Enabled=false;
			button2.Enabled=true;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			save=true;
			if(mtgcComboBox1.SelectedIndex.Equals(-1))
			{
				MessageBox.Show("Veuillez choisir une chaine","Attention",MessageBoxButtons.OK, MessageBoxIcon.Information);
				save=false;
			}
			if(mtgcComboBox2.SelectedIndex.Equals(-1))
			{
				MessageBox.Show("Veuillez choisir un capteur","Attention",MessageBoxButtons.OK, MessageBoxIcon.Information);
				save=false;
			}
			if(mtgcComboBox3.SelectedIndex.Equals(-1))
			{
				MessageBox.Show("Veuillez choisir un opérateur","Attention",MessageBoxButtons.OK, MessageBoxIcon.Information);
				save=false;
			}
			if(save)
			{
				textBox16.Text=textBox16.Text.Replace(",",".");
				textBox17.Text=textBox17.Text.Replace(",",".");
				textBox18.Text=textBox18.Text.Replace(",",".");
				textBox19.Text=textBox19.Text.Replace(",",".");
				textBox20.Text=textBox20.Text.Replace(",",".");
				textBox21.Text=textBox21.Text.Replace(",",".");
				textBox22.Text=textBox22.Text.Replace(",",".");
				textBox23.Text=textBox23.Text.Replace(",",".");
				textBox24.Text=textBox24.Text.Replace(",",".");
				textBox25.Text=textBox25.Text.Replace(",",".");
				textBox26.Text=textBox26.Text.Replace(",",".");
				textBox27.Text=textBox27.Text.Replace(",",".");
				textBox28.Text=textBox28.Text.Replace(",",".");
				textBox29.Text=textBox29.Text.Replace(",",".");
				textBox30.Text=textBox30.Text.Replace(",",".");
				textBox31.Text=textBox31.Text.Replace(",",".");
				textBox32.Text=textBox32.Text.Replace(",",".");
				textBox33.Text=textBox33.Text.Replace(",",".");
				textBox34.Text=textBox34.Text.Replace(",",".");
				textBox35.Text=textBox35.Text.Replace(",",".");
				textBox36.Text=textBox36.Text.Replace(",",".");
				dataSet11.Tables["t_controles_dym"].Clear();
				oleDbSelectCommand6.CommandText="select * from t_controles_dym where [n° controle]="+textBox7.Text;
				oleDbDataAdapter6.Fill(dataSet11);
				if(dataSet11.Tables["t_controles_dym"].Rows.Count.Equals(0))
				{

					MTGCComboBoxItem Capteur = (MTGCComboBoxItem)mtgcComboBox2.SelectedItem;
					if(textBox9.TextLength.Equals(0))
						textBox9.Text="?";
					oleDbConnection1.Open();
					OleDbCommand Comm = new OleDbCommand();
					Transac = oleDbConnection1.BeginTransaction();
					Comm.Connection=oleDbConnection1;
					Comm.Transaction=Transac;
					Comm.CommandText="insert into t_controles_dym ([n° controle],date_controle,operateur,[code machine opindus],indentification,r_20,val_001_20,val_002_20,val_003_20,val_004_20,val_005_20,r_60,val_001_60,val_002_60,val_003_60,val_004_60,val_005_60,r_100,val_001_100,val_002_100,val_003_100,val_004_100,val_005_100,marquage,conf_carre,aspect,ets,capteur,commentaire) values ("+textBox7.Text+",'"+textBox8.Text+"','"+mtgcComboBox3.Text+"','"+textBox1.Text+"',"+checkBox1.Checked+","+textBox16.Text+","+textBox17.Text+","+textBox18.Text+","+textBox19.Text+","+textBox20.Text+","+textBox21.Text+","+textBox29.Text+","+textBox28.Text+","+textBox27.Text+","+textBox26.Text+","+textBox25.Text+","+textBox24.Text+","+textBox36.Text+","+textBox35.Text+","+textBox34.Text+","+textBox33.Text+","+textBox32.Text+","+textBox31.Text+","+checkBox2.Checked+","+checkBox3.Checked+",'"+mtgcComboBox4.Text+"','"+mtgcComboBox1.Text+"',"+Capteur.Tag.ToString()+",'"+textBox9.Text+"')";
					try
					{
						Comm.ExecuteNonQuery();
						Comm.CommandText="UPDATE t_parc_machine SET [Date dernier controle]='"+DateTime.Now.Day.ToString()+"/"+DateTime.Now.Month.ToString()+"/"+DateTime.Now.Year.ToString()+"' WHERE [Code machine opindus]='"+textBox1.Text.Replace("'","''")+"'";
						Comm.ExecuteNonQuery();
						Transac.Commit();
						MessageBox.Show("Enregistrement terminé.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
						button3.Enabled=true;
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
						try
						{
							Transac.Rollback();
						}
						catch(OleDbException ex)
						{
							if(Transac.Connection!=null)
							{
								MessageBox.Show("Problème lors du Rollback !");
								MessageBox.Show(ex.Message);
							}
						}
					}
					finally
					{
						oleDbConnection1.Close();
					}
				}
				else
				{
					if(textBox9.TextLength.Equals(0))
						textBox9.Text="?";
					oleDbConnection1.Open();
					OleDbCommand Comm = new OleDbCommand();
					Transac = oleDbConnection1.BeginTransaction();
					Comm.Connection=oleDbConnection1;
					Comm.Transaction=Transac;
					Comm.CommandText="update t_controles_dym set [n° controle]="+textBox7.Text+",date_controle='"+textBox8.Text+"',operateur='"+mtgcComboBox3.Text+"',[code machine opindus]='"+textBox1.Text+"',indentification="+checkBox1.Checked+",r_20="+textBox16.Text+",val_001_20="+textBox17.Text+",val_002_20="+textBox18.Text+",val_003_20="+textBox19.Text+",val_004_20="+textBox20.Text+",val_005_20="+textBox21.Text+",r_60="+textBox29.Text+",val_001_60="+textBox28.Text+",val_002_60="+textBox27.Text+",val_003_60="+textBox26.Text+",val_004_60="+textBox25.Text+",val_005_60="+textBox24.Text+",r_100="+textBox36.Text+",val_001_100="+textBox35.Text+",val_002_100="+textBox34.Text+",val_003_100="+textBox33.Text+",val_004_100="+textBox32.Text+",val_005_100="+textBox31.Text+",marquage="+checkBox2.Checked+",conf_carre="+checkBox3.Checked+",aspect='"+mtgcComboBox4.Text+"',ets='"+mtgcComboBox1.Text+"',capteur="+mtgcComboBox2.Text+",commentaire='"+textBox9.Text+"' where [n° controle]="+textBox7.Text;
					try
					{
						Comm.ExecuteNonQuery();
						Transac.Commit();
						MessageBox.Show("Mise à jour terminée.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
						try
						{
							Transac.Rollback();
						}
						catch(OleDbException ex)
						{
							if(Transac.Connection!=null)
							{
								MessageBox.Show("Problème lors du Rollback !");
								MessageBox.Show(ex.Message);
							}
						}
					}
					finally
					{
						oleDbConnection1.Close();
					}
				}
			}
		}

		private void textBox16_Leave(object sender, System.EventArgs e)
		{
			if(textBox16.TextLength>0)
			{
				
				try
				{
					textBox16.Text=textBox16.Text.Replace(".",",");
					textBox16.Text=System.Convert.ToDecimal(textBox16.Text).ToString("0.00");
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
					textBox17.Text=System.Convert.ToDecimal(textBox17.Text).ToString("0.00");
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
					textBox18.Text=System.Convert.ToDecimal(textBox18.Text).ToString("0.00");
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
					textBox19.Text=System.Convert.ToDecimal(textBox19.Text).ToString("0.00");
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
					textBox20.Text=System.Convert.ToDecimal(textBox20.Text).ToString("0.00");
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
					textBox21.Text=System.Convert.ToDecimal(textBox21.Text).ToString("0.00");
					textBox21.Text=textBox21.Text.Replace(",",".");
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
					textBox29.Text=System.Convert.ToDecimal(textBox29.Text).ToString("0.00");
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
					textBox28.Text=System.Convert.ToDecimal(textBox28.Text).ToString("0.00");
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
					textBox27.Text=System.Convert.ToDecimal(textBox27.Text).ToString("0.00");
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
					textBox26.Text=System.Convert.ToDecimal(textBox26.Text).ToString("0.00");
					textBox26.Text=textBox26.Text.Replace(",",".");
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
					textBox25.Text=System.Convert.ToDecimal(textBox25.Text).ToString("0.00");
					textBox25.Text=textBox25.Text.Replace(",",".");
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
					textBox24.Text=System.Convert.ToDecimal(textBox24.Text).ToString("0.00");
					textBox24.Text=textBox24.Text.Replace(",",".");
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
					textBox36.Text=System.Convert.ToDecimal(textBox36.Text).ToString("0.00");
					textBox36.Text=textBox36.Text.Replace(",",".");
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
					textBox35.Text=System.Convert.ToDecimal(textBox35.Text).ToString("0.00");
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
			if(textBox35.TextLength>0)
			{
				
				try
				{
					textBox34.Text=textBox34.Text.Replace(".",",");
					textBox34.Text=System.Convert.ToDecimal(textBox34.Text).ToString("0.00");
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
					textBox33.Text=System.Convert.ToDecimal(textBox33.Text).ToString("0.00");
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
					textBox32.Text=System.Convert.ToDecimal(textBox32.Text).ToString("0.00");
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
					textBox31.Text=System.Convert.ToDecimal(textBox31.Text).ToString("0.00");
					textBox31.Text=textBox31.Text.Replace(",",".");
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
			}
		}

		private void button4_Click_1(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			OleDbDataAdapter DataAD = new OleDbDataAdapter();

			Comm.CommandText="SELECT T_controles_dym.[N° Controle], T_clients.Nom, T_clients.Adresse_1, T_clients.Adresse_2, T_clients.Code_Postal, T_clients.Ville, T_clients.Pays, T_parc_machine.[Type machine] FROM T_controles_dym INNER JOIN (T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) ON T_controles_dym.[Code machine opindus] = T_parc_machine.[Code machine Opindus] WHERE (((T_controles_dym.[N° Controle])="+textBox7.Text+"))";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(dataSet11,"t_clients");
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}

			String MiseEnService="";
			try
			{
				oleDbConnection1.Open();
				Comm.CommandText="SELECT Min(T_devis_entete.Date) AS MinDeDate FROM T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_parc_machine.[Code machine Opindus])='"+textBox1.Text.Replace("'","''")+"'))";
				MiseEnService=System.Convert.ToString(Comm.ExecuteScalar());
			}
			catch
			{
				MiseEnService="";
			}
			finally
			{
				oleDbConnection1.Close();
			}

			String Controle="";
			try
			{
				oleDbConnection1.Open();
				Comm.CommandText="SELECT Min(T_controles_dym.Date_controle) AS MinDeDate_controle FROM T_controles_dym WHERE (((T_controles_dym.[Code machine opindus])='"+textBox1.Text.Replace("'","''")+"'))";
				Controle=System.Convert.ToString(Comm.ExecuteScalar());
			}
			catch
			{
				Controle="";
			}
			finally
			{
				oleDbConnection1.Close();
			}
			try
			{
				if(System.Convert.ToDateTime(Controle).Equals(System.Convert.ToDateTime(textBox8.Text)))
					Controle="";
			}
			catch
			{
			}
			/*printPreviewDialog1.Document=printDocument1;
			printPreviewDialog1.ShowDialog();*/
			Microsoft.Office.Interop.Excel.Application oXL; 
			Microsoft.Office.Interop.Excel._Workbook oWB; 
			Microsoft.Office.Interop.Excel._Worksheet oSheet; 
			Microsoft.Office.Interop.Excel.Range oRng;

			oXL = new Microsoft.Office.Interop.Excel.Application();
			oXL.Application.Visible=false;
			try
			{
				if(Directory.Exists(@"C:\Program Files (x86)\Opindus\Excel\"+textBox1.Text+@"\")==false)
				{
					DirectoryInfo repertoire = Directory.CreateDirectory(@"C:\Program Files (x86)\Opindus\Excel\"+textBox1.Text+@"\"); 
				}
			
				oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\modeles\controle_dyn.xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);
			
				oWB = (Microsoft.Office.Interop.Excel._Workbook)oXL.Workbooks[1];
				oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1];
					
				oSheet.Cells[3,6] = dataSet11.Tables["t_clients"].Rows[0]["nom"].ToString();
				oSheet.Cells[4,6] = dataSet11.Tables["t_clients"].Rows[0]["adresse_1"].ToString();
				oSheet.Cells[5,6] = dataSet11.Tables["t_clients"].Rows[0]["adresse_2"].ToString();
				oSheet.Cells[6,6] = dataSet11.Tables["t_clients"].Rows[0]["code_postal"].ToString()+" "+dataSet11.Tables["t_clients"].Rows[0]["ville"].ToString();
				oSheet.Cells[29,7] = textBox17.Text.Replace(".",",");
				oSheet.Cells[30,7] = textBox18.Text.Replace(".",",");
				oSheet.Cells[31,7] = textBox19.Text.Replace(".",",");
				oSheet.Cells[32,7] = textBox20.Text.Replace(".",",");
				oSheet.Cells[33,7] = textBox21.Text.Replace(".",",");

				oSheet.Cells[34,7] = textBox28.Text.Replace(".",",");
				oSheet.Cells[35,7] = textBox27.Text.Replace(".",",");
				oSheet.Cells[36,7] = textBox26.Text.Replace(".",",");
				oSheet.Cells[37,7] = textBox25.Text.Replace(".",",");
				oSheet.Cells[38,7] = textBox24.Text.Replace(".",",");

				oSheet.Cells[39,7] = textBox35.Text.Replace(".",",");
				oSheet.Cells[40,7] = textBox34.Text.Replace(".",",");
				oSheet.Cells[41,7] = textBox33.Text.Replace(".",",");
				oSheet.Cells[42,7] = textBox32.Text.Replace(".",",");
				oSheet.Cells[43,7] = textBox31.Text.Replace(".",",");

				oSheet.Cells[53,5] = textBox9.Text;

				oSheet.Cells[5,3] = textBox2.Text;
				oSheet.Cells[7,3] = textBox3.Text;
				oSheet.Cells[8,3] = textBox10.Text;
				oSheet.Cells[9,3] = textBox11.Text;
				oSheet.Cells[10,3] = textBox14.Text;
				oSheet.Cells[11,3] = textBox12.Text;
				oSheet.Cells[12,3] = textBox13.Text;

				oSheet.Cells[31,5] = textBox22.Text.Replace(".",",");
				oSheet.Cells[31,6] = textBox16.Text.Replace(".",",");
				oSheet.Cells[36,5] = textBox23.Text.Replace(".",",");
				oSheet.Cells[36,6] = textBox29.Text.Replace(".",",");
				oSheet.Cells[41,5] = textBox30.Text.Replace(".",",");
				oSheet.Cells[41,6] = textBox36.Text.Replace(".",",");

				oSheet.Cells[8,7] = textBox1.Text;
				oSheet.Cells[9,7] = MiseEnService;
				oSheet.Cells[10,7] = Controle;
				oSheet.Cells[11,7] = textBox6.Text;
				oSheet.Cells[12,7] = textBox5.Text;
				oSheet.Cells[9,11] = textBox7.Text;
				oSheet.Cells[10,11] = textBox8.Text;
				oSheet.Cells[11,11] = DateTime.Now.ToShortDateString();
				oSheet.Cells[12,11] = mtgcComboBox3.Text;
				oSheet.Cells[22,3] = mtgcComboBox1.Text;
				oSheet.Cells[23,3] = mtgcComboBox2.Text;

				oSheet.Cells[50,7] = mtgcComboBox4.Text;

				oXL.Workbooks[1].SaveAs(@"C:\Program Files (x86)\Opindus\excel\"+textBox1.Text+@"\controle_dyn.xls",Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,"","",false,false,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,null,null,null,null,null); 
				if(oXL != null)
				{
					oXL.Quit();
					System.Runtime.InteropServices.Marshal.ReleaseComObject (oXL);
					oXL = null;		
				}
				oXL = new Microsoft.Office.Interop.Excel.Application();
				oXL.Application.Visible=true;
				oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\excel\"+textBox1.Text+@"\controle_dyn.xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);
			}
			catch
			{
				if(oXL != null)
				{
					oXL.Quit();
					System.Runtime.InteropServices.Marshal.ReleaseComObject (oXL);
					oXL = null;		
				}
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Decimal Tolerance1=new Decimal(6);
			Decimal Tolerance2=new Decimal(7);
			Decimal Tolerance3=new Decimal(5.50);
			Decimal Tolerance4=new Decimal(4);
			bool Tol1=true;
			bool Tol2=true;
			int ypos=120;
			e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left,ypos-5,e.MarginBounds.Width,30);
			e.Graphics.DrawString("Vérification périodique clé dynamométrique", 
				new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+140, ypos);
			ypos+=60;
			e.Graphics.DrawString("Identification :", 
				new Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_clients"].Rows[0]["nom"].ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
			ypos+=15;
			e.Graphics.DrawString("Marque : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(textBox2.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+80, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_clients"].Rows[0]["adresse_1"].ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
			ypos+=15;
			e.Graphics.DrawString("Famille : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(textBox3.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+80, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_clients"].Rows[0]["adresse_2"].ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
			ypos+=15;
			e.Graphics.DrawString("Modèle : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_clients"].Rows[0]["type machine"].ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+80, ypos);
			e.Graphics.DrawString(dataSet11.Tables["t_clients"].Rows[0]["code_postal"].ToString()+" "+dataSet11.Tables["t_clients"].Rows[0]["ville"].ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
			ypos+=15;
			e.Graphics.DrawString("Type ISO :", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(textBox10.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+80, ypos);
			ypos+=15;
			e.Graphics.DrawString("Classe ISO :", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(textBox11.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+80, ypos);
			e.Graphics.DrawString("Numéro de la clé : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
			e.Graphics.DrawString(textBox1.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+330, ypos);
			ypos+=15;
			e.Graphics.DrawString("Tolérance :", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(textBox14.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+80, ypos);
			e.Graphics.DrawString("Date de mise en service : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
			e.Graphics.DrawString("Certificat N°", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
			e.Graphics.DrawString(textBox7.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos);
			ypos+=15;
			e.Graphics.DrawString("C.mini Nm :", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(textBox12.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+80, ypos);
			e.Graphics.DrawString("Derniere vérification : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
			e.Graphics.DrawString("Date de vérification", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
			e.Graphics.DrawString(textBox8.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos);
			ypos+=15;
			e.Graphics.DrawString("C.max Nm :", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(textBox13.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+80, ypos);
			e.Graphics.DrawString("Site : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
			e.Graphics.DrawString(textBox6.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+330, ypos);
			e.Graphics.DrawString("Date d'édition", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
			e.Graphics.DrawString(DateTime.Now.ToShortDateString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos);
			ypos+=15;
			e.Graphics.DrawString("Emplacement : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
			e.Graphics.DrawString(textBox5.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+330, ypos);
			e.Graphics.DrawString("Opérateur", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+480, ypos);
			e.Graphics.DrawString(mtgcComboBox3.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+600, ypos);
			ypos+=15;
			e.Graphics.DrawString("Matériel de contrôle :", 
				new Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("Matériel NORBAR, modèle ETS, étalonné par le laboratoire habilité NAMAS N°0256", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("(suivant accord multilatéral WECC du 01/12/89).", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("Précision matériel 0,1%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("Mesures effectuées sur banc d'étalonnage.", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawString("Procédure d'essai conforme aux Normes.", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=25;
			e.Graphics.DrawString("Chaine", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			Comm.CommandText="SELECT chaine FROM t_parc_capteurs WHERE id ="+mtgcComboBox2.Text;
			oleDbConnection1.Open();
			String Chaine = (String)Comm.ExecuteScalar();
			oleDbConnection1.Close();
			e.Graphics.DrawString(mtgcComboBox1.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
			ypos+=15;
			e.Graphics.DrawString("Capteur", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(Chaine, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
			ypos+=25;
			e.Graphics.DrawString("Mesures en N.m :", 
				new Font("Arial", 8, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left, ypos);
			ypos+=15;
			e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left,ypos,560,340);
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos+20), new Point(e.MarginBounds.Left+560,ypos+20));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos+40), new Point(e.MarginBounds.Left+560,ypos+40));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos+140), new Point(e.MarginBounds.Left+560,ypos+140));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos+240), new Point(e.MarginBounds.Left+560,ypos+240));

			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+80,ypos), new Point(e.MarginBounds.Left+80,ypos+340));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+160,ypos), new Point(e.MarginBounds.Left+160,ypos+340));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos), new Point(e.MarginBounds.Left+240,ypos+340));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+320,ypos), new Point(e.MarginBounds.Left+320,ypos+340));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+400,ypos), new Point(e.MarginBounds.Left+400,ypos+340));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+480,ypos+20), new Point(e.MarginBounds.Left+480,ypos+340));

			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+60), new Point(e.MarginBounds.Left+400,ypos+60));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+80), new Point(e.MarginBounds.Left+400,ypos+80));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+100), new Point(e.MarginBounds.Left+400,ypos+100));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+120), new Point(e.MarginBounds.Left+400,ypos+120));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+160), new Point(e.MarginBounds.Left+400,ypos+160));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+180), new Point(e.MarginBounds.Left+400,ypos+180));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+200), new Point(e.MarginBounds.Left+400,ypos+200));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+220), new Point(e.MarginBounds.Left+400,ypos+220));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+260), new Point(e.MarginBounds.Left+400,ypos+260));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+280), new Point(e.MarginBounds.Left+400,ypos+280));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+300), new Point(e.MarginBounds.Left+400,ypos+300));
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+240,ypos+320), new Point(e.MarginBounds.Left+400,ypos+320));
			
			e.Graphics.DrawString("COUPLE", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+10, ypos+3);
			e.Graphics.DrawString("COUPLE", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+90, ypos+3);
			e.Graphics.DrawString("COUPLE", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+170, ypos+3);
			e.Graphics.DrawString("COUPLE", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos+3);
			e.Graphics.DrawString("ECART", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+335, ypos+3);
			e.Graphics.DrawString("TOLERANCE", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+440, ypos+3);

			e.Graphics.DrawString("D'ESSAI", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+10, ypos+23);
			e.Graphics.DrawString("THEORIQ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+85, ypos+23);
			e.Graphics.DrawString("REGLE", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+173, ypos+23);
			e.Graphics.DrawString("MESURE", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos+23);
			e.Graphics.DrawString("%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+23);
			e.Graphics.DrawString("ISO 6789", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+410, ypos+23);
			e.Graphics.DrawString("NFE 74325", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+490, ypos+23);

			e.Graphics.DrawString("20%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+30, ypos+83);
			e.Graphics.DrawString("60%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+30, ypos+183);
			e.Graphics.DrawString("100%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+30, ypos+283);

			e.Graphics.DrawString(textBox22.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+110, ypos+83);
			e.Graphics.DrawString(textBox23.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+110, ypos+183);
			e.Graphics.DrawString(textBox30.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+110, ypos+283);

			e.Graphics.DrawString(textBox16.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+190, ypos+83);
			e.Graphics.DrawString(textBox29.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+190, ypos+183);
			e.Graphics.DrawString(textBox36.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+190, ypos+283);

			e.Graphics.DrawString("6%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+430, ypos+83);
			e.Graphics.DrawString("6%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+430, ypos+183);
			e.Graphics.DrawString("6%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+430, ypos+283);

			e.Graphics.DrawString("7%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+510, ypos+83);
			e.Graphics.DrawString("5,50%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+510, ypos+183);
			e.Graphics.DrawString("4%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+510, ypos+283);

			e.Graphics.DrawString(textBox17.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+43);
			e.Graphics.DrawString(textBox18.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+63);
			e.Graphics.DrawString(textBox19.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+83);
			e.Graphics.DrawString(textBox20.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+103);
			e.Graphics.DrawString(textBox21.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+123);

			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox17.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+43);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox17.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox17.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance2)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox18.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+63);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox18.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox18.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance2)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox19.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+83);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox19.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox19.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance2)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox20.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+103);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox20.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox20.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance2)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox21.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+123);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox21.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox21.Text),System.Convert.ToDecimal(textBox16.Text))-1)*100)>Tolerance2)
				Tol2=false;
			e.Graphics.DrawString(textBox28.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+143);
			e.Graphics.DrawString(textBox27.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+163);
			e.Graphics.DrawString(textBox26.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+183);
			e.Graphics.DrawString(textBox25.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+203);
			e.Graphics.DrawString(textBox24.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+223);

			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox28.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+143);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox28.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox28.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance3)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox27.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+163);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox27.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox27.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance3)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox26.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+183);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox26.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox26.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance3)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox25.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+203);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox25.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox25.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance3)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox24.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+223);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox24.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox24.Text),System.Convert.ToDecimal(textBox29.Text))-1)*100)>Tolerance3)
				Tol2=false;

			e.Graphics.DrawString(textBox35.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+243);
			e.Graphics.DrawString(textBox34.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+263);
			e.Graphics.DrawString(textBox33.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+283);
			e.Graphics.DrawString(textBox32.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+303);
			e.Graphics.DrawString(textBox31.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+270, ypos+323);

			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox35.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+243);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox35.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox35.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance4)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox34.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+263);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox34.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox34.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance4)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox33.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+283);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox33.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox33.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance4)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox32.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+303);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox32.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox32.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance4)
				Tol2=false;
			e.Graphics.DrawString((((Decimal.Divide(System.Convert.ToDecimal(textBox31.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)).ToString("0.00")+"%", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+345, ypos+323);
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox31.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance1)
				Tol1=false;
			if((Math.Abs(Decimal.Divide(System.Convert.ToDecimal(textBox31.Text),System.Convert.ToDecimal(textBox36.Text))-1)*100)>Tolerance4)
				Tol2=false;
			ypos+=375;
			e.Graphics.DrawString("Conformité à la Norme ISO 6789", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			String Norme="";
			if(Tol1)
				Norme="Oui";
			else
				Norme="Non";
			String Norme2="";
			if(Tol2)
				Norme2="Oui";
			else
				Norme2="Non";
			e.Graphics.DrawString(Norme, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			ypos+=15;
			e.Graphics.DrawString("Conformité à la Norme NFE 74325", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(Norme2, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			ypos+=15;
			e.Graphics.DrawString("Conformité marquage", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			if(checkBox2.Checked)
				e.Graphics.DrawString("Oui", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			else
				e.Graphics.DrawString("Non", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			ypos+=15;
			e.Graphics.DrawString("Conformité carré entrainement", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			if(checkBox3.Checked)
				e.Graphics.DrawString("Oui", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			else
				e.Graphics.DrawString("Non", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			ypos+=15;
			e.Graphics.DrawString("Identification formelle", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			if(checkBox1.Checked)
				e.Graphics.DrawString("Oui", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			else
				e.Graphics.DrawString("Non", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			ypos+=15;
			e.Graphics.DrawString("Aspect extérieur (4=bon, 1=mauvais)", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString(mtgcComboBox4.Text, 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+240, ypos);
			ypos+=15;
			e.Graphics.DrawString("Date vérific. : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
			ypos+=15;
			e.Graphics.DrawString("Certificat N° : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
			ypos+=15;
			e.Graphics.DrawString("Opérateur : ", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
			ypos+=40;
			if(Agence.Equals(1))
			{
				e.Graphics.DrawString("FAIT A ST PRIEST LE  "+DateTime.Now.ToShortDateString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			}
			else if(Agence.Equals(1))
			{
				e.Graphics.DrawString("FAIT A ROUEN LE  "+DateTime.Now.ToShortDateString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			}
			else if(Agence.Equals(1))
			{
				e.Graphics.DrawString("FAIT A FRETIN LE  "+DateTime.Now.ToShortDateString(), 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			}
			e.Graphics.DrawString("SUIVI ENVISAGE", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
			ypos+=60;
			e.Graphics.DrawString("SIGNATURE AUTORISEE", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("PROCHAINE VERIFICATION", 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);

		}

		private void textBox13_TextChanged(object sender, System.EventArgs e)
		{
			textBox16.Text=Decimal.Multiply(Decimal.Divide(System.Convert.ToDecimal(textBox13.Text),new Decimal(100)),new Decimal(20)).ToString("0.00");
			textBox29.Text=Decimal.Multiply(Decimal.Divide(System.Convert.ToDecimal(textBox13.Text),new Decimal(100)),new Decimal(60)).ToString("0.00");
			textBox36.Text=Decimal.Multiply(Decimal.Divide(System.Convert.ToDecimal(textBox13.Text),new Decimal(100)),new Decimal(100)).ToString("0.00");
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			GraphiquesCAM WinGfx = new GraphiquesCAM(System.Convert.ToInt32(textBox7.Text),50,20,1,20,90,50);
		}
	}
}
