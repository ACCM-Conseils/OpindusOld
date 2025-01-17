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
	/// Description résumée de TypesMachines.
	/// </summary>
	public class TypesMachines : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private string Fourn;
		private bool nouveau;
		private DataRow Selrow;
		private bool save;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
		private int Agence;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter6;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter7;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter8;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox txNetCommande;
		private System.Windows.Forms.TextBox textBox7;
		private MTGCComboBox mtgcComboBox1;
		private MTGCComboBox mtgcComboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DateTimePicker dateTimePicker4;
		private MTGCComboBox mtgcComboBox3;
		private System.Windows.Forms.DateTimePicker dateTimePicker5;
		private MTGCComboBox mtgcComboBox4;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button button5;
		private OleDbTransaction Transac;
		private OleDbCommand Comm;
		private DataSet ds;
		private OleDbDataAdapter DataAD;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
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
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TypesMachines(int Agence,bool Nouvelle)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			this.Agence=Agence;
			ds=new DataSet();
			DataAD=new OleDbDataAdapter();
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
			save=false;
			if(Nouvelle)
			{
				nouveau=true;
				Enable();
				Vider();
				textBox1.BackColor=Color.MistyRose;
				textBox1.ForeColor=Color.Black;
				textBox1.Focus();
			}
		}

		public TypesMachines(int Agence,string Type)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			this.Agence=Agence;
			ds=new DataSet();
			DataAD=new OleDbDataAdapter();
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
			mtgcComboBox3.SelectedIndex=mtgcComboBox3.FindString(Type);
			HideCarac();
			textBox1.Text="";
			textBox3.Text="";
			textBox5.Text="0";
			textBox6.Text="90";
			textBox7.Text="";
			txNetCommande.Text="";
			textBox11.Text="";
			mtgcComboBox1.SelectedIndex=0;
			mtgcComboBox2.SelectedIndex=0;
			if(mtgcComboBox3.SelectedIndex>=0)
			{
				nouveau=false;
				btEnregistre.Enabled=true;
				btSupprime.Enabled=true;
				textBox1.Enabled=true;
				dateTimePicker1.Enabled=true;
				textBox3.Enabled=true;
				textBox5.Enabled=true;
				textBox6.Enabled=true;
				textBox7.Enabled=true;
				txNetCommande.Enabled=true;
				textBox11.Enabled=true;
				mtgcComboBox1.Enabled=true;
				mtgcComboBox2.Enabled=true;
				button1.Enabled=true;
				button2.Enabled=true;
				OleDbCommand Comm = new OleDbCommand();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="select t_type_machine.fournisseur,t_type_machine.[date creation],t_type_machine.[prix catalogue],t_type_machine.[mise a jour tarif],t_type_machine.[nombre reparations],t_type_machine.[delai garantie],t_type_machine.[forfait dnr],t_type_machine.[date maj dnr],t_type_machine.[forfait transport],t_type_machine.[date maj transport],t_type_machine.[forfait controle],t_type_machine.[date maj controle],T_type_machine.Code, T_famille_machine.Designation, T_famille_machine.[Type] FROM t_type_machine,T_fournisseurs,T_famille_machine where T_type_machine.Fournisseur=T_fournisseurs.Code and T_type_machine.[Code famille]=T_famille_machine.Code and t_type_machine.code='"+mtgcComboBox3.Text+"'";
				DataAD.SelectCommand=Comm;
				try
				{
					if(DataAD.Fill(ds,"Machine")>0)
					{
						DataRow Selrow=ds.Tables["Machine"].Rows[0];
							textBox1.Text=Selrow["Code"].ToString();
							try
							{
								dateTimePicker1.Value=System.Convert.ToDateTime(Selrow["Date creation"].ToString());
							}
							catch
							{
								dateTimePicker1.Checked=false;
								dateTimePicker1.Text="";
							}
							textBox3.Text=System.Convert.ToDecimal(Selrow["Prix catalogue"].ToString()).ToString("0.00");
							if(Selrow["mise a jour tarif"].ToString().Length>0)
							{
								if(Selrow["mise a jour tarif"].ToString().Remove(10,9)!="01/01/1970"&&Selrow["date maj dnr"].ToString().Length>0)
								{
									dateTimePicker5.Value=System.Convert.ToDateTime(Selrow["mise a jour tarif"].ToString());
									dateTimePicker5.Checked=true;
								}
							}
							textBox5.Text=Selrow["nombre reparations"].ToString();
							if(textBox5.TextLength.Equals(0))
								textBox5.Text="0";
							textBox6.Text=Selrow["Delai garantie"].ToString();
							textBox7.Text=System.Convert.ToDecimal(Selrow["forfait DNR"].ToString()).ToString("0.00");
							if(Selrow["date maj dnr"].ToString().Length>0)
							{
								if(Selrow["date maj dnr"].ToString().Remove(10,9)!="01/01/1970"&&Selrow["date maj dnr"].ToString().Length>0)
								{
									dateTimePicker2.Value=System.Convert.ToDateTime(Selrow["date maj dnr"].ToString());
									dateTimePicker2.Checked=true;
								}
							}
							txNetCommande.Text=System.Convert.ToDecimal(Selrow["forfait transport"].ToString()).ToString("0.00");
							if(Selrow["date maj transport"].ToString().Length>0)
							{
								if(Selrow["date maj transport"].ToString().Remove(10,9)!="01/01/1970"&&Selrow["date maj transport"].ToString().Length>0)
								{
									dateTimePicker3.Value=System.Convert.ToDateTime(Selrow["date maj transport"].ToString());
									dateTimePicker3.Checked=true;
								}
							}
							textBox11.Text=System.Convert.ToDecimal(Selrow["forfait controle"].ToString()).ToString("0.00");
							Fourn=Selrow["Fournisseur"].ToString();
							if(Selrow["date maj controle"].ToString().Length>0)
							{
								if(Selrow["date maj controle"].ToString().Remove(10,9)!="01/01/1970"&&Selrow["date maj controle"].ToString().Length>0)
								{
									dateTimePicker4.Value=System.Convert.ToDateTime(Selrow["date maj controle"].ToString());
									dateTimePicker4.Checked=true;
								}
							}
							mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindString(Selrow["designation"].ToString());
							dataSet11.Tables["t_fournisseurs"].Clear();
							Comm.Connection=oleDbConnection1;
							Comm.CommandText="select * from t_fournisseurs where code='"+Selrow["fournisseur"].ToString()+"'";
							oleDbDataAdapter3.SelectCommand=Comm;
							try
							{
								oleDbDataAdapter3.Fill(dataSet11);
							}
							catch(Exception exp)
							{
								MessageBox.Show(exp.Message);
							}
							mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(dataSet11.Tables["t_fournisseurs"].Rows[0]["nom"].ToString());

							label17.Text=mtgcComboBox1.Text+" "+textBox1.Text;
							panel1.Visible=true;
							textBox21.Text=Selrow["Type"].ToString();
							if(Selrow["Type"].ToString().Equals("1"))
							{
								Comm.Connection=oleDbConnection1;
								Comm.CommandText="SELECT T_type_machine_dyn.*, T_type_machine_dyn_iso.Type, T_type_machine_dyn_iso.classe, T_type_machine_dyn_iso.precision, T_type_machine_dyn.Code FROM T_type_machine_dyn_iso INNER JOIN T_type_machine_dyn ON T_type_machine_dyn_iso.ID = T_type_machine_dyn.idIso WHERE (((T_type_machine_dyn.Code)='"+textBox1.Text+"'))";
								oleDbDataAdapter4.SelectCommand=Comm;
								oleDbDataAdapter4.Fill(ds);
								DataTable Table = ds.Tables["T_type_machine_dyn"];
								if(ds.Tables["T_type_machine_dyn"].Rows.Count>0)
								{
									mtgcComboBox4.SelectedIndex=System.Convert.ToInt32(Table.Rows[0]["idIso"].ToString());
									label26.Visible=true;
									textBox13.Visible=true;
									textBox14.Visible=true;
									textBox15.Text=System.Convert.ToDecimal(Table.Rows[0]["C_mini"].ToString()).ToString("0.00");
									textBox15.Visible=true;
									textBox17.Text=System.Convert.ToDecimal(Table.Rows[0]["C_maxi"].ToString()).ToString("0.00");
									textBox17.Visible=true;
									textBox16.Visible=true;
									label18.Text="Type ISO";
									label18.Visible=true;
									label19.Text="Classe ISO";
									label19.Visible=true;
									label20.Text="C. mini (nm)";
									label20.Visible=true;
									label21.Text="C. maxi (nm)";
									label21.Visible=true;
									label22.Text="Précision";
									label22.Visible=true;
									label28.Visible=true;
									mtgcComboBox4.Visible=true;
								}
								else
								{
									label26.Visible=true;
									textBox13.Visible=true;
									textBox14.Visible=true;
									textBox15.Text="0,00";
									textBox15.Visible=true;
									textBox17.Text="0,00";
									textBox17.Visible=true;
									textBox16.Visible=true;
									label18.Text="Type ISO";
									label18.Visible=true;
									label19.Text="Classe ISO";
									label19.Visible=true;
									label20.Text="C. mini (nm)";
									label20.Visible=true;
									label21.Text="C. maxi (nm)";
									label21.Visible=true;
									label22.Text="Précision";
									label22.Visible=true;
									label28.Visible=true;
									mtgcComboBox4.Visible=true;
								}


							}
							else if(Selrow["Type"].ToString().Equals("2"))
							{
								Comm.Connection=oleDbConnection1;
								Comm.CommandText="select * from t_type_machine_vis where code='"+textBox1.Text+"'";
								oleDbDataAdapter5.SelectCommand=Comm;
								try
								{
									oleDbDataAdapter5.Fill(ds);
								}
								catch(Exception exp)
								{

								}
								DataTable Table = ds.Tables["T_type_machine_vis"];
								if(Table.Rows.Count>0)
								{
									textBox18.Visible=true;
									textBox19.Visible=true;
									textBox20.Visible=true;
									label24.Visible=true;
									label25.Visible=true;
									label27.Visible=true;
									textBox18.Text=System.Convert.ToDecimal(Table.Rows[0]["C_mini"].ToString()).ToString("0.00");
									textBox19.Text=System.Convert.ToDecimal(Table.Rows[0]["C_maxi"].ToString()).ToString("0.00");
									textBox20.Text=System.Convert.ToDecimal(Table.Rows[0]["Vitesse"].ToString()).ToString("0.00");
									label24.Text="C. mini(Nm)";
									label25.Text="C. maxi(Nm)";
									label27.Text="Vitesse (t/mn)";
									panel1.Visible=true;
								}
								else
								{
									textBox18.Visible=true;
									textBox19.Visible=true;
									textBox20.Visible=true;
									label24.Visible=true;
									label25.Visible=true;
									label27.Visible=true;
									textBox18.Text="0,00";
									textBox19.Text="0,00";
									textBox20.Text="0,00";
									label24.Text="C. mini (Nm)";
									label25.Text="C. maxi (Nm)";
									label27.Text="Vitesse (t/mn)";
									panel1.Visible=true;
								}
							}
							else if(Selrow["Type"].ToString().Equals("3"))
							{
								Comm.Connection=oleDbConnection1;
								Comm.CommandText="select * from t_type_machine_meu where code='"+textBox1.Text+"'";
								oleDbDataAdapter6.SelectCommand=Comm;
								try
								{
									oleDbDataAdapter6.Fill(ds);
								}
								catch(Exception exp)
								{

								}

								DataTable Table = ds.Tables["T_type_machine_meu"];
								if(Table.Rows.Count>0)
								{
									textBox18.Visible=true;
									textBox19.Visible=true;
									label24.Visible=true;
									label25.Visible=true;
									textBox18.Text=System.Convert.ToDecimal(Table.Rows[0]["Vitesse"].ToString()).ToString("0.00");
									textBox19.Text=System.Convert.ToDecimal(Table.Rows[0]["Puissance"].ToString()).ToString("0.00");
									label24.Text="Vitesse t/mn";
									label25.Text="Puissance Watt";
									panel1.Visible=true;
								}
								else
								{
									textBox18.Visible=true;
									textBox19.Visible=true;
									label24.Visible=true;
									label25.Visible=true;
									textBox18.Text="0,00";
									textBox19.Text="0,00";
									label24.Text="Vitesse t/mn";
									label25.Text="Puissance Watt";
									panel1.Visible=true;
								}
							}
							else if(Selrow["Type"].ToString().Equals("4"))
							{
								Comm.Connection=oleDbConnection1;
								Comm.CommandText="select * from t_type_machine_per where code='"+textBox1.Text+"'";
								oleDbDataAdapter7.SelectCommand=Comm;
								try
								{
									oleDbDataAdapter7.Fill(ds);
								}
								catch(Exception exp)
								{

								}
								DataTable Table = ds.Tables["T_type_machine_per"];
								if(Table.Rows.Count>0)
								{
									textBox18.Visible=true;
									textBox19.Visible=true;
									label24.Visible=true;
									label25.Visible=true;
									textBox18.Text=System.Convert.ToDecimal(Table.Rows[0]["Vitesse"].ToString()).ToString("0.00");
									textBox19.Text=System.Convert.ToDecimal(Table.Rows[0]["Puissance"].ToString()).ToString("0.00");
									label24.Text="Vitesse t/mn";
									label25.Text="Puissance Watt";
									panel1.Visible=true;
								}
								else
								{
									textBox18.Visible=true;
									textBox19.Visible=true;
									label24.Visible=true;
									label25.Visible=true;
									textBox18.Text="0,00";
									textBox19.Text="0,00";
									label24.Text="Vitesse t/mn";
									label25.Text="Puissance Watt";
									panel1.Visible=true;
								}
							}
							else if(Selrow["Type"].ToString().Equals("5"))
							{
								Comm.Connection=oleDbConnection1;
								Comm.CommandText="select * from t_type_machine_clc where code='"+textBox1.Text+"'";
								oleDbDataAdapter8.SelectCommand=Comm;
								try
								{
									oleDbDataAdapter8.Fill(ds);
								}
								catch(Exception exp)
								{

								}
								DataTable Table = ds.Tables["T_type_machine_clc"];
								if(Table.Rows.Count>0)
								{
									textBox18.Visible=true;
									textBox19.Visible=true;
									label24.Visible=true;
									label25.Visible=true;
									textBox18.Text=System.Convert.ToDecimal(Table.Rows[0]["C_maxi"].ToString()).ToString("0.00");
									textBox19.Text=System.Convert.ToDecimal(Table.Rows[0]["Vitesse"].ToString()).ToString("0.00");
									label24.Text="C_Maxi (mdaN)";
									label25.Text="Vitesse t/mn";
									panel1.Visible=true;
								}
								else
								{
									textBox18.Visible=true;
									textBox19.Visible=true;
									label24.Visible=true;
									label25.Visible=true;
									textBox18.Text="0,00";
									textBox19.Text="0,00";
									label24.Text="C_Maxi (mdaN)";
									label25.Text="Vitesse t/mn";
									panel1.Visible=true;
								}
							}
							else if(Selrow["Type"].ToString().Equals("6"))
							{
								label23.Visible=true;
								panel1.Visible=true;
							}
						}
						else
							MessageBox.Show("!!!");
					ds.Tables["Machine"].Clear();
					}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}		
			}
			save=false;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TypesMachines));
			this.label1 = new System.Windows.Forms.Label();
			this.btSupprime = new System.Windows.Forms.Button();
			this.btEnregistre = new System.Windows.Forms.Button();
			this.btNouveau = new System.Windows.Forms.Button();
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
			this.oleDbDataAdapter8 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand8 = new System.Data.OleDb.OleDbCommand();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label28 = new System.Windows.Forms.Label();
			this.mtgcComboBox4 = new MTGCComboBox();
			this.label27 = new System.Windows.Forms.Label();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.txNetCommande = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Recherche types";
			// 
			// btSupprime
			// 
			this.btSupprime.BackColor = System.Drawing.Color.White;
			this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSupprime.Enabled = false;
			this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btSupprime.ForeColor = System.Drawing.Color.Red;
			this.btSupprime.Location = new System.Drawing.Point(480, 640);
			this.btSupprime.Name = "btSupprime";
			this.btSupprime.Size = new System.Drawing.Size(100, 23);
			this.btSupprime.TabIndex = 0;
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
			this.btEnregistre.Location = new System.Drawing.Point(120, 640);
			this.btEnregistre.Name = "btEnregistre";
			this.btEnregistre.Size = new System.Drawing.Size(100, 23);
			this.btEnregistre.TabIndex = 13;
			this.btEnregistre.TabStop = false;
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
			this.btNouveau.Location = new System.Drawing.Point(8, 640);
			this.btNouveau.Name = "btNouveau";
			this.btNouveau.Size = new System.Drawing.Size(100, 23);
			this.btNouveau.TabIndex = 0;
			this.btNouveau.TabStop = false;
			this.btNouveau.Text = "Nouveau";
			this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
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
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM T_type_machine WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO T_type_machine(Code, [Code famille], [Date creation], [Date MAJ controle], [Date MAJ DNR], [Date MAJ Transport], [Delai garantie], [Forfait controle], [Forfait DNR], [Forfait Transport], Fournisseur, [Maxi machine], [Mini machine], [Mise a jour tarif], [Nombre reparations], [Prix catalogue], Vitesse) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT Code, [Code famille], [Date creation], [Date MAJ controle], [Date MAJ DNR], [Date MAJ Transport], [Delai garantie], [Forfait controle], [Forfait DNR], [Forfait Transport], Fournisseur, [Maxi machine], [Mini machine], [Mise a jour tarif], [Nombre reparations], [Prix catalogue], Vitesse FROM T_type_machine";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE T_type_machine SET Code = ?, [Code famille] = ?, [Date creation] = ?, [Date MAJ controle] = ?, [Date MAJ DNR] = ?, [Date MAJ Transport] = ?, [Delai garantie] = ?, [Forfait controle] = ?, [Forfait DNR] = ?, [Forfait Transport] = ?, Fournisseur = ?, [Maxi machine] = ?, [Mini machine] = ?, [Mise a jour tarif] = ?, [Nombre reparations] = ?, [Prix catalogue] = ?, Vitesse = ? WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_famille_machine", new System.Data.Common.DataColumnMapping[] {
																																																							 new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							 new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_1", "E_champ_1"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_2", "E_champ_2"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_3", "E_champ_3"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_4", "E_champ_4"),
																																																							 new System.Data.Common.DataColumnMapping("Type", "Type")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM T_famille_machine WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (E_champ_1 = ? OR ? IS NULL AND E_champ_1 IS NULL) AND (E_champ_2 = ? OR ? IS NULL AND E_champ_2 IS NULL) AND (E_champ_3 = ? OR ? IS NULL AND E_champ_3 IS NULL) AND (E_champ_4 = ? OR ? IS NULL AND E_champ_4 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO T_famille_machine(Code, Designation, E_champ_1, E_champ_2, E_champ_3," +
				" E_champ_4, Type) VALUES (?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Code, Designation, E_champ_1, E_champ_2, E_champ_3, E_champ_4, Type FROM T" +
				"_famille_machine ORDER BY Designation";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE T_famille_machine SET Code = ?, Designation = ?, E_champ_1 = ?, E_champ_2 = ?, E_champ_3 = ?, E_champ_4 = ?, Type = ? WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (E_champ_1 = ? OR ? IS NULL AND E_champ_1 IS NULL) AND (E_champ_2 = ? OR ? IS NULL AND E_champ_2 IS NULL) AND (E_champ_3 = ? OR ? IS NULL AND E_champ_3 IS NULL) AND (E_champ_4 = ? OR ? IS NULL AND E_champ_4 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
			// 
			// oleDbDeleteCommand3
			// 
			this.oleDbDeleteCommand3.CommandText = @"DELETE FROM T_fournisseurs WHERE (Code = ?) AND (Activite = ? OR ? IS NULL AND Activite IS NULL) AND ([Adresse 1] = ? OR ? IS NULL AND [Adresse 1] IS NULL) AND ([Adresse 2] = ? OR ? IS NULL AND [Adresse 2] IS NULL) AND ([Chiffre affaire Annee_1] = ? OR ? IS NULL AND [Chiffre affaire Annee_1] IS NULL) AND ([Chiffre affaire Annee_2] = ? OR ? IS NULL AND [Chiffre affaire Annee_2] IS NULL) AND ([Chiffre affaire Annee_3] = ? OR ? IS NULL AND [Chiffre affaire Annee_3] IS NULL) AND ([Chiffre affaire Annee_4] = ? OR ? IS NULL AND [Chiffre affaire Annee_4] IS NULL) AND ([Chiffre affaire PV] = ? OR ? IS NULL AND [Chiffre affaire PV] IS NULL) AND ([Chiffre affaire en cours] = ? OR ? IS NULL AND [Chiffre affaire en cours] IS NULL) AND ([Code Postal] = ? OR ? IS NULL AND [Code Postal] IS NULL) AND ([Coef PA PV] = ? OR ? IS NULL AND [Coef PA PV] IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Pays = ? OR ? IS NULL AND Pays IS NULL) AND ([Pourcentage Remise] = ? OR ? IS NULL AND [Pourcentage Remise] IS NULL) AND (Telecopie = ? OR ? IS NULL AND Telecopie IS NULL) AND (Telephone = ? OR ? IS NULL AND Telephone IS NULL) AND (Telex = ? OR ? IS NULL AND Telex IS NULL) AND (Ville = ? OR ? IS NULL AND Ville IS NULL)";
			this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Activite", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Activite1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telex", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telex", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand3
			// 
			this.oleDbInsertCommand3.CommandText = @"INSERT INTO T_fournisseurs(Activite, [Adresse 1], [Adresse 2], [Chiffre affaire Annee_1], [Chiffre affaire Annee_2], [Chiffre affaire Annee_3], [Chiffre affaire Annee_4], [Chiffre affaire en cours], [Chiffre affaire PV], Code, [Code Postal], [Coef PA PV], Commentaire, Nom, Pays, [Pourcentage Remise], Telecopie, Telephone, Telex, Ville) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Activite", System.Data.OleDb.OleDbType.VarWChar, 255, "Activite"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 1"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 2"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_1"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_2"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_3"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_4"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire en cours"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire PV"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, "Coef PA PV"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage Remise"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telex", System.Data.OleDb.OleDbType.VarWChar, 255, "Telex"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = @"SELECT Activite, [Adresse 1], [Adresse 2], [Chiffre affaire Annee_1], [Chiffre affaire Annee_2], [Chiffre affaire Annee_3], [Chiffre affaire Annee_4], [Chiffre affaire en cours], [Chiffre affaire PV], Code, [Code Postal], [Coef PA PV], Commentaire, Nom, Pays, [Pourcentage Remise], Telecopie, Telephone, Telex, Ville FROM T_fournisseurs ORDER BY Nom";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand3
			// 
			this.oleDbUpdateCommand3.CommandText = "UPDATE T_fournisseurs SET Activite = ?, [Adresse 1] = ?, [Adresse 2] = ?, [Chiffr" +
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
			this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Activite", System.Data.OleDb.OleDbType.VarWChar, 255, "Activite"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 1"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse 2"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_1"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_2"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_3"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire Annee_4"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire en cours"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, "Chiffre affaire PV"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 3, "Code"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, "Code Postal"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, "Coef PA PV"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commentaire", System.Data.OleDb.OleDbType.VarWChar, 0, "Commentaire"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 255, "Nom"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pays", System.Data.OleDb.OleDbType.VarWChar, 255, "Pays"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, "Pourcentage Remise"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, "Telecopie"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, "Telephone"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Telex", System.Data.OleDb.OleDbType.VarWChar, 255, "Telex"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ville", System.Data.OleDb.OleDbType.VarWChar, 255, "Ville"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Activite", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Activite1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Activite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_2", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_21", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse 2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_11", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_2", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_21", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_3", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_31", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_4", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_Annee_41", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire Annee_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire PV", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Chiffre_affaire_en_cours1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Chiffre affaire en cours", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Postal1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Postal", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Coef_PA_PV1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Coef PA PV", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pays1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pays", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Pourcentage_Remise1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pourcentage Remise", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telecopie1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telecopie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telephone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telex", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telex", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Telex1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Telex", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ville1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ville", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand4;
			this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand4;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_type_machine_dyn", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("C_maxi", "C_maxi"),
																																																							  new System.Data.Common.DataColumnMapping("C_mini", "C_mini"),
																																																							  new System.Data.Common.DataColumnMapping("Classe_Iso", "Classe_Iso"),
																																																							  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							  new System.Data.Common.DataColumnMapping("Precision", "Precision"),
																																																							  new System.Data.Common.DataColumnMapping("Type_Iso", "Type_Iso")})});
			this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand4;
			// 
			// oleDbDeleteCommand4
			// 
			this.oleDbDeleteCommand4.CommandText = @"DELETE FROM T_type_machine_dyn WHERE (Code = ?) AND (C_maxi = ? OR ? IS NULL AND C_maxi IS NULL) AND (C_mini = ? OR ? IS NULL AND C_mini IS NULL) AND (Classe_Iso = ? OR ? IS NULL AND Classe_Iso IS NULL) AND (Precision = ? OR ? IS NULL AND Precision IS NULL) AND (Type_Iso = ? OR ? IS NULL AND Type_Iso IS NULL)";
			this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Classe_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Classe_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Classe_Iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Classe_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Precision", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Precision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Precision1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Precision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_Iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type_Iso", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand4
			// 
			this.oleDbInsertCommand4.CommandText = "INSERT INTO T_type_machine_dyn(C_maxi, C_mini, Classe_Iso, Code, Precision, Type_" +
				"Iso) VALUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_mini", System.Data.OleDb.OleDbType.Double, 0, "C_mini"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Classe_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, "Classe_Iso"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Precision", System.Data.OleDb.OleDbType.Double, 0, "Precision"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, "Type_Iso"));
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = "SELECT C_maxi, C_mini, Classe_Iso, Code, Precision, Type_Iso FROM T_type_machine_" +
				"dyn";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand4
			// 
			this.oleDbUpdateCommand4.CommandText = @"UPDATE T_type_machine_dyn SET C_maxi = ?, C_mini = ?, Classe_Iso = ?, Code = ?, Precision = ?, Type_Iso = ? WHERE (Code = ?) AND (C_maxi = ? OR ? IS NULL AND C_maxi IS NULL) AND (C_mini = ? OR ? IS NULL AND C_mini IS NULL) AND (Classe_Iso = ? OR ? IS NULL AND Classe_Iso IS NULL) AND (Precision = ? OR ? IS NULL AND Precision IS NULL) AND (Type_Iso = ? OR ? IS NULL AND Type_Iso IS NULL)";
			this.oleDbUpdateCommand4.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_mini", System.Data.OleDb.OleDbType.Double, 0, "C_mini"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Classe_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, "Classe_Iso"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Precision", System.Data.OleDb.OleDbType.Double, 0, "Precision"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, "Type_Iso"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Classe_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Classe_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Classe_Iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Classe_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Precision", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Precision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Precision1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Precision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_Iso", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type_Iso", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_Iso1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type_Iso", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter5
			// 
			this.oleDbDataAdapter5.DeleteCommand = this.oleDbDeleteCommand5;
			this.oleDbDataAdapter5.InsertCommand = this.oleDbInsertCommand5;
			this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
			this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_type_machine_Vis", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("C_maxi", "C_maxi"),
																																																							  new System.Data.Common.DataColumnMapping("C_mini", "C_mini"),
																																																							  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							  new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse")})});
			this.oleDbDataAdapter5.UpdateCommand = this.oleDbUpdateCommand5;
			// 
			// oleDbDeleteCommand5
			// 
			this.oleDbDeleteCommand5.CommandText = "DELETE FROM T_type_machine_Vis WHERE (Code = ?) AND (C_maxi = ? OR ? IS NULL AND " +
				"C_maxi IS NULL) AND (C_mini = ? OR ? IS NULL AND C_mini IS NULL) AND (Vitesse = " +
				"? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbDeleteCommand5.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand5
			// 
			this.oleDbInsertCommand5.CommandText = "INSERT INTO T_type_machine_Vis(C_maxi, C_mini, Code, Vitesse) VALUES (?, ?, ?, ?)" +
				"";
			this.oleDbInsertCommand5.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_mini", System.Data.OleDb.OleDbType.Double, 0, "C_mini"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			// 
			// oleDbSelectCommand5
			// 
			this.oleDbSelectCommand5.CommandText = "SELECT C_maxi, C_mini, Code, Vitesse FROM T_type_machine_Vis";
			this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand5
			// 
			this.oleDbUpdateCommand5.CommandText = "UPDATE T_type_machine_Vis SET C_maxi = ?, C_mini = ?, Code = ?, Vitesse = ? WHERE" +
				" (Code = ?) AND (C_maxi = ? OR ? IS NULL AND C_maxi IS NULL) AND (C_mini = ? OR " +
				"? IS NULL AND C_mini IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)" +
				"";
			this.oleDbUpdateCommand5.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_mini", System.Data.OleDb.OleDbType.Double, 0, "C_mini"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter6
			// 
			this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand6;
			this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand6;
			this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
			this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_type_machine_meu", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							  new System.Data.Common.DataColumnMapping("Puissance", "Puissance"),
																																																							  new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse")})});
			this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand6;
			// 
			// oleDbDeleteCommand6
			// 
			this.oleDbDeleteCommand6.CommandText = "DELETE FROM T_type_machine_meu WHERE (Code = ?) AND (Puissance = ? OR ? IS NULL A" +
				"ND Puissance IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbDeleteCommand6.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Puissance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Puissance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand6
			// 
			this.oleDbInsertCommand6.CommandText = "INSERT INTO T_type_machine_meu(Code, Puissance, Vitesse) VALUES (?, ?, ?)";
			this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Puissance", System.Data.OleDb.OleDbType.Double, 0, "Puissance"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			// 
			// oleDbSelectCommand6
			// 
			this.oleDbSelectCommand6.CommandText = "SELECT Code, Puissance, Vitesse FROM T_type_machine_meu";
			this.oleDbSelectCommand6.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand6
			// 
			this.oleDbUpdateCommand6.CommandText = "UPDATE T_type_machine_meu SET Code = ?, Puissance = ?, Vitesse = ? WHERE (Code = " +
				"?) AND (Puissance = ? OR ? IS NULL AND Puissance IS NULL) AND (Vitesse = ? OR ? " +
				"IS NULL AND Vitesse IS NULL)";
			this.oleDbUpdateCommand6.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Puissance", System.Data.OleDb.OleDbType.Double, 0, "Puissance"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Puissance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Puissance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter7
			// 
			this.oleDbDataAdapter7.DeleteCommand = this.oleDbDeleteCommand7;
			this.oleDbDataAdapter7.InsertCommand = this.oleDbInsertCommand7;
			this.oleDbDataAdapter7.SelectCommand = this.oleDbSelectCommand7;
			this.oleDbDataAdapter7.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_type_machine_per", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							  new System.Data.Common.DataColumnMapping("Puissance", "Puissance"),
																																																							  new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse")})});
			this.oleDbDataAdapter7.UpdateCommand = this.oleDbUpdateCommand7;
			// 
			// oleDbDeleteCommand7
			// 
			this.oleDbDeleteCommand7.CommandText = "DELETE FROM T_type_machine_per WHERE (Code = ?) AND (Puissance = ? OR ? IS NULL A" +
				"ND Puissance IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbDeleteCommand7.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Puissance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Puissance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand7
			// 
			this.oleDbInsertCommand7.CommandText = "INSERT INTO T_type_machine_per(Code, Puissance, Vitesse) VALUES (?, ?, ?)";
			this.oleDbInsertCommand7.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Puissance", System.Data.OleDb.OleDbType.Double, 0, "Puissance"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			// 
			// oleDbSelectCommand7
			// 
			this.oleDbSelectCommand7.CommandText = "SELECT Code, Puissance, Vitesse FROM T_type_machine_per";
			this.oleDbSelectCommand7.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand7
			// 
			this.oleDbUpdateCommand7.CommandText = "UPDATE T_type_machine_per SET Code = ?, Puissance = ?, Vitesse = ? WHERE (Code = " +
				"?) AND (Puissance = ? OR ? IS NULL AND Puissance IS NULL) AND (Vitesse = ? OR ? " +
				"IS NULL AND Vitesse IS NULL)";
			this.oleDbUpdateCommand7.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Puissance", System.Data.OleDb.OleDbType.Double, 0, "Puissance"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Puissance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Puissance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter8
			// 
			this.oleDbDataAdapter8.DeleteCommand = this.oleDbDeleteCommand8;
			this.oleDbDataAdapter8.InsertCommand = this.oleDbInsertCommand8;
			this.oleDbDataAdapter8.SelectCommand = this.oleDbSelectCommand8;
			this.oleDbDataAdapter8.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_type_machine_ClC", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("C_maxi", "C_maxi"),
																																																							  new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							  new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse")})});
			this.oleDbDataAdapter8.UpdateCommand = this.oleDbUpdateCommand8;
			// 
			// oleDbDeleteCommand8
			// 
			this.oleDbDeleteCommand8.CommandText = "DELETE FROM T_type_machine_ClC WHERE (Code = ?) AND (C_maxi = ? OR ? IS NULL AND " +
				"C_maxi IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbDeleteCommand8.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand8
			// 
			this.oleDbInsertCommand8.CommandText = "INSERT INTO T_type_machine_ClC(C_maxi, Code, Vitesse) VALUES (?, ?, ?)";
			this.oleDbInsertCommand8.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"));
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			// 
			// oleDbSelectCommand8
			// 
			this.oleDbSelectCommand8.CommandText = "SELECT C_maxi, Code, Vitesse FROM T_type_machine_ClC";
			this.oleDbSelectCommand8.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand8
			// 
			this.oleDbUpdateCommand8.CommandText = "UPDATE T_type_machine_ClC SET C_maxi = ?, Code = ?, Vitesse = ? WHERE (Code = ?) " +
				"AND (C_maxi = ? OR ? IS NULL AND C_maxi IS NULL) AND (Vitesse = ? OR ? IS NULL A" +
				"ND Vitesse IS NULL)";
			this.oleDbUpdateCommand8.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Location = new System.Drawing.Point(-8, 48);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(944, 560);
			this.tabControlEX1.TabColor = System.Drawing.Color.DarkGray;
			this.tabControlEX1.TabIndex = 14;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.groupBox2);
			this.tabPageEX1.Controls.Add(this.groupBox1);
			this.tabPageEX1.Controls.Add(this.groupBox4);
			this.tabPageEX1.Controls.Add(this.groupBox3);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(936, 531);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Saisie";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.label28);
			this.groupBox2.Controls.Add(this.mtgcComboBox4);
			this.groupBox2.Controls.Add(this.label27);
			this.groupBox2.Controls.Add(this.textBox20);
			this.groupBox2.Controls.Add(this.label26);
			this.groupBox2.Controls.Add(this.label25);
			this.groupBox2.Controls.Add(this.label24);
			this.groupBox2.Controls.Add(this.textBox19);
			this.groupBox2.Controls.Add(this.textBox18);
			this.groupBox2.Controls.Add(this.label23);
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.textBox17);
			this.groupBox2.Controls.Add(this.textBox16);
			this.groupBox2.Controls.Add(this.textBox15);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.textBox14);
			this.groupBox2.Controls.Add(this.textBox13);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(504, 9);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(409, 292);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(32, 96);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(240, 16);
			this.label28.TabIndex = 21;
			this.label28.Text = "Liste des types et classes ISO";
			this.label28.Visible = false;
			// 
			// mtgcComboBox4
			// 
			this.mtgcComboBox4.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox4.ColumnNum = 4;
			this.mtgcComboBox4.ColumnWidth = "0;100;100;100";
			this.mtgcComboBox4.DisplayMember = "Text";
			this.mtgcComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox4.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox4.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox4.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox4.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox4.DropDownWidth = 320;
			this.mtgcComboBox4.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox4.GridLineHorizontal = false;
			this.mtgcComboBox4.GridLineVertical = true;
			this.mtgcComboBox4.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox4.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox4.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox4.Location = new System.Drawing.Point(32, 112);
			this.mtgcComboBox4.ManagingFastMouseMoving = true;
			this.mtgcComboBox4.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox4.Name = "mtgcComboBox4";
			this.mtgcComboBox4.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox4.Size = new System.Drawing.Size(344, 21);
			this.mtgcComboBox4.TabIndex = 1;
			this.mtgcComboBox4.Visible = false;
			this.mtgcComboBox4.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox4_SelectedIndexChanged);
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(272, 152);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(106, 15);
			this.label27.TabIndex = 19;
			// 
			// textBox20
			// 
			this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox20.Location = new System.Drawing.Point(272, 168);
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new System.Drawing.Size(104, 20);
			this.textBox20.TabIndex = 4;
			this.textBox20.Text = "";
			this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox20.Visible = false;
			this.textBox20.Leave += new System.EventHandler(this.textBox20_Leave);
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(360, 232);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(12, 15);
			this.label26.TabIndex = 17;
			this.label26.Text = "%";
			this.label26.Visible = false;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(152, 152);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(104, 15);
			this.label25.TabIndex = 16;
			this.label25.Visible = false;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(32, 152);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(112, 14);
			this.label24.TabIndex = 15;
			this.label24.Visible = false;
			// 
			// textBox19
			// 
			this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox19.Location = new System.Drawing.Point(152, 168);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(104, 20);
			this.textBox19.TabIndex = 3;
			this.textBox19.Text = "";
			this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox19.Visible = false;
			this.textBox19.Leave += new System.EventHandler(this.textBox19_Leave);
			// 
			// textBox18
			// 
			this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox18.Location = new System.Drawing.Point(32, 168);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(104, 20);
			this.textBox18.TabIndex = 2;
			this.textBox18.Text = "";
			this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox18.Visible = false;
			this.textBox18.Leave += new System.EventHandler(this.textBox18_Leave);
			// 
			// label23
			// 
			this.label23.ForeColor = System.Drawing.Color.Red;
			this.label23.Location = new System.Drawing.Point(32, 77);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(266, 17);
			this.label23.TabIndex = 12;
			this.label23.Text = "Aucune information pour cette machine";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label23.Visible = false;
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.Location = new System.Drawing.Point(312, 200);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(58, 31);
			this.label22.TabIndex = 11;
			this.label22.Text = "label22";
			this.label22.Visible = false;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.Location = new System.Drawing.Point(240, 200);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(47, 32);
			this.label21.TabIndex = 10;
			this.label21.Text = "label21";
			this.label21.Visible = false;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(176, 200);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(50, 28);
			this.label20.TabIndex = 9;
			this.label20.Text = "label20";
			this.label20.Visible = false;
			// 
			// textBox17
			// 
			this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox17.Location = new System.Drawing.Point(240, 232);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(53, 20);
			this.textBox17.TabIndex = 8;
			this.textBox17.Text = "";
			this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox17.Visible = false;
			this.textBox17.Leave += new System.EventHandler(this.textBox17_Leave);
			// 
			// textBox16
			// 
			this.textBox16.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox16.ForeColor = System.Drawing.Color.White;
			this.textBox16.Location = new System.Drawing.Point(312, 232);
			this.textBox16.Name = "textBox16";
			this.textBox16.ReadOnly = true;
			this.textBox16.Size = new System.Drawing.Size(44, 20);
			this.textBox16.TabIndex = 9;
			this.textBox16.Text = "";
			this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox16.Visible = false;
			// 
			// textBox15
			// 
			this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox15.Location = new System.Drawing.Point(168, 232);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(53, 20);
			this.textBox15.TabIndex = 7;
			this.textBox15.Text = "";
			this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox15.Visible = false;
			this.textBox15.Leave += new System.EventHandler(this.textBox15_Leave);
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(104, 200);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(44, 27);
			this.label19.TabIndex = 4;
			this.label19.Text = "label19";
			this.label19.Visible = false;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(32, 200);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(44, 26);
			this.label18.TabIndex = 3;
			this.label18.Text = "label18";
			this.label18.Visible = false;
			// 
			// textBox14
			// 
			this.textBox14.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox14.ForeColor = System.Drawing.Color.White;
			this.textBox14.Location = new System.Drawing.Point(104, 232);
			this.textBox14.Name = "textBox14";
			this.textBox14.ReadOnly = true;
			this.textBox14.Size = new System.Drawing.Size(51, 20);
			this.textBox14.TabIndex = 6;
			this.textBox14.Text = "";
			this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox14.Visible = false;
			// 
			// textBox13
			// 
			this.textBox13.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox13.ForeColor = System.Drawing.Color.White;
			this.textBox13.Location = new System.Drawing.Point(32, 232);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(50, 20);
			this.textBox13.TabIndex = 5;
			this.textBox13.Text = "";
			this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox13.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Location = new System.Drawing.Point(32, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(344, 56);
			this.panel1.TabIndex = 0;
			this.panel1.Visible = false;
			// 
			// label17
			// 
			this.label17.ForeColor = System.Drawing.Color.SpringGreen;
			this.label17.Location = new System.Drawing.Point(18, 29);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(307, 23);
			this.label17.TabIndex = 1;
			this.label17.Text = "label17";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(90, 10);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(161, 12);
			this.label16.TabIndex = 0;
			this.label16.Text = "Caractéristiques machine";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.mtgcComboBox2);
			this.groupBox1.Controls.Add(this.mtgcComboBox1);
			this.groupBox1.Controls.Add(this.textBox21);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(16, 9);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(488, 176);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(248, 32);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// mtgcComboBox2
			// 
			this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox2.ColumnNum = 1;
			this.mtgcComboBox2.ColumnWidth = "121";
			this.mtgcComboBox2.DisplayMember = "Text";
			this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox2.DropDownWidth = 141;
			this.mtgcComboBox2.Enabled = false;
			this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox2.GridLineHorizontal = false;
			this.mtgcComboBox2.GridLineVertical = false;
			this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox2.Location = new System.Drawing.Point(88, 112);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(312, 21);
			this.mtgcComboBox2.TabIndex = 4;
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(88, 72);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(312, 21);
			this.mtgcComboBox1.TabIndex = 3;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// textBox21
			// 
			this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox21.Location = new System.Drawing.Point(416, 32);
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new System.Drawing.Size(34, 20);
			this.textBox21.TabIndex = 42;
			this.textBox21.TabStop = false;
			this.textBox21.Text = "";
			this.textBox21.Visible = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Enabled = false;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(416, 112);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 20);
			this.button2.TabIndex = 0;
			this.button2.TabStop = false;
			this.button2.Text = "...";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Enabled = false;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(416, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 20);
			this.button1.TabIndex = 0;
			this.button1.TabStop = false;
			this.button1.Text = "...";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Fournisseur";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Code famille";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(88, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(139, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(248, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Date création";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Code";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox4.Controls.Add(this.textBox6);
			this.groupBox4.Controls.Add(this.dateTimePicker5);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.textBox5);
			this.groupBox4.Controls.Add(this.textBox3);
			this.groupBox4.Location = new System.Drawing.Point(16, 176);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(488, 125);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.White;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Enabled = false;
			this.textBox6.Location = new System.Drawing.Point(320, 64);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(80, 20);
			this.textBox6.TabIndex = 8;
			this.textBox6.Text = "90";
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dateTimePicker5
			// 
			this.dateTimePicker5.Checked = false;
			this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker5.Location = new System.Drawing.Point(104, 64);
			this.dateTimePicker5.Name = "dateTimePicker5";
			this.dateTimePicker5.ShowCheckBox = true;
			this.dateTimePicker5.Size = new System.Drawing.Size(96, 20);
			this.dateTimePicker5.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(320, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "Délai garantie";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(216, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "Nbr réparations";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(120, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 16);
			this.label7.TabIndex = 0;
			this.label7.Text = "MAJ Tarifs";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 14);
			this.label6.TabIndex = 0;
			this.label6.Text = "Prix catalogue";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.White;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Enabled = false;
			this.textBox5.Location = new System.Drawing.Point(224, 64);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(63, 20);
			this.textBox5.TabIndex = 7;
			this.textBox5.Text = "0";
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(11, 64);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(77, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox3.Controls.Add(this.dateTimePicker4);
			this.groupBox3.Controls.Add(this.dateTimePicker3);
			this.groupBox3.Controls.Add(this.dateTimePicker2);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.textBox11);
			this.groupBox3.Controls.Add(this.txNetCommande);
			this.groupBox3.Controls.Add(this.textBox7);
			this.groupBox3.Location = new System.Drawing.Point(16, 296);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(897, 79);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			// 
			// dateTimePicker4
			// 
			this.dateTimePicker4.Checked = false;
			this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker4.Location = new System.Drawing.Point(592, 40);
			this.dateTimePicker4.Name = "dateTimePicker4";
			this.dateTimePicker4.ShowCheckBox = true;
			this.dateTimePicker4.Size = new System.Drawing.Size(96, 20);
			this.dateTimePicker4.TabIndex = 14;
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Checked = false;
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker3.Location = new System.Drawing.Point(344, 40);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.ShowCheckBox = true;
			this.dateTimePicker3.Size = new System.Drawing.Size(96, 20);
			this.dateTimePicker3.TabIndex = 12;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Checked = false;
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(120, 40);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.ShowCheckBox = true;
			this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
			this.dateTimePicker2.TabIndex = 10;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(584, 24);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(109, 16);
			this.label15.TabIndex = 0;
			this.label15.Text = "Date MAJ contrôle";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(472, 24);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(93, 16);
			this.label14.TabIndex = 0;
			this.label14.Text = "Forfait contrôle";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(344, 24);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(117, 16);
			this.label13.TabIndex = 0;
			this.label13.Text = "Date MAJ transport";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(232, 24);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 16);
			this.label12.TabIndex = 0;
			this.label12.Text = "Forfait transport";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(120, 24);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = "Date MAJ DNR";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(27, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(117, 16);
			this.label10.TabIndex = 0;
			this.label10.Text = "Forfait DNR";
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.Color.White;
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Enabled = false;
			this.textBox11.Location = new System.Drawing.Point(472, 40);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(90, 20);
			this.textBox11.TabIndex = 13;
			this.textBox11.Text = "0,00";
			this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txNetCommande
			// 
			this.txNetCommande.BackColor = System.Drawing.Color.White;
			this.txNetCommande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txNetCommande.Enabled = false;
			this.txNetCommande.Location = new System.Drawing.Point(232, 40);
			this.txNetCommande.Name = "txNetCommande";
			this.txNetCommande.Size = new System.Drawing.Size(90, 20);
			this.txNetCommande.TabIndex = 11;
			this.txNetCommande.Text = "0,00";
			this.txNetCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.White;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Enabled = false;
			this.textBox7.Location = new System.Drawing.Point(11, 40);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(90, 20);
			this.textBox7.TabIndex = 9;
			this.textBox7.Text = "0,00";
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mtgcComboBox3
			// 
			this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox3.ColumnNum = 3;
			this.mtgcComboBox3.ColumnWidth = "150;200;200";
			this.mtgcComboBox3.DisplayMember = "Text";
			this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox3.DropDownWidth = 670;
			this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox3.GridLineHorizontal = false;
			this.mtgcComboBox3.GridLineVertical = true;
			this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox3.Location = new System.Drawing.Point(144, 8);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(560, 21);
			this.mtgcComboBox3.TabIndex = 0;
			this.mtgcComboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox3_KeyDown);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(848, 624);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 16;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// TypesMachines
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(924, 688);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.mtgcComboBox3);
			this.Controls.Add(this.tabControlEX1);
			this.Controls.Add(this.btSupprime);
			this.Controls.Add(this.btEnregistre);
			this.Controls.Add(this.btNouveau);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "TypesMachines";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Types machines";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select T_type_machine.Code, T_famille_machine.Designation, T_fournisseurs.Nom FROM t_type_machine,T_fournisseurs,T_famille_machine where T_type_machine.Fournisseur=T_fournisseurs.Code and T_type_machine.[Code famille]=T_famille_machine.Code order by 1 asc";
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
				mtgcComboBox3.SourceDataString=new string[]{"Code","Nom","Designation",""};
				mtgcComboBox3.SourceDataTable=dataSet11.T_type_machine;
			}
			catch(Exception exp)
			{
				
			}
			try
			{
				oleDbDataAdapter2.Fill(dataSet11);
				foreach(DataRow row in dataSet11.Tables["T_famille_machine"].Rows)
				{
					MTGCComboBoxItem item = new MTGCComboBoxItem(row["designation"].ToString(),"","","");
					item.Tag=row["Code"].ToString();
					mtgcComboBox1.Items.Add(item);
				}
				
				mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
				mtgcComboBox1.SelectedIndex=0;
				dataSet11.Tables["T_famille_machine"].Clear();
			}
			catch(Exception exp)
			{
			}
			try
			{
				oleDbDataAdapter3.Fill(dataSet11);
				foreach(DataRow row in dataSet11.Tables["t_fournisseurs"].Rows)
				{
					MTGCComboBoxItem item = new MTGCComboBoxItem(row["nom"].ToString(),"","","");
					item.Tag=row["Code"].ToString();
					mtgcComboBox2.Items.Add(item);
				}
				mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
				mtgcComboBox2.SelectedIndex=0;
			}
			catch(Exception exp)
			{
			}
			
			mtgcComboBox3.SelectedIndex=-1;
			Comm.CommandText="Select * from t_type_machine_dyn_iso order by type,classe";
			OleDbDataAdapter DataAD = new OleDbDataAdapter();
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(dataSet11,"T_type_machine_dyn_iso");
				foreach(DataRow row in dataSet11.Tables["t_type_machine_dyn_iso"].Rows)
				{
					Decimal Precision = System.Convert.ToDecimal(row["precision"].ToString())*100;
					mtgcComboBox4.Items.Add(new MTGCComboBoxItem(row["ID"].ToString(),row["Type"].ToString(),row["Classe"].ToString(),Precision.ToString()));
				}
			}
			catch(Exception exp)
			{
			}
			
			mtgcComboBox4.SelectedIndex=-1;
		}

		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}


		private void button1_Click(object sender, System.EventArgs e)
		{
			if(mtgcComboBox1.SelectedIndex>=0)
			{
				FamillesMachines WinFamilles = new FamillesMachines(Agence,mtgcComboBox1.Text);
				WinFamilles.ShowDialog();
				this.Update();
			}
			else
			{
				FamillesMachines WinFamilles = new FamillesMachines(Agence,"");
				WinFamilles.ShowDialog();
				mtgcComboBox1.Items.Clear();
				dataSet11.Tables["t_famille_machine"].Clear();
				try
				{
					oleDbDataAdapter2.Fill(dataSet11);
					foreach(DataRow row in dataSet11.Tables["T_famille_machine"].Rows)
					{
						MTGCComboBoxItem item = new MTGCComboBoxItem(row["designation"].ToString(),"","","");
						item.Tag=row["Code"].ToString();
						mtgcComboBox1.Items.Add(item);
					}
				
					mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
					mtgcComboBox1.SelectedIndex=0;
					dataSet11.Tables["T_famille_machine"].Clear();
				}
				catch(Exception exp)
				{

				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(mtgcComboBox2.SelectedIndex>=0)
			{
				SaisieFournisseurs WinFourn = new SaisieFournisseurs(Agence,Fourn);
				WinFourn.ShowDialog();
				this.Refresh();
			}
			else
			{
				SaisieFournisseurs WinFourn = new SaisieFournisseurs(Agence,true);
				WinFourn.ShowDialog();
				mtgcComboBox2.Items.Clear();
				dataSet11.Tables["t_fournisseurs"].Clear();
				try
				{
					oleDbDataAdapter3.Fill(dataSet11);
					foreach(DataRow row in dataSet11.Tables["t_fournisseurs"].Rows)
					{
						MTGCComboBoxItem item = new MTGCComboBoxItem(row["nom"].ToString(),"","","");
						item.Tag=row["Code"].ToString();
						mtgcComboBox2.Items.Add(item);
					}
					mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
					mtgcComboBox2.SelectedIndex=0;
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				this.Refresh();
			}
		}

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			nouveau=true;
			Enable();
			Vider();
			textBox1.Focus();
			textBox1.ForeColor=Color.Black;
			textBox1.BackColor=Color.MistyRose;
		}

		private void Enable()
		{
			textBox1.BackColor=Color.MistyRose;
			textBox1.ForeColor=Color.White;
			textBox1.Focus();
			btEnregistre.Enabled=true;
			btSupprime.Enabled=true;
			textBox1.Enabled=true;
			textBox3.Enabled=true;
			textBox5.Enabled=true;
			textBox6.Enabled=true;
			dateTimePicker1.Enabled=true;
			textBox7.Enabled=true;
			txNetCommande.Enabled=true;
			textBox11.Enabled=true;
			mtgcComboBox1.Enabled=true;
			mtgcComboBox2.Enabled=true;
			button1.Enabled=true;
			button2.Enabled=true;
			mtgcComboBox3.SelectedIndex=0;
			mtgcComboBox1.SelectedIndex=0;
			mtgcComboBox2.SelectedIndex=0;
		}

		private void Vider()
		{
			textBox1.Text="";
			textBox3.Text="";
			textBox5.Text="0";
			textBox6.Text="90";
			textBox7.Text="0,00";
			txNetCommande.Text="0,00";
			textBox11.Text="0,00";
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			int Error=0;

			if(mtgcComboBox1.SelectedIndex.Equals(0))
			{
				mtgcComboBox1.BackColor=Color.PeachPuff;
				Error=1;
			}
			else
				mtgcComboBox1.BackColor=Color.Empty;
			
			if(mtgcComboBox2.SelectedIndex.Equals(0))
			{
				mtgcComboBox2.BackColor=Color.PeachPuff;
				Error=1;
			}
			else
				mtgcComboBox2.BackColor=Color.Empty;
			if(textBox1.TextLength.Equals(0))
			{
				textBox1.BackColor=Color.PeachPuff;
				Error=1;
			}
			else
			{
				textBox1.BackColor=Color.Empty;
			}
			if(Error.Equals(0))
			{
				Comm.CommandText="select * from t_type_machine where code='"+textBox1.Text+"'";
				OleDbDataAdapter DataAD=new OleDbDataAdapter();
				DataSet ds = new DataSet();
				DataAD.SelectCommand=Comm;
				try
				{
					DataAD.Fill(ds,"t_type_machine");
				}
				catch(Exception exp)
				{
				}
				if(nouveau)
				{
					if(ds.Tables["t_type_machine"].Rows.Count>0)
					{
						MessageBox.Show("Code machine déja existant !");
					}
					else
					{
						MTGCComboBoxItem Fourn=(MTGCComboBoxItem)mtgcComboBox2.SelectedItem;
						MTGCComboBoxItem Famille=(MTGCComboBoxItem)mtgcComboBox1.SelectedItem;

						save=true;
				
						nouveau=false;
						String SQL="INSERT INTO t_type_machine (Code,[Code famille],Fournisseur,[Date Creation]";
						if(textBox3.Text.Length>0)
							SQL+=",[Prix catalogue]";
						if(dateTimePicker5.Checked.Equals(true))
							SQL+=",[Mise a jour tarif]";
						if(textBox6.Text.Length>0)
							SQL+=",[Delai garantie]";
						if(textBox7.Text.Length>0)
							SQL+=",[Forfait DNR]";
						if(dateTimePicker2.Checked.Equals(true))
							SQL+=",[Date MAJ DNR]";
						if(txNetCommande.Text.Length>0)
							SQL+=",[Forfait transport]";
						if(dateTimePicker3.Checked.Equals(true))
							SQL+=",[Date MAJ transport]";
						if(textBox11.Text.Length>0)
							SQL+=",[Forfait controle]";
						if(dateTimePicker4.Checked.Equals(true))
							SQL+=",[Date MAJ controle]";
						SQL+=") VALUES ('"+textBox1.Text.Replace("'","''").ToUpper()+"',"+Famille.Tag.ToString()+",'"+Fourn.Tag.ToString()+"','"+dateTimePicker1.Value.ToShortDateString()+"'";
						if(textBox3.Text.Length>0)
							SQL+=","+textBox3.Text.Replace(",",".");
						if(dateTimePicker5.Checked.Equals(true))
							SQL+=",'"+dateTimePicker5.Value.ToShortDateString()+"'";
						if(textBox6.Text.ToUpper().Length!=0)
							SQL+=","+textBox6.Text.Replace(",",".");
						if(textBox7.Text.ToUpper().Length!=0)
							SQL+=","+textBox7.Text.Replace(",",".");
						if(dateTimePicker2.Checked.Equals(true))
							SQL+=",'"+dateTimePicker2.Value.ToShortDateString()+"'";
						if(txNetCommande.Text.ToUpper().Length!=0)
							SQL+=","+txNetCommande.Text.Replace(",",".");
						if(dateTimePicker3.Checked.Equals(true))
							SQL+=",'"+dateTimePicker3.Value.ToShortDateString()+"'";
						if(textBox11.Text.ToUpper().Length!=0)
							SQL+=","+textBox11.Text.Replace(",",".");
						if(dateTimePicker4.Checked.Equals(true))
							SQL+=",'"+dateTimePicker4.Value.ToShortDateString()+"'";
						SQL+=")";
						Comm.CommandText=SQL;
						try
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.Transaction=Transac;
							Comm.ExecuteNonQuery();
							/*try
							{
								Transac.Commit();
							}
							catch(OleDbException excp)
							{
								Transac.Rollback();
							}*/
							
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						textBox15.Text=textBox15.Text.Replace(",",".");
						textBox16.Text=textBox16.Text.Replace(",",".");
						textBox17.Text=textBox17.Text.Replace(",",".");
						textBox18.Text=textBox18.Text.Replace(",",".");
						textBox19.Text=textBox19.Text.Replace(",",".");
						textBox20.Text=textBox20.Text.Replace(",",".");
						if(textBox21.Text.Equals("1"))
						{
							dataSet11.Tables["t_type_machine_dyn"].Clear();
							Comm.CommandText="select * from t_type_machine_dyn where code='"+textBox1.Text+"'";
							oleDbDataAdapter4.SelectCommand=Comm;
							oleDbDataAdapter4.Fill(dataSet11,"t_type_machine_dyn");
							if(dataSet11.Tables["t_type_machine_dyn"].Rows.Count.Equals(0))
							{
								Decimal Precision = System.Convert.ToDecimal(textBox16.Text.Replace(".",","))/100;
								Comm.CommandText="insert into t_type_machine_dyn (code,idIso,C_mini,C_maxi) values ('"+textBox1.Text.ToUpper()+"',"+mtgcComboBox4.Text+","+textBox15.Text.Replace(",",".")+","+textBox17.Text.Replace(",",".")+")";
								try
								{
									Comm.ExecuteNonQuery();
									try
									{
										Transac.Commit();
										MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
									}
									catch(OleDbException excp)
									{
										Transac.Rollback();
										MessageBox.Show(excp.Message);
									}
								}
								catch(Exception exp)
								{
									MessageBox.Show(Comm.CommandText);
									MessageBox.Show(exp.Message);
								}
								finally
								{
									oleDbConnection1.Close();
								}
							}
							else
							{
								Comm.CommandText="update t_type_machine_dyn set [iDiso]="+mtgcComboBox4.Text+",[c_mini]="+textBox15.Text.Replace(",",".")+",[c_maxi]="+textBox17.Text.Replace(",",".")+" where code='"+textBox1.Text+"'";
								try
								{
									Comm.ExecuteNonQuery();
									try
									{
										Transac.Commit();
										MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
									}
									catch(OleDbException excp)
									{
										Transac.Rollback();
										MessageBox.Show(excp.Message);
									}
								}
								catch(Exception exp)
								{
									MessageBox.Show(Comm.CommandText);
									MessageBox.Show(exp.Message);
								}
								finally
								{
									oleDbConnection1.Close();
								}
							}
						}
						else if(textBox21.Text.Equals("2"))
						{
							Comm.CommandText="select * from t_type_machine_vis where code='"+textBox1.Text+"'";
							oleDbDataAdapter5.SelectCommand=Comm;
							try
							{
								oleDbDataAdapter5.Fill(dataSet11);
							}
							catch(Exception exp)
							{

							}
							Comm.CommandText="INSERT INTO t_type_machine_vis (code,[c_mini],[c_maxi],[vitesse]) VALUES ('"+textBox1.Text.Replace(",",".").ToUpper()+"',"+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+","+textBox20.Text.Replace(",",".")+")";
							try
							{
								Comm.ExecuteNonQuery();
								try
								{
									Transac.Commit();
									MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
						else if(textBox21.Text.Equals("3"))
						{
							Comm.CommandText="select * from t_type_machine_meu where code='"+textBox1.Text+"'";
							oleDbDataAdapter6.SelectCommand=Comm;
							try
							{
								oleDbDataAdapter6.Fill(dataSet11);
							}
							catch(Exception exp)
							{

							}
							Comm.CommandText="insert into t_type_machine_meu (code,vitesse,puissance) values ('"+textBox1.Text.Replace(",",".").ToUpper()+"',"+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+")";;
							try
							{
								Comm.ExecuteNonQuery();
								try
								{
									Transac.Commit();
									MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
						else if(textBox21.Text.Equals("4"))
						{
							Comm.CommandText="select * from t_type_machine_per where code='"+textBox1.Text+"'";
							oleDbDataAdapter7.SelectCommand=Comm;
							try
							{
								oleDbDataAdapter7.Fill(dataSet11);
							}
							catch(Exception exp)
							{

							}
							Comm.CommandText="insert into t_type_machine_per (code,vitesse,puissance) values ('"+textBox1.Text.Replace(",",".").ToUpper()+"',"+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+")";
							try
							{
								Comm.ExecuteNonQuery();
								try
								{
									Transac.Commit();
									MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
								}
								catch(OleDbException excp)
								{
									Transac.Rollback();
									MessageBox.Show(excp.Message);
								}
							}
							catch(Exception exp)
							{
								MessageBox.Show(Comm.CommandText);
								MessageBox.Show(exp.Message);
							}
							finally
							{
								oleDbConnection1.Close();
							}
						}
						else if(textBox21.Text.Equals("5"))
						{
							Comm.CommandText="select * from t_type_machine_clc where code='"+textBox1.Text+"'";
							oleDbDataAdapter8.SelectCommand=Comm;
							try
							{
								oleDbDataAdapter8.Fill(dataSet11);
							}
							catch(Exception exp)
							{

							}
							Comm.CommandText="insert into t_type_machine_clc (code,[c_maxi],vitesse) values ('"+textBox1.Text.Replace(",",".").ToUpper()+"',"+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+")";;
							try
							{
								Comm.ExecuteNonQuery();
								try
								{
									Transac.Commit();
									MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
						else
						{
							try
							{
								Transac.Commit();
								MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
							}
							catch(OleDbException excp)
							{
								Transac.Rollback();
								MessageBox.Show(excp.Message);
							}
							finally
							{
								oleDbConnection1.Close();
							}
							
						}
					}
				}
				else
				{
					MTGCComboBoxItem Fourn=(MTGCComboBoxItem)mtgcComboBox2.SelectedItem;
					MTGCComboBoxItem Famille=(MTGCComboBoxItem)mtgcComboBox1.SelectedItem;
					string datecrea=null;
					string prixcat=null;
					string majtarif=null;
					string delaigar=null;
					string forfaitdnr=null;
					string datemajdnr=null;
					string forfaittrans=null;
					string datemajtrans=null;
					string forfaitctl=null;
					string datemajctl=null;
					int code_famille=0;
					string code_fournisseur="";
					if(textBox15.TextLength>0)
						textBox15.Text=System.Convert.ToDecimal(textBox15.Text).ToString("0.00");
					if(textBox17.TextLength>0)
						textBox17.Text=System.Convert.ToDecimal(textBox17.Text).ToString("0.00");
					if(textBox18.TextLength>0)
						textBox18.Text=System.Convert.ToDecimal(textBox18.Text).ToString("0.00");
					if(textBox19.TextLength>0)
						textBox19.Text=System.Convert.ToDecimal(textBox19.Text).ToString("0.00");
					if(textBox20.TextLength>0)
						textBox20.Text=System.Convert.ToDecimal(textBox20.Text).ToString("0.00");
					if(textBox7.TextLength.Equals(0))
						textBox7.Text="0,00";
					if(txNetCommande.TextLength.Equals(0))
						txNetCommande.Text="0,00";
					if(textBox11.TextLength.Equals(0))
						textBox11.Text="0,00";
			
					datecrea=dateTimePicker1.Value.ToShortDateString();
					if(textBox3.Text.ToUpper().Length!=0)
						prixcat=textBox3.Text.Replace(",",".");
					if(dateTimePicker5.Checked.Equals(true))
						majtarif=dateTimePicker5.Value.ToShortDateString();
					else
						majtarif="01/01/1970";
					if(textBox6.Text.ToUpper().Length!=0)
						delaigar=System.Convert.ToInt32(textBox6.Text.ToUpper()).ToString();
					if(textBox7.Text.ToUpper().Length!=0)
						forfaitdnr=textBox7.Text.Replace(",",".");
					if(dateTimePicker2.Checked.Equals(true))
						datemajdnr=dateTimePicker2.Value.ToShortDateString();
					else
						datemajdnr="01/01/1970";
					if(txNetCommande.Text.ToUpper().Length!=0)
						forfaittrans=txNetCommande.Text.Replace(",",".");
					if(dateTimePicker3.Checked.Equals(true))
						datemajtrans=dateTimePicker3.Value.ToShortDateString();
					else
						datemajtrans="01/01/1970";
					if(textBox11.Text.ToUpper().Length!=0)
						forfaitctl=textBox11.Text.Replace(",",".");
					if(dateTimePicker4.Checked.Equals(true))
						datemajctl=dateTimePicker4.Value.ToShortDateString();
					else
						datemajctl="01/01/1970";
				
					textBox15.Text=textBox15.Text.Replace(",",".");
					textBox17.Text=textBox17.Text.Replace(",",".");
					textBox18.Text=textBox18.Text.Replace(",",".");
					textBox19.Text=textBox19.Text.Replace(",",".");
					textBox20.Text=textBox20.Text.Replace(",",".");
					try
					{
						oleDbConnection1.Open();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					Transac=oleDbConnection1.BeginTransaction();
					Comm.CommandText="update t_type_machine set [Date MAJ controle]='"+datemajctl+"', [code famille]="+Famille.Tag.ToString()+",[Forfait controle]="+forfaitctl+",[Date MAJ Transport]='"+datemajtrans+"',[Forfait Transport]="+forfaittrans+",[Date MAJ DNR]='"+datemajdnr+"',[forfait dnr]="+forfaitdnr+",[Delai garantie]="+delaigar+",[mise a jour tarif]='"+majtarif+"',[date creation]='"+datecrea+"', [prix catalogue]="+prixcat+", fournisseur='"+Fourn.Tag.ToString()+"' where code='"+textBox1.Text+"'";
					Comm.Connection=oleDbConnection1;
					Comm.Transaction=Transac;
					try
					{
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
					if(textBox21.Text.Equals("1"))
					{
						Comm.CommandText="select * from t_type_machine_dyn where code='"+textBox1.Text+"'";
						oleDbDataAdapter4.SelectCommand=Comm;
						oleDbDataAdapter4.Fill(dataSet11);
						if(dataSet11.Tables["t_type_machine_dyn"].Rows.Count.Equals(0))
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="insert into t_type_machine_dyn (code,type_iso,classe_iso,precision,c_mini,c_maxi) values ('"+textBox1.Text.Replace(",",".").ToUpper()+"','"+textBox13.Text.Replace(",",".")+"','"+textBox14.Text.Replace(",",".")+"',"+textBox16.Text.Replace(",",".")+","+textBox15.Text.Replace(",",".")+","+textBox17.Text.Replace(",",".")+")";
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
						}
						else
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="update t_type_machine_dyn set [iDiso]="+mtgcComboBox4.Text+",[c_mini]="+textBox15.Text.Replace(",",".")+", [c_maxi]="+textBox17.Text.Replace(",",".")+" where [code]='"+textBox1.Text+"'";
							Comm.Transaction=Transac;
							try
							{
								Comm.ExecuteNonQuery();
								try
								{
									Transac.Commit();
									MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
					}
					else if(textBox21.Text.Equals("2"))
					{
						Comm.CommandText="select * from t_type_machine_vis where code='"+textBox1.Text+"'";
						oleDbDataAdapter5.SelectCommand=Comm;
						try
						{
							oleDbDataAdapter5.Fill(dataSet11);
						}
						catch(Exception exp)
						{

						}
						if(dataSet11.Tables["t_type_machine_vis"].Rows.Count.Equals(0))
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="insert into t_type_machine_vis (code, c_mini,c_maxi,vitesse) values ('"+textBox1.Text.Replace(",",".").ToUpper()+"',"+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+","+textBox20.Text.Replace(",",".")+")";;
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
						}
						else
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="update t_type_machine_vis set c_mini="+textBox18.Text.Replace(",",".")+", c_maxi="+textBox19.Text.Replace(",",".")+" ,vitesse="+textBox20.Text.Replace(",",".")+" where code='"+textBox1.Text+"'";
							Comm.Transaction=Transac;
							try
							{
								Comm.ExecuteNonQuery();
								try
								{
									Transac.Commit();
									MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
					}
					else if(textBox21.Text.Equals("3"))
					{
						Comm.CommandText="select * from t_type_machine_meu where code='"+textBox1.Text+"'";
						oleDbDataAdapter6.SelectCommand=Comm;
						try
						{
							oleDbDataAdapter6.Fill(dataSet11);
						}
						catch(Exception exp)
						{

						}
						if(dataSet11.Tables["t_type_machine_meu"].Rows.Count.Equals(0))
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="insert into t_type_machine_meu (code,vitesse,puissance) values ('"+textBox1.Text.Replace(",",".").ToUpper()+"',"+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+")";
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
						}
						else
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="update t_type_machine_meu set vitesse="+textBox18.Text.Replace(",",".")+" ,puissance="+textBox19.Text.Replace(",",".")+" where code='"+textBox1.Text+"'";
							Comm.Transaction=Transac;
							try
							{
								Comm.ExecuteNonQuery();
								try
								{
									Transac.Commit();
									MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
					}
					else if(textBox21.Text.Equals("4"))
					{
						Comm.CommandText="select * from t_type_machine_per where code='"+textBox1.Text+"'";
						oleDbDataAdapter7.SelectCommand=Comm;
						try
						{
							oleDbDataAdapter7.Fill(dataSet11);
						}
						catch(Exception exp)
						{

						}
						if(dataSet11.Tables["t_type_machine_per"].Rows.Count.Equals(0))
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="insert into t_type_machine_per (code,vitesse,puissance) values ('"+textBox1.Text.Replace(",",".").ToUpper()+"',"+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+")";
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
						}
						else
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="update t_type_machine_per set vitesse="+textBox18.Text.Replace(",",".")+" ,puissance="+textBox19.Text.Replace(",",".")+" where code='"+textBox1.Text+"'";
							Comm.Transaction=Transac;
							try
							{
								Comm.ExecuteNonQuery();
								try
								{
									Transac.Commit();
									MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
					}
					else if(textBox21.Text.Equals("5"))
					{
						Comm.CommandText="select * from t_type_machine_clc where code='"+textBox1.Text+"'";
						oleDbDataAdapter8.SelectCommand=Comm;
						try
						{
							oleDbDataAdapter8.Fill(dataSet11);
						}
						catch(Exception exp)
						{

						}
						if(dataSet11.Tables["t_type_machine_clc"].Rows.Count.Equals(0))
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="insert into t_type_machine_clc (code,c_maxi,vitesse) values ('"+textBox1.Text.Replace(",",".").ToUpper()+"',"+textBox18.Text.Replace(",",".")+","+textBox19.Text.Replace(",",".")+")";
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
						}
						else
						{
							oleDbConnection1.Open();
							Transac=oleDbConnection1.BeginTransaction();
							Comm.CommandText="update t_type_machine_clc set c_maxi="+textBox18.Text.Replace(",",".")+" ,vitesse="+textBox19.Text.Replace(",",".")+" where code='"+textBox1.Text+"'";
							Comm.Transaction=Transac;
							try
							{
								Comm.ExecuteNonQuery();
								try
								{
									Transac.Commit();
									MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
					}
				}
				mtgcComboBox3.Items.Clear();
				dataSet11.Clear();
				OleDbCommand Comm1 = new OleDbCommand();
				oleDbConnection1.Close();
				oleDbConnection1.Open();
				Comm1.Connection=oleDbConnection1;
				Comm1.Transaction=oleDbConnection1.BeginTransaction();
				Comm1.CommandText="select T_type_machine.Code, T_famille_machine.Designation FROM t_type_machine,T_fournisseurs,T_famille_machine where T_type_machine.Fournisseur=T_fournisseurs.Code and T_type_machine.[Code famille]=T_famille_machine.Code order by 1 asc";
				oleDbDataAdapter1.SelectCommand=Comm1;
				try
				{
					oleDbDataAdapter1.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				finally
				{
					oleDbConnection1.Close();
				}
				mtgcComboBox3.SourceDataString=new string[]{"Code","","",""};
				mtgcComboBox3.SourceDataTable=dataSet11.Tables["t_type_machine"];

				dateTimePicker2.Enabled=false;
				dateTimePicker3.Enabled=false;
				dateTimePicker4.Enabled=false;
				dateTimePicker5.Enabled=false;
				Vider();
				HideCarac();
				mtgcComboBox1.SelectedIndex=0;
				mtgcComboBox2.SelectedIndex=0;
				mtgcComboBox3.SelectedIndex=0;
			}
			else
			{
				MessageBox.Show("Veuillez vérifier les champs obligatoires","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}


		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			DataSet ds = new DataSet();
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select * from t_type_machine";
			oleDbDataAdapter1.SelectCommand=Comm;
			oleDbDataAdapter1.Fill(ds);
			DataTable Table = ds.Tables["T_type_machine"];
			
			if(MessageBox.Show("Supprimer le type ?","Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
			{
				foreach (DataRow row in Table.Rows)
				{
					if(row["Code"].ToString().Equals(textBox1.Text.ToUpper()))
					{
						row.Delete();
						break;
					}
				}
			}
			oleDbConnection1.Open();
			Transac=oleDbConnection1.BeginTransaction();
			oleDbDeleteCommand1.Transaction=Transac;
			try
			{
				oleDbDataAdapter1.Update(ds);
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
			HideCarac();
			dateTimePicker1.Value=DateTime.Now;
			dateTimePicker2.Value=DateTime.Now;
			dateTimePicker3.Value=DateTime.Now;
			dateTimePicker4.Value=DateTime.Now;
			dateTimePicker2.Checked=false;
			dateTimePicker3.Checked=false;
			dateTimePicker4.Checked=false;
			Enable();
			save=false;
			this.Dispose();
		}


		private void HideCarac()
		{
			label22.Visible=false;
			label18.Visible=false;
			label19.Visible=false;
			label20.Visible=false;
			label21.Visible=false;
			panel1.Visible=false;
			textBox13.Visible=false;
			textBox14.Visible=false;
			textBox15.Visible=false;
			textBox16.Visible=false;
			textBox17.Visible=false;
			textBox20.Visible=false;
			label26.Visible=false;
			textBox18.Visible=false;
			textBox19.Visible=false;
			textBox20.Visible=false;
			label24.Visible=false;
			label25.Visible=false;
			label27.Visible=false;
			label23.Visible=false;
			label28.Visible=false;
			mtgcComboBox4.Visible=false;
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			string fam=mtgcComboBox1.Text;
			MTGCComboBoxItem item = (MTGCComboBoxItem)mtgcComboBox1.SelectedItem;
			if(mtgcComboBox1.SelectedIndex>0)
			{
				FamillesMachines WinFamilles = new FamillesMachines(Agence,item.Tag.ToString());
				WinFamilles.ShowDialog();
			}
			else
			{
				FamillesMachines WinFamilles = new FamillesMachines(Agence,"");
				WinFamilles.ShowDialog();
			}
			mtgcComboBox1.Items.Clear();
			Comm.CommandText="select code,designation from t_famille_machine order by designation";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_famille_machine");
				foreach(DataRow row in ds.Tables["T_famille_machine"].Rows)
				{
					MTGCComboBoxItem item2 = new MTGCComboBoxItem(row["designation"].ToString(),"","","");
					item2.Tag=row["Code"].ToString();
					mtgcComboBox1.Items.Add(item2);
				}
				
				mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
				mtgcComboBox1.SelectedIndex=0;
				ds.Tables["T_famille_machine"].Clear();

			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindStringExact(fam);

		}

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			string fourn=mtgcComboBox2.Text;
			if(mtgcComboBox2.SelectedIndex>0)
			{
				MTGCComboBoxItem select = (MTGCComboBoxItem)mtgcComboBox2.SelectedItem;
				SaisieFournisseurs WinFourn = new SaisieFournisseurs(Agence,select.Tag.ToString());
				WinFourn.ShowDialog();
			}
			else
			{
				SaisieFournisseurs WinFourn = new SaisieFournisseurs(Agence,true);
				WinFourn.ShowDialog();
			}
			
			mtgcComboBox2.Items.Clear();
			try
			{
				Comm.CommandText="SELECT Code,nom FROM t_fournisseurs ORDER BY nom ASC";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_fournisseurs");
				foreach(DataRow row in ds.Tables["t_fournisseurs"].Rows)
				{
					MTGCComboBoxItem item = new MTGCComboBoxItem(row["nom"].ToString(),"","","");
					item.Tag=row["Code"].ToString();
					mtgcComboBox2.Items.Add(item);
				}
				mtgcComboBox2.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
				mtgcComboBox2.SelectedIndex=0;
				ds.Tables["t_fournisseurs"].Clear();
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindStringExact(fourn);
		}

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox1.SelectedIndex>0&&mtgcComboBox1.Text.Length>0)
			{
				HideCarac();
				
				dataSet11.Tables["t_famille_machine"].Clear();
				OleDbCommand Comm = new OleDbCommand();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="select * from t_famille_machine where designation='"+mtgcComboBox1.Text.Replace("'","''")+"'";
				oleDbDataAdapter2.SelectCommand=Comm;
				try
				{
					oleDbDataAdapter2.Fill(dataSet11);
					textBox21.Text=dataSet11.Tables["t_famille_machine"].Rows[0]["Type"].ToString();
					label17.Text=dataSet11.Tables["t_famille_machine"].Rows[0]["Designation"].ToString();
					if(dataSet11.Tables["t_famille_machine"].Rows[0]["Type"].ToString().Equals("1"))
					{
						label28.Visible=true;
						mtgcComboBox4.Visible=true;
						mtgcComboBox4.SelectedIndex=0;
						label26.Visible=true;
						textBox13.Text="I";
						textBox13.Visible=true;
						textBox14.Text="A";
						textBox14.Visible=true;
						textBox15.Text="0,00";
						textBox15.Visible=true;
						textBox17.Text="0,00";
						textBox17.Visible=true;
						textBox16.Text="0,00";
						textBox16.Visible=true;
						label18.Text="Type ISO";
						label18.Visible=true;
						label19.Text="Classe ISO";
						label19.Visible=true;
						label20.Text="C. mini (nm)";
						label20.Visible=true;
						label21.Text="C. maxi (nm)";
						label21.Visible=true;
						label22.Text="Précision";
						label22.Visible=true;
						panel1.Visible=true;

					}
					else if(dataSet11.Tables["t_famille_machine"].Rows[0]["Type"].ToString().Equals("2"))
					{
						textBox18.Visible=true;
						textBox19.Visible=true;
						textBox20.Visible=true;
						label24.Visible=true;
						label25.Visible=true;
						label27.Visible=true;
						textBox18.Text="0,00";
						textBox19.Text="0,00";
						textBox20.Text="0,00";
						label24.Text="Couple mini (nm)";
						label25.Text="Couple maxi (nm)";
						label27.Text="Vitesse t/mn";
						panel1.Visible=true;
					}
					else if(dataSet11.Tables["t_famille_machine"].Rows[0]["Type"].ToString().Equals("3"))
					{
						textBox18.Visible=true;
						textBox19.Visible=true;
						label24.Visible=true;
						label25.Visible=true;
						textBox18.Text="0,00";
						textBox19.Text="0,00";
						label24.Text="Vitesse";
						label25.Text="Puissance";
						panel1.Visible=true;
					}
					else if(dataSet11.Tables["t_famille_machine"].Rows[0]["Type"].ToString().Equals("4"))
					{
						textBox18.Visible=true;
						textBox19.Visible=true;
						label24.Visible=true;
						label25.Visible=true;
						textBox18.Text="0,00";
						textBox19.Text="0,00";
						label24.Text="Vitesse";
						label25.Text="Puissance";
						panel1.Visible=true;
					}
					else if(dataSet11.Tables["t_famille_machine"].Rows[0]["Type"].ToString().Equals("5"))
					{

						textBox18.Visible=true;
						textBox19.Visible=true;
						label24.Visible=true;
						label25.Visible=true;
						textBox18.Text="0,00";
						textBox19.Text="0,00";
						label24.Text="C_maxi";
						label25.Text="Vitesse";
						panel1.Visible=true;
					}
					else if(dataSet11.Tables["t_famille_machine"].Rows[0]["Type"].ToString().Equals("6"))
					{
						label23.Visible=true;
						panel1.Visible=true;
					}
				}
				catch(Exception exp)
				{

				}
				
			}
		}

		private void mtgcComboBox3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(13))
			{
				HideCarac();
				textBox1.Text="";
				textBox3.Text="";
				textBox5.Text="0";
				textBox6.Text="90";
				textBox7.Text="";
				txNetCommande.Text="";
				textBox11.Text="";
				mtgcComboBox1.SelectedIndex=0;
				mtgcComboBox2.SelectedIndex=0;
				if(mtgcComboBox3.SelectedIndex>=0)
				{
					nouveau=false;
					btEnregistre.Enabled=true;
					btSupprime.Enabled=true;
					textBox1.Enabled=true;
					dateTimePicker1.Enabled=true;
					textBox3.Enabled=true;
					textBox5.Enabled=true;
					textBox6.Enabled=true;
					textBox7.Enabled=true;
					txNetCommande.Enabled=true;
					textBox11.Enabled=true;
					mtgcComboBox1.Enabled=true;
					mtgcComboBox2.Enabled=true;
					button1.Enabled=true;
					button2.Enabled=true;
					dataSet11.Tables["t_type_machine"].Clear();
					OleDbCommand Comm = new OleDbCommand();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select t_type_machine.fournisseur,t_type_machine.[date creation],t_type_machine.[prix catalogue],t_type_machine.[mise a jour tarif],t_type_machine.[nombre reparations],t_type_machine.[delai garantie],t_type_machine.[forfait dnr],t_type_machine.[date maj dnr],t_type_machine.[forfait transport],t_type_machine.[date maj transport],t_type_machine.[forfait controle],t_type_machine.[date maj controle],T_type_machine.Code, T_famille_machine.Designation, T_famille_machine.[Type] FROM t_type_machine,T_fournisseurs,T_famille_machine where T_type_machine.Fournisseur=T_fournisseurs.Code and T_type_machine.[Code famille]=T_famille_machine.Code and t_type_machine.code='"+mtgcComboBox3.Text+"'";
					oleDbDataAdapter1.SelectCommand=Comm;
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					if(dataSet11.Tables["t_type_machine"].Rows.Count>0)
					{
						Selrow = dataSet11.Tables["t_type_machine"].Rows[0];
						textBox1.Text=Selrow["Code"].ToString();
						try
						{
							dateTimePicker1.Value=System.Convert.ToDateTime(Selrow["Date creation"].ToString());
						}
						catch
						{
							dateTimePicker1.Checked=false;
							dateTimePicker1.Text="";
						}
						try
						{
							textBox3.Text=System.Convert.ToDecimal(Selrow["Prix catalogue"].ToString()).ToString("0.00");
						}
						catch
						{
							textBox3.Text="0,00";
						}
						if(Selrow["mise a jour tarif"].ToString().Length>0)
						{
							if(Selrow["mise a jour tarif"].ToString().Remove(10,9)!="01/01/1970"&&Selrow["date maj dnr"].ToString().Length>0)
							{
								dateTimePicker5.Value=System.Convert.ToDateTime(Selrow["mise a jour tarif"].ToString());
								dateTimePicker5.Checked=true;
							}
						}
						textBox5.Text=Selrow["nombre reparations"].ToString();
						if(textBox5.TextLength.Equals(0))
							textBox5.Text="0";
						textBox6.Text=Selrow["Delai garantie"].ToString();
						textBox7.Text=System.Convert.ToDecimal(Selrow["forfait DNR"].ToString()).ToString("0.00");
						if(Selrow["date maj dnr"].ToString().Length>0)
						{
							if(Selrow["date maj dnr"].ToString().Remove(10,9)!="01/01/1970"&&Selrow["date maj dnr"].ToString().Length>0)
							{
								dateTimePicker2.Value=System.Convert.ToDateTime(Selrow["date maj dnr"].ToString());
								dateTimePicker2.Checked=true;
							}
						}
						txNetCommande.Text=System.Convert.ToDecimal(Selrow["forfait transport"].ToString()).ToString("0.00");
						if(Selrow["date maj transport"].ToString().Length>0)
						{
							if(Selrow["date maj transport"].ToString().Remove(10,9)!="01/01/1970"&&Selrow["date maj transport"].ToString().Length>0)
							{
								dateTimePicker3.Value=System.Convert.ToDateTime(Selrow["date maj transport"].ToString());
								dateTimePicker3.Checked=true;
							}
						}
						textBox11.Text=System.Convert.ToDecimal(Selrow["forfait controle"].ToString()).ToString("0.00");
						Fourn=Selrow["Fournisseur"].ToString();
						if(Selrow["date maj controle"].ToString().Length>0)
						{
							if(Selrow["date maj controle"].ToString().Remove(10,9)!="01/01/1970"&&Selrow["date maj controle"].ToString().Length>0)
							{
								dateTimePicker4.Value=System.Convert.ToDateTime(Selrow["date maj controle"].ToString());
								dateTimePicker4.Checked=true;
							}
						}
						mtgcComboBox1.SelectedIndex=mtgcComboBox1.FindString(Selrow["designation"].ToString());
						dataSet11.Tables["t_fournisseurs"].Clear();
						Comm.Connection=oleDbConnection1;
						Comm.CommandText="select * from t_fournisseurs where code='"+Selrow["fournisseur"].ToString()+"'";
						oleDbDataAdapter3.SelectCommand=Comm;
						try
						{
							oleDbDataAdapter3.Fill(dataSet11);
						}
						catch(Exception exp)
						{
							MessageBox.Show(exp.Message);
						}
						mtgcComboBox2.SelectedIndex=mtgcComboBox2.FindString(dataSet11.Tables["t_fournisseurs"].Rows[0]["nom"].ToString());

						label17.Text=mtgcComboBox1.Text+" "+textBox1.Text;
						panel1.Visible=true;
						textBox21.Text=Selrow["Type"].ToString();
						if(Selrow["Type"].ToString().Equals("1"))
						{
							DataSet ds = new DataSet();
							Comm.Connection=oleDbConnection1;
							Comm.CommandText="SELECT T_type_machine_dyn.*, T_type_machine_dyn_iso.Type, T_type_machine_dyn_iso.classe, T_type_machine_dyn_iso.precision, T_type_machine_dyn.Code FROM T_type_machine_dyn_iso INNER JOIN T_type_machine_dyn ON T_type_machine_dyn_iso.ID = T_type_machine_dyn.idIso WHERE (((T_type_machine_dyn.Code)='"+textBox1.Text+"'))";
							oleDbDataAdapter4.SelectCommand=Comm;
							oleDbDataAdapter4.Fill(ds);
							DataTable Table = ds.Tables["T_type_machine_dyn"];
							if(ds.Tables["T_type_machine_dyn"].Rows.Count>0)
							{
								mtgcComboBox4.SelectedIndex=System.Convert.ToInt32(Table.Rows[0]["idIso"].ToString());
								label26.Visible=true;
								textBox13.Visible=true;
								textBox14.Visible=true;
								textBox15.Text=System.Convert.ToDecimal(Table.Rows[0]["C_mini"].ToString()).ToString("0.00");
								textBox15.Visible=true;
								textBox17.Text=System.Convert.ToDecimal(Table.Rows[0]["C_maxi"].ToString()).ToString("0.00");
								textBox17.Visible=true;
								textBox16.Visible=true;
								label18.Text="Type ISO";
								label18.Visible=true;
								label19.Text="Classe ISO";
								label19.Visible=true;
								label20.Text="C. mini (nm)";
								label20.Visible=true;
								label21.Text="C. maxi (nm)";
								label21.Visible=true;
								label22.Text="Précision";
								label22.Visible=true;
								label28.Visible=true;
								mtgcComboBox4.Visible=true;
							}
							else
							{
								label26.Visible=true;
								textBox13.Visible=true;
								textBox14.Visible=true;
								textBox15.Text="0,00";
								textBox15.Visible=true;
								textBox17.Text="0,00";
								textBox17.Visible=true;
								textBox16.Visible=true;
								label18.Text="Type ISO";
								label18.Visible=true;
								label19.Text="Classe ISO";
								label19.Visible=true;
								label20.Text="C. mini (nm)";
								label20.Visible=true;
								label21.Text="C. maxi (nm)";
								label21.Visible=true;
								label22.Text="Précision";
								label22.Visible=true;
								label28.Visible=true;
								mtgcComboBox4.Visible=true;
							}


						}
						else if(Selrow["Type"].ToString().Equals("2"))
						{
							DataSet ds = new DataSet();
							Comm.Connection=oleDbConnection1;
							Comm.CommandText="select * from t_type_machine_vis where code='"+textBox1.Text+"'";
							oleDbDataAdapter5.SelectCommand=Comm;
							try
							{
								oleDbDataAdapter5.Fill(ds);
							}
							catch(Exception exp)
							{

							}
							DataTable Table = ds.Tables["T_type_machine_vis"];
							if(Table.Rows.Count>0)
							{
								textBox18.Visible=true;
								textBox19.Visible=true;
								textBox20.Visible=true;
								label24.Visible=true;
								label25.Visible=true;
								label27.Visible=true;
								textBox18.Text=System.Convert.ToDecimal(Table.Rows[0]["C_mini"].ToString()).ToString("0.00");
								textBox19.Text=System.Convert.ToDecimal(Table.Rows[0]["C_maxi"].ToString()).ToString("0.00");
								textBox20.Text=System.Convert.ToDecimal(Table.Rows[0]["Vitesse"].ToString()).ToString("0.00");
								label24.Text="C. mini(Nm)";
								label25.Text="C. maxi(Nm)";
								label27.Text="Vitesse (t/mn)";
								panel1.Visible=true;
							}
							else
							{
								textBox18.Visible=true;
								textBox19.Visible=true;
								textBox20.Visible=true;
								label24.Visible=true;
								label25.Visible=true;
								label27.Visible=true;
								textBox18.Text="0,00";
								textBox19.Text="0,00";
								textBox20.Text="0,00";
								label24.Text="C. mini (Nm)";
								label25.Text="C. maxi (Nm)";
								label27.Text="Vitesse (t/mn)";
								panel1.Visible=true;
							}
						}
						else if(Selrow["Type"].ToString().Equals("3"))
						{
							DataSet ds = new DataSet();
							Comm.Connection=oleDbConnection1;
							Comm.CommandText="select * from t_type_machine_meu where code='"+textBox1.Text+"'";
							oleDbDataAdapter6.SelectCommand=Comm;
							try
							{
								oleDbDataAdapter6.Fill(ds);
							}
							catch(Exception exp)
							{

							}

							DataTable Table = ds.Tables["T_type_machine_meu"];
							if(Table.Rows.Count>0)
							{
								textBox18.Visible=true;
								textBox19.Visible=true;
								label24.Visible=true;
								label25.Visible=true;
								textBox18.Text=System.Convert.ToDecimal(Table.Rows[0]["Vitesse"].ToString()).ToString("0.00");
								textBox19.Text=System.Convert.ToDecimal(Table.Rows[0]["Puissance"].ToString()).ToString("0.00");
								label24.Text="Vitesse t/mn";
								label25.Text="Puissance Watt";
								panel1.Visible=true;
							}
							else
							{
								textBox18.Visible=true;
								textBox19.Visible=true;
								label24.Visible=true;
								label25.Visible=true;
								textBox18.Text="0,00";
								textBox19.Text="0,00";
								label24.Text="Vitesse t/mn";
								label25.Text="Puissance Watt";
								panel1.Visible=true;
							}
						}
						else if(Selrow["Type"].ToString().Equals("4"))
						{
							DataSet ds = new DataSet();
							Comm.Connection=oleDbConnection1;
							Comm.CommandText="select * from t_type_machine_per where code='"+textBox1.Text+"'";
							oleDbDataAdapter7.SelectCommand=Comm;
							try
							{
								oleDbDataAdapter7.Fill(ds);
							}
							catch(Exception exp)
							{

							}
							DataTable Table = ds.Tables["T_type_machine_per"];
							if(Table.Rows.Count>0)
							{
								textBox18.Visible=true;
								textBox19.Visible=true;
								label24.Visible=true;
								label25.Visible=true;
								textBox18.Text=System.Convert.ToDecimal(Table.Rows[0]["Vitesse"].ToString()).ToString("0.00");
								textBox19.Text=System.Convert.ToDecimal(Table.Rows[0]["Puissance"].ToString()).ToString("0.00");
								label24.Text="Vitesse t/mn";
								label25.Text="Puissance Watt";
								panel1.Visible=true;
							}
							else
							{
								textBox18.Visible=true;
								textBox19.Visible=true;
								label24.Visible=true;
								label25.Visible=true;
								textBox18.Text="0,00";
								textBox19.Text="0,00";
								label24.Text="Vitesse t/mn";
								label25.Text="Puissance Watt";
								panel1.Visible=true;
							}
						}
						else if(Selrow["Type"].ToString().Equals("5"))
						{
							DataSet ds = new DataSet();
							Comm.Connection=oleDbConnection1;
							Comm.CommandText="select * from t_type_machine_clc where code='"+textBox1.Text+"'";
							oleDbDataAdapter8.SelectCommand=Comm;
							try
							{
								oleDbDataAdapter8.Fill(ds);
							}
							catch(Exception exp)
							{

							}
							DataTable Table = ds.Tables["T_type_machine_clc"];
							if(Table.Rows.Count>0)
							{
								textBox18.Visible=true;
								textBox19.Visible=true;
								label24.Visible=true;
								label25.Visible=true;
								textBox18.Text=System.Convert.ToDecimal(Table.Rows[0]["C_maxi"].ToString()).ToString("0.00");
								textBox19.Text=System.Convert.ToDecimal(Table.Rows[0]["Vitesse"].ToString()).ToString("0.00");
								label24.Text="C_Maxi (mdaN)";
								label25.Text="Vitesse t/mn";
								panel1.Visible=true;
							}
							else
							{
								textBox18.Visible=true;
								textBox19.Visible=true;
								label24.Visible=true;
								label25.Visible=true;
								textBox18.Text="0,00";
								textBox19.Text="0,00";
								label24.Text="C_Maxi (mdaN)";
								label25.Text="Vitesse t/mn";
								panel1.Visible=true;
							}
						}
						else if(Selrow["Type"].ToString().Equals("6"))
						{
							label23.Visible=true;
							panel1.Visible=true;
						}
					}
					else
						MessageBox.Show("!!!");
						
				}
			}
		}

		private void mtgcComboBox4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			OleDbCommand Comm= new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select * from t_type_machine_dyn_iso where id="+mtgcComboBox4.Text;
			OleDbDataAdapter DataAD = new OleDbDataAdapter();
			dataSet11.Tables["t_type_machine_dyn_iso"].Clear();
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(dataSet11,"t_type_machine_dyn_iso");
			}
			catch(Exception exp)
			{

			}
			if(dataSet11.Tables["t_type_machine_dyn_iso"].Rows.Count>0)
			{
				textBox13.Text=dataSet11.Tables["t_type_machine_dyn_iso"].Rows[0]["Type"].ToString();
				textBox14.Text=dataSet11.Tables["t_type_machine_dyn_iso"].Rows[0]["Classe"].ToString();
				try
				{
					Decimal Precision = System.Convert.ToDecimal(dataSet11.Tables["t_type_machine_dyn_iso"].Rows[0]["Precision"].ToString())*100;
					textBox16.Text=Precision.ToString();
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				
			}
		}

		private void textBox18_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(textBox18.TextLength>0&&!save)
				{
					Decimal x = Decimal.Parse(textBox18.Text);
					errorProvider1.SetError(textBox18,"");
				}
			}
			catch(Exception exp)
			{
				errorProvider1.SetError(textBox18,"Nombre invalide");
			}
		}

		private void textBox19_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(textBox19.TextLength>0&&!save)
				{
					Decimal x = Decimal.Parse(textBox19.Text);
					errorProvider1.SetError(textBox19,"");
				}
			}
			catch(Exception exp)
			{
				errorProvider1.SetError(textBox19,"Nombre invalide");
			}
		}

		private void textBox20_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(textBox20.TextLength>0&&!save)
				{
					Decimal x = Decimal.Parse(textBox20.Text);
					errorProvider1.SetError(textBox20,"");
				}
			}
			catch(Exception exp)
			{
				errorProvider1.SetError(textBox20,"Nombre invalide");
			}
		}

		private void textBox15_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(textBox15.TextLength>0&&!save)
				{
					Decimal x = Decimal.Parse(textBox15.Text);
					errorProvider1.SetError(textBox15,"");
				}
			}
			catch(Exception exp)
			{
				errorProvider1.SetError(textBox15,"Nombre invalide");
			}
		}

		private void textBox17_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(textBox17.TextLength>0&&!save)
				{
					Decimal x = Decimal.Parse(textBox17.Text);
					errorProvider1.SetError(textBox17,"");
				}
			}
			catch(Exception exp)
			{
				errorProvider1.SetError(textBox17,"Nombre invalide");
			}
		}

		private void textBox15_Leave(object sender, System.EventArgs e)
		{
			textBox15.Text=System.Convert.ToDecimal(textBox15.Text).ToString("0.00");
		}

		private void textBox17_Leave(object sender, System.EventArgs e)
		{
			textBox17.Text=System.Convert.ToDecimal(textBox17.Text).ToString("0.00");
		}

		private void textBox18_Leave(object sender, System.EventArgs e)
		{
			textBox18.Text=textBox18.Text.Replace(".",",");
			textBox18.Text=System.Convert.ToDecimal(textBox18.Text).ToString("0.00");
		}

		private void textBox19_Leave(object sender, System.EventArgs e)
		{
			textBox19.Text=textBox19.Text.Replace(".",",");
			textBox19.Text=System.Convert.ToDecimal(textBox19.Text).ToString("0.00");
		}

		private void textBox20_Leave(object sender, System.EventArgs e)
		{
			textBox20.Text=textBox20.Text.Replace(".",",");
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

	}
}
