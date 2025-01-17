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
	/// Description résumée de ImpressionParc.
	/// </summary>
	public class ImpressionParc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private DataRow rowClient;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private int countRow;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
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
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private int Agence;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ImpressionParc(int Agence,DataRow RowClient)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			rowClient=RowClient;
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
			InitializeData();
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

		private void InitializeData()
		{
			comboBox1.SelectedIndex=0;
			comboBox2.SelectedIndex=0;
			if(comboBox1.Text.Equals("Tous")&&comboBox2.Text.Equals("Toutes"))
				oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom],t_parc_machine.[date dernier intervention], t_parc_machine.[date dernier controle], t_parc_machine.[date reforme] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
			else if(comboBox1.Text!="Tous"&&comboBox2.Text.Equals("Toutes"))
				oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom],t_parc_machine.[date dernier intervention], t_parc_machine.[date dernier controle], t_parc_machine.[date reforme] from t_parc_machine,t_type_machine,t_fournisseurs where t_type_machine.[Fournisseur]="+textBox3.Text+" and t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
			oleDbConnection1.Open();
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			oleDbConnection1.Close();
			foreach(DataRow row in dataSet11.Tables["t_parc_machine"].Rows)
			{
				if(comboBox1.Items.Count==0)
				{
					comboBox1.Items.Add(row["Nom"].ToString());
				}
				else
				{
					if(row["Nom"].ToString()!=comboBox1.Items[comboBox1.Items.Count-1].ToString())
						comboBox1.Items.Add(row["Nom"].ToString());
				}
			}
			oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom],t_parc_machine.[date dernier intervention], t_parc_machine.[date dernier controle], t_parc_machine.[date reforme] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
			oleDbConnection1.Open();
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			oleDbConnection1.Close();
			foreach(DataRow row in dataSet11.Tables["t_parc_machine"].Rows)
			{
				if(comboBox2.Items.Count==0)
				{
					comboBox2.Items.Add(row["type machine"].ToString());
				}
				else
				{
					if(row["type machine"].ToString()!=comboBox2.Items[comboBox2.Items.Count-1].ToString())
						comboBox2.Items.Add(row["type machine"].ToString());
				}
			}
			
			countRow=0;
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ImpressionParc));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
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
			this.button3 = new System.Windows.Forms.Button();
			this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// checkBox5
			// 
			this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox5.Location = new System.Drawing.Point(16, 112);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(160, 24);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "Interventions en retard";
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox4.Location = new System.Drawing.Point(16, 88);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(160, 24);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Contrôles en retard";
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(16, 64);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(238, 24);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Dates contrôles et interventions";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(16, 40);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(136, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Edition parc valorisé";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(16, 16);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Edition parc";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBox7);
			this.groupBox2.Controls.Add(this.checkBox6);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(8, 144);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(312, 88);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// checkBox7
			// 
			this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox7.Location = new System.Drawing.Point(155, 64);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(158, 15);
			this.checkBox7.TabIndex = 5;
			this.checkBox7.Text = "Interventions à effectuer";
			this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
			// 
			// checkBox6
			// 
			this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox6.Location = new System.Drawing.Point(15, 64);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(143, 15);
			this.checkBox6.TabIndex = 4;
			this.checkBox6.Text = "Contrôles à effectuer";
			this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(156, 32);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(67, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Jours, soit le :";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(16, 31);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(40, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "30";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Borne";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.checkBox9);
			this.groupBox3.Controls.Add(this.checkBox8);
			this.groupBox3.Controls.Add(this.comboBox1);
			this.groupBox3.Controls.Add(this.comboBox2);
			this.groupBox3.Location = new System.Drawing.Point(8, 224);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(312, 138);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(256, 55);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(36, 20);
			this.textBox4.TabIndex = 11;
			this.textBox4.Text = "";
			this.textBox4.Visible = false;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(257, 10);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(36, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 11);
			this.label4.TabIndex = 9;
			this.label4.Text = "Type de machine";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Fournisseur";
			// 
			// checkBox9
			// 
			this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox9.Location = new System.Drawing.Point(155, 114);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(158, 15);
			this.checkBox9.TabIndex = 7;
			this.checkBox9.Text = "Interventions à effectuer";
			this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
			// 
			// checkBox8
			// 
			this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox8.Location = new System.Drawing.Point(15, 114);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(140, 15);
			this.checkBox8.TabIndex = 6;
			this.checkBox8.Text = "Contrôles à effectuer";
			this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "Tous"});
			this.comboBox1.Location = new System.Drawing.Point(16, 31);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(278, 22);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.Items.AddRange(new object[] {
														   "Toutes"});
			this.comboBox2.Location = new System.Drawing.Point(16, 76);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(278, 22);
			this.comboBox2.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lavender;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(120, 384);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Imprimer";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(148, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
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
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_parc_machine WHERE ([Code machine Opindus] = ?) AND (Affectation = " +
				"? OR ? IS NULL AND Affectation IS NULL) AND ([Code Client] = ? OR ? IS NULL AND " +
				"[Code Client] IS NULL) AND ([Code Mabec] = ? OR ? IS NULL AND [Code Mabec] IS NU" +
				"LL) AND ([Code machine client] = ? OR ? IS NULL AND [Code machine client] IS NUL" +
				"L) AND ([Date dernier controle] = ? OR ? IS NULL AND [Date dernier controle] IS " +
				"NULL) AND ([Date dernier intervention] = ? OR ? IS NULL AND [Date dernier interv" +
				"ention] IS NULL) AND ([Date fin garantie] = ? OR ? IS NULL AND [Date fin garanti" +
				"e] IS NULL) AND ([Date mise en service] = ? OR ? IS NULL AND [Date mise en servi" +
				"ce] IS NULL) AND ([Date reforme] = ? OR ? IS NULL AND [Date reforme] IS NULL) AN" +
				"D ([Date refus] = ? OR ? IS NULL AND [Date refus] IS NULL) AND ([En parc] = ?) A" +
				"ND ([En reparation] = ?) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine]" +
				" IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND (" +
				"N_fichier_FVG = ? OR ? IS NULL AND N_fichier_FVG IS NULL) AND ([No controle] = ?" +
				" OR ? IS NULL AND [No controle] IS NULL) AND ([No dernier devis] = ? OR ? IS NUL" +
				"L AND [No dernier devis] IS NULL) AND ([No dernier devis refus] = ? OR ? IS NULL" +
				" AND [No dernier devis refus] IS NULL) AND ([No serie] = ? OR ? IS NULL AND [No " +
				"serie] IS NULL) AND ([N° Troncon] = ?) AND ([Prix Achat] = ? OR ? IS NULL AND [P" +
				"rix Achat] IS NULL) AND ([Prix remplacement] = ? OR ? IS NULL AND [Prix remplace" +
				"ment] IS NULL) AND (Site = ? OR ? IS NULL AND Site IS NULL) AND ([Total MO] = ? " +
				"OR ? IS NULL AND [Total MO] IS NULL) AND ([Total casse] = ? OR ? IS NULL AND [To" +
				"tal casse] IS NULL) AND ([Total controle] = ? OR ? IS NULL AND [Total controle] " +
				"IS NULL) AND ([Total general] = ? OR ? IS NULL AND [Total general] IS NULL) AND " +
				"([Total maintenance] = ? OR ? IS NULL AND [Total maintenance] IS NULL) AND ([Tot" +
				"al piece manque] = ? OR ? IS NULL AND [Total piece manque] IS NULL) AND ([Total " +
				"transport] = ? OR ? IS NULL AND [Total transport] IS NULL) AND ([Total usure] = " +
				"? OR ? IS NULL AND [Total usure] IS NULL) AND ([Type machine] = ? OR ? IS NULL A" +
				"ND [Type machine] IS NULL) AND (creation = ?) AND ([nombre semaine entre ctl] = " +
				"? OR ? IS NULL AND [nombre semaine entre ctl] IS NULL) AND ([nombre semaine entr" +
				"e inter] = ? OR ? IS NULL AND [nombre semaine entre inter] IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Affectation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Affectation1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Mabec1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_client1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_refus1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_En_parc", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "En parc", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "En reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_serie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Site", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Site", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_MO", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_MO1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_casse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_casse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_general", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total general", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_general1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total general", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_maintenance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_usure", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_usure1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_machine1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO T_parc_machine(Affectation, [Code Client], [Code Mabec], [Code machine client], [Code machine Opindus], creation, [Date dernier controle], [Date dernier intervention], [Date fin garantie], [Date mise en service], [Date reforme], [Date refus], [En parc], [En reparation], [Maxi machine], [Memo], [Mini machine], N_fichier_FVG, [N° Troncon], [No controle], [No dernier devis], [No dernier devis refus], [No serie], [nombre semaine entre ctl], [nombre semaine entre inter], [Prix Achat], [Prix remplacement], Site, [Total casse], [Total controle], [Total general], [Total maintenance], [Total MO], [Total piece manque], [Total transport], [Total usure], [Type machine]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Affectation", System.Data.OleDb.OleDbType.Integer, 0, "Affectation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Mabec"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Boolean, 2, "creation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier intervention"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, "Date fin garantie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, "Date mise en service"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Date reforme"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, "Date refus"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("En_parc", System.Data.OleDb.OleDbType.Boolean, 2, "En parc"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, "En reparation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, "N_fichier_FVG"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_controle", System.Data.OleDb.OleDbType.Integer, 0, "No controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis refus"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, "No serie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre ctl"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre inter"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, "Prix remplacement"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.Integer, 0, "Site"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_casse", System.Data.OleDb.OleDbType.Double, 0, "Total casse"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_controle", System.Data.OleDb.OleDbType.Double, 0, "Total controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_general", System.Data.OleDb.OleDbType.Double, 0, "Total general"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, "Total maintenance"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_MO", System.Data.OleDb.OleDbType.Double, 0, "Total MO"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, "Total piece manque"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_transport", System.Data.OleDb.OleDbType.Double, 0, "Total transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_usure", System.Data.OleDb.OleDbType.Double, 0, "Total usure"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, "Type machine"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT [Code Client],[Code machine Opindus],[Date dernier controle], [Date dernie" +
				"r intervention],[Date reforme],[Type machine] FROM T_parc_machine";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_parc_machine SET Affectation = ?, [Code Client] = ?, [Code Mabec] = ?, [" +
				"Code machine client] = ?, [Code machine Opindus] = ?, creation = ?, [Date dernie" +
				"r controle] = ?, [Date dernier intervention] = ?, [Date fin garantie] = ?, [Date" +
				" mise en service] = ?, [Date reforme] = ?, [Date refus] = ?, [En parc] = ?, [En " +
				"reparation] = ?, [Maxi machine] = ?, [Memo] = ?, [Mini machine] = ?, N_fichier_F" +
				"VG = ?, [N° Troncon] = ?, [No controle] = ?, [No dernier devis] = ?, [No dernier" +
				" devis refus] = ?, [No serie] = ?, [nombre semaine entre ctl] = ?, [nombre semai" +
				"ne entre inter] = ?, [Prix Achat] = ?, [Prix remplacement] = ?, Site = ?, [Total" +
				" casse] = ?, [Total controle] = ?, [Total general] = ?, [Total maintenance] = ?," +
				" [Total MO] = ?, [Total piece manque] = ?, [Total transport] = ?, [Total usure] " +
				"= ?, [Type machine] = ? WHERE ([Code machine Opindus] = ?) AND (Affectation = ? " +
				"OR ? IS NULL AND Affectation IS NULL) AND ([Code Client] = ? OR ? IS NULL AND [C" +
				"ode Client] IS NULL) AND ([Code Mabec] = ? OR ? IS NULL AND [Code Mabec] IS NULL" +
				") AND ([Code machine client] = ? OR ? IS NULL AND [Code machine client] IS NULL)" +
				" AND ([Date dernier controle] = ? OR ? IS NULL AND [Date dernier controle] IS NU" +
				"LL) AND ([Date dernier intervention] = ? OR ? IS NULL AND [Date dernier interven" +
				"tion] IS NULL) AND ([Date fin garantie] = ? OR ? IS NULL AND [Date fin garantie]" +
				" IS NULL) AND ([Date mise en service] = ? OR ? IS NULL AND [Date mise en service" +
				"] IS NULL) AND ([Date reforme] = ? OR ? IS NULL AND [Date reforme] IS NULL) AND " +
				"([Date refus] = ? OR ? IS NULL AND [Date refus] IS NULL) AND ([En parc] = ?) AND" +
				" ([En reparation] = ?) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] I" +
				"S NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND (N_" +
				"fichier_FVG = ? OR ? IS NULL AND N_fichier_FVG IS NULL) AND ([No controle] = ? O" +
				"R ? IS NULL AND [No controle] IS NULL) AND ([No dernier devis] = ? OR ? IS NULL " +
				"AND [No dernier devis] IS NULL) AND ([No dernier devis refus] = ? OR ? IS NULL A" +
				"ND [No dernier devis refus] IS NULL) AND ([No serie] = ? OR ? IS NULL AND [No se" +
				"rie] IS NULL) AND ([N° Troncon] = ?) AND ([Prix Achat] = ? OR ? IS NULL AND [Pri" +
				"x Achat] IS NULL) AND ([Prix remplacement] = ? OR ? IS NULL AND [Prix remplaceme" +
				"nt] IS NULL) AND (Site = ? OR ? IS NULL AND Site IS NULL) AND ([Total MO] = ? OR" +
				" ? IS NULL AND [Total MO] IS NULL) AND ([Total casse] = ? OR ? IS NULL AND [Tota" +
				"l casse] IS NULL) AND ([Total controle] = ? OR ? IS NULL AND [Total controle] IS" +
				" NULL) AND ([Total general] = ? OR ? IS NULL AND [Total general] IS NULL) AND ([" +
				"Total maintenance] = ? OR ? IS NULL AND [Total maintenance] IS NULL) AND ([Total" +
				" piece manque] = ? OR ? IS NULL AND [Total piece manque] IS NULL) AND ([Total tr" +
				"ansport] = ? OR ? IS NULL AND [Total transport] IS NULL) AND ([Total usure] = ? " +
				"OR ? IS NULL AND [Total usure] IS NULL) AND ([Type machine] = ? OR ? IS NULL AND" +
				" [Type machine] IS NULL) AND (creation = ?) AND ([nombre semaine entre ctl] = ? " +
				"OR ? IS NULL AND [nombre semaine entre ctl] IS NULL) AND ([nombre semaine entre " +
				"inter] = ? OR ? IS NULL AND [nombre semaine entre inter] IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Affectation", System.Data.OleDb.OleDbType.Integer, 0, "Affectation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Mabec"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Boolean, 2, "creation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier intervention"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, "Date fin garantie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, "Date mise en service"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Date reforme"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, "Date refus"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("En_parc", System.Data.OleDb.OleDbType.Boolean, 2, "En parc"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, "En reparation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, "N_fichier_FVG"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_controle", System.Data.OleDb.OleDbType.Integer, 0, "No controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis refus"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, "No serie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre ctl"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre inter"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, "Prix remplacement"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.Integer, 0, "Site"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_casse", System.Data.OleDb.OleDbType.Double, 0, "Total casse"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_controle", System.Data.OleDb.OleDbType.Double, 0, "Total controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_general", System.Data.OleDb.OleDbType.Double, 0, "Total general"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, "Total maintenance"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_MO", System.Data.OleDb.OleDbType.Double, 0, "Total MO"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, "Total piece manque"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_transport", System.Data.OleDb.OleDbType.Double, 0, "Total transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_usure", System.Data.OleDb.OleDbType.Double, 0, "Total usure"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, "Type machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Affectation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Affectation1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Mabec1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_client1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_refus1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_En_parc", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "En parc", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "En reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_serie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Site", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Site", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_MO", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_MO1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_casse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_casse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_general", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total general", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_general1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total general", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_maintenance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_usure", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_usure1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_machine1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null));
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
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM T_type_machine WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = @"INSERT INTO T_type_machine(Code, [Code famille], [Date creation], [Date MAJ controle], [Date MAJ DNR], [Date MAJ Transport], [Delai garantie], [Forfait controle], [Forfait DNR], [Forfait Transport], Fournisseur, [Maxi machine], [Mini machine], [Mise a jour tarif], [Nombre reparations], [Prix catalogue], Vitesse) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Code, Fournisseur FROM T_type_machine";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE T_type_machine SET Code = ?, [Code famille] = ?, [Date creation] = ?, [Date MAJ controle] = ?, [Date MAJ DNR] = ?, [Date MAJ Transport] = ?, [Delai garantie] = ?, [Forfait controle] = ?, [Forfait DNR] = ?, [Forfait Transport] = ?, Fournisseur = ?, [Maxi machine] = ?, [Mini machine] = ?, [Mise a jour tarif] = ?, [Nombre reparations] = ?, [Prix catalogue] = ?, Vitesse = ? WHERE (Code = ?) AND ([Code famille] = ? OR ? IS NULL AND [Code famille] IS NULL) AND ([Date MAJ DNR] = ? OR ? IS NULL AND [Date MAJ DNR] IS NULL) AND ([Date MAJ Transport] = ? OR ? IS NULL AND [Date MAJ Transport] IS NULL) AND ([Date MAJ controle] = ? OR ? IS NULL AND [Date MAJ controle] IS NULL) AND ([Date creation] = ? OR ? IS NULL AND [Date creation] IS NULL) AND ([Delai garantie] = ? OR ? IS NULL AND [Delai garantie] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait Transport] = ? OR ? IS NULL AND [Forfait Transport] IS NULL) AND ([Forfait controle] = ? OR ? IS NULL AND [Forfait controle] IS NULL) AND (Fournisseur = ? OR ? IS NULL AND Fournisseur IS NULL) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND ([Mise a jour tarif] = ? OR ? IS NULL AND [Mise a jour tarif] IS NULL) AND ([Nombre reparations] = ? OR ? IS NULL AND [Nombre reparations] IS NULL) AND ([Prix catalogue] = ? OR ? IS NULL AND [Prix catalogue] IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_famille", System.Data.OleDb.OleDbType.Integer, 0, "Code famille"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, "Date creation"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ controle"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ DNR"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, "Date MAJ Transport"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, "Delai garantie"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait controle"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait Transport"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, "Fournisseur"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, "Mise a jour tarif"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, "Nombre reparations"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, "Prix catalogue"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_famille1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code famille", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_DNR1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_Transport1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_MAJ_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date MAJ controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_creation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Delai_garantie1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Delai garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fournisseur1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fournisseur", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mise_a_jour_tarif1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mise a jour tarif", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nombre_reparations1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nombre reparations", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_catalogue1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix catalogue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null));
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
			this.oleDbSelectCommand3.CommandText = "SELECT Code, Nom FROM T_fournisseurs";
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
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lavender;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(8, 384);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Visualiser";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand4;
			this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand4;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand4;
			// 
			// oleDbDeleteCommand4
			// 
			this.oleDbDeleteCommand4.CommandText = "DELETE FROM T_devis_entete WHERE ([N° Devis] = ?) AND ([Accord Client] = ?) AND (" +
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
			this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Repare", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand4
			// 
			this.oleDbInsertCommand4.CommandText = @"INSERT INTO T_devis_entete([Accord Client], [Calcul Auto], [Cause atelier], [Cause client], [Code Client], [Code Materiel], [Commande generee], Comment, [Date], [Date Decision], [Date entree reelle], [Date Generation commande], [Date Reception pieces], [Date reparation], [Detail atelier], [Detail Client], Edite, edition_fax, Emplacement, [Forfait Controle], [Forfait DNR], [Forfait transport], [Imputation comptable], [Limite Devis], [Message Pieds], [n° Bl], [N° Commande generee], [N° Commande ouverte], [N° Devis], [N° Troncon], Niveau, [Ordre Travail], [Prix machine neuve], [Prix Reference], Reforme, Refus, Reparateur_D, Reparateur_R, Repare, [Seuil Client], [Seuil devis], [Total devis], [Total devis euro], [Total pieces], [Type devis], Valide) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = @"SELECT [Accord Client], [Calcul Auto], [Cause atelier], [Cause client], [Code Client], [Code Materiel], [Commande generee], Comment, [Date], [Date Decision], [Date entree reelle], [Date Generation commande], [Date Reception pieces], [Date reparation], [Detail atelier], [Detail Client], Edite, edition_fax, Emplacement, [Forfait Controle], [Forfait DNR], [Forfait transport], [Imputation comptable], [Limite Devis], [Message Pieds], [n° Bl], [N° Commande generee], [N° Commande ouverte], [N° Devis], [N° Troncon], Niveau, [Ordre Travail], [Prix machine neuve], [Prix Reference], Reforme, Refus, Reparateur_D, Reparateur_R, Repare, [Seuil Client], [Seuil devis], [Total devis], [Total devis euro], [Total pieces], [Type devis], Valide FROM T_devis_entete";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand4
			// 
			this.oleDbUpdateCommand4.CommandText = "UPDATE T_devis_entete SET [Accord Client] = ?, [Calcul Auto] = ?, [Cause atelier]" +
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
			this.oleDbUpdateCommand4.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Repare", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(272, 372);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 17;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// ImpressionParc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(330, 431);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "ImpressionParc";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Impression du parc machines";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
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
			if(!(checkBox1.Checked)&&!(checkBox2.Checked)&&!(checkBox3.Checked)&&!(checkBox4.Checked)&&!(checkBox5.Checked)&&!(checkBox6.Checked)&&!(checkBox7.Checked)&&!(checkBox8.Checked)&&!(checkBox9.Checked))
			{
				MessageBox.Show("Veuillez cocher une case.","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else
			{
				if(checkBox1.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom],t_parc_machine.[date dernier intervention], t_parc_machine.[date dernier controle], t_parc_machine.[date reforme] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox2.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=true;
					printDocument1.DefaultPageSettings.Margins.Bottom=10;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox3.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[date dernier intervention], t_parc_machine.[Date dernier controle], t_parc_machine.[Nombre semaine entre inter], t_parc_machine.[Nombre semaine entre ctl],t_parc_machine.[Date reforme] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox4.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier controle], t_parc_machine.[Nombre semaine entre ctl] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox5.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier intervention], t_parc_machine.[Nombre semaine entre inter] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox6.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier controle], t_parc_machine.[Nombre semaine entre ctl] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox7.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier intervention], t_parc_machine.[Nombre semaine entre inter] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox8.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier controle], t_parc_machine.[Nombre semaine entre ctl] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox9.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier intervention], t_parc_machine.[Nombre semaine entre inter] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				printDocument1.Print();
				countRow=0;
			}
		}

		private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			oleDbConnection1.Open();
			OleDbCommand somme = new OleDbCommand();
			somme.Connection=oleDbConnection1;
			if(checkBox1.Checked)
			{
				int ypos=300;
			
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,52), new Point(780,52));
				e.Graphics.DrawString("Parc machine", 
					new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 300, 80);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,150), new Point(780,150));
				e.Graphics.DrawString("Client :", 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 180);
				e.Graphics.DrawString(rowClient["Nom"].ToString(), 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 220);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,250), new Point(780,250));
				e.Graphics.DrawString("Type Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 50, 260);
				e.Graphics.DrawString("Code Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 150, 260); 
				e.Graphics.DrawString("Dernière intervention", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 350, 260); 
				e.Graphics.DrawString("Dernier contrôle", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 500, 260); 
				e.Graphics.DrawString("Date réforme", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 700, 260); 
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,285), new Point(780,285));
				string ancienfourn=null;
				string ancientype=null;
				bool debut=true;
				while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						ancienfourn=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Nom"].ToString();
						ancientype=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(ancienfourn!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=5;
						e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 350, ypos); 
						ypos+=20;
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=10;
					}
					if(ancientype!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString())
					{
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 50, ypos); 
					}
					e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 150, ypos); 
					if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Length>0)
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Remove(10,9)), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 350, ypos); 
					if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Length>0)
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Remove(10,9)), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 500, ypos); 
					if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date reforme"].ToString().Length>0)
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date reforme"].ToString().Remove(10,9)), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 700, ypos); 
					ypos+=30;
					countRow+=1;
				}
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
				ypos+=10;
				e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				if(countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
				}
			}
			else if(checkBox2.Checked==true)
			{
				int ypos=e.MarginBounds.Top+5;
			
				e.Graphics.DrawString("Cumul des dépenses par client", 
					new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
				ypos+=80;
				e.Graphics.DrawString("Client :", 
					new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString(rowClient["Nom"].ToString(), 
					new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+70, ypos);
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
				ypos+=5;
				e.Graphics.DrawString("Type Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
				e.Graphics.DrawString("Code Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+150, ypos); 
				e.Graphics.DrawString("Pièces", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+300, ypos); 
				e.Graphics.DrawString("M.O", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+450, ypos); 
				e.Graphics.DrawString("Contrôle", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+600, ypos); 
				e.Graphics.DrawString("Transport", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+750, ypos); 
				e.Graphics.DrawString("Total", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+900, ypos); 
				ypos+=30;
				string ancienfourn=null;
				string ancientype=null;
				bool debut=true;
				while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						ancienfourn=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Nom"].ToString();
						ancientype=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(ancienfourn!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=8;
						e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+450, ypos); 
						ypos+=18;
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
					}
					if(ancientype!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString())
					{
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos); 
					}
					e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+150, ypos); 
					somme.CommandText="select * from t_devis_entete where [Code materiel]='"+dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()+"'";
					oleDbDataAdapter4.SelectCommand=somme;
					oleDbDataAdapter4.Fill(dataSet11);
					decimal somPieces=0;
					decimal somMO=0;
					decimal somControle=0;
					decimal somTrans=0;
					decimal somTotal=0;
					foreach(DataRow row in dataSet11.Tables["T_devis_entete"].Rows)
					{
						if(row["Total pieces"].ToString().Length>0)
							somPieces+=System.Convert.ToDecimal(row["Total pieces"].ToString());
						if(row["Forfait DNR"].ToString().Length>0)
							somMO+=System.Convert.ToDecimal(row["Forfait DNR"].ToString());
						if(row["Forfait controle"].ToString().Length>0)
							somControle+=System.Convert.ToDecimal(row["Forfait controle"].ToString());
						if(row["Forfait transport"].ToString().Length>0)
							somTrans+=System.Convert.ToDecimal(row["Forfait transport"].ToString());
						if(row["Total Devis"].ToString().Length>0)
							somTotal+=System.Convert.ToDecimal(row["Total Devis"].ToString());
					}
					dataSet11.Tables["T_devis_entete"].Clear();
					e.Graphics.DrawString((somPieces.ToString("c")), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos); 
					e.Graphics.DrawString((somMO.ToString("c")), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+450, ypos); 
					e.Graphics.DrawString((somControle.ToString("c")), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+618, ypos); 
					e.Graphics.DrawString((somTrans.ToString("c")), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+767, ypos);
					e.Graphics.DrawString((somTotal.ToString("c")), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+895, ypos);
					ypos+=30;
					countRow+=1;
				}
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
				ypos+=10;
				e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				if(countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
				}
			}
			else if(checkBox3.Checked)
			{
				int ypos=300;
			
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,52), new Point(780,52));
				e.Graphics.DrawString("Parc machine", 
					new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 300, 80);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,150), new Point(780,150));
				e.Graphics.DrawString("Client :", 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 180);
				e.Graphics.DrawString(rowClient["Nom"].ToString(), 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 220);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,250), new Point(780,250));
				e.Graphics.DrawString("Type Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 50, 260);
				e.Graphics.DrawString("Code Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 150, 260); 
				e.Graphics.DrawString("Dernière intervention", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 250, 260); 
				e.Graphics.DrawString("Prochaine intervention", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 375, 260); 
				e.Graphics.DrawString("Dernier contrôle", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 505, 260);
				e.Graphics.DrawString("Prochain contrôle", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 605, 260); 
				e.Graphics.DrawString("Date réforme", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 710, 260); 
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,285), new Point(780,285));
				string ancienfourn=null;
				string ancientype=null;
				bool debut=true;
				while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						ancienfourn=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Nom"].ToString();
						ancientype=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(ancienfourn!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=5;
						e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 350, ypos); 
						ypos+=20;
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=10;
					}
					if(ancientype!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString())
					{
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 50, ypos); 
					}
					DateTime ProchainInter=DateTime.Now;
					DateTime ProchainCtl=DateTime.Now;
					bool affiche1=false;
					bool affiche2=false;
					if((dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre inter"].ToString().Length>0)&&(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Length>0))
					{
						affiche1=true;
						ProchainInter=System.Convert.ToDateTime(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString()).AddDays(System.Convert.ToInt32(dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre inter"].ToString()));
					}
					if((dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre ctl"].ToString().Length>0)&&(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Length>0))
					{
						affiche2=true;
						ProchainCtl=System.Convert.ToDateTime(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre ctl"].ToString()));
					}
					e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 165, ypos); 
					if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Length>0)
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Remove(10,9)), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 270, ypos); 
					if(affiche1)
					{
						e.Graphics.DrawString(ProchainInter.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 410, ypos); 
					}
					if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Length>0)
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Remove(10,9)), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 520, ypos); 
					if(affiche2)
					{
						e.Graphics.DrawString(ProchainCtl.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 625, ypos); 
					} 
					if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date reforme"].ToString().Length>0)
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date reforme"].ToString().Remove(10,9)), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 715, ypos); 
					ypos+=30;
					countRow+=1;
				}
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
				ypos+=10;
				e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				if(countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
				}
			}
			else if(checkBox4.Checked)
			{
				int ypos=300;
			
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,52), new Point(780,52));
				e.Graphics.DrawString("Parc machine", 
					new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 300, 80);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,150), new Point(780,150));
				e.Graphics.DrawString("Client :", 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 180);
				e.Graphics.DrawString(rowClient["Nom"].ToString(), 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 220);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,250), new Point(780,250));
				e.Graphics.DrawString("Type Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 50, 260);
				e.Graphics.DrawString("Code Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 150, 260); 
				e.Graphics.DrawString("Prochain contrôle", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 605, 260); 
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,285), new Point(780,285));
				string ancienfourn=null;
				string ancientype=null;
				bool debut=true;
				while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						ancienfourn=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Nom"].ToString();
						ancientype=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(ancienfourn!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=5;
						e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 350, ypos); 
						ypos+=20;
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=10;
					}
					if(ancientype!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString())
					{
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 50, ypos); 
					}
					DateTime ProchainCtl=DateTime.Now;
					bool affiche=false;
					if((dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre ctl"].ToString().Length>0)&&(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Length>0))
					{
						affiche=true;
						ProchainCtl=System.Convert.ToDateTime(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre ctl"].ToString()));
					}
					e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 165, ypos);  
					if(affiche)
					{
						if(DateTime.Now>ProchainCtl)
							e.Graphics.DrawString(ProchainCtl.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 625, ypos); 
					} 
					ypos+=30;
					countRow+=1;
				}
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
				ypos+=10;
				e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				if(countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
				}
			}
			else if(checkBox5.Checked)
			{
				int ypos=300;
			
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,52), new Point(780,52));
				e.Graphics.DrawString("Parc machine", 
					new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 300, 80);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,150), new Point(780,150));
				e.Graphics.DrawString("Client :", 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 180);
				e.Graphics.DrawString(rowClient["Nom"].ToString(), 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 220);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,250), new Point(780,250));
				e.Graphics.DrawString("Type Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 50, 260);
				e.Graphics.DrawString("Code Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 150, 260); 
				e.Graphics.DrawString("Prochaine intervention", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 605, 260); 
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,285), new Point(780,285));
				string ancienfourn=null;
				string ancientype=null;
				bool debut=true;
				while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						ancienfourn=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Nom"].ToString();
						ancientype=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(ancienfourn!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=5;
						e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 350, ypos); 
						ypos+=20;
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=10;
					}
					if(ancientype!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString())
					{
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 50, ypos); 
					}
					DateTime ProchaineInter=DateTime.Now;
					bool affiche=false;
					if((dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre inter"].ToString().Length>0)&&(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Length>0))
					{
						affiche=true;
						ProchaineInter=System.Convert.ToDateTime(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString()).AddDays(System.Convert.ToInt32(dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre inter"].ToString()));
					}
					e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 165, ypos);  
					if(affiche)
					{
						if(DateTime.Now>ProchaineInter)
							e.Graphics.DrawString(ProchaineInter.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 635, ypos); 
					} 
					ypos+=30;
					countRow+=1;
				}
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
				ypos+=10;
				e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				if(countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
				}
			}
			else if(checkBox6.Checked)
			{
				int ypos=300;
			
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,52), new Point(780,52));
				e.Graphics.DrawString("Parc machine", 
					new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 300, 80);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,150), new Point(780,150));
				e.Graphics.DrawString("Client :", 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 180);
				e.Graphics.DrawString(rowClient["Nom"].ToString(), 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 220);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,250), new Point(780,250));
				e.Graphics.DrawString("Type Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 50, 260);
				e.Graphics.DrawString("Code Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 150, 260); 
				e.Graphics.DrawString("Prochain contrôle", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 605, 260); 
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,285), new Point(780,285));
				string ancienfourn=null;
				string ancientype=null;
				bool debut=true;
				while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						ancienfourn=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Nom"].ToString();
						ancientype=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(ancienfourn!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=5;
						e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 350, ypos); 
						ypos+=20;
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=10;
					}
					if(ancientype!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString())
					{
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 50, ypos); 
					}
					DateTime ProchainCtl=DateTime.Now;
					bool affiche=false;
					if((dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre ctl"].ToString().Length>0)&&(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Length>0))
					{
						affiche=true;
						ProchainCtl=System.Convert.ToDateTime(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre ctl"].ToString()));
					}
					e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 165, ypos);  
					if(affiche)
					{
						if((ProchainCtl>=DateTime.Now)&&(ProchainCtl<DateTime.Now.AddDays(System.Convert.ToInt32(textBox1.Text))))
							e.Graphics.DrawString(ProchainCtl.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 625, ypos); 
					} 
					ypos+=30;
					countRow+=1;
				}
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
				ypos+=10;
				e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				if(countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
				}
			}
			else if(checkBox7.Checked)
			{
				int ypos=300;
			
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,52), new Point(780,52));
				e.Graphics.DrawString("Parc machine", 
					new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 300, 80);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,150), new Point(780,150));
				e.Graphics.DrawString("Client :", 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 180);
				e.Graphics.DrawString(rowClient["Nom"].ToString(), 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 220);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,250), new Point(780,250));
				e.Graphics.DrawString("Type Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 50, 260);
				e.Graphics.DrawString("Code Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 150, 260); 
				e.Graphics.DrawString("Prochaine intervention", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 605, 260); 
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,285), new Point(780,285));
				string ancienfourn=null;
				string ancientype=null;
				bool debut=true;
				while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						ancienfourn=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Nom"].ToString();
						ancientype=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(ancienfourn!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=5;
						e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 350, ypos); 
						ypos+=20;
						e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
						ypos+=10;
					}
					if(ancientype!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString())
					{
						e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 50, ypos); 
					}
					DateTime ProchaineInter=DateTime.Now;
					bool affiche=false;
					if((dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre inter"].ToString().Length>0)&&(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Length>0))
					{
						affiche=true;
						ProchaineInter=System.Convert.ToDateTime(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString()).AddDays(System.Convert.ToInt32(dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre inter"].ToString()));
					}
					e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 165, ypos);  
					if(affiche)
					{
						if((ProchaineInter>=DateTime.Now)&&(ProchaineInter<DateTime.Now.AddDays(System.Convert.ToInt32(textBox1.Text))))
							e.Graphics.DrawString(ProchaineInter.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 645, ypos); 
					} 
					ypos+=30;
					countRow+=1;
				}
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
				ypos+=10;
				e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				if(countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
				}
			}
			else if(checkBox8.Checked)
			{
				int ypos=300;
			
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,52), new Point(780,52));
				e.Graphics.DrawString("Parc machine", 
					new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 300, 80);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,150), new Point(780,150));
				e.Graphics.DrawString("Client :", 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 180);
				e.Graphics.DrawString(rowClient["Nom"].ToString(), 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 220);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,250), new Point(780,250));
				e.Graphics.DrawString("Type Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 50, 260);
				e.Graphics.DrawString("Code Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 150, 260); 
				e.Graphics.DrawString("Dernier contrôle", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 450, 260); 
				e.Graphics.DrawString("Prochain contrôle", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 605, 260); 
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,285), new Point(780,285));
				string ancienfourn=null;
				string ancientype=null;
				bool debut=true;
				while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
				{
					if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString().ToUpper().Equals(comboBox1.SelectedItem.ToString())||comboBox1.SelectedItem.ToString().ToUpper().Equals("TOUS"))
					{
						if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString().ToUpper().Equals(comboBox2.SelectedItem.ToString())||comboBox2.SelectedItem.ToString().ToUpper().Equals("TOUTES"))
						{
							if(debut)
								debut=false;
							else
							{
								ancienfourn=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Nom"].ToString();
								ancientype=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Type machine"].ToString();
							}
							if(ancienfourn!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString())
							{
								e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
								ypos+=5;
								e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString(), 
									new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 350, ypos); 
								ypos+=20;
								e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
								ypos+=10;
							}
							if(ancientype!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString())
							{
								e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 50, ypos); 
							}
							DateTime ProchainCont=DateTime.Now;
							bool affiche=false;
							if((dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre ctl"].ToString().Length>0)&&(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Length>0))
							{
								affiche=true;
								ProchainCont=System.Convert.ToDateTime(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString()).AddDays(System.Convert.ToInt32(dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre ctl"].ToString()));
							}
							e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 165, ypos);  
							if(affiche)
							{
								if(ProchainCont>=DateTime.Now)
									e.Graphics.DrawString(ProchainCont.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 630, ypos); 
							} 
							if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Length>0)
								e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier controle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 465, ypos); 
							ypos+=30;
						}
					}
					countRow+=1;
				}
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
				ypos+=10;
				e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				if(countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
				}
			}
			else if(checkBox9.Checked)
			{
				int ypos=300;
			
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,52), new Point(780,52));
				e.Graphics.DrawString("Parc machine", 
					new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 300, 80);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,150), new Point(780,150));
				e.Graphics.DrawString("Client :", 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 180);
				e.Graphics.DrawString(rowClient["Nom"].ToString(), 
					new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 220);
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,250), new Point(780,250));
				e.Graphics.DrawString("Type Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 50, 260);
				e.Graphics.DrawString("Code Machine", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 150, 260); 
				e.Graphics.DrawString("Derniere intervention", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 450, 260); 
				e.Graphics.DrawString("Prochaine intervention", 
					new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 605, 260); 
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,285), new Point(780,285));
				string ancienfourn=null;
				string ancientype=null;
				bool debut=true;
				while(ypos<e.MarginBounds.Height&&countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
				{
					if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString().ToUpper().Equals(comboBox1.SelectedItem.ToString())||comboBox1.SelectedItem.ToString().ToUpper().Equals("TOUS"))
					{
						if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString().ToUpper().Equals(comboBox2.SelectedItem.ToString())||comboBox2.SelectedItem.ToString().ToUpper().Equals("TOUTES"))
						{
							if(debut)
								debut=false;
							else
							{
								ancienfourn=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Nom"].ToString();
								ancientype=dataSet11.Tables["t_parc_machine"].Rows[countRow-1]["Type machine"].ToString();
							}
							if(ancienfourn!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString())
							{
								e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
								ypos+=5;
								e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Nom"].ToString(), 
									new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 350, ypos); 
								ypos+=20;
								e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
								ypos+=10;
							}
							if(ancientype!=dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString())
							{
								e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Type machine"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 50, ypos); 
							}
							DateTime ProchaineInter=DateTime.Now;
							bool affiche=false;
							if((dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre inter"].ToString().Length>0)&&(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Length>0))
							{
								affiche=true;
								ProchaineInter=System.Convert.ToDateTime(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString()).AddDays(System.Convert.ToInt32(dataSet11.Tables["t_parc_machine"].Rows[countRow]["nombre semaine entre inter"].ToString()));
							}
							e.Graphics.DrawString((dataSet11.Tables["t_parc_machine"].Rows[countRow]["Code machine opindus"].ToString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 165, ypos);  
							if(affiche)
							{
								if(ProchaineInter>=DateTime.Now)
									e.Graphics.DrawString(ProchaineInter.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, 630, ypos); 
							} 
							if(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Length>0)
								e.Graphics.DrawString(dataSet11.Tables["t_parc_machine"].Rows[countRow]["Date dernier intervention"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 465, ypos); 
							ypos+=30;
						}
					}
					countRow+=1;
				}
				ypos+=20;
				e.Graphics.DrawLine(new Pen(Color.Black, 3),new Point(50,ypos), new Point(780,ypos));
				ypos+=10;
				e.Graphics.DrawString((DateTime.Now.ToLongDateString()), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom-50);
				if(countRow<dataSet11.Tables["t_parc_machine"].Rows.Count)
					e.HasMorePages=true;
				else
				{
					e.HasMorePages=false;
					countRow=0;
				}
			}
			oleDbConnection1.Close();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked==true)
			{
				checkBox2.Checked=false;
				checkBox3.Checked=false;
				checkBox4.Checked=false;
				checkBox5.Checked=false;
				checkBox6.Checked=false;
				checkBox7.Checked=false;
				checkBox8.Checked=false;
				checkBox9.Checked=false;
			}
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox2.Checked==true)
			{
				checkBox1.Checked=false;
				checkBox3.Checked=false;
				checkBox4.Checked=false;
				checkBox5.Checked=false;
				checkBox6.Checked=false;
				checkBox7.Checked=false;
				checkBox8.Checked=false;
				checkBox9.Checked=false;
			}
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox3.Checked==true)
			{
				checkBox1.Checked=false;
				checkBox2.Checked=false;
				checkBox4.Checked=false;
				checkBox5.Checked=false;
				checkBox6.Checked=false;
				checkBox7.Checked=false;
				checkBox8.Checked=false;
				checkBox9.Checked=false;
			}
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox4.Checked==true)
			{
				checkBox1.Checked=false;
				checkBox2.Checked=false;
				checkBox3.Checked=false;
				checkBox5.Checked=false;
				checkBox6.Checked=false;
				checkBox7.Checked=false;
				checkBox8.Checked=false;
				checkBox9.Checked=false;
			}
		}

		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox5.Checked==true)
			{
				checkBox1.Checked=false;
				checkBox2.Checked=false;
				checkBox3.Checked=false;
				checkBox4.Checked=false;
				checkBox6.Checked=false;
				checkBox7.Checked=false;
				checkBox8.Checked=false;
				checkBox9.Checked=false;

			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if(!(checkBox1.Checked)&&!(checkBox2.Checked)&&!(checkBox3.Checked)&&!(checkBox4.Checked)&&!(checkBox5.Checked)&&!(checkBox6.Checked)&&!(checkBox7.Checked)&&!(checkBox8.Checked)&&!(checkBox9.Checked))
			{
				MessageBox.Show("Veuillez cocher une case.","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else
			{
				if(checkBox1.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom],t_parc_machine.[date dernier intervention], t_parc_machine.[date dernier controle], t_parc_machine.[date reforme] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox2.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=true;
					printDocument1.DefaultPageSettings.Margins.Bottom=10;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox3.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[date dernier intervention], t_parc_machine.[Date dernier controle], t_parc_machine.[Nombre semaine entre inter], t_parc_machine.[Nombre semaine entre ctl],t_parc_machine.[Date reforme] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox4.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier controle], t_parc_machine.[Nombre semaine entre ctl] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox5.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier intervention], t_parc_machine.[Nombre semaine entre inter] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox6.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier controle], t_parc_machine.[Nombre semaine entre ctl] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox7.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier intervention], t_parc_machine.[Nombre semaine entre inter] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox8.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier controle], t_parc_machine.[Nombre semaine entre ctl] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				else if(checkBox9.Checked)
				{
					oleDbSelectCommand1.CommandText="select t_parc_machine.[code machine opindus],t_parc_machine.[type machine],t_fournisseurs.[nom], t_parc_machine.[Date dernier intervention], t_parc_machine.[Nombre semaine entre inter] from t_parc_machine,t_type_machine,t_fournisseurs where t_parc_machine.[type machine]=t_type_machine.[code] and t_type_machine.[fournisseur]=t_fournisseurs.[Code] and t_parc_machine.[code client]="+rowClient["Ident"].ToString()+" order by 3,2,1 ASC";
					oleDbConnection1.Open();
					try
					{
						oleDbDataAdapter1.Fill(dataSet11);
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					printDocument1.DefaultPageSettings.Landscape=false;
					printDocument1.DefaultPageSettings.Margins.Bottom=50;
					printPreviewDialog1.SetBounds(0,0,800,600);
				}
				printPreviewDialog1.Document=printDocument1;
				printPreviewDialog1.ShowDialog();
				countRow=0;
			}
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(textBox1.Text.Length>0)
				textBox2.Text=DateTime.Now.AddDays(System.Convert.ToInt32(textBox1.Text)).ToShortDateString();
			else
				textBox2.Text=DateTime.Now.ToShortDateString();
		}

		private void checkBox9_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox9.Checked==true)
			{
				checkBox1.Checked=false;
				checkBox2.Checked=false;
				checkBox3.Checked=false;
				checkBox4.Checked=false;
				checkBox5.Checked=false;
				checkBox6.Checked=false;
				checkBox7.Checked=false;
				checkBox8.Checked=false;
			}
		}

		private void checkBox6_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox6.Checked==true)
			{
				checkBox1.Checked=false;
				checkBox2.Checked=false;
				checkBox3.Checked=false;
				checkBox4.Checked=false;
				checkBox5.Checked=false;
				checkBox7.Checked=false;
				checkBox8.Checked=false;
				checkBox9.Checked=false;
			}
		}

		private void checkBox7_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox7.Checked==true)
			{
				checkBox1.Checked=false;
				checkBox2.Checked=false;
				checkBox3.Checked=false;
				checkBox4.Checked=false;
				checkBox5.Checked=false;
				checkBox6.Checked=false;
				checkBox8.Checked=false;
				checkBox9.Checked=false;
			}
		}

		private void checkBox8_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox8.Checked==true)
			{
				checkBox1.Checked=false;
				checkBox2.Checked=false;
				checkBox3.Checked=false;
				checkBox4.Checked=false;
				checkBox5.Checked=false;
				checkBox6.Checked=false;
				checkBox7.Checked=false;
				checkBox9.Checked=false;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(comboBox1.Text!="Tous")
			{
				dataSet11.Tables["t_fournisseurs"].Clear();
				OleDbCommand Comm = new OleDbCommand();
				Comm.Connection=oleDbConnection1;
				Comm.CommandText="select * from t_fournisseurs where nom='"+comboBox1.Text+"'";
				oleDbDataAdapter3.SelectCommand=Comm;
				oleDbDataAdapter3.Fill(dataSet11);
				textBox3.Text=dataSet11.Tables["t_fournisseurs"].Rows[0]["Code"].ToString();
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
